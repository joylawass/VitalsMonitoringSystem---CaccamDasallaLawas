Imports Org.BouncyCastle.Crypto.Macs
Imports MySql.Data.MySqlClient

Public Class Notes

    Private patientID As String = ""

    Public Sub New(patientID As String)
        InitializeComponent()
        Me.patientID = patientID
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxNotes.Multiline = True
        txtboxNotes.TextAlign = HorizontalAlignment.Left

        DisplayPatientNotes()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxNotes.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get the notes text from the txtboxNotes control
        Dim notesText As String = txtboxNotes.Text

        ' Insert the notes into the MySQL database for the specific patient
        Connect()
        query = "UPDATE patient_info SET notes = @notes WHERE patientID = @patientID;"
        Try
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@notes", notesText)
                command.Parameters.AddWithValue("@patientID", patientID)
                command.ExecuteNonQuery()
            End Using

            ' Show a success message and close the Notes form
            MessageBox.Show("Notes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            ' Show an error message if the insertion fails
            MessageBox.Show("Failed to save notes. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayPatientNotes()
        ' Connect to the database
        Connect()

        ' Construct a SQL query to retrieve the notes for the specific patient
        query = "SELECT notes FROM patient_info WHERE patientID = @patientID;"

        Try
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@patientID", patientID)

                ' Execute the SQL query to retrieve the notes
                Dim notes As String = CStr(command.ExecuteScalar())

                ' Display the retrieved notes in the txtboxNotes control
                txtboxNotes.Text = notes
            End Using
        Catch ex As Exception
            ' Show an error message if the retrieval fails
            MessageBox.Show("Failed to retrieve notes. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class