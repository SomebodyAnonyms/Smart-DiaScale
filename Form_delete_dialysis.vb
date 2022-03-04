Imports System.Data.SqlClient

Public Class Form_delete_dialysis
    Dim String_form_status As String

    Private Sub Form_delete_dialysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public_Determine_Form = "Form_delete_dialysis"
        Public_Determine_Languages()

        Label_dialysis_number.Text = Form_show_patient_database.Main_DataGridView.CurrentRow.Cells(0).Value

        Label_time_1_info.Text = Form_show_patient_database.Main_DataGridView.CurrentRow.Cells(2).Value
        Label_time_2_info.Text = Form_show_patient_database.Main_DataGridView.CurrentRow.Cells(6).Value
        Label_date_1_info.Text = Form_show_patient_database.Main_DataGridView.CurrentRow.Cells(1).Value
        Label_date_2_info.Text = Form_show_patient_database.Main_DataGridView.CurrentRow.Cells(5).Value
        Label_weight_1_info.Text = Form_show_patient_database.Main_DataGridView.CurrentRow.Cells(3).Value
        Label_weight_2_info.Text = Form_show_patient_database.Main_DataGridView.CurrentRow.Cells(7).Value
    End Sub
    Private Sub Form_delete_dialysis_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub Button_delete_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_delete.KeyDown
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
    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        Select Case My.Settings.Languages
            Case 1
                Message_box = MessageBox.Show("Are you want to delete this Item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 2
                Message_box = MessageBox.Show("آیا از حذف این آیتم مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 3
                Message_box = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا البند؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 4
                Message_box = MessageBox.Show("¿Quieres eliminar este artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        End Select


        If Message_box = DialogResult.Yes Then
            String_form_status = "delete"

            Dim Delete As String = "Delete from Table_" & Public_Integer_ID_save & " where id=" & Public_Integer_D_N_save
            Dim Run As SqlCommand = New SqlCommand(Delete, Public_connect_DataGridView)
            Public_connect_DataGridView.Open()
            Run.ExecuteNonQuery()
            Public_connect_DataGridView.Close()

            Me.Close()
        End If
    End Sub
    Private Sub Button_delete_MouseEnter(sender As Object, e As EventArgs) Handles Button_delete.MouseEnter
        Button_delete.FlatAppearance.BorderSize = 1
        Button_delete.BackColor = Color.AliceBlue
    End Sub
    Private Sub Button_delete_MouseLeave(sender As Object, e As EventArgs) Handles Button_delete.MouseLeave
        Button_delete.FlatAppearance.BorderSize = 2
        Button_delete.BackColor = Color.Gainsboro
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
End Class