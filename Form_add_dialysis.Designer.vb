<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_add_dialysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_add_dialysis))
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
        Me.Button_add = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown_weight_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_weight_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaskedTextBox_date_1
        '
        Me.MaskedTextBox_date_1.Location = New System.Drawing.Point(12, 125)
        Me.MaskedTextBox_date_1.Mask = "0000/00/00"
        Me.MaskedTextBox_date_1.Name = "MaskedTextBox_date_1"
        Me.MaskedTextBox_date_1.Size = New System.Drawing.Size(70, 20)
        Me.MaskedTextBox_date_1.TabIndex = 43
        Me.MaskedTextBox_date_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_date_2
        '
        Me.MaskedTextBox_date_2.Location = New System.Drawing.Point(242, 125)
        Me.MaskedTextBox_date_2.Mask = "0000/00/00"
        Me.MaskedTextBox_date_2.Name = "MaskedTextBox_date_2"
        Me.MaskedTextBox_date_2.Size = New System.Drawing.Size(70, 20)
        Me.MaskedTextBox_date_2.TabIndex = 46
        Me.MaskedTextBox_date_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_time_2
        '
        Me.MaskedTextBox_time_2.Location = New System.Drawing.Point(277, 38)
        Me.MaskedTextBox_time_2.Mask = "00:00"
        Me.MaskedTextBox_time_2.Name = "MaskedTextBox_time_2"
        Me.MaskedTextBox_time_2.Size = New System.Drawing.Size(35, 20)
        Me.MaskedTextBox_time_2.TabIndex = 45
        Me.MaskedTextBox_time_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox_time_2.ValidatingType = GetType(Date)
        '
        'MaskedTextBox_time_1
        '
        Me.MaskedTextBox_time_1.Location = New System.Drawing.Point(12, 38)
        Me.MaskedTextBox_time_1.Mask = "00:00"
        Me.MaskedTextBox_time_1.Name = "MaskedTextBox_time_1"
        Me.MaskedTextBox_time_1.Size = New System.Drawing.Size(35, 20)
        Me.MaskedTextBox_time_1.TabIndex = 42
        Me.MaskedTextBox_time_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox_time_1.ValidatingType = GetType(Date)
        '
        'Label_weight_2
        '
        Me.Label_weight_2.Location = New System.Drawing.Point(162, 180)
        Me.Label_weight_2.Name = "Label_weight_2"
        Me.Label_weight_2.Size = New System.Drawing.Size(150, 25)
        Me.Label_weight_2.TabIndex = 55
        Me.Label_weight_2.Text = "Label_weight_2"
        Me.Label_weight_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_date_2
        '
        Me.Label_date_2.Location = New System.Drawing.Point(162, 95)
        Me.Label_date_2.Name = "Label_date_2"
        Me.Label_date_2.Size = New System.Drawing.Size(150, 25)
        Me.Label_date_2.TabIndex = 54
        Me.Label_date_2.Text = "Label_date_2"
        Me.Label_date_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_time_2
        '
        Me.Label_time_2.Location = New System.Drawing.Point(162, 10)
        Me.Label_time_2.Name = "Label_time_2"
        Me.Label_time_2.Size = New System.Drawing.Size(150, 25)
        Me.Label_time_2.TabIndex = 53
        Me.Label_time_2.Text = "Label_time_2"
        Me.Label_time_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_weight_1
        '
        Me.Label_weight_1.Location = New System.Drawing.Point(12, 180)
        Me.Label_weight_1.Name = "Label_weight_1"
        Me.Label_weight_1.Size = New System.Drawing.Size(150, 25)
        Me.Label_weight_1.TabIndex = 52
        Me.Label_weight_1.Text = "Label_weight_1"
        Me.Label_weight_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_date_1
        '
        Me.Label_date_1.Location = New System.Drawing.Point(12, 95)
        Me.Label_date_1.Name = "Label_date_1"
        Me.Label_date_1.Size = New System.Drawing.Size(150, 25)
        Me.Label_date_1.TabIndex = 51
        Me.Label_date_1.Text = "Label_date_1"
        Me.Label_date_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_time_1
        '
        Me.Label_time_1.Location = New System.Drawing.Point(12, 10)
        Me.Label_time_1.Name = "Label_time_1"
        Me.Label_time_1.Size = New System.Drawing.Size(150, 25)
        Me.Label_time_1.TabIndex = 50
        Me.Label_time_1.Text = "Label_time_1"
        Me.Label_time_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown_weight_2
        '
        Me.NumericUpDown_weight_2.DecimalPlaces = 2
        Me.NumericUpDown_weight_2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_weight_2.Location = New System.Drawing.Point(252, 208)
        Me.NumericUpDown_weight_2.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_weight_2.Name = "NumericUpDown_weight_2"
        Me.NumericUpDown_weight_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumericUpDown_weight_2.Size = New System.Drawing.Size(60, 20)
        Me.NumericUpDown_weight_2.TabIndex = 47
        Me.NumericUpDown_weight_2.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDown_weight_1
        '
        Me.NumericUpDown_weight_1.DecimalPlaces = 2
        Me.NumericUpDown_weight_1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_weight_1.Location = New System.Drawing.Point(12, 208)
        Me.NumericUpDown_weight_1.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_weight_1.Name = "NumericUpDown_weight_1"
        Me.NumericUpDown_weight_1.Size = New System.Drawing.Size(60, 20)
        Me.NumericUpDown_weight_1.TabIndex = 44
        Me.NumericUpDown_weight_1.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Button_cancell
        '
        Me.Button_cancell.BackColor = System.Drawing.Color.Gainsboro
        Me.Button_cancell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_cancell.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button_cancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cancell.Location = New System.Drawing.Point(9, 250)
        Me.Button_cancell.Name = "Button_cancell"
        Me.Button_cancell.Size = New System.Drawing.Size(150, 27)
        Me.Button_cancell.TabIndex = 48
        Me.Button_cancell.Text = "Cancel"
        Me.Button_cancell.UseVisualStyleBackColor = False
        '
        'Button_add
        '
        Me.Button_add.BackColor = System.Drawing.Color.Gainsboro
        Me.Button_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_add.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Button_add.FlatAppearance.BorderSize = 2
        Me.Button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_add.Location = New System.Drawing.Point(162, 250)
        Me.Button_add.Name = "Button_add"
        Me.Button_add.Size = New System.Drawing.Size(150, 27)
        Me.Button_add.TabIndex = 49
        Me.Button_add.Text = "Add"
        Me.Button_add.UseVisualStyleBackColor = False
        '
        'Form_add_dialysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(324, 286)
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
        Me.Controls.Add(Me.Button_add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_add_dialysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Dialysis"
        CType(Me.NumericUpDown_weight_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_weight_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Button_add As System.Windows.Forms.Button
End Class
