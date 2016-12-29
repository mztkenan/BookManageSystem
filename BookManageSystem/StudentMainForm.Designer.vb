<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentMainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.预定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.预定图书ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询图书详情ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.其它ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.我的信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.主界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.预定ToolStripMenuItem, Me.查询ToolStripMenuItem, Me.其它ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(856, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '预定ToolStripMenuItem
        '
        Me.预定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.预定图书ToolStripMenuItem})
        Me.预定ToolStripMenuItem.Name = "预定ToolStripMenuItem"
        Me.预定ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.预定ToolStripMenuItem.Text = "预定"
        '
        '预定图书ToolStripMenuItem
        '
        Me.预定图书ToolStripMenuItem.Name = "预定图书ToolStripMenuItem"
        Me.预定图书ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.预定图书ToolStripMenuItem.Text = "预定图书"
        '
        '查询ToolStripMenuItem
        '
        Me.查询ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查询图书详情ToolStripMenuItem})
        Me.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem"
        Me.查询ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.查询ToolStripMenuItem.Text = "查询"
        '
        '查询图书详情ToolStripMenuItem
        '
        Me.查询图书详情ToolStripMenuItem.Name = "查询图书详情ToolStripMenuItem"
        Me.查询图书详情ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.查询图书详情ToolStripMenuItem.Text = "查询图书详情"
        '
        '其它ToolStripMenuItem
        '
        Me.其它ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.我的信息ToolStripMenuItem, Me.主界面ToolStripMenuItem, Me.关于ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.其它ToolStripMenuItem.Name = "其它ToolStripMenuItem"
        Me.其它ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.其它ToolStripMenuItem.Text = "其它"
        '
        '我的信息ToolStripMenuItem
        '
        Me.我的信息ToolStripMenuItem.Name = "我的信息ToolStripMenuItem"
        Me.我的信息ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.我的信息ToolStripMenuItem.Text = "我的信息"
        '
        '主界面ToolStripMenuItem
        '
        Me.主界面ToolStripMenuItem.Name = "主界面ToolStripMenuItem"
        Me.主界面ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.主界面ToolStripMenuItem.Text = "主界面"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'StudentMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BookManageSystem.My.Resources.Resources._97X58PICAY4_1024
        Me.ClientSize = New System.Drawing.Size(856, 611)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StudentMainForm"
        Me.Text = "学生"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 预定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 预定图书ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查询ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查询图书详情ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 其它ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 主界面ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 我的信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
