<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_find_dialysis_number
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_find_dialysis_number))
        Me.Button_next = New System.Windows.Forms.Button()
        Me.TextBox_dialysis_number = New System.Windows.Forms.TextBox()
        Me.Label_dialysis_number = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_next
        '
        Me.Button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_next.Location = New System.Drawing.Point(77, 66)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(75, 27)
        Me.Button_next.TabIndex = 8
        Me.Button_next.Text = "Next"
        Me.Button_next.UseVisualStyleBackColor = True
        '
        'TextBox_dialysis_number
        '
        Me.TextBox_dialysis_number.Location = New System.Drawing.Point(42, 40)
        Me.TextBox_dialysis_number.MaxLength = 10
        Me.TextBox_dialysis_number.Name = "TextBox_dialysis_number"
        Me.TextBox_dialysis_number.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_dialysis_number.TabIndex = 7
        Me.TextBox_dialysis_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_dialysis_number
        '
        Me.Label_dialysis_number.Location = New System.Drawing.Point(42, 8)
        Me.Label_dialysis_number.Name = "Label_dialysis_number"
        Me.Label_dialysis_number.Size = New System.Drawing.Size(150, 29)
        Me.Label_dialysis_number.TabIndex = 6
        Me.Label_dialysis_number.Text = "Label_dialysis_number"
        Me.Label_dialysis_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_find_dialysis_number
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(234, 101)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.TextBox_dialysis_number)
        Me.Controls.Add(Me.Label_dialysis_number)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_find_dialysis_number"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Dialysis Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_next As System.Windows.Forms.Button
    Friend WithEvents TextBox_dialysis_number As System.Windows.Forms.TextBox
    Friend WithEvents Label_dialysis_number As System.Windows.Forms.Label
End Class
