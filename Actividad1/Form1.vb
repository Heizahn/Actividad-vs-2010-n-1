Public Class Form1
    Dim diametro, radio As Decimal
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        diametro = TextBox1.Text
        radio = diametro / 2

        Label2.Text = ("El radio es: " & radio)
    End Sub
End Class
