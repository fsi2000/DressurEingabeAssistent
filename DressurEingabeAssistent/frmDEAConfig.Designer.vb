<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDEAConfig
	Inherits System.Windows.Forms.Form

	'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Wird vom Windows Form-Designer benötigt.
	Private components As System.ComponentModel.IContainer

	'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
	'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
	'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox3 = New System.Windows.Forms.CheckBox()
		Me.cmdOK = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Checked = Global.DressurEingabeAssistent.My.MySettings.Default.AudioVoice
		Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DressurEingabeAssistent.My.MySettings.Default, "AudioVoice", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox1.Location = New System.Drawing.Point(12, 12)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(151, 17)
		Me.CheckBox1.TabIndex = 0
		Me.CheckBox1.Text = "Sprachausgabe der Noten"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Checked = Global.DressurEingabeAssistent.My.MySettings.Default.AudioBeep
		Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DressurEingabeAssistent.My.MySettings.Default, "AudioBeep", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox2.Location = New System.Drawing.Point(12, 35)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(108, 17)
		Me.CheckBox2.TabIndex = 1
		Me.CheckBox2.Text = "Bestätigungstöne"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'CheckBox3
		'
		Me.CheckBox3.AutoSize = True
		Me.CheckBox3.Checked = Global.DressurEingabeAssistent.My.MySettings.Default.RestrictionFullHalf
		Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DressurEingabeAssistent.My.MySettings.Default, "RestrictionFullHalf", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox3.Location = New System.Drawing.Point(12, 58)
		Me.CheckBox3.Name = "CheckBox3"
		Me.CheckBox3.Size = New System.Drawing.Size(201, 17)
		Me.CheckBox3.TabIndex = 2
		Me.CheckBox3.Text = "Nur ganze und halbe Noten zulassen"
		Me.CheckBox3.UseVisualStyleBackColor = True
		'
		'cmdOK
		'
		Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.cmdOK.Location = New System.Drawing.Point(217, 126)
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(75, 23)
		Me.cmdOK.TabIndex = 3
		Me.cmdOK.Text = "OK"
		Me.cmdOK.UseVisualStyleBackColor = True
		'
		'frmDEAConfig
		'
		Me.AcceptButton = Me.cmdOK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(304, 161)
		Me.Controls.Add(Me.cmdOK)
		Me.Controls.Add(Me.CheckBox3)
		Me.Controls.Add(Me.CheckBox2)
		Me.Controls.Add(Me.CheckBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmDEAConfig"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Konfiguration"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents cmdOK As Button
End Class
