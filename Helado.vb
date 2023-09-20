Public Class Helado
    Public Property Sabor As String
    Public Property Cantidas As Integer
    Public Property NumOrdenes As Integer

    Public Sub New()

    End Sub

    Public Sub New(sabor As String, cantidas As Integer, numOrdenes As Integer)
        Me.Sabor = sabor
        Me.Cantidas = cantidas
        Me.NumOrdenes = numOrdenes
    End Sub
End Class
