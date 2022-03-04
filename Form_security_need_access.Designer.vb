<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_security_need_access
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_security_need_access))
        Me.Label_title = New System.Windows.Forms.Label()
        Me.Button_enter = New System.Windows.Forms.Button()
        Me.PictureBox_password_visible = New System.Windows.Forms.PictureBox()
        Me.PictureBox_username_visible = New System.Windows.Forms.PictureBox()
        Me.Label_password = New System.Windows.Forms.Label()
        Me.Label_username = New System.Windows.Forms.Label()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox_password_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_username_visible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_title
        '
        Me.Label_title.Location = New System.Drawing.Point(12, 10)
        Me.Label_title.Name = "Label_title"
        Me.Label_title.Size = New System.Drawing.Size(560, 50)
        Me.Label_title.TabIndex = 78
        Me.Label_title.Text = "Label_title"
        Me.Label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_enter
        '
        Me.Button_enter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_enter.Location = New System.Drawing.Point(254, 195)
        Me.Button_enter.Name = "Button_enter"
        Me.Button_enter.Size = New System.Drawing.Size(75, 27)
        Me.Button_enter.TabIndex = 73
        Me.Button_enter.Text = "Enter"
        Me.Button_enter.UseVisualStyleBackColor = True
        '
        'PictureBox_password_visible
        '
        Me.PictureBox_password_visible.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.visible
        Me.PictureBox_password_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_password_visible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_password_visible.Location = New System.Drawing.Point(360, 148)
        Me.PictureBox_password_visible.Name = "PictureBox_password_visible"
        Me.PictureBox_password_visible.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_password_visible.TabIndex = 77
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
        Me.PictureBox_username_visible.TabIndex = 76
        Me.PictureBox_username_visible.TabStop = False
        '
        'Label_password
        '
        Me.Label_password.Location = New System.Drawing.Point(204, 122)
        Me.Label_password.Name = "Label_password"
        Me.Label_password.Size = New System.Drawing.Size(250, 25)
        Me.Label_password.TabIndex = 75
        Me.Label_password.Text = "Label_password"
        Me.Label_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_username
        '
        Me.Label_username.Location = New System.Drawing.Point(204, 70)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(250, 25)
        Me.Label_username.TabIndex = 74
        Me.Label_username.Text = "Label_username"
        Me.Label_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_password
        '
        Me.TextBox_password.Location = New System.Drawing.Point(204, 148)
        Me.TextBox_password.MaxLength = 50
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_password.TabIndex = 72
        Me.TextBox_password.UseSystemPasswordChar = True
        '
        'TextBox_username
        '
        Me.TextBox_username.Location = New System.Drawing.Point(204, 96)
        Me.TextBox_username.MaxLength = 50
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_username.TabIndex = 71
        '
        'Form_security_need_access
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
        Me.Name = "Form_security_need_access"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_security_need_access"
        CType(Me.PictureBox_password_visible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_username_visible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_title As System.Windows.Forms.Label
    Friend WithEvents Button_enter As System.Windows.Forms.Button
    Friend WithEvents PictureBox_password_visible As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_username_visible As System.Windows.Forms.PictureBox
    Friend WithEvents Label_password As System.Windows.Forms.Label
    Friend WithEvents Label_username As System.Windows.Forms.Label
    Friend WithEvents TextBox_password As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_username As System.Windows.Forms.TextBox
End Class
