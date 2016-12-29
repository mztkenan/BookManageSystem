<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMainForm
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
        Me.图书基本信息查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.学生基本信息管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.登记ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.出版社信息管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.录入ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询修改删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.图书预定管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.预定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询预定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.学生借阅管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅登记ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅归还ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.其它ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退回主界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.图书基本信息查询ToolStripMenuItem, Me.学生基本信息管理ToolStripMenuItem, Me.出版社信息管理ToolStripMenuItem, Me.图书预定管理ToolStripMenuItem, Me.学生借阅管理ToolStripMenuItem, Me.其它ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '图书基本信息查询ToolStripMenuItem
        '
        Me.图书基本信息查询ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.录入ToolStripMenuItem, Me.修改ToolStripMenuItem})
        Me.图书基本信息查询ToolStripMenuItem.Name = "图书基本信息查询ToolStripMenuItem"
        Me.图书基本信息查询ToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.图书基本信息查询ToolStripMenuItem.Text = "图书基本信息管理"
        '
        '录入ToolStripMenuItem
        '
        Me.录入ToolStripMenuItem.Name = "录入ToolStripMenuItem"
        Me.录入ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.录入ToolStripMenuItem.Text = "图书录入"
        '
        '修改ToolStripMenuItem
        '
        Me.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem"
        Me.修改ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.修改ToolStripMenuItem.Text = "图书删改"
        '
        '学生基本信息管理ToolStripMenuItem
        '
        Me.学生基本信息管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.登记ToolStripMenuItem, Me.查询ToolStripMenuItem})
        Me.学生基本信息管理ToolStripMenuItem.Name = "学生基本信息管理ToolStripMenuItem"
        Me.学生基本信息管理ToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.学生基本信息管理ToolStripMenuItem.Text = "学生基本信息管理"
        '
        '登记ToolStripMenuItem
        '
        Me.登记ToolStripMenuItem.Name = "登记ToolStripMenuItem"
        Me.登记ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.登记ToolStripMenuItem.Text = "学生登记"
        '
        '查询ToolStripMenuItem
        '
        Me.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem"
        Me.查询ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.查询ToolStripMenuItem.Text = "学生删改"
        '
        '出版社信息管理ToolStripMenuItem
        '
        Me.出版社信息管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.录入ToolStripMenuItem1, Me.查询修改删除ToolStripMenuItem})
        Me.出版社信息管理ToolStripMenuItem.Name = "出版社信息管理ToolStripMenuItem"
        Me.出版社信息管理ToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.出版社信息管理ToolStripMenuItem.Text = "出版社信息管理"
        '
        '录入ToolStripMenuItem1
        '
        Me.录入ToolStripMenuItem1.Name = "录入ToolStripMenuItem1"
        Me.录入ToolStripMenuItem1.Size = New System.Drawing.Size(153, 24)
        Me.录入ToolStripMenuItem1.Text = "出版社录入"
        '
        '查询修改删除ToolStripMenuItem
        '
        Me.查询修改删除ToolStripMenuItem.Name = "查询修改删除ToolStripMenuItem"
        Me.查询修改删除ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.查询修改删除ToolStripMenuItem.Text = "出版社删改"
        '
        '图书预定管理ToolStripMenuItem
        '
        Me.图书预定管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.预定ToolStripMenuItem, Me.查询预定ToolStripMenuItem})
        Me.图书预定管理ToolStripMenuItem.Name = "图书预定管理ToolStripMenuItem"
        Me.图书预定管理ToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.图书预定管理ToolStripMenuItem.Text = "图书预定管理"
        '
        '预定ToolStripMenuItem
        '
        Me.预定ToolStripMenuItem.Name = "预定ToolStripMenuItem"
        Me.预定ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.预定ToolStripMenuItem.Text = "预定登记"
        '
        '查询预定ToolStripMenuItem
        '
        Me.查询预定ToolStripMenuItem.Name = "查询预定ToolStripMenuItem"
        Me.查询预定ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.查询预定ToolStripMenuItem.Text = "预定删改"
        '
        '学生借阅管理ToolStripMenuItem
        '
        Me.学生借阅管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.借阅登记ToolStripMenuItem, Me.借阅查询ToolStripMenuItem, Me.借阅归还ToolStripMenuItem})
        Me.学生借阅管理ToolStripMenuItem.Name = "学生借阅管理ToolStripMenuItem"
        Me.学生借阅管理ToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.学生借阅管理ToolStripMenuItem.Text = "学生借阅管理"
        '
        '借阅登记ToolStripMenuItem
        '
        Me.借阅登记ToolStripMenuItem.Name = "借阅登记ToolStripMenuItem"
        Me.借阅登记ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.借阅登记ToolStripMenuItem.Text = "借阅登记"
        '
        '借阅查询ToolStripMenuItem
        '
        Me.借阅查询ToolStripMenuItem.Name = "借阅查询ToolStripMenuItem"
        Me.借阅查询ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.借阅查询ToolStripMenuItem.Text = "借阅查询"
        '
        '借阅归还ToolStripMenuItem
        '
        Me.借阅归还ToolStripMenuItem.Name = "借阅归还ToolStripMenuItem"
        Me.借阅归还ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.借阅归还ToolStripMenuItem.Text = "借阅归还"
        '
        '其它ToolStripMenuItem
        '
        Me.其它ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于ToolStripMenuItem, Me.退回主界面ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.其它ToolStripMenuItem.Name = "其它ToolStripMenuItem"
        Me.其它ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.其它ToolStripMenuItem.Text = "其它"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        '退回主界面ToolStripMenuItem
        '
        Me.退回主界面ToolStripMenuItem.Name = "退回主界面ToolStripMenuItem"
        Me.退回主界面ToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.退回主界面ToolStripMenuItem.Text = "主界面"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'AdminMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BookManageSystem.My.Resources.Resources._49R58PICeVU_1024
        Me.ClientSize = New System.Drawing.Size(859, 652)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminMainForm"
        Me.Text = "管理员"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 图书基本信息查询ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 录入ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 修改ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 学生基本信息管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 登记ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查询ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 出版社信息管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 图书预定管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 学生借阅管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 录入ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查询修改删除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 预定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查询预定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 借阅登记ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 借阅查询ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 借阅归还ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 其它ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退回主界面ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
