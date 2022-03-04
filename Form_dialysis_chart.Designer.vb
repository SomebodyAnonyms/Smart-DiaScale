<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_dialysis_chart
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_dialysis_chart))
        Me.Label_one_week = New System.Windows.Forms.Label()
        Me.Label_two_week = New System.Windows.Forms.Label()
        Me.Label_month = New System.Windows.Forms.Label()
        Me.Label_year = New System.Windows.Forms.Label()
        Me.Label_all = New System.Windows.Forms.Label()
        Me.Label_seperator_1 = New System.Windows.Forms.Label()
        Me.Label_seperator_2 = New System.Windows.Forms.Label()
        Me.Label_seperator_3 = New System.Windows.Forms.Label()
        Me.Label_seperator_4 = New System.Windows.Forms.Label()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label_nothing_to_show = New System.Windows.Forms.Label()
        Me.TrackBar_chart_type = New System.Windows.Forms.TrackBar()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label_chart_filter_weight_1 = New System.Windows.Forms.Label()
        Me.Label_chart_filter_weight_2 = New System.Windows.Forms.Label()
        Me.Label_chart_filter_bmi_1 = New System.Windows.Forms.Label()
        Me.Label_chart_filter_bmi_2 = New System.Windows.Forms.Label()
        Me.Label_chart_filter_weight_all = New System.Windows.Forms.Label()
        Me.Label_chart_filter_bmi_all = New System.Windows.Forms.Label()
        Me.Label_chart_filter_all = New System.Windows.Forms.Label()
        Me.Label_seperator_6 = New System.Windows.Forms.Label()
        Me.Label_seperator_7 = New System.Windows.Forms.Label()
        Me.Label_seperator_8 = New System.Windows.Forms.Label()
        Me.Label_seperator_9 = New System.Windows.Forms.Label()
        Me.Label_seperator_10 = New System.Windows.Forms.Label()
        Me.Label_seperator_11 = New System.Windows.Forms.Label()
        Me.Label_seperator_5 = New System.Windows.Forms.Label()
        Me.Label_customize = New System.Windows.Forms.Label()
        Me.Label_customize_explain_1 = New System.Windows.Forms.Label()
        Me.Label_customize_explain_2 = New System.Windows.Forms.Label()
        Me.TextBox_customize_number = New System.Windows.Forms.TextBox()
        Me.PictureBox_reload_chart = New System.Windows.Forms.PictureBox()
        Me.PictureBox_default_setting = New System.Windows.Forms.PictureBox()
        Me.PictureBox_chart_labels_visible = New System.Windows.Forms.PictureBox()
        Me.PictureBox_nothing_to_show = New System.Windows.Forms.PictureBox()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_chart_type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_reload_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_default_setting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_chart_labels_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_nothing_to_show, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_one_week
        '
        Me.Label_one_week.AutoSize = True
        Me.Label_one_week.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_one_week.Location = New System.Drawing.Point(139, 9)
        Me.Label_one_week.Name = "Label_one_week"
        Me.Label_one_week.Size = New System.Drawing.Size(89, 13)
        Me.Label_one_week.TabIndex = 0
        Me.Label_one_week.Text = "Label_one_week"
        Me.Label_one_week.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_two_week
        '
        Me.Label_two_week.AutoSize = True
        Me.Label_two_week.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_two_week.Location = New System.Drawing.Point(335, 9)
        Me.Label_two_week.Name = "Label_two_week"
        Me.Label_two_week.Size = New System.Drawing.Size(88, 13)
        Me.Label_two_week.TabIndex = 1
        Me.Label_two_week.Text = "Label_two_week"
        Me.Label_two_week.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_month
        '
        Me.Label_month.AutoSize = True
        Me.Label_month.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_month.Location = New System.Drawing.Point(530, 9)
        Me.Label_month.Name = "Label_month"
        Me.Label_month.Size = New System.Drawing.Size(68, 13)
        Me.Label_month.TabIndex = 2
        Me.Label_month.Text = "Label_month"
        Me.Label_month.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_year
        '
        Me.Label_year.AutoSize = True
        Me.Label_year.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_year.Location = New System.Drawing.Point(705, 9)
        Me.Label_year.Name = "Label_year"
        Me.Label_year.Size = New System.Drawing.Size(59, 13)
        Me.Label_year.TabIndex = 3
        Me.Label_year.Text = "Label_year"
        Me.Label_year.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_all
        '
        Me.Label_all.AutoSize = True
        Me.Label_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_all.Location = New System.Drawing.Point(871, 9)
        Me.Label_all.Name = "Label_all"
        Me.Label_all.Size = New System.Drawing.Size(49, 13)
        Me.Label_all.TabIndex = 4
        Me.Label_all.Text = "Label_all"
        Me.Label_all.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_1
        '
        Me.Label_seperator_1.AutoSize = True
        Me.Label_seperator_1.Location = New System.Drawing.Point(234, 9)
        Me.Label_seperator_1.Name = "Label_seperator_1"
        Me.Label_seperator_1.Size = New System.Drawing.Size(95, 13)
        Me.Label_seperator_1.TabIndex = 5
        Me.Label_seperator_1.Text = "Label_seperator_1"
        Me.Label_seperator_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_2
        '
        Me.Label_seperator_2.AutoSize = True
        Me.Label_seperator_2.Location = New System.Drawing.Point(429, 9)
        Me.Label_seperator_2.Name = "Label_seperator_2"
        Me.Label_seperator_2.Size = New System.Drawing.Size(95, 13)
        Me.Label_seperator_2.TabIndex = 6
        Me.Label_seperator_2.Text = "Label_seperator_2"
        Me.Label_seperator_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_3
        '
        Me.Label_seperator_3.AutoSize = True
        Me.Label_seperator_3.Location = New System.Drawing.Point(604, 9)
        Me.Label_seperator_3.Name = "Label_seperator_3"
        Me.Label_seperator_3.Size = New System.Drawing.Size(95, 13)
        Me.Label_seperator_3.TabIndex = 7
        Me.Label_seperator_3.Text = "Label_seperator_3"
        Me.Label_seperator_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_4
        '
        Me.Label_seperator_4.AutoSize = True
        Me.Label_seperator_4.Location = New System.Drawing.Point(770, 9)
        Me.Label_seperator_4.Name = "Label_seperator_4"
        Me.Label_seperator_4.Size = New System.Drawing.Size(95, 13)
        Me.Label_seperator_4.TabIndex = 8
        Me.Label_seperator_4.Text = "Label_seperator_4"
        Me.Label_seperator_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart
        '
        Me.Chart.BorderlineWidth = 0
        Me.Chart.BorderSkin.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Me.Chart.Dock = System.Windows.Forms.DockStyle.Bottom
        Legend1.Name = "Legend1"
        Me.Chart.Legends.Add(Legend1)
        Me.Chart.Location = New System.Drawing.Point(0, 200)
        Me.Chart.Name = "Chart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series4"
        Me.Chart.Series.Add(Series1)
        Me.Chart.Series.Add(Series2)
        Me.Chart.Series.Add(Series3)
        Me.Chart.Series.Add(Series4)
        Me.Chart.Size = New System.Drawing.Size(1200, 300)
        Me.Chart.TabIndex = 11
        Me.Chart.Text = "Chart"
        '
        'Label_nothing_to_show
        '
        Me.Label_nothing_to_show.Location = New System.Drawing.Point(450, 370)
        Me.Label_nothing_to_show.Name = "Label_nothing_to_show"
        Me.Label_nothing_to_show.Size = New System.Drawing.Size(300, 30)
        Me.Label_nothing_to_show.TabIndex = 13
        Me.Label_nothing_to_show.Text = "Label_nothing_to_show"
        Me.Label_nothing_to_show.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label_nothing_to_show.Visible = False
        '
        'TrackBar_chart_type
        '
        Me.TrackBar_chart_type.AutoSize = False
        Me.TrackBar_chart_type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar_chart_type.LargeChange = 1
        Me.TrackBar_chart_type.Location = New System.Drawing.Point(788, 165)
        Me.TrackBar_chart_type.Maximum = 5
        Me.TrackBar_chart_type.Name = "TrackBar_chart_type"
        Me.TrackBar_chart_type.Size = New System.Drawing.Size(120, 35)
        Me.TrackBar_chart_type.TabIndex = 0
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        '
        'Label_chart_filter_weight_1
        '
        Me.Label_chart_filter_weight_1.AutoSize = True
        Me.Label_chart_filter_weight_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_chart_filter_weight_1.Location = New System.Drawing.Point(12, 184)
        Me.Label_chart_filter_weight_1.Name = "Label_chart_filter_weight_1"
        Me.Label_chart_filter_weight_1.Size = New System.Drawing.Size(105, 13)
        Me.Label_chart_filter_weight_1.TabIndex = 18
        Me.Label_chart_filter_weight_1.Text = "chart_filter_weight_1"
        '
        'Label_chart_filter_weight_2
        '
        Me.Label_chart_filter_weight_2.AutoSize = True
        Me.Label_chart_filter_weight_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_chart_filter_weight_2.Location = New System.Drawing.Point(123, 184)
        Me.Label_chart_filter_weight_2.Name = "Label_chart_filter_weight_2"
        Me.Label_chart_filter_weight_2.Size = New System.Drawing.Size(105, 13)
        Me.Label_chart_filter_weight_2.TabIndex = 19
        Me.Label_chart_filter_weight_2.Text = "chart_filter_weight_2"
        '
        'Label_chart_filter_bmi_1
        '
        Me.Label_chart_filter_bmi_1.AutoSize = True
        Me.Label_chart_filter_bmi_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_chart_filter_bmi_1.Location = New System.Drawing.Point(234, 184)
        Me.Label_chart_filter_bmi_1.Name = "Label_chart_filter_bmi_1"
        Me.Label_chart_filter_bmi_1.Size = New System.Drawing.Size(90, 13)
        Me.Label_chart_filter_bmi_1.TabIndex = 20
        Me.Label_chart_filter_bmi_1.Text = "chart_filter_bmi_1"
        '
        'Label_chart_filter_bmi_2
        '
        Me.Label_chart_filter_bmi_2.AutoSize = True
        Me.Label_chart_filter_bmi_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_chart_filter_bmi_2.Location = New System.Drawing.Point(330, 184)
        Me.Label_chart_filter_bmi_2.Name = "Label_chart_filter_bmi_2"
        Me.Label_chart_filter_bmi_2.Size = New System.Drawing.Size(90, 13)
        Me.Label_chart_filter_bmi_2.TabIndex = 21
        Me.Label_chart_filter_bmi_2.Text = "chart_filter_bmi_2"
        '
        'Label_chart_filter_weight_all
        '
        Me.Label_chart_filter_weight_all.AutoSize = True
        Me.Label_chart_filter_weight_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_chart_filter_weight_all.Location = New System.Drawing.Point(429, 184)
        Me.Label_chart_filter_weight_all.Name = "Label_chart_filter_weight_all"
        Me.Label_chart_filter_weight_all.Size = New System.Drawing.Size(109, 13)
        Me.Label_chart_filter_weight_all.TabIndex = 22
        Me.Label_chart_filter_weight_all.Text = "chart_filter_weight_all"
        '
        'Label_chart_filter_bmi_all
        '
        Me.Label_chart_filter_bmi_all.AutoSize = True
        Me.Label_chart_filter_bmi_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_chart_filter_bmi_all.Location = New System.Drawing.Point(544, 184)
        Me.Label_chart_filter_bmi_all.Name = "Label_chart_filter_bmi_all"
        Me.Label_chart_filter_bmi_all.Size = New System.Drawing.Size(94, 13)
        Me.Label_chart_filter_bmi_all.TabIndex = 23
        Me.Label_chart_filter_bmi_all.Text = "chart_filter_bmi_all"
        '
        'Label_chart_filter_all
        '
        Me.Label_chart_filter_all.AutoSize = True
        Me.Label_chart_filter_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_chart_filter_all.Location = New System.Drawing.Point(644, 184)
        Me.Label_chart_filter_all.Name = "Label_chart_filter_all"
        Me.Label_chart_filter_all.Size = New System.Drawing.Size(72, 13)
        Me.Label_chart_filter_all.TabIndex = 24
        Me.Label_chart_filter_all.Text = "chart_filter_all"
        '
        'Label_seperator_6
        '
        Me.Label_seperator_6.AutoSize = True
        Me.Label_seperator_6.Location = New System.Drawing.Point(12, 165)
        Me.Label_seperator_6.Name = "Label_seperator_6"
        Me.Label_seperator_6.Size = New System.Drawing.Size(95, 13)
        Me.Label_seperator_6.TabIndex = 25
        Me.Label_seperator_6.Text = "Label_seperator_6"
        Me.Label_seperator_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_7
        '
        Me.Label_seperator_7.AutoSize = True
        Me.Label_seperator_7.Location = New System.Drawing.Point(113, 165)
        Me.Label_seperator_7.Name = "Label_seperator_7"
        Me.Label_seperator_7.Size = New System.Drawing.Size(95, 13)
        Me.Label_seperator_7.TabIndex = 26
        Me.Label_seperator_7.Text = "Label_seperator_7"
        Me.Label_seperator_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_8
        '
        Me.Label_seperator_8.AutoSize = True
        Me.Label_seperator_8.Location = New System.Drawing.Point(214, 165)
        Me.Label_seperator_8.Name = "Label_seperator_8"
        Me.Label_seperator_8.Size = New System.Drawing.Size(95, 13)
        Me.Label_seperator_8.TabIndex = 27
        Me.Label_seperator_8.Text = "Label_seperator_8"
        Me.Label_seperator_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_9
        '
        Me.Label_seperator_9.AutoSize = True
        Me.Label_seperator_9.Location = New System.Drawing.Point(315, 165)
        Me.Label_seperator_9.Name = "Label_seperator_9"
        Me.Label_seperator_9.Size = New System.Drawing.Size(95, 13)
        Me.Label_seperator_9.TabIndex = 28
        Me.Label_seperator_9.Text = "Label_seperator_9"
        Me.Label_seperator_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_10
        '
        Me.Label_seperator_10.AutoSize = True
        Me.Label_seperator_10.Location = New System.Drawing.Point(416, 165)
        Me.Label_seperator_10.Name = "Label_seperator_10"
        Me.Label_seperator_10.Size = New System.Drawing.Size(101, 13)
        Me.Label_seperator_10.TabIndex = 29
        Me.Label_seperator_10.Text = "Label_seperator_10"
        Me.Label_seperator_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_11
        '
        Me.Label_seperator_11.AutoSize = True
        Me.Label_seperator_11.Location = New System.Drawing.Point(517, 165)
        Me.Label_seperator_11.Name = "Label_seperator_11"
        Me.Label_seperator_11.Size = New System.Drawing.Size(101, 13)
        Me.Label_seperator_11.TabIndex = 30
        Me.Label_seperator_11.Text = "Label_seperator_11"
        Me.Label_seperator_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_seperator_5
        '
        Me.Label_seperator_5.AutoSize = True
        Me.Label_seperator_5.Location = New System.Drawing.Point(926, 9)
        Me.Label_seperator_5.Name = "Label_seperator_5"
        Me.Label_seperator_5.Size = New System.Drawing.Size(95, 13)
        Me.Label_seperator_5.TabIndex = 31
        Me.Label_seperator_5.Text = "Label_seperator_5"
        Me.Label_seperator_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_customize
        '
        Me.Label_customize.AutoSize = True
        Me.Label_customize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_customize.Location = New System.Drawing.Point(1027, 9)
        Me.Label_customize.Name = "Label_customize"
        Me.Label_customize.Size = New System.Drawing.Size(86, 13)
        Me.Label_customize.TabIndex = 32
        Me.Label_customize.Text = "Label_customize"
        Me.Label_customize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_customize_explain_1
        '
        Me.Label_customize_explain_1.AutoSize = True
        Me.Label_customize_explain_1.Location = New System.Drawing.Point(304, 76)
        Me.Label_customize_explain_1.Name = "Label_customize_explain_1"
        Me.Label_customize_explain_1.Size = New System.Drawing.Size(137, 13)
        Me.Label_customize_explain_1.TabIndex = 33
        Me.Label_customize_explain_1.Text = "Label_customize_explain_1"
        Me.Label_customize_explain_1.Visible = False
        '
        'Label_customize_explain_2
        '
        Me.Label_customize_explain_2.AutoSize = True
        Me.Label_customize_explain_2.Location = New System.Drawing.Point(481, 76)
        Me.Label_customize_explain_2.Name = "Label_customize_explain_2"
        Me.Label_customize_explain_2.Size = New System.Drawing.Size(137, 13)
        Me.Label_customize_explain_2.TabIndex = 34
        Me.Label_customize_explain_2.Text = "Label_customize_explain_2"
        Me.Label_customize_explain_2.Visible = False
        '
        'TextBox_customize_number
        '
        Me.TextBox_customize_number.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_customize_number.ForeColor = System.Drawing.Color.Blue
        Me.TextBox_customize_number.Location = New System.Drawing.Point(438, 76)
        Me.TextBox_customize_number.MaxLength = 6
        Me.TextBox_customize_number.Name = "TextBox_customize_number"
        Me.TextBox_customize_number.Size = New System.Drawing.Size(40, 13)
        Me.TextBox_customize_number.TabIndex = 35
        Me.TextBox_customize_number.Text = "1234"
        Me.TextBox_customize_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox_customize_number.Visible = False
        '
        'PictureBox_reload_chart
        '
        Me.PictureBox_reload_chart.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.reload
        Me.PictureBox_reload_chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_reload_chart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_reload_chart.Location = New System.Drawing.Point(453, 95)
        Me.PictureBox_reload_chart.Name = "PictureBox_reload_chart"
        Me.PictureBox_reload_chart.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox_reload_chart.TabIndex = 36
        Me.PictureBox_reload_chart.TabStop = False
        Me.PictureBox_reload_chart.Visible = False
        '
        'PictureBox_default_setting
        '
        Me.PictureBox_default_setting.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.default_setting
        Me.PictureBox_default_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_default_setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_default_setting.Location = New System.Drawing.Point(231, 5)
        Me.PictureBox_default_setting.Name = "PictureBox_default_setting"
        Me.PictureBox_default_setting.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox_default_setting.TabIndex = 17
        Me.PictureBox_default_setting.TabStop = False
        '
        'PictureBox_chart_labels_visible
        '
        Me.PictureBox_chart_labels_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible
        Me.PictureBox_chart_labels_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_chart_labels_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_chart_labels_visible.Location = New System.Drawing.Point(200, 5)
        Me.PictureBox_chart_labels_visible.Name = "PictureBox_chart_labels_visible"
        Me.PictureBox_chart_labels_visible.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox_chart_labels_visible.TabIndex = 16
        Me.PictureBox_chart_labels_visible.TabStop = False
        '
        'PictureBox_nothing_to_show
        '
        Me.PictureBox_nothing_to_show.Image = Global.Smart_DiaScale_I.My.Resources.Resources.chart1
        Me.PictureBox_nothing_to_show.Location = New System.Drawing.Point(450, 220)
        Me.PictureBox_nothing_to_show.Name = "PictureBox_nothing_to_show"
        Me.PictureBox_nothing_to_show.Size = New System.Drawing.Size(300, 200)
        Me.PictureBox_nothing_to_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_nothing_to_show.TabIndex = 12
        Me.PictureBox_nothing_to_show.TabStop = False
        Me.PictureBox_nothing_to_show.Visible = False
        '
        'Form_dialysis_chart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 500)
        Me.Controls.Add(Me.PictureBox_reload_chart)
        Me.Controls.Add(Me.TextBox_customize_number)
        Me.Controls.Add(Me.Label_customize_explain_2)
        Me.Controls.Add(Me.Label_customize_explain_1)
        Me.Controls.Add(Me.Label_customize)
        Me.Controls.Add(Me.Label_seperator_5)
        Me.Controls.Add(Me.Label_seperator_11)
        Me.Controls.Add(Me.Label_seperator_10)
        Me.Controls.Add(Me.Label_seperator_9)
        Me.Controls.Add(Me.Label_seperator_8)
        Me.Controls.Add(Me.Label_seperator_7)
        Me.Controls.Add(Me.Label_seperator_6)
        Me.Controls.Add(Me.Label_chart_filter_all)
        Me.Controls.Add(Me.Label_chart_filter_bmi_all)
        Me.Controls.Add(Me.Label_chart_filter_weight_all)
        Me.Controls.Add(Me.Label_chart_filter_bmi_2)
        Me.Controls.Add(Me.Label_chart_filter_bmi_1)
        Me.Controls.Add(Me.Label_chart_filter_weight_2)
        Me.Controls.Add(Me.Label_chart_filter_weight_1)
        Me.Controls.Add(Me.PictureBox_default_setting)
        Me.Controls.Add(Me.PictureBox_chart_labels_visible)
        Me.Controls.Add(Me.TrackBar_chart_type)
        Me.Controls.Add(Me.Label_nothing_to_show)
        Me.Controls.Add(Me.PictureBox_nothing_to_show)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.Label_seperator_4)
        Me.Controls.Add(Me.Label_seperator_3)
        Me.Controls.Add(Me.Label_seperator_2)
        Me.Controls.Add(Me.Label_seperator_1)
        Me.Controls.Add(Me.Label_all)
        Me.Controls.Add(Me.Label_year)
        Me.Controls.Add(Me.Label_month)
        Me.Controls.Add(Me.Label_two_week)
        Me.Controls.Add(Me.Label_one_week)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_dialysis_chart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialysis Chart"
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_chart_type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_reload_chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_default_setting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_chart_labels_visible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_nothing_to_show, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_one_week As System.Windows.Forms.Label
    Friend WithEvents Label_two_week As System.Windows.Forms.Label
    Friend WithEvents Label_month As System.Windows.Forms.Label
    Friend WithEvents Label_year As System.Windows.Forms.Label
    Friend WithEvents Label_all As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_1 As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_2 As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_3 As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_4 As System.Windows.Forms.Label
    Friend WithEvents Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PictureBox_nothing_to_show As System.Windows.Forms.PictureBox
    Friend WithEvents Label_nothing_to_show As System.Windows.Forms.Label
    Friend WithEvents TrackBar_chart_type As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox_chart_labels_visible As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox_default_setting As System.Windows.Forms.PictureBox
    Friend WithEvents Label_chart_filter_weight_1 As System.Windows.Forms.Label
    Friend WithEvents Label_chart_filter_weight_2 As System.Windows.Forms.Label
    Friend WithEvents Label_chart_filter_bmi_1 As System.Windows.Forms.Label
    Friend WithEvents Label_chart_filter_bmi_2 As System.Windows.Forms.Label
    Friend WithEvents Label_chart_filter_weight_all As System.Windows.Forms.Label
    Friend WithEvents Label_chart_filter_bmi_all As System.Windows.Forms.Label
    Friend WithEvents Label_chart_filter_all As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_6 As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_7 As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_8 As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_9 As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_10 As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_11 As System.Windows.Forms.Label
    Friend WithEvents Label_seperator_5 As System.Windows.Forms.Label
    Friend WithEvents Label_customize As System.Windows.Forms.Label
    Friend WithEvents Label_customize_explain_1 As System.Windows.Forms.Label
    Friend WithEvents Label_customize_explain_2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_customize_number As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_reload_chart As System.Windows.Forms.PictureBox
End Class
