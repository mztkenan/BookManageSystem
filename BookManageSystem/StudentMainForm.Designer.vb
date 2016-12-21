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
        Me.查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询图书详情ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.预定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.预定图书ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.预定ToolStripMenuItem, Me.查询ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '查询ToolStripMenuItem
        '
        Me.查询ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查询图书详情ToolStripMenuItem})
        Me.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem"
        Me.查询ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.查询ToolStripMenuItem.Text = "查询"
        '
        '查询图书详情ToolStripMenuItem
        '
        Me.查询图书详情ToolStripMenuItem.Name = "查询图书详情ToolStripMenuItem"
        Me.查询图书详情ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.查询图书详情ToolStripMenuItem.Text = "查询图书详情"
        '
        '预定ToolStripMenuItem
        '
        Me.预定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.预定图书ToolStripMenuItem})
        Me.预定ToolStripMenuItem.Name = "预定ToolStripMenuItem"
        Me.预定ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.预定ToolStripMenuItem.Text = "预定"
        '
        '预定图书ToolStripMenuItem
        '
        Me.预定图书ToolStripMenuItem.Name = "预定图书ToolStripMenuItem"
        Me.预定图书ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.预定图书ToolStripMenuItem.Text = "预定图书"
        '
        'StudentMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 522)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
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
End Class
