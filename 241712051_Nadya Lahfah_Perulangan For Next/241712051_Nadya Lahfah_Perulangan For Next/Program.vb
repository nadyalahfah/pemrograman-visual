Module Program
    Sub Main()
        Dim total As Integer = 0
        Console.WriteLine("TABEL PERKALIAN 5")
        Console.WriteLine("-----------------")
        For i As Integer = 1 To 10
            Console.WriteLine("5 x " & i & " = " & 5 * i)
            total += 5 * i
        Next
        Console.WriteLine("-----------------")
        Console.WriteLine("Total seluruh hasil = " & total)
        Console.ReadLine()
    End Sub
End Module