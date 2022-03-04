<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_edit_dialysis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_edit_dialysis))
        Me.Label_dialysis_number = New System.Windows.Forms.Label()
        Me.MaskedTextBox_date_1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_date_2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_time_2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_time_1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label_weight_2 = New System.Windows.Forms.Label()
        Me.Label_date_2 = New System.Windows.Forms.Label()
        Me.Label_time_2 = New System.Windows.Forms.Label()
        Me.Label_weight_1 = New System.Windows.Forms.Label()
        Me.Label_date_1 = New System.Windows.Forms.Label()
        Me.Label_time_1 = New System.Windows.Forms.Label()
        Me.NumericUpDown_weight_2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_weight_1 = New System.Windows.Forms.NumericUpDown()
        Me.Button_cancell = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown_weight_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_weight_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_dialysis_number
        '
        Me.Label_dialysis_number.ForeColor = System.Drawing.Color.Red
        Me.Label_dialysis_number.Location = New System.Drawing.Point(110, 10)
        Me.Label_dialysis_number.Name = "Label_dialysis_number"
        Me.Label_dialysis_number.Size = New System.Drawing.Size(100, 25)
        Me.Label_dialysis_number.TabIndex = 92
        Me.Label_dialysis_number.Text = "Label_dialysis_number"
        Me.Label_dialysis_number.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MaskedTextBox_date_1
        '
        Me.MaskedTextBox_date_1.Location = New System.Drawing.Point(14, 155)
        Me.MaskedTextBox_date_1.Mask = "0000/00/00"
        Me.MaskedTextBox_date_1.Name = "MaskedTextBox_date_1"
        Me.MaskedTextBox_date_1.Size = New System.Drawing.Size(70, 20)
        Me.MaskedTextBox_date_1.TabIndex = 79
        Me.MaskedTextBox_date_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_date_2
        '
        Me.MaskedTextBox_date_2.Location = New System.Drawing.Point(244, 155)
        Me.MaskedTextBox_date_2.Mask = "0000/00/00"
        Me.MaskedTextBox_date_2.Name = "MaskedTextBox_date_2"
        Me.MaskedTextBox_date_2.Size = New System.Drawing.Size(70, 20)
        Me.MaskedTextBox_date_2.TabIndex = 82
        Me.MaskedTextBox_date_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_time_2
        '
        Me.MaskedTextBox_time_2.Location = New System.Drawing.Point(279, 70)
        Me.MaskedTextBox_time_2.Mask = "00:00"
        Me.MaskedTextBox_time_2.Name = "MaskedTextBox_time_2"
        Me.MaskedTextBox_time_2.Size = New System.Drawing.Size(35, 20)
        Me.MaskedTextBox_time_2.TabIndex = 81
        Me.MaskedTextBox_time_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox_time_2.ValidatingType = GetType(Date)
        '
        'MaskedTextBox_time_1
        '
        Me.MaskedTextBox_time_1.Location = New System.Drawing.Point(14, 70)
        Me.MaskedTextBox_time_1.Mask = "00:00"
        Me.MaskedTextBox_time_1.Name = "MaskedTextBox_time_1"
        Me.MaskedTextBox_time_1.Size = New System.Drawing.Size(35, 20)
        Me.MaskedTextBox_time_1.TabIndex = 78
        Me.MaskedTextBox_time_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox_time_1.ValidatingType = GetType(Date)
        '
        'Label_weight_2
        '
        Me.Label_weight_2.Location = New System.Drawing.Point(164, 210)
        Me.Label_weight_2.Name = "Label_weight_2"
        Me.Label_weight_2.Size = New System.Drawing.Size(150, 25)
        Me.Label_weight_2.TabIndex = 91
        Me.Label_weight_2.Text = "Label_weight_2"
        Me.Label_weight_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_date_2
        '
        Me.Label_date_2.Location = New System.Drawing.Point(164, 125)
        Me.Label_date_2.Name = "Label_date_2"
        Me.Label_date_2.Size = New System.Drawing.Size(150, 25)
        Me.Label_date_2.TabIndex = 90
        Me.Label_date_2.Text = "Label_date_2"
        Me.Label_date_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_time_2
        '
        Me.Label_time_2.Location = New System.Drawing.Point(164, 40)
        Me.Label_time_2.Name = "Label_time_2"
        Me.Label_time_2.Size = New System.Drawing.Size(150, 25)
        Me.Label_time_2.TabIndex = 89
        Me.Label_time_2.Text = "Label_time_2"
        Me.Label_time_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_weight_1
        '
        Me.Label_weight_1.Location = New System.Drawing.Point(14, 210)
        Me.Label_weight_1.Name = "Label_weight_1"
        Me.Label_weight_1.Size = New System.Drawing.Size(150, 25)
        Me.Label_weight_1.TabIndex = 88
        Me.Label_weight_1.Text = "Label_weight_1"
        Me.Label_weight_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_date_1
        '
        Me.Label_date_1.Location = New System.Drawing.Point(14, 125)
        Me.Label_date_1.Name = "Label_date_1"
        Me.Label_date_1.Size = New System.Drawing.Size(150, 25)
        Me.Label_date_1.TabIndex = 87
        Me.Label_date_1.Text = "Label_date_1"
        Me.Label_date_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_time_1
        '
        Me.Label_time_1.Location = New System.Drawing.Point(14, 40)
        Me.Label_time_1.Name = "Label_time_1"
        Me.Label_time_1.Size = New System.Drawing.Size(150, 25)
        Me.Label_time_1.TabIndex = 86
        Me.Label_time_1.Text = "Label_time_1"
        Me.Label_time_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown_weight_2
        '
        Me.NumericUpDown_weight_2.DecimalPlaces = 2
        Me.NumericUpDown_weight_2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_weight_2.Location = New System.Drawing.Point(254, 240)
        Me.NumericUpDown_weight_2.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_weight_2.Name = "NumericUpDown_weight_2"
        Me.NumericUpDown_weight_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumericUpDown_weight_2.Size = New System.Drawing.Size(60, 20)
        Me.NumericUpDown_weight_2.TabIndex = 83
        Me.NumericUpDown_weight_2.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDown_weight_1
        '
        Me.NumericUpDown_weight_1.DecimalPlaces = 2
        Me.NumericUpDown_weight_1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_weight_1.Location = New System.Drawing.Point(14, 240)
        Me.NumericUpDown_weight_1.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_weight_1.Name = "NumericUpDown_weight_1"
        Me.NumericUpDown_weight_1.Size = New System.Drawing.Size(60, 20)
        Me.NumericUpDown_weight_1.TabIndex = 80
        Me.NumericUpDown_weight_1.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Button_cancell
        '
        Me.Button_cancell.BackColor = System.Drawing.Color.Gainsboro
        Me.Button_cancell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_cancell.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button_cancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cancell.Location = New System.Drawing.Point(11, 280)
        Me.Button_cancell.Name = "Button_cancell"
        Me.Button_cancell.Size = New System.Drawing.Size(150, 27)
        Me.Button_cancell.TabIndex = 84
        Me.Button_cancell.Text = "Cancel"
        Me.Button_cancell.UseVisualStyleBackColor = False
        '
        'Button_edit
        '
        Me.Button_edit.BackColor = System.Drawing.Color.Gainsboro
        Me.Button_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_edit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Button_edit.FlatAppearance.BorderSize = 2
        Me.Button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_edit.Location = New System.Drawing.Point(164, 280)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(150, 27)
        Me.Button_edit.TabIndex = 85
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = False
        '
        'Form_edit_dialysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(324, 316)
        Me.Controls.Add(Me.Label_dialysis_number)
        Me.Controls.Add(Me.MaskedTextBox_date_1)
        Me.Controls.Add(Me.MaskedTextBox_date_2)
        Me.Controls.Add(Me.MaskedTextBox_time_2)
        Me.Controls.Add(Me.MaskedTextBox_time_1)
        Me.Controls.Add(Me.Label_weight_2)
        Me.Controls.Add(Me.Label_date_2)
        Me.Controls.Add(Me.Label_time_2)
        Me.Controls.Add(Me.Label_weight_1)
        Me.Controls.Add(Me.Label_date_1)
        Me.Controls.Add(Me.Label_time_1)
        Me.Controls.Add(Me.NumericUpDown_weight_2)
        Me.Controls.Add(Me.NumericUpDown_weight_1)
        Me.Controls.Add(Me.Button_cancell)
        Me.Controls.Add(Me.Button_edit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_edit_dialysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Dialysis"
        CType(Me.NumericUpDown_weight_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_weight_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_dialysis_number As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_date_1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_date_2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_time_2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_time_1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label_weight_2 As System.Windows.Forms.Label
    Friend WithEvents Label_date_2 As System.Windows.Forms.Label
    Friend WithEvents Label_time_2 As System.Windows.Forms.Label
    Friend WithEvents Label_weight_1 As System.Windows.Forms.Label
    Friend WithEvents Label_date_1 As System.Windows.Forms.Label
    Friend WithEvents Label_time_1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_weight_2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_weight_1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button_cancell As System.Windows.Forms.Button
    Friend WithEvents Button_edit As System.Windows.Forms.Button
End Class
