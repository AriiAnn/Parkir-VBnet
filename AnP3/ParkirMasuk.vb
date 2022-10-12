Imports System.Data.Odbc
Imports System.Drawing.Printing
Public Class FormParkirMasuk
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Sub tampil_data()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_parkirmasuk", konek)
        DS = New DataSet
        DA.Fill(DS)
        Tabel1.DataSource = DS.Tables(0)
        Tabel1.ReadOnly = True
        Tabel1.Columns(0).Width = 65
        Tabel1.Columns(1).Width = 90
        Tabel1.Columns(2).Width = 95
        Tabel1.Columns(3).Width = 75



    End Sub

    Sub Bersihkan()
        NoKendaraan.Clear()
        txtkdmasuk.Clear()
        JamMasuk.Text = "00:00:00"

        JenKendaraan.Text = "---"
        Tarif.Text = "---"

        RBMotor.Checked = False
        RBMobil.Checked = False
        NoKendaraan.Focus()




    End Sub

    Private Sub RBMotor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMotor.CheckedChanged
        If RBMotor.Checked = True Then
            Tarif.Text = "2000"
            JenKendaraan.Text = "Motor"


        End If
    End Sub

    Private Sub RBMobil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMobil.CheckedChanged
        If RBMobil.Checked = True Then
            Tarif.Text = "3000"
            JenKendaraan.Text = "Mobil"

        End If
    End Sub

    Private Sub FormParkirMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KonekDB()
        Call tampil_data()
        JamMasuk.Text = "00:00:00"
        txtkdmasuk.Enabled = False

    End Sub

    Private Sub Kembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kembali.Click
        Me.Hide()
        FormMenu.Show()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If NoKendaraan.Text = "" Then
                MsgBox("Nomor kendaraan tidak boleh kosong")
                Exit Sub
            ElseIf JamMasuk.Text = "" Then
                MsgBox("Jam Masuk tidak boleh kosong")
                Exit Sub

            Else
                CMD = New OdbcCommand("SELECT * FROM TBL_PARKIRMASUK WHERE KD_MASUK = '" & "" & "'", konek)
                DR = CMD.ExecuteReader
                DR.Read()
                If Not DR.HasRows Then
                    Dim simpan As String = "insert into tbl_parkirmasuk (No_Kendaraan, Tarif, Jam_Masuk,  Jen_Kendaraan) value ('" & NoKendaraan.Text & "','" _
                                                                                & Tarif.Text & "','" _
                                                                                & JamMasuk.Text & "','" _
                                                                                & JenKendaraan.Text & "')"

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

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If txtkdmasuk.Text = "" Then
            MsgBox("data  belum di pilih", vbInformation, "pesan")
            Exit Sub
        Else
            Dim hapusdata As String = "delete from tbl_parkirmasuk where kd_masuk = '" & txtkdmasuk.Text & "'"
            CMD = New OdbcCommand(hapusdata, konek)
            CMD.ExecuteNonQuery()
            MsgBox("data berhasil di hapus", vbInformation, "pesan")
            Call KonekDB()
            Call tampil_data()
            Call Bersihkan()
        End If

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        Try
            If NoKendaraan.Text = "" Then
                MsgBox("Nomor kendaraan tidak boleh kosong")
                Exit Sub
            ElseIf JamMasuk.Text = "" Then
                MsgBox("Jam Masuk tidak boleh kosong")
                Exit Sub

            Else
                CMD = New OdbcCommand("SELECT * FROM TBL_PARKIRMASUK WHERE KD_MASUK = '" & txtkdmasuk.Text & "'", konek)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Dim edit As String = "update tbl_parkirmasuk set No_Kendaraan ='" & NoKendaraan.Text & _
                        "', Tarif ='" & Tarif.Text & "', Jam_Masuk = '" & JamMasuk.Text & "',Jen_Kendaraan = '" & JenKendaraan.Text & _
                        "' where kd_masuk ='" & txtkdmasuk.Text & "'"
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

    Private Sub CetakStruk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakStruk.Click
        PPD.Document = PD
        PPD.ShowDialog()
        PD.Print()

    End Sub
    Private Sub PD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 250, 100)
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
        garis = "------------------------------------------------------"

        e.Graphics.DrawString("Struk Parkir", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString(garis, f12, Brushes.Black, 0, 30)

        e.Graphics.DrawString("Plat_Kendaraan", f12b, Brushes.Black, 85, 45)
        e.Graphics.DrawString("Jam_Masuk", f12b, Brushes.Black, 0, 45)
        e.Graphics.DrawString("Harga/Jam", f12b, Brushes.Black, rightmargin, 45, kanan)



        e.Graphics.DrawString(NoKendaraan.Text, f12, Brushes.Black, 85, 65)
        e.Graphics.DrawString(JamMasuk.Text, f12, Brushes.Black, 0, 65)
        e.Graphics.DrawString(Tarif.Text, f12, Brushes.Black, rightmargin, 65, kanan)









    End Sub

    Private Sub Tabel1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Tabel1.CellMouseClick
        On Error Resume Next
        txtkdmasuk.Text = Tabel1.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_PARKIRMASUK WHERE KD_MASUK = '" & txtkdmasuk.Text & "" & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkdmasuk.Text = DR.Item("kd_masuk")
            NoKendaraan.Text = DR.Item("No_Kendaraan")
            Tarif.Text = DR.Item("Tarif")
            JamMasuk.Text = DR.Item("Jam_Masuk")
            JenKendaraan.Text = DR.Item("Jen_Kendaraan")



        End If
    End Sub


    Private Sub Tabel1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabel1.CellContentClick

    End Sub
End Class
