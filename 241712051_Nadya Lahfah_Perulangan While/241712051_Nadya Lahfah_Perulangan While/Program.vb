Module Program
    Sub Main()
        Dim angka, jumlah, banyak As Integer
        Console.Write("Masukkan angka (0 untuk berhenti): ")
        angka = CInt(Console.ReadLine())
        While angka <> 0
            jumlah += angka
            banyak += 1
            Console.Write("Masukkan angka (0 untuk berhenti): ")
            angka = CInt(Console.ReadLine())
        End While
        Console.WriteLine()
        Console.WriteLine("Banyak data : " & banyak)
        Console.WriteLine("Jumlah : " & jumlah)
        If banyak > 0 Then
            Console.WriteLine("Rata-rata : " & jumlah / banyak)
        End If
        Console.ReadLine()
    End Sub
End Module