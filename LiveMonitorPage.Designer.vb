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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.liveMonitoringDTG = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.patientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PatientInfoPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.iconEdit = New System.Windows.Forms.PictureBox()
        Me.txtbxNotes = New System.Windows.Forms.TextBox()
        Me.txtbxDiagnosisHealthHistory = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDiagnonsisHealthHistory = New System.Windows.Forms.Label()
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
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox6 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2Elipse10 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.ReloadBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DismissBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        CType(Me.liveMonitoringDTG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientInfoPanel.SuspendLayout()
        CType(Me.iconEdit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel7.SuspendLayout()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel6.SuspendLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.liveMonitoringDTG
        '
        'liveMonitoringDTG
        '
        Me.liveMonitoringDTG.AllowUserToAddRows = False
        Me.liveMonitoringDTG.AllowUserToDeleteRows = False
        Me.liveMonitoringDTG.AllowUserToOrderColumns = True
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
        Me.liveMonitoringDTG.Location = New System.Drawing.Point(32, 22)
        Me.liveMonitoringDTG.Margin = New System.Windows.Forms.Padding(6)
        Me.liveMonitoringDTG.Name = "liveMonitoringDTG"
        Me.liveMonitoringDTG.ReadOnly = True
        Me.liveMonitoringDTG.RowHeadersVisible = False
        Me.liveMonitoringDTG.RowHeadersWidth = 72
        Me.liveMonitoringDTG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.liveMonitoringDTG.Size = New System.Drawing.Size(623, 868)
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
        Me.patientID.MinimumWidth = 9
        Me.patientID.Name = "patientID"
        Me.patientID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "lastname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 9
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
        Me.PatientInfoPanel.Controls.Add(Me.iconEdit)
        Me.PatientInfoPanel.Controls.Add(Me.txtbxNotes)
        Me.PatientInfoPanel.Controls.Add(Me.txtbxDiagnosisHealthHistory)
        Me.PatientInfoPanel.Controls.Add(Me.Label14)
        Me.PatientInfoPanel.Controls.Add(Me.lblDiagnonsisHealthHistory)
        Me.PatientInfoPanel.Controls.Add(Me.wardNumberLive)
        Me.PatientInfoPanel.Controls.Add(Me.weightPanel)
        Me.PatientInfoPanel.Controls.Add(Me.bmiPanel)
        Me.PatientInfoPanel.Controls.Add(Me.heightPanell)
        Me.PatientInfoPanel.Controls.Add(Me.patientName)
        Me.PatientInfoPanel.Controls.Add(Me.agePanell)
        Me.PatientInfoPanel.Controls.Add(Me.sexPanel)
        Me.PatientInfoPanel.Controls.Add(Me.bloodTypePanel)
        Me.PatientInfoPanel.Location = New System.Drawing.Point(671, 22)
        Me.PatientInfoPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.PatientInfoPanel.Name = "PatientInfoPanel"
        Me.PatientInfoPanel.Size = New System.Drawing.Size(578, 645)
        Me.PatientInfoPanel.TabIndex = 37
        '
        'iconEdit
        '
        Me.iconEdit.BackColor = System.Drawing.Color.Transparent
        Me.iconEdit.BackgroundImage = Global.VitalsMonitoringSystem.My.Resources.Resources.icons8_edit_161
        Me.iconEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconEdit.InitialImage = Global.VitalsMonitoringSystem.My.Resources.Resources.icons8_edit_16
        Me.iconEdit.Location = New System.Drawing.Point(493, 257)
        Me.iconEdit.Name = "iconEdit"
        Me.iconEdit.Size = New System.Drawing.Size(85, 26)
        Me.iconEdit.TabIndex = 56
        Me.iconEdit.TabStop = False
        '
        'txtbxNotes
        '
        Me.txtbxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbxNotes.Location = New System.Drawing.Point(296, 295)
        Me.txtbxNotes.MaxLength = 50000
        Me.txtbxNotes.Multiline = True
        Me.txtbxNotes.Name = "txtbxNotes"
        Me.txtbxNotes.ReadOnly = True
        Me.txtbxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxNotes.Size = New System.Drawing.Size(255, 318)
        Me.txtbxNotes.TabIndex = 54
        '
        'txtbxDiagnosisHealthHistory
        '
        Me.txtbxDiagnosisHealthHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbxDiagnosisHealthHistory.Location = New System.Drawing.Point(27, 295)
        Me.txtbxDiagnosisHealthHistory.MaxLength = 50000
        Me.txtbxDiagnosisHealthHistory.Multiline = True
        Me.txtbxDiagnosisHealthHistory.Name = "txtbxDiagnosisHealthHistory"
        Me.txtbxDiagnosisHealthHistory.ReadOnly = True
        Me.txtbxDiagnosisHealthHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxDiagnosisHealthHistory.Size = New System.Drawing.Size(255, 318)
        Me.txtbxDiagnosisHealthHistory.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Location = New System.Drawing.Point(308, 255)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 30)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Notes:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiagnonsisHealthHistory
        '
        Me.lblDiagnonsisHealthHistory.AutoSize = True
        Me.lblDiagnonsisHealthHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDiagnonsisHealthHistory.ForeColor = System.Drawing.Color.White
        Me.lblDiagnonsisHealthHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDiagnonsisHealthHistory.Location = New System.Drawing.Point(34, 255)
        Me.lblDiagnonsisHealthHistory.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDiagnonsisHealthHistory.Name = "lblDiagnonsisHealthHistory"
        Me.lblDiagnonsisHealthHistory.Size = New System.Drawing.Size(248, 30)
        Me.lblDiagnonsisHealthHistory.TabIndex = 51
        Me.lblDiagnonsisHealthHistory.Text = "Diagnosis/Health History:"
        Me.lblDiagnonsisHealthHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'wardNumberLive
        '
        Me.wardNumberLive.AutoSize = True
        Me.wardNumberLive.BackColor = System.Drawing.Color.Transparent
        Me.wardNumberLive.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardNumberLive.ForeColor = System.Drawing.Color.White
        Me.wardNumberLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.wardNumberLive.Location = New System.Drawing.Point(519, 21)
        Me.wardNumberLive.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.wardNumberLive.Name = "wardNumberLive"
        Me.wardNumberLive.Size = New System.Drawing.Size(33, 37)
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
        Me.weightPanel.Location = New System.Drawing.Point(297, 126)
        Me.weightPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.weightPanel.Name = "weightPanel"
        Me.weightPanel.Size = New System.Drawing.Size(255, 52)
        Me.weightPanel.TabIndex = 47
        '
        'weightLive
        '
        Me.weightLive.AutoSize = True
        Me.weightLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.weightLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.weightLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.weightLive.Location = New System.Drawing.Point(121, 8)
        Me.weightLive.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.weightLive.Name = "weightLive"
        Me.weightLive.Size = New System.Drawing.Size(99, 36)
        Me.weightLive.TabIndex = 45
        Me.weightLive.Text = "weight"
        Me.weightLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(9, 8)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 37)
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
        Me.bmiPanel.Location = New System.Drawing.Point(297, 182)
        Me.bmiPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.bmiPanel.Name = "bmiPanel"
        Me.bmiPanel.Size = New System.Drawing.Size(255, 52)
        Me.bmiPanel.TabIndex = 48
        '
        'bmiLive
        '
        Me.bmiLive.AutoSize = True
        Me.bmiLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.bmiLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bmiLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bmiLive.Location = New System.Drawing.Point(81, 8)
        Me.bmiLive.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.bmiLive.Name = "bmiLive"
        Me.bmiLive.Size = New System.Drawing.Size(62, 36)
        Me.bmiLive.TabIndex = 45
        Me.bmiLive.Text = "bmi"
        Me.bmiLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(9, 8)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 37)
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
        Me.heightPanell.Location = New System.Drawing.Point(297, 70)
        Me.heightPanell.Margin = New System.Windows.Forms.Padding(6)
        Me.heightPanell.Name = "heightPanell"
        Me.heightPanell.Size = New System.Drawing.Size(255, 52)
        Me.heightPanell.TabIndex = 46
        '
        'heightLive
        '
        Me.heightLive.AutoSize = True
        Me.heightLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.heightLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.heightLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.heightLive.Location = New System.Drawing.Point(112, 8)
        Me.heightLive.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.heightLive.Name = "heightLive"
        Me.heightLive.Size = New System.Drawing.Size(94, 36)
        Me.heightLive.TabIndex = 45
        Me.heightLive.Text = "height"
        Me.heightLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'heightPanel
        '
        Me.heightPanel.AutoSize = True
        Me.heightPanel.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heightPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.heightPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.heightPanel.Location = New System.Drawing.Point(9, 8)
        Me.heightPanel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.heightPanel.Name = "heightPanel"
        Me.heightPanel.Size = New System.Drawing.Size(110, 37)
        Me.heightPanel.TabIndex = 44
        Me.heightPanel.Text = "Height: "
        Me.heightPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patientName
        '
        Me.patientName.AutoSize = True
        Me.patientName.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientName.ForeColor = System.Drawing.Color.White
        Me.patientName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.patientName.Location = New System.Drawing.Point(36, 21)
        Me.patientName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.patientName.Name = "patientName"
        Me.patientName.Size = New System.Drawing.Size(166, 37)
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
        Me.agePanell.Location = New System.Drawing.Point(27, 70)
        Me.agePanell.Margin = New System.Windows.Forms.Padding(6)
        Me.agePanell.Name = "agePanell"
        Me.agePanell.Size = New System.Drawing.Size(255, 52)
        Me.agePanell.TabIndex = 45
        '
        'ageLive
        '
        Me.ageLive.AutoSize = True
        Me.ageLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ageLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ageLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ageLive.Location = New System.Drawing.Point(79, 8)
        Me.ageLive.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ageLive.Name = "ageLive"
        Me.ageLive.Size = New System.Drawing.Size(59, 36)
        Me.ageLive.TabIndex = 45
        Me.ageLive.Text = "age"
        Me.ageLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 37)
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
        Me.sexPanel.Location = New System.Drawing.Point(27, 126)
        Me.sexPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.sexPanel.Name = "sexPanel"
        Me.sexPanel.Size = New System.Drawing.Size(255, 52)
        Me.sexPanel.TabIndex = 46
        '
        'sexLive
        '
        Me.sexLive.AutoSize = True
        Me.sexLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.sexLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sexLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sexLive.Location = New System.Drawing.Point(72, 8)
        Me.sexLive.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.sexLive.Name = "sexLive"
        Me.sexLive.Size = New System.Drawing.Size(54, 36)
        Me.sexLive.TabIndex = 45
        Me.sexLive.Text = "sex"
        Me.sexLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(9, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 37)
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
        Me.bloodTypePanel.Location = New System.Drawing.Point(27, 182)
        Me.bloodTypePanel.Margin = New System.Windows.Forms.Padding(6)
        Me.bloodTypePanel.Name = "bloodTypePanel"
        Me.bloodTypePanel.Size = New System.Drawing.Size(255, 52)
        Me.bloodTypePanel.TabIndex = 47
        '
        'bloodtypeLive
        '
        Me.bloodtypeLive.AutoSize = True
        Me.bloodtypeLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.bloodtypeLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bloodtypeLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bloodtypeLive.Location = New System.Drawing.Point(170, 8)
        Me.bloodtypeLive.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.bloodtypeLive.Name = "bloodtypeLive"
        Me.bloodtypeLive.Size = New System.Drawing.Size(41, 36)
        Me.bloodtypeLive.TabIndex = 45
        Me.bloodtypeLive.Text = "bt"
        Me.bloodtypeLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(9, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 37)
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
        Me.vitalsPanel.Location = New System.Drawing.Point(671, 679)
        Me.vitalsPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.vitalsPanel.Name = "vitalsPanel"
        Me.vitalsPanel.Size = New System.Drawing.Size(284, 275)
        Me.vitalsPanel.TabIndex = 49
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2Panel3.Location = New System.Drawing.Point(11, 64)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(260, 63)
        Me.Guna2Panel3.TabIndex = 60
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(4, 0)
        Me.Guna2PictureBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(82, 62)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 1
        Me.Guna2PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(95, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 36)
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
        Me.Guna2Panel2.Location = New System.Drawing.Point(11, 132)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(260, 63)
        Me.Guna2Panel2.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(99, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 36)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "37 °C"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(12, 6)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(62, 53)
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
        Me.Guna2Panel1.Location = New System.Drawing.Point(11, 200)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(260, 63)
        Me.Guna2Panel1.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(95, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 36)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "100%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(62, 53)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(38, 15)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(192, 36)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Patient's Vitals"
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
        Me.othersPanel.Controls.Add(Me.Guna2Panel7)
        Me.othersPanel.Controls.Add(Me.Guna2Panel6)
        Me.othersPanel.Controls.Add(Me.Label15)
        Me.othersPanel.Location = New System.Drawing.Point(964, 679)
        Me.othersPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.othersPanel.Name = "othersPanel"
        Me.othersPanel.Size = New System.Drawing.Size(284, 275)
        Me.othersPanel.TabIndex = 50
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel5.Controls.Add(Me.Label12)
        Me.Guna2Panel5.Controls.Add(Me.Guna2PictureBox4)
        Me.Guna2Panel5.Location = New System.Drawing.Point(11, 200)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(260, 63)
        Me.Guna2Panel5.TabIndex = 56
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(105, 13)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 36)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "100%"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.Image = CType(resources.GetObject("Guna2PictureBox4.Image"), System.Drawing.Image)
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(16, 11)
        Me.Guna2PictureBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(62, 53)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox4.TabIndex = 1
        Me.Guna2PictureBox4.TabStop = False
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel7.Controls.Add(Me.Label11)
        Me.Guna2Panel7.Controls.Add(Me.Guna2PictureBox6)
        Me.Guna2Panel7.Location = New System.Drawing.Point(11, 64)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(260, 63)
        Me.Guna2Panel7.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(108, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 36)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Inactive"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox6
        '
        Me.Guna2PictureBox6.Image = CType(resources.GetObject("Guna2PictureBox6.Image"), System.Drawing.Image)
        Me.Guna2PictureBox6.ImageRotate = 0!
        Me.Guna2PictureBox6.Location = New System.Drawing.Point(15, 6)
        Me.Guna2PictureBox6.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2PictureBox6.Name = "Guna2PictureBox6"
        Me.Guna2PictureBox6.Size = New System.Drawing.Size(62, 53)
        Me.Guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox6.TabIndex = 0
        Me.Guna2PictureBox6.TabStop = False
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel6.Controls.Add(Me.Label10)
        Me.Guna2Panel6.Controls.Add(Me.Guna2PictureBox5)
        Me.Guna2Panel6.Location = New System.Drawing.Point(11, 132)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(260, 63)
        Me.Guna2Panel6.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(105, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 36)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "100%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = CType(resources.GetObject("Guna2PictureBox5.Image"), System.Drawing.Image)
        Me.Guna2PictureBox5.ImageRotate = 0!
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(16, 6)
        Me.Guna2PictureBox5.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(62, 53)
        Me.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox5.TabIndex = 0
        Me.Guna2PictureBox5.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(54, 14)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 36)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Device Status"
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
        Me.ReloadBtn.Location = New System.Drawing.Point(326, 899)
        Me.ReloadBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.ReloadBtn.Name = "ReloadBtn"
        Me.ReloadBtn.Size = New System.Drawing.Size(160, 52)
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
        Me.DismissBtn.Location = New System.Drawing.Point(494, 899)
        Me.DismissBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.DismissBtn.Name = "DismissBtn"
        Me.DismissBtn.Size = New System.Drawing.Size(160, 52)
        Me.DismissBtn.TabIndex = 52
        Me.DismissBtn.Text = "Dismiss"
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LiveMonitorPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 984)
        Me.Controls.Add(Me.DismissBtn)
        Me.Controls.Add(Me.ReloadBtn)
        Me.Controls.Add(Me.othersPanel)
        Me.Controls.Add(Me.liveMonitoringDTG)
        Me.Controls.Add(Me.vitalsPanel)
        Me.Controls.Add(Me.PatientInfoPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "LiveMonitorPage"
        Me.Text = "LiveMonitorPage"
        CType(Me.liveMonitoringDTG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientInfoPanel.ResumeLayout(False)
        Me.PatientInfoPanel.PerformLayout()
        CType(Me.iconEdit, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel7.PerformLayout()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
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
    Friend WithEvents Guna2Elipse9 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents liveMonitoringDTG As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents othersPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse10 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ReloadBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DismissBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents wardNumberLive As Label
    Friend WithEvents patientID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents agePanell As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ageLive As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2PictureBox6 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblDiagnonsisHealthHistory As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbxNotes As TextBox
    Friend WithEvents txtbxDiagnosisHealthHistory As TextBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents iconEdit As PictureBox
End Class
