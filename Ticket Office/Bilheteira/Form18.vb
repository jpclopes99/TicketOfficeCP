Public Class Form18
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Form27.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Campolide"
        Form19.TextBox5.Text = "0.35" & "€"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Benfica"
        Form19.TextBox5.Text = "0.35" & "€"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Santa Cruz - Damaia"
        Form19.TextBox5.Text = "0.40" & "€"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Reboleira"
        Form19.TextBox5.Text = "0.40" & "€"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Amadora"
        Form19.TextBox5.Text = "0.40" & "€"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Queluz - Bela"
        Form19.TextBox5.Text = "0.40" & "€"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Monte Abraão"
        Form19.TextBox5.Text = "0.40" & "€"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Massamá Barcarena"
        Form19.TextBox5.Text = "0.50" & "€"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Cacém"
        Form19.TextBox5.Text = "0.50" & "€"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Meleças"
        Form19.TextBox5.Text = "0.50" & "€"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Rio de Mouro"
        Form19.TextBox5.Text = "0.50" & "€"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Mercês"
        Form19.TextBox5.Text = "0.55" & "€"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Algueirão - MMartins"
        Form19.TextBox5.Text = "0.55" & "€"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Portela de Sintra"
        Form19.TextBox5.Text = "0.55" & "€"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        Form19.Show()
        Form19.TextBox2.Text = "Bilhete_Quarto"
        Form19.TextBox3.Text = "Lisboa Rossio"
        Form19.TextBox1.Text = "Sintra"
        Form19.TextBox5.Text = "0.55" & "€"
    End Sub

    Private Sub Lbdata_Click(sender As Object, e As EventArgs) Handles Lbdata.Click
        Lbdata.Text = Date.Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeString
    End Sub

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label2.Text = TimeString

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class