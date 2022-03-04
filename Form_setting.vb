Imports System.Data
Imports System.Data.SqlClient

Public Class Form_setting

    Dim Integer_Calibrate_status As Integer
    Dim Integer_Security_Add_username_visible_status As Integer
    Dim Integer_Security_Add_password_visible_status As Integer
    Dim Integer_Security_Delete_username_visible_status As Integer
    Dim Integer_Security_Delete_password_visible_status As Integer
    'Dim Integer_Security_Edit_step_1_username_visible_status As Integer
    'Dim Integer_Security_Edit_step_1_password_visible_status As Integer
    'Dim Integer_Security_Edit_step_2_username_visible_status As Integer
    'Dim Integer_Security_Edit_step_2_password_visible_status As Integer
    Dim Integer_application_username_and_password_username_visible_status As Integer
    Dim Integer_application_username_and_password_password_visible_status As Integer
    Dim Integer_Security_Edit_step As Integer
    Dim Integer_get_id As Integer

    'Dim String_get_name As String
    'Dim String_get_username As String
    'Dim String_get_password As String

    Private Sub Form_setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public_Determine_Form = "Form_setting"
        Public_Determine_Languages()

        RadioButton_english_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold
        RadioButton_persian_language.Font = Public_B_Nazanin_Font_12_Bold
        RadioButton_arabic_language.Font = Public_B_Nazanin_Font_12_Bold
        RadioButton_spanish_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold

        Select Case My.Settings.Languages
            Case 1
                RadioButton_english_language.Checked = True
            Case 2
                RadioButton_persian_language.Checked = True
            Case 3
                RadioButton_arabic_language.Checked = True
            Case 4
                RadioButton_spanish_language.Checked = True
        End Select

        Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From setting", Public_connect_DataGridView)
        Dim DataTable As New DataTable
        data_adapter.Fill(DataTable)

        TextBox_hospital_name.Text = DataTable.Rows(0).Item(1)
        TextBox_hospital_address.Text = DataTable.Rows(0).Item(2)
        MaskedTextBox_hospital_tel.Text = DataTable.Rows(0).Item(3)
        NumericUpDown_dialysis_time.Value = DataTable.Rows(0).Item(4)


        Select Case My.Settings.auto_connectin
            Case 1
                PictureBox_auto_connection.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.switch__3_
            Case 2
                PictureBox_auto_connection.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.switch__1_
        End Select
        Label_auto_connection.Location = New Point((Me.Size.Width - 16 - (Label_auto_connection.Size.Width + 35)) / 2, ((30 - Label_auto_connection.Size.Height) / 2) + 285)
        PictureBox_auto_connection.Location = New Point(Label_auto_connection.Location.X + Label_auto_connection.Size.Width + 5, 285)
        PictureBox_trying_to_connect.Location = New Point((Me.Size.Width - 16 - PictureBox_trying_to_connect.Size.Width) / 2, Label_auto_connection.Location.Y)
        Label_trying_to_connect.Location = New Point((Me.Size.Width - 16 - Label_trying_to_connect.Size.Width) / 2, PictureBox_trying_to_connect.Location.Y + 55)

        Integer_Calibrate_status = 1
        Label_calibrate_explain.Visible = False
        Label_calibrate_help.Visible = False
        TextBox_calibrate.Visible = False
        PictureBox_calibrate_cancel.Visible = False
        TextBox_calibrate.Text = 0

        Integer_Security_Add_username_visible_status = 1
        Integer_Security_Add_password_visible_status = 2
        Integer_Security_Delete_username_visible_status = 1
        Integer_Security_Delete_password_visible_status = 2
        Integer_application_username_and_password_username_visible_status = 1
        Integer_application_username_and_password_password_visible_status = 2

        Integer_Security_Edit_step = 1
    End Sub
    Private Sub Form_setting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TextBox_hospital_name.BackColor = Color.White
        TextBox_hospital_address.BackColor = Color.White
        MaskedTextBox_hospital_tel.BackColor = Color.White
        NumericUpDown_dialysis_time.BackColor = Color.White

        TextBox_Security_Add_name.Text = String.Empty
        TextBox_Security_Add_username.Text = String.Empty
        TextBox_Security_Add_password.Text = String.Empty
        TextBox_Security_Add_confirm_password.Text = String.Empty

        TextBox_Security_Delete_name.Text = String.Empty
        TextBox_Security_Delete_username.Text = String.Empty
        TextBox_Security_Delete_password.Text = String.Empty

        'TextBox_Security_Edit_step_2_name.Text = String.Empty
        'TextBox_Security_Edit_step_2_username.Text = String.Empty
        'TextBox_Security_Edit_step_2_password.Text = String.Empty
        'TextBox_Security_Edit_step_2_confirm_password.Text = String.Empty

        'Label_Security_Edit_step_2_name.Visible = False
        'Label_Security_Edit_step_2_username.Visible = False
        'Label_Security_Edit_step_2_password.Visible = False
        'Label_Security_Edit_step_2_confirm_password.Visible = False
        'TextBox_Security_Edit_step_2_name.Visible = False
        'TextBox_Security_Edit_step_2_username.Visible = False
        'TextBox_Security_Edit_step_2_password.Visible = False
        'TextBox_Security_Edit_step_2_confirm_password.Visible = False
        'PictureBox_Security_Edit_step_2_username_visible.Visible = False
        'PictureBox_Security_Edit_step_2_password_visible.Visible = False

        'TextBox_Security_Edit_step_1_name.Text = String.Empty
        'TextBox_Security_Edit_step_1_username.Text = String.Empty
        'TextBox_Security_Edit_step_1_password.Text = String.Empty

        'Label_Security_Edit_step_1_name.Visible = True
        'Label_Security_Edit_step_1_username.Visible = True
        'Label_Security_Edit_step_1_password.Visible = True
        'TextBox_Security_Edit_step_1_name.Visible = True
        'TextBox_Security_Edit_step_1_username.Visible = True
        'TextBox_Security_Edit_step_1_password.Visible = True
        'PictureBox_Security_Edit_step_1_username_visible.Visible = True
        'PictureBox_Security_Edit_step_1_password_visible.Visible = True

        Integer_Security_Edit_step = 1

        If Integer_Calibrate_status = 2 Then
            If Form_main.SerialPort.IsOpen = True Then
                Form_main.SerialPort.WriteLine("end")
            End If
        End If

        TabControl_setting.SelectedTab = TabPage_language
        Public_Boolean_Administrator_access = False
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
    Private Sub TabControl_setting_KeyDown(sender As Object, e As KeyEventArgs) Handles TabControl_setting.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If Button_change_language.Visible = True Then Button_change_language.Focus()
                If Button_change_setting_table.Visible = True Then Button_change_setting_table.Focus()
                If Button_connect.Visible = True Then Button_connect.Focus()
                If Button_calibrate.Visible = True Then Button_calibrate.Focus()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub RadioButton_english_language_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton_english_language.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_change_language.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub RadioButton_persian_language_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton_persian_language.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_change_language.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_change_language_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_change_language.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub TextBox_hospital_name_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_hospital_name.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_change_setting_table.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_hospital_address_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_hospital_address.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_change_setting_table.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_hospital_tel_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_hospital_tel.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_change_setting_table.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub NumericUpDown_dialysis_time_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown_dialysis_time.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_change_setting_table.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_change_setting_table_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_change_setting_table.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub Button_connect_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_connect.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub ComboBox_ListPort_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox_ListPort.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_connect.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub Button_calibrate_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_calibrate.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_offset_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_offset.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_calibrate_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_calibrate.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_calibrate.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub TextBox_Security_Add_name_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Security_Add_name.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_Security_Add_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_Security_Add_username_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Security_Add_username.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_Security_Add_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_Security_Add_password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Security_Add_password.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_Security_Add_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_Security_Add_confirm_password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Security_Add_confirm_password.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_Security_Add_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_Security_Add_done_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_Security_Add_done.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub TextBox_Security_Delete_name_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Security_Delete_name.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_Security_Delete_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_Security_Delete_username_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Security_Delete_username.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_Security_Delete_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_Security_Delete_password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Security_Delete_password.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_Security_Delete_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_Security_Delete_done_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_Security_Delete_done.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub TextBox_application_username_and_password_username_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_application_username_and_password_username.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_application_username_and_password_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_application_username_and_password_password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_application_username_and_password_password.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_application_username_and_password_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_application_username_and_password_confirm_password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_application_username_and_password_confirm_password.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_application_username_and_password_done.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_application_username_and_password_done_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_application_username_and_password_done.KeyDown
        Select Case e.KeyCode
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
    'objects TABPAGE Language
    Private Sub PictureBox_english_language_Click(sender As Object, e As EventArgs) Handles PictureBox_english_language.Click
        Label_title_language.Text = "Please select the language"
        Button_change_language.Text = "Change language"
        Label_title_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold
        Button_change_language.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        RadioButton_english_language.Checked = True
        RadioButton_persian_language.Checked = False
        RadioButton_arabic_language.Checked = False
        RadioButton_spanish_language.Checked = False
    End Sub
    Private Sub PictureBox_persian_language_Click(sender As Object, e As EventArgs) Handles PictureBox_persian_language.Click
        Label_title_language.Text = "لطفا زبان خود را انتخاب نمایید"
        Button_change_language.Text = "تغییر زبان"
        Label_title_language.Font = Public_B_Nazanin_Font_14_Bold
        Button_change_language.Font = Public_B_Nazanin_Font_9_Bold
        RadioButton_english_language.Checked = False
        RadioButton_persian_language.Checked = True
        RadioButton_arabic_language.Checked = False
        RadioButton_spanish_language.Checked = False
    End Sub
    Private Sub PictureBox_arabic_language_Click(sender As Object, e As EventArgs) Handles PictureBox_arabic_language.Click
        Label_title_language.Text = "الرجاء اختيار لغتك"
        Button_change_language.Text = "تغيير اللغة"
        Label_title_language.Font = Public_B_Nazanin_Font_14_Bold
        Button_change_language.Font = Public_B_Nazanin_Font_9_Bold
        RadioButton_english_language.Checked = False
        RadioButton_persian_language.Checked = False
        RadioButton_arabic_language.Checked = True
        RadioButton_spanish_language.Checked = False
    End Sub
    Private Sub PictureBox_spanish_language_Click(sender As Object, e As EventArgs) Handles PictureBox_spanish_language.Click
        Label_title_language.Text = "Por favor seleccione el idioma"
        Button_change_language.Text = "Cambiar idioma"
        Label_title_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold
        Button_change_language.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        RadioButton_english_language.Checked = False
        RadioButton_persian_language.Checked = False
        RadioButton_arabic_language.Checked = False
        RadioButton_spanish_language.Checked = True
    End Sub

    Private Sub RadioButton_english_language_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_english_language.CheckedChanged
        If RadioButton_english_language.Checked = True Then
            Label_title_language.Text = "Please select the language"
            Button_change_language.Text = "Change language"
            Label_title_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Button_change_language.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            RadioButton_persian_language.Checked = False
            RadioButton_arabic_language.Checked = False
            RadioButton_spanish_language.Checked = False
        End If
    End Sub
    Private Sub RadioButton_persian_language_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_persian_language.CheckedChanged
        If RadioButton_persian_language.Checked = True Then
            Label_title_language.Text = "لطفا زبان خود را انتخاب نمایید"
            Button_change_language.Text = "تغییر زبان"
            Label_title_language.Font = Public_B_Nazanin_Font_14_Bold
            Button_change_language.Font = Public_B_Nazanin_Font_9_Bold
            RadioButton_english_language.Checked = False
            RadioButton_arabic_language.Checked = False
            RadioButton_spanish_language.Checked = False
        End If
    End Sub
    Private Sub RadioButton_arabic_language_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_arabic_language.CheckedChanged
        If RadioButton_arabic_language.Checked = True Then
            Label_title_language.Text = "الرجاء اختيار لغتك"
            Button_change_language.Text = "تغيير اللغة"
            Label_title_language.Font = Public_B_Nazanin_Font_14_Bold
            Button_change_language.Font = Public_B_Nazanin_Font_9_Bold
            RadioButton_english_language.Checked = False
            RadioButton_persian_language.Checked = False
            RadioButton_spanish_language.Checked = False
        End If
    End Sub
    Private Sub RadioButton_spanish_language_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_spanish_language.CheckedChanged
        If RadioButton_spanish_language.Checked = True Then
            Label_title_language.Text = "Por favor seleccione el idioma"
            Button_change_language.Text = "Cambiar idioma"
            Label_title_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Button_change_language.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            RadioButton_english_language.Checked = False
            RadioButton_persian_language.Checked = False
            RadioButton_arabic_language.Checked = False
        End If
    End Sub

    Private Sub Button_change_language_Click(sender As Object, e As EventArgs) Handles Button_change_language.Click
        If RadioButton_english_language.Checked = True Then
            If Not My.Settings.Languages = 1 Then
                My.Settings.Languages = 1
                My.Settings.Data_Mode = 1
                Public_Determine_Layout()
                Public_Determine_Form = "Form_setting"
                Public_Determine_Languages()
                Public_Determine_Form = "Form_main"
                Public_Determine_Languages()
                Message_box = MessageBox.Show("Language changed successfully", "Change language", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If Form_main.SerialPort.IsOpen = True Then
                    Form_main.SerialPort.WriteLine("close")
                    Form_main.SerialPort.Close()
                    If My.Settings.auto_connectin = 2 Then
                        Timer_manual_connection.Enabled = True
                    End If
                End If
            Else
                Message_box = MessageBox.Show("The current language is English", "Change language", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf RadioButton_persian_language.Checked = True Then
            If Not My.Settings.Languages = 2 Then
                My.Settings.Languages = 2
                My.Settings.Data_Mode = 2
                Public_Determine_Layout()
                Public_Determine_Form = "Form_setting"
                Public_Determine_Languages()
                Public_Determine_Form = "Form_main"
                Public_Determine_Languages()
                Message_box = MessageBox.Show("زبان با موفقیت تغییر کرد", "تغییر زبان", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If Form_main.SerialPort.IsOpen = True Then
                    Form_main.SerialPort.WriteLine("close")
                    Form_main.SerialPort.Close()
                    If My.Settings.auto_connectin = 2 Then
                        Timer_manual_connection.Enabled = True
                    End If
                End If
            Else
                Message_box = MessageBox.Show("زبان جاری فارسی میباشد", "تغییر زبان", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf RadioButton_arabic_language.Checked = True Then
            If Not My.Settings.Languages = 3 Then
                My.Settings.Languages = 3
                My.Settings.Data_Mode = 3
                Public_Determine_Layout()
                Public_Determine_Form = "Form_setting"
                Public_Determine_Languages()
                Public_Determine_Form = "Form_main"
                Public_Determine_Languages()
                Message_box = MessageBox.Show("تغيرت اللغة بنجاح", "تغيير اللغة", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If Form_main.SerialPort.IsOpen = True Then
                    Form_main.SerialPort.WriteLine("close")
                    Form_main.SerialPort.Close()
                    If My.Settings.auto_connectin = 2 Then
                        Timer_manual_connection.Enabled = True
                    End If
                End If
            Else
                Message_box = MessageBox.Show("اللغة الحالية هي العربية", "تغيير اللغة", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf RadioButton_spanish_language.Checked = True Then
            If Not My.Settings.Languages = 4 Then
                My.Settings.Languages = 4
                My.Settings.Data_Mode = 1
                Public_Determine_Layout()
                Public_Determine_Form = "Form_setting"
                Public_Determine_Languages()
                Public_Determine_Form = "Form_main"
                Public_Determine_Languages()
                Message_box = MessageBox.Show("El idioma cambió con éxito", "cambiar idioma", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If Form_main.SerialPort.IsOpen = True Then
                    Form_main.SerialPort.WriteLine("close")
                    Form_main.SerialPort.Close()
                    If My.Settings.auto_connectin = 2 Then
                        Timer_manual_connection.Enabled = True
                    End If
                End If
            Else
                Message_box = MessageBox.Show("El idioma actual es el español", "cambiar idioma", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        Label_auto_connection.Location = New Point((Me.Size.Width - 16 - (Label_auto_connection.Size.Width + 35)) / 2, ((30 - Label_auto_connection.Size.Height) / 2) + 285)
        PictureBox_auto_connection.Location = New Point(Label_auto_connection.Location.X + Label_auto_connection.Size.Width + 5, 285)
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
    'objects TABPAGE Hospital
    Private Sub Button_change_setting_table_Click(sender As Object, e As EventArgs) Handles Button_change_setting_table.Click
        If TextBox_hospital_name.Text = String.Empty Or TextBox_hospital_address.Text = String.Empty Or MaskedTextBox_hospital_tel.Text = "" Or NumericUpDown_dialysis_time.Value = 0 Then
            If TextBox_hospital_name.Text = String.Empty Then TextBox_hospital_name.BackColor = Color.Red
            If TextBox_hospital_address.Text = String.Empty Then TextBox_hospital_address.BackColor = Color.Red
            If MaskedTextBox_hospital_tel.Text = "" Then MaskedTextBox_hospital_tel.BackColor = Color.Red
            If NumericUpDown_dialysis_time.Value = 0 Then NumericUpDown_dialysis_time.BackColor = Color.Red

            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Please fill in the required fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("لطفا فیلد های مورد نیاز را پر نمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("يرجى تعبئة الحقول المطلوبة", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("Por favor llene los campos requeridos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        Else
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Are you sure the information is correct?", "Hospital information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Case 2
                    Message_box = MessageBox.Show("آیا از صحت اطلاعات اطمینان دارید؟", "اطلاعات بیمارستان", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Case 3
                    Message_box = MessageBox.Show("هل أنت متأكد من صحة المعلومات؟", "معلومات المستشفى", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Case 4
                    Message_box = MessageBox.Show("¿Estás seguro de que la información es correcta?", "Información del hospital", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            End Select

            If Message_box = DialogResult.Yes Then
                Dim edit As String = "update setting set hospital_name=N'" & TextBox_hospital_name.Text & "',hospital_address=N'" & TextBox_hospital_address.Text & "',hospital_tel=N'" & MaskedTextBox_hospital_tel.Text & "',maximum_dialysis_time=N'" & NumericUpDown_dialysis_time.Value & "' where id= 1"
                Dim Run As SqlCommand = New SqlCommand(edit, Public_connect_DataGridView)
                Public_connect_DataGridView.Open()
                Run.ExecuteNonQuery()
                Public_connect_DataGridView.Close()

                Select Case My.Settings.Languages
                    Case 1
                        Message_box = MessageBox.Show("Hospital information changed successfully", "Hospital information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 2
                        Message_box = MessageBox.Show("اطلاعات بیمارستان با موفقیت تغییر کرد", "اطلاعات بیمارستان", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 3
                        Message_box = MessageBox.Show("تم تغيير معلومات المستشفى بنجاح", "معلومات المستشفى", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 4
                        Message_box = MessageBox.Show("La información del hospital se modificó correctamente", "Información del hospital", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Select
            End If
        End If
    End Sub

    Private Sub TextBox_hospital_name_GotFocus(sender As Object, e As EventArgs) Handles TextBox_hospital_name.GotFocus
        TextBox_hospital_name.BackColor = Color.White
    End Sub
    Private Sub TextBox_hospital_address_GotFocus(sender As Object, e As EventArgs) Handles TextBox_hospital_address.GotFocus
        TextBox_hospital_address.BackColor = Color.White
    End Sub
    Private Sub MaskedTextBox_hospital_tel_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_hospital_tel.GotFocus
        MaskedTextBox_hospital_tel.BackColor = Color.White
    End Sub
    Private Sub NumericUpDown_dialysis_time_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown_dialysis_time.GotFocus
        NumericUpDown_dialysis_time.BackColor = Color.White
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
    'objects TABPAGE Devices
    Private Sub Timer_connection_status_Tick(sender As Object, e As EventArgs) Handles Timer_connection_status.Tick
        If Form_main.SerialPort.IsOpen = True Then
            Select Case My.Settings.Languages
                Case 1
                    Label_connection_status.Text = "The computer is connected to the fingerprint device"
                    Button_connect.Text = "Disconnect"
                    Label_connection_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                    Button_connect.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                    Form_main.StatusStrip_label_connection_status.Text = "The computer is connected to the fingerprint device"
                Case 2
                    Label_connection_status.Text = "کامپیوتر به دستگاه اثر انگشت متصل است"
                    Button_connect.Text = "قطع اتصال"
                    Label_connection_status.Font = Public_B_Nazanin_Font_9_Bold
                    Button_connect.Font = Public_B_Nazanin_Font_9_Bold
                    Form_main.StatusStrip_label_connection_status.Text = "کامپیوتر به دستگاه اثر انگشت متصل است"
                Case 3
                    Label_connection_status.Text = "الكمبيوتر متصل بجهاز البصمة"
                    Button_connect.Text = "قطع الاتصال"
                    Label_connection_status.Font = Public_B_Nazanin_Font_9_Bold
                    Button_connect.Font = Public_B_Nazanin_Font_9_Bold
                    Form_main.StatusStrip_label_connection_status.Text = "الكمبيوتر متصل بجهاز البصمة"
                Case 4
                    Label_connection_status.Text = "La computadora está conectada al dispositivo de huellas dactilares"
                    Button_connect.Text = "Desconectar"
                    Label_connection_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                    Button_connect.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                    Form_main.StatusStrip_label_connection_status.Text = "La computadora está conectada al dispositivo de huellas dactilares"
            End Select

            Label_connection_status.ForeColor = Color.Green

            Form_main.StatusStrip_label_connection_status.ForeColor = Color.Green

            PictureBox_trying_to_connect.Visible = False
            Label_trying_to_connect.Visible = False

            If My.Settings.auto_connectin = 1 Then
                Timer_auto_connection.Enabled = False
            End If
        Else
            Select Case My.Settings.Languages
                Case 1
                    Label_connection_status.Text = "The computer is not connected to the fingerprint device"
                    Button_connect.Text = "Connect"
                    Label_connection_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                    Button_connect.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                    Form_main.StatusStrip_label_connection_status.Text = "The computer is not connected to the fingerprint device"
                Case 2
                    Label_connection_status.Text = "کامپیوتر به دستگاه اثر انگشت متصل نیست"
                    Button_connect.Text = "اتصال"
                    Label_connection_status.Font = Public_B_Nazanin_Font_9_Bold
                    Button_connect.Font = Public_B_Nazanin_Font_9_Bold
                    Form_main.StatusStrip_label_connection_status.Text = "کامپیوتر به دستگاه اثر انگشت متصل نیست"
                Case 3
                    Label_connection_status.Text = "الكمبيوتر غير متصل بجهاز البصمة"
                    Button_connect.Text = "الإتصال"
                    Label_connection_status.Font = Public_B_Nazanin_Font_9_Bold
                    Button_connect.Font = Public_B_Nazanin_Font_9_Bold
                    Form_main.StatusStrip_label_connection_status.Text = "الكمبيوتر غير متصل بجهاز البصمة"
                Case 4
                    Label_connection_status.Text = "La computadora no está conectada al dispositivo de huellas dactilares"
                    Button_connect.Text = "Conectar"
                    Label_connection_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                    Button_connect.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                    Form_main.StatusStrip_label_connection_status.Text = "La computadora no está conectada al dispositivo de huellas dactilares"
            End Select

            Label_connection_status.ForeColor = Color.Red

            Form_main.StatusStrip_label_connection_status.ForeColor = Color.Red

            If My.Settings.auto_connectin = 1 Or Timer_manual_connection.Enabled = True Then
                PictureBox_trying_to_connect.Visible = True
                Label_trying_to_connect.Visible = True
            Else
                PictureBox_trying_to_connect.Visible = False
                Label_trying_to_connect.Visible = False
            End If

            If My.Settings.auto_connectin = 1 Then
                Timer_auto_connection.Enabled = True
            End If
        End If
    End Sub
    Private Sub Timer_auto_connection_Tick(sender As Object, e As EventArgs) Handles Timer_auto_connection.Tick
        On Error Resume Next
        If Form_main.SerialPort.IsOpen = False Then
            If My.Settings.auto_connectin = 1 Then
                ComboBox_ListPort.Items.Clear()
                For Each Serial_Name As String In My.Computer.Ports.SerialPortNames
                    ComboBox_ListPort.Items.Add(Serial_Name)
                Next
                If Not ComboBox_ListPort.Items.Count = 0 Then
                    If ComboBox_ListPort.Text = String.Empty Then
                        ComboBox_ListPort.Text = ComboBox_ListPort.Items(0)
                    End If
                    For i = 0 To ComboBox_ListPort.Items.Count - 1
                        If My.Settings.Com_port_save = ComboBox_ListPort.Items(i) Then
                            ComboBox_ListPort.Text = My.Settings.Com_port_save
                            Form_main.SerialPort.PortName = My.Settings.Com_port_save
                            Exit For
                        Else
                            Form_main.SerialPort.PortName = ComboBox_ListPort.Text
                        End If
                    Next
                    With Form_main.SerialPort
                        .BaudRate = "9600"
                        .DataBits = "8"
                        .Parity = IO.Ports.Parity.None
                        .StopBits = IO.Ports.StopBits.One
                    End With
                    Form_main.SerialPort.Open()
                    If Form_main.SerialPort.IsOpen = True Then
                        System.Threading.Thread.Sleep(1000)
                        Select Case My.Settings.Languages
                            Case 1
                                Form_main.SerialPort.WriteLine("start_en")
                            Case 2
                                Form_main.SerialPort.WriteLine("start_fa")
                            Case 3
                                Form_main.SerialPort.WriteLine("start_ar")
                            Case 4
                                Form_main.SerialPort.WriteLine("start_sp")
                        End Select
                        My.Settings.Com_port_save = Form_main.SerialPort.PortName.ToString
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Timer_manual_connection_Tick(sender As Object, e As EventArgs) Handles Timer_manual_connection.Tick
        On Error Resume Next
        Timer_manual_connection.Enabled = False
        ComboBox_ListPort.Items.Clear()
        For Each Serial_Name As String In My.Computer.Ports.SerialPortNames
            ComboBox_ListPort.Items.Add(Serial_Name)
        Next
        If Not ComboBox_ListPort.Items.Count = 0 Then
            If ComboBox_ListPort.Text = String.Empty Then
                ComboBox_ListPort.Text = ComboBox_ListPort.Items(0)
            End If
            If Form_main.SerialPort.IsOpen = False Then
                If My.Settings.auto_connectin = 2 Then
                    With Form_main.SerialPort
                        .BaudRate = "9600"
                        .DataBits = "8"
                        .Parity = IO.Ports.Parity.None
                        .StopBits = IO.Ports.StopBits.One
                        .PortName = ComboBox_ListPort.Text
                    End With
                    Form_main.SerialPort.Open()
                    If Form_main.SerialPort.IsOpen = True Then
                        System.Threading.Thread.Sleep(1000)
                        Select Case My.Settings.Languages
                            Case 1
                                Form_main.SerialPort.WriteLine("start_en")
                            Case 2
                                Form_main.SerialPort.WriteLine("start_fa")
                            Case 3
                                Form_main.SerialPort.WriteLine("start_ar")
                            Case 4
                                Form_main.SerialPort.WriteLine("start_sp")
                        End Select
                        My.Settings.Com_port_save = Form_main.SerialPort.PortName.ToString
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button_connect_Click(sender As Object, e As EventArgs) Handles Button_connect.Click
        Public_Connect_Serial()
    End Sub

    Private Sub ComboBox_ListPort_Click(sender As Object, e As EventArgs) Handles ComboBox_ListPort.Click
        ComboBox_ListPort.Items.Clear()
        For Each Serial_Name As String In My.Computer.Ports.SerialPortNames
            ComboBox_ListPort.Items.Add(Serial_Name)
        Next
        If Not ComboBox_ListPort.Items.Count = 0 Then
            If ComboBox_ListPort.Text = String.Empty Then
                ComboBox_ListPort.Text = ComboBox_ListPort.Items(0)
            End If
        End If
    End Sub
    Private Sub ComboBox_ListPort_TextChanged(sender As Object, e As EventArgs) Handles ComboBox_ListPort.TextChanged
        If Form_main.SerialPort.IsOpen = True Then
            Form_main.SerialPort.WriteLine("close")
            Form_main.SerialPort.Close()
        End If
    End Sub

    Private Sub PictureBox_auto_connection_Click(sender As Object, e As EventArgs) Handles PictureBox_auto_connection.Click
        Select Case My.Settings.auto_connectin
            Case 1
                PictureBox_auto_connection.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.switch__2_
                My.Settings.auto_connectin = 2
            Case 2
                PictureBox_auto_connection.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.switch__4_
                My.Settings.auto_connectin = 1
        End Select
    End Sub
    Private Sub PictureBox_auto_connection_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_auto_connection.MouseEnter
        Select Case My.Settings.auto_connectin
            Case 1
                PictureBox_auto_connection.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.switch__4_
            Case 2
                PictureBox_auto_connection.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.switch__2_
        End Select
    End Sub
    Private Sub PictureBox_auto_connection_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_auto_connection.MouseLeave
        Select Case My.Settings.auto_connectin
            Case 1
                PictureBox_auto_connection.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.switch__3_
            Case 2
                PictureBox_auto_connection.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.switch__1_
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
    'objects TABPAGE Scale setting
    Private Sub TextBox_calibrate_TextChanged(sender As Object, e As EventArgs) Handles TextBox_calibrate.TextChanged
        TextBox_calibrate.Text = Val(TextBox_calibrate.Text)
    End Sub

    Private Sub Button_calibrate_Click(sender As Object, e As EventArgs) Handles Button_calibrate.Click
        If Form_main.SerialPort.IsOpen = True Then
            If Integer_Calibrate_status = 1 Then
                Form_main.SerialPort.WriteLine("NewCalibrate")
                Label_calibrate_explain.Visible = True
                TextBox_calibrate.Visible = True
                PictureBox_calibrate_cancel.Visible = True
                TextBox_calibrate.Text = 0
                Select Case My.Settings.Languages
                    Case 1
                        Button_calibrate.Text = "Send"
                    Case 2
                        Button_calibrate.Text = "ارسال"
                    Case 3
                        Button_calibrate.Text = "إرسال"
                    Case 4
                        Button_calibrate.Text = "Enviar"
                End Select
                Integer_Calibrate_status = 2
            Else
                Form_main.SerialPort.WriteLine(Val(TextBox_calibrate.Text))
                Label_calibrate_explain.Visible = False
                TextBox_calibrate.Visible = False
                PictureBox_calibrate_cancel.Visible = False
                TextBox_calibrate.Text = 0
                Select Case My.Settings.Languages
                    Case 1
                        Button_calibrate.Text = "Calibrate"
                    Case 2
                        Button_calibrate.Text = "کالیبره کردن"
                    Case 3
                        Button_calibrate.Text = "معايرة"
                    Case 4
                        Button_calibrate.Text = "Calibrar"
                End Select
                Integer_Calibrate_status = 1
                Select Case My.Settings.Languages
                    Case 1
                        Message_box = MessageBox.Show("Information submitted successfully", "Calibrate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 2
                        Message_box = MessageBox.Show("اطلاعات با موفقیت ارسال شد", "کالیبره کردن", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 3
                        Message_box = MessageBox.Show("تم إرسال المعلومات بنجاح", "معايرة", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 4
                        Message_box = MessageBox.Show("Información enviada con éxito", "Calibrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Select
            End If
        Else
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Communication with the fingerprint device is disconnected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("ارتباط با دستگاه اثر انگشت قطع میباشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("تم قطع الاتصال بجهاز البصمة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("La comunicación con el dispositivo de huellas dactilares está desconectada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        End If
    End Sub

    Private Sub PictureBox_calibrate_help_Click(sender As Object, e As EventArgs) Handles PictureBox_calibrate_help.Click
        If Label_calibrate_help.Visible = False Then
            Label_calibrate_help.Visible = True
        Else
            Label_calibrate_help.Visible = False
        End If
    End Sub
    Private Sub PictureBox_calibrate_help_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_calibrate_help.MouseEnter
        PictureBox_calibrate_help.Size = New Size(PictureBox_calibrate_help.Size.Width + 3, PictureBox_calibrate_help.Size.Height + 3)
        PictureBox_calibrate_help.Location = New Point(PictureBox_calibrate_help.Location.X - 1.5, PictureBox_calibrate_help.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_calibrate_help_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_calibrate_help.MouseLeave
        PictureBox_calibrate_help.Size = New Size(PictureBox_calibrate_help.Size.Width - 3, PictureBox_calibrate_help.Size.Height - 3)
        PictureBox_calibrate_help.Location = New Point(PictureBox_calibrate_help.Location.X + 1.5, PictureBox_calibrate_help.Location.Y + 1.5)
    End Sub

    Private Sub PictureBox_calibrate_cancel_Click(sender As Object, e As EventArgs) Handles PictureBox_calibrate_cancel.Click
        Integer_Calibrate_status = 1
        Label_calibrate_explain.Visible = False
        Label_calibrate_help.Visible = False
        TextBox_calibrate.Visible = False
        PictureBox_calibrate_cancel.Visible = False
        TextBox_calibrate.Text = 0
        Select Case My.Settings.Languages
            Case 1
                Button_calibrate.Text = "Calibrate"
            Case 2
                Button_calibrate.Text = "کالیبره کردن"
            Case 3
                Button_calibrate.Text = "معايرة"
            Case 4
                Button_calibrate.Text = "Calibrar"
        End Select
        If Form_main.SerialPort.IsOpen = True Then
            Form_main.SerialPort.WriteLine("end")
        End If
    End Sub
    Private Sub PictureBox_calibrate_cancel_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_calibrate_cancel.MouseEnter
        PictureBox_calibrate_cancel.Size = New Size(PictureBox_calibrate_cancel.Size.Width + 3, PictureBox_calibrate_cancel.Size.Height + 3)
        PictureBox_calibrate_cancel.Location = New Point(PictureBox_calibrate_cancel.Location.X - 1.5, PictureBox_calibrate_cancel.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_calibrate_cancel_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_calibrate_cancel.MouseLeave
        PictureBox_calibrate_cancel.Size = New Size(PictureBox_calibrate_cancel.Size.Width - 3, PictureBox_calibrate_cancel.Size.Height - 3)
        PictureBox_calibrate_cancel.Location = New Point(PictureBox_calibrate_cancel.Location.X + 1.5, PictureBox_calibrate_cancel.Location.Y + 1.5)
    End Sub


    Private Sub Button_offset_Click(sender As Object, e As EventArgs) Handles Button_offset.Click
        If Form_main.SerialPort.IsOpen = True Then
            If Integer_Calibrate_status = 2 Then
                Integer_Calibrate_status = 1
                Label_calibrate_explain.Visible = False
                Label_calibrate_help.Visible = False
                TextBox_calibrate.Visible = False
                PictureBox_calibrate_cancel.Visible = False
                TextBox_calibrate.Text = 0
                Select Case My.Settings.Languages
                    Case 1
                        Button_calibrate.Text = "Calibrate"
                    Case 2
                        Button_calibrate.Text = "کالیبره کردن"
                    Case 3
                        Button_calibrate.Text = "معايرة"
                    Case 4
                        Button_calibrate.Text = "Calibrar"
                End Select
                Form_main.SerialPort.WriteLine("end")
            End If
            Form_main.SerialPort.WriteLine("Offset")
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Information submitted successfully", "Reset the scales", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 2
                    Message_box = MessageBox.Show("اطلاعات با موفقیت ارسال شد", "صفر کردن ترازو", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 3
                    Message_box = MessageBox.Show("تم إرسال المعلومات بنجاح", "إعادة تعيين", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 4
                    Message_box = MessageBox.Show("Información enviada con éxito", "Reiniciar las escalas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Else
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Communication with the fingerprint device is disconnected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("ارتباط با دستگاه اثر انگشت قطع میباشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("تم قطع الاتصال بجهاز البصمة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("La comunicación con el dispositivo de huellas dactilares está desconectada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        End If
    End Sub

    Private Sub PictureBox_offset_help_Click(sender As Object, e As EventArgs) Handles PictureBox_offset_help.Click
        If Label_offset_help.Visible = False Then
            Label_offset_help.Visible = True
        Else
            Label_offset_help.Visible = False
        End If
    End Sub
    Private Sub PictureBox_offset_help_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_offset_help.MouseEnter
        PictureBox_offset_help.Size = New Size(PictureBox_offset_help.Size.Width + 3, PictureBox_offset_help.Size.Height + 3)
        PictureBox_offset_help.Location = New Point(PictureBox_offset_help.Location.X - 1.5, PictureBox_offset_help.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_offset_help_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_offset_help.MouseLeave
        PictureBox_offset_help.Size = New Size(PictureBox_offset_help.Size.Width - 3, PictureBox_offset_help.Size.Height - 3)
        PictureBox_offset_help.Location = New Point(PictureBox_offset_help.Location.X + 1.5, PictureBox_offset_help.Location.Y + 1.5)
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
    'objects TABPAGE Security_Add
    Private Sub PictureBox_Security_Add_username_visible_Click(sender As Object, e As EventArgs) Handles PictureBox_Security_Add_username_visible.Click
        If Integer_Security_Add_username_visible_status = 1 Then
            Integer_Security_Add_username_visible_status = 2
            TextBox_Security_Add_username.UseSystemPasswordChar = True
            PictureBox_Security_Add_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
        Else
            Integer_Security_Add_username_visible_status = 1
            TextBox_Security_Add_username.UseSystemPasswordChar = False
            PictureBox_Security_Add_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
        End If
    End Sub
    Private Sub PictureBox_Security_Add_username_visible_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_Security_Add_username_visible.MouseEnter
        PictureBox_Security_Add_username_visible.Size = New Size(PictureBox_Security_Add_username_visible.Size.Width + 3, PictureBox_Security_Add_username_visible.Size.Height + 3)
        PictureBox_Security_Add_username_visible.Location = New Point(PictureBox_Security_Add_username_visible.Location.X - 1.5, PictureBox_Security_Add_username_visible.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_Security_Add_username_visible_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Security_Add_username_visible.MouseLeave
        PictureBox_Security_Add_username_visible.Size = New Size(PictureBox_Security_Add_username_visible.Size.Width - 3, PictureBox_Security_Add_username_visible.Size.Height - 3)
        PictureBox_Security_Add_username_visible.Location = New Point(PictureBox_Security_Add_username_visible.Location.X + 1.5, PictureBox_Security_Add_username_visible.Location.Y + 1.5)
    End Sub

    Private Sub PictureBox_Security_Add_password_visible_Click(sender As Object, e As EventArgs) Handles PictureBox_Security_Add_password_visible.Click
        If Integer_Security_Add_password_visible_status = 1 Then
            Integer_Security_Add_password_visible_status = 2
            TextBox_Security_Add_password.UseSystemPasswordChar = True
            TextBox_Security_Add_confirm_password.UseSystemPasswordChar = True
            PictureBox_Security_Add_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
        Else
            Integer_Security_Add_password_visible_status = 1
            TextBox_Security_Add_password.UseSystemPasswordChar = False
            TextBox_Security_Add_confirm_password.UseSystemPasswordChar = False
            PictureBox_Security_Add_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
        End If
    End Sub
    Private Sub PictureBox_Security_Add_password_visible_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_Security_Add_password_visible.MouseEnter
        PictureBox_Security_Add_password_visible.Size = New Size(PictureBox_Security_Add_password_visible.Size.Width + 3, PictureBox_Security_Add_password_visible.Size.Height + 3)
        PictureBox_Security_Add_password_visible.Location = New Point(PictureBox_Security_Add_password_visible.Location.X - 1.5, PictureBox_Security_Add_password_visible.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_Security_Add_password_visible_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Security_Add_password_visible.MouseLeave
        PictureBox_Security_Add_password_visible.Size = New Size(PictureBox_Security_Add_password_visible.Size.Width - 3, PictureBox_Security_Add_password_visible.Size.Height - 3)
        PictureBox_Security_Add_password_visible.Location = New Point(PictureBox_Security_Add_password_visible.Location.X + 1.5, PictureBox_Security_Add_password_visible.Location.Y + 1.5)
    End Sub

    Private Sub Button_Security_Add_done_Click(sender As Object, e As EventArgs) Handles Button_Security_Add_done.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If TextBox_Security_Add_username.Text = String.Empty Or TextBox_Security_Add_password.Text = String.Empty Or Trim(TextBox_Security_Add_name.Text) = String.Empty Then
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Name and Username and password cannot be empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("نام و نام کاربری و رمز عبور نمی توانند خالی باشند", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("لا يمكن أن يكون الاسم واسم المستخدم وكلمة المرور فارغين", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("El nombre y el nombre de usuario y la contraseña no pueden estar vacíos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        Else
            Public_String_username_text = TextBox_Security_Add_username.Text.ToString
            Public_username_format_check()

            If Public_Integer_username_format_error = 1 Then
                Select Case My.Settings.Languages
                    Case 1
                        Message_box = MessageBox.Show("The username format is incorrect" & vbNewLine & "The correct username format includes English letters and numbers and the symbols ""_"" (underline) and ""."" (Period) and without spaces", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 2
                        Message_box = MessageBox.Show("قالب نام کاربری نادرست است" & vbNewLine & "قالب صحیح نام کاربری شامل حروف و اعداد انگلیسی و نمادهای ""_"" (زیرخط) و ""."" (نقطه) و بدون فاصله میباشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 3
                        Message_box = MessageBox.Show("نموذج اسم المستخدم غير صحيح" & vbNewLine & "يتضمن تنسيق اسم المستخدم الصحيح أحرفًا وأرقامًا إنجليزية ورموز ""_"" (تسطير) و ""."" (فترة) وبدون مسافات", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 4
                        Message_box = MessageBox.Show("El formato del nombre de usuario es incorrecto" & vbNewLine & "El formato de nombre de usuario correcto incluye letras y números en inglés y los símbolos ""_"" (subrayado) y ""."" (Punto) y sin espacios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                If TextBox_Security_Add_password.TextLength < 8 Then
                    Select Case My.Settings.Languages
                        Case 1
                            Message_box = MessageBox.Show("Password must be more than 8 digits", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 2
                            Message_box = MessageBox.Show("رمز عبور باید بیشتر از ۸ رقم باشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 3
                            Message_box = MessageBox.Show("يجب أن تكون كلمة المرور أكثر من 8 أرقام", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 4
                            Message_box = MessageBox.Show("La contraseña debe tener más de 8 dígitos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Select
                Else
                    If TextBox_Security_Add_password.Text.Replace(" ", String.Empty) = String.Empty Then
                        Select Case My.Settings.Languages
                            Case 1
                                Message_box = MessageBox.Show("Password must contain at least one letter or number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 2
                                Message_box = MessageBox.Show("رمز عبور باید حداقل حاوی یک حرف یا عدد باشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 3
                                Message_box = MessageBox.Show("يجب أن تحتوي كلمة المرور على حرف أو رقم واحد على الأقل", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 4
                                Message_box = MessageBox.Show("La contraseña debe contener al menos una letra o un número", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Select
                    Else
                        If Not TextBox_Security_Add_password.Text = TextBox_Security_Add_confirm_password.Text Then
                            Select Case My.Settings.Languages
                                Case 1
                                    Message_box = MessageBox.Show("The password does not match the password confirmation", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Case 2
                                    Message_box = MessageBox.Show("رمز عبور با تأیید رمز عبور مطابقت ندارد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Case 3
                                    Message_box = MessageBox.Show("كلمة المرور لا تتطابق مع تأكيد كلمة المرور", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Case 4
                                    Message_box = MessageBox.Show("La contraseña no coincide con la confirmación de la contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End Select
                        Else
                            Dim searchQuery As String = ("select * from security where name = N'" & TextBox_Security_Add_name.Text & "'")
                            Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
                            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
                            Dim DataTable As New DataTable
                            data_adapter.Fill(DataTable)
                            If Not DataTable.Rows.Count = 0 Then
                                Select Case My.Settings.Languages
                                    Case 1
                                        Message_box = MessageBox.Show("This name has already been selected" & vbNewLine & "Please enter another name", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Case 2
                                        Message_box = MessageBox.Show("این نام قبلاً انتخاب شده است" & vbNewLine & "لطفاً نام دیگری وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Case 3
                                        Message_box = MessageBox.Show("تم تحديد هذا الاسم بالفعل" & vbNewLine & "الرجاء إدخال اسم آخر", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Case 4
                                        Message_box = MessageBox.Show("Este nombre ya ha sido seleccionado" & vbNewLine & "Por favor ingrese otro nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End Select
                            Else
                                Dim searchQuery_1 As String = ("select * from security where username = N'" & TextBox_Security_Add_username.Text & "'")
                                Dim command_1 As New SqlCommand(searchQuery_1, Public_connect_DataGridView)
                                Dim data_adapter_1 As SqlDataAdapter = New SqlDataAdapter(command_1)
                                Dim DataTable_1 As New DataTable
                                data_adapter_1.Fill(DataTable_1)
                                If Not DataTable_1.Rows.Count = 0 Then
                                    Select Case My.Settings.Languages
                                        Case 1
                                            Message_box = MessageBox.Show("This username has already been selected" & vbNewLine & "Please select another username", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Case 2
                                            Message_box = MessageBox.Show("این نام کاربری قبلاً انتخاب شده است" & vbNewLine & "لطفاً نام کاربری دیگری را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Case 3
                                            Message_box = MessageBox.Show("تم اختيار اسم المستخدم هذا بالفعل" & vbNewLine & "الرجاء تحديد اسم مستخدم آخر", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Case 4
                                            Message_box = MessageBox.Show("Este nombre de usuario ya ha sido seleccionado" & vbNewLine & "Seleccione otro nombre de usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End Select
                                Else
                                    Select Case My.Settings.Languages
                                        Case 1
                                            Message_box = MessageBox.Show("Are you sure the information is correct?", "Hospital information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                        Case 2
                                            Message_box = MessageBox.Show("آیا از صحت اطلاعات اطمینان دارید؟", "اطلاعات بیمارستان", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                        Case 3
                                            Message_box = MessageBox.Show("هل أنت متأكد من صحة المعلومات؟", "معلومات المستشفى", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                        Case 4
                                            Message_box = MessageBox.Show("¿Estás seguro de que la información es correcta?", "Información del hospital", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                    End Select

                                    If Message_box = DialogResult.Yes Then
                                        Dim insert As String = "insert into security (name,username,password) values (N'" & TextBox_Security_Add_name.Text & "',N'" & TextBox_Security_Add_username.Text & "',N'" & TextBox_Security_Add_password.Text & "')"
                                        Dim Run As SqlCommand = New SqlCommand(insert, Public_connect_DataGridView)
                                        Public_connect_DataGridView.Open()
                                        Run.ExecuteNonQuery()
                                        Public_connect_DataGridView.Close()

                                        TextBox_Security_Add_name.Text = String.Empty
                                        TextBox_Security_Add_username.Text = String.Empty
                                        TextBox_Security_Add_password.Text = String.Empty
                                        TextBox_Security_Add_confirm_password.Text = String.Empty

                                        Select Case My.Settings.Languages
                                            Case 1
                                                Message_box = MessageBox.Show("New username and password successfully registered", "Username and password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Case 2
                                                Message_box = MessageBox.Show("نام کاربری و رمز عبور جدید با موفقیت ثبت شد", "نام کاربری و رمز عبور", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Case 3
                                                Message_box = MessageBox.Show("تم تسجيل اسم المستخدم وكلمة المرور الجديدة بنجاح", "اسم المستخدم و كلمة السر", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Case 4
                                                Message_box = MessageBox.Show("Nuevo nombre de usuario y contraseña registrados correctamente", "Nombre de usuario y contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End Select
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
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
    'objects TABPAGE Security_Delete
    Private Sub PictureBox_Security_Delete_username_visible_Click(sender As Object, e As EventArgs) Handles PictureBox_Security_Delete_username_visible.Click
        If Integer_Security_Delete_username_visible_status = 1 Then
            Integer_Security_Delete_username_visible_status = 2
            TextBox_Security_Delete_username.UseSystemPasswordChar = True
            PictureBox_Security_Delete_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
        Else
            Integer_Security_Delete_username_visible_status = 1
            TextBox_Security_Delete_username.UseSystemPasswordChar = False
            PictureBox_Security_Delete_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
        End If
    End Sub
    Private Sub PictureBox_Security_Delete_username_visible_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_Security_Delete_username_visible.MouseEnter
        PictureBox_Security_Delete_username_visible.Size = New Size(PictureBox_Security_Delete_username_visible.Size.Width + 3, PictureBox_Security_Delete_username_visible.Size.Height + 3)
        PictureBox_Security_Delete_username_visible.Location = New Point(PictureBox_Security_Delete_username_visible.Location.X - 1.5, PictureBox_Security_Delete_username_visible.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_Security_Delete_username_visible_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Security_Delete_username_visible.MouseLeave
        PictureBox_Security_Delete_username_visible.Size = New Size(PictureBox_Security_Delete_username_visible.Size.Width - 3, PictureBox_Security_Delete_username_visible.Size.Height - 3)
        PictureBox_Security_Delete_username_visible.Location = New Point(PictureBox_Security_Delete_username_visible.Location.X + 1.5, PictureBox_Security_Delete_username_visible.Location.Y + 1.5)
    End Sub

    Private Sub PictureBox_Security_Delete_password_visible_Click(sender As Object, e As EventArgs) Handles PictureBox_Security_Delete_password_visible.Click
        If Integer_Security_Delete_password_visible_status = 1 Then
            Integer_Security_Delete_password_visible_status = 2
            TextBox_Security_Delete_password.UseSystemPasswordChar = True
            PictureBox_Security_Delete_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
        Else
            Integer_Security_Delete_password_visible_status = 1
            TextBox_Security_Delete_password.UseSystemPasswordChar = False
            PictureBox_Security_Delete_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
        End If
    End Sub
    Private Sub PictureBox_Security_Delete_password_visible_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_Security_Delete_password_visible.MouseEnter
        PictureBox_Security_Delete_password_visible.Size = New Size(PictureBox_Security_Delete_password_visible.Size.Width + 3, PictureBox_Security_Delete_password_visible.Size.Height + 3)
        PictureBox_Security_Delete_password_visible.Location = New Point(PictureBox_Security_Delete_password_visible.Location.X - 1.5, PictureBox_Security_Delete_password_visible.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_Security_Delete_password_visible_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Security_Delete_password_visible.MouseLeave
        PictureBox_Security_Delete_password_visible.Size = New Size(PictureBox_Security_Delete_password_visible.Size.Width - 3, PictureBox_Security_Delete_password_visible.Size.Height - 3)
        PictureBox_Security_Delete_password_visible.Location = New Point(PictureBox_Security_Delete_password_visible.Location.X + 1.5, PictureBox_Security_Delete_password_visible.Location.Y + 1.5)
    End Sub

    Private Sub Button_Security_Delete_done_Click(sender As Object, e As EventArgs) Handles Button_Security_Delete_done.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If TextBox_Security_Delete_username.Text = String.Empty Or TextBox_Security_Delete_password.Text = String.Empty Or Trim(TextBox_Security_Delete_name.Text) = String.Empty Then
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Name and Username and password cannot be empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("نام و نام کاربری و رمز عبور نمی توانند خالی باشند", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("لا يمكن أن يكون الاسم واسم المستخدم وكلمة المرور فارغين", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("El nombre y el nombre de usuario y la contraseña no pueden estar vacíos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        Else
            Dim searchQuery As String = ("select * from security where username = N'" & TextBox_Security_Delete_username.Text & "'")
            Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            data_adapter.Fill(DataTable)

            If Not DataTable.Rows.Count > 0 Then
                Select Case My.Settings.Languages
                    Case 1
                        Message_box = MessageBox.Show("Incorrect name or username or password" & vbNewLine & "Please try again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 2
                        Message_box = MessageBox.Show("نام یا نام کاربری یا رمز عبور نادرست است" & vbNewLine & "لطفا دوباره امتحان کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 3
                        Message_box = MessageBox.Show("اسم غير صحيح أو اسم المستخدم أو كلمة المرور" & vbNewLine & "حاول مرة اخرى", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 4
                        Message_box = MessageBox.Show("Nombre, nombre de usuario o contraseña incorrectos" & vbNewLine & "Inténtalo de nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                If Not TextBox_Security_Delete_name.Text = DataTable.Rows(0).Item(1) Then
                    Select Case My.Settings.Languages
                        Case 1
                            Message_box = MessageBox.Show("Incorrect name or username or password" & vbNewLine & "Please try again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 2
                            Message_box = MessageBox.Show("نام یا نام کاربری یا رمز عبور نادرست است" & vbNewLine & "لطفا دوباره امتحان کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 3
                            Message_box = MessageBox.Show("اسم غير صحيح أو اسم المستخدم أو كلمة المرور" & vbNewLine & "حاول مرة اخرى", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 4
                            Message_box = MessageBox.Show("Nombre, nombre de usuario o contraseña incorrectos" & vbNewLine & "Inténtalo de nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Select
                Else
                    If Not TextBox_Security_Delete_password.Text = DataTable.Rows(0).Item(3) Then
                        Select Case My.Settings.Languages
                            Case 1
                                Message_box = MessageBox.Show("Incorrect name or username or password" & vbNewLine & "Please try again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 2
                                Message_box = MessageBox.Show("نام یا نام کاربری یا رمز عبور نادرست است" & vbNewLine & "لطفا دوباره امتحان کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 3
                                Message_box = MessageBox.Show("اسم غير صحيح أو اسم المستخدم أو كلمة المرور" & vbNewLine & "حاول مرة اخرى", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 4
                                Message_box = MessageBox.Show("Nombre, nombre de usuario o contraseña incorrectos" & vbNewLine & "Inténtalo de nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Select
                    Else
                        Select Case My.Settings.Languages
                            Case 1
                                Message_box = MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            Case 2
                                Message_box = MessageBox.Show("آیا مطمئن هستید که میخواهید این مورد را حذف کنید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            Case 3
                                Message_box = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا البند؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            Case 4
                                Message_box = MessageBox.Show("¿Estás seguro de que quieres eliminar este artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        End Select

                        If Message_box = DialogResult.Yes Then
                            Dim Delete As String = "Delete from security where id=" & DataTable.Rows(0).Item(0)
                            Dim Run As SqlCommand = New SqlCommand(Delete, Public_connect_DataGridView)
                            Public_connect_DataGridView.Open()
                            Run.ExecuteNonQuery()
                            Public_connect_DataGridView.Close()

                            TextBox_Security_Delete_name.Text = String.Empty
                            TextBox_Security_Delete_username.Text = String.Empty
                            TextBox_Security_Delete_password.Text = String.Empty

                            Select Case My.Settings.Languages
                                Case 1
                                    Message_box = MessageBox.Show("Username and password successfully removed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Case 2
                                    Message_box = MessageBox.Show("نام کاربری و رمز عبور با موفقیت حذف شد", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Case 3
                                    Message_box = MessageBox.Show("تمت إزالة اسم المستخدم وكلمة المرور بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Case 4
                                    Message_box = MessageBox.Show("Nombre de usuario y contraseña eliminados correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Select
                        End If
                    End If
                End If
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
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
    'objects TABPAGE Security_Edit
    'Private Sub PictureBox_Security_Edit_step_1_username_visible_Click(sender As Object, e As EventArgs)
    '    If Integer_Security_Edit_step_1_username_visible_status = 1 Then
    '        Integer_Security_Edit_step_1_username_visible_status = 2
    '        TextBox_Security_Edit_step_1_username.UseSystemPasswordChar = True
    '        PictureBox_Security_Edit_step_1_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
    '    Else
    '        Integer_Security_Edit_step_1_username_visible_status = 1
    '        TextBox_Security_Edit_step_1_username.UseSystemPasswordChar = False
    '        PictureBox_Security_Edit_step_1_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
    '    End If
    'End Sub
    'Private Sub PictureBox_Security_Edit_step_1_username_visible_MouseEnter(sender As Object, e As EventArgs)
    '    PictureBox_Security_Edit_step_1_username_visible.Size = New Size(PictureBox_Security_Edit_step_1_username_visible.Size.Width + 3, PictureBox_Security_Edit_step_1_username_visible.Size.Height + 3)
    '    PictureBox_Security_Edit_step_1_username_visible.Location = New Point(PictureBox_Security_Edit_step_1_username_visible.Location.X - 1.5, PictureBox_Security_Edit_step_1_username_visible.Location.Y - 1.5)
    'End Sub
    'Private Sub PictureBox_Security_Edit_step_1_username_visible_MouseLeave(sender As Object, e As EventArgs)
    '    PictureBox_Security_Edit_step_1_username_visible.Size = New Size(PictureBox_Security_Edit_step_1_username_visible.Size.Width - 3, PictureBox_Security_Edit_step_1_username_visible.Size.Height - 3)
    '    PictureBox_Security_Edit_step_1_username_visible.Location = New Point(PictureBox_Security_Edit_step_1_username_visible.Location.X + 1.5, PictureBox_Security_Edit_step_1_username_visible.Location.Y + 1.5)
    'End Sub

    'Private Sub PictureBox_Security_Edit_step_1_password_visible_Click(sender As Object, e As EventArgs)
    '    If Integer_Security_Edit_step_1_password_visible_status = 1 Then
    '        Integer_Security_Edit_step_1_password_visible_status = 2
    '        TextBox_Security_Edit_step_1_password.UseSystemPasswordChar = True
    '        PictureBox_Security_Edit_step_1_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
    '    Else
    '        Integer_Security_Edit_step_1_password_visible_status = 1
    '        TextBox_Security_Edit_step_1_password.UseSystemPasswordChar = False
    '        PictureBox_Security_Edit_step_1_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
    '    End If
    'End Sub
    'Private Sub PictureBox_Security_Edit_step_1_password_visible_MouseEnter(sender As Object, e As EventArgs)
    '    PictureBox_Security_Edit_step_1_password_visible.Size = New Size(PictureBox_Security_Edit_step_1_password_visible.Size.Width + 3, PictureBox_Security_Edit_step_1_password_visible.Size.Height + 3)
    '    PictureBox_Security_Edit_step_1_password_visible.Location = New Point(PictureBox_Security_Edit_step_1_password_visible.Location.X - 1.5, PictureBox_Security_Edit_step_1_password_visible.Location.Y - 1.5)
    'End Sub
    'Private Sub PictureBox_Security_Edit_step_1_password_visible_MouseLeave(sender As Object, e As EventArgs)
    '    PictureBox_Security_Edit_step_1_password_visible.Size = New Size(PictureBox_Security_Edit_step_1_password_visible.Size.Width - 3, PictureBox_Security_Edit_step_1_password_visible.Size.Height - 3)
    '    PictureBox_Security_Edit_step_1_password_visible.Location = New Point(PictureBox_Security_Edit_step_1_password_visible.Location.X + 1.5, PictureBox_Security_Edit_step_1_password_visible.Location.Y + 1.5)
    'End Sub

    'Private Sub PictureBox_Security_Edit_step_2_username_visible_Click(sender As Object, e As EventArgs)
    '    If Integer_Security_Edit_step_2_username_visible_status = 1 Then
    '        Integer_Security_Edit_step_2_username_visible_status = 2
    '        TextBox_Security_Edit_step_2_username.UseSystemPasswordChar = True
    '        PictureBox_Security_Edit_step_2_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
    '    Else
    '        Integer_Security_Edit_step_2_username_visible_status = 1
    '        TextBox_Security_Edit_step_2_username.UseSystemPasswordChar = False
    '        PictureBox_Security_Edit_step_2_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
    '    End If
    'End Sub
    'Private Sub PictureBox_Security_Edit_step_2_username_visible_MouseEnter(sender As Object, e As EventArgs)
    '    PictureBox_Security_Edit_step_2_username_visible.Size = New Size(PictureBox_Security_Edit_step_2_username_visible.Size.Width + 3, PictureBox_Security_Edit_step_2_username_visible.Size.Height + 3)
    '    PictureBox_Security_Edit_step_2_username_visible.Location = New Point(PictureBox_Security_Edit_step_2_username_visible.Location.X - 1.5, PictureBox_Security_Edit_step_2_username_visible.Location.Y - 1.5)
    'End Sub
    'Private Sub PictureBox_Security_Edit_step_2_username_visible_MouseLeave(sender As Object, e As EventArgs)
    '    PictureBox_Security_Edit_step_2_username_visible.Size = New Size(PictureBox_Security_Edit_step_2_username_visible.Size.Width - 3, PictureBox_Security_Edit_step_2_username_visible.Size.Height - 3)
    '    PictureBox_Security_Edit_step_2_username_visible.Location = New Point(PictureBox_Security_Edit_step_2_username_visible.Location.X + 1.5, PictureBox_Security_Edit_step_2_username_visible.Location.Y + 1.5)
    'End Sub

    'Private Sub PictureBox_Security_Edit_step_2_password_visible_Click(sender As Object, e As EventArgs)
    '    If Integer_Security_Edit_step_2_password_visible_status = 1 Then
    '        Integer_Security_Edit_step_2_password_visible_status = 2
    '        TextBox_Security_Edit_step_2_password.UseSystemPasswordChar = True
    '        PictureBox_Security_Edit_step_2_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
    '    Else
    '        Integer_Security_Edit_step_2_password_visible_status = 1
    '        TextBox_Security_Edit_step_2_password.UseSystemPasswordChar = False
    '        PictureBox_Security_Edit_step_2_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
    '    End If
    'End Sub
    'Private Sub PictureBox_Security_Edit_step_2_password_visible_MouseEnter(sender As Object, e As EventArgs)
    '    PictureBox_Security_Edit_step_2_password_visible.Size = New Size(PictureBox_Security_Edit_step_2_password_visible.Size.Width + 3, PictureBox_Security_Edit_step_2_password_visible.Size.Height + 3)
    '    PictureBox_Security_Edit_step_2_password_visible.Location = New Point(PictureBox_Security_Edit_step_2_password_visible.Location.X - 1.5, PictureBox_Security_Edit_step_2_password_visible.Location.Y - 1.5)
    'End Sub
    'Private Sub PictureBox_Security_Edit_step_2_password_visible_MouseLeave(sender As Object, e As EventArgs)
    '    PictureBox_Security_Edit_step_2_password_visible.Size = New Size(PictureBox_Security_Edit_step_2_password_visible.Size.Width - 3, PictureBox_Security_Edit_step_2_password_visible.Size.Height - 3)
    '    PictureBox_Security_Edit_step_2_password_visible.Location = New Point(PictureBox_Security_Edit_step_2_password_visible.Location.X + 1.5, PictureBox_Security_Edit_step_2_password_visible.Location.Y + 1.5)
    'End Sub

    'Private Sub Button_Security_Edit_done_Click(sender As Object, e As EventArgs)
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

    '    If Integer_Security_Edit_step = 1 Then
    '        If TextBox_Security_Edit_step_1_username.Text = String.Empty Or TextBox_Security_Edit_step_1_password.Text = String.Empty Or Trim(TextBox_Security_Edit_step_1_name.Text) = String.Empty Then
    '            Select Case My.Settings.Languages
    '                Case 1
    '                    Message_box = MessageBox.Show("Name and Username and password cannot be empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                Case 2
    '                    Message_box = MessageBox.Show("نام و نام کاربری و رمز عبور نمی توانند خالی باشند", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                Case 3
    '                    Message_box = MessageBox.Show("لا يمكن أن يكون الاسم واسم المستخدم وكلمة المرور فارغين", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                Case 4
    '                    Message_box = MessageBox.Show("El nombre y el nombre de usuario y la contraseña no pueden estar vacíos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            End Select
    '        Else
    '            Dim searchQuery As String = ("select * from security where username = N'" & TextBox_Security_Edit_step_1_username.Text & "'")
    '            Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
    '            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
    '            Dim DataTable As New DataTable
    '            data_adapter.Fill(DataTable)

    '            If Not DataTable.Rows.Count > 0 Then
    '                Select Case My.Settings.Languages
    '                    Case 1
    '                        Message_box = MessageBox.Show("Incorrect name or username or password" & vbNewLine & "Please try again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    Case 2
    '                        Message_box = MessageBox.Show("نام یا نام کاربری یا رمز عبور نادرست است" & vbNewLine & "لطفا دوباره امتحان کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    Case 3
    '                        Message_box = MessageBox.Show("اسم غير صحيح أو اسم المستخدم أو كلمة المرور" & vbNewLine & "حاول مرة اخرى", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    Case 4
    '                        Message_box = MessageBox.Show("Nombre, nombre de usuario o contraseña incorrectos" & vbNewLine & "Inténtalo de nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                End Select
    '            Else
    '                If Not TextBox_Security_Edit_step_1_name.Text = DataTable.Rows(0).Item(1) Then
    '                    Select Case My.Settings.Languages
    '                        Case 1
    '                            Message_box = MessageBox.Show("Incorrect name or username or password" & vbNewLine & "Please try again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        Case 2
    '                            Message_box = MessageBox.Show("نام یا نام کاربری یا رمز عبور نادرست است" & vbNewLine & "لطفا دوباره امتحان کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        Case 3
    '                            Message_box = MessageBox.Show("اسم غير صحيح أو اسم المستخدم أو كلمة المرور" & vbNewLine & "حاول مرة اخرى", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        Case 4
    '                            Message_box = MessageBox.Show("Nombre, nombre de usuario o contraseña incorrectos" & vbNewLine & "Inténtalo de nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    End Select
    '                Else
    '                    If Not TextBox_Security_Edit_step_1_password.Text = DataTable.Rows(0).Item(3) Then
    '                        Select Case My.Settings.Languages
    '                            Case 1
    '                                Message_box = MessageBox.Show("Incorrect name or username or password" & vbNewLine & "Please try again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                            Case 2
    '                                Message_box = MessageBox.Show("نام یا نام کاربری یا رمز عبور نادرست است" & vbNewLine & "لطفا دوباره امتحان کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                            Case 3
    '                                Message_box = MessageBox.Show("اسم غير صحيح أو اسم المستخدم أو كلمة المرور" & vbNewLine & "حاول مرة اخرى", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                            Case 4
    '                                Message_box = MessageBox.Show("Nombre, nombre de usuario o contraseña incorrectos" & vbNewLine & "Inténtalo de nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        End Select
    '                    Else
    '                        Select Case My.Settings.Languages
    '                            Case 1
    '                                Message_box = MessageBox.Show("Are you sure you want to edit this item?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '                            Case 2
    '                                Message_box = MessageBox.Show("آیا مطمئن هستید که میخواهید این مورد را ویرایش کنید؟", "ویرایش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '                            Case 3
    '                                Message_box = MessageBox.Show("هل أنت متأكد أنك تريد تحرير هذا العنصر؟", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '                            Case 4
    '                                Message_box = MessageBox.Show("¿Estás seguro de que quieres editar este artículo?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '                        End Select

    '                        If Message_box = DialogResult.Yes Then
    '                            Integer_get_id = DataTable.Rows(0).Item(0)
    '                            String_get_name = DataTable.Rows(0).Item(1)
    '                            String_get_username = DataTable.Rows(0).Item(2)
    '                            String_get_password = DataTable.Rows(0).Item(3)

    '                            TextBox_Security_Edit_step_1_name.Text = String.Empty
    '                            TextBox_Security_Edit_step_1_username.Text = String.Empty
    '                            TextBox_Security_Edit_step_1_password.Text = String.Empty

    '                            Label_Security_Edit_step_1_name.Visible = False
    '                            Label_Security_Edit_step_1_username.Visible = False
    '                            Label_Security_Edit_step_1_password.Visible = False
    '                            TextBox_Security_Edit_step_1_name.Visible = False
    '                            TextBox_Security_Edit_step_1_username.Visible = False
    '                            TextBox_Security_Edit_step_1_password.Visible = False
    '                            PictureBox_Security_Edit_step_1_username_visible.Visible = False
    '                            PictureBox_Security_Edit_step_1_password_visible.Visible = False

    '                            Label_Security_Edit_step_2_name.Visible = True
    '                            Label_Security_Edit_step_2_username.Visible = True
    '                            Label_Security_Edit_step_2_password.Visible = True
    '                            Label_Security_Edit_step_2_confirm_password.Visible = True
    '                            TextBox_Security_Edit_step_2_name.Visible = True
    '                            TextBox_Security_Edit_step_2_username.Visible = True
    '                            TextBox_Security_Edit_step_2_password.Visible = True
    '                            TextBox_Security_Edit_step_2_confirm_password.Visible = True
    '                            PictureBox_Security_Edit_step_2_username_visible.Visible = True
    '                            PictureBox_Security_Edit_step_2_password_visible.Visible = True

    '                            Select Case My.Settings.Languages
    '                                Case 1
    '                                    Button_Security_Edit_done.Text = "Edit"
    '                                Case 2
    '                                    Button_Security_Edit_done.Text = "ویرایش"
    '                                Case 3
    '                                    Button_Security_Edit_done.Text = "تعديل"
    '                                Case 4
    '                                    Button_Security_Edit_done.Text = "Editar"
    '                            End Select

    '                            Integer_Security_Edit_step = 2
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '    Else



















    '        If TextBox_Security_Add_username.Text = String.Empty Or TextBox_Security_Add_password.Text = String.Empty Or Trim(TextBox_Security_Add_name.Text) = String.Empty Then
    '            Select Case My.Settings.Languages
    '                Case 1
    '                    Message_box = MessageBox.Show("Name and Username and password cannot be empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                Case 2
    '                    Message_box = MessageBox.Show("نام و نام کاربری و رمز عبور نمی توانند خالی باشند", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                Case 3
    '                    Message_box = MessageBox.Show("لا يمكن أن يكون الاسم واسم المستخدم وكلمة المرور فارغين", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                Case 4
    '                    Message_box = MessageBox.Show("El nombre y el nombre de usuario y la contraseña no pueden estar vacíos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            End Select
    '        Else
    '            Public_String_username_text = TextBox_Security_Add_username.Text.ToString
    '            Public_username_format_check()

    '            If Public_Integer_username_format_error = 1 Then
    '                Select Case My.Settings.Languages
    '                    Case 1
    '                        Message_box = MessageBox.Show("The username format is incorrect" & vbNewLine & "The correct username format includes English letters and numbers and the symbols ""_"" (underline) and ""."" (Period) and without spaces", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    Case 2
    '                        Message_box = MessageBox.Show("قالب نام کاربری نادرست است" & vbNewLine & "قالب صحیح نام کاربری شامل حروف و اعداد انگلیسی و نمادهای ""_"" (زیرخط) و ""."" (نقطه) و بدون فاصله میباشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    Case 3
    '                        Message_box = MessageBox.Show("نموذج اسم المستخدم غير صحيح" & vbNewLine & "يتضمن تنسيق اسم المستخدم الصحيح أحرفًا وأرقامًا إنجليزية ورموز ""_"" (تسطير) و ""."" (فترة) وبدون مسافات", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    Case 4
    '                        Message_box = MessageBox.Show("El formato del nombre de usuario es incorrecto" & vbNewLine & "El formato de nombre de usuario correcto incluye letras y números en inglés y los símbolos ""_"" (subrayado) y ""."" (Punto) y sin espacios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                End Select
    '            Else
    '                If TextBox_Security_Add_password.TextLength < 8 Then
    '                    Select Case My.Settings.Languages
    '                        Case 1
    '                            Message_box = MessageBox.Show("Password must be more than 8 digits", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        Case 2
    '                            Message_box = MessageBox.Show("رمز عبور باید بیشتر از ۸ رقم باشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        Case 3
    '                            Message_box = MessageBox.Show("يجب أن تكون كلمة المرور أكثر من 8 أرقام", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        Case 4
    '                            Message_box = MessageBox.Show("La contraseña debe tener más de 8 dígitos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    End Select
    '                Else
    '                    If TextBox_Security_Add_password.Text.Replace(" ", String.Empty) = String.Empty Then
    '                        Select Case My.Settings.Languages
    '                            Case 1
    '                                Message_box = MessageBox.Show("Password must contain at least one letter or number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                            Case 2
    '                                Message_box = MessageBox.Show("رمز عبور باید حداقل حاوی یک حرف یا عدد باشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                            Case 3
    '                                Message_box = MessageBox.Show("يجب أن تحتوي كلمة المرور على حرف أو رقم واحد على الأقل", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                            Case 4
    '                                Message_box = MessageBox.Show("La contraseña debe contener al menos una letra o un número", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        End Select
    '                    Else
    '                        If Not TextBox_Security_Add_password.Text = TextBox_Security_Add_confirm_password.Text Then
    '                            Select Case My.Settings.Languages
    '                                Case 1
    '                                    Message_box = MessageBox.Show("The password does not match the password confirmation", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                Case 2
    '                                    Message_box = MessageBox.Show("رمز عبور با تأیید رمز عبور مطابقت ندارد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                Case 3
    '                                    Message_box = MessageBox.Show("كلمة المرور لا تتطابق مع تأكيد كلمة المرور", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                Case 4
    '                                    Message_box = MessageBox.Show("La contraseña no coincide con la confirmación de la contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                            End Select
    '                        Else
    '                            Dim searchQuery As String = ("select * from security where name = N'" & TextBox_Security_Add_name.Text & "'")
    '                            Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
    '                            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
    '                            Dim DataTable As New DataTable
    '                            data_adapter.Fill(DataTable)
    '                            If Not DataTable.Rows.Count = 0 Then
    '                                Select Case My.Settings.Languages
    '                                    Case 1
    '                                        Message_box = MessageBox.Show("This name has already been selected" & vbNewLine & "Please enter another name", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    Case 2
    '                                        Message_box = MessageBox.Show("این نام قبلاً انتخاب شده است" & vbNewLine & "لطفاً نام دیگری وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    Case 3
    '                                        Message_box = MessageBox.Show("تم تحديد هذا الاسم بالفعل" & vbNewLine & "الرجاء إدخال اسم آخر", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    Case 4
    '                                        Message_box = MessageBox.Show("Este nombre ya ha sido seleccionado" & vbNewLine & "Por favor ingrese otro nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                End Select
    '                            Else
    '                                Dim searchQuery_1 As String = ("select * from security where username = N'" & TextBox_Security_Add_username.Text & "'")
    '                                Dim command_1 As New SqlCommand(searchQuery_1, Public_connect_DataGridView)
    '                                Dim data_adapter_1 As SqlDataAdapter = New SqlDataAdapter(command_1)
    '                                Dim DataTable_1 As New DataTable
    '                                data_adapter_1.Fill(DataTable_1)
    '                                If Not DataTable_1.Rows.Count = 0 Then
    '                                    Select Case My.Settings.Languages
    '                                        Case 1
    '                                            Message_box = MessageBox.Show("This username has already been selected" & vbNewLine & "Please select another username", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                        Case 2
    '                                            Message_box = MessageBox.Show("این نام کاربری قبلاً انتخاب شده است" & vbNewLine & "لطفاً نام کاربری دیگری را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                        Case 3
    '                                            Message_box = MessageBox.Show("تم اختيار اسم المستخدم هذا بالفعل" & vbNewLine & "الرجاء تحديد اسم مستخدم آخر", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                        Case 4
    '                                            Message_box = MessageBox.Show("Este nombre de usuario ya ha sido seleccionado" & vbNewLine & "Seleccione otro nombre de usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    End Select
    '                                Else
    '                                    Select Case My.Settings.Languages
    '                                        Case 1
    '                                            Message_box = MessageBox.Show("Are you sure the information is correct?", "Hospital information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '                                        Case 2
    '                                            Message_box = MessageBox.Show("آیا از صحت اطلاعات اطمینان دارید؟", "اطلاعات بیمارستان", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '                                        Case 3
    '                                            Message_box = MessageBox.Show("هل أنت متأكد من صحة المعلومات؟", "معلومات المستشفى", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '                                        Case 4
    '                                            Message_box = MessageBox.Show("¿Estás seguro de que la información es correcta?", "Información del hospital", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '                                    End Select

    '                                    If Message_box = DialogResult.Yes Then
    '                                        Dim insert As String = "insert into security (name,username,password) values (N'" & TextBox_Security_Add_name.Text & "',N'" & TextBox_Security_Add_username.Text & "',N'" & TextBox_Security_Add_password.Text & "')"
    '                                        Dim Run As SqlCommand = New SqlCommand(insert, Public_connect_DataGridView)
    '                                        Public_connect_DataGridView.Open()
    '                                        Run.ExecuteNonQuery()
    '                                        Public_connect_DataGridView.Close()

    '                                        TextBox_Security_Add_name.Text = String.Empty
    '                                        TextBox_Security_Add_username.Text = String.Empty
    '                                        TextBox_Security_Add_password.Text = String.Empty
    '                                        TextBox_Security_Add_confirm_password.Text = String.Empty

    '                                        Select Case My.Settings.Languages
    '                                            Case 1
    '                                                Message_box = MessageBox.Show("New username and password successfully registered", "Username and password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                            Case 2
    '                                                Message_box = MessageBox.Show("نام کاربری و رمز عبور جدید با موفقیت ثبت شد", "نام کاربری و رمز عبور", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                            Case 3
    '                                                Message_box = MessageBox.Show("تم تسجيل اسم المستخدم وكلمة المرور الجديدة بنجاح", "اسم المستخدم و كلمة السر", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                            Case 4
    '                                                Message_box = MessageBox.Show("Nuevo nombre de usuario y contraseña registrados correctamente", "Nombre de usuario y contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                        End Select
    '                                    End If
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If






    '    Dim searchQuery As String = ("select * from security where name = N'" & TextBox_Security_Add_name.Text & "'")
    '    Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
    '    Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
    '    Dim DataTable As New DataTable
    '    data_adapter.Fill(DataTable)
    '    If Not DataTable.Rows.Count = 0 Then
    '        If Not DataTable.Rows(0).Item(1) = String_get_name Then

    '        Else
    '            Dim searchQuery_1 As String = ("select * from security where username = N'" & TextBox_Security_Add_username.Text & "'")
    '            Dim command_1 As New SqlCommand(searchQuery_1, Public_connect_DataGridView)
    '            Dim data_adapter_1 As SqlDataAdapter = New SqlDataAdapter(command_1)
    '            Dim DataTable_1 As New DataTable
    '            data_adapter_1.Fill(DataTable_1)
    '            If Not DataTable_1.Rows.Count = 0 Then
    '                If Not DataTable.Rows(0).Item(2) = String_get_username Then

    '                Else

    '                End If
    '            Else

    '            End If
    '        End If
    '    Else

    '    End If





    '    'Dim edit As String = "update security set name=N'" & TextBox_Security_Edit_step_2_name.Text & "',username=N'" & TextBox_Security_Edit_step_2_username.Text & "',password=N'" & TextBox_Security_Edit_step_2_password.Text & "' where id=" & Integer_get_id
    '    'Dim Run As SqlCommand = New SqlCommand(edit, Public_connect_DataGridView)
    '    'Public_connect_DataGridView.Open()
    '    'Run.ExecuteNonQuery()
    '    'Public_connect_DataGridView.Close()

    '    'Integer_get_id = 0
    '    'String_get_name = String.Empty
    '    'String_get_username = String.Empty
    '    'String_get_password = String.Empty

    '    'TextBox_Security_Edit_step_2_name.Text = String.Empty
    '    'TextBox_Security_Edit_step_2_username.Text = String.Empty
    '    'TextBox_Security_Edit_step_2_password.Text = String.Empty
    '    'TextBox_Security_Edit_step_2_confirm_password.Text = String.Empty

    '    'Label_Security_Edit_step_2_name.Visible = False
    '    'Label_Security_Edit_step_2_username.Visible = False
    '    'Label_Security_Edit_step_2_password.Visible = False
    '    'Label_Security_Edit_step_2_confirm_password.Visible = False
    '    'TextBox_Security_Edit_step_2_name.Visible = False
    '    'TextBox_Security_Edit_step_2_username.Visible = False
    '    'TextBox_Security_Edit_step_2_password.Visible = False
    '    'TextBox_Security_Edit_step_2_confirm_password.Visible = False
    '    'PictureBox_Security_Edit_step_2_username_visible.Visible = False
    '    'PictureBox_Security_Edit_step_2_password_visible.Visible = False

    '    'Label_Security_Edit_step_1_name.Visible = True
    '    'Label_Security_Edit_step_1_username.Visible = True
    '    'Label_Security_Edit_step_1_password.Visible = True
    '    'TextBox_Security_Edit_step_1_name.Visible = True
    '    'TextBox_Security_Edit_step_1_username.Visible = True
    '    'TextBox_Security_Edit_step_1_password.Visible = True
    '    'PictureBox_Security_Edit_step_1_username_visible.Visible = True
    '    'PictureBox_Security_Edit_step_1_password_visible.Visible = True

    '    'Select Case My.Settings.Languages
    '    '    Case 1
    '    '        Button_Security_Edit_done.Text = "Next"
    '    '    Case 2
    '    '        Button_Security_Edit_done.Text = "بعدی"
    '    '    Case 3
    '    '        Button_Security_Edit_done.Text = "التالى"
    '    '    Case 4
    '    '        Button_Security_Edit_done.Text = "siguiente"
    '    'End Select

    '    'Integer_Security_Edit_step = 1

    '    'Select Case My.Settings.Languages
    '    '    Case 1
    '    '        Message_box = MessageBox.Show("Username and password changed successfully", "Username and password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    Case 2
    '    '        Message_box = MessageBox.Show("نام کاربری و رمز عبور با موفقیت تغییر یافت", "نام کاربری و رمز عبور", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    Case 3
    '    '        Message_box = MessageBox.Show("تم تغيير اسم المستخدم وكلمة المرور بنجاح", "اسم المستخدم و كلمة السر", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    Case 4
    '    '        Message_box = MessageBox.Show("El nombre de usuario y la contraseña se cambiaron correctamente", "Nombre de usuario y contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    'End Select
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    'End Sub
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
    'objects TABPAGE Security_application username and password
    Private Sub PictureBox_application_username_and_password_username_visible_Click(sender As Object, e As EventArgs) Handles PictureBox_application_username_and_password_username_visible.Click
        If Integer_application_username_and_password_username_visible_status = 1 Then
            Integer_application_username_and_password_username_visible_status = 2
            TextBox_application_username_and_password_username.UseSystemPasswordChar = True
            PictureBox_application_username_and_password_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
        Else
            Integer_application_username_and_password_username_visible_status = 1
            TextBox_application_username_and_password_username.UseSystemPasswordChar = False
            PictureBox_application_username_and_password_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
        End If
    End Sub
    Private Sub PictureBox_application_username_and_password_username_visible_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_application_username_and_password_username_visible.MouseEnter
        PictureBox_application_username_and_password_username_visible.Size = New Size(PictureBox_application_username_and_password_username_visible.Size.Width + 3, PictureBox_application_username_and_password_username_visible.Size.Height + 3)
        PictureBox_application_username_and_password_username_visible.Location = New Point(PictureBox_application_username_and_password_username_visible.Location.X - 1.5, PictureBox_application_username_and_password_username_visible.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_application_username_and_password_username_visible_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_application_username_and_password_username_visible.MouseLeave
        PictureBox_application_username_and_password_username_visible.Size = New Size(PictureBox_application_username_and_password_username_visible.Size.Width - 3, PictureBox_application_username_and_password_username_visible.Size.Height - 3)
        PictureBox_application_username_and_password_username_visible.Location = New Point(PictureBox_application_username_and_password_username_visible.Location.X + 1.5, PictureBox_application_username_and_password_username_visible.Location.Y + 1.5)
    End Sub

    Private Sub PictureBox_application_username_and_password_password_visible_Click(sender As Object, e As EventArgs) Handles PictureBox_application_username_and_password_password_visible.Click
        If Integer_application_username_and_password_password_visible_status = 1 Then
            Integer_application_username_and_password_password_visible_status = 2
            TextBox_application_username_and_password_password.UseSystemPasswordChar = True
            TextBox_application_username_and_password_confirm_password.UseSystemPasswordChar = True
            PictureBox_application_username_and_password_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
        Else
            Integer_application_username_and_password_password_visible_status = 1
            TextBox_application_username_and_password_password.UseSystemPasswordChar = False
            TextBox_application_username_and_password_confirm_password.UseSystemPasswordChar = False
            PictureBox_application_username_and_password_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
        End If
    End Sub
    Private Sub PictureBox_application_username_and_password_password_visible_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_application_username_and_password_password_visible.MouseEnter
        PictureBox_application_username_and_password_password_visible.Size = New Size(PictureBox_application_username_and_password_password_visible.Size.Width + 3, PictureBox_application_username_and_password_password_visible.Size.Height + 3)
        PictureBox_application_username_and_password_password_visible.Location = New Point(PictureBox_application_username_and_password_password_visible.Location.X - 1.5, PictureBox_application_username_and_password_password_visible.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_application_username_and_password_password_visible_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_application_username_and_password_password_visible.MouseLeave
        PictureBox_application_username_and_password_password_visible.Size = New Size(PictureBox_application_username_and_password_password_visible.Size.Width - 3, PictureBox_application_username_and_password_password_visible.Size.Height - 3)
        PictureBox_application_username_and_password_password_visible.Location = New Point(PictureBox_application_username_and_password_password_visible.Location.X + 1.5, PictureBox_application_username_and_password_password_visible.Location.Y + 1.5)
    End Sub

    Private Sub Button_application_username_and_password_done_Click(sender As Object, e As EventArgs) Handles Button_application_username_and_password_done.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If TextBox_application_username_and_password_username.Text = String.Empty Or TextBox_application_username_and_password_password.Text = String.Empty Then
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Username and password cannot be empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("نام کاربری و رمز عبور نمی توانند خالی باشند", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("لا يمكن أن يكون اسم المستخدم وكلمة المرور فارغين", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("El nombre de usuario y la contraseña no pueden estar vacíos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        Else
            Public_String_username_text = TextBox_application_username_and_password_username.Text.ToString
            Public_username_format_check()

            If Public_Integer_username_format_error = 1 Then
                Select Case My.Settings.Languages
                    Case 1
                        Message_box = MessageBox.Show("The username format is incorrect" & vbNewLine & "The correct username format includes English letters and numbers and the symbols ""_"" (underline) and ""."" (Period) and without spaces", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 2
                        Message_box = MessageBox.Show("قالب نام کاربری نادرست است" & vbNewLine & "قالب صحیح نام کاربری شامل حروف و اعداد انگلیسی و نمادهای ""_"" (زیرخط) و ""."" (نقطه) و بدون فاصله میباشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 3
                        Message_box = MessageBox.Show("نموذج اسم المستخدم غير صحيح" & vbNewLine & "يتضمن تنسيق اسم المستخدم الصحيح أحرفًا وأرقامًا إنجليزية ورموز ""_"" (تسطير) و ""."" (فترة) وبدون مسافات", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 4
                        Message_box = MessageBox.Show("El formato del nombre de usuario es incorrecto" & vbNewLine & "El formato de nombre de usuario correcto incluye letras y números en inglés y los símbolos ""_"" (subrayado) y ""."" (Punto) y sin espacios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                If TextBox_application_username_and_password_password.TextLength < 8 Then
                    Select Case My.Settings.Languages
                        Case 1
                            Message_box = MessageBox.Show("Password must be more than 8 digits", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 2
                            Message_box = MessageBox.Show("رمز عبور باید بیشتر از ۸ رقم باشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 3
                            Message_box = MessageBox.Show("يجب أن تكون كلمة المرور أكثر من 8 أرقام", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 4
                            Message_box = MessageBox.Show("La contraseña debe tener más de 8 dígitos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Select
                Else
                    If TextBox_application_username_and_password_password.Text.Replace(" ", String.Empty) = String.Empty Then
                        Select Case My.Settings.Languages
                            Case 1
                                Message_box = MessageBox.Show("Password must contain at least one letter or number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 2
                                Message_box = MessageBox.Show("رمز عبور باید حداقل حاوی یک حرف یا عدد باشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 3
                                Message_box = MessageBox.Show("يجب أن تحتوي كلمة المرور على حرف أو رقم واحد على الأقل", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 4
                                Message_box = MessageBox.Show("La contraseña debe contener al menos una letra o un número", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Select
                    Else
                        If Not TextBox_application_username_and_password_password.Text = TextBox_application_username_and_password_confirm_password.Text Then
                            Select Case My.Settings.Languages
                                Case 1
                                    Message_box = MessageBox.Show("The password does not match the password confirmation", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Case 2
                                    Message_box = MessageBox.Show("رمز عبور با تأیید رمز عبور مطابقت ندارد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Case 3
                                    Message_box = MessageBox.Show("كلمة المرور لا تتطابق مع تأكيد كلمة المرور", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Case 4
                                    Message_box = MessageBox.Show("La contraseña no coincide con la confirmación de la contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End Select
                        Else
                            Select Case My.Settings.Languages
                                Case 1
                                    Message_box = MessageBox.Show("Are you sure the information is correct?", "Hospital information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                Case 2
                                    Message_box = MessageBox.Show("آیا از صحت اطلاعات اطمینان دارید؟", "اطلاعات بیمارستان", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                Case 3
                                    Message_box = MessageBox.Show("هل أنت متأكد من صحة المعلومات؟", "معلومات المستشفى", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                Case 4
                                    Message_box = MessageBox.Show("¿Estás seguro de que la información es correcta?", "Información del hospital", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            End Select

                            If Message_box = DialogResult.Yes Then
                                Dim edit As String = "update security set name=N'" & "Admin" & "',username=N'" & TextBox_application_username_and_password_username.Text & "',password=N'" & TextBox_application_username_and_password_password.Text & "' where id= 1"
                                Dim Run As SqlCommand = New SqlCommand(edit, Public_connect_DataGridView)
                                Public_connect_DataGridView.Open()
                                Run.ExecuteNonQuery()
                                Public_connect_DataGridView.Close()

                                TextBox_application_username_and_password_username.Text = String.Empty
                                TextBox_application_username_and_password_password.Text = String.Empty
                                TextBox_application_username_and_password_confirm_password.Text = String.Empty

                                Select Case My.Settings.Languages
                                    Case 1
                                        Message_box = MessageBox.Show("Application username and password changed successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Case 2
                                        Message_box = MessageBox.Show("نام کاربری و رمز عبور برنامه با موفقیت تغییر کرد", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Case 3
                                        Message_box = MessageBox.Show("تم تغيير اسم المستخدم وكلمة المرور للتطبيق بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Case 4
                                        Message_box = MessageBox.Show("El nombre de usuario y la contraseña de la aplicación se cambiaron correctamente", "editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Select
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
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
    'objects Tabpage controls
    Private Sub TabPage_Security_Enter(sender As Object, e As EventArgs) Handles TabPage_Security.Enter
        If Public_Boolean_Enter_Administrator = False And Public_Boolean_Administrator_access = False Then
            Form_security_need_access.ShowDialog()
            If Public_Boolean_Administrator_access = True Then

            Else
                Me.Close()
                TabControl_setting.SelectedTab = TabPage_language
            End If
        End If
    End Sub
End Class