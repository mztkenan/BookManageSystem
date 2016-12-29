Imports System.Data.SqlClient
Public Class BookAdd

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfim_Click(sender As System.Object, e As System.EventArgs) Handles btnConfim.Click
        Dim sqlStr As String
        Dim result As Integer
        sqlStr = String.Format("INSERT INTO BOOK VALUES('{0}','{1}','{2}','{3}',{4},'{5}')", tbBookID.Text.Trim, tbBookName.Text.Trim, tbAuthor.Text.Trim, tbPublisher.Text.Trim, tbQuantity.Text.Trim, tbLocation.Text.Trim)
        Try
            con.Open()
            command = New SqlCommand(sqlStr, con)
            result = command.ExecuteNonQuery()
            If result = 1 Then
                MsgBox("添加图书成功！")
            Else
                MsgBox("添加图书失败！")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class