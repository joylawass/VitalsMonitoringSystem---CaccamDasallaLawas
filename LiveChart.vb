Imports System.Windows.Forms.DataVisualization.Charting
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf

Public Class LiveChart
    Private Sub LiveChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Titles.Add("Temperature")
        Chart2.Titles.Add("Pulse Rate")
        Chart3.Titles.Add("Blood Oxygen")

        Chart1.Series("Temperature").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart2.Series("Pulse Rate").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart3.Series("Blood Oxygen").ChartType = DataVisualization.Charting.SeriesChartType.Line

        Connect()
        Try
            query = "SELECT * FROM `" & ChartGen & "`"
            With command
                .Connection = connection
                .CommandText = query
                .Parameters.Clear()
                reader = .ExecuteReader
                While reader.Read
                    Chart1.Series("Temperature").Points.AddXY(" ", reader.GetString("temperature"))
                    Chart2.Series("Pulse Rate").Points.AddXY(" ", reader.GetString("pulse"))
                    Chart3.Series("Blood Oxygen").Points.AddXY(" ", reader.GetString("SPO2"))
                End While
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click

    End Sub



    'create a conditional statement about

    '1. first classifying the gender into male or female
    '2. then, classifying the real-time value into low, normal, and high number ranges

    'from mysql database in vb.net

End Class