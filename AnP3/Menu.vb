Imports System.Data.Odbc
Imports System.Drawing.Printing
Public Class FormMenu


    Dim WithEvents PD2 As New PrintDocument
    Dim PPD2 As New PrintPreviewDialog

    Private Sub ParkirMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParkirMasuk.Click
        Me.Hide()
        FormParkirMasuk.Show()

    End Sub

    Private Sub ParkirKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParkirKeluar.Click
        Me.Hide()
        FormParkirKeluar.Show()

    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        End

    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Call KonekDB()
        Call tampil_data()
        Call tampil_data2()
    End Sub

    Private Sub CetakLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakLaporan.Click
        PPD2.Document = PD2
        PPD2.ShowDialog()
    End Sub
    Sub tampil_data()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_parkirkeluar", konek)
        DS = New DataSet
        DA.Fill(DS)
        Tabel2.DataSource = DS.Tables(0)
        Tabel2.ReadOnly = True

    End Sub
    Sub tampil_data2()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_parkirmasuk", konek)
        DS = New DataSet
        DA.Fill(DS)
        Tabel1.DataSource = DS.Tables(0)
        Tabel1.ReadOnly = True
    End Sub
    Private Sub PD2_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD2.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 430, 500)
        PD2.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD2.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD2.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD2.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD2.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-----------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Hasil Laporan Parkir ", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("-----------------", f10, Brushes.Black, centermargin, 30, tengah)
        e.Graphics.DrawString("-----------------", f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 55)

        e.Graphics.DrawString("Kode Masuk", f10b, Brushes.Black, 40, 70, tengah)
        e.Graphics.DrawString("Kode Keluar", f10b, Brushes.Black, 130, 70, tengah)
        e.Graphics.DrawString("Jam Parkir", f10b, Brushes.Black, 210, 70, tengah)
        e.Graphics.DrawString("Lama Parkir", f10b, Brushes.Black, 290, 70, tengah)
        e.Graphics.DrawString("Biaya Parkir", f10b, Brushes.Black, 380, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 85)
        Tabel2.AllowUserToAddRows = False
        Tabel1.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To Tabel2.RowCount - 1

            tinggi += 15
            e.Graphics.DrawString(Tabel2.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 33, 80 + tinggi)
            e.Graphics.DrawString(Tabel2.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 123, 80 + tinggi)
            e.Graphics.DrawString(Tabel2.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 180, 80 + tinggi)

            e.Graphics.DrawString(Tabel2.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 265, 80 + tinggi)
            e.Graphics.DrawString(Tabel2.Rows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 340, 80 + tinggi)
        Next

       
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call KonekDB()
        Call tampil_data()
        Call tampil_data2()
    End Sub
End Class