Imports System.IO
Imports System.IO.File
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, RichTextBox1.Text, True)
        End If


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Text Files (*)|*.txt"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label2.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog2.Filter = "TXT Files (*.txt*)|*.txt"
        Dim fileawal As String = Label2.Text
        If SaveFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            System.IO.File.Copy(fileawal, SaveFileDialog2.FileName)
            MessageBox.Show("File telah di copy")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OpenFileDialog2 As New OpenFileDialog

        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label4.Text = OpenFileDialog2.FileName
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fl As String = Label4.Text

        'Ini untuk menghapus file
        File.Delete(fl)
        MessageBox.Show("File telah di Delete")
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim OpenFileDialog3 As New OpenFileDialog

        OpenFileDialog3.Filter = "Text Files (*)|*.txt"
        If OpenFileDialog3.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label5.Text = OpenFileDialog3.FileName
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SaveFileDialog3.Filter = "TXT Files (*.txt*)|*.txt"
        Dim fileawal As String = Label5.Text
        If SaveFileDialog3.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            System.IO.File.Move(fileawal, SaveFileDialog3.FileName)
            MessageBox.Show("File telah di Pindah")
        End If
    End Sub


 
End Class
