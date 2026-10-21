Imports System.IO

Public Class FormPeminjaman

    ' Daftar kode buku yang sedang dipinjam (untuk cek duplikat)
    Private ReadOnly kodeTerpinjam As New List(Of String)

    ' Membersihkan semua ikon ErrorProvider sebelum validasi baru
    Private Sub ResetError()
        errPinjam.SetError(txtKodeBuku, "")
        errPinjam.SetError(txtJudul, "")
        errPinjam.SetError(cboKategori, "")
        errPinjam.SetError(txtNamaPeminjam, "")
        errPinjam.SetError(txtLamaPinjam, "")
    End Sub

    ' Memeriksa SEMUA isian sekaligus. Mengembalikan True jika semua valid.
    Private Function ValidasiInput() As Boolean
        ResetError()
        Dim valid As Boolean = True

        ' --- Kode buku: cek format dulu, lalu cek apakah sedang dipinjam ---
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "Format harus BK diikuti 4 digit, contoh BK0012.")
            valid = False
        ElseIf kodeTerpinjam.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            valid = False
        End If

        ' --- Judul wajib diisi ---
        If txtJudul.Text.Trim().Length = 0 Then
            errPinjam.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If

        ' --- Kategori wajib dipilih ---
        If cboKategori.SelectedIndex < 0 Then
            errPinjam.SetError(cboKategori, "Pilih kategori.")
            valid = False
        End If

        ' --- Nama peminjam minimal 3 karakter (abaikan spasi tepi) ---
        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama minimal 3 karakter.")
            valid = False
        End If

        ' --- Lama pinjam: harus angka 1 sampai 14 via TryParse ---
        Dim lama As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lama) OrElse lama < 1 OrElse lama > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus angka 1 sampai 14.")
            valid = False
        End If

        Return valid
    End Function

    ' Menangani klik tombol Pinjam: validasi, catat, perbarui status, kosongkan form.
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        ' 1. Panggil fungsi validasi. Kalau ada yang salah, berhenti (Return).
        If Not ValidasiInput() Then Return

        ' 2. Ambil data yang sudah valid (rapikan spasi & jadikan huruf besar)
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim judul As String = txtJudul.Text.Trim()
        Dim kategori As String = cboKategori.SelectedItem.ToString()
        Dim peminjam As String = txtNamaPeminjam.Text.Trim()
        Dim lama As Integer = Integer.Parse(txtLamaPinjam.Text.Trim())

        ' 3. Hitung tanggal kembali (Hari ini + lama pinjam)
        Dim kembali As String = Date.Today.AddDays(lama).ToString("dd/MM/yyyy")

        ' 4. Susun format baris sesuai ketentuan tugas
        Dim baris As String = $"{kode} | {judul} | {kategori} | {peminjam} | {lama} hari | kembali {kembali}"

        ' 5. Simpan ke ListBox dan catat kodenya sebagai "sedang dipinjam"
        lstPeminjaman.Items.Add(baris)
        kodeTerpinjam.Add(kode)

        ' 6. Perbarui label status
        lblStatus.Text = $"Jumlah peminjaman: {lstPeminjaman.Items.Count}"

        ' 7. Bersihkan form
        BersihkanForm()
    End Sub

    ' Fungsi untuk mengosongkan semua isian dan menghapus semua ikon ErrorProvider.
    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()

        ResetError()
        txtKodeBuku.Focus() ' Kursor kembali ke kotak kode buku
    End Sub

    ' Menangani klik tombol Bersihkan.
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    ' Menangani klik Ekspor: tulis lstPeminjaman ke CSV di folder Documents.
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        ' Cek jika daftar kosong, jangan buat file
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Belum ada peminjaman untuk diekspor.", "Ekspor",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Tentukan lokasi file di folder Documents
        Dim filePath As String = System.IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "peminjaman.csv")

        Dim writer As StreamWriter = Nothing
        Try
            writer = New StreamWriter(filePath, False)
            ' Tulis judul kolom
            writer.WriteLine("Kode;Judul;Kategori;Peminjam;Lama;Kembali")

            ' Tulis setiap baris dari ListBox
            For Each item As Object In lstPeminjaman.Items
                ' Ganti pemisah " | " menjadi ";" agar formatnya CSV yang benar
                writer.WriteLine(item.ToString().Replace(" | ", ";"))
            Next

            MessageBox.Show($"Ekspor berhasil: {filePath}", "Ekspor",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As IOException
            MessageBox.Show("File sedang dipakai program lain (misalnya Excel). Tutup file lalu coba lagi.",
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Tidak punya izin menulis ke folder Documents. Jalankan ulang atau simpan di folder lain.",
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            ' Pastikan StreamWriter ditutup apapun yang terjadi
            If writer IsNot Nothing Then writer.Close()
        End Try
    End Sub

    ' Memeriksa format kode buku segera saat fokus pindah kontrol
    Private Sub txtKodeBuku_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeBuku.Validating
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If kode.Length = 0 Then
            errPinjam.SetError(txtKodeBuku, "") ' Kosongkan error jika kosong
        ElseIf Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "Format harus BK diikuti 4 digit, contoh BK0012.")
        Else
            errPinjam.SetError(txtKodeBuku, "")
        End If
    End Sub
End Class