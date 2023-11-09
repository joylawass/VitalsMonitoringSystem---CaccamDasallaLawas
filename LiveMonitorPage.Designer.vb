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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiveMonitorPage))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.liveMonitoringDTG = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.patientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PatientInfoPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.weightPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.weightLive = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bmiPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.bmiLive = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.heightPanell = New Guna.UI2.WinForms.Guna2Panel()
        Me.heightLive = New System.Windows.Forms.Label()
        Me.heightPanel = New System.Windows.Forms.Label()
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
        Me.Guna2Elipse10 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.DiagnosisPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.historyLivePanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.historyLive = New System.Windows.Forms.Label()
        Me.lblDiagnonsisHealthHistory = New System.Windows.Forms.Label()
        Me.ReloadBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DismissBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.othersPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbRFID = New System.Windows.Forms.Label()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbHall = New System.Windows.Forms.Label()
        Me.Guna2PictureBox6 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbBatt = New System.Windows.Forms.Label()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.vitalsPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbBpm = New System.Windows.Forms.Label()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbTemp = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbO2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.wardNumberLive = New System.Windows.Forms.Label()
        Me.patientName = New System.Windows.Forms.Label()
        Me.Guna2Elipse11 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse12 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.notestxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NotesPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Guna2Elipse16 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse17 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon3 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon4 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon5 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.liveMonitoringDTG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientInfoPanel.SuspendLayout()
        Me.weightPanel.SuspendLayout()
        Me.bmiPanel.SuspendLayout()
        Me.heightPanell.SuspendLayout()
        Me.agePanell.SuspendLayout()
        Me.sexPanel.SuspendLayout()
        Me.bloodTypePanel.SuspendLayout()
        Me.DiagnosisPanel.SuspendLayout()
        Me.historyLivePanel.SuspendLayout()
        Me.othersPanel.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel7.SuspendLayout()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel6.SuspendLayout()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.vitalsPanel.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.NotesPanel.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
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
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.liveMonitoringDTG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.liveMonitoringDTG.BackgroundColor = System.Drawing.SystemColors.Control
        Me.liveMonitoringDTG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.liveMonitoringDTG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.liveMonitoringDTG.ColumnHeadersHeight = 28
        Me.liveMonitoringDTG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.patientID, Me.DataGridViewTextBoxColumn2})
        Me.liveMonitoringDTG.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.liveMonitoringDTG.DefaultCellStyle = DataGridViewCellStyle15
        Me.liveMonitoringDTG.GridColor = System.Drawing.Color.White
        Me.liveMonitoringDTG.Location = New System.Drawing.Point(21, 12)
        Me.liveMonitoringDTG.Name = "liveMonitoringDTG"
        Me.liveMonitoringDTG.ReadOnly = True
        Me.liveMonitoringDTG.RowHeadersVisible = False
        Me.liveMonitoringDTG.RowHeadersWidth = 72
        Me.liveMonitoringDTG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.liveMonitoringDTG.Size = New System.Drawing.Size(337, 283)
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
        Me.liveMonitoringDTG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
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
        Me.patientID.HeaderText = "ID"
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
        Me.PatientInfoPanel.Controls.Add(Me.weightPanel)
        Me.PatientInfoPanel.Controls.Add(Me.bmiPanel)
        Me.PatientInfoPanel.Controls.Add(Me.heightPanell)
        Me.PatientInfoPanel.Controls.Add(Me.agePanell)
        Me.PatientInfoPanel.Controls.Add(Me.sexPanel)
        Me.PatientInfoPanel.Controls.Add(Me.bloodTypePanel)
        Me.PatientInfoPanel.Location = New System.Drawing.Point(365, 194)
        Me.PatientInfoPanel.Name = "PatientInfoPanel"
        Me.PatientInfoPanel.Size = New System.Drawing.Size(312, 101)
        Me.PatientInfoPanel.TabIndex = 37
        '
        'weightPanel
        '
        Me.weightPanel.BackColor = System.Drawing.Color.White
        Me.weightPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.weightPanel.Controls.Add(Me.weightLive)
        Me.weightPanel.Controls.Add(Me.Label6)
        Me.weightPanel.Location = New System.Drawing.Point(157, 36)
        Me.weightPanel.Name = "weightPanel"
        Me.weightPanel.Size = New System.Drawing.Size(149, 28)
        Me.weightPanel.TabIndex = 47
        '
        'weightLive
        '
        Me.weightLive.AutoSize = True
        Me.weightLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.weightLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.weightLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.weightLive.Location = New System.Drawing.Point(66, 4)
        Me.weightLive.Name = "weightLive"
        Me.weightLive.Size = New System.Drawing.Size(13, 20)
        Me.weightLive.TabIndex = 45
        Me.weightLive.Text = " "
        Me.weightLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(5, 4)
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
        Me.bmiPanel.Location = New System.Drawing.Point(158, 66)
        Me.bmiPanel.Name = "bmiPanel"
        Me.bmiPanel.Size = New System.Drawing.Size(148, 28)
        Me.bmiPanel.TabIndex = 48
        '
        'bmiLive
        '
        Me.bmiLive.AutoSize = True
        Me.bmiLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.bmiLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bmiLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bmiLive.Location = New System.Drawing.Point(44, 4)
        Me.bmiLive.Name = "bmiLive"
        Me.bmiLive.Size = New System.Drawing.Size(13, 20)
        Me.bmiLive.TabIndex = 45
        Me.bmiLive.Text = " "
        Me.bmiLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(5, 4)
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
        Me.heightPanell.Location = New System.Drawing.Point(157, 6)
        Me.heightPanell.Name = "heightPanell"
        Me.heightPanell.Size = New System.Drawing.Size(149, 28)
        Me.heightPanell.TabIndex = 46
        '
        'heightLive
        '
        Me.heightLive.AutoSize = True
        Me.heightLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.heightLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.heightLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.heightLive.Location = New System.Drawing.Point(61, 4)
        Me.heightLive.Name = "heightLive"
        Me.heightLive.Size = New System.Drawing.Size(13, 20)
        Me.heightLive.TabIndex = 45
        Me.heightLive.Text = " "
        Me.heightLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'heightPanel
        '
        Me.heightPanel.AutoSize = True
        Me.heightPanel.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heightPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.heightPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.heightPanel.Location = New System.Drawing.Point(5, 4)
        Me.heightPanel.Name = "heightPanel"
        Me.heightPanel.Size = New System.Drawing.Size(61, 20)
        Me.heightPanel.TabIndex = 44
        Me.heightPanel.Text = "Height: "
        Me.heightPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'agePanell
        '
        Me.agePanell.BackColor = System.Drawing.Color.White
        Me.agePanell.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.agePanell.Controls.Add(Me.ageLive)
        Me.agePanell.Controls.Add(Me.Label2)
        Me.agePanell.Location = New System.Drawing.Point(6, 6)
        Me.agePanell.Name = "agePanell"
        Me.agePanell.Size = New System.Drawing.Size(149, 28)
        Me.agePanell.TabIndex = 45
        '
        'ageLive
        '
        Me.ageLive.AutoSize = True
        Me.ageLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ageLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ageLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ageLive.Location = New System.Drawing.Point(43, 4)
        Me.ageLive.Name = "ageLive"
        Me.ageLive.Size = New System.Drawing.Size(13, 20)
        Me.ageLive.TabIndex = 45
        Me.ageLive.Text = " "
        Me.ageLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(5, 4)
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
        Me.sexPanel.Location = New System.Drawing.Point(6, 36)
        Me.sexPanel.Name = "sexPanel"
        Me.sexPanel.Size = New System.Drawing.Size(149, 28)
        Me.sexPanel.TabIndex = 46
        '
        'sexLive
        '
        Me.sexLive.AutoSize = True
        Me.sexLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.sexLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sexLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sexLive.Location = New System.Drawing.Point(39, 4)
        Me.sexLive.Name = "sexLive"
        Me.sexLive.Size = New System.Drawing.Size(13, 20)
        Me.sexLive.TabIndex = 45
        Me.sexLive.Text = " "
        Me.sexLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(5, 4)
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
        Me.bloodTypePanel.Location = New System.Drawing.Point(6, 66)
        Me.bloodTypePanel.Name = "bloodTypePanel"
        Me.bloodTypePanel.Size = New System.Drawing.Size(149, 28)
        Me.bloodTypePanel.TabIndex = 47
        '
        'bloodtypeLive
        '
        Me.bloodtypeLive.AutoSize = True
        Me.bloodtypeLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.bloodtypeLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bloodtypeLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bloodtypeLive.Location = New System.Drawing.Point(93, 4)
        Me.bloodtypeLive.Name = "bloodtypeLive"
        Me.bloodtypeLive.Size = New System.Drawing.Size(13, 20)
        Me.bloodtypeLive.TabIndex = 45
        Me.bloodtypeLive.Text = " "
        Me.bloodtypeLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(5, 4)
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
        'Guna2Elipse10
        '
        Me.Guna2Elipse10.TargetControl = Me.DiagnosisPanel
        '
        'DiagnosisPanel
        '
        Me.DiagnosisPanel.BackColor = System.Drawing.SystemColors.Control
        Me.DiagnosisPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.DiagnosisPanel.Controls.Add(Me.historyLivePanel)
        Me.DiagnosisPanel.Controls.Add(Me.lblDiagnonsisHealthHistory)
        Me.DiagnosisPanel.Location = New System.Drawing.Point(6, 6)
        Me.DiagnosisPanel.Name = "DiagnosisPanel"
        Me.DiagnosisPanel.Size = New System.Drawing.Size(300, 182)
        Me.DiagnosisPanel.TabIndex = 46
        '
        'historyLivePanel
        '
        Me.historyLivePanel.BackColor = System.Drawing.SystemColors.Control
        Me.historyLivePanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.historyLivePanel.Controls.Add(Me.historyLive)
        Me.historyLivePanel.Location = New System.Drawing.Point(2, 27)
        Me.historyLivePanel.Name = "historyLivePanel"
        Me.historyLivePanel.Size = New System.Drawing.Size(297, 150)
        Me.historyLivePanel.TabIndex = 52
        '
        'historyLive
        '
        Me.historyLive.AutoSize = True
        Me.historyLive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.historyLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.historyLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.historyLive.Location = New System.Drawing.Point(6, 14)
        Me.historyLive.Name = "historyLive"
        Me.historyLive.Size = New System.Drawing.Size(13, 20)
        Me.historyLive.TabIndex = 46
        Me.historyLive.Text = " "
        Me.historyLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiagnonsisHealthHistory
        '
        Me.lblDiagnonsisHealthHistory.AutoSize = True
        Me.lblDiagnonsisHealthHistory.BackColor = System.Drawing.Color.Transparent
        Me.lblDiagnonsisHealthHistory.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiagnonsisHealthHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDiagnonsisHealthHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDiagnonsisHealthHistory.Location = New System.Drawing.Point(111, 4)
        Me.lblDiagnonsisHealthHistory.Name = "lblDiagnonsisHealthHistory"
        Me.lblDiagnonsisHealthHistory.Size = New System.Drawing.Size(77, 20)
        Me.lblDiagnonsisHealthHistory.TabIndex = 51
        Me.lblDiagnonsisHealthHistory.Text = "Diagnosis"
        Me.lblDiagnonsisHealthHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.ReloadBtn.Location = New System.Drawing.Point(513, 501)
        Me.ReloadBtn.Name = "ReloadBtn"
        Me.ReloadBtn.Size = New System.Drawing.Size(79, 28)
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
        Me.DismissBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DismissBtn.ForeColor = System.Drawing.Color.White
        Me.DismissBtn.Location = New System.Drawing.Point(598, 501)
        Me.DismissBtn.Name = "DismissBtn"
        Me.DismissBtn.Size = New System.Drawing.Size(79, 28)
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
        'othersPanel
        '
        Me.othersPanel.BackColor = System.Drawing.SystemColors.Control
        Me.othersPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.othersPanel.Controls.Add(Me.Guna2Panel5)
        Me.othersPanel.Controls.Add(Me.Guna2Panel7)
        Me.othersPanel.Controls.Add(Me.Guna2Panel6)
        Me.othersPanel.Controls.Add(Me.Label15)
        Me.othersPanel.Location = New System.Drawing.Point(522, 39)
        Me.othersPanel.Name = "othersPanel"
        Me.othersPanel.Size = New System.Drawing.Size(155, 149)
        Me.othersPanel.TabIndex = 54
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel5.Controls.Add(Me.lbRFID)
        Me.Guna2Panel5.Controls.Add(Me.Guna2PictureBox4)
        Me.Guna2Panel5.Location = New System.Drawing.Point(6, 108)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(142, 34)
        Me.Guna2Panel5.TabIndex = 56
        '
        'lbRFID
        '
        Me.lbRFID.AutoSize = True
        Me.lbRFID.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbRFID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbRFID.Location = New System.Drawing.Point(57, 7)
        Me.lbRFID.Name = "lbRFID"
        Me.lbRFID.Size = New System.Drawing.Size(40, 20)
        Me.lbRFID.TabIndex = 51
        Me.lbRFID.Text = "RFID"
        Me.lbRFID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.Image = CType(resources.GetObject("Guna2PictureBox4.Image"), System.Drawing.Image)
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(9, 6)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(34, 28)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox4.TabIndex = 1
        Me.Guna2PictureBox4.TabStop = False
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel7.Controls.Add(Me.lbHall)
        Me.Guna2Panel7.Controls.Add(Me.Guna2PictureBox6)
        Me.Guna2Panel7.Location = New System.Drawing.Point(6, 35)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(142, 34)
        Me.Guna2Panel7.TabIndex = 54
        '
        'lbHall
        '
        Me.lbHall.AutoSize = True
        Me.lbHall.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbHall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbHall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbHall.Location = New System.Drawing.Point(57, 7)
        Me.lbHall.Name = "lbHall"
        Me.lbHall.Size = New System.Drawing.Size(49, 20)
        Me.lbHall.TabIndex = 50
        Me.lbHall.Text = "Status"
        Me.lbHall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox6
        '
        Me.Guna2PictureBox6.Image = CType(resources.GetObject("Guna2PictureBox6.Image"), System.Drawing.Image)
        Me.Guna2PictureBox6.ImageRotate = 0!
        Me.Guna2PictureBox6.Location = New System.Drawing.Point(8, 3)
        Me.Guna2PictureBox6.Name = "Guna2PictureBox6"
        Me.Guna2PictureBox6.Size = New System.Drawing.Size(34, 28)
        Me.Guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox6.TabIndex = 0
        Me.Guna2PictureBox6.TabStop = False
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel6.Controls.Add(Me.lbBatt)
        Me.Guna2Panel6.Controls.Add(Me.Guna2PictureBox5)
        Me.Guna2Panel6.Location = New System.Drawing.Point(6, 72)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(142, 34)
        Me.Guna2Panel6.TabIndex = 55
        '
        'lbBatt
        '
        Me.lbBatt.AutoSize = True
        Me.lbBatt.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbBatt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbBatt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbBatt.Location = New System.Drawing.Point(57, 7)
        Me.lbBatt.Name = "lbBatt"
        Me.lbBatt.Size = New System.Drawing.Size(74, 20)
        Me.lbBatt.TabIndex = 49
        Me.lbBatt.Text = "Batt Level"
        Me.lbBatt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = CType(resources.GetObject("Guna2PictureBox5.Image"), System.Drawing.Image)
        Me.Guna2PictureBox5.ImageRotate = 0!
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(9, 3)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(34, 28)
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
        Me.Label15.Location = New System.Drawing.Point(29, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 20)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Device Status"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'vitalsPanel
        '
        Me.vitalsPanel.BackColor = System.Drawing.SystemColors.Control
        Me.vitalsPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.vitalsPanel.Controls.Add(Me.Guna2Panel3)
        Me.vitalsPanel.Controls.Add(Me.Guna2Panel2)
        Me.vitalsPanel.Controls.Add(Me.Guna2Panel1)
        Me.vitalsPanel.Controls.Add(Me.Label19)
        Me.vitalsPanel.Location = New System.Drawing.Point(365, 39)
        Me.vitalsPanel.Name = "vitalsPanel"
        Me.vitalsPanel.Size = New System.Drawing.Size(155, 149)
        Me.vitalsPanel.TabIndex = 53
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel3.Controls.Add(Me.lbBpm)
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2Panel3.Location = New System.Drawing.Point(6, 35)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(142, 34)
        Me.Guna2Panel3.TabIndex = 60
        '
        'lbBpm
        '
        Me.lbBpm.AutoSize = True
        Me.lbBpm.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbBpm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbBpm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbBpm.Location = New System.Drawing.Point(52, 7)
        Me.lbBpm.Name = "lbBpm"
        Me.lbBpm.Size = New System.Drawing.Size(77, 20)
        Me.lbBpm.TabIndex = 46
        Me.lbBpm.Text = "Pulse Rate"
        Me.lbBpm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(2, 0)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(45, 33)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 1
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel2.Controls.Add(Me.lbTemp)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(6, 72)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(142, 34)
        Me.Guna2Panel2.TabIndex = 59
        '
        'lbTemp
        '
        Me.lbTemp.AutoSize = True
        Me.lbTemp.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbTemp.Location = New System.Drawing.Point(52, 8)
        Me.lbTemp.Name = "lbTemp"
        Me.lbTemp.Size = New System.Drawing.Size(84, 20)
        Me.lbTemp.TabIndex = 47
        Me.lbTemp.Text = "Body Temp"
        Me.lbTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(7, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(34, 28)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 0
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.lbO2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(6, 108)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(142, 34)
        Me.Guna2Panel1.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(6, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "SpO₂"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbO2
        '
        Me.lbO2.AutoSize = True
        Me.lbO2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbO2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbO2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbO2.Location = New System.Drawing.Point(52, 7)
        Me.lbO2.Name = "lbO2"
        Me.lbO2.Size = New System.Drawing.Size(70, 20)
        Me.lbO2.TabIndex = 48
        Me.lbO2.Text = "Blood O₂"
        Me.lbO2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(21, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 20)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Patient's Vitals"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'wardNumberLive
        '
        Me.wardNumberLive.AutoSize = True
        Me.wardNumberLive.BackColor = System.Drawing.Color.Transparent
        Me.wardNumberLive.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardNumberLive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.wardNumberLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.wardNumberLive.Location = New System.Drawing.Point(632, 12)
        Me.wardNumberLive.Name = "wardNumberLive"
        Me.wardNumberLive.Size = New System.Drawing.Size(13, 20)
        Me.wardNumberLive.TabIndex = 56
        Me.wardNumberLive.Text = " "
        Me.wardNumberLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patientName
        '
        Me.patientName.AutoSize = True
        Me.patientName.Font = New System.Drawing.Font("Segoe UI", 11.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.patientName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.patientName.Location = New System.Drawing.Point(367, 12)
        Me.patientName.Name = "patientName"
        Me.patientName.Size = New System.Drawing.Size(93, 20)
        Me.patientName.TabIndex = 55
        Me.patientName.Text = "FULL NAME"
        Me.patientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Elipse11
        '
        Me.Guna2Elipse11.TargetControl = Me.vitalsPanel
        '
        'Guna2Elipse12
        '
        Me.Guna2Elipse12.TargetControl = Me.othersPanel
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel4.Controls.Add(Me.notestxtbox)
        Me.Guna2Panel4.Controls.Add(Me.NotesPanel)
        Me.Guna2Panel4.Location = New System.Drawing.Point(20, 301)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(337, 194)
        Me.Guna2Panel4.TabIndex = 57
        '
        'notestxtbox
        '
        Me.notestxtbox.BackColor = System.Drawing.SystemColors.Control
        Me.notestxtbox.BorderColor = System.Drawing.SystemColors.Control
        Me.notestxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.notestxtbox.DefaultText = ""
        Me.notestxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.notestxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.notestxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.notestxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.notestxtbox.Enabled = False
        Me.notestxtbox.FillColor = System.Drawing.SystemColors.Control
        Me.notestxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.notestxtbox.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.notestxtbox.ForeColor = System.Drawing.Color.White
        Me.notestxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.notestxtbox.Location = New System.Drawing.Point(9, 33)
        Me.notestxtbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.notestxtbox.Name = "notestxtbox"
        Me.notestxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.notestxtbox.PlaceholderForeColor = System.Drawing.Color.White
        Me.notestxtbox.PlaceholderText = ""
        Me.notestxtbox.SelectedText = ""
        Me.notestxtbox.Size = New System.Drawing.Size(319, 150)
        Me.notestxtbox.TabIndex = 53
        '
        'NotesPanel
        '
        Me.NotesPanel.BackColor = System.Drawing.SystemColors.Control
        Me.NotesPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.NotesPanel.Controls.Add(Me.Label22)
        Me.NotesPanel.Location = New System.Drawing.Point(6, 6)
        Me.NotesPanel.Name = "NotesPanel"
        Me.NotesPanel.Size = New System.Drawing.Size(324, 182)
        Me.NotesPanel.TabIndex = 52
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Location = New System.Drawing.Point(105, 3)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(114, 20)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Vitals' Analysis"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Elipse16
        '
        Me.Guna2Elipse16.TargetControl = Me.Guna2Panel4
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel8.Controls.Add(Me.DiagnosisPanel)
        Me.Guna2Panel8.Location = New System.Drawing.Point(365, 301)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(312, 194)
        Me.Guna2Panel8.TabIndex = 58
        '
        'Guna2Elipse17
        '
        Me.Guna2Elipse17.TargetControl = Me.Guna2Panel8
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'NotifyIcon2
        '
        Me.NotifyIcon2.Icon = CType(resources.GetObject("NotifyIcon2.Icon"), System.Drawing.Icon)
        Me.NotifyIcon2.Text = "NotifyIcon2"
        Me.NotifyIcon2.Visible = True
        '
        'NotifyIcon3
        '
        Me.NotifyIcon3.Icon = CType(resources.GetObject("NotifyIcon3.Icon"), System.Drawing.Icon)
        Me.NotifyIcon3.Text = "NotifyIcon3"
        Me.NotifyIcon3.Visible = True
        '
        'NotifyIcon4
        '
        Me.NotifyIcon4.Icon = CType(resources.GetObject("NotifyIcon4.Icon"), System.Drawing.Icon)
        Me.NotifyIcon4.Text = "NotifyIcon4"
        Me.NotifyIcon4.Visible = True
        '
        'NotifyIcon5
        '
        Me.NotifyIcon5.Icon = CType(resources.GetObject("NotifyIcon5.Icon"), System.Drawing.Icon)
        Me.NotifyIcon5.Text = "NotifyIcon5"
        Me.NotifyIcon5.Visible = True
        '
        'LiveMonitorPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(697, 541)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.wardNumberLive)
        Me.Controls.Add(Me.patientName)
        Me.Controls.Add(Me.othersPanel)
        Me.Controls.Add(Me.vitalsPanel)
        Me.Controls.Add(Me.DismissBtn)
        Me.Controls.Add(Me.ReloadBtn)
        Me.Controls.Add(Me.liveMonitoringDTG)
        Me.Controls.Add(Me.PatientInfoPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LiveMonitorPage"
        Me.Text = "LiveMonitorPage"
        CType(Me.liveMonitoringDTG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientInfoPanel.ResumeLayout(False)
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
        Me.DiagnosisPanel.ResumeLayout(False)
        Me.DiagnosisPanel.PerformLayout()
        Me.historyLivePanel.ResumeLayout(False)
        Me.historyLivePanel.PerformLayout()
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
        Me.Guna2Panel4.ResumeLayout(False)
        Me.NotesPanel.ResumeLayout(False)
        Me.NotesPanel.PerformLayout()
        Me.Guna2Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PatientInfoPanel As Guna.UI2.WinForms.Guna2Panel
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
    Friend WithEvents liveMonitoringDTG As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Elipse10 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ReloadBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DismissBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents agePanell As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ageLive As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents othersPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbRFID As Label
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbHall As Label
    Friend WithEvents Guna2PictureBox6 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbBatt As Label
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents vitalsPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbBpm As Label
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbTemp As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbO2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents wardNumberLive As Label
    Friend WithEvents patientName As Label
    Friend WithEvents Guna2Elipse11 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse12 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label5 As Label
    Friend WithEvents patientID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents NotesPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Guna2Elipse16 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DiagnosisPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblDiagnonsisHealthHistory As Label
    Friend WithEvents Guna2Elipse17 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents historyLivePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents historyLive As Label
    Friend WithEvents notestxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents NotifyIcon2 As NotifyIcon
    Friend WithEvents NotifyIcon3 As NotifyIcon
    Friend WithEvents NotifyIcon4 As NotifyIcon
    Friend WithEvents NotifyIcon5 As NotifyIcon
End Class
