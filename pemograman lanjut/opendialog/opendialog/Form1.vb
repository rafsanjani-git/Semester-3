Imports System.IO
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Label1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fileawal As String = Label1.Text
        Dim filepindahan As String = "C:\coba\copy3.jpg"

        File.Copy(fileawal, filepindahan, True)
        MessageBox.Show("file telah di pindah ke" + filepindahan + "", "pemberitahuan")
    End Sub
End Class
