<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_show_patient_database
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_show_patient_database))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripButton_refresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox_search = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_print = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_edit_dialysis = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_delete_dialysis = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_add_dialysis = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_menu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_chart = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip_label_percent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip_progress_bar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Label_dialysis_count = New System.Windows.Forms.Label()
        Me.PictureBox_dialysis_count = New System.Windows.Forms.PictureBox()
        Me.Label_name = New System.Windows.Forms.Label()
        Me.PictureBox_user = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_blood_type = New System.Windows.Forms.Label()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.Main_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Timer_proggress_bar = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip_menu.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.PictureBox_dialysis_count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Main_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        '
        'ToolStripButton_refresh
        '
        Me.ToolStripButton_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_refresh.Image = Global.Smart_DiaScale_I.My.Resources.Resources.refresh
        Me.ToolStripButton_refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_refresh.Name = "ToolStripButton_refresh"
        Me.ToolStripButton_refresh.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_refresh.Text = "ToolStripButton_refresh"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox_search
        '
        Me.ToolStripTextBox_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox_search.Name = "ToolStripTextBox_search"
        Me.ToolStripTextBox_search.Size = New System.Drawing.Size(200, 25)
        Me.ToolStripTextBox_search.Text = "Search"
        Me.ToolStripTextBox_search.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripButton_print
        '
        Me.ToolStripButton_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_print.Image = Global.Smart_DiaScale_I.My.Resources.Resources.print
        Me.ToolStripButton_print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_print.Name = "ToolStripButton_print"
        Me.ToolStripButton_print.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_print.Text = "ToolStripButton1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_edit_dialysis
        '
        Me.ToolStripButton_edit_dialysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_edit_dialysis.Image = Global.Smart_DiaScale_I.My.Resources.Resources.edit
        Me.ToolStripButton_edit_dialysis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_edit_dialysis.Name = "ToolStripButton_edit_dialysis"
        Me.ToolStripButton_edit_dialysis.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_edit_dialysis.Text = "ToolStripButton3"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_delete_dialysis
        '
        Me.ToolStripButton_delete_dialysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_delete_dialysis.Image = Global.Smart_DiaScale_I.My.Resources.Resources.minus
        Me.ToolStripButton_delete_dialysis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_delete_dialysis.Name = "ToolStripButton_delete_dialysis"
        Me.ToolStripButton_delete_dialysis.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_delete_dialysis.Text = "ToolStripButton2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_add_dialysis
        '
        Me.ToolStripButton_add_dialysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_add_dialysis.Image = Global.Smart_DiaScale_I.My.Resources.Resources.plus
        Me.ToolStripButton_add_dialysis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_add_dialysis.Name = "ToolStripButton_add_dialysis"
        Me.ToolStripButton_add_dialysis.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_add_dialysis.Text = "ToolStripButton1"
        '
        'ToolStrip_menu
        '
        Me.ToolStrip_menu.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_add_dialysis, Me.ToolStripSeparator1, Me.ToolStripButton_delete_dialysis, Me.ToolStripSeparator2, Me.ToolStripButton_edit_dialysis, Me.ToolStripSeparator3, Me.ToolStripButton_chart, Me.ToolStripSeparator4, Me.ToolStripButton_print, Me.ToolStripTextBox_search, Me.ToolStripSeparator5, Me.ToolStripButton_refresh})
        Me.ToolStrip_menu.Location = New System.Drawing.Point(0, 114)
        Me.ToolStrip_menu.Name = "ToolStrip_menu"
        Me.ToolStrip_menu.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip_menu.TabIndex = 8
        Me.ToolStrip_menu.Text = "ToolStrip1"
        '
        'ToolStripButton_chart
        '
        Me.ToolStripButton_chart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_chart.Image = Global.Smart_DiaScale_I.My.Resources.Resources.chart
        Me.ToolStripButton_chart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_chart.Name = "ToolStripButton_chart"
        Me.ToolStripButton_chart.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_chart.Text = "ToolStripButton1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
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
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.White
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStrip_progress_bar, Me.StatusStrip_label_percent})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'Label_dialysis_count
        '
        Me.Label_dialysis_count.Location = New System.Drawing.Point(3, 45)
        Me.Label_dialysis_count.Name = "Label_dialysis_count"
        Me.Label_dialysis_count.Size = New System.Drawing.Size(50, 20)
        Me.Label_dialysis_count.TabIndex = 3
        Me.Label_dialysis_count.Text = "0"
        Me.Label_dialysis_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox_dialysis_count
        '
        Me.PictureBox_dialysis_count.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.dialysis
        Me.PictureBox_dialysis_count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_dialysis_count.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox_dialysis_count.Name = "PictureBox_dialysis_count"
        Me.PictureBox_dialysis_count.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox_dialysis_count.TabIndex = 2
        Me.PictureBox_dialysis_count.TabStop = False
        '
        'Label_name
        '
        Me.Label_name.Location = New System.Drawing.Point(335, 56)
        Me.Label_name.Name = "Label_name"
        Me.Label_name.Size = New System.Drawing.Size(300, 25)
        Me.Label_name.TabIndex = 1
        Me.Label_name.Text = "Label_name"
        Me.Label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox_user
        '
        Me.PictureBox_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_user.Location = New System.Drawing.Point(460, 3)
        Me.PictureBox_user.Name = "PictureBox_user"
        Me.PictureBox_user.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_user.TabIndex = 0
        Me.PictureBox_user.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_blood_type)
        Me.Panel1.Controls.Add(Me.Label_dialysis_count)
        Me.Panel1.Controls.Add(Me.PictureBox_dialysis_count)
        Me.Panel1.Controls.Add(Me.Label_name)
        Me.Panel1.Controls.Add(Me.PictureBox_user)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 114)
        Me.Panel1.TabIndex = 6
        '
        'Label_blood_type
        '
        Me.Label_blood_type.ForeColor = System.Drawing.Color.Red
        Me.Label_blood_type.Location = New System.Drawing.Point(335, 81)
        Me.Label_blood_type.Name = "Label_blood_type"
        Me.Label_blood_type.Size = New System.Drawing.Size(300, 25)
        Me.Label_blood_type.TabIndex = 4
        Me.Label_blood_type.Text = "Label_blood_type"
        Me.Label_blood_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDocument
        '
        '
        'Main_DataGridView
        '
        Me.Main_DataGridView.AllowUserToAddRows = False
        Me.Main_DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Main_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
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
        Me.Main_DataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Main_DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.Main_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main_DataGridView.Location = New System.Drawing.Point(0, 139)
        Me.Main_DataGridView.Name = "Main_DataGridView"
        Me.Main_DataGridView.ReadOnly = True
        Me.Main_DataGridView.RowHeadersWidth = 20
        Me.Main_DataGridView.Size = New System.Drawing.Size(984, 400)
        Me.Main_DataGridView.TabIndex = 5
        '
        'Timer_proggress_bar
        '
        Me.Timer_proggress_bar.Interval = 1
        '
        'Form_show_patient_database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Main_DataGridView)
        Me.Controls.Add(Me.ToolStrip_menu)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_show_patient_database"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient Dialysis Info"
        Me.ToolStrip_menu.ResumeLayout(False)
        Me.ToolStrip_menu.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.PictureBox_dialysis_count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Main_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripButton_refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox_search As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_print As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_edit_dialysis As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_delete_dialysis As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_add_dialysis As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip_label_percent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip_progress_bar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Label_dialysis_count As System.Windows.Forms.Label
    Friend WithEvents PictureBox_dialysis_count As System.Windows.Forms.PictureBox
    Friend WithEvents Label_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox_user As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents Main_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton_chart As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer_proggress_bar As System.Windows.Forms.Timer
    Friend WithEvents Label_blood_type As System.Windows.Forms.Label
End Class
