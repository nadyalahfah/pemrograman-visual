<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        picImage = New PictureBox()
        cmbRole = New ComboBox()
        lblRole = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(312, 41)
        picImage.Name = "picImage"
        picImage.Size = New Size(125, 125)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(296, 201)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(151, 28)
        cmbRole.TabIndex = 1
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(209, 204)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(66, 20)
        lblRole.TabIndex = 2
        lblRole.Text = "Role      :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(209, 260)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nama   :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(209, 315)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 4
        Label2.Text = "Nim      :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(296, 253)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(151, 27)
        txtNama.TabIndex = 5
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(296, 312)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(151, 27)
        txtNim.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(321, 378)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblRole)
        Controls.Add(cmbRole)
        Controls.Add(picImage)
        Name = "FrmLogin"
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents btnLogin As Button

End Class
