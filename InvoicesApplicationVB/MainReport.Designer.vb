<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainReport
	Inherits DevExpress.XtraReports.UI.XtraReport

	'XtraReport overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Designer
	'It can be modified using the Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.companyNameMainLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.invoiceDateLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.invoiceTermsLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
		Me.companyIDLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.MainGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
		Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
		Me.MainReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
		Me.CompanyTotalReportLabel = New DevExpress.XtraReports.UI.XRLabel()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.invoiceDateLabel, Me.invoiceTermsLabel})
		Me.Detail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Detail.HeightF = 38.62502!
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
		Me.Detail.StylePriority.UseFont = False
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		'
		'TopMargin
		'
		Me.TopMargin.HeightF = 100.0!
		Me.TopMargin.Name = "TopMargin"
		Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
		Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		'
		'BottomMargin
		'
		Me.BottomMargin.HeightF = 100.0!
		Me.BottomMargin.Name = "BottomMargin"
		Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
		Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		'
		'companyNameMainLabel
		'
		Me.companyNameMainLabel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.companyNameMainLabel.LocationFloat = New DevExpress.Utils.PointFloat(32.29167!, 10.00001!)
		Me.companyNameMainLabel.Name = "companyNameMainLabel"
		Me.companyNameMainLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.companyNameMainLabel.SizeF = New System.Drawing.SizeF(228.125!, 23.0!)
		Me.companyNameMainLabel.StylePriority.UseFont = False
		Me.companyNameMainLabel.Text = "[name]"
		'
		'invoiceDateLabel
		'
		Me.invoiceDateLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.invoiceDateLabel.LocationFloat = New DevExpress.Utils.PointFloat(52.08334!, 8.854168!)
		Me.invoiceDateLabel.Name = "invoiceDateLabel"
		Me.invoiceDateLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.invoiceDateLabel.SizeF = New System.Drawing.SizeF(251.0417!, 23.0!)
		Me.invoiceDateLabel.StylePriority.UseFont = False
		Me.invoiceDateLabel.Text = "[date]"
		'
		'invoiceTermsLabel
		'
		Me.invoiceTermsLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.invoiceTermsLabel.LocationFloat = New DevExpress.Utils.PointFloat(303.125!, 8.854167!)
		Me.invoiceTermsLabel.Name = "invoiceTermsLabel"
		Me.invoiceTermsLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.invoiceTermsLabel.SizeF = New System.Drawing.SizeF(294.7917!, 23.0!)
		Me.invoiceTermsLabel.StylePriority.UseFont = False
		Me.invoiceTermsLabel.Text = "[terms]"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.HeightF = 63.54167!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'companyIDLabel
		'
		Me.companyIDLabel.LocationFloat = New DevExpress.Utils.PointFloat(260.4167!, 10.00001!)
		Me.companyIDLabel.Name = "companyIDLabel"
		Me.companyIDLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.companyIDLabel.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
		Me.companyIDLabel.Text = "[company_id]"
		Me.companyIDLabel.Visible = False
		'
		'MainGroupHeader
		'
		Me.MainGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.companyIDLabel, Me.companyNameMainLabel})
		Me.MainGroupHeader.HeightF = 37.58335!
		Me.MainGroupHeader.Name = "MainGroupHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
		Me.PageFooter.HeightF = 80.20834!
		Me.PageFooter.Name = "PageFooter"
		'
		'XrPageInfo1
		'
		Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 56.16665!)
		Me.XrPageInfo1.Name = "XrPageInfo1"
		Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
		'
		'MainReportHeader
		'
		Me.MainReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.CompanyTotalReportLabel})
		Me.MainReportHeader.HeightF = 37.5!
		Me.MainReportHeader.Name = "MainReportHeader"
		'
		'CompanyTotalReportLabel
		'
		Me.CompanyTotalReportLabel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CompanyTotalReportLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
		Me.CompanyTotalReportLabel.Name = "CompanyTotalReportLabel"
		Me.CompanyTotalReportLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.CompanyTotalReportLabel.SizeF = New System.Drawing.SizeF(253.125!, 23.0!)
		Me.CompanyTotalReportLabel.StylePriority.UseFont = False
		Me.CompanyTotalReportLabel.Text = "Main Report"
		'
		'MainReport
		'
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.MainGroupHeader, Me.GroupFooter1, Me.PageFooter, Me.MainReportHeader})
		Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
		Me.Version = "14.1"
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
	Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Friend WithEvents invoiceDateLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents invoiceTermsLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents companyNameMainLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
	Friend WithEvents companyIDLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents MainGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
	Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
	Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
	Friend WithEvents MainReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
	Friend WithEvents CompanyTotalReportLabel As DevExpress.XtraReports.UI.XRLabel
End Class
