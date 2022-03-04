Imports System.Data.SqlClient

Public Class Form_find_dialysis_number
    Private Sub Form_find_dialysis_number_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public_Determine_Form = "Form_find_dialysis_number"
        Public_Determine_Languages()

        TextBox_dialysis_number.Text = String.Empty
        TextBox_dialysis_number.Focus()
    End Sub

    Private Sub Button_next_Click(sender As Object, e As EventArgs) Handles Button_next.Click
        Form_show_patient_database.StatusStrip_progress_bar.Value = 0

        Dim searchQuery As String = ("select * from Table_" & Public_Integer_ID_save & " where id= N'" & TextBox_dialysis_number.Text & "'")
        Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
        Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        data_adapter.Fill(DataTable)
        Form_show_patient_database.Main_DataGridView.DataSource = DataTable

        If Form_show_patient_database.Main_DataGridView.RowCount > 0 Then
            Select Case Public_String_Menu_Item
                Case "delete"
                    For i = 0 To Form_show_patient_database.Main_DataGridView.Rows(0).Cells.Count - 1
                        Form_show_patient_database.Main_DataGridView.Rows(0).Cells(i).Style.BackColor = Color.Red
                    Next
                Case "edit"
                    For i = 0 To Form_show_patient_database.Main_DataGridView.Rows(0).Cells.Count - 1
                        Form_show_patient_database.Main_DataGridView.Rows(0).Cells(i).Style.BackColor = Color.Orange
                    Next
            End Select

            Public_Integer_D_N_save = Form_show_patient_database.Main_DataGridView.Rows(0).Cells(0).Value
            Me.Close()

            Select Case Public_String_Menu_Item
                Case "delete"
                    Form_delete_dialysis.ShowDialog()
                Case "edit"
                    Form_edit_dialysis.ShowDialog()
            End Select
        Else
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("No Dialysis was found with this Dialysis number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("دیالیزی با این شماره دیالیز یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("لم يتم العثور على غسيل الكلى مع رقم غسيل الكلى هذا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("No se encontró diálisis con este número de diálisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select

            Form_show_patient_database.StatusStrip_progress_bar.Value = 0

            Dim data_adapter_1 As SqlDataAdapter = New SqlDataAdapter("SELECT * From Table_" & Public_Integer_ID_save & "", Public_connect_DataGridView)
            Dim DataTable_1 As New DataTable
            data_adapter_1.Fill(DataTable_1)
            Form_show_patient_database.Main_DataGridView.DataSource = DataTable_1

            Form_show_patient_database.Main_DataGridView.Sort(Form_show_patient_database.Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

            Public_GridColor_Dialysis(Form_show_patient_database.Main_DataGridView)
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
    Private Sub TextBox_dialysis_number_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_dialysis_number.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_next.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_next_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_next.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
End Class