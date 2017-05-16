Imports System.IO

Public Class index
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        administradorLogin.ShowDialog()
    End Sub

    Private Sub btnInstrucciones_Click(sender As Object, e As EventArgs) Handles btnInstrucciones.Click
        Dim file As New StreamReader("intrucciones.txt")

        MsgBox(file.ReadToEnd())
        file.Close()
    End Sub

    Private Sub btnRanking_Click(sender As Object, e As EventArgs) Handles btnRanking.Click
        Dim file As New StreamReader("ranking.txt")

        MsgBox(file.ReadToEnd())
        file.Close()
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        Dim login As New Login
        login.ShowDialog()

    End Sub
End Class
