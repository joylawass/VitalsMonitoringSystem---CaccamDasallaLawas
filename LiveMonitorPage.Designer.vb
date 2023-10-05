<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LiveMonitorPage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiveMonitorPage))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.liveMonitoringDTG = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.patientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PatientInfoPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.wardNumberLive = New System.Windows.Forms.Label()
        Me.weightPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.weightLive = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bmiPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.bmiLive = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.heightPanell = New Guna.UI2.WinForms.Guna2Panel()
        Me.heightLive = New System.Windows.Forms.Label()
        Me.heightPanel = New System.Windows.Forms.Label()
        Me.patientName = New System.Windows.Forms.Label()
        Me.agePanell = New Guna.UI2.WinForms.Guna2Panel()
        Me.ageLive = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sexPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.sexLive = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bloodTypePanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.bloodtypeLive = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse7 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse8 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse6 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.vitalsPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Guna2Elipse9 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.othersPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox6 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2Elipse10 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.ReloadBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DismissBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.liveMonitoringDTG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientInfoPanel.SuspendLayout()
        Me.weightPanel.SuspendLayout()
        Me.bmiPanel.SuspendLayout()
        Me.heightPanell.SuspendLayout()
        Me.agePanell.SuspendLayout()
        Me.sexPanel.SuspendLayout()
        Me.bloodTypePanel.SuspendLayout()
        Me.vitalsPanel.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.othersPanel.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel6.SuspendLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel7.SuspendLayout()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 508)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.DarkGray
        Me.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsername.Location = New System.Drawing.Point(82, 508)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(70, 16)
        Me.lblUsername.TabIndex = 34
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.liveMonitoringDTG
        '
        'liveMonitoringDTG
        '
        Me.liveMonitoringDTG.AllowUserToAddRows = False
        Me.liveMonitoringDTG.AllowUserToDeleteRows = False
        Me.liveMonitoringDTG.AllowUserToResizeColumns = False
        Me.liveMonitoringDTG.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.liveMonitoringDTG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.liveMonitoringDTG.BackgroundColor = System.Drawing.SystemColors.Control
        Me.liveMonitoringDTG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.liveMonitoringDTG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.liveMonitoringDTG.ColumnHeadersHeight = 28
        Me.liveMonitoringDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.liveMonitoringDTG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.patientID, Me.DataGridViewTextBoxColumn2})
        Me.liveMonitoringDTG.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.liveMonitoringDTG.DefaultCellStyle = DataGridViewCellStyle3
        Me.liveMonitoringDTG.GridColor = System.Drawing.Color.White
        Me.liveMonitoringDTG.Location = New System.Drawing.Point(12, 12)
        Me.liveMonitoringDTG.Name = "liveMonitoringDTG"
        Me.liveMonitoringDTG.ReadOnly = True
        Me.liveMonitoringDTG.RowHeadersVisible = False
        Me.liveMonitoringDTG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.liveMonitoringDTG.Size = New System.Drawing.Size(340, 444)
        Me.liveMonitoringDTG.TabIndex = 50
        Me.liveMonitoringDTG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.liveMonitoringDTG.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.liveMonitoringDTG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.liveMonitoringDTG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.liveMonitoringDTG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.liveMonitoringDTG.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.liveMonitoringDTG.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.liveMonitoringDTG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.liveMonitoringDTG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.liveMonitoringDTG.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.liveMonitoringDTG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.liveMonitoringDTG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.liveMonitoringDTG.ThemeStyle.HeaderStyle.Height = 28
        Me.liveMonitoringDTG.ThemeStyle.ReadOnly = True
        Me.liveMonitoringDTG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.liveMonitoringDTG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.liveMonitoringDTG.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.liveMonitoringDTG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.liveMonitoringDTG.ThemeStyle.RowsStyle.Height = 22
        Me.liveMonitoringDTG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.liveMonitoringDTG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'patientID
        '
        Me.patientID.DataPropertyName = "patientID"
        Me.patientID.HeaderText = "Patient ID"
        Me.patientID.Name = "patientID"
        Me.patientID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "lastname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.PatientInfoPanel
        '
        'PatientInfoPanel
        '
        Me.PatientInfoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PatientInfoPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.PatientInfoPanel.Controls.Add(Me.wardNumberLive)
        Me.PatientInfoPanel.Controls.Add(Me.weightPanel)
        Me.PatientInfoPanel.Controls.Add(Me.bmiPanel)
        Me.PatientInfoPanel.Controls.Add(Me.heightPanell)
        Me.PatientInfoPanel.Controls.Add(Me.patientName)
        Me.PatientInfoPanel.Controls.Add(Me.agePanell)
        Me.PatientInfoPanel.Controls.Add(Me.sexPanel)
        Me.PatientInfoPanel.Controls.Add(Me.bloodTypePanel)
        Me.PatientInfoPanel.Location = New System.Drawing.Point(374, 12)
        Me.PatientInfoPanel.Name = "PatientInfoPanel"
        Me.PatientInfoPanel.Size = New System.Drawing.Size(315, 173)
        Me.PatientInfoPanel.TabIndex = 37
        '
        'wardNumberLive
        '
        Me.wardNumberLive.AutoSize = True
        Me.wardNumberLive.BackColor = System.Drawing.Color.Transparent
        Me.wardNumberLive.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardNumberLive.ForeColor = System.Drawing.Color.White
        Me.wardNumberLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.wardNumberLive.Location = New System.Drawing.Point(276, 5)
        Me.wardNumberLive.Name = "wardNumberLive"
        Me.wardNumberLive.Size = New System.Drawing.Size(23, 25)
        Me.wardNumberLive.TabIndex = 50
        Me.wardNumberLive.Text = "#"
        Me.wardNumberLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'weightPanel
        '
        Me.weightPanel.BackColor = System.Drawing.Color.White
        Me.weightPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.weightPanel.Controls.Add(Me.weightLive)
        Me.weightPanel.Controls.Add(Me.Label6)
        Me.weightPanel.Location = New System.Drawing.Point(167, 83)
        Me.weightPanel.Name = "weightPanel"
        Me.weightPanel.Size = New System.Drawing.Size(126, 35)
        Me.weightPanel.TabIndex = 47
        '
        'weightLive
        '
        Me.weightLive.AutoSize = True
        Me.weightLive.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.weightLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.weightLive.Location = New System.Drawing.Point(66, 7)
        Me.weightLive.Name = "weightLive"
        Me.weightLive.Size = New System.Drawing.Size(57, 20)
        Me.weightLive.TabIndex = 45
        Me.weightLive.Text = "weight"
        Me.weightLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(5, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Weight: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bmiPanel
        '
        Me.bmiPanel.BackColor = System.Drawing.Color.White
        Me.bmiPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.bmiPanel.Controls.Add(Me.bmiLive)
        Me.bmiPanel.Controls.Add(Me.Label7)
        Me.bmiPanel.Location = New System.Drawing.Point(167, 124)
        Me.bmiPanel.Name = "bmiPanel"
        Me.bmiPanel.Size = New System.Drawing.Size(126, 35)
        Me.bmiPanel.TabIndex = 48
        '
        'bmiLive
        '
        Me.bmiLive.AutoSize = True
        Me.bmiLive.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bmiLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bmiLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bmiLive.Location = New System.Drawing.Point(44, 7)
        Me.bmiLive.Name = "bmiLive"
        Me.bmiLive.Size = New System.Drawing.Size(36, 20)
        Me.bmiLive.TabIndex = 45
        Me.bmiLive.Text = "bmi"
        Me.bmiLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(5, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "BMI:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'heightPanell
        '
        Me.heightPanell.BackColor = System.Drawing.Color.White
        Me.heightPanell.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.heightPanell.Controls.Add(Me.heightLive)
        Me.heightPanell.Controls.Add(Me.heightPanel)
        Me.heightPanell.Location = New System.Drawing.Point(167, 42)
        Me.heightPanell.Name = "heightPanell"
        Me.heightPanell.Size = New System.Drawing.Size(126, 35)
        Me.heightPanell.TabIndex = 46
        '
        'heightLive
        '
        Me.heightLive.AutoSize = True
        Me.heightLive.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heightLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.heightLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.heightLive.Location = New System.Drawing.Point(61, 7)
        Me.heightLive.Name = "heightLive"
        Me.heightLive.Size = New System.Drawing.Size(54, 20)
        Me.heightLive.TabIndex = 45
        Me.heightLive.Text = "height"
        Me.heightLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'heightPanel
        '
        Me.heightPanel.AutoSize = True
        Me.heightPanel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heightPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.heightPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.heightPanel.Location = New System.Drawing.Point(5, 7)
        Me.heightPanel.Name = "heightPanel"
        Me.heightPanel.Size = New System.Drawing.Size(61, 20)
        Me.heightPanel.TabIndex = 44
        Me.heightPanel.Text = "Height: "
        Me.heightPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patientName
        '
        Me.patientName.AutoSize = True
        Me.patientName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientName.ForeColor = System.Drawing.Color.White
        Me.patientName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.patientName.Location = New System.Drawing.Point(18, 10)
        Me.patientName.Name = "patientName"
        Me.patientName.Size = New System.Drawing.Size(93, 20)
        Me.patientName.TabIndex = 44
        Me.patientName.Text = "FULL NAME"
        Me.patientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'agePanell
        '
        Me.agePanell.BackColor = System.Drawing.Color.White
        Me.agePanell.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.agePanell.Controls.Add(Me.ageLive)
        Me.agePanell.Controls.Add(Me.Label2)
        Me.agePanell.Location = New System.Drawing.Point(22, 42)
        Me.agePanell.Name = "agePanell"
        Me.agePanell.Size = New System.Drawing.Size(126, 35)
        Me.agePanell.TabIndex = 45
        '
        'ageLive
        '
        Me.ageLive.AutoSize = True
        Me.ageLive.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ageLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ageLive.Location = New System.Drawing.Point(43, 7)
        Me.ageLive.Name = "ageLive"
        Me.ageLive.Size = New System.Drawing.Size(34, 20)
        Me.ageLive.TabIndex = 45
        Me.ageLive.Text = "age"
        Me.ageLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(5, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Age:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sexPanel
        '
        Me.sexPanel.BackColor = System.Drawing.Color.White
        Me.sexPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.sexPanel.Controls.Add(Me.sexLive)
        Me.sexPanel.Controls.Add(Me.Label3)
        Me.sexPanel.Location = New System.Drawing.Point(22, 83)
        Me.sexPanel.Name = "sexPanel"
        Me.sexPanel.Size = New System.Drawing.Size(126, 35)
        Me.sexPanel.TabIndex = 46
        '
        'sexLive
        '
        Me.sexLive.AutoSize = True
        Me.sexLive.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sexLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sexLive.Location = New System.Drawing.Point(39, 7)
        Me.sexLive.Name = "sexLive"
        Me.sexLive.Size = New System.Drawing.Size(32, 20)
        Me.sexLive.TabIndex = 45
        Me.sexLive.Text = "sex"
        Me.sexLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(5, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 20)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Sex:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bloodTypePanel
        '
        Me.bloodTypePanel.BackColor = System.Drawing.Color.White
        Me.bloodTypePanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.bloodTypePanel.Controls.Add(Me.bloodtypeLive)
        Me.bloodTypePanel.Controls.Add(Me.Label4)
        Me.bloodTypePanel.Location = New System.Drawing.Point(22, 124)
        Me.bloodTypePanel.Name = "bloodTypePanel"
        Me.bloodTypePanel.Size = New System.Drawing.Size(126, 35)
        Me.bloodTypePanel.TabIndex = 47
        '
        'bloodtypeLive
        '
        Me.bloodtypeLive.AutoSize = True
        Me.bloodtypeLive.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloodtypeLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bloodtypeLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bloodtypeLive.Location = New System.Drawing.Point(93, 7)
        Me.bloodtypeLive.Name = "bloodtypeLive"
        Me.bloodtypeLive.Size = New System.Drawing.Size(24, 20)
        Me.bloodtypeLive.TabIndex = 45
        Me.bloodtypeLive.Text = "bt"
        Me.bloodtypeLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(5, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Blood Type:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.TargetControl = Me.sexPanel
        '
        'Guna2Elipse5
        '
        Me.Guna2Elipse5.TargetControl = Me.bloodTypePanel
        '
        'Guna2Elipse7
        '
        Me.Guna2Elipse7.TargetControl = Me.weightPanel
        '
        'Guna2Elipse8
        '
        Me.Guna2Elipse8.TargetControl = Me.bmiPanel
        '
        'Guna2Elipse6
        '
        Me.Guna2Elipse6.TargetControl = Me.heightPanell
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.TargetControl = Me.agePanell
        '
        'vitalsPanel
        '
        Me.vitalsPanel.BackColor = System.Drawing.SystemColors.Control
        Me.vitalsPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.vitalsPanel.Controls.Add(Me.Guna2Panel3)
        Me.vitalsPanel.Controls.Add(Me.Guna2Panel2)
        Me.vitalsPanel.Controls.Add(Me.Guna2Panel1)
        Me.vitalsPanel.Controls.Add(Me.Label19)
        Me.vitalsPanel.Location = New System.Drawing.Point(374, 191)
        Me.vitalsPanel.Name = "vitalsPanel"
        Me.vitalsPanel.Size = New System.Drawing.Size(155, 299)
        Me.vitalsPanel.TabIndex = 49
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Location = New System.Drawing.Point(6, 61)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(142, 58)
        Me.Guna2Panel3.TabIndex = 48
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(55, 52)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 1
        Me.Guna2PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(51, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 28)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "100 bpm"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel2.Controls.Add(Me.Label8)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(6, 137)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(142, 58)
        Me.Guna2Panel2.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(64, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 28)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "37 °C"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(55, 52)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 0
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(6, 217)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(142, 58)
        Me.Guna2Panel1.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(64, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 28)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "100%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(55, 52)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(9, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(136, 20)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "PATIENT'S VITALS"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Elipse9
        '
        Me.Guna2Elipse9.TargetControl = Me.vitalsPanel
        '
        'othersPanel
        '
        Me.othersPanel.BackColor = System.Drawing.SystemColors.Control
        Me.othersPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.othersPanel.Controls.Add(Me.Guna2Panel5)
        Me.othersPanel.Controls.Add(Me.Guna2Panel6)
        Me.othersPanel.Controls.Add(Me.Guna2Panel7)
        Me.othersPanel.Controls.Add(Me.Label15)
        Me.othersPanel.Location = New System.Drawing.Point(534, 191)
        Me.othersPanel.Name = "othersPanel"
        Me.othersPanel.Size = New System.Drawing.Size(155, 299)
        Me.othersPanel.TabIndex = 50
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel5.Controls.Add(Me.Label12)
        Me.Guna2Panel5.Controls.Add(Me.Guna2PictureBox4)
        Me.Guna2Panel5.Location = New System.Drawing.Point(6, 217)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(142, 58)
        Me.Guna2Panel5.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(69, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 28)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "100%"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.Image = CType(resources.GetObject("Guna2PictureBox4.Image"), System.Drawing.Image)
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(55, 52)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox4.TabIndex = 1
        Me.Guna2PictureBox4.TabStop = False
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel6.Controls.Add(Me.Label10)
        Me.Guna2Panel6.Controls.Add(Me.Guna2PictureBox5)
        Me.Guna2Panel6.Location = New System.Drawing.Point(6, 137)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(142, 58)
        Me.Guna2Panel6.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(69, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 28)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "100%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = CType(resources.GetObject("Guna2PictureBox5.Image"), System.Drawing.Image)
        Me.Guna2PictureBox5.ImageRotate = 0!
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(55, 52)
        Me.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox5.TabIndex = 0
        Me.Guna2PictureBox5.TabStop = False
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel7.Controls.Add(Me.Label11)
        Me.Guna2Panel7.Controls.Add(Me.Guna2PictureBox6)
        Me.Guna2Panel7.Location = New System.Drawing.Point(6, 61)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(142, 58)
        Me.Guna2Panel7.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(60, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 28)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Inactive"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox6
        '
        Me.Guna2PictureBox6.Image = CType(resources.GetObject("Guna2PictureBox6.Image"), System.Drawing.Image)
        Me.Guna2PictureBox6.ImageRotate = 0!
        Me.Guna2PictureBox6.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox6.Name = "Guna2PictureBox6"
        Me.Guna2PictureBox6.Size = New System.Drawing.Size(55, 52)
        Me.Guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox6.TabIndex = 0
        Me.Guna2PictureBox6.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(18, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 20)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "DEVICE STATUS"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Elipse10
        '
        Me.Guna2Elipse10.TargetControl = Me.othersPanel
        '
        'ReloadBtn
        '
        Me.ReloadBtn.BorderRadius = 5
        Me.ReloadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ReloadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ReloadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ReloadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ReloadBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ReloadBtn.ForeColor = System.Drawing.Color.White
        Me.ReloadBtn.Location = New System.Drawing.Point(172, 462)
        Me.ReloadBtn.Name = "ReloadBtn"
        Me.ReloadBtn.Size = New System.Drawing.Size(87, 28)
        Me.ReloadBtn.TabIndex = 51
        Me.ReloadBtn.Text = "Reload"
        '
        'DismissBtn
        '
        Me.DismissBtn.BorderRadius = 5
        Me.DismissBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DismissBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DismissBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DismissBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DismissBtn.FillColor = System.Drawing.Color.Red
        Me.DismissBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.DismissBtn.ForeColor = System.Drawing.Color.White
        Me.DismissBtn.Location = New System.Drawing.Point(265, 462)
        Me.DismissBtn.Name = "DismissBtn"
        Me.DismissBtn.Size = New System.Drawing.Size(87, 28)
        Me.DismissBtn.TabIndex = 52
        Me.DismissBtn.Text = "Dismiss"
        '
        'LiveMonitorPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(697, 533)
        Me.Controls.Add(Me.DismissBtn)
        Me.Controls.Add(Me.ReloadBtn)
        Me.Controls.Add(Me.othersPanel)
        Me.Controls.Add(Me.liveMonitoringDTG)
        Me.Controls.Add(Me.vitalsPanel)
        Me.Controls.Add(Me.PatientInfoPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LiveMonitorPage"
        Me.Text = "LiveMonitorPage"
        CType(Me.liveMonitoringDTG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientInfoPanel.ResumeLayout(False)
        Me.PatientInfoPanel.PerformLayout()
        Me.weightPanel.ResumeLayout(False)
        Me.weightPanel.PerformLayout()
        Me.bmiPanel.ResumeLayout(False)
        Me.bmiPanel.PerformLayout()
        Me.heightPanell.ResumeLayout(False)
        Me.heightPanell.PerformLayout()
        Me.agePanell.ResumeLayout(False)
        Me.agePanell.PerformLayout()
        Me.sexPanel.ResumeLayout(False)
        Me.sexPanel.PerformLayout()
        Me.bloodTypePanel.ResumeLayout(False)
        Me.bloodTypePanel.PerformLayout()
        Me.vitalsPanel.ResumeLayout(False)
        Me.vitalsPanel.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.othersPanel.ResumeLayout(False)
        Me.othersPanel.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel7.PerformLayout()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PatientInfoPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents patientName As Label
    Friend WithEvents sexPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents bloodTypePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents bmiPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse7 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents weightPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Elipse8 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents heightPanel As Label
    Friend WithEvents heightPanell As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse6 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents sexLive As Label
    Friend WithEvents bloodtypeLive As Label
    Friend WithEvents weightLive As Label
    Friend WithEvents heightLive As Label
    Friend WithEvents bmiLive As Label
    Friend WithEvents vitalsPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Guna2Elipse9 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents liveMonitoringDTG As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents othersPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox6 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse10 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label15 As Label
    Friend WithEvents ReloadBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DismissBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents wardNumberLive As Label
    Friend WithEvents patientID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents agePanell As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ageLive As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
