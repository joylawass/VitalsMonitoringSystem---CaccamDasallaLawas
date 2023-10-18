Public Class DashboardPage
    Private Sub DashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountDevices()
        lblUsername.Text = LoggedInUser + "!"
        lblUsername1.Text = LoggedInUser
    End Sub

    Private Sub lbBatt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub liveNotifPanel_Paint(sender As Object, e As PaintEventArgs) Handles liveNotifPanel.Paint

    End Sub
End Class