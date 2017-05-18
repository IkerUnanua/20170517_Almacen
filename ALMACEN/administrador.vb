Imports System.IO

Public Class Administrador
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim fichero As New StreamWriter("articulos.txt")
        Dim articulos(9) As String
        For i = 0 To 9

            Do
                articulos(i) = InputBox("Que articulo desea introducir")
                If articulos(i) = "" Then
                    MsgBox("Lo sentimos pero debe introducir un valor")

                End If
            Loop While articulos(i) = ""
        Next

        For i = 0 To articulos.Length - 1
            fichero.WriteLine("Articulo:" + articulos(i))
        Next
    End Sub

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Spinning_Seal___GifSound, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Administrador_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Computer.Audio.Stop()
    End Sub
End Class