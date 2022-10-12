<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParkirKeluar
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tabel2 = New System.Windows.Forms.DataGridView()
        Me.txtkdmasuk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kdKeluar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tabel1 = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Kembalian = New System.Windows.Forms.TextBox()
        Me.UangTunai = New System.Windows.Forms.TextBox()
        Me.Tarif = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JamParkir = New System.Windows.Forms.Label()
        Me.TotalBayar = New System.Windows.Forms.TextBox()
        Me.JamKeluar = New System.Windows.Forms.TextBox()
        Me.JamMasuk = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.baru = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.Selesai = New System.Windows.Forms.Button()
        Me.CetakStruk = New System.Windows.Forms.Button()
        Me.BtnTotal = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LamaParkir = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Tabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(344, 32)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "MENU PARKIR KELUAR"
        '
        'Tabel2
        '
        Me.Tabel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabel2.Location = New System.Drawing.Point(488, 260)
        Me.Tabel2.Name = "Tabel2"
        Me.Tabel2.RowTemplate.Height = 24
        Me.Tabel2.Size = New System.Drawing.Size(655, 220)
        Me.Tabel2.TabIndex = 91
        '
        'txtkdmasuk
        '
        Me.txtkdmasuk.Location = New System.Drawing.Point(238, 120)
        Me.txtkdmasuk.Name = "txtkdmasuk"
        Me.txtkdmasuk.Size = New System.Drawing.Size(192, 22)
        Me.txtkdmasuk.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Kode Masuk"
        '
        'kdKeluar
        '
        Me.kdKeluar.Location = New System.Drawing.Point(238, 83)
        Me.kdKeluar.Name = "kdKeluar"
        Me.kdKeluar.Size = New System.Drawing.Size(192, 22)
        Me.kdKeluar.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 22)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Kode Keluar"
        '
        'Tabel1
        '
        Me.Tabel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabel1.Location = New System.Drawing.Point(498, 34)
        Me.Tabel1.Name = "Tabel1"
        Me.Tabel1.RowTemplate.Height = 24
        Me.Tabel1.Size = New System.Drawing.Size(437, 220)
        Me.Tabel1.TabIndex = 86
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 363)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 22)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "KEMBALIAN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 334)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 22)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "UANG TUNAI"
        '
        'Kembalian
        '
        Me.Kembalian.Enabled = False
        Me.Kembalian.Location = New System.Drawing.Point(238, 363)
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.Size = New System.Drawing.Size(192, 22)
        Me.Kembalian.TabIndex = 82
        '
        'UangTunai
        '
        Me.UangTunai.Location = New System.Drawing.Point(238, 335)
        Me.UangTunai.Name = "UangTunai"
        Me.UangTunai.Size = New System.Drawing.Size(192, 22)
        Me.UangTunai.TabIndex = 83
        '
        'Tarif
        '
        Me.Tarif.Location = New System.Drawing.Point(238, 148)
        Me.Tarif.Name = "Tarif"
        Me.Tarif.Size = New System.Drawing.Size(192, 22)
        Me.Tarif.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 22)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Tarif"
        '
        'JamParkir
        '
        Me.JamParkir.AutoSize = True
        Me.JamParkir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JamParkir.Location = New System.Drawing.Point(256, 264)
        Me.JamParkir.Name = "JamParkir"
        Me.JamParkir.Size = New System.Drawing.Size(38, 22)
        Me.JamParkir.TabIndex = 79
        Me.JamParkir.Text = "----"
        '
        'TotalBayar
        '
        Me.TotalBayar.Enabled = False
        Me.TotalBayar.Location = New System.Drawing.Point(238, 298)
        Me.TotalBayar.Name = "TotalBayar"
        Me.TotalBayar.Size = New System.Drawing.Size(192, 22)
        Me.TotalBayar.TabIndex = 78
        '
        'JamKeluar
        '
        Me.JamKeluar.Location = New System.Drawing.Point(238, 204)
        Me.JamKeluar.Name = "JamKeluar"
        Me.JamKeluar.Size = New System.Drawing.Size(192, 22)
        Me.JamKeluar.TabIndex = 77
        '
        'JamMasuk
        '
        Me.JamMasuk.Location = New System.Drawing.Point(238, 176)
        Me.JamMasuk.Name = "JamMasuk"
        Me.JamMasuk.Size = New System.Drawing.Size(192, 22)
        Me.JamMasuk.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 22)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Total Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 22)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Jam Parkir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 22)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Jam Keluar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 22)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Jam Masuk"
        '
        'baru
        '
        Me.baru.Location = New System.Drawing.Point(403, 401)
        Me.baru.Name = "baru"
        Me.baru.Size = New System.Drawing.Size(75, 23)
        Me.baru.TabIndex = 98
        Me.baru.Text = "New"
        Me.baru.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(109, 401)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 99
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(190, 401)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(104, 23)
        Me.BtnHapus.TabIndex = 97
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(300, 401)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 23)
        Me.edit.TabIndex = 96
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'Selesai
        '
        Me.Selesai.Location = New System.Drawing.Point(18, 430)
        Me.Selesai.Name = "Selesai"
        Me.Selesai.Size = New System.Drawing.Size(113, 23)
        Me.Selesai.TabIndex = 94
        Me.Selesai.Text = "KEMBALIAN"
        Me.Selesai.UseVisualStyleBackColor = True
        '
        'CetakStruk
        '
        Me.CetakStruk.Location = New System.Drawing.Point(153, 430)
        Me.CetakStruk.Name = "CetakStruk"
        Me.CetakStruk.Size = New System.Drawing.Size(109, 23)
        Me.CetakStruk.TabIndex = 95
        Me.CetakStruk.Text = "Cetak Struk"
        Me.CetakStruk.UseVisualStyleBackColor = True
        '
        'BtnTotal
        '
        Me.BtnTotal.Location = New System.Drawing.Point(28, 401)
        Me.BtnTotal.Name = "BtnTotal"
        Me.BtnTotal.Size = New System.Drawing.Size(75, 23)
        Me.BtnTotal.TabIndex = 93
        Me.BtnTotal.Text = "Total"
        Me.BtnTotal.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 22)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Lama Parkir"
        '
        'LamaParkir
        '
        Me.LamaParkir.Enabled = False
        Me.LamaParkir.Location = New System.Drawing.Point(238, 239)
        Me.LamaParkir.Name = "LamaParkir"
        Me.LamaParkir.Size = New System.Drawing.Size(192, 22)
        Me.LamaParkir.TabIndex = 100
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(278, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(386, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 27)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormParkirKeluar
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1166, 542)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LamaParkir)
        Me.Controls.Add(Me.baru)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.Selesai)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CetakStruk)
        Me.Controls.Add(Me.BtnTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Tabel2)
        Me.Controls.Add(Me.txtkdmasuk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kdKeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tabel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Kembalian)
        Me.Controls.Add(Me.UangTunai)
        Me.Controls.Add(Me.Tarif)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.JamParkir)
        Me.Controls.Add(Me.TotalBayar)
        Me.Controls.Add(Me.JamKeluar)
        Me.Controls.Add(Me.JamMasuk)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FormParkirKeluar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Tabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tabel2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtkdmasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kdKeluar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tabel1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Kembalian As System.Windows.Forms.TextBox
    Friend WithEvents UangTunai As System.Windows.Forms.TextBox
    Friend WithEvents Tarif As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents JamParkir As System.Windows.Forms.Label
    Friend WithEvents TotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents JamKeluar As System.Windows.Forms.TextBox
    Friend WithEvents JamMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents baru As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents Selesai As System.Windows.Forms.Button
    Friend WithEvents CetakStruk As System.Windows.Forms.Button
    Friend WithEvents BtnTotal As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LamaParkir As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
