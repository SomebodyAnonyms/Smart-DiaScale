Imports System.Data.SqlClient
Imports System.IO

Public Class Form_main
    Dim PersianCalendar As New System.Globalization.PersianCalendar
    Dim ArabicCalendar As New System.Globalization.HijriCalendar

    Public Delegate Sub Delegate_Serial()

    Dim Integer_Row_count As Integer
    Dim Integer_record_level As Integer
    Dim Integer_date_diff As Integer
    Dim Integer_Row_check As Integer
    Dim Integer_DataTable_Rows_Count As Integer
    Dim Integer_time_count As Integer
    Dim Integer_fingerprint As Integer

    Dim String_date As String
    Dim String_weight As String
    Dim Date_transfor_month As String
    Dim Date_transfor_day As String
    Dim String_serial_port As String

    Dim Time_1 As DateTime
    Dim Time_2 As DateTime

    Private Sub Main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form_setting.ComboBox_ListPort.Items.Clear()
        For Each Serial_Name As String In My.Computer.Ports.SerialPortNames
            Form_setting.ComboBox_ListPort.Items.Add(Serial_Name)
        Next
        If Not Form_setting.ComboBox_ListPort.Items.Count = 0 Then
            If Form_setting.ComboBox_ListPort.Text = String.Empty Then
                Form_setting.ComboBox_ListPort.Text = Form_setting.ComboBox_ListPort.Items(0)
            End If
        End If

        ListBox_serial_items.Items.Clear()


        StatusStrip_label_percent.Text = "0%"


        Main_DataGridView.RowTemplate.Height = 50

        Refresh_DataGridView()

        If Main_DataGridView.RowCount = 0 Then
            StatusStrip_progress_bar.Value = 100
            StatusStrip_label_percent.Text = "100%"
        End If

        Main_DataGridView.Columns(0).Visible = False
        Main_DataGridView.Columns(11).Visible = False
        Main_DataGridView.Columns(15).Visible = False
        Main_DataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Main_DataGridView.Columns(1).Width = 50
        Column_image.ImageLayout = DataGridViewImageCellLayout.Zoom

        Public_Determine_Form = "Form_main"
        Public_Determine_Languages()
    End Sub
    Private Sub Form_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Select Case My.Settings.Languages
            Case 1
                Message_box = MessageBox.Show("Do you want to close the app?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 2
                Message_box = MessageBox.Show("آیا می خواهید برنامه را ببندید؟", "بستن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 3
                Message_box = MessageBox.Show("هل تريد إغلاق التطبيق؟", "لإغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 4
                Message_box = MessageBox.Show("¿Quieres cerrar la aplicación?", "Cerca", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        End Select

        If Message_box = DialogResult.No Then
            e.Cancel = True
        Else
            If SerialPort.IsOpen = True Then
                SerialPort.WriteLine("close")
            End If
        End If
    End Sub

    Sub Refresh_DataGridView()
        Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From all_patients", Public_connect_DataGridView)
        Dim DataTable As New DataTable
        data_adapter.Fill(DataTable)
        Main_DataGridView.DataSource = DataTable

        Public_GridColor_Patients(Main_DataGridView)

        Main_DataGridView.Sort(Main_DataGridView.Columns(12), System.ComponentModel.ListSortDirection.Descending)

        Select Case My.Settings.Languages
            Case 1
                ToolStripTextBox_search.Text = "Search"
            Case 2
                ToolStripTextBox_search.Text = "جستجو"
            Case 3
                ToolStripTextBox_search.Text = "بحث"
            Case 4
                ToolStripTextBox_search.Text = "Buscar"
        End Select
        ToolStripTextBox_search.ForeColor = Color.Gray

        If Main_DataGridView.RowCount = 0 Then
            StatusStrip_progress_bar.Value = 100
            StatusStrip_label_percent.Text = "100%"
        End If
    End Sub

    Sub Get_image()
        Dim Stream As New MemoryStream()
        Public_connect_DataGridView.Open()
        Dim command As New SqlCommand("select image from all_patients where id=" & Public_Integer_ID_save, Public_connect_DataGridView)
        Dim image As Byte() = DirectCast(command.ExecuteScalar(), Byte())
        Stream.Write(image, 0, image.Length)
        Public_connect_DataGridView.Close()
        Dim Bitmap As New Bitmap(Stream)
        Form_show_patient_database.PictureBox_user.Image = Bitmap
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
    Private Sub Form_main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Main_DataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles Main_DataGridView.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If Not Main_DataGridView.Rows.Count = 0 Then
                    Public_Integer_ID_save = Main_DataGridView.CurrentRow.Cells(0).Value
                    Main_DataGridView.CurrentRow.Selected = True
                    Form_show_patient_database.ShowDialog()
                End If
            Case Keys.Delete
                Public_String_Menu_Item = "delete"
                Main_DataGridView.CurrentRow.Selected = False
                For i = 0 To Main_DataGridView.CurrentRow.Cells.Count - 1
                    Main_DataGridView.CurrentRow.Cells(i).Style.BackColor = Color.Red
                Next
                Public_Integer_ID_save = Main_DataGridView.CurrentRow.Cells(0).Value
                Form_delete_patient.ShowDialog()
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
    'Main_DataGridView
    Private Sub Main_DataGridView_Sorted(sender As Object, e As EventArgs) Handles Main_DataGridView.Sorted
        Public_GridColor_Patients(Main_DataGridView)
    End Sub
    Private Sub Main_DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Main_DataGridView.CellClick
        If Not Main_DataGridView.Rows.Count = 0 Then
            Main_DataGridView.CurrentRow.Selected = True
        End If
    End Sub
    Private Sub Main_DataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Main_DataGridView.CellMouseDoubleClick
        If Not Main_DataGridView.Rows.Count = 0 Then
            Public_Integer_ID_save = Main_DataGridView.CurrentRow.Cells(0).Value
            Main_DataGridView.CurrentRow.Selected = True
            Form_show_patient_database.ShowDialog()
        End If
    End Sub
    Private Sub Main_DataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles Main_DataGridView.RowsAdded
        If Main_DataGridView.RowCount = 1 Then
            If ToolStripTextBox_search.Text = "Search" Or ToolStripTextBox_search.Text = "جستجو" Or ToolStripTextBox_search.Text = "بحث" Or ToolStripTextBox_search.Text = "Buscar" Then
                Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From all_patients", Public_connect_DataGridView)
                Dim DataTable As New DataTable
                data_adapter.Fill(DataTable)
                Integer_Row_count = 100 / DataTable.Rows.Count
                Integer_DataTable_Rows_Count = DataTable.Rows.Count
                Integer_Row_check = 0
                Timer_proggress_bar.Enabled = True
            End If
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
    'search
    Private Sub ToolStripTextBox_search_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox_search.Click
        If ToolStripTextBox_search.Text = "Search" Or ToolStripTextBox_search.Text = "جستجو" Or ToolStripTextBox_search.Text = "بحث" Or ToolStripTextBox_search.Text = "Buscar" Then
            ToolStripTextBox_search.Text = String.Empty
            ToolStripTextBox_search.ForeColor = Color.Black
        End If
    End Sub
    Private Sub ToolStripTextBox_search_LostFocus(sender As Object, e As EventArgs) Handles ToolStripTextBox_search.LostFocus
        If ToolStripTextBox_search.Text = String.Empty Then
            Select Case My.Settings.Languages
                Case 1
                    ToolStripTextBox_search.Text = "Search"
                Case 2
                    ToolStripTextBox_search.Text = "جستجو"
                Case 3
                    ToolStripTextBox_search.Text = "بحث"
                Case 4
                    ToolStripTextBox_search.Text = "Buscar"
            End Select
            ToolStripTextBox_search.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub ToolStripTextBox_search_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox_search.TextChanged
        If ToolStripTextBox_search.Text = "Search" Or ToolStripTextBox_search.Text = "جستجو" Or ToolStripTextBox_search.Text = "بحث" Or ToolStripTextBox_search.Text = "Buscar" Then
        Else
            Dim SearchQuery As String = ("select * from all_patients where concat(name,lastname,father_name,birth_date,id_code,mobile_number,home_number,gender,height,enroll_date,dr_name,blood_type) like N'%" & ToolStripTextBox_search.Text & "%'")
            Dim command As New SqlCommand(SearchQuery, Public_connect_DataGridView)
            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            data_adapter.Fill(DataTable)

            Integer_DataTable_Rows_Count = DataTable.Rows.Count
            Integer_Row_check = 0
            If Timer_proggress_bar.Enabled = False Then
                Timer_proggress_bar.Enabled = True
            End If

            Main_DataGridView.DataSource = DataTable

            Main_DataGridView.Sort(Main_DataGridView.Columns(12), System.ComponentModel.ListSortDirection.Descending)

            Public_GridColor_Patients(Main_DataGridView)

            If Not ToolStripTextBox_search.Text = String.Empty Then
                For i = 0 To Main_DataGridView.RowCount - 1
                    For b = 0 To 15
                        If InStr(1, Main_DataGridView.Rows(i).Cells(b).Value.ToString, ToolStripTextBox_search.Text.ToString, CompareMethod.Text) > 0 Then
                            Main_DataGridView.Rows(i).Cells(b).Style.BackColor = Color.Aqua
                        End If
                    Next
                Next
            End If
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
    'menu
    Private Sub ToolStripButton_add_patients_Click(sender As Object, e As EventArgs) Handles ToolStripButton_add_patients.Click
        If Not Main_DataGridView.RowCount > 250 Then
            Public_String_Menu_Item = "add"
            Form_add_patient.ShowDialog()
        Else
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("The capacity of patients is full", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("ظرفیت بیماران پر است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("سعة المرضى ممتلئة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("La capacidad de los pacientes está llena.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        End If
    End Sub
    Private Sub ToolStripButton_delete_patients_Click(sender As Object, e As EventArgs) Handles ToolStripButton_delete_patients.Click
        Public_String_Menu_Item = "delete"
        Form_find_ID.ShowDialog()
    End Sub
    Private Sub ToolStripButton_edit_patients_Click(sender As Object, e As EventArgs) Handles ToolStripButton_edit_patients.Click
        Public_String_Menu_Item = "edit"
        Form_find_ID.ShowDialog()
    End Sub

    Private Sub ToolStripButton_backup_Click(sender As Object, e As EventArgs) Handles ToolStripButton_backup.Click
        SaveFileDialog.Filter = "Backup Database SQL|*.bak"
        SaveFileDialog.FileName = "Main_Database " & "(" & DateAndTime.DateString & "    " & Now.TimeOfDay.Hours & "-" & Now.TimeOfDay.Minutes & "-" & Now.TimeOfDay.Seconds & ")"

        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Public_Integer_backup_restore_status = 1

            Form_backup_proccess.ShowDialog()
        End If
    End Sub
    Private Sub ToolStripButton_recovery_Click(sender As Object, e As EventArgs) Handles ToolStripButton_recovery.Click
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Public_Integer_backup_restore_status = 2

            Form_backup_proccess.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton_setting_Click(sender As Object, e As EventArgs) Handles ToolStripButton_setting.Click
        Form_setting.ShowDialog()
    End Sub

    Private Sub ToolStripButton_about_us_Click(sender As Object, e As EventArgs) Handles ToolStripButton_about_us.Click
        Form_about_us.ShowDialog()
    End Sub

    Private Sub ToolStripButton_refresh_Click(sender As Object, e As EventArgs) Handles ToolStripButton_refresh.Click
        StatusStrip_progress_bar.Value = 0
        Refresh_DataGridView()
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
    'timers
    Private Sub Timer_Time_Tick(sender As Object, e As EventArgs) Handles Timer_Time.Tick
        Select Case My.Settings.Data_Mode
            Case 1
                StatusStrip_label_time.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second & " - " & Now.Date.Year & "/" & Now.Date.Month & "/" & Now.Date.Day
            Case 2
                StatusStrip_label_time.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second & " - " & PersianCalendar.GetYear(Now) & "/" & PersianCalendar.GetMonth(Now) & "/" & PersianCalendar.GetDayOfMonth(Now)
            Case 3
                StatusStrip_label_time.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second & " - " & ArabicCalendar.GetYear(Now) & "/" & ArabicCalendar.GetMonth(Now) & "/" & ArabicCalendar.GetDayOfMonth(Now)
        End Select
    End Sub

    Private Sub Timer_proggress_bar_Tick(sender As Object, e As EventArgs) Handles Timer_proggress_bar.Tick
        If StatusStrip_label_percent.Text = "100%" Then
            StatusStrip_progress_bar.Value = 0
        End If

        If Integer_Row_check < Main_DataGridView.RowCount Or Main_DataGridView.RowCount = 0 Then
            If Main_DataGridView.RowCount = Integer_DataTable_Rows_Count Then
                StatusStrip_progress_bar.Value = 100
                Timer_proggress_bar.Enabled = False
            Else
                StatusStrip_progress_bar.Value = Main_DataGridView.RowCount * Integer_Row_count
            End If
        End If

        StatusStrip_label_percent.Text = StatusStrip_progress_bar.Value & "%"
        Integer_Row_check = Main_DataGridView.RowCount
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
    'SerialPort
    Dim Persian_Text As String
    Dim Persian_Hex As String
    Dim Persian_Hex_S As Byte
    Private Sub Persian_Letters()
        Persian_Hex = ""
        Select Case Mid(Persian_Text, Persian_Hex_S, 1)
            Case "ا"
                Persian_Hex = &HC7
            Case "آ"
                Persian_Hex = &HC2
            Case "ب"
                Persian_Hex = &HC8
            Case "پ"
                Persian_Hex = &H81
            Case "ت"
                Persian_Hex = &HCA
            Case "ث"
                Persian_Hex = &HCB
            Case "ج"
                Persian_Hex = &HCC
            Case "چ"
                Persian_Hex = &H8D
            Case "ح"
                Persian_Hex = &HCD
            Case "خ"
                Persian_Hex = &HCE
            Case "د"
                Persian_Hex = &HCF
            Case "ذ"
                Persian_Hex = &HD0
            Case "ر"
                Persian_Hex = &HD1
            Case "ز"
                Persian_Hex = &HD2
            Case "ژ"
                Persian_Hex = &H8E
            Case "س"
                Persian_Hex = &HD3
            Case "ش"
                Persian_Hex = &HD4
            Case "ص"
                Persian_Hex = &HD5
            Case "ض"
                Persian_Hex = &HD6
            Case "ط"
                Persian_Hex = &HD8
            Case "ظ"
                Persian_Hex = &HD9
            Case "ع"
                Persian_Hex = &HDA
            Case "غ"
                Persian_Hex = &HDB
            Case "ف"
                Persian_Hex = &HDD
            Case "ق"
                Persian_Hex = &HDE
            Case "ک"
                Persian_Hex = &H98
            Case "گ"
                Persian_Hex = &H90
            Case "ل"
                Persian_Hex = &HE1
            Case "م"
                Persian_Hex = &HE3
            Case "ن"
                Persian_Hex = &HE4
            Case "و"
                Persian_Hex = &HE6
            Case "ه"
                Persian_Hex = &HE5
            Case "ی"
                Persian_Hex = &HED
            Case "ئ"
                Persian_Hex = &HC6
            Case " "
                Persian_Hex = &H20
            Case ":"
                Persian_Hex = &H3A
        End Select
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        String_serial_port = Trim(SerialPort.ReadExisting)
        String_serial_port = String_serial_port.Replace(vbLf, String.Empty)
        String_serial_port = String_serial_port.Replace(vbCr, String.Empty)
        If String_serial_port.Length > 0 Then
            Me.BeginInvoke(New Delegate_Serial(AddressOf SerialPort_read), New Object() {})
        End If
    End Sub
    Public Sub SerialPort_read()
        ListBox_serial_items.Items.Add(String_serial_port)
        Timer_read_serial.Enabled = True
    End Sub
    Private Sub Timer_read_serial_Tick(sender As Object, e As EventArgs) Handles Timer_read_serial.Tick
        Timer_read_serial.Enabled = False

        If ListBox_serial_items.Items.Count > 1 Then
            String_serial_port = String.Empty
            For i = 0 To ListBox_serial_items.Items.Count - 1
                String_serial_port = String_serial_port & ListBox_serial_items.Items(i)
            Next
        End If
        ListBox_serial_items.Items.Clear()

        Select Case Microsoft.VisualBasic.Left(String_serial_port, 1)
            Case "I"
                SerialPort.WriteLine("ok_id")
                String_serial_port = String_serial_port.Replace("I", String.Empty)
                If Not String_serial_port = String.Empty Then
                    Integer_fingerprint = String_serial_port
                    If Form_receive_fingerprint.Visible = True And Public_Integer_Fingerprint_Status = 0 Then
                        Public_String_fingerprint = Convert.ToString(String_serial_port)
                        SerialPort.WriteLine("receive_fingerprint")
                        Fingerprint()
                    Else
                        Integer_record_level = 1
                    End If
                Else
                    If Form_receive_fingerprint.Visible = True And Public_Integer_Fingerprint_Status = 0 Then
                        SerialPort.WriteLine("end")
                    Else
                        SerialPort.WriteLine("not_found")
                    End If
                    Select Case My.Settings.Languages
                        Case 1
                            Message_box = MessageBox.Show("The information sent by the device is not complete" & vbNewLine & "Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 2
                            Message_box = MessageBox.Show("اطلاعات ارسالی توسط دستگاه کامل نیست" & vbNewLine & "لطفا دوباره امتحان کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 3
                            Message_box = MessageBox.Show("المعلومات التي يرسلها الجهاز ليست كاملة" & vbNewLine & "حاول مرة اخرى", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 4
                            Message_box = MessageBox.Show("La información enviada por el dispositivo no está completa" & vbNewLine & "Inténtalo de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Select
                End If
            Case "W"
                String_serial_port = String_serial_port.Replace("W", String.Empty)
                If Not String_serial_port = String.Empty Then
                    Integer_record_level = 2
                Else
                    SerialPort.WriteLine("Resend_Weight")
                    Select Case My.Settings.Languages
                        Case 1
                            Message_box = MessageBox.Show("The information sent by the device is not complete" & vbNewLine & "Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 2
                            Message_box = MessageBox.Show("اطلاعات ارسالی توسط دستگاه کامل نیست" & vbNewLine & "لطفا دوباره امتحان کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 3
                            Message_box = MessageBox.Show("المعلومات التي يرسلها الجهاز ليست كاملة" & vbNewLine & "حاول مرة اخرى", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 4
                            Message_box = MessageBox.Show("La información enviada por el dispositivo no está completa" & vbNewLine & "Inténtalo de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Select
                End If
        End Select
        If String_serial_port = "refresh" Then
            Refresh_DataGridView()
        End If


        Select Case Integer_record_level
            Case 1
                Integer_record_level = 0

                Refresh_DataGridView()

                Dim SearchQuery As String = ("select * from all_patients where fingerprint = " & String_serial_port & "")
                Dim command As New SqlCommand(SearchQuery, Public_connect_DataGridView)
                Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
                Dim DataTable As New DataTable
                data_adapter.Fill(DataTable)
                Main_DataGridView.DataSource = DataTable

                Public_GridColor_Patients(Main_DataGridView)

                If Not DataTable.Rows.Count = 0 Then
                    Public_Integer_ID_save = Integer_fingerprint

                    Select Case My.Settings.Languages
                        Case 1
                            SerialPort.WriteLine("Name")
                            System.Threading.Thread.Sleep(300)
                            SerialPort.WriteLine("Name: " & Main_DataGridView.Rows(0).Cells(2).Value & " " & Main_DataGridView.Rows(0).Cells(3).Value)
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine("NameFather")
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine("Father's name: " & Main_DataGridView.Rows(0).Cells(4).Value)
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine("CodeMeli")
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine("ID code: " & Main_DataGridView.Rows(0).Cells(6).Value)
                        Case 2
                            SerialPort.WriteLine("Name")
                            System.Threading.Thread.Sleep(300)
                            Persian_Text = "نام: " & Main_DataGridView.Rows(0).Cells(2).Value & " " & Main_DataGridView.Rows(0).Cells(3).Value
                            System.Threading.Thread.Sleep(200)
                            For i = 1 To Persian_Text.Length
                                Persian_Hex_S = i
                                Persian_Letters()
                                SerialPort.Write(New Byte() {Persian_Hex}, 0, 1)
                            Next
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine(vbCrLf & "NameFather")
                            System.Threading.Thread.Sleep(200)
                            Persian_Text = "نام پدر: " & Main_DataGridView.Rows(0).Cells(4).Value
                            System.Threading.Thread.Sleep(200)
                            For i = 1 To Persian_Text.Length
                                Persian_Hex_S = i
                                Persian_Letters()
                                SerialPort.Write(New Byte() {Persian_Hex}, 0, 1)
                            Next
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine(vbCrLf & "CodeMeli")
                            System.Threading.Thread.Sleep(200)
                            Persian_Text = "ش ملی: "
                            System.Threading.Thread.Sleep(200)
                            For i = 1 To Persian_Text.Length
                                Persian_Hex_S = i
                                Persian_Letters()
                                SerialPort.Write(New Byte() {Persian_Hex}, 0, 1)
                            Next
                            SerialPort.WriteLine(Main_DataGridView.Rows(0).Cells(6).Value)
                        Case 3
                            SerialPort.WriteLine("Name")
                            System.Threading.Thread.Sleep(300)
                            Persian_Text = "اسم: " & Main_DataGridView.Rows(0).Cells(2).Value & " " & Main_DataGridView.Rows(0).Cells(3).Value
                            System.Threading.Thread.Sleep(200)
                            For i = 1 To Persian_Text.Length
                                Persian_Hex_S = i
                                Persian_Letters()
                                SerialPort.Write(New Byte() {Persian_Hex}, 0, 1)
                            Next
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine(vbCrLf & "NameFather")
                            System.Threading.Thread.Sleep(200)
                            Persian_Text = "اسم الاب: " & Main_DataGridView.Rows(0).Cells(4).Value
                            System.Threading.Thread.Sleep(200)
                            For i = 1 To Persian_Text.Length
                                Persian_Hex_S = i
                                Persian_Letters()
                                SerialPort.Write(New Byte() {Persian_Hex}, 0, 1)
                            Next
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine(vbCrLf & "CodeMeli")
                            System.Threading.Thread.Sleep(200)
                            Persian_Text = "ر دولی: "
                            System.Threading.Thread.Sleep(200)
                            For i = 1 To Persian_Text.Length
                                Persian_Hex_S = i
                                Persian_Letters()
                                SerialPort.Write(New Byte() {Persian_Hex}, 0, 1)
                            Next
                            SerialPort.WriteLine(Main_DataGridView.Rows(0).Cells(6).Value)
                        Case 4
                            SerialPort.WriteLine("Name")
                            System.Threading.Thread.Sleep(300)
                            SerialPort.WriteLine("Nombre: " & Main_DataGridView.Rows(0).Cells(2).Value & " " & Main_DataGridView.Rows(0).Cells(3).Value)
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine("NameFather")
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine("Nombre del Padre: " & Main_DataGridView.Rows(0).Cells(4).Value)
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine("CodeMeli")
                            System.Threading.Thread.Sleep(200)
                            SerialPort.WriteLine("Código de identificación: " & Main_DataGridView.Rows(0).Cells(6).Value)
                    End Select

                    For i = 0 To Main_DataGridView.Rows(Main_DataGridView.RowCount - 1).Cells.Count - 1
                        Main_DataGridView.Rows(Main_DataGridView.RowCount - 1).Cells(i).Style.BackColor = Color.LightGreen
                    Next

                    Refresh_dialysis()
                    Get_patient_information()
                Else
                    SerialPort.WriteLine("not_found")
                    Refresh_DataGridView()
                End If
            Case 2
                Integer_record_level = 0

                String_weight = String_serial_port

                Select Case My.Settings.Languages
                    Case 1
                        If Now.Date.Month < 10 Or Now.Date.Day < 10 Then
                            If Now.Date.Month < 10 Then
                                Date_transfor_month = "0" & Now.Date.Month
                            Else
                                Date_transfor_month = Now.Date.Month
                            End If
                            If Now.Date.Day < 10 Then
                                Date_transfor_day = "0" & Now.Date.Day
                            Else
                                Date_transfor_day = Now.Date.Day
                            End If
                            String_date = Now.Date.Year & "/" & Date_transfor_month & "/" & Date_transfor_day
                        Else
                            String_date = Now.Date.Year & "/" & Now.Date.Month & "/" & Now.Date.Day
                        End If
                    Case 2
                        String_date = PersianDate(Now.Date)
                    Case 3
                        String_date = ArabicDate(Now.Date)
                    Case 4
                        If Now.Date.Month < 10 Or Now.Date.Day < 10 Then
                            If Now.Date.Month < 10 Then
                                Date_transfor_month = "0" & Now.Date.Month
                            Else
                                Date_transfor_month = Now.Date.Month
                            End If
                            If Now.Date.Day < 10 Then
                                Date_transfor_day = "0" & Now.Date.Day
                            Else
                                Date_transfor_day = Now.Date.Day
                            End If
                            String_date = Now.Date.Year & "/" & Date_transfor_month & "/" & Date_transfor_day
                        Else
                            String_date = Now.Date.Year & "/" & Now.Date.Month & "/" & Now.Date.Day
                        End If
                End Select

                Public_Integer_ID_save = Integer_fingerprint

                Refresh_dialysis()

                If Not Form_show_patient_database.Main_DataGridView.RowCount = 0 Then
                    Time_1 = Now.TimeOfDay.ToString
                    Time_2 = Form_show_patient_database.Main_DataGridView.Rows(0).Cells(2).Value.ToString

                    If Form_show_patient_database.Main_DataGridView.Rows(0).Cells(5).Value.ToString = "0" Then
                        Public_Integer_D_N_save = Form_show_patient_database.Main_DataGridView.Rows(0).Cells(0).Value

                        Dim Data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From setting", Public_connect_DataGridView)
                        Dim DataTable As New DataTable
                        Data_adapter.Fill(DataTable)

                        If Not DateDiff(DateInterval.Minute, Time_2, Time_1) / 60 > DataTable.Rows(0).Item(4) Then
                            Edit_dialysis()

                            SerialPort.WriteLine("edit_dialysis")
                        Else
                            Delete_dialysis()

                            Add_dialysis()

                            SerialPort.WriteLine("add_dialysis")
                        End If
                    Else
                        Add_dialysis()

                        SerialPort.WriteLine("add_dialysis")
                    End If
                Else
                    Add_dialysis()

                    SerialPort.WriteLine("add_dialysis")
                End If

                Refresh_DataGridView()
                Refresh_dialysis()
                Get_patient_information()
        End Select

        SerialPort.DiscardInBuffer()
        SerialPort.DiscardOutBuffer()
    End Sub

    Sub Get_patient_information()
        Get_image()
        For i = 0 To Main_DataGridView.RowCount - 1
            If Public_Integer_ID_save = Main_DataGridView.Rows(i).Cells(0).Value Then
                Form_show_patient_database.Label_name.Text = Main_DataGridView.Rows(i).Cells(2).Value & " " & Main_DataGridView.Rows(i).Cells(3).Value
                Form_show_patient_database.Label_blood_type.Text = Main_DataGridView.Rows(i).Cells(14).Value
                Exit For
            End If
        Next
    End Sub
    Sub Refresh_dialysis()
        Dim Data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From Table_" & Public_Integer_ID_save & "", Public_connect_DataGridView)
        Dim DataTable As New DataTable
        Data_adapter.Fill(DataTable)
        Form_show_patient_database.Main_DataGridView.DataSource = DataTable
        Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    Sub Add_dialysis()
        Dim insert As String = "insert into Table_" & Public_Integer_ID_save & "(enter_date,enter_time,enter_weight,enter_bmi,exit_date,exit_time,exit_weight,exit_bmi,nurse) values ('" & String_date & "','" & Now.TimeOfDay.Hours & ":" & Now.TimeOfDay.Minutes & "','" & String_weight & "','" & Math.Round(String_weight / (Main_DataGridView.CurrentRow.Cells(10).Value * Main_DataGridView.CurrentRow.Cells(10).Value), decimals:=2) & "','" & "0" & "','" & "0" & "','" & "0" & "' ,'" & "0" & "',N'" & StatusStrip_label_entered_person_name.Text & "')"
        Dim Run As SqlCommand = New SqlCommand(insert, Public_connect_DataGridView)
        Public_connect_DataGridView.Open()
        Run.ExecuteNonQuery()
        Public_connect_DataGridView.Close()
    End Sub
    Sub Delete_dialysis()
        Dim Delete As String = "Delete from Table_" & Public_Integer_ID_save & " where id=" & Public_Integer_D_N_save
        Dim Run As SqlCommand = New SqlCommand(Delete, Public_connect_DataGridView)
        Public_connect_DataGridView.Open()
        Run.ExecuteNonQuery()
        Public_connect_DataGridView.Close()
    End Sub
    Sub Edit_dialysis()
        Dim edit As String = "update Table_" & Public_Integer_ID_save & " set exit_date='" & String_date & "',exit_time='" & Now.TimeOfDay.Hours & ":" & Now.TimeOfDay.Minutes & "',exit_weight='" & String_weight & "',exit_bmi='" & Math.Round(String_weight / (Main_DataGridView.CurrentRow.Cells(10).Value * Main_DataGridView.CurrentRow.Cells(10).Value), decimals:=2) & "',nurse=N'" & StatusStrip_label_entered_person_name.Text & "' where id=" & Public_Integer_D_N_save
        Dim Run As SqlCommand = New SqlCommand(edit, Public_connect_DataGridView)
        Public_connect_DataGridView.Open()
        Run.ExecuteNonQuery()
        Public_connect_DataGridView.Close()
    End Sub
End Class

