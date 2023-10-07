Public Class DashboardPage
    Private Sub DashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountDevices()
        lblUsername.Text = LoggedInUser + "!"
        lblUsername1.Text = LoggedInUser
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class