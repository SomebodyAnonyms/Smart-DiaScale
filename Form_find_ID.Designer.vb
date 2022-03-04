<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_find_ID
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_find_ID))
        Me.Button_next = New System.Windows.Forms.Button()
        Me.TextBox_id_code = New System.Windows.Forms.TextBox()
        Me.Label_id_code = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_next
        '
        Me.Button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_next.Location = New System.Drawing.Point(80, 67)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(75, 27)
        Me.Button_next.TabIndex = 5
        Me.Button_next.Text = "Next"
        Me.Button_next.UseVisualStyleBackColor = True
        '
        'TextBox_id_code
        '
        Me.TextBox_id_code.Location = New System.Drawing.Point(45, 41)
        Me.TextBox_id_code.MaxLength = 10
        Me.TextBox_id_code.Name = "TextBox_id_code"
        Me.TextBox_id_code.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_id_code.TabIndex = 4
        Me.TextBox_id_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_id_code
        '
        Me.Label_id_code.Location = New System.Drawing.Point(45, 9)
        Me.Label_id_code.Name = "Label_id_code"
        Me.Label_id_code.Size = New System.Drawing.Size(150, 29)
        Me.Label_id_code.TabIndex = 3
        Me.Label_id_code.Text = "Label_id_code"
        Me.Label_id_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_find_ID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(234, 101)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.TextBox_id_code)
        Me.Controls.Add(Me.Label_id_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_find_ID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ID Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_next As System.Windows.Forms.Button
    Friend WithEvents TextBox_id_code As System.Windows.Forms.TextBox
    Friend WithEvents Label_id_code As System.Windows.Forms.Label
End Class
