Imports System.Data.Odbc

Public Class Formutama

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtkodeuser.PasswordChar = ""
        Else
            txtkodeuser.PasswordChar = "*"
        End If
    End Sub

    Private Sub Formutama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtkodeuser.PasswordChar = "*"
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Or txtkodeuser.Text = "" Then
            MsgBox("Username atau Kode User Tidak boleh kosong!")
        Else
            Call KoneksiDatabase()
            CMD = New OdbcCommand("select * from TBL_NASABAH where USERNAME='" & txtusername.Text & "' and KODE_USER='" & txtkodeuser.Text & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Berhasil")
                Me.Hide()
                pinjamannasabah.ShowDialog()

            Else
                MsgBox("Username atau kode user salah", MsgBoxStyle.Exclamation, "Gagal")
            End If
        End If
    End Sub

    Private Sub lnkregistrasi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkregistrasi.LinkClicked
        Me.Hide()
        registrasinasabah.Show()
    End Sub

    Private Sub lnkloginadmin_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkloginadmin.LinkClicked
        Me.Hide()
        Formlogin.Show()
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged

    End Sub
End Class