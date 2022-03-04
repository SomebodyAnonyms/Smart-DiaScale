<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_first_start_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_first_start_2))
        Me.Label_title = New System.Windows.Forms.Label()
        Me.Button_next = New System.Windows.Forms.Button()
        Me.NumericUpDown_dialysis_time = New System.Windows.Forms.NumericUpDown()
        Me.MaskedTextBox_hospital_tel = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox_hospital_address = New System.Windows.Forms.TextBox()
        Me.TextBox_hospital_name = New System.Windows.Forms.TextBox()
        Me.Label_dialysis_time = New System.Windows.Forms.Label()
        Me.Label_hospital_tel = New System.Windows.Forms.Label()
        Me.Label_hospital_address = New System.Windows.Forms.Label()
        Me.Label_hospital_name = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown_dialysis_time, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_title
        '
        Me.Label_title.Location = New System.Drawing.Point(12, 10)
        Me.Label_title.Name = "Label_title"
        Me.Label_title.Size = New System.Drawing.Size(776, 50)
        Me.Label_title.TabIndex = 35
        Me.Label_title.Text = "Label_title"
        Me.Label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_next
        '
        Me.Button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_next.Location = New System.Drawing.Point(362, 315)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(75, 27)
        Me.Button_next.TabIndex = 30
        Me.Button_next.Text = "Button_next"
        Me.Button_next.UseVisualStyleBackColor = True
        '
        'NumericUpDown_dialysis_time
        '
        Me.NumericUpDown_dialysis_time.Location = New System.Drawing.Point(735, 250)
        Me.NumericUpDown_dialysis_time.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.NumericUpDown_dialysis_time.Name = "NumericUpDown_dialysis_time"
        Me.NumericUpDown_dialysis_time.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDown_dialysis_time.TabIndex = 29
        Me.NumericUpDown_dialysis_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_hospital_tel
        '
        Me.MaskedTextBox_hospital_tel.Location = New System.Drawing.Point(15, 250)
        Me.MaskedTextBox_hospital_tel.Mask = "00000000000"
        Me.MaskedTextBox_hospital_tel.Name = "MaskedTextBox_hospital_tel"
        Me.MaskedTextBox_hospital_tel.Size = New System.Drawing.Size(80, 20)
        Me.MaskedTextBox_hospital_tel.TabIndex = 28
        Me.MaskedTextBox_hospital_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_hospital_address
        '
        Me.TextBox_hospital_address.Location = New System.Drawing.Point(585, 115)
        Me.TextBox_hospital_address.Name = "TextBox_hospital_address"
        Me.TextBox_hospital_address.Size = New System.Drawing.Size(200, 20)
        Me.TextBox_hospital_address.TabIndex = 27
        Me.TextBox_hospital_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_hospital_name
        '
        Me.TextBox_hospital_name.Location = New System.Drawing.Point(15, 115)
        Me.TextBox_hospital_name.Name = "TextBox_hospital_name"
        Me.TextBox_hospital_name.Size = New System.Drawing.Size(200, 20)
        Me.TextBox_hospital_name.TabIndex = 26
        Me.TextBox_hospital_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_dialysis_time
        '
        Me.Label_dialysis_time.Location = New System.Drawing.Point(585, 220)
        Me.Label_dialysis_time.Name = "Label_dialysis_time"
        Me.Label_dialysis_time.Size = New System.Drawing.Size(200, 25)
        Me.Label_dialysis_time.TabIndex = 34
        Me.Label_dialysis_time.Text = "Label_dialysis_time"
        Me.Label_dialysis_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_hospital_tel
        '
        Me.Label_hospital_tel.Location = New System.Drawing.Point(15, 220)
        Me.Label_hospital_tel.Name = "Label_hospital_tel"
        Me.Label_hospital_tel.Size = New System.Drawing.Size(200, 25)
        Me.Label_hospital_tel.TabIndex = 33
        Me.Label_hospital_tel.Text = "Label_hospital_tel"
        Me.Label_hospital_tel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_hospital_address
        '
        Me.Label_hospital_address.Location = New System.Drawing.Point(585, 85)
        Me.Label_hospital_address.Name = "Label_hospital_address"
        Me.Label_hospital_address.Size = New System.Drawing.Size(200, 25)
        Me.Label_hospital_address.TabIndex = 32
        Me.Label_hospital_address.Text = "Label_hospital_address"
        Me.Label_hospital_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_hospital_name
        '
        Me.Label_hospital_name.Location = New System.Drawing.Point(15, 85)
        Me.Label_hospital_name.Name = "Label_hospital_name"
        Me.Label_hospital_name.Size = New System.Drawing.Size(200, 25)
        Me.Label_hospital_name.TabIndex = 31
        Me.Label_hospital_name.Text = "Label_hospital_name"
        Me.Label_hospital_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_first_start_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 350)
        Me.Controls.Add(Me.Label_title)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.NumericUpDown_dialysis_time)
        Me.Controls.Add(Me.MaskedTextBox_hospital_tel)
        Me.Controls.Add(Me.TextBox_hospital_address)
        Me.Controls.Add(Me.TextBox_hospital_name)
        Me.Controls.Add(Me.Label_dialysis_time)
        Me.Controls.Add(Me.Label_hospital_tel)
        Me.Controls.Add(Me.Label_hospital_address)
        Me.Controls.Add(Me.Label_hospital_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_first_start_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "First Start"
        CType(Me.NumericUpDown_dialysis_time, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_title As System.Windows.Forms.Label
    Friend WithEvents Button_next As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown_dialysis_time As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaskedTextBox_hospital_tel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox_hospital_address As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_hospital_name As System.Windows.Forms.TextBox
    Friend WithEvents Label_dialysis_time As System.Windows.Forms.Label
    Friend WithEvents Label_hospital_tel As System.Windows.Forms.Label
    Friend WithEvents Label_hospital_address As System.Windows.Forms.Label
    Friend WithEvents Label_hospital_name As System.Windows.Forms.Label
End Class
