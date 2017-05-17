Public Class Administrador
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click

    End Sub

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Spinning_Seal___GifSound, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Administrador_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Computer.Audio.Stop()
    End Sub
End Class