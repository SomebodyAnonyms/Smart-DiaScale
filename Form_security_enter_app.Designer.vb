<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_security_enter_app
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_security_enter_app))
        Me.Label_password = New System.Windows.Forms.Label()
        Me.Label_username = New System.Windows.Forms.Label()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.PictureBox_password_visible = New System.Windows.Forms.PictureBox()
        Me.PictureBox_username_visible = New System.Windows.Forms.PictureBox()
        Me.Button_enter = New System.Windows.Forms.Button()
        Me.Label_title = New System.Windows.Forms.Label()
        CType(Me.PictureBox_password_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_username_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_password
        '
        Me.Label_password.Location = New System.Drawing.Point(204, 122)
        Me.Label_password.Name = "Label_password"
        Me.Label_password.Size = New System.Drawing.Size(250, 25)
        Me.Label_password.TabIndex = 66
        Me.Label_password.Text = "Label_password"
        Me.Label_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_username
        '
        Me.Label_username.Location = New System.Drawing.Point(204, 70)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(250, 25)
        Me.Label_username.TabIndex = 65
        Me.Label_username.Text = "Label_username"
        Me.Label_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_password
        '
        Me.TextBox_password.Location = New System.Drawing.Point(204, 148)
        Me.TextBox_password.MaxLength = 50
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_password.TabIndex = 1
        Me.TextBox_password.UseSystemPasswordChar = True
        '
        'TextBox_username
        '
        Me.TextBox_username.Location = New System.Drawing.Point(204, 96)
        Me.TextBox_username.MaxLength = 50
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_username.TabIndex = 0
        '
        'PictureBox_password_visible
        '
        Me.PictureBox_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible
        Me.PictureBox_password_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_password_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_password_visible.Location = New System.Drawing.Point(360, 148)
        Me.PictureBox_password_visible.Name = "PictureBox_password_visible"
        Me.PictureBox_password_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_password_visible.TabIndex = 68
        Me.PictureBox_password_visible.TabStop = False
        '
        'PictureBox_username_visible
        '
        Me.PictureBox_username_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible_1_
        Me.PictureBox_username_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_username_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_username_visible.Location = New System.Drawing.Point(360, 96)
        Me.PictureBox_username_visible.Name = "PictureBox_username_visible"
        Me.PictureBox_username_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_username_visible.TabIndex = 67
        Me.PictureBox_username_visible.TabStop = False
        '
        'Button_enter
        '
        Me.Button_enter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_enter.Location = New System.Drawing.Point(254, 195)
        Me.Button_enter.Name = "Button_enter"
        Me.Button_enter.Size = New System.Drawing.Size(75, 27)
        Me.Button_enter.TabIndex = 2
        Me.Button_enter.Text = "Enter"
        Me.Button_enter.UseVisualStyleBackColor = True
        '
        'Label_title
        '
        Me.Label_title.Location = New System.Drawing.Point(12, 10)
        Me.Label_title.Name = "Label_title"
        Me.Label_title.Size = New System.Drawing.Size(560, 50)
        Me.Label_title.TabIndex = 70
        Me.Label_title.Text = "Label_title"
        Me.Label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_security
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 228)
        Me.Controls.Add(Me.Label_title)
        Me.Controls.Add(Me.Button_enter)
        Me.Controls.Add(Me.PictureBox_password_visible)
        Me.Controls.Add(Me.PictureBox_username_visible)
        Me.Controls.Add(Me.Label_password)
        Me.Controls.Add(Me.Label_username)
        Me.Controls.Add(Me.TextBox_password)
        Me.Controls.Add(Me.TextBox_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_security"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Security"
        CType(Me.PictureBox_password_visible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_username_visible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_password_visible As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_username_visible As System.Windows.Forms.PictureBox
    Friend WithEvents Label_password As System.Windows.Forms.Label
    Friend WithEvents Label_username As System.Windows.Forms.Label
    Friend WithEvents TextBox_password As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_username As System.Windows.Forms.TextBox
    Friend WithEvents Button_enter As System.Windows.Forms.Button
    Friend WithEvents Label_title As System.Windows.Forms.Label
End Class
