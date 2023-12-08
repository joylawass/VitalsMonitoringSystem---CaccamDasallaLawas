<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopupNotification
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblNotifTitle = New System.Windows.Forms.Label()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblNotifContent = New System.Windows.Forms.Label()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'lblNotifTitle
        '
        Me.lblNotifTitle.AutoSize = True
        Me.lblNotifTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotifTitle.ForeColor = System.Drawing.Color.Black
        Me.lblNotifTitle.Location = New System.Drawing.Point(92, 37)
        Me.lblNotifTitle.Name = "lblNotifTitle"
        Me.lblNotifTitle.Size = New System.Drawing.Size(158, 28)
        Me.lblNotifTitle.TabIndex = 1
        Me.lblNotifTitle.Text = "Notification Title"
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.CustomClick = True
        Me.CloseButton.FillColor = System.Drawing.Color.Transparent
        Me.CloseButton.IconColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(284, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(30, 30)
        Me.CloseButton.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 29)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "VITALS MONITORING SYSTEM"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.VitalsMonitoringSystem.My.Resources.Resources.icons8_warning_50
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(7, 37)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(79, 64)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 5
        Me.Guna2PictureBox1.TabStop = False
        '
        'lblNotifContent
        '
        Me.lblNotifContent.AutoSize = True
        Me.lblNotifContent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotifContent.ForeColor = System.Drawing.Color.Black
        Me.lblNotifContent.Location = New System.Drawing.Point(93, 69)
        Me.lblNotifContent.Name = "lblNotifContent"
        Me.lblNotifContent.Size = New System.Drawing.Size(150, 21)
        Me.lblNotifContent.TabIndex = 6
        Me.lblNotifContent.Text = "Notification Content"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 15
        '
        'PopupNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(314, 111)
        Me.Controls.Add(Me.lblNotifContent)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.lblNotifTitle)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PopupNotification"
        Me.Text = "PopupNotification"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblNotifTitle As Label
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblNotifContent As Label
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Timer1 As Timer
End Class
