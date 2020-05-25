<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDEAMain
	Inherits System.Windows.Forms.Form

	'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

	'Wird vom Windows Form-Designer benötigt.
	Private components As System.ComponentModel.IContainer

	'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
	'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
	'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdAddScore = New System.Windows.Forms.Button()
		Me.lstScores = New System.Windows.Forms.ListBox()
		Me.txtScore = New System.Windows.Forms.TextBox()
		Me.cmdSendScore = New System.Windows.Forms.Button()
		Me.cmdClearScore = New System.Windows.Forms.Button()
		Me.cmdModifyScore = New System.Windows.Forms.Button()
		Me.cmdDeleteScore = New System.Windows.Forms.Button()
		Me.tmrAutomation = New System.Windows.Forms.Timer(Me.components)
		Me.cmdConfig = New System.Windows.Forms.Button()
		Me.ttToolTips = New System.Windows.Forms.ToolTip(Me.components)
		Me.SuspendLayout()
		'
		'cmdAddScore
		'
		Me.cmdAddScore.Location = New System.Drawing.Point(8, 38)
		Me.cmdAddScore.Name = "cmdAddScore"
		Me.cmdAddScore.Size = New System.Drawing.Size(36, 23)
		Me.cmdAddScore.TabIndex = 1
		Me.cmdAddScore.Text = "+"
		Me.ttToolTips.SetToolTip(Me.cmdAddScore, "Wertnote hinzufügen")
		Me.cmdAddScore.UseVisualStyleBackColor = True
		'
		'lstScores
		'
		Me.lstScores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstScores.ColumnWidth = 60
		Me.lstScores.FormattingEnabled = True
		Me.lstScores.IntegralHeight = False
		Me.lstScores.Location = New System.Drawing.Point(8, 67)
		Me.lstScores.MultiColumn = True
		Me.lstScores.Name = "lstScores"
		Me.lstScores.Size = New System.Drawing.Size(130, 243)
		Me.lstScores.TabIndex = 4
		'
		'txtScore
		'
		Me.txtScore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtScore.Location = New System.Drawing.Point(8, 12)
		Me.txtScore.MaxLength = 3
		Me.txtScore.Name = "txtScore"
		Me.txtScore.Size = New System.Drawing.Size(130, 20)
		Me.txtScore.TabIndex = 0
		Me.ttToolTips.SetToolTip(Me.txtScore, "Eingabefeld für Wertnote")
		'
		'cmdSendScore
		'
		Me.cmdSendScore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdSendScore.Location = New System.Drawing.Point(8, 316)
		Me.cmdSendScore.Name = "cmdSendScore"
		Me.cmdSendScore.Size = New System.Drawing.Size(130, 23)
		Me.cmdSendScore.TabIndex = 5
		Me.cmdSendScore.Text = "senden"
		Me.ttToolTips.SetToolTip(Me.cmdSendScore, "Wertnoten an TORIS senden")
		Me.cmdSendScore.UseVisualStyleBackColor = True
		'
		'cmdClearScore
		'
		Me.cmdClearScore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdClearScore.Location = New System.Drawing.Point(8, 345)
		Me.cmdClearScore.Name = "cmdClearScore"
		Me.cmdClearScore.Size = New System.Drawing.Size(130, 23)
		Me.cmdClearScore.TabIndex = 6
		Me.cmdClearScore.Text = "löschen"
		Me.ttToolTips.SetToolTip(Me.cmdClearScore, "Lister der Wertnoten löschen")
		Me.cmdClearScore.UseVisualStyleBackColor = True
		'
		'cmdModifyScore
		'
		Me.cmdModifyScore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdModifyScore.Location = New System.Drawing.Point(50, 38)
		Me.cmdModifyScore.Name = "cmdModifyScore"
		Me.cmdModifyScore.Size = New System.Drawing.Size(46, 23)
		Me.cmdModifyScore.TabIndex = 2
		Me.cmdModifyScore.Text = "<>"
		Me.ttToolTips.SetToolTip(Me.cmdModifyScore, "AUsgewählte Wertnoet ändern")
		Me.cmdModifyScore.UseVisualStyleBackColor = True
		'
		'cmdDeleteScore
		'
		Me.cmdDeleteScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdDeleteScore.Location = New System.Drawing.Point(102, 38)
		Me.cmdDeleteScore.Name = "cmdDeleteScore"
		Me.cmdDeleteScore.Size = New System.Drawing.Size(36, 23)
		Me.cmdDeleteScore.TabIndex = 3
		Me.cmdDeleteScore.Text = "-"
		Me.ttToolTips.SetToolTip(Me.cmdDeleteScore, "Ausgewählte Wertnote entfernen")
		Me.cmdDeleteScore.UseVisualStyleBackColor = True
		'
		'tmrAutomation
		'
		Me.tmrAutomation.Interval = 1000
		'
		'cmdConfig
		'
		Me.cmdConfig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdConfig.Location = New System.Drawing.Point(8, 396)
		Me.cmdConfig.Name = "cmdConfig"
		Me.cmdConfig.Size = New System.Drawing.Size(130, 23)
		Me.cmdConfig.TabIndex = 9
		Me.cmdConfig.Text = "Konfiguration"
		Me.ttToolTips.SetToolTip(Me.cmdConfig, "Konfigurationsdialog öffnen")
		Me.cmdConfig.UseVisualStyleBackColor = True
		'
		'frmDEAMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(144, 431)
		Me.Controls.Add(Me.cmdConfig)
		Me.Controls.Add(Me.cmdDeleteScore)
		Me.Controls.Add(Me.cmdModifyScore)
		Me.Controls.Add(Me.cmdClearScore)
		Me.Controls.Add(Me.cmdSendScore)
		Me.Controls.Add(Me.txtScore)
		Me.Controls.Add(Me.cmdAddScore)
		Me.Controls.Add(Me.lstScores)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(160, 470)
		Me.Name = "frmDEAMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "DEA v0.4 (v2005)"
		Me.TopMost = True
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents cmdAddScore As System.Windows.Forms.Button
	Friend WithEvents lstScores As System.Windows.Forms.ListBox
	Friend WithEvents txtScore As System.Windows.Forms.TextBox
	Friend WithEvents cmdSendScore As System.Windows.Forms.Button
	Friend WithEvents cmdClearScore As System.Windows.Forms.Button
	Friend WithEvents cmdModifyScore As System.Windows.Forms.Button
	Friend WithEvents cmdDeleteScore As System.Windows.Forms.Button
	Friend WithEvents tmrAutomation As System.Windows.Forms.Timer
    Friend WithEvents cmdConfig As Button
	Friend WithEvents ttToolTips As ToolTip
End Class
