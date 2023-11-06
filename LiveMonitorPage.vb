﻿Imports System.Windows.Media.Media3D
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports Org.BouncyCastle.Asn1

Public Class LiveMonitorPage

    Dim temperature As Integer
    Dim pulse As Double
    Dim SPO2 As Integer
    Dim Mac As String
    Dim Battery As Double
    Dim Worn As Boolean
    Dim RFID As Boolean
    Dim tableName As String
    Dim currentDateTime As DateTime = DateTime.Now
    Dim SelectedDevID As String

    Private dismissedPatientIDs As New List(Of String)
    Private selectedPatientID As String = ""

    Public Sub UpdateUsernameText()
        'lblUsername.Text = LoggedInUser
    End Sub

    Private Sub TableUpdate()
        liveMonitoringDTG.Rows.Clear()
        Connect()
        Try
            ' Select patientID, lastname, firstname, middlename, and extname columns from the patient_info table
            query = "SELECT patientID, lastname, firstname, middlename, extname FROM `patient_info`"
            Using command As New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    ' Retrieve patient information
                    Dim patientID As String = reader.GetString("patientID")
                    Dim lastname As String = reader.GetString("lastname")
                    Dim firstname As String = reader.GetString("firstname")
                    Dim middlename As String = reader.GetString("middlename")
                    Dim extname As String = reader.GetString("extname")

                    ' Combine last name, first name, middle name, and ext name into a full name
                    Dim fullName As String = $"{lastname}, {firstname} {extname} {middlename}"

                    ' Add the patient ID and full name to the DataGridView
                    liveMonitoringDTG.Rows.Add(patientID, fullName)
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'For Each row As DataGridViewRow In liveMonitoringDTG.Rows
        '    tableName = row.Cells("Patient ID").Value.ToString() & row.Cells("Number").Value.ToString()
        '    Try
        '        Connect()
        '        query = "SELECT * FROM " & tableName
        '        With command
        '            .Connection = connection
        '            .CommandText = query
        '            .Parameters.Clear()
        '            reader = .ExecuteReader
        '            While reader.Read
        '                temperature = reader.GetString("temperature")
        '                pulse = reader.GetString("pulse")
        '                SPO2 = reader.GetString("SPO2")
        '                Worn = Convert.ToBoolean(reader.GetString("wearStat"))
        '                RFID = Convert.ToBoolean(reader.GetString("RFID")) '
        '                With row
        '                    .Cells("BodyTemp").Value = temperature
        '                    .Cells("PulseRate").Value = pulse
        '                    .Cells("Column4").Value = SPO2
        '                    .Cells("Column2").Value = Worn
        '                    .Cells("Column1").Value = RFID
        '                End With
        '            End While
        '        End With

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        '    Try
        '        Connect()
        '        query = "SELECT * FROM devicelist WHERE MAC='" & row.Cells("DeviceID").Value.ToString & "'"
        '        With command
        '            .Connection = connection
        '            .CommandText = query
        '            reader = .ExecuteReader
        '            While reader.Read
        '                row.Cells("Column3").Value = reader.GetString("Battery")
        '            End While
        '        End With
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'Next
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    TableUpdate()
    '    Dim highlightedRows As New List(Of DataGridViewRow)()

    '    For Each row As DataGridViewRow In liveMonitoringDTG.Rows
    '        With row
    '            If .Cells("BodyTemp").Value > 38 Or
    '       .Cells("PulseRate").Value > 100 Or
    '       .Cells("Column4").Value < 95 Or
    '       .Cells("Column2").Value = False Or
    '       .Cells("Column1").Value = False Then
    '                ' Highlight the row with light salmon color
    '                .DefaultCellStyle.BackColor = Color.LightSalmon
    '                highlightedRows.Add(row)
    '            End If
    '        End With
    '    Next

    '    For Each row As DataGridViewRow In highlightedRows
    '        liveMonitoringDTG.Rows.Remove(row)   ' Remove the highlighted row from its current position
    '    Next

    '    For i As Integer = highlightedRows.Count - 1 To 0 Step -1
    '        liveMonitoringDTG.Rows.Insert(0, highlightedRows(i))   ' Insert the highlighted row at the top
    '    Next
    'End Sub
    Private Sub LiveMonitorPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblUsername.Text = LoggedInUser

        notestxtbox.Multiline = True
        notestxtbox.TextAlign = HorizontalAlignment.Left
        liveMonitoringDTG.Rows.Clear()
        liveMonitoringDTG.Columns(0).Width = 40

        Connect()
        Try
            ' Select patientID, lastname, firstname, middlename, and extname columns from the patient_info table
            query = "SELECT patientID, lastname, firstname, middlename, extname FROM `patient_info` WHERE Status = 'Active'"
            Using command As New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    ' Retrieve patient information
                    Dim patientID As String = reader.GetString("patientID")
                    Dim lastname As String = reader.GetString("lastname")
                    Dim firstname As String = reader.GetString("firstname")
                    Dim middlename As String = reader.GetString("middlename")
                    Dim extname As String = reader.GetString("extname")

                    ' Combine last name, first name, middle name, and ext name into a full name
                    Dim fullName As String = $"{lastname}, {firstname} {extname} {middlename}"

                    ' Add the patient ID and full name to the DataGridView
                    liveMonitoringDTG.Rows.Add(patientID, fullName)
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ReloadBtn_Click(sender As Object, e As EventArgs) Handles ReloadBtn.Click
        ' Clear the DataGridView
        liveMonitoringDTG.Rows.Clear()
        Timer1.Enabled = False
        IconEdit.Enabled = False

        ' Re-fetch and load patient information, excluding dismissed patients
        Connect()
        Try
            ' Select patientID, lastname, firstname, middlename, and extname columns from the patient_info table
            query = "SELECT patientID, lastname, firstname, middlename, extname FROM `patient_info` WHERE Status = 'Active'"
            Using command As New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    ' Retrieve patient information
                    Dim patientID As String = reader.GetString("patientID")
                    Dim lastname As String = reader.GetString("lastname")
                    Dim firstname As String = reader.GetString("firstname")
                    Dim middlename As String = reader.GetString("middlename")
                    Dim extname As String = reader.GetString("extname")

                    ' Combine last name, first name, middle name, and ext name into a full name
                    Dim fullName As String = $"{lastname}, {firstname} {extname} {middlename}"

                    ' Add the patient ID and full name to the DataGridView
                    liveMonitoringDTG.Rows.Add(patientID, fullName)
                End While
            End Using
        Catch ex As Exception
            ' Handle any potential errors silently, without displaying a message
        End Try
        ageLive.Text = ""
        bloodtypeLive.Text = ""
        bmiLive.Text = ""
        heightLive.Text = ""
        historyLive.Text = ""
        notestxtbox.Text = ""
        sexLive.Text = ""
        wardNumberLive.Text = ""
        weightLive.Text = ""
        lbBpm.Text = String.Empty
        lbBpm.Text = "Pulse Rate"
        lbTemp.Text = String.Empty
        lbTemp.Text = "Body Temp"
        lbO2.Text = String.Empty
        lbO2.Text = "Blood O₂"
        lbHall.Text = String.Empty
        lbHall.Text = "Status"
        lbBatt.Text = String.Empty
        lbBatt.Text = "Batt Level"
        lbRFID.Text = String.Empty
        lbRFID.Text = "RFID"
    End Sub

    Private Sub liveMonitoringDTG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles liveMonitoringDTG.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < liveMonitoringDTG.Rows.Count Then
            IconEdit.Enabled = True
            ' Get the patient ID from the selected row
            selectedPatientID = liveMonitoringDTG.Rows(e.RowIndex).Cells("patientID").Value.ToString()

            ' Retrieve patient information from the database using the selectedPatientID
            Dim patientNameChange As String = ""
            Dim sexChange As String = ""
            Dim bloodTypeChange As String = ""
            Dim heightChange As String = ""
            Dim weightChange As String = ""
            Dim bmiChange As String = ""
            Dim wardChange As String = ""
            Dim history As String = ""
            Dim notes As String = ""
            Dim patientBirthdate As Date

            ' Fetch patient information from the database using the selectedPatientID
            Connect()
            query = "SELECT lastname, firstname, middlename, extname, birthdate, sex, blood_type, ward, height, weight, bmi, Dev_ID, health_history FROM patient_info WHERE patientID = @patientID"
            Try
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@patientID", selectedPatientID)
                    reader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve patient information
                        Dim lastname As String = reader.GetString("lastname")
                        Dim firstname As String = reader.GetString("firstname")
                        Dim middlename As String = reader.GetString("middlename")
                        Dim extname As String = reader.GetString("extname")
                        Dim birthdateString As String = reader.GetString("birthdate")

                        patientNameChange = $"{lastname}, {firstname} {extname} {middlename}"
                        sexChange = reader.GetString("sex")
                        bloodTypeChange = reader.GetString("blood_type")
                        heightChange = reader.GetString("height")
                        weightChange = reader.GetString("weight")
                        bmiChange = reader.GetString("bmi")
                        wardChange = reader.GetString("ward")
                        history = reader.GetString("health_history")
                        tableName = reader.GetString("lastname") & selectedPatientID
                        SelectedDevID = reader.GetString("Dev_ID")
                        Timer1.Enabled = True
                        ' Attempt to parse the birthdate string into a Date
                        If Date.TryParse(birthdateString, patientBirthdate) Then
                            ' Calculate the age based on the birthdate
                            Dim age As Integer = CalculateAge(patientBirthdate)

                            ' Update the agelive label with the calculated age
                            ageLive.Text = age.ToString()
                        Else
                            ' Handle the case where the birthdate cannot be parsed
                            ageLive.Text = "Invalid Birthdate"
                        End If
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            ' Update the agelive label with the calculated age
            patientName.Text = patientNameChange
            sexLive.Text = sexChange
            bloodtypeLive.Text = bloodTypeChange
            heightLive.Text = heightChange
            weightLive.Text = weightChange
            bmiLive.Text = bmiChange
            wardNumberLive.Text = wardChange
            historyLive.Text = history
            notestxtbox.Text = notes
        Else
            IconEdit.Enabled = False
        End If
    End Sub '


    Private Function CalculateAge(birthdate As Date) As Integer
        ' Calculate the age based on the birthdate and the current date
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthdate.Year

        ' Adjust the age if the birthday has not occurred yet this year
        If today < birthdate.AddYears(age) Then
            age -= 1
        End If

        Return age
    End Function

    Private Sub DismissBtn_Click(sender As Object, e As EventArgs) Handles DismissBtn.Click
        If liveMonitoringDTG.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = liveMonitoringDTG.SelectedRows(0).Index
            Dim selectedPatientID As String = liveMonitoringDTG.SelectedRows(0).Cells("patientID").Value.ToString()

            ' Display a confirmation prompt
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to dismiss this patient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Remove the selected row from the DataGridView
                liveMonitoringDTG.Rows.RemoveAt(selectedRowIndex)

                ' Update the status in the database (similar to your existing code)
                Connect()
                query = "UPDATE patient_info SET Status = 'Inactive' WHERE patientID = @patientID;"
                Try
                    With command
                        .Connection = connection
                        .CommandText = query
                        With .Parameters
                            .Clear()
                            .Add("@patientID", MySqlDbType.VarChar).Value = selectedPatientID
                        End With
                        .ExecuteNonQuery()
                        AdminLogs("Updated patient Status with id = " + selectedPatientID + " using credential : " & LoggedInUser)
                        MessageBox.Show("Patient dismissed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Please select a patient from the list before dismissing.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub IconEdit_Click(sender As Object, e As EventArgs) Handles IconEdit.Click
        ' Show the Notes form with the selected patient's ID passed as an argument
        Dim notesForm As New Notes(tableName)
        notesForm.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Connect()
        query = "select * from " & tableName
        Try
            With command
                .Connection = connection
                .CommandText = query
                .Parameters.Clear()
                reader = .ExecuteReader
                While reader.Read()

                    'Pulse
                    lbBpm.Text = reader.GetString("pulse")
                    If Convert.ToDouble(lbBpm.Text) < 59 Or Convert.ToDouble(lbBpm.Text) > 101 Then
                        lbBpm.ForeColor = Color.Red
                    Else
                        lbBpm.ForeColor = Color.FromArgb(94, 148, 255)
                    End If

                    'Hall Sensor
                    lbHall.Text = Convert.ToBoolean(reader.GetString("wearStat"))
                    If Convert.ToBoolean(lbHall.Text) = False Then
                        lbBpm.ForeColor = Color.Red
                    Else
                        lbBpm.ForeColor = Color.FromArgb(94, 148, 255)
                    End If

                    'SPO2
                    lbO2.Text = reader.GetString("SPO2")
                    If Convert.ToDouble(lbO2.Text) < 94 Or Convert.ToDouble(lbO2.Text) > 101 Then
                        lbBpm.ForeColor = Color.Red
                    Else
                        lbBpm.ForeColor = Color.FromArgb(94, 148, 255)
                    End If

                    'Temperature
                    lbTemp.Text = reader.GetString("temperature")
                    If Convert.ToDouble(lbTemp.Text) < 36 Or Convert.ToDouble(lbTemp.Text) > 37.3 Then
                        lbBpm.ForeColor = Color.Red
                    Else
                        lbBpm.ForeColor = Color.FromArgb(94, 148, 255)
                    End If

                    notestxtbox.Text = reader.GetString("notes")

                    'RFID
                    lbRFID.Text = Convert.ToBoolean(reader.GetString("RFID"))
                    If Convert.ToBoolean(lbHall.Text) = False Then
                        lbBpm.ForeColor = Color.Red
                    Else
                        lbBpm.ForeColor = Color.FromArgb(94, 148, 255)
                    End If

                End While

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbTemp_Click(sender As Object, e As EventArgs) Handles lbTemp.Click

        Dim query As String = "SELECT temperature FROM patient_info WHERE patientID = @patientID"

        Dim cmd As New MySqlCommand(query, connection)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                ' Get real-time value from the database
                Dim temperature As Double = Double.Parse(reader("real_time_value").ToString())

                If temperature < 36.0 Then
                    lbTemp.ForeColor = Color.Blue ' Change text color to blue for low temperature
                ElseIf temperature >= 36.1 AndAlso temperature < 37.2 Then
                    lbTemp.ForeColor = Color.Black ' Change text color to black for normal temperature
                Else
                    lbTemp.ForeColor = Color.Red ' Change text color to red for high temperature
                End If

            End While
        Else
            Console.WriteLine("fetching...")
        End If

        ' Close the reader and the database connection
        reader.Close()
        connection.Close()

    End Sub

End Class