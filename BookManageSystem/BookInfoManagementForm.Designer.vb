<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookInfoManagementForm
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txbInput = New System.Windows.Forms.TextBox()
        Me.cbHasStorage = New System.Windows.Forms.CheckBox()
        Me.rdPublisher = New System.Windows.Forms.RadioButton()
        Me.rdAuthor = New System.Windows.Forms.RadioButton()
        Me.rdBookName = New System.Windows.Forms.RadioButton()
        Me.rdBookId = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 191)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(908, 321)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "查询结果"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 38)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(847, 250)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbMessage)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblInput)
        Me.GroupBox1.Controls.Add(Me.txbInput)
        Me.GroupBox1.Controls.Add(Me.cbHasStorage)
        Me.GroupBox1.Controls.Add(Me.rdPublisher)
        Me.GroupBox1.Controls.Add(Me.rdAuthor)
        Me.GroupBox1.Controls.Add(Me.rdBookName)
        Me.GroupBox1.Controls.Add(Me.rdBookId)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(908, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询图书信息"
        '
        'lbMessage
        '
        Me.lbMessage.AutoSize = True
        Me.lbMessage.ForeColor = System.Drawing.Color.Red
        Me.lbMessage.Location = New System.Drawing.Point(800, 59)
        Me.lbMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(0, 15)
        Me.lbMessage.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(787, 81)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 29)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "保存修改"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(647, 81)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 29)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "查看所有"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 82)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(59, 91)
        Me.lblInput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(45, 15)
        Me.lblInput.TabIndex = 6
        Me.lblInput.Text = "输入:"
        '
        'txbInput
        '
        Me.txbInput.Location = New System.Drawing.Point(123, 84)
        Me.txbInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbInput.Name = "txbInput"
        Me.txbInput.Size = New System.Drawing.Size(155, 25)
        Me.txbInput.TabIndex = 5
        '
        'cbHasStorage
        '
        Me.cbHasStorage.AutoSize = True
        Me.cbHasStorage.Location = New System.Drawing.Point(500, 45)
        Me.cbHasStorage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbHasStorage.Name = "cbHasStorage"
        Me.cbHasStorage.Size = New System.Drawing.Size(219, 24)
        Me.cbHasStorage.TabIndex = 4
        Me.cbHasStorage.Text = "只查询在馆图书信息"
        Me.cbHasStorage.UseVisualStyleBackColor = True
        '
        'rdPublisher
        '
        Me.rdPublisher.AutoSize = True
        Me.rdPublisher.Location = New System.Drawing.Point(380, 44)
        Me.rdPublisher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdPublisher.Name = "rdPublisher"
        Me.rdPublisher.Size = New System.Drawing.Size(97, 24)
        Me.rdPublisher.TabIndex = 3
        Me.rdPublisher.TabStop = True
        Me.rdPublisher.Text = "出版社"
        Me.rdPublisher.UseVisualStyleBackColor = True
        '
        'rdAuthor
        '
        Me.rdAuthor.AutoSize = True
        Me.rdAuthor.Location = New System.Drawing.Point(271, 44)
        Me.rdAuthor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdAuthor.Name = "rdAuthor"
        Me.rdAuthor.Size = New System.Drawing.Size(77, 24)
        Me.rdAuthor.TabIndex = 2
        Me.rdAuthor.TabStop = True
        Me.rdAuthor.Text = "作者"
        Me.rdAuthor.UseVisualStyleBackColor = True
        '
        'rdBookName
        '
        Me.rdBookName.AutoSize = True
        Me.rdBookName.Location = New System.Drawing.Point(164, 44)
        Me.rdBookName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdBookName.Name = "rdBookName"
        Me.rdBookName.Size = New System.Drawing.Size(77, 24)
        Me.rdBookName.TabIndex = 1
        Me.rdBookName.TabStop = True
        Me.rdBookName.Text = "书名"
        Me.rdBookName.UseVisualStyleBackColor = True
        '
        'rdBookId
        '
        Me.rdBookId.AutoSize = True
        Me.rdBookId.Location = New System.Drawing.Point(60, 44)
        Me.rdBookId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdBookId.Name = "rdBookId"
        Me.rdBookId.Size = New System.Drawing.Size(77, 24)
        Me.rdBookId.TabIndex = 0
        Me.rdBookId.TabStop = True
        Me.rdBookId.Text = "书号"
        Me.rdBookId.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BookInfoManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 528)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BookInfoManagementForm"
        Me.Text = "图书信息管理"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbHasStorage As System.Windows.Forms.CheckBox
    Friend WithEvents rdPublisher As System.Windows.Forms.RadioButton
    Friend WithEvents rdAuthor As System.Windows.Forms.RadioButton
    Friend WithEvents rdBookName As System.Windows.Forms.RadioButton
    Friend WithEvents rdBookId As System.Windows.Forms.RadioButton
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txbInput As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lbMessage As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
