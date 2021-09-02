Public Class Form48
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeString
    End Sub

    Private Sub Lbdata_Click(sender As Object, e As EventArgs) Handles Lbdata.Click
        Lbdata.Text = Date.Today
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form14.Show()
        Me.Hide()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form49.Show()
        Form49.TextBox2.Text = "Bilhete_Multiviagem_Zona1"
        Form49.TextBox5.Text = "11.70" & "€"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form49.Show()
        Form49.TextBox2.Text = "Bilhete_Multiviagem_Zona2"
        Form49.TextBox5.Text = "14.40" & "€"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form49.Show()
        Form49.TextBox2.Text = "Bilhete_Multiviagem_Zona3"
        Form49.TextBox5.Text = "17.10" & "€"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form49.Show()
        Form49.TextBox2.Text = "Bilhete_Multiviagem_Zona4"
        Form49.TextBox5.Text = "19.80" & "€"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Form52.Show()
        Me.Hide()
    End Sub
    Private Sub Form48_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label2.Text = TimeString

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class