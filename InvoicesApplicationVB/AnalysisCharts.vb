﻿Imports CemDB
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient

Public Class AnalysisCharts
	Inherits DevExpress.XtraEditors.XtraForm

	Private WithEvents dbCompanies As DBDataSet
	Private WithEvents dbInvoices As DBDataSet
	Private WithEvents dbDetails As DBDataSet
	Private WithEvents dbAddresses As DBDataSet
	Private WithEvents dbNumInvoices As DBDataSet
	Private WithEvents dbTotalCosts As DBDataSet

	Private tableCompanies As DataTable
	Private tableInvoices As DataTable
	Private tableDetails As DataTable
	Private tableAddresses As DataTable
	Private tableNumInvoices As DataTable
	Private tableTotalCosts As DataTable

	Private WithEvents dsMaster As DataSet

	Private barChartSeries As Series
	Private pieChartSeries As Series
	Private costChartSeries As Series
	Private lineChartSeries As Series


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
		dbNumInvoices = New DBDataSet()	' required for bar and pie graph (summary analysis)
		dbTotalCosts = New DBDataSet() ' required for line graph (summary analysis)

		tableCompanies = New DataTable("tableCompanies")
		tableInvoices = New DataTable("tableInvoices")
		tableDetails = New DataTable("tableDetails")
		tableAddresses = New DataTable("tableAddresses")
		tableNumInvoices = New DataTable("tableNumInvoices")
		tableTotalCosts = New DataTable("tableTotalCosts")

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
		dbTotalCosts.FetchStoredProcedure = "fetch_total_costs"

		dbCompanies.FetchDataTable(tableCompanies)
		dbInvoices.FetchDataTable(tableInvoices)
		dbDetails.FetchDataTable(tableDetails)
		dbAddresses.FetchDataTable(tableAddresses)
		dbNumInvoices.FetchDataTable(tableNumInvoices)
		dbTotalCosts.FetchDataTable(tableTotalCosts)

		'Set DataSet for relations.
		dsMaster = New DataSet()
		dbCompanies.DataSet = dsMaster

		dsMaster.Tables.Add(tableCompanies)
		dsMaster.Tables.Add(tableInvoices)
		dsMaster.Tables.Add(tableDetails)
		dsMaster.Tables.Add(tableAddresses)

		System.Console.WriteLine("COUNT: {0} ", dsMaster.Tables.Count)

		dsMaster.Relations.Add("Company Invoices", dsMaster.Tables(0).Columns("company_id"),
							 dsMaster.Tables(1).Columns("company_id"), False)
		dsMaster.Relations.Add("Invoice Details", dsMaster.Tables(1).Columns("invoice_id"),
									dsMaster.Tables(2).Columns("invoice_id"), False)
		dsMaster.Relations.Add("Company Addresses", dsMaster.Tables(0).Columns("company_id"),
									dsMaster.Tables(3).Columns("company_id"), False)

		barChartControl.DataSource = dsMaster.Tables("tableCompanies")

		' Set the Y-Axis to integer values
		CType(barChartControl.Diagram, XYDiagram).AxisY.NumericScaleOptions.AutoGrid = False
		CType(barChartControl.Diagram, XYDiagram).AxisY.NumericScaleOptions.GridSpacing = 1

	End Sub


	Private Sub AnalysisChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim numInvoices As Integer
		Dim companyName As String
		Dim cost As Double = 0

		'' -- BAR CHART --
		'Create a series for invoice counts bar chart.
		barChartControl.Series.Clear()
		barChartSeries = New Series("Invoices", ViewType.Bar)

		' Obtain number of invoices per company
		For Each companyResult As DataRow In tableNumInvoices.Rows
			numInvoices = (CType(companyResult("sum_invoices"), Integer))
			companyName = companyResult("name").ToString()
			barChartSeries.Points.Add(New SeriesPoint(companyName, numInvoices))
		Next

		' Customize bar graph
		Dim view As BarSeriesView = CType(barChartSeries.View, BarSeriesView)
		view.ColorEach = True

		Dim barLabel As BarSeriesLabel = CType(barChartSeries.Label, BarSeriesLabel)
		barLabel.TextPattern = "{A}: {V}"
		barLabel.Font = New Font("Tahoma", 8, FontStyle.Regular)

		Dim barChartTitle As New ChartTitle() With {.Text = "Number of Invoices Per Company", .Font = New Font("Tahoma", 14, FontStyle.Bold)}

		' Add customizations to barChartControl
		barChartControl.Titles.Add(barChartTitle)
		barChartControl.Series.Add(barChartSeries)


		'' -- PIE CHART --
		'Pie chart version - clone of bar graph
		pieChartControl.Series.Clear()
		pieChartSeries = CType(barChartSeries.Clone(), Series)
		pieChartSeries.ChangeView(ViewType.Pie)

		'Add customizations to pieChartControl
		Dim pieLabel As PieSeriesLabel = CType(pieChartSeries.Label, PieSeriesLabel)
		pieLabel.TextPattern = "{A}: {V} ({VP:P0})"
		pieChartControl.Series.Add(pieChartSeries)
		Dim pieChartTitle As New ChartTitle() With {.Text = "Percentage of Invoices Per Company", .Font = New Font("Tahoma", 14, FontStyle.Bold)}
		pieChartControl.Titles.Add(pieChartTitle)


		'' -- LINE GRAPH --
		'Create series for invoice cost line chart.
		costChartControl.Series.Clear()

		'Obtain total costs per companyID
		For Each companyResult As DataRow In tableTotalCosts.Rows
			cost = (CType(companyResult("total_cost"), Integer))
			companyName = companyResult("name").ToString()

			costChartSeries = New Series(companyName, ViewType.Line)
			costChartSeries.Points.Add(New SeriesPoint(companyName, cost))
			CType(costChartSeries.View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True

			costChartControl.Series.Add(costChartSeries)
		Next

		' Customize line graph
		Dim lsView As LineSeriesView = CType(lineChartSeries.View, LineSeriesView)
		lsView.ColorEach = True

		Dim costChartTitle As New ChartTitle() With {.Text = "Total Cost of Invoices Per Company"}
		costChartControl.Titles.Add(costChartTitle)


	End Sub

End Class