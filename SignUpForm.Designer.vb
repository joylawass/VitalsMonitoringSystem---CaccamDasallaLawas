﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.MinimizeButton = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.txtbxConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
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
        Me.btnSignUp.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(147, 401)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(96, 36)
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
        Me.TopPanel.Controls.Add(Me.Guna2Button1)
        Me.TopPanel.Controls.Add(Me.MinimizeButton)
        Me.TopPanel.Controls.Add(Me.CloseButton)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(290, 29)
        Me.TopPanel.TabIndex = 14
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.MinimizeButton.FillColor = System.Drawing.SystemColors.HotTrack
        Me.MinimizeButton.IconColor = System.Drawing.Color.White
        Me.MinimizeButton.Location = New System.Drawing.Point(220, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(32, 29)
        Me.MinimizeButton.TabIndex = 3
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.CustomClick = True
        Me.CloseButton.FillColor = System.Drawing.SystemColors.HotTrack
        Me.CloseButton.IconColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(258, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(32, 29)
        Me.CloseButton.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.BorderRadius = 5
        Me.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReset.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(43, 401)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(96, 36)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "Reset"
        '
        'txtbxConfirmPass
        '
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
        Me.txtbxConfirmPass.Location = New System.Drawing.Point(45, 329)
        Me.txtbxConfirmPass.Name = "txtbxConfirmPass"
        Me.txtbxConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxConfirmPass.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxConfirmPass.PlaceholderText = "Confirm Password"
        Me.txtbxConfirmPass.SelectedText = ""
        Me.txtbxConfirmPass.Size = New System.Drawing.Size(200, 36)
        Me.txtbxConfirmPass.TabIndex = 3
        Me.txtbxConfirmPass.TextOffset = New System.Drawing.Point(6, 0)
        '
        'txtbxPassword
        '
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
        Me.txtbxPassword.Location = New System.Drawing.Point(45, 287)
        Me.txtbxPassword.Name = "txtbxPassword"
        Me.txtbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxPassword.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxPassword.PlaceholderText = "Password"
        Me.txtbxPassword.SelectedText = ""
        Me.txtbxPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtbxPassword.TabIndex = 2
        Me.txtbxPassword.TextOffset = New System.Drawing.Point(4, 0)
        '
        'txtbxUsername
        '
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
        Me.txtbxUsername.Location = New System.Drawing.Point(45, 245)
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxUsername.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtbxUsername.PlaceholderText = "Username"
        Me.txtbxUsername.SelectedText = ""
        Me.txtbxUsername.Size = New System.Drawing.Size(200, 36)
        Me.txtbxUsername.TabIndex = 1
        Me.txtbxUsername.TextOffset = New System.Drawing.Point(4, 0)
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.BackColor = System.Drawing.Color.Transparent
        Me.showPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.ForeColor = System.Drawing.Color.White
        Me.showPassword.Location = New System.Drawing.Point(45, 371)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(129, 24)
        Me.showPassword.TabIndex = 26
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-140, -67)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(570, 339)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 27
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(47, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 28)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Admin Registration"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(33, 29)
        Me.Guna2Button1.TabIndex = 29
        Me.Guna2Button1.Text = "<"
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(290, 464)
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
    Friend WithEvents MinimizeButton As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents txtbxConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showPassword As CheckBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
