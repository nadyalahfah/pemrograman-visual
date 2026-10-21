Option Strict On

Module ModValidasi
    ' Mengecek apakah semua karakter dalam teks adalah angka 0-9.
    Public Function SemuaDigit(teks As String) As Boolean
        If teks.Length = 0 Then Return False
        For Each c As Char In teks
            If Not Char.IsDigit(c) Then Return False
        Next
        Return True
    End Function

    ' Memeriksa format kode buku: "BK" + tepat 4 digit.
    Public Function KodeBukuValid(kode As String) As Boolean
        If kode Is Nothing Then Return False
        If kode.Length <> 6 Then Return False
        If Not kode.StartsWith("BK", StringComparison.OrdinalIgnoreCase) Then Return False
        Return SemuaDigit(kode.Substring(2))
    End Function

    ' Fungsi pengaman untuk karakter khusus di Filter (seperti tanda kutip)
    Public Function AmankanTeks(teks As String) As String
        Return teks.Replace("'", "''")
    End Function
End Module