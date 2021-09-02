Public Class Form10
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeString
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label2.Text = TimeString
        TextBox4.Text = "1"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text -= 1
        If TextBox4.Text < 1 Then
            TextBox4.Text = 1
        End If
        If TextBox1.Text = "Campolide" Then
            TextBox5.Text = FormatNumber(1.3 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Benfica" Then
            TextBox5.Text = FormatNumber(1.3 * TextBox4.Text + 0.5, 2) & "€"
        End If

        If TextBox1.Text = "Santa Cruz - Damaia" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Reboleira" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Amadora" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Queluz - Bela" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Monte Abraão" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Massamá - Barcarena" Then
            TextBox5.Text = FormatNumber(1.9 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Cacém" Then
            TextBox5.Text = FormatNumber(1.9 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Meleças" Then
            TextBox5.Text = FormatNumber(1.9 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Rio de Mouro" Then
            TextBox5.Text = FormatNumber(1.9 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Mercês" Then
            TextBox5.Text = FormatNumber(2.2 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Algueirão - MMartins" Then
            TextBox5.Text = FormatNumber(2.2 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Portela de Sintra" Then
            TextBox5.Text = FormatNumber(2.2 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Sintra" Then
            TextBox5.Text = FormatNumber(2.2 * TextBox4.Text + 0.5, 2) & "€"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text += 1
        If TextBox1.Text = "Campolide" Then
            TextBox5.Text = FormatNumber(1.3 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Benfica" Then
            TextBox5.Text = FormatNumber(1.3 * TextBox4.Text + 0.5, 2) & "€"
        End If

        If TextBox1.Text = "Santa Cruz - Damaia" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Reboleira" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Amadora" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Queluz - Bela" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Monte Abraão" Then
            TextBox5.Text = FormatNumber(1.6 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Massamá - Barcarena" Then
            TextBox5.Text = FormatNumber(1.9 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Cacém" Then
            TextBox5.Text = FormatNumber(1.9 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Meleças" Then
            TextBox5.Text = FormatNumber(1.9 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Rio de Mouro" Then
            TextBox5.Text = FormatNumber(1.9 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Mercês" Then
            TextBox5.Text = FormatNumber(2.2 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Algueirão - MMartins" Then
            TextBox5.Text = FormatNumber(2.2 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Portela de Sintra" Then
            TextBox5.Text = FormatNumber(2.2 * TextBox4.Text + 0.5, 2) & "€"
        End If
        If TextBox1.Text = "Sintra" Then
            TextBox5.Text = FormatNumber(2.2 * TextBox4.Text + 0.5, 2) & "€"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form24.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form56.Label7.Text = TextBox5.Text
        Form56.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Lbdata_Click(sender As Object, e As EventArgs) Handles Lbdata.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class