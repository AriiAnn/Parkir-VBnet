<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Keluar = New System.Windows.Forms.Button()
        Me.ParkirKeluar = New System.Windows.Forms.Button()
        Me.ParkirMasuk = New System.Windows.Forms.Button()
        Me.CetakLaporan = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Tabel2 = New System.Windows.Forms.DataGridView()
        Me.Tabel1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Tabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 45)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "MENU"
        '
        'Keluar
        '
        Me.Keluar.Location = New System.Drawing.Point(69, 315)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(153, 58)
        Me.Keluar.TabIndex = 12
        Me.Keluar.Text = "Keluar"
        Me.Keluar.UseVisualStyleBackColor = True
        '
        'ParkirKeluar
        '
        Me.ParkirKeluar.Location = New System.Drawing.Point(69, 163)
        Me.ParkirKeluar.Name = "ParkirKeluar"
        Me.ParkirKeluar.Size = New System.Drawing.Size(153, 58)
        Me.ParkirKeluar.TabIndex = 13
        Me.ParkirKeluar.Text = "Parkir Keluar"
        Me.ParkirKeluar.UseVisualStyleBackColor = True
        '
        'ParkirMasuk
        '
        Me.ParkirMasuk.Location = New System.Drawing.Point(69, 99)
        Me.ParkirMasuk.Name = "ParkirMasuk"
        Me.ParkirMasuk.Size = New System.Drawing.Size(153, 58)
        Me.ParkirMasuk.TabIndex = 14
        Me.ParkirMasuk.Text = "Parkir Masuk"
        Me.ParkirMasuk.UseVisualStyleBackColor = True
        '
        'CetakLaporan
        '
        Me.CetakLaporan.Location = New System.Drawing.Point(69, 227)
        Me.CetakLaporan.Name = "CetakLaporan"
        Me.CetakLaporan.Size = New System.Drawing.Size(153, 58)
        Me.CetakLaporan.TabIndex = 14
        Me.CetakLaporan.Text = "Cetak Laporan"
        Me.CetakLaporan.UseVisualStyleBackColor = True
        '
        'Tabel2
        '
        Me.Tabel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabel2.Location = New System.Drawing.Point(334, 180)
        Me.Tabel2.Name = "Tabel2"
        Me.Tabel2.RowTemplate.Height = 24
        Me.Tabel2.Size = New System.Drawing.Size(10, 12)
        Me.Tabel2.TabIndex = 16
        '
        'Tabel1
        '
        Me.Tabel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabel1.Location = New System.Drawing.Point(334, 147)
        Me.Tabel1.Name = "Tabel1"
        Me.Tabel1.RowTemplate.Height = 24
        Me.Tabel1.Size = New System.Drawing.Size(10, 10)
        Me.Tabel1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(243, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 224)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(393, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 27)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Segarkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 395)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Tabel1)
        Me.Controls.Add(Me.Tabel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CetakLaporan)
        Me.Controls.Add(Me.ParkirMasuk)
        Me.Controls.Add(Me.ParkirKeluar)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMenu"
        Me.Text = "Menu"
        CType(Me.Tabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Keluar As System.Windows.Forms.Button
    Friend WithEvents ParkirKeluar As System.Windows.Forms.Button
    Friend WithEvents ParkirMasuk As System.Windows.Forms.Button
    Friend WithEvents CetakLaporan As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Tabel2 As System.Windows.Forms.DataGridView
    Friend WithEvents Tabel1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
