Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows

Public Class FrmLogin
    Private staffNama As String = "Nadya"
    Private staffNIM As String = "241712051"

    Private managerNama As String = "Mingyu"
    Private managerNIM As String = "241712000"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblRole.Click

    End Sub

    Private Sub picImage_Click(sender As Object, e As EventArgs) Handles picImage.Click

    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem Is Nothing Then
            Return
        End If

        Dim namaFile As String = ""
        Select Case cmbRole.SelectedItem.ToString()

            Case "Staff"
                picImage.Image = Image.FromFile("Assets\Staff.jpg")

            Case "Manager"
                picImage.Image = Image.FromFile("Assets\Manager.jpg")

        End Select
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.SelectedIndex = 0
        picImage.SizeMode = PictureBoxSizeMode.Zoom

        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, picImage.Width, picImage.Height)
        picImage.Region = New Region(path)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cmbRole.SelectedItem Is Nothing Then
            MessageBox.Show("Silakan pilih role terlebih dahulu!")
            Return
        End If

        Dim role As String = cmbRole.SelectedItem.ToString()
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNim.Text.Trim()

        If role = "Staff" Then
            If nama.Equals(staffNama, StringComparison.OrdinalIgnoreCase) AndAlso
               nim = staffNIM Then

                Dim form2 As New FrmPajak()
                form2.Show()
                Me.Hide()
                txtNama.Clear()
                txtNim.Clear()

            Else
                MessageBox.Show("Masukkan data Staff dengan benar!")
            End If

        ElseIf role = "Manager" Then
            If nama.Equals(managerNama, StringComparison.OrdinalIgnoreCase) AndAlso
               nim = managerNIM Then

                Dim form2 As New FrmPajak()
                form2.Show()
                Me.Hide()
                txtNama.Clear()
                txtNim.Clear()

            Else
                MessageBox.Show("Masukkan data Manager dengan benar!")
            End If
        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
