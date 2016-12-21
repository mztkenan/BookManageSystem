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
        Me.学生基本信息管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.出版社信息管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.图书预定管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.学生借阅管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.登记ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.录入ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询修改删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.预定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询预定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅登记ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅归还ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.图书基本信息查询ToolStripMenuItem, Me.学生基本信息管理ToolStripMenuItem, Me.出版社信息管理ToolStripMenuItem, Me.图书预定管理ToolStripMenuItem, Me.学生借阅管理ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '图书基本信息查询ToolStripMenuItem
        '
        Me.图书基本信息查询ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.录入ToolStripMenuItem, Me.修改ToolStripMenuItem})
        Me.图书基本信息查询ToolStripMenuItem.Name = "图书基本信息查询ToolStripMenuItem"
        Me.图书基本信息查询ToolStripMenuItem.Size = New System.Drawing.Size(116, 21)
        Me.图书基本信息查询ToolStripMenuItem.Text = "图书基本信息管理"
        '
        '学生基本信息管理ToolStripMenuItem
        '
        Me.学生基本信息管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.登记ToolStripMenuItem, Me.查询ToolStripMenuItem})
        Me.学生基本信息管理ToolStripMenuItem.Name = "学生基本信息管理ToolStripMenuItem"
        Me.学生基本信息管理ToolStripMenuItem.Size = New System.Drawing.Size(116, 21)
        Me.学生基本信息管理ToolStripMenuItem.Text = "学生基本信息管理"
        '
        '出版社信息管理ToolStripMenuItem
        '
        Me.出版社信息管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.录入ToolStripMenuItem1, Me.查询修改删除ToolStripMenuItem})
        Me.出版社信息管理ToolStripMenuItem.Name = "出版社信息管理ToolStripMenuItem"
        Me.出版社信息管理ToolStripMenuItem.Size = New System.Drawing.Size(104, 21)
        Me.出版社信息管理ToolStripMenuItem.Text = "出版社信息管理"
        '
        '图书预定管理ToolStripMenuItem
        '
        Me.图书预定管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.预定ToolStripMenuItem, Me.查询预定ToolStripMenuItem})
        Me.图书预定管理ToolStripMenuItem.Name = "图书预定管理ToolStripMenuItem"
        Me.图书预定管理ToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.图书预定管理ToolStripMenuItem.Text = "图书预定管理"
        '
        '学生借阅管理ToolStripMenuItem
        '
        Me.学生借阅管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.借阅登记ToolStripMenuItem, Me.借阅查询ToolStripMenuItem, Me.借阅归还ToolStripMenuItem})
        Me.学生借阅管理ToolStripMenuItem.Name = "学生借阅管理ToolStripMenuItem"
        Me.学生借阅管理ToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.学生借阅管理ToolStripMenuItem.Text = "学生借阅管理"
        '
        '录入ToolStripMenuItem
        '
        Me.录入ToolStripMenuItem.Name = "录入ToolStripMenuItem"
        Me.录入ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.录入ToolStripMenuItem.Text = "图书录入"
        '
        '修改ToolStripMenuItem
        '
        Me.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem"
        Me.修改ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.修改ToolStripMenuItem.Text = "图书删改"
        '
        '登记ToolStripMenuItem
        '
        Me.登记ToolStripMenuItem.Name = "登记ToolStripMenuItem"
        Me.登记ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.登记ToolStripMenuItem.Text = "学生登记"
        '
        '查询ToolStripMenuItem
        '
        Me.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem"
        Me.查询ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.查询ToolStripMenuItem.Text = "学生删改"
        '
        '录入ToolStripMenuItem1
        '
        Me.录入ToolStripMenuItem1.Name = "录入ToolStripMenuItem1"
        Me.录入ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.录入ToolStripMenuItem1.Text = "出版社录入"
        '
        '查询修改删除ToolStripMenuItem
        '
        Me.查询修改删除ToolStripMenuItem.Name = "查询修改删除ToolStripMenuItem"
        Me.查询修改删除ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.查询修改删除ToolStripMenuItem.Text = "出版社删改"
        '
        '预定ToolStripMenuItem
        '
        Me.预定ToolStripMenuItem.Name = "预定ToolStripMenuItem"
        Me.预定ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.预定ToolStripMenuItem.Text = "预定登记"
        '
        '查询预定ToolStripMenuItem
        '
        Me.查询预定ToolStripMenuItem.Name = "查询预定ToolStripMenuItem"
        Me.查询预定ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.查询预定ToolStripMenuItem.Text = "预定删改"
        '
        '借阅登记ToolStripMenuItem
        '
        Me.借阅登记ToolStripMenuItem.Name = "借阅登记ToolStripMenuItem"
        Me.借阅登记ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.借阅登记ToolStripMenuItem.Text = "借阅登记"
        '
        '借阅查询ToolStripMenuItem
        '
        Me.借阅查询ToolStripMenuItem.Name = "借阅查询ToolStripMenuItem"
        Me.借阅查询ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.借阅查询ToolStripMenuItem.Text = "借阅查询"
        '
        '借阅归还ToolStripMenuItem
        '
        Me.借阅归还ToolStripMenuItem.Name = "借阅归还ToolStripMenuItem"
        Me.借阅归还ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.借阅归还ToolStripMenuItem.Text = "借阅归还"
        '
        'AdminMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 522)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
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
End Class
