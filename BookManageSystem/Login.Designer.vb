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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.UserText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnForget = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TypeBox = New System.Windows.Forms.ComboBox()
        Me.lbForget = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("隶书", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "图书管理系统"
        '
        'PasswordText
        '
        Me.PasswordText.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PasswordText.Location = New System.Drawing.Point(333, 303)
        Me.PasswordText.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordText.Size = New System.Drawing.Size(293, 39)
        Me.PasswordText.TabIndex = 8
        '
        'UserText
        '
        Me.UserText.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UserText.Location = New System.Drawing.Point(333, 231)
        Me.UserText.Margin = New System.Windows.Forms.Padding(4)
        Me.UserText.Name = "UserText"
        Me.UserText.Size = New System.Drawing.Size(293, 39)
        Me.UserText.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(219, 303)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 39)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "密码"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(219, 231)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "账号"
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(227, 502)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(152, 51)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "确定"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnForget
        '
        Me.btnForget.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnForget.Location = New System.Drawing.Point(476, 501)
        Me.btnForget.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForget.Name = "btnForget"
        Me.btnForget.Size = New System.Drawing.Size(152, 52)
        Me.btnForget.TabIndex = 10
        Me.btnForget.Text = "忘记密码"
        Me.btnForget.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(219, 387)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 39)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "类型"
        '
        'TypeBox
        '
        Me.TypeBox.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Items.AddRange(New Object() {"管理员", "学生"})
        Me.TypeBox.Location = New System.Drawing.Point(333, 385)
        Me.TypeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(293, 39)
        Me.TypeBox.TabIndex = 12
        '
        'lbForget
        '
        Me.lbForget.AutoSize = True
        Me.lbForget.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbForget.ForeColor = System.Drawing.Color.Red
        Me.lbForget.Location = New System.Drawing.Point(373, 43)
        Me.lbForget.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbForget.Name = "lbForget"
        Me.lbForget.Size = New System.Drawing.Size(0, 32)
        Me.lbForget.TabIndex = 13
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BookManageSystem.My.Resources.Resources._97X58PICAY4_1024
        Me.ClientSize = New System.Drawing.Size(869, 628)
        Me.Controls.Add(Me.lbForget)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "登录"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PasswordText As System.Windows.Forms.TextBox
    Friend WithEvents UserText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnForget As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TypeBox As System.Windows.Forms.ComboBox
    Friend WithEvents lbForget As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
