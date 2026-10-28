Public Class FrmKasir
    Private daftarPesanan As New List(Of Pesanan)

    Private Sub FrmKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each nama As String In daftarLayanan
            cboLayanan.Items.Add(nama)
        Next
        bsPesanan.DataSource = daftarPesanan
        dgvPesanan.DataSource = bsPesanan
        AturKolom()
        lblTotal.Text = "Rp 0"
    End Sub

    Private Sub AturKolom()
        dgvPesanan.AutoGenerateColumns = False
        dgvPesanan.Columns.Clear()

        Dim colLayanan As New DataGridViewTextBoxColumn()
        colLayanan.DataPropertyName = "Layanan"
        colLayanan.HeaderText = "Layanan"
        colLayanan.Name = "colLayanan"
        dgvPesanan.Columns.Add(colLayanan)

        Dim colJumlah As New DataGridViewTextBoxColumn()
        colJumlah.DataPropertyName = "Jumlah"
        colJumlah.HeaderText = "Jumlah"
        colJumlah.Name = "colJumlah"
        dgvPesanan.Columns.Add(colJumlah)

        Dim colHarga As New DataGridViewTextBoxColumn()
        colHarga.DataPropertyName = "Harga"
        colHarga.HeaderText = "Harga Satuan"
        colHarga.Name = "colHarga"
        colHarga.DefaultCellStyle.Format = "N0"
        colHarga.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvPesanan.Columns.Add(colHarga)

        Dim colDiskon As New DataGridViewTextBoxColumn()
        colDiskon.DataPropertyName = "Diskon"
        colDiskon.HeaderText = "Diskon"
        colDiskon.Name = "colDiskon"
        colDiskon.DefaultCellStyle.Format = "N0"
        colDiskon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvPesanan.Columns.Add(colDiskon)

        Dim colSubtotal As New DataGridViewTextBoxColumn()
        colSubtotal.DataPropertyName = "Subtotal"
        colSubtotal.HeaderText = "Subtotal"
        colSubtotal.Name = "colSubtotal"
        colSubtotal.DefaultCellStyle.Format = "N0"
        colSubtotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvPesanan.Columns.Add(colSubtotal)
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            errInput.Clear()
            Dim adaError As Boolean = False

            If cboLayanan.SelectedIndex = -1 Then
                errInput.SetError(cboLayanan, "Pilih layanan!")
                adaError = True
            End If

            Dim jumlah As Integer
            Dim teksJumlah As String = txtJumlah.Text.Trim()

            If teksJumlah = "" OrElse Not Integer.TryParse(teksJumlah, jumlah) OrElse jumlah < 1 OrElse jumlah > 1000 Then
                errInput.SetError(txtJumlah, "Jumlah harus bilangan bulat 1 - 1000!")
                adaError = True
            End If

            If adaError Then Exit Sub
            Dim layananDipilih As String = cboLayanan.SelectedItem.ToString()
            Dim harga As Decimal = HargaSatuan(layananDipilih)

            Dim pesananAda As Pesanan = Nothing
            For Each p As Pesanan In daftarPesanan
                If p.Layanan = layananDipilih Then
                    pesananAda = p
                    Exit For
                End If
            Next

            If pesananAda IsNot Nothing Then
                Dim jumlahGabung As Integer = pesananAda.Jumlah + jumlah
                If jumlahGabung > 1000 Then
                    errInput.SetError(txtJumlah, "Total jumlah melebihi 1000 lembar!")
                    Exit Sub
                End If

                pesananAda.Jumlah = jumlahGabung
                HitungUlangPesanan(pesananAda, harga)
                bsPesanan.ResetBindings(False)
            Else
                Dim pesananBaru As New Pesanan()
                pesananBaru.Layanan = layananDipilih
                pesananBaru.Jumlah = jumlah
                pesananBaru.Harga = harga
                HitungUlangPesanan(pesananBaru, harga)

                daftarPesanan.Add(pesananBaru)
                bsPesanan.ResetBindings(False)
            End If

            HitungTotal()

            cboLayanan.SelectedIndex = -1
            txtJumlah.Clear()
            errInput.Clear()
            txtJumlah.Focus()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub HitungUlangPesanan(p As Pesanan, harga As Decimal)
        Dim kotor As Decimal = harga * p.Jumlah
        If p.Jumlah >= 100 Then
            p.Diskon = kotor * 0.1D
        Else
            p.Diskon = 0D
        End If
        p.Subtotal = kotor - p.Diskon
    End Sub
    Private Sub HitungTotal()
        Dim total As Decimal = 0D
        For Each p As Pesanan In daftarPesanan
            total += p.Subtotal
        Next
        lblTotal.Text = "Rp " & total.ToString("N0")
    End Sub
    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        Dim jawaban As DialogResult = MessageBox.Show(
            "Hapus semua pesanan dan mulai transaksi baru?",
            "Transaksi Baru",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If jawaban = DialogResult.Yes Then
            daftarPesanan.Clear()
            bsPesanan.ResetBindings(False)
            lblTotal.Text = "Rp 0"
            cboLayanan.SelectedIndex = -1
            txtJumlah.Clear()
            errInput.Clear()
        End If
    End Sub
End Class