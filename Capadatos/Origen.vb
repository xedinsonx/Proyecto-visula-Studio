Public Class Origen
    Public Function generaserie(valorinicial As Integer, razon As Integer, nrotern As Integer) As Integer()
        Dim vector(nrotern - 1) As Integer
        For i As Integer = 1 To nrotern
            vector(i - 1) = valorinicial
            valorinicial = valorinicial + razon
        Next
        Return vector
    End Function
End Class
