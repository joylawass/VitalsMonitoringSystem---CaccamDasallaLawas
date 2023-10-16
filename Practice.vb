Public Class Practice
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'setup the chart area
        Chart4.Titles.Add("Line of x^2") ' specify chart name
        Chart4.ChartAreas.Clear()
        Chart4.ChartAreas.Add("Default")

        With Chart4.ChartAreas("Default")
            .AxisX.Title = "X" ' x label
            .AxisX.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.Title = "Y" 'y label
        End With

        'specify series plot lines 
        Chart4.Series.Clear()
        Chart4.Series.Add("plot1")
        Chart4.Series("plot1").Color = Color.Red
        Chart4.Series("plot1").ChartType = DataVisualization.Charting.SeriesChartType.Line

        Chart4.Series("plot1").Points.AddXY("0", "37.6")
        Chart4.Series("plot1").Points.AddXY("6", "26.7")
        Chart4.Series("plot1").Points.AddXY("12", "39.5")
        Chart4.Series("plot1").Points.AddXY("6", "28.5")
        Chart4.Series("plot1").Points.AddXY("12", "37.2")


    End Sub

    Private Sub Practice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class