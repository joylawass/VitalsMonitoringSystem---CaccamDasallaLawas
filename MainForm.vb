Imports System.Reflection
Imports System.Windows.Documents
Imports FontAwesome.Sharp
Imports System.Windows.Forms
Imports System.Net
Imports System.Net.Sockets
Public Class MainForm

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 61)
        MenuPanelMainForm.Controls.Add(leftBorderBtn)
    End Sub


    Public Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisabledButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(0, 122, 244)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

            currentBtn.Font = New Font(currentBtn.Font, FontStyle.Bold)

            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            PageTitle.Text = currentBtn.Text
        End If

    End Sub

    Public Sub DisabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(0, 102, 204)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

            currentBtn.Font = New Font(currentBtn.Font, FontStyle.Regular)
        End If
    End Sub

    Sub switchPanel(ByVal panel As Form)
        MainBox.Controls.Clear()
        panel.TopLevel = False
        MainBox.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit without logging out?", "Close Window",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Switch panels as needed
        switchPanel(LiveMonitorPage)
        switchPanel(PatientPage)
        switchPanel(DashboardPage)

        ' Get the local IP address and save it to a string
        Dim localIP As String = ""

        ' Get the host name
        Dim hostName As String = System.Net.Dns.GetHostName()

        ' Get the IP addresses associated with the host
        Dim ipAddresses As System.Net.IPAddress() = System.Net.Dns.GetHostAddresses(hostName)

        ' Find the first IPv4 address (skip IPv6 addresses)
        For Each ipAddress As System.Net.IPAddress In ipAddresses
            If ipAddress.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                localIP = ipAddress.ToString()
                Exit For
            End If
        Next

        ' Now, the localIP variable contains the local IP address
        'MessageBox.Show("Local IP Address: " & localIP)
    End Sub


    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        ActivateButton(sender, Color.White)
        switchPanel(DashboardPage)
    End Sub

    Private Sub PatientButton_Click(sender As Object, e As EventArgs) Handles PatientButton.Click
        switchPanel(PatientPage)
        ActivateButton(sender, Color.White)
    End Sub

    Private Sub LiveMonitorButton_Click(sender As Object, e As EventArgs) Handles LiveMonitorButton.Click
        ActivateButton(sender, Color.White)
        switchPanel(LiveMonitorPage)
    End Sub

    Private Sub DashboardButton_MouseEnter(sender As Object, e As EventArgs) Handles DashboardButton.MouseEnter
        If currentBtn IsNot DashboardButton Then
            DashboardButton.Font = New Font(DashboardButton.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub PatientButton_MouseEnter(sender As Object, e As EventArgs) Handles PatientButton.MouseEnter
        If currentBtn IsNot PatientButton Then
            PatientButton.Font = New Font(PatientButton.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub LiveMonitorButton_MouseEnter(sender As Object, e As EventArgs) Handles LiveMonitorButton.MouseEnter
        If currentBtn IsNot LiveMonitorButton Then
            LiveMonitorButton.Font = New Font(LiveMonitorButton.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub DashboardButton_MouseLeave(sender As Object, e As EventArgs) Handles DashboardButton.MouseLeave
        If currentBtn IsNot DashboardButton Then
            DashboardButton.Font = New Font(DashboardButton.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub PatientButton_MouseLeave(sender As Object, e As EventArgs) Handles PatientButton.MouseLeave
        If currentBtn IsNot PatientButton Then
            PatientButton.Font = New Font(PatientButton.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub LiveMonitorButton_MouseLeave(sender As Object, e As EventArgs) Handles LiveMonitorButton.MouseLeave
        If currentBtn IsNot LiveMonitorButton Then
            LiveMonitorButton.Font = New Font(LiveMonitorButton.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMM dd, yyyy")
        lblTimee.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        ActivateButton(sender, Color.White)
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to log out?", "Log Out Prompt",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub LogoutBtn_MouseEnter(sender As Object, e As EventArgs) Handles LogoutBtn.MouseEnter
        If currentBtn IsNot LogoutButton Then
            LogoutButton.Font = New Font(LogoutButton.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub LogoutBtn_MouseLeave(sender As Object, e As EventArgs) Handles LogoutBtn.MouseLeave
        If currentBtn IsNot LogoutButton Then
            LogoutButton.Font = New Font(LogoutButton.Font, FontStyle.Regular)
        End If
    End Sub

End Class
