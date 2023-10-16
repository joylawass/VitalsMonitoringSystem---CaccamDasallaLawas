<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Practice
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Plot"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart4
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend1)
        Me.Chart4.Location = New System.Drawing.Point(12, 12)
        Me.Chart4.Name = "Chart4"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart4.Series.Add(Series1)
        Me.Chart4.Size = New System.Drawing.Size(382, 197)
        Me.Chart4.TabIndex = 8
        Me.Chart4.Text = "Chart4"
        '
        'Practice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 245)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart4)
        Me.Name = "Practice"
        Me.Text = "Practice"
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Chart4 As DataVisualization.Charting.Chart
End Class
