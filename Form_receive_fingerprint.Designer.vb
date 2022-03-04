<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_receive_fingerprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_receive_fingerprint))
        Me.Label_percent = New System.Windows.Forms.Label()
        Me.Label_explain = New System.Windows.Forms.Label()
        Me.ProgressBar_fingerprint = New System.Windows.Forms.ProgressBar()
        Me.PictureBox_fingerprint_change = New System.Windows.Forms.PictureBox()
        Me.PictureBox_fingerprint_scan = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_fingerprint_change, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_fingerprint_scan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_percent
        '
        Me.Label_percent.Location = New System.Drawing.Point(439, 155)
        Me.Label_percent.Name = "Label_percent"
        Me.Label_percent.Size = New System.Drawing.Size(44, 23)
        Me.Label_percent.TabIndex = 8
        Me.Label_percent.Text = "100%"
        Me.Label_percent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_percent.Visible = False
        '
        'Label_explain
        '
        Me.Label_explain.Location = New System.Drawing.Point(12, 9)
        Me.Label_explain.Name = "Label_explain"
        Me.Label_explain.Size = New System.Drawing.Size(460, 73)
        Me.Label_explain.TabIndex = 7
        Me.Label_explain.Text = "Label1"
        Me.Label_explain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgressBar_fingerprint
        '
        Me.ProgressBar_fingerprint.Location = New System.Drawing.Point(12, 155)
        Me.ProgressBar_fingerprint.Name = "ProgressBar_fingerprint"
        Me.ProgressBar_fingerprint.Size = New System.Drawing.Size(421, 23)
        Me.ProgressBar_fingerprint.TabIndex = 5
        Me.ProgressBar_fingerprint.Visible = False
        '
        'PictureBox_fingerprint_change
        '
        Me.PictureBox_fingerprint_change.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.fingerprint_scanner
        Me.PictureBox_fingerprint_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_fingerprint_change.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_fingerprint_change.Location = New System.Drawing.Point(220, 128)
        Me.PictureBox_fingerprint_change.Name = "PictureBox_fingerprint_change"
        Me.PictureBox_fingerprint_change.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox_fingerprint_change.TabIndex = 9
        Me.PictureBox_fingerprint_change.TabStop = False
        Me.PictureBox_fingerprint_change.Visible = False
        '
        'PictureBox_fingerprint_scan
        '
        Me.PictureBox_fingerprint_scan.Image = Global.Smart_DiaScale_I.My.Resources.Resources.fingerprint_scan
        Me.PictureBox_fingerprint_scan.Location = New System.Drawing.Point(190, 85)
        Me.PictureBox_fingerprint_scan.Name = "PictureBox_fingerprint_scan"
        Me.PictureBox_fingerprint_scan.Size = New System.Drawing.Size(90, 72)
        Me.PictureBox_fingerprint_scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_fingerprint_scan.TabIndex = 6
        Me.PictureBox_fingerprint_scan.TabStop = False
        Me.PictureBox_fingerprint_scan.Visible = False
        '
        'Form_receive_fingerprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 186)
        Me.Controls.Add(Me.Label_percent)
        Me.Controls.Add(Me.Label_explain)
        Me.Controls.Add(Me.ProgressBar_fingerprint)
        Me.Controls.Add(Me.PictureBox_fingerprint_change)
        Me.Controls.Add(Me.PictureBox_fingerprint_scan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_receive_fingerprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fingerprint"
        CType(Me.PictureBox_fingerprint_change, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_fingerprint_scan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_percent As System.Windows.Forms.Label
    Friend WithEvents Label_explain As System.Windows.Forms.Label
    Friend WithEvents ProgressBar_fingerprint As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox_fingerprint_change As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_fingerprint_scan As System.Windows.Forms.PictureBox
End Class
