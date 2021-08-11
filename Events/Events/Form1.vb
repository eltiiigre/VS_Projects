Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress, txtID.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Error!")
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
            MsgBox("Error!")
        End If
    End Sub


    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or txtAge.Text.Length > 2 Then
            e.Handled = True
            MsgBox("Error!")
        End If
    End Sub



    Private Sub txtID_MouseEnter(sender As Object, e As EventArgs) Handles txtID.MouseEnter
        txtID.BackColor = Color.Cyan
        txtID.ForeColor = Color.Crimson
    End Sub

    Private Sub txtID_MouseLeave(sender As Object, e As EventArgs) Handles txtID.MouseLeave
        txtID.BackColor = Color.White
    End Sub

    Private Sub txtName_MouseEnter(sender As Object, e As EventArgs) Handles txtName.MouseEnter
        txtName.BackColor = Color.Cyan
        txtName.ForeColor = Color.Crimson
    End Sub

    Private Sub txtName_MouseLeave(sender As Object, e As EventArgs) Handles txtName.MouseLeave
        txtName.BackColor = Color.White
    End Sub

    Private Sub txtAge_MouseEnter(sender As Object, e As EventArgs) Handles txtAge.MouseEnter
        txtAge.BackColor = Color.Cyan
        txtAge.ForeColor = Color.Crimson
    End Sub

    Private Sub txtAge_MouseLeave(sender As Object, e As EventArgs) Handles txtAge.MouseLeave
        txtAge.BackColor = Color.White
    End Sub


    Private Sub txtAge_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAge.KeyUp
        If Integer.Parse(txtAge.Text) > 122 Then
            MsgBox("Errorrr")
        End If
    End Sub
End Class
