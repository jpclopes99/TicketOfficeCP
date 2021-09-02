Public Class Form8
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeString
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label2.Text = TimeString

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form31.Show()
        Form31.TextBox2.Text = "Zapping"
        Form31.TextBox5.Text = "3.50" & "€"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form31.Show()
        Form31.TextBox2.Text = "Zapping"
        Form31.TextBox5.Text = "5.50" & "€"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form31.Show()
        Form31.TextBox2.Text = "Zapping"
        Form31.TextBox5.Text = "10.50" & "€"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form31.Show()
        Form31.TextBox2.Text = "Zapping"
        Form31.TextBox5.Text = "15.50" & "€"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form31.Show()
        Form31.TextBox2.Text = "Zapping"
        Form31.TextBox5.Text = "20.50" & "€"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form31.Show()
        Form31.TextBox2.Text = "Zapping"
        Form31.TextBox5.Text = "25.50" & "€"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Form31.Show()
        Form31.TextBox2.Text = "Zapping"
        Form31.TextBox5.Text = "30.50" & "€"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Form31.Show()
        Form31.TextBox2.Text = "Zapping"
        Form31.TextBox5.Text = "35.50" & "€"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Form31.Show()
        Form31.TextBox2.Text = "Zapping"
        Form31.TextBox5.Text = "40.50" & "€"
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Form33.Show()
        Me.Hide()
    End Sub

    Private Sub Lbdata_Click(sender As Object, e As EventArgs) Handles Lbdata.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class