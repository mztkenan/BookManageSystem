Imports System.Data.SqlClient
Public Class StudentAdd

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfim_Click(sender As System.Object, e As System.EventArgs) Handles btnConfim.Click
        Dim sqlStr As String
        Dim result As Integer
        sqlStr = String.Format("INSERT INTO STUDENT VALUES('{0}','{1}','{2}','{3}')", tbSno.Text.Trim, tbSname.Text.Trim, tbDepart.Text.Trim, tbAge.Text.Trim)
        Try
            con.Open()
            command = New SqlCommand(sqlStr, con)
            result = command.ExecuteNonQuery()
            If result = 1 Then
                MsgBox("添加学生成功！")
            Else
                MsgBox("添加学生失败！")
            End If

            sqlStr = String.Format("INSERT INTO STUDENTUSER VALUES('{0}','{1}','{2}')", tbUser.Text.Trim, tbPassword.Text.Trim, tbSno.Text.Trim)
            command.CommandText = sqlStr
            result = command.ExecuteNonQuery
            If result = 1 Then
                MsgBox("添加学生账户成功！")
            Else
                MsgBox("添加学生账户失败！")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        
    End Sub
End Class