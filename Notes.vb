Imports Org.BouncyCastle.Crypto.Macs
Imports MySql.Data.MySqlClient

Public Class Notes

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxNotes.Multiline = True
        txtboxNotes.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxNotes.Clear()
    End Sub
End Class