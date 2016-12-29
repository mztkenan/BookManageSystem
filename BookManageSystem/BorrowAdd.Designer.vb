<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowAdd
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbBookID = New System.Windows.Forms.TextBox()
        Me.tbSno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfim = New System.Windows.Forms.Button()
        Me.borrowTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 294)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "借书日期："
        '
        'tbBookID
        '
        Me.tbBookID.Location = New System.Drawing.Point(180, 192)
        Me.tbBookID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbBookID.Name = "tbBookID"
        Me.tbBookID.Size = New System.Drawing.Size(132, 25)
        Me.tbBookID.TabIndex = 22
        '
        'tbSno
        '
        Me.tbSno.Location = New System.Drawing.Point(180, 104)
        Me.tbSno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbSno.Name = "tbSno"
        Me.tbSno.Size = New System.Drawing.Size(132, 25)
        Me.tbSno.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 205)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "书    号："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "学    号："
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(345, 531)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 29)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfim
        '
        Me.btnConfim.Location = New System.Drawing.Point(148, 531)
        Me.btnConfim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfim.Name = "btnConfim"
        Me.btnConfim.Size = New System.Drawing.Size(100, 29)
        Me.btnConfim.TabIndex = 17
        Me.btnConfim.Text = "确定"
        Me.btnConfim.UseVisualStyleBackColor = True
        '
        'borrowTimePicker
        '
        Me.borrowTimePicker.Location = New System.Drawing.Point(180, 286)
        Me.borrowTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.borrowTimePicker.Name = "borrowTimePicker"
        Me.borrowTimePicker.Size = New System.Drawing.Size(197, 25)
        Me.borrowTimePicker.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.borrowTimePicker)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbSno)
        Me.GroupBox1.Controls.Add(Me.tbBookID)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(455, 411)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "借书信息登记"
        '
        'BorrowAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 652)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfim)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BorrowAdd"
        Me.Text = "借书登记"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbBookID As System.Windows.Forms.TextBox
    Friend WithEvents tbSno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnConfim As System.Windows.Forms.Button
    Friend WithEvents borrowTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
