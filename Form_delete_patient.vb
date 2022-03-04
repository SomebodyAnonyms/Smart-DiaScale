Imports System.Data.SqlClient
Imports System.IO

Public Class Form_delete_patient

    Private Sub Form_delete_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_image()

        Public_Determine_Form = "Form_delete_patient"
        Public_Determine_Languages()
        Label_name_2.Text = Form_main.Main_DataGridView.CurrentRow.Cells(2).Value & " " & Form_main.Main_DataGridView.CurrentRow.Cells(3).Value
        Label_father_name_2.Text = Form_main.Main_DataGridView.CurrentRow.Cells(4).Value
        Label_id_code_2.Text = Form_main.Main_DataGridView.CurrentRow.Cells(6).Value
        Label_birth_date_2.Text = Form_main.Main_DataGridView.CurrentRow.Cells(5).Value
    End Sub
    Private Sub Form_delete_patient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

        If Form_main.Main_DataGridView.RowCount = 0 Then
            Form_main.StatusStrip_progress_bar.Value = 100
            Form_main.StatusStrip_label_percent.Text = "100%"
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
        PictureBox_user.Image = Bitmap
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
                Message_box = MessageBox.Show("Are you want to delete this patient?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 2
                Message_box = MessageBox.Show("آیا از حذف این بیمار مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 3
                Message_box = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا المريض؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Case 4
                Message_box = MessageBox.Show("¿Quieres eliminar a este paciente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        End Select


        If Message_box = DialogResult.Yes Then
            Dim Delete As String = "Delete from all_patients where id=" & Public_Integer_ID_save
            Dim Run As SqlCommand = New SqlCommand(Delete, Public_connect_DataGridView)
            Public_connect_DataGridView.Open()
            Run.ExecuteNonQuery()
            Public_connect_DataGridView.Close()

            Dim Create As String = "DROP TABLE Table_" & Public_Integer_ID_save & ""
            Dim SqlCommand As SqlCommand = New SqlCommand(Create, Public_connect_DataGridView)
            Public_connect_DataGridView.Open()
            SqlCommand.ExecuteNonQuery()
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