Public Class frmDEAMain
	Dim sendscorestate As Integer
	Private Sub frmDEAMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MoveWindowTopRight()
	End Sub

	Private Function GetScoreText(ByVal count As Integer, ByVal score As String) As String
		Return count.ToString + ": " + score
	End Function

	Private Function GetScore(ByVal s As String) As String
		Dim i As Integer
		i = s.IndexOf(":")
		Return s.Substring(i + 2, s.Length - i - 2)
	End Function

	Private Sub cmdAddScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddScore.Click
		Dim i As Integer
		Dim s As String
		Dim valid As Boolean
		Dim value As Single

		i = lstScores.Items.Count
		s = txtScore.Text

		s = s.Replace(".", ",")         'replace seperator with comma

		If s.Length = 2 Then
			s = s.Insert(1, ",")
		End If

		valid = True                                'assume input is valid

		If My.Settings.RestrictionFullHalf Then
			value = Single.Parse(s)                 'get float value
			value = value - Math.Truncate(value)    'only floating part
			If value > 0 And value < 0.5 Then
				valid = False
			End If
			If value > 0.5 Then
				valid = False
			End If
		End If

		If s = "" Then
			valid = False
		End If

		If valid Then
			lstScores.Items.Add(GetScoreText(i + 1, s))
			PlayAudioSample(Samples.beep)
		Else
			PlayAudioSample(Samples.beepLow)
		End If

		txtScore.Focus()
		txtScore.SelectAll()
	End Sub

	Private Sub txtScore_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtScore.KeyDown
		If e.KeyCode = Keys.Enter Then
			e.Handled = True
			e.SuppressKeyPress = True
			cmdAddScore_Click(sender, e)
		End If

		If e.KeyCode = Keys.D0 Or e.KeyCode = Keys.NumPad0 Then PlayAudioSample(Samples.null)
		If e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1 Then PlayAudioSample(Samples.eins)
		If e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad2 Then PlayAudioSample(Samples.zwei)
		If e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad3 Then PlayAudioSample(Samples.drei)
		If e.KeyCode = Keys.D4 Or e.KeyCode = Keys.NumPad4 Then PlayAudioSample(Samples.vier)
		If e.KeyCode = Keys.D5 Or e.KeyCode = Keys.NumPad5 Then PlayAudioSample(Samples.fuenf)
		If e.KeyCode = Keys.D6 Or e.KeyCode = Keys.NumPad6 Then PlayAudioSample(Samples.sechs)
		If e.KeyCode = Keys.D7 Or e.KeyCode = Keys.NumPad7 Then PlayAudioSample(Samples.sieben)
		If e.KeyCode = Keys.D8 Or e.KeyCode = Keys.NumPad8 Then PlayAudioSample(Samples.acht)
		If e.KeyCode = Keys.D9 Or e.KeyCode = Keys.NumPad9 Then PlayAudioSample(Samples.neun)
		If e.KeyCode = Keys.Oemcomma Or e.KeyCode = Keys.Decimal Then PlayAudioSample(Samples.komma)
		If e.KeyCode = Keys.Back Then PlayAudioSample(Samples.beepLow)
	End Sub

	Private Sub PlayAudioSample(audio As Audio.Samples)
		If My.Settings.AudioBeep Then
			Select Case audio
				Case Samples.beep : My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
				Case Samples.beepLow : My.Computer.Audio.Play(My.Resources.beep_low, AudioPlayMode.Background)
			End Select
		End If

		If My.Settings.AudioVoice Then
			Select Case audio
				Case Samples.null : My.Computer.Audio.Play(My.Resources.null, AudioPlayMode.Background)
				Case Samples.eins : My.Computer.Audio.Play(My.Resources.eins, AudioPlayMode.Background)
				Case Samples.zwei : My.Computer.Audio.Play(My.Resources.zwei, AudioPlayMode.Background)
				Case Samples.drei : My.Computer.Audio.Play(My.Resources.drei, AudioPlayMode.Background)
				Case Samples.vier : My.Computer.Audio.Play(My.Resources.vier, AudioPlayMode.Background)
				Case Samples.fuenf : My.Computer.Audio.Play(My.Resources.fuenf, AudioPlayMode.Background)
				Case Samples.sechs : My.Computer.Audio.Play(My.Resources.sechs, AudioPlayMode.Background)
				Case Samples.sieben : My.Computer.Audio.Play(My.Resources.sieben, AudioPlayMode.Background)
				Case Samples.acht : My.Computer.Audio.Play(My.Resources.acht, AudioPlayMode.Background)
				Case Samples.neun : My.Computer.Audio.Play(My.Resources.neun, AudioPlayMode.Background)
				Case Samples.komma : My.Computer.Audio.Play(My.Resources.komma, AudioPlayMode.Background)
			End Select
		End If
	End Sub

	Private Sub lstScores_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstScores.DoubleClick
		Dim s As String
		s = lstScores.Items(lstScores.SelectedIndex)

		txtScore.Text = GetScore(s)

		txtScore.Focus()
		txtScore.SelectAll()
	End Sub

	Private Sub cmdModifyScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModifyScore.Click
		Dim i As Integer
		Dim s As String

		i = lstScores.SelectedIndex
		s = txtScore.Text

		If s.Length = 2 Then
			s = s.Insert(1, ",")
		End If

		lstScores.Items(i) = GetScoreText(i + 1, s)

		txtScore.Focus()
		txtScore.SelectAll()
	End Sub

	Private Sub cmdDeleteScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteScore.Click
		Dim i As Integer

		i = lstScores.SelectedIndex
		If i <> -1 Then
			If MessageBox.Show("Eintrag löschen?", "Bestätigung", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
				lstScores.Items.RemoveAt(i)
			End If
		End If
	End Sub

	Private Sub cmdClearScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearScore.Click
		If MessageBox.Show("Alles löschen?", "Bestätigung", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
			lstScores.Items.Clear()
		End If
	End Sub

	Private Sub cmdSendScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendScore.Click
		sendscorestate = 1
		tmrAutomation.Start()
	End Sub

#Region "Automation"
	Private Sub AutomationSwitchToTORIS()
		SendKeys.Send("%{Tab}")
	End Sub

	Private Sub AutomationSendValuesToTORIS()
		Dim i As Integer
		Dim s As String

		For i = 0 To lstScores.Items.Count - 1
			lstScores.SelectedIndex = i
			s = lstScores.Items(i)
			s = GetScore(s)
			SendKeys.Send(s)
			SendKeys.Send("{ENTER}")
			LongDelay(30000)
		Next
	End Sub

	Private Sub AutomationSwitchBackToDEA()
		SendKeys.Send("%{Tab}")
	End Sub
#End Region

	Private Sub tmrAutomation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutomation.Tick
		tmrAutomation.Stop()

		Select Case sendscorestate
			Case 1
				AutomationSwitchToTORIS()
			Case 2
				AutomationSendValuesToTORIS()
			Case 3
				AutomationSwitchBackToDEA()
		End Select

		sendscorestate = sendscorestate + 1
		If sendscorestate > 100 Then sendscorestate = 100

		tmrAutomation.Start()
	End Sub

	Private Sub MoveWindowTopRight()
		Dim scr = Screen.FromPoint(Me.Location)
		Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Top)
	End Sub

	Private Sub LongDelay(count As Integer)
		Dim i As Integer
		Dim j As Integer

		For i = 0 To count
			For j = 0 To 7
				Application.DoEvents()
			Next
		Next
	End Sub

	Private Sub cmdConfig_Click(sender As Object, e As EventArgs) Handles cmdConfig.Click
		frmDEAConfig.ShowDialog()
	End Sub
End Class
