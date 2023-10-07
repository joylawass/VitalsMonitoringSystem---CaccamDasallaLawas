<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardPage
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Welcome = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Welcome
        '
        Me.Welcome.AutoSize = True
        Me.Welcome.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Welcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Welcome.Location = New System.Drawing.Point(39, 30)
        Me.Welcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(181, 32)
        Me.Welcome.TabIndex = 23
        Me.Welcome.Text = "Welcome back, "
        Me.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(33, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 135)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "##"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(38, 140)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 169)
        Me.Panel1.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(45, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 29)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Active Devices"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsername.Location = New System.Drawing.Point(213, 30)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(121, 32)
        Me.lblUsername.TabIndex = 27
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
        Me.Label1.Location = New System.Drawing.Point(16, 625)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername1
        '
        Me.lblUsername1.AutoSize = True
        Me.lblUsername1.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername1.ForeColor = System.Drawing.Color.DarkGray
        Me.lblUsername1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsername1.Location = New System.Drawing.Point(109, 625)
        Me.lblUsername1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername1.Name = "lblUsername1"
        Me.lblUsername1.Size = New System.Drawing.Size(86, 20)
        Me.lblUsername1.TabIndex = 34
        Me.lblUsername1.Text = "Username"
        Me.lblUsername1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(313, 140)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 169)
        Me.Panel2.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(24, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 29)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Recorded Patients"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(33, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 135)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "##"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(38, 317)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 169)
        Me.Panel3.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(23, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 29)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Number of Beds"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(33, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 135)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "##"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(33, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 135)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "##"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(313, 319)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(267, 169)
        Me.Panel4.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(23, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 29)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Number of Beds"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(58, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(195, 31)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Live Notifications"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(618, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(288, 611)
        Me.Panel5.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.VitalsMonitoringSystem.My.Resources.Resources.icons8_notification_24
        Me.PictureBox1.Location = New System.Drawing.Point(28, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'DashboardPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(929, 656)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Welcome)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DashboardPage"
        Me.Text = "DashboardPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Welcome As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
