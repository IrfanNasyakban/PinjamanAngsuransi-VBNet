Imports System.Data.Odbc
Imports Microsoft.VisualBasic

Public Class pinjamannasabah

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtkodeuser.Text = "" Then
            MsgBox("Kode User Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txttanggal.Text = "" Then
            MsgBox("Tanggal Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtpokok.Text = "" Then
            MsgBox("Pokok Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf lblbunga.Text = "" Then
            MsgBox("Bunga Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtangsuran.Text = "" Then
            MsgBox("Angsuran Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtstatus.Text = "" Then
            MsgBox("Status Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            Call KoneksiDatabase()
            Dim simpan As String = "insert into tbl_pinjaman values ('" & txtkodeuser.Text & "','" _
                                                                      & txttanggal.Text & "','" _
                                                                      & txtpokok.Text & "','" _
                                                                      & lblbunga.Text & "','" _
                                                                      & txtangsuran.Text & "','" _
                                                                      & txtstatus.Text & "')"
            CMD = New OdbcCommand(simpan, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Terimakasih, Pinjaman anda akan saya konfirmasi dalam 24 jam", vbInformation, "Sukses")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Formutama.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim bunga As Integer
        If txtpokok.Text < 10000000 Then
            lblbunga.Text = "10%"
        Else
            lblbunga.Text = "15%"
        End If

        If lblbunga.Text = "10%" Then
            bunga = txtpokok.Text * 0.1
            txtangsuran.Text = txtpokok.Text + bunga
        ElseIf lblbunga.Text = "15%" Then
            bunga = txtpokok.Text * 0.15
            txtangsuran.Text = txtpokok.Text + bunga
        End If
    End Sub

    Private Sub txtpokok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpokok.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("hanya angka!")
        End If
    End Sub

    Private Sub txtangsuran_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtangsuran.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("hanya angka!")
        End If
    End Sub

    Private Sub txtpokok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpokok.TextChanged

    End Sub
End Class