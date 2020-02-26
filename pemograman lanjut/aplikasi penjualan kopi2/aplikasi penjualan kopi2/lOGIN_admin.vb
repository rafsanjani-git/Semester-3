Public Class lOGIN_admin

 
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        If GunaLineTextBox1.Text = "rafi" And GunaLineTextBox2.Text = "1234" Then
            input_kopi.Show()
            Me.Close()
        Else
            GunaLineTextBox1.Text = ""
            GunaLineTextBox2.Text = ""

            MessageBox.Show("Silahkan Masukkan Username & Pasword", "Warning", MessageBoxButtons.OK)
        End If
    End Sub
End Class