Imports MySql.Data.MySqlClient
Imports Tulpep.NotificationWindow

Module NotificationModule
    Dim tableName As String
    Dim patientList As New List(Of Notification)
    Sub NotifList()


        Connect()
        query = "SELECT pi.patientID, pi.lastname, pi.firstname, pi.middlename, pi.extname, pi.ward, dl.Notification FROM patient_info pi JOIN devicelist dl ON pi.Dev_ID = dl.MAC;"

        Try
            With command
                .Connection = connection
                .CommandText = query
                reader = .ExecuteReader
                While reader.Read
                    Dim patientID As String = reader("patientID").ToString()
                    Dim lastName As String = reader("lastname").ToString()
                    Dim patient As New Notification()
                    ' Check if the item with the matching PatientID and LastName is already in the list
                    If Not patientList.Any(Function(p) p.PatientID = patientID AndAlso p.LastName = lastName) Then
                        ' Item is not in the list, add it
                        With patient
                            .PatientID = patientID
                            .LastName = lastName
                            .FirstName = reader("firstname").ToString()
                            .MiddleName = reader("middlename").ToString()
                            .ExtName = reader("extname").ToString()
                            .Ward = reader("ward").ToString()
                            .PrevNotif = ""
                            .Notification = reader("Notification").ToString()
                            patientList.Add(patient)
                        End With
                    Else

                        With patient
                            .PatientID = patientID
                            .LastName = lastName
                            .FirstName = reader("firstname").ToString()
                            .MiddleName = reader("middlename").ToString()
                            .ExtName = reader("extname").ToString()
                            .Ward = reader("ward").ToString()
                            .PrevNotif = .Notification
                            .Notification = reader("Notification").ToString()
                            If Not .Notification.Equals(.PrevNotif) Then

                                'insert notification logic here'
                                PopupNotification.lblNotifTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
                                PopupNotification.lblNotifContent.Font() = New Font("Segoe UI", 12, FontStyle.Regular)
                                PopupNotification.lblNotifTitle.Text = "Patient " + patientID + ": " + .LastName + ", " + .FirstName
                                PopupNotification.lblNotifContent.Text = .Notification
                                PopupNotification.Show()

                            Else
                                PopupNotification.Hide()
                            End If
                        End With
                    End If
                End While
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Access patient information
        Console.ReadLine()
    End Sub
End Module
