Imports System.Data.SqlClient

Public Class Form_backup_proccess

    Private Sub Form_backup_proccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Form_main.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Form_main.Main_DataGridView.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ProgressBar_backup.Value = 0
        Label_percent.Text = "0%"

        Public_Determine_Form = "Form_backup_proccess"
        Public_Determine_Languages()

        Timer_proccess.Enabled = True
    End Sub

    Private Sub Timer_percent_Tick(sender As Object, e As EventArgs) Handles Timer_percent.Tick
        Label_percent.Text = ProgressBar_backup.Value & "%"
    End Sub

    Private Sub Timer_proccess_Tick(sender As Object, e As EventArgs) Handles Timer_proccess.Tick
        If Public_Integer_backup_restore_status = 1 Then
            Dim sqlcom As New SqlCommand("BACKUP DATABASE [" & My.Application.Info.DirectoryPath & "\Main_DB.mdf] TO disk ='" & Form_main.SaveFileDialog.FileName & "'", Public_connect_DataGridView)
            Public_connect_DataGridView.Open()
            sqlcom.ExecuteNonQuery()
            Public_connect_DataGridView.Close()

            ProgressBar_backup.Value = 100

            Me.Cursor = System.Windows.Forms.Cursors.Default
            Form_main.Cursor = System.Windows.Forms.Cursors.Default
            Form_main.Main_DataGridView.Cursor = System.Windows.Forms.Cursors.Hand

            Me.Close()

            Timer_proccess.Enabled = False

            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Backup successfully done", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 2
                    Message_box = MessageBox.Show("پشتیبان گیری با موفقیت انجام شد", "پشتیبان گیری", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 3
                    Message_box = MessageBox.Show("تم النسخ الاحتياطي بنجاح", "دعم", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 4
                    Message_box = MessageBox.Show("Copia de seguridad realizada con éxito", "Apoyo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Else


            ProgressBar_backup.Value = 100

            Me.Cursor = System.Windows.Forms.Cursors.Default
            Form_main.Cursor = System.Windows.Forms.Cursors.Default
            Form_main.Main_DataGridView.Cursor = System.Windows.Forms.Cursors.Hand

            Me.Close()

            Timer_proccess.Enabled = False

            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Restore successfully done", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 2
                    Message_box = MessageBox.Show("بازیابی با موفقیت انجام شد", "بازیابی", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 3
                    Message_box = MessageBox.Show("كان الاسترداد ناجحًا", "استعادة", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 4
                    Message_box = MessageBox.Show("Restaurar hecho con éxito", "Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        End If
    End Sub
End Class