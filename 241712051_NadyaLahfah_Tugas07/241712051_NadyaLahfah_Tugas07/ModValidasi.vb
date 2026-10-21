Option Strict On

Module ModValidasi

    ' Fungsi untuk mengecek apakah semua karakter adalah angka 0-9.
    ' Dipakai untuk memastikan 4 digit terakhir kode buku benar-benar angka.
    Public Function SemuaDigit(teks As String) As Boolean
        If teks.Length = 0 Then Return False

        For Each c As Char In teks
            If Not Char.IsDigit(c) Then Return False
        Next

        Return True
    End Function

    ' Fungsi untuk memeriksa format kode buku: "BK" + tepat 4 digit.
    ' Huruf kecil (bk) tetap diterima karena memakai OrdinalIgnoreCase.
    Public Function KodeBukuValid(kode As String) As Boolean
        If kode Is Nothing Then Return False

        ' 1. Cek panjang harus pas 6 karakter (BK + 4 angka)
        If kode.Length <> 6 Then Return False

        ' 2. Cek apakah diawali "BK" (tidak peduli huruf besar/kecil)
        If Not kode.StartsWith("BK", StringComparison.OrdinalIgnoreCase) Then Return False

        ' 3. Cek sisa 4 karakter setelah "BK" harus angka semua
        Return SemuaDigit(kode.Substring(2))
    End Function

End Module