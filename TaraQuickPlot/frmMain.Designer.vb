<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Me.chtPosition = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.cmdPlotPosition = New System.Windows.Forms.Button
        CType(Me.chtPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chtPosition
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtPosition.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtPosition.Legends.Add(Legend1)
        Me.chtPosition.Location = New System.Drawing.Point(24, 12)
        Me.chtPosition.Name = "chtPosition"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtPosition.Series.Add(Series1)
        Me.chtPosition.Size = New System.Drawing.Size(730, 300)
        Me.chtPosition.TabIndex = 0
        Me.chtPosition.Text = "Position Data"
        '
        'cmdPlotPosition
        '
        Me.cmdPlotPosition.Location = New System.Drawing.Point(358, 331)
        Me.cmdPlotPosition.Name = "cmdPlotPosition"
        Me.cmdPlotPosition.Size = New System.Drawing.Size(128, 23)
        Me.cmdPlotPosition.TabIndex = 1
        Me.cmdPlotPosition.Text = "Plot Position Data"
        Me.cmdPlotPosition.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 366)
        Me.Controls.Add(Me.cmdPlotPosition)
        Me.Controls.Add(Me.chtPosition)
        Me.Name = "frmMain"
        Me.Text = "TARA Quick Plot"
        CType(Me.chtPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chtPosition As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cmdPlotPosition As System.Windows.Forms.Button

End Class
