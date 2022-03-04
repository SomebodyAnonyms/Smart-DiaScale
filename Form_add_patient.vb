Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO

Public Class Form_add_patient
    Dim String_gender As String
    Dim String_date As String
    Dim String_form_status As String
    Dim Date_transfor_month As String
    Dim Date_transfor_day As String
    Dim String_File_Name As String

    Dim Row_number As Integer
    Dim Row_compare As Integer
    Dim Integer_patient_image_status As Integer

    Private Sub add_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public_Integer_Fingerprint_Status = 0
        Integer_patient_image_status = 0

        String_form_status = "cancel"

        Public_String_fingerprint = 0

        Public_Determine_Form = "Form_add_patient"
        Public_Determine_Languages()

        Select Case My.Settings.Languages
            Case 1 Or 4
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
                    MaskedTextBox_enroll_date.Text = Now.Date.Year & Date_transfor_month & Date_transfor_day
                Else
                    MaskedTextBox_enroll_date.Text = Now.Date.Year & Now.Date.Month & Now.Date.Day
                End If
            Case 2
                MaskedTextBox_enroll_date.Text = PersianDate(Now.Date)
            Case 3
                MaskedTextBox_enroll_date.Text = ArabicDate(Now.Date)
        End Select

        RadioButton_female.Location = New Point(RadioButton_male.Location.X + RadioButton_male.Size.Width + 3, RadioButton_male.Location.Y)
    End Sub
    Private Sub Form_add_patient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not String_form_status = "add" Then
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Are you sure want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Case 2
                    Message_box = MessageBox.Show("آیا از کنسل کردن مطمئن هستید؟", "کنسل", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Case 3
                    Message_box = MessageBox.Show("هل أنت متأكد أنك تريد إلغاء؟", "إلغاء", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Case 4
                    Message_box = MessageBox.Show("¿Seguro que quieres cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            End Select

            If Message_box = DialogResult.Yes Then
                TextBox_name.Text = String.Empty
                TextBox_lastname.Text = String.Empty
                TextBox_father_name.Text = String.Empty
                MaskedTextBox_birth_date.Text = String.Empty
                MaskedTextBox_id_code.Text = String.Empty
                MaskedTextBox_mobile_number.Text = String.Empty
                MaskedTextBox_home_number.Text = String.Empty
                MaskedTextBox_enroll_date.Text = String.Empty
                NumericUpDown_hieght.Value = 1.7
                RadioButton_male.Checked = False
                RadioButton_female.Checked = False
                String_gender = String.Empty
                TextBox_dr_name.Text = String.Empty
                ComboBox_blood_type.Text = ComboBox_blood_type.Items(0)
                ComboBox_shift.Text = ComboBox_shift.Items(0)
                PictureBox_patient_image.Image = Global.Smart_DiaScale_I.My.Resources.add_patient_image
                PictureBox_fingerprint.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.fingerprint
                PictureBox_delete_image.Visible = False
                Public_String_fingerprint = 0

                TextBox_name.BackColor = Color.White
                TextBox_lastname.BackColor = Color.White
                TextBox_father_name.BackColor = Color.White
                MaskedTextBox_birth_date.BackColor = Color.White
                MaskedTextBox_id_code.BackColor = Color.White
                MaskedTextBox_mobile_number.BackColor = Color.White
                MaskedTextBox_enroll_date.BackColor = Color.White
                RadioButton_male.ForeColor = Color.Black
                RadioButton_female.ForeColor = Color.Black
                TextBox_dr_name.BackColor = Color.White
                ComboBox_blood_type.BackColor = Color.Silver
                ComboBox_shift.BackColor = Color.Silver
                Label_fingerprint_status.ForeColor = Color.Black

                Form_main.StatusStrip_progress_bar.Value = 0

                Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From all_patients", Public_connect_DataGridView)
                Dim DataTable As New DataTable
                data_adapter.Fill(DataTable)
                Form_main.Main_DataGridView.DataSource = DataTable

                Public_GridColor_Patients(Form_main.Main_DataGridView)

                Form_main.Main_DataGridView.Sort(Form_main.Main_DataGridView.Columns(12), System.ComponentModel.ListSortDirection.Descending)

                Select Case My.Settings.Languages
                    Case 1
                        Form_main.ToolStripTextBox_search.Text = "Search"
                    Case 2
                        Form_main.ToolStripTextBox_search.Text = "جستجو"
                    Case 3
                        Form_main.ToolStripTextBox_search.Text = "بحث"
                    Case 4
                        Form_main.ToolStripTextBox_search.Text = "Buscar"
                End Select
                Form_main.ToolStripTextBox_search.ForeColor = Color.Gray

                If Public_Integer_Fingerprint_Status = 1 Then
                    If Form_main.SerialPort.IsOpen = True Then
                        Form_main.SerialPort.WriteLine("end")
                    End If
                End If
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Function ImageToStream(ByVal fileName As String) As Byte()
        Dim stream As New MemoryStream()
        Dim Bitmap As New Bitmap(fileName)
        Bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
        Return stream.ToArray()
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
    'Key Control
    Private Sub TextBox_name_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_name.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_lastname_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_lastname.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_father_name_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_father_name.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_dr_name_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_dr_name.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_birth_date_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_birth_date.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_id_code_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_id_code.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_mobile_number_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_mobile_number.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_home_number_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_home_number.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub NumericUpDown_hieght_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown_hieght.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_enroll_date_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_enroll_date.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub ComboBox_blood_type_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox_blood_type.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub ComboBox_shift_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox_shift.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub RadioButton_female_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton_female.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub RadioButton_male_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton_male.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_add_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_add.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_cancell_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_cancell.KeyDown
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
    'objects
    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        If TextBox_name.Text = String.Empty Or TextBox_lastname.Text = String.Empty Or TextBox_father_name.Text = String.Empty Or MaskedTextBox_birth_date.Text = "    /  /" Or MaskedTextBox_id_code.Text = "" Or MaskedTextBox_mobile_number.Text = "" Or String_gender = String.Empty Or MaskedTextBox_enroll_date.Text = "    /  /" Or TextBox_dr_name.Text = String.Empty Or ComboBox_blood_type.Text = String.Empty Or ComboBox_shift.Text = String.Empty Then
            If TextBox_name.Text = String.Empty Then TextBox_name.BackColor = Color.Red
            If TextBox_lastname.Text = String.Empty Then TextBox_lastname.BackColor = Color.Red
            If TextBox_father_name.Text = String.Empty Then TextBox_father_name.BackColor = Color.Red
            If MaskedTextBox_birth_date.Text = "    /  /" Then MaskedTextBox_birth_date.BackColor = Color.Red
            If MaskedTextBox_id_code.Text = "" Then MaskedTextBox_id_code.BackColor = Color.Red
            If MaskedTextBox_mobile_number.Text = "" Then MaskedTextBox_mobile_number.BackColor = Color.Red
            If MaskedTextBox_enroll_date.Text = "    /  /" Then MaskedTextBox_enroll_date.BackColor = Color.Red
            If String_gender = String.Empty Then
                RadioButton_male.ForeColor = Color.Red
                RadioButton_female.ForeColor = Color.Red
            End If
            If TextBox_dr_name.Text = String.Empty Then TextBox_dr_name.BackColor = Color.Red
            If ComboBox_blood_type.Text = String.Empty Then ComboBox_blood_type.BackColor = Color.Red
            If ComboBox_shift.Text = String.Empty Then ComboBox_shift.BackColor = Color.Red

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
            Dim searchQuery As String = ("select * from all_patients where id_code = N'" & MaskedTextBox_id_code.Text & "'")
            Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
            Dim data_adapter_1 As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable_1 As New DataTable
            data_adapter_1.Fill(DataTable_1)

            If Not DataTable_1.Rows.Count = 0 Then
                Select Case My.Settings.Languages
                    Case 1
                        Message_box = MessageBox.Show("A person with this ID code has already been registered", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 2
                        Message_box = MessageBox.Show("شخصی با این کد ملی قبلا ثبت شده است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 3
                        Message_box = MessageBox.Show("تم تسجيل شخص يحمل هذا الرمز الوطني بالفعل", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 4
                        Message_box = MessageBox.Show("Ya se ha registrado una persona con este código de identificación", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                Select Case My.Settings.Languages
                    Case 1
                        Message_box = MessageBox.Show("Are you sure the information is correct?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    Case 2
                        Message_box = MessageBox.Show("آیا از صحت اطلاعات اطمینان دارید؟", "افزودن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    Case 3
                        Message_box = MessageBox.Show("هل أنت متأكد من صحة المعلومات؟", "أضف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    Case 4
                        Message_box = MessageBox.Show("¿Estás seguro de que la información es correcta?", "Añadir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                End Select


                If Message_box = DialogResult.Yes Then
                    String_form_status = "add"

                    Form_main.Main_DataGridView.Sort(Form_main.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

                    If Not Form_main.Main_DataGridView.RowCount = 0 Then
                        For i = 0 To Form_main.Main_DataGridView.RowCount - 1
                            If Form_main.Main_DataGridView.Rows(i).Cells(0).Value = i + 1 Then
                                If i + 1 <= Form_main.Main_DataGridView.RowCount - 1 Then
                                    If Form_main.Main_DataGridView.Rows(i + 1).Cells(0).Value - Form_main.Main_DataGridView.Rows(i).Cells(0).Value > 1 Then
                                        Row_number = i + 2
                                        Exit For
                                    End If
                                Else
                                    Row_number = i + 2
                                    Exit For
                                End If
                            Else
                                Row_number = i + 1
                                Exit For
                            End If
                        Next
                    Else
                        Row_number = 1
                    End If

                    If Integer_patient_image_status = 0 Then
                        If RadioButton_male.Checked = True Then
                            String_File_Name = My.Application.Info.DirectoryPath & "\man.png"
                            Dim Bitmap As New Bitmap(Global.Smart_DiaScale_I.My.Resources.man)
                            If Not IsNothing(PictureBox_patient_image.Image) Then PictureBox_patient_image.Image.Dispose()
                            PictureBox_patient_image.Image = Bitmap
                        Else
                            String_File_Name = My.Application.Info.DirectoryPath & "\woman.png"
                            Dim Bitmap As New Bitmap(Global.Smart_DiaScale_I.My.Resources.woman)
                            If Not IsNothing(PictureBox_patient_image.Image) Then PictureBox_patient_image.Image.Dispose()
                            PictureBox_patient_image.Image = Bitmap
                        End If
                    End If
                    Dim content As Byte() = ImageToStream(String_File_Name)
                    Dim insert As String = "insert into all_patients(id,image,name,lastname,father_name,birth_date,id_code,mobile_number,home_number,gender,height,fingerprint,enroll_date,dr_name,blood_type,shift) values (" & Row_number & ",@image,N'" & TextBox_name.Text & "',N'" & TextBox_lastname.Text & "',N'" & TextBox_father_name.Text & "',N'" & MaskedTextBox_birth_date.Text & "',N'" & MaskedTextBox_id_code.Text & "',N'" & MaskedTextBox_mobile_number.Text & "',N'" & MaskedTextBox_home_number.Text & "',N'" & String_gender & "',N'" & NumericUpDown_hieght.Text & "'," & Public_String_fingerprint & ",N'" & MaskedTextBox_enroll_date.Text & "',N'" & TextBox_dr_name.Text & "',N'" & ComboBox_blood_type.Text & "',N'" & Microsoft.VisualBasic.Left(ComboBox_shift.Text, 1) & "')"
                    Dim Run As SqlCommand = New SqlCommand(insert, Public_connect_DataGridView)
                    Run.Parameters.AddWithValue("@image", content)
                    Public_connect_DataGridView.Open()
                    Run.ExecuteNonQuery()
                    Public_connect_DataGridView.Close()

                    Me.Close()

                    Form_main.StatusStrip_progress_bar.Value = 0

                    Dim data_adapter_2 As SqlDataAdapter = New SqlDataAdapter("SELECT * From all_patients", Public_connect_DataGridView)
                    Dim DataTable_2 As New DataTable
                    data_adapter_2.Fill(DataTable_2)
                    Form_main.Main_DataGridView.DataSource = DataTable_2

                    Public_GridColor_Patients(Form_main.Main_DataGridView)

                    Form_main.Main_DataGridView.Sort(Form_main.Main_DataGridView.Columns(12), System.ComponentModel.ListSortDirection.Descending)

                    Select Case My.Settings.Languages
                        Case 1
                            Form_main.ToolStripTextBox_search.Text = "Search"
                        Case 2
                            Form_main.ToolStripTextBox_search.Text = "جستجو"
                        Case 3
                            Form_main.ToolStripTextBox_search.Text = "بحث"
                        Case 4
                            Form_main.ToolStripTextBox_search.Text = "Buscar"
                    End Select
                    Form_main.ToolStripTextBox_search.ForeColor = Color.Gray

                    For i = 0 To Form_main.Main_DataGridView.RowCount - 1
                        If Row_number = Form_main.Main_DataGridView.Rows(i).Cells(0).Value Then
                            For b = 0 To Form_main.Main_DataGridView.Rows(0).Cells.Count - 1
                                Form_main.Main_DataGridView.Rows(i).Cells(b).Style.BackColor = Color.LightGreen
                            Next
                            Exit For
                        End If
                    Next

                    Dim Create As String = "CREATE TABLE Table_" & Row_number & " ([Id] INT NOT NULL PRIMARY KEY IDENTITY, [enter_date] VARCHAR(10) NULL, [enter_time] VARCHAR(8) NULL, [enter_weight] NVARCHAR(8) NULL, [enter_bmi] NVARCHAR(8) NULL, [exit_date] VARCHAR(10) NULL, [exit_time] VARCHAR(8) NULL, [exit_weight] NVARCHAR(8) NULL, [exit_bmi] NVARCHAR(8) NULL, [nurse] NVARCHAR(50) NULL)"
                    Dim SqlCommand As SqlCommand = New SqlCommand(Create, Public_connect_DataGridView)
                    Public_connect_DataGridView.Open()
                    SqlCommand.ExecuteNonQuery()
                    Public_connect_DataGridView.Close()

                    TextBox_name.Text = String.Empty
                    TextBox_lastname.Text = String.Empty
                    TextBox_father_name.Text = String.Empty
                    MaskedTextBox_birth_date.Text = String.Empty
                    MaskedTextBox_id_code.Text = String.Empty
                    MaskedTextBox_mobile_number.Text = String.Empty
                    MaskedTextBox_home_number.Text = String.Empty
                    MaskedTextBox_enroll_date.Text = String.Empty
                    NumericUpDown_hieght.Value = 1.7
                    RadioButton_male.Checked = False
                    RadioButton_female.Checked = False
                    String_gender = String.Empty
                    TextBox_dr_name.Text = String.Empty
                    ComboBox_blood_type.Text = ComboBox_blood_type.Items(0)
                    ComboBox_shift.Text = ComboBox_shift.Items(0)
                    PictureBox_patient_image.Image = Global.Smart_DiaScale_I.My.Resources.add_patient_image
                    PictureBox_fingerprint.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.fingerprint
                    Public_String_fingerprint = 0
                End If
            End If
        End If
    End Sub
    Private Sub Button_add_MouseEnter(sender As Object, e As EventArgs) Handles Button_add.MouseEnter
        Button_add.FlatAppearance.BorderSize = 1
        Button_add.BackColor = Color.AliceBlue
    End Sub
    Private Sub Button_add_MouseLeave(sender As Object, e As EventArgs) Handles Button_add.MouseLeave
        Button_add.FlatAppearance.BorderSize = 2
        Button_add.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button_cancell_Click(sender As Object, e As EventArgs) Handles Button_cancell.Click
        String_form_status = "cancel"
        Me.Close()
    End Sub
    Private Sub Button_cancell_MouseEnter(sender As Object, e As EventArgs) Handles Button_cancell.MouseEnter
        Button_cancell.BackColor = Color.AliceBlue
        Button_cancell.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
    End Sub
    Private Sub Button_cancell_MouseLeave(sender As Object, e As EventArgs) Handles Button_cancell.MouseLeave
        Button_cancell.BackColor = Color.Gainsboro
        Button_cancell.FlatAppearance.BorderColor = Color.Gray
    End Sub


    Private Sub RadioButton_male_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_male.CheckedChanged
        If RadioButton_male.Checked = True Then
            Select Case My.Settings.Languages
                Case 1
                    String_gender = "Male"
                Case 2
                    String_gender = "مرد"
                Case 3
                    String_gender = "رجل"
                Case 4
                    String_gender = "Masculino"
            End Select
        End If
    End Sub
    Private Sub RadioButton_female_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_female.CheckedChanged
        If RadioButton_female.Checked = True Then
            Select Case My.Settings.Languages
                Case 1
                    String_gender = "Female"
                Case 2
                    String_gender = "زن"
                Case 3
                    String_gender = "أنثى"
                Case 4
                    String_gender = "Hembra"
            End Select
        End If
    End Sub


    Private Sub TextBox_name_GotFocus(sender As Object, e As EventArgs) Handles TextBox_name.GotFocus
        TextBox_name.BackColor = Color.White
    End Sub
    Private Sub TextBox_lastname_GotFocus(sender As Object, e As EventArgs) Handles TextBox_lastname.GotFocus
        TextBox_lastname.BackColor = Color.White
    End Sub
    Private Sub TextBox_father_name_GotFocus(sender As Object, e As EventArgs) Handles TextBox_father_name.GotFocus
        TextBox_father_name.BackColor = Color.White
    End Sub
    Private Sub MaskedTextBox_birth_date_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_birth_date.GotFocus
        MaskedTextBox_birth_date.BackColor = Color.White
    End Sub
    Private Sub MaskedTextBox_id_code_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_id_code.GotFocus
        MaskedTextBox_id_code.BackColor = Color.White
    End Sub
    Private Sub MaskedTextBox_mobile_number_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_mobile_number.GotFocus
        MaskedTextBox_mobile_number.BackColor = Color.White
    End Sub
    Private Sub MaskedTextBox_enroll_date_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_enroll_date.GotFocus
        MaskedTextBox_enroll_date.BackColor = Color.White
    End Sub
    Private Sub TextBox_dr_name_GotFocus(sender As Object, e As EventArgs) Handles TextBox_dr_name.GotFocus
        TextBox_dr_name.BackColor = Color.White
    End Sub
    Private Sub ComboBox_blood_type_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_blood_type.GotFocus
        ComboBox_blood_type.BackColor = Color.Silver
    End Sub
    Private Sub ComboBox_shift_GotFocus(sender As Object, e As EventArgs) Handles ComboBox_shift.GotFocus
        ComboBox_shift.BackColor = Color.Silver
    End Sub
    Private Sub RadioButton_male_GotFocus(sender As Object, e As EventArgs) Handles RadioButton_male.GotFocus
        RadioButton_male.ForeColor = Color.Black
        RadioButton_female.ForeColor = Color.Black
    End Sub
    Private Sub RadioButton_female_GotFocus(sender As Object, e As EventArgs) Handles RadioButton_female.GotFocus
        RadioButton_male.ForeColor = Color.Black
        RadioButton_female.ForeColor = Color.Black
    End Sub


    Private Sub PictureBox_fingerprint_Click(sender As Object, e As EventArgs) Handles PictureBox_fingerprint.Click
        Label_fingerprint_status.ForeColor = Color.Black
        Form_receive_fingerprint.ShowDialog()
    End Sub
    Private Sub PictureBox_fingerprint_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_fingerprint.MouseEnter
        PictureBox_fingerprint.Size = New Size(PictureBox_fingerprint.Size.Width + 3, PictureBox_fingerprint.Size.Height + 3)
        PictureBox_fingerprint.Location = New Point(PictureBox_fingerprint.Location.X - 1.5, PictureBox_fingerprint.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_fingerprint_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_fingerprint.MouseLeave
        PictureBox_fingerprint.Size = New Size(PictureBox_fingerprint.Size.Width - 3, PictureBox_fingerprint.Size.Height - 3)
        PictureBox_fingerprint.Location = New Point(PictureBox_fingerprint.Location.X + 1.5, PictureBox_fingerprint.Location.Y + 1.5)
    End Sub


    Private Sub PictureBox_patient_image_Click(sender As Object, e As EventArgs) Handles PictureBox_patient_image.Click
        OpenFileDialog.Filter = "PNG|*.png|JPEG|*.jpg"
        OpenFileDialog.FileName = String.Empty
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            String_File_Name = OpenFileDialog.FileName
            Dim Bitmap As New Bitmap(OpenFileDialog.FileName)
            If Not IsNothing(PictureBox_patient_image.Image) Then PictureBox_patient_image.Image.Dispose()
            PictureBox_patient_image.Image = Bitmap
            Integer_patient_image_status = 1
            PictureBox_delete_image.Visible = True
        End If
    End Sub
    Private Sub PictureBox_patient_image_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_patient_image.MouseEnter
        PictureBox_patient_image.Size = New Size(PictureBox_patient_image.Size.Width + 3, PictureBox_patient_image.Size.Height + 3)
        PictureBox_patient_image.Location = New Point(PictureBox_patient_image.Location.X - 1.5, PictureBox_patient_image.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_patient_image_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_patient_image.MouseLeave
        PictureBox_patient_image.Size = New Size(PictureBox_patient_image.Size.Width - 3, PictureBox_patient_image.Size.Height - 3)
        PictureBox_patient_image.Location = New Point(PictureBox_patient_image.Location.X + 1.5, PictureBox_patient_image.Location.Y + 1.5)
    End Sub

    Private Sub PictureBox_delete_image_Click(sender As Object, e As EventArgs) Handles PictureBox_delete_image.Click
        PictureBox_patient_image.Image = Global.Smart_DiaScale_I.My.Resources.add_patient_image
        Integer_patient_image_status = 0
        PictureBox_delete_image.Visible = False
    End Sub
    Private Sub PictureBox_delete_image_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_delete_image.MouseEnter
        PictureBox_delete_image.Size = New Size(PictureBox_delete_image.Size.Width + 3, PictureBox_delete_image.Size.Height + 3)
        PictureBox_delete_image.Location = New Point(PictureBox_delete_image.Location.X - 1.5, PictureBox_delete_image.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_delete_image_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_delete_image.MouseLeave
        PictureBox_delete_image.Size = New Size(PictureBox_delete_image.Size.Width - 3, PictureBox_delete_image.Size.Height - 3)
        PictureBox_delete_image.Location = New Point(PictureBox_delete_image.Location.X + 1.5, PictureBox_delete_image.Location.Y + 1.5)
    End Sub
End Class