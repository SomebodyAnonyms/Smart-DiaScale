<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_every_start
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_every_start))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox_Logo = New System.Windows.Forms.PictureBox()
        Me.Label_application_name = New System.Windows.Forms.Label()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 2500
        '
        'PictureBox_Logo
        '
        Me.PictureBox_Logo.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.Logo
        Me.PictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_Logo.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_Logo.Name = "PictureBox_Logo"
        Me.PictureBox_Logo.Size = New System.Drawing.Size(400, 253)
        Me.PictureBox_Logo.TabIndex = 0
        Me.PictureBox_Logo.TabStop = False
        '
        'Label_application_name
        '
        Me.Label_application_name.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_application_name.Font = New System.Drawing.Font("Plasma Drip (BRK)", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_application_name.Location = New System.Drawing.Point(0, 253)
        Me.Label_application_name.Name = "Label_application_name"
        Me.Label_application_name.Size = New System.Drawing.Size(400, 45)
        Me.Label_application_name.TabIndex = 1
        Me.Label_application_name.Text = "Smart DiaScale I"
        Me.Label_application_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_every_start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(400, 298)
        Me.Controls.Add(Me.PictureBox_Logo)
        Me.Controls.Add(Me.Label_application_name)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_every_start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_every_start"
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Label_application_name As System.Windows.Forms.Label
End Class
