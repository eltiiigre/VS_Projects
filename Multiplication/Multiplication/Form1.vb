Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = Integer.Parse(TextBox1.Text)
        Dim b As Integer = Integer.Parse(TextBox2.Text)
        Dim c As Integer = 1
        Dim ss As String = a & " x " & c & " = " & a * c & vbCrLf
        Dim print As String
        For asd = 1 To (b - 1)

            c += 1
            ss += a & " x " & c & " = " & a * c & vbCrLf
        Next asd
        MessageBox.Show(ss)
    End Sub
End Class
