Imports System.Data.SqlClient

Public Class Form_receive_fingerprint
    Dim Row_number As Integer

    Private Sub Form_receive_fingerprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox_fingerprint_change.Visible = False
        PictureBox_fingerprint_scan.Visible = False
        ProgressBar_fingerprint.Visible = False
        Label_percent.Visible = False

        If Public_Integer_Fingerprint_Status = 1 Then
            PictureBox_fingerprint_change.Visible = True

            Public_Determine_Form = "Form_receive_fingerprint"
            Public_Determine_Languages()
        Else
            If Form_main.SerialPort.IsOpen = True Then
                Form_main.SerialPort.WriteLine("ready_to_receive_fingerprint")
                Select Case Public_String_Menu_Item
                    Case "add"
                        Form_main.StatusStrip_progress_bar.Value = 0

                        Dim data_adapter_2 As SqlDataAdapter = New SqlDataAdapter("SELECT * From all_patients", Public_connect_DataGridView)
                        Dim DataTable_2 As New DataTable
                        data_adapter_2.Fill(DataTable_2)
                        Form_main.Main_DataGridView.DataSource = DataTable_2

                        Public_GridColor_Patients(Form_main.Main_DataGridView)

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
                        Form_main.SerialPort.WriteLine(Row_number)

                        Form_main.Main_DataGridView.Sort(Form_main.Main_DataGridView.Columns(12), System.ComponentModel.ListSortDirection.Descending)
                    Case "edit"
                        Form_main.SerialPort.WriteLine(Form_main.Main_DataGridView.Rows(0).Cells(0).Value)
                End Select


            End If


            PictureBox_fingerprint_scan.Visible = True
            ProgressBar_fingerprint.Visible = True
            Label_percent.Visible = True

            Public_Determine_Form = "Form_receive_fingerprint"
            Public_Determine_Languages()

            ProgressBar_fingerprint.Value = 0
            Label_percent.Text = "0%"
            Label_percent.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        End If
    End Sub
    Private Sub Form_receive_fingerprint_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Public_Integer_Fingerprint_Status = 0 Then
            If Form_main.SerialPort.IsOpen = True Then
                Form_main.SerialPort.WriteLine("end")
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
    'Key Control
    Private Sub Form_receive_fingerprint_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If Public_Integer_Fingerprint_Status = 1 Then
                    Select Case My.Settings.Languages
                        Case 1
                            Message_box = MessageBox.Show("Are you sure you want to change the fingerprint?", "Change fingerprint", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        Case 2
                            Message_box = MessageBox.Show("آیا از تغییر اثر انگشت اطمینان دارید؟", "تغییر اثر انگشت", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        Case 3
                            Message_box = MessageBox.Show("هل أنت متأكد أنك تريد تغيير البصمة؟", "تغيير بصمة الإصبع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        Case 4
                            Message_box = MessageBox.Show("¿Estás seguro de que quieres cambiar la huella digital?", "Cambiar huella digital", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    End Select


                    If Message_box = DialogResult.Yes Then
                        If Form_main.SerialPort.IsOpen = True Then
                            Form_main.SerialPort.WriteLine("ready_to_receive_fingerprint")
                            Select Case Public_String_Menu_Item
                                Case "add"
                                    Form_main.StatusStrip_progress_bar.Value = 0

                                    Dim data_adapter_2 As SqlDataAdapter = New SqlDataAdapter("SELECT * From all_patients", Public_connect_DataGridView)
                                    Dim DataTable_2 As New DataTable
                                    data_adapter_2.Fill(DataTable_2)
                                    Form_main.Main_DataGridView.DataSource = DataTable_2

                                    Public_GridColor_Patients(Form_main.Main_DataGridView)

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
                                    Form_main.SerialPort.WriteLine(Row_number)

                                    Form_main.Main_DataGridView.Sort(Form_main.Main_DataGridView.Columns(12), System.ComponentModel.ListSortDirection.Descending)
                                Case "edit"
                                    Form_main.SerialPort.WriteLine(Form_main.Main_DataGridView.Rows(0).Cells(0).Value)
                            End Select
                        End If



                        PictureBox_fingerprint_change.Visible = False

                        Public_Integer_Fingerprint_Status = 0
                        Public_String_fingerprint = 0

                        Form_add_patient.PictureBox_fingerprint.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.fingerprint
                        Form_edit_patient.PictureBox_fingerprint.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.fingerprint
                        Public_Determine_Form = "Form_receive_fingerprint"
                        Public_Determine_Languages()

                        ProgressBar_fingerprint.Value = 0
                        Label_percent.Font = Public_Microsoft_Tai_Le_Font_8_Bold

                        PictureBox_fingerprint_scan.Visible = True
                        ProgressBar_fingerprint.Visible = True
                        Label_percent.Visible = True
                    End If
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
    Private Sub Timer_update_percent_Tick(sender As Object, e As EventArgs)
        If ProgressBar_fingerprint.Value = 100 Then
            Label_percent.Text = "100%"

            Public_Integer_Fingerprint_Status = 1

            Public_Determine_Form = "Form_receive_fingerprint"
            Public_Determine_Languages()

            Me.Close()
        Else
            Label_percent.Text = ProgressBar_fingerprint.Value & "%"
        End If
    End Sub

    Private Sub PictureBox_fingerprint_change_Click(sender As Object, e As EventArgs) Handles PictureBox_fingerprint_change.Click
        Select Case My.Settings.Languages
            Case 1
                Message_box = MessageBox.Show("Are you sure you want to change the fingerprint?", "Change fingerprint", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 2
                Message_box = MessageBox.Show("آیا از تغییر اثر انگشت اطمینان دارید؟", "تغییر اثر انگشت", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 3
                Message_box = MessageBox.Show("هل أنت متأكد أنك تريد تغيير البصمة؟", "تغيير بصمة الإصبع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 4
                Message_box = MessageBox.Show("¿Estás seguro de que quieres cambiar la huella digital?", "Cambiar huella digital", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        End Select


        If Message_box = DialogResult.Yes Then
            If Form_main.SerialPort.IsOpen = True Then
                Form_main.SerialPort.WriteLine("ready_to_receive_fingerprint")
                Select Case Public_String_Menu_Item
                    Case "add"
                        Form_main.StatusStrip_progress_bar.Value = 0

                        Dim data_adapter_2 As SqlDataAdapter = New SqlDataAdapter("SELECT * From all_patients", Public_connect_DataGridView)
                        Dim DataTable_2 As New DataTable
                        data_adapter_2.Fill(DataTable_2)
                        Form_main.Main_DataGridView.DataSource = DataTable_2

                        Public_GridColor_Patients(Form_main.Main_DataGridView)

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
                        Form_main.SerialPort.WriteLine(Row_number)

                        Form_main.Main_DataGridView.Sort(Form_main.Main_DataGridView.Columns(12), System.ComponentModel.ListSortDirection.Descending)
                    Case "edit"
                        Form_main.SerialPort.WriteLine(Form_main.Main_DataGridView.Rows(0).Cells(0).Value)
                End Select
            End If



            PictureBox_fingerprint_change.Visible = False

            Public_Integer_Fingerprint_Status = 0
            Public_String_fingerprint = 0

            Form_add_patient.PictureBox_fingerprint.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.fingerprint
            Form_edit_patient.PictureBox_fingerprint.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.fingerprint
            Public_Determine_Form = "Form_receive_fingerprint"
            Public_Determine_Languages()

            ProgressBar_fingerprint.Value = 0
            Label_percent.Font = Public_Microsoft_Tai_Le_Font_8_Bold

            PictureBox_fingerprint_scan.Visible = True
            ProgressBar_fingerprint.Visible = True
            Label_percent.Visible = True
        End If
    End Sub
    Private Sub PictureBox_fingerprint_change_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_fingerprint_change.MouseEnter
        PictureBox_fingerprint_change.Size = New Size(PictureBox_fingerprint_change.Size.Width + 3, PictureBox_fingerprint_change.Size.Height + 3)
        PictureBox_fingerprint_change.Location = New Point(PictureBox_fingerprint_change.Location.X - 1.5, PictureBox_fingerprint_change.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_fingerprint_change_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_fingerprint_change.MouseLeave
        PictureBox_fingerprint_change.Size = New Size(PictureBox_fingerprint_change.Size.Width - 3, PictureBox_fingerprint_change.Size.Height - 3)
        PictureBox_fingerprint_change.Location = New Point(PictureBox_fingerprint_change.Location.X + 1.5, PictureBox_fingerprint_change.Location.Y + 1.5)
    End Sub
End Class