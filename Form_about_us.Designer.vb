<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_about_us
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

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_Description As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_about_us))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_Description = New System.Windows.Forms.TextBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LinkLabel_1 = New System.Windows.Forms.LinkLabel()
        Me.Label_Product_Name = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Label_Copyright = New System.Windows.Forms.Label()
        Me.Label_Company_Name = New System.Windows.Forms.Label()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.TableLayoutPanel.Controls.Add(Me.TextBox_Description, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LinkLabel_1, 1, 5)
        Me.TableLayoutPanel.Controls.Add(Me.Label_Product_Name, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label_Version, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.Label_Copyright, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.Label_Company_Name, 1, 3)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 9)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 7
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(847, 258)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'TextBox_Description
        '
        Me.TextBox_Description.BackColor = System.Drawing.Color.White
        Me.TextBox_Description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Description.Location = New System.Drawing.Point(285, 95)
        Me.TextBox_Description.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBox_Description.Multiline = True
        Me.TextBox_Description.Name = "TextBox_Description"
        Me.TextBox_Description.ReadOnly = True
        Me.TextBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Description.Size = New System.Drawing.Size(559, 113)
        Me.TextBox_Description.TabIndex = 0
        Me.TextBox_Description.TabStop = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.BackgroundImage = Global.Smart_DiaScale_I.My.Resources.Resources.Logo
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 7)
        Me.LogoPictureBox.Size = New System.Drawing.Size(273, 252)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LinkLabel_1
        '
        Me.LinkLabel_1.AutoSize = True
        Me.LinkLabel_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel_1.Location = New System.Drawing.Point(282, 211)
        Me.LinkLabel_1.Name = "LinkLabel_1"
        Me.LinkLabel_1.Size = New System.Drawing.Size(562, 23)
        Me.LinkLabel_1.TabIndex = 1
        Me.LinkLabel_1.TabStop = True
        Me.LinkLabel_1.Text = "LinkLabel_1"
        Me.LinkLabel_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Product_Name
        '
        Me.Label_Product_Name.AutoSize = True
        Me.Label_Product_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Product_Name.Location = New System.Drawing.Point(282, 0)
        Me.Label_Product_Name.Name = "Label_Product_Name"
        Me.Label_Product_Name.Size = New System.Drawing.Size(562, 23)
        Me.Label_Product_Name.TabIndex = 3
        Me.Label_Product_Name.Text = "Label_Product_Name"
        Me.Label_Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Version.Location = New System.Drawing.Point(282, 23)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(562, 23)
        Me.Label_Version.TabIndex = 4
        Me.Label_Version.Text = "Label_Version"
        Me.Label_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Copyright
        '
        Me.Label_Copyright.AutoSize = True
        Me.Label_Copyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Copyright.Location = New System.Drawing.Point(282, 46)
        Me.Label_Copyright.Name = "Label_Copyright"
        Me.Label_Copyright.Size = New System.Drawing.Size(562, 23)
        Me.Label_Copyright.TabIndex = 5
        Me.Label_Copyright.Text = "Label_Copyright"
        Me.Label_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Company_Name
        '
        Me.Label_Company_Name.AutoSize = True
        Me.Label_Company_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Company_Name.Location = New System.Drawing.Point(282, 69)
        Me.Label_Company_Name.Name = "Label_Company_Name"
        Me.Label_Company_Name.Size = New System.Drawing.Size(562, 23)
        Me.Label_Company_Name.TabIndex = 6
        Me.Label_Company_Name.Text = "Label_Company_Name"
        Me.Label_Company_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_about_us
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(865, 276)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_about_us"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_about_us"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LinkLabel_1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_Product_Name As System.Windows.Forms.Label
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents Label_Copyright As System.Windows.Forms.Label
    Friend WithEvents Label_Company_Name As System.Windows.Forms.Label

End Class
