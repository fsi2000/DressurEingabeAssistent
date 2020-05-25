Public Class frmDEAMain
	Dim sendscorestate As Integer

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
		Dim s2 As String

		i = lstScores.Items.Count
		s = txtScore.Text

		If s.Length = 2 Then
			s = s.Insert(1, ",")
		End If

		valid = True

		If chkRestrictFullHalf.Checked Then
			s2 = s.Replace(",", ".")
			value = Single.Parse(s2)
			value = value - Math.Truncate(value)
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
			My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
		Else
			My.Computer.Audio.Play(My.Resources.beep_low, AudioPlayMode.Background)
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

		If chkSpeech.Checked Then
			If e.KeyCode = Keys.D0 Or e.KeyCode = Keys.NumPad0 Then
				My.Computer.Audio.Play(My.Resources.null, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1 Then
				My.Computer.Audio.Play(My.Resources.eins, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad2 Then
				My.Computer.Audio.Play(My.Resources.zwei, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad3 Then
				My.Computer.Audio.Play(My.Resources.drei, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.D4 Or e.KeyCode = Keys.NumPad4 Then
				My.Computer.Audio.Play(My.Resources.vier, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.D5 Or e.KeyCode = Keys.NumPad5 Then
				My.Computer.Audio.Play(My.Resources.fuenf, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.D6 Or e.KeyCode = Keys.NumPad6 Then
				My.Computer.Audio.Play(My.Resources.sechs, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.D7 Or e.KeyCode = Keys.NumPad7 Then
				My.Computer.Audio.Play(My.Resources.sieben, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.D8 Or e.KeyCode = Keys.NumPad8 Then
				My.Computer.Audio.Play(My.Resources.acht, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.D9 Or e.KeyCode = Keys.NumPad9 Then
				My.Computer.Audio.Play(My.Resources.neun, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.Oemcomma Or e.KeyCode = Keys.Decimal Then
				My.Computer.Audio.Play(My.Resources.komma, AudioPlayMode.Background)
			End If
			If e.KeyCode = Keys.Back Then
				My.Computer.Audio.Play(My.Resources.beep_low, AudioPlayMode.Background)
			End If
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
		tmrSendScores.Start()
	End Sub

	Private Sub AutomationSwitchToTORIS()
		SendKeys.Send("%{Tab}")
	End Sub

	Private Sub AutomationSendValuesToTORIS()
		Dim i As Integer
		Dim j As Integer
		Dim s As String

		For i = 0 To lstScores.Items.Count - 1
			lstScores.SelectedIndex = i
			s = lstScores.Items(i)
			s = GetScore(s)
			SendKeys.Send(s)
			SendKeys.Send("{ENTER}")
			For j = 0 To 30000 : Application.DoEvents() : Application.DoEvents() : Application.DoEvents() : Next
		Next
	End Sub

	Private Sub AutomationSwitchBackToDEA()
		SendKeys.Send("%{Tab}")
	End Sub

	Private Sub tmrSendScores_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSendScores.Tick
		tmrSendScores.Stop()

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

		tmrSendScores.Start()
	End Sub
End Class
