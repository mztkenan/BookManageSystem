<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReserve
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbMessage = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txbInput = New System.Windows.Forms.TextBox()
        Me.rbReserveDate = New System.Windows.Forms.RadioButton()
        Me.rbBookId = New System.Windows.Forms.RadioButton()
        Me.rbSno = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(68, 172)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(704, 312)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "查询结果"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(64, 36)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(576, 250)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbMessage)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.lblInput)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txbInput)
        Me.GroupBox1.Controls.Add(Me.rbReserveDate)
        Me.GroupBox1.Controls.Add(Me.rbBookId)
        Me.GroupBox1.Controls.Add(Me.rbSno)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 44)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(704, 121)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询预定信息"
        '
        'lbMessage
        '
        Me.lbMessage.AutoSize = True
        Me.lbMessage.ForeColor = System.Drawing.Color.Red
        Me.lbMessage.Location = New System.Drawing.Point(521, 89)
        Me.lbMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(0, 15)
        Me.lbMessage.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(599, 39)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(389, 81)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 29)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "保存修改"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(361, 46)
        Me.lblInput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(45, 15)
        Me.lblInput.TabIndex = 4
        Me.lblInput.Text = "输入:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(221, 81)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 29)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "查看所有"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txbInput
        '
        Me.txbInput.Location = New System.Drawing.Point(424, 40)
        Me.txbInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbInput.Name = "txbInput"
        Me.txbInput.Size = New System.Drawing.Size(155, 25)
        Me.txbInput.TabIndex = 3
        '
        'rbReserveDate
        '
        Me.rbReserveDate.AutoSize = True
        Me.rbReserveDate.Location = New System.Drawing.Point(244, 44)
        Me.rbReserveDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbReserveDate.Name = "rbReserveDate"
        Me.rbReserveDate.Size = New System.Drawing.Size(117, 24)
        Me.rbReserveDate.TabIndex = 2
        Me.rbReserveDate.TabStop = True
        Me.rbReserveDate.Text = "预定时间"
        Me.rbReserveDate.UseVisualStyleBackColor = True
        '
        'rbBookId
        '
        Me.rbBookId.AutoSize = True
        Me.rbBookId.Location = New System.Drawing.Point(137, 44)
        Me.rbBookId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbBookId.Name = "rbBookId"
        Me.rbBookId.Size = New System.Drawing.Size(77, 24)
        Me.rbBookId.TabIndex = 1
        Me.rbBookId.TabStop = True
        Me.rbBookId.Text = "书号"
        Me.rbBookId.UseVisualStyleBackColor = True
        '
        'rbSno
        '
        Me.rbSno.AutoSize = True
        Me.rbSno.Location = New System.Drawing.Point(33, 44)
        Me.rbSno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbSno.Name = "rbSno"
        Me.rbSno.Size = New System.Drawing.Size(77, 24)
        Me.rbSno.TabIndex = 0
        Me.rbSno.TabStop = True
        Me.rbSno.Text = "学号"
        Me.rbSno.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BookReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 528)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BookReserve"
        Me.Text = "图书预定管理"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbMessage As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txbInput As System.Windows.Forms.TextBox
    Friend WithEvents rbReserveDate As System.Windows.Forms.RadioButton
    Friend WithEvents rbBookId As System.Windows.Forms.RadioButton
    Friend WithEvents rbSno As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
