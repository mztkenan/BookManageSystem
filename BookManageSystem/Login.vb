Public Class Login



    Private Sub 新建ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        End
    End Sub

    Private Sub 打开ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            MsgBox("NO SUCH FILE!")

        End If

    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Form23.ShowDialog()
    End Sub
End Class
