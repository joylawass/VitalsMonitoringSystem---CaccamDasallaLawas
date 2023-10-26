Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Macs

Module DatabaseQueries
    Public query As String
    Public result As String
    Public LoggedInUser As String
    Public UserPass As String
    Public Identifier As String
    Public ChartGen As String

    Public command As New MySqlCommand
    Public connection As New MySqlConnection
    Public conn As New SqlConnection
    Public reader As MySqlDataReader
    Public dt As DataTable
    Public da As MySqlDataAdapter

    Public Sub AdminLogs(activity As String)
        Connect()
        query = "INSERT INTO adminlogs (timestamp, activity) VALUES (@timestamp, @activity)"
        Try
            With command
                .Connection = connection
                .CommandText = query
                With .Parameters
                    .Add("@timestamp", MySqlDbType.VarChar).Value = DateTime.Now.ToString
                    .Add("@activity", MySqlDbType.Text).Value = activity
                End With
                .ExecuteNonQuery()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Connect()
        Try
            connection.Close()
            connection = New MySqlConnection("server=localhost;database=monitoring system;username=root;password=")
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            'Finally
            '    MsgBox("Connection Successful")
        End Try
    End Sub

    Public Sub CreateAdmin(user As String, pass As String)
        Connect()
        query = "SELECT * FROM adminlist WHERE username = '" & user & "';"
        Try
            With command
                .Connection = connection
                .CommandText = query
                reader = .ExecuteReader
                If reader.Read Then
                    MessageBox.Show("Username has already been used.", "User Exists Already", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Try
                        Connect()
                        query = "INSERT INTO `adminlist` (username, password) VALUES (@username, @password);"
                        With command
                            .Connection = connection
                            .CommandText = query
                            With .Parameters
                                .Clear()
                                .Add("@username", MySqlDbType.VarChar).Value = user
                                .Add("@password", MySqlDbType.VarChar).Value = pass
                            End With
                            .ExecuteNonQuery()
                        End With
                        AdminLogs("Signed up new user using credential : " & user)
                        MessageBox.Show("Registration Success!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        SignUpForm.txtbxUsername.Clear()
                        SignUpForm.txtbxPassword.Clear()
                        SignUpForm.txtbxConfirmPass.Clear()
                    Catch ex As Exception
                        MessageBox.Show("Registration Failed!", "User Not Inserted", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SignUpForm.txtbxUsername.Clear()
                        SignUpForm.txtbxPassword.Clear()
                        SignUpForm.txtbxConfirmPass.Clear()
                    End Try
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LogInQuery(user As String, pass As String)
        Connect()
        Try
            query = "SELECT * FROM adminlist WHERE username = @username"
            With command
                .Connection = connection
                .CommandText = query
                .Parameters.Clear()
                .Parameters.Add("@username", MySqlDbType.VarChar).Value = user
                reader = .ExecuteReader
                If reader.Read Then
                    LoggedInUser = user
                    UserPass = reader.GetString("password")
                    If UserPass.Equals(pass) Then
                        AdminLogs("Login using credential : " & LoggedInUser)
                        'DashboardPage.UpdateUsernameText()
                        MainForm.Show()
                        LoginForm.Hide()
                    Else
                        MsgBox("Credentials do not match.")
                        LoginForm.txtbxUsername.Clear()
                        LoginForm.txtbxPassword.Clear()
                    End If
                ElseIf LoginForm.txtbxUsername.Text.Trim() = "" Or LoginForm.txtbxUsername.Text.Trim() = "Username" Then
                    MessageBox.Show("Enter your Username!", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf LoginForm.txtbxPassword.Text.Trim() = "" Or LoginForm.txtbxPassword.Text.Trim() = "Password" Then
                    MessageBox.Show("Enter your Password!", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Account does not exist!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Login is not successful", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub PatientRegister(surname As String, firstname As String, middlename As String, ext As String, address As String, nationality As String, birthdate As String, placeofbirth As String, Sex As String, BloodType As String, BloodOxygen As String, Temperature As String, bpm As String, physician As String, ward As String, emcontactname As String, relationship As String, emaddress As String, emcontact As String, height As String, weight As String, bmi As String, Dev_ID As String, health_history As String)
        Connect()
        query = "SELECT * FROM patient_info WHERE lastname = @lastname AND firstname = @firstname AND middlename = @middlename AND extname = @extname;"
        Try
            With command
                .Connection = connection
                .CommandText = query
                With .Parameters
                    .Clear()
                    .Add("@lastname", MySqlDbType.VarChar).Value = surname
                    .Add("@firstname", MySqlDbType.VarChar).Value = firstname
                    .Add("@middlename", MySqlDbType.VarChar).Value = middlename
                    .Add("@extname", MySqlDbType.VarChar).Value = ext
                End With
                reader = .ExecuteReader
                If reader.Read Then
                    Identifier = reader.GetString("patientID")
                    Dim result As DialogResult = MessageBox.Show("Record Already Exists. Overwrite data?", "caption", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        Connect()
                        query = "UPDATE patient_info SET lastname = @lastname, firstname = @firstname, middlename = @middlename, extname = @extname, current_address = @current_address, nationality = @nationality, birthdate = @birthdate, birthplace = @birthplace, sex = @sex, blood_type = @blood_type, blood_oxygen = @blood_oxygen, physician = @physician, ward = @ward, emergency_name = @emergency_name, emergency_relation = @emergency_relation, emergency_address = @emergency_address, emergency_contact = @emergency_contact, height = @height, weight = @weight, bmi = @bmi, health_history = @health_history, Dev_ID = @Dev_ID WHERE patientID = @patientID;"
                        Try
                            With command
                                .Connection = connection
                                .CommandText = query
                                With .Parameters
                                    .Clear()
                                    .Add("@patientID", MySqlDbType.VarChar).Value = Identifier
                                    .Add("@lastname", MySqlDbType.VarChar).Value = surname
                                    .Add("@firstname", MySqlDbType.VarChar).Value = firstname
                                    .Add("@middlename", MySqlDbType.VarChar).Value = middlename
                                    .Add("@extname", MySqlDbType.VarChar).Value = ext
                                    .Add("@current_address", MySqlDbType.VarChar).Value = address
                                    .Add("@nationality", MySqlDbType.VarChar).Value = nationality
                                    .Add("@birthdate", MySqlDbType.VarChar).Value = birthdate
                                    .Add("@birthplace", MySqlDbType.VarChar).Value = placeofbirth
                                    .Add("@sex", MySqlDbType.VarChar).Value = Sex
                                    .Add("@blood_type", MySqlDbType.VarChar).Value = BloodType
                                    .Add("@blood_oxygen", MySqlDbType.VarChar).Value = BloodOxygen
                                    .Add("@physician", MySqlDbType.VarChar).Value = physician
                                    .Add("@ward", MySqlDbType.VarChar).Value = ward
                                    .Add("@emergency_name", MySqlDbType.VarChar).Value = emcontactname
                                    .Add("@emergency_relation", MySqlDbType.VarChar).Value = relationship
                                    .Add("@emergency_address", MySqlDbType.VarChar).Value = emaddress
                                    .Add("@emergency_contact", MySqlDbType.VarChar).Value = emcontact
                                    .Add("@height", MySqlDbType.VarChar).Value = height
                                    .Add("@weight", MySqlDbType.VarChar).Value = weight
                                    .Add("@bmi", MySqlDbType.VarChar).Value = bmi
                                    .Add("@health_history", MySqlDbType.VarChar).Value = health_history
                                    .Add("@Dev_ID", MySqlDbType.VarChar).Value = Dev_ID
                                End With
                                .ExecuteNonQuery()
                                AdminLogs("Updated patient info with id = " + Identifier + " using credential : " & LoggedInUser)
                            End With
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    ElseIf result = DialogResult.No Then
                        MsgBox("Cancelled")
                    End If
                Else
                    Try
                        Connect()
                        query = "INSERT INTO `patient_info` (lastname, firstname, middlename, extname, current_address, nationality, birthdate, birthplace, sex, blood_type, blood_oxygen, physician, ward, emergency_name, emergency_relation, emergency_address, emergency_contact, height, weight, bmi, Dev_ID, health_history, Status) VALUES (@lastname, @firstname, @middlename, @extname, @current_address, @nationality, @birthdate, @birthplace, @sex, @blood_type, @blood_oxygen, @physician, @ward, @emergency_name, @emergency_relation, @emergency_address, @emergency_contact, @height, @weight, @bmi, @Dev_ID, @health_history, 'Active');"
                        With command
                            .Connection = connection
                            .CommandText = query
                            With .Parameters
                                .Clear()
                                .Add("@lastname", MySqlDbType.VarChar).Value = surname
                                .Add("@firstname", MySqlDbType.VarChar).Value = firstname
                                .Add("@middlename", MySqlDbType.VarChar).Value = middlename
                                .Add("@extname", MySqlDbType.VarChar).Value = ext
                                .Add("@current_address", MySqlDbType.VarChar).Value = address
                                .Add("@nationality", MySqlDbType.VarChar).Value = nationality
                                .Add("@birthdate", MySqlDbType.VarChar).Value = birthdate
                                .Add("@birthplace", MySqlDbType.VarChar).Value = placeofbirth
                                .Add("@sex", MySqlDbType.VarChar).Value = Sex
                                .Add("@blood_type", MySqlDbType.VarChar).Value = BloodType
                                .Add("@blood_oxygen", MySqlDbType.VarChar).Value = BloodOxygen
                                .Add("@physician", MySqlDbType.VarChar).Value = physician
                                .Add("@ward", MySqlDbType.VarChar).Value = ward
                                .Add("@emergency_name", MySqlDbType.VarChar).Value = emcontactname
                                .Add("@emergency_relation", MySqlDbType.VarChar).Value = relationship
                                .Add("@emergency_address", MySqlDbType.VarChar).Value = emaddress
                                .Add("@emergency_contact", MySqlDbType.VarChar).Value = emcontact
                                .Add("@height", MySqlDbType.VarChar).Value = height
                                .Add("@weight", MySqlDbType.VarChar).Value = weight
                                .Add("@bmi", MySqlDbType.VarChar).Value = bmi
                                .Add("@Dev_ID", MySqlDbType.VarChar).Value = Dev_ID
                                .Add("@health_history", MySqlDbType.VarChar).Value = health_history
                            End With
                            .ExecuteNonQuery()
                            AdminLogs("Registered new patient info with id = " + Identifier + " using credential : " & LoggedInUser)
                        End With
                        Connect()

                        Try
                            Connect()
                            query = "SELECT * FROM patient_info WHERE lastname = @lastname AND firstname = @firstname AND middlename = @middlename AND extname = @extname;"
                            With command
                                .Connection = connection
                                .CommandText = query
                                With .Parameters
                                    .Clear()
                                    .Add("@lastname", MySqlDbType.VarChar).Value = surname
                                    .Add("@firstname", MySqlDbType.VarChar).Value = firstname
                                    .Add("@middlename", MySqlDbType.VarChar).Value = middlename
                                    .Add("@extname", MySqlDbType.VarChar).Value = ext
                                End With
                            End With
                            reader = .ExecuteReader
                            If reader.Read Then
                                Identifier = reader.GetString("patientID")
                                CreatePatientRecord(surname, Identifier, Temperature, bpm)
                                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Else
                                MessageBox.Show("Fail", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CreatePatientRecord(lastname As String, patientID As String, temperature As String, pulse As String)
        Connect()
        Try
            query = "CREATE TABLE " & lastname & patientID & " (temperature DECIMAL(4,2) , pulse INT(3), SPO2 INT(3), wearStat BOOLEAN, RFID BOOLEAN, time_stamp VarChar (30), notes VarChar (100))"
            With command
                .Connection = connection
                .CommandText = query
                .ExecuteNonQuery()
            End With
            Connect()
            query = "INSERT INTO " & lastname & patientID & " (temperature, pulse, wearStat, SPO2,RFID, time_stamp) VALUES (@temperature, @pulse, @wearStat, @SPO2,@RFID, @time_stamp, @notes)"
            With command
                .Connection = connection
                .CommandText = query
                With .Parameters
                    .AddWithValue("@temperature", temperature)
                    .AddWithValue("@pulse", pulse)
                    .AddWithValue("@wearStat", False)
                    .AddWithValue("@SPO2", False)
                    .AddWithValue("@RFID", False)
                    .AddWithValue("@time_stamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    .AddWithValue("@notes", "Patient Health Monitoring History Created at : " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                End With
                .ExecuteNonQuery()
                AdminLogs("Created new patient Info Table with id = " + Identifier + " using credential : " & LoggedInUser)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CountDevices()
        Connect()
        query = "SELECT COUNT(*) FROM devicelist"
        Try
            With command
                .Connection = connection
                .CommandText = query
                Dim deviceCount As Integer = CInt(.ExecuteScalar())
                DashboardPage.Label3.Text = deviceCount.ToString()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module