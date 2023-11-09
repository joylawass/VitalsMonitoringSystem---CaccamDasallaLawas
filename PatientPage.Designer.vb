<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTGList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AddPatientBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ReloadBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.UpdatePatientButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ActivePatientBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DismissedPatientBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysiciansName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dev_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DTGList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.DarkGray
        Me.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsername.Location = New System.Drawing.Point(82, 516)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(70, 16)
        Me.lblUsername.TabIndex = 32
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 516)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTGList
        '
        Me.DTGList.AllowUserToAddRows = False
        Me.DTGList.AllowUserToDeleteRows = False
        Me.DTGList.AllowUserToResizeColumns = False
        Me.DTGList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DTGList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DTGList.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DTGList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DTGList.ColumnHeadersHeight = 28
        Me.DTGList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientID, Me.LastName, Me.FirstName, Me.WardNumber, Me.PhysiciansName, Me.Dev_ID})
        Me.DTGList.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTGList.DefaultCellStyle = DataGridViewCellStyle3
        Me.DTGList.GridColor = System.Drawing.Color.White
        Me.DTGList.Location = New System.Drawing.Point(29, 66)
        Me.DTGList.Name = "DTGList"
        Me.DTGList.ReadOnly = True
        Me.DTGList.RowHeadersVisible = False
        Me.DTGList.Size = New System.Drawing.Size(639, 404)
        Me.DTGList.TabIndex = 34
        Me.DTGList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DTGList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DTGList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DTGList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DTGList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DTGList.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.DTGList.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.DTGList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTGList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DTGList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DTGList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTGList.ThemeStyle.HeaderStyle.Height = 28
        Me.DTGList.ThemeStyle.ReadOnly = True
        Me.DTGList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DTGList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DTGList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DTGList.ThemeStyle.RowsStyle.Height = 22
        Me.DTGList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTGList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AddPatientBtn
        '
        Me.AddPatientBtn.BorderRadius = 5
        Me.AddPatientBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddPatientBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddPatientBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddPatientBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddPatientBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AddPatientBtn.ForeColor = System.Drawing.Color.White
        Me.AddPatientBtn.Location = New System.Drawing.Point(559, 32)
        Me.AddPatientBtn.Name = "AddPatientBtn"
        Me.AddPatientBtn.Size = New System.Drawing.Size(109, 28)
        Me.AddPatientBtn.TabIndex = 35
        Me.AddPatientBtn.Text = "Add Patient"
        '
        'ReloadBtn
        '
        Me.ReloadBtn.BorderRadius = 5
        Me.ReloadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ReloadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ReloadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ReloadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ReloadBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ReloadBtn.ForeColor = System.Drawing.Color.White
        Me.ReloadBtn.Location = New System.Drawing.Point(29, 32)
        Me.ReloadBtn.Name = "ReloadBtn"
        Me.ReloadBtn.Size = New System.Drawing.Size(79, 28)
        Me.ReloadBtn.TabIndex = 38
        Me.ReloadBtn.Text = "Reload"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.DTGList
        '
        'UpdatePatientButton
        '
        Me.UpdatePatientButton.BorderRadius = 5
        Me.UpdatePatientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UpdatePatientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UpdatePatientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UpdatePatientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UpdatePatientButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UpdatePatientButton.ForeColor = System.Drawing.Color.White
        Me.UpdatePatientButton.Location = New System.Drawing.Point(537, 476)
        Me.UpdatePatientButton.Name = "UpdatePatientButton"
        Me.UpdatePatientButton.Size = New System.Drawing.Size(131, 28)
        Me.UpdatePatientButton.TabIndex = 39
        Me.UpdatePatientButton.Text = "Update Patient"
        '
        'ActivePatientBtn
        '
        Me.ActivePatientBtn.BorderRadius = 5
        Me.ActivePatientBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ActivePatientBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ActivePatientBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ActivePatientBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ActivePatientBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ActivePatientBtn.ForeColor = System.Drawing.Color.White
        Me.ActivePatientBtn.Location = New System.Drawing.Point(187, 476)
        Me.ActivePatientBtn.Name = "ActivePatientBtn"
        Me.ActivePatientBtn.Size = New System.Drawing.Size(128, 28)
        Me.ActivePatientBtn.TabIndex = 40
        Me.ActivePatientBtn.Text = "Active Patients"
        '
        'DismissedPatientBtn
        '
        Me.DismissedPatientBtn.BorderRadius = 5
        Me.DismissedPatientBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DismissedPatientBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DismissedPatientBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DismissedPatientBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DismissedPatientBtn.FillColor = System.Drawing.Color.Red
        Me.DismissedPatientBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DismissedPatientBtn.ForeColor = System.Drawing.Color.White
        Me.DismissedPatientBtn.Location = New System.Drawing.Point(29, 476)
        Me.DismissedPatientBtn.Name = "DismissedPatientBtn"
        Me.DismissedPatientBtn.Size = New System.Drawing.Size(152, 28)
        Me.DismissedPatientBtn.TabIndex = 41
        Me.DismissedPatientBtn.Text = "Dismissed Patients"
        '
        'PatientID
        '
        Me.PatientID.FillWeight = 99.53053!
        Me.PatientID.HeaderText = "ID"
        Me.PatientID.Name = "PatientID"
        Me.PatientID.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "lastname"
        Me.LastName.FillWeight = 100.5994!
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "firstname"
        Me.FirstName.FillWeight = 99.44451!
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'WardNumber
        '
        Me.WardNumber.DataPropertyName = "ward"
        Me.WardNumber.FillWeight = 100.5335!
        Me.WardNumber.HeaderText = "Ward Number"
        Me.WardNumber.Name = "WardNumber"
        Me.WardNumber.ReadOnly = True
        '
        'PhysiciansName
        '
        Me.PhysiciansName.DataPropertyName = "physician"
        Me.PhysiciansName.FillWeight = 99.39546!
        Me.PhysiciansName.HeaderText = "Physician's Name"
        Me.PhysiciansName.Name = "PhysiciansName"
        Me.PhysiciansName.ReadOnly = True
        '
        'Dev_ID
        '
        Me.Dev_ID.DataPropertyName = "Device ID"
        Me.Dev_ID.FillWeight = 100.4967!
        Me.Dev_ID.HeaderText = "Device_ID"
        Me.Dev_ID.Name = "Dev_ID"
        Me.Dev_ID.ReadOnly = True
        '
        'PatientPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(697, 541)
        Me.Controls.Add(Me.DismissedPatientBtn)
        Me.Controls.Add(Me.ActivePatientBtn)
        Me.Controls.Add(Me.UpdatePatientButton)
        Me.Controls.Add(Me.ReloadBtn)
        Me.Controls.Add(Me.AddPatientBtn)
        Me.Controls.Add(Me.DTGList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PatientPage"
        Me.Text = "PatientPage"
        CType(Me.DTGList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTGList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AddPatientBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ReloadBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UpdatePatientButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ActivePatientBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DismissedPatientBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents WardNumber As DataGridViewTextBoxColumn
    Friend WithEvents PhysiciansName As DataGridViewTextBoxColumn
    Friend WithEvents Dev_ID As DataGridViewTextBoxColumn
End Class
