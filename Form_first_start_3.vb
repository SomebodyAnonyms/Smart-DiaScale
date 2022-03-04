Imports System.Data.SqlClient

Public Class Form_first_start_3

    Dim Integer_username_visible_status As Integer
    Dim Integer_password_visible_status As Integer

    Private Sub Form_first_start_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public_Determine_Form = "Form_first_start_3"
        Public_Determine_Languages()

        Integer_username_visible_status = 1
        Integer_password_visible_status = 2
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
                Button_next.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_password.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_next.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub TextBox_confirm_password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_confirm_password.KeyDown
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
            TextBox_confirm_password.UseSystemPasswordChar = True
            PictureBox_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.visible
        Else
            Integer_password_visible_status = 1
            TextBox_password.UseSystemPasswordChar = False
            TextBox_confirm_password.UseSystemPasswordChar = False
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

    Private Sub Button_next_Click(sender As Object, e As EventArgs) Handles Button_next.Click
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
            Public_String_username_text = TextBox_username.Text.ToString
            Public_username_format_check()

            If Public_Integer_username_format_error = 1 Then
                Select Case My.Settings.Languages
                    Case 1
                        Message_box = MessageBox.Show("The username format is incorrect" & vbNewLine & "The correct username format includes English letters and numbers and the symbols ""_"" (underline) and ""."" (Period) and without spaces", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 2
                        Message_box = MessageBox.Show("قالب نام کاربری نادرست است" & vbNewLine & "قالب صحیح نام کاربری شامل حروف و اعداد انگلیسی و نمادهای ""_"" (زیرخط) و ""."" (نقطه) و بدون فاصله میباشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 3
                        Message_box = MessageBox.Show("نموذج اسم المستخدم غير صحيح" & vbNewLine & "يتضمن تنسيق اسم المستخدم الصحيح أحرفًا وأرقامًا إنجليزية ورموز ""_"" (تسطير) و ""."" (فترة) وبدون مسافات", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 4
                        Message_box = MessageBox.Show("El formato del nombre de usuario es incorrecto" & vbNewLine & "El formato de nombre de usuario correcto incluye letras y números en inglés y los símbolos ""_"" (subrayado) y ""."" (Punto) y sin espacios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                If TextBox_password.TextLength < 8 Then
                    Select Case My.Settings.Languages
                        Case 1
                            Message_box = MessageBox.Show("Password must be more than 8 digits", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 2
                            Message_box = MessageBox.Show("رمز عبور باید بیشتر از ۸ رقم باشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 3
                            Message_box = MessageBox.Show("يجب أن تكون كلمة المرور أكثر من 8 أرقام", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 4
                            Message_box = MessageBox.Show("La contraseña debe tener más de 8 dígitos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Select
                Else
                    If TextBox_password.Text.Replace(" ", String.Empty) = String.Empty Then
                        Select Case My.Settings.Languages
                            Case 1
                                Message_box = MessageBox.Show("Password must contain at least one letter or number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 2
                                Message_box = MessageBox.Show("رمز عبور باید حداقل حاوی یک حرف یا عدد باشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 3
                                Message_box = MessageBox.Show("يجب أن تحتوي كلمة المرور على حرف أو رقم واحد على الأقل", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 4
                                Message_box = MessageBox.Show("La contraseña debe contener al menos una letra o un número", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Select
                    Else
                        If Not TextBox_password.Text = TextBox_confirm_password.Text Then
                            Select Case My.Settings.Languages
                                Case 1
                                    Message_box = MessageBox.Show("The password does not match the password confirmation", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Case 2
                                    Message_box = MessageBox.Show("رمز عبور با تأیید رمز عبور مطابقت ندارد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Case 3
                                    Message_box = MessageBox.Show("كلمة المرور لا تتطابق مع تأكيد كلمة المرور", "انتباه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Case 4
                                    Message_box = MessageBox.Show("La contraseña no coincide con la confirmación de la contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                                Dim edit As String = "update security set name=N'" & "Admin" & "',username=N'" & TextBox_username.Text & "',password=N'" & TextBox_password.Text & "' where id= 1"
                                Dim Run As SqlCommand = New SqlCommand(edit, Public_connect_DataGridView)
                                Public_connect_DataGridView.Open()
                                Run.ExecuteNonQuery()
                                Public_connect_DataGridView.Close()

                                My.Settings.First_start = 1
                                Public_Integer_entered_application = 1
                                Public_Boolean_Enter_Administrator = True
                                Public_Integer_entered_person_id = 1

                                Public_Determine_Layout()
                                Form_main.Show()
                                Me.Close()

                                Select Case My.Settings.Languages
                                    Case 1
                                        My.Settings.Data_Mode = 1
                                        Message_box = MessageBox.Show("The initial settings of the program were performed successfully", "Initial Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Case 2
                                        My.Settings.Data_Mode = 2
                                        Message_box = MessageBox.Show("تنظیمات اولیه برنامه با موفقیت انجام شد", "تنظیمات اولیه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Case 3
                                        My.Settings.Data_Mode = 3
                                        Message_box = MessageBox.Show("تم تنفيذ الإعدادات الأولية للبرنامج بنجاح", "الإعدادات الأساسية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Case 4
                                        My.Settings.Data_Mode = 4
                                        Message_box = MessageBox.Show("La configuración inicial del programa se realizó con éxito", "Ajustes iniciales", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Select
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class