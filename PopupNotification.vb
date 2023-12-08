Imports Tulpep.NotificationWindow
Imports MySql.Data.MySqlClient
Imports System.Media


Public Class PopupNotification
    Private Const AnimationDuration As Integer = 500 ' Animation duration in milliseconds
    Private WithEvents AnimationTimer As New Timer With {.Interval = 20} ' Timer for animation
    Private Const Margin As Integer = 10 ' Adjust margin as needed

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        ' Start the fade-out animation when the close button is clicked
        FadeOut()
    End Sub

    Private Sub PopupNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SystemSounds.Exclamation.Play()

        ' Set the form's initial location off-screen at the right side with equal margins
        Dim rightMargin As Integer = Screen.PrimaryScreen.WorkingArea.Right - Me.Width - Margin
        Dim bottomMargin As Integer = Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height - Margin
        Me.Location = New Point(rightMargin, bottomMargin)

        ' Start the fade-in animation when the form is loaded
        FadeIn()
    End Sub

    Private Sub FadeIn()
        ' Set the initial opacity to 0
        Me.Opacity = 0.0

        ' Start the fade-in animation
        AnimationTimer.Tag = True ' Tag is used to determine the direction of the animation (fade-in)
        AnimationTimer.Start()
    End Sub

    Private Sub FadeOut()
        ' Start the fade-out animation
        AnimationTimer.Tag = False ' Tag is used to determine the direction of the animation (fade-out)
        AnimationTimer.Start()
    End Sub

    Private Sub AnimationTimer_Tick(sender As Object, e As EventArgs) Handles AnimationTimer.Tick
        ' Handle the animation tick
        Dim direction As Boolean = CBool(AnimationTimer.Tag) ' True for fade-in, False for fade-out

        If direction Then
            ' Fade-in by increasing opacity
            If Me.Opacity < 1.0 Then
                Me.Opacity += 0.05
            Else
                ' Stop the timer when fade-in is complete
                AnimationTimer.Stop()
            End If
        Else
            ' Fade-out by decreasing opacity
            If Me.Opacity > 0.0 Then
                Me.Opacity -= 0.05
            Else
                ' Stop the timer when fade-out is complete
                AnimationTimer.Stop()

                ' Close the form when the fade-out animation is complete
                Me.Close()
            End If
        End If
    End Sub
End Class
