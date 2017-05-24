Imports System.IO

Public Class Administrador
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Dim fichero As New StreamWriter("ficheros/articulos.txt")
        Dim articulos(9) As String
        For i = 0 To 9

            articulos(i) = InputBox("Que articulo desea introducir")
                If String.IsNullOrWhiteSpace(articulos(i)) = "" Then
                Exit Sub
            End If

    Next

        For i = 0 To articulos.Length - 1
            fichero.WriteLine("Articulo:" + articulos(i))
        Next
        fichero.Close()

    End Sub

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Spinning_Seal___GifSound, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Administrador_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim file As New StreamReader("ficheros/infoAdmin.txt")

        MsgBox(file.ReadToEnd())
        file.Close()
    End Sub

    Private Sub btnEnunciados_Click(sender As Object, e As EventArgs) Handles btnEnunciados.Click
        Dim file As New StreamWriter("ficheros/enunciados.txt")
        Dim cont As Integer = 0
        Dim enunciado As String
        Do
            cont = cont + 1
            enunciado = InputBox("Por favor introduzca el " + cont.ToString + "º enunciado")
            If enunciado = "" Then
                MsgBox("Se ha terminado de introducir usuarios")
            Else
                file.WriteLine("Enunciado:" + enunciado)
            End If
        Loop Until enunciado = ""
        file.Close()
    End Sub

    Private Sub btnContraseñas_Click(sender As Object, e As EventArgs) Handles btnContraseñas.Click
        Dim file As New StreamReader("ficheros/usuarios.txt")

        MsgBox(file.ReadToEnd())
        file.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class