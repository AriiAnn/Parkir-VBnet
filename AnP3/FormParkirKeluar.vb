Imports System.Data.Odbc
Imports System.Drawing.Printing
Public Class FormParkirKeluar
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Dim WithEvents PD2 As New PrintDocument
    Dim PPD2 As New PrintPreviewDialog
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

    Sub Bersihkan()


        JamMasuk.Text = "00:00:00"
        JamKeluar.Text = "00:00:00"
        JamParkir.Text = "---"
        Tarif.Text = "---"
        TotalBayar.Clear()
        LamaParkir.Text = "0:0:0"
        UangTunai.Clear()
        Kembalian.Clear()
        JamParkir.Text = "0"
        kdKeluar.Clear()
        txtkdmasuk.Clear()
        JamKeluar.Focus()



    End Sub

    Private Sub LamaParkir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LamaParkir.TextChanged

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If JamMasuk.Text = "" Then
                MsgBox("Jam Masuk tidak boleh kosong")
                Exit Sub
            ElseIf JamKeluar.Text = "" Then
                MsgBox("Jam Keluar tidak boleh kosong")
                Exit Sub
            ElseIf UangTunai.Text = "" Then
                MsgBox("masukkan jumlah uang yang di terima")
                Exit Sub
            Else
                CMD = New OdbcCommand("SELECT * FROM TBL_PARKIRKELUAR WHERE KD_KELUAR = '" & "" & "'", konek)
                DR = CMD.ExecuteReader
                DR.Read()
                If Not DR.HasRows Then
                    Dim simpan As String = "insert into tbl_parkirkeluar (kd_masuk, Jam_Keluar, Lama_Parkir,Jam_Parkir, Total_Bayar, Uang_Tunai, Kembalian ) value ('" & txtkdmasuk.Text & "','" _
                                                                                & JamKeluar.Text & "','" _
                                                                                & LamaParkir.Text & "','" _
                                                                                & JamParkir.Text & "','" _
                                                                                & TotalBayar.Text & "','" _
                                                                                & UangTunai.Text & "','" _
                                                                                & Kembalian.Text & "')"


                    CMD = New OdbcCommand(simpan, konek)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil disimpan", vbInformation, "simpan")
                    Call tampil_data()
                    Call Bersihkan()

                Else
                    MsgBox("data sudah ada")






                End If


            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub Tabel1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Tabel1.CellMouseClick
        On Error Resume Next
        txtkdmasuk.Text = Tabel1.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_PARKIRMASUK WHERE KD_MASUK = '" & txtkdmasuk.Text & "" & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkdmasuk.Text = DR.Item("kd_masuk")

            Tarif.Text = DR.Item("Tarif")
            JamMasuk.Text = DR.Item("Jam_Masuk")




        End If
    End Sub

    Private Sub ParkirKeluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KonekDB()
        Call tampil_data()
        Call tampil_data2()

        JamMasuk.Text = "00:00:00"
        JamKeluar.Text = "00:00:00"
        txtkdmasuk.Enabled = False
        Tabel1.Columns(0).Width = 65
        Tabel1.Columns(1).Width = 90
        Tabel1.Columns(2).Width = 100
        Tabel1.Columns(3).Width = 90
        Tabel1.Columns(4).Width = 60
        Tabel2.Columns(0).Width = 60
        Tabel2.Columns(1).Width = 75
        Tabel2.Columns(2).Width = 75
        Tabel2.Columns(3).Width = 85
        Tabel2.Columns(4).Width = 85
        Tabel2.Columns(5).Width = 85
        Tabel2.Columns(6).Width = 75
        Tabel2.Columns(7).Width = 75

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        FormMenu.Show()

    End Sub

    Private Sub BtnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTotal.Click
        If JamMasuk.Text = "" Then
            MsgBox("Jam Masuk tidak boleh kosong")
            Exit Sub
        ElseIf JamKeluar.Text = "" Then
            MsgBox("Jam Keluar tidak boleh kosong")
            Exit Sub
        End If

        Dim Hasil As TimeSpan = TimeValue(JamKeluar.Text) - TimeValue(JamMasuk.Text)
        LamaParkir.Text = (String.Format("{0}:{1}:{2}", Hasil.Hours, Hasil.Minutes, Hasil.Seconds))
        JamParkir.Text = Hour(LamaParkir.Text) + 1
        TotalBayar.Text = Val(JamParkir.Text) * Val(Tarif.Text)
    End Sub

    Private Sub Selesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Selesai.Click
        If UangTunai.Text = "" Then
            MsgBox("Uang tunai tidak boleh kosong")
            Exit Sub
        End If
        Kembalian.Text = UangTunai.Text - TotalBayar.Text



    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If kdKeluar.Text = "" Then
            MsgBox("data  belum di pilih", vbInformation, "pesan")
            Exit Sub
        Else
            Dim hapusdata As String = "delete from tbl_parkirkeluar where kd_keluar = '" & kdKeluar.Text & "'"
            CMD = New OdbcCommand(hapusdata, konek)
            CMD.ExecuteNonQuery()
            MsgBox("data berhasil di hapus", vbInformation, "pesan")
            Call tampil_data()
            Call Bersihkan()
        End If

    End Sub

    Private Sub Tabel2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabel2.CellContentClick
        On Error Resume Next
        kdKeluar.Text = Tabel2.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_PARKIRKELUAR WHERE Kd_keluar = '" & kdKeluar.Text & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            kdKeluar.Text = DR.Item("Kd_keluar")


            JamMasuk.Text = DR.Item("Jam_Masuk")
            JamKeluar.Text = DR.Item("Jam_Keluar")

            TotalBayar.Text = DR.Item("Total_Bayar")
            LamaParkir.Text = DR.Item("Lama_Parkir")
            JamParkir.Text = DR.Item("Jam_Parkir")
            UangTunai.Text = DR.Item("Uang_Tunai")
            Kembalian.Text = DR.Item("Kembalian")



        End If
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        Try
            If JamMasuk.Text = "" Then
                MsgBox("Jam Masuk tidak boleh kosong")
                Exit Sub
            ElseIf JamKeluar.Text = "" Then
                MsgBox("Jam Keluar tidak boleh kosong")
                Exit Sub

            Else
                CMD = New OdbcCommand("SELECT * FROM TBL_PARKIRKELUAR WHERE Kd_keluar = '" & kdKeluar.Text & "'", konek)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Dim edit As String = "update tbl_parkirkeluar set kd_masuk ='" & txtkdmasuk.Text & _
                        "',Jam_Keluar ='" & JamKeluar.Text & "',Total_Bayar = '" & TotalBayar.Text & "', Lama_Parkir = ' " & LamaParkir.Text & "',Jam_Parkir = '" & JamParkir.Text & "', Uang_Tunai= '" & UangTunai.Text & "', Kembalian ='" & Kembalian.Text & "' where kd_keluar='" & kdKeluar.Text & "'"
                    CMD = New OdbcCommand(edit, konek)
                    CMD.ExecuteNonQuery()
                    MsgBox("Berhasil di edit", vbInformation, "edit")
                    Call tampil_data()
                    Call KonekDB()



                Else
                    MsgBox("data belum dipilih")
                    Exit Sub

                End If


            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub baru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baru.Click
        Bersihkan()
    End Sub

    Private Sub PD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 430, 130)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim f12 As New Font(" Times New Roman", 8, FontStyle.Regular)
        Dim f12b As New Font(" Times New Roman", 8, FontStyle.Bold)
        Dim f14 As New Font(" Times New Roman", 14, FontStyle.Regular)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        Dim kiri As New StringFormat
        kiri.Alignment = StringAlignment.Near
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-----------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Bukti Pembayaran Parkir", f14, Brushes.Black, centermargin, 5, tengah)

        e.Graphics.DrawString(garis, f12, Brushes.Black, 0, 55)

        e.Graphics.DrawString("Kode Masuk", f12b, Brushes.Black, 40, 70, tengah)
        e.Graphics.DrawString("Kode keluar", f12b, Brushes.Black, 130, 70, tengah)
        e.Graphics.DrawString("Biaya parkir", f12b, Brushes.Black, 210, 70, tengah)
        e.Graphics.DrawString("Uang Tunai", f12b, Brushes.Black, 290, 70, tengah)
        e.Graphics.DrawString("Kembalian", f12b, Brushes.Black, 360, 70, tengah)
        e.Graphics.DrawString(garis, f12, Brushes.Black, 0, 85)

        e.Graphics.DrawString(txtkdmasuk.Text, f12, Brushes.Black, 33, 100)
        e.Graphics.DrawString(kdKeluar.Text, f12, Brushes.Black, 123, 100)
        e.Graphics.DrawString(TotalBayar.Text, f12, Brushes.Black, 180, 100)
        e.Graphics.DrawString(UangTunai.Text, f12, Brushes.Black, 265, 100)
        e.Graphics.DrawString(Kembalian.Text, f12, Brushes.Black, 340, 100)
    End Sub

    Private Sub CetakStruk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakStruk.Click
        PPD.Document = PD
        PPD.ShowDialog()
        PD.Print()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        e.Graphics.DrawString("Jam Masuk", f10b, Brushes.Black, 210, 70, tengah)
        e.Graphics.DrawString("Jam Keluar", f10b, Brushes.Black, 290, 70, tengah)
        e.Graphics.DrawString("Biaya Parkir", f10b, Brushes.Black, 380, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 85)
        Tabel2.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To Tabel2.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(Tabel2.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 33, 80 + tinggi)
            e.Graphics.DrawString(Tabel2.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 123, 80 + tinggi)
            e.Graphics.DrawString(Tabel1.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 180, 80 + tinggi)
            e.Graphics.DrawString(Tabel2.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 265, 80 + tinggi)
            e.Graphics.DrawString(Tabel2.Rows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 340, 80 + tinggi)
        Next

    End Sub

    Private Sub Tabel1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabel1.CellContentClick

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call KonekDB()
        Call tampil_data()
        Call tampil_data2()
    End Sub
End Class
