Imports System.Data.Odbc

Public Class LoginAdmin


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpasword.PasswordChar = ""
        Else
            txtpasword.PasswordChar = "*"
        End If
    End Sub

    Private Sub loginadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpasword.PasswordChar = "*"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtusername.Text = "" Or Button1.Text = "" Then
            MsgBox("Username atau password Tidak boleh kosong!")
        Else
            Call KonekDB()
            CMD = New OdbcCommand("select * from TBL_ADMIN where USERNAME='" & txtusername.Text & "' and PASSWORD='" & txtpasword.Text & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Berhasil")
                FormMenu.Show()

            Else
                MsgBox("Username atau password salah", MsgBoxStyle.Exclamation, "Gagal")
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class

