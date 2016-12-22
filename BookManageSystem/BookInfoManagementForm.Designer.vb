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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbBookName = New System.Windows.Forms.RadioButton()
        Me.rdBookId = New System.Windows.Forms.RadioButton()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txbInput = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(50, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 257)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "查询结果"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(502, 200)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblInput)
        Me.GroupBox1.Controls.Add(Me.txbInput)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rbBookName)
        Me.GroupBox1.Controls.Add(Me.rdBookId)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 104)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询图书信息"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(380, 36)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(132, 16)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "只查询在馆图书信息"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(290, 35)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 16)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "出版社"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(208, 35)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "作者"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbBookName
        '
        Me.rbBookName.AutoSize = True
        Me.rbBookName.Location = New System.Drawing.Point(128, 35)
        Me.rbBookName.Name = "rbBookName"
        Me.rbBookName.Size = New System.Drawing.Size(47, 16)
        Me.rbBookName.TabIndex = 1
        Me.rbBookName.TabStop = True
        Me.rbBookName.Text = "书名"
        Me.rbBookName.UseVisualStyleBackColor = True
        '
        'rdBookId
        '
        Me.rdBookId.AutoSize = True
        Me.rdBookId.Location = New System.Drawing.Point(50, 35)
        Me.rdBookId.Name = "rdBookId"
        Me.rdBookId.Size = New System.Drawing.Size(47, 16)
        Me.rdBookId.TabIndex = 0
        Me.rdBookId.TabStop = True
        Me.rdBookId.Text = "书号"
        Me.rdBookId.UseVisualStyleBackColor = True
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(163, 73)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(35, 12)
        Me.lblInput.TabIndex = 6
        Me.lblInput.Text = "输入:"
        '
        'txbInput
        '
        Me.txbInput.Location = New System.Drawing.Point(211, 67)
        Me.txbInput.Name = "txbInput"
        Me.txbInput.Size = New System.Drawing.Size(117, 21)
        Me.txbInput.TabIndex = 5
        '
        'BookInfoManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 422)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
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
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBookName As System.Windows.Forms.RadioButton
    Friend WithEvents rdBookId As System.Windows.Forms.RadioButton
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txbInput As System.Windows.Forms.TextBox
End Class
