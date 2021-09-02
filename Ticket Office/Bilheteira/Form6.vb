Public Class Form6
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeString
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Campolide"
        Form10.TextBox5.Text = "1.80" & "€"


    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label2.Text = TimeString

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Benfica"
        Form10.TextBox5.Text = "1.80" & "€"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Santa Cruz - Damaia"
        Form10.TextBox5.Text = "2.10" & "€"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Reboleira"
        Form10.TextBox5.Text = "2.10" & "€"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Amadora"
        Form10.TextBox5.Text = "2.10" & "€"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Queluz - Bela"
        Form10.TextBox5.Text = "2.10" & "€"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Monte Abraão"
        Form10.TextBox5.Text = "2.10" & "€"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Massamá Barcarena"
        Form10.TextBox5.Text = "2.40" & "€"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Cacém"
        Form10.TextBox5.Text = "2.40" & "€"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Meleças"
        Form10.TextBox5.Text = "2.40" & "€"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Rio de Mouro"
        Form10.TextBox5.Text = "2.40" & "€"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Mercês"
        Form10.TextBox5.Text = "2.70" & "€"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Algueirão - MMartins"
        Form10.TextBox5.Text = "2.70" & "€"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Portela de Sintra"
        Form10.TextBox5.Text = "2.70" & "€"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        Form10.Show()
        Form10.TextBox2.Text = "Bilhete_Inteiro"
        Form10.TextBox3.Text = "Lisboa Rossio"
        Form10.TextBox1.Text = "Sintra"
        Form10.TextBox5.Text = "2.70" & "€"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class