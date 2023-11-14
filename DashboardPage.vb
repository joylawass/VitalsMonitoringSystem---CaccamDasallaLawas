Public Class DashboardPage
    Private Sub DashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountDevices()
        CountPatients()
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

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    NotifyIcon1.ShowBalloonTip(1000, "Device Status", "[Patient] at ward [ward] attempted to remove the device, possible attempted breach.", ToolTipIcon.Warning)
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    NotifyIcon1.ShowBalloonTip(1000, "RFID Status", "[Patient] went through RFID Sensor, possible attempted breach.", ToolTipIcon.Warning)
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    NotifyIcon1.ShowBalloonTip(1000, "Low Battery", "The device assigned to [patient] at ward [ward] is running low on power; needs charging.", ToolTipIcon.Warning)
    'End Sub
End Class