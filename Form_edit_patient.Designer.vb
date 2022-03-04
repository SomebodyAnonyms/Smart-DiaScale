<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_edit_patient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_edit_patient))
        Me.MaskedTextBox_enroll_date = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_birth_date = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_id_code = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_home_number = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_mobile_number = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox_dr_name = New System.Windows.Forms.TextBox()
        Me.Label_dr_name = New System.Windows.Forms.Label()
        Me.Label_fingerprint_status = New System.Windows.Forms.Label()
        Me.Button_cancell = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.RadioButton_female = New System.Windows.Forms.RadioButton()
        Me.RadioButton_male = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown_hieght = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_father_name = New System.Windows.Forms.TextBox()
        Me.TextBox_lastname = New System.Windows.Forms.TextBox()
        Me.TextBox_name = New System.Windows.Forms.TextBox()
        Me.Label_enroll_date = New System.Windows.Forms.Label()
        Me.Label_hieght = New System.Windows.Forms.Label()
        Me.Label_gender = New System.Windows.Forms.Label()
        Me.Label_home_number = New System.Windows.Forms.Label()
        Me.Label_mbile_number = New System.Windows.Forms.Label()
        Me.Label_id_code = New System.Windows.Forms.Label()
        Me.Label_birth_date = New System.Windows.Forms.Label()
        Me.Label_father_name = New System.Windows.Forms.Label()
        Me.Label_lastname = New System.Windows.Forms.Label()
        Me.Label_name = New System.Windows.Forms.Label()
        Me.PictureBox_fingerprint = New System.Windows.Forms.PictureBox()
        Me.ComboBox_blood_type = New System.Windows.Forms.ComboBox()
        Me.Label_blood_type = New System.Windows.Forms.Label()
        Me.PictureBox_patient_image = New System.Windows.Forms.PictureBox()
        Me.Label_patient_image = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox_shift = New System.Windows.Forms.ComboBox()
        Me.Label_shift = New System.Windows.Forms.Label()
        Me.PictureBox_delete_image = New System.Windows.Forms.PictureBox()
        CType(Me.NumericUpDown_hieght, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_fingerprint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_patient_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_delete_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaskedTextBox_enroll_date
        '
        Me.MaskedTextBox_enroll_date.Location = New System.Drawing.Point(420, 382)
        Me.MaskedTextBox_enroll_date.Mask = "0000/00/00"
        Me.MaskedTextBox_enroll_date.Name = "MaskedTextBox_enroll_date"
        Me.MaskedTextBox_enroll_date.Size = New System.Drawing.Size(70, 20)
        Me.MaskedTextBox_enroll_date.TabIndex = 10
        Me.MaskedTextBox_enroll_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_birth_date
        '
        Me.MaskedTextBox_birth_date.Location = New System.Drawing.Point(15, 297)
        Me.MaskedTextBox_birth_date.Mask = "0000/00/00"
        Me.MaskedTextBox_birth_date.Name = "MaskedTextBox_birth_date"
        Me.MaskedTextBox_birth_date.Size = New System.Drawing.Size(70, 20)
        Me.MaskedTextBox_birth_date.TabIndex = 3
        Me.MaskedTextBox_birth_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_id_code
        '
        Me.MaskedTextBox_id_code.Location = New System.Drawing.Point(15, 382)
        Me.MaskedTextBox_id_code.Mask = "0000000000"
        Me.MaskedTextBox_id_code.Name = "MaskedTextBox_id_code"
        Me.MaskedTextBox_id_code.Size = New System.Drawing.Size(70, 20)
        Me.MaskedTextBox_id_code.TabIndex = 4
        Me.MaskedTextBox_id_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_home_number
        '
        Me.MaskedTextBox_home_number.Location = New System.Drawing.Point(420, 127)
        Me.MaskedTextBox_home_number.Mask = "00000000000"
        Me.MaskedTextBox_home_number.Name = "MaskedTextBox_home_number"
        Me.MaskedTextBox_home_number.Size = New System.Drawing.Size(80, 20)
        Me.MaskedTextBox_home_number.TabIndex = 6
        Me.MaskedTextBox_home_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_mobile_number
        '
        Me.MaskedTextBox_mobile_number.Location = New System.Drawing.Point(420, 52)
        Me.MaskedTextBox_mobile_number.Mask = "00000000000"
        Me.MaskedTextBox_mobile_number.Name = "MaskedTextBox_mobile_number"
        Me.MaskedTextBox_mobile_number.Size = New System.Drawing.Size(80, 20)
        Me.MaskedTextBox_mobile_number.TabIndex = 5
        Me.MaskedTextBox_mobile_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_dr_name
        '
        Me.TextBox_dr_name.Location = New System.Drawing.Point(740, 52)
        Me.TextBox_dr_name.Name = "TextBox_dr_name"
        Me.TextBox_dr_name.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_dr_name.TabIndex = 11
        '
        'Label_dr_name
        '
        Me.Label_dr_name.Location = New System.Drawing.Point(740, 30)
        Me.Label_dr_name.Name = "Label_dr_name"
        Me.Label_dr_name.Size = New System.Drawing.Size(150, 20)
        Me.Label_dr_name.TabIndex = 91
        Me.Label_dr_name.Text = "Label_dr_name"
        '
        'Label_fingerprint_status
        '
        Me.Label_fingerprint_status.Location = New System.Drawing.Point(700, 391)
        Me.Label_fingerprint_status.Name = "Label_fingerprint_status"
        Me.Label_fingerprint_status.Size = New System.Drawing.Size(200, 20)
        Me.Label_fingerprint_status.TabIndex = 90
        Me.Label_fingerprint_status.Text = "Label_fingerprint_status"
        Me.Label_fingerprint_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_cancell
        '
        Me.Button_cancell.BackColor = System.Drawing.Color.Gainsboro
        Me.Button_cancell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_cancell.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button_cancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cancell.Location = New System.Drawing.Point(897, 425)
        Me.Button_cancell.Name = "Button_cancell"
        Me.Button_cancell.Size = New System.Drawing.Size(75, 27)
        Me.Button_cancell.TabIndex = 14
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
        Me.Button_edit.Location = New System.Drawing.Point(816, 425)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(75, 27)
        Me.Button_edit.TabIndex = 13
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = False
        '
        'RadioButton_female
        '
        Me.RadioButton_female.AutoSize = True
        Me.RadioButton_female.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_female.Location = New System.Drawing.Point(470, 212)
        Me.RadioButton_female.Name = "RadioButton_female"
        Me.RadioButton_female.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton_female.TabIndex = 8
        Me.RadioButton_female.TabStop = True
        Me.RadioButton_female.Text = "female"
        Me.RadioButton_female.UseVisualStyleBackColor = True
        '
        'RadioButton_male
        '
        Me.RadioButton_male.AutoSize = True
        Me.RadioButton_male.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_male.Location = New System.Drawing.Point(420, 212)
        Me.RadioButton_male.Name = "RadioButton_male"
        Me.RadioButton_male.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton_male.TabIndex = 7
        Me.RadioButton_male.TabStop = True
        Me.RadioButton_male.Text = "male"
        Me.RadioButton_male.UseVisualStyleBackColor = True
        '
        'NumericUpDown_hieght
        '
        Me.NumericUpDown_hieght.DecimalPlaces = 2
        Me.NumericUpDown_hieght.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDown_hieght.Location = New System.Drawing.Point(420, 297)
        Me.NumericUpDown_hieght.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericUpDown_hieght.Name = "NumericUpDown_hieght"
        Me.NumericUpDown_hieght.Size = New System.Drawing.Size(90, 20)
        Me.NumericUpDown_hieght.TabIndex = 9
        Me.NumericUpDown_hieght.Value = New Decimal(New Integer() {17, 0, 0, 65536})
        '
        'TextBox_father_name
        '
        Me.TextBox_father_name.Location = New System.Drawing.Point(15, 212)
        Me.TextBox_father_name.Name = "TextBox_father_name"
        Me.TextBox_father_name.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_father_name.TabIndex = 2
        '
        'TextBox_lastname
        '
        Me.TextBox_lastname.Location = New System.Drawing.Point(15, 127)
        Me.TextBox_lastname.Name = "TextBox_lastname"
        Me.TextBox_lastname.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_lastname.TabIndex = 1
        '
        'TextBox_name
        '
        Me.TextBox_name.Location = New System.Drawing.Point(15, 52)
        Me.TextBox_name.Name = "TextBox_name"
        Me.TextBox_name.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_name.TabIndex = 0
        '
        'Label_enroll_date
        '
        Me.Label_enroll_date.Location = New System.Drawing.Point(420, 360)
        Me.Label_enroll_date.Name = "Label_enroll_date"
        Me.Label_enroll_date.Size = New System.Drawing.Size(150, 20)
        Me.Label_enroll_date.TabIndex = 88
        Me.Label_enroll_date.Text = "Label_enroll_date"
        '
        'Label_hieght
        '
        Me.Label_hieght.Location = New System.Drawing.Point(420, 275)
        Me.Label_hieght.Name = "Label_hieght"
        Me.Label_hieght.Size = New System.Drawing.Size(150, 20)
        Me.Label_hieght.TabIndex = 87
        Me.Label_hieght.Text = "Label_hieght"
        '
        'Label_gender
        '
        Me.Label_gender.Location = New System.Drawing.Point(420, 190)
        Me.Label_gender.Name = "Label_gender"
        Me.Label_gender.Size = New System.Drawing.Size(150, 20)
        Me.Label_gender.TabIndex = 86
        Me.Label_gender.Text = "Label_gender"
        '
        'Label_home_number
        '
        Me.Label_home_number.Location = New System.Drawing.Point(420, 105)
        Me.Label_home_number.Name = "Label_home_number"
        Me.Label_home_number.Size = New System.Drawing.Size(150, 20)
        Me.Label_home_number.TabIndex = 85
        Me.Label_home_number.Text = "Label_home_number"
        '
        'Label_mbile_number
        '
        Me.Label_mbile_number.Location = New System.Drawing.Point(420, 30)
        Me.Label_mbile_number.Name = "Label_mbile_number"
        Me.Label_mbile_number.Size = New System.Drawing.Size(150, 20)
        Me.Label_mbile_number.TabIndex = 84
        Me.Label_mbile_number.Text = "Label_mbile_number"
        '
        'Label_id_code
        '
        Me.Label_id_code.Location = New System.Drawing.Point(15, 360)
        Me.Label_id_code.Name = "Label_id_code"
        Me.Label_id_code.Size = New System.Drawing.Size(150, 20)
        Me.Label_id_code.TabIndex = 83
        Me.Label_id_code.Text = "Label_id_code"
        '
        'Label_birth_date
        '
        Me.Label_birth_date.Location = New System.Drawing.Point(15, 275)
        Me.Label_birth_date.Name = "Label_birth_date"
        Me.Label_birth_date.Size = New System.Drawing.Size(150, 20)
        Me.Label_birth_date.TabIndex = 82
        Me.Label_birth_date.Text = "Label_birth_date"
        '
        'Label_father_name
        '
        Me.Label_father_name.Location = New System.Drawing.Point(15, 190)
        Me.Label_father_name.Name = "Label_father_name"
        Me.Label_father_name.Size = New System.Drawing.Size(150, 20)
        Me.Label_father_name.TabIndex = 81
        Me.Label_father_name.Text = "Label_father_name"
        '
        'Label_lastname
        '
        Me.Label_lastname.Location = New System.Drawing.Point(15, 105)
        Me.Label_lastname.Name = "Label_lastname"
        Me.Label_lastname.Size = New System.Drawing.Size(150, 20)
        Me.Label_lastname.TabIndex = 80
        Me.Label_lastname.Text = "Label_lastname"
        '
        'Label_name
        '
        Me.Label_name.Location = New System.Drawing.Point(15, 30)
        Me.Label_name.Name = "Label_name"
        Me.Label_name.Size = New System.Drawing.Size(150, 20)
        Me.Label_name.TabIndex = 79
        Me.Label_name.Text = "Label_name"
        '
        'PictureBox_fingerprint
        '
        Me.PictureBox_fingerprint.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.fingerprint
        Me.PictureBox_fingerprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_fingerprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_fingerprint.Location = New System.Drawing.Point(775, 338)
        Me.PictureBox_fingerprint.Name = "PictureBox_fingerprint"
        Me.PictureBox_fingerprint.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox_fingerprint.TabIndex = 89
        Me.PictureBox_fingerprint.TabStop = False
        '
        'ComboBox_blood_type
        '
        Me.ComboBox_blood_type.BackColor = System.Drawing.Color.Silver
        Me.ComboBox_blood_type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_blood_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_blood_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_blood_type.FormattingEnabled = True
        Me.ComboBox_blood_type.Items.AddRange(New Object() {"", "O-", "O+", "A-", "A+", "B-", "B+", "AB-", "AB+"})
        Me.ComboBox_blood_type.Location = New System.Drawing.Point(740, 211)
        Me.ComboBox_blood_type.Name = "ComboBox_blood_type"
        Me.ComboBox_blood_type.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_blood_type.TabIndex = 12
        '
        'Label_blood_type
        '
        Me.Label_blood_type.Location = New System.Drawing.Point(740, 190)
        Me.Label_blood_type.Name = "Label_blood_type"
        Me.Label_blood_type.Size = New System.Drawing.Size(150, 20)
        Me.Label_blood_type.TabIndex = 94
        Me.Label_blood_type.Text = "Label_blood_type"
        '
        'PictureBox_patient_image
        '
        Me.PictureBox_patient_image.BackColor = System.Drawing.Color.Silver
        Me.PictureBox_patient_image.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_patient_image.Image = CType(resources.GetObject("PictureBox_patient_image.Image"), System.Drawing.Image)
        Me.PictureBox_patient_image.Location = New System.Drawing.Point(740, 127)
        Me.PictureBox_patient_image.Name = "PictureBox_patient_image"
        Me.PictureBox_patient_image.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox_patient_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_patient_image.TabIndex = 93
        Me.PictureBox_patient_image.TabStop = False
        '
        'Label_patient_image
        '
        Me.Label_patient_image.Location = New System.Drawing.Point(740, 105)
        Me.Label_patient_image.Name = "Label_patient_image"
        Me.Label_patient_image.Size = New System.Drawing.Size(150, 20)
        Me.Label_patient_image.TabIndex = 92
        Me.Label_patient_image.Text = "Label_image"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'ComboBox_shift
        '
        Me.ComboBox_shift.BackColor = System.Drawing.Color.Silver
        Me.ComboBox_shift.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_shift.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_shift.FormattingEnabled = True
        Me.ComboBox_shift.Location = New System.Drawing.Point(740, 296)
        Me.ComboBox_shift.Name = "ComboBox_shift"
        Me.ComboBox_shift.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_shift.TabIndex = 95
        '
        'Label_shift
        '
        Me.Label_shift.Location = New System.Drawing.Point(740, 275)
        Me.Label_shift.Name = "Label_shift"
        Me.Label_shift.Size = New System.Drawing.Size(150, 20)
        Me.Label_shift.TabIndex = 96
        Me.Label_shift.Text = "Label_shift"
        '
        'PictureBox_delete_image
        '
        Me.PictureBox_delete_image.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.cancel
        Me.PictureBox_delete_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_delete_image.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_delete_image.Location = New System.Drawing.Point(796, 142)
        Me.PictureBox_delete_image.Name = "PictureBox_delete_image"
        Me.PictureBox_delete_image.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_delete_image.TabIndex = 97
        Me.PictureBox_delete_image.TabStop = False
        '
        'Form_edit_patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.PictureBox_delete_image)
        Me.Controls.Add(Me.ComboBox_shift)
        Me.Controls.Add(Me.Label_shift)
        Me.Controls.Add(Me.ComboBox_blood_type)
        Me.Controls.Add(Me.Label_blood_type)
        Me.Controls.Add(Me.PictureBox_patient_image)
        Me.Controls.Add(Me.Label_patient_image)
        Me.Controls.Add(Me.MaskedTextBox_enroll_date)
        Me.Controls.Add(Me.MaskedTextBox_birth_date)
        Me.Controls.Add(Me.MaskedTextBox_id_code)
        Me.Controls.Add(Me.MaskedTextBox_home_number)
        Me.Controls.Add(Me.MaskedTextBox_mobile_number)
        Me.Controls.Add(Me.TextBox_dr_name)
        Me.Controls.Add(Me.Label_dr_name)
        Me.Controls.Add(Me.Label_fingerprint_status)
        Me.Controls.Add(Me.Button_cancell)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.RadioButton_female)
        Me.Controls.Add(Me.RadioButton_male)
        Me.Controls.Add(Me.NumericUpDown_hieght)
        Me.Controls.Add(Me.PictureBox_fingerprint)
        Me.Controls.Add(Me.TextBox_father_name)
        Me.Controls.Add(Me.TextBox_lastname)
        Me.Controls.Add(Me.TextBox_name)
        Me.Controls.Add(Me.Label_enroll_date)
        Me.Controls.Add(Me.Label_hieght)
        Me.Controls.Add(Me.Label_gender)
        Me.Controls.Add(Me.Label_home_number)
        Me.Controls.Add(Me.Label_mbile_number)
        Me.Controls.Add(Me.Label_id_code)
        Me.Controls.Add(Me.Label_birth_date)
        Me.Controls.Add(Me.Label_father_name)
        Me.Controls.Add(Me.Label_lastname)
        Me.Controls.Add(Me.Label_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_edit_patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Patient"
        CType(Me.NumericUpDown_hieght, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_fingerprint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_patient_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_delete_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaskedTextBox_enroll_date As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_birth_date As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_id_code As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_home_number As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_mobile_number As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox_dr_name As System.Windows.Forms.TextBox
    Friend WithEvents Label_dr_name As System.Windows.Forms.Label
    Friend WithEvents Label_fingerprint_status As System.Windows.Forms.Label
    Friend WithEvents Button_cancell As System.Windows.Forms.Button
    Friend WithEvents Button_edit As System.Windows.Forms.Button
    Friend WithEvents RadioButton_female As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_male As System.Windows.Forms.RadioButton
    Friend WithEvents NumericUpDown_hieght As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox_fingerprint As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_father_name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_lastname As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_name As System.Windows.Forms.TextBox
    Friend WithEvents Label_enroll_date As System.Windows.Forms.Label
    Friend WithEvents Label_hieght As System.Windows.Forms.Label
    Friend WithEvents Label_gender As System.Windows.Forms.Label
    Friend WithEvents Label_home_number As System.Windows.Forms.Label
    Friend WithEvents Label_mbile_number As System.Windows.Forms.Label
    Friend WithEvents Label_id_code As System.Windows.Forms.Label
    Friend WithEvents Label_birth_date As System.Windows.Forms.Label
    Friend WithEvents Label_father_name As System.Windows.Forms.Label
    Friend WithEvents Label_lastname As System.Windows.Forms.Label
    Friend WithEvents Label_name As System.Windows.Forms.Label
    Friend WithEvents ComboBox_blood_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label_blood_type As System.Windows.Forms.Label
    Friend WithEvents PictureBox_patient_image As System.Windows.Forms.PictureBox
    Friend WithEvents Label_patient_image As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ComboBox_shift As System.Windows.Forms.ComboBox
    Friend WithEvents Label_shift As System.Windows.Forms.Label
    Friend WithEvents PictureBox_delete_image As System.Windows.Forms.PictureBox
End Class
