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
            sqlStr = "select count(*) from " & usertype & " where loginId='" & UserText.Text.Trim & "' and loginPassword='" & PasswordText.Text.Trim & "'"
            Try
                con.Open()
                command = New SqlCommand(sqlStr, con)
                result = command.ExecuteScalar
                If result = 0 Then
                    MsgBox("账户或用户名错误！")
                ElseIf usertype = "ADMIN" Then
                    loginType = "administrator"
                    AdminMainForm.Show()
                    Me.Hide()
                Else
                    loginType = "student"
                    userName = UserText.Text.Trim
                    password = PasswordText.Text.Trim
                    loginTime = Date.Now
                    sqlStr = "select studentid from STUDENTUSER where loginId='" & UserText.Text.Trim & "'"
                    command.CommandText = sqlStr
                    studentID = command.ExecuteScalar
                    StudentMainForm.Show()
                    Me.Hide()
                End If

            Catch ex As Exception
                MsgBox("数据库连接失败")
                MsgBox(ex.Message)
            Finally
                con.Close()
                MsgBox(loginType)
            End Try
        End If
    End Sub

    Private Sub btnForget_Click(sender As System.Object, e As System.EventArgs) Handles btnForget.Click
        lbForget.Text = "admin admin"
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lbForget.Text = ""
        Timer1.Enabled = False
    End Sub
End Class
