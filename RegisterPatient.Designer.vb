<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterPatient
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
        Me.lblNote = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.CloseButton = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.TopPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txbxFamilyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxfirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxmidname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxExtensionName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxCurrentAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxPlaceOfBirth = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxNationality = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxSex = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxBloodType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbxpulse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxtemperature = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxbloodoxygen = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxPhysician = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxward = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxemergencycontactname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxRelationship = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbxemergencyaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxMac = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.healthHistory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxheight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtboxweight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxBmi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.txbxBirthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txbxemergencynumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Font = New System.Drawing.Font("Microsoft YaHei", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.Color.Red
        Me.lblNote.Location = New System.Drawing.Point(28, 580)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(142, 16)
        Me.lblNote.TabIndex = 125
        Me.lblNote.Text = "*This form is case-sensitive."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(437, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 19)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Patient's Device Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(28, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Emergency Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(215, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Birth Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 21)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "PATIENT'S PROFILE"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.CustomClick = True
        Me.CloseButton.FillColor = System.Drawing.Color.Transparent
        Me.CloseButton.IconColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(732, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(32, 29)
        Me.CloseButton.TabIndex = 1
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.CloseButton)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(764, 29)
        Me.TopPanel.TabIndex = 132
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 5
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(627, 560)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 36)
        Me.btnSave.TabIndex = 133
        Me.btnSave.Text = "Save"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(27, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 19)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Initial Vital Signs"
        '
        'txbxFamilyName
        '
        Me.txbxFamilyName.Animated = True
        Me.txbxFamilyName.BorderRadius = 5
        Me.txbxFamilyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxFamilyName.DefaultText = ""
        Me.txbxFamilyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxFamilyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxFamilyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxFamilyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxFamilyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxFamilyName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxFamilyName.ForeColor = System.Drawing.Color.Black
        Me.txbxFamilyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxFamilyName.Location = New System.Drawing.Point(31, 94)
        Me.txbxFamilyName.Name = "txbxFamilyName"
        Me.txbxFamilyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxFamilyName.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxFamilyName.PlaceholderText = "Last Name"
        Me.txbxFamilyName.SelectedText = ""
        Me.txbxFamilyName.Size = New System.Drawing.Size(222, 36)
        Me.txbxFamilyName.TabIndex = 1
        '
        'txbxfirstname
        '
        Me.txbxfirstname.Animated = True
        Me.txbxfirstname.BorderRadius = 5
        Me.txbxfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxfirstname.DefaultText = ""
        Me.txbxfirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxfirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxfirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxfirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxfirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxfirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxfirstname.ForeColor = System.Drawing.Color.Black
        Me.txbxfirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxfirstname.Location = New System.Drawing.Point(259, 94)
        Me.txbxfirstname.Name = "txbxfirstname"
        Me.txbxfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxfirstname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxfirstname.PlaceholderText = "First Name"
        Me.txbxfirstname.SelectedText = ""
        Me.txbxfirstname.Size = New System.Drawing.Size(222, 36)
        Me.txbxfirstname.TabIndex = 2
        '
        'txbxmidname
        '
        Me.txbxmidname.Animated = True
        Me.txbxmidname.BorderRadius = 5
        Me.txbxmidname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxmidname.DefaultText = ""
        Me.txbxmidname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxmidname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxmidname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxmidname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxmidname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxmidname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxmidname.ForeColor = System.Drawing.Color.Black
        Me.txbxmidname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxmidname.Location = New System.Drawing.Point(487, 94)
        Me.txbxmidname.Name = "txbxmidname"
        Me.txbxmidname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxmidname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxmidname.PlaceholderText = "Middle Name"
        Me.txbxmidname.SelectedText = ""
        Me.txbxmidname.Size = New System.Drawing.Size(169, 36)
        Me.txbxmidname.TabIndex = 3
        '
        'txbxExtensionName
        '
        Me.txbxExtensionName.Animated = True
        Me.txbxExtensionName.BorderRadius = 5
        Me.txbxExtensionName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxExtensionName.DefaultText = ""
        Me.txbxExtensionName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxExtensionName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxExtensionName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxExtensionName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxExtensionName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxExtensionName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxExtensionName.ForeColor = System.Drawing.Color.Black
        Me.txbxExtensionName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxExtensionName.Location = New System.Drawing.Point(662, 94)
        Me.txbxExtensionName.Name = "txbxExtensionName"
        Me.txbxExtensionName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxExtensionName.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxExtensionName.PlaceholderText = "Suffix"
        Me.txbxExtensionName.SelectedText = ""
        Me.txbxExtensionName.Size = New System.Drawing.Size(72, 36)
        Me.txbxExtensionName.TabIndex = 4
        '
        'txbxCurrentAddress
        '
        Me.txbxCurrentAddress.Animated = True
        Me.txbxCurrentAddress.BorderRadius = 5
        Me.txbxCurrentAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxCurrentAddress.DefaultText = ""
        Me.txbxCurrentAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxCurrentAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxCurrentAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxCurrentAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxCurrentAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxCurrentAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxCurrentAddress.ForeColor = System.Drawing.Color.Black
        Me.txbxCurrentAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxCurrentAddress.Location = New System.Drawing.Point(31, 136)
        Me.txbxCurrentAddress.Name = "txbxCurrentAddress"
        Me.txbxCurrentAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxCurrentAddress.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxCurrentAddress.PlaceholderText = "Current Address"
        Me.txbxCurrentAddress.SelectedText = ""
        Me.txbxCurrentAddress.Size = New System.Drawing.Size(450, 36)
        Me.txbxCurrentAddress.TabIndex = 5
        '
        'txbxPlaceOfBirth
        '
        Me.txbxPlaceOfBirth.Animated = True
        Me.txbxPlaceOfBirth.BorderRadius = 5
        Me.txbxPlaceOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxPlaceOfBirth.DefaultText = ""
        Me.txbxPlaceOfBirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxPlaceOfBirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxPlaceOfBirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxPlaceOfBirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxPlaceOfBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxPlaceOfBirth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxPlaceOfBirth.ForeColor = System.Drawing.Color.Black
        Me.txbxPlaceOfBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxPlaceOfBirth.Location = New System.Drawing.Point(487, 136)
        Me.txbxPlaceOfBirth.Name = "txbxPlaceOfBirth"
        Me.txbxPlaceOfBirth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxPlaceOfBirth.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxPlaceOfBirth.PlaceholderText = "Place of Birth"
        Me.txbxPlaceOfBirth.SelectedText = ""
        Me.txbxPlaceOfBirth.Size = New System.Drawing.Size(247, 36)
        Me.txbxPlaceOfBirth.TabIndex = 6
        '
        'txbxNationality
        '
        Me.txbxNationality.Animated = True
        Me.txbxNationality.BorderRadius = 5
        Me.txbxNationality.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxNationality.DefaultText = ""
        Me.txbxNationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxNationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxNationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxNationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxNationality.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxNationality.ForeColor = System.Drawing.Color.Black
        Me.txbxNationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxNationality.Location = New System.Drawing.Point(31, 178)
        Me.txbxNationality.Name = "txbxNationality"
        Me.txbxNationality.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxNationality.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxNationality.PlaceholderText = "Nationality"
        Me.txbxNationality.SelectedText = ""
        Me.txbxNationality.Size = New System.Drawing.Size(178, 36)
        Me.txbxNationality.TabIndex = 8
        '
        'cbxSex
        '
        Me.cbxSex.BackColor = System.Drawing.Color.Transparent
        Me.cbxSex.BorderRadius = 5
        Me.cbxSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSex.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxSex.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxSex.ForeColor = System.Drawing.Color.Black
        Me.cbxSex.ItemHeight = 30
        Me.cbxSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbxSex.Location = New System.Drawing.Point(474, 178)
        Me.cbxSex.Name = "cbxSex"
        Me.cbxSex.Size = New System.Drawing.Size(98, 36)
        Me.cbxSex.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(440, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 15)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Sex:"
        '
        'cbxBloodType
        '
        Me.cbxBloodType.BackColor = System.Drawing.Color.Transparent
        Me.cbxBloodType.BorderRadius = 5
        Me.cbxBloodType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBloodType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxBloodType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxBloodType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxBloodType.ForeColor = System.Drawing.Color.Black
        Me.cbxBloodType.ItemHeight = 30
        Me.cbxBloodType.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.cbxBloodType.Location = New System.Drawing.Point(652, 178)
        Me.cbxBloodType.Name = "cbxBloodType"
        Me.cbxBloodType.Size = New System.Drawing.Size(82, 36)
        Me.cbxBloodType.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(578, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "Blood Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(438, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 17)
        Me.Label8.TabIndex = 147
        Me.Label8.Text = "Diagnosis / Health History"
        '
        'txbxpulse
        '
        Me.txbxpulse.Animated = True
        Me.txbxpulse.BorderRadius = 5
        Me.txbxpulse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxpulse.DefaultText = ""
        Me.txbxpulse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxpulse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxpulse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxpulse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxpulse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxpulse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxpulse.ForeColor = System.Drawing.Color.Black
        Me.txbxpulse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxpulse.Location = New System.Drawing.Point(31, 268)
        Me.txbxpulse.Name = "txbxpulse"
        Me.txbxpulse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxpulse.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxpulse.PlaceholderText = "Pulse Rate"
        Me.txbxpulse.SelectedText = ""
        Me.txbxpulse.Size = New System.Drawing.Size(123, 36)
        Me.txbxpulse.TabIndex = 11
        '
        'txbxtemperature
        '
        Me.txbxtemperature.Animated = True
        Me.txbxtemperature.BorderRadius = 5
        Me.txbxtemperature.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxtemperature.DefaultText = ""
        Me.txbxtemperature.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxtemperature.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxtemperature.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxtemperature.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxtemperature.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxtemperature.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxtemperature.ForeColor = System.Drawing.Color.Black
        Me.txbxtemperature.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxtemperature.Location = New System.Drawing.Point(160, 268)
        Me.txbxtemperature.Name = "txbxtemperature"
        Me.txbxtemperature.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxtemperature.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxtemperature.PlaceholderText = "Body Temperature"
        Me.txbxtemperature.SelectedText = ""
        Me.txbxtemperature.Size = New System.Drawing.Size(123, 36)
        Me.txbxtemperature.TabIndex = 12
        '
        'txbxbloodoxygen
        '
        Me.txbxbloodoxygen.Animated = True
        Me.txbxbloodoxygen.BorderRadius = 5
        Me.txbxbloodoxygen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxbloodoxygen.DefaultText = ""
        Me.txbxbloodoxygen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxbloodoxygen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxbloodoxygen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxbloodoxygen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxbloodoxygen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxbloodoxygen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxbloodoxygen.ForeColor = System.Drawing.Color.Black
        Me.txbxbloodoxygen.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxbloodoxygen.Location = New System.Drawing.Point(289, 268)
        Me.txbxbloodoxygen.Name = "txbxbloodoxygen"
        Me.txbxbloodoxygen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxbloodoxygen.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxbloodoxygen.PlaceholderText = "Blood Oxygen"
        Me.txbxbloodoxygen.SelectedText = ""
        Me.txbxbloodoxygen.Size = New System.Drawing.Size(123, 36)
        Me.txbxbloodoxygen.TabIndex = 13
        '
        'txbxPhysician
        '
        Me.txbxPhysician.Animated = True
        Me.txbxPhysician.BorderRadius = 5
        Me.txbxPhysician.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxPhysician.DefaultText = ""
        Me.txbxPhysician.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxPhysician.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxPhysician.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxPhysician.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxPhysician.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxPhysician.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxPhysician.ForeColor = System.Drawing.Color.Black
        Me.txbxPhysician.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxPhysician.Location = New System.Drawing.Point(31, 310)
        Me.txbxPhysician.Name = "txbxPhysician"
        Me.txbxPhysician.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxPhysician.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxPhysician.PlaceholderText = "Physician's Name"
        Me.txbxPhysician.SelectedText = ""
        Me.txbxPhysician.Size = New System.Drawing.Size(252, 36)
        Me.txbxPhysician.TabIndex = 14
        '
        'txbxward
        '
        Me.txbxward.Animated = True
        Me.txbxward.BorderRadius = 5
        Me.txbxward.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxward.DefaultText = ""
        Me.txbxward.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxward.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxward.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxward.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxward.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxward.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxward.ForeColor = System.Drawing.Color.Black
        Me.txbxward.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxward.Location = New System.Drawing.Point(289, 310)
        Me.txbxward.Name = "txbxward"
        Me.txbxward.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxward.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxward.PlaceholderText = "Ward Number"
        Me.txbxward.SelectedText = ""
        Me.txbxward.Size = New System.Drawing.Size(123, 36)
        Me.txbxward.TabIndex = 15
        '
        'txbxemergencycontactname
        '
        Me.txbxemergencycontactname.Animated = True
        Me.txbxemergencycontactname.BorderRadius = 5
        Me.txbxemergencycontactname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxemergencycontactname.DefaultText = ""
        Me.txbxemergencycontactname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxemergencycontactname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxemergencycontactname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxemergencycontactname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxemergencycontactname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxemergencycontactname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxemergencycontactname.ForeColor = System.Drawing.Color.Black
        Me.txbxemergencycontactname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxemergencycontactname.Location = New System.Drawing.Point(31, 403)
        Me.txbxemergencycontactname.Name = "txbxemergencycontactname"
        Me.txbxemergencycontactname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxemergencycontactname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxemergencycontactname.PlaceholderText = "Full Name"
        Me.txbxemergencycontactname.SelectedText = ""
        Me.txbxemergencycontactname.Size = New System.Drawing.Size(370, 36)
        Me.txbxemergencycontactname.TabIndex = 17
        '
        'txbxRelationship
        '
        Me.txbxRelationship.Animated = True
        Me.txbxRelationship.BorderRadius = 5
        Me.txbxRelationship.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxRelationship.DefaultText = ""
        Me.txbxRelationship.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxRelationship.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxRelationship.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxRelationship.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxRelationship.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxRelationship.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxRelationship.ForeColor = System.Drawing.Color.Black
        Me.txbxRelationship.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxRelationship.Location = New System.Drawing.Point(31, 487)
        Me.txbxRelationship.Name = "txbxRelationship"
        Me.txbxRelationship.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxRelationship.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxRelationship.PlaceholderText = "Relationship"
        Me.txbxRelationship.SelectedText = ""
        Me.txbxRelationship.Size = New System.Drawing.Size(206, 36)
        Me.txbxRelationship.TabIndex = 19
        '
        'txbxemergencyaddress
        '
        Me.txbxemergencyaddress.Animated = True
        Me.txbxemergencyaddress.BorderRadius = 5
        Me.txbxemergencyaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxemergencyaddress.DefaultText = ""
        Me.txbxemergencyaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxemergencyaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxemergencyaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxemergencyaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxemergencyaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxemergencyaddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxemergencyaddress.ForeColor = System.Drawing.Color.Black
        Me.txbxemergencyaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxemergencyaddress.Location = New System.Drawing.Point(31, 445)
        Me.txbxemergencyaddress.Name = "txbxemergencyaddress"
        Me.txbxemergencyaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxemergencyaddress.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxemergencyaddress.PlaceholderText = "Current Address"
        Me.txbxemergencyaddress.SelectedText = ""
        Me.txbxemergencyaddress.Size = New System.Drawing.Size(370, 36)
        Me.txbxemergencyaddress.TabIndex = 18
        '
        'cbxMac
        '
        Me.cbxMac.BackColor = System.Drawing.Color.Transparent
        Me.cbxMac.BorderRadius = 5
        Me.cbxMac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxMac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMac.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxMac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxMac.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxMac.ForeColor = System.Drawing.Color.Black
        Me.cbxMac.ItemHeight = 30
        Me.cbxMac.Location = New System.Drawing.Point(441, 364)
        Me.cbxMac.Name = "cbxMac"
        Me.cbxMac.Size = New System.Drawing.Size(293, 36)
        Me.cbxMac.TabIndex = 21
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 5
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'healthHistory
        '
        Me.healthHistory.Animated = True
        Me.healthHistory.BorderRadius = 5
        Me.healthHistory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.healthHistory.DefaultText = ""
        Me.healthHistory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.healthHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.healthHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.healthHistory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.healthHistory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.healthHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.healthHistory.ForeColor = System.Drawing.Color.Black
        Me.healthHistory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.healthHistory.Location = New System.Drawing.Point(444, 453)
        Me.healthHistory.Name = "healthHistory"
        Me.healthHistory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.healthHistory.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.healthHistory.PlaceholderText = "Put N/A if none."
        Me.healthHistory.SelectedText = ""
        Me.healthHistory.Size = New System.Drawing.Size(290, 70)
        Me.healthHistory.TabIndex = 149
        '
        'txtboxheight
        '
        Me.txtboxheight.Animated = True
        Me.txtboxheight.BorderRadius = 5
        Me.txtboxheight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxheight.DefaultText = ""
        Me.txtboxheight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxheight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxheight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxheight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxheight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxheight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxheight.ForeColor = System.Drawing.Color.Black
        Me.txtboxheight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxheight.Location = New System.Drawing.Point(443, 268)
        Me.txtboxheight.Name = "txtboxheight"
        Me.txtboxheight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxheight.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtboxheight.PlaceholderText = "Height (m)"
        Me.txtboxheight.SelectedText = ""
        Me.txtboxheight.Size = New System.Drawing.Size(92, 36)
        Me.txtboxheight.TabIndex = 150
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(439, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Body Mass Index"
        '
        'txtboxweight
        '
        Me.txtboxweight.Animated = True
        Me.txtboxweight.BorderRadius = 5
        Me.txtboxweight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxweight.DefaultText = ""
        Me.txtboxweight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxweight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxweight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxweight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxweight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxweight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxweight.ForeColor = System.Drawing.Color.Black
        Me.txtboxweight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxweight.Location = New System.Drawing.Point(541, 268)
        Me.txtboxweight.Name = "txtboxweight"
        Me.txtboxweight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxweight.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtboxweight.PlaceholderText = "Weight (kg)"
        Me.txtboxweight.SelectedText = ""
        Me.txtboxweight.Size = New System.Drawing.Size(92, 36)
        Me.txtboxweight.TabIndex = 152
        '
        'txtboxBmi
        '
        Me.txtboxBmi.Animated = True
        Me.txtboxBmi.BorderRadius = 5
        Me.txtboxBmi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxBmi.DefaultText = ""
        Me.txtboxBmi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxBmi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxBmi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxBmi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxBmi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxBmi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxBmi.ForeColor = System.Drawing.Color.Black
        Me.txtboxBmi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxBmi.Location = New System.Drawing.Point(642, 268)
        Me.txtboxBmi.Name = "txtboxBmi"
        Me.txtboxBmi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxBmi.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtboxBmi.PlaceholderText = "BMI"
        Me.txtboxBmi.SelectedText = ""
        Me.txtboxBmi.Size = New System.Drawing.Size(92, 36)
        Me.txtboxBmi.TabIndex = 153
        '
        'btnClear
        '
        Me.btnClear.BorderRadius = 5
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(514, 560)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 36)
        Me.btnClear.TabIndex = 154
        Me.btnClear.Text = "Clear"
        '
        'txbxBirthdate
        '
        Me.txbxBirthdate.Animated = True
        Me.txbxBirthdate.BackColor = System.Drawing.Color.Transparent
        Me.txbxBirthdate.BorderColor = System.Drawing.Color.White
        Me.txbxBirthdate.BorderRadius = 5
        Me.txbxBirthdate.Checked = True
        Me.txbxBirthdate.FillColor = System.Drawing.Color.White
        Me.txbxBirthdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxBirthdate.ForeColor = System.Drawing.Color.Black
        Me.txbxBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txbxBirthdate.Location = New System.Drawing.Point(283, 178)
        Me.txbxBirthdate.MaxDate = New Date(2023, 9, 29, 0, 0, 0, 0)
        Me.txbxBirthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txbxBirthdate.Name = "txbxBirthdate"
        Me.txbxBirthdate.Size = New System.Drawing.Size(151, 36)
        Me.txbxBirthdate.TabIndex = 155
        Me.txbxBirthdate.Value = New Date(2023, 9, 29, 0, 0, 0, 0)
        '
        'txbxemergencynumber
        '
        Me.txbxemergencynumber.Animated = True
        Me.txbxemergencynumber.BorderRadius = 5
        Me.txbxemergencynumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbxemergencynumber.DefaultText = ""
        Me.txbxemergencynumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbxemergencynumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbxemergencynumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxemergencynumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbxemergencynumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxemergencynumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbxemergencynumber.ForeColor = System.Drawing.Color.Black
        Me.txbxemergencynumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbxemergencynumber.Location = New System.Drawing.Point(243, 487)
        Me.txbxemergencynumber.Name = "txbxemergencynumber"
        Me.txbxemergencynumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbxemergencynumber.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txbxemergencynumber.PlaceholderText = "Emergency Number"
        Me.txbxemergencynumber.SelectedText = ""
        Me.txbxemergencynumber.Size = New System.Drawing.Size(158, 36)
        Me.txbxemergencynumber.TabIndex = 156
        '
        'RegisterPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 617)
        Me.Controls.Add(Me.txbxemergencynumber)
        Me.Controls.Add(Me.txbxBirthdate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtboxBmi)
        Me.Controls.Add(Me.txtboxweight)
        Me.Controls.Add(Me.txtboxheight)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxMac)
        Me.Controls.Add(Me.txbxemergencyaddress)
        Me.Controls.Add(Me.txbxRelationship)
        Me.Controls.Add(Me.txbxemergencycontactname)
        Me.Controls.Add(Me.txbxward)
        Me.Controls.Add(Me.txbxPhysician)
        Me.Controls.Add(Me.txbxbloodoxygen)
        Me.Controls.Add(Me.txbxtemperature)
        Me.Controls.Add(Me.txbxpulse)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxBloodType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxSex)
        Me.Controls.Add(Me.txbxNationality)
        Me.Controls.Add(Me.txbxPlaceOfBirth)
        Me.Controls.Add(Me.txbxExtensionName)
        Me.Controls.Add(Me.txbxmidname)
        Me.Controls.Add(Me.txbxfirstname)
        Me.Controls.Add(Me.txbxFamilyName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbxCurrentAddress)
        Me.Controls.Add(Me.healthHistory)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterPatient"
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNote As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txbxFamilyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxExtensionName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxmidname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxfirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxPlaceOfBirth As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxCurrentAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxNationality As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxSex As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxBloodType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txbxpulse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxMac As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txbxemergencyaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxRelationship As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxemergencycontactname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxward As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxPhysician As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxbloodoxygen As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxtemperature As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents healthHistory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxBmi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxweight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxheight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txbxBirthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txbxemergencynumber As Guna.UI2.WinForms.Guna2TextBox
End Class
