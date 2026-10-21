<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventaris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudulForm = New Label()
        lblKodeBuku = New Label()
        txtKodeBuku = New TextBox()
        lblJudul = New Label()
        txtJudul = New TextBox()
        lblPenulis = New Label()
        txtPenulis = New TextBox()
        lblKategori = New Label()
        cboKategori = New ComboBox()
        lblTahun = New Label()
        txtTahun = New TextBox()
        lblStok = New Label()
        txtStok = New TextBox()
        btnTambah = New Button()
        btnBersihkan = New Button()
        lblCari = New Label()
        txtCari = New TextBox()
        lblFilter = New Label()
        cboFilterKategori = New ComboBox()
        dgvBuku = New DataGridView()
        lblJumlah = New Label()
        lblTotalStok = New Label()
        bsBuku = New BindingSource(components)
        errBuku = New ErrorProvider(components)
        cboUrut = New ComboBox()
        lblUrut = New Label()
        chkStokHabis = New CheckBox()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(31, 29)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(332, 31)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(31, 93)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(80, 20)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode Buku"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(31, 116)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(359, 27)
        txtKodeBuku.TabIndex = 2
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(31, 157)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(43, 20)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Judul"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(31, 180)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(359, 27)
        txtJudul.TabIndex = 4
        ' 
        ' lblPenulis
        ' 
        lblPenulis.AutoSize = True
        lblPenulis.Location = New Point(31, 223)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New Size(54, 20)
        lblPenulis.TabIndex = 5
        lblPenulis.Text = "Penulis"
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(31, 246)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(359, 27)
        txtPenulis.TabIndex = 6
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(31, 292)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(66, 20)
        lblKategori.TabIndex = 7
        lblKategori.Text = "Kategori"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Romansa Klasik", "Horor", "Misteri", "Fiksi", "Nonfiksi", "Referensi", "Majalah", "Komik", "Biografi", "Sejarah", "Sains & Teknologi", "Pelajaran", "Kamus"})
        cboKategori.Location = New Point(31, 317)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(359, 28)
        cboKategori.TabIndex = 8
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Location = New Point(31, 364)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(47, 20)
        lblTahun.TabIndex = 9
        lblTahun.Text = "Tahun"
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(31, 389)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(359, 27)
        txtTahun.TabIndex = 10
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(31, 439)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(38, 20)
        lblStok.TabIndex = 11
        lblStok.Text = "Stok"
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(31, 462)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(359, 27)
        txtStok.TabIndex = 12
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(221, 521)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(169, 47)
        btnTambah.TabIndex = 13
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(31, 521)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(166, 47)
        btnBersihkan.TabIndex = 14
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(472, 93)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(127, 20)
        lblCari.TabIndex = 15
        lblCari.Text = "Cari Judul/Penulis:"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(472, 116)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(610, 27)
        txtCari.TabIndex = 16
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Location = New Point(472, 157)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(106, 20)
        lblFilter.TabIndex = 17
        lblFilter.Text = "Filter Kategori:"
        ' 
        ' cboFilterKategori
        ' 
        cboFilterKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Romansa Klasik", "Horor", "Misteri", "Fiksi", "Nonfiksi", "Referensi", "Majalah", "Komik", "Biografi", "Sejarah", "Sains & Teknologi", "Pelajaran", "Kamus"})
        cboFilterKategori.Location = New Point(472, 180)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New Size(178, 28)
        cboFilterKategori.TabIndex = 18
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(472, 228)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New Size(610, 275)
        dgvBuku.TabIndex = 19
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(472, 521)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(189, 20)
        lblJumlah.TabIndex = 20
        lblJumlah.Text = "Menampilkan 0 dari 0 buku"
        ' 
        ' lblTotalStok
        ' 
        lblTotalStok.AutoSize = True
        lblTotalStok.Location = New Point(472, 548)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New Size(90, 20)
        lblTotalStok.TabIndex = 21
        lblTotalStok.Text = "Total Stok: 0"
        ' 
        ' errBuku
        ' 
        errBuku.ContainerControl = Me
        ' 
        ' cboUrut
        ' 
        cboUrut.DropDownStyle = ComboBoxStyle.DropDownList
        cboUrut.FormattingEnabled = True
        cboUrut.Items.AddRange(New Object() {"Urutan awal", "Judul A-Z", "Tahun terbaru", "Stok terbanyak"})
        cboUrut.Location = New Point(854, 180)
        cboUrut.Name = "cboUrut"
        cboUrut.Size = New Size(228, 28)
        cboUrut.TabIndex = 22
        ' 
        ' lblUrut
        ' 
        lblUrut.AutoSize = True
        lblUrut.Location = New Point(854, 157)
        lblUrut.Name = "lblUrut"
        lblUrut.Size = New Size(96, 20)
        lblUrut.TabIndex = 23
        lblUrut.Text = "Urutkan buku"
        ' 
        ' chkStokHabis
        ' 
        chkStokHabis.AutoSize = True
        chkStokHabis.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkStokHabis.Location = New Point(670, 184)
        chkStokHabis.Name = "chkStokHabis"
        chkStokHabis.Size = New Size(129, 21)
        chkStokHabis.TabIndex = 24
        chkStokHabis.Text = "Hanya stok habis"
        chkStokHabis.UseVisualStyleBackColor = True
        ' 
        ' FormInventaris
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 603)
        Controls.Add(chkStokHabis)
        Controls.Add(lblUrut)
        Controls.Add(cboUrut)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(dgvBuku)
        Controls.Add(cboFilterKategori)
        Controls.Add(lblFilter)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(txtStok)
        Controls.Add(lblStok)
        Controls.Add(txtTahun)
        Controls.Add(lblTahun)
        Controls.Add(cboKategori)
        Controls.Add(lblKategori)
        Controls.Add(txtPenulis)
        Controls.Add(lblPenulis)
        Controls.Add(txtJudul)
        Controls.Add(lblJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        Name = "FormInventaris"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventaris Buku Perpustakaan"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblPenulis As Label
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents lblTahun As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents lblStok As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents cboFilterKategori As ComboBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents bsBuku As BindingSource
    Friend WithEvents errBuku As ErrorProvider
    Friend WithEvents lblUrut As Label
    Friend WithEvents cboUrut As ComboBox
    Friend WithEvents chkStokHabis As CheckBox

End Class
