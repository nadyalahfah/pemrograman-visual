Imports System.Globalization
Imports System.Windows

Public Class FrmPajak

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim Pendapatan As Decimal
        Dim pajak As Decimal

        If Not Decimal.TryParse(txtPendapatan.Text, Pendapatan) Then
            MessageBox.Show("Pendapatan Harus Berupa Angka!", "Peringatan")
            txtPendapatan.Focus()
            Exit Sub
        End If

        If Pendapatan <= 5000000 Then
            pajak = Pendapatan * 0D

        ElseIf Pendapatan <= 30000000 Then
            pajak = Pendapatan * 0.1D

        ElseIf Pendapatan <= 100000000 Then
            pajak = Pendapatan * 0.2D

        Else
            pajak = Pendapatan * 0.3D
        End If

        MessageBox.Show("Pajak yang harus dibayar: " &
                    pajak.ToString("C0", New Globalization.CultureInfo("id-ID")),
                    "Hasil Pajak")
    End Sub

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FrmLogin.Show()
        Me.Close()

    End Sub
End Class