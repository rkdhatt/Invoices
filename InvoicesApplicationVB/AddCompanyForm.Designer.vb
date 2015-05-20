<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCompanyForm
	Inherits System.Windows.Forms.Form

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
		Me.addCompanyRequestLabel = New System.Windows.Forms.Label()
		Me.addCompanyTextBox = New System.Windows.Forms.TextBox()
		Me.addCompanyButton = New System.Windows.Forms.Button()
		Me.cancelAddCompanyButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'addCompanyRequestLabel
		'
		Me.addCompanyRequestLabel.AutoSize = True
		Me.addCompanyRequestLabel.Location = New System.Drawing.Point(12, 9)
		Me.addCompanyRequestLabel.Name = "addCompanyRequestLabel"
		Me.addCompanyRequestLabel.Size = New System.Drawing.Size(85, 13)
		Me.addCompanyRequestLabel.TabIndex = 1
		Me.addCompanyRequestLabel.Text = "Company Name:"
		'
		'addCompanyTextBox
		'
		Me.addCompanyTextBox.BackColor = System.Drawing.SystemColors.Window
		Me.addCompanyTextBox.Location = New System.Drawing.Point(120, 6)
		Me.addCompanyTextBox.Name = "addCompanyTextBox"
		Me.addCompanyTextBox.Size = New System.Drawing.Size(100, 20)
		Me.addCompanyTextBox.TabIndex = 2
		'
		'addCompanyButton
		'
		Me.addCompanyButton.Location = New System.Drawing.Point(42, 40)
		Me.addCompanyButton.Name = "addCompanyButton"
		Me.addCompanyButton.Size = New System.Drawing.Size(75, 23)
		Me.addCompanyButton.TabIndex = 3
		Me.addCompanyButton.Text = "Add"
		Me.addCompanyButton.UseVisualStyleBackColor = True
		'
		'cancelAddCompanyButton
		'
		Me.cancelAddCompanyButton.Location = New System.Drawing.Point(123, 40)
		Me.cancelAddCompanyButton.Name = "cancelAddCompanyButton"
		Me.cancelAddCompanyButton.Size = New System.Drawing.Size(75, 23)
		Me.cancelAddCompanyButton.TabIndex = 4
		Me.cancelAddCompanyButton.Text = "Cancel"
		Me.cancelAddCompanyButton.UseVisualStyleBackColor = True
		'
		'addCompanyForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(254, 75)
		Me.ControlBox = False
		Me.Controls.Add(Me.cancelAddCompanyButton)
		Me.Controls.Add(Me.addCompanyButton)
		Me.Controls.Add(Me.addCompanyTextBox)
		Me.Controls.Add(Me.addCompanyRequestLabel)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "addCompanyForm"
		Me.Text = "Add Company"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents addCompanyRequestLabel As System.Windows.Forms.Label
	Friend WithEvents addCompanyTextBox As System.Windows.Forms.TextBox
	Friend WithEvents addCompanyButton As System.Windows.Forms.Button
	Friend WithEvents cancelAddCompanyButton As System.Windows.Forms.Button
End Class
