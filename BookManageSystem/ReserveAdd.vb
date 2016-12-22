Imports System.Data.SqlClient
Public Class ReserveAdd

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfim_Click(sender As System.Object, e As System.EventArgs) Handles btnConfim.Click
        Dim sqlStr As String
        Dim result As Integer
        'Dim dateStr As String
        'dateStr = borrowTimePicker.Value
        'MsgBox(dateStr)
        sqlStr = String.Format("INSERT INTO RESERVE VALUES('{0}','{1}','{2}','{3}')", tbSno.Text.Trim, tbBookId.Text.Trim, DateTimePicker1.Value, tbQty.Text.Trim)
        Try
            con.Open()
            command = New SqlCommand(sqlStr, con)
            result = command.ExecuteNonQuery()
            If result = 1 Then
                MsgBox("预约成功！")
            Else
                MsgBox("预约失败！")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub ReserveAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = Now.Date
    End Sub
End Class