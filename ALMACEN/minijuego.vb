Public Class minijuego
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPapel.Click, btnPiedras.Click, btnTijeras.Click
        Dim boton As Button = TryCast(sender, Button)
        Dim array As String() = {"Papel", "Tijera", "Piedra"}
        Dim random As New Random
        Dim numAux As Integer = random.Next(1, 4)

        If boton.Name = btnPapel.Name Then
            If array(numAux - 1) = "Papel" Then
                MsgBox("Empate, los dos habeis elegido Papel")
            ElseIf array(numAux - 1) = "Piedra" Then
                MsgBox("Has ganado, el otro ha elegido Piedra")
            ElseIf array(numAux - 1) = "Tijera" Then
                MsgBox("Has perdido, el otro ha elegido Tijera")
            End If
        End If

        If boton.Name = btnTijeras.Name Then
            If array(numAux - 1) = "Tijera" Then
                MsgBox("Empate, los dos habeis elegido Tijera")
            ElseIf array(numAux - 1) = "Papel" Then
                MsgBox("Has ganado, el otro ha elegido Papel")
            ElseIf array(numAux - 1) = "Piedra" Then
                MsgBox("Has perdido, el otro ha elegido Piedra")
            End If
        End If

        If boton.Name = btnPiedras.Name Then
            If array(numAux - 1) = "Piedra" Then
                MsgBox("Empate, los dos habeis elegido Piedra")
            ElseIf array(numAux - 1) = "Tijera" Then
                MsgBox("Has ganado, el otro ha elegido Tijera")
            ElseIf array(numAux - 1) = "Papel" Then
                MsgBox("Has perdido, el otro ha elegido Papel")
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub minijuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTijeras.Visible = False
        btnPiedras.Visible = False
        btnPapel.Visible = False
        Label1.Visible = False
        pbx1.Visible = False
        pbx2.Visible = False
        pbx3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        btnEmpezar.Visible = False
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static sec As Integer
        sec = sec + 1
        If sec = 4 Then
            pbx3.Visible = True
        End If
        If sec = 8 Then
            pbx2.Visible = True
            pbx3.Visible = False
        End If
        If sec = 12 Then

            pbx2.Visible = False
            pbx1.Visible = True
        End If
        If sec = 16 Then
            Label1.Visible = True
            btnTijeras.Visible = True
            btnPiedras.Visible = True
            btnPapel.Visible = True
            pbx1.Visible = False
        End If
    End Sub
End Class