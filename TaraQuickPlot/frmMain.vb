Option Explicit On
Imports System.IO
Public Class frmMain

    Dim srsBack As New DataVisualization.Charting.Series
    Dim srsRight As New DataVisualization.Charting.Series
    Dim srsAltitude As New DataVisualization.Charting.Series


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chtPosition.Series.Clear()
        chtPosition.Titles.Add("Sonar range")
        chtPosition.ChartAreas(0).AxisX.ScrollBar.Enabled = True
        chtPosition.ChartAreas(0).AxisX.Title = "Time [0.002 sec]" 'Chart1.ChartAreas("ChartArea1").AxisX.Title = "Time"
        chtPosition.ChartAreas(0).AxisY.Title = "Position [cm]"
        chtPosition.ChartAreas(0).AxisX.ScaleView.Size = 100

        srsBack.Name = "Back"
        srsBack.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        srsRight.Name = "Right"
        srsRight.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        srsAltitude.Name = "Altitude"
        srsAltitude.ChartType = DataVisualization.Charting.SeriesChartType.FastLine

        chtPosition.Series.Add(srsBack)
        chtPosition.Series.Add(srsRight)
        chtPosition.Series.Add(srsAltitude)

        chtPosition.Series("Back").Color = Color.Blue
        chtPosition.Series("Right").Color = Color.Red
        chtPosition.Series("Altitude").Color = Color.Black

        chtPosition.Series("Back").BorderWidth = 3
        chtPosition.Series("Right").BorderWidth = 3
        chtPosition.Series("Altitude").BorderWidth = 3

    End Sub

    Private Sub cmdPlotPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlotPosition.Click
        Dim openFile As New OpenFileDialog()
        Dim strIncoming As String
        Try
            openFile.Filter = "Text File|*.txt"
            openFile.Title = "Open Log File"

            ' If the file name is not an empty string save the name.
            If openFile.ShowDialog() = DialogResult.OK Then
                Dim srRead = New StreamReader(openFile.FileName, True)
                'TargetFile.WriteLine(())

                While Not srRead.ReadToEnd()
                    strIncoming = srRead.ReadLine()
                    strIncoming = strIncoming.Trim()

                    Dim strArray() As String = Split(strIncoming, ",")

                    Select Case strArray(0)
                        Case "Xaxis"
                            srsBack.Points.AddY(CSng(strArray(5)) / 10.0)

                        Case "Yaxis"
                            srsRight.Points.AddY(CSng(strArray(5)) / 10.0)
                            'srsRight.Points.AddXY(dblLastTime, CDbl(strArray(5)) / 10.0)
                        Case "Zaxis"
                            srsAltitude.Points.AddY(CSng(strArray(5)) / 10.0)
                            'srsAltitude.Points.AddXY(dblLastTime, CDbl(strArray(5)) / 10.0)

                    End Select

                End While
                srRead.Close()


            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
