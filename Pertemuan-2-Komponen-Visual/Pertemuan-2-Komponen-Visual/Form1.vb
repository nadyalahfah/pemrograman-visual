Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblNim.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lblKom.Click

    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Halo" & vbCrLf &
                        "Nama : " & txtNama.Text & vbCrLf &
                        "Nim  : " & txtNim.Text & vbCrLf &
                        "Kom  : " & txtKom.Text & vbCrLf &
                        "Selamat Datang di Visual Basic")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
