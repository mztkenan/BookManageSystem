﻿Public Class AdminMainForm

    Private Sub 图书基本信息查询ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 图书基本信息查询ToolStripMenuItem.Click

    End Sub

    Private Sub 登记ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 登记ToolStripMenuItem.Click
        StudentAdd.Show()
    End Sub

    Private Sub 录入ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 录入ToolStripMenuItem.Click
        BookAdd.Show()
    End Sub

    Private Sub 录入ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles 录入ToolStripMenuItem1.Click
        PublisherAdd.Show()
    End Sub

    Private Sub 预定ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 预定ToolStripMenuItem.Click
        ReserveAdd.Show()
    End Sub

    Private Sub 借阅登记ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 借阅登记ToolStripMenuItem.Click
        BorrowAdd.Show()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 退回主界面ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 退回主界面ToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub 修改ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 修改ToolStripMenuItem.Click
        BookInfoManagementForm.Show()
    End Sub

    Private Sub 查询ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 查询ToolStripMenuItem.Click
        StudentInfoManagementForm.Show()
    End Sub

    Private Sub 查询修改删除ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 查询修改删除ToolStripMenuItem.Click
        PublisherInfo.Show()
    End Sub

    Private Sub 查询预定ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 查询预定ToolStripMenuItem.Click
        BookReserve.Show()
    End Sub

    Private Sub 借阅查询ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 借阅查询ToolStripMenuItem.Click
        BookBorrowInfo.Show()
    End Sub

    Private Sub 借阅归还ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 借阅归还ToolStripMenuItem.Click
        ReturnBook.Show()
    End Sub
End Class