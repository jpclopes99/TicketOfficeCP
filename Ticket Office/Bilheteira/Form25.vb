﻿Public Class Form25
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = TimeString
    End Sub

    Private Sub Lbdata_Click(sender As Object, e As EventArgs) Handles Lbdata.Click
        Lbdata.Text = Date.Today
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbdata.Text = Date.Today
        Label4.Text = TimeString

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class