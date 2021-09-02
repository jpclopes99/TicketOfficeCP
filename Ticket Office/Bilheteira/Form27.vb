Public Class Form27
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form18.Show()
        Me.Hide()
    End Sub

    Private Sub Lbdata_Click(sender As Object, e As EventArgs) Handles Lbdata.Click

    End Sub

    Private Sub Form27_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label4.Text = TimeString

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class