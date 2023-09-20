Imports System.ComponentModel

Public Class Encomienda
    Public Property Origen As String
    Public Property Destino As String
    Public Property Peso As Integer
    Public Property Cliente As String

    Public Sub New()

    End Sub
    Public Sub New(origen As String, destino As String, peso As Integer, cliente As String)
        Me.Origen = origen
        Me.Destino = destino
        Me.Peso = peso
        Me.Cliente = cliente
    End Sub

End Class
