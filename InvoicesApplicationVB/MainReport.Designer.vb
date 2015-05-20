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
		Me.invoiceDateLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.invoiceTermsLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.companyNameMainLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
		Me.companyIDLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.MainGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
		Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
		Me.MainReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
		Me.CompanyTotalReportLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.invoiceDateLabel, Me.invoiceTermsLabel})
		Me.Detail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Detail.HeightF = 24.04169!
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
		Me.Detail.StylePriority.UseFont = False
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		'
		'invoiceDateLabel
		'
		Me.invoiceDateLabel.BackColor = System.Drawing.Color.Cornsilk
		Me.invoiceDateLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.invoiceDateLabel.LocationFloat = New DevExpress.Utils.PointFloat(58.33333!, 0.0!)
		Me.invoiceDateLabel.Name = "invoiceDateLabel"
		Me.invoiceDateLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.invoiceDateLabel.SizeF = New System.Drawing.SizeF(241.6667!, 23.0!)
		Me.invoiceDateLabel.StylePriority.UseBackColor = False
		Me.invoiceDateLabel.StylePriority.UseFont = False
		Me.invoiceDateLabel.Text = "[date]"
		'
		'invoiceTermsLabel
		'
		Me.invoiceTermsLabel.BackColor = System.Drawing.Color.Cornsilk
		Me.invoiceTermsLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.invoiceTermsLabel.LocationFloat = New DevExpress.Utils.PointFloat(300.0!, 0.0!)
		Me.invoiceTermsLabel.Name = "invoiceTermsLabel"
		Me.invoiceTermsLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.invoiceTermsLabel.SizeF = New System.Drawing.SizeF(245.8333!, 23.0!)
		Me.invoiceTermsLabel.StylePriority.UseBackColor = False
		Me.invoiceTermsLabel.StylePriority.UseFont = False
		Me.invoiceTermsLabel.Text = "[terms]"
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
		Me.companyNameMainLabel.BackColor = System.Drawing.Color.DarkRed
		Me.companyNameMainLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.companyNameMainLabel.ForeColor = System.Drawing.Color.White
		Me.companyNameMainLabel.LocationFloat = New DevExpress.Utils.PointFloat(58.33333!, 10.00001!)
		Me.companyNameMainLabel.Name = "companyNameMainLabel"
		Me.companyNameMainLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.companyNameMainLabel.SizeF = New System.Drawing.SizeF(487.5!, 23.0!)
		Me.companyNameMainLabel.StylePriority.UseBackColor = False
		Me.companyNameMainLabel.StylePriority.UseFont = False
		Me.companyNameMainLabel.StylePriority.UseForeColor = False
		Me.companyNameMainLabel.Text = "[name]"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.HeightF = 27.08333!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'companyIDLabel
		'
		Me.companyIDLabel.BackColor = System.Drawing.Color.DarkRed
		Me.companyIDLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.companyIDLabel.ForeColor = System.Drawing.Color.White
		Me.companyIDLabel.LocationFloat = New DevExpress.Utils.PointFloat(596.875!, 10.00001!)
		Me.companyIDLabel.Name = "companyIDLabel"
		Me.companyIDLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.companyIDLabel.SizeF = New System.Drawing.SizeF(53.125!, 23.0!)
		Me.companyIDLabel.StylePriority.UseBackColor = False
		Me.companyIDLabel.StylePriority.UseFont = False
		Me.companyIDLabel.StylePriority.UseForeColor = False
		Me.companyIDLabel.Text = "[company_id]"
		Me.companyIDLabel.Visible = False
		'
		'MainGroupHeader
		'
		Me.MainGroupHeader.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
			Or DevExpress.XtraPrinting.BorderSide.Right) _
			Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
		Me.MainGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.companyIDLabel, Me.companyNameMainLabel})
		Me.MainGroupHeader.HeightF = 33.0!
		Me.MainGroupHeader.Name = "MainGroupHeader"
		Me.MainGroupHeader.StylePriority.UseBorders = False
		'
		'PageFooter
		'
		Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
		Me.PageFooter.HeightF = 80.20834!
		Me.PageFooter.Name = "PageFooter"
		'
		'XrPageInfo1
		'
		Me.XrPageInfo1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(586.8749!, 57.20832!)
		Me.XrPageInfo1.Name = "XrPageInfo1"
		Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(53.125!, 23.0!)
		Me.XrPageInfo1.StylePriority.UseFont = False
		Me.XrPageInfo1.StylePriority.UseTextAlignment = False
		Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
		'
		'MainReportHeader
		'
		Me.MainReportHeader.Borders = DevExpress.XtraPrinting.BorderSide.None
		Me.MainReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.CompanyTotalReportLabel})
		Me.MainReportHeader.HeightF = 28.125!
		Me.MainReportHeader.Name = "MainReportHeader"
		Me.MainReportHeader.StylePriority.UseBorders = False
		'
		'CompanyTotalReportLabel
		'
		Me.CompanyTotalReportLabel.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CompanyTotalReportLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
		Me.CompanyTotalReportLabel.Name = "CompanyTotalReportLabel"
		Me.CompanyTotalReportLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.CompanyTotalReportLabel.SizeF = New System.Drawing.SizeF(253.125!, 23.0!)
		Me.CompanyTotalReportLabel.StylePriority.UseFont = False
		Me.CompanyTotalReportLabel.Text = "Main Report"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2})
		Me.PageHeader.HeightF = 35.41667!
		Me.PageHeader.Name = "PageHeader"
		'
		'XrPageInfo2
		'
		Me.XrPageInfo2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.XrPageInfo2.Format = "Created: {0:h:mm tt dd MMM yyyy}"
		Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(26.04167!, 0.0!)
		Me.XrPageInfo2.Name = "XrPageInfo2"
		Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
		Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(213.5417!, 23.0!)
		Me.XrPageInfo2.StylePriority.UseFont = False
		'
		'MainReport
		'
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.MainGroupHeader, Me.GroupFooter1, Me.PageFooter, Me.MainReportHeader, Me.PageHeader})
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
	Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
End Class
