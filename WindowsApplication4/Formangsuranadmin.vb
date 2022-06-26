Imports System.Data.Odbc
Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions
Imports System.Drawing.Printing

Public Class Formangsuranadmin

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Dim WithEvents PD2 As New PrintDocument
    Dim PPD2 As New PrintPreviewDialog

    Sub tampil_angsuran()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_angsuran", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabelangsuran.DataSource = DS.Tables(0)
    End Sub
    Sub tampil_konfirmasi()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_konfirmasi", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabelkonfirmasi.DataSource = DS.Tables(0)
    End Sub

    Private Sub btntambah4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah4.Click
        txtkodeangsuran.Clear()
        txtkodekonfirmasi.Clear()
        txttelat.Clear()
        txtdenda.Clear()
        txtkodekonfirmasi.Focus()
        txtangsuran.Clear()
        txttotalangsuran.Clear()
        txtstatus.Clear()
    End Sub

    Private Sub btnsimpan4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan4.Click
        If txtkodekonfirmasi.Text = "" Then
            MsgBox("Kode Konfirmasi Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtangsuran.Text = "" Then
            MsgBox("Tanggal Tempo Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txttelat.Text = "" Then
            MsgBox("Telat Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtdenda.Text = "" Then
            MsgBox("Denda Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_ANGSURAN WHERE KODE_ANGSURAN = '" & "" & "" & "" & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan As String = "insert into tbl_angsuran (kode_konfirmasi, telat_perbulan, denda, total_angsuran, status) value ('" & txtkodekonfirmasi.Text & "','" _
                                                                                                                                    & txttelat.Text & "','" _
                                                                                                                                    & txtdenda.Text & "','" _
                                                                                                                                    & txttotalangsuran.Text & "','" _
                                                                                                                                    & txtstatus.Text & "')"

                CMD = New OdbcCommand(simpan, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", vbInformation, "Simpan")
                Call KoneksiDatabase()
                Call tampil_angsuran()
            Else
                MsgBox("Data sudah ada")
            End If
        End If
    End Sub

    Private Sub btnedit4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit4.Click
        If txtkodekonfirmasi.Text = "" Then
            MsgBox("Kode Konfirmasi Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txttelat.Text = "" Then
            MsgBox("Telat Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtdenda.Text = "" Then
            MsgBox("Denda Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_ANGSURAN WHERE KODE_ANGSURAN = '" & txtkodeangsuran.Text & "" & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim edit As String = "update tbl_angsuran set kode_konfirmasi ='" & txtkodekonfirmasi.Text & _
                    "',telat_perbulan='" & txttelat.Text & _
                    "',denda='" & txtdenda.Text & _
                    "',total_angsuran='" & txttotalangsuran.Text & _
                    "',status='" & txtstatus.Text & _
                    "' where kode_angsuran='" & txtkodeangsuran.Text & "'"

                CMD = New OdbcCommand(edit, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit", vbInformation, "Edit")
                Call KoneksiDatabase()
                Call tampil_angsuran()
            Else
                MsgBox("Data belum di pilih")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnhapus4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus4.Click
        If txtkodeangsuran.Text = "" Then
            MsgBox("Data belum di pilih", vbInformation, "pesan")
            Exit Sub
        Else
            Dim hapusdata As String = "delete from tbl_angsuran where kode_angsuran = '" & txtkodeangsuran.Text & "'"
            CMD = New OdbcCommand(hapusdata, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", vbInformation, "pesan")
            Call KoneksiDatabase()
            Call tampil_angsuran()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Call KoneksiDatabase()
        Call tampil_angsuran()
        Formadmin.Show()
    End Sub

    Private Sub Formangsuranadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Call tampil_angsuran()
        Call tampil_konfirmasi()
    End Sub

    Private Sub txttelat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelat.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("hanya angka!")
        End If
    End Sub

    Private Sub tabelkonfirmasi_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles tabelkonfirmasi.CellMouseClick
        On Error Resume Next
        txtkodekonfirmasi.Text = tabelkonfirmasi.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_KONFIRMASI WHERE KODE_KONFIRMASI = '" & txtkodekonfirmasi.Text & "" & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkodekonfirmasi.Text = DR.Item("KODE_KONFIRMASI")
            txttanggaltempo.Text = DR.Item("TANGGAL_TEMPO")
            txtangsuran.Text = DR.Item("ANGSURAN")
        End If
    End Sub

    Private Sub tabelangsuran_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles tabelangsuran.CellMouseClick
        On Error Resume Next
        txtkodeangsuran.Text = tabelangsuran.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_ANGSURAN WHERE KODE_ANGSURAN = '" & txtkodeangsuran.Text & "" & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkodekonfirmasi.Text = DR.Item("KODE_KONFIRMASI")
            txttelat.Text = DR.Item("TELAT_PERBULAN")
            txtdenda.Text = DR.Item("DENDA")
            txttotalangsuran.Text = DR.Item("TOTAL_ANGSURAN")
            txtstatus.Text = DR.Item("STATUS")
        End If
    End Sub

    Private Sub txtdenda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdenda.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("hanya angka!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim denda As Integer
        If txttelat.Text = 1 Then
            denda = txtangsuran.Text * 0.01
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        ElseIf txttelat.Text = 2 Then
            denda = txtangsuran.Text * 0.02
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        ElseIf txttelat.Text = 3 Then
            denda = txtangsuran.Text * 0.03
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        ElseIf txttelat.Text = 4 Then
            denda = txtangsuran.Text * 0.04
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        ElseIf txttelat.Text = 5 Then
            denda = txtangsuran.Text * 0.05
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        ElseIf txttelat.Text = 6 Then
            denda = txtangsuran.Text * 0.06
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        ElseIf txttelat.Text = 7 Then
            denda = txtangsuran.Text * 0.07
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        ElseIf txttelat.Text = 8 Then
            denda = txtangsuran.Text * 0.08
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        ElseIf txttelat.Text = 9 Then
            denda = txtangsuran.Text * 0.09
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        ElseIf txttelat.Text > 10 Then
            denda = txtangsuran.Text * 0.3
            txtdenda.Text = denda
            txttotalangsuran.Text = txtangsuran.Text + denda
        End If

    End Sub

    Private Sub txtangsuran_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtangsuran.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("hanya angka!")
        End If
    End Sub

    Private Sub txttotalangsuran_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotalangsuran.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("hanya angka!")
        End If
    End Sub

    Private Sub txtangsuran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtangsuran.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtangsuran.Text = digitsOnly.Replace(txtangsuran.Text, "")
    End Sub

    Private Sub txtdenda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdenda.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtdenda.Text = digitsOnly.Replace(txtdenda.Text, "")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 608, 130)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "----------------------------------------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Denda Pinjaman Angsuransi", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("PT. Pinjaman Angsuransi", f10, Brushes.Black, centermargin, 30, tengah)
        e.Graphics.DrawString("Tanggal: " + txttanggaltempo.Text, f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 55)

        e.Graphics.DrawString("Kode Angsuran", f10b, Brushes.Black, 50, 70, tengah)
        e.Graphics.DrawString("Kode Konfirmasi", f10b, Brushes.Black, 165, 70, tengah)
        e.Graphics.DrawString("Telat Perbulan", f10b, Brushes.Black, 273, 70, tengah)
        e.Graphics.DrawString("Denda", f10b, Brushes.Black, 362, 70, tengah)
        e.Graphics.DrawString("Total Angsuran", f10b, Brushes.Black, 445, 70, tengah)
        e.Graphics.DrawString("Status", f10b, Brushes.Black, 537, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 85)

        e.Graphics.DrawString(txtkodeangsuran.Text, f10, Brushes.Black, 33, 100)
        e.Graphics.DrawString(txtkodekonfirmasi.Text, f10, Brushes.Black, 160, 100)
        e.Graphics.DrawString(txttelat.Text, f10, Brushes.Black, 268, 100)
        e.Graphics.DrawString(txtdenda.Text, f10, Brushes.Black, 338, 100)
        e.Graphics.DrawString(txttotalangsuran.Text, f10, Brushes.Black, 420, 100)
        e.Graphics.DrawString(txtstatus.Text, f10, Brushes.Black, 515, 100)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PPD2.Document = PD2
        PPD2.ShowDialog()
    End Sub

    Private Sub PD2_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD2.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 608, 700)
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
        garis = "----------------------------------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Hasil Laporan Denda Angsuran", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("PT. Angsuran Pinjaman", f10, Brushes.Black, centermargin, 30, tengah)
        e.Graphics.DrawString("No: 0822-8899-0099", f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 55)

        e.Graphics.DrawString("Kode Angsuran", f10b, Brushes.Black, 55, 70, tengah)
        e.Graphics.DrawString("Kode Konfirmasi", f10b, Brushes.Black, 173, 70, tengah)
        e.Graphics.DrawString("Telat/Bulan", f10b, Brushes.Black, 279, 70, tengah)
        e.Graphics.DrawString("Denda", f10b, Brushes.Black, 360, 70, tengah)
        e.Graphics.DrawString("Total Angsuran", f10b, Brushes.Black, 450, 70, tengah)
        e.Graphics.DrawString("Status", f10b, Brushes.Black, 540, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 85)
        tabelangsuran.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To tabelangsuran.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(tabelangsuran.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 53, 80 + tinggi)
            e.Graphics.DrawString(tabelangsuran.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 173, 80 + tinggi)
            e.Graphics.DrawString(tabelangsuran.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 270, 80 + tinggi)
            e.Graphics.DrawString(tabelangsuran.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 335, 80 + tinggi)
            e.Graphics.DrawString(tabelangsuran.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 420, 80 + tinggi)
            e.Graphics.DrawString(tabelangsuran.Rows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 520, 80 + tinggi)
        Next
    End Sub
End Class