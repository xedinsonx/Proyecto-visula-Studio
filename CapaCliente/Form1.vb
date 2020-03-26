Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New Capalogica.ado_operaciones
        Dim vector() As Integer = obj.mostrar(CInt(txtvalor.text), CInt(txtrazon.text), CInt(txtnro.text))
        'visualizar elemento en la lista
        For i As Integer = 0 To vector.Length - 1
            lista.Items.Add(vector(i))
        Next
        'Mostrar la suma
        lblsuma.Text = obj.promedio(vector)
    End Sub
End Class
