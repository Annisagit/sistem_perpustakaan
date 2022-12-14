Public Class singup
    Private Sub ButtonSingUp_Click(sender As Object, e As EventArgs) Handles ButtonSingUp.Click
        If TxtUsername.Text.Length > 0 And TxtPassword.Text.Length > 0 Then
            Login.users.AddUsersDatabase(TxtUsername.Text, TxtPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub
End Class