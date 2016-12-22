Imports System.Data.SqlClient
Public Class PublisherAdd

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim sqlStr As String
        Dim result As Integer
        'Dim dateStr As String
        'dateStr = borrowTimePicker.Value
        'MsgBox(dateStr)
        sqlStr = String.Format("INSERT INTO PUBLISHER VALUES('{0}','{1}','{2}','{3}')", tbPublisher.Text.Trim, tbTelegram.Text.Trim, tbTel.Text.Trim, tbLocation.Text.Trim)
        Try
            con.Open()
            command = New SqlCommand(sqlStr, con)
            result = command.ExecuteNonQuery()
            If result = 1 Then
                MsgBox("登记出版社成功！")
            Else
                MsgBox("登记出版社失败！")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class