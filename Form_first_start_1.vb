Public Class Form_first_start_1

    Private Sub Form_first_start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Initial Start"
        Label_title.Text = "Please select the language"
        Button_next.Text = "Next"
        Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
        Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        RadioButton_persian_language.Checked = False
        RadioButton_english_language.Checked = True

        RadioButton_english_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold
        RadioButton_persian_language.Font = Public_B_Nazanin_Font_12_Bold
        RadioButton_arabic_language.Font = Public_B_Nazanin_Font_12_Bold
        RadioButton_spanish_language.Font = Public_Microsoft_Tai_Le_Font_12_Bold
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
    Private Sub RadioButton_english_language_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton_english_language.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button_next.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub RadioButton_persian_language_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton_persian_language.KeyDown
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
    'objects
    Private Sub PictureBox_english_language_Click(sender As Object, e As EventArgs) Handles PictureBox_english_language.Click
        Me.Text = "Initial Start"
        Label_title.Text = "Please select the language"
        Button_next.Text = "Next"
        Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
        Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        RadioButton_english_language.Checked = True
        RadioButton_persian_language.Checked = False
        RadioButton_arabic_language.Checked = False
        RadioButton_spanish_language.Checked = False
    End Sub
    Private Sub PictureBox_persian_language_Click(sender As Object, e As EventArgs) Handles PictureBox_persian_language.Click
        Me.Text = "شروع اولیه"
        Label_title.Text = "لطفا زبان خود را انتخاب نمایید"
        Button_next.Text = "بعدی"
        Label_title.Font = Public_B_Nazanin_Font_14_Bold
        Button_next.Font = Public_B_Nazanin_Font_9_Bold
        RadioButton_english_language.Checked = False
        RadioButton_persian_language.Checked = True
        RadioButton_arabic_language.Checked = False
        RadioButton_spanish_language.Checked = False
    End Sub
    Private Sub PictureBox_arabic_language_Click(sender As Object, e As EventArgs) Handles PictureBox_arabic_language.Click
        Me.Text = "البداية الأولية"
        Label_title.Text = "الرجاء اختيار لغتك"
        Button_next.Text = "التالي"
        Label_title.Font = Public_B_Nazanin_Font_14_Bold
        Button_next.Font = Public_B_Nazanin_Font_9_Bold
        RadioButton_english_language.Checked = False
        RadioButton_persian_language.Checked = False
        RadioButton_arabic_language.Checked = True
        RadioButton_spanish_language.Checked = False
    End Sub
    Private Sub PictureBox_spanish_language_Click(sender As Object, e As EventArgs) Handles PictureBox_spanish_language.Click
        Me.Text = "Inicio inicial"
        Label_title.Text = "Por favor seleccione el idioma"
        Button_next.Text = "siguiente"
        Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
        Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
        RadioButton_english_language.Checked = False
        RadioButton_persian_language.Checked = False
        RadioButton_arabic_language.Checked = False
        RadioButton_spanish_language.Checked = True
    End Sub

    Private Sub RadioButton_english_language_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_english_language.CheckedChanged
        If RadioButton_english_language.Checked = True Then
            Me.Text = "Initial Start"
            Label_title.Text = "Please select the language"
            Button_next.Text = "Next"
            Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            RadioButton_persian_language.Checked = False
            RadioButton_arabic_language.Checked = False
            RadioButton_spanish_language.Checked = False
        End If
    End Sub
    Private Sub RadioButton_persian_language_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_persian_language.CheckedChanged
        If RadioButton_persian_language.Checked = True Then
            Me.Text = "شروع اولیه"
            Label_title.Text = "لطفا زبان خود را انتخاب نمایید"
            Button_next.Text = "بعدی"
            Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Button_next.Font = Public_B_Nazanin_Font_9_Bold
            RadioButton_english_language.Checked = False
            RadioButton_arabic_language.Checked = False
            RadioButton_spanish_language.Checked = False
        End If
    End Sub
    Private Sub RadioButton_arabic_language_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_arabic_language.CheckedChanged
        If RadioButton_arabic_language.Checked = True Then
            Me.Text = "البداية الأولية"
            Label_title.Text = "الرجاء اختيار لغتك"
            Button_next.Text = "التالي"
            Label_title.Font = Public_B_Nazanin_Font_14_Bold
            Button_next.Font = Public_B_Nazanin_Font_9_Bold
            RadioButton_english_language.Checked = False
            RadioButton_persian_language.Checked = False
            RadioButton_spanish_language.Checked = False
        End If
    End Sub
    Private Sub RadioButton_spanish_language_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_spanish_language.CheckedChanged
        If RadioButton_spanish_language.Checked = True Then
            Me.Text = "Inicio inicial"
            Label_title.Text = "Por favor seleccione el idioma"
            Button_next.Text = "siguiente"
            Label_title.Font = Public_Microsoft_Tai_Le_Font_12_Bold
            Button_next.Font = Public_Microsoft_Tai_Le_Font_8_Bold
            RadioButton_english_language.Checked = False
            RadioButton_persian_language.Checked = False
            RadioButton_arabic_language.Checked = False
        End If
    End Sub

    Private Sub Button_next_Click(sender As Object, e As EventArgs) Handles Button_next.Click
        If RadioButton_english_language.Checked = True Then
            My.Settings.Languages = 1
        ElseIf RadioButton_persian_language.Checked = True Then
            My.Settings.Languages = 2
        ElseIf RadioButton_arabic_language.Checked = True Then
            My.Settings.Languages = 3
        ElseIf RadioButton_spanish_language.Checked = True Then
            My.Settings.Languages = 4
        End If

        Form_first_start_2.Show()
        Me.Close()
    End Sub
End Class