﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PublisherInfo
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txbInput = New System.Windows.Forms.TextBox()
        Me.rbId = New System.Windows.Forms.RadioButton()
        Me.rbName = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 172)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(725, 310)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "查询结果"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(71, 38)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(587, 250)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbMessage)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lblInput)
        Me.GroupBox1.Controls.Add(Me.txbInput)
        Me.GroupBox1.Controls.Add(Me.rbId)
        Me.GroupBox1.Controls.Add(Me.rbName)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(725, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询出版社信息"
        '
        'lbMessage
        '
        Me.lbMessage.AutoSize = True
        Me.lbMessage.ForeColor = System.Drawing.Color.Red
        Me.lbMessage.Location = New System.Drawing.Point(524, 82)
        Me.lbMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(0, 15)
        Me.lbMessage.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(597, 29)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 29)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(388, 76)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 29)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "保存修改"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(220, 76)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 29)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "查看所有"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(347, 39)
        Me.lblInput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(45, 15)
        Me.lblInput.TabIndex = 6
        Me.lblInput.Text = "输入:"
        '
        'txbInput
        '
        Me.txbInput.Location = New System.Drawing.Point(411, 31)
        Me.txbInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbInput.Name = "txbInput"
        Me.txbInput.Size = New System.Drawing.Size(155, 25)
        Me.txbInput.TabIndex = 5
        '
        'rbId
        '
        Me.rbId.AutoSize = True
        Me.rbId.Location = New System.Drawing.Point(176, 38)
        Me.rbId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbId.Name = "rbId"
        Me.rbId.Size = New System.Drawing.Size(177, 24)
        Me.rbId.TabIndex = 4
        Me.rbId.TabStop = True
        Me.rbId.Text = "出版社模糊查询"
        Me.rbId.UseVisualStyleBackColor = True
        '
        'rbName
        '
        Me.rbName.AutoSize = True
        Me.rbName.Location = New System.Drawing.Point(44, 38)
        Me.rbName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbName.Name = "rbName"
        Me.rbName.Size = New System.Drawing.Size(137, 24)
        Me.rbName.TabIndex = 3
        Me.rbName.TabStop = True
        Me.rbName.Text = "出版社全称"
        Me.rbName.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PublisherInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 528)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PublisherInfo"
        Me.Text = "出版商信息管理"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbId As System.Windows.Forms.RadioButton
    Friend WithEvents rbName As System.Windows.Forms.RadioButton
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txbInput As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbMessage As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
