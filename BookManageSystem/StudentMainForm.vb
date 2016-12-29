Public Class StudentMainForm

    Private Sub 预定图书ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 预定图书ToolStripMenuItem.Click
        ReserveAdd.Show()
    End Sub

    Private Sub 查询图书详情ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 查询图书详情ToolStripMenuItem.Click
        StudentSearchBook.Show()
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub 主界面ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 主界面ToolStripMenuItem.Click
        Me.Close()
        Login.Show()
        userName = ""
        password = ""
        studentID = ""
        loginType = ""
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 我的信息ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 我的信息ToolStripMenuItem.Click
        PersonalInfo.Show()
    End Sub
End Class