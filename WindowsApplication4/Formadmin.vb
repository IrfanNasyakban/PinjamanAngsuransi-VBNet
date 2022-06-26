Public Class Formadmin

    Private Sub btnnasabah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnasabah.Click
        Me.Hide()
        Formkonfirmasi.Show()
    End Sub


    Private Sub btnpinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Formkonfirmasi.ShowDialog()
    End Sub

    Private Sub btnangsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnangsuran.Click
        Me.Hide()
        Formangsuranadmin.ShowDialog()
    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        Me.Hide()
        Formutama.Show()
    End Sub

    Private Sub Formadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class