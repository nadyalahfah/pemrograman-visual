Module ModTarif
    Public daftarLayanan() As String = {"Fotokopi", "Print Hitam Putih", "Print Warna", "Jilid"}
    Public Function HargaSatuan(layanan As String) As Decimal
        Select Case layanan
            Case "Fotokopi"
                Return 300D
            Case "Print Hitam Putih"
                Return 500D
            Case "Print Warna"
                Return 1500D
            Case "Jilid"
                Return 5000D
            Case Else
                Return 0D
        End Select
    End Function
End Module