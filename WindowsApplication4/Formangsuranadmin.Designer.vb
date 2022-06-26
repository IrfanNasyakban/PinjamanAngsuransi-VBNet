<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formangsuranadmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txttelat = New System.Windows.Forms.TextBox()
        Me.txtdenda = New System.Windows.Forms.TextBox()
        Me.txtkodeangsuran = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btntambah4 = New System.Windows.Forms.Button()
        Me.btnedit4 = New System.Windows.Forms.Button()
        Me.btnhapus4 = New System.Windows.Forms.Button()
        Me.btnsimpan4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtkodekonfirmasi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttanggaltempo = New System.Windows.Forms.DateTimePicker()
        Me.tabelangsuran = New System.Windows.Forms.DataGridView()
        Me.tabelkonfirmasi = New System.Windows.Forms.DataGridView()
        Me.txtangsuran = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txttotalangsuran = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        CType(Me.tabelangsuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelkonfirmasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttelat
        '
        Me.txttelat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelat.Location = New System.Drawing.Point(200, 252)
        Me.txttelat.Name = "txttelat"
        Me.txttelat.Size = New System.Drawing.Size(195, 32)
        Me.txttelat.TabIndex = 50
        '
        'txtdenda
        '
        Me.txtdenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdenda.Location = New System.Drawing.Point(200, 290)
        Me.txtdenda.Name = "txtdenda"
        Me.txtdenda.Size = New System.Drawing.Size(195, 32)
        Me.txtdenda.TabIndex = 49
        '
        'txtkodeangsuran
        '
        Me.txtkodeangsuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodeangsuran.Location = New System.Drawing.Point(200, 60)
        Me.txtkodeangsuran.Name = "txtkodeangsuran"
        Me.txtkodeangsuran.Size = New System.Drawing.Size(43, 32)
        Me.txtkodeangsuran.TabIndex = 53
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 66)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(155, 24)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "Kode Angsuran"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(20, 258)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(115, 24)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Telat/Bulan"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(19, 296)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(71, 24)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "Denda"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 142)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(158, 24)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Tanggal Tempo"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(117, 9)
        Me.Label30.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(208, 31)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "Data Angsuran"
        '
        'btntambah4
        '
        Me.btntambah4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btntambah4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah4.Location = New System.Drawing.Point(1, 460)
        Me.btntambah4.Name = "btntambah4"
        Me.btntambah4.Size = New System.Drawing.Size(107, 41)
        Me.btntambah4.TabIndex = 56
        Me.btntambah4.Text = "Tambah"
        Me.btntambah4.UseVisualStyleBackColor = False
        '
        'btnedit4
        '
        Me.btnedit4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnedit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit4.Location = New System.Drawing.Point(206, 460)
        Me.btnedit4.Name = "btnedit4"
        Me.btnedit4.Size = New System.Drawing.Size(102, 41)
        Me.btnedit4.TabIndex = 57
        Me.btnedit4.Text = "Edit"
        Me.btnedit4.UseVisualStyleBackColor = False
        '
        'btnhapus4
        '
        Me.btnhapus4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnhapus4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus4.Location = New System.Drawing.Point(307, 460)
        Me.btnhapus4.Name = "btnhapus4"
        Me.btnhapus4.Size = New System.Drawing.Size(93, 41)
        Me.btnhapus4.TabIndex = 54
        Me.btnhapus4.Text = "Hapus"
        Me.btnhapus4.UseVisualStyleBackColor = False
        '
        'btnsimpan4
        '
        Me.btnsimpan4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsimpan4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan4.Location = New System.Drawing.Point(108, 460)
        Me.btnsimpan4.Name = "btnsimpan4"
        Me.btnsimpan4.Size = New System.Drawing.Size(100, 41)
        Me.btnsimpan4.TabIndex = 55
        Me.btnsimpan4.Text = "Simpan"
        Me.btnsimpan4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(406, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 41)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtkodekonfirmasi
        '
        Me.txtkodekonfirmasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodekonfirmasi.Location = New System.Drawing.Point(200, 98)
        Me.txtkodekonfirmasi.Name = "txtkodekonfirmasi"
        Me.txtkodekonfirmasi.Size = New System.Drawing.Size(43, 32)
        Me.txtkodekonfirmasi.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Kode Konfirmasi"
        '
        'txttanggaltempo
        '
        Me.txttanggaltempo.Location = New System.Drawing.Point(200, 144)
        Me.txttanggaltempo.Name = "txttanggaltempo"
        Me.txttanggaltempo.Size = New System.Drawing.Size(200, 22)
        Me.txttanggaltempo.TabIndex = 68
        '
        'tabelangsuran
        '
        Me.tabelangsuran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelangsuran.Location = New System.Drawing.Point(406, 216)
        Me.tabelangsuran.Name = "tabelangsuran"
        Me.tabelangsuran.RowTemplate.Height = 24
        Me.tabelangsuran.Size = New System.Drawing.Size(814, 198)
        Me.tabelangsuran.TabIndex = 70
        '
        'tabelkonfirmasi
        '
        Me.tabelkonfirmasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelkonfirmasi.Location = New System.Drawing.Point(406, 12)
        Me.tabelkonfirmasi.Name = "tabelkonfirmasi"
        Me.tabelkonfirmasi.RowTemplate.Height = 24
        Me.tabelkonfirmasi.Size = New System.Drawing.Size(814, 198)
        Me.tabelkonfirmasi.TabIndex = 69
        '
        'txtangsuran
        '
        Me.txtangsuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtangsuran.Location = New System.Drawing.Point(200, 178)
        Me.txtangsuran.Name = "txtangsuran"
        Me.txtangsuran.Size = New System.Drawing.Size(195, 32)
        Me.txtangsuran.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Angsuran"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(200, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 37)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "Hitung Denda"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txttotalangsuran
        '
        Me.txttotalangsuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalangsuran.Location = New System.Drawing.Point(200, 328)
        Me.txttotalangsuran.Name = "txttotalangsuran"
        Me.txttotalangsuran.Size = New System.Drawing.Size(195, 32)
        Me.txttotalangsuran.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Total Angsuran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 34)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "catatan: Telat 1 bulan naik 1% apabila telat lebih " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dari 10 bulan maka bunga nai" & _
            "k menjadi 30%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(201, 410)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(195, 32)
        Me.txtstatus.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 24)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Status"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(804, 430)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(205, 41)
        Me.Button3.TabIndex = 79
        Me.Button3.Text = "Cetak Laporan"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1015, 430)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(205, 41)
        Me.Button4.TabIndex = 80
        Me.Button4.Text = "Cetak Kwitansi"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PrintDocument2
        '
        '
        'Formangsuranadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(1236, 504)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotalangsuran)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtangsuran)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tabelangsuran)
        Me.Controls.Add(Me.tabelkonfirmasi)
        Me.Controls.Add(Me.txttanggaltempo)
        Me.Controls.Add(Me.txtkodekonfirmasi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btntambah4)
        Me.Controls.Add(Me.btnedit4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnhapus4)
        Me.Controls.Add(Me.btnsimpan4)
        Me.Controls.Add(Me.txttelat)
        Me.Controls.Add(Me.txtdenda)
        Me.Controls.Add(Me.txtkodeangsuran)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label30)
        Me.Name = "Formangsuranadmin"
        Me.Text = "Formangsuranadmin"
        CType(Me.tabelangsuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelkonfirmasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttelat As System.Windows.Forms.TextBox
    Friend WithEvents txtdenda As System.Windows.Forms.TextBox
    Friend WithEvents txtkodeangsuran As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btntambah4 As System.Windows.Forms.Button
    Friend WithEvents btnedit4 As System.Windows.Forms.Button
    Friend WithEvents btnhapus4 As System.Windows.Forms.Button
    Friend WithEvents btnsimpan4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtkodekonfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttanggaltempo As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabelangsuran As System.Windows.Forms.DataGridView
    Friend WithEvents tabelkonfirmasi As System.Windows.Forms.DataGridView
    Friend WithEvents txtangsuran As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txttotalangsuran As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
End Class
