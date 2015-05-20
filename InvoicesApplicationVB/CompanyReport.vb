Imports CemDB

Public Class CompanyReport
	Private WithEvents dbCompanyReport As DBDataSet
	Private tableCompanyReportInfo As DataTable
	Private cID As Int32

	Public Sub New(companyID As Int32)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		cID = companyID
		dbCompanyReport = New DBDataSet
		tableCompanyReportInfo = New DataTable
		dbCompanyReport.FetchStoredProcedure = "fetch_company_report"
		dbCompanyReport.FetchDataTable(tableCompanyReportInfo)
		DataSource = tableCompanyReportInfo


	End Sub

	Private Sub dbCompanyReport_BeforeFetch(sender As Object, cmd As SqlClient.SqlCommand, cancel As Cancel) Handles dbCompanyReport.BeforeFetch
		cmd.Parameters("@company_id").Value = cID
	End Sub

	Private Sub CompanyReport_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint

		' If no data available for a company, show warning message and dispose report.
		If tableCompanyReportInfo.Rows.Count = 0 Then
			DevExpress.XtraEditors.XtraMessageBox.Show("No data to display!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
			MyBase.Dispose(True)
			Return
		End If

	End Sub

End Class