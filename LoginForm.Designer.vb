<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TopPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.MinimizeButton = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.linkLabelCreateAccount = New System.Windows.Forms.LinkLabel()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.txtbxUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtbxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TopPanel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TopPanel.Controls.Add(Me.MinimizeButton)
        Me.TopPanel.Controls.Add(Me.CloseButton)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(277, 29)
        Me.TopPanel.TabIndex = 0
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.MinimizeButton.FillColor = System.Drawing.SystemColors.HotTrack
        Me.MinimizeButton.IconColor = System.Drawing.Color.White
        Me.MinimizeButton.Location = New System.Drawing.Point(207, 0)
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
        Me.CloseButton.Location = New System.Drawing.Point(245, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(32, 29)
        Me.CloseButton.TabIndex = 1
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.TopPanel
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(84, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Admin Login"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.BorderRadius = 5
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(142, 312)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 32)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Log In"
        '
        'linkLabelCreateAccount
        '
        Me.linkLabelCreateAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkLabelCreateAccount.AutoSize = True
        Me.linkLabelCreateAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkLabelCreateAccount.LinkColor = System.Drawing.Color.Black
        Me.linkLabelCreateAccount.Location = New System.Drawing.Point(94, 375)
        Me.linkLabelCreateAccount.Name = "linkLabelCreateAccount"
        Me.linkLabelCreateAccount.Size = New System.Drawing.Size(89, 15)
        Me.linkLabelCreateAccount.TabIndex = 13
        Me.linkLabelCreateAccount.TabStop = True
        Me.linkLabelCreateAccount.Text = "Create Account"
        '
        'btnReset
        '
        Me.btnReset.Animated = True
        Me.btnReset.BorderRadius = 5
        Me.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReset.FillColor = System.Drawing.Color.Red
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(38, 312)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(96, 32)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "Reset"
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.BackColor = System.Drawing.Color.Transparent
        Me.showPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.showPassword.ForeColor = System.Drawing.Color.White
        Me.showPassword.Location = New System.Drawing.Point(39, 287)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(108, 19)
        Me.showPassword.TabIndex = 10
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = False
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
        Me.txtbxUsername.Margin = New System.Windows.Forms.Padding(6, 6, 5, 6)
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxUsername.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxUsername.PlaceholderText = "Username"
        Me.txtbxUsername.SelectedText = ""
        Me.txtbxUsername.Size = New System.Drawing.Size(200, 32)
        Me.txtbxUsername.TabIndex = 1
        Me.txtbxUsername.TextOffset = New System.Drawing.Point(4, 0)
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-125, -50)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(526, 302)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 28
        Me.Guna2PictureBox1.TabStop = False
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
        Me.txtbxPassword.Margin = New System.Windows.Forms.Padding(6, 6, 5, 6)
        Me.txtbxPassword.Name = "txtbxPassword"
        Me.txtbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxPassword.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxPassword.PlaceholderText = "Password"
        Me.txtbxPassword.SelectedText = ""
        Me.txtbxPassword.Size = New System.Drawing.Size(200, 32)
        Me.txtbxPassword.TabIndex = 2
        Me.txtbxPassword.TextOffset = New System.Drawing.Point(4, 0)
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(73, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Don't have an account?"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(277, 414)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.linkLabelCreateAccount)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtbxPassword)
        Me.Controls.Add(Me.txtbxUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.TopPanel.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents MinimizeButton As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents linkLabelCreateAccount As LinkLabel
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showPassword As CheckBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtbxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
End Class
