Public Class ado_operaciones
    Public Function promedio(valor() As Integer) As Single
        Dim s As Integer
        For i As Integer = 0 To valor.Length - 1
            s = s + valor(i)
        Next
        Return s / valor.Length
    End Function
    Public Function mostrar(valorincial As Integer, razon As Integer, nroterminado As Integer) As Integer()
        Dim obj As New Capadatos.Origen
        Dim vector() As Integer = obj.generaserie(valorincial, razon, nroterminado)
        Return  vector
    End Function
End Class
