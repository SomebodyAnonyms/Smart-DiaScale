<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_backup_proccess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_backup_proccess))
        Me.Label_percent = New System.Windows.Forms.Label()
        Me.ProgressBar_backup = New System.Windows.Forms.ProgressBar()
        Me.Label_explain = New System.Windows.Forms.Label()
        Me.Timer_percent = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_proccess = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label_percent
        '
        Me.Label_percent.Location = New System.Drawing.Point(304, 50)
        Me.Label_percent.Name = "Label_percent"
        Me.Label_percent.Size = New System.Drawing.Size(34, 23)
        Me.Label_percent.TabIndex = 10
        Me.Label_percent.Text = "100%"
        Me.Label_percent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar_backup
        '
        Me.ProgressBar_backup.Location = New System.Drawing.Point(12, 50)
        Me.ProgressBar_backup.Name = "ProgressBar_backup"
        Me.ProgressBar_backup.Size = New System.Drawing.Size(286, 23)
        Me.ProgressBar_backup.TabIndex = 9
        '
        'Label_explain
        '
        Me.Label_explain.Location = New System.Drawing.Point(12, 9)
        Me.Label_explain.Name = "Label_explain"
        Me.Label_explain.Size = New System.Drawing.Size(326, 38)
        Me.Label_explain.TabIndex = 11
        Me.Label_explain.Text = "Label_explain"
        Me.Label_explain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer_percent
        '
        Me.Timer_percent.Enabled = True
        Me.Timer_percent.Interval = 10
        '
        'Timer_proccess
        '
        Me.Timer_proccess.Interval = 1000
        '
        'Form_backup_proccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 80)
        Me.Controls.Add(Me.Label_explain)
        Me.Controls.Add(Me.Label_percent)
        Me.Controls.Add(Me.ProgressBar_backup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_backup_proccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Backup "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_percent As System.Windows.Forms.Label
    Friend WithEvents ProgressBar_backup As System.Windows.Forms.ProgressBar
    Friend WithEvents Label_explain As System.Windows.Forms.Label
    Friend WithEvents Timer_percent As System.Windows.Forms.Timer
    Friend WithEvents Timer_proccess As System.Windows.Forms.Timer
End Class
