Imports System.Data.SqlClient
Public Class BorrowAdd

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfim_Click(sender As System.Object, e As System.EventArgs) Handles btnConfim.Click
        'Dim sqlStr As String
        Dim result As Integer
        Dim sno, bno, borrowDate As New SqlParameter
        command.CommandText = "PROC_BORROW_BOOK"
        command.CommandType = CommandType.StoredProcedure

        'Dim dateStr As String
        'dateStr = borrowTimePicker.Value
        'MsgBox(dateStr)
        'sqlStr = String.Format("INSERT INTO BORROW(studentId,bookId,borrowDate) VALUES('{0}','{1}','{2}')", tbSno.Text.Trim, tbBookID.Text.Trim, borrowTimePicker.Value)
        sno.ParameterName = "@SNO" : sno.Value = tbSno.Text.Trim
        bno.ParameterName = "@BNO" : bno.Value = tbBookID.Text.Trim
        borrowDate.ParameterName = "@BORROWDATE" : borrowDate.Value = borrowTimePicker.Value
        command.Connection = con
        command.Parameters.Add(sno)
        command.Parameters.Add(bno)
        command.Parameters.Add(borrowDate)
        Try
            con.Open()
            result = command.ExecuteNonQuery()
            If result = 2 Then
                MsgBox("借阅图书成功！")
            Else
                MsgBox("借阅图书失败！")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            command.Parameters.Clear()
        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class