<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKasir
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
        components = New ComponentModel.Container()
        lblJudul = New Label()
        lblLayanan = New Label()
        cboLayanan = New ComboBox()
        lblJumlah = New Label()
        txtJumlah = New TextBox()
        btnTambah = New Button()
        btnBaru = New Button()
        dgvPesanan = New DataGridView()
        bsPesanan = New BindingSource(components)
        lblTotalText = New Label()
        lblTotal = New Label()
        errInput = New ErrorProvider(components)
        CType(dgvPesanan, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsPesanan, ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(30, 26)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(170, 31)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Kasir Fotokopi"
        ' 
        ' lblLayanan
        ' 
        lblLayanan.AutoSize = True
        lblLayanan.Location = New Point(30, 83)
        lblLayanan.Name = "lblLayanan"
        lblLayanan.Size = New Size(63, 20)
        lblLayanan.TabIndex = 1
        lblLayanan.Text = "Layanan"
        ' 
        ' cboLayanan
        ' 
        cboLayanan.FormattingEnabled = True
        cboLayanan.Location = New Point(152, 80)
        cboLayanan.Name = "cboLayanan"
        cboLayanan.Size = New Size(225, 28)
        cboLayanan.TabIndex = 2
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(30, 124)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(116, 20)
        lblJumlah.TabIndex = 3
        lblJumlah.Text = "Jumlah (lembar)"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(152, 121)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(225, 27)
        txtJumlah.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(599, 70)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(156, 38)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBaru
        ' 
        btnBaru.Location = New Point(427, 70)
        btnBaru.Name = "btnBaru"
        btnBaru.Size = New Size(156, 38)
        btnBaru.TabIndex = 6
        btnBaru.Text = "Transaksi Baru"
        btnBaru.UseVisualStyleBackColor = True
        ' 
        ' dgvPesanan
        ' 
        dgvPesanan.AllowUserToAddRows = False
        dgvPesanan.AllowUserToDeleteRows = False
        dgvPesanan.AutoGenerateColumns = False
        dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPesanan.DataSource = bsPesanan
        dgvPesanan.Location = New Point(30, 172)
        dgvPesanan.Name = "dgvPesanan"
        dgvPesanan.ReadOnly = True
        dgvPesanan.RowHeadersWidth = 51
        dgvPesanan.Size = New Size(725, 245)
        dgvPesanan.TabIndex = 7
        ' 
        ' lblTotalText
        ' 
        lblTotalText.AutoSize = True
        lblTotalText.Location = New Point(500, 428)
        lblTotalText.Name = "lblTotalText"
        lblTotalText.Size = New Size(83, 20)
        lblTotalText.TabIndex = 8
        lblTotalText.Text = "Total Bayar"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(702, 428)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(18, 20)
        lblTotal.TabIndex = 9
        lblTotal.Text = "0"
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmKasir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 477)
        Controls.Add(lblTotal)
        Controls.Add(lblTotalText)
        Controls.Add(dgvPesanan)
        Controls.Add(btnBaru)
        Controls.Add(btnTambah)
        Controls.Add(txtJumlah)
        Controls.Add(lblJumlah)
        Controls.Add(cboLayanan)
        Controls.Add(lblLayanan)
        Controls.Add(lblJudul)
        Name = "FrmKasir"
        Text = "Kasir Fotokopi"
        CType(dgvPesanan, ComponentModel.ISupportInitialize).EndInit()
        CType(bsPesanan, ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblLayanan As Label
    Friend WithEvents cboLayanan As ComboBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBaru As Button
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents lblTotalText As Label
    Friend WithEvents bsPesanan As BindingSource
    Friend WithEvents lblTotal As Label
    Friend WithEvents errInput As ErrorProvider

End Class
