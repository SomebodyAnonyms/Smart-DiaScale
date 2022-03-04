<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_setting
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_setting))
        Me.Timer_connection_status = New System.Windows.Forms.Timer(Me.components)
        Me.Label_connection_status = New System.Windows.Forms.Label()
        Me.Label_title_devices = New System.Windows.Forms.Label()
        Me.Button_connect = New System.Windows.Forms.Button()
        Me.TabPage_devices = New System.Windows.Forms.TabPage()
        Me.ComboBox_ListPort = New System.Windows.Forms.ComboBox()
        Me.Label_trying_to_connect = New System.Windows.Forms.Label()
        Me.Label_auto_connection = New System.Windows.Forms.Label()
        Me.PictureBox_auto_connection = New System.Windows.Forms.PictureBox()
        Me.PictureBox_trying_to_connect = New System.Windows.Forms.PictureBox()
        Me.Label_title_hospital = New System.Windows.Forms.Label()
        Me.Button_change_setting_table = New System.Windows.Forms.Button()
        Me.NumericUpDown_dialysis_time = New System.Windows.Forms.NumericUpDown()
        Me.MaskedTextBox_hospital_tel = New System.Windows.Forms.MaskedTextBox()
        Me.RadioButton_persian_language = New System.Windows.Forms.RadioButton()
        Me.TextBox_hospital_address = New System.Windows.Forms.TextBox()
        Me.TextBox_hospital_name = New System.Windows.Forms.TextBox()
        Me.Label_dialysis_time = New System.Windows.Forms.Label()
        Me.Label_hospital_tel = New System.Windows.Forms.Label()
        Me.Label_hospital_address = New System.Windows.Forms.Label()
        Me.Label_hospital_name = New System.Windows.Forms.Label()
        Me.Button_change_language = New System.Windows.Forms.Button()
        Me.Label_title_language = New System.Windows.Forms.Label()
        Me.RadioButton_english_language = New System.Windows.Forms.RadioButton()
        Me.TabPage_language = New System.Windows.Forms.TabPage()
        Me.RadioButton_spanish_language = New System.Windows.Forms.RadioButton()
        Me.PictureBox_spanish_language = New System.Windows.Forms.PictureBox()
        Me.RadioButton_arabic_language = New System.Windows.Forms.RadioButton()
        Me.PictureBox_arabic_language = New System.Windows.Forms.PictureBox()
        Me.PictureBox_persian_language = New System.Windows.Forms.PictureBox()
        Me.PictureBox_english_language = New System.Windows.Forms.PictureBox()
        Me.TabPage_hospital = New System.Windows.Forms.TabPage()
        Me.TabControl_setting = New System.Windows.Forms.TabControl()
        Me.TabPage_scale_setting = New System.Windows.Forms.TabPage()
        Me.PictureBox_calibrate_cancel = New System.Windows.Forms.PictureBox()
        Me.Label_offset_help = New System.Windows.Forms.Label()
        Me.Button_offset = New System.Windows.Forms.Button()
        Me.Label_title_offset = New System.Windows.Forms.Label()
        Me.TextBox_calibrate = New System.Windows.Forms.TextBox()
        Me.Label_calibrate_help = New System.Windows.Forms.Label()
        Me.Button_calibrate = New System.Windows.Forms.Button()
        Me.Label_calibrate_explain = New System.Windows.Forms.Label()
        Me.Label_title_calibrate = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PictureBox_offset_help = New System.Windows.Forms.PictureBox()
        Me.PictureBox_calibrate_help = New System.Windows.Forms.PictureBox()
        Me.TabPage_Security = New System.Windows.Forms.TabPage()
        Me.Timer_auto_connection = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_manual_connection = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage_application_username_and_password = New System.Windows.Forms.TabPage()
        Me.TextBox_application_username_and_password_username = New System.Windows.Forms.TextBox()
        Me.TextBox_application_username_and_password_password = New System.Windows.Forms.TextBox()
        Me.Label_application_username_and_password_username = New System.Windows.Forms.Label()
        Me.Label_application_username_and_password_title = New System.Windows.Forms.Label()
        Me.Button_application_username_and_password_done = New System.Windows.Forms.Button()
        Me.Label_application_username_and_password_password = New System.Windows.Forms.Label()
        Me.PictureBox_application_username_and_password_username_visible = New System.Windows.Forms.PictureBox()
        Me.PictureBox_application_username_and_password_password_visible = New System.Windows.Forms.PictureBox()
        Me.TextBox_application_username_and_password_confirm_password = New System.Windows.Forms.TextBox()
        Me.Label_application_username_and_password_confirm_password = New System.Windows.Forms.Label()
        Me.TabPage_Security_Delete = New System.Windows.Forms.TabPage()
        Me.PictureBox_Security_Delete_username_visible = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Security_Delete_password_visible = New System.Windows.Forms.PictureBox()
        Me.TextBox_Security_Delete_username = New System.Windows.Forms.TextBox()
        Me.TextBox_Security_Delete_password = New System.Windows.Forms.TextBox()
        Me.Label_Security_Delete_username = New System.Windows.Forms.Label()
        Me.Label_Security_Delete_title = New System.Windows.Forms.Label()
        Me.Button_Security_Delete_done = New System.Windows.Forms.Button()
        Me.Label_Security_Delete_password = New System.Windows.Forms.Label()
        Me.TextBox_Security_Delete_name = New System.Windows.Forms.TextBox()
        Me.Label_Security_Delete_name = New System.Windows.Forms.Label()
        Me.TabPage_Security_Add = New System.Windows.Forms.TabPage()
        Me.TextBox_Security_Add_username = New System.Windows.Forms.TextBox()
        Me.TextBox_Security_Add_password = New System.Windows.Forms.TextBox()
        Me.Label_Security_Add_username = New System.Windows.Forms.Label()
        Me.Label_Security_Add_title = New System.Windows.Forms.Label()
        Me.Button_Security_Add_done = New System.Windows.Forms.Button()
        Me.Label_Security_Add_password = New System.Windows.Forms.Label()
        Me.PictureBox_Security_Add_username_visible = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Security_Add_password_visible = New System.Windows.Forms.PictureBox()
        Me.TextBox_Security_Add_confirm_password = New System.Windows.Forms.TextBox()
        Me.Label_Security_Add_confirm_password = New System.Windows.Forms.Label()
        Me.TextBox_Security_Add_name = New System.Windows.Forms.TextBox()
        Me.Label_Security_Add_name = New System.Windows.Forms.Label()
        Me.TabControl_Security = New System.Windows.Forms.TabControl()
        Me.TabPage_devices.SuspendLayout()
        CType(Me.PictureBox_auto_connection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_trying_to_connect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dialysis_time, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_language.SuspendLayout()
        CType(Me.PictureBox_spanish_language, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_arabic_language, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_persian_language, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_english_language, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_hospital.SuspendLayout()
        Me.TabControl_setting.SuspendLayout()
        Me.TabPage_scale_setting.SuspendLayout()
        CType(Me.PictureBox_calibrate_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_offset_help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_calibrate_help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Security.SuspendLayout()
        Me.TabPage_application_username_and_password.SuspendLayout()
        CType(Me.PictureBox_application_username_and_password_username_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_application_username_and_password_password_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Security_Delete.SuspendLayout()
        CType(Me.PictureBox_Security_Delete_username_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Security_Delete_password_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Security_Add.SuspendLayout()
        CType(Me.PictureBox_Security_Add_username_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Security_Add_password_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_Security.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_connection_status
        '
        Me.Timer_connection_status.Enabled = True
        '
        'Label_connection_status
        '
        Me.Label_connection_status.Location = New System.Drawing.Point(208, 246)
        Me.Label_connection_status.Name = "Label_connection_status"
        Me.Label_connection_status.Size = New System.Drawing.Size(400, 25)
        Me.Label_connection_status.TabIndex = 37
        Me.Label_connection_status.Text = "Label_connection_status"
        Me.Label_connection_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_title_devices
        '
        Me.Label_title_devices.Location = New System.Drawing.Point(20, 16)
        Me.Label_title_devices.Name = "Label_title_devices"
        Me.Label_title_devices.Size = New System.Drawing.Size(776, 50)
        Me.Label_title_devices.TabIndex = 36
        Me.Label_title_devices.Text = "Label_title_devices"
        Me.Label_title_devices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_connect
        '
        Me.Button_connect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_connect.Location = New System.Drawing.Point(345, 168)
        Me.Button_connect.Name = "Button_connect"
        Me.Button_connect.Size = New System.Drawing.Size(125, 27)
        Me.Button_connect.TabIndex = 1
        Me.Button_connect.Text = "Button_connect"
        Me.Button_connect.UseVisualStyleBackColor = True
        '
        'TabPage_devices
        '
        Me.TabPage_devices.Controls.Add(Me.ComboBox_ListPort)
        Me.TabPage_devices.Controls.Add(Me.Label_trying_to_connect)
        Me.TabPage_devices.Controls.Add(Me.Label_auto_connection)
        Me.TabPage_devices.Controls.Add(Me.Label_connection_status)
        Me.TabPage_devices.Controls.Add(Me.Label_title_devices)
        Me.TabPage_devices.Controls.Add(Me.Button_connect)
        Me.TabPage_devices.Controls.Add(Me.PictureBox_auto_connection)
        Me.TabPage_devices.Controls.Add(Me.PictureBox_trying_to_connect)
        Me.TabPage_devices.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_devices.Name = "TabPage_devices"
        Me.TabPage_devices.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_devices.Size = New System.Drawing.Size(808, 364)
        Me.TabPage_devices.TabIndex = 2
        Me.TabPage_devices.Text = "devices"
        Me.TabPage_devices.UseVisualStyleBackColor = True
        '
        'ComboBox_ListPort
        '
        Me.ComboBox_ListPort.BackColor = System.Drawing.Color.Silver
        Me.ComboBox_ListPort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_ListPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_ListPort.FormattingEnabled = True
        Me.ComboBox_ListPort.Location = New System.Drawing.Point(345, 201)
        Me.ComboBox_ListPort.Name = "ComboBox_ListPort"
        Me.ComboBox_ListPort.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox_ListPort.TabIndex = 70
        '
        'Label_trying_to_connect
        '
        Me.Label_trying_to_connect.AutoSize = True
        Me.Label_trying_to_connect.Location = New System.Drawing.Point(346, 343)
        Me.Label_trying_to_connect.Name = "Label_trying_to_connect"
        Me.Label_trying_to_connect.Size = New System.Drawing.Size(124, 13)
        Me.Label_trying_to_connect.TabIndex = 41
        Me.Label_trying_to_connect.Text = "Label_trying_to_connect"
        Me.Label_trying_to_connect.Visible = False
        '
        'Label_auto_connection
        '
        Me.Label_auto_connection.AutoSize = True
        Me.Label_auto_connection.BackColor = System.Drawing.Color.Transparent
        Me.Label_auto_connection.Location = New System.Drawing.Point(326, 293)
        Me.Label_auto_connection.Name = "Label_auto_connection"
        Me.Label_auto_connection.Size = New System.Drawing.Size(119, 13)
        Me.Label_auto_connection.TabIndex = 38
        Me.Label_auto_connection.Text = "Label_auto_connection"
        Me.Label_auto_connection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox_auto_connection
        '
        Me.PictureBox_auto_connection.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_auto_connection.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.switch__4_
        Me.PictureBox_auto_connection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_auto_connection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_auto_connection.Location = New System.Drawing.Point(451, 285)
        Me.PictureBox_auto_connection.Name = "PictureBox_auto_connection"
        Me.PictureBox_auto_connection.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox_auto_connection.TabIndex = 39
        Me.PictureBox_auto_connection.TabStop = False
        '
        'PictureBox_trying_to_connect
        '
        Me.PictureBox_trying_to_connect.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_trying_to_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_trying_to_connect.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox_trying_to_connect.Image = Global.Smart_DiaScale_I.My.Resources.Resources.loading
        Me.PictureBox_trying_to_connect.Location = New System.Drawing.Point(375, 286)
        Me.PictureBox_trying_to_connect.Name = "PictureBox_trying_to_connect"
        Me.PictureBox_trying_to_connect.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox_trying_to_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_trying_to_connect.TabIndex = 40
        Me.PictureBox_trying_to_connect.TabStop = False
        Me.PictureBox_trying_to_connect.Visible = False
        '
        'Label_title_hospital
        '
        Me.Label_title_hospital.Location = New System.Drawing.Point(16, 16)
        Me.Label_title_hospital.Name = "Label_title_hospital"
        Me.Label_title_hospital.Size = New System.Drawing.Size(776, 50)
        Me.Label_title_hospital.TabIndex = 35
        Me.Label_title_hospital.Text = "Label_title_hospital"
        Me.Label_title_hospital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_change_setting_table
        '
        Me.Button_change_setting_table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_change_setting_table.Location = New System.Drawing.Point(342, 321)
        Me.Button_change_setting_table.Name = "Button_change_setting_table"
        Me.Button_change_setting_table.Size = New System.Drawing.Size(125, 27)
        Me.Button_change_setting_table.TabIndex = 5
        Me.Button_change_setting_table.Text = "change_setting_table"
        Me.Button_change_setting_table.UseVisualStyleBackColor = True
        '
        'NumericUpDown_dialysis_time
        '
        Me.NumericUpDown_dialysis_time.Location = New System.Drawing.Point(739, 256)
        Me.NumericUpDown_dialysis_time.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.NumericUpDown_dialysis_time.Name = "NumericUpDown_dialysis_time"
        Me.NumericUpDown_dialysis_time.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDown_dialysis_time.TabIndex = 4
        Me.NumericUpDown_dialysis_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox_hospital_tel
        '
        Me.MaskedTextBox_hospital_tel.Location = New System.Drawing.Point(19, 256)
        Me.MaskedTextBox_hospital_tel.Mask = "00000000000"
        Me.MaskedTextBox_hospital_tel.Name = "MaskedTextBox_hospital_tel"
        Me.MaskedTextBox_hospital_tel.Size = New System.Drawing.Size(80, 20)
        Me.MaskedTextBox_hospital_tel.TabIndex = 3
        Me.MaskedTextBox_hospital_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton_persian_language
        '
        Me.RadioButton_persian_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_persian_language.Location = New System.Drawing.Point(283, 227)
        Me.RadioButton_persian_language.Name = "RadioButton_persian_language"
        Me.RadioButton_persian_language.Size = New System.Drawing.Size(100, 25)
        Me.RadioButton_persian_language.TabIndex = 2
        Me.RadioButton_persian_language.Text = "فارسی"
        Me.RadioButton_persian_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_persian_language.UseVisualStyleBackColor = True
        '
        'TextBox_hospital_address
        '
        Me.TextBox_hospital_address.Location = New System.Drawing.Point(589, 121)
        Me.TextBox_hospital_address.Name = "TextBox_hospital_address"
        Me.TextBox_hospital_address.Size = New System.Drawing.Size(200, 20)
        Me.TextBox_hospital_address.TabIndex = 2
        Me.TextBox_hospital_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_hospital_name
        '
        Me.TextBox_hospital_name.Location = New System.Drawing.Point(19, 121)
        Me.TextBox_hospital_name.Name = "TextBox_hospital_name"
        Me.TextBox_hospital_name.Size = New System.Drawing.Size(200, 20)
        Me.TextBox_hospital_name.TabIndex = 1
        Me.TextBox_hospital_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_dialysis_time
        '
        Me.Label_dialysis_time.Location = New System.Drawing.Point(589, 226)
        Me.Label_dialysis_time.Name = "Label_dialysis_time"
        Me.Label_dialysis_time.Size = New System.Drawing.Size(200, 25)
        Me.Label_dialysis_time.TabIndex = 29
        Me.Label_dialysis_time.Text = "Label_dialysis_time"
        Me.Label_dialysis_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_hospital_tel
        '
        Me.Label_hospital_tel.Location = New System.Drawing.Point(19, 226)
        Me.Label_hospital_tel.Name = "Label_hospital_tel"
        Me.Label_hospital_tel.Size = New System.Drawing.Size(200, 25)
        Me.Label_hospital_tel.TabIndex = 28
        Me.Label_hospital_tel.Text = "Label_hospital_tel"
        Me.Label_hospital_tel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_hospital_address
        '
        Me.Label_hospital_address.Location = New System.Drawing.Point(589, 91)
        Me.Label_hospital_address.Name = "Label_hospital_address"
        Me.Label_hospital_address.Size = New System.Drawing.Size(200, 25)
        Me.Label_hospital_address.TabIndex = 27
        Me.Label_hospital_address.Text = "Label_hospital_address"
        Me.Label_hospital_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_hospital_name
        '
        Me.Label_hospital_name.Location = New System.Drawing.Point(19, 91)
        Me.Label_hospital_name.Name = "Label_hospital_name"
        Me.Label_hospital_name.Size = New System.Drawing.Size(200, 25)
        Me.Label_hospital_name.TabIndex = 26
        Me.Label_hospital_name.Text = "Label_hospital_name"
        Me.Label_hospital_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_change_language
        '
        Me.Button_change_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_change_language.Location = New System.Drawing.Point(342, 321)
        Me.Button_change_language.Name = "Button_change_language"
        Me.Button_change_language.Size = New System.Drawing.Size(125, 27)
        Me.Button_change_language.TabIndex = 3
        Me.Button_change_language.Text = "change_language"
        Me.Button_change_language.UseVisualStyleBackColor = True
        '
        'Label_title_language
        '
        Me.Label_title_language.Location = New System.Drawing.Point(16, 16)
        Me.Label_title_language.Name = "Label_title_language"
        Me.Label_title_language.Size = New System.Drawing.Size(776, 50)
        Me.Label_title_language.TabIndex = 12
        Me.Label_title_language.Text = "Label_title_language"
        Me.Label_title_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton_english_language
        '
        Me.RadioButton_english_language.Checked = True
        Me.RadioButton_english_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_english_language.Location = New System.Drawing.Point(133, 227)
        Me.RadioButton_english_language.Name = "RadioButton_english_language"
        Me.RadioButton_english_language.Size = New System.Drawing.Size(100, 25)
        Me.RadioButton_english_language.TabIndex = 1
        Me.RadioButton_english_language.TabStop = True
        Me.RadioButton_english_language.Text = "English (USA)"
        Me.RadioButton_english_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_english_language.UseVisualStyleBackColor = True
        '
        'TabPage_language
        '
        Me.TabPage_language.Controls.Add(Me.RadioButton_spanish_language)
        Me.TabPage_language.Controls.Add(Me.PictureBox_spanish_language)
        Me.TabPage_language.Controls.Add(Me.RadioButton_arabic_language)
        Me.TabPage_language.Controls.Add(Me.PictureBox_arabic_language)
        Me.TabPage_language.Controls.Add(Me.Button_change_language)
        Me.TabPage_language.Controls.Add(Me.Label_title_language)
        Me.TabPage_language.Controls.Add(Me.RadioButton_english_language)
        Me.TabPage_language.Controls.Add(Me.RadioButton_persian_language)
        Me.TabPage_language.Controls.Add(Me.PictureBox_persian_language)
        Me.TabPage_language.Controls.Add(Me.PictureBox_english_language)
        Me.TabPage_language.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_language.Name = "TabPage_language"
        Me.TabPage_language.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_language.Size = New System.Drawing.Size(808, 364)
        Me.TabPage_language.TabIndex = 0
        Me.TabPage_language.Text = "language"
        Me.TabPage_language.UseVisualStyleBackColor = True
        '
        'RadioButton_spanish_language
        '
        Me.RadioButton_spanish_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_spanish_language.Location = New System.Drawing.Point(583, 227)
        Me.RadioButton_spanish_language.Name = "RadioButton_spanish_language"
        Me.RadioButton_spanish_language.Size = New System.Drawing.Size(100, 25)
        Me.RadioButton_spanish_language.TabIndex = 19
        Me.RadioButton_spanish_language.Text = "Español"
        Me.RadioButton_spanish_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_spanish_language.UseVisualStyleBackColor = True
        '
        'PictureBox_spanish_language
        '
        Me.PictureBox_spanish_language.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.spain
        Me.PictureBox_spanish_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_spanish_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_spanish_language.Location = New System.Drawing.Point(583, 141)
        Me.PictureBox_spanish_language.Name = "PictureBox_spanish_language"
        Me.PictureBox_spanish_language.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox_spanish_language.TabIndex = 20
        Me.PictureBox_spanish_language.TabStop = False
        '
        'RadioButton_arabic_language
        '
        Me.RadioButton_arabic_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_arabic_language.Location = New System.Drawing.Point(433, 227)
        Me.RadioButton_arabic_language.Name = "RadioButton_arabic_language"
        Me.RadioButton_arabic_language.Size = New System.Drawing.Size(100, 25)
        Me.RadioButton_arabic_language.TabIndex = 17
        Me.RadioButton_arabic_language.Text = "عربی"
        Me.RadioButton_arabic_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_arabic_language.UseVisualStyleBackColor = True
        '
        'PictureBox_arabic_language
        '
        Me.PictureBox_arabic_language.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.saudi_arabia
        Me.PictureBox_arabic_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_arabic_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_arabic_language.Location = New System.Drawing.Point(433, 141)
        Me.PictureBox_arabic_language.Name = "PictureBox_arabic_language"
        Me.PictureBox_arabic_language.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox_arabic_language.TabIndex = 18
        Me.PictureBox_arabic_language.TabStop = False
        '
        'PictureBox_persian_language
        '
        Me.PictureBox_persian_language.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.iran
        Me.PictureBox_persian_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_persian_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_persian_language.Location = New System.Drawing.Point(283, 141)
        Me.PictureBox_persian_language.Name = "PictureBox_persian_language"
        Me.PictureBox_persian_language.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox_persian_language.TabIndex = 9
        Me.PictureBox_persian_language.TabStop = False
        '
        'PictureBox_english_language
        '
        Me.PictureBox_english_language.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.usa
        Me.PictureBox_english_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_english_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_english_language.Location = New System.Drawing.Point(133, 141)
        Me.PictureBox_english_language.Name = "PictureBox_english_language"
        Me.PictureBox_english_language.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox_english_language.TabIndex = 8
        Me.PictureBox_english_language.TabStop = False
        '
        'TabPage_hospital
        '
        Me.TabPage_hospital.Controls.Add(Me.Label_title_hospital)
        Me.TabPage_hospital.Controls.Add(Me.Button_change_setting_table)
        Me.TabPage_hospital.Controls.Add(Me.NumericUpDown_dialysis_time)
        Me.TabPage_hospital.Controls.Add(Me.MaskedTextBox_hospital_tel)
        Me.TabPage_hospital.Controls.Add(Me.TextBox_hospital_address)
        Me.TabPage_hospital.Controls.Add(Me.TextBox_hospital_name)
        Me.TabPage_hospital.Controls.Add(Me.Label_dialysis_time)
        Me.TabPage_hospital.Controls.Add(Me.Label_hospital_tel)
        Me.TabPage_hospital.Controls.Add(Me.Label_hospital_address)
        Me.TabPage_hospital.Controls.Add(Me.Label_hospital_name)
        Me.TabPage_hospital.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_hospital.Name = "TabPage_hospital"
        Me.TabPage_hospital.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_hospital.Size = New System.Drawing.Size(808, 364)
        Me.TabPage_hospital.TabIndex = 1
        Me.TabPage_hospital.Text = "hospital"
        Me.TabPage_hospital.UseVisualStyleBackColor = True
        '
        'TabControl_setting
        '
        Me.TabControl_setting.Controls.Add(Me.TabPage_language)
        Me.TabControl_setting.Controls.Add(Me.TabPage_hospital)
        Me.TabControl_setting.Controls.Add(Me.TabPage_devices)
        Me.TabControl_setting.Controls.Add(Me.TabPage_scale_setting)
        Me.TabControl_setting.Controls.Add(Me.TabPage_Security)
        Me.TabControl_setting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_setting.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_setting.Name = "TabControl_setting"
        Me.TabControl_setting.SelectedIndex = 0
        Me.TabControl_setting.Size = New System.Drawing.Size(816, 390)
        Me.TabControl_setting.TabIndex = 1
        '
        'TabPage_scale_setting
        '
        Me.TabPage_scale_setting.Controls.Add(Me.PictureBox_calibrate_cancel)
        Me.TabPage_scale_setting.Controls.Add(Me.Label_offset_help)
        Me.TabPage_scale_setting.Controls.Add(Me.Button_offset)
        Me.TabPage_scale_setting.Controls.Add(Me.Label_title_offset)
        Me.TabPage_scale_setting.Controls.Add(Me.TextBox_calibrate)
        Me.TabPage_scale_setting.Controls.Add(Me.Label_calibrate_help)
        Me.TabPage_scale_setting.Controls.Add(Me.Button_calibrate)
        Me.TabPage_scale_setting.Controls.Add(Me.Label_calibrate_explain)
        Me.TabPage_scale_setting.Controls.Add(Me.Label_title_calibrate)
        Me.TabPage_scale_setting.Controls.Add(Me.ShapeContainer1)
        Me.TabPage_scale_setting.Controls.Add(Me.PictureBox_offset_help)
        Me.TabPage_scale_setting.Controls.Add(Me.PictureBox_calibrate_help)
        Me.TabPage_scale_setting.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_scale_setting.Name = "TabPage_scale_setting"
        Me.TabPage_scale_setting.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_scale_setting.Size = New System.Drawing.Size(808, 364)
        Me.TabPage_scale_setting.TabIndex = 3
        Me.TabPage_scale_setting.Text = "calibrate"
        Me.TabPage_scale_setting.UseVisualStyleBackColor = True
        '
        'PictureBox_calibrate_cancel
        '
        Me.PictureBox_calibrate_cancel.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.cancel
        Me.PictureBox_calibrate_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_calibrate_cancel.Location = New System.Drawing.Point(295, 204)
        Me.PictureBox_calibrate_cancel.Name = "PictureBox_calibrate_cancel"
        Me.PictureBox_calibrate_cancel.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_calibrate_cancel.TabIndex = 50
        Me.PictureBox_calibrate_cancel.TabStop = False
        '
        'Label_offset_help
        '
        Me.Label_offset_help.ForeColor = System.Drawing.Color.Red
        Me.Label_offset_help.Location = New System.Drawing.Point(490, 262)
        Me.Label_offset_help.Name = "Label_offset_help"
        Me.Label_offset_help.Size = New System.Drawing.Size(308, 97)
        Me.Label_offset_help.TabIndex = 49
        Me.Label_offset_help.Text = "Label_offset_help"
        Me.Label_offset_help.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label_offset_help.Visible = False
        '
        'Button_offset
        '
        Me.Button_offset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_offset.Location = New System.Drawing.Point(581, 201)
        Me.Button_offset.Name = "Button_offset"
        Me.Button_offset.Size = New System.Drawing.Size(125, 27)
        Me.Button_offset.TabIndex = 47
        Me.Button_offset.Text = "offset"
        Me.Button_offset.UseVisualStyleBackColor = True
        '
        'Label_title_offset
        '
        Me.Label_title_offset.Location = New System.Drawing.Point(490, 10)
        Me.Label_title_offset.Name = "Label_title_offset"
        Me.Label_title_offset.Size = New System.Drawing.Size(308, 50)
        Me.Label_title_offset.TabIndex = 46
        Me.Label_title_offset.Text = "Label_title_offset"
        Me.Label_title_offset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_calibrate
        '
        Me.TextBox_calibrate.Location = New System.Drawing.Point(180, 175)
        Me.TextBox_calibrate.MaxLength = 7
        Me.TextBox_calibrate.Name = "TextBox_calibrate"
        Me.TextBox_calibrate.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_calibrate.TabIndex = 44
        Me.TextBox_calibrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox_calibrate.Visible = False
        '
        'Label_calibrate_help
        '
        Me.Label_calibrate_help.ForeColor = System.Drawing.Color.Red
        Me.Label_calibrate_help.Location = New System.Drawing.Point(20, 262)
        Me.Label_calibrate_help.Name = "Label_calibrate_help"
        Me.Label_calibrate_help.Size = New System.Drawing.Size(420, 97)
        Me.Label_calibrate_help.TabIndex = 43
        Me.Label_calibrate_help.Text = "Label_calibrate_help"
        Me.Label_calibrate_help.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label_calibrate_help.Visible = False
        '
        'Button_calibrate
        '
        Me.Button_calibrate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_calibrate.Location = New System.Drawing.Point(167, 201)
        Me.Button_calibrate.Name = "Button_calibrate"
        Me.Button_calibrate.Size = New System.Drawing.Size(125, 27)
        Me.Button_calibrate.TabIndex = 41
        Me.Button_calibrate.Text = "calibrate"
        Me.Button_calibrate.UseVisualStyleBackColor = True
        '
        'Label_calibrate_explain
        '
        Me.Label_calibrate_explain.Location = New System.Drawing.Point(20, 147)
        Me.Label_calibrate_explain.Name = "Label_calibrate_explain"
        Me.Label_calibrate_explain.Size = New System.Drawing.Size(420, 25)
        Me.Label_calibrate_explain.TabIndex = 39
        Me.Label_calibrate_explain.Text = "Label_calibrate_explain"
        Me.Label_calibrate_explain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_calibrate_explain.Visible = False
        '
        'Label_title_calibrate
        '
        Me.Label_title_calibrate.Location = New System.Drawing.Point(20, 10)
        Me.Label_title_calibrate.Name = "Label_title_calibrate"
        Me.Label_title_calibrate.Size = New System.Drawing.Size(420, 50)
        Me.Label_title_calibrate.TabIndex = 37
        Me.Label_title_calibrate.Text = "Label_title_calibrate"
        Me.Label_title_calibrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(802, 358)
        Me.ShapeContainer1.TabIndex = 45
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 460
        Me.LineShape1.X2 = 460
        Me.LineShape1.Y1 = 7
        Me.LineShape1.Y2 = 352
        '
        'PictureBox_offset_help
        '
        Me.PictureBox_offset_help.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.help
        Me.PictureBox_offset_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_offset_help.Location = New System.Drawing.Point(634, 234)
        Me.PictureBox_offset_help.Name = "PictureBox_offset_help"
        Me.PictureBox_offset_help.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_offset_help.TabIndex = 48
        Me.PictureBox_offset_help.TabStop = False
        '
        'PictureBox_calibrate_help
        '
        Me.PictureBox_calibrate_help.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.help
        Me.PictureBox_calibrate_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_calibrate_help.Location = New System.Drawing.Point(220, 234)
        Me.PictureBox_calibrate_help.Name = "PictureBox_calibrate_help"
        Me.PictureBox_calibrate_help.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_calibrate_help.TabIndex = 42
        Me.PictureBox_calibrate_help.TabStop = False
        '
        'TabPage_Security
        '
        Me.TabPage_Security.Controls.Add(Me.TabControl_Security)
        Me.TabPage_Security.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Security.Name = "TabPage_Security"
        Me.TabPage_Security.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Security.Size = New System.Drawing.Size(808, 364)
        Me.TabPage_Security.TabIndex = 4
        Me.TabPage_Security.Text = "Security"
        Me.TabPage_Security.UseVisualStyleBackColor = True
        '
        'Timer_auto_connection
        '
        Me.Timer_auto_connection.Interval = 5000
        '
        'Timer_manual_connection
        '
        Me.Timer_manual_connection.Interval = 5000
        '
        'TabPage_application_username_and_password
        '
        Me.TabPage_application_username_and_password.Controls.Add(Me.Label_application_username_and_password_confirm_password)
        Me.TabPage_application_username_and_password.Controls.Add(Me.TextBox_application_username_and_password_confirm_password)
        Me.TabPage_application_username_and_password.Controls.Add(Me.PictureBox_application_username_and_password_password_visible)
        Me.TabPage_application_username_and_password.Controls.Add(Me.PictureBox_application_username_and_password_username_visible)
        Me.TabPage_application_username_and_password.Controls.Add(Me.Label_application_username_and_password_password)
        Me.TabPage_application_username_and_password.Controls.Add(Me.Button_application_username_and_password_done)
        Me.TabPage_application_username_and_password.Controls.Add(Me.Label_application_username_and_password_title)
        Me.TabPage_application_username_and_password.Controls.Add(Me.Label_application_username_and_password_username)
        Me.TabPage_application_username_and_password.Controls.Add(Me.TextBox_application_username_and_password_password)
        Me.TabPage_application_username_and_password.Controls.Add(Me.TextBox_application_username_and_password_username)
        Me.TabPage_application_username_and_password.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_application_username_and_password.Name = "TabPage_application_username_and_password"
        Me.TabPage_application_username_and_password.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_application_username_and_password.Size = New System.Drawing.Size(794, 332)
        Me.TabPage_application_username_and_password.TabIndex = 3
        Me.TabPage_application_username_and_password.Text = "Application Username And Password"
        Me.TabPage_application_username_and_password.UseVisualStyleBackColor = True
        '
        'TextBox_application_username_and_password_username
        '
        Me.TextBox_application_username_and_password_username.Location = New System.Drawing.Point(322, 126)
        Me.TextBox_application_username_and_password_username.MaxLength = 50
        Me.TextBox_application_username_and_password_username.Name = "TextBox_application_username_and_password_username"
        Me.TextBox_application_username_and_password_username.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_application_username_and_password_username.TabIndex = 0
        '
        'TextBox_application_username_and_password_password
        '
        Me.TextBox_application_username_and_password_password.Location = New System.Drawing.Point(322, 178)
        Me.TextBox_application_username_and_password_password.MaxLength = 50
        Me.TextBox_application_username_and_password_password.Name = "TextBox_application_username_and_password_password"
        Me.TextBox_application_username_and_password_password.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_application_username_and_password_password.TabIndex = 1
        Me.TextBox_application_username_and_password_password.UseSystemPasswordChar = True
        '
        'Label_application_username_and_password_username
        '
        Me.Label_application_username_and_password_username.Location = New System.Drawing.Point(322, 100)
        Me.Label_application_username_and_password_username.Name = "Label_application_username_and_password_username"
        Me.Label_application_username_and_password_username.Size = New System.Drawing.Size(250, 25)
        Me.Label_application_username_and_password_username.TabIndex = 58
        Me.Label_application_username_and_password_username.Text = "Label_application_username_and_password_username"
        Me.Label_application_username_and_password_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_application_username_and_password_title
        '
        Me.Label_application_username_and_password_title.Location = New System.Drawing.Point(9, 10)
        Me.Label_application_username_and_password_title.Name = "Label_application_username_and_password_title"
        Me.Label_application_username_and_password_title.Size = New System.Drawing.Size(776, 50)
        Me.Label_application_username_and_password_title.TabIndex = 59
        Me.Label_application_username_and_password_title.Text = "Label_application_username_and_password_title"
        Me.Label_application_username_and_password_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_application_username_and_password_done
        '
        Me.Button_application_username_and_password_done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_application_username_and_password_done.Location = New System.Drawing.Point(359, 300)
        Me.Button_application_username_and_password_done.Name = "Button_application_username_and_password_done"
        Me.Button_application_username_and_password_done.Size = New System.Drawing.Size(75, 27)
        Me.Button_application_username_and_password_done.TabIndex = 3
        Me.Button_application_username_and_password_done.Text = "Done"
        Me.Button_application_username_and_password_done.UseVisualStyleBackColor = True
        '
        'Label_application_username_and_password_password
        '
        Me.Label_application_username_and_password_password.Location = New System.Drawing.Point(322, 152)
        Me.Label_application_username_and_password_password.Name = "Label_application_username_and_password_password"
        Me.Label_application_username_and_password_password.Size = New System.Drawing.Size(250, 25)
        Me.Label_application_username_and_password_password.TabIndex = 60
        Me.Label_application_username_and_password_password.Text = "Label_application_username_and_password_password"
        Me.Label_application_username_and_password_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_application_username_and_password_username_visible
        '
        Me.PictureBox_application_username_and_password_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible_1_
        Me.PictureBox_application_username_and_password_username_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_application_username_and_password_username_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_application_username_and_password_username_visible.Location = New System.Drawing.Point(478, 126)
        Me.PictureBox_application_username_and_password_username_visible.Name = "PictureBox_application_username_and_password_username_visible"
        Me.PictureBox_application_username_and_password_username_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_application_username_and_password_username_visible.TabIndex = 61
        Me.PictureBox_application_username_and_password_username_visible.TabStop = False
        '
        'PictureBox_application_username_and_password_password_visible
        '
        Me.PictureBox_application_username_and_password_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible
        Me.PictureBox_application_username_and_password_password_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_application_username_and_password_password_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_application_username_and_password_password_visible.Location = New System.Drawing.Point(478, 178)
        Me.PictureBox_application_username_and_password_password_visible.Name = "PictureBox_application_username_and_password_password_visible"
        Me.PictureBox_application_username_and_password_password_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_application_username_and_password_password_visible.TabIndex = 62
        Me.PictureBox_application_username_and_password_password_visible.TabStop = False
        '
        'TextBox_application_username_and_password_confirm_password
        '
        Me.TextBox_application_username_and_password_confirm_password.Location = New System.Drawing.Point(322, 229)
        Me.TextBox_application_username_and_password_confirm_password.MaxLength = 50
        Me.TextBox_application_username_and_password_confirm_password.Name = "TextBox_application_username_and_password_confirm_password"
        Me.TextBox_application_username_and_password_confirm_password.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_application_username_and_password_confirm_password.TabIndex = 2
        Me.TextBox_application_username_and_password_confirm_password.UseSystemPasswordChar = True
        '
        'Label_application_username_and_password_confirm_password
        '
        Me.Label_application_username_and_password_confirm_password.Location = New System.Drawing.Point(322, 203)
        Me.Label_application_username_and_password_confirm_password.Name = "Label_application_username_and_password_confirm_password"
        Me.Label_application_username_and_password_confirm_password.Size = New System.Drawing.Size(250, 25)
        Me.Label_application_username_and_password_confirm_password.TabIndex = 63
        Me.Label_application_username_and_password_confirm_password.Text = "Label_application_username_and_password_confirm_password"
        Me.Label_application_username_and_password_confirm_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage_Security_Delete
        '
        Me.TabPage_Security_Delete.Controls.Add(Me.Label_Security_Delete_name)
        Me.TabPage_Security_Delete.Controls.Add(Me.TextBox_Security_Delete_name)
        Me.TabPage_Security_Delete.Controls.Add(Me.TextBox_Security_Delete_username)
        Me.TabPage_Security_Delete.Controls.Add(Me.Label_Security_Delete_password)
        Me.TabPage_Security_Delete.Controls.Add(Me.Button_Security_Delete_done)
        Me.TabPage_Security_Delete.Controls.Add(Me.Label_Security_Delete_title)
        Me.TabPage_Security_Delete.Controls.Add(Me.Label_Security_Delete_username)
        Me.TabPage_Security_Delete.Controls.Add(Me.TextBox_Security_Delete_password)
        Me.TabPage_Security_Delete.Controls.Add(Me.PictureBox_Security_Delete_password_visible)
        Me.TabPage_Security_Delete.Controls.Add(Me.PictureBox_Security_Delete_username_visible)
        Me.TabPage_Security_Delete.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Security_Delete.Name = "TabPage_Security_Delete"
        Me.TabPage_Security_Delete.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Security_Delete.Size = New System.Drawing.Size(794, 332)
        Me.TabPage_Security_Delete.TabIndex = 1
        Me.TabPage_Security_Delete.Text = "Delete Username and Password"
        Me.TabPage_Security_Delete.UseVisualStyleBackColor = True
        '
        'PictureBox_Security_Delete_username_visible
        '
        Me.PictureBox_Security_Delete_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible_1_
        Me.PictureBox_Security_Delete_username_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_Security_Delete_username_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Security_Delete_username_visible.Location = New System.Drawing.Point(478, 178)
        Me.PictureBox_Security_Delete_username_visible.Name = "PictureBox_Security_Delete_username_visible"
        Me.PictureBox_Security_Delete_username_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_Security_Delete_username_visible.TabIndex = 63
        Me.PictureBox_Security_Delete_username_visible.TabStop = False
        '
        'PictureBox_Security_Delete_password_visible
        '
        Me.PictureBox_Security_Delete_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible
        Me.PictureBox_Security_Delete_password_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_Security_Delete_password_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Security_Delete_password_visible.Location = New System.Drawing.Point(478, 229)
        Me.PictureBox_Security_Delete_password_visible.Name = "PictureBox_Security_Delete_password_visible"
        Me.PictureBox_Security_Delete_password_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_Security_Delete_password_visible.TabIndex = 64
        Me.PictureBox_Security_Delete_password_visible.TabStop = False
        '
        'TextBox_Security_Delete_username
        '
        Me.TextBox_Security_Delete_username.Location = New System.Drawing.Point(322, 178)
        Me.TextBox_Security_Delete_username.MaxLength = 50
        Me.TextBox_Security_Delete_username.Name = "TextBox_Security_Delete_username"
        Me.TextBox_Security_Delete_username.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_Security_Delete_username.TabIndex = 1
        '
        'TextBox_Security_Delete_password
        '
        Me.TextBox_Security_Delete_password.Location = New System.Drawing.Point(322, 229)
        Me.TextBox_Security_Delete_password.MaxLength = 50
        Me.TextBox_Security_Delete_password.Name = "TextBox_Security_Delete_password"
        Me.TextBox_Security_Delete_password.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_Security_Delete_password.TabIndex = 2
        Me.TextBox_Security_Delete_password.UseSystemPasswordChar = True
        '
        'Label_Security_Delete_username
        '
        Me.Label_Security_Delete_username.Location = New System.Drawing.Point(322, 152)
        Me.Label_Security_Delete_username.Name = "Label_Security_Delete_username"
        Me.Label_Security_Delete_username.Size = New System.Drawing.Size(250, 25)
        Me.Label_Security_Delete_username.TabIndex = 60
        Me.Label_Security_Delete_username.Text = "Label_Security_Delete_username"
        Me.Label_Security_Delete_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Security_Delete_title
        '
        Me.Label_Security_Delete_title.Location = New System.Drawing.Point(9, 10)
        Me.Label_Security_Delete_title.Name = "Label_Security_Delete_title"
        Me.Label_Security_Delete_title.Size = New System.Drawing.Size(776, 50)
        Me.Label_Security_Delete_title.TabIndex = 61
        Me.Label_Security_Delete_title.Text = "Label_Security_Delete_title"
        Me.Label_Security_Delete_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Security_Delete_done
        '
        Me.Button_Security_Delete_done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Security_Delete_done.Location = New System.Drawing.Point(359, 300)
        Me.Button_Security_Delete_done.Name = "Button_Security_Delete_done"
        Me.Button_Security_Delete_done.Size = New System.Drawing.Size(75, 27)
        Me.Button_Security_Delete_done.TabIndex = 3
        Me.Button_Security_Delete_done.Text = "Done"
        Me.Button_Security_Delete_done.UseVisualStyleBackColor = True
        '
        'Label_Security_Delete_password
        '
        Me.Label_Security_Delete_password.Location = New System.Drawing.Point(322, 203)
        Me.Label_Security_Delete_password.Name = "Label_Security_Delete_password"
        Me.Label_Security_Delete_password.Size = New System.Drawing.Size(250, 25)
        Me.Label_Security_Delete_password.TabIndex = 62
        Me.Label_Security_Delete_password.Text = "Label_Security_Delete_password"
        Me.Label_Security_Delete_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Security_Delete_name
        '
        Me.TextBox_Security_Delete_name.Location = New System.Drawing.Point(322, 126)
        Me.TextBox_Security_Delete_name.MaxLength = 50
        Me.TextBox_Security_Delete_name.Name = "TextBox_Security_Delete_name"
        Me.TextBox_Security_Delete_name.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_Security_Delete_name.TabIndex = 0
        '
        'Label_Security_Delete_name
        '
        Me.Label_Security_Delete_name.Location = New System.Drawing.Point(322, 100)
        Me.Label_Security_Delete_name.Name = "Label_Security_Delete_name"
        Me.Label_Security_Delete_name.Size = New System.Drawing.Size(250, 25)
        Me.Label_Security_Delete_name.TabIndex = 67
        Me.Label_Security_Delete_name.Text = "Label_Security_Delete_name"
        Me.Label_Security_Delete_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage_Security_Add
        '
        Me.TabPage_Security_Add.Controls.Add(Me.Label_Security_Add_name)
        Me.TabPage_Security_Add.Controls.Add(Me.TextBox_Security_Add_name)
        Me.TabPage_Security_Add.Controls.Add(Me.TextBox_Security_Add_username)
        Me.TabPage_Security_Add.Controls.Add(Me.Label_Security_Add_confirm_password)
        Me.TabPage_Security_Add.Controls.Add(Me.TextBox_Security_Add_confirm_password)
        Me.TabPage_Security_Add.Controls.Add(Me.PictureBox_Security_Add_password_visible)
        Me.TabPage_Security_Add.Controls.Add(Me.PictureBox_Security_Add_username_visible)
        Me.TabPage_Security_Add.Controls.Add(Me.Label_Security_Add_password)
        Me.TabPage_Security_Add.Controls.Add(Me.Button_Security_Add_done)
        Me.TabPage_Security_Add.Controls.Add(Me.Label_Security_Add_title)
        Me.TabPage_Security_Add.Controls.Add(Me.Label_Security_Add_username)
        Me.TabPage_Security_Add.Controls.Add(Me.TextBox_Security_Add_password)
        Me.TabPage_Security_Add.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Security_Add.Name = "TabPage_Security_Add"
        Me.TabPage_Security_Add.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Security_Add.Size = New System.Drawing.Size(794, 332)
        Me.TabPage_Security_Add.TabIndex = 0
        Me.TabPage_Security_Add.Text = "Add Username and Password"
        Me.TabPage_Security_Add.UseVisualStyleBackColor = True
        '
        'TextBox_Security_Add_username
        '
        Me.TextBox_Security_Add_username.Location = New System.Drawing.Point(322, 152)
        Me.TextBox_Security_Add_username.MaxLength = 50
        Me.TextBox_Security_Add_username.Name = "TextBox_Security_Add_username"
        Me.TextBox_Security_Add_username.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_Security_Add_username.TabIndex = 1
        '
        'TextBox_Security_Add_password
        '
        Me.TextBox_Security_Add_password.Location = New System.Drawing.Point(322, 203)
        Me.TextBox_Security_Add_password.MaxLength = 50
        Me.TextBox_Security_Add_password.Name = "TextBox_Security_Add_password"
        Me.TextBox_Security_Add_password.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_Security_Add_password.TabIndex = 2
        Me.TextBox_Security_Add_password.UseSystemPasswordChar = True
        '
        'Label_Security_Add_username
        '
        Me.Label_Security_Add_username.Location = New System.Drawing.Point(322, 126)
        Me.Label_Security_Add_username.Name = "Label_Security_Add_username"
        Me.Label_Security_Add_username.Size = New System.Drawing.Size(250, 25)
        Me.Label_Security_Add_username.TabIndex = 48
        Me.Label_Security_Add_username.Text = "Label_Security_Add_username"
        Me.Label_Security_Add_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Security_Add_title
        '
        Me.Label_Security_Add_title.Location = New System.Drawing.Point(9, 10)
        Me.Label_Security_Add_title.Name = "Label_Security_Add_title"
        Me.Label_Security_Add_title.Size = New System.Drawing.Size(776, 50)
        Me.Label_Security_Add_title.TabIndex = 49
        Me.Label_Security_Add_title.Text = "Label_Security_Add_title"
        Me.Label_Security_Add_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Security_Add_done
        '
        Me.Button_Security_Add_done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Security_Add_done.Location = New System.Drawing.Point(359, 300)
        Me.Button_Security_Add_done.Name = "Button_Security_Add_done"
        Me.Button_Security_Add_done.Size = New System.Drawing.Size(75, 27)
        Me.Button_Security_Add_done.TabIndex = 4
        Me.Button_Security_Add_done.Text = "Done"
        Me.Button_Security_Add_done.UseVisualStyleBackColor = True
        '
        'Label_Security_Add_password
        '
        Me.Label_Security_Add_password.Location = New System.Drawing.Point(322, 177)
        Me.Label_Security_Add_password.Name = "Label_Security_Add_password"
        Me.Label_Security_Add_password.Size = New System.Drawing.Size(250, 25)
        Me.Label_Security_Add_password.TabIndex = 50
        Me.Label_Security_Add_password.Text = "Label_Security_Add_password"
        Me.Label_Security_Add_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_Security_Add_username_visible
        '
        Me.PictureBox_Security_Add_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible_1_
        Me.PictureBox_Security_Add_username_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_Security_Add_username_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Security_Add_username_visible.Location = New System.Drawing.Point(478, 152)
        Me.PictureBox_Security_Add_username_visible.Name = "PictureBox_Security_Add_username_visible"
        Me.PictureBox_Security_Add_username_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_Security_Add_username_visible.TabIndex = 51
        Me.PictureBox_Security_Add_username_visible.TabStop = False
        '
        'PictureBox_Security_Add_password_visible
        '
        Me.PictureBox_Security_Add_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible
        Me.PictureBox_Security_Add_password_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_Security_Add_password_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Security_Add_password_visible.Location = New System.Drawing.Point(478, 203)
        Me.PictureBox_Security_Add_password_visible.Name = "PictureBox_Security_Add_password_visible"
        Me.PictureBox_Security_Add_password_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_Security_Add_password_visible.TabIndex = 52
        Me.PictureBox_Security_Add_password_visible.TabStop = False
        '
        'TextBox_Security_Add_confirm_password
        '
        Me.TextBox_Security_Add_confirm_password.Location = New System.Drawing.Point(322, 255)
        Me.TextBox_Security_Add_confirm_password.MaxLength = 50
        Me.TextBox_Security_Add_confirm_password.Name = "TextBox_Security_Add_confirm_password"
        Me.TextBox_Security_Add_confirm_password.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_Security_Add_confirm_password.TabIndex = 3
        Me.TextBox_Security_Add_confirm_password.UseSystemPasswordChar = True
        '
        'Label_Security_Add_confirm_password
        '
        Me.Label_Security_Add_confirm_password.Location = New System.Drawing.Point(322, 229)
        Me.Label_Security_Add_confirm_password.Name = "Label_Security_Add_confirm_password"
        Me.Label_Security_Add_confirm_password.Size = New System.Drawing.Size(250, 25)
        Me.Label_Security_Add_confirm_password.TabIndex = 53
        Me.Label_Security_Add_confirm_password.Text = "Label_Security_Add_confirm_password"
        Me.Label_Security_Add_confirm_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Security_Add_name
        '
        Me.TextBox_Security_Add_name.Location = New System.Drawing.Point(322, 101)
        Me.TextBox_Security_Add_name.MaxLength = 50
        Me.TextBox_Security_Add_name.Name = "TextBox_Security_Add_name"
        Me.TextBox_Security_Add_name.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_Security_Add_name.TabIndex = 0
        '
        'Label_Security_Add_name
        '
        Me.Label_Security_Add_name.Location = New System.Drawing.Point(322, 75)
        Me.Label_Security_Add_name.Name = "Label_Security_Add_name"
        Me.Label_Security_Add_name.Size = New System.Drawing.Size(250, 25)
        Me.Label_Security_Add_name.TabIndex = 55
        Me.Label_Security_Add_name.Text = "Label_Security_Add_name"
        Me.Label_Security_Add_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl_Security
        '
        Me.TabControl_Security.Controls.Add(Me.TabPage_Security_Add)
        Me.TabControl_Security.Controls.Add(Me.TabPage_Security_Delete)
        Me.TabControl_Security.Controls.Add(Me.TabPage_application_username_and_password)
        Me.TabControl_Security.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Security.Location = New System.Drawing.Point(3, 3)
        Me.TabControl_Security.Name = "TabControl_Security"
        Me.TabControl_Security.SelectedIndex = 0
        Me.TabControl_Security.Size = New System.Drawing.Size(802, 358)
        Me.TabControl_Security.TabIndex = 0
        '
        'Form_setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(816, 390)
        Me.Controls.Add(Me.TabControl_setting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setting"
        Me.TabPage_devices.ResumeLayout(False)
        Me.TabPage_devices.PerformLayout()
        CType(Me.PictureBox_auto_connection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_trying_to_connect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dialysis_time, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_language.ResumeLayout(False)
        CType(Me.PictureBox_spanish_language, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_arabic_language, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_persian_language, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_english_language, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_hospital.ResumeLayout(False)
        Me.TabPage_hospital.PerformLayout()
        Me.TabControl_setting.ResumeLayout(False)
        Me.TabPage_scale_setting.ResumeLayout(False)
        Me.TabPage_scale_setting.PerformLayout()
        CType(Me.PictureBox_calibrate_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_offset_help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_calibrate_help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Security.ResumeLayout(False)
        Me.TabPage_application_username_and_password.ResumeLayout(False)
        Me.TabPage_application_username_and_password.PerformLayout()
        CType(Me.PictureBox_application_username_and_password_username_visible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_application_username_and_password_password_visible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Security_Delete.ResumeLayout(False)
        Me.TabPage_Security_Delete.PerformLayout()
        CType(Me.PictureBox_Security_Delete_username_visible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Security_Delete_password_visible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Security_Add.ResumeLayout(False)
        Me.TabPage_Security_Add.PerformLayout()
        CType(Me.PictureBox_Security_Add_username_visible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Security_Add_password_visible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_Security.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer_connection_status As System.Windows.Forms.Timer
    Friend WithEvents Label_connection_status As System.Windows.Forms.Label
    Friend WithEvents Label_title_devices As System.Windows.Forms.Label
    Friend WithEvents Button_connect As System.Windows.Forms.Button
    Friend WithEvents TabPage_devices As System.Windows.Forms.TabPage
    Friend WithEvents Label_title_hospital As System.Windows.Forms.Label
    Friend WithEvents Button_change_setting_table As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown_dialysis_time As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaskedTextBox_hospital_tel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RadioButton_persian_language As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox_persian_language As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_english_language As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_hospital_address As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_hospital_name As System.Windows.Forms.TextBox
    Friend WithEvents Label_dialysis_time As System.Windows.Forms.Label
    Friend WithEvents Label_hospital_tel As System.Windows.Forms.Label
    Friend WithEvents Label_hospital_address As System.Windows.Forms.Label
    Friend WithEvents Label_hospital_name As System.Windows.Forms.Label
    Friend WithEvents Button_change_language As System.Windows.Forms.Button
    Friend WithEvents Label_title_language As System.Windows.Forms.Label
    Friend WithEvents RadioButton_english_language As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage_language As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_hospital As System.Windows.Forms.TabPage
    Friend WithEvents TabControl_setting As System.Windows.Forms.TabControl
    Friend WithEvents PictureBox_auto_connection As System.Windows.Forms.PictureBox
    Friend WithEvents Label_auto_connection As System.Windows.Forms.Label
    Friend WithEvents PictureBox_trying_to_connect As System.Windows.Forms.PictureBox
    Friend WithEvents Label_trying_to_connect As System.Windows.Forms.Label
    Friend WithEvents Timer_auto_connection As System.Windows.Forms.Timer
    Friend WithEvents Timer_manual_connection As System.Windows.Forms.Timer
    Friend WithEvents TabPage_scale_setting As System.Windows.Forms.TabPage
    Friend WithEvents Label_title_calibrate As System.Windows.Forms.Label
    Friend WithEvents Label_calibrate_explain As System.Windows.Forms.Label
    Friend WithEvents Button_calibrate As System.Windows.Forms.Button
    Friend WithEvents PictureBox_calibrate_help As System.Windows.Forms.PictureBox
    Friend WithEvents Label_calibrate_help As System.Windows.Forms.Label
    Friend WithEvents TextBox_calibrate As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label_title_offset As System.Windows.Forms.Label
    Friend WithEvents Label_offset_help As System.Windows.Forms.Label
    Friend WithEvents PictureBox_offset_help As System.Windows.Forms.PictureBox
    Friend WithEvents Button_offset As System.Windows.Forms.Button
    Friend WithEvents PictureBox_calibrate_cancel As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton_spanish_language As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox_spanish_language As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton_arabic_language As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox_arabic_language As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox_ListPort As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage_Security As System.Windows.Forms.TabPage
    Friend WithEvents TabControl_Security As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Security_Add As System.Windows.Forms.TabPage
    Friend WithEvents Label_Security_Add_name As System.Windows.Forms.Label
    Friend WithEvents TextBox_Security_Add_name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Security_Add_username As System.Windows.Forms.TextBox
    Friend WithEvents Label_Security_Add_confirm_password As System.Windows.Forms.Label
    Friend WithEvents TextBox_Security_Add_confirm_password As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_Security_Add_password_visible As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Security_Add_username_visible As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Security_Add_password As System.Windows.Forms.Label
    Friend WithEvents Button_Security_Add_done As System.Windows.Forms.Button
    Friend WithEvents Label_Security_Add_title As System.Windows.Forms.Label
    Friend WithEvents Label_Security_Add_username As System.Windows.Forms.Label
    Friend WithEvents TextBox_Security_Add_password As System.Windows.Forms.TextBox
    Friend WithEvents TabPage_Security_Delete As System.Windows.Forms.TabPage
    Friend WithEvents Label_Security_Delete_name As System.Windows.Forms.Label
    Friend WithEvents TextBox_Security_Delete_name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Security_Delete_username As System.Windows.Forms.TextBox
    Friend WithEvents Label_Security_Delete_password As System.Windows.Forms.Label
    Friend WithEvents Button_Security_Delete_done As System.Windows.Forms.Button
    Friend WithEvents Label_Security_Delete_title As System.Windows.Forms.Label
    Friend WithEvents Label_Security_Delete_username As System.Windows.Forms.Label
    Friend WithEvents TextBox_Security_Delete_password As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_Security_Delete_password_visible As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Security_Delete_username_visible As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage_application_username_and_password As System.Windows.Forms.TabPage
    Friend WithEvents Label_application_username_and_password_confirm_password As System.Windows.Forms.Label
    Friend WithEvents TextBox_application_username_and_password_confirm_password As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_application_username_and_password_password_visible As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_application_username_and_password_username_visible As System.Windows.Forms.PictureBox
    Friend WithEvents Label_application_username_and_password_password As System.Windows.Forms.Label
    Friend WithEvents Button_application_username_and_password_done As System.Windows.Forms.Button
    Friend WithEvents Label_application_username_and_password_title As System.Windows.Forms.Label
    Friend WithEvents Label_application_username_and_password_username As System.Windows.Forms.Label
    Friend WithEvents TextBox_application_username_and_password_password As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_application_username_and_password_username As System.Windows.Forms.TextBox
End Class
