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
End Class