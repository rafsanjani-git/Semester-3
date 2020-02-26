<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class project2
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_filename = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.btn_searchfoldercreate = New System.Windows.Forms.Button()
        Me.txt_foldercreate = New System.Windows.Forms.TextBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_searchfiledelete = New System.Windows.Forms.Button()
        Me.txt_filedelete = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_move = New System.Windows.Forms.Button()
        Me.btn_searchfilemove = New System.Windows.Forms.Button()
        Me.btn_searchfoldermove = New System.Windows.Forms.Button()
        Me.txt_foldermove = New System.Windows.Forms.TextBox()
        Me.txt_filemove = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_copyfile = New System.Windows.Forms.Button()
        Me.btn_searchfilecopy = New System.Windows.Forms.Button()
        Me.btn_searchfoldercopy = New System.Windows.Forms.Button()
        Me.txt_foldercopy = New System.Windows.Forms.TextBox()
        Me.txt_filecopy = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.OFDCopy = New System.Windows.Forms.OpenFileDialog()
        Me.FBDCopy = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txt_filename)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.btn_create)
        Me.GroupBox4.Controls.Add(Me.btn_searchfoldercreate)
        Me.GroupBox4.Controls.Add(Me.txt_foldercreate)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(304, 110)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Create File"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nama file"
        '
        'txt_filename
        '
        Me.txt_filename.Location = New System.Drawing.Point(99, 55)
        Me.txt_filename.Name = "txt_filename"
        Me.txt_filename.Size = New System.Drawing.Size(154, 20)
        Me.txt_filename.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tujuan"
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(99, 81)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 7
        Me.btn_create.Text = "CREATE"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'btn_searchfoldercreate
        '
        Me.btn_searchfoldercreate.Location = New System.Drawing.Point(259, 24)
        Me.btn_searchfoldercreate.Name = "btn_searchfoldercreate"
        Me.btn_searchfoldercreate.Size = New System.Drawing.Size(28, 23)
        Me.btn_searchfoldercreate.TabIndex = 9
        Me.btn_searchfoldercreate.Text = "..."
        Me.btn_searchfoldercreate.UseVisualStyleBackColor = True
        '
        'txt_foldercreate
        '
        Me.txt_foldercreate.Location = New System.Drawing.Point(99, 26)
        Me.txt_foldercreate.Name = "txt_foldercreate"
        Me.txt_foldercreate.Size = New System.Drawing.Size(154, 20)
        Me.txt_foldercreate.TabIndex = 8
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btn_delete)
        Me.groupBox3.Controls.Add(Me.btn_searchfiledelete)
        Me.groupBox3.Controls.Add(Me.txt_filedelete)
        Me.groupBox3.Controls.Add(Me.label6)
        Me.groupBox3.Location = New System.Drawing.Point(336, 24)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(312, 110)
        Me.groupBox3.TabIndex = 12
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Delete File"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(127, 81)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 6
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_searchfiledelete
        '
        Me.btn_searchfiledelete.Location = New System.Drawing.Point(259, 24)
        Me.btn_searchfiledelete.Name = "btn_searchfiledelete"
        Me.btn_searchfiledelete.Size = New System.Drawing.Size(28, 23)
        Me.btn_searchfiledelete.TabIndex = 5
        Me.btn_searchfiledelete.Text = "..."
        Me.btn_searchfiledelete.UseVisualStyleBackColor = True
        '
        'txt_filedelete
        '
        Me.txt_filedelete.Location = New System.Drawing.Point(99, 26)
        Me.txt_filedelete.Name = "txt_filedelete"
        Me.txt_filedelete.Size = New System.Drawing.Size(154, 20)
        Me.txt_filedelete.TabIndex = 2
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(18, 29)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(26, 13)
        Me.label6.TabIndex = 0
        Me.label6.Text = "File "
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btn_move)
        Me.groupBox2.Controls.Add(Me.btn_searchfilemove)
        Me.groupBox2.Controls.Add(Me.btn_searchfoldermove)
        Me.groupBox2.Controls.Add(Me.txt_foldermove)
        Me.groupBox2.Controls.Add(Me.txt_filemove)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Location = New System.Drawing.Point(12, 153)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(312, 130)
        Me.groupBox2.TabIndex = 11
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Move File"
        '
        'btn_move
        '
        Me.btn_move.Location = New System.Drawing.Point(99, 92)
        Me.btn_move.Name = "btn_move"
        Me.btn_move.Size = New System.Drawing.Size(75, 23)
        Me.btn_move.TabIndex = 6
        Me.btn_move.Text = "Move"
        Me.btn_move.UseVisualStyleBackColor = True
        '
        'btn_searchfilemove
        '
        Me.btn_searchfilemove.Location = New System.Drawing.Point(259, 24)
        Me.btn_searchfilemove.Name = "btn_searchfilemove"
        Me.btn_searchfilemove.Size = New System.Drawing.Size(28, 23)
        Me.btn_searchfilemove.TabIndex = 5
        Me.btn_searchfilemove.Text = "..."
        Me.btn_searchfilemove.UseVisualStyleBackColor = True
        '
        'btn_searchfoldermove
        '
        Me.btn_searchfoldermove.Location = New System.Drawing.Point(259, 59)
        Me.btn_searchfoldermove.Name = "btn_searchfoldermove"
        Me.btn_searchfoldermove.Size = New System.Drawing.Size(28, 23)
        Me.btn_searchfoldermove.TabIndex = 4
        Me.btn_searchfoldermove.Text = "...."
        Me.btn_searchfoldermove.UseVisualStyleBackColor = True
        '
        'txt_foldermove
        '
        Me.txt_foldermove.Location = New System.Drawing.Point(99, 61)
        Me.txt_foldermove.Name = "txt_foldermove"
        Me.txt_foldermove.Size = New System.Drawing.Size(154, 20)
        Me.txt_foldermove.TabIndex = 3
        '
        'txt_filemove
        '
        Me.txt_filemove.Location = New System.Drawing.Point(99, 26)
        Me.txt_filemove.Name = "txt_filemove"
        Me.txt_filemove.Size = New System.Drawing.Size(154, 20)
        Me.txt_filemove.TabIndex = 2
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(18, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(40, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Tujuan"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(18, 29)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(26, 13)
        Me.label4.TabIndex = 0
        Me.label4.Text = "File "
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btn_copyfile)
        Me.groupBox1.Controls.Add(Me.btn_searchfilecopy)
        Me.groupBox1.Controls.Add(Me.btn_searchfoldercopy)
        Me.groupBox1.Controls.Add(Me.txt_foldercopy)
        Me.groupBox1.Controls.Add(Me.txt_filecopy)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(336, 153)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(312, 130)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Copy File"
        '
        'btn_copyfile
        '
        Me.btn_copyfile.Location = New System.Drawing.Point(99, 92)
        Me.btn_copyfile.Name = "btn_copyfile"
        Me.btn_copyfile.Size = New System.Drawing.Size(75, 23)
        Me.btn_copyfile.TabIndex = 6
        Me.btn_copyfile.Text = "Copy"
        Me.btn_copyfile.UseVisualStyleBackColor = True
        '
        'btn_searchfilecopy
        '
        Me.btn_searchfilecopy.Location = New System.Drawing.Point(259, 24)
        Me.btn_searchfilecopy.Name = "btn_searchfilecopy"
        Me.btn_searchfilecopy.Size = New System.Drawing.Size(28, 23)
        Me.btn_searchfilecopy.TabIndex = 5
        Me.btn_searchfilecopy.Text = "..."
        Me.btn_searchfilecopy.UseVisualStyleBackColor = True
        '
        'btn_searchfoldercopy
        '
        Me.btn_searchfoldercopy.Location = New System.Drawing.Point(259, 59)
        Me.btn_searchfoldercopy.Name = "btn_searchfoldercopy"
        Me.btn_searchfoldercopy.Size = New System.Drawing.Size(28, 23)
        Me.btn_searchfoldercopy.TabIndex = 4
        Me.btn_searchfoldercopy.Text = "...."
        Me.btn_searchfoldercopy.UseVisualStyleBackColor = True
        '
        'txt_foldercopy
        '
        Me.txt_foldercopy.Location = New System.Drawing.Point(99, 61)
        Me.txt_foldercopy.Name = "txt_foldercopy"
        Me.txt_foldercopy.Size = New System.Drawing.Size(154, 20)
        Me.txt_foldercopy.TabIndex = 3
        '
        'txt_filecopy
        '
        Me.txt_filecopy.Location = New System.Drawing.Point(99, 26)
        Me.txt_filecopy.Name = "txt_filecopy"
        Me.txt_filecopy.Size = New System.Drawing.Size(154, 20)
        Me.txt_filecopy.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(18, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Tujuan"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(18, 29)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(26, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "File "
        '
        'OFDCopy
        '
        Me.OFDCopy.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(289, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 35)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Menu Awal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'project2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 335)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "project2"
        Me.Text = "project2"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_filename As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents btn_create As System.Windows.Forms.Button
    Private WithEvents btn_searchfoldercreate As System.Windows.Forms.Button
    Private WithEvents txt_foldercreate As System.Windows.Forms.TextBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents btn_delete As System.Windows.Forms.Button
    Private WithEvents btn_searchfiledelete As System.Windows.Forms.Button
    Private WithEvents txt_filedelete As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btn_move As System.Windows.Forms.Button
    Private WithEvents btn_searchfilemove As System.Windows.Forms.Button
    Private WithEvents btn_searchfoldermove As System.Windows.Forms.Button
    Private WithEvents txt_foldermove As System.Windows.Forms.TextBox
    Private WithEvents txt_filemove As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btn_copyfile As System.Windows.Forms.Button
    Private WithEvents btn_searchfilecopy As System.Windows.Forms.Button
    Private WithEvents btn_searchfoldercopy As System.Windows.Forms.Button
    Private WithEvents txt_foldercopy As System.Windows.Forms.TextBox
    Private WithEvents txt_filecopy As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents OFDCopy As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FBDCopy As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
