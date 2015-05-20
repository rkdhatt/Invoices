<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CompanyReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
			If dbCompanyReport IsNot Nothing Then
				dbCompanyReport.Dispose()
				dbCompanyReport = Nothing
			End If
			If tableCompanyReportInfo IsNot Nothing Then
				tableCompanyReportInfo.Dispose()
				tableCompanyReportInfo = Nothing
			End If
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
		Me.totalCostLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.descriptionLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.CompanyInvoiceGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
		Me.totalCostTitleLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.descriptionTitleLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.termsLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.invoice_dateLabel = New DevExpress.XtraReports.UI.XRLabel()
		Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
		Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.companyNameLabel = New DevExpress.XtraReports.UI.XRLabel()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.totalCostLabel, Me.descriptionLabel})
		Me.Detail.HeightF = 23.0!
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		'
		'totalCostLabel
		'
		Me.totalCostLabel.BackColor = System.Drawing.Color.Cornsilk
		Me.totalCostLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.totalCostLabel.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 0.0!)
		Me.totalCostLabel.Name = "totalCostLabel"
		Me.totalCostLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.totalCostLabel.SizeF = New System.Drawing.SizeF(181.25!, 23.0!)
		Me.totalCostLabel.StylePriority.UseBackColor = False
		Me.totalCostLabel.StylePriority.UseFont = False
		Me.totalCostLabel.Text = "[total_cost]"
		'
		'descriptionLabel
		'
		Me.descriptionLabel.BackColor = System.Drawing.Color.Cornsilk
		Me.descriptionLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.descriptionLabel.LocationFloat = New DevExpress.Utils.PointFloat(91.66667!, 0.0!)
		Me.descriptionLabel.Name = "descriptionLabel"
		Me.descriptionLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.descriptionLabel.SizeF = New System.Drawing.SizeF(233.3333!, 23.0!)
		Me.descriptionLabel.StylePriority.UseBackColor = False
		Me.descriptionLabel.StylePriority.UseFont = False
		Me.descriptionLabel.Text = "[description]"
		'
		'TopMargin
		'
		Me.TopMargin.HeightF = 98.95834!
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
		'CompanyInvoiceGroupHeader
		'
		Me.CompanyInvoiceGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.totalCostTitleLabel, Me.descriptionTitleLabel, Me.termsLabel, Me.invoice_dateLabel})
		Me.CompanyInvoiceGroupHeader.HeightF = 69.79166!
		Me.CompanyInvoiceGroupHeader.Name = "CompanyInvoiceGroupHeader"
		'
		'totalCostTitleLabel
		'
		Me.totalCostTitleLabel.BackColor = System.Drawing.Color.DarkRed
		Me.totalCostTitleLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.totalCostTitleLabel.ForeColor = System.Drawing.Color.White
		Me.totalCostTitleLabel.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 46.79165!)
		Me.totalCostTitleLabel.Name = "totalCostTitleLabel"
		Me.totalCostTitleLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.totalCostTitleLabel.SizeF = New System.Drawing.SizeF(181.25!, 23.0!)
		Me.totalCostTitleLabel.StylePriority.UseBackColor = False
		Me.totalCostTitleLabel.StylePriority.UseFont = False
		Me.totalCostTitleLabel.StylePriority.UseForeColor = False
		Me.totalCostTitleLabel.Text = "Total Cost"
		'
		'descriptionTitleLabel
		'
		Me.descriptionTitleLabel.BackColor = System.Drawing.Color.DarkRed
		Me.descriptionTitleLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.descriptionTitleLabel.ForeColor = System.Drawing.Color.White
		Me.descriptionTitleLabel.LocationFloat = New DevExpress.Utils.PointFloat(91.66666!, 46.79165!)
		Me.descriptionTitleLabel.Name = "descriptionTitleLabel"
		Me.descriptionTitleLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.descriptionTitleLabel.SizeF = New System.Drawing.SizeF(233.3333!, 23.0!)
		Me.descriptionTitleLabel.StylePriority.UseBackColor = False
		Me.descriptionTitleLabel.StylePriority.UseFont = False
		Me.descriptionTitleLabel.StylePriority.UseForeColor = False
		Me.descriptionTitleLabel.Text = "Description"
		'
		'termsLabel
		'
		Me.termsLabel.BackColor = System.Drawing.Color.DarkRed
		Me.termsLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.termsLabel.ForeColor = System.Drawing.Color.White
		Me.termsLabel.LocationFloat = New DevExpress.Utils.PointFloat(300.0!, 10.00001!)
		Me.termsLabel.Name = "termsLabel"
		Me.termsLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.termsLabel.SizeF = New System.Drawing.SizeF(181.25!, 23.0!)
		Me.termsLabel.StylePriority.UseBackColor = False
		Me.termsLabel.StylePriority.UseFont = False
		Me.termsLabel.StylePriority.UseForeColor = False
		Me.termsLabel.Text = "[terms]"
		'
		'invoice_dateLabel
		'
		Me.invoice_dateLabel.BackColor = System.Drawing.Color.DarkRed
		Me.invoice_dateLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.invoice_dateLabel.ForeColor = System.Drawing.Color.White
		Me.invoice_dateLabel.LocationFloat = New DevExpress.Utils.PointFloat(57.29167!, 10.00001!)
		Me.invoice_dateLabel.Name = "invoice_dateLabel"
		Me.invoice_dateLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.invoice_dateLabel.SizeF = New System.Drawing.SizeF(242.7083!, 23.0!)
		Me.invoice_dateLabel.StylePriority.UseBackColor = False
		Me.invoice_dateLabel.StylePriority.UseFont = False
		Me.invoice_dateLabel.StylePriority.UseForeColor = False
		Me.invoice_dateLabel.Text = "[date]"
		'
		'XrPageInfo1
		'
		Me.XrPageInfo1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 34.29168!)
		Me.XrPageInfo1.Name = "XrPageInfo1"
		Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
		Me.XrPageInfo1.StylePriority.UseFont = False
		'
		'PageFooter
		'
		Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
		Me.PageFooter.HeightF = 57.29168!
		Me.PageFooter.Name = "PageFooter"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.companyNameLabel})
		Me.PageHeader.HeightF = 31.25!
		Me.PageHeader.Name = "PageHeader"
		'
		'companyNameLabel
		'
		Me.companyNameLabel.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.companyNameLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
		Me.companyNameLabel.Name = "companyNameLabel"
		Me.companyNameLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.companyNameLabel.SizeF = New System.Drawing.SizeF(419.7917!, 23.0!)
		Me.companyNameLabel.StylePriority.UseFont = False
		Me.companyNameLabel.Text = "[name]"
		'
		'CompanyReport
		'
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.CompanyInvoiceGroupHeader, Me.PageFooter, Me.PageHeader})
		Me.Margins = New System.Drawing.Printing.Margins(100, 100, 99, 100)
		Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
		Me.Version = "14.1"
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
	Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Friend WithEvents totalCostLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents descriptionLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents CompanyInvoiceGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
	Friend WithEvents termsLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents invoice_dateLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents totalCostTitleLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents descriptionTitleLabel As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
	Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
	Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Friend WithEvents companyNameLabel As DevExpress.XtraReports.UI.XRLabel
End Class
