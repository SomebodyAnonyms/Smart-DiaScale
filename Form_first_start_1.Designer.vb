<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_first_start_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_first_start_1))
        Me.Button_next = New System.Windows.Forms.Button()
        Me.Label_title = New System.Windows.Forms.Label()
        Me.RadioButton_english_language = New System.Windows.Forms.RadioButton()
        Me.RadioButton_persian_language = New System.Windows.Forms.RadioButton()
        Me.RadioButton_arabic_language = New System.Windows.Forms.RadioButton()
        Me.RadioButton_spanish_language = New System.Windows.Forms.RadioButton()
        Me.PictureBox_spanish_language = New System.Windows.Forms.PictureBox()
        Me.PictureBox_arabic_language = New System.Windows.Forms.PictureBox()
        Me.PictureBox_persian_language = New System.Windows.Forms.PictureBox()
        Me.PictureBox_english_language = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_spanish_language, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_arabic_language, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_persian_language, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_english_language, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_next
        '
        Me.Button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_next.Location = New System.Drawing.Point(362, 315)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(75, 27)
        Me.Button_next.TabIndex = 11
        Me.Button_next.Text = "Button_next"
        Me.Button_next.UseVisualStyleBackColor = True
        '
        'Label_title
        '
        Me.Label_title.Location = New System.Drawing.Point(12, 10)
        Me.Label_title.Name = "Label_title"
        Me.Label_title.Size = New System.Drawing.Size(776, 50)
        Me.Label_title.TabIndex = 12
        Me.Label_title.Text = "Label_title"
        Me.Label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton_english_language
        '
        Me.RadioButton_english_language.Checked = True
        Me.RadioButton_english_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_english_language.Location = New System.Drawing.Point(133, 221)
        Me.RadioButton_english_language.Name = "RadioButton_english_language"
        Me.RadioButton_english_language.Size = New System.Drawing.Size(100, 25)
        Me.RadioButton_english_language.TabIndex = 7
        Me.RadioButton_english_language.TabStop = True
        Me.RadioButton_english_language.Text = "English (USA)"
        Me.RadioButton_english_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_english_language.UseVisualStyleBackColor = True
        '
        'RadioButton_persian_language
        '
        Me.RadioButton_persian_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_persian_language.Location = New System.Drawing.Point(283, 221)
        Me.RadioButton_persian_language.Name = "RadioButton_persian_language"
        Me.RadioButton_persian_language.Size = New System.Drawing.Size(100, 25)
        Me.RadioButton_persian_language.TabIndex = 9
        Me.RadioButton_persian_language.Text = "فارسی"
        Me.RadioButton_persian_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_persian_language.UseVisualStyleBackColor = True
        '
        'RadioButton_arabic_language
        '
        Me.RadioButton_arabic_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_arabic_language.Location = New System.Drawing.Point(433, 221)
        Me.RadioButton_arabic_language.Name = "RadioButton_arabic_language"
        Me.RadioButton_arabic_language.Size = New System.Drawing.Size(100, 25)
        Me.RadioButton_arabic_language.TabIndex = 13
        Me.RadioButton_arabic_language.Text = "عربی"
        Me.RadioButton_arabic_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_arabic_language.UseVisualStyleBackColor = True
        '
        'RadioButton_spanish_language
        '
        Me.RadioButton_spanish_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_spanish_language.Location = New System.Drawing.Point(583, 221)
        Me.RadioButton_spanish_language.Name = "RadioButton_spanish_language"
        Me.RadioButton_spanish_language.Size = New System.Drawing.Size(100, 25)
        Me.RadioButton_spanish_language.TabIndex = 15
        Me.RadioButton_spanish_language.Text = "Español"
        Me.RadioButton_spanish_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_spanish_language.UseVisualStyleBackColor = True
        '
        'PictureBox_spanish_language
        '
        Me.PictureBox_spanish_language.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.spain
        Me.PictureBox_spanish_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_spanish_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_spanish_language.Location = New System.Drawing.Point(583, 135)
        Me.PictureBox_spanish_language.Name = "PictureBox_spanish_language"
        Me.PictureBox_spanish_language.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox_spanish_language.TabIndex = 16
        Me.PictureBox_spanish_language.TabStop = False
        '
        'PictureBox_arabic_language
        '
        Me.PictureBox_arabic_language.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.saudi_arabia
        Me.PictureBox_arabic_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_arabic_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_arabic_language.Location = New System.Drawing.Point(433, 135)
        Me.PictureBox_arabic_language.Name = "PictureBox_arabic_language"
        Me.PictureBox_arabic_language.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox_arabic_language.TabIndex = 14
        Me.PictureBox_arabic_language.TabStop = False
        '
        'PictureBox_persian_language
        '
        Me.PictureBox_persian_language.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.iran
        Me.PictureBox_persian_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_persian_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_persian_language.Location = New System.Drawing.Point(283, 135)
        Me.PictureBox_persian_language.Name = "PictureBox_persian_language"
        Me.PictureBox_persian_language.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox_persian_language.TabIndex = 10
        Me.PictureBox_persian_language.TabStop = False
        '
        'PictureBox_english_language
        '
        Me.PictureBox_english_language.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.usa
        Me.PictureBox_english_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_english_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_english_language.Location = New System.Drawing.Point(133, 135)
        Me.PictureBox_english_language.Name = "PictureBox_english_language"
        Me.PictureBox_english_language.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox_english_language.TabIndex = 8
        Me.PictureBox_english_language.TabStop = False
        '
        'Form_first_start_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 350)
        Me.Controls.Add(Me.RadioButton_spanish_language)
        Me.Controls.Add(Me.PictureBox_spanish_language)
        Me.Controls.Add(Me.RadioButton_arabic_language)
        Me.Controls.Add(Me.PictureBox_arabic_language)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.Label_title)
        Me.Controls.Add(Me.RadioButton_english_language)
        Me.Controls.Add(Me.RadioButton_persian_language)
        Me.Controls.Add(Me.PictureBox_persian_language)
        Me.Controls.Add(Me.PictureBox_english_language)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_first_start_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "First Start"
        CType(Me.PictureBox_spanish_language, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_arabic_language, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_persian_language, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_english_language, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_next As System.Windows.Forms.Button
    Friend WithEvents Label_title As System.Windows.Forms.Label
    Friend WithEvents RadioButton_english_language As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_persian_language As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox_persian_language As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_english_language As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton_arabic_language As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox_arabic_language As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton_spanish_language As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox_spanish_language As System.Windows.Forms.PictureBox
End Class
