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
		Me.tmrSendScores = New System.Windows.Forms.Timer(Me.components)
		Me.chkSpeech = New System.Windows.Forms.CheckBox()
		Me.chkRestrictFullHalf = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'cmdAddScore
		'
		Me.cmdAddScore.Location = New System.Drawing.Point(84, 4)
		Me.cmdAddScore.Name = "cmdAddScore"
		Me.cmdAddScore.Size = New System.Drawing.Size(36, 23)
		Me.cmdAddScore.TabIndex = 1
		Me.cmdAddScore.Text = "add"
		Me.cmdAddScore.UseVisualStyleBackColor = True
		'
		'lstScores
		'
		Me.lstScores.FormattingEnabled = True
		Me.lstScores.IntegralHeight = False
		Me.lstScores.Location = New System.Drawing.Point(8, 32)
		Me.lstScores.MultiColumn = True
		Me.lstScores.Name = "lstScores"
		Me.lstScores.Size = New System.Drawing.Size(184, 300)
		Me.lstScores.TabIndex = 3
		'
		'txtScore
		'
		Me.txtScore.Location = New System.Drawing.Point(8, 4)
		Me.txtScore.MaxLength = 3
		Me.txtScore.Name = "txtScore"
		Me.txtScore.Size = New System.Drawing.Size(60, 20)
		Me.txtScore.TabIndex = 0
		'
		'cmdSendScore
		'
		Me.cmdSendScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.cmdSendScore.Location = New System.Drawing.Point(8, 336)
		Me.cmdSendScore.Name = "cmdSendScore"
		Me.cmdSendScore.Size = New System.Drawing.Size(76, 23)
		Me.cmdSendScore.TabIndex = 4
		Me.cmdSendScore.Text = "send"
		Me.cmdSendScore.UseVisualStyleBackColor = True
		'
		'cmdClearScore
		'
		Me.cmdClearScore.Location = New System.Drawing.Point(116, 336)
		Me.cmdClearScore.Name = "cmdClearScore"
		Me.cmdClearScore.Size = New System.Drawing.Size(76, 23)
		Me.cmdClearScore.TabIndex = 5
		Me.cmdClearScore.Text = "clear"
		Me.cmdClearScore.UseVisualStyleBackColor = True
		'
		'cmdModifyScore
		'
		Me.cmdModifyScore.Location = New System.Drawing.Point(120, 4)
		Me.cmdModifyScore.Name = "cmdModifyScore"
		Me.cmdModifyScore.Size = New System.Drawing.Size(36, 23)
		Me.cmdModifyScore.TabIndex = 6
		Me.cmdModifyScore.Text = "mod"
		Me.cmdModifyScore.UseVisualStyleBackColor = True
		'
		'cmdDeleteScore
		'
		Me.cmdDeleteScore.Location = New System.Drawing.Point(156, 4)
		Me.cmdDeleteScore.Name = "cmdDeleteScore"
		Me.cmdDeleteScore.Size = New System.Drawing.Size(36, 23)
		Me.cmdDeleteScore.TabIndex = 7
		Me.cmdDeleteScore.Text = "del"
		Me.cmdDeleteScore.UseVisualStyleBackColor = True
		'
		'tmrSendScores
		'
		Me.tmrSendScores.Interval = 1000
		'
		'chkSpeech
		'
		Me.chkSpeech.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.chkSpeech.Checked = True
		Me.chkSpeech.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkSpeech.Location = New System.Drawing.Point(8, 364)
		Me.chkSpeech.Name = "chkSpeech"
		Me.chkSpeech.Size = New System.Drawing.Size(72, 20)
		Me.chkSpeech.TabIndex = 8
		Me.chkSpeech.Text = "Audio"
		Me.chkSpeech.UseVisualStyleBackColor = True
		'
		'chkRestrictFullHalf
		'
		Me.chkRestrictFullHalf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.chkRestrictFullHalf.Checked = True
		Me.chkRestrictFullHalf.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkRestrictFullHalf.Location = New System.Drawing.Point(96, 364)
		Me.chkRestrictFullHalf.Name = "chkRestrictFullHalf"
		Me.chkRestrictFullHalf.Size = New System.Drawing.Size(96, 20)
		Me.chkRestrictFullHalf.TabIndex = 9
		Me.chkRestrictFullHalf.Text = ",0 && ,5 only"
		Me.chkRestrictFullHalf.UseVisualStyleBackColor = True
		'
		'frmDEAMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(198, 388)
		Me.Controls.Add(Me.chkRestrictFullHalf)
		Me.Controls.Add(Me.chkSpeech)
		Me.Controls.Add(Me.cmdDeleteScore)
		Me.Controls.Add(Me.cmdModifyScore)
		Me.Controls.Add(Me.cmdClearScore)
		Me.Controls.Add(Me.cmdSendScore)
		Me.Controls.Add(Me.txtScore)
		Me.Controls.Add(Me.lstScores)
		Me.Controls.Add(Me.cmdAddScore)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "frmDEAMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "EingabeAssistent v0.3 (171225)"
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
	Friend WithEvents tmrSendScores As System.Windows.Forms.Timer
	Friend WithEvents chkSpeech As CheckBox
	Friend WithEvents chkRestrictFullHalf As CheckBox
End Class
