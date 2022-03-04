Imports System.Data.SqlClient

Public Class Form_security_enter_app

    Dim Integer_username_visible_status As Integer
    Dim Integer_password_visible_status As Integer

    Private Sub Form_security_enter_app_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public_Determine_Form = "Form_security_enter_app"
        Public_Determine_Languages()

        Integer_username_visible_status = 1
        Integer_password_visible_status = 2

        TextBox_username.Text = String.Empty
        TextBox_password.Text = String.Empty

        Public_Boolean_Enter_Administrator = False
        Public_Boolean_Enter_User = False

        Public_Integer_entered_application = 0
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
    Private Sub TextBox_username_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_username.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_enter.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_password.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_enter.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub Button_enter_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_enter.KeyDown
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
    Private Sub PictureBox_username_visible_Click(sender As Object, e As EventArgs) Handles PictureBox_username_visible.Click
        If Integer_username_visible_status = 1 Then
            Integer_username_visible_status = 2
            TextBox_username.UseSystemPasswordChar = True
            PictureBox_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
        Else
            Integer_username_visible_status = 1
            TextBox_username.UseSystemPasswordChar = False
            PictureBox_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
        End If
    End Sub
    Private Sub PictureBox_username_visible_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_username_visible.MouseEnter
        PictureBox_username_visible.Size = New Size(PictureBox_username_visible.Size.Width + 3, PictureBox_username_visible.Size.Height + 3)
        PictureBox_username_visible.Location = New Point(PictureBox_username_visible.Location.X - 1.5, PictureBox_username_visible.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_username_visible_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_username_visible.MouseLeave
        PictureBox_username_visible.Size = New Size(PictureBox_username_visible.Size.Width - 3, PictureBox_username_visible.Size.Height - 3)
        PictureBox_username_visible.Location = New Point(PictureBox_username_visible.Location.X + 1.5, PictureBox_username_visible.Location.Y + 1.5)
    End Sub

    Private Sub PictureBox_password_visible_Click(sender As Object, e As EventArgs) Handles PictureBox_password_visible.Click
        If Integer_password_visible_status = 1 Then
            Integer_password_visible_status = 2
            TextBox_password.UseSystemPasswordChar = True
            PictureBox_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
        Else
            Integer_password_visible_status = 1
            TextBox_password.UseSystemPasswordChar = False
            PictureBox_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible_1_
        End If
    End Sub
    Private Sub PictureBox_password_visible_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_password_visible.MouseEnter
        PictureBox_password_visible.Size = New Size(PictureBox_password_visible.Size.Width + 3, PictureBox_password_visible.Size.Height + 3)
        PictureBox_password_visible.Location = New Point(PictureBox_password_visible.Location.X - 1.5, PictureBox_password_visible.Location.Y - 1.5)
    End Sub
    Private Sub PictureBox_password_visible_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_password_visible.MouseLeave
        PictureBox_password_visible.Size = New Size(PictureBox_password_visible.Size.Width - 3, PictureBox_password_visible.Size.Height - 3)
        PictureBox_password_visible.Location = New Point(PictureBox_password_visible.Location.X + 1.5, PictureBox_password_visible.Location.Y + 1.5)
    End Sub

    Private Sub Button_enter_Click(sender As Object, e As EventArgs) Handles Button_enter.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If TextBox_username.Text = String.Empty Or TextBox_password.Text = String.Empty Then
            Select Case My.Settings.Languages
                Case 1
                    Message_box = MessageBox.Show("Username and password cannot be empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    Message_box = MessageBox.Show("نام کاربری و رمز عبور نمی توانند خالی باشند", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 3
                    Message_box = MessageBox.Show("لا يمكن أن يكون اسم المستخدم وكلمة المرور فارغين", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 4
                    Message_box = MessageBox.Show("El nombre de usuario y la contraseña no pueden estar vacíos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        Else
            Dim searchQuery As String = ("select * from security where username = N'" & TextBox_username.Text & "'")
            Dim command As New SqlCommand(searchQuery, Public_connect_DataGridView)
            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            data_adapter.Fill(DataTable)

            If Not DataTable.Rows.Count > 0 Then
                Select Case My.Settings.Languages
                    Case 1
                        Message_box = MessageBox.Show("Incorrect name or username or password" & vbNewLine & "Please try again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 2
                        Message_box = MessageBox.Show("نام یا نام کاربری یا رمز عبور نادرست است" & vbNewLine & "لطفا دوباره امتحان کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 3
                        Message_box = MessageBox.Show("اسم غير صحيح أو اسم المستخدم أو كلمة المرور" & vbNewLine & "حاول مرة اخرى", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 4
                        Message_box = MessageBox.Show("Nombre, nombre de usuario o contraseña incorrectos" & vbNewLine & "Inténtalo de nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                If Not TextBox_password.Text = DataTable.Rows(0).Item(3) Then
                    Select Case My.Settings.Languages
                        Case 1
                            Message_box = MessageBox.Show("Incorrect name or username or password" & vbNewLine & "Please try again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 2
                            Message_box = MessageBox.Show("نام یا نام کاربری یا رمز عبور نادرست است" & vbNewLine & "لطفا دوباره امتحان کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 3
                            Message_box = MessageBox.Show("اسم غير صحيح أو اسم المستخدم أو كلمة المرور" & vbNewLine & "حاول مرة اخرى", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 4
                            Message_box = MessageBox.Show("Nombre, nombre de usuario o contraseña incorrectos" & vbNewLine & "Inténtalo de nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Select
                Else
                    If DataTable.Rows(0).Item(0) = 1 Then
                        Public_Boolean_Enter_Administrator = True
                        Public_Integer_entered_person_id = 1
                    Else
                        Public_Boolean_Enter_User = True
                        Public_Integer_entered_person_id = DataTable.Rows(0).Item(0)
                        Form_main.StatusStrip_label_entered_person_name.Text = DataTable.Rows(0).Item(1)
                    End If

                    Public_Integer_entered_application = 1
                    Public_Determine_Layout()
                    Form_main.Show()
                    Me.Close()
                End If
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class