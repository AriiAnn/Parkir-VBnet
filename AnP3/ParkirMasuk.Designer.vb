<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParkirMasuk
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
        Me.Tarif = New System.Windows.Forms.Label()
        Me.NoKendaraan = New System.Windows.Forms.TextBox()
        Me.JamMasuk = New System.Windows.Forms.TextBox()
        Me.txtkdmasuk = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RBMotor = New System.Windows.Forms.RadioButton()
        Me.RBMobil = New System.Windows.Forms.RadioButton()
        Me.JenKendaraan = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tabel1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.baru = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.CetakStruk = New System.Windows.Forms.Button()
        Me.Kembali = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.Tabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tarif
        '
        Me.Tarif.AutoSize = True
        Me.Tarif.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tarif.Location = New System.Drawing.Point(252, 161)
        Me.Tarif.Name = "Tarif"
        Me.Tarif.Size = New System.Drawing.Size(31, 22)
        Me.Tarif.TabIndex = 54
        Me.Tarif.Text = "---"
        '
        'NoKendaraan
        '
        Me.NoKendaraan.Location = New System.Drawing.Point(230, 112)
        Me.NoKendaraan.Name = "NoKendaraan"
        Me.NoKendaraan.Size = New System.Drawing.Size(192, 22)
        Me.NoKendaraan.TabIndex = 52
        '
        'JamMasuk
        '
        Me.JamMasuk.Location = New System.Drawing.Point(230, 214)
        Me.JamMasuk.Name = "JamMasuk"
        Me.JamMasuk.Size = New System.Drawing.Size(192, 22)
        Me.JamMasuk.TabIndex = 53
        '
        'txtkdmasuk
        '
        Me.txtkdmasuk.Location = New System.Drawing.Point(168, 63)
        Me.txtkdmasuk.Name = "txtkdmasuk"
        Me.txtkdmasuk.Size = New System.Drawing.Size(80, 22)
        Me.txtkdmasuk.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 22)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Jam Masuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Tarif/jam"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(39, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 22)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Kode Masuk"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 22)
        Me.Label16.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 22)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nomor Plat"
        '
        'RBMotor
        '
        Me.RBMotor.AutoSize = True
        Me.RBMotor.Location = New System.Drawing.Point(282, 259)
        Me.RBMotor.Name = "RBMotor"
        Me.RBMotor.Size = New System.Drawing.Size(65, 21)
        Me.RBMotor.TabIndex = 56
        Me.RBMotor.TabStop = True
        Me.RBMotor.Text = "Motor"
        Me.RBMotor.UseVisualStyleBackColor = True
        '
        'RBMobil
        '
        Me.RBMobil.AutoSize = True
        Me.RBMobil.Location = New System.Drawing.Point(186, 259)
        Me.RBMobil.Name = "RBMobil"
        Me.RBMobil.Size = New System.Drawing.Size(62, 21)
        Me.RBMobil.TabIndex = 55
        Me.RBMobil.TabStop = True
        Me.RBMobil.Text = "Mobil"
        Me.RBMobil.UseVisualStyleBackColor = True
        '
        'JenKendaraan
        '
        Me.JenKendaraan.AutoSize = True
        Me.JenKendaraan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenKendaraan.Location = New System.Drawing.Point(384, 259)
        Me.JenKendaraan.Name = "JenKendaraan"
        Me.JenKendaraan.Size = New System.Drawing.Size(38, 22)
        Me.JenKendaraan.TabIndex = 58
        Me.JenKendaraan.Text = "----"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 22)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Jenis Kendaraan"
        '
        'Tabel1
        '
        Me.Tabel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabel1.Location = New System.Drawing.Point(451, 12)
        Me.Tabel1.Name = "Tabel1"
        Me.Tabel1.RowTemplate.Height = 24
        Me.Tabel1.Size = New System.Drawing.Size(636, 274)
        Me.Tabel1.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(328, 32)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "MENU PARKIR MASUK"
        '
        'baru
        '
        Me.baru.Location = New System.Drawing.Point(540, 322)
        Me.baru.Name = "baru"
        Me.baru.Size = New System.Drawing.Size(158, 65)
        Me.baru.TabIndex = 77
        Me.baru.Text = "New"
        Me.baru.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(24, 322)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(136, 65)
        Me.BtnSave.TabIndex = 78
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(168, 322)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(166, 65)
        Me.BtnHapus.TabIndex = 76
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(355, 322)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(166, 65)
        Me.edit.TabIndex = 74
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'CetakStruk
        '
        Me.CetakStruk.Location = New System.Drawing.Point(720, 322)
        Me.CetakStruk.Name = "CetakStruk"
        Me.CetakStruk.Size = New System.Drawing.Size(157, 65)
        Me.CetakStruk.TabIndex = 75
        Me.CetakStruk.Text = "Cetak Struk"
        Me.CetakStruk.UseVisualStyleBackColor = True
        '
        'Kembali
        '
        Me.Kembali.Location = New System.Drawing.Point(922, 322)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.Size = New System.Drawing.Size(200, 65)
        Me.Kembali.TabIndex = 75
        Me.Kembali.Text = "Kembali"
        Me.Kembali.UseVisualStyleBackColor = True
        '
        'FormParkirMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1134, 409)
        Me.Controls.Add(Me.baru)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.Kembali)
        Me.Controls.Add(Me.CetakStruk)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Tabel1)
        Me.Controls.Add(Me.JenKendaraan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RBMotor)
        Me.Controls.Add(Me.RBMobil)
        Me.Controls.Add(Me.Tarif)
        Me.Controls.Add(Me.NoKendaraan)
        Me.Controls.Add(Me.JamMasuk)
        Me.Controls.Add(Me.txtkdmasuk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormParkirMasuk"
        Me.Text = "ParkirMasuk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Tabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tarif As System.Windows.Forms.Label
    Friend WithEvents NoKendaraan As System.Windows.Forms.TextBox
    Friend WithEvents JamMasuk As System.Windows.Forms.TextBox
    Friend WithEvents txtkdmasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RBMotor As System.Windows.Forms.RadioButton
    Friend WithEvents RBMobil As System.Windows.Forms.RadioButton
    Friend WithEvents JenKendaraan As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tabel1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents baru As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents CetakStruk As System.Windows.Forms.Button
    Friend WithEvents Kembali As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
