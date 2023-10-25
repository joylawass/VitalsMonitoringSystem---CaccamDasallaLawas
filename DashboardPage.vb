Public Class DashboardPage
    Private Sub DashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountDevices()
        lblUsername.Text = LoggedInUser + "!"
        lblUsername1.Text = LoggedInUser
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Connect()
        query = "SELECT * from patient_info WHERE Status = 'Active'"
        Try
            With command
                .Connection = connection
                .CommandText = query
                .Parameters.Clear()
                reader = .ExecuteReader
                While reader.Read()

                End While
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NotifyIcon1.ShowBalloonTip(1000, "Device Status", "The device was removed from the patient.", ToolTipIcon.None)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NotifyIcon1.ShowBalloonTip(1000, "RFID Status", "The patient escaped from the area.", ToolTipIcon.None)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NotifyIcon1.ShowBalloonTip(1000, "Low Battery", "The battery is getting low. 20% remaining.", ToolTipIcon.None)
    End Sub
End Class