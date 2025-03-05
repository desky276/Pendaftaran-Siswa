Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Set PictureBox untuk ditampilkan
        PictureBox2.Visible = True
        ' Hentikan timer pertama
        Timer1.Stop()
        ' Mulai timer kedua
        Timer2.Start()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sembunyikan PictureBox saat form dimuat
        PictureBox2.Visible = False
        ' Mulai timer pertama saat form dimuat
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Sembunyikan PictureBox
        PictureBox2.Visible = False
        ' Hentikan timer kedua
        Timer2.Stop()
        ' Mulai timer pertama untuk memulai siklus baru
        Timer1.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class