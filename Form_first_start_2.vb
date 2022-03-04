Imports System.Data.SqlClient

Public Class Form_first_start_2

    Private Sub Form_first_start_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public_Determine_Form = "Form_first_start_2"
        Public_Determine_Languages()
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
    Private Sub TextBox_hospital_name_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_hospital_name.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_next.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_hospital_address_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_hospital_address.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_next.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub MaskedTextBox_hospital_tel_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox_hospital_tel.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_next.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub NumericUpDown_dialysis_time_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown_dialysis_time.KeyDown
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
    Private Sub Button_next_Click(sender As Object, e As EventArgs) Handles Button_next.Click
        If TextBox_hospital_name.Text = String.Empty Or TextBox_hospital_address.Text = String.Empty Or MaskedTextBox_hospital_tel.Text = "" Or NumericUpDown_dialysis_time.Value = 0 Then
            If TextBox_hospital_name.Text = String.Empty Then TextBox_hospital_name.BackColor = Color.Red
            If TextBox_hospital_address.Text = String.Empty Then TextBox_hospital_address.BackColor = Color.Red
            If MaskedTextBox_hospital_tel.Text = "" Then MaskedTextBox_hospital_tel.BackColor = Color.Red
            If NumericUpDown_dialysis_time.Value = 0 Then NumericUpDown_dialysis_time.BackColor = Color.Red

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
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Are you sure the information is correct?", "Hospital information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Case 2
                    Message_box = MessageBox.Show("آیا از صحت اطلاعات اطمینان دارید؟", "اطلاعات بیمارستان", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Case 3
                    Message_box = MessageBox.Show("هل أنت متأكد من صحة المعلومات؟", "معلومات المستشفى", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Case 4
                    Message_box = MessageBox.Show("¿Estás seguro de que la información es correcta?", "Información del hospital", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            End Select

            If Message_box = DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                Dim edit As String = "update setting set hospital_name=N'" & TextBox_hospital_name.Text & "',hospital_address=N'" & TextBox_hospital_address.Text & "',hospital_tel=N'" & MaskedTextBox_hospital_tel.Text & "',maximum_dialysis_time=N'" & NumericUpDown_dialysis_time.Value & "' where id= 1"
                Dim Run As SqlCommand = New SqlCommand(edit, Public_connect_DataGridView)
                Public_connect_DataGridView.Open()
                Run.ExecuteNonQuery()
                Public_connect_DataGridView.Close()

                Public_Determine_Layout()
                Form_main.Visible = False

                Form_first_start_3.Show()
                Me.Close()
            End If
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub TextBox_hospital_name_GotFocus(sender As Object, e As EventArgs) Handles TextBox_hospital_name.GotFocus
        TextBox_hospital_name.BackColor = Color.White
    End Sub
    Private Sub TextBox_hospital_address_GotFocus(sender As Object, e As EventArgs) Handles TextBox_hospital_address.GotFocus
        TextBox_hospital_address.BackColor = Color.White
    End Sub
    Private Sub MaskedTextBox_hospital_tel_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox_hospital_tel.GotFocus
        MaskedTextBox_hospital_tel.BackColor = Color.White
    End Sub
    Private Sub NumericUpDown_dialysis_time_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown_dialysis_time.GotFocus
        NumericUpDown_dialysis_time.BackColor = Color.White
    End Sub
End Class