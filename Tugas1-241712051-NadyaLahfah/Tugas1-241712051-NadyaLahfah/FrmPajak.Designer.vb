<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblLimaJuta = New Label()
        lblTigaPuluhJuta = New Label()
        lblSeratusJuta = New Label()
        lblPendapatan = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        lblRupiah = New Label()
        SuspendLayout()
        ' 
        ' lblLimaJuta
        ' 
        lblLimaJuta.AutoSize = True
        lblLimaJuta.Location = New Point(221, 72)
        lblLimaJuta.Name = "lblLimaJuta"
        lblLimaJuta.Size = New Size(276, 20)
        lblLimaJuta.TabIndex = 0
        lblLimaJuta.Text = " Pendapatan lebih dari 5 juta , 10% Pajak"
        ' 
        ' lblTigaPuluhJuta
        ' 
        lblTigaPuluhJuta.AutoSize = True
        lblTigaPuluhJuta.Location = New Point(224, 103)
        lblTigaPuluhJuta.Name = "lblTigaPuluhJuta"
        lblTigaPuluhJuta.Size = New Size(280, 20)
        lblTigaPuluhJuta.TabIndex = 1
        lblTigaPuluhJuta.Text = "Pendapatan lebih dari 30 juta , 20% Pajak"
        ' 
        ' lblSeratusJuta
        ' 
        lblSeratusJuta.AutoSize = True
        lblSeratusJuta.Location = New Point(224, 133)
        lblSeratusJuta.Name = "lblSeratusJuta"
        lblSeratusJuta.Size = New Size(288, 20)
        lblSeratusJuta.TabIndex = 2
        lblSeratusJuta.Text = "Pendapatan lebih dari 100 juta , 30% Pajak"
        ' 
        ' lblPendapatan
        ' 
        lblPendapatan.AutoSize = True
        lblPendapatan.Location = New Point(293, 200)
        lblPendapatan.Name = "lblPendapatan"
        lblPendapatan.Size = New Size(156, 20)
        lblPendapatan.TabIndex = 3
        lblPendapatan.Text = "Masukkan Pendapatan"
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(293, 251)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(156, 27)
        txtPendapatan.TabIndex = 4
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(324, 310)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(94, 29)
        btnHitung.TabIndex = 5
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(324, 360)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 6
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblRupiah
        ' 
        lblRupiah.AutoSize = True
        lblRupiah.Location = New Point(257, 254)
        lblRupiah.Name = "lblRupiah"
        lblRupiah.Size = New Size(30, 20)
        lblRupiah.TabIndex = 7
        lblRupiah.Text = "Rp."
        ' 
        ' FrmPajak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblRupiah)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(lblPendapatan)
        Controls.Add(lblSeratusJuta)
        Controls.Add(lblTigaPuluhJuta)
        Controls.Add(lblLimaJuta)
        Name = "FrmPajak"
        Text = "Pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLimaJuta As Label
    Friend WithEvents lblTigaPuluhJuta As Label
    Friend WithEvents lblSeratusJuta As Label
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblRupiah As Label

    Private Sub txtPendapatan_TextChanged(sender As Object, e As EventArgs) Handles txtPendapatan.TextChanged

    End Sub

    Private Sub FrmPajak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
