Public Class HalLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Hide()
        Me.Visible = False

        btnLogin.Show()


        If txtUser.Text = "admin" And txtPass.Text = "admin" Then
            MessageBox.Show("Login Telah Berhasil", "Konfirmasi",
        MessageBoxButtons.OK, MessageBoxIcon.Information)

            HalManagement.Show()
        Else
            MessageBox.Show("username dan password Yang Anda Masukkan Salah", "Konfirmasi",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        btnLogin.Show()
    End Sub

    Private Sub HalLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.MaxLength = 20
        txtPass.MaxLength = 5
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        ' Hanya memperbolehkan inputan huruf kecil
        If Not Char.IsLetter(e.KeyChar) OrElse Char.IsUpper(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        ' Hanya memperbolehkan inputan huruf kecil
        If Not Char.IsLetter(e.KeyChar) OrElse Char.IsUpper(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub
End Class