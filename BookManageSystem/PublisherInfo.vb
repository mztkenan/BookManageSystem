Imports System.Data.SqlClient
Public Class PublisherInfo

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            dbAdapter = New SqlDataAdapter("select * from publisher", con)
            dbSet = New DataSet()
            dbAdapter.Fill(dbSet, "Publisher")
            DataGridView1.DataSource = dbSet.Tables("Publisher")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(dbAdapter)
        Dim result As Integer
        Try
            result = dbAdapter.Update(dbSet, "Publisher")
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim selectCondition As String
        If rbName.Checked Then
            selectCondition = "publisherName"
        Else
            selectCondition = "publisherVague"
        End If
        searchFromDatabase(selectCondition)
    End Sub

    Sub searchFromDatabase(ByVal selectCondition)
        Try
            If selectCondition = "publisherName" Then
                dbAdapter = New SqlDataAdapter("select * from publisher where publisherName = '" & txbInput.Text & "'", con)
            Else
                dbAdapter = New SqlDataAdapter("select * from publisher where  publisherName like '%" & txbInput.Text & "%'", con)
            End If

            dbSet = New DataSet()
            dbAdapter.Fill(dbSet, "Publisher")
            DataGridView1.DataSource = dbSet.Tables("Publisher")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class