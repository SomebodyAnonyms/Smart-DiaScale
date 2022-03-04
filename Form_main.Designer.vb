<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_main))
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox_search = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip_menu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_add_patients = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_delete_patients = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_edit_patients = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_backup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_recovery = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_setting = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_about_us = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_refresh = New System.Windows.Forms.ToolStripButton()
        Me.Timer_Time = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip_label_percent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip_progress_bar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip_label_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip_label_entered_person_name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip_label_connection_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Main_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Column_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_father_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_birth_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_id_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_mobile_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_home_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_fingerprint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_enroll_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_dr_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_blood_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_shift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllpatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Main_DBDataSet = New Smart_DiaScale_I.Main_DBDataSet()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Timer_proggress_bar = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox_serial_items = New System.Windows.Forms.ListBox()
        Me.Timer_read_serial = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip_label_seperator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip_menu.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.Main_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllpatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripTextBox_search
        '
        Me.ToolStripTextBox_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox_search.Name = "ToolStripTextBox_search"
        Me.ToolStripTextBox_search.Size = New System.Drawing.Size(200, 39)
        Me.ToolStripTextBox_search.Text = "Search"
        Me.ToolStripTextBox_search.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'SerialPort
        '
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStrip_menu
        '
        Me.ToolStrip_menu.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip_menu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_add_patients, Me.ToolStripSeparator1, Me.ToolStripButton_delete_patients, Me.ToolStripSeparator2, Me.ToolStripButton_edit_patients, Me.ToolStripSeparator3, Me.ToolStripButton_backup, Me.ToolStripSeparator4, Me.ToolStripButton_recovery, Me.ToolStripSeparator5, Me.ToolStripButton_setting, Me.ToolStripSeparator6, Me.ToolStripButton_about_us, Me.ToolStripTextBox_search, Me.ToolStripSeparator7, Me.ToolStripButton_refresh})
        Me.ToolStrip_menu.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_menu.Name = "ToolStrip_menu"
        Me.ToolStrip_menu.Size = New System.Drawing.Size(984, 39)
        Me.ToolStrip_menu.TabIndex = 6
        Me.ToolStrip_menu.Text = "ToolStrip1"
        '
        'ToolStripButton_add_patients
        '
        Me.ToolStripButton_add_patients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_add_patients.Image = Global.Smart_DiaScale_I.My.Resources.Resources.plus
        Me.ToolStripButton_add_patients.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_add_patients.Name = "ToolStripButton_add_patients"
        Me.ToolStripButton_add_patients.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_add_patients.Text = "ToolStripButton1"
        '
        'ToolStripButton_delete_patients
        '
        Me.ToolStripButton_delete_patients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_delete_patients.Image = Global.Smart_DiaScale_I.My.Resources.Resources.minus
        Me.ToolStripButton_delete_patients.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_delete_patients.Name = "ToolStripButton_delete_patients"
        Me.ToolStripButton_delete_patients.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_delete_patients.Text = "ToolStripButton2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton_edit_patients
        '
        Me.ToolStripButton_edit_patients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_edit_patients.Image = Global.Smart_DiaScale_I.My.Resources.Resources.edit
        Me.ToolStripButton_edit_patients.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_edit_patients.Name = "ToolStripButton_edit_patients"
        Me.ToolStripButton_edit_patients.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_edit_patients.Text = "ToolStripButton3"
        '
        'ToolStripButton_backup
        '
        Me.ToolStripButton_backup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_backup.Image = Global.Smart_DiaScale_I.My.Resources.Resources.backup
        Me.ToolStripButton_backup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_backup.Name = "ToolStripButton_backup"
        Me.ToolStripButton_backup.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_backup.Text = "ToolStripButton1"
        '
        'ToolStripButton_recovery
        '
        Me.ToolStripButton_recovery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_recovery.Image = Global.Smart_DiaScale_I.My.Resources.Resources.recovery
        Me.ToolStripButton_recovery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_recovery.Name = "ToolStripButton_recovery"
        Me.ToolStripButton_recovery.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_recovery.Text = "ToolStripButton2"
        '
        'ToolStripButton_setting
        '
        Me.ToolStripButton_setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_setting.Image = Global.Smart_DiaScale_I.My.Resources.Resources.settings
        Me.ToolStripButton_setting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_setting.Name = "ToolStripButton_setting"
        Me.ToolStripButton_setting.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_setting.Text = "ToolStripButton1"
        '
        'ToolStripButton_about_us
        '
        Me.ToolStripButton_about_us.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_about_us.Image = Global.Smart_DiaScale_I.My.Resources.Resources.about_us
        Me.ToolStripButton_about_us.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_about_us.Name = "ToolStripButton_about_us"
        Me.ToolStripButton_about_us.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_about_us.Text = "ToolStripButton1"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton_refresh
        '
        Me.ToolStripButton_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_refresh.Image = Global.Smart_DiaScale_I.My.Resources.Resources.refresh
        Me.ToolStripButton_refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_refresh.Name = "ToolStripButton_refresh"
        Me.ToolStripButton_refresh.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_refresh.Text = "ToolStripButton_refresh"
        '
        'Timer_Time
        '
        Me.Timer_Time.Enabled = True
        Me.Timer_Time.Interval = 1000
        '
        'StatusStrip_label_percent
        '
        Me.StatusStrip_label_percent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StatusStrip_label_percent.Name = "StatusStrip_label_percent"
        Me.StatusStrip_label_percent.Size = New System.Drawing.Size(138, 17)
        Me.StatusStrip_label_percent.Text = "StatusStrip_label_percent"
        '
        'StatusStrip_progress_bar
        '
        Me.StatusStrip_progress_bar.AutoSize = False
        Me.StatusStrip_progress_bar.Name = "StatusStrip_progress_bar"
        Me.StatusStrip_progress_bar.Size = New System.Drawing.Size(150, 16)
        '
        'StatusStrip_label_time
        '
        Me.StatusStrip_label_time.AutoSize = False
        Me.StatusStrip_label_time.Name = "StatusStrip_label_time"
        Me.StatusStrip_label_time.Size = New System.Drawing.Size(150, 17)
        Me.StatusStrip_label_time.Text = "StatusStrip_label_time"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.White
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStrip_label_time, Me.StatusStrip_progress_bar, Me.StatusStrip_label_percent, Me.StatusStrip_label_entered_person_name, Me.StatusStrip_label_seperator, Me.StatusStrip_label_connection_status})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusStrip_label_entered_person_name
        '
        Me.StatusStrip_label_entered_person_name.ForeColor = System.Drawing.Color.Blue
        Me.StatusStrip_label_entered_person_name.Name = "StatusStrip_label_entered_person_name"
        Me.StatusStrip_label_entered_person_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusStrip_label_entered_person_name.Size = New System.Drawing.Size(293, 17)
        Me.StatusStrip_label_entered_person_name.Spring = True
        Me.StatusStrip_label_entered_person_name.Text = "StatusStrip_label_entered_person_name"
        Me.StatusStrip_label_entered_person_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip_label_connection_status
        '
        Me.StatusStrip_label_connection_status.Name = "StatusStrip_label_connection_status"
        Me.StatusStrip_label_connection_status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusStrip_label_connection_status.Size = New System.Drawing.Size(194, 17)
        Me.StatusStrip_label_connection_status.Text = "StatusStrip_label_connection_status"
        Me.StatusStrip_label_connection_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main_DataGridView
        '
        Me.Main_DataGridView.AllowUserToAddRows = False
        Me.Main_DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Main_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Main_DataGridView.AutoGenerateColumns = False
        Me.Main_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Main_DataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.Main_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Main_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Main_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Main_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_id, Me.Column_image, Me.Column_name, Me.Column_lastname, Me.Column_father_name, Me.Column_birth_date, Me.Column_id_code, Me.Column_mobile_number, Me.Column_home_number, Me.Column_gender, Me.Column_height, Me.Column_fingerprint, Me.Column_enroll_date, Me.Column_dr_name, Me.Column_blood_type, Me.Column_shift})
        Me.Main_DataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Main_DataGridView.DataSource = Me.AllpatientsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Main_DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.Main_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main_DataGridView.Location = New System.Drawing.Point(0, 39)
        Me.Main_DataGridView.Name = "Main_DataGridView"
        Me.Main_DataGridView.ReadOnly = True
        Me.Main_DataGridView.RowHeadersWidth = 20
        Me.Main_DataGridView.Size = New System.Drawing.Size(984, 400)
        Me.Main_DataGridView.TabIndex = 5
        '
        'Column_id
        '
        Me.Column_id.DataPropertyName = "Id"
        Me.Column_id.HeaderText = "Id"
        Me.Column_id.Name = "Column_id"
        Me.Column_id.ReadOnly = True
        '
        'Column_image
        '
        Me.Column_image.DataPropertyName = "image"
        Me.Column_image.HeaderText = "image"
        Me.Column_image.Name = "Column_image"
        Me.Column_image.ReadOnly = True
        '
        'Column_name
        '
        Me.Column_name.DataPropertyName = "name"
        Me.Column_name.HeaderText = "name"
        Me.Column_name.Name = "Column_name"
        Me.Column_name.ReadOnly = True
        '
        'Column_lastname
        '
        Me.Column_lastname.DataPropertyName = "lastname"
        Me.Column_lastname.HeaderText = "lastname"
        Me.Column_lastname.Name = "Column_lastname"
        Me.Column_lastname.ReadOnly = True
        '
        'Column_father_name
        '
        Me.Column_father_name.DataPropertyName = "father_name"
        Me.Column_father_name.HeaderText = "father_name"
        Me.Column_father_name.Name = "Column_father_name"
        Me.Column_father_name.ReadOnly = True
        '
        'Column_birth_date
        '
        Me.Column_birth_date.DataPropertyName = "birth_date"
        Me.Column_birth_date.HeaderText = "birth_date"
        Me.Column_birth_date.Name = "Column_birth_date"
        Me.Column_birth_date.ReadOnly = True
        '
        'Column_id_code
        '
        Me.Column_id_code.DataPropertyName = "id_code"
        Me.Column_id_code.HeaderText = "id_code"
        Me.Column_id_code.Name = "Column_id_code"
        Me.Column_id_code.ReadOnly = True
        '
        'Column_mobile_number
        '
        Me.Column_mobile_number.DataPropertyName = "mobile_number"
        Me.Column_mobile_number.HeaderText = "mobile_number"
        Me.Column_mobile_number.Name = "Column_mobile_number"
        Me.Column_mobile_number.ReadOnly = True
        '
        'Column_home_number
        '
        Me.Column_home_number.DataPropertyName = "home_number"
        Me.Column_home_number.HeaderText = "home_number"
        Me.Column_home_number.Name = "Column_home_number"
        Me.Column_home_number.ReadOnly = True
        '
        'Column_gender
        '
        Me.Column_gender.DataPropertyName = "gender"
        Me.Column_gender.HeaderText = "gender"
        Me.Column_gender.Name = "Column_gender"
        Me.Column_gender.ReadOnly = True
        '
        'Column_height
        '
        Me.Column_height.DataPropertyName = "height"
        Me.Column_height.HeaderText = "height"
        Me.Column_height.Name = "Column_height"
        Me.Column_height.ReadOnly = True
        '
        'Column_fingerprint
        '
        Me.Column_fingerprint.DataPropertyName = "fingerprint"
        Me.Column_fingerprint.HeaderText = "fingerprint"
        Me.Column_fingerprint.Name = "Column_fingerprint"
        Me.Column_fingerprint.ReadOnly = True
        '
        'Column_enroll_date
        '
        Me.Column_enroll_date.DataPropertyName = "enroll_date"
        Me.Column_enroll_date.HeaderText = "enroll_date"
        Me.Column_enroll_date.Name = "Column_enroll_date"
        Me.Column_enroll_date.ReadOnly = True
        '
        'Column_dr_name
        '
        Me.Column_dr_name.DataPropertyName = "dr_name"
        Me.Column_dr_name.HeaderText = "dr_name"
        Me.Column_dr_name.Name = "Column_dr_name"
        Me.Column_dr_name.ReadOnly = True
        '
        'Column_blood_type
        '
        Me.Column_blood_type.DataPropertyName = "blood_type"
        Me.Column_blood_type.HeaderText = "blood_type"
        Me.Column_blood_type.Name = "Column_blood_type"
        Me.Column_blood_type.ReadOnly = True
        '
        'Column_shift
        '
        Me.Column_shift.DataPropertyName = "shift"
        Me.Column_shift.HeaderText = "shift"
        Me.Column_shift.Name = "Column_shift"
        Me.Column_shift.ReadOnly = True
        '
        'AllpatientsBindingSource
        '
        Me.AllpatientsBindingSource.DataMember = "all_patients"
        Me.AllpatientsBindingSource.DataSource = Me.Main_DBDataSet
        '
        'Main_DBDataSet
        '
        Me.Main_DBDataSet.DataSetName = "Main_DBDataSet"
        Me.Main_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer_proggress_bar
        '
        Me.Timer_proggress_bar.Interval = 1
        '
        'ListBox_serial_items
        '
        Me.ListBox_serial_items.FormattingEnabled = True
        Me.ListBox_serial_items.Location = New System.Drawing.Point(12, 270)
        Me.ListBox_serial_items.Name = "ListBox_serial_items"
        Me.ListBox_serial_items.Size = New System.Drawing.Size(146, 95)
        Me.ListBox_serial_items.TabIndex = 8
        Me.ListBox_serial_items.Visible = False
        '
        'Timer_read_serial
        '
        '
        'StatusStrip_label_seperator
        '
        Me.StatusStrip_label_seperator.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip_label_seperator.Name = "StatusStrip_label_seperator"
        Me.StatusStrip_label_seperator.Size = New System.Drawing.Size(11, 17)
        Me.StatusStrip_label_seperator.Text = "|"
        '
        'Form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.ListBox_serial_items)
        Me.Controls.Add(Me.Main_DataGridView)
        Me.Controls.Add(Me.ToolStrip_menu)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Smart DiaScale I"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip_menu.ResumeLayout(False)
        Me.ToolStrip_menu.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.Main_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllpatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripButton_refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox_search As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_setting As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_recovery As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_backup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents ToolStripButton_edit_patients As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_delete_patients As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_add_patients As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer_Time As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip_label_percent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip_progress_bar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents StatusStrip_label_time As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Main_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StatusStrip_label_connection_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer_proggress_bar As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton_about_us As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListBox_serial_items As System.Windows.Forms.ListBox
    Friend WithEvents Main_DBDataSet As Smart_DiaScale_I.Main_DBDataSet
    Friend WithEvents AllpatientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Column_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_image As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_father_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_birth_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_id_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_mobile_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_home_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_height As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_fingerprint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_enroll_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_dr_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_blood_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_shift As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer_read_serial As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip_label_entered_person_name As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip_label_seperator As System.Windows.Forms.ToolStripStatusLabel

End Class
