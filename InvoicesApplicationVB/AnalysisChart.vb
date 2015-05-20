Imports CemDB
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient

Public Class AnalysisChart
	Inherits DevExpress.XtraEditors.XtraForm

	Private WithEvents dbCompanies As DBDataSet
	Private WithEvents dbInvoices As DBDataSet
	Private WithEvents dbDetails As DBDataSet
	Private WithEvents dbAddresses As DBDataSet

	Private WithEvents dbNumInvoices As DBDataSet

	Private tableCompanies As DataTable
	Private tableInvoices As DataTable
	Private tableDetails As DataTable
	Private tableAddresses As DataTable
	Private tableNumInvoices As DataTable

	Private WithEvents dsMaster As DataSet

	Private barChartSeries As Series


	Shared Sub New()
		DevExpress.UserSkins.BonusSkins.Register()
		DevExpress.Skins.SkinManager.EnableFormSkins()
	End Sub


	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		'Initializations.
		dbCompanies = New DBDataSet()
		dbInvoices = New DBDataSet()
		dbDetails = New DBDataSet()
		dbAddresses = New DBDataSet()
		dbNumInvoices = New DBDataSet()

		tableCompanies = New DataTable("tableCompanies")
		tableInvoices = New DataTable("tableInvoices")
		tableDetails = New DataTable("tableDetails")
		tableAddresses = New DataTable("tableAddresses")
		tableNumInvoices = New DataTable("tableNumInvoices")

		'Set procedures.
		dbCompanies.FetchStoredProcedure = "fetch_companies"
		dbCompanies.InsertStoredProcedure = "add_company"
		dbCompanies.UpdateStoredProcedure = "update_company"
		dbCompanies.DeleteStoredProcedure = "delete_company"

		dbInvoices.FetchStoredProcedure = "fetch_invoices"
		dbInvoices.InsertStoredProcedure = "add_invoice"
		dbInvoices.UpdateStoredProcedure = "update_invoice"
		dbInvoices.DeleteStoredProcedure = "delete_invoice"

		dbAddresses.FetchStoredProcedure = "fetch_addresses"
		dbAddresses.InsertStoredProcedure = "add_address"
		dbAddresses.UpdateStoredProcedure = "update_address"
		dbAddresses.DeleteStoredProcedure = "delete_address"

		dbDetails.FetchStoredProcedure = "fetch_details"
		dbDetails.InsertStoredProcedure = "add_detail"
		dbDetails.UpdateStoredProcedure = "update_detail"
		dbDetails.DeleteStoredProcedure = "delete_detail"

		dbNumInvoices.FetchStoredProcedure = "fetch_num_invoices"

		dbCompanies.FetchDataTable(tableCompanies)
		dbInvoices.FetchDataTable(tableInvoices)
		dbDetails.FetchDataTable(tableDetails)
		dbAddresses.FetchDataTable(tableAddresses)
		dbNumInvoices.FetchDataTable(tableNumInvoices)

		'Set DataSet for relations.
		dsMaster = New DataSet()
		dbCompanies.DataSet = dsMaster

		dsMaster.Tables.Add(tableCompanies)
		dsMaster.Tables.Add(tableInvoices)
		dsMaster.Tables.Add(tableDetails)
		dsMaster.Tables.Add(tableAddresses)
		dsMaster.Tables.Add(tableNumInvoices)

		System.Console.WriteLine("COUNT: {0} ", dsMaster.Tables.Count)

		dsMaster.Relations.Add("Company Invoices", dsMaster.Tables(0).Columns("company_id"),
							 dsMaster.Tables(1).Columns("company_id"), False)
		dsMaster.Relations.Add("Invoice Details", dsMaster.Tables(1).Columns("invoice_id"),
									dsMaster.Tables(2).Columns("invoice_id"), False)
		dsMaster.Relations.Add("Company Addresses", dsMaster.Tables(0).Columns("company_id"),
									dsMaster.Tables(3).Columns("company_id"), False)

		barChartControl.DataSource = dsMaster.Tables("tableCompanies")

		' Set the Y-Axis to integer values
		CType(barChartControl.Diagram, XYDiagram).AxisY.GridSpacingAuto = False
		CType(barChartControl.Diagram, XYDiagram).AxisY.GridSpacing = 1

	End Sub


	Private Sub AnalysisChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim numInvoices As Integer
		Dim companyName As String

		'Create a series for invoice counts bar chart.
		barChartControl.Series.Clear()
		barChartSeries = New Series("Invoices", ViewType.Bar)

		' Obtain number of invoices per company
		For Each companyResult As DataRow In tableNumInvoices.Rows
			numInvoices = (CType(companyResult("sum_invoices"), Integer))
			companyName = companyResult("name").ToString()
			barChartSeries.Points.Add(New SeriesPoint(companyName, numInvoices))
		Next

		' Set up bar graph appearance and display
		Dim view As BarSeriesView = CType(barChartSeries.View, BarSeriesView)
		view.ColorEach = True

		Dim barLabel As BarSeriesLabel = CType(barChartSeries.Label, BarSeriesLabel)
		barLabel.TextPattern = "{A}: {V}"
		barLabel.Font = New Font("Tahoma", 8, FontStyle.Regular)

		Dim barChartTitle As New ChartTitle() With {.Text = "Number of Invoices Per Company", .Font = New Font("Tahoma", 14, FontStyle.Bold)}

		barChartControl.Titles.Add(barChartTitle)
		barChartControl.Series.Add(barChartSeries)

	End Sub
End Class