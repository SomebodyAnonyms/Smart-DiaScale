Imports System.Data.SqlClient

Public Class Form_find_ID

    Private Sub Form_find_ID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public_Determine_Form = "Form_find_ID"
        Public_Determine_Languages()

        TextBox_id_code.Text = String.Empty
        TextBox_id_code.Focus()
    End Sub

    Private Sub Button_next_Click(sender As Object, e As EventArgs) Handles Button_next.Click
        Form_main.StatusStrip_progress_bar.Value = 0

        Dim searchQuery As String = ("select * from all_patients where id_code = N'" & TextBox_id_code.Text & "'")
        Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
        Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        data_adapter.Fill(DataTable)
        Form_main.Main_DataGridView.DataSource = DataTable

        If Form_main.Main_DataGridView.RowCount > 0 Then
            Select Case Public_String_Menu_Item
                Case "delete"
                    For i = 0 To Form_main.Main_DataGridView.Rows(0).Cells.Count - 1
                        Form_main.Main_DataGridView.Rows(0).Cells(i).Style.BackColor = Color.Red
                    Next
                Case "edit"
                    For i = 0 To Form_main.Main_DataGridView.Rows(0).Cells.Count - 1
                        Form_main.Main_DataGridView.Rows(0).Cells(i).Style.BackColor = Color.Orange
                    Next
            End Select

            Public_Integer_ID_save = Form_main.Main_DataGridView.Rows(0).Cells(0).Value
            Me.Close()

            Select Case Public_String_Menu_Item
                Case "delete"
                    Form_delete_patient.ShowDialog()
                Case "edit"
                    Form_edit_patient.ShowDialog()
            End Select
        Else
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("No one was found with this ID Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("شخصی با این کد ملی یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("لم يتم العثور على أي شخص بهذا الرمز الوطني", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("No se encontró a nadie con este código de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select

            Form_main.StatusStrip_progress_bar.Value = 0

            Dim data_adapter_1 As SqlDataAdapter = New SqlDataAdapter("SELECT * From all_patients", Public_connect_DataGridView)
            Dim DataTable_1 As New DataTable
            data_adapter_1.Fill(DataTable_1)
            Form_main.Main_DataGridView.DataSource = DataTable_1

            Public_GridColor_Patients(Form_main.Main_DataGridView)

            Form_main.Main_DataGridView.Sort(Form_main.Main_DataGridView.Columns(12), System.ComponentModel.ListSortDirection.Descending)
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
    Private Sub TextBox_id_code_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_id_code.KeyDown
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