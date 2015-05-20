<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalysisChart
	Inherits DevExpress.XtraEditors.XtraForm

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
		Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
		Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
		Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
		Me.barChartControl = New DevExpress.XtraCharts.ChartControl()
		CType(Me.barChartControl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'barChartControl
		'
		XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
		XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
		Me.barChartControl.Diagram = XyDiagram1
		Me.barChartControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.barChartControl.Location = New System.Drawing.Point(0, 0)
		Me.barChartControl.Name = "barChartControl"
		Me.barChartControl.PaletteName = "Violet II"
		Series1.Name = "Series 1"
		Series2.Name = "Series 2"
		Me.barChartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
		Me.barChartControl.Size = New System.Drawing.Size(567, 270)
		Me.barChartControl.TabIndex = 1
		'
		'AnalysisChart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(567, 270)
		Me.Controls.Add(Me.barChartControl)
		Me.Name = "AnalysisChart"
		Me.Text = "AnalysisChart"
		CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.barChartControl, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents barChartControl As DevExpress.XtraCharts.ChartControl
End Class
