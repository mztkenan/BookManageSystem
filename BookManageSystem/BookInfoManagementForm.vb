Imports System.Data.SqlClient
Public Class BookInfoManagementForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim selectCondition As String
        If rdBookId.Checked Then
            selectCondition = "bookId"
        ElseIf rdBookName.Checked Then
            selectCondition = "bookName"
        ElseIf rdAuthor.Checked Then
            selectCondition = "author"
        Else
            selectCondition = "publisherName"
        End If
        searchFromDatabase(selectCondition)
    End Sub


    Sub searchFromDatabase(ByVal selectCondition)
        Try
            If cbHasStorage.Checked Then
                dbAdapter = New SqlDataAdapter("select * from book where " & selectCondition & "= '" & txbInput.Text & "' and quantity>0", con)
            Else
                dbAdapter = New SqlDataAdapter("select * from book where " & selectCondition & "= '" & txbInput.Text & "'", con)
            End If

            dbSet = New DataSet()
            dbAdapter.Fill(dbSet, "Book")
            DataGridView1.DataSource = dbSet.Tables("Book")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            If cbHasStorage.Checked Then
                dbAdapter = New SqlDataAdapter("select * from book where quantity>0", con)
            Else
                dbAdapter = New SqlDataAdapter("select * from book", con)
            End If

            dbSet = New DataSet()
            dbAdapter.Fill(dbSet, "Book")
            DataGridView1.DataSource = dbSet.Tables("Book")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(dbAdapter)
        Dim result As Integer
        Try
            result = dbAdapter.Update(dbSet, "Book")
            If (result <> 0) Then
                lbMessage.Text = "保存成功！"
                Timer1.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lbMessage.Text = ""
        Timer1.Enabled = False
    End Sub
End Class