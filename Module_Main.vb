Imports System.Data.SqlClient
Imports System.Globalization

Module Module_Main
    Public Public_Integer_ID_save As Integer
    Public Public_Integer_D_N_save As Integer
    Public Public_Integer_Fingerprint_Status As Integer
    Public Public_Integer_backup_restore_status As Integer
    Public Public_Integer_username_format_error As Integer
    Public Public_Integer_entered_application As Integer
    Public Public_Integer_entered_person_id As Integer

    Public Message_box As String
    Public Public_String_fingerprint As String
    Public Public_String_Menu_Item As String
    Public Public_Determine_Form As String
    Public Public_String_username_text As String

    Public Public_Boolean_Enter_Administrator As Boolean
    Public Public_Boolean_Enter_User As Boolean
    Public Public_Boolean_Administrator_access As Boolean

    Public Public_connect_DataGridView As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & My.Application.Info.DirectoryPath & "\Main_DB.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub Public_Connect_Serial()
        If Form_main.SerialPort.IsOpen = False Then
            Form_setting.Timer_manual_connection.Enabled = True
        Else
            Form_main.SerialPort.WriteLine("close")
            Form_main.SerialPort.Close()
        End If
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
    'calendar
    Public Function PersianDate(ByVal InputDate As Date, Optional ByVal Difference As Integer = 0) As String
        Dim PC As New PersianCalendar
        Dim D, M, Y As String

        InputDate = PC.AddDays(InputDate, Difference)

        D = PC.GetDayOfMonth(InputDate)
        M = PC.GetMonth(InputDate)
        Y = PC.GetYear(InputDate)

        If D.Length < 2 Then D = "0" & D
        If M.Length < 2 Then M = "0" & M

        PersianDate = PC.GetYear(InputDate) & "/" & M & "/" & D
    End Function
    Public Function ArabicDate(ByVal InputDate As Date, Optional ByVal Difference As Integer = 0) As String
        Dim PC As New HijriCalendar
        Dim D, M, Y As String

        InputDate = PC.AddDays(InputDate, Difference)

        D = PC.GetDayOfMonth(InputDate)
        M = PC.GetMonth(InputDate)
        Y = PC.GetYear(InputDate)

        If D.Length < 2 Then D = "0" & D
        If M.Length < 2 Then M = "0" & M

        ArabicDate = PC.GetYear(InputDate) & "/" & M & "/" & D
    End Function
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
    'Fingerprint
    Public Sub Fingerprint()
        Form_receive_fingerprint.ProgressBar_fingerprint.Value = 100
        Form_receive_fingerprint.Label_percent.Text = "100%"

        Public_Integer_Fingerprint_Status = 1


        Select Case Public_String_Menu_Item
            Case "add"
                Form_add_patient.PictureBox_fingerprint.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.fingerprint_1_
                Select Case My.Settings.Languages
                    Case 1
                        Form_add_patient.Label_fingerprint_status.Text = "Fingerprint successfully registered"
                        Message_box = MessageBox.Show("Fingerprint successfully registered", "Fingerprint", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 2
                        Form_add_patient.Label_fingerprint_status.Text = "اثر انگشت با موفقیت ثبت شد"
                        Message_box = MessageBox.Show("اثر انگشت با موفقیت ثبت شد", "اثر انگشت", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 3
                        Form_add_patient.Label_fingerprint_status.Text = "تم تسجيل بصمة الإصبع بنجاح"
                        Message_box = MessageBox.Show("تم تسجيل بصمة الإصبع بنجاح", "بصمة الاصبع", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 4
                        Form_add_patient.Label_fingerprint_status.Text = "Huella digital registrada correctamente"
                        Message_box = MessageBox.Show("Huella digital registrada correctamente", "Huella dactilar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Select
            Case "edit"
                Form_edit_patient.PictureBox_fingerprint.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.fingerprint_1_
                Select Case My.Settings.Languages
                    Case 1
                        Form_edit_patient.Label_fingerprint_status.Text = "Fingerprint successfully changed"
                        Message_box = MessageBox.Show("Fingerprint successfully changed", "Fingerprint", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 2
                        Form_edit_patient.Label_fingerprint_status.Text = "اثر انگشت با موفقیت تغییر یافت"
                        Message_box = MessageBox.Show("اثر انگشت با موفقیت تغییر یافت", "اثر انگشت", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 3
                        Form_edit_patient.Label_fingerprint_status.Text = "تم تغيير بصمة الإصبع بنجاح"
                        Message_box = MessageBox.Show("تم تغيير بصمة الإصبع بنجاح", "بصمة الاصبع", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 4
                        Form_edit_patient.Label_fingerprint_status.Text = "Huella digital modificada correctamente"
                        Message_box = MessageBox.Show("Huella digital modificada correctamente", "Huella dactilar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Select
        End Select

        Form_receive_fingerprint.Close()
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
    'Username format check
    Public Sub Public_username_format_check()
        Public_Integer_username_format_error = 0

        Public_String_username_text = Public_String_username_text.Replace(".", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("_", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("0", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("1", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("2", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("3", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("4", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("5", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("6", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("7", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("8", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("9", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("a", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("b", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("c", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("d", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("e", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("f", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("g", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("h", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("i", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("j", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("k", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("l", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("m", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("n", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("o", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("p", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("q", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("r", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("s", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("t", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("u", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("v", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("w", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("x", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("y", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("z", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("A", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("B", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("C", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("D", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("E", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("F", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("G", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("H", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("I", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("G", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("J", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("K", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("L", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("M", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("N", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("O", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("P", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("Q", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("R", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("S", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("T", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("U", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("V", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("W", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("X", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("Y", String.Empty)
        Public_String_username_text = Public_String_username_text.Replace("Z", String.Empty)

        If Public_String_username_text.Length > 0 Then
            Public_Integer_username_format_error = 1
        End If
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
    'Gridcolor
    Public Sub Public_GridColor_Patients(ByVal GridControl As DataGridView)
        For i = 0 To GridControl.RowCount - 1
            Dim a As Integer = i Mod 2
            If (i Mod 2) = 0 Then
                For j = 0 To GridControl.ColumnCount - 1
                    GridControl.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.FromArgb(180, 250, 250)
                    GridControl.Rows.Item(i).Cells.Item(j).Style.ForeColor = Color.Black
                Next
            Else
                For j = 0 To GridControl.ColumnCount - 1
                    GridControl.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightCyan
                    GridControl.Rows.Item(i).Cells.Item(j).Style.ForeColor = Color.Black
                Next
            End If
            If GridControl.Rows(i).Cells(11).Value = 0 Then
                For b = 0 To GridControl.Rows(i).Cells.Count - 1
                    GridControl.Rows(i).Cells(b).Style.BackColor = Color.HotPink
                Next
            End If
        Next
    End Sub
    Sub Public_GridColor_Dialysis(ByVal GridControl As DataGridView)
        For i = 0 To GridControl.RowCount - 1
            Dim a As Integer = i Mod 2
            If (i Mod 2) = 0 Then
                For j = 0 To GridControl.ColumnCount - 1
                    GridControl.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.FromArgb(180, 250, 250)
                    GridControl.Rows.Item(i).Cells.Item(3).Style.BackColor = Color.FromArgb(255, 153, 0)
                    GridControl.Rows.Item(i).Cells.Item(7).Style.BackColor = Color.FromArgb(255, 153, 0)
                    GridControl.Rows.Item(i).Cells.Item(4).Style.BackColor = Color.FromArgb(255, 102, 153)
                    GridControl.Rows.Item(i).Cells.Item(8).Style.BackColor = Color.FromArgb(255, 102, 153)
                Next
            Else
                For j = 0 To GridControl.ColumnCount - 1
                    GridControl.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightCyan
                    GridControl.Rows.Item(i).Cells.Item(3).Style.BackColor = Color.FromArgb(255, 204, 0)
                    GridControl.Rows.Item(i).Cells.Item(7).Style.BackColor = Color.FromArgb(255, 204, 0)
                    GridControl.Rows.Item(i).Cells.Item(4).Style.BackColor = Color.FromArgb(255, 179, 204)
                    GridControl.Rows.Item(i).Cells.Item(8).Style.BackColor = Color.FromArgb(255, 179, 204)
                Next
            End If
        Next
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
    'Change Layout
    Sub Public_Left_Layout()
        If My.Settings.First_start = 0 Then
            Form_first_start_3.RightToLeft = Windows.Forms.RightToLeft.No
            Form_first_start_3.RightToLeftLayout = False
        ElseIf Public_Integer_entered_application = 0 Then
            Form_security_enter_app.RightToLeft = Windows.Forms.RightToLeft.No
            Form_security_enter_app.RightToLeftLayout = False
        Else
            Public_Left_Layout_TabPage(Form_setting.TabPage_Security_Add)
            Public_Left_Layout_TabPage(Form_setting.TabPage_Security_Delete)
            'Public_Left_Layout_TabPage(Form_setting.TabPage_Security_Edit)
            Public_Left_Layout_TabPage(Form_setting.TabPage_application_username_and_password)

            Form_setting.RightToLeft = Windows.Forms.RightToLeft.No
            Form_setting.RightToLeftLayout = False
            Form_setting.TabControl_setting.RightToLeft = Windows.Forms.RightToLeft.No
            Form_setting.TabControl_setting.RightToLeftLayout = False
            Form_setting.TabControl_Security.RightToLeft = Windows.Forms.RightToLeft.No
            Form_setting.TabControl_Security.RightToLeftLayout = False
            Form_main.RightToLeft = Windows.Forms.RightToLeft.No
            Form_main.RightToLeftLayout = False
            Form_about_us.RightToLeft = Windows.Forms.RightToLeft.No
            Form_about_us.RightToLeftLayout = False
            Form_add_dialysis.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_dialysis.RightToLeftLayout = False
            Form_add_patient.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_patient.RightToLeftLayout = False
            Form_backup_proccess.RightToLeft = Windows.Forms.RightToLeft.No
            Form_backup_proccess.RightToLeftLayout = False
            Form_delete_dialysis.RightToLeft = Windows.Forms.RightToLeft.No
            Form_delete_dialysis.RightToLeftLayout = False
            Form_delete_patient.RightToLeft = Windows.Forms.RightToLeft.No
            Form_delete_patient.RightToLeftLayout = False
            Form_dialysis_chart.RightToLeft = Windows.Forms.RightToLeft.No
            Form_dialysis_chart.RightToLeftLayout = False
            Form_edit_dialysis.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_dialysis.RightToLeftLayout = False
            Form_edit_patient.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_patient.RightToLeftLayout = False
            Form_find_dialysis_number.RightToLeft = Windows.Forms.RightToLeft.No
            Form_find_dialysis_number.RightToLeftLayout = False
            Form_find_ID.RightToLeft = Windows.Forms.RightToLeft.No
            Form_find_ID.RightToLeftLayout = False
            Form_receive_fingerprint.RightToLeft = Windows.Forms.RightToLeft.No
            Form_receive_fingerprint.RightToLeftLayout = False
            Form_security_need_access.RightToLeft = Windows.Forms.RightToLeft.No
            Form_security_need_access.RightToLeftLayout = False
            Form_show_patient_database.RightToLeft = Windows.Forms.RightToLeft.No
            Form_show_patient_database.RightToLeftLayout = False
        End If
    End Sub
    Sub Public_Right_Layout()
        If My.Settings.First_start = 0 Then
            Form_first_start_3.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_first_start_3.RightToLeftLayout = True
        ElseIf Public_Integer_entered_application = 0 Then
            Form_security_enter_app.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_security_enter_app.RightToLeftLayout = True
        Else
            Public_Right_Layout_TabPage(Form_setting.TabPage_Security_Add)
            Public_Right_Layout_TabPage(Form_setting.TabPage_Security_Delete)
            'Public_Right_Layout_TabPage(Form_setting.TabPage_Security_Edit)
            Public_Right_Layout_TabPage(Form_setting.TabPage_application_username_and_password)

            Form_setting.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_setting.RightToLeftLayout = True
            Form_setting.TabControl_setting.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_setting.TabControl_setting.RightToLeftLayout = True
            Form_setting.TabControl_Security.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_setting.TabControl_Security.RightToLeftLayout = True
            Form_main.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_main.RightToLeftLayout = True
            Form_about_us.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_about_us.RightToLeftLayout = True
            Form_add_dialysis.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_add_dialysis.RightToLeftLayout = True
            Form_add_patient.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_add_patient.RightToLeftLayout = True
            Form_backup_proccess.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_backup_proccess.RightToLeftLayout = True
            Form_delete_dialysis.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_delete_dialysis.RightToLeftLayout = True
            Form_delete_patient.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_delete_patient.RightToLeftLayout = True
            Form_dialysis_chart.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_dialysis_chart.RightToLeftLayout = True
            Form_edit_dialysis.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_edit_dialysis.RightToLeftLayout = True
            Form_edit_patient.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_edit_patient.RightToLeftLayout = True
            Form_find_dialysis_number.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_find_dialysis_number.RightToLeftLayout = True
            Form_find_ID.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_find_ID.RightToLeftLayout = True
            Form_receive_fingerprint.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_receive_fingerprint.RightToLeftLayout = True
            Form_security_need_access.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_security_need_access.RightToLeftLayout = True
            Form_show_patient_database.RightToLeft = Windows.Forms.RightToLeft.Yes
            Form_show_patient_database.RightToLeftLayout = True
        End If
    End Sub

    Public Sub Public_Right_Layout_TabPage(ByVal TabPage As TabPage)
        If Form_setting.RightToLeftLayout = False Then
            For Each PictureBox As PictureBox In TabPage.Controls.OfType(Of PictureBox)()
                If TypeOf PictureBox Is PictureBox Then
                    PictureBox.Location = New Point(TabPage.Width - PictureBox.Location.X - PictureBox.Width, PictureBox.Location.Y)
                End If
            Next
            For Each TextBox As TextBox In TabPage.Controls.OfType(Of TextBox)()
                If TypeOf TextBox Is TextBox Then
                    TextBox.Location = New Point(TabPage.Width - TextBox.Location.X - TextBox.Width, TextBox.Location.Y)
                End If
            Next
            For Each Button As Button In TabPage.Controls.OfType(Of Button)()
                If TypeOf Button Is Button Then
                    Button.Location = New Point(TabPage.Width - Button.Location.X - Button.Width, Button.Location.Y)
                End If
            Next
            For Each Label As Label In TabPage.Controls.OfType(Of Label)()
                If TypeOf Label Is Label Then
                    Label.Location = New Point(TabPage.Width - Label.Location.X - Label.Width, Label.Location.Y)
                End If
            Next
        End If
    End Sub
    Public Sub Public_Left_Layout_TabPage(ByVal TabPage As TabPage)
        If Form_setting.RightToLeftLayout = True Then
            For Each PictureBox As PictureBox In TabPage.Controls.OfType(Of PictureBox)()
                If TypeOf PictureBox Is PictureBox Then
                    PictureBox.Location = New Point(TabPage.Width - (PictureBox.Location.X + PictureBox.Width), PictureBox.Location.Y)
                End If
            Next
            For Each TextBox As TextBox In TabPage.Controls.OfType(Of TextBox)()
                If TypeOf TextBox Is TextBox Then
                    TextBox.Location = New Point(TabPage.Width - (TextBox.Location.X + TextBox.Width), TextBox.Location.Y)
                End If
            Next
            For Each Button As Button In TabPage.Controls.OfType(Of Button)()
                If TypeOf Button Is Button Then
                    Button.Location = New Point(TabPage.Width - (Button.Location.X + Button.Width), Button.Location.Y)
                End If
            Next
            For Each Label As Label In TabPage.Controls.OfType(Of Label)()
                If TypeOf Label Is Label Then
                    Label.Location = New Point(TabPage.Width - (Label.Location.X + Label.Width), Label.Location.Y)
                End If
            Next
        End If
    End Sub

    Sub Public_Determine_Layout()
        Select Case My.Settings.Languages
            Case 1
                Public_Left_Layout()
            Case 2
                Public_Right_Layout()
            Case 3
                Public_Right_Layout()
            Case 4
                Public_Left_Layout()
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
    'Languages
    Public Public_Microsoft_Tai_Le_Font_8_Bold As New Font("Microsoft Tai Le", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Public Public_Microsoft_Tai_Le_Font_12_Bold As New Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Public Public_Microsoft_Tai_Le_Font_12_Regular As New Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Public Public_Microsoft_Tai_Le_Font_15_Bold As New Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Public Public_Microsoft_Tai_Le_Font_20_Bold As New Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

    Public Public_B_Nazanin_Font_9_Bold As New Font("B Nazanin", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Public_B_Nazanin_Font_12_Bold As New Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Public_B_Nazanin_Font_14_Bold As New Font("B Nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Public_B_Nazanin_Font_20_Bold As New Font("B Nazanin", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))

    Sub Public_English_Language()
        If Public_Determine_Form = "Form_about_us" Then
            Form_about_us.Text = "About us"

            Form_about_us.Label_Product_Name.Text = "Product Name: " & My.Application.Info.ProductName.ToString
            Form_about_us.Label_Version.Text = "Version: " & My.Application.Info.Version.ToString
            Form_about_us.Label_Copyright.Text = "Copyright: " & My.Application.Info.Copyright.ToString
            Form_about_us.Label_Company_Name.Text = "Products Alvand Darou Fam Company"
            Form_about_us.TextBox_Description.Text = "Program description:" & vbNewLine & vbNewLine & "Intelligently measure the weight of dialysis clients when entering the dialysis room"
            Form_about_us.LinkLabel_1.Text = "Alvand Darou Fam"

            Form_about_us.Label_Product_Name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.Label_Version.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.Label_Copyright.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.Label_Company_Name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.TextBox_Description.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.LinkLabel_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_add_dialysis" Then
            Form_add_dialysis.Text = "Add Dialysis"

            Form_add_dialysis.Button_add.Text = "Add"
            Form_add_dialysis.Button_cancell.Text = "Cancel"

            Form_add_dialysis.Label_time_1.Text = "Entry time"
            Form_add_dialysis.Label_time_2.Text = "leaving time"
            Form_add_dialysis.Label_date_1.Text = "Entry date"
            Form_add_dialysis.Label_date_2.Text = "leaving date"
            Form_add_dialysis.Label_weight_1.Text = "Initial weight"
            Form_add_dialysis.Label_weight_2.Text = "Secondary weight"

            Form_add_dialysis.Label_time_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_time_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_date_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_date_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_weight_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_weight_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_dialysis.Button_add.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_dialysis.NumericUpDown_weight_2.RightToLeft = Windows.Forms.RightToLeft.Yes
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_add_patient" Then
            Form_add_patient.Text = "Add Patient"

            Form_add_patient.Button_add.Text = "Add"
            Form_add_patient.Button_cancell.Text = "Cancel"

            Form_add_patient.Label_name.Text = "Name:"
            Form_add_patient.Label_lastname.Text = "Lastname:"
            Form_add_patient.Label_father_name.Text = "Father's name:"
            Form_add_patient.Label_birth_date.Text = "Date of birth:"
            Form_add_patient.Label_id_code.Text = "ID Code:"
            Form_add_patient.Label_mbile_number.Text = "Phone number:"
            Form_add_patient.Label_home_number.Text = "Telephone number:"
            Form_add_patient.Label_gender.Text = "Gender:"
            Form_add_patient.RadioButton_male.Text = "Male"
            Form_add_patient.RadioButton_female.Text = "Female"
            Form_add_patient.Label_hieght.Text = "Height:"
            Form_add_patient.Label_enroll_date.Text = "Enroll date:"
            Form_add_patient.Label_dr_name.Text = "Doctor's name:"
            Form_add_patient.Label_patient_image.Text = "Picture"
            Form_add_patient.Label_blood_type.Text = "Blood type:"
            Form_add_patient.Label_shift.Text = "Shift:"
            Form_add_patient.Label_fingerprint_status.Text = "Fingerprint is not registered"

            Form_add_patient.ComboBox_shift.Items.Clear()
            Form_add_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_add_patient.ComboBox_shift.Items.Add("1 Even(Morning)")
            Form_add_patient.ComboBox_shift.Items.Add("2 Even(Noon)")
            Form_add_patient.ComboBox_shift.Items.Add("3 Even(Night)")
            Form_add_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_add_patient.ComboBox_shift.Items.Add("4 Odd(Morning)")
            Form_add_patient.ComboBox_shift.Items.Add("5 Odd(Noon)")
            Form_add_patient.ComboBox_shift.Items.Add("6 Odd(Night)")

            Form_add_patient.Label_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_lastname.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_father_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_birth_date.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_id_code.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_mbile_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_home_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_gender.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_hieght.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_enroll_date.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_dr_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_patient_image.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_shift.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_fingerprint_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_patient.RadioButton_male.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.RadioButton_female.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_patient.Button_add.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_patient.ComboBox_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.ComboBox_shift.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_backup_proccess" Then
            Form_backup_proccess.Label_explain.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            If Public_Integer_backup_restore_status = 1 Then
                Form_backup_proccess.Label_explain.Text = "Backing up..."
            Else
                Form_backup_proccess.Label_explain.Text = "Restoring..."
            End If
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_delete_dialysis" Then
            Form_delete_dialysis.Text = "Delete Dialysis"

            Form_delete_dialysis.Button_delete.Text = "Delete"
            Form_delete_dialysis.Button_cancell.Text = "Cancel"

            Form_delete_dialysis.Label_time_1.Text = "Entry time"
            Form_delete_dialysis.Label_time_2.Text = "leaving time"
            Form_delete_dialysis.Label_date_1.Text = "Entry date"
            Form_delete_dialysis.Label_date_2.Text = "leaving date"
            Form_delete_dialysis.Label_weight_1.Text = "Initial weight"
            Form_delete_dialysis.Label_weight_2.Text = "Secondary weight"

            Form_delete_dialysis.Label_time_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_time_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_date_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_date_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_weight_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_weight_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_delete_dialysis.Button_delete.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_delete_patient" Then
            Form_delete_patient.Text = "Delete Patient"

            Form_delete_patient.Button_delete.Text = "Delete"
            Form_delete_patient.Button_cancell.Text = "Cancel"

            Form_delete_patient.Label_name_1.Text = "Name:"
            Form_delete_patient.Label_father_name_1.Text = "Father's name:"
            Form_delete_patient.Label_id_code_1.Text = "ID Code:"
            Form_delete_patient.Label_birth_date_1.Text = "Date of birth:"

            Form_delete_patient.Button_delete.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_delete_patient.Label_name_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_father_name_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_id_code_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_birth_date_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_delete_patient.Label_name_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_father_name_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_id_code_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_birth_date_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_dialysis_chart" Then
            Form_dialysis_chart.Text = "Chart"

            Form_dialysis_chart.Label_one_week.Text = "ONE WEEK"
            Form_dialysis_chart.Label_two_week.Text = "TWO WEEK"
            Form_dialysis_chart.Label_month.Text = "MONTH"
            Form_dialysis_chart.Label_year.Text = "YEAR"
            Form_dialysis_chart.Label_all.Text = "ALL"
            Form_dialysis_chart.Label_customize.Text = "CUSTOMIZE"

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_one_week, "Show dialysis charts based on information from the last one weeks")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_two_week, "Show dialysis charts based on information from the last two weeks")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_month, "Show dialysis charts based on information from the last month")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_year, "Show dialysis charts based on information from the last year")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_all, "Show dialysis charts based on total dialysis information")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_customize, "Show dialysis charts based on selected days information")

            Form_dialysis_chart.Label_one_week.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_two_week.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_month.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_year.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_all.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_customize.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_seperator_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_3.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_4.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_5.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_customize_explain_1.Text = "Dialysis charts based on information from the last"
            Form_dialysis_chart.Label_customize_explain_2.Text = "days"

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_reload_chart, "Calculate information")

            Form_dialysis_chart.Label_customize_explain_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_customize_explain_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_chart_filter_weight_1.Text = "Initial weight"
            Form_dialysis_chart.Label_chart_filter_weight_2.Text = "Secondary weight"
            Form_dialysis_chart.Label_chart_filter_bmi_1.Text = "Initial BMI"
            Form_dialysis_chart.Label_chart_filter_bmi_2.Text = "Secondary BMI"
            Form_dialysis_chart.Label_chart_filter_weight_all.Text = "Weight"
            Form_dialysis_chart.Label_chart_filter_bmi_all.Text = "BMI"
            Form_dialysis_chart.Label_chart_filter_all.Text = "Weight and BMI"

            Form_dialysis_chart.Label_chart_filter_weight_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_weight_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_weight_all.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_all.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_all.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_seperator_6.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_7.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_8.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_9.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_10.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_11.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Chart.Series(0).LegendText = "Initial weight"
            Form_dialysis_chart.Chart.Series(1).LegendText = "Secondary weight"
            Form_dialysis_chart.Chart.Series(2).LegendText = "Initial BMI"
            Form_dialysis_chart.Chart.Series(3).LegendText = "Secondary BMI"

            Form_dialysis_chart.Chart.Series(0).LegendToolTip = "Patient weight before dialysis"
            Form_dialysis_chart.Chart.Series(1).LegendToolTip = "Patient weight after dialysis"
            Form_dialysis_chart.Chart.Series(2).LegendToolTip = "Patient BMI before dialysis"
            Form_dialysis_chart.Chart.Series(3).LegendToolTip = "Patient BMI after dialysis"

            Form_dialysis_chart.Chart.Legends(0).Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_nothing_to_show.Text = "There is nothing to show"
            Form_dialysis_chart.Label_nothing_to_show.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_chart_labels_visible, "Hide chart numbers")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_default_setting, "Restore the chart to the default setting")
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_edit_dialysis" Then
            Form_edit_dialysis.Text = "Edit Dialysis"

            Form_edit_dialysis.Button_edit.Text = "Edit"
            Form_edit_dialysis.Button_cancell.Text = "Cancel"

            Form_edit_dialysis.Label_time_1.Text = "Entry time"
            Form_edit_dialysis.Label_time_2.Text = "leaving time"
            Form_edit_dialysis.Label_date_1.Text = "Entry date"
            Form_edit_dialysis.Label_date_2.Text = "leaving date"
            Form_edit_dialysis.Label_weight_1.Text = "Initial weight"
            Form_edit_dialysis.Label_weight_2.Text = "Secondary weight"

            Form_edit_dialysis.Label_time_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_time_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_date_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_date_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_weight_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_weight_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_dialysis.Button_edit.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_dialysis.NumericUpDown_weight_2.RightToLeft = Windows.Forms.RightToLeft.Yes
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_edit_patient" Then
            Form_edit_patient.Text = "Edit Patient"

            Form_edit_patient.Button_edit.Text = "Edit"
            Form_edit_patient.Button_cancell.Text = "Cancel"

            Form_edit_patient.Label_name.Text = "Name:"
            Form_edit_patient.Label_lastname.Text = "Lastname:"
            Form_edit_patient.Label_father_name.Text = "Father's name:"
            Form_edit_patient.Label_birth_date.Text = "Date of birth:"
            Form_edit_patient.Label_id_code.Text = "ID Code:"
            Form_edit_patient.Label_mbile_number.Text = "Phone number:"
            Form_edit_patient.Label_home_number.Text = "Telephone number:"
            Form_edit_patient.Label_gender.Text = "Gender:"
            Form_edit_patient.RadioButton_male.Text = "Male"
            Form_edit_patient.RadioButton_female.Text = "Female"
            Form_edit_patient.Label_hieght.Text = "Height:"
            Form_edit_patient.Label_enroll_date.Text = "Enroll date:"
            Form_edit_patient.Label_dr_name.Text = "Doctor's name:"
            Form_edit_patient.Label_patient_image.Text = "Picture"
            Form_edit_patient.Label_blood_type.Text = "Blood type:"
            Form_edit_patient.Label_shift.Text = "Shift:"
            If Public_Integer_Fingerprint_Status = 0 Then
                Form_edit_patient.Label_fingerprint_status.Text = "Fingerprint is not registered"
            Else
                Form_edit_patient.Label_fingerprint_status.Text = "Click to change Fingerprint"
            End If

            Form_edit_patient.ComboBox_shift.Items.Clear()
            Form_edit_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_edit_patient.ComboBox_shift.Items.Add("1 Even(Morning)")
            Form_edit_patient.ComboBox_shift.Items.Add("2 Even(Noon)")
            Form_edit_patient.ComboBox_shift.Items.Add("3 Even(Night)")
            Form_edit_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_edit_patient.ComboBox_shift.Items.Add("4 Odd(Morning)")
            Form_edit_patient.ComboBox_shift.Items.Add("5 Odd(Noon)")
            Form_edit_patient.ComboBox_shift.Items.Add("6 Odd(Night)")

            Form_edit_patient.Label_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_lastname.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_father_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_birth_date.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_id_code.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_mbile_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_home_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_gender.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_hieght.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_enroll_date.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_dr_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_patient_image.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_shift.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_fingerprint_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_patient.RadioButton_male.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.RadioButton_female.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_patient.Button_edit.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_patient.ComboBox_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.ComboBox_shift.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_find_dialysis_number" Then
            Form_find_dialysis_number.Text = "Search Dialysis Number"
            Form_find_dialysis_number.Label_dialysis_number.Text = "Please enter Dialysis Number"
            Form_find_dialysis_number.Button_next.Text = "Next"
            Form_find_dialysis_number.Label_dialysis_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_find_dialysis_number.Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_find_ID" Then
            Form_find_ID.Text = "Search ID Code"
            Form_find_ID.Label_id_code.Text = "Please enter ID Code"
            Form_find_ID.Button_next.Text = "Next"
            Form_find_ID.Label_id_code.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_find_ID.Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_first_start_2" Then
            Form_first_start_2.Text = "Initial Start"

            Form_first_start_2.Label_title.Text = "Please fill in the required fields"
            Form_first_start_2.Label_hospital_name.Text = "Hospital name"
            Form_first_start_2.Label_hospital_address.Text = "Hospital address"
            Form_first_start_2.Label_hospital_tel.Text = "Hospital Tel"
            Form_first_start_2.Label_dialysis_time.Text = "Dialysis time/h"
            Form_first_start_2.Button_next.Text = "next"

            Form_first_start_2.Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_first_start_2.Label_hospital_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_2.Label_hospital_address.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_2.Label_hospital_tel.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_2.Label_dialysis_time.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_2.Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_first_start_3" Then
            Form_first_start_3.Text = "Initial Start"

            Form_first_start_3.Label_title.Text = "Please select a username and password for the application"
            Form_first_start_3.Label_username.Text = "Create Username"
            Form_first_start_3.Label_password.Text = "Create Password"
            Form_first_start_3.Label_confirm_password.Text = "Confirm password"

            Form_first_start_3.Button_next.Text = "Done"

            Form_first_start_3.Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_first_start_3.Label_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_3.Label_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_3.Label_confirm_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_first_start_3.Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_main" Then
            Form_main.Main_DataGridView.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_main.Main_DataGridView.ColumnHeadersDefaultCellStyle.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_main.ToolStrip_menu.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_main.ToolStripButton_add_patients.ToolTipText = "Add patient"
            Form_main.ToolStripButton_delete_patients.ToolTipText = "Delete patient"
            Form_main.ToolStripButton_edit_patients.ToolTipText = "Edit patient"
            Form_main.ToolStripButton_backup.ToolTipText = "Backup"
            Form_main.ToolStripButton_recovery.ToolTipText = "Recovery"
            Form_main.ToolStripButton_setting.ToolTipText = "Setting"
            Form_main.ToolStripButton_about_us.ToolTipText = "About us"
            Form_main.ToolStripButton_refresh.ToolTipText = "Refresh"
            Form_main.ToolStripTextBox_search.Text = "Search"

            Form_main.Main_DataGridView.Columns(1).HeaderText = "Picture"
            Form_main.Main_DataGridView.Columns(1).ToolTipText = "Patient Picture"
            Form_main.Main_DataGridView.Columns(2).HeaderText = "Name"
            Form_main.Main_DataGridView.Columns(2).ToolTipText = "Patient name"
            Form_main.Main_DataGridView.Columns(3).HeaderText = "Lastname"
            Form_main.Main_DataGridView.Columns(3).ToolTipText = "Patient Lastname"
            Form_main.Main_DataGridView.Columns(4).HeaderText = "Father's name"
            Form_main.Main_DataGridView.Columns(4).ToolTipText = "Patient Father's name"
            Form_main.Main_DataGridView.Columns(5).HeaderText = "Date of birth"
            Form_main.Main_DataGridView.Columns(5).ToolTipText = "Patient Date of birth"
            Form_main.Main_DataGridView.Columns(6).HeaderText = "ID Code"
            Form_main.Main_DataGridView.Columns(6).ToolTipText = "Patient ID Code"
            Form_main.Main_DataGridView.Columns(7).HeaderText = "Phone number"
            Form_main.Main_DataGridView.Columns(7).ToolTipText = "Patient Phone number"
            Form_main.Main_DataGridView.Columns(8).HeaderText = "Telephone number"
            Form_main.Main_DataGridView.Columns(8).ToolTipText = "Patient Telephone number"
            Form_main.Main_DataGridView.Columns(9).HeaderText = "Gender"
            Form_main.Main_DataGridView.Columns(9).ToolTipText = "Patient Gender"
            Form_main.Main_DataGridView.Columns(10).HeaderText = "Height"
            Form_main.Main_DataGridView.Columns(10).ToolTipText = "Patient height in centimeters"
            Form_main.Main_DataGridView.Columns(12).HeaderText = "Enroll date"
            Form_main.Main_DataGridView.Columns(12).ToolTipText = "Patient enroll date"
            Form_main.Main_DataGridView.Columns(13).HeaderText = "Doctor's Name"
            Form_main.Main_DataGridView.Columns(13).ToolTipText = "Patient Doctor's Name"
            Form_main.Main_DataGridView.Columns(14).HeaderText = "Blood type"
            Form_main.Main_DataGridView.Columns(14).ToolTipText = "Patient blood type"
            Form_main.Main_DataGridView.RightToLeft = Windows.Forms.RightToLeft.No

            Form_main.ToolStrip_menu.RightToLeft = Windows.Forms.RightToLeft.No

            Form_main.StatusStrip_label_connection_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_main.StatusStrip_label_seperator.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_main.StatusStrip_label_entered_person_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            If Public_Integer_entered_person_id = 1 Then Form_main.StatusStrip_label_entered_person_name.Text = "Administration"

            Public_GridColor_Patients(Form_main.Main_DataGridView)
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_receive_fingerprint" Then
            Form_receive_fingerprint.Text = "Fingerprint"
            If Public_Integer_Fingerprint_Status = 1 Then
                Form_receive_fingerprint.Label_explain.Text = "Fingerprint has already been registered" & vbNewLine & "Click on the icon below to change"
                Form_receive_fingerprint.Label_explain.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Else
                Form_receive_fingerprint.Label_explain.Text = "The device is ready to receive fingerprints" & vbNewLine & "Please place your finger completely on the device"
                Form_receive_fingerprint.Label_explain.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                Form_add_patient.Label_fingerprint_status.Text = "Fingerprint is not registered"
                Form_edit_patient.Label_fingerprint_status.Text = "Fingerprint is not registered"
            End If
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_security_enter_app" Then
            Form_security_enter_app.Text = "Enter"

            Form_security_enter_app.Label_title.Text = "Please enter your username and password"
            Form_security_enter_app.Label_username.Text = "Username"
            Form_security_enter_app.Label_password.Text = "Password"
            Form_security_enter_app.Button_enter.Text = "Enter"

            Form_security_enter_app.Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_security_enter_app.Label_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_security_enter_app.Label_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_security_enter_app.Button_enter.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_security_need_access" Then
            Form_security_need_access.Text = "Enter"

            Form_security_need_access.Label_title.Text = "Please enter your username and password(Administration)"
            Form_security_need_access.Label_username.Text = "Username"
            Form_security_need_access.Label_password.Text = "Password"
            Form_security_need_access.Button_enter.Text = "Enter"

            Form_security_need_access.Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_security_need_access.Label_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_security_need_access.Label_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_security_need_access.Button_enter.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_setting" Then
            Form_setting.Text = "Setting"

            Form_setting.TabPage_language.Text = "Language"
            Form_setting.TabPage_hospital.Text = "Hospital"
            Form_setting.TabPage_devices.Text = "Devices"
            Form_setting.TabPage_scale_setting.Text = "Scale Setting"
            Form_setting.TabPage_Security.Text = "Security"
            Form_setting.TabPage_Security_Add.Text = "Add username and password"
            Form_setting.TabPage_Security_Delete.Text = "Delete username and password"
            'Form_setting.TabPage_Security_Edit.Text = "Edit username and password"
            Form_setting.TabPage_application_username_and_password.Text = "Application Username And Password"

            Form_setting.Label_title_language.Text = "Please select the language"
            Form_setting.Button_change_language.Text = "Change language"
            Form_setting.Label_title_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Button_change_language.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_title_hospital.Text = "Please fill in the required fields"
            Form_setting.Label_hospital_name.Text = "Hospital name"
            Form_setting.Label_hospital_address.Text = "Hospital address"
            Form_setting.Label_hospital_tel.Text = "Hospital Tel"
            Form_setting.Label_dialysis_time.Text = "Dialysis time/h"
            Form_setting.Button_change_setting_table.Text = "Change information"

            Form_setting.Label_title_hospital.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_hospital_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_hospital_address.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_hospital_tel.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_dialysis_time.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_change_setting_table.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_hospital_name.TextAlign = ContentAlignment.MiddleLeft
            Form_setting.Label_hospital_tel.TextAlign = ContentAlignment.MiddleLeft
            Form_setting.Label_hospital_address.TextAlign = ContentAlignment.MiddleRight
            Form_setting.Label_dialysis_time.TextAlign = ContentAlignment.MiddleRight

            Form_setting.Label_title_devices.Text = "Status of computer connection to fingerprint device"
            Form_setting.Label_title_devices.Font = Public_Microsoft_Tai_Le_Font_12_Bold

            Form_setting.Label_auto_connection.Text = "Auto connection"
            Form_setting.Label_auto_connection.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_trying_to_connect.Text = "Trying to connect"
            Form_setting.Label_trying_to_connect.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_title_calibrate.Text = "Calibrate the scales"
            Form_setting.Label_calibrate_explain.Text = "Please enter weight (in grams)"
            Form_setting.Label_calibrate_help.Text = "To calibrate, first empty the scale and select the calibration option at the top" & vbNewLine & "Then place a weight of at least 50 kg on the scales (find out the exact weight of the weight)" & vbNewLine & "Finally, select the send option and calibrate"
            Form_setting.Button_calibrate.Text = "Calibrate"

            Form_setting.Label_title_calibrate.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_calibrate_explain.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_calibrate_help.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_calibrate.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_title_offset.Text = "Reset the scales"
            Form_setting.Label_offset_help.Text = "By selecting the above option, the weight specified by the scales is considered as the base weight (the weight of the scales is considered zero)"
            Form_setting.Button_offset.Text = "Reset"

            Form_setting.Label_title_offset.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_offset_help.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_offset.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_Security_Add_title.Text = "Please select a new username and password"
            Form_setting.Label_Security_Add_name.Text = "Name"
            Form_setting.Label_Security_Add_username.Text = "Create Username"
            Form_setting.Label_Security_Add_password.Text = "Create Password"
            Form_setting.Label_Security_Add_confirm_password.Text = "Confirm password"
            Form_setting.Button_Security_Add_done.Text = "Done"

            Form_setting.Label_Security_Add_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_Security_Add_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Add_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Add_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Add_confirm_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_Security_Add_done.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_Security_Delete_title.Text = "Please enter your username and password"
            Form_setting.Label_Security_Delete_name.Text = "Name"
            Form_setting.Label_Security_Delete_username.Text = "Username"
            Form_setting.Label_Security_Delete_password.Text = "Password"
            Form_setting.Button_Security_Delete_done.Text = "Delete"

            Form_setting.Label_Security_Delete_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_Security_Delete_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Delete_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Delete_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_Security_Delete_done.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            'Form_setting.Label_Security_Edit_title.Text = "Please enter your information for editing"
            'Form_setting.Label_Security_Edit_step_1_name.Text = "Name"
            'Form_setting.Label_Security_Edit_step_1_username.Text = "Username"
            'Form_setting.Label_Security_Edit_step_1_password.Text = "Password"
            'Form_setting.Label_Security_Edit_step_2_name.Text = "Name"
            'Form_setting.Label_Security_Edit_step_2_username.Text = "Create Username"
            'Form_setting.Label_Security_Edit_step_2_password.Text = "Create Password"
            'Form_setting.Label_Security_Edit_step_2_confirm_password.Text = "Confirm password"
            'Form_setting.Button_Security_Edit_done.Text = "Next"

            'Form_setting.Label_Security_Edit_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            'Form_setting.Label_Security_Edit_step_1_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_1_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_1_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_2_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_2_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_2_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_2_confirm_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Button_Security_Edit_done.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_application_username_and_password_title.Text = "Please select a new username and password"
            Form_setting.Label_application_username_and_password_username.Text = "Create Username"
            Form_setting.Label_application_username_and_password_password.Text = "Create Password"
            Form_setting.Label_application_username_and_password_confirm_password.Text = "Confirm password"
            Form_setting.Button_application_username_and_password_done.Text = "Edit"

            Form_setting.Label_application_username_and_password_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_application_username_and_password_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_application_username_and_password_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_application_username_and_password_confirm_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_application_username_and_password_done.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_show_patient_database" Then
            Form_show_patient_database.Text = "Patient Dialysis Information"

            Form_show_patient_database.Main_DataGridView.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_show_patient_database.Main_DataGridView.ColumnHeadersDefaultCellStyle.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_show_patient_database.Label_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_show_patient_database.ToolStripButton_add_dialysis.ToolTipText = "Add Dialysis"
            Form_show_patient_database.ToolStripButton_delete_dialysis.ToolTipText = "Delete Dialysis"
            Form_show_patient_database.ToolStripButton_edit_dialysis.ToolTipText = "Edit Dialysis"
            Form_show_patient_database.ToolStripButton_chart.ToolTipText = "Chart"
            Form_show_patient_database.ToolStripButton_print.ToolTipText = "Print"
            Form_show_patient_database.ToolStripButton_refresh.ToolTipText = "Refresh"
            Form_show_patient_database.ToolStripTextBox_search.Text = "Search"

            Form_show_patient_database.Main_DataGridView.Columns(0).HeaderText = "D.N"
            Form_show_patient_database.Main_DataGridView.Columns(0).ToolTipText = "Dialysis Number"
            Form_show_patient_database.Main_DataGridView.Columns(1).HeaderText = "Entry date"
            Form_show_patient_database.Main_DataGridView.Columns(1).ToolTipText = "Date of patient's arrival to dialysis ward"
            Form_show_patient_database.Main_DataGridView.Columns(2).HeaderText = "Entry time"
            Form_show_patient_database.Main_DataGridView.Columns(2).ToolTipText = "Time of the patient's arrival to the dialysis ward"
            Form_show_patient_database.Main_DataGridView.Columns(3).HeaderText = "Initial weight"
            Form_show_patient_database.Main_DataGridView.Columns(3).ToolTipText = "Patient weight before dialysis"
            Form_show_patient_database.Main_DataGridView.Columns(4).HeaderText = "Initial BMI"
            Form_show_patient_database.Main_DataGridView.Columns(4).ToolTipText = "Patient BMI before dialysis"
            Form_show_patient_database.Main_DataGridView.Columns(5).HeaderText = "leaving date"
            Form_show_patient_database.Main_DataGridView.Columns(5).ToolTipText = "Date of patient leaving the dialysis ward"
            Form_show_patient_database.Main_DataGridView.Columns(6).HeaderText = "leaving time"
            Form_show_patient_database.Main_DataGridView.Columns(6).ToolTipText = "Time of patient leaving the dialysis ward"
            Form_show_patient_database.Main_DataGridView.Columns(7).HeaderText = "Secondary weight"
            Form_show_patient_database.Main_DataGridView.Columns(7).ToolTipText = "Patient weight after dialysis"
            Form_show_patient_database.Main_DataGridView.Columns(8).HeaderText = "Secondary BMI"
            Form_show_patient_database.Main_DataGridView.Columns(8).ToolTipText = "Patient BMI after dialysis"
            Form_show_patient_database.Main_DataGridView.Columns(9).HeaderText = "Nurse"
            Form_show_patient_database.Main_DataGridView.Columns(9).ToolTipText = "Patient nurse when recording information"

            Form_show_patient_database.ToolTip.SetToolTip(Form_show_patient_database.PictureBox_dialysis_count, "Number of dialysis sessions")
            Form_show_patient_database.ToolTip.SetToolTip(Form_show_patient_database.Label_dialysis_count, "Number of dialysis sessions")

            Public_GridColor_Dialysis(Form_show_patient_database.Main_DataGridView)
        End If
    End Sub
    Sub Public_Persian_Language()
        If Public_Determine_Form = "Form_about_us" Then
            Form_about_us.Text = "درباره ما"

            Form_about_us.Label_Product_Name.Text = "نام محصول: " & My.Application.Info.ProductName.ToString
            Form_about_us.Label_Version.Text = "نسخه: " & My.Application.Info.Version.ToString
            Form_about_us.Label_Copyright.Text = "حق کپی رایت: " & My.Application.Info.Copyright.ToString
            Form_about_us.Label_Company_Name.Text = "محصولی از شرکت الوند دارو فام"
            Form_about_us.TextBox_Description.Text = "نوضیحات برنامه:" & vbNewLine & vbNewLine & "اندازه گیری هوشمند وزن مددجویان دیالیزی در هنگام ورود به سالن دیالیز"
            Form_about_us.LinkLabel_1.Text = "الوند دارو فام"

            Form_about_us.Label_Product_Name.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.Label_Version.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.Label_Copyright.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.Label_Company_Name.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.TextBox_Description.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.LinkLabel_1.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_add_dialysis" Then
            Form_add_dialysis.Text = "افزودن دیالیز"

            Form_add_dialysis.Button_add.Text = "افزودن"
            Form_add_dialysis.Button_cancell.Text = "کنسل"

            Form_add_dialysis.Label_time_1.Text = "ساعت ورود"
            Form_add_dialysis.Label_time_2.Text = "ساعت خروج"
            Form_add_dialysis.Label_date_1.Text = "تاریخ ورود"
            Form_add_dialysis.Label_date_2.Text = "تاریخ خروج"
            Form_add_dialysis.Label_weight_1.Text = "وزن اولیه"
            Form_add_dialysis.Label_weight_2.Text = "وزن ثانویه"

            Form_add_dialysis.Label_time_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_time_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_date_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_date_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_weight_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_weight_2.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_dialysis.Button_add.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_dialysis.MaskedTextBox_date_1.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_dialysis.MaskedTextBox_date_2.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_dialysis.MaskedTextBox_time_1.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_dialysis.MaskedTextBox_time_2.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_dialysis.NumericUpDown_weight_2.RightToLeft = Windows.Forms.RightToLeft.No
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_add_patient" Then
            Form_add_patient.Text = "افزودن بیمار"

            Form_add_patient.Button_add.Text = "افزودن"
            Form_add_patient.Button_cancell.Text = "کنسل"

            Form_add_patient.Label_name.Text = "نام:"
            Form_add_patient.Label_lastname.Text = "نام خانوادگی:"
            Form_add_patient.Label_father_name.Text = "نام پدر:"
            Form_add_patient.Label_birth_date.Text = "تاریخ تولد:"
            Form_add_patient.Label_id_code.Text = "کد ملی:"
            Form_add_patient.Label_mbile_number.Text = "شماره موبایل:"
            Form_add_patient.Label_home_number.Text = "شماره تلفن:"
            Form_add_patient.Label_gender.Text = "جنسیت:"
            Form_add_patient.RadioButton_male.Text = "مرد"
            Form_add_patient.RadioButton_female.Text = "زن"
            Form_add_patient.Label_hieght.Text = "قد:"
            Form_add_patient.Label_enroll_date.Text = "تاریخ ثبت نام:"
            Form_add_patient.Label_dr_name.Text = "نام پزشک:"
            Form_add_patient.Label_patient_image.Text = "عکس"
            Form_add_patient.Label_blood_type.Text = "گروه خونی:"
            Form_add_patient.Label_shift.Text = "شیفت:"
            Form_add_patient.Label_fingerprint_status.Text = "اثر انگشت ثبت نشده است"

            Form_add_patient.ComboBox_shift.Items.Clear()
            Form_add_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_add_patient.ComboBox_shift.Items.Add("1 زوج(صبح)")
            Form_add_patient.ComboBox_shift.Items.Add("2 زوج(ظهر)")
            Form_add_patient.ComboBox_shift.Items.Add("3 زوج(شب)")
            Form_add_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_add_patient.ComboBox_shift.Items.Add("4 فرد(صبح)")
            Form_add_patient.ComboBox_shift.Items.Add("5 فرد(ظهر)")
            Form_add_patient.ComboBox_shift.Items.Add("6 فرد(شب)")

            Form_add_patient.Label_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_lastname.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_father_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_birth_date.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_id_code.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_mbile_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_home_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_gender.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_hieght.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_enroll_date.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_dr_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_patient_image.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_blood_type.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_shift.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_fingerprint_status.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_patient.RadioButton_male.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.RadioButton_female.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_patient.Button_add.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_patient.ComboBox_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.ComboBox_shift.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_patient.MaskedTextBox_id_code.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_patient.MaskedTextBox_mobile_number.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_patient.MaskedTextBox_home_number.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_patient.MaskedTextBox_birth_date.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_patient.MaskedTextBox_enroll_date.RightToLeft = Windows.Forms.RightToLeft.No
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_backup_proccess" Then
            Form_backup_proccess.Label_explain.Font = Public_B_Nazanin_Font_9_Bold
            If Public_Integer_backup_restore_status = 1 Then
                Form_backup_proccess.Label_explain.Text = "در حال پشتیبان گیری..."
            Else
                Form_backup_proccess.Label_explain.Text = "در حال بازیابی..."
            End If
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_delete_dialysis" Then
            Form_delete_dialysis.Text = "حذف دیالیز"

            Form_delete_dialysis.Button_delete.Text = "حذف"
            Form_delete_dialysis.Button_cancell.Text = "کنسل"

            Form_delete_dialysis.Label_time_1.Text = "ساعت ورود"
            Form_delete_dialysis.Label_time_2.Text = "ساعت خروج"
            Form_delete_dialysis.Label_date_1.Text = "تاریخ ورود"
            Form_delete_dialysis.Label_date_2.Text = "تاریخ خروج"
            Form_delete_dialysis.Label_weight_1.Text = "وزن اولیه"
            Form_delete_dialysis.Label_weight_2.Text = "وزن ثانویه"

            Form_delete_dialysis.Label_time_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_time_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_date_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_date_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_weight_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_weight_2.Font = Public_B_Nazanin_Font_9_Bold

            Form_delete_dialysis.Button_delete.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_delete_patient" Then
            Form_delete_patient.Text = "حذف بیمار"

            Form_delete_patient.Button_delete.Text = "حذف"
            Form_delete_patient.Button_cancell.Text = "کنسل"

            Form_delete_patient.Label_name_1.Text = "نام:"
            Form_delete_patient.Label_father_name_1.Text = "نام پدر:"
            Form_delete_patient.Label_id_code_1.Text = "کد ملی:"
            Form_delete_patient.Label_birth_date_1.Text = "تاریخ تولد:"

            Form_delete_patient.Button_delete.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_delete_patient.Label_name_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_father_name_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_id_code_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_birth_date_1.Font = Public_B_Nazanin_Font_9_Bold

            Form_delete_patient.Label_name_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_father_name_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_id_code_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_birth_date_2.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_dialysis_chart" Then
            Form_dialysis_chart.Text = "نمودار"

            Form_dialysis_chart.Label_one_week.Text = "یک هفته"
            Form_dialysis_chart.Label_two_week.Text = "دو هفته"
            Form_dialysis_chart.Label_month.Text = "ماه"
            Form_dialysis_chart.Label_year.Text = "سال"
            Form_dialysis_chart.Label_all.Text = "کل"
            Form_dialysis_chart.Label_customize.Text = "شخصی سازی"

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_one_week, "نمایش نمودار دیالیز ها بر اساس اطلاعات هفته اخیر")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_two_week, "نمایش نمودار دیالیز ها بر اساس اطلاعات دو هفته اخیر")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_month, "نمایش نمودار دیالیز ها بر اساس اطلاعات یک ماه گذشته")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_year, "نمایش نمودار دیالیز ها بر اساس اطلاعات یک سال گذشته")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_all, "نمایش نمودار دیالیز ها بر اساس اطلاعات کل دیالیز ها")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_customize, "نمایش نمودار دیالیز ها بر اساس اطلاعات روز های انتخابی")

            Form_dialysis_chart.Label_one_week.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_two_week.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_month.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_year.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_all.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_customize.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_seperator_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_3.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_4.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_5.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_customize_explain_1.Text = "نمودار دیالیز ها بر اساس اطلاعات"
            Form_dialysis_chart.Label_customize_explain_2.Text = "روز اخیر"

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_reload_chart, "محاسبه اطلاعات")

            Form_dialysis_chart.Label_customize_explain_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_customize_explain_2.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_chart_filter_weight_1.Text = "وزن اولیه"
            Form_dialysis_chart.Label_chart_filter_weight_2.Text = "وزن ثانویه"
            Form_dialysis_chart.Label_chart_filter_bmi_1.Text = "شاخص توده بدنی اولیه"
            Form_dialysis_chart.Label_chart_filter_bmi_2.Text = "شاخص توده بدنی ثانویه"
            Form_dialysis_chart.Label_chart_filter_weight_all.Text = "وزن"
            Form_dialysis_chart.Label_chart_filter_bmi_all.Text = "شاخص توده بدنی"
            Form_dialysis_chart.Label_chart_filter_all.Text = "وزن و شاخص توده بدنی"

            Form_dialysis_chart.Label_chart_filter_weight_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_weight_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_weight_all.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_all.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_all.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_seperator_6.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_7.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_8.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_9.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_10.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_11.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Chart.Series(0).LegendText = "وزن اولیه"
            Form_dialysis_chart.Chart.Series(1).LegendText = "وزن ثانویه"
            Form_dialysis_chart.Chart.Series(2).LegendText = "شاخص توده بدنی اولیه"
            Form_dialysis_chart.Chart.Series(3).LegendText = "شاخص توده بدنی ثانویه"

            Form_dialysis_chart.Chart.Series(0).LegendToolTip = "وزن بیمار قبل از انجام دیالیز"
            Form_dialysis_chart.Chart.Series(1).LegendToolTip = "وزن بیمار بعد از انجام دیالیز"
            Form_dialysis_chart.Chart.Series(2).LegendToolTip = "شاخص توده بدنی بیمار قبل از انجام دیالیز"
            Form_dialysis_chart.Chart.Series(3).LegendToolTip = "شاخص توده بدنی بیمار بعد از انجام دیالیز"

            Form_dialysis_chart.Chart.Legends(0).Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_nothing_to_show.Text = "چیزی برای نمایش وجود ندارد"
            Form_dialysis_chart.Label_nothing_to_show.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_chart_labels_visible, "مخفی کردن اعداد نمودار")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_default_setting, "بازگردانی نمودار به تنظیمات پیش فرض")
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_edit_dialysis" Then
            Form_edit_dialysis.Text = "ویرایش دیالیز"

            Form_edit_dialysis.Button_edit.Text = "ویرایش"
            Form_edit_dialysis.Button_cancell.Text = "کنسل"

            Form_edit_dialysis.Label_time_1.Text = "ساعت ورود"
            Form_edit_dialysis.Label_time_2.Text = "ساعت خروج"
            Form_edit_dialysis.Label_date_1.Text = "تاریخ ورود"
            Form_edit_dialysis.Label_date_2.Text = "تاریخ خروج"
            Form_edit_dialysis.Label_weight_1.Text = "وزن اولیه"
            Form_edit_dialysis.Label_weight_2.Text = "وزن ثانویه"

            Form_edit_dialysis.Label_time_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_time_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_date_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_date_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_weight_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_weight_2.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_dialysis.Button_edit.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_dialysis.MaskedTextBox_date_1.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_dialysis.MaskedTextBox_date_2.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_dialysis.MaskedTextBox_time_1.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_dialysis.MaskedTextBox_time_2.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_dialysis.NumericUpDown_weight_2.RightToLeft = Windows.Forms.RightToLeft.No
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_edit_patient" Then
            Form_edit_patient.Text = "ویرایش بیمار"

            Form_edit_patient.Button_edit.Text = "ویرایش"
            Form_edit_patient.Button_cancell.Text = "کنسل"

            Form_edit_patient.Label_name.Text = "نام:"
            Form_edit_patient.Label_lastname.Text = "نام خانوادگی:"
            Form_edit_patient.Label_father_name.Text = "نام پدر:"
            Form_edit_patient.Label_birth_date.Text = "تاریخ تولد:"
            Form_edit_patient.Label_id_code.Text = "کد ملی:"
            Form_edit_patient.Label_mbile_number.Text = "شماره موبایل:"
            Form_edit_patient.Label_home_number.Text = "شماره تلفن:"
            Form_edit_patient.Label_gender.Text = "جنسیت:"
            Form_edit_patient.RadioButton_male.Text = "مرد"
            Form_edit_patient.RadioButton_female.Text = "زن"
            Form_edit_patient.Label_hieght.Text = "قد:"
            Form_edit_patient.Label_enroll_date.Text = "تاریخ ثبت نام:"
            Form_edit_patient.Label_dr_name.Text = "نام پزشک:"
            Form_edit_patient.Label_patient_image.Text = "عکس"
            Form_edit_patient.Label_blood_type.Text = "گروه خونی:"
            Form_edit_patient.Label_shift.Text = "شیفت:"
            If Public_Integer_Fingerprint_Status = 0 Then
                Form_edit_patient.Label_fingerprint_status.Text = "اثر انگشت ثبت نشده است"
            Else
                Form_edit_patient.Label_fingerprint_status.Text = "برای تغییر اثر انگشت کلیک کنید"
            End If

            Form_edit_patient.ComboBox_shift.Items.Clear()
            Form_edit_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_edit_patient.ComboBox_shift.Items.Add("1 زوج(صبح)")
            Form_edit_patient.ComboBox_shift.Items.Add("2 زوج(ظهر)")
            Form_edit_patient.ComboBox_shift.Items.Add("3 زوج(شب)")
            Form_edit_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_edit_patient.ComboBox_shift.Items.Add("4 فرد(صبح)")
            Form_edit_patient.ComboBox_shift.Items.Add("5 فرد(ظهر)")
            Form_edit_patient.ComboBox_shift.Items.Add("6 فرد(شب)")

            Form_edit_patient.Label_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_lastname.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_father_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_birth_date.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_id_code.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_mbile_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_home_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_gender.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_hieght.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_enroll_date.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_dr_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_patient_image.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_blood_type.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_shift.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_fingerprint_status.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_patient.RadioButton_male.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.RadioButton_female.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_patient.Button_edit.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_patient.ComboBox_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.ComboBox_shift.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_patient.MaskedTextBox_id_code.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_patient.MaskedTextBox_mobile_number.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_patient.MaskedTextBox_home_number.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_patient.MaskedTextBox_birth_date.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_patient.MaskedTextBox_enroll_date.RightToLeft = Windows.Forms.RightToLeft.No
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_find_dialysis_number" Then
            Form_find_dialysis_number.Text = "جستجوی شماره دیالیز"
            Form_find_dialysis_number.Label_dialysis_number.Text = "لطفا شماره دیالیز را وارد نمایید"
            Form_find_dialysis_number.Button_next.Text = "بعدی"
            Form_find_dialysis_number.Label_dialysis_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_find_dialysis_number.Button_next.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_find_ID" Then
            Form_find_ID.Text = "جستجوی کد ملی"
            Form_find_ID.Label_id_code.Text = "لطفا کد ملی را وارد نمایید"
            Form_find_ID.Button_next.Text = "بعدی"
            Form_find_ID.Label_id_code.Font = Public_B_Nazanin_Font_9_Bold
            Form_find_ID.Button_next.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_first_start_2" Then
            Form_first_start_2.Text = "شروع اولیه"

            Form_first_start_2.Label_title.Text = "لطفا فیلد های مورد نیاز را پر نمایید"
            Form_first_start_2.Label_hospital_name.Text = "نام بیمارستان"
            Form_first_start_2.Label_hospital_address.Text = "آدرس بیمارستان"
            Form_first_start_2.Label_hospital_tel.Text = "تلفن بیمارستان"
            Form_first_start_2.Label_dialysis_time.Text = "حداکثر زمان دیالیز(بر حسب ساعت)"
            Form_first_start_2.Button_next.Text = "بعدی"

            Form_first_start_2.Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_first_start_2.Label_hospital_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_2.Label_hospital_address.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_2.Label_hospital_tel.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_2.Label_dialysis_time.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_2.Button_next.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_first_start_3" Then
            Form_first_start_3.Text = "شروع اولیه"

            Form_first_start_3.Label_title.Text = "لطفاً یک نام کاربری و گذرواژه برای برنامه انتخاب کنید"
            Form_first_start_3.Label_username.Text = "ایجاد نام کاربری"
            Form_first_start_3.Label_password.Text = "ایجاد رمز عبور"
            Form_first_start_3.Label_confirm_password.Text = "رمز عبور را تأیید کنید"

            Form_first_start_3.Button_next.Text = "انجام شد"

            Form_first_start_3.Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_first_start_3.Label_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_3.Label_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_3.Label_confirm_password.Font = Public_B_Nazanin_Font_9_Bold

            Form_first_start_3.Button_next.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_main" Then
            Form_main.Main_DataGridView.Font = Public_B_Nazanin_Font_9_Bold
            Form_main.Main_DataGridView.ColumnHeadersDefaultCellStyle.Font = Public_B_Nazanin_Font_9_Bold
            Form_main.ToolStrip_menu.Font = Public_B_Nazanin_Font_9_Bold

            Form_main.ToolStripButton_add_patients.ToolTipText = "افزودن بیمار"
            Form_main.ToolStripButton_delete_patients.ToolTipText = "حذف بیمار"
            Form_main.ToolStripButton_edit_patients.ToolTipText = "ویرایش بیمار"
            Form_main.ToolStripButton_backup.ToolTipText = "پشتیبان گیری"
            Form_main.ToolStripButton_recovery.ToolTipText = "بازیابی"
            Form_main.ToolStripButton_setting.ToolTipText = "تنظیمات"
            Form_main.ToolStripButton_about_us.ToolTipText = "درباره ما"
            Form_main.ToolStripButton_refresh.ToolTipText = "تازه سازی"
            Form_main.ToolStripTextBox_search.Text = "جستجو"

            Form_main.Main_DataGridView.Columns(1).HeaderText = "عکس"
            Form_main.Main_DataGridView.Columns(1).ToolTipText = "عکس بیمار"
            Form_main.Main_DataGridView.Columns(2).HeaderText = "نام"
            Form_main.Main_DataGridView.Columns(2).ToolTipText = "نام بیمار"
            Form_main.Main_DataGridView.Columns(3).HeaderText = "نام خانوادگی"
            Form_main.Main_DataGridView.Columns(3).ToolTipText = "نام خانوادگی بیمار"
            Form_main.Main_DataGridView.Columns(4).HeaderText = "نام پدر"
            Form_main.Main_DataGridView.Columns(4).ToolTipText = "نام پدر بیمار"
            Form_main.Main_DataGridView.Columns(5).HeaderText = "تاریخ تولد"
            Form_main.Main_DataGridView.Columns(5).ToolTipText = "تاریخ تولد بیمار"
            Form_main.Main_DataGridView.Columns(6).HeaderText = "کد ملی"
            Form_main.Main_DataGridView.Columns(6).ToolTipText = "کد ملی بیمار"
            Form_main.Main_DataGridView.Columns(7).HeaderText = "شماره موبایل"
            Form_main.Main_DataGridView.Columns(7).ToolTipText = "شماره موبایل بیمار"
            Form_main.Main_DataGridView.Columns(8).HeaderText = "شماره تلفن"
            Form_main.Main_DataGridView.Columns(8).ToolTipText = "شماره تلفن بیمار"
            Form_main.Main_DataGridView.Columns(9).HeaderText = "جنسیت"
            Form_main.Main_DataGridView.Columns(9).ToolTipText = "جنسیت بیمار"
            Form_main.Main_DataGridView.Columns(10).HeaderText = "قد"
            Form_main.Main_DataGridView.Columns(10).ToolTipText = "قد بیمار بر حسب سانتی متر"
            Form_main.Main_DataGridView.Columns(12).HeaderText = "تاریخ ثبت نام"
            Form_main.Main_DataGridView.Columns(12).ToolTipText = "تاریخ ثبت نام بیمار"
            Form_main.Main_DataGridView.Columns(13).HeaderText = "نام پزشک"
            Form_main.Main_DataGridView.Columns(13).ToolTipText = "نام پزشک بیمار"
            Form_main.Main_DataGridView.Columns(14).HeaderText = "گروه خونی"
            Form_main.Main_DataGridView.Columns(14).ToolTipText = "گروه خونی بیمار"
            Form_main.Main_DataGridView.RightToLeft = Windows.Forms.RightToLeft.Yes

            Form_main.ToolStrip_menu.RightToLeft = Windows.Forms.RightToLeft.Yes

            Form_main.StatusStrip_label_connection_status.Font = Public_B_Nazanin_Font_9_Bold
            Form_main.StatusStrip_label_seperator.Font = Public_B_Nazanin_Font_9_Bold
            Form_main.StatusStrip_label_entered_person_name.Font = Public_B_Nazanin_Font_9_Bold
            If Public_Integer_entered_person_id = 1 Then Form_main.StatusStrip_label_entered_person_name.Text = "مدیریت"

            Public_GridColor_Patients(Form_main.Main_DataGridView)
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_receive_fingerprint" Then
            Form_receive_fingerprint.Text = "اثر انگشت"
            If Public_Integer_Fingerprint_Status = 1 Then
                Form_receive_fingerprint.Label_explain.Text = "اثر انگشت قبلا ثبت شده است" & vbNewLine & "برای تغییر بر روی آیکون زیر کلیک کنید"
                Form_receive_fingerprint.Label_explain.Font = Public_B_Nazanin_Font_9_Bold
            Else
                Form_receive_fingerprint.Label_explain.Text = "دستگاه آماده دریافت اثرانگشت میباشد" & vbNewLine & "لطفا انگشت خود را به طور کامل روی دستگاه قرار دهید"
                Form_receive_fingerprint.Label_explain.Font = Public_B_Nazanin_Font_9_Bold
                Form_add_patient.Label_fingerprint_status.Text = "اثر انگشت ثبت نشده است"
                Form_edit_patient.Label_fingerprint_status.Text = "اثر انگشت ثبت نشده است"
            End If
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_security_enter_app" Then
            Form_security_enter_app.Text = "ورود"

            Form_security_enter_app.Label_title.Text = "لطفا نام کاربری و رمز عبور خود را وارد کنید"
            Form_security_enter_app.Label_username.Text = "نام کاربری"
            Form_security_enter_app.Label_password.Text = "رمز عبور"
            Form_security_enter_app.Button_enter.Text = "ورود"

            Form_security_enter_app.Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_security_enter_app.Label_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_security_enter_app.Label_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_security_enter_app.Button_enter.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_security_need_access" Then
            Form_security_need_access.Text = "ورود"

            Form_security_need_access.Label_title.Text = "لطفا نام کاربری و رمز عبور خود را وارد کنید(مدیریت)"
            Form_security_need_access.Label_username.Text = "نام کاربری"
            Form_security_need_access.Label_password.Text = "رمز عبور"
            Form_security_need_access.Button_enter.Text = "ورود"

            Form_security_need_access.Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_security_need_access.Label_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_security_need_access.Label_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_security_need_access.Button_enter.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_setting" Then
            Form_setting.Text = "تنظیمات"

            Form_setting.TabPage_language.Text = "زبان"
            Form_setting.TabPage_hospital.Text = "بیمارستان"
            Form_setting.TabPage_devices.Text = "دستگاه ها"
            Form_setting.TabPage_scale_setting.Text = "تنظیمات ترازو"
            Form_setting.TabPage_Security.Text = "امنیت"
            Form_setting.TabPage_Security_Add.Text = "افزودن نام کاربری و رمز عبور"
            Form_setting.TabPage_Security_Delete.Text = "حذف نام کاربری و رمز عبور"
            'Form_setting.TabPage_Security_Edit.Text = "ویرایش نام کاربری و رمز عبور"
            Form_setting.TabPage_application_username_and_password.Text = "نام کاربری و رمز عبور برنامه"

            Form_setting.Label_title_language.Text = "لطفا زبان خود را انتخاب نمایید"
            Form_setting.Button_change_language.Text = "تغییر زبان"
            Form_setting.Label_title_language.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Button_change_language.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_title_hospital.Text = "لطفا فیلد های مورد نیاز را پر نمایید"
            Form_setting.Label_hospital_name.Text = "نام بیمارستان"
            Form_setting.Label_hospital_address.Text = "آدرس بیمارستان"
            Form_setting.Label_hospital_tel.Text = "تلفن بیمارستان"
            Form_setting.Label_dialysis_time.Text = "حداکثر زمان دیالیز(بر حسب ساعت)"
            Form_setting.Button_change_setting_table.Text = "تغییر اطلاعات"

            Form_setting.Label_title_hospital.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_hospital_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_hospital_address.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_hospital_tel.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_dialysis_time.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_change_setting_table.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_hospital_name.TextAlign = ContentAlignment.MiddleRight
            Form_setting.Label_hospital_tel.TextAlign = ContentAlignment.MiddleRight
            Form_setting.Label_hospital_address.TextAlign = ContentAlignment.MiddleLeft
            Form_setting.Label_dialysis_time.TextAlign = ContentAlignment.MiddleLeft

            Form_setting.Label_title_devices.Text = "وضعیت اتصال کامپیوتر به دستگاه اثر انگشت"
            Form_setting.Label_title_devices.Font = Public_B_Nazanin_Font_14_Bold

            Form_setting.Label_auto_connection.Text = "اتصال خودکار"
            Form_setting.Label_auto_connection.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_trying_to_connect.Text = "در حال تلاش برای اتصال"
            Form_setting.Label_trying_to_connect.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_title_calibrate.Text = "کالیبره کردن ترازو"
            Form_setting.Label_calibrate_explain.Text = "لطفا وزن را وارد کنید(به گرم)"
            Form_setting.Label_calibrate_help.Text = "برای کالیبره کردن ابتدا ترازو را خالی کرده و در بالا گزینه کالیبره کردن را انتخاب کنید" & vbNewLine & "سپس وزنه ای با وزن حداقل ۵۰ کیلوگرم را بر روی ترازو قرار دهید(از وزن دقیق وزنه اطلاع پیدا کنید)" & vbNewLine & "در انتها گزینه ارسال را انتخاب کرده و کالیبره را انجام دهید"
            Form_setting.Button_calibrate.Text = "کالیبره کردن"

            Form_setting.Label_title_calibrate.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_calibrate_explain.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_calibrate_help.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_calibrate.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_title_offset.Text = "صفر کردن ترازو"
            Form_setting.Label_offset_help.Text = "با انتخاب گزینه بالا وزن مشخص شده توسط ترازو به عنوان وزن پایه در نظر گرفته میشود(وزن ترازو صفر در نظر گرفته میشود)"
            Form_setting.Button_offset.Text = "صفر کردن"

            Form_setting.Label_title_offset.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_offset_help.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_offset.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_Security_Add_title.Text = "لطفاً نام کاربری و رمز عبور جدیدی انتخاب کنید"
            Form_setting.Label_Security_Add_name.Text = "نام"
            Form_setting.Label_Security_Add_username.Text = "ایجاد نام کاربری"
            Form_setting.Label_Security_Add_password.Text = "ایجاد رمز عبور"
            Form_setting.Label_Security_Add_confirm_password.Text = "رمز عبور را تأیید کنید"
            Form_setting.Button_Security_Add_done.Text = "انجام شد"

            Form_setting.Label_Security_Add_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_Security_Add_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Add_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Add_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Add_confirm_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_Security_Add_done.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_Security_Delete_title.Text = "لطفا نام کاربری و رمز عبور خود را وارد کنید"
            Form_setting.Label_Security_Delete_name.Text = "نام"
            Form_setting.Label_Security_Delete_username.Text = "نام کاربری"
            Form_setting.Label_Security_Delete_password.Text = "رمز عبور"
            Form_setting.Button_Security_Delete_done.Text = "حذف"

            Form_setting.Label_Security_Delete_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_Security_Delete_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Delete_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Delete_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_Security_Delete_done.Font = Public_B_Nazanin_Font_9_Bold

            'Form_setting.Label_Security_Edit_title.Text = "لطفاً اطلاعات خود را برای ویرایش وارد کنید"
            'Form_setting.Label_Security_Edit_step_1_name.Text = "نام"
            'Form_setting.Label_Security_Edit_step_1_username.Text = "نام کاربری"
            'Form_setting.Label_Security_Edit_step_1_password.Text = "رمز عبور"
            'Form_setting.Label_Security_Edit_step_2_name.Text = "نام"
            'Form_setting.Label_Security_Edit_step_2_username.Text = "ایجاد نام کاربری"
            'Form_setting.Label_Security_Edit_step_2_password.Text = "ایجاد رمز عبور"
            'Form_setting.Label_Security_Edit_step_2_confirm_password.Text = "رمز عبور را تأیید کنید"
            'Form_setting.Button_Security_Edit_done.Text = "بعدی"

            'Form_setting.Label_Security_Edit_title.Font = Public_B_Nazanin_Font_14_Bold
            'Form_setting.Label_Security_Edit_step_1_name.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_1_username.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_1_password.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_2_name.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_2_username.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_2_password.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_2_confirm_password.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Button_Security_Edit_done.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_application_username_and_password_title.Text = "لطفاً نام کاربری و رمز عبور جدیدی انتخاب کنید"
            Form_setting.Label_application_username_and_password_username.Text = "ایجاد نام کاربری"
            Form_setting.Label_application_username_and_password_password.Text = "ایجاد رمز عبور"
            Form_setting.Label_application_username_and_password_confirm_password.Text = "رمز عبور را تأیید کنید"
            Form_setting.Button_application_username_and_password_done.Text = "ویرایش"

            Form_setting.Label_application_username_and_password_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_application_username_and_password_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_application_username_and_password_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_application_username_and_password_confirm_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_application_username_and_password_done.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_show_patient_database" Then
            Form_show_patient_database.Text = "اطلاعات دیالیز بیمار"

            Form_show_patient_database.Main_DataGridView.Font = Public_B_Nazanin_Font_9_Bold
            Form_show_patient_database.Main_DataGridView.ColumnHeadersDefaultCellStyle.Font = Public_B_Nazanin_Font_9_Bold

            Form_show_patient_database.Label_name.Font = Public_B_Nazanin_Font_9_Bold

            Form_show_patient_database.ToolStripButton_add_dialysis.ToolTipText = "افزودن دیالیز"
            Form_show_patient_database.ToolStripButton_delete_dialysis.ToolTipText = "حذف دیالیز"
            Form_show_patient_database.ToolStripButton_edit_dialysis.ToolTipText = "ویرایش دیالیز"
            Form_show_patient_database.ToolStripButton_chart.ToolTipText = "نمودار"
            Form_show_patient_database.ToolStripButton_print.ToolTipText = "چاپ"
            Form_show_patient_database.ToolStripButton_refresh.ToolTipText = "تازه سازی"
            Form_show_patient_database.ToolStripTextBox_search.Text = "جستجو"

            Form_show_patient_database.Main_DataGridView.Columns(0).HeaderText = "ش.د"
            Form_show_patient_database.Main_DataGridView.Columns(0).ToolTipText = "شماره دیالیز"
            Form_show_patient_database.Main_DataGridView.Columns(1).HeaderText = "تاریخ ورود"
            Form_show_patient_database.Main_DataGridView.Columns(1).ToolTipText = "تاریخ ورود بیمار به بخش دیالیز"
            Form_show_patient_database.Main_DataGridView.Columns(2).HeaderText = "ساعت ورود"
            Form_show_patient_database.Main_DataGridView.Columns(2).ToolTipText = "ساعت ورود بیمار به بخش دیالیز"
            Form_show_patient_database.Main_DataGridView.Columns(3).HeaderText = "وزن اولیه"
            Form_show_patient_database.Main_DataGridView.Columns(3).ToolTipText = "وزن بیمار قبل از انجام دیالیز"
            Form_show_patient_database.Main_DataGridView.Columns(4).HeaderText = "شاخص توده بدنی اولیه"
            Form_show_patient_database.Main_DataGridView.Columns(4).ToolTipText = "شاخص توده بدنی بیمار قبل از انجام دیالیز"
            Form_show_patient_database.Main_DataGridView.Columns(5).HeaderText = "تاریخ خروج"
            Form_show_patient_database.Main_DataGridView.Columns(5).ToolTipText = "تاریخ خروج بیمار از بخش دیالیز"
            Form_show_patient_database.Main_DataGridView.Columns(6).HeaderText = "ساعت خروج"
            Form_show_patient_database.Main_DataGridView.Columns(6).ToolTipText = "ساعت خروج بیمار از بخش دیالیز"
            Form_show_patient_database.Main_DataGridView.Columns(7).HeaderText = "وزن ثانویه"
            Form_show_patient_database.Main_DataGridView.Columns(7).ToolTipText = "وزن بیمار بعد از انجام دیالیز"
            Form_show_patient_database.Main_DataGridView.Columns(8).HeaderText = "شاخص توده بدنی ثانویه"
            Form_show_patient_database.Main_DataGridView.Columns(8).ToolTipText = "شاخص توده بدنی بیمار بعد از انجام دیالیز"
            Form_show_patient_database.Main_DataGridView.Columns(9).HeaderText = "پرستار"
            Form_show_patient_database.Main_DataGridView.Columns(9).ToolTipText = "پرستار بیمار در هنگام ثبت اطلاعات"

            Form_show_patient_database.ToolTip.SetToolTip(Form_show_patient_database.PictureBox_dialysis_count, "تعداد جلسات دیالیز")
            Form_show_patient_database.ToolTip.SetToolTip(Form_show_patient_database.Label_dialysis_count, "تعداد جلسات دیالیز")

            Public_GridColor_Dialysis(Form_show_patient_database.Main_DataGridView)
        End If
    End Sub
    Sub Public_Arabic_Language()
        If Public_Determine_Form = "Form_about_us" Then
            Form_about_us.Text = "معلومات عنا"

            Form_about_us.Label_Product_Name.Text = "اسم المنتج: " & My.Application.Info.ProductName.ToString
            Form_about_us.Label_Version.Text = "الإصدار: " & My.Application.Info.Version.ToString
            Form_about_us.Label_Copyright.Text = "حقوق النشر: " & My.Application.Info.Copyright.ToString
            Form_about_us.Label_Company_Name.Text = "منتجات من شركة ألفاند دارو فام"
            Form_about_us.TextBox_Description.Text = "تفاصيل البرنامج:" & vbNewLine & vbNewLine & "قم بقياس وزن عملاء غسيل الكلى بذكاء عند دخول غرفة غسيل الكلى"
            Form_about_us.LinkLabel_1.Text = "ألفاند دارو فام"

            Form_about_us.Label_Product_Name.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.Label_Version.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.Label_Copyright.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.Label_Company_Name.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.TextBox_Description.Font = Public_B_Nazanin_Font_9_Bold
            Form_about_us.LinkLabel_1.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_add_dialysis" Then
            Form_add_dialysis.Text = "أضف غسيل الكلى"

            Form_add_dialysis.Button_add.Text = "أضف"
            Form_add_dialysis.Button_cancell.Text = "إلغاء"

            Form_add_dialysis.Label_time_1.Text = "ساعة الدخول"
            Form_add_dialysis.Label_time_2.Text = "ساعة المغادرة"
            Form_add_dialysis.Label_date_1.Text = "موعد الدخول"
            Form_add_dialysis.Label_date_2.Text = "موعد المغادرة"
            Form_add_dialysis.Label_weight_1.Text = "الوزن البدائي"
            Form_add_dialysis.Label_weight_2.Text = "الوزن الثانوي"

            Form_add_dialysis.Label_time_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_time_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_date_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_date_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_weight_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Label_weight_2.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_dialysis.Button_add.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_dialysis.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_dialysis.MaskedTextBox_date_1.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_dialysis.MaskedTextBox_date_2.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_dialysis.MaskedTextBox_time_1.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_dialysis.MaskedTextBox_time_2.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_dialysis.NumericUpDown_weight_2.RightToLeft = Windows.Forms.RightToLeft.No
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_add_patient" Then
            Form_add_patient.Text = "أضف المريض"

            Form_add_patient.Button_add.Text = "أضف"
            Form_add_patient.Button_cancell.Text = "إلغاء"

            Form_add_patient.Label_name.Text = "اسم:"
            Form_add_patient.Label_lastname.Text = "الكنية:"
            Form_add_patient.Label_father_name.Text = "اسم الاب:"
            Form_add_patient.Label_birth_date.Text = "تاريخ الولادة:"
            Form_add_patient.Label_id_code.Text = "رمز دولي:"
            Form_add_patient.Label_mbile_number.Text = "رقم الهاتف:"
            Form_add_patient.Label_home_number.Text = "رقم هاتف المنزل:"
            Form_add_patient.Label_gender.Text = "جنس:"
            Form_add_patient.RadioButton_male.Text = "رجل"
            Form_add_patient.RadioButton_female.Text = "أنثى"
            Form_add_patient.Label_hieght.Text = "ارتفاع:"
            Form_add_patient.Label_enroll_date.Text = "تاريخ التسجيل:"
            Form_add_patient.Label_dr_name.Text = "اسم الطبيب:"
            Form_add_patient.Label_patient_image.Text = "صورة"
            Form_add_patient.Label_blood_type.Text = "فصيلة الدم:"
            Form_add_patient.Label_shift.Text = "تحول:"
            Form_add_patient.Label_fingerprint_status.Text = "بصمة الإصبع غير مسجلة"

            Form_add_patient.ComboBox_shift.Items.Clear()
            Form_add_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_add_patient.ComboBox_shift.Items.Add("1 زوجان(صباح)")
            Form_add_patient.ComboBox_shift.Items.Add("2 زوجان(الظهيرة)")
            Form_add_patient.ComboBox_shift.Items.Add("3 زوجان(الليل)")
            Form_add_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_add_patient.ComboBox_shift.Items.Add("4 غريب(صباح)")
            Form_add_patient.ComboBox_shift.Items.Add("5 غريب(الظهيرة)")
            Form_add_patient.ComboBox_shift.Items.Add("6 غريب(الليل)")

            Form_add_patient.Label_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_lastname.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_father_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_birth_date.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_id_code.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_mbile_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_home_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_gender.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_hieght.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_enroll_date.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_dr_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_patient_image.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_blood_type.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_shift.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Label_fingerprint_status.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_patient.RadioButton_male.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.RadioButton_female.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_patient.Button_add.Font = Public_B_Nazanin_Font_9_Bold
            Form_add_patient.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_patient.ComboBox_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.ComboBox_shift.Font = Public_B_Nazanin_Font_9_Bold

            Form_add_patient.MaskedTextBox_id_code.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_patient.MaskedTextBox_mobile_number.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_patient.MaskedTextBox_home_number.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_patient.MaskedTextBox_birth_date.RightToLeft = Windows.Forms.RightToLeft.No
            Form_add_patient.MaskedTextBox_enroll_date.RightToLeft = Windows.Forms.RightToLeft.No
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_backup_proccess" Then
            Form_backup_proccess.Label_explain.Font = Public_B_Nazanin_Font_9_Bold
            If Public_Integer_backup_restore_status = 1 Then
                Form_backup_proccess.Label_explain.Text = "النسخة الإحتياطية..."
            Else
                Form_backup_proccess.Label_explain.Text = "استعادة..."
            End If
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_delete_dialysis" Then
            Form_delete_dialysis.Text = "القضاء على غسيل الكلى"

            Form_delete_dialysis.Button_delete.Text = "حذف"
            Form_delete_dialysis.Button_cancell.Text = "إلغاء"

            Form_delete_dialysis.Label_time_1.Text = "ساعة الدخول"
            Form_delete_dialysis.Label_time_2.Text = "ساعة المغادرة"
            Form_delete_dialysis.Label_date_1.Text = "موعد الدخول"
            Form_delete_dialysis.Label_date_2.Text = "موعد المغادرة"
            Form_delete_dialysis.Label_weight_1.Text = "الوزن البدائي"
            Form_delete_dialysis.Label_weight_2.Text = "الوزن الثانوي"

            Form_delete_dialysis.Label_time_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_time_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_date_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_date_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_weight_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Label_weight_2.Font = Public_B_Nazanin_Font_9_Bold

            Form_delete_dialysis.Button_delete.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_dialysis.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_delete_patient" Then
            Form_delete_patient.Text = "حذف المريض"

            Form_delete_patient.Button_delete.Text = "حذف"
            Form_delete_patient.Button_cancell.Text = "إلغاء"

            Form_delete_patient.Label_name_1.Text = "اسم:"
            Form_delete_patient.Label_father_name_1.Text = "اسم الاب:"
            Form_delete_patient.Label_id_code_1.Text = "رمز دولي:"
            Form_delete_patient.Label_birth_date_1.Text = "تاريخ الولادة:"

            Form_delete_patient.Button_delete.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_delete_patient.Label_name_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_father_name_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_id_code_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_birth_date_1.Font = Public_B_Nazanin_Font_9_Bold

            Form_delete_patient.Label_name_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_father_name_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_id_code_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_delete_patient.Label_birth_date_2.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_dialysis_chart" Then
            Form_dialysis_chart.Text = "الرسم البياني"

            Form_dialysis_chart.Label_one_week.Text = "اسبوع واحد"
            Form_dialysis_chart.Label_two_week.Text = "إسبوعين"
            Form_dialysis_chart.Label_month.Text = "شهر"
            Form_dialysis_chart.Label_year.Text = "عام"
            Form_dialysis_chart.Label_all.Text = "مجموع"
            Form_dialysis_chart.Label_customize.Text = "إضفاء الطابع الشخصي"

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_one_week, "اعرض مخططات غسيل الكلى بناءً على معلومات الأسبوع الأخير")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_two_week, "اعرض مخططات غسيل الكلى بناءً على معلومات الأسبوعين الماضيين")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_month, "اعرض مخططات غسيل الكلى بناءً على معلومات من الشهر الماضي")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_year, "اعرض مخططات غسيل الكلى بناءً على معلومات من العام الماضي")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_all, "اعرض مخططات غسيل الكلى بناءً على معلومات غسيل الكلى الكلية")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_customize, "اعرض مخططات غسيل الكلى بناءً على معلومات اليوم المحددة")

            Form_dialysis_chart.Label_one_week.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_two_week.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_month.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_year.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_all.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_customize.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_seperator_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_3.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_4.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_5.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_customize_explain_1.Text = "مخطط غسيل الكلى بناءً على معلومات من آخر"
            Form_dialysis_chart.Label_customize_explain_2.Text = "يوم"

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_reload_chart, "احسب المعلومات")

            Form_dialysis_chart.Label_customize_explain_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_customize_explain_2.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_chart_filter_weight_1.Text = "الوزن البدائي"
            Form_dialysis_chart.Label_chart_filter_weight_2.Text = "الوزن الثانوي"
            Form_dialysis_chart.Label_chart_filter_bmi_1.Text = "مؤشر كتلة الجسم الأساسي"
            Form_dialysis_chart.Label_chart_filter_bmi_2.Text = "مؤشر كتلة الجسم الثانوي"
            Form_dialysis_chart.Label_chart_filter_weight_all.Text = "وزن"
            Form_dialysis_chart.Label_chart_filter_bmi_all.Text = "مؤشر كتلة الجسم"
            Form_dialysis_chart.Label_chart_filter_all.Text = "وزن و مؤشر كتلة الجسم"

            Form_dialysis_chart.Label_chart_filter_weight_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_weight_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_weight_all.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_all.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_chart_filter_all.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_seperator_6.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_7.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_8.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_9.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_10.Font = Public_B_Nazanin_Font_9_Bold
            Form_dialysis_chart.Label_seperator_11.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Chart.Series(0).LegendText = "الوزن البدائي"
            Form_dialysis_chart.Chart.Series(1).LegendText = "الوزن الثانوي"
            Form_dialysis_chart.Chart.Series(2).LegendText = "مؤشر كتلة الجسم الأساسي"
            Form_dialysis_chart.Chart.Series(3).LegendText = "مؤشر كتلة الجسم الثانوي"

            Form_dialysis_chart.Chart.Series(0).LegendToolTip = "وزن المريض قبل غسيل الكلى"
            Form_dialysis_chart.Chart.Series(1).LegendToolTip = "وزن المريض بعد غسيل الكلى"
            Form_dialysis_chart.Chart.Series(2).LegendToolTip = "مؤشر كتلة جسم المريض قبل غسيل الكلى"
            Form_dialysis_chart.Chart.Series(3).LegendToolTip = "مؤشر كتلة جسم المريض بعد غسيل الكلى"

            Form_dialysis_chart.Chart.Legends(0).Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.Label_nothing_to_show.Text = "لا يوجد شيء لعرضه"
            Form_dialysis_chart.Label_nothing_to_show.Font = Public_B_Nazanin_Font_9_Bold

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_chart_labels_visible, "إخفاء أرقام المخطط")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_default_setting, "استعادة الرسم البياني إلى الإعدادات الافتراضية")
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_edit_dialysis" Then
            Form_edit_dialysis.Text = "تحرير غسيل الكلى"

            Form_edit_dialysis.Button_edit.Text = "تعديل"
            Form_edit_dialysis.Button_cancell.Text = "إلغاء"

            Form_edit_dialysis.Label_time_1.Text = "ساعة الدخول"
            Form_edit_dialysis.Label_time_2.Text = "ساعة المغادرة"
            Form_edit_dialysis.Label_date_1.Text = "موعد الدخول"
            Form_edit_dialysis.Label_date_2.Text = "موعد المغادرة"
            Form_edit_dialysis.Label_weight_1.Text = "الوزن البدائي"
            Form_edit_dialysis.Label_weight_2.Text = "الوزن الثانوي"

            Form_edit_dialysis.Label_time_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_time_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_date_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_date_2.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_weight_1.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Label_weight_2.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_dialysis.Button_edit.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_dialysis.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_dialysis.MaskedTextBox_date_1.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_dialysis.MaskedTextBox_date_2.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_dialysis.MaskedTextBox_time_1.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_dialysis.MaskedTextBox_time_2.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_dialysis.NumericUpDown_weight_2.RightToLeft = Windows.Forms.RightToLeft.No
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_edit_patient" Then
            Form_edit_patient.Text = "تحرير المريض"

            Form_edit_patient.Button_edit.Text = "تعديل"
            Form_edit_patient.Button_cancell.Text = "إلغاء"

            Form_edit_patient.Label_name.Text = "اسم:"
            Form_edit_patient.Label_lastname.Text = "الكنية:"
            Form_edit_patient.Label_father_name.Text = "اسم الاب:"
            Form_edit_patient.Label_birth_date.Text = "تاريخ الولادة:"
            Form_edit_patient.Label_id_code.Text = "رمز دولي:"
            Form_edit_patient.Label_mbile_number.Text = "رقم الهاتف:"
            Form_edit_patient.Label_home_number.Text = "رقم هاتف المنزل:"
            Form_edit_patient.Label_gender.Text = "جنس:"
            Form_edit_patient.RadioButton_male.Text = "رجل"
            Form_edit_patient.RadioButton_female.Text = "أنثى"
            Form_edit_patient.Label_hieght.Text = "ارتفاع:"
            Form_edit_patient.Label_enroll_date.Text = "تاريخ التسجيل:"
            Form_edit_patient.Label_dr_name.Text = "اسم الطبيب:"
            Form_edit_patient.Label_patient_image.Text = "صورة"
            Form_edit_patient.Label_blood_type.Text = "فصيلة الدم:"
            Form_edit_patient.Label_shift.Text = "تحول:"
            If Public_Integer_Fingerprint_Status = 0 Then
                Form_edit_patient.Label_fingerprint_status.Text = "بصمة الإصبع غير مسجلة"
            Else
                Form_edit_patient.Label_fingerprint_status.Text = "انقر لتغيير بصمة الإصبع"
            End If

            Form_edit_patient.ComboBox_shift.Items.Clear()
            Form_edit_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_edit_patient.ComboBox_shift.Items.Add("1 زوجان(صباح)")
            Form_edit_patient.ComboBox_shift.Items.Add("2 زوجان(الظهيرة)")
            Form_edit_patient.ComboBox_shift.Items.Add("3 زوجان(الليل)")
            Form_edit_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_edit_patient.ComboBox_shift.Items.Add("4 غريب(صباح)")
            Form_edit_patient.ComboBox_shift.Items.Add("5 غريب(الظهيرة)")
            Form_edit_patient.ComboBox_shift.Items.Add("6 غريب(الليل)")

            Form_edit_patient.Label_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_lastname.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_father_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_birth_date.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_id_code.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_mbile_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_home_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_gender.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_hieght.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_enroll_date.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_dr_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_patient_image.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_blood_type.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_shift.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Label_fingerprint_status.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_patient.RadioButton_male.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.RadioButton_female.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_patient.Button_edit.Font = Public_B_Nazanin_Font_9_Bold
            Form_edit_patient.Button_cancell.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_patient.ComboBox_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.ComboBox_shift.Font = Public_B_Nazanin_Font_9_Bold

            Form_edit_patient.MaskedTextBox_id_code.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_patient.MaskedTextBox_mobile_number.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_patient.MaskedTextBox_home_number.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_patient.MaskedTextBox_birth_date.RightToLeft = Windows.Forms.RightToLeft.No
            Form_edit_patient.MaskedTextBox_enroll_date.RightToLeft = Windows.Forms.RightToLeft.No
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_find_dialysis_number" Then
            Form_find_dialysis_number.Text = "البحث عن رقم غسيل الكلى"
            Form_find_dialysis_number.Label_dialysis_number.Text = "الرجاء إدخال رقم غسيل الكلى"
            Form_find_dialysis_number.Button_next.Text = "التالي"
            Form_find_dialysis_number.Label_dialysis_number.Font = Public_B_Nazanin_Font_9_Bold
            Form_find_dialysis_number.Button_next.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_find_ID" Then
            Form_find_ID.Text = "البحث عن الكود الوطني"
            Form_find_ID.Label_id_code.Text = "الرجاء إدخال الرمز الوطني"
            Form_find_ID.Button_next.Text = "التالي"
            Form_find_ID.Label_id_code.Font = Public_B_Nazanin_Font_9_Bold
            Form_find_ID.Button_next.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_first_start_2" Then
            Form_first_start_2.Text = "البداية الأولية"

            Form_first_start_2.Label_title.Text = "يرجى تعبئة الحقول المطلوبة"
            Form_first_start_2.Label_hospital_name.Text = "اسم المستشفى"
            Form_first_start_2.Label_hospital_address.Text = "عنوان المستشفى"
            Form_first_start_2.Label_hospital_tel.Text = "هاتف المستشفى"
            Form_first_start_2.Label_dialysis_time.Text = "أقصى وقت لغسيل الكلى (بالساعات)"
            Form_first_start_2.Button_next.Text = "التالي"

            Form_first_start_2.Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_first_start_2.Label_hospital_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_2.Label_hospital_address.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_2.Label_hospital_tel.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_2.Label_dialysis_time.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_2.Button_next.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_first_start_3" Then
            Form_first_start_3.Text = "البداية الأولية"

            Form_first_start_3.Label_title.Text = "الرجاء تحديد اسم مستخدم وكلمة مرور للتطبيق"
            Form_first_start_3.Label_username.Text = "انشي اسم مستخدم"
            Form_first_start_3.Label_password.Text = "أنشئ كلمة مرور"
            Form_first_start_3.Label_confirm_password.Text = "تأكيد كلمة المرور"

            Form_first_start_3.Button_next.Text = "منجز"

            Form_first_start_3.Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_first_start_3.Label_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_3.Label_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_first_start_3.Label_confirm_password.Font = Public_B_Nazanin_Font_9_Bold

            Form_first_start_3.Button_next.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_main" Then
            Form_main.Main_DataGridView.Font = Public_B_Nazanin_Font_9_Bold
            Form_main.Main_DataGridView.ColumnHeadersDefaultCellStyle.Font = Public_B_Nazanin_Font_9_Bold
            Form_main.ToolStrip_menu.Font = Public_B_Nazanin_Font_9_Bold

            Form_main.ToolStripButton_add_patients.ToolTipText = "أضف المريض"
            Form_main.ToolStripButton_delete_patients.ToolTipText = "حذف المريض"
            Form_main.ToolStripButton_edit_patients.ToolTipText = "تحرير المريض"
            Form_main.ToolStripButton_backup.ToolTipText = "دعم"
            Form_main.ToolStripButton_recovery.ToolTipText = "استعادة"
            Form_main.ToolStripButton_setting.ToolTipText = "إعدادات"
            Form_main.ToolStripButton_about_us.ToolTipText = "معلومات عنا"
            Form_main.ToolStripButton_refresh.ToolTipText = "تحديث"
            Form_main.ToolStripTextBox_search.Text = "بحث"

            Form_main.Main_DataGridView.Columns(1).HeaderText = "صورة"
            Form_main.Main_DataGridView.Columns(1).ToolTipText = "صورة المريض"
            Form_main.Main_DataGridView.Columns(2).HeaderText = "اسم"
            Form_main.Main_DataGridView.Columns(2).ToolTipText = "اسم المريض"
            Form_main.Main_DataGridView.Columns(3).HeaderText = "الكنية"
            Form_main.Main_DataGridView.Columns(3).ToolTipText = "الكنية المريض"
            Form_main.Main_DataGridView.Columns(4).HeaderText = "اسم الاب"
            Form_main.Main_DataGridView.Columns(4).ToolTipText = "اسم الأب المريض"
            Form_main.Main_DataGridView.Columns(5).HeaderText = "تاريخ الولادة"
            Form_main.Main_DataGridView.Columns(5).ToolTipText = "تاريخ ميلاد المريض"
            Form_main.Main_DataGridView.Columns(6).HeaderText = "رمز دولي"
            Form_main.Main_DataGridView.Columns(6).ToolTipText = "رمز دولي المريض"
            Form_main.Main_DataGridView.Columns(7).HeaderText = "رقم الهاتف"
            Form_main.Main_DataGridView.Columns(7).ToolTipText = "رقم الهاتف المريض"
            Form_main.Main_DataGridView.Columns(8).HeaderText = "رقم هاتف المنزل"
            Form_main.Main_DataGridView.Columns(8).ToolTipText = "رقم هاتف المنزل المريض"
            Form_main.Main_DataGridView.Columns(9).HeaderText = "جنس"
            Form_main.Main_DataGridView.Columns(9).ToolTipText = "جنس المريض"
            Form_main.Main_DataGridView.Columns(10).HeaderText = "ارتفاع"
            Form_main.Main_DataGridView.Columns(10).ToolTipText = "ارتفاع المريض بالسنتيمتر"
            Form_main.Main_DataGridView.Columns(12).HeaderText = "تاريخ التسجيل"
            Form_main.Main_DataGridView.Columns(12).ToolTipText = "تاريخ التسجيل المريض"
            Form_main.Main_DataGridView.Columns(13).HeaderText = "اسم الطبيب"
            Form_main.Main_DataGridView.Columns(13).ToolTipText = "اسم الطبيب المريض"
            Form_main.Main_DataGridView.Columns(14).HeaderText = "فصيلة الدم"
            Form_main.Main_DataGridView.Columns(14).ToolTipText = "فصيلة الدم المريض"
            Form_main.Main_DataGridView.RightToLeft = Windows.Forms.RightToLeft.Yes

            Form_main.ToolStrip_menu.RightToLeft = Windows.Forms.RightToLeft.Yes

            Form_main.StatusStrip_label_connection_status.Font = Public_B_Nazanin_Font_9_Bold
            Form_main.StatusStrip_label_seperator.Font = Public_B_Nazanin_Font_9_Bold
            Form_main.StatusStrip_label_entered_person_name.Font = Public_B_Nazanin_Font_9_Bold
            If Public_Integer_entered_person_id = 1 Then Form_main.StatusStrip_label_entered_person_name.Text = "الادارة"

            Public_GridColor_Patients(Form_main.Main_DataGridView)
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_receive_fingerprint" Then
            Form_receive_fingerprint.Text = "بصمة الاصبع"
            If Public_Integer_Fingerprint_Status = 1 Then
                Form_receive_fingerprint.Label_explain.Text = "تم تسجيل بصمة الإصبع بالفعل" & vbNewLine & "انقر على الأيقونة أدناه للتغيير"
                Form_receive_fingerprint.Label_explain.Font = Public_B_Nazanin_Font_9_Bold
            Else
                Form_receive_fingerprint.Label_explain.Text = "الجهاز جاهز لاستلام بصمات الأصابع" & vbNewLine & "الرجاء وضع إصبعك بالكامل على الجهاز"
                Form_receive_fingerprint.Label_explain.Font = Public_B_Nazanin_Font_9_Bold
                Form_add_patient.Label_fingerprint_status.Text = "بصمة الإصبع غير مسجلة"
                Form_edit_patient.Label_fingerprint_status.Text = "بصمة الإصبع غير مسجلة"
            End If
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_security_enter_app" Then
            Form_security_enter_app.Text = "أدخل"

            Form_security_enter_app.Label_title.Text = "الرجاء إدخال اسم المستخدم وكلمة المرور الخاصة بك"
            Form_security_enter_app.Label_username.Text = "اسم المستخدم"
            Form_security_enter_app.Label_password.Text = "كلمة مرور"
            Form_security_enter_app.Button_enter.Text = "أدخل"

            Form_security_enter_app.Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_security_enter_app.Label_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_security_enter_app.Label_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_security_enter_app.Button_enter.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_security_need_access" Then
            Form_security_need_access.Text = "أدخل"

            Form_security_need_access.Label_title.Text = "الرجاء إدخال اسم المستخدم وكلمة المرور الخاصة بك(الادارة)"
            Form_security_need_access.Label_username.Text = "اسم المستخدم"
            Form_security_need_access.Label_password.Text = "كلمة مرور"
            Form_security_need_access.Button_enter.Text = "أدخل"

            Form_security_need_access.Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_security_need_access.Label_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_security_need_access.Label_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_security_need_access.Button_enter.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_setting" Then
            Form_setting.Text = "إعدادات"

            Form_setting.TabPage_language.Text = "لغة"
            Form_setting.TabPage_hospital.Text = "مستشفى"
            Form_setting.TabPage_devices.Text = "الأجهزة"
            Form_setting.TabPage_scale_setting.Text = "إعدادات التوازن"
            Form_setting.TabPage_Security.Text = "الأمان"
            Form_setting.TabPage_Security_Add.Text = "أضف اسم المستخدم وكلمة المرور"
            Form_setting.TabPage_Security_Delete.Text = "احذف اسم المستخدم وكلمة المرور"
            'Form_setting.TabPage_Security_Edit.Text = "تحرير اسم المستخدم وكلمة المرور"
            Form_setting.TabPage_application_username_and_password.Text = "اسم المستخدم وكلمة المرور للتطبيق"

            Form_setting.Label_title_language.Text = "الرجاء اختيار لغتك"
            Form_setting.Button_change_language.Text = "تغيير اللغة"
            Form_setting.Label_title_language.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Button_change_language.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_title_hospital.Text = "يرجى تعبئة الحقول المطلوبة"
            Form_setting.Label_hospital_name.Text = "اسم المستشفى"
            Form_setting.Label_hospital_address.Text = "عنوان المستشفى"
            Form_setting.Label_hospital_tel.Text = "هاتف المستشفى"
            Form_setting.Label_dialysis_time.Text = "أقصى وقت لغسيل الكلى (بالساعات)"
            Form_setting.Button_change_setting_table.Text = "تغيير المعلومات"

            Form_setting.Label_title_hospital.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_hospital_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_hospital_address.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_hospital_tel.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_dialysis_time.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_change_setting_table.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_hospital_name.TextAlign = ContentAlignment.MiddleRight
            Form_setting.Label_hospital_tel.TextAlign = ContentAlignment.MiddleRight
            Form_setting.Label_hospital_address.TextAlign = ContentAlignment.MiddleLeft
            Form_setting.Label_dialysis_time.TextAlign = ContentAlignment.MiddleLeft

            Form_setting.Label_title_devices.Text = "حالة اتصال الكمبيوتر بجهاز البصمة"
            Form_setting.Label_title_devices.Font = Public_B_Nazanin_Font_14_Bold

            Form_setting.Label_auto_connection.Text = "اتصال تلقائي"
            Form_setting.Label_auto_connection.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_trying_to_connect.Text = "تحاول الاتصال"
            Form_setting.Label_trying_to_connect.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_title_calibrate.Text = "قم بمعايرة الموازين"
            Form_setting.Label_calibrate_explain.Text = "الرجاء إدخال الوزن (بالجرام)"
            Form_setting.Label_calibrate_help.Text = "للمعايرة ، أفرغ المقياس أولاً وحدد خيار المعايرة في الأعلى" & vbNewLine & "ثم ضع وزنًا لا يقل عن 50 كجم على الميزان (اكتشف الوزن الدقيق للوزن)" & vbNewLine & "أخيرًا ، حدد خيار الإرسال وقم بالمعايرة"
            Form_setting.Button_calibrate.Text = "معايرة"

            Form_setting.Label_title_calibrate.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_calibrate_explain.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_calibrate_help.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_calibrate.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_title_offset.Text = "أعد ضبط المقاييس"
            Form_setting.Label_offset_help.Text = "باختيار الخيار أعلاه ، يعتبر الوزن المحدد بواسطة المقياس بمثابة الوزن الأساسي (يعتبر وزن المقياس صفراً)"
            Form_setting.Button_offset.Text = "إعادة تعيين"

            Form_setting.Label_title_offset.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_offset_help.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_offset.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_Security_Add_title.Text = "الرجاء تحديد اسم مستخدم وكلمة مرور جديدين"
            Form_setting.Label_Security_Add_name.Text = "اسم"
            Form_setting.Label_Security_Add_username.Text = "انشي اسم مستخدم"
            Form_setting.Label_Security_Add_password.Text = "أنشئ كلمة مرور"
            Form_setting.Label_Security_Add_confirm_password.Text = "تأكيد كلمة المرور"
            Form_setting.Button_Security_Add_done.Text = "منجز"

            Form_setting.Label_Security_Add_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_Security_Add_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Add_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Add_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Add_confirm_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_Security_Add_done.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_Security_Delete_title.Text = "الرجاء إدخال اسم المستخدم وكلمة المرور الخاصة بك"
            Form_setting.Label_Security_Delete_name.Text = "اسم"
            Form_setting.Label_Security_Delete_username.Text = "اسم المستخدم"
            Form_setting.Label_Security_Delete_password.Text = "كلمة مرور"
            Form_setting.Button_Security_Delete_done.Text = "حذف"

            Form_setting.Label_Security_Delete_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_Security_Delete_name.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Delete_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_Security_Delete_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_Security_Delete_done.Font = Public_B_Nazanin_Font_9_Bold

            'Form_setting.Label_Security_Edit_title.Text = "الرجاء إدخال المعلومات الخاصة بك للتحرير"
            'Form_setting.Label_Security_Edit_step_1_name.Text = "اسم"
            'Form_setting.Label_Security_Edit_step_1_username.Text = "اسم المستخدم"
            'Form_setting.Label_Security_Edit_step_1_password.Text = "كلمة مرور"
            'Form_setting.Label_Security_Edit_step_2_name.Text = "اسم"
            'Form_setting.Label_Security_Edit_step_2_username.Text = "انشي اسم مستخدم"
            'Form_setting.Label_Security_Edit_step_2_password.Text = "أنشئ كلمة مرور"
            'Form_setting.Label_Security_Edit_step_2_confirm_password.Text = "تأكيد كلمة المرور"
            'Form_setting.Button_Security_Edit_done.Text = "التالى"

            'Form_setting.Label_Security_Edit_title.Font = Public_B_Nazanin_Font_14_Bold
            'Form_setting.Label_Security_Edit_step_1_name.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_1_username.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_1_password.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_2_name.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_2_username.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_2_password.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Label_Security_Edit_step_2_confirm_password.Font = Public_B_Nazanin_Font_9_Bold
            'Form_setting.Button_Security_Edit_done.Font = Public_B_Nazanin_Font_9_Bold

            Form_setting.Label_application_username_and_password_title.Text = "الرجاء تحديد اسم مستخدم وكلمة مرور جديدين"
            Form_setting.Label_application_username_and_password_username.Text = "انشي اسم مستخدم"
            Form_setting.Label_application_username_and_password_password.Text = "أنشئ كلمة مرور"
            Form_setting.Label_application_username_and_password_confirm_password.Text = "تأكيد كلمة المرور"
            Form_setting.Button_application_username_and_password_done.Text = "تعديل"

            Form_setting.Label_application_username_and_password_title.Font = Public_B_Nazanin_Font_14_Bold
            Form_setting.Label_application_username_and_password_username.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_application_username_and_password_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Label_application_username_and_password_confirm_password.Font = Public_B_Nazanin_Font_9_Bold
            Form_setting.Button_application_username_and_password_done.Font = Public_B_Nazanin_Font_9_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_show_patient_database" Then
            Form_show_patient_database.Text = "معلومات غسيل الكلى للمريض"

            Form_show_patient_database.Main_DataGridView.Font = Public_B_Nazanin_Font_9_Bold
            Form_show_patient_database.Main_DataGridView.ColumnHeadersDefaultCellStyle.Font = Public_B_Nazanin_Font_9_Bold

            Form_show_patient_database.Label_name.Font = Public_B_Nazanin_Font_9_Bold

            Form_show_patient_database.ToolStripButton_add_dialysis.ToolTipText = "أضف غسيل الكلى"
            Form_show_patient_database.ToolStripButton_delete_dialysis.ToolTipText = "حذف غسيل الكلى"
            Form_show_patient_database.ToolStripButton_edit_dialysis.ToolTipText = "تحرير غسيل الكلى"
            Form_show_patient_database.ToolStripButton_chart.ToolTipText = "الرسم البياني"
            Form_show_patient_database.ToolStripButton_print.ToolTipText = "طباعة"
            Form_show_patient_database.ToolStripButton_refresh.ToolTipText = "تحديث"
            Form_show_patient_database.ToolStripTextBox_search.Text = "بحث"

            Form_show_patient_database.Main_DataGridView.Columns(0).HeaderText = "ر.غ"
            Form_show_patient_database.Main_DataGridView.Columns(0).ToolTipText = "رقم غسيل الكلى"
            Form_show_patient_database.Main_DataGridView.Columns(1).HeaderText = "موعد الدخول"
            Form_show_patient_database.Main_DataGridView.Columns(1).ToolTipText = "تاريخ دخول المريض إلى قسم غسيل الكلى"
            Form_show_patient_database.Main_DataGridView.Columns(2).HeaderText = "الساعة الدخول"
            Form_show_patient_database.Main_DataGridView.Columns(2).ToolTipText = "الساعة وصول المريض إلى قسم غسيل الكلى"
            Form_show_patient_database.Main_DataGridView.Columns(3).HeaderText = "الوزن البدائي"
            Form_show_patient_database.Main_DataGridView.Columns(3).ToolTipText = "وزن المريض قبل غسيل الكلى"
            Form_show_patient_database.Main_DataGridView.Columns(4).HeaderText = "مؤشر كتلة الجسم الأساسي"
            Form_show_patient_database.Main_DataGridView.Columns(4).ToolTipText = "مؤشر كتلة جسم المريض قبل غسيل الكلى"
            Form_show_patient_database.Main_DataGridView.Columns(5).HeaderText = "موعد المغادرة"
            Form_show_patient_database.Main_DataGridView.Columns(5).ToolTipText = "تاريخ مغادرة المريض لقسم غسيل الكلى"
            Form_show_patient_database.Main_DataGridView.Columns(6).HeaderText = "الساعة المغادرة"
            Form_show_patient_database.Main_DataGridView.Columns(6).ToolTipText = "الساعة مغادرة المريض لقسم غسيل الكلى"
            Form_show_patient_database.Main_DataGridView.Columns(7).HeaderText = "الوزن الثانوي"
            Form_show_patient_database.Main_DataGridView.Columns(7).ToolTipText = "وزن المريض بعد غسيل الكلى"
            Form_show_patient_database.Main_DataGridView.Columns(8).HeaderText = "مؤشر كتلة الجسم الثانوي"
            Form_show_patient_database.Main_DataGridView.Columns(8).ToolTipText = "مؤشر كتلة جسم المريض بعد غسيل الكلى"
            Form_show_patient_database.Main_DataGridView.Columns(9).HeaderText = "ممرضة"
            Form_show_patient_database.Main_DataGridView.Columns(9).ToolTipText = "ممرضة المريض عند تسجيل المعلومات"

            Form_show_patient_database.ToolTip.SetToolTip(Form_show_patient_database.PictureBox_dialysis_count, "عدد جلسات غسيل الكلى")
            Form_show_patient_database.ToolTip.SetToolTip(Form_show_patient_database.Label_dialysis_count, "عدد جلسات غسيل الكلى")

            Public_GridColor_Dialysis(Form_show_patient_database.Main_DataGridView)
        End If
    End Sub
    Sub Public_Spanish_Language()
        If Public_Determine_Form = "Form_about_us" Then
            Form_about_us.Text = "Sobre nosotros"

            Form_about_us.Label_Product_Name.Text = "Nombre del producto: " & My.Application.Info.ProductName.ToString
            Form_about_us.Label_Version.Text = "Versión: " & My.Application.Info.Version.ToString
            Form_about_us.Label_Copyright.Text = "Derechos de autor: " & My.Application.Info.Copyright.ToString
            Form_about_us.Label_Company_Name.Text = "Productos Alvand Darou Fam Company"
            Form_about_us.TextBox_Description.Text = "Descripción del programa:" & vbNewLine & vbNewLine & "Mida de forma inteligente el peso de los clientes de diálisis al ingresar a la sala de diálisis"
            Form_about_us.LinkLabel_1.Text = "Alvand Darou Fam"

            Form_about_us.Label_Product_Name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.Label_Version.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.Label_Copyright.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.Label_Company_Name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.TextBox_Description.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_about_us.LinkLabel_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_add_dialysis" Then
            Form_add_dialysis.Text = "Agregar diálisis"

            Form_add_dialysis.Button_add.Text = "Añadir"
            Form_add_dialysis.Button_cancell.Text = "Cancelar"

            Form_add_dialysis.Label_time_1.Text = "Tiempo de entrada"
            Form_add_dialysis.Label_time_2.Text = "dejando tiempo"
            Form_add_dialysis.Label_date_1.Text = "Fecha de entrada"
            Form_add_dialysis.Label_date_2.Text = "fecha de salida"
            Form_add_dialysis.Label_weight_1.Text = "Peso inicial"
            Form_add_dialysis.Label_weight_2.Text = "Peso secundario"

            Form_add_dialysis.Label_time_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_time_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_date_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_date_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_weight_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Label_weight_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_dialysis.Button_add.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_dialysis.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_dialysis.NumericUpDown_weight_2.RightToLeft = Windows.Forms.RightToLeft.Yes
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_add_patient" Then
            Form_add_patient.Text = "Agregar paciente"

            Form_add_patient.Button_add.Text = "Añadir"
            Form_add_patient.Button_cancell.Text = "Cancelar"

            Form_add_patient.Label_name.Text = "Nombre:"
            Form_add_patient.Label_lastname.Text = "Apellido:"
            Form_add_patient.Label_father_name.Text = "Nombre del Padre:"
            Form_add_patient.Label_birth_date.Text = "Fecha de nacimiento:"
            Form_add_patient.Label_id_code.Text = "Código de identificación:"
            Form_add_patient.Label_mbile_number.Text = "Número de teléfono:"
            Form_add_patient.Label_home_number.Text = "Numero de telefono de casa:"
            Form_add_patient.Label_gender.Text = "Género:"
            Form_add_patient.RadioButton_male.Text = "Masculino"
            Form_add_patient.RadioButton_female.Text = "Hembra"
            Form_add_patient.Label_hieght.Text = "Altura:"
            Form_add_patient.Label_enroll_date.Text = "Fecha de inscripción:"
            Form_add_patient.Label_dr_name.Text = "El nombre del doctor:"
            Form_add_patient.Label_patient_image.Text = "Imagen"
            Form_add_patient.Label_blood_type.Text = "Tipo de sangre:"
            Form_add_patient.Label_shift.Text = "Cambio:"
            Form_add_patient.Label_fingerprint_status.Text = "La huella dactilar no está registrada"

            Form_add_patient.ComboBox_shift.Items.Clear()
            Form_add_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_add_patient.ComboBox_shift.Items.Add("1 Incluso(Mañana)")
            Form_add_patient.ComboBox_shift.Items.Add("2 Incluso(Mediodía)")
            Form_add_patient.ComboBox_shift.Items.Add("3 Incluso(Noche)")
            Form_add_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_add_patient.ComboBox_shift.Items.Add("4 impar(Mañana)")
            Form_add_patient.ComboBox_shift.Items.Add("5 impar(Mediodía)")
            Form_add_patient.ComboBox_shift.Items.Add("6 impar(Noche)")

            Form_add_patient.Label_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_lastname.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_father_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_birth_date.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_id_code.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_mbile_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_home_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_gender.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_hieght.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_enroll_date.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_dr_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_patient_image.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_shift.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Label_fingerprint_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_patient.RadioButton_male.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.RadioButton_female.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_patient.Button_add.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_add_patient.ComboBox_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_add_patient.ComboBox_shift.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_backup_proccess" Then
            Form_backup_proccess.Label_explain.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            If Public_Integer_backup_restore_status = 1 Then
                Form_backup_proccess.Label_explain.Text = "Retrocediendo..."
            Else
                Form_backup_proccess.Label_explain.Text = "Restaurando..."
            End If
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_delete_dialysis" Then
            Form_delete_dialysis.Text = "Eliminar diálisis"

            Form_delete_dialysis.Button_delete.Text = "Eliminar"
            Form_delete_dialysis.Button_cancell.Text = "Cancelar"

            Form_delete_dialysis.Label_time_1.Text = "Tiempo de entrada"
            Form_delete_dialysis.Label_time_2.Text = "dejando tiempo"
            Form_delete_dialysis.Label_date_1.Text = "Fecha de entrada"
            Form_delete_dialysis.Label_date_2.Text = "fecha de salida"
            Form_delete_dialysis.Label_weight_1.Text = "Peso inicial"
            Form_delete_dialysis.Label_weight_2.Text = "Peso secundario"

            Form_delete_dialysis.Label_time_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_time_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_date_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_date_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_weight_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Label_weight_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_delete_dialysis.Button_delete.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_dialysis.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_delete_patient" Then
            Form_delete_patient.Text = "Eliminar paciente"

            Form_delete_patient.Button_delete.Text = "Eliminar"
            Form_delete_patient.Button_cancell.Text = "Cancelar"

            Form_delete_patient.Label_name_1.Text = "Nombre:"
            Form_delete_patient.Label_father_name_1.Text = "Nombre del Padre:"
            Form_delete_patient.Label_id_code_1.Text = "Código de identificación:"
            Form_delete_patient.Label_birth_date_1.Text = "Fecha de nacimiento:"

            Form_delete_patient.Button_delete.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_delete_patient.Label_name_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_father_name_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_id_code_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_birth_date_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_delete_patient.Label_name_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_father_name_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_id_code_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_delete_patient.Label_birth_date_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_dialysis_chart" Then
            Form_dialysis_chart.Text = "Gráfico"

            Form_dialysis_chart.Label_one_week.Text = "UNA SEMANA"
            Form_dialysis_chart.Label_two_week.Text = "DOS SEMANAS"
            Form_dialysis_chart.Label_month.Text = "MES"
            Form_dialysis_chart.Label_year.Text = "AÑO"
            Form_dialysis_chart.Label_all.Text = "TODOS"
            Form_dialysis_chart.Label_customize.Text = "PERSONALIZAR"

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_one_week, "Mostrar cuadros de diálisis basados en información de las últimas semanas")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_two_week, "Mostrar cuadros de diálisis basados en información de las últimas dos semanas")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_month, "Mostrar cuadros de diálisis basados en información del último mes")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_year, "Mostrar cuadros de diálisis basados en información del último año")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_all, "Mostrar cuadros de diálisis basados en la información total de diálisis")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.Label_customize, "Mostrar cuadros de diálisis basados en la información de días seleccionados")

            Form_dialysis_chart.Label_one_week.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_two_week.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_month.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_year.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_all.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_customize.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_seperator_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_3.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_4.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_5.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_customize_explain_1.Text = "Gráficos de diálisis basados en información del último"
            Form_dialysis_chart.Label_customize_explain_2.Text = "dias"

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_reload_chart, "Calcular información")

            Form_dialysis_chart.Label_customize_explain_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_customize_explain_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_chart_filter_weight_1.Text = "Peso inicial"
            Form_dialysis_chart.Label_chart_filter_weight_2.Text = "Peso secundario"
            Form_dialysis_chart.Label_chart_filter_bmi_1.Text = "IMC inicial"
            Form_dialysis_chart.Label_chart_filter_bmi_2.Text = "IMC secundario"
            Form_dialysis_chart.Label_chart_filter_weight_all.Text = "Peso"
            Form_dialysis_chart.Label_chart_filter_bmi_all.Text = "IMC"
            Form_dialysis_chart.Label_chart_filter_all.Text = "Peso e IMC"

            Form_dialysis_chart.Label_chart_filter_weight_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_weight_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_weight_all.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_bmi_all.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_chart_filter_all.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_seperator_6.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_7.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_8.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_9.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_10.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_dialysis_chart.Label_seperator_11.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Chart.Series(0).LegendText = "Peso inicial"
            Form_dialysis_chart.Chart.Series(1).LegendText = "Peso secundario"
            Form_dialysis_chart.Chart.Series(2).LegendText = "IMC inicial"
            Form_dialysis_chart.Chart.Series(3).LegendText = "IMC secundario"

            Form_dialysis_chart.Chart.Series(0).LegendToolTip = "Peso del paciente antes de la diálisis"
            Form_dialysis_chart.Chart.Series(1).LegendToolTip = "Peso del paciente después de la diálisis"
            Form_dialysis_chart.Chart.Series(2).LegendToolTip = "IMC del paciente antes de la diálisis"
            Form_dialysis_chart.Chart.Series(3).LegendToolTip = "IMC del paciente después de la diálisis"

            Form_dialysis_chart.Chart.Legends(0).Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.Label_nothing_to_show.Text = "No hay nada que mostrar"
            Form_dialysis_chart.Label_nothing_to_show.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_chart_labels_visible, "Ocultar números de gráfico")
            Form_dialysis_chart.ToolTip.SetToolTip(Form_dialysis_chart.PictureBox_default_setting, "Restaurar el gráfico a la configuración predeterminada")
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_edit_dialysis" Then
            Form_edit_dialysis.Text = "Editar diálisis"

            Form_edit_dialysis.Button_edit.Text = "Editar"
            Form_edit_dialysis.Button_cancell.Text = "Cancelar"

            Form_edit_dialysis.Label_time_1.Text = "Tiempo de entrada"
            Form_edit_dialysis.Label_time_2.Text = "dejando tiempo"
            Form_edit_dialysis.Label_date_1.Text = "Fecha de entrada"
            Form_edit_dialysis.Label_date_2.Text = "fecha de salida"
            Form_edit_dialysis.Label_weight_1.Text = "Peso inicial"
            Form_edit_dialysis.Label_weight_2.Text = "Peso secundario"

            Form_edit_dialysis.Label_time_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_time_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_date_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_date_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_weight_1.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Label_weight_2.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_dialysis.Button_edit.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_dialysis.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_dialysis.NumericUpDown_weight_2.RightToLeft = Windows.Forms.RightToLeft.Yes
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_edit_patient" Then
            Form_edit_patient.Text = "Editar paciente"

            Form_edit_patient.Button_edit.Text = "Editar"
            Form_edit_patient.Button_cancell.Text = "Cancelar"

            Form_edit_patient.Label_name.Text = "Nombre:"
            Form_edit_patient.Label_lastname.Text = "Apellido:"
            Form_edit_patient.Label_father_name.Text = "Nombre del Padre:"
            Form_edit_patient.Label_birth_date.Text = "Fecha de nacimiento:"
            Form_edit_patient.Label_id_code.Text = "Código de identificación:"
            Form_edit_patient.Label_mbile_number.Text = "Número de teléfono:"
            Form_edit_patient.Label_home_number.Text = "número de teléfono de casa:"
            Form_edit_patient.Label_gender.Text = "Género:"
            Form_edit_patient.RadioButton_male.Text = "Masculino"
            Form_edit_patient.RadioButton_female.Text = "Hembra"
            Form_edit_patient.Label_hieght.Text = "Altura:"
            Form_edit_patient.Label_enroll_date.Text = "Fecha de inscripción:"
            Form_edit_patient.Label_dr_name.Text = "El nombre del doctor:"
            Form_edit_patient.Label_patient_image.Text = "Imagen"
            Form_edit_patient.Label_blood_type.Text = "Tipo de sangre:"
            Form_edit_patient.Label_shift.Text = "Cambio:"
            If Public_Integer_Fingerprint_Status = 0 Then
                Form_edit_patient.Label_fingerprint_status.Text = "La huella dactilar no está registrada"
            Else
                Form_edit_patient.Label_fingerprint_status.Text = "Haga clic para cambiar la huella digital"
            End If

            Form_edit_patient.ComboBox_shift.Items.Clear()
            Form_edit_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_edit_patient.ComboBox_shift.Items.Add("1 Incluso(Mañana)")
            Form_edit_patient.ComboBox_shift.Items.Add("2 Incluso(Mediodía)")
            Form_edit_patient.ComboBox_shift.Items.Add("3 Incluso(Noche)")
            Form_edit_patient.ComboBox_shift.Items.Add(String.Empty)
            Form_edit_patient.ComboBox_shift.Items.Add("4 impar(Mañana)")
            Form_edit_patient.ComboBox_shift.Items.Add("5 impar(Mediodía)")
            Form_edit_patient.ComboBox_shift.Items.Add("6 impar(Noche)")

            Form_edit_patient.Label_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_lastname.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_father_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_birth_date.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_id_code.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_mbile_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_home_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_gender.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_hieght.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_enroll_date.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_dr_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_patient_image.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_shift.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Label_fingerprint_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_patient.RadioButton_male.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.RadioButton_female.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_patient.Button_edit.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.Button_cancell.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_edit_patient.ComboBox_blood_type.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_edit_patient.ComboBox_shift.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_find_dialysis_number" Then
            Form_find_dialysis_number.Text = "Buscar número de diálisis"
            Form_find_dialysis_number.Label_dialysis_number.Text = "Ingrese el número de diálisis"
            Form_find_dialysis_number.Button_next.Text = "siguiente"
            Form_find_dialysis_number.Label_dialysis_number.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_find_dialysis_number.Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_find_ID" Then
            Form_find_ID.Text = "Buscar código de identificación"
            Form_find_ID.Label_id_code.Text = "Ingrese el código de identificación"
            Form_find_ID.Button_next.Text = "siguiente"
            Form_find_ID.Label_id_code.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_find_ID.Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_first_start_2" Then
            Form_first_start_2.Text = "Inicio inicial"

            Form_first_start_2.Label_title.Text = "Por favor llene los campos requeridos"
            Form_first_start_2.Label_hospital_name.Text = "Nombre del hospital"
            Form_first_start_2.Label_hospital_address.Text = "Dirección del hospital"
            Form_first_start_2.Label_hospital_tel.Text = "Tel Hospital"
            Form_first_start_2.Label_dialysis_time.Text = "Tiempo de diálisis/h"
            Form_first_start_2.Button_next.Text = "siguiente"

            Form_first_start_2.Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_first_start_2.Label_hospital_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_2.Label_hospital_address.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_2.Label_hospital_tel.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_2.Label_dialysis_time.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_2.Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_first_start_3" Then
            Form_first_start_3.Text = "Inicio inicial"

            Form_first_start_3.Label_title.Text = "Seleccione un nombre de usuario y contraseña para la aplicación."
            Form_first_start_3.Label_username.Text = "Crear nombre de usuario"
            Form_first_start_3.Label_password.Text = "Crear contraseña"
            Form_first_start_3.Label_confirm_password.Text = "Confirmar contraseña"

            Form_first_start_3.Button_next.Text = "Hecho"

            Form_first_start_3.Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_first_start_3.Label_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_3.Label_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_first_start_3.Label_confirm_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_first_start_3.Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_main" Then
            Form_main.Main_DataGridView.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_main.Main_DataGridView.ColumnHeadersDefaultCellStyle.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_main.ToolStrip_menu.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_main.ToolStripButton_add_patients.ToolTipText = "Agregar paciente"
            Form_main.ToolStripButton_delete_patients.ToolTipText = "Eliminar paciente"
            Form_main.ToolStripButton_edit_patients.ToolTipText = "Editar paciente"
            Form_main.ToolStripButton_backup.ToolTipText = "Apoyo"
            Form_main.ToolStripButton_recovery.ToolTipText = "Recuperación"
            Form_main.ToolStripButton_setting.ToolTipText = "Ajuste"
            Form_main.ToolStripButton_about_us.ToolTipText = "Sobre nosotros"
            Form_main.ToolStripButton_refresh.ToolTipText = "Actualizar"
            Form_main.ToolStripTextBox_search.Text = "Buscar"

            Form_main.Main_DataGridView.Columns(1).HeaderText = "Imagen"
            Form_main.Main_DataGridView.Columns(1).ToolTipText = "Imagen del paciente"
            Form_main.Main_DataGridView.Columns(2).HeaderText = "Nombre"
            Form_main.Main_DataGridView.Columns(2).ToolTipText = "Nombre del paciente"
            Form_main.Main_DataGridView.Columns(3).HeaderText = "Apellido"
            Form_main.Main_DataGridView.Columns(3).ToolTipText = "Apellido del paciente"
            Form_main.Main_DataGridView.Columns(4).HeaderText = "Nombre del Padre"
            Form_main.Main_DataGridView.Columns(4).ToolTipText = "Nombre del padre del paciente"
            Form_main.Main_DataGridView.Columns(5).HeaderText = "Fecha de nacimiento"
            Form_main.Main_DataGridView.Columns(5).ToolTipText = "Paciente Fecha de nacimiento"
            Form_main.Main_DataGridView.Columns(6).HeaderText = "Código de identificación"
            Form_main.Main_DataGridView.Columns(6).ToolTipText = "Código de identificación del paciente"
            Form_main.Main_DataGridView.Columns(7).HeaderText = "Número de teléfono"
            Form_main.Main_DataGridView.Columns(7).ToolTipText = "Número de teléfono del paciente"
            Form_main.Main_DataGridView.Columns(8).HeaderText = "Numero de telefono de casa"
            Form_main.Main_DataGridView.Columns(8).ToolTipText = "Numero de telefono de casa del paciente"
            Form_main.Main_DataGridView.Columns(9).HeaderText = "Género"
            Form_main.Main_DataGridView.Columns(9).ToolTipText = "Sexo del paciente"
            Form_main.Main_DataGridView.Columns(10).HeaderText = "Altura"
            Form_main.Main_DataGridView.Columns(10).ToolTipText = "Altura del paciente en centímetros"
            Form_main.Main_DataGridView.Columns(12).HeaderText = "Fecha de inscripción"
            Form_main.Main_DataGridView.Columns(12).ToolTipText = "Fecha de inscripción del paciente"
            Form_main.Main_DataGridView.Columns(13).HeaderText = "El nombre del doctor"
            Form_main.Main_DataGridView.Columns(13).ToolTipText = "Nombre del médico del paciente"
            Form_main.Main_DataGridView.Columns(14).HeaderText = "Tipo de sangre"
            Form_main.Main_DataGridView.Columns(14).ToolTipText = "Tipo de sangre del paciente"
            Form_main.Main_DataGridView.RightToLeft = Windows.Forms.RightToLeft.No

            Form_main.ToolStrip_menu.RightToLeft = Windows.Forms.RightToLeft.No

            Form_main.StatusStrip_label_connection_status.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_main.StatusStrip_label_seperator.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_main.StatusStrip_label_entered_person_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            If Public_Integer_entered_person_id = 1 Then Form_main.StatusStrip_label_entered_person_name.Text = "Administración"

            Public_GridColor_Patients(Form_main.Main_DataGridView)
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_receive_fingerprint" Then
            Form_receive_fingerprint.Text = "Huella dactilar"
            If Public_Integer_Fingerprint_Status = 1 Then
                Form_receive_fingerprint.Label_explain.Text = "La huella dactilar ya ha sido registrada" & vbNewLine & "Haga clic en el icono de abajo para cambiar"
                Form_receive_fingerprint.Label_explain.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Else
                Form_receive_fingerprint.Label_explain.Text = "El dispositivo está listo para recibir huellas digitales" & vbNewLine & "Coloque su dedo completamente en el dispositivo"
                Form_receive_fingerprint.Label_explain.Font = Public_Microsoft_Tai_Le_Font_8_Bold
                Form_add_patient.Label_fingerprint_status.Text = "La huella dactilar no está registrada"
                Form_edit_patient.Label_fingerprint_status.Text = "La huella dactilar no está registrada"
            End If
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_security_enter_app" Then
            Form_security_enter_app.Text = "Entrar"

            Form_security_enter_app.Label_title.Text = "porfavor introduzca su nombre de usuario y contraseña"
            Form_security_enter_app.Label_username.Text = "Nombre de usuario"
            Form_security_enter_app.Label_password.Text = "Contraseña"
            Form_security_enter_app.Button_enter.Text = "Entrar"

            Form_security_enter_app.Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_security_enter_app.Label_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_security_enter_app.Label_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_security_enter_app.Button_enter.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_security_need_access" Then
            Form_security_need_access.Text = "Entrar"

            Form_security_need_access.Label_title.Text = "porfavor introduzca su nombre de usuario y contraseña(administración)"
            Form_security_need_access.Label_username.Text = "Nombre de usuario"
            Form_security_need_access.Label_password.Text = "Contraseña"
            Form_security_need_access.Button_enter.Text = "Entrar"

            Form_security_need_access.Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_security_need_access.Label_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_security_need_access.Label_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_security_need_access.Button_enter.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_setting" Then
            Form_setting.Text = "Ajuste"

            Form_setting.TabPage_language.Text = "Idioma"
            Form_setting.TabPage_hospital.Text = "Hospital"
            Form_setting.TabPage_devices.Text = "Dispositivos"
            Form_setting.TabPage_scale_setting.Text = "Ajuste de escala"
            Form_setting.TabPage_Security.Text = "Seguridad"
            Form_setting.TabPage_Security_Add.Text = "Agregar nombre de usuario y contraseña"
            Form_setting.TabPage_Security_Delete.Text = "Eliminar nombre de usuario y contraseña"
            'Form_setting.TabPage_Security_Edit.Text = "Editar nombre de usuario y contraseña"
            Form_setting.TabPage_application_username_and_password.Text = "Nombre de usuario y contraseña de la aplicación"

            Form_setting.Label_title_language.Text = "Por favor seleccione el idioma"
            Form_setting.Button_change_language.Text = "Cambiar idioma"
            Form_setting.Label_title_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Button_change_language.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_title_hospital.Text = "Por favor llene los campos requeridos"
            Form_setting.Label_hospital_name.Text = "Nombre del hospital"
            Form_setting.Label_hospital_address.Text = "Dirección del hospital"
            Form_setting.Label_hospital_tel.Text = "Tel Hospital"
            Form_setting.Label_dialysis_time.Text = "Tiempo de diálisis / h"
            Form_setting.Button_change_setting_table.Text = "Cambiar información"

            Form_setting.Label_title_hospital.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_hospital_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_hospital_address.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_hospital_tel.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_dialysis_time.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_change_setting_table.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_hospital_name.TextAlign = ContentAlignment.MiddleLeft
            Form_setting.Label_hospital_tel.TextAlign = ContentAlignment.MiddleLeft
            Form_setting.Label_hospital_address.TextAlign = ContentAlignment.MiddleRight
            Form_setting.Label_dialysis_time.TextAlign = ContentAlignment.MiddleRight

            Form_setting.Label_title_devices.Text = "Estado de la conexión de la computadora al dispositivo de huellas dactilares"
            Form_setting.Label_title_devices.Font = Public_Microsoft_Tai_Le_Font_12_Bold

            Form_setting.Label_auto_connection.Text = "Conexión automática"
            Form_setting.Label_auto_connection.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_trying_to_connect.Text = "Intentando conectar"
            Form_setting.Label_trying_to_connect.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_title_calibrate.Text = "Calibrar las escalas"
            Form_setting.Label_calibrate_explain.Text = "Ingrese el peso (en gramos)"
            Form_setting.Label_calibrate_help.Text = "Para calibrar, primero vacíe la báscula y seleccione la opción de calibración en la parte superior" & vbNewLine & "Luego coloque un peso de al menos 50 kg en la balanza (averigüe el peso exacto del peso)" & vbNewLine & "Finalmente, seleccione la opción de enviar y calibre"
            Form_setting.Button_calibrate.Text = "Calibrar"

            Form_setting.Label_title_calibrate.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_calibrate_explain.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_calibrate_help.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_calibrate.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_title_offset.Text = "Reiniciar las escalas"
            Form_setting.Label_offset_help.Text = "Al seleccionar la opción anterior, el peso especificado por la báscula se considera como el peso base (el peso de la báscula se considera cero)"
            Form_setting.Button_offset.Text = "Reiniciar"

            Form_setting.Label_title_offset.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_offset_help.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_offset.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_Security_Add_title.Text = "Seleccione un nuevo nombre de usuario y contraseña"
            Form_setting.Label_Security_Add_name.Text = "Nombre"
            Form_setting.Label_Security_Add_username.Text = "Crear nombre de usuario"
            Form_setting.Label_Security_Add_password.Text = "Crear contraseña"
            Form_setting.Label_Security_Add_confirm_password.Text = "Confirmar contraseña"
            Form_setting.Button_Security_Add_done.Text = "Hecho"

            Form_setting.Label_Security_Add_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_Security_Add_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Add_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Add_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Add_confirm_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_Security_Add_done.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_Security_Delete_title.Text = "porfavor introduzca su nombre de usuario y contraseña"
            Form_setting.Label_Security_Delete_name.Text = "Nombre"
            Form_setting.Label_Security_Delete_username.Text = "Nombre de usuario"
            Form_setting.Label_Security_Delete_password.Text = "Contraseña"
            Form_setting.Button_Security_Delete_done.Text = "Eliminar"

            Form_setting.Label_Security_Delete_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_Security_Delete_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Delete_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_Security_Delete_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_Security_Delete_done.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            'Form_setting.Label_Security_Edit_title.Text = "Ingrese su información para editar"
            'Form_setting.Label_Security_Edit_step_1_name.Text = "Nombre"
            'Form_setting.Label_Security_Edit_step_1_username.Text = "Nombre de usuario"
            'Form_setting.Label_Security_Edit_step_1_password.Text = "Contraseña"
            'Form_setting.Label_Security_Edit_step_2_name.Text = "Nombre"
            'Form_setting.Label_Security_Edit_step_2_username.Text = "Crear nombre de usuario"
            'Form_setting.Label_Security_Edit_step_2_password.Text = "Crear contraseña"
            'Form_setting.Label_Security_Edit_step_2_confirm_password.Text = "Confirmar contraseña"
            'Form_setting.Button_Security_Edit_done.Text = "siguiente"

            'Form_setting.Label_Security_Edit_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            'Form_setting.Label_Security_Edit_step_1_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_1_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_1_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_2_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_2_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_2_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Label_Security_Edit_step_2_confirm_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            'Form_setting.Button_Security_Edit_done.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_setting.Label_application_username_and_password_title.Text = "Seleccione un nuevo nombre de usuario y contraseña"
            Form_setting.Label_application_username_and_password_username.Text = "Crear nombre de usuario"
            Form_setting.Label_application_username_and_password_password.Text = "Crear contraseña"
            Form_setting.Label_application_username_and_password_confirm_password.Text = "Confirmar contraseña"
            Form_setting.Button_application_username_and_password_done.Text = "Editar"

            Form_setting.Label_application_username_and_password_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Form_setting.Label_application_username_and_password_username.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_application_username_and_password_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Label_application_username_and_password_confirm_password.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_setting.Button_application_username_and_password_done.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
        '
        '
        '
        '
        '
        '
        If Public_Determine_Form = "Form_show_patient_database" Then
            Form_show_patient_database.Text = "Información de diálisis del paciente"

            Form_show_patient_database.Main_DataGridView.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            Form_show_patient_database.Main_DataGridView.ColumnHeadersDefaultCellStyle.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_show_patient_database.Label_name.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            Form_show_patient_database.ToolStripButton_add_dialysis.ToolTipText = "Agregar diálisis"
            Form_show_patient_database.ToolStripButton_delete_dialysis.ToolTipText = "Eliminar diálisis"
            Form_show_patient_database.ToolStripButton_edit_dialysis.ToolTipText = "Editar diálisis"
            Form_show_patient_database.ToolStripButton_chart.ToolTipText = "Gráfico"
            Form_show_patient_database.ToolStripButton_print.ToolTipText = "Impresión"
            Form_show_patient_database.ToolStripButton_refresh.ToolTipText = "Actualizar"
            Form_show_patient_database.ToolStripTextBox_search.Text = "Buscar"

            Form_show_patient_database.Main_DataGridView.Columns(0).HeaderText = "N.D"
            Form_show_patient_database.Main_DataGridView.Columns(0).ToolTipText = "Número de diálisis"
            Form_show_patient_database.Main_DataGridView.Columns(1).HeaderText = "Fecha de entrada"
            Form_show_patient_database.Main_DataGridView.Columns(1).ToolTipText = "Fecha de llegada del paciente a la sala de diálisis."
            Form_show_patient_database.Main_DataGridView.Columns(2).HeaderText = "Tiempo de entrada"
            Form_show_patient_database.Main_DataGridView.Columns(2).ToolTipText = "Hora de llegada del paciente a la sala de diálisis."
            Form_show_patient_database.Main_DataGridView.Columns(3).HeaderText = "Peso inicial"
            Form_show_patient_database.Main_DataGridView.Columns(3).ToolTipText = "Peso del paciente antes de la diálisis"
            Form_show_patient_database.Main_DataGridView.Columns(4).HeaderText = "IMC inicial"
            Form_show_patient_database.Main_DataGridView.Columns(4).ToolTipText = "IMC del paciente antes de la diálisis"
            Form_show_patient_database.Main_DataGridView.Columns(5).HeaderText = "fecha de salida"
            Form_show_patient_database.Main_DataGridView.Columns(5).ToolTipText = "Fecha de salida del paciente de la sala de diálisis."
            Form_show_patient_database.Main_DataGridView.Columns(6).HeaderText = "dejando tiempo"
            Form_show_patient_database.Main_DataGridView.Columns(6).ToolTipText = "Tiempo de salida del paciente de la sala de diálisis."
            Form_show_patient_database.Main_DataGridView.Columns(7).HeaderText = "Peso secundario"
            Form_show_patient_database.Main_DataGridView.Columns(7).ToolTipText = "Peso del paciente después de la diálisis"
            Form_show_patient_database.Main_DataGridView.Columns(8).HeaderText = "IMC secundario"
            Form_show_patient_database.Main_DataGridView.Columns(8).ToolTipText = "IMC del paciente después de la diálisis"
            Form_show_patient_database.Main_DataGridView.Columns(9).HeaderText = "Enfermero"
            Form_show_patient_database.Main_DataGridView.Columns(9).ToolTipText = "Enfermera paciente al registrar información"

            Form_show_patient_database.ToolTip.SetToolTip(Form_show_patient_database.PictureBox_dialysis_count, "Número de sesiones de diálisis")
            Form_show_patient_database.ToolTip.SetToolTip(Form_show_patient_database.Label_dialysis_count, "Número de sesiones de diálisis")

            Public_GridColor_Dialysis(Form_show_patient_database.Main_DataGridView)
        End If
    End Sub

    Sub Public_Determine_Languages()
        Select Case My.Settings.Languages
            Case 1
                Public_English_Language()
            Case 2
                Public_Persian_Language()
            Case 3
                Public_Arabic_Language()
            Case 4
                Public_Spanish_Language()
        End Select
    End Sub
End Module
