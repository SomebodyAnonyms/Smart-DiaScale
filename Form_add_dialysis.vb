Imports System.Data.SqlClient

Public Class Form_add_dialysis

    Dim String_form_status As String

    Private Sub Form_add_dialysis_Load(sender As Object, e As EventArgs) Handles Me.Load
        Public_Determine_Form = "Form_add_dialysis"
        Public_Determine_Languages()
    End Sub
    Private Sub Form_add_dialysis_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
                MaskedTextBox_time_1.Text = String.Empty
                MaskedTextBox_time_2.Text = String.Empty
                MaskedTextBox_date_1.Text = String.Empty
                MaskedTextBox_date_2.Text = String.Empty
                NumericUpDown_weight_1.Value = 50
                NumericUpDown_weight_2.Value = 50

                MaskedTextBox_time_1.BackColor = Color.White
                MaskedTextBox_time_2.BackColor = Color.White
                MaskedTextBox_date_1.BackColor = Color.White
                MaskedTextBox_date_2.BackColor = Color.White

                Form_show_patient_database.StatusStrip_progress_bar.Value = 0

                Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From Table_" & Public_Integer_ID_save & "", Public_connect_DataGridView)
                Dim DataTable As New DataTable
                data_adapter.Fill(DataTable)
                Form_show_patient_database.Main_DataGridView.DataSource = DataTable

                Public_GridColor_Dialysis(Form_show_patient_database.Main_DataGridView)

                Select Case My.Settings.Languages
                    Case 1
                        Form_show_patient_database.ToolStripTextBox_search.Text = "Search"
                    Case 2
                        Form_show_patient_database.ToolStripTextBox_search.Text = "جستجو"
                    Case 3
                        Form_show_patient_database.ToolStripTextBox_search.Text = "بحث"
                    Case 4
                        Form_show_patient_database.ToolStripTextBox_search.Text = "Buscar"
                End Select

                Form_show_patient_database.ToolStripTextBox_search.ForeColor = Color.Gray

                Form_show_patient_database.Label_dialysis_count.Text = Form_show_patient_database.Main_DataGridView.RowCount

                Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
            Else
                e.Cancel = True
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
    Private Sub MaskedTextBox_date_1_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_date_1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_date_2_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_date_2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_time_1_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_time_1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_time_2_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_time_2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub NumericUpDown_weight_1_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown_weight_1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_add.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub NumericUpDown_weight_2_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown_weight_2.KeyDown
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
        If MaskedTextBox_time_1.Text = "  :" Or MaskedTextBox_time_2.Text = "  :" Or MaskedTextBox_date_1.Text = "    /  /" Or MaskedTextBox_date_2.Text = "    /  /" Then
            If MaskedTextBox_time_1.Text = "  :" Then MaskedTextBox_time_1.BackColor = Color.Red
            If MaskedTextBox_time_2.Text = "  :" Then MaskedTextBox_time_2.BackColor = Color.Red
            If MaskedTextBox_date_1.Text = "    /  /" Then MaskedTextBox_date_1.BackColor = Color.Red
            If MaskedTextBox_date_2.Text = "    /  /" Then MaskedTextBox_date_2.BackColor = Color.Red

            Dim Message_box_1 As String
            Select Case My.Settings.Languages
                Case 1
                    Message_box_1 = MessageBox.Show("Please fill in the required fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box_1 = MessageBox.Show("لطفا فیلد های مورد نیاز را پر نمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box_1 = MessageBox.Show("يرجى تعبئة الحقول المطلوبة", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box_1 = MessageBox.Show("Por favor llene los campos requeridos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

                Dim insert As String = "insert into Table_" & Public_Integer_ID_save & "(enter_date,enter_time,enter_weight,enter_bmi,exit_date,exit_time,exit_weight,exit_bmi,nurse) values ('" & MaskedTextBox_date_1.Text & "','" & MaskedTextBox_time_1.Text & "','" & NumericUpDown_weight_1.Text & "','" & Math.Round(NumericUpDown_weight_1.Value / (Form_main.Main_DataGridView.CurrentRow.Cells(10).Value * Form_main.Main_DataGridView.CurrentRow.Cells(10).Value), decimals:=2) & "','" & MaskedTextBox_date_2.Text & "','" & MaskedTextBox_time_2.Text & "','" & NumericUpDown_weight_2.Text & "','" & Math.Round(NumericUpDown_weight_2.Value / (Form_main.Main_DataGridView.CurrentRow.Cells(10).Value * Form_main.Main_DataGridView.CurrentRow.Cells(10).Value), decimals:=2) & "',N'" & Form_main.StatusStrip_label_entered_person_name.Text & "')"
                Dim Run As SqlCommand = New SqlCommand(insert, Public_connect_DataGridView)
                Public_connect_DataGridView.Open()
                Run.ExecuteNonQuery()
                Public_connect_DataGridView.Close()

                Me.Close()

                Form_show_patient_database.StatusStrip_progress_bar.Value = 0

                Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From Table_" & Public_Integer_ID_save & "", Public_connect_DataGridView)
                Dim DataTable As New DataTable
                data_adapter.Fill(DataTable)
                Form_show_patient_database.Main_DataGridView.DataSource = DataTable

                Public_GridColor_Dialysis(Form_show_patient_database.Main_DataGridView)

                Select Case My.Settings.Languages
                    Case 1
                        Form_show_patient_database.ToolStripTextBox_search.Text = "Search"
                    Case 2
                        Form_show_patient_database.ToolStripTextBox_search.Text = "جستجو"
                    Case 3
                        Form_show_patient_database.ToolStripTextBox_search.Text = "بحث"
                    Case 4
                        Form_show_patient_database.ToolStripTextBox_search.Text = "Buscar"
                End Select
                Form_show_patient_database.ToolStripTextBox_search.ForeColor = Color.Gray

                Form_show_patient_database.Label_dialysis_count.Text = Form_show_patient_database.Main_DataGridView.RowCount

                Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

                MaskedTextBox_time_1.Text = String.Empty
                MaskedTextBox_time_2.Text = String.Empty
                MaskedTextBox_date_1.Text = String.Empty
                MaskedTextBox_date_2.Text = String.Empty
                NumericUpDown_weight_1.Value = 50
                NumericUpDown_weight_2.Value = 50
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

    Private Sub MaskedTextBox_time_1_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_time_1.GotFocus
        MaskedTextBox_time_1.BackColor = Color.White
    End Sub
    Private Sub MaskedTextBox_time_2_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_time_2.GotFocus
        MaskedTextBox_time_2.BackColor = Color.White
    End Sub
    Private Sub MaskedTextBox_date_1_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_date_1.GotFocus
        MaskedTextBox_date_1.BackColor = Color.White
    End Sub
    Private Sub MaskedTextBox_date_2_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_date_2.GotFocus
        MaskedTextBox_date_2.BackColor = Color.White
    End Sub
End Class