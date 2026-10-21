Imports System.Data

Public Class FormInventaris

    ' Membuat DataTable di memori
    Private ReadOnly tabelBuku As New DataTable("Buku")

    Private Sub FormInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Buat Struktur Kolom
        tabelBuku.Columns.Add("KodeBuku", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("Tahun", GetType(Integer))
        tabelBuku.Columns.Add("Stok", GetType(Integer))

        ' Isi Data Awal (Judul buku & Penulis)
        tabelBuku.Rows.Add("BK0001", "Pride and Prejudice", "Jane Austen", "Fiksi", 1813, 5)
        tabelBuku.Rows.Add("BK0002", "Sense and Sensibility", "Jane Austen", "Fiksi", 1811, 3)
        tabelBuku.Rows.Add("BK0003", "Teka-Teki Rumah Aneh", "Udagawa Gakuto", "Horor", 2011, 0)
        tabelBuku.Rows.Add("BK0004", "Gadis Kretek", "Ratih Kumala", "Fiksi", 2012, 4)
        tabelBuku.Rows.Add("BK0005", "Bumi Manusia", "Pramoedya A. Toer", "Fiksi", 1980, 2)
        tabelBuku.Rows.Add("BK0006", "Cantik Itu Luka", "Eka Kurniawan", "Fiksi", 2002, 6)
        tabelBuku.Rows.Add("BK0007", "Another", "Yukito Ayatsuji", "Horor", 2009, 0)
        tabelBuku.Rows.Add("BK0008", "Holy Mother", "Rikako Akiyoshi", "Horor", 2015, 10)
        tabelBuku.Rows.Add("BK0009", "Buku E-Application", "Nadya", "Pelajaran", 2020, 8)
        tabelBuku.Rows.Add("BK0010", "Sejarah Sastra Dunia", "Mingyu", "Nonfiksi", 2019, 7)

        ' Ikat ke BindingSource dan DataGridView
        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku

        ' Atur Kerapian Kolom Grid
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
        dgvBuku.Columns("Judul").FillWeight = 200
        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Set nilai awal ComboBox Filter & Urut
        cboFilterKategori.SelectedIndex = 0 ' "Semua"
        cboUrut.SelectedIndex = 0           ' "Urutan awal"

        TerapkanFilter() ' Panggil fungsi untuk pertama kali
    End Sub

    Private Sub TerapkanFilter()
        ' A. Susun syarat pencarian teks (Judul atau Penulis)
        Dim kataKunci As String = AmankanTeks(txtCari.Text.Trim())
        Dim filterTeks As String = ""
        If kataKunci.Length > 0 Then
            filterTeks = $"(Judul LIKE '%{kataKunci}%' OR Penulis LIKE '%{kataKunci}%')"
        End If

        ' B. Susun syarat kategori
        Dim filterKategori As String = ""
        If cboFilterKategori.Text <> "Semua" AndAlso cboFilterKategori.SelectedIndex >= 0 Then
            filterKategori = $"Kategori = '{AmankanTeks(cboFilterKategori.Text)}'"
        End If

        ' C. Syarat Bonus: Hanya stok habis
        Dim filterStok As String = ""
        If chkStokHabis.Checked Then
            filterStok = "Stok = 0"
        End If

        ' D. Gabungkan semua syarat dengan "AND"
        Dim syaratGabungan As New List(Of String)
        If filterTeks.Length > 0 Then syaratGabungan.Add(filterTeks)
        If filterKategori.Length > 0 Then syaratGabungan.Add(filterKategori)
        If filterStok.Length > 0 Then syaratGabungan.Add(filterStok)

        bsBuku.Filter = String.Join(" AND ", syaratGabungan)

        ' E. Fitur Bonus: Urutan (Sort)
        Select Case cboUrut.Text
            Case "Judul A-Z"
                bsBuku.Sort = "Judul ASC"
            Case "Tahun terbaru"
                bsBuku.Sort = "Tahun DESC"
            Case "Stok terbanyak"
                bsBuku.Sort = "Stok DESC"
            Case Else
                bsBuku.Sort = "" ' Urutan awal (default)
        End Select

        ' F. Hitung Ringkasan (Jumlah dan Total Stok)
        HitungRingkasan()
    End Sub

    ' Fungsi untuk menghitung total stok dari baris yang SEDANG TAMPIL di grid
    Private Sub HitungRingkasan()
        Dim jumlahTampil As Integer = dgvBuku.Rows.Count
        Dim totalBuku As Integer = tabelBuku.Rows.Count
        Dim totalStok As Integer = 0

        ' Perulangan membaca sel Stok di grid yang sedang tampil
        For Each baris As DataGridViewRow In dgvBuku.Rows
            If baris.Cells("Stok").Value IsNot DBNull.Value Then
                totalStok += CInt(baris.Cells("Stok").Value)
            End If
        Next

        lblJumlah.Text = $"Menampilkan {jumlahTampil} dari {totalBuku} buku"
        lblTotalStok.Text = $"Total Stok: {totalStok}"
    End Sub

    ' Event saat user mengetik di kotak pencarian
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    ' Event saat user mengganti filter kategori
    Private Sub cboFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterKategori.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    ' Event bonus: centang "Hanya stok habis"
    Private Sub chkStokHabis_CheckedChanged(sender As Object, e As EventArgs) Handles chkStokHabis.CheckedChanged
        TerapkanFilter()
    End Sub

    ' Event bonus: ganti urutan
    Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUrut.SelectedIndexChanged
        TerapkanFilter()
    End Sub
    Private Sub ResetError()
        errBuku.SetError(txtKodeBuku, "")
        errBuku.SetError(txtJudul, "")
        errBuku.SetError(txtPenulis, "")
        errBuku.SetError(cboKategori, "")
        errBuku.SetError(txtTahun, "")
        errBuku.SetError(txtStok, "")
    End Sub

    Private Function ValidasiInput() As Boolean
        ResetError()
        Dim valid As Boolean = True

        ' 1. Cek Kode Buku (Format & Duplikat)
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If Not KodeBukuValid(kode) Then
            errBuku.SetError(txtKodeBuku, "Format harus BK diikuti 4 digit.")
            valid = False
        Else
            ' Cek apakah kode sudah ada di DataTable (pakai perulangan)
            For Each baris As DataRow In tabelBuku.Rows
                If baris("KodeBuku").ToString() = kode Then
                    errBuku.SetError(txtKodeBuku, "Kode buku sudah ada.")
                    valid = False
                    Exit For
                End If
            Next
        End If

        ' 2. Judul & Penulis Wajib Isi
        If txtJudul.Text.Trim().Length = 0 Then
            errBuku.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If
        If txtPenulis.Text.Trim().Length = 0 Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            valid = False
        End If

        ' 3. Kategori Wajib Pilih
        If cboKategori.SelectedIndex < 0 Then
            errBuku.SetError(cboKategori, "Pilih kategori.")
            valid = False
        End If

        ' 4. Tahun (1900 s/d Tahun ini)
        Dim tahun As Integer
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) OrElse tahun < 1900 OrElse tahun > Date.Today.Year Then
            errBuku.SetError(txtTahun, $"Tahun harus angka 1900 - {Date.Today.Year}.")
            valid = False
        End If

        ' 5. Stok (0 atau lebih)
        Dim stok As Integer
        If Not Integer.TryParse(txtStok.Text.Trim(), stok) OrElse stok < 0 Then
            errBuku.SetError(txtStok, "Stok minimal 0.")
            valid = False
        End If

        Return valid
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Return

        ' Tambahkan ke DataTable (Grid otomatis terupdate lewat BindingSource)
        tabelBuku.Rows.Add(
            txtKodeBuku.Text.Trim().ToUpper(),
            txtJudul.Text.Trim(),
            txtPenulis.Text.Trim(),
            cboKategori.Text,
            Integer.Parse(txtTahun.Text.Trim()),
            Integer.Parse(txtStok.Text.Trim())
        )

        TerapkanFilter() ' Perbarui label ringkasan
        BersihkanForm()
    End Sub

    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()
        ResetError()
        txtKodeBuku.Focus()
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

End Class