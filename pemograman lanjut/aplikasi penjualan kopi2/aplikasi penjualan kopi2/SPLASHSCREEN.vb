Public Class SPLASHSCREEN

    Private Sub SPLASHSCREEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 5
        If Panel2.Width >= 700 Then
            Timer1.Dispose()
            Me.Visible = False
            menuAwal.Show()


        End If
    End Sub


End Class