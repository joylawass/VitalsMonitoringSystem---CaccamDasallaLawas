<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.TopPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnBackToLogIn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.txtbxConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblPasswordsDoNotMatch = New System.Windows.Forms.Label()
        Me.TopPanel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnSignUp
        '
        Me.btnSignUp.BorderRadius = 5
        Me.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignUp.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btnSignUp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(142, 343)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(96, 32)
        Me.btnSignUp.TabIndex = 4
        Me.btnSignUp.Text = "Sign Up"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.TopPanel
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TopPanel.Controls.Add(Me.btnBackToLogIn)
        Me.TopPanel.Controls.Add(Me.btnMinimize)
        Me.TopPanel.Controls.Add(Me.btnClose)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(277, 29)
        Me.TopPanel.TabIndex = 14
        '
        'btnBackToLogIn
        '
        Me.btnBackToLogIn.BorderRadius = 5
        Me.btnBackToLogIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackToLogIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackToLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackToLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackToLogIn.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btnBackToLogIn.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnBackToLogIn.ForeColor = System.Drawing.Color.White
        Me.btnBackToLogIn.Location = New System.Drawing.Point(0, 0)
        Me.btnBackToLogIn.Name = "btnBackToLogIn"
        Me.btnBackToLogIn.Size = New System.Drawing.Size(33, 29)
        Me.btnBackToLogIn.TabIndex = 29
        Me.btnBackToLogIn.Text = "<"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.btnMinimize.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btnMinimize.IconColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(207, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(32, 29)
        Me.btnMinimize.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.CustomClick = True
        Me.btnClose.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btnClose.IconColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(245, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 29)
        Me.btnClose.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.BorderRadius = 5
        Me.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReset.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(38, 343)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(96, 32)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "Reset"
        '
        'txtbxConfirmPass
        '
        Me.txtbxConfirmPass.Animated = True
        Me.txtbxConfirmPass.BorderColor = System.Drawing.Color.Black
        Me.txtbxConfirmPass.BorderRadius = 5
        Me.txtbxConfirmPass.BorderThickness = 0
        Me.txtbxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxConfirmPass.DefaultText = ""
        Me.txtbxConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxConfirmPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxConfirmPass.ForeColor = System.Drawing.Color.Black
        Me.txtbxConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxConfirmPass.IconLeft = Global.VitalsMonitoringSystem.My.Resources.Resources.icons8_confirm_30
        Me.txtbxConfirmPass.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.txtbxConfirmPass.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtbxConfirmPass.Location = New System.Drawing.Point(38, 281)
        Me.txtbxConfirmPass.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtbxConfirmPass.Name = "txtbxConfirmPass"
        Me.txtbxConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxConfirmPass.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxConfirmPass.PlaceholderText = "Confirm Password"
        Me.txtbxConfirmPass.SelectedText = ""
        Me.txtbxConfirmPass.Size = New System.Drawing.Size(200, 32)
        Me.txtbxConfirmPass.TabIndex = 3
        Me.txtbxConfirmPass.TextOffset = New System.Drawing.Point(6, 0)
        '
        'txtbxPassword
        '
        Me.txtbxPassword.Animated = True
        Me.txtbxPassword.BorderColor = System.Drawing.Color.Black
        Me.txtbxPassword.BorderRadius = 5
        Me.txtbxPassword.BorderThickness = 0
        Me.txtbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxPassword.DefaultText = ""
        Me.txtbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxPassword.ForeColor = System.Drawing.Color.Black
        Me.txtbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxPassword.IconLeft = Global.VitalsMonitoringSystem.My.Resources.Resources.icons8_password_64
        Me.txtbxPassword.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txtbxPassword.Location = New System.Drawing.Point(38, 244)
        Me.txtbxPassword.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtbxPassword.Name = "txtbxPassword"
        Me.txtbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxPassword.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxPassword.PlaceholderText = "Password"
        Me.txtbxPassword.SelectedText = ""
        Me.txtbxPassword.Size = New System.Drawing.Size(200, 32)
        Me.txtbxPassword.TabIndex = 2
        Me.txtbxPassword.TextOffset = New System.Drawing.Point(4, 0)
        '
        'txtbxUsername
        '
        Me.txtbxUsername.Animated = True
        Me.txtbxUsername.BorderColor = System.Drawing.Color.Transparent
        Me.txtbxUsername.BorderRadius = 5
        Me.txtbxUsername.BorderThickness = 0
        Me.txtbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxUsername.DefaultText = ""
        Me.txtbxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxUsername.ForeColor = System.Drawing.Color.Black
        Me.txtbxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxUsername.IconLeft = Global.VitalsMonitoringSystem.My.Resources.Resources.icons8_username_64__3_
        Me.txtbxUsername.IconLeftOffset = New System.Drawing.Point(0, -4)
        Me.txtbxUsername.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txtbxUsername.Location = New System.Drawing.Point(38, 208)
        Me.txtbxUsername.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxUsername.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxUsername.PlaceholderText = "Username"
        Me.txtbxUsername.SelectedText = ""
        Me.txtbxUsername.Size = New System.Drawing.Size(200, 32)
        Me.txtbxUsername.TabIndex = 1
        Me.txtbxUsername.TextOffset = New System.Drawing.Point(4, 0)
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.BackColor = System.Drawing.Color.Transparent
        Me.showPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.ForeColor = System.Drawing.Color.White
        Me.showPassword.Location = New System.Drawing.Point(38, 322)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(108, 19)
        Me.showPassword.TabIndex = 26
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(59, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 21)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Admin Registration"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-126, -50)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(526, 302)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 29
        Me.Guna2PictureBox1.TabStop = False
        '
        'lblPasswordsDoNotMatch
        '
        Me.lblPasswordsDoNotMatch.AutoSize = True
        Me.lblPasswordsDoNotMatch.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Italic)
        Me.lblPasswordsDoNotMatch.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPasswordsDoNotMatch.Location = New System.Drawing.Point(36, 378)
        Me.lblPasswordsDoNotMatch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswordsDoNotMatch.Name = "lblPasswordsDoNotMatch"
        Me.lblPasswordsDoNotMatch.Size = New System.Drawing.Size(115, 12)
        Me.lblPasswordsDoNotMatch.TabIndex = 30
        Me.lblPasswordsDoNotMatch.Text = "*Passwords do not match."
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(277, 427)
        Me.Controls.Add(Me.lblPasswordsDoNotMatch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtbxConfirmPass)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.txtbxPassword)
        Me.Controls.Add(Me.txtbxUsername)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUpForm"
        Me.TopPanel.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents txtbxConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showPassword As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBackToLogIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblPasswordsDoNotMatch As Label
End Class
