<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TopPanelMainForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.MinimizeButton = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.MenuPanelMainForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.LogoutBtn = New FontAwesome.Sharp.IconButton()
        Me.LiveMonitorButton = New FontAwesome.Sharp.IconButton()
        Me.PatientButton = New FontAwesome.Sharp.IconButton()
        Me.DashboardButton = New FontAwesome.Sharp.IconButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LogoutButton = New FontAwesome.Sharp.IconButton()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.MainBox = New Guna.UI2.WinForms.Guna2Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTimee = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PageTitle = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.TopPanelMainForm.SuspendLayout()
        Me.MenuPanelMainForm.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'TopPanelMainForm
        '
        Me.TopPanelMainForm.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TopPanelMainForm.Controls.Add(Me.MinimizeButton)
        Me.TopPanelMainForm.Controls.Add(Me.CloseButton)
        Me.TopPanelMainForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanelMainForm.Location = New System.Drawing.Point(0, 0)
        Me.TopPanelMainForm.Name = "TopPanelMainForm"
        Me.TopPanelMainForm.Size = New System.Drawing.Size(969, 29)
        Me.TopPanelMainForm.TabIndex = 0
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.MinimizeButton.FillColor = System.Drawing.SystemColors.HotTrack
        Me.MinimizeButton.IconColor = System.Drawing.Color.White
        Me.MinimizeButton.Location = New System.Drawing.Point(899, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(32, 29)
        Me.MinimizeButton.TabIndex = 2
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.CustomClick = True
        Me.CloseButton.FillColor = System.Drawing.SystemColors.HotTrack
        Me.CloseButton.IconColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(937, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(32, 29)
        Me.CloseButton.TabIndex = 0
        '
        'MenuPanelMainForm
        '
        Me.MenuPanelMainForm.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuPanelMainForm.Controls.Add(Me.LogoutBtn)
        Me.MenuPanelMainForm.Controls.Add(Me.LiveMonitorButton)
        Me.MenuPanelMainForm.Controls.Add(Me.PatientButton)
        Me.MenuPanelMainForm.Controls.Add(Me.DashboardButton)
        Me.MenuPanelMainForm.Controls.Add(Me.Guna2PictureBox1)
        Me.MenuPanelMainForm.Controls.Add(Me.LogoutButton)
        Me.MenuPanelMainForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanelMainForm.Location = New System.Drawing.Point(0, 29)
        Me.MenuPanelMainForm.Name = "MenuPanelMainForm"
        Me.MenuPanelMainForm.Size = New System.Drawing.Size(256, 600)
        Me.MenuPanelMainForm.TabIndex = 1
        '
        'LogoutBtn
        '
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.LogoutBtn.IconColor = System.Drawing.Color.White
        Me.LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LogoutBtn.IconSize = 36
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.Location = New System.Drawing.Point(8, 490)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LogoutBtn.Rotation = 180.0R
        Me.LogoutBtn.Size = New System.Drawing.Size(240, 61)
        Me.LogoutBtn.TabIndex = 44
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'LiveMonitorButton
        '
        Me.LiveMonitorButton.FlatAppearance.BorderSize = 0
        Me.LiveMonitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiveMonitorButton.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.LiveMonitorButton.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt
        Me.LiveMonitorButton.IconColor = System.Drawing.Color.White
        Me.LiveMonitorButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LiveMonitorButton.IconSize = 36
        Me.LiveMonitorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LiveMonitorButton.Location = New System.Drawing.Point(8, 390)
        Me.LiveMonitorButton.Name = "LiveMonitorButton"
        Me.LiveMonitorButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LiveMonitorButton.Size = New System.Drawing.Size(240, 61)
        Me.LiveMonitorButton.TabIndex = 41
        Me.LiveMonitorButton.Text = "Live Monitor"
        Me.LiveMonitorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LiveMonitorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LiveMonitorButton.UseVisualStyleBackColor = True
        '
        'PatientButton
        '
        Me.PatientButton.FlatAppearance.BorderSize = 0
        Me.PatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PatientButton.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.PatientButton.IconChar = FontAwesome.Sharp.IconChar.HospitalUser
        Me.PatientButton.IconColor = System.Drawing.Color.White
        Me.PatientButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PatientButton.IconSize = 36
        Me.PatientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PatientButton.Location = New System.Drawing.Point(8, 323)
        Me.PatientButton.Name = "PatientButton"
        Me.PatientButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.PatientButton.Size = New System.Drawing.Size(240, 61)
        Me.PatientButton.TabIndex = 40
        Me.PatientButton.Text = "Records"
        Me.PatientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PatientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PatientButton.UseVisualStyleBackColor = True
        '
        'DashboardButton
        '
        Me.DashboardButton.FlatAppearance.BorderSize = 0
        Me.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardButton.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DashboardButton.IconChar = FontAwesome.Sharp.IconChar.Hive
        Me.DashboardButton.IconColor = System.Drawing.Color.White
        Me.DashboardButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DashboardButton.IconSize = 36
        Me.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardButton.Location = New System.Drawing.Point(8, 256)
        Me.DashboardButton.Name = "DashboardButton"
        Me.DashboardButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.DashboardButton.Size = New System.Drawing.Size(240, 61)
        Me.DashboardButton.TabIndex = 39
        Me.DashboardButton.Text = "Dashboard"
        Me.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardButton.UseVisualStyleBackColor = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-51, -102)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(429, 428)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 14
        Me.Guna2PictureBox1.TabStop = False
        '
        'LogoutButton
        '
        Me.LogoutButton.FlatAppearance.BorderSize = 0
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutButton.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.LogoutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.LogoutButton.IconColor = System.Drawing.Color.White
        Me.LogoutButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LogoutButton.IconSize = 36
        Me.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.Location = New System.Drawing.Point(22, 931)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.LogoutButton.Rotation = 180.0R
        Me.LogoutButton.Size = New System.Drawing.Size(190, 49)
        Me.LogoutButton.TabIndex = 43
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.TopPanelMainForm
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'MainBox
        '
        Me.MainBox.Location = New System.Drawing.Point(264, 80)
        Me.MainBox.Name = "MainBox"
        Me.MainBox.Size = New System.Drawing.Size(697, 541)
        Me.MainBox.TabIndex = 21
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Panel1.Controls.Add(Me.lblTimee)
        Me.Guna2Panel1.Controls.Add(Me.IconCurrentForm)
        Me.Guna2Panel1.Controls.Add(Me.PageTitle)
        Me.Guna2Panel1.Controls.Add(Me.lblDate)
        Me.Guna2Panel1.Controls.Add(Me.lblTime)
        Me.Guna2Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Panel1.Location = New System.Drawing.Point(264, 35)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(697, 47)
        Me.Guna2Panel1.TabIndex = 22
        '
        'lblTimee
        '
        Me.lblTimee.AutoSize = True
        Me.lblTimee.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimee.ForeColor = System.Drawing.Color.White
        Me.lblTimee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTimee.Location = New System.Drawing.Point(603, 11)
        Me.lblTimee.Name = "lblTimee"
        Me.lblTimee.Size = New System.Drawing.Size(94, 25)
        Me.lblTimee.TabIndex = 44
        Me.lblTimee.Text = "hh:mm:ss"
        Me.lblTimee.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.Transparent
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Hive
        Me.IconCurrentForm.IconColor = System.Drawing.Color.White
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(8, 7)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 42
        Me.IconCurrentForm.TabStop = False
        '
        'PageTitle
        '
        Me.PageTitle.AutoSize = True
        Me.PageTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageTitle.ForeColor = System.Drawing.Color.White
        Me.PageTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PageTitle.Location = New System.Drawing.Point(46, 11)
        Me.PageTitle.Name = "PageTitle"
        Me.PageTitle.Size = New System.Drawing.Size(109, 25)
        Me.PageTitle.TabIndex = 43
        Me.PageTitle.Text = "Dashboard"
        Me.PageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDate.Location = New System.Drawing.Point(471, 11)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(145, 25)
        Me.lblDate.TabIndex = 41
        Me.lblDate.Text = "MMM dd, yyyy"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTime.Location = New System.Drawing.Point(1106, 7)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 25)
        Me.lblTime.TabIndex = 40
        Me.lblTime.Text = "HH:MM:SS"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(969, 629)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.MainBox)
        Me.Controls.Add(Me.MenuPanelMainForm)
        Me.Controls.Add(Me.TopPanelMainForm)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        Me.TopPanelMainForm.ResumeLayout(False)
        Me.MenuPanelMainForm.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TopPanelMainForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MenuPanelMainForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents MinimizeButton As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents MainBox As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DashboardButton As FontAwesome.Sharp.IconButton
    Friend WithEvents LiveMonitorButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PatientButton As FontAwesome.Sharp.IconButton
    Friend WithEvents LogoutButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PageTitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents LogoutBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents lblTimee As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
