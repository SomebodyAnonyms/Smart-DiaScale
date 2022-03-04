
Public Class Form_dialysis_chart
    Dim PersianCalendar As New System.Globalization.PersianCalendar

    Dim Integer_chart_day As Integer
    Dim Integer_date_diff As Integer
    Dim Integer_row_number As Integer
    Dim Integer_chart_access As Integer
    Dim Integer_chart_labels_visible As Integer
    Dim MeasureString_Width As Integer
    Dim MeasureString_Height As Integer

    Dim Size_Of_String As New SizeF

    Dim Graphics As Graphics = Me.CreateGraphics

    Dim Date_today As Date
    Dim Date_dialysis As Date

    Dim Date_transfor_month As String
    Dim Date_transfor_day As String

    Private Sub Form_dialysis_chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public_Determine_Form = "Form_dialysis_chart"
        Public_Determine_Languages()

        Label_seperator_1.Text = "|"
        Label_seperator_2.Text = "|"
        Label_seperator_3.Text = "|"
        Label_seperator_4.Text = "|"
        Label_seperator_5.Text = "|"

        Label_month.Location = New Point((1200 - Label_month.Width) / 2, 10)
        Label_seperator_2.Location = New Point(Label_month.Location.X - Label_seperator_2.Width, 10)
        Label_two_week.Location = New Point(Label_seperator_2.Location.X - Label_two_week.Width, 10)
        Label_seperator_1.Location = New Point(Label_two_week.Location.X - Label_seperator_1.Width, 10)
        Label_one_week.Location = New Point(Label_seperator_1.Location.X - Label_one_week.Width, 10)
        Label_seperator_3.Location = New Point(Label_month.Location.X + Label_month.Width, 10)
        Label_year.Location = New Point((Label_seperator_3.Location.X + Label_seperator_3.Width), 10)
        Label_seperator_4.Location = New Point(Label_year.Location.X + Label_year.Width, 10)
        Label_all.Location = New Point((Label_seperator_4.Location.X + Label_seperator_4.Width), 10)
        Label_seperator_5.Location = New Point(Label_all.Location.X + Label_all.Width, 10)
        Label_customize.Location = New Point((Label_seperator_5.Location.X + Label_seperator_5.Width), 10)

        Label_two_week.ForeColor = Color.Black
        Label_month.ForeColor = Color.Black
        Label_year.ForeColor = Color.Black
        Label_all.ForeColor = Color.Black
        Label_customize.ForeColor = Color.Black
        Label_one_week.ForeColor = Color.Red



        Label_seperator_6.Text = "|"
        Label_seperator_7.Text = "|"
        Label_seperator_8.Text = "|"
        Label_seperator_9.Text = "|"
        Label_seperator_10.Text = "|"
        Label_seperator_11.Text = "|"

        Label_chart_filter_weight_1.Location = New Point(5, Me.Size.Height - Chart.Size.Height - Label_chart_filter_weight_1.Size.Height - 40)
        Label_seperator_6.Location = New Point(Label_chart_filter_weight_1.Location.X + Label_chart_filter_weight_1.Size.Width, Me.Size.Height - Chart.Size.Height - Label_seperator_6.Size.Height - 40)
        Label_chart_filter_weight_2.Location = New Point(Label_seperator_6.Location.X + Label_seperator_6.Size.Width, Me.Size.Height - Chart.Size.Height - Label_chart_filter_weight_2.Size.Height - 40)
        Label_seperator_7.Location = New Point(Label_chart_filter_weight_2.Location.X + Label_chart_filter_weight_2.Size.Width, Me.Size.Height - Chart.Size.Height - Label_seperator_7.Size.Height - 40)
        Label_chart_filter_bmi_1.Location = New Point(Label_seperator_7.Location.X + Label_seperator_7.Size.Width, Me.Size.Height - Chart.Size.Height - Label_chart_filter_bmi_1.Size.Height - 40)
        Label_seperator_8.Location = New Point(Label_chart_filter_bmi_1.Location.X + Label_chart_filter_bmi_1.Size.Width, Me.Size.Height - Chart.Size.Height - Label_seperator_8.Size.Height - 40)
        Label_chart_filter_bmi_2.Location = New Point(Label_seperator_8.Location.X + Label_seperator_8.Size.Width, Me.Size.Height - Chart.Size.Height - Label_chart_filter_bmi_2.Size.Height - 40)
        Label_seperator_9.Location = New Point(Label_chart_filter_bmi_2.Location.X + Label_chart_filter_bmi_2.Size.Width, Me.Size.Height - Chart.Size.Height - Label_seperator_9.Size.Height - 40)
        Label_chart_filter_weight_all.Location = New Point(Label_seperator_9.Location.X + Label_seperator_9.Size.Width, Me.Size.Height - Chart.Size.Height - Label_chart_filter_weight_all.Size.Height - 40)
        Label_seperator_10.Location = New Point(Label_chart_filter_weight_all.Location.X + Label_chart_filter_weight_all.Size.Width, Me.Size.Height - Chart.Size.Height - Label_seperator_10.Size.Height - 40)
        Label_chart_filter_bmi_all.Location = New Point(Label_seperator_10.Location.X + Label_seperator_10.Size.Width, Me.Size.Height - Chart.Size.Height - Label_chart_filter_bmi_all.Size.Height - 40)
        Label_seperator_11.Location = New Point(Label_chart_filter_bmi_all.Location.X + Label_chart_filter_bmi_all.Size.Width, Me.Size.Height - Chart.Size.Height - Label_seperator_11.Size.Height - 40)
        Label_chart_filter_all.Location = New Point(Label_seperator_11.Location.X + Label_seperator_11.Size.Width, Me.Size.Height - Chart.Size.Height - Label_chart_filter_all.Size.Height - 40)

        Label_chart_filter_weight_1.ForeColor = Color.Black
        Label_chart_filter_weight_2.ForeColor = Color.Black
        Label_chart_filter_bmi_1.ForeColor = Color.Black
        Label_chart_filter_bmi_2.ForeColor = Color.Black
        Label_chart_filter_weight_all.ForeColor = Color.Black
        Label_chart_filter_bmi_all.ForeColor = Color.Black
        Label_chart_filter_all.ForeColor = Color.Red



        Select Case My.Settings.Languages
            Case 1
                TrackBar_chart_type.Location = New Point(Label_chart_filter_all.Location.X + Label_chart_filter_all.Size.Width + 5, Me.Size.Height - Chart.Size.Height - TrackBar_chart_type.Size.Height - 25)
            Case 2
                TrackBar_chart_type.Location = New Point(Label_chart_filter_all.Location.X + Label_chart_filter_all.Size.Width + 5, Me.Size.Height - Chart.Size.Height - TrackBar_chart_type.Size.Height - 28)
            Case 3
                TrackBar_chart_type.Location = New Point(Label_chart_filter_all.Location.X + Label_chart_filter_all.Size.Width + 5, Me.Size.Height - Chart.Size.Height - TrackBar_chart_type.Size.Height - 28)
            Case 4
                TrackBar_chart_type.Location = New Point(Label_chart_filter_all.Location.X + Label_chart_filter_all.Size.Width + 5, Me.Size.Height - Chart.Size.Height - TrackBar_chart_type.Size.Height - 25)
        End Select


        Integer_chart_labels_visible = 1
        PictureBox_chart_labels_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_



        TextBox_customize_number.Text = 90
        Size_Of_String = Graphics.MeasureString(TextBox_customize_number.Text, Public_Microsoft_Tai_Le_Font_8_Bold)
        MeasureString_Width = Size_Of_String.Width
        MeasureString_Height = Size_Of_String.Height

        TextBox_customize_number.Size = New Size(MeasureString_Width, MeasureString_Height)
        Label_customize_explain_1.Location = New Point((Me.Size.Width - 16 - Label_customize_explain_1.Size.Width - TextBox_customize_number.Size.Width - Label_customize_explain_2.Size.Width) / 2, 70)
        TextBox_customize_number.Location = New Point(Label_customize_explain_1.Location.X + Label_customize_explain_1.Size.Width, ((Label_customize_explain_1.Size.Height - TextBox_customize_number.Size.Height) / 2) + Label_customize_explain_1.Location.Y)
        Label_customize_explain_2.Location = New Point(TextBox_customize_number.Location.X + TextBox_customize_number.Size.Width, 70)

        PictureBox_reload_chart.Location = New Point((Me.Size.Width - 16 - PictureBox_reload_chart.Size.Width) / 2, Label_customize_explain_1.Location.Y + Label_customize_explain_1.Size.Height + 5)
        PictureBox_reload_chart.Visible = False

        Label_customize_explain_1.Visible = False
        Label_customize_explain_2.Visible = False
        TextBox_customize_number.Visible = False
        PictureBox_reload_chart.Visible = False



        one_week()
        TrackBar_chart_type.Value = 2
        chart_type()

        Chart.Series(0).Enabled = True
        Chart.Series(1).Enabled = True
        Chart.Series(2).Enabled = True
        Chart.Series(3).Enabled = True
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'Key Control
    Private Sub Form_dialysis_chart_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_customize_number_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_customize_number.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                customize()
                PictureBox_reload_chart.Visible = False
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TrackBar_chart_type_KeyDown(sender As Object, e As KeyEventArgs) Handles TrackBar_chart_type.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If PictureBox_reload_chart.Visible = True Then
                    customize()
                    PictureBox_reload_chart.Visible = False
                End If
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'Objects
    Private Sub Label_one_week_Click(sender As Object, e As EventArgs) Handles Label_one_week.Click
        If Not Label_one_week.ForeColor = Color.Red Then
            Label_two_week.ForeColor = Color.Black
            Label_month.ForeColor = Color.Black
            Label_year.ForeColor = Color.Black
            Label_all.ForeColor = Color.Black
            Label_customize.ForeColor = Color.Black

            Label_one_week.ForeColor = Color.Red

            Label_customize_explain_1.Visible = False
            Label_customize_explain_2.Visible = False
            TextBox_customize_number.Visible = False
            PictureBox_reload_chart.Visible = False

            one_week()
        End If

    End Sub
    Private Sub Label_one_week_MouseEnter(sender As Object, e As EventArgs) Handles Label_one_week.MouseEnter
        If Not Label_one_week.ForeColor = Color.Red Then
            Label_one_week.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_one_week_MouseLeave(sender As Object, e As EventArgs) Handles Label_one_week.MouseLeave
        If Not Label_one_week.ForeColor = Color.Red Then
            Label_one_week.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_two_week_Click(sender As Object, e As EventArgs) Handles Label_two_week.Click
        If Not Label_two_week.ForeColor = Color.Red Then
            Label_one_week.ForeColor = Color.Black
            Label_month.ForeColor = Color.Black
            Label_year.ForeColor = Color.Black
            Label_all.ForeColor = Color.Black
            Label_customize.ForeColor = Color.Black

            Label_two_week.ForeColor = Color.Red

            Label_customize_explain_1.Visible = False
            Label_customize_explain_2.Visible = False
            TextBox_customize_number.Visible = False
            PictureBox_reload_chart.Visible = False

            two_week()
        End If
    End Sub
    Private Sub Label_two_week_MouseEnter(sender As Object, e As EventArgs) Handles Label_two_week.MouseEnter
        If Not Label_two_week.ForeColor = Color.Red Then
            Label_two_week.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_two_week_MouseLeave(sender As Object, e As EventArgs) Handles Label_two_week.MouseLeave
        If Not Label_two_week.ForeColor = Color.Red Then
            Label_two_week.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_month_Click(sender As Object, e As EventArgs) Handles Label_month.Click
        If Not Label_month.ForeColor = Color.Red Then
            Label_one_week.ForeColor = Color.Black
            Label_two_week.ForeColor = Color.Black
            Label_year.ForeColor = Color.Black
            Label_all.ForeColor = Color.Black
            Label_customize.ForeColor = Color.Black

            Label_month.ForeColor = Color.Red

            Label_customize_explain_1.Visible = False
            Label_customize_explain_2.Visible = False
            TextBox_customize_number.Visible = False
            PictureBox_reload_chart.Visible = False

            month()
        End If
    End Sub
    Private Sub Label_month_MouseEnter(sender As Object, e As EventArgs) Handles Label_month.MouseEnter
        If Not Label_month.ForeColor = Color.Red Then
            Label_month.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_month_MouseLeave(sender As Object, e As EventArgs) Handles Label_month.MouseLeave
        If Not Label_month.ForeColor = Color.Red Then
            Label_month.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_year_Click(sender As Object, e As EventArgs) Handles Label_year.Click
        If Not Label_year.ForeColor = Color.Red Then
            Label_one_week.ForeColor = Color.Black
            Label_two_week.ForeColor = Color.Black
            Label_month.ForeColor = Color.Black
            Label_all.ForeColor = Color.Black
            Label_customize.ForeColor = Color.Black

            Label_year.ForeColor = Color.Red

            Label_customize_explain_1.Visible = False
            Label_customize_explain_2.Visible = False
            TextBox_customize_number.Visible = False
            PictureBox_reload_chart.Visible = False

            year()
        End If
    End Sub
    Private Sub Label_year_MouseEnter(sender As Object, e As EventArgs) Handles Label_year.MouseEnter
        If Not Label_year.ForeColor = Color.Red Then
            Label_year.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_year_MouseLeave(sender As Object, e As EventArgs) Handles Label_year.MouseLeave
        If Not Label_year.ForeColor = Color.Red Then
            Label_year.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_all_Click(sender As Object, e As EventArgs) Handles Label_all.Click
        If Not Label_all.ForeColor = Color.Red Then
            Label_one_week.ForeColor = Color.Black
            Label_two_week.ForeColor = Color.Black
            Label_month.ForeColor = Color.Black
            Label_year.ForeColor = Color.Black
            Label_customize.ForeColor = Color.Black

            Label_all.ForeColor = Color.Red

            Label_customize_explain_1.Visible = False
            Label_customize_explain_2.Visible = False
            TextBox_customize_number.Visible = False
            PictureBox_reload_chart.Visible = False

            all()
        End If
    End Sub
    Private Sub Label_all_MouseEnter(sender As Object, e As EventArgs) Handles Label_all.MouseEnter
        If Not Label_all.ForeColor = Color.Red Then
            Label_all.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_all_MouseLeave(sender As Object, e As EventArgs) Handles Label_all.MouseLeave
        If Not Label_all.ForeColor = Color.Red Then
            Label_all.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_customize_Click(sender As Object, e As EventArgs) Handles Label_customize.Click
        If Not Label_customize.ForeColor = Color.Red Then
            Label_one_week.ForeColor = Color.Black
            Label_two_week.ForeColor = Color.Black
            Label_month.ForeColor = Color.Black
            Label_year.ForeColor = Color.Black
            Label_all.ForeColor = Color.Black

            Label_customize.ForeColor = Color.Red

            Label_customize_explain_1.Visible = True
            Label_customize_explain_2.Visible = True
            TextBox_customize_number.Visible = True

            customize()
        End If
    End Sub
    Private Sub Label_customize_MouseEnter(sender As Object, e As EventArgs) Handles Label_customize.MouseEnter
        If Not Label_customize.ForeColor = Color.Red Then
            Label_customize.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_customize_MouseLeave(sender As Object, e As EventArgs) Handles Label_customize.MouseLeave
        If Not Label_customize.ForeColor = Color.Red Then
            Label_customize.ForeColor = Color.Black
        End If
    End Sub



    Private Sub Label_chart_filter_weight_1_Click(sender As Object, e As EventArgs) Handles Label_chart_filter_weight_1.Click
        If Not Label_chart_filter_weight_1.ForeColor = Color.Red Then
            Label_chart_filter_weight_2.ForeColor = Color.Black
            Label_chart_filter_bmi_1.ForeColor = Color.Black
            Label_chart_filter_bmi_2.ForeColor = Color.Black
            Label_chart_filter_weight_all.ForeColor = Color.Black
            Label_chart_filter_bmi_all.ForeColor = Color.Black
            Label_chart_filter_all.ForeColor = Color.Black

            Label_chart_filter_weight_1.ForeColor = Color.Red

            If Label_one_week.ForeColor = Color.Red Then one_week()
            If Label_two_week.ForeColor = Color.Red Then two_week()
            If Label_month.ForeColor = Color.Red Then month()
            If Label_year.ForeColor = Color.Red Then year()
            If Label_all.ForeColor = Color.Red Then all()
            If Label_customize.ForeColor = Color.Red Then customize()

            Chart.Series(0).Enabled = True
            Chart.Series(1).Enabled = False
            Chart.Series(2).Enabled = False
            Chart.Series(3).Enabled = False
        End If
    End Sub
    Private Sub Label_chart_filter_weight_1_MouseEnter(sender As Object, e As EventArgs) Handles Label_chart_filter_weight_1.MouseEnter
        If Not Label_chart_filter_weight_1.ForeColor = Color.Red Then
            Label_chart_filter_weight_1.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_chart_filter_weight_1_MouseLeave(sender As Object, e As EventArgs) Handles Label_chart_filter_weight_1.MouseLeave
        If Not Label_chart_filter_weight_1.ForeColor = Color.Red Then
            Label_chart_filter_weight_1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_chart_filter_weight_2_Click(sender As Object, e As EventArgs) Handles Label_chart_filter_weight_2.Click
        If Not Label_chart_filter_weight_2.ForeColor = Color.Red Then
            Label_chart_filter_weight_1.ForeColor = Color.Black
            Label_chart_filter_bmi_1.ForeColor = Color.Black
            Label_chart_filter_bmi_2.ForeColor = Color.Black
            Label_chart_filter_weight_all.ForeColor = Color.Black
            Label_chart_filter_bmi_all.ForeColor = Color.Black
            Label_chart_filter_all.ForeColor = Color.Black

            Label_chart_filter_weight_2.ForeColor = Color.Red

            If Label_one_week.ForeColor = Color.Red Then one_week()
            If Label_two_week.ForeColor = Color.Red Then two_week()
            If Label_month.ForeColor = Color.Red Then month()
            If Label_year.ForeColor = Color.Red Then year()
            If Label_all.ForeColor = Color.Red Then all()
            If Label_customize.ForeColor = Color.Red Then customize()

            Chart.Series(0).Enabled = False
            Chart.Series(1).Enabled = True
            Chart.Series(2).Enabled = False
            Chart.Series(3).Enabled = False
        End If
    End Sub
    Private Sub Label_chart_filter_weight_2_MouseEnter(sender As Object, e As EventArgs) Handles Label_chart_filter_weight_2.MouseEnter
        If Not Label_chart_filter_weight_2.ForeColor = Color.Red Then
            Label_chart_filter_weight_2.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_chart_filter_weight_2_MouseLeave(sender As Object, e As EventArgs) Handles Label_chart_filter_weight_2.MouseLeave
        If Not Label_chart_filter_weight_2.ForeColor = Color.Red Then
            Label_chart_filter_weight_2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_chart_filter_bmi_1_Click(sender As Object, e As EventArgs) Handles Label_chart_filter_bmi_1.Click
        If Not Label_chart_filter_bmi_1.ForeColor = Color.Red Then
            Label_chart_filter_weight_1.ForeColor = Color.Black
            Label_chart_filter_weight_2.ForeColor = Color.Black
            Label_chart_filter_bmi_2.ForeColor = Color.Black
            Label_chart_filter_weight_all.ForeColor = Color.Black
            Label_chart_filter_bmi_all.ForeColor = Color.Black
            Label_chart_filter_all.ForeColor = Color.Black

            Label_chart_filter_bmi_1.ForeColor = Color.Red

            If Label_one_week.ForeColor = Color.Red Then one_week()
            If Label_two_week.ForeColor = Color.Red Then two_week()
            If Label_month.ForeColor = Color.Red Then month()
            If Label_year.ForeColor = Color.Red Then year()
            If Label_all.ForeColor = Color.Red Then all()
            If Label_customize.ForeColor = Color.Red Then customize()

            Chart.Series(0).Enabled = False
            Chart.Series(1).Enabled = False
            Chart.Series(2).Enabled = True
            Chart.Series(3).Enabled = False
        End If
    End Sub
    Private Sub Label_chart_filter_bmi_1_MouseEnter(sender As Object, e As EventArgs) Handles Label_chart_filter_bmi_1.MouseEnter
        If Not Label_chart_filter_bmi_1.ForeColor = Color.Red Then
            Label_chart_filter_bmi_1.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_chart_filter_bmi_1_MouseLeave(sender As Object, e As EventArgs) Handles Label_chart_filter_bmi_1.MouseLeave
        If Not Label_chart_filter_bmi_1.ForeColor = Color.Red Then
            Label_chart_filter_bmi_1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_chart_filter_bmi_2_Click(sender As Object, e As EventArgs) Handles Label_chart_filter_bmi_2.Click
        If Not Label_chart_filter_bmi_2.ForeColor = Color.Red Then
            Label_chart_filter_weight_1.ForeColor = Color.Black
            Label_chart_filter_weight_2.ForeColor = Color.Black
            Label_chart_filter_bmi_1.ForeColor = Color.Black
            Label_chart_filter_weight_all.ForeColor = Color.Black
            Label_chart_filter_bmi_all.ForeColor = Color.Black
            Label_chart_filter_all.ForeColor = Color.Black

            Label_chart_filter_bmi_2.ForeColor = Color.Red

            If Label_one_week.ForeColor = Color.Red Then one_week()
            If Label_two_week.ForeColor = Color.Red Then two_week()
            If Label_month.ForeColor = Color.Red Then month()
            If Label_year.ForeColor = Color.Red Then year()
            If Label_all.ForeColor = Color.Red Then all()
            If Label_customize.ForeColor = Color.Red Then customize()

            Chart.Series(0).Enabled = False
            Chart.Series(1).Enabled = False
            Chart.Series(2).Enabled = False
            Chart.Series(3).Enabled = True
        End If
    End Sub
    Private Sub Label_chart_filter_bmi_2_MouseEnter(sender As Object, e As EventArgs) Handles Label_chart_filter_bmi_2.MouseEnter
        If Not Label_chart_filter_bmi_2.ForeColor = Color.Red Then
            Label_chart_filter_bmi_2.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_chart_filter_bmi_2_MouseLeave(sender As Object, e As EventArgs) Handles Label_chart_filter_bmi_2.MouseLeave
        If Not Label_chart_filter_bmi_2.ForeColor = Color.Red Then
            Label_chart_filter_bmi_2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_chart_filter_weight_all_Click(sender As Object, e As EventArgs) Handles Label_chart_filter_weight_all.Click
        If Not Label_chart_filter_weight_all.ForeColor = Color.Red Then
            Label_chart_filter_weight_1.ForeColor = Color.Black
            Label_chart_filter_weight_2.ForeColor = Color.Black
            Label_chart_filter_bmi_1.ForeColor = Color.Black
            Label_chart_filter_bmi_2.ForeColor = Color.Black
            Label_chart_filter_bmi_all.ForeColor = Color.Black
            Label_chart_filter_all.ForeColor = Color.Black

            Label_chart_filter_weight_all.ForeColor = Color.Red

            If Label_one_week.ForeColor = Color.Red Then one_week()
            If Label_two_week.ForeColor = Color.Red Then two_week()
            If Label_month.ForeColor = Color.Red Then month()
            If Label_year.ForeColor = Color.Red Then year()
            If Label_all.ForeColor = Color.Red Then all()
            If Label_customize.ForeColor = Color.Red Then customize()

            Chart.Series(0).Enabled = True
            Chart.Series(1).Enabled = True
            Chart.Series(2).Enabled = False
            Chart.Series(3).Enabled = False
        End If
    End Sub
    Private Sub Label_chart_filter_weight_all_MouseEnter(sender As Object, e As EventArgs) Handles Label_chart_filter_weight_all.MouseEnter
        If Not Label_chart_filter_weight_all.ForeColor = Color.Red Then
            Label_chart_filter_weight_all.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_chart_filter_weight_all_MouseLeave(sender As Object, e As EventArgs) Handles Label_chart_filter_weight_all.MouseLeave
        If Not Label_chart_filter_weight_all.ForeColor = Color.Red Then
            Label_chart_filter_weight_all.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_chart_filter_bmi_all_Click(sender As Object, e As EventArgs) Handles Label_chart_filter_bmi_all.Click
        If Not Label_chart_filter_bmi_all.ForeColor = Color.Red Then
            Label_chart_filter_weight_1.ForeColor = Color.Black
            Label_chart_filter_weight_2.ForeColor = Color.Black
            Label_chart_filter_bmi_1.ForeColor = Color.Black
            Label_chart_filter_bmi_2.ForeColor = Color.Black
            Label_chart_filter_weight_all.ForeColor = Color.Black
            Label_chart_filter_all.ForeColor = Color.Black

            Label_chart_filter_bmi_all.ForeColor = Color.Red

            If Label_one_week.ForeColor = Color.Red Then one_week()
            If Label_two_week.ForeColor = Color.Red Then two_week()
            If Label_month.ForeColor = Color.Red Then month()
            If Label_year.ForeColor = Color.Red Then year()
            If Label_all.ForeColor = Color.Red Then all()
            If Label_customize.ForeColor = Color.Red Then customize()

            Chart.Series(0).Enabled = False
            Chart.Series(1).Enabled = False
            Chart.Series(2).Enabled = True
            Chart.Series(3).Enabled = True
        End If
    End Sub
    Private Sub Label_chart_filter_bmi_all_MouseEnter(sender As Object, e As EventArgs) Handles Label_chart_filter_bmi_all.MouseEnter
        If Not Label_chart_filter_bmi_all.ForeColor = Color.Red Then
            Label_chart_filter_bmi_all.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_chart_filter_bmi_all_MouseLeave(sender As Object, e As EventArgs) Handles Label_chart_filter_bmi_all.MouseLeave
        If Not Label_chart_filter_bmi_all.ForeColor = Color.Red Then
            Label_chart_filter_bmi_all.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_chart_filter_all_Click(sender As Object, e As EventArgs) Handles Label_chart_filter_all.Click
        If Not Label_chart_filter_all.ForeColor = Color.Red Then
            Label_chart_filter_weight_1.ForeColor = Color.Black
            Label_chart_filter_weight_2.ForeColor = Color.Black
            Label_chart_filter_bmi_1.ForeColor = Color.Black
            Label_chart_filter_bmi_2.ForeColor = Color.Black
            Label_chart_filter_weight_all.ForeColor = Color.Black
            Label_chart_filter_bmi_all.ForeColor = Color.Black

            Label_chart_filter_all.ForeColor = Color.Red

            If Label_one_week.ForeColor = Color.Red Then one_week()
            If Label_two_week.ForeColor = Color.Red Then two_week()
            If Label_month.ForeColor = Color.Red Then month()
            If Label_year.ForeColor = Color.Red Then year()
            If Label_all.ForeColor = Color.Red Then all()
            If Label_customize.ForeColor = Color.Red Then customize()

            Chart.Series(0).Enabled = True
            Chart.Series(1).Enabled = True
            Chart.Series(2).Enabled = True
            Chart.Series(3).Enabled = True
        End If
    End Sub
    Private Sub Label_chart_filter_all_MouseEnter(sender As Object, e As EventArgs) Handles Label_chart_filter_all.MouseEnter
        If Not Label_chart_filter_all.ForeColor = Color.Red Then
            Label_chart_filter_all.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub Label_chart_filter_all_MouseLeave(sender As Object, e As EventArgs) Handles Label_chart_filter_all.MouseLeave
        If Not Label_chart_filter_all.ForeColor = Color.Red Then
            Label_chart_filter_all.ForeColor = Color.Black
        End If
    End Sub


    Private Sub TrackBar_chart_type_Scroll(sender As Object, e As EventArgs) Handles TrackBar_chart_type.Scroll
        chart_type()
    End Sub


    Private Sub PictureBox_chart_labels_visible_Click(sender As Object, e As EventArgs) Handles PictureBox_chart_labels_visible.Click
        If Chart.Visible = True Then
            If Chart.Series(0).Points(0).Label = String.Empty Then
                For i = 0 To Chart.Series(0).Points.Count - 1
                    Chart.Series(0).Points(i).Label = Chart.Series(0).Points(i).YValues(0)
                    Chart.Series(1).Points(i).Label = Chart.Series(1).Points(i).YValues(0)
                    Chart.Series(2).Points(i).Label = Chart.Series(2).Points(i).YValues(0)
                    Chart.Series(3).Points(i).Label = Chart.Series(3).Points(i).YValues(0)
                Next
                Integer_chart_labels_visible = 1
                PictureBox_chart_labels_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
                Select Case My.Settings.Languages
                    Case 1
                        ToolTip.SetToolTip(PictureBox_chart_labels_visible, "Hide chart numbers")
                    Case 2
                        ToolTip.SetToolTip(PictureBox_chart_labels_visible, "مخفی کردن اعداد نمودار")
                    Case 3
                        ToolTip.SetToolTip(PictureBox_chart_labels_visible, "إخفاء أرقام المخطط")
                    Case 4
                        ToolTip.SetToolTip(PictureBox_chart_labels_visible, "Ocultar números de gráfico")
                End Select
            Else
                For i = 0 To Chart.Series(0).Points.Count - 1
                    Chart.Series(0).Points(i).Label = String.Empty
                    Chart.Series(1).Points(i).Label = String.Empty
                    Chart.Series(2).Points(i).Label = String.Empty
                    Chart.Series(3).Points(i).Label = String.Empty
                Next
                PictureBox_chart_labels_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
                Integer_chart_labels_visible = 2
                Select Case My.Settings.Languages
                    Case 1
                        ToolTip.SetToolTip(PictureBox_chart_labels_visible, "Show chart numbers")
                    Case 2
                        ToolTip.SetToolTip(PictureBox_chart_labels_visible, "نمایش اعداد نمودار")
                    Case 3
                        ToolTip.SetToolTip(PictureBox_chart_labels_visible, "عرض أرقام الرسم البياني")
                    Case 4
                        ToolTip.SetToolTip(PictureBox_chart_labels_visible, "Mostrar números de gráfico")
                End Select
            End If
        End If
    End Sub
    Private Sub PictureBox_chart_labels_visible_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_chart_labels_visible.MouseEnter
        PictureBox_chart_labels_visible.Size = New Size(PictureBox_chart_labels_visible.Size.Width + 3, PictureBox_chart_labels_visible.Size.Height + 3)
        PictureBox_chart_labels_visible.Location = New Point(PictureBox_chart_labels_visible.Location.X - 1.5, PictureBox_chart_labels_visible.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_chart_labels_visible_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_chart_labels_visible.MouseLeave
        PictureBox_chart_labels_visible.Size = New Size(PictureBox_chart_labels_visible.Size.Width - 3, PictureBox_chart_labels_visible.Size.Height - 3)
        PictureBox_chart_labels_visible.Location = New Point(PictureBox_chart_labels_visible.Location.X + 1.5, PictureBox_chart_labels_visible.Location.Y + 1.5)
    End Sub

    Private Sub PictureBox_default_setting_Click(sender As Object, e As EventArgs) Handles PictureBox_default_setting.Click
        If Chart.Visible = True Then
            Chart.Series(0).Enabled = True
            Chart.Series(1).Enabled = True
            Chart.Series(2).Enabled = True
            Chart.Series(3).Enabled = True

            TrackBar_chart_type.Value = 2
            chart_type()

            Label_chart_filter_weight_1.ForeColor = Color.Black
            Label_chart_filter_weight_2.ForeColor = Color.Black
            Label_chart_filter_bmi_1.ForeColor = Color.Black
            Label_chart_filter_bmi_2.ForeColor = Color.Black
            Label_chart_filter_weight_all.ForeColor = Color.Black
            Label_chart_filter_bmi_all.ForeColor = Color.Black
            Label_chart_filter_all.ForeColor = Color.Red

            For i = 0 To Chart.Series(0).Points.Count - 1
                Chart.Series(0).Points(i).Label = Chart.Series(0).Points(i).YValues(0)
                Chart.Series(1).Points(i).Label = Chart.Series(1).Points(i).YValues(0)
                Chart.Series(2).Points(i).Label = Chart.Series(2).Points(i).YValues(0)
                Chart.Series(3).Points(i).Label = Chart.Series(3).Points(i).YValues(0)
            Next
            Integer_chart_labels_visible = 1
            PictureBox_chart_labels_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
            Select Case My.Settings.Languages
                Case 1
                    ToolTip.SetToolTip(PictureBox_chart_labels_visible, "Hide chart numbers")
                Case 2
                    ToolTip.SetToolTip(PictureBox_chart_labels_visible, "مخفی کردن اعداد نمودار")
                Case 3
                    ToolTip.SetToolTip(PictureBox_chart_labels_visible, "إخفاء أرقام المخطط")
                Case 4
                    ToolTip.SetToolTip(PictureBox_chart_labels_visible, "Ocultar números de gráfico")
            End Select
        End If
    End Sub
    Private Sub PictureBox_default_setting_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_default_setting.MouseEnter
        PictureBox_default_setting.Size = New Size(PictureBox_default_setting.Size.Width + 3, PictureBox_default_setting.Size.Height + 3)
        PictureBox_default_setting.Location = New Point(PictureBox_default_setting.Location.X - 1.5, PictureBox_default_setting.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_default_setting_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_default_setting.MouseLeave
        PictureBox_default_setting.Size = New Size(PictureBox_default_setting.Size.Width - 3, PictureBox_default_setting.Size.Height - 3)
        PictureBox_default_setting.Location = New Point(PictureBox_default_setting.Location.X + 1.5, PictureBox_default_setting.Location.Y + 1.5)
    End Sub


    Private Sub TextBox_customize_number_TextChanged(sender As Object, e As EventArgs) Handles TextBox_customize_number.TextChanged
        TextBox_customize_number.Text = Val(TextBox_customize_number.Text)

        Size_Of_String = Graphics.MeasureString(TextBox_customize_number.Text, Public_Microsoft_Tai_Le_Font_8_Bold)
        MeasureString_Width = Size_Of_String.Width
        MeasureString_Height = Size_Of_String.Height

        TextBox_customize_number.Size = New Size(MeasureString_Width, MeasureString_Height)
        Label_customize_explain_1.Location = New Point((Me.Size.Width - 16 - Label_customize_explain_1.Size.Width - TextBox_customize_number.Size.Width - Label_customize_explain_2.Size.Width) / 2, 70)
        TextBox_customize_number.Location = New Point(Label_customize_explain_1.Location.X + Label_customize_explain_1.Size.Width, ((Label_customize_explain_1.Size.Height - TextBox_customize_number.Size.Height) / 2) + Label_customize_explain_1.Location.Y)
        Label_customize_explain_2.Location = New Point(TextBox_customize_number.Location.X + TextBox_customize_number.Size.Width, 70)

        PictureBox_reload_chart.Visible = True
    End Sub

    Private Sub PictureBox_reload_chart_Click(sender As Object, e As EventArgs) Handles PictureBox_reload_chart.Click
        customize()
        PictureBox_reload_chart.Visible = False
    End Sub
    Private Sub PictureBox_reload_chart_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_reload_chart.MouseEnter
        PictureBox_reload_chart.Size = New Size(PictureBox_reload_chart.Size.Width + 3, PictureBox_reload_chart.Size.Height + 3)
        PictureBox_reload_chart.Location = New Point(PictureBox_reload_chart.Location.X - 1.5, PictureBox_reload_chart.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_reload_chart_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_reload_chart.MouseLeave
        PictureBox_reload_chart.Size = New Size(PictureBox_reload_chart.Size.Width - 3, PictureBox_reload_chart.Size.Height - 3)
        PictureBox_reload_chart.Location = New Point(PictureBox_reload_chart.Location.X + 1.5, PictureBox_reload_chart.Location.Y + 1.5)
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'Chart Calcute
    Sub one_week()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Integer_row_number = 0
        Integer_chart_access = 0
        Integer_date_diff = 0
        Integer_chart_day = 7

        PictureBox_chart_labels_visible.Visible = True
        PictureBox_default_setting.Visible = True
        Label_chart_filter_weight_1.Visible = True
        Label_chart_filter_weight_2.Visible = True
        Label_chart_filter_bmi_1.Visible = True
        Label_chart_filter_bmi_2.Visible = True
        Label_chart_filter_weight_all.Visible = True
        Label_chart_filter_bmi_all.Visible = True
        Label_chart_filter_all.Visible = True
        Label_seperator_6.Visible = True
        Label_seperator_7.Visible = True
        Label_seperator_8.Visible = True
        Label_seperator_9.Visible = True
        Label_seperator_10.Visible = True
        Label_seperator_11.Visible = True
        TrackBar_chart_type.Visible = True
        Chart.Visible = True
        PictureBox_nothing_to_show.Visible = False
        Label_nothing_to_show.Visible = False

        Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        Select Case My.Settings.Languages
            Case 1
                Date_today = Now.Date
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
            Case 2
                Date_today = PersianDate(Now.Date)
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
        End Select

        Chart.Series(0).Points.Clear()
        Chart.Series(1).Points.Clear()
        Chart.Series(2).Points.Clear()
        Chart.Series(3).Points.Clear()

        If Integer_chart_access = 1 Then
            For i = 0 To Integer_row_number
                Chart.Series(0).Points.Add(i)
                Chart.Series(0).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Chart.Series(0).Points(i).Color = Color.Green
                Chart.Series(0).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(0).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(0).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(0).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(0).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاريخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(0).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(0).Points(i).MarkerColor = Color.Blue
                Chart.Series(0).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(0).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(0).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(0).Points(i).MarkerSize = 10



                Chart.Series(1).Points.Add(i)
                Chart.Series(1).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Chart.Series(1).Points(i).Color = Color.Fuchsia
                Chart.Series(1).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(1).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(1).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(1).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(1).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(1).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(1).Points(i).MarkerColor = Color.Blue
                Chart.Series(1).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(1).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(1).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(1).Points(i).MarkerSize = 10



                Chart.Series(2).Points.Add(i)
                Chart.Series(2).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Chart.Series(2).Points(i).Color = Color.Orange
                Chart.Series(2).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(2).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(2).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(2).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(2).Points(i).MarkerColor = Color.Blue
                Chart.Series(2).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(2).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(2).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(2).Points(i).MarkerSize = 10



                Chart.Series(3).Points.Add(i)
                Chart.Series(3).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Chart.Series(3).Points(i).Color = Color.Purple
                Chart.Series(3).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(3).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(3).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(3).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(3).Points(i).MarkerColor = Color.Blue
                Chart.Series(3).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(3).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(3).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(3).Points(i).MarkerSize = 10
            Next
        Else
            PictureBox_chart_labels_visible.Visible = False
            PictureBox_default_setting.Visible = False
            Label_chart_filter_weight_1.Visible = False
            Label_chart_filter_weight_2.Visible = False
            Label_chart_filter_bmi_1.Visible = False
            Label_chart_filter_bmi_2.Visible = False
            Label_chart_filter_weight_all.Visible = False
            Label_chart_filter_bmi_all.Visible = False
            Label_chart_filter_all.Visible = False
            Label_seperator_6.Visible = False
            Label_seperator_7.Visible = False
            Label_seperator_8.Visible = False
            Label_seperator_9.Visible = False
            Label_seperator_10.Visible = False
            Label_seperator_11.Visible = False
            TrackBar_chart_type.Visible = False
            Chart.Visible = False
            PictureBox_nothing_to_show.Visible = True
            Label_nothing_to_show.Visible = True
            Label_nothing_to_show.BringToFront()
        End If

        Chart.Series(0).Color = Color.Green
        Chart.Series(1).Color = Color.Fuchsia
        Chart.Series(2).Color = Color.Orange
        Chart.Series(3).Color = Color.Purple

        chart_type()

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Sub two_week()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Integer_row_number = 0
        Integer_chart_access = 0
        Integer_date_diff = 0
        Integer_chart_day = 14

        PictureBox_chart_labels_visible.Visible = True
        PictureBox_default_setting.Visible = True
        Label_chart_filter_weight_1.Visible = True
        Label_chart_filter_weight_2.Visible = True
        Label_chart_filter_bmi_1.Visible = True
        Label_chart_filter_bmi_2.Visible = True
        Label_chart_filter_weight_all.Visible = True
        Label_chart_filter_bmi_all.Visible = True
        Label_chart_filter_all.Visible = True
        Label_seperator_6.Visible = True
        Label_seperator_7.Visible = True
        Label_seperator_8.Visible = True
        Label_seperator_9.Visible = True
        Label_seperator_10.Visible = True
        Label_seperator_11.Visible = True
        TrackBar_chart_type.Visible = True
        Chart.Visible = True
        PictureBox_nothing_to_show.Visible = False
        Label_nothing_to_show.Visible = False

        Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        Select Case My.Settings.Languages
            Case 1
                Date_today = Now.Date
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
            Case 2
                Date_today = PersianDate(Now.Date)
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
        End Select

        Chart.Series(0).Points.Clear()
        Chart.Series(1).Points.Clear()
        Chart.Series(2).Points.Clear()
        Chart.Series(3).Points.Clear()

        If Integer_chart_access = 1 Then
            For i = 0 To Integer_row_number
                Chart.Series(0).Points.Add(i)
                Chart.Series(0).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Chart.Series(0).Points(i).Color = Color.Green
                Chart.Series(0).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(0).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(0).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(0).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(0).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاريخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(0).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(0).Points(i).MarkerColor = Color.Blue
                Chart.Series(0).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(0).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(0).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(0).Points(i).MarkerSize = 10



                Chart.Series(1).Points.Add(i)
                Chart.Series(1).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Chart.Series(1).Points(i).Color = Color.Fuchsia
                Chart.Series(1).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(1).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(1).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(1).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(1).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(1).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(1).Points(i).MarkerColor = Color.Blue
                Chart.Series(1).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(1).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(1).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(1).Points(i).MarkerSize = 10



                Chart.Series(2).Points.Add(i)
                Chart.Series(2).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Chart.Series(2).Points(i).Color = Color.Orange
                Chart.Series(2).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(2).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(2).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(2).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(2).Points(i).MarkerColor = Color.Blue
                Chart.Series(2).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(2).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(2).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(2).Points(i).MarkerSize = 10



                Chart.Series(3).Points.Add(i)
                Chart.Series(3).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Chart.Series(3).Points(i).Color = Color.Purple
                Chart.Series(3).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(3).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(3).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(3).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(3).Points(i).MarkerColor = Color.Blue
                Chart.Series(3).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(3).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(3).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(3).Points(i).MarkerSize = 10
            Next
        Else
            PictureBox_chart_labels_visible.Visible = False
            PictureBox_default_setting.Visible = False
            Label_chart_filter_weight_1.Visible = False
            Label_chart_filter_weight_2.Visible = False
            Label_chart_filter_bmi_1.Visible = False
            Label_chart_filter_bmi_2.Visible = False
            Label_chart_filter_weight_all.Visible = False
            Label_chart_filter_bmi_all.Visible = False
            Label_chart_filter_all.Visible = False
            Label_seperator_6.Visible = False
            Label_seperator_7.Visible = False
            Label_seperator_8.Visible = False
            Label_seperator_9.Visible = False
            Label_seperator_10.Visible = False
            Label_seperator_11.Visible = False
            TrackBar_chart_type.Visible = False
            Chart.Visible = False
            PictureBox_nothing_to_show.Visible = True
            Label_nothing_to_show.Visible = True
            Label_nothing_to_show.BringToFront()
        End If

        Chart.Series(0).Color = Color.Green
        Chart.Series(1).Color = Color.Fuchsia
        Chart.Series(2).Color = Color.Orange
        Chart.Series(3).Color = Color.Purple

        chart_type()

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Sub month()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Integer_row_number = 0
        Integer_chart_access = 0
        Integer_date_diff = 0
        Integer_chart_day = 30

        PictureBox_chart_labels_visible.Visible = True
        PictureBox_default_setting.Visible = True
        Label_chart_filter_weight_1.Visible = True
        Label_chart_filter_weight_2.Visible = True
        Label_chart_filter_bmi_1.Visible = True
        Label_chart_filter_bmi_2.Visible = True
        Label_chart_filter_weight_all.Visible = True
        Label_chart_filter_bmi_all.Visible = True
        Label_chart_filter_all.Visible = True
        Label_seperator_6.Visible = True
        Label_seperator_7.Visible = True
        Label_seperator_8.Visible = True
        Label_seperator_9.Visible = True
        Label_seperator_10.Visible = True
        Label_seperator_11.Visible = True
        TrackBar_chart_type.Visible = True
        Chart.Visible = True
        PictureBox_nothing_to_show.Visible = False
        Label_nothing_to_show.Visible = False

        Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        Select Case My.Settings.Languages
            Case 1
                Date_today = Now.Date
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
            Case 2
                Date_today = PersianDate(Now.Date)
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
        End Select

        Chart.Series(0).Points.Clear()
        Chart.Series(1).Points.Clear()
        Chart.Series(2).Points.Clear()
        Chart.Series(3).Points.Clear()

        If Integer_chart_access = 1 Then
            For i = 0 To Integer_row_number
                Chart.Series(0).Points.Add(i)
                Chart.Series(0).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Chart.Series(0).Points(i).Color = Color.Green
                Chart.Series(0).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(0).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(0).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(0).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(0).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاريخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(0).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(0).Points(i).MarkerColor = Color.Blue
                Chart.Series(0).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(0).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(0).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(0).Points(i).MarkerSize = 10



                Chart.Series(1).Points.Add(i)
                Chart.Series(1).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Chart.Series(1).Points(i).Color = Color.Fuchsia
                Chart.Series(1).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(1).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(1).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(1).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(1).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(1).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(1).Points(i).MarkerColor = Color.Blue
                Chart.Series(1).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(1).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(1).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(1).Points(i).MarkerSize = 10



                Chart.Series(2).Points.Add(i)
                Chart.Series(2).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Chart.Series(2).Points(i).Color = Color.Orange
                Chart.Series(2).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(2).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(2).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(2).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(2).Points(i).MarkerColor = Color.Blue
                Chart.Series(2).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(2).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(2).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(2).Points(i).MarkerSize = 10



                Chart.Series(3).Points.Add(i)
                Chart.Series(3).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Chart.Series(3).Points(i).Color = Color.Purple
                Chart.Series(3).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(3).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(3).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(3).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(3).Points(i).MarkerColor = Color.Blue
                Chart.Series(3).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(3).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(3).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(3).Points(i).MarkerSize = 10
            Next
        Else
            PictureBox_chart_labels_visible.Visible = False
            PictureBox_default_setting.Visible = False
            Label_chart_filter_weight_1.Visible = False
            Label_chart_filter_weight_2.Visible = False
            Label_chart_filter_bmi_1.Visible = False
            Label_chart_filter_bmi_2.Visible = False
            Label_chart_filter_weight_all.Visible = False
            Label_chart_filter_bmi_all.Visible = False
            Label_chart_filter_all.Visible = False
            Label_seperator_6.Visible = False
            Label_seperator_7.Visible = False
            Label_seperator_8.Visible = False
            Label_seperator_9.Visible = False
            Label_seperator_10.Visible = False
            Label_seperator_11.Visible = False
            TrackBar_chart_type.Visible = False
            Chart.Visible = False
            PictureBox_nothing_to_show.Visible = True
            Label_nothing_to_show.Visible = True
            Label_nothing_to_show.BringToFront()
        End If

        Chart.Series(0).Color = Color.Green
        Chart.Series(1).Color = Color.Fuchsia
        Chart.Series(2).Color = Color.Orange
        Chart.Series(3).Color = Color.Purple

        chart_type()

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Sub year()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Integer_row_number = 0
        Integer_chart_access = 0
        Integer_date_diff = 0
        Integer_chart_day = 365

        PictureBox_chart_labels_visible.Visible = True
        PictureBox_default_setting.Visible = True
        Label_chart_filter_weight_1.Visible = True
        Label_chart_filter_weight_2.Visible = True
        Label_chart_filter_bmi_1.Visible = True
        Label_chart_filter_bmi_2.Visible = True
        Label_chart_filter_weight_all.Visible = True
        Label_chart_filter_bmi_all.Visible = True
        Label_chart_filter_all.Visible = True
        Label_seperator_6.Visible = True
        Label_seperator_7.Visible = True
        Label_seperator_8.Visible = True
        Label_seperator_9.Visible = True
        Label_seperator_10.Visible = True
        Label_seperator_11.Visible = True
        TrackBar_chart_type.Visible = True
        Chart.Visible = True
        PictureBox_nothing_to_show.Visible = False
        Label_nothing_to_show.Visible = False

        Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        Select Case My.Settings.Languages
            Case 1
                Date_today = Now.Date
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
            Case 2
                Date_today = PersianDate(Now.Date)
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
        End Select

        Chart.Series(0).Points.Clear()
        Chart.Series(1).Points.Clear()
        Chart.Series(2).Points.Clear()
        Chart.Series(3).Points.Clear()

        If Integer_chart_access = 1 Then
            For i = 0 To Integer_row_number
                Chart.Series(0).Points.Add(i)
                Chart.Series(0).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Chart.Series(0).Points(i).Color = Color.Green
                Chart.Series(0).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(0).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(0).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(0).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(0).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاريخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(0).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(0).Points(i).MarkerColor = Color.Blue
                Chart.Series(0).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(0).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(0).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(0).Points(i).MarkerSize = 10



                Chart.Series(1).Points.Add(i)
                Chart.Series(1).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Chart.Series(1).Points(i).Color = Color.Fuchsia
                Chart.Series(1).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(1).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(1).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(1).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(1).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(1).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(1).Points(i).MarkerColor = Color.Blue
                Chart.Series(1).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(1).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(1).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(1).Points(i).MarkerSize = 10



                Chart.Series(2).Points.Add(i)
                Chart.Series(2).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Chart.Series(2).Points(i).Color = Color.Orange
                Chart.Series(2).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(2).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(2).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(2).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(2).Points(i).MarkerColor = Color.Blue
                Chart.Series(2).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(2).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(2).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(2).Points(i).MarkerSize = 10



                Chart.Series(3).Points.Add(i)
                Chart.Series(3).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Chart.Series(3).Points(i).Color = Color.Purple
                Chart.Series(3).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(3).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(3).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(3).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(3).Points(i).MarkerColor = Color.Blue
                Chart.Series(3).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(3).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(3).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(3).Points(i).MarkerSize = 10
            Next
        Else
            PictureBox_chart_labels_visible.Visible = False
            PictureBox_default_setting.Visible = False
            Label_chart_filter_weight_1.Visible = False
            Label_chart_filter_weight_2.Visible = False
            Label_chart_filter_bmi_1.Visible = False
            Label_chart_filter_bmi_2.Visible = False
            Label_chart_filter_weight_all.Visible = False
            Label_chart_filter_bmi_all.Visible = False
            Label_chart_filter_all.Visible = False
            Label_seperator_6.Visible = False
            Label_seperator_7.Visible = False
            Label_seperator_8.Visible = False
            Label_seperator_9.Visible = False
            Label_seperator_10.Visible = False
            Label_seperator_11.Visible = False
            TrackBar_chart_type.Visible = False
            Chart.Visible = False
            PictureBox_nothing_to_show.Visible = True
            Label_nothing_to_show.Visible = True
            Label_nothing_to_show.BringToFront()
        End If

        Chart.Series(0).Color = Color.Green
        Chart.Series(1).Color = Color.Fuchsia
        Chart.Series(2).Color = Color.Orange
        Chart.Series(3).Color = Color.Purple

        chart_type()

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Sub all()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        PictureBox_chart_labels_visible.Visible = True
        PictureBox_default_setting.Visible = True
        Label_chart_filter_weight_1.Visible = True
        Label_chart_filter_weight_2.Visible = True
        Label_chart_filter_bmi_1.Visible = True
        Label_chart_filter_bmi_2.Visible = True
        Label_chart_filter_weight_all.Visible = True
        Label_chart_filter_bmi_all.Visible = True
        Label_chart_filter_all.Visible = True
        Label_seperator_6.Visible = True
        Label_seperator_7.Visible = True
        Label_seperator_8.Visible = True
        Label_seperator_9.Visible = True
        Label_seperator_10.Visible = True
        Label_seperator_11.Visible = True
        TrackBar_chart_type.Visible = True
        Chart.Visible = True
        PictureBox_nothing_to_show.Visible = False
        Label_nothing_to_show.Visible = False

        Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        Chart.Series(0).Points.Clear()
        Chart.Series(1).Points.Clear()
        Chart.Series(2).Points.Clear()
        Chart.Series(3).Points.Clear()

        If Not Form_show_patient_database.Main_DataGridView.RowCount = 0 Then
            For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                Chart.Series(0).Points.Add(i)
                Chart.Series(0).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Chart.Series(0).Points(i).Color = Color.Green
                Chart.Series(0).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(0).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(0).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(0).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(0).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاريخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(0).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(0).Points(i).MarkerColor = Color.Blue
                Chart.Series(0).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(0).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(0).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(0).Points(i).MarkerSize = 10



                Chart.Series(1).Points.Add(i)
                Chart.Series(1).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Chart.Series(1).Points(i).Color = Color.Fuchsia
                Chart.Series(1).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(1).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(1).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(1).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(1).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(1).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(1).Points(i).MarkerColor = Color.Blue
                Chart.Series(1).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(1).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(1).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(1).Points(i).MarkerSize = 10



                Chart.Series(2).Points.Add(i)
                Chart.Series(2).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Chart.Series(2).Points(i).Color = Color.Orange
                Chart.Series(2).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(2).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(2).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(2).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(2).Points(i).MarkerColor = Color.Blue
                Chart.Series(2).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(2).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(2).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(2).Points(i).MarkerSize = 10



                Chart.Series(3).Points.Add(i)
                Chart.Series(3).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Chart.Series(3).Points(i).Color = Color.Purple
                Chart.Series(3).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(3).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(3).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(3).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(3).Points(i).MarkerColor = Color.Blue
                Chart.Series(3).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(3).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(3).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(3).Points(i).MarkerSize = 10
            Next
        Else
            PictureBox_chart_labels_visible.Visible = False
            PictureBox_default_setting.Visible = False
            Label_chart_filter_weight_1.Visible = False
            Label_chart_filter_weight_2.Visible = False
            Label_chart_filter_bmi_1.Visible = False
            Label_chart_filter_bmi_2.Visible = False
            Label_chart_filter_weight_all.Visible = False
            Label_chart_filter_bmi_all.Visible = False
            Label_chart_filter_all.Visible = False
            Label_seperator_6.Visible = False
            Label_seperator_7.Visible = False
            Label_seperator_8.Visible = False
            Label_seperator_9.Visible = False
            Label_seperator_10.Visible = False
            Label_seperator_11.Visible = False
            TrackBar_chart_type.Visible = False
            Chart.Visible = False
            PictureBox_nothing_to_show.Visible = True
            Label_nothing_to_show.Visible = True
            Label_nothing_to_show.BringToFront()
        End If

        Chart.Series(0).Color = Color.Green
        Chart.Series(1).Color = Color.Fuchsia
        Chart.Series(2).Color = Color.Orange
        Chart.Series(3).Color = Color.Purple

        chart_type()

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Sub customize()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Integer_row_number = 0
        Integer_chart_access = 0
        Integer_date_diff = 0
        Integer_chart_day = Val(TextBox_customize_number.Text)

        PictureBox_reload_chart.Visible = False
        PictureBox_chart_labels_visible.Visible = True
        PictureBox_default_setting.Visible = True
        Label_chart_filter_weight_1.Visible = True
        Label_chart_filter_weight_2.Visible = True
        Label_chart_filter_bmi_1.Visible = True
        Label_chart_filter_bmi_2.Visible = True
        Label_chart_filter_weight_all.Visible = True
        Label_chart_filter_bmi_all.Visible = True
        Label_chart_filter_all.Visible = True
        Label_seperator_6.Visible = True
        Label_seperator_7.Visible = True
        Label_seperator_8.Visible = True
        Label_seperator_9.Visible = True
        Label_seperator_10.Visible = True
        Label_seperator_11.Visible = True
        TrackBar_chart_type.Visible = True
        Chart.Visible = True
        PictureBox_nothing_to_show.Visible = False
        Label_nothing_to_show.Visible = False

        Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        Select Case My.Settings.Languages
            Case 1
                Date_today = Now.Date
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
            Case 2
                Date_today = PersianDate(Now.Date)
                For i = 0 To Form_show_patient_database.Main_DataGridView.RowCount - 1
                    Date_dialysis = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                    If DateDiff(DateInterval.Day, Date_dialysis, Date_today) > Integer_chart_day Then
                        Exit For
                    End If
                    Integer_date_diff = DateDiff(DateInterval.Day, Date_dialysis, Date_today)
                    Integer_row_number = i
                    Integer_chart_access = 1
                Next
        End Select

        Chart.Series(0).Points.Clear()
        Chart.Series(1).Points.Clear()
        Chart.Series(2).Points.Clear()
        Chart.Series(3).Points.Clear()

        If Integer_chart_access = 1 Then
            For i = 0 To Integer_row_number
                Chart.Series(0).Points.Add(i)
                Chart.Series(0).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Chart.Series(0).Points(i).Color = Color.Green
                Chart.Series(0).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(0).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(0).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(0).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(0).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "تاريخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(0).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(0).Points(i).MarkerColor = Color.Blue
                Chart.Series(0).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(0).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(0).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(0).Points(i).MarkerSize = 10



                Chart.Series(1).Points.Add(i)
                Chart.Series(1).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Chart.Series(1).Points(i).Color = Color.Fuchsia
                Chart.Series(1).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(1).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(1).Points(i).ToolTip = "BMI: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(1).Points(i).ToolTip = "شاخص توده بدنی: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(1).Points(i).ToolTip = "مؤشر كتلة الجسم: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(1).Points(i).ToolTip = "IMC: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(1).Points(i).MarkerColor = Color.Blue
                Chart.Series(1).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(1).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(1).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(1).Points(i).MarkerSize = 10



                Chart.Series(2).Points.Add(i)
                Chart.Series(2).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Chart.Series(2).Points(i).Color = Color.Orange
                Chart.Series(2).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(2).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(4).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(2).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 2
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 3
                        Chart.Series(2).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                    Case 4
                        Chart.Series(2).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(3).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(2).Value
                End Select
                Chart.Series(2).Points(i).MarkerColor = Color.Blue
                Chart.Series(2).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(2).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(2).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(1).Value
                Chart.Series(2).Points(i).MarkerSize = 10



                Chart.Series(3).Points.Add(i)
                Chart.Series(3).Points(i).YValues(0) = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Chart.Series(3).Points(i).Color = Color.Purple
                Chart.Series(3).Points(i).BorderWidth = 5
                If Integer_chart_labels_visible = 1 Then Chart.Series(3).Points(i).Label = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(8).Value
                Select Case My.Settings.Languages
                    Case 1
                        Chart.Series(3).Points(i).ToolTip = "Weight: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Date: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Time: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 2
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "ساعت: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 3
                        Chart.Series(3).Points(i).ToolTip = "وزن: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "تاریخ: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "الساعة: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                    Case 4
                        Chart.Series(3).Points(i).ToolTip = "Peso: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(7).Value & vbNewLine & "Fecha: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value & vbNewLine & "Hora: " & Form_show_patient_database.Main_DataGridView.Rows(i).Cells(6).Value
                End Select
                Chart.Series(3).Points(i).MarkerColor = Color.Blue
                Chart.Series(3).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(3).Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart.Series(3).Points(i).AxisLabel = Form_show_patient_database.Main_DataGridView.Rows(i).Cells(5).Value
                Chart.Series(3).Points(i).MarkerSize = 10
            Next
        Else
            PictureBox_chart_labels_visible.Visible = False
            PictureBox_default_setting.Visible = False
            Label_chart_filter_weight_1.Visible = False
            Label_chart_filter_weight_2.Visible = False
            Label_chart_filter_bmi_1.Visible = False
            Label_chart_filter_bmi_2.Visible = False
            Label_chart_filter_weight_all.Visible = False
            Label_chart_filter_bmi_all.Visible = False
            Label_chart_filter_all.Visible = False
            Label_seperator_6.Visible = False
            Label_seperator_7.Visible = False
            Label_seperator_8.Visible = False
            Label_seperator_9.Visible = False
            Label_seperator_10.Visible = False
            Label_seperator_11.Visible = False
            TrackBar_chart_type.Visible = False
            Chart.Visible = False
            PictureBox_nothing_to_show.Visible = True
            Label_nothing_to_show.Visible = True
            Label_nothing_to_show.BringToFront()
        End If

        Chart.Series(0).Color = Color.Green
        Chart.Series(1).Color = Color.Fuchsia
        Chart.Series(2).Color = Color.Orange
        Chart.Series(3).Color = Color.Purple

        chart_type()

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub chart_type()
        If TrackBar_chart_type.Value = 0 Then
            Chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
            Chart.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Point
            Chart.Series(2).ChartType = DataVisualization.Charting.SeriesChartType.Point
            Chart.Series(3).ChartType = DataVisualization.Charting.SeriesChartType.Point
            For i = 0 To Chart.Series(0).Points.Count - 1
                Chart.Series(0).Points(i).MarkerColor = Color.Green
                Chart.Series(1).Points(i).MarkerColor = Color.Fuchsia
                Chart.Series(2).Points(i).MarkerColor = Color.Orange
                Chart.Series(3).Points(i).MarkerColor = Color.Purple
                Chart.Series(0).Points(i).MarkerBorderColor = Color.Green
                Chart.Series(1).Points(i).MarkerBorderColor = Color.Fuchsia
                Chart.Series(2).Points(i).MarkerBorderColor = Color.Orange
                Chart.Series(3).Points(i).MarkerBorderColor = Color.Purple
            Next
        Else
            For i = 0 To Chart.Series(0).Points.Count - 1
                Chart.Series(0).Points(i).MarkerColor = Color.Blue
                Chart.Series(1).Points(i).MarkerColor = Color.Blue
                Chart.Series(2).Points(i).MarkerColor = Color.Blue
                Chart.Series(3).Points(i).MarkerColor = Color.Blue
                Chart.Series(0).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(1).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(2).Points(i).MarkerBorderColor = Color.Blue
                Chart.Series(3).Points(i).MarkerBorderColor = Color.Blue
            Next
        End If

        Select Case TrackBar_chart_type.Value
            Case 1
                Chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart.Series(2).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart.Series(3).ChartType = DataVisualization.Charting.SeriesChartType.Line
            Case 2
                Chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
                Chart.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Spline
                Chart.Series(2).ChartType = DataVisualization.Charting.SeriesChartType.Spline
                Chart.Series(3).ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Case 3
                Chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
                Chart.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
                Chart.Series(2).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
                Chart.Series(3).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
            Case 4
                Chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                Chart.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Column
                Chart.Series(2).ChartType = DataVisualization.Charting.SeriesChartType.Column
                Chart.Series(3).ChartType = DataVisualization.Charting.SeriesChartType.Column
            Case 5
                Chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
                Chart.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
                Chart.Series(2).ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
                Chart.Series(3).ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
        End Select
    End Sub
End Class