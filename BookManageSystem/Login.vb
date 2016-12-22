Imports System.Data.SqlClient
Public Class Login








    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        Dim usertype As String, sqlStr As String
        Dim result As Integer
        If TypeBox.Text = "管理员" Then
            usertype = "ADMIN"
        ElseIf TypeBox.Text = "学生" Then
            usertype = "STUDENTUSER"
        Else
            usertype = ""
        End If
        If usertype <> "" Then
            sqlStr = "select count(*) from " & usertype & " where loginId='" & UserText.Text & "' and loginPassword='" & PasswordText.Text & "'"
            MsgBox(sqlStr)
            Try
                con.Open()
                command = New SqlCommand(sqlStr, con)
                result = command.ExecuteScalar
                con.Close()
                If result = 0 Then
                    MsgBox("账户或用户名错误！")
                ElseIf usertype = "ADMIN" Then
                    AdminMainForm.Show()
                Else
                    StudentMainForm.Show()
                End If
                Me.Hide()
            Catch ex As Exception
                MsgBox("数据库连接失败")
                MsgBox(ex.Message)
                con.Close()
            End Try

        End If
    End Sub
End Class
