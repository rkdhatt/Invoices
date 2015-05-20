Imports CemDB

Public Class addCompanyForm

	Private Sub addCompanyDialogBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub addCompanyButton_Click(sender As Object, e As EventArgs) Handles addCompanyButton.Click
		If (addCompanyTextBox.TextLength() = 0) Then
			MessageBox.Show("Cannot enter blank company name.", "Company Name Error", MessageBoxButtons.OK)
			Return
		End If

		' Create sql to add new company
		Dim cmd As System.Data.SqlClient.SqlCommand = DBControl.GetStoredProcCmd("add_company")

		' Grab name from addCompanyTextBox to be added and execute add_company stored procedure
		cmd.Parameters("@name").Value = addCompanyTextBox.Text
		DBControl.ExecuteCommand(cmd)
		Me.DialogResult = DialogResult.OK
		Return

	End Sub

	Private Sub cancelAddCompanyButton_Click(sender As Object, e As EventArgs) Handles cancelAddCompanyButton.Click
		Me.Close()
	End Sub
End Class