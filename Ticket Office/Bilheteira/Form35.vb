Public Class Form35
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form34.Show()
        Me.Hide()
    End Sub

    Private Sub Lbdata_Click(sender As Object, e As EventArgs) Handles Lbdata.Click
        Lbdata.Text = Date.Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeString
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Form35_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label2.Text = TimeString

    End Sub
End Class