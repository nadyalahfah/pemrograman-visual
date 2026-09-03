<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNama = New Label()
        txtNama = New TextBox()
        lblNim = New Label()
        txtNim = New TextBox()
        lblKom = New Label()
        txtKom = New TextBox()
        btnTampilkan = New Button()
        btnHapus = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(83, 64)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(83, 99)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(143, 27)
        txtNama.TabIndex = 1
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(83, 145)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(44, 20)
        lblNim.TabIndex = 2
        lblNim.Text = "Nim :"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(83, 177)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(143, 27)
        txtNim.TabIndex = 3
        ' 
        ' lblKom
        ' 
        lblKom.AutoSize = True
        lblKom.Location = New Point(83, 227)
        lblKom.Name = "lblKom"
        lblKom.Size = New Size(47, 20)
        lblKom.TabIndex = 4
        lblKom.Text = "Kom :"
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(83, 262)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(143, 27)
        txtKom.TabIndex = 5
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(83, 328)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(143, 29)
        btnTampilkan.TabIndex = 6
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(83, 375)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(143, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(83, 421)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(143, 29)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 529)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnTampilkan)
        Controls.Add(txtKom)
        Controls.Add(lblKom)
        Controls.Add(txtNim)
        Controls.Add(lblNim)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Profil Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblKom As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button

End Class
