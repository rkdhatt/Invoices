Imports CemDB

Public Class MainReport
	Private WithEvents dbMainReport As DBDataSet
	Private tableMainReportInfo As DataTable

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		dbMainReport = New DBDataSet
		tableMainReportInfo = New DataTable
		dbMainReport.FetchStoredProcedure = "fetch_main_report"
		dbMainReport.FetchDataTable(tableMainReportInfo)

		DataSource = tableMainReportInfo

	End Sub

	Private Sub MainReport_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint

		If tableMainReportInfo.Rows.Count = 0 Then
			DevExpress.XtraEditors.XtraMessageBox.Show("No data to display!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Exit Sub
		End If

		' Use group fields if grouping by more than one attribute.
		MainGroupHeader.GroupFields.Add(New DevExpress.XtraReports.UI.GroupField("company_id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending))
	End Sub
End Class