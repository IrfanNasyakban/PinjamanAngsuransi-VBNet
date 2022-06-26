<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formkonfirmasi
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
        Me.btnedit2 = New System.Windows.Forms.Button()
        Me.btnhapus2 = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.tabelpinjaman = New System.Windows.Forms.DataGridView()
        Me.txtangsuran = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.DateTimePicker()
        Me.lblbunga = New System.Windows.Forms.Label()
        Me.txtkodeuser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.txtpokok = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttanggaltempo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabelpinjaman2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkodekonfirmasi = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.tabelpinjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelpinjaman2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnedit2
        '
        Me.btnedit2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnedit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit2.Location = New System.Drawing.Point(197, 429)
        Me.btnedit2.Name = "btnedit2"
        Me.btnedit2.Size = New System.Drawing.Size(91, 41)
        Me.btnedit2.TabIndex = 46
        Me.btnedit2.Text = "Edit"
        Me.btnedit2.UseVisualStyleBackColor = False
        '
        'btnhapus2
        '
        Me.btnhapus2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnhapus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus2.Location = New System.Drawing.Point(289, 429)
        Me.btnhapus2.Name = "btnhapus2"
        Me.btnhapus2.Size = New System.Drawing.Size(93, 41)
        Me.btnhapus2.TabIndex = 45
        Me.btnhapus2.Text = "Hapus"
        Me.btnhapus2.UseVisualStyleBackColor = False
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembali.Location = New System.Drawing.Point(388, 429)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(93, 41)
        Me.btnkembali.TabIndex = 45
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'tabelpinjaman
        '
        Me.tabelpinjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelpinjaman.Location = New System.Drawing.Point(388, 12)
        Me.tabelpinjaman.Name = "tabelpinjaman"
        Me.tabelpinjaman.RowTemplate.Height = 24
        Me.tabelpinjaman.Size = New System.Drawing.Size(685, 198)
        Me.tabelpinjaman.TabIndex = 49
        '
        'txtangsuran
        '
        Me.txtangsuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtangsuran.Location = New System.Drawing.Point(152, 294)
        Me.txtangsuran.Name = "txtangsuran"
        Me.txtangsuran.Size = New System.Drawing.Size(230, 30)
        Me.txtangsuran.TabIndex = 63
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(176, 133)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(200, 22)
        Me.txttanggal.TabIndex = 61
        '
        'lblbunga
        '
        Me.lblbunga.AutoSize = True
        Me.lblbunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbunga.Location = New System.Drawing.Point(148, 258)
        Me.lblbunga.Name = "lblbunga"
        Me.lblbunga.Size = New System.Drawing.Size(28, 24)
        Me.lblbunga.TabIndex = 59
        Me.lblbunga.Text = "---"
        '
        'txtkodeuser
        '
        Me.txtkodeuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodeuser.Location = New System.Drawing.Point(176, 91)
        Me.txtkodeuser.Name = "txtkodeuser"
        Me.txtkodeuser.Size = New System.Drawing.Size(62, 30)
        Me.txtkodeuser.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Kode User"
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(152, 333)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(230, 30)
        Me.txtstatus.TabIndex = 55
        '
        'txtpokok
        '
        Me.txtpokok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpokok.Location = New System.Drawing.Point(152, 217)
        Me.txtpokok.Name = "txtpokok"
        Me.txtpokok.Size = New System.Drawing.Size(230, 30)
        Me.txtpokok.TabIndex = 56
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 299)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 24)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Angsuran"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 217)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 24)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Pokok"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 338)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 24)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Status"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 258)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(136, 24)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Bunga/Tahun"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 133)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 24)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(115, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 29)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Konfirmasi"
        '
        'txttanggaltempo
        '
        Me.txttanggaltempo.Location = New System.Drawing.Point(176, 172)
        Me.txttanggaltempo.Name = "txttanggaltempo"
        Me.txttanggaltempo.Size = New System.Drawing.Size(200, 22)
        Me.txttanggaltempo.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 24)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Tanggal Tempo"
        '
        'tabelpinjaman2
        '
        Me.tabelpinjaman2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelpinjaman2.Location = New System.Drawing.Point(388, 216)
        Me.tabelpinjaman2.Name = "tabelpinjaman2"
        Me.tabelpinjaman2.RowTemplate.Height = 24
        Me.tabelpinjaman2.Size = New System.Drawing.Size(685, 198)
        Me.tabelpinjaman2.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(100, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 41)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 24)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Kode Konfirmasi"
        '
        'txtkodekonfirmasi
        '
        Me.txtkodekonfirmasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodekonfirmasi.Location = New System.Drawing.Point(176, 51)
        Me.txtkodekonfirmasi.Name = "txtkodekonfirmasi"
        Me.txtkodekonfirmasi.Size = New System.Drawing.Size(62, 30)
        Me.txtkodekonfirmasi.TabIndex = 70
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 41)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Formkonfirmasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(1094, 482)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtkodekonfirmasi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tabelpinjaman2)
        Me.Controls.Add(Me.txttanggaltempo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtangsuran)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.lblbunga)
        Me.Controls.Add(Me.txtkodeuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txtpokok)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tabelpinjaman)
        Me.Controls.Add(Me.btnedit2)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnhapus2)
        Me.Name = "Formkonfirmasi"
        Me.Text = "Formpinjamanadmin"
        CType(Me.tabelpinjaman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelpinjaman2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnedit2 As System.Windows.Forms.Button
    Friend WithEvents btnhapus2 As System.Windows.Forms.Button
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents tabelpinjaman As System.Windows.Forms.DataGridView
    Friend WithEvents txtangsuran As System.Windows.Forms.TextBox
    Friend WithEvents txttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblbunga As System.Windows.Forms.Label
    Friend WithEvents txtkodeuser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents txtpokok As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttanggaltempo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabelpinjaman2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkodekonfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
