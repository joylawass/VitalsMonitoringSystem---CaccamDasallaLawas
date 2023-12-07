Imports MySql.Data.MySqlClient
Imports Tulpep.NotificationWindow

Module NotificationModule
    Dim tableName As String

    Sub NotifList(Bpm As String, Hall As String, O2 As String, Temp As String, RFID As String)

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
                                            End With

                                            ' Check conditions for displaying notifications
                                            ' Wala pa nko natry if mugana
                                            If Convert.ToDouble(Bpm) < 60 Or Convert.ToDouble(Bpm) > 100 Then
                                                PulseRate()
                                            ElseIf Convert.ToBoolean(Hall) = False Then
                                                HallSensor()
                                            ElseIf Convert.ToDouble(O2) < 95 Or Convert.ToDouble(O2) > 100 Then
                                                SPO2()
                                            ElseIf Convert.ToDouble(Temp) < 36 Or Convert.ToDouble(Temp) > 37.2 Then
                                                Temperature()
                                            ElseIf Convert.ToBoolean(RFID) = False Then
                                                RFIDDevice()
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

    Public Sub PulseRate()
        Dim popup As New PopupNotifier()
        popup.Image = My.Resources.icons8_warning_501
        popup.BodyColor = Color.FromArgb(255, 193, 7)
        popup.TitleText = "Pulse Rate"
        popup.TitleColor = Color.White
        popup.TitleFont = New Font("Segoe UI", 15, FontStyle.Bold)
        popup.ContentText = "Pulse rate is outside the normal range" 'MYSQL Database Notification must reflect on this message, pls pakichange boss katong exact na message gikan sa notification sa db
        popup.ContentColor = Color.White
        popup.ContentFont = New Font("Segoe UI", 12)
        popup.Popup()
    End Sub

    Public Sub HallSensor()
        Dim popup As New PopupNotifier()
        popup.Image = My.Resources.icons8_warning_501
        popup.BodyColor = Color.FromArgb(255, 193, 7)
        popup.TitleText = "Device Removal Detected"
        popup.TitleColor = Color.White
        popup.TitleFont = New Font("Segoe UI", 15, FontStyle.Bold)
        popup.ContentText = "Hall sensor detected device removal" 'MYSQL Database Notification must reflect on this message, pls pakichange boss katong exact na message gikan sa notification sa db
        popup.ContentColor = Color.White
        popup.ContentFont = New Font("Segoe UI", 12)
        popup.Popup()
    End Sub

    Public Sub SPO2()
        Dim popup As New PopupNotifier()
        popup.Image = My.Resources.icons8_warning_501
        popup.BodyColor = Color.FromArgb(255, 193, 7)
        popup.TitleText = "Blood Oxygen"
        popup.TitleColor = Color.White
        popup.TitleFont = New Font("Segoe UI", 15, FontStyle.Bold)
        popup.ContentText = "Blood oxygen level is outside the normal range" 'MYSQL Database Notification must reflect on this message, pls pakichange boss katong exact na message gikan sa notification sa db
        popup.ContentColor = Color.White
        popup.ContentFont = New Font("Segoe UI", 12)
        popup.Popup()
    End Sub

    Public Sub Temperature()
        Dim popup As New PopupNotifier()
        popup.Image = My.Resources.icons8_warning_501
        popup.BodyColor = Color.FromArgb(255, 193, 7)
        popup.TitleText = "Body Temperature"
        popup.TitleColor = Color.White
        popup.TitleFont = New Font("Segoe UI", 15, FontStyle.Bold)
        popup.ContentText = "Body temperature is outside the normal range" 'MYSQL Database Notification must reflect on this message, pls pakichange boss katong exact na message gikan sa notification sa db
        popup.ContentColor = Color.White
        popup.ContentFont = New Font("Segoe UI", 12)
        popup.Popup()
    End Sub

    Public Sub RFIDDevice()
        Dim popup As New PopupNotifier()
        popup.Image = My.Resources.icons8_warning_501
        popup.BodyColor = Color.FromArgb(255, 193, 7)
        popup.TitleText = "Breach Attempt Detected"
        popup.TitleColor = Color.White
        popup.TitleFont = New Font("Segoe UI", 15, FontStyle.Bold)
        popup.ContentText = "RFID sensor detected possible device removal" 'MYSQL Database Notification must reflect on this message, pls pakichange boss katong exact na message gikan sa notification sa db
        popup.ContentColor = Color.White
        popup.ContentFont = New Font("Segoe UI", 12)
        popup.Popup()
    End Sub
End Module
