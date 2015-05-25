<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCompanyForm
	Inherits DevExpress.XtraEditors.XtraForm

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.addCompanyLabel = New System.Windows.Forms.Label()
		Me.addCompanyTextBox = New System.Windows.Forms.TextBox()
		Me.addCompanyButton = New System.Windows.Forms.Button()
		Me.cancelAddButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'addCompanyLabel
		'
		Me.addCompanyLabel.AutoSize = True
		Me.addCompanyLabel.Location = New System.Drawing.Point(26, 19)
		Me.addCompanyLabel.Name = "addCompanyLabel"
		Me.addCompanyLabel.Size = New System.Drawing.Size(86, 13)
		Me.addCompanyLabel.TabIndex = 0
		Me.addCompanyLabel.Text = "Company Name:"
		'
		'addCompanyTextBox
		'
		Me.addCompanyTextBox.BackColor = System.Drawing.SystemColors.Window
		Me.addCompanyTextBox.Location = New System.Drawing.Point(130, 16)
		Me.addCompanyTextBox.Name = "addCompanyTextBox"
		Me.addCompanyTextBox.Size = New System.Drawing.Size(100, 21)
		Me.addCompanyTextBox.TabIndex = 7
		'
		'addCompanyButton
		'
		Me.addCompanyButton.Location = New System.Drawing.Point(49, 47)
		Me.addCompanyButton.Name = "addCompanyButton"
		Me.addCompanyButton.Size = New System.Drawing.Size(75, 23)
		Me.addCompanyButton.TabIndex = 5
		Me.addCompanyButton.Text = "Add"
		Me.addCompanyButton.UseVisualStyleBackColor = True
		'
		'cancelAddButton
		'
		Me.cancelAddButton.Location = New System.Drawing.Point(130, 47)
		Me.cancelAddButton.Name = "cancelAddButton"
		Me.cancelAddButton.Size = New System.Drawing.Size(75, 23)
		Me.cancelAddButton.TabIndex = 6
		Me.cancelAddButton.Text = "Cancel"
		Me.cancelAddButton.UseVisualStyleBackColor = True
		'
		'AddCompanyForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(269, 88)
		Me.Controls.Add(Me.addCompanyTextBox)
		Me.Controls.Add(Me.cancelAddButton)
		Me.Controls.Add(Me.addCompanyButton)
		Me.Controls.Add(Me.addCompanyLabel)
		Me.MaximumSize = New System.Drawing.Size(285, 126)
		Me.MinimumSize = New System.Drawing.Size(285, 126)
		Me.Name = "AddCompanyForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Add Company"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents addCompanyLabel As System.Windows.Forms.Label
	Friend WithEvents addCompanyTextBox As System.Windows.Forms.TextBox
	Friend WithEvents addCompanyButton As System.Windows.Forms.Button
	Friend WithEvents cancelAddButton As System.Windows.Forms.Button
End Class
