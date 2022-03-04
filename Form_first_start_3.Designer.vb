<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_first_start_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_first_start_3))
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.Label_username = New System.Windows.Forms.Label()
        Me.Label_title = New System.Windows.Forms.Label()
        Me.Button_next = New System.Windows.Forms.Button()
        Me.Label_password = New System.Windows.Forms.Label()
        Me.PictureBox_username_visible = New System.Windows.Forms.PictureBox()
        Me.PictureBox_password_visible = New System.Windows.Forms.PictureBox()
        Me.Label_confirm_password = New System.Windows.Forms.Label()
        Me.TextBox_confirm_password = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox_username_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_password_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_username
        '
        Me.TextBox_username.Location = New System.Drawing.Point(325, 138)
        Me.TextBox_username.MaxLength = 50
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_username.TabIndex = 0
        '
        'TextBox_password
        '
        Me.TextBox_password.Location = New System.Drawing.Point(325, 187)
        Me.TextBox_password.MaxLength = 50
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_password.TabIndex = 1
        Me.TextBox_password.UseSystemPasswordChar = True
        '
        'Label_username
        '
        Me.Label_username.Location = New System.Drawing.Point(325, 110)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(250, 25)
        Me.Label_username.TabIndex = 4
        Me.Label_username.Text = "Label_username"
        Me.Label_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_title
        '
        Me.Label_title.Location = New System.Drawing.Point(12, 10)
        Me.Label_title.Name = "Label_title"
        Me.Label_title.Size = New System.Drawing.Size(776, 50)
        Me.Label_title.TabIndex = 36
        Me.Label_title.Text = "Label_title"
        Me.Label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_next
        '
        Me.Button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_next.Location = New System.Drawing.Point(362, 315)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(75, 27)
        Me.Button_next.TabIndex = 3
        Me.Button_next.Text = "Button_next"
        Me.Button_next.UseVisualStyleBackColor = True
        '
        'Label_password
        '
        Me.Label_password.Location = New System.Drawing.Point(325, 161)
        Me.Label_password.Name = "Label_password"
        Me.Label_password.Size = New System.Drawing.Size(250, 25)
        Me.Label_password.TabIndex = 38
        Me.Label_password.Text = "Label_password"
        Me.Label_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_username_visible
        '
        Me.PictureBox_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible_1_
        Me.PictureBox_username_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_username_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_username_visible.Location = New System.Drawing.Point(480, 138)
        Me.PictureBox_username_visible.Name = "PictureBox_username_visible"
        Me.PictureBox_username_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_username_visible.TabIndex = 40
        Me.PictureBox_username_visible.TabStop = False
        '
        'PictureBox_password_visible
        '
        Me.PictureBox_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible
        Me.PictureBox_password_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_password_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_password_visible.Location = New System.Drawing.Point(480, 187)
        Me.PictureBox_password_visible.Name = "PictureBox_password_visible"
        Me.PictureBox_password_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_password_visible.TabIndex = 41
        Me.PictureBox_password_visible.TabStop = False
        '
        'Label_confirm_password
        '
        Me.Label_confirm_password.Location = New System.Drawing.Point(325, 210)
        Me.Label_confirm_password.Name = "Label_confirm_password"
        Me.Label_confirm_password.Size = New System.Drawing.Size(250, 25)
        Me.Label_confirm_password.TabIndex = 43
        Me.Label_confirm_password.Text = "Label_confirm_password"
        Me.Label_confirm_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_confirm_password
        '
        Me.TextBox_confirm_password.Location = New System.Drawing.Point(325, 236)
        Me.TextBox_confirm_password.MaxLength = 50
        Me.TextBox_confirm_password.Name = "TextBox_confirm_password"
        Me.TextBox_confirm_password.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_confirm_password.TabIndex = 2
        Me.TextBox_confirm_password.UseSystemPasswordChar = True
        '
        'Form_first_start_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 350)
        Me.Controls.Add(Me.Label_confirm_password)
        Me.Controls.Add(Me.TextBox_confirm_password)
        Me.Controls.Add(Me.PictureBox_password_visible)
        Me.Controls.Add(Me.PictureBox_username_visible)
        Me.Controls.Add(Me.Label_password)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.Label_title)
        Me.Controls.Add(Me.Label_username)
        Me.Controls.Add(Me.TextBox_password)
        Me.Controls.Add(Me.TextBox_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_first_start_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "First Start"
        CType(Me.PictureBox_username_visible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_password_visible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_username As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_password As System.Windows.Forms.TextBox
    Friend WithEvents Label_username As System.Windows.Forms.Label
    Friend WithEvents Label_title As System.Windows.Forms.Label
    Friend WithEvents Button_next As System.Windows.Forms.Button
    Friend WithEvents Label_password As System.Windows.Forms.Label
    Friend WithEvents PictureBox_username_visible As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_password_visible As System.Windows.Forms.PictureBox
    Friend WithEvents Label_confirm_password As System.Windows.Forms.Label
    Friend WithEvents TextBox_confirm_password As System.Windows.Forms.TextBox
End Class
