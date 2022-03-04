Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class Form_show_patient_database
    Dim Integer_Row_count As Integer

    Dim Integer_Number As Integer
    Dim Integer_Number_Save As Integer
    Dim Integer_Text_Height As Integer
    Dim Integer_Elevator As Integer
    Dim Integer_Row_Number As Integer
    Dim Integer_Row_Number_1 As Integer
    Dim Integer_Page_Number As Integer
    Dim Integer_Row_check As Integer
    Dim Integer_DataTable_Rows_Count As Integer

    Private Sub Form_show_patient_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_image()

        Label_name.Text = Form_main.Main_DataGridView.CurrentRow.Cells(2).Value & " " & Form_main.Main_DataGridView.CurrentRow.Cells(3).Value
        Label_blood_type.Text = Form_main.Main_DataGridView.CurrentRow.Cells(14).Value

        StatusStrip_label_percent.Text = "0%"
        StatusStrip_progress_bar.Value = 0

        Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From Table_" & Public_Integer_ID_save & "", Public_connect_DataGridView)
        Dim DataTable As New DataTable
        data_adapter.Fill(DataTable)
        Main_DataGridView.DataSource = DataTable

        Main_DataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Main_DataGridView.Columns(0).Width = 45
        Main_DataGridView.Sort(Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        Public_Determine_Form = "Form_show_patient_database"
        Public_Determine_Languages()
    End Sub
    Private Sub Form_show_patient_database_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label_dialysis_count.Text = Main_DataGridView.RowCount

        Public_GridColor_Dialysis(Main_DataGridView)
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
    Private Sub Main_DataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles Main_DataGridView.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Form_dialysis_chart.ShowDialog()
            Case Keys.Delete
                Public_String_Menu_Item = "delete"
                Main_DataGridView.CurrentRow.Selected = False
                For i = 0 To Main_DataGridView.CurrentRow.Cells.Count - 1
                    Main_DataGridView.CurrentRow.Cells(i).Style.BackColor = Color.Red
                Next
                Public_Integer_D_N_save = Main_DataGridView.CurrentRow.Cells(0).Value
                Form_delete_dialysis.ShowDialog()
                Main_DataGridView.Sort(Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
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
        Public_GridColor_Dialysis(Main_DataGridView)
    End Sub
    Private Sub Main_DataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles Main_DataGridView.RowsAdded
        If Main_DataGridView.RowCount = 1 Then
            If ToolStripTextBox_search.Text = "Search" Or ToolStripTextBox_search.Text = "جستجو" Or ToolStripTextBox_search.Text = "بحث" Or ToolStripTextBox_search.Text = "Buscar" Then
                Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From Table_" & Public_Integer_ID_save & "", Public_connect_DataGridView)
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
    'menu
    Private Sub ToolStripButton_add_dialysis_Click(sender As Object, e As EventArgs) Handles ToolStripButton_add_dialysis.Click
        Public_String_Menu_Item = "add"
        Form_add_dialysis.ShowDialog()
    End Sub
    Private Sub ToolStripButton_delete_dialysis_Click(sender As Object, e As EventArgs) Handles ToolStripButton_delete_dialysis.Click
        Public_String_Menu_Item = "delete"
        Form_find_dialysis_number.ShowDialog()
    End Sub
    Private Sub ToolStripButton_edit_dialysis_Click(sender As Object, e As EventArgs) Handles ToolStripButton_edit_dialysis.Click
        Public_String_Menu_Item = "edit"
        Form_find_dialysis_number.ShowDialog()
    End Sub

    Private Sub ToolStripButton_chart_Click(sender As Object, e As EventArgs) Handles ToolStripButton_chart.Click
        Form_dialysis_chart.ShowDialog()
    End Sub

    Private Sub ToolStripButton_print_Click(sender As Object, e As EventArgs) Handles ToolStripButton_print.Click
        If Not Main_DataGridView.RowCount = 0 Then
            PrintPreviewDialog.WindowState = FormWindowState.Maximized
            PrintPreviewDialog.Document = PrintDocument
            PageSetupDialog.Document = PrintDocument

            If PageSetupDialog.ShowDialog = DialogResult.OK Then
                Integer_Row_Number = 0
                Integer_Row_Number_1 = 0
                Integer_Page_Number = 0

                PrintPreviewDialog.ShowDialog()
            End If
        Else
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("No information to print", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("اطلاعاتی برای چاپ وجود ندارد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("لا توجد معلومات للطباعة", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("No hay información para imprimir", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        End If
    End Sub

    Private Sub ToolStripButton_refresh_Click(sender As Object, e As EventArgs) Handles ToolStripButton_refresh.Click
        StatusStrip_progress_bar.Value = 0

        Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From Table_" & Public_Integer_ID_save & "", Public_connect_DataGridView)
        Dim DataTable As New DataTable
        data_adapter.Fill(DataTable)
        Main_DataGridView.DataSource = DataTable

        Public_GridColor_Dialysis(Main_DataGridView)

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

        Label_dialysis_count.Text = Main_DataGridView.RowCount

        Main_DataGridView.Sort(Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
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
    'print
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument.PrintPage
        Integer_Page_Number += 1
        Integer_Number = 0
        Integer_Number_Save = 0
        Integer_Text_Height = 0
        Integer_Elevator = 0

        If My.Settings.Languages = 1 Then
            Dim Text_Format As New StringFormat
            Text_Format.Alignment = StringAlignment.Center
            Text_Format.LineAlignment = StringAlignment.Center
            Text_Format.FormatFlags = StringFormatFlags.LineLimit

            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - 40) / 2
            Dim Stream As New MemoryStream()
            Public_connect_DataGridView.Open()
            Dim command As New SqlCommand("select image from all_patients where id=" & Public_Integer_ID_save, Public_connect_DataGridView)
            Dim image As Byte() = DirectCast(command.ExecuteScalar(), Byte())
            Stream.Write(image, 0, image.Length)
            Public_connect_DataGridView.Close()
            Dim Bitmap As New Bitmap(Stream)
            e.Graphics.DrawImage(Bitmap, Integer_Number, 10, 40, 52)

            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - 300) / 2
            e.Graphics.DrawString(Label_name.Text, Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number, 70, 300, 20), Text_Format)
            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - (PrintDocument.DefaultPageSettings.PaperSize.Width - 20)) / 2
            e.Graphics.DrawString("Father's Name: " & Form_main.Main_DataGridView.CurrentRow.Cells(4).Value & "     " & "Date of Birth: " & Form_main.Main_DataGridView.CurrentRow.Cells(5).Value & "     " & "ID Code: " & Form_main.Main_DataGridView.CurrentRow.Cells(6).Value & vbNewLine & "Mobile: " & Form_main.Main_DataGridView.CurrentRow.Cells(7).Value & "     " & "Tel: " & Form_main.Main_DataGridView.CurrentRow.Cells(8).Value & "     " & "Height: " & Form_main.Main_DataGridView.CurrentRow.Cells(10).Value & "     " & "Enroll Date: " & Form_main.Main_DataGridView.CurrentRow.Cells(12).Value & vbNewLine & "Doctor's Name: " & Form_main.Main_DataGridView.CurrentRow.Cells(13).Value & "     " & "Blood type: " & Form_main.Main_DataGridView.CurrentRow.Cells(14).Value, Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number, 95, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 90), Text_Format)
            e.Graphics.DrawRectangle(Pens.Black, Integer_Number, 95, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 90)
            e.Graphics.DrawLine(Pens.Black, 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, 200)





            e.Graphics.DrawRectangle(Pens.Black, 10, PrintDocument.DefaultPageSettings.PaperSize.Height - 135, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 100)

            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From setting", Public_connect_DataGridView)
            Dim DataTable As New DataTable
            data_adapter.Fill(DataTable)
            e.Graphics.DrawString(DataTable.Rows(0).Item(1), Public_Microsoft_Tai_Le_Font_20_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 130, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 40), Text_Format)
            e.Graphics.DrawString("Address: " & DataTable.Rows(0).Item(2), Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 80, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)
            e.Graphics.DrawString("Tel: " & DataTable.Rows(0).Item(3), Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 60, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)




            Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Columns(0).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, 7 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
            For i = 1 To 8
                If e.Graphics.MeasureString(Main_DataGridView.Columns(i).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height > Integer_Text_Height Then
                    Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Columns(i).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                End If
            Next
            Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
            e.Graphics.DrawString(Main_DataGridView.Columns(0).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(10, 200, Integer_Number, Integer_Text_Height + 20), Text_Format)
            For i = 1 To 8
                Integer_Number_Save += Integer_Number
                Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                e.Graphics.DrawString(Main_DataGridView.Columns(i).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number_Save + 10, 200, Integer_Number, Integer_Text_Height + 20), Text_Format)
            Next
            e.Graphics.DrawLine(Pens.Black, 10, 200 + Integer_Text_Height + 20, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, 200 + Integer_Text_Height + 20)


            Integer_Elevator = Integer_Text_Height + 200 + 20
            For i = Integer_Row_Number To Main_DataGridView.RowCount - 1
                Integer_Number_Save = 0

                Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(0).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 7 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                For c = 1 To 8
                    If e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(c).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height > Integer_Text_Height Then
                        Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(c).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                    End If
                Next

                Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                e.Graphics.DrawString(Main_DataGridView.Rows(i).Cells(0).Value, Public_Microsoft_Tai_Le_Font_12_Regular, Brushes.Black, New RectangleF(10, Integer_Elevator, Integer_Number, Integer_Text_Height + 20), Text_Format)

                For b = 1 To 8
                    Integer_Number_Save += Integer_Number
                    Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                    e.Graphics.DrawString(Main_DataGridView.Rows(i).Cells(b).Value, Public_Microsoft_Tai_Le_Font_12_Regular, Brushes.Black, New RectangleF(Integer_Number_Save + 10, Integer_Elevator, Integer_Number, Integer_Text_Height + 20), Text_Format)
                Next

                Integer_Elevator += Integer_Text_Height + 20
                e.Graphics.DrawLine(Pens.Black, 10, Integer_Elevator, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, Integer_Elevator)

                Integer_Row_Number_1 = i
                If Not i = Main_DataGridView.RowCount - 1 Then
                    If Integer_Elevator + Integer_Text_Height + 20 > PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                        Integer_Row_Number = i + 1
                        Exit For
                    End If
                End If
            Next

            Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
            e.Graphics.DrawLine(Pens.Black, Integer_Number + 10, 200, Integer_Number + 10, Integer_Elevator)
            Integer_Number_Save = Integer_Number
            For i = 1 To 7
                Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                Integer_Number_Save += Integer_Number
                e.Graphics.DrawLine(Pens.Black, Integer_Number_Save + 10, 200, Integer_Number_Save + 10, Integer_Elevator)
            Next
            e.Graphics.DrawRectangle(Pens.Black, 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, Integer_Elevator - 200)

            e.Graphics.DrawString(Integer_Page_Number, Public_Microsoft_Tai_Le_Font_15_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 25, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)

            If Not Integer_Row_Number_1 = Main_DataGridView.RowCount - 1 Then
                If Integer_Elevator + Integer_Text_Height + 20 < PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                    e.HasMorePages = False
                End If
            End If
            If Not Integer_Row_Number_1 = Main_DataGridView.RowCount - 1 Then
                If Integer_Elevator + Integer_Text_Height + 20 > PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                    e.HasMorePages = True
                End If
            End If
        End If





        If My.Settings.Languages = 2 Then
            Dim Text_Format As New StringFormat
            Text_Format.Alignment = StringAlignment.Center
            Text_Format.LineAlignment = StringAlignment.Center
            Text_Format.FormatFlags = StringFormatFlags.LineLimit
            Text_Format.FormatFlags = StringFormatFlags.DirectionRightToLeft

            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - 40) / 2
            Dim Stream As New MemoryStream()
            Public_connect_DataGridView.Open()
            Dim command As New SqlCommand("select image from all_patients where id=" & Public_Integer_ID_save, Public_connect_DataGridView)
            Dim image As Byte() = DirectCast(command.ExecuteScalar(), Byte())
            Stream.Write(image, 0, image.Length)
            Public_connect_DataGridView.Close()
            Dim Bitmap As New Bitmap(Stream)
            e.Graphics.DrawImage(Bitmap, Integer_Number, 10, 40, 52)

            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - 300) / 2
            e.Graphics.DrawString(Label_name.Text, Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number, 70, 300, 20), Text_Format)
            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - (PrintDocument.DefaultPageSettings.PaperSize.Width - 20)) / 2
            e.Graphics.DrawString("نام پدر: " & Form_main.Main_DataGridView.CurrentRow.Cells(4).Value & "     " & "تاریخ تولد: " & Form_main.Main_DataGridView.CurrentRow.Cells(5).Value & "     " & "کد ملی: " & Form_main.Main_DataGridView.CurrentRow.Cells(6).Value & vbNewLine & "موبایل: " & Form_main.Main_DataGridView.CurrentRow.Cells(7).Value & "     " & "تلفن: " & Form_main.Main_DataGridView.CurrentRow.Cells(8).Value & "     " & "قد: " & Form_main.Main_DataGridView.CurrentRow.Cells(10).Value & "     " & "تاریخ ثبت نام: " & Form_main.Main_DataGridView.CurrentRow.Cells(12).Value & vbNewLine & "نام پزشک: " & Form_main.Main_DataGridView.CurrentRow.Cells(13).Value & "     " & "گروه خونی: " & Form_main.Main_DataGridView.CurrentRow.Cells(14).Value, Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number, 95, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 90), Text_Format)
            e.Graphics.DrawRectangle(Pens.Black, Integer_Number, 95, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 90)
            e.Graphics.DrawLine(Pens.Black, 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, 200)





            e.Graphics.DrawRectangle(Pens.Black, 10, PrintDocument.DefaultPageSettings.PaperSize.Height - 135, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 100)

            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From setting", Public_connect_DataGridView)
            Dim DataTable As New DataTable
            data_adapter.Fill(DataTable)
            e.Graphics.DrawString(DataTable.Rows(0).Item(1), Public_B_Nazanin_Font_20_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 130, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 40), Text_Format)
            e.Graphics.DrawString("آدرس: " & DataTable.Rows(0).Item(2), Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 80, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)
            e.Graphics.DrawString("تلفن: " & DataTable.Rows(0).Item(3), Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 60, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)




            Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Columns(0).HeaderText, Public_B_Nazanin_Font_12_Bold, 7 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
            For i = 1 To 8
                If e.Graphics.MeasureString(Main_DataGridView.Columns(i).HeaderText, Public_B_Nazanin_Font_12_Bold, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height > Integer_Text_Height Then
                    Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Columns(i).HeaderText, Public_B_Nazanin_Font_12_Bold, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                End If
            Next
            Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
            e.Graphics.DrawString(Main_DataGridView.Columns(0).HeaderText, Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number - 10, 200, Integer_Number, Integer_Text_Height + 20), Text_Format)
            Integer_Number_Save += Integer_Number
            For i = 1 To 8
                Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                Integer_Number_Save += Integer_Number
                e.Graphics.DrawString(Main_DataGridView.Columns(i).HeaderText, Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number_Save - 10, 200, Integer_Number, Integer_Text_Height + 20), Text_Format)

            Next
            e.Graphics.DrawLine(Pens.Black, 10, 200 + Integer_Text_Height + 20, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, 200 + Integer_Text_Height + 20)


            Integer_Elevator = Integer_Text_Height + 200 + 20
            For i = Integer_Row_Number To Main_DataGridView.RowCount - 1
                Integer_Number_Save = 0

                Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(0).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 7 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                For c = 1 To 8
                    If e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(c).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height > Integer_Text_Height Then
                        Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(c).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                    End If
                Next

                Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                e.Graphics.DrawString(Main_DataGridView.Rows(i).Cells(0).Value, Public_Microsoft_Tai_Le_Font_12_Regular, Brushes.Black, New RectangleF(PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number - 10, Integer_Elevator, Integer_Number, Integer_Text_Height + 20), Text_Format)
                Integer_Number_Save += Integer_Number
                For b = 1 To 8
                    Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                    Integer_Number_Save += Integer_Number
                    e.Graphics.DrawString(Main_DataGridView.Rows(i).Cells(b).Value, Public_Microsoft_Tai_Le_Font_12_Regular, Brushes.Black, New RectangleF(PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number_Save - 10, Integer_Elevator, Integer_Number, Integer_Text_Height + 20), Text_Format)
                Next

                Integer_Elevator += Integer_Text_Height + 20
                e.Graphics.DrawLine(Pens.Black, 10, Integer_Elevator, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, Integer_Elevator)

                Integer_Row_Number_1 = i
                If Not i = Main_DataGridView.RowCount - 1 Then
                    If Integer_Elevator + Integer_Text_Height + 20 > PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                        Integer_Row_Number = i + 1
                        Exit For
                    End If
                End If
            Next

            Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
            e.Graphics.DrawLine(Pens.Black, PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number - 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number - 10, Integer_Elevator)
            Integer_Number_Save = Integer_Number
            For i = 1 To 7
                Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                Integer_Number_Save += Integer_Number
                e.Graphics.DrawLine(Pens.Black, PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number_Save - 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number_Save - 10, Integer_Elevator)
            Next
            e.Graphics.DrawRectangle(Pens.Black, 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, Integer_Elevator - 200)

            e.Graphics.DrawString(Integer_Page_Number, Public_Microsoft_Tai_Le_Font_15_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 25, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)

            If Not Integer_Row_Number_1 = Main_DataGridView.RowCount - 1 Then
                If Integer_Elevator + Integer_Text_Height + 20 < PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                    e.HasMorePages = False
                End If
            End If
            If Not Integer_Row_Number_1 = Main_DataGridView.RowCount - 1 Then
                If Integer_Elevator + Integer_Text_Height + 20 > PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                    e.HasMorePages = True
                End If
            End If
        End If





        If My.Settings.Languages = 3 Then
            Dim Text_Format As New StringFormat
            Text_Format.Alignment = StringAlignment.Center
            Text_Format.LineAlignment = StringAlignment.Center
            Text_Format.FormatFlags = StringFormatFlags.LineLimit
            Text_Format.FormatFlags = StringFormatFlags.DirectionRightToLeft

            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - 40) / 2
            Dim Stream As New MemoryStream()
            Public_connect_DataGridView.Open()
            Dim command As New SqlCommand("select image from all_patients where id=" & Public_Integer_ID_save, Public_connect_DataGridView)
            Dim image As Byte() = DirectCast(command.ExecuteScalar(), Byte())
            Stream.Write(image, 0, image.Length)
            Public_connect_DataGridView.Close()
            Dim Bitmap As New Bitmap(Stream)
            e.Graphics.DrawImage(Bitmap, Integer_Number, 10, 40, 52)

            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - 300) / 2
            e.Graphics.DrawString(Label_name.Text, Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number, 70, 300, 20), Text_Format)
            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - (PrintDocument.DefaultPageSettings.PaperSize.Width - 20)) / 2
            e.Graphics.DrawString("اسم الاب: " & Form_main.Main_DataGridView.CurrentRow.Cells(4).Value & "     " & "تاريخ الولادة: " & Form_main.Main_DataGridView.CurrentRow.Cells(5).Value & "     " & "رمز دولي: " & Form_main.Main_DataGridView.CurrentRow.Cells(6).Value & vbNewLine & "هاتف: " & Form_main.Main_DataGridView.CurrentRow.Cells(7).Value & "     " & "هاتف المنزل: " & Form_main.Main_DataGridView.CurrentRow.Cells(8).Value & "     " & "ارتفاع: " & Form_main.Main_DataGridView.CurrentRow.Cells(10).Value & "     " & "تاريخ التسجيل: " & Form_main.Main_DataGridView.CurrentRow.Cells(12).Value & vbNewLine & "اسم الطبيب: " & Form_main.Main_DataGridView.CurrentRow.Cells(13).Value & "     " & "فصيلة الدم: " & Form_main.Main_DataGridView.CurrentRow.Cells(14).Value, Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number, 95, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 90), Text_Format)
            e.Graphics.DrawRectangle(Pens.Black, Integer_Number, 95, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 90)
            e.Graphics.DrawLine(Pens.Black, 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, 200)





            e.Graphics.DrawRectangle(Pens.Black, 10, PrintDocument.DefaultPageSettings.PaperSize.Height - 135, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 100)

            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From setting", Public_connect_DataGridView)
            Dim DataTable As New DataTable
            data_adapter.Fill(DataTable)
            e.Graphics.DrawString(DataTable.Rows(0).Item(1), Public_B_Nazanin_Font_20_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 130, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 40), Text_Format)
            e.Graphics.DrawString("عنوان: " & DataTable.Rows(0).Item(2), Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 80, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)
            e.Graphics.DrawString("هاتف: " & DataTable.Rows(0).Item(3), Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 60, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)




            Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Columns(0).HeaderText, Public_B_Nazanin_Font_12_Bold, 7 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
            For i = 1 To 8
                If e.Graphics.MeasureString(Main_DataGridView.Columns(i).HeaderText, Public_B_Nazanin_Font_12_Bold, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height > Integer_Text_Height Then
                    Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Columns(i).HeaderText, Public_B_Nazanin_Font_12_Bold, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                End If
            Next
            Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
            e.Graphics.DrawString(Main_DataGridView.Columns(0).HeaderText, Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number - 10, 200, Integer_Number, Integer_Text_Height + 20), Text_Format)
            Integer_Number_Save += Integer_Number
            For i = 1 To 8
                Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                Integer_Number_Save += Integer_Number
                e.Graphics.DrawString(Main_DataGridView.Columns(i).HeaderText, Public_B_Nazanin_Font_12_Bold, Brushes.Black, New RectangleF(PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number_Save - 10, 200, Integer_Number, Integer_Text_Height + 20), Text_Format)

            Next
            e.Graphics.DrawLine(Pens.Black, 10, 200 + Integer_Text_Height + 20, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, 200 + Integer_Text_Height + 20)


            Integer_Elevator = Integer_Text_Height + 200 + 20
            For i = Integer_Row_Number To Main_DataGridView.RowCount - 1
                Integer_Number_Save = 0

                Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(0).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 7 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                For c = 1 To 8
                    If e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(c).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height > Integer_Text_Height Then
                        Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(c).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                    End If
                Next

                Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                e.Graphics.DrawString(Main_DataGridView.Rows(i).Cells(0).Value, Public_Microsoft_Tai_Le_Font_12_Regular, Brushes.Black, New RectangleF(PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number - 10, Integer_Elevator, Integer_Number, Integer_Text_Height + 20), Text_Format)
                Integer_Number_Save += Integer_Number
                For b = 1 To 8
                    Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                    Integer_Number_Save += Integer_Number
                    e.Graphics.DrawString(Main_DataGridView.Rows(i).Cells(b).Value, Public_Microsoft_Tai_Le_Font_12_Regular, Brushes.Black, New RectangleF(PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number_Save - 10, Integer_Elevator, Integer_Number, Integer_Text_Height + 20), Text_Format)
                Next

                Integer_Elevator += Integer_Text_Height + 20
                e.Graphics.DrawLine(Pens.Black, 10, Integer_Elevator, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, Integer_Elevator)

                Integer_Row_Number_1 = i
                If Not i = Main_DataGridView.RowCount - 1 Then
                    If Integer_Elevator + Integer_Text_Height + 20 > PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                        Integer_Row_Number = i + 1
                        Exit For
                    End If
                End If
            Next

            Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
            e.Graphics.DrawLine(Pens.Black, PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number - 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number - 10, Integer_Elevator)
            Integer_Number_Save = Integer_Number
            For i = 1 To 7
                Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                Integer_Number_Save += Integer_Number
                e.Graphics.DrawLine(Pens.Black, PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number_Save - 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - Integer_Number_Save - 10, Integer_Elevator)
            Next
            e.Graphics.DrawRectangle(Pens.Black, 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, Integer_Elevator - 200)

            e.Graphics.DrawString(Integer_Page_Number, Public_Microsoft_Tai_Le_Font_15_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 25, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)

            If Not Integer_Row_Number_1 = Main_DataGridView.RowCount - 1 Then
                If Integer_Elevator + Integer_Text_Height + 20 < PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                    e.HasMorePages = False
                End If
            End If
            If Not Integer_Row_Number_1 = Main_DataGridView.RowCount - 1 Then
                If Integer_Elevator + Integer_Text_Height + 20 > PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                    e.HasMorePages = True
                End If
            End If
        End If





        If My.Settings.Languages = 4 Then
            Dim Text_Format As New StringFormat
            Text_Format.Alignment = StringAlignment.Center
            Text_Format.LineAlignment = StringAlignment.Center
            Text_Format.FormatFlags = StringFormatFlags.LineLimit

            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - 40) / 2
            Dim Stream As New MemoryStream()
            Public_connect_DataGridView.Open()
            Dim command As New SqlCommand("select image from all_patients where id=" & Public_Integer_ID_save, Public_connect_DataGridView)
            Dim image As Byte() = DirectCast(command.ExecuteScalar(), Byte())
            Stream.Write(image, 0, image.Length)
            Public_connect_DataGridView.Close()
            Dim Bitmap As New Bitmap(Stream)
            e.Graphics.DrawImage(Bitmap, Integer_Number, 10, 40, 52)

            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - 300) / 2
            e.Graphics.DrawString(Label_name.Text, Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number, 70, 300, 20), Text_Format)
            Integer_Number = (PrintDocument.DefaultPageSettings.PaperSize.Width - (PrintDocument.DefaultPageSettings.PaperSize.Width - 20)) / 2
            e.Graphics.DrawString("Nombre del Padre: " & Form_main.Main_DataGridView.CurrentRow.Cells(4).Value & "     " & "Fecha de nacimiento: " & Form_main.Main_DataGridView.CurrentRow.Cells(5).Value & "     " & "Código de identificación: " & Form_main.Main_DataGridView.CurrentRow.Cells(6).Value & vbNewLine & "Móvil: " & Form_main.Main_DataGridView.CurrentRow.Cells(7).Value & "     " & "Tel: " & Form_main.Main_DataGridView.CurrentRow.Cells(8).Value & "     " & "Altura: " & Form_main.Main_DataGridView.CurrentRow.Cells(10).Value & "     " & "Fecha de inscripción: " & Form_main.Main_DataGridView.CurrentRow.Cells(12).Value & vbNewLine & "El nombre del doctor: " & Form_main.Main_DataGridView.CurrentRow.Cells(13).Value & "     " & "Tipo de sangre: " & Form_main.Main_DataGridView.CurrentRow.Cells(14).Value, Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number, 95, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 90), Text_Format)
            e.Graphics.DrawRectangle(Pens.Black, Integer_Number, 95, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 90)
            e.Graphics.DrawLine(Pens.Black, 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, 200)





            e.Graphics.DrawRectangle(Pens.Black, 10, PrintDocument.DefaultPageSettings.PaperSize.Height - 135, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 100)

            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * From setting", Public_connect_DataGridView)
            Dim DataTable As New DataTable
            data_adapter.Fill(DataTable)
            e.Graphics.DrawString(DataTable.Rows(0).Item(1), Public_Microsoft_Tai_Le_Font_20_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 130, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 40), Text_Format)
            e.Graphics.DrawString("Habla a: " & DataTable.Rows(0).Item(2), Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 80, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)
            e.Graphics.DrawString("Tel: " & DataTable.Rows(0).Item(3), Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 60, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)




            Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Columns(0).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, 7 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
            For i = 1 To 8
                If e.Graphics.MeasureString(Main_DataGridView.Columns(i).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height > Integer_Text_Height Then
                    Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Columns(i).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                End If
            Next
            Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
            e.Graphics.DrawString(Main_DataGridView.Columns(0).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(10, 200, Integer_Number, Integer_Text_Height + 20), Text_Format)
            For i = 1 To 8
                Integer_Number_Save += Integer_Number
                Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                e.Graphics.DrawString(Main_DataGridView.Columns(i).HeaderText, Public_Microsoft_Tai_Le_Font_12_Bold, Brushes.Black, New RectangleF(Integer_Number_Save + 10, 200, Integer_Number, Integer_Text_Height + 20), Text_Format)
            Next
            e.Graphics.DrawLine(Pens.Black, 10, 200 + Integer_Text_Height + 20, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, 200 + Integer_Text_Height + 20)


            Integer_Elevator = Integer_Text_Height + 200 + 20
            For i = Integer_Row_Number To Main_DataGridView.RowCount - 1
                Integer_Number_Save = 0

                Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(0).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 7 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                For c = 1 To 8
                    If e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(c).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height > Integer_Text_Height Then
                        Integer_Text_Height = e.Graphics.MeasureString(Main_DataGridView.Rows(i).Cells(c).Value, Public_Microsoft_Tai_Le_Font_12_Regular, 11.625 * PrintDocument.DefaultPageSettings.PaperSize.Width / 100, Text_Format).Height
                    End If
                Next

                Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                e.Graphics.DrawString(Main_DataGridView.Rows(i).Cells(0).Value, Public_Microsoft_Tai_Le_Font_12_Regular, Brushes.Black, New RectangleF(10, Integer_Elevator, Integer_Number, Integer_Text_Height + 20), Text_Format)

                For b = 1 To 8
                    Integer_Number_Save += Integer_Number
                    Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                    e.Graphics.DrawString(Main_DataGridView.Rows(i).Cells(b).Value, Public_Microsoft_Tai_Le_Font_12_Regular, Brushes.Black, New RectangleF(Integer_Number_Save + 10, Integer_Elevator, Integer_Number, Integer_Text_Height + 20), Text_Format)
                Next

                Integer_Elevator += Integer_Text_Height + 20
                e.Graphics.DrawLine(Pens.Black, 10, Integer_Elevator, PrintDocument.DefaultPageSettings.PaperSize.Width - 10, Integer_Elevator)

                Integer_Row_Number_1 = i
                If Not i = Main_DataGridView.RowCount - 1 Then
                    If Integer_Elevator + Integer_Text_Height + 20 > PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                        Integer_Row_Number = i + 1
                        Exit For
                    End If
                End If
            Next

            Integer_Number = 7 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
            e.Graphics.DrawLine(Pens.Black, Integer_Number + 10, 200, Integer_Number + 10, Integer_Elevator)
            Integer_Number_Save = Integer_Number
            For i = 1 To 7
                Integer_Number = 11.625 * (PrintDocument.DefaultPageSettings.PaperSize.Width - 20) / 100
                Integer_Number_Save += Integer_Number
                e.Graphics.DrawLine(Pens.Black, Integer_Number_Save + 10, 200, Integer_Number_Save + 10, Integer_Elevator)
            Next
            e.Graphics.DrawRectangle(Pens.Black, 10, 200, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, Integer_Elevator - 200)

            e.Graphics.DrawString(Integer_Page_Number, Public_Microsoft_Tai_Le_Font_15_Bold, Brushes.Black, New RectangleF(10, PrintDocument.DefaultPageSettings.PaperSize.Height - 25, PrintDocument.DefaultPageSettings.PaperSize.Width - 20, 20), Text_Format)

            If Not Integer_Row_Number_1 = Main_DataGridView.RowCount - 1 Then
                If Integer_Elevator + Integer_Text_Height + 20 < PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                    e.HasMorePages = False
                End If
            End If
            If Not Integer_Row_Number_1 = Main_DataGridView.RowCount - 1 Then
                If Integer_Elevator + Integer_Text_Height + 20 > PrintDocument.DefaultPageSettings.PaperSize.Height - 145 Then
                    e.HasMorePages = True
                End If
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
            Dim searchQuery As String = ("SELECT * From Table_" & Public_Integer_ID_save & " where concat(id,enter_date,enter_time,enter_weight,enter_bmi,exit_date,exit_time,exit_weight,exit_bmi,nurse) like N'%" & ToolStripTextBox_search.Text & "%'")
            Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            data_adapter.Fill(DataTable)

            Integer_DataTable_Rows_Count = DataTable.Rows.Count
            Integer_Row_check = 0
            If Timer_proggress_bar.Enabled = False Then
                Timer_proggress_bar.Enabled = True
            End If

            Main_DataGridView.DataSource = DataTable
            Main_DataGridView.Sort(Main_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

            Public_GridColor_Dialysis(Main_DataGridView)

            If Not ToolStripTextBox_search.Text = String.Empty Then
                For i = 0 To Main_DataGridView.RowCount - 1
                    For b = 0 To 9
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
    'timer
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

End Class