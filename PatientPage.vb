Public Class PatientPage

    Dim TableView As String

    Private selectedPatientID As String
    Private Sub PatientPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = LoggedInUser
        DTGList.Rows.Clear()
        Connect()
        Try
            query = "SELECT * FROM `patient_info` where " & TableView
            With command
                .Connection = connection
                .CommandText = query
                .Parameters.Clear()
                reader = .ExecuteReader
                While reader.Read
                    DTGList.Rows.Add(
                                            reader.GetString("patientID"),
                                            reader.GetString("lastname"),
                                            reader.GetString("firstname") + " " + reader.GetString("extname"),
                                            reader.GetString("ward"),
                                            reader.GetString("physician"),
                                            reader.GetString("Dev_ID")
                    )
                End While
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles AddPatientBtn.Click
        RegisterPatient.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles ReloadBtn.Click
        DTGList.Rows.Clear()
        Connect()
        Try
            query = "SELECT * FROM `patient_info`"
            With command
                .Connection = connection
                .CommandText = query
                .Parameters.Clear()
                reader = .ExecuteReader
                While reader.Read
                    DTGList.Rows.Add(
                                            reader.GetString("patientID"),
                                            reader.GetString("lastname"),
                                            reader.GetString("firstname") + " " + reader.GetString("extname"),
                                            reader.GetString("ward"),
                                            reader.GetString("physician"),
                                            reader.GetString("Dev_ID")
                    )
                End While
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpdatePatientButton_Click(sender As Object, e As EventArgs) Handles UpdatePatientButton.Click
        ' Check if a row is selected in the DataGridView
        If DTGList.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DTGList.SelectedRows(0)

            ' Retrieve the patient's unique identifier (e.g., patientID) from the selected row
            Dim patientID As String = selectedRow.Cells("PatientID").Value.ToString()

            ' Open the UpdateAndDismissPatient form
            Dim updateForm As New UpdateAndDismissPatient()
            ' Pass the patientID to the UpdateAndDismissPatient form
            updateForm.LoadPatientData(patientID)
            updateForm.Show()
        Else
            MessageBox.Show("Please select a patient from the list before clicking Update.")
        End If
    End Sub

    Private Sub DTGList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGList.CellContentClick
        ' Check if a row is clicked (ignore header clicks and other clicks)
        If e.RowIndex >= 0 Then
            ' Get the patient's unique identifier (e.g., patientID) from the selected row
            Dim selectedRow As DataGridViewRow = DTGList.Rows(e.RowIndex)
            ChartGen = selectedRow.Cells("Lastname").Value.ToString().ToLower + selectedRow.Cells("PatientID").Value.ToString()

            ' Create an instance of the LiveChart form
            Dim liveChartForm As New LiveChart()

            ' Pass the patientID to the LiveChart form (if needed)

            ' Show the LiveChart form
            liveChartForm.Show()
        End If
    End Sub
End Class