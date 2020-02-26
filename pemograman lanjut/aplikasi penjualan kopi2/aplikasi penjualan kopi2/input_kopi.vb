Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text.RegularExpressions

Public Class input_kopi

    Private Sub input_kopi_Load(sender As Object, e As EventArgs) Handles Me.Load

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("id-ID")
       
        With DataGridView1.Columns
            .Add("kode_kopi", "KODE KOPI")
            .Add("nama_kopi", "NAMA KOPI")
            .Add("harga_beli", "HARGA BELI")
            .Add("harga_jual", "HARGA JUAL")
            .Add("jumlah", "JUMLAH")
            .Add("tanggal_beli", "TANGGAL BELI")

        End With
        load_datagrid()
        load_chart1()
        menipulasidgv()
        disabel()
        Call warnaRebra(DataGridView1)
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Orange
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
        DateTimePicker1.Value.ToString("dd/MM/yyyy")
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        GunaTextBox1.MaxLength = 5
        GunaTextBox2.MaxLength = 20
        TextBox2.MaxLength = 14
        TextBox3.MaxLength = 9
        GunaTextBox5.MaxLength = 2

    End Sub
    Private Sub GunaGradientTileButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientTileButton1.Click
        
        enabel()

        If GunaTextBox1.Text.Length = 0 Then
            GunaTextBox1.Select()

        ElseIf GunaTextBox2.Text.Length = 0 Then
            GunaTextBox2.Select()

        ElseIf TextBox2.Text.Length = 3 Then
            TextBox2.Select()

        ElseIf TextBox3.Text.Length = 3 Then
            TextBox3.Select()

        ElseIf GunaTextBox5.Text.Length = 0 Then
            GunaTextBox5.Select()
        ElseIf Val(TextBox3.Text) < Val(TextBox2.Text) Then
            MsgBox("haga jual harus lebih besar dari harga beli")
            TextBox3.Select()


        Else
            Dim x As Object = MessageBox.Show("Apakah anda ingin menyimpan data?", "konfirmasi", MessageBoxButtons.YesNo)
            If x = Windows.Forms.DialogResult.Yes Then
                With DataGridView1
                    Dim indekBaru = .NewRowIndex
                    .Rows.Insert(indekBaru, GunaTextBox1.Text, GunaTextBox2.Text, TextBox2.Text, TextBox3.Text, GunaTextBox5.Text, DateTimePicker1.Text)
                    .CurrentCell = DataGridView1(.CurrentCell.ColumnIndex, indekBaru)
                    .CurrentRow.Selected = True
                   
                End With

                GunaGradientTileButton1.Text = "TAMBAH"
                Chart1.Series(0).Points.Clear()
                load_gridto_chart()
                menipulasidgv()

                Call warnaRebra(DataGridView1)
                MessageBox.Show("Data telah di simpan", "konfirmasi", MessageBoxButtons.OK)
                GunaTextBox1.Text = ""
                GunaTextBox2.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                GunaTextBox5.Text = ""


            Else

                GunaTextBox1.Text = ""
                GunaTextBox2.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                GunaTextBox5.Text = ""

                MessageBox.Show("Data tidak di simpan", "konfirmasi", MessageBoxButtons.OK)

            End If
        End If


    End Sub





    Private Sub GunaGradientTileButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientTileButton2.Click
        enabel()
        If GunaGradientTileButton2.Text = "UBAH" Then
            GunaTextBox1.Select()
            GunaGradientTileButton2.Text = "SIMPAN"
        Else
            With DataGridView1
                Dim idx = .CurrentRow.Index
                .Rows.RemoveAt(idx)
                .Rows.Insert(idx, GunaTextBox1.Text, GunaTextBox2.Text, TextBox2.Text, TextBox3.Text, GunaTextBox5.Text, DateTimePicker1.Text)
                .CurrentCell = DataGridView1(.CurrentCell.ColumnIndex, idx)
            End With
            GunaGradientTileButton2.Text = "UBAH"
            MessageBox.Show("Data telah di simpan", "konfirmasi", MessageBoxButtons.OK)
        End If
        Chart1.Series(0).Points.Clear()
        load_gridto_chart()
        menipulasidgv()
        Call warnaRebra(DataGridView1)
        MessageBox.Show("Data telah di simpan", "konfirmasi", MessageBoxButtons.OK)
        GunaTextBox1.Text = ""
        GunaTextBox2.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        GunaTextBox5.Text = ""
    End Sub

    Private Sub GunaGradientTileButton7_Click(sender As Object, e As EventArgs) Handles GunaGradientTileButton7.Click
        Dim kolom As Integer = 0
        Dim cari As String = TextBox1.Text + "*"
        Dim data As String
        Dim cek As Boolean
        If GunaRadioButton1.Checked = True Then
            kolom = 0

        End If
        If GunaRadioButton2.Checked = True Then
            kolom = 1

        End If
        For xloop As Integer = 1 To DataGridView1.RowCount - 1
            data = DataGridView1.Rows(xloop - 1).Cells(kolom).Value
            cek = UCase(data) Like UCase(cari)
            If cek = True Then
                DataGridView1.CurrentCell = DataGridView1.Item(kolom, xloop - 1)
                TextBox1.Text = DataGridView1.CurrentCell.Value
                DataGridView1.CurrentRow.Selected = True
                Call tampilkanData()
                Exit Sub
            ElseIf GunaRadioButton1.Checked = False And GunaRadioButton2.Checked = False Then
                TextBox1.Text = ""
                MessageBox.Show("pilih Kode atau Nama!!!", "peringatan", MessageBoxButtons.OK)
                Exit Sub
            End If
        Next
        If cek = False Then
            MessageBox.Show("data tidak ditemukan", "peringatan", MessageBoxButtons.OK)
            TextBox1.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub GunaGradientTileButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientTileButton3.Click
        Dim x As Object = MessageBox.Show("Apakah Anda ingin menghapus ini?", "konfirmasi", MessageBoxButtons.YesNo)
        If x = Windows.Forms.DialogResult.Yes Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            Chart1.Series(0).Points.Clear()
            load_gridto_chart()
            MessageBox.Show("Data telah di hapus", "konfirmasi", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Data tidak di hapus", "konfirmasi", MessageBoxButtons.OK)
        End If

    End Sub

    Sub menipulasidgv()
        'GANTI PANJANG COLUMNS
       
        Me.DataGridView1.Columns(0).Width = 100
        Me.DataGridView1.Columns(1).Width = 180
        Me.DataGridView1.Columns(2).Width = 100
        Me.DataGridView1.Columns(3).Width = 100
        Me.DataGridView1.Columns(4).Width = 100
        Me.DataGridView1.Columns(5).Width = 100
        'GANTI POSISI HEADER
        Me.DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'GANTI SIZE FONT
        Me.DataGridView1.Columns(0).HeaderCell.Style.Font = New Font("Arial", 8, FontStyle.Bold)
        Me.DataGridView1.Columns(1).HeaderCell.Style.Font = New Font("Arial", 8, FontStyle.Bold)
        Me.DataGridView1.Columns(2).HeaderCell.Style.Font = New Font("Arial", 8, FontStyle.Bold)
        Me.DataGridView1.Columns(3).HeaderCell.Style.Font = New Font("Arial", 8, FontStyle.Bold)
        Me.DataGridView1.Columns(4).HeaderCell.Style.Font = New Font("Arial", 8, FontStyle.Bold)
        Me.DataGridView1.Columns(5).HeaderCell.Style.Font = New Font("Arial", 8, FontStyle.Bold)
        'GANTI POSISI ISI DATAGRID
        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'HEADER TIDAK BISA DI CLIK
        Me.DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        'FORMAT RUPIAH
        DataGridView1.Columns(2).DefaultCellStyle.Format = "N2"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N2"

        'RUBAH FONT DATAGRIDVIEW
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 10)
        'RUBAH BARIS DATAGRIDVIEW


    End Sub

    Public Sub warnaRebra(ByVal rDataGridView As DataGridView)
        For Each iniRow As DataGridViewRow In rDataGridView.Rows
            For Each iniCell As DataGridViewCell In iniRow.Cells
                If iniRow.Index Mod 2 = 0 Then
                    iniCell.Style.BackColor = Color.LightGreen
                Else
                    iniCell.Style.BackColor = Color.DarkGreen
                End If
            Next
        Next
    End Sub

    Function load_datagrid()
        'isi datagrid
        Dim row2 As String() = New String() {"KP08002", "Arabika Kerinci", "Rp27.000", "Rp34.000", "3", "20/10/2019"}
        DataGridView1.Rows.Add(row2)
        row2 = New String() {"KP0708", "Arabika Garut", "Rp26.000", "Rp32.000", "5", "25/10/2019"}
        DataGridView1.Rows.Add(row2)
        row2 = New String() {"KP0806", "Arabika Kintamani", "Rp32.000", "Rp37.000", "3", "27/10/2019"}
        DataGridView1.Rows.Add(row2)
        row2 = New String() {"kp06700", "Arabika Temanggung", "Rp25.000", "Rp31.000", "2", "23/10/2019"}
        DataGridView1.Rows.Add(row2)
        row2 = New String() {"KP0708", "Arabika Talagabodas", "Rp25.000", "Rp27.000", "3", "22/10/2019"}
        DataGridView1.Rows.Add(row2)
        row2 = New String() {"KP0806", "Arabika Manggarai", "Rp32.000", "Rp37.000", "3", "21/10/2019"}
        DataGridView1.Rows.Add(row2)
        row2 = New String() {"kp06700", "Arabika Wamena", "Rp25.000", "Rp31.000", "4", "22/10/2019"}
        DataGridView1.Rows.Add(row2)
        row2 = New String() {"KP0708", "Arabika Padang", "Rp26.000", "Rp32.000", "5", "24/10/2019"}
        DataGridView1.Rows.Add(row2)
        row2 = New String() {"KP0806", "Arabika Arjuno", "Rp32.000", "Rp37.000", "6", "25/10/2019"}
        DataGridView1.Rows.Add(row2)
        row2 = New String() {"kp06700", "Arabika Trawas", "Rp25.000", "Rp31.000", "2", "27/10/2019"}
        DataGridView1.Rows.Add(row2)
    End Function
    Function load_chart1()

        Chart1.Series(0).Points.AddXY("Arabika Kerinci", 3)
        Chart1.Series(0).Points.AddXY("Arabika Garut", 5)
        Chart1.Series(0).Points.AddXY("Arabika Kintamani", 3)
        Chart1.Series(0).Points.AddXY("Arabika Temanggung", 2)
        Chart1.Series(0).Points.AddXY("Arabika Talagabodas", 3)
        Chart1.Series(0).Points.AddXY("Arabika Manggarai", 3)
        Chart1.Series(0).Points.AddXY("Arabika Wamena", 4)
        Chart1.Series(0).Points.AddXY("Arabika Padang", 5)
        Chart1.Series(0).Points.AddXY("Arabika Arjuno", 6)
        Chart1.Series(0).Points.AddXY("Arabika Trawas", 2)
    End Function


    Function load_gridto_chart()
        Dim i As Integer

        For i = 0 To DataGridView1.Rows.Count - 1
            If i <> DataGridView1.NewRowIndex Then
                Chart1.Series(0).Points.AddXY(DataGridView1.Item(1, i).Value,
                    DataGridView1.Item(4, i).Value)
            End If
        Next
    End Function

    Function hapus()
        GunaTextBox1.Text = ""
        GunaTextBox2.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        GunaTextBox5.Text = ""

    End Function

    Function enabel()
        GunaTextBox1.Enabled = True
        GunaTextBox2.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        GunaTextBox5.Enabled = True

    End Function
    Function disabel()
        GunaTextBox1.Enabled = False
        GunaTextBox2.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        GunaTextBox5.Enabled = False

    End Function
    'Function validasiTambah()
    '    Dim kode As String = "^[a-zA-Z0-9]$"
    '    Dim namaKopi As String = "^[a-zA-Z]$"
    '    If System.Text.RegularExpressions.Regex.Match(GunaTextBox1.Text, kode).Success Then


    '    End If
    'End Function

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox1.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[A-Z,a-z,0-9]" _
             Or KeyAscii = Keys.Back) Then
            KeyAscii = 0

        End If

        e.Handled = CBool(KeyAscii)


    End Sub

    Private Sub GunaTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox2.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[A-Z,a-z]" _
             OrElse KeyAscii = Keys.Space _
             Or KeyAscii = Keys.Back) Then
            KeyAscii = 0

        End If

        e.Handled = CBool(KeyAscii)


    End Sub

    

    Private Sub GunaTextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox5.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[1-9]" _
             Or KeyAscii = Keys.Back) Then
            KeyAscii = 0

        End If

        e.Handled = CBool(KeyAscii)

    End Sub





    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call tampilkanData()
        GunaGradientTileButton2.Enabled = True
        GunaGradientTileButton1.Enabled = False
        GunaGradientTileButton3.Enabled = True
    End Sub

    Private Sub GunaTextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GunaTextBox1.Validating
        If GunaTextBox1.Text.Length = 0 Then
            ErrorProvider1.SetError(GunaTextBox1, "Input tidak boleh kosong")
            GunaTextBox1.BackColor = Color.Red
            GunaTextBox1.Select()
        Else
            ErrorProvider1.Clear()
        End If
    End Sub
    Private Sub GunaTextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GunaTextBox2.Validating
        If GunaTextBox2.Text.Length = 0 Then
            ErrorProvider2.SetError(GunaTextBox2, "Input tidak boleh kosong")
            GunaTextBox2.BackColor = Color.Red
            GunaTextBox2.Select()
        Else
            ErrorProvider2.Clear()
        End If
    End Sub




    Private Sub GunaTextBox5_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GunaTextBox5.Validating
        If GunaTextBox5.Text.Length = 0 Then
            ErrorProvider5.SetError(GunaTextBox1, "Input tidak boleh kosong")
            GunaTextBox5.BackColor = Color.Red
            GunaTextBox5.Select()
        Else
            ErrorProvider5.Clear()
        End If
    End Sub

    Private Sub GunaGradientTileButton4_Click(sender As Object, e As EventArgs) Handles GunaGradientTileButton4.Click
        hapus()
    End Sub
    Function tampilkanData()
        Dim baris = DataGridView1.CurrentRow.Index
        Dim tgl As String = DataGridView1.Item(5, baris).Value
        Dim expenddt As Date = Date.ParseExact(tgl, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        With DataGridView1
            GunaTextBox1.Text = .Item(0, baris).Value
            GunaTextBox2.Text = .Item(1, baris).Value
            TextBox2.Text = .Item(2, baris).Value
            TextBox3.Text = .Item(3, baris).Value
            GunaTextBox5.Text = .Item(4, baris).Value
            DateTimePicker1.Value = expenddt

        End With
    End Function

  


    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If ((e.KeyChar >= Convert.ToChar(48)) AndAlso (e.KeyChar <= Convert.ToChar(57))) Then ' 0 - 9

            e.Handled = False

        ElseIf (e.KeyChar = Convert.ToChar(8)) Then ' backspace

            e.Handled = False

        ElseIf (e.KeyChar = Convert.ToChar(13)) Then ' enter

            e.Handled = False

        Else

            e.Handled = True

        End If

        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
             Or KeyAscii = Keys.Back) Then
            KeyAscii = 0

        End If

        e.Handled = CBool(KeyAscii)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length <= 2 Then ' jika panjang karakter pada textbox1 <= 2

            TextBox2.Text = FormatCurrency(0) ' menampilkan Rp0

        Else ' jika tidak

            TextBox2.Text = FormatCurrency(TextBox2.Text) ' mengubah format pada textbox1 menjadi currency

            TextBox2.SelectionStart = TextBox2.Text.Length '  menetapkan titik awal dari teks yang dipilih pada textbox

        End If
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating
        If TextBox2.Text.Length = 2 Then
            ErrorProvider3.SetError(TextBox2, "Input tidak boleh kosong")
            TextBox2.BackColor = Color.Red
            TextBox2.Select()
        Else
            ErrorProvider3.Clear()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If ((e.KeyChar >= Convert.ToChar(48)) AndAlso (e.KeyChar <= Convert.ToChar(57))) Then ' 0 - 9

            e.Handled = False

        ElseIf (e.KeyChar = Convert.ToChar(8)) Then ' backspace

            e.Handled = False

        ElseIf (e.KeyChar = Convert.ToChar(13)) Then ' enter

            e.Handled = False

        Else

            e.Handled = True

        End If


        Dim KeyAscii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" _
             Or KeyAscii = Keys.Back) Then
            KeyAscii = 0

        End If

        e.Handled = CBool(KeyAscii)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text.Length <= 2 Then ' jika panjang karakter pada textbox1 <= 2

            TextBox3.Text = FormatCurrency(0) ' menampilkan Rp0

        Else ' jika tidak

            TextBox3.Text = FormatCurrency(TextBox3.Text) ' mengubah format pada textbox1 menjadi currency

            TextBox3.Select() '  menetapkan titik awal dari teks yang dipilih pada textbox

        End If
    End Sub

    Private Sub TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox3.Validating
        If TextBox3.Text.Length = 2 Then
            ErrorProvider4.SetError(TextBox3, "Input tidak boleh kosong dan harga jual harus lebih besar dari beli")
            TextBox3.BackColor = Color.Red
            TextBox3.Select()
        Else
            ErrorProvider4.Clear()
        End If
    End Sub
End Class