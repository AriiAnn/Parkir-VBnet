Imports System.Data.Odbc

Module Module1
    Public konek As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DR As OdbcDataReader
    Public DS As DataSet
    Public CMD As OdbcCommand


    Sub KonekDB()
        Try
            konek = New OdbcConnection("DSN=db_parkir;MultipleaActiveSets=True")
            If konek.State = ConnectionState.Closed Then
                konek.Open()


            End If


        Catch ex As Exception
            MsgBox("Koneksi ke database gagal", vbCritical, "GAgal")

        End Try

    End Sub


End Module
