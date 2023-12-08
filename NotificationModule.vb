Imports MySql.Data.MySqlClient
Imports Tulpep.NotificationWindow

Module NotificationModule
    Dim tableName As String

    Sub NotifList(Bpm As String, Hall As String, O2 As String, Temp As String, RFID As String, notes As String)

        ' Create a list to store patients
        Dim patientList As New List(Of Notification)


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
                            .PrevNotif = .Notification
                            If .Notification.Equals(.PrevNotif) Then

                                'insert notification logic here'
                                Connect()
                                query = "SELECT * from " & tableName
                                Try
                                    With command
                                        .Connection = connection
                                        .CommandText = query
                                        .Parameters.Clear()
                                        reader = .ExecuteReader
                                        While reader.Read()
                                            ' Update patient data
                                            With .Parameters
                                                Bpm = reader.GetString("pulse")
                                                Hall = reader.GetString("wearStat")
                                                O2 = reader.GetString("SPO2")
                                                Temp = reader.GetString("temperature")
                                                RFID = reader.GetString("RFID")
                                                notes = reader.GetString("notes")
                                            End With

                                            ' Check conditions for displaying notifications
                                            ' Wala pa nko natry if mugana
                                            If Convert.ToDouble(Bpm) < 60 Or Convert.ToDouble(Bpm) > 100 Then
                                                PopupNotification.lblNotifTitle.Text = "Pulse Rate"
                                                PopupNotification.lblNotifContent.Text = "Notification"
                                            ElseIf Convert.ToBoolean(Hall) = False Then
                                                PopupNotification.lblNotifTitle.Text = "Device Removal Detected"
                                                PopupNotification.lblNotifContent.Text = "Notification"
                                            ElseIf Convert.ToDouble(O2) < 95 Or Convert.ToDouble(O2) > 100 Then
                                                PopupNotification.lblNotifTitle.Text = "Blood Oxygen"
                                                PopupNotification.lblNotifContent.Text = "Notification"
                                            ElseIf Convert.ToDouble(Temp) < 36 Or Convert.ToDouble(Temp) > 37.2 Then
                                                PopupNotification.lblNotifTitle.Text = "Body Temperature"
                                                PopupNotification.lblNotifContent.Text = "Notification"
                                            ElseIf Convert.ToBoolean(RFID) = False Then
                                                PopupNotification.lblNotifTitle.Text = "Breach Attempt Detected"
                                                PopupNotification.lblNotifContent.Text = "Notification"
                                            End If
                                        End While
                                    End With
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                End Try
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
