Imports Org.BouncyCastle.Crypto.Macs
Imports MySql.Data.MySqlClient

Public Class Notes

    Private tableName As String = ""

    Public Sub New(tableName As String)
        InitializeComponent()
        Me.tableName = tableName
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
        Connect()
        query = "SELECT FROM " & tableName & ";"
    End Sub

    Public Sub DisplayPatientNotes()
        Connect()
        query = "SELECT FROM " & tableName & ";"
    End Sub

End Class