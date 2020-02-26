Public Class PELANGGAN

 
    Private Sub BIJIKOPIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BIJIKOPIToolStripMenuItem.Click
        lblSelected1.Visible = True
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False

        biji_kopi.Show()
        biji_kopi.MdiParent = Me
    End Sub

    
    
    Private Sub BUBUKKOPIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUBUKKOPIToolStripMenuItem.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = True
        lblSelected3.Visible = False
        lblSelected4.Visible = False
    End Sub

    Private Sub COFFEEROASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COFFEEROASTERToolStripMenuItem.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = True
        lblSelected4.Visible = False
    End Sub

    Private Sub COFFEEMACHINEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COFFEEMACHINEToolStripMenuItem.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = True
    End Sub


End Class