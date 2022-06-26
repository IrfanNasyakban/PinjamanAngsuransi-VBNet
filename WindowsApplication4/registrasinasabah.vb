Imports System.Data.Odbc

Public Class registrasinasabah

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Formutama.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtusername.Text = "" Then
            MsgBox("username Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtkodeuser.Text = "" Then
            MsgBox("Kode User Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtktp.Text = "" Then
            MsgBox("No KTP Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtalamat.Text = "" Then
            MsgBox("Alamat Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txttelepon.Text = "" Then
            MsgBox("Telepon Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtemail.Text = "" Then
            MsgBox("Email Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            Call KoneksiDatabase()
            Dim simpan As String = "insert into tbl_nasabah values ('" & txtusername.Text & "','" _
                                                                      & txtkodeuser.Text & "','" _
                                                                      & txtktp.Text & "','" _
                                                                      & txtalamat.Text & "','" _
                                                                      & txttelepon.Text & "','" _
                                                                      & txtemail.Text & "')"
            CMD = New OdbcCommand(simpan, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Regristrasi Berhasil!", vbInformation, "Sukses")
        End If
    End Sub

    Private Sub txtkodeuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodeuser.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub registrasinasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class