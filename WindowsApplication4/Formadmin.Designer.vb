<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formadmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formadmin))
        Me.btnnasabah = New System.Windows.Forms.Button()
        Me.btnangsuran = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnasabah
        '
        Me.btnnasabah.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnnasabah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnasabah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnasabah.Location = New System.Drawing.Point(26, 265)
        Me.btnnasabah.Name = "btnnasabah"
        Me.btnnasabah.Size = New System.Drawing.Size(166, 59)
        Me.btnnasabah.TabIndex = 0
        Me.btnnasabah.Text = "&Konfirmasi Pinjaman"
        Me.btnnasabah.UseVisualStyleBackColor = False
        '
        'btnangsuran
        '
        Me.btnangsuran.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnangsuran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnangsuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnangsuran.Location = New System.Drawing.Point(224, 265)
        Me.btnangsuran.Name = "btnangsuran"
        Me.btnangsuran.Size = New System.Drawing.Size(166, 59)
        Me.btnangsuran.TabIndex = 0
        Me.btnangsuran.Text = "&Input Angsuran"
        Me.btnangsuran.UseVisualStyleBackColor = False
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnkembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembali.Location = New System.Drawing.Point(120, 330)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(166, 59)
        Me.btnkembali.TabIndex = 1
        Me.btnkembali.Text = "&Kembali"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(101, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Formadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(415, 409)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnangsuran)
        Me.Controls.Add(Me.btnnasabah)
        Me.Name = "Formadmin"
        Me.Text = "From Edit Nasabah"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnnasabah As System.Windows.Forms.Button
    Friend WithEvents btnangsuran As System.Windows.Forms.Button
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
