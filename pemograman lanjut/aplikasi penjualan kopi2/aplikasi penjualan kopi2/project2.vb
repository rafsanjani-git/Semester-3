
Imports System.IO

Public Class project2

    Private Sub btn_searchfilecopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_searchfilecopy.Click
        ' Mendapatkan filename yang akan di copy
        Dim result As DialogResult = OFDCopy.ShowDialog
        If (result = System.Windows.Forms.DialogResult.OK) Then
            txt_filecopy.Text = OFDCopy.FileName
        End If
    End Sub

    Private Sub btn_searchfoldercopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_searchfoldercopy.Click
        ' Mendapatkan folder tujuan 
        Dim result As DialogResult = FBDCopy.ShowDialog
        If (result = System.Windows.Forms.DialogResult.OK) Then
            txt_foldercopy.Text = (FBDCopy.SelectedPath + ("\" + OFDCopy.SafeFileName))
        End If
    End Sub

    Private Sub btn_copyfile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_copyfile.Click
        If ((txt_filecopy.Text.Trim <> "") Or (txt_foldercopy.Text.Trim <> "")) Then
            ' Menjalankan procedure untuk mengcopy file
            System.IO.File.Copy(txt_filecopy.Text, txt_foldercopy.Text)
            MessageBox.Show("File berhasil dicopy", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_searchfilemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_searchfilemove.Click
        ' mendapatkan file yang akan di pindahkan
        Dim result As DialogResult = OFDCopy.ShowDialog
        If (result = System.Windows.Forms.DialogResult.OK) Then
            txt_filemove.Text = OFDCopy.FileName
        End If
    End Sub

    Private Sub btn_searchfoldermove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_searchfoldermove.Click
        ' mendapatkan folder tujuan
        Dim result As DialogResult = FBDCopy.ShowDialog
        If (result = System.Windows.Forms.DialogResult.OK) Then
            txt_foldermove.Text = (FBDCopy.SelectedPath + ("\" + OFDCopy.SafeFileName))
        End If
    End Sub

    Private Sub btn_move_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_move.Click
        If ((txt_filemove.Text.Trim <> "") Or (txt_foldermove.Text.Trim <> "")) Then
            ' menjalankan procedure untuk memindahkan file
            System.IO.File.Move(txt_filemove.Text, txt_foldermove.Text)
            MessageBox.Show("File berhasil dipindahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_searchfiledelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_searchfiledelete.Click
        ' mendapatkan file yang akan dihapus
        Dim result As DialogResult = OFDCopy.ShowDialog
        If (result = System.Windows.Forms.DialogResult.OK) Then
            txt_filedelete.Text = OFDCopy.FileName
        End If
    End Sub

    Private Sub btn_delete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_delete.Click
        If (txt_filedelete.Text.Trim <> "") Then
            ' menjalankan procedure untuk` menghapus file
            System.IO.File.Delete(txt_filedelete.Text)
            MessageBox.Show("File berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    Private Sub btn_searchfoldercreate_Click(sender As Object, e As EventArgs) Handles btn_searchfoldercreate.Click
        Dim result As DialogResult = FBDCopy.ShowDialog
        If (result = System.Windows.Forms.DialogResult.OK) Then
            txt_foldercreate.Text = (FBDCopy.SelectedPath)
        End If
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Dim fs As FileStream = Nothing

        Dim fileLoc As String = txt_foldercreate.Text + ("\" + txt_filename.Text)


        If (Not File.Exists(fileLoc)) Then
            fs = File.Create(fileLoc)
            Using fs

            End Using
            MessageBox.Show("File berhasil dibuat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_create.Enabled = False
    End Sub

    Private Sub txt_filename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_filename.KeyPress
        btn_create.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menuAwal.Show()
        Me.Close()
    End Sub
End Class

