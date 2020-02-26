<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class input_kopi
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(input_kopi))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaGroupBox4 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaGradientTileButton7 = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GunaRadioButton2 = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaRadioButton1 = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaGradientTileButton4 = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.GunaGradientTileButton3 = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.GunaGradientTileButton2 = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.GunaGradientTileButton1 = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox5 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.GunaGroupBox4.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 397)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(509, 220)
        Me.DataGridView1.TabIndex = 2
        '
        'Chart1
        '
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin5
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(521, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Jumlah (KG)"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(836, 614)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaGroupBox4)
        Me.GunaGradientPanel1.Controls.Add(Me.Chart1)
        Me.GunaGradientPanel1.Controls.Add(Me.DataGridView1)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaGradientTileButton4)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaGradientTileButton3)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaGradientTileButton2)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaGradientTileButton1)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaGroupBox1)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Maroon
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.Orange
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(20, 60)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(1360, 620)
        Me.GunaGradientPanel1.TabIndex = 0
        Me.GunaGradientPanel1.Text = "panel1"
        '
        'GunaGroupBox4
        '
        Me.GunaGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox4.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox4.Controls.Add(Me.GunaGradientTileButton7)
        Me.GunaGroupBox4.Controls.Add(Me.TextBox1)
        Me.GunaGroupBox4.Controls.Add(Me.GunaRadioButton2)
        Me.GunaGroupBox4.Controls.Add(Me.GunaRadioButton1)
        Me.GunaGroupBox4.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox4.Location = New System.Drawing.Point(6, 294)
        Me.GunaGroupBox4.Name = "GunaGroupBox4"
        Me.GunaGroupBox4.Size = New System.Drawing.Size(509, 97)
        Me.GunaGroupBox4.TabIndex = 7
        Me.GunaGroupBox4.Text = "CARI DATA"
        Me.GunaGroupBox4.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaGradientTileButton7
        '
        Me.GunaGradientTileButton7.AnimationHoverSpeed = 0.07!
        Me.GunaGradientTileButton7.AnimationSpeed = 0.03!
        Me.GunaGradientTileButton7.BaseColor1 = System.Drawing.Color.PaleVioletRed
        Me.GunaGradientTileButton7.BaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientTileButton7.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientTileButton7.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaGradientTileButton7.ForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton7.Image = Nothing
        Me.GunaGradientTileButton7.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaGradientTileButton7.Location = New System.Drawing.Point(405, 42)
        Me.GunaGradientTileButton7.Name = "GunaGradientTileButton7"
        Me.GunaGradientTileButton7.OnHoverBaseColor1 = System.Drawing.Color.DarkOrange
        Me.GunaGradientTileButton7.OnHoverBaseColor2 = System.Drawing.Color.Gold
        Me.GunaGradientTileButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton7.OnHoverImage = Nothing
        Me.GunaGradientTileButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton7.Size = New System.Drawing.Size(89, 44)
        Me.GunaGradientTileButton7.TabIndex = 8
        Me.GunaGradientTileButton7.Text = "CARI"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 44)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(301, 44)
        Me.TextBox1.TabIndex = 9
        '
        'GunaRadioButton2
        '
        Me.GunaRadioButton2.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButton2.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButton2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButton2.FillColor = System.Drawing.Color.White
        Me.GunaRadioButton2.Location = New System.Drawing.Point(3, 42)
        Me.GunaRadioButton2.Name = "GunaRadioButton2"
        Me.GunaRadioButton2.Size = New System.Drawing.Size(92, 20)
        Me.GunaRadioButton2.TabIndex = 2
        Me.GunaRadioButton2.Text = "NAMA KOPI"
        '
        'GunaRadioButton1
        '
        Me.GunaRadioButton1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButton1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButton1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButton1.FillColor = System.Drawing.Color.White
        Me.GunaRadioButton1.Location = New System.Drawing.Point(3, 68)
        Me.GunaRadioButton1.Name = "GunaRadioButton1"
        Me.GunaRadioButton1.Size = New System.Drawing.Size(92, 20)
        Me.GunaRadioButton1.TabIndex = 1
        Me.GunaRadioButton1.Text = "KODE KOPI"
        '
        'GunaGradientTileButton4
        '
        Me.GunaGradientTileButton4.AnimationHoverSpeed = 0.07!
        Me.GunaGradientTileButton4.AnimationSpeed = 0.03!
        Me.GunaGradientTileButton4.BaseColor1 = System.Drawing.Color.PaleVioletRed
        Me.GunaGradientTileButton4.BaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientTileButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientTileButton4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.GunaGradientTileButton4.ForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton4.Image = Nothing
        Me.GunaGradientTileButton4.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaGradientTileButton4.Location = New System.Drawing.Point(382, 258)
        Me.GunaGradientTileButton4.Name = "GunaGradientTileButton4"
        Me.GunaGradientTileButton4.OnHoverBaseColor1 = System.Drawing.Color.DarkOrange
        Me.GunaGradientTileButton4.OnHoverBaseColor2 = System.Drawing.Color.Gold
        Me.GunaGradientTileButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton4.OnHoverImage = Nothing
        Me.GunaGradientTileButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton4.Size = New System.Drawing.Size(133, 31)
        Me.GunaGradientTileButton4.TabIndex = 4
        Me.GunaGradientTileButton4.Text = "HAPUS SEMUA"
        '
        'GunaGradientTileButton3
        '
        Me.GunaGradientTileButton3.AnimationHoverSpeed = 0.07!
        Me.GunaGradientTileButton3.AnimationSpeed = 0.03!
        Me.GunaGradientTileButton3.BaseColor1 = System.Drawing.Color.PaleVioletRed
        Me.GunaGradientTileButton3.BaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientTileButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientTileButton3.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaGradientTileButton3.ForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton3.Image = Nothing
        Me.GunaGradientTileButton3.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaGradientTileButton3.Location = New System.Drawing.Point(256, 258)
        Me.GunaGradientTileButton3.Name = "GunaGradientTileButton3"
        Me.GunaGradientTileButton3.OnHoverBaseColor1 = System.Drawing.Color.DarkOrange
        Me.GunaGradientTileButton3.OnHoverBaseColor2 = System.Drawing.Color.Gold
        Me.GunaGradientTileButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton3.OnHoverImage = Nothing
        Me.GunaGradientTileButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton3.Size = New System.Drawing.Size(89, 31)
        Me.GunaGradientTileButton3.TabIndex = 3
        Me.GunaGradientTileButton3.Text = "HAPUS"
        '
        'GunaGradientTileButton2
        '
        Me.GunaGradientTileButton2.AnimationHoverSpeed = 0.07!
        Me.GunaGradientTileButton2.AnimationSpeed = 0.03!
        Me.GunaGradientTileButton2.BaseColor1 = System.Drawing.Color.PaleVioletRed
        Me.GunaGradientTileButton2.BaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientTileButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientTileButton2.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaGradientTileButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton2.Image = Nothing
        Me.GunaGradientTileButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaGradientTileButton2.Location = New System.Drawing.Point(140, 257)
        Me.GunaGradientTileButton2.Name = "GunaGradientTileButton2"
        Me.GunaGradientTileButton2.OnHoverBaseColor1 = System.Drawing.Color.DarkOrange
        Me.GunaGradientTileButton2.OnHoverBaseColor2 = System.Drawing.Color.Gold
        Me.GunaGradientTileButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton2.OnHoverImage = Nothing
        Me.GunaGradientTileButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton2.Size = New System.Drawing.Size(89, 31)
        Me.GunaGradientTileButton2.TabIndex = 2
        Me.GunaGradientTileButton2.Text = "UBAH"
        '
        'GunaGradientTileButton1
        '
        Me.GunaGradientTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientTileButton1.AnimationSpeed = 0.03!
        Me.GunaGradientTileButton1.BaseColor1 = System.Drawing.Color.PaleVioletRed
        Me.GunaGradientTileButton1.BaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientTileButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientTileButton1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaGradientTileButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton1.Image = Nothing
        Me.GunaGradientTileButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaGradientTileButton1.Location = New System.Drawing.Point(7, 257)
        Me.GunaGradientTileButton1.Name = "GunaGradientTileButton1"
        Me.GunaGradientTileButton1.OnHoverBaseColor1 = System.Drawing.Color.DarkOrange
        Me.GunaGradientTileButton1.OnHoverBaseColor2 = System.Drawing.Color.Gold
        Me.GunaGradientTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton1.OnHoverImage = Nothing
        Me.GunaGradientTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton1.Size = New System.Drawing.Size(97, 31)
        Me.GunaGradientTileButton1.TabIndex = 1
        Me.GunaGradientTileButton1.Text = "TAMBAH"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.DarkGoldenrod
        Me.GunaGroupBox1.Controls.Add(Me.TextBox3)
        Me.GunaGroupBox1.Controls.Add(Me.TextBox2)
        Me.GunaGroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GunaGroupBox1.Controls.Add(Me.GunaTextBox1)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel12)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel11)
        Me.GunaGroupBox1.Controls.Add(Me.GunaTextBox5)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel10)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaTextBox2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.DarkKhaki
        Me.GunaGroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(508, 249)
        Me.GunaGroupBox1.TabIndex = 0
        Me.GunaGroupBox1.Text = "INPUT DATA KOPI"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(262, 147)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(232, 23)
        Me.TextBox3.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(262, 109)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(232, 23)
        Me.TextBox2.TabIndex = 20
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CausesValidation = False
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(262, 218)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.Location = New System.Drawing.Point(262, 33)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(232, 30)
        Me.GunaTextBox1.TabIndex = 18
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel12.Location = New System.Drawing.Point(3, 178)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(92, 28)
        Me.GunaLabel12.TabIndex = 17
        Me.GunaLabel12.Text = "JUMLAH "
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel11.Location = New System.Drawing.Point(229, 178)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(16, 28)
        Me.GunaLabel11.TabIndex = 16
        Me.GunaLabel11.Text = ":"
        '
        'GunaTextBox5
        '
        Me.GunaTextBox5.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox5.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox5.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox5.Location = New System.Drawing.Point(262, 176)
        Me.GunaTextBox5.Name = "GunaTextBox5"
        Me.GunaTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox5.Size = New System.Drawing.Size(232, 30)
        Me.GunaTextBox5.TabIndex = 15
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel10.Location = New System.Drawing.Point(3, 146)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(126, 28)
        Me.GunaLabel10.TabIndex = 14
        Me.GunaLabel10.Text = "HARGA JUAL"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(229, 144)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(16, 28)
        Me.GunaLabel9.TabIndex = 13
        Me.GunaLabel9.Text = ":"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(229, 213)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(16, 28)
        Me.GunaLabel8.TabIndex = 11
        Me.GunaLabel8.Text = ":"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(229, 103)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(16, 28)
        Me.GunaLabel7.TabIndex = 10
        Me.GunaLabel7.Text = ":"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(229, 68)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(16, 28)
        Me.GunaLabel6.TabIndex = 9
        Me.GunaLabel6.Text = ":"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(229, 33)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(16, 28)
        Me.GunaLabel5.TabIndex = 8
        Me.GunaLabel5.Text = ":"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(3, 215)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(140, 28)
        Me.GunaLabel4.TabIndex = 7
        Me.GunaLabel4.Text = "TANGGAL BELI"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(3, 106)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(118, 28)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "HARGA BELI"
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox2.Location = New System.Drawing.Point(262, 69)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Size = New System.Drawing.Size(232, 30)
        Me.GunaTextBox2.TabIndex = 3
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 69)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(119, 28)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "NAMA KOPI"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(3, 31)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(63, 28)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "KODE"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'ErrorProvider5
        '
        Me.ErrorProvider5.ContainerControl = Me
        '
        'input_kopi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 700)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Name = "input_kopi"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TransparencyKey = System.Drawing.Color.MediumVioletRed
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGroupBox4.ResumeLayout(False)
        Me.GunaGroupBox4.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGradientTileButton4 As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents GunaGradientTileButton3 As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents GunaGradientTileButton2 As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents GunaGradientTileButton1 As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox5 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaGroupBox4 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaRadioButton2 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaRadioButton1 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GunaGradientTileButton7 As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider4 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider5 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
