Public Class Articulo : Implements IEquatable(Of Articulo)

    Public Property Nombre As String
    Public Property Stock As Integer

    Public Sub New(ByVal nombre As String, ByVal stock As Integer)
        Me.Nombre = nombre

        Me.Stock = stock
    End Sub



    Public Overloads Function Equals(other As Articulo) As Boolean Implements IEquatable(Of Articulo).Equals
        Return Not IsNothing(other) AndAlso Me.Nombre.ToLower = other.Nombre.ToLower
    End Function
End Class