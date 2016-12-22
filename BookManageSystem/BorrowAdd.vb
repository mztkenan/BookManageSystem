Imports System.Data.SqlClient
Public Class BorrowAdd

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfim_Click(sender As System.Object, e As System.EventArgs) Handles btnConfim.Click
        Dim sqlStr As String
        Dim result As Integer
        'Dim dateStr As String
        'dateStr = borrowTimePicker.Value
        'MsgBox(dateStr)
        sqlStr = String.Format("INSERT INTO BORROW(studentId,bookId,borrowDate) VALUES('{0}','{1}','{2}')", tbSno.Text.Trim, tbBookID.Text.Trim, borrowTimePicker.Value)
        Try
            con.Open()
            command = New SqlCommand(sqlStr, con)
            result = command.ExecuteNonQuery()
            If result = 1 Then
                MsgBox("借阅图书成功！")
            Else
                MsgBox("借阅图书失败！")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class