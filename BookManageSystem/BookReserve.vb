Imports System.Data.SqlClient
Public Class BookReserve

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim selectCondition As String
        If rbSno.Checked Then
            selectCondition = "studentId"
        ElseIf rbBookId.Checked Then
            selectCondition = "bookId"
        Else
            selectCondition = "reserveTime"
        End If
        searchFromDatabase(selectCondition)
    End Sub
    Sub searchFromDatabase(ByVal selectCondition)
        Try
            dbAdapter = New SqlDataAdapter("select * from Reserve where " & selectCondition & "= '" & txbInput.Text & "'", con)
            dbSet = New DataSet()
            dbAdapter.Fill(dbSet, "Reserve")
            DataGridView1.DataSource = dbSet.Tables("Reserve")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            dbAdapter = New SqlDataAdapter("select * from Reserve", con)
            dbSet = New DataSet()
            dbAdapter.Fill(dbSet, "Reserve")
            DataGridView1.DataSource = dbSet.Tables("Reserve")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(dbAdapter)
        Dim result As Integer
        Try
            result = dbAdapter.Update(dbSet, "Reserve")
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