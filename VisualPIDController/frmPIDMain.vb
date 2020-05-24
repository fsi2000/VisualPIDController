Public Class frmPIDMain
	'desired value
	Private mSetPoint As Double
	Private mActualValue As Double
	Private mError As Double

	'Constants for proportion, integral, and derivative
	Private mKp As Double
	Private mKi As Double
	Private mKd As Double

	'Proportion, last proportion, integral, and differentiation
	Private mP As Double
	Private mPLast As Double
	Private mI As Double
	Private mD As Double

	Private mInterval As Double                 'Time between updates (probably 25ms)

	Private mControlValue As Double

	Private mMin As Double
	Private mMax As Double

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadSettings()

		tmrPIDController.Start()
		tmrSimulation.Start()
	End Sub

	Private Sub LoadSettings()
		tbP.Value = My.Settings.P
		tbI.Value = My.Settings.I
		tbD.Value = My.Settings.D
		tbCV.Value = My.Settings.CV

		UpdateParameterSettings()
		UpdateParameterInput()
	End Sub

	Private Sub SaveSettings()
		My.Settings.P = tbP.Value
		My.Settings.I = tbI.Value
		My.Settings.D = tbD.Value
		My.Settings.CV = tbCV.Value
	End Sub

	Private Sub tmrPIDController_Tick(sender As Object, e As EventArgs) Handles tmrPIDController.Tick
		mInterval = ElapsedMilliseconds()

		mP = mSetPoint - mActualValue
		mI = mI + (mP * mInterval)
		mD = (mP - mPLast) / mInterval

		mPLast = mP
		mControlValue = (mP * mKp) + (mI * mKi) + (mD * mKd)

		'limit set value
		If (mControlValue < mMin) Then mControlValue = mMin
		If (mControlValue > mMax) Then mControlValue = mMax

		mError = Math.Abs(mP)       'calculate |error|

		UpdateParameterOutput()
	End Sub

	Private Function ElapsedMilliseconds() As Long
		Static lastTimestamp As Long
		Dim result As Long
		result = (System.Diagnostics.Stopwatch.GetTimestamp - lastTimestamp) * 1000 / System.Diagnostics.Stopwatch.Frequency
		lastTimestamp = System.Diagnostics.Stopwatch.GetTimestamp
		Return result
	End Function

	Private Function LimitValue(value As Double, min As Double, max As Double) As Double
		Dim tmp As Double

		tmp = value
		If tmp < min Then tmp = min
		If tmp > max Then tmp = max

		Return tmp
	End Function

	Private Sub UpdateParameterInput()
		mKp = tbP.Value / 10000
		lblP.Text = "P=" + mKp.ToString("0.000")

		mKi = tbI.Value / 10000 / 10
		lblI.Text = "I=" + mKi.ToString("0.00000")

		mKd = tbD.Value / 10000
		lblD.Text = "D=" + mKd.ToString("0.000")

		mSetPoint = tbSollwert.Value
		lblSollwert.Text = "SOLL=" + mSetPoint.ToString("0")
	End Sub

	Private Sub UpdateParameterOutput()
		tbStellgroesse.Value = LimitValue(mControlValue, tbStellgroesse.Minimum, tbStellgroesse.Maximum)
		lblStellgroesse.Text = "STELL=" + mControlValue.ToString("0")
	End Sub

	Private Sub UpdateParameterSettings()
		mMin = tbCV.Value * -1
		mMax = tbCV.Value * +1
		lblCVminmax.Text = "CV(min max)= +/-" + tbCV.Value.ToString("0")
	End Sub

	Private Sub UpdateParameterSimulation()
		Dim tmp As Double

		tbIstwert.Value = LimitValue(mActualValue, tbIstwert.Minimum, tbIstwert.Maximum)
		lblIstwert.Text = "IST=" + mActualValue.ToString("0")

		tmp = mError
		If tmp < pbFehler.Minimum Then tmp = pbFehler.Minimum
		If tmp > pbFehler.Maximum Then tmp = pbFehler.Maximum
		Label1.Text = "FEHLER=" + mError.ToString("0")
		pbFehler.Value = tmp
	End Sub

	Private Sub tbP_Scroll(sender As Object, e As EventArgs) Handles tbP.Scroll
		UpdateParameterInput()
	End Sub

	Private Sub tbI_Scroll(sender As Object, e As EventArgs) Handles tbI.Scroll
		UpdateParameterInput()
	End Sub

	Private Sub tbD_Scroll(sender As Object, e As EventArgs) Handles tbD.Scroll
		UpdateParameterInput()
	End Sub

	Private Sub tbSollwert_Scroll(sender As Object, e As EventArgs) Handles tbSollwert.Scroll
		UpdateParameterInput()
	End Sub

	Private Sub tmrSimulation_Tick(sender As Object, e As EventArgs) Handles tmrSimulation.Tick
		Dim tmp As Double

		tmp = mControlValue
		If Math.Abs(tmp) < 15 Then tmp = 0

		mActualValue = mActualValue + (tmp / 10)

		'If mActual < tbIstwert.Minimum Then mActual = tbIstwert.Minimum
		'If mActual > tbIstwert.Maximum Then mActual = tbIstwert.Maximum

		UpdateParameterSimulation()
	End Sub

	Private Sub frmPIDMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		SaveSettings()
	End Sub

	Private Sub tbCV_Scroll(sender As Object, e As EventArgs) Handles tbCV.Scroll
		UpdateParameterSettings()
	End Sub

End Class