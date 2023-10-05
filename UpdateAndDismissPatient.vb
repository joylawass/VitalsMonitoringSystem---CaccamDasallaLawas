Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class UpdateAndDismissPatient

    Private Sub txbxFamilyName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbxRelationship.KeyPress, txbxPlaceOfBirth.KeyPress, txbxPhysician.KeyPress, txbxNationality.KeyPress, txbxfirstname.KeyPress, txbxFamilyName.KeyPress, txbxemergencycontactname.KeyPress, txbxmidname.KeyPress, txbxExtensionName.KeyPress
        If (Not Char.IsControl(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And e.KeyChar <> "." And e.KeyChar <> "/") Then
            e.Handled = True
            lblNote.Show()
        End If
    End Sub

    Private Sub txbxpulse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbxtemperature.KeyPress, txbxpulse.KeyPress, txbxbloodoxygen.KeyPress, txbxward.KeyPress, txtboxheight.KeyPress, txtboxweight.KeyPress, txtboxBmi.KeyPress, txbxemergencynumber.KeyPress, MyBase.KeyPress

        If (Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And e.KeyChar <> "." And e.KeyChar <> "/") Then
            e.Handled = True
            lblNote.Show()
        End If
    End Sub

    Private Sub txbxFamilyName_Leave(sender As Object, e As EventArgs) Handles txbxward.Leave, txbxtemperature.Leave, txbxRelationship.Leave, txbxpulse.Leave, txbxPlaceOfBirth.Leave, txbxPhysician.Leave, txbxNationality.Leave, txbxmidname.Leave, txbxfirstname.Leave, txbxFamilyName.Leave, txbxExtensionName.Leave, txbxemergencycontactname.Leave, txbxemergencyaddress.Leave, txbxCurrentAddress.Leave, txbxbloodoxygen.Leave, cbxSex.Leave, cbxMac.Leave, cbxBloodType.Leave
        lblNote.Hide()
    End Sub

    Public Sub LoadPatientData(patientID As String)
        ' Modify this connection string with your MySQL database details
        Dim connectionString As String = "server=localhost;database=monitoring system;username=root;password=''"

        ' Create a connection and a SQL command
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Modify this SQL query to retrieve patient data based on patientID
            Dim query As String = "SELECT * FROM patient_info WHERE patientID = @patientID"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@patientID", patientID)

                ' Execute the query and retrieve the patient's data
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Populate the form's controls with the retrieved data
                        txbxFamilyName.Text = reader("lastname").ToString()
                        txbxfirstname.Text = reader("firstname").ToString()
                        txbxmidname.Text = reader("middlename").ToString()
                        txbxExtensionName.Text = reader("extname").ToString()
                        txbxCurrentAddress.Text = reader("current_address").ToString()
                        txbxPlaceOfBirth.Text = reader("birthplace").ToString()
                        txbxBirthdate.Text = reader("birthdate").ToString()
                        txbxNationality.Text = reader("nationality").ToString()
                        txbxbloodoxygen.Text = reader("blood_oxygen").ToString()
                        txbxPhysician.Text = reader("physician").ToString()
                        txbxward.Text = reader("ward").ToString()
                        txbxemergencycontactname.Text = reader("emergency_name").ToString()
                        txbxemergencyaddress.Text = reader("emergency_address").ToString()
                        txbxRelationship.Text = reader("emergency_relation").ToString()
                        txbxemergencynumber.Text = reader("emergency_contact").ToString()
                        txtboxheight.Text = reader("height").ToString()
                        txtboxweight.Text = reader("weight").ToString()
                        txtboxBmi.Text = reader("bmi").ToString()
                        healthHistory.Text = reader("health_history").ToString()

                        LoadComboData(reader("sex").ToString(), reader("blood_type").ToString(), reader("ward").ToString())
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadSexComboBox(selectedSex As String)
        ' Assuming cbxSex is a ComboBox control
        ' Load data into the Sex combo box
        cbxSex.SelectedItem = selectedSex
    End Sub

    Private Sub LoadBloodTypeComboBox(selectedBloodType As String)
        ' Assuming cbxBloodType is a ComboBox control
        ' Load data into the Blood Type combo box
        cbxBloodType.SelectedItem = selectedBloodType
    End Sub

    Private Sub LoadComboData(selectedSex As String, selectedBloodType As String, selectedWard As String)
        ' Load data into combo boxes
        LoadSexComboBox(selectedSex)
        LoadBloodTypeComboBox(selectedBloodType)
    End Sub

    Private Sub UpdateAndDismissPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNote.Hide()
        healthHistory.Multiline = True
        healthHistory.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txbxFamilyName.Text) OrElse
         String.IsNullOrEmpty(txbxfirstname.Text) OrElse
         String.IsNullOrEmpty(txbxmidname.Text) OrElse
         String.IsNullOrEmpty(txbxCurrentAddress.Text) OrElse
         String.IsNullOrEmpty(txbxNationality.Text) OrElse
         String.IsNullOrEmpty(txbxBirthdate.Text) OrElse
         String.IsNullOrEmpty(txbxPlaceOfBirth.Text) OrElse
         cbxSex.SelectedItem Is Nothing OrElse
         cbxBloodType.SelectedItem Is Nothing OrElse
         String.IsNullOrEmpty(txbxbloodoxygen.Text) OrElse
         String.IsNullOrEmpty(txbxtemperature.Text) OrElse
         String.IsNullOrEmpty(txbxpulse.Text) OrElse
         String.IsNullOrEmpty(txbxPhysician.Text) OrElse
         String.IsNullOrEmpty(txbxward.Text) OrElse
         String.IsNullOrEmpty(txbxemergencycontactname.Text) OrElse
         String.IsNullOrEmpty(txbxRelationship.Text) OrElse
         String.IsNullOrEmpty(txbxemergencyaddress.Text) OrElse
         String.IsNullOrEmpty(txbxemergencynumber.Text) OrElse
         String.IsNullOrEmpty(txtboxheight.Text) OrElse
         String.IsNullOrEmpty(txtboxweight.Text) OrElse
         String.IsNullOrEmpty(txtboxBmi.Text) OrElse
         String.IsNullOrEmpty(healthHistory.Text) OrElse
         cbxMac.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        PatientRegister(txbxFamilyName.Text, txbxfirstname.Text, txbxmidname.Text, txbxExtensionName.Text, txbxCurrentAddress.Text, txbxNationality.Text, txbxBirthdate.Text, txbxPlaceOfBirth.Text, cbxSex.SelectedItem, cbxBloodType.SelectedItem, txbxbloodoxygen.Text, txbxtemperature.Text, txbxpulse.Text, txbxPhysician.Text, txbxward.Text, txbxemergencycontactname.Text, txbxRelationship.Text, txbxemergencyaddress.Text, txbxemergencynumber.Text, txtboxheight.Text, txtboxweight.Text, txtboxBmi.Text, cbxMac.SelectedItem.ToString(), healthHistory.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txbxFamilyName.Clear()
        txbxfirstname.Clear()
        txbxmidname.Clear()
        txbxExtensionName.Clear()
        txbxCurrentAddress.Clear()
        txbxNationality.Clear()
        txbxPlaceOfBirth.Clear()
        cbxSex.Items.Clear()
        cbxBloodType.Items.Clear()
        txbxbloodoxygen.Clear()
        txbxtemperature.Clear()
        txbxpulse.Clear()
        txbxPhysician.Clear()
        txbxward.Clear()
        txbxemergencycontactname.Clear()
        txbxRelationship.Clear()
        txbxemergencyaddress.Clear()
        txbxemergencynumber.Clear()
        txtboxheight.Clear()
        txtboxweight.Clear()
        txtboxBmi.Clear()
        cbxMac.Items.Clear()
        healthHistory.Clear()
    End Sub

    Private Sub txtboxheight_TextChanged(sender As Object, e As EventArgs)
        Dim heightText As String = txtboxheight.Text.Trim()
        Dim numericValue As Double

        ' Get the current cursor position
        Dim cursorPosition As Integer = txtboxheight.SelectionStart

        ' Try to parse the numeric value
        If Double.TryParse(heightText, numericValue) Then
            ' Append "cm" and update the textbox
            txtboxheight.Text = numericValue.ToString() & " cm"
        End If

        ' Restore the cursor position
        txtboxheight.SelectionStart = cursorPosition
        CalculateBMI()
    End Sub

    Private Sub txtboxweight_TextChanged(sender As Object, e As EventArgs)
        Dim weightText As String = txtboxweight.Text.Trim()
        Dim numericValue As Double

        ' Get the current cursor position
        Dim cursorPosition As Integer = txtboxweight.SelectionStart

        ' Try to parse the numeric value
        If Double.TryParse(weightText, numericValue) Then
            ' Append "kg" and update the textbox
            txtboxweight.Text = numericValue.ToString() & " kg"
        End If

        ' Restore the cursor position
        txtboxweight.SelectionStart = cursorPosition
        CalculateBMI()
    End Sub

    ' Function to calculate BMI and update the BMI textbox
    Private Sub CalculateBMI()
        ' Remove "cm" and "kg" from the text, if present
        Dim heightText As String = txtboxheight.Text.Replace("cm", "").Trim()
        Dim weightText As String = txtboxweight.Text.Replace("kg", "").Trim()

        ' Parse height and weight as doubles
        Dim height As Double
        Dim weight As Double

        If Double.TryParse(heightText, height) AndAlso Double.TryParse(weightText, weight) Then
            ' Calculate BMI (BMI = weight in kg / (height in meters * height in meters))
            Dim heightInMeters As Double = height / 100.0 ' Convert cm to meters
            Dim bmi As Double = weight / (heightInMeters * heightInMeters)

            ' Display BMI with two decimal places in the BMI textbox
            txtboxBmi.Text = bmi.ToString("N2")
        Else
            ' Handle invalid input (non-numeric or empty values)
            txtboxBmi.Text = ""
        End If
    End Sub

    Private Sub CloseButton_Click_1(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class