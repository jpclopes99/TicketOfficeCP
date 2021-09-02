Public Class Form34
    Private Sub Lbdata_Click(sender As Object, e As EventArgs) Handles Lbdata.Click
        Lbdata.Text = Date.Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeString
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form36.Show()
        Form36.TextBox2.Text = "Bilhete_Multiviagem_Zona1"
        Form36.TextBox5.Text = "12.20" & "€"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form36.Show()
        Form36.TextBox2.Text = "Bilhete_Multiviagem_Zona2"
        Form36.TextBox5.Text = "14.90" & "€"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form36.Show()
        Form36.TextBox2.Text = "Bilhete_Multiviagem_Zona3"
        Form36.TextBox5.Text = "17.60" & "€"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form36.Show()
        Form36.TextBox2.Text = "Bilhete_Multiviagem_Zona4"
        Form36.TextBox5.Text = "20.30" & "€"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Form51.Show()
        Me.Hide()
    End Sub

    Private Sub Form34_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label2.Text = TimeString

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class