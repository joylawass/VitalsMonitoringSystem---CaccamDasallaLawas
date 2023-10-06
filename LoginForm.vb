Public Class LoginForm
    Private Sub linkLabelCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabelCreateAccount.LinkClicked
        txtbxUsername.Clear()
        txtbxPassword.Clear()
        SignUpForm.Show()
        Me.Hide()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit?", "Log Out Prompt",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LogInQuery(txtbxUsername.Text, txtbxPassword.Text)
        MainForm.ActivateButton(MainForm.DashboardButton, Color.White)
        MainForm.switchPanel(DashboardPage)
        'Dim loginSuccessful As Boolean = True ' You should replace this with your actual login logic

        'If loginSuccessful Then

        '    ' Call the ActivateButton method for the Dashboard button
        '    MainForm.ActivateButton(MainForm.DashboardButton, Color.White)

        '    ' Switch to the MainForm
        '    MainForm.switchPanel(DashboardPage)

        '    ' Close the LoginForm
        '    Me.Hide()
        'Else
        '    LogInQuery(txtbxUsername.Text, txtbxPassword.Text)
        'End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnLogin
        txtbxUsername.SelectionStart = 0
        txtbxUsername.SelectionLength = 0
        txtbxUsername.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtbxUsername.Clear()
        txtbxPassword.Clear()
    End Sub

    Private Sub txtbxUsername_GotFocus(sender As Object, e As EventArgs) Handles txtbxUsername.GotFocus
        If txtbxUsername.PlaceholderText = "Username" Then
            txtbxUsername.PlaceholderText = ""
            txtbxUsername.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtbxUsername_LostFocus(sender As Object, e As EventArgs) Handles txtbxUsername.LostFocus
        If txtbxUsername.PlaceholderText = "" Then
            txtbxUsername.PlaceholderText = "Username"
            txtbxUsername.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtbxPassword_GotFocus(sender As Object, e As EventArgs) Handles txtbxPassword.GotFocus
        If txtbxPassword.PlaceholderText = "Password" Then
            txtbxPassword.PlaceholderText = ""
            txtbxPassword.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtbxPassword_LostFocus(sender As Object, e As EventArgs) Handles txtbxPassword.LostFocus
        If txtbxPassword.PlaceholderText = "" Then
            txtbxPassword.PlaceholderText = "Password"
            txtbxPassword.PlaceholderForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtbxPassword_TextChanged(sender As Object, e As EventArgs) Handles txtbxPassword.TextChanged
        txtbxPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        If showPassword.Checked = True Then
            txtbxPassword.UseSystemPasswordChar = False
        Else
            txtbxPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class