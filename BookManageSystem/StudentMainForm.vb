Public Class StudentMainForm

    Private Sub 预定图书ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 预定图书ToolStripMenuItem.Click
        ReserveAdd.ShowDialog()
    End Sub

    Private Sub 查询图书详情ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 查询图书详情ToolStripMenuItem.Click
        StudentSearchBook.ShowDialog()
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub 主界面ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 主界面ToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub
End Class