Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = Integer.Parse(TextBox1.Text)
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim result As Integer
        Dim s As String = "0 "

        For asd = 1 To (num - 1)
            s += b & " "
            result = a + b
            a = b
            b = result
        Next asd
        TextBox2.Text = s

    End Sub
End Class