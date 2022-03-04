Public Class Form_every_start
    Dim Integer_Time As Integer = 0

    Private Sub Form_every_start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Enabled = True
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'Objects
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Integer_Time += 1

        If Integer_Time = 5 Then
            If My.Settings.First_start = 0 Then
                Form_first_start_1.Show()
            Else
                Public_Determine_Layout()
                Form_security_enter_app.Show()
            End If

            Timer.Enabled = False
            Me.Close()
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class