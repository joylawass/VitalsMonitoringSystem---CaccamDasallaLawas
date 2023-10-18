Public Class SignUpForm
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        txtbxUsername.Clear()
        txtbxPassword.Clear()
        txtbxConfirmPass.Clear()
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit?", "Log Out Prompt",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtbxUsername.Clear()
        txtbxPassword.Clear()
        txtbxConfirmPass.Clear()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If String.IsNullOrEmpty(txtbxUsername.Text) Or String.IsNullOrEmpty(txtbxPassword.Text) Then
            MessageBox.Show("Username or Password cannot be empty!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If txtbxPassword.Text.Equals(txtbxConfirmPass.Text) Then
                CreateAdmin(txtbxUsername.Text.Trim, txtbxConfirmPass.Text.Trim)
            Else
                MessageBox.Show("Password do not match.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtbxUsername_GotFocus(sender As Object, e As EventArgs) Handles txtbxUsername.GotFocus
        If txtbxUsername.PlaceholderText = "Username" Then
            txtbxUsername.PlaceholderText = ""
            txtbxUsername.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtbxPassword_GotFocus(sender As Object, e As EventArgs) Handles txtbxPassword.GotFocus
        If txtbxPassword.PlaceholderText = "Password" Then
            txtbxPassword.PlaceholderText = ""
            txtbxPassword.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtbxConfirmPass_GotFocus(sender As Object, e As EventArgs) Handles txtbxConfirmPass.GotFocus
        If txtbxConfirmPass.PlaceholderText = "Confirm Password" Then
            txtbxConfirmPass.PlaceholderText = ""
            txtbxConfirmPass.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtbxUsername_LostFocus(sender As Object, e As EventArgs) Handles txtbxUsername.LostFocus
        If txtbxUsername.PlaceholderText = "" Then
            txtbxUsername.PlaceholderText = "Username"
            txtbxUsername.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtbxPassword_LostFocus(sender As Object, e As EventArgs) Handles txtbxPassword.LostFocus
        If txtbxPassword.PlaceholderText = "" Then
            txtbxPassword.PlaceholderText = "Password"
            txtbxPassword.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtbxConfirmPass_LostFocus(sender As Object, e As EventArgs) Handles txtbxConfirmPass.LostFocus
        If txtbxConfirmPass.PlaceholderText = "" Then
            txtbxConfirmPass.PlaceholderText = "Confirm Password"
            txtbxConfirmPass.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        If showPassword.Checked = True Then
            txtbxPassword.UseSystemPasswordChar = False
        Else
            txtbxPassword.UseSystemPasswordChar = True
        End If

        If showPassword.Checked = True Then
            txtbxConfirmPass.UseSystemPasswordChar = False
        Else
            txtbxConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtbxPassword_TextChanged(sender As Object, e As EventArgs) Handles txtbxPassword.TextChanged
        txtbxPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub txtbxConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtbxConfirmPass.TextChanged
        txtbxConfirmPass.UseSystemPasswordChar = True

        If txtbxPassword.Text = txtbxConfirmPass.Text Then
            lblPasswordsDoNotMatch.Visible = False
        Else
            lblPasswordsDoNotMatch.Visible = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnBackToLogIn.Click
        txtbxUsername.Clear()
        txtbxPassword.Clear()
        txtbxConfirmPass.Clear()
        Me.Close()
        LoginForm.Show()
    End Sub
End Class