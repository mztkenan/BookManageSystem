<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BeautifulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuejieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaopoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.UserText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnForget = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TypeBox = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeautifulToolStripMenuItem, Me.XuejieToolStripMenuItem, Me.LaopoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 70)
        '
        'BeautifulToolStripMenuItem
        '
        Me.BeautifulToolStripMenuItem.Name = "BeautifulToolStripMenuItem"
        Me.BeautifulToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BeautifulToolStripMenuItem.Text = "beautiful"
        '
        'XuejieToolStripMenuItem
        '
        Me.XuejieToolStripMenuItem.Name = "XuejieToolStripMenuItem"
        Me.XuejieToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.XuejieToolStripMenuItem.Text = "xuejie"
        '
        'LaopoToolStripMenuItem
        '
        Me.LaopoToolStripMenuItem.Name = "LaopoToolStripMenuItem"
        Me.LaopoToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.LaopoToolStripMenuItem.Text = "laopo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "pictures(*.jpg)|"
        Me.OpenFileDialog1.InitialDirectory = "C:\Windows"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("隶书", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "图书管理系统"
        '
        'PasswordText
        '
        Me.PasswordText.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PasswordText.Location = New System.Drawing.Point(250, 253)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordText.Size = New System.Drawing.Size(221, 33)
        Me.PasswordText.TabIndex = 8
        '
        'UserText
        '
        Me.UserText.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UserText.Location = New System.Drawing.Point(250, 195)
        Me.UserText.Name = "UserText"
        Me.UserText.Size = New System.Drawing.Size(221, 33)
        Me.UserText.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "密码"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(164, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "账号"
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(170, 412)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(114, 41)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "确定"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnForget
        '
        Me.btnForget.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnForget.Location = New System.Drawing.Point(357, 411)
        Me.btnForget.Name = "btnForget"
        Me.btnForget.Size = New System.Drawing.Size(114, 42)
        Me.btnForget.TabIndex = 10
        Me.btnForget.Text = "忘记密码"
        Me.btnForget.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(164, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 31)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "类型"
        '
        'TypeBox
        '
        Me.TypeBox.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Items.AddRange(New Object() {"管理员", "学生"})
        Me.TypeBox.Location = New System.Drawing.Point(250, 318)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(221, 33)
        Me.TypeBox.TabIndex = 12
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BookManageSystem.My.Resources.Resources.Tulips
        Me.ClientSize = New System.Drawing.Size(650, 528)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.TypeBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.UserText)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnForget)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Login"
        Me.Text = "登录"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BeautifulToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XuejieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaopoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PasswordText As System.Windows.Forms.TextBox
    Friend WithEvents UserText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnForget As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TypeBox As System.Windows.Forms.ComboBox

End Class
