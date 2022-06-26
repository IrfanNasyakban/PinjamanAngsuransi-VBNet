Imports System.Data.Odbc

Public Class Formkonfirmasi

    Sub tampil_pinjaman()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_pinjaman", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabelpinjaman.DataSource = DS.Tables(0)
    End Sub

    Sub tampil_pinjaman2()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_konfirmasi", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabelpinjaman2.DataSource = DS.Tables(0)
    End Sub

    Private Sub btnedit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit2.Click
        If txtkodeuser.Text = "" Then
            MsgBox("Kode User Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txttanggaltempo.Text = "" Then
            MsgBox("Tanggal Tempo Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtangsuran.Text = "" Then
            MsgBox("Angsuran Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtstatus.Text = "" Then
            MsgBox("Status Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_KONFIRMASI WHERE KODE_KONFIRMASI = '" & txtkodekonfirmasi.Text & "" & "" & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim edit As String = "update tbl_konfirmasi set kode_user ='" & txtkodeuser.Text & _
                    "',tanggal_tempo='" & txttanggaltempo.Text & _
                    "',angsuran='" & txtangsuran.Text & _
                    "',status='" & txtstatus.Text & _
                    "' where kode_konfirmasi='" & txtkodekonfirmasi.Text & "'"

                CMD = New OdbcCommand(edit, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit", vbInformation, "Edit")
                Call KoneksiDatabase()
                Call tampil_pinjaman2()
            Else
                MsgBox("Data belum di pilih")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnhapus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus2.Click
        If txtkodekonfirmasi.Text = "" Then
            MsgBox("Data belum di pilih", vbInformation, "pesan")
            Exit Sub
        Else
            Dim hapusdata As String = "delete from tbl_konfirmasi where kode_konfirmasi = '" & txtkodekonfirmasi.Text & "'"
            CMD = New OdbcCommand(hapusdata, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", vbInformation, "pesan")
            Call KoneksiDatabase()
            Call tampil_pinjaman2()
        End If
    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        Me.Hide()
        Formadmin.Show()
    End Sub

    Private Sub Formpinjamanadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Call tampil_pinjaman()
        Call tampil_pinjaman2()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtkodeuser.Text = "" Then
            MsgBox("Kode User tidak boleh kosong")
            Exit Sub
        ElseIf txttanggaltempo.Text = "" Then
            MsgBox("Tanggal Tempo tidak boleh kosong")
            Exit Sub
        ElseIf txtstatus.Text = "" Then
            MsgBox("Status tidak boleh kosong")
            Exit Sub
        ElseIf txtangsuran.Text = "" Then
            MsgBox("Angsuran tidak boleh kosong")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_KONFIRMASI WHERE KODE_KONFIRMASI = '" & "" & "" & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan As String = "insert into tbl_konfirmasi (kode_user, tanggal_tempo, angsuran, status) value ('" & txtkodeuser.Text & "','" _
                                                                                                                          & txttanggaltempo.Text & "','" _
                                                                                                                          & txtangsuran.Text & "','" _
                                                                                                                          & txtstatus.Text & "')"


                CMD = New OdbcCommand(simpan, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil disimpan", vbInformation, "simpan")
                Call KoneksiDatabase()
                Call tampil_pinjaman2()
            Else
                MsgBox("data sudah ada")
            End If
        End If
    End Sub

    Private Sub tabelpinjaman_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles tabelpinjaman.CellMouseClick
        On Error Resume Next
        txtkodeuser.Text = tabelpinjaman.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_PINJAMAN WHERE KODE_USER = '" & txtkodeuser.Text & "" & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkodeuser.Text = DR.Item("KODE_USER")
            txttanggal.Text = DR.Item("TANGGAL")
            txtpokok.Text = DR.Item("POKOK")
            lblbunga.Text = DR.Item("BUNGA")
            txtangsuran.Text = DR.Item("ANGSURAN")
        End If
    End Sub

    Private Sub tabelpinjaman2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles tabelpinjaman2.CellMouseClick
        On Error Resume Next
        txtkodekonfirmasi.Text = tabelpinjaman2.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_KONFIRMASI WHERE KODE_KONFIRMASI = '" & txtkodekonfirmasi.Text & "" & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkodekonfirmasi.Text = DR.Item("KODE_KONFIRMASI")
            txtkodeuser.Text = DR.Item("KODE_USER")
            txttanggaltempo.Text = DR.Item("TANGGAL_TEMPO")
            txtstatus.Text = DR.Item("STATUS")
        End If
    End Sub

    Private Sub tabelpinjaman_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabelpinjaman.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtangsuran.Clear()
        txtkodekonfirmasi.Clear()
        txtkodeuser.Clear()
        txtpokok.Clear()
        txtstatus.Clear()
        lblbunga.Text = "---"
    End Sub
End Class