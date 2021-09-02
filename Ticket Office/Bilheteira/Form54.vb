Public Class Form54
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form53.Show()
        Me.Hide()
    End Sub

    Private Sub Lbdata_Click(sender As Object, e As EventArgs) Handles Lbdata.Click
        Lbdata.Text = Date.Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeString
    End Sub

    Private Sub Form54_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label2.Text = TimeString

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class