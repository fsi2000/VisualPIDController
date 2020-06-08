Public Class frmPIDMain
	Private sim As Simulator
	Private pid As PIDControler

	Private Const factorP As Double = (10000 / 5)
	Private Const factorI As Double = (10000 / 5)
	Private Const factorD As Double = (10000 / 5)
	Private Const factorSP As Double = (1000 / 100)
	Private Const factorPV As Double = (1000 / 100)
	Private Const factorCV As Double = (1000 / 100)
	Private Const factorGain As Double = (1000 / 5)

	Private Sub LoadSettings()
		tbP.Value = My.Settings.P * factorP
		tbI.Value = My.Settings.I * factorI
		tbD.Value = My.Settings.D * factorD
		tbCV.Value = My.Settings.CV * factorCV
		tbSP.Value = My.Settings.SP * factorSP
		tbPV.Value = My.Settings.PV * factorPV
	End Sub

	Private Sub SaveSettings()
		My.Settings.P = tbP.Value / factorP
		My.Settings.I = tbI.Value / factorI
		My.Settings.D = tbD.Value / factorD
		My.Settings.CV = tbCV.Value / factorCV
		My.Settings.SP = tbSP.Value / factorSP
		My.Settings.PV = tbPV.Value / factorPV
	End Sub

	Private Sub frmPIDMainNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sim = New Simulator()
		sim.ProcessValueLimitEnable = True
		sim.ProcessValueMin = -100.0
		sim.ProcessValueMax = +100.0

		sim.Gain = 1.0

		sim.ThresholdEnable = True
		sim.ThresholdValue = 5

		pid = New PIDControler()
		pid.ControlValueLimitEnable = True
		pid.ControlValueMin = -1000
		pid.ControlValueMax = +1000

		pid.AntiWindUpEnable = False
		pid.AntiWindUpMin = -100
		pid.AntiWindUpMax = +100

		UpdateParametersPID()
		UpdateParametersSimulation()
	End Sub

	Private Sub tmrSimulation_Tick(sender As Object, e As EventArgs) Handles tmrSimulation.Tick
		sim.UpdateInterval()
		sim.Calculate()
		tbPV.Value = (sim.ProcessValue * factorPV)
		UpdateParametersSimulation()
	End Sub

	Private Sub tmrController_Tick(sender As Object, e As EventArgs) Handles tmrController.Tick
		pid.ProcessValue = sim.ProcessValue
		pid.UpdateInterval()
		pid.Calculate()
		tbCV.Value = CInt(pid.ControlValue)

		sim.ControlValue = pid.ControlValue
		UpdateParametersSimulation()


		Me.Text = pid.Interval.ToString + " / " + pid.mP.ToString("0.000") + " / " + pid.mI.ToString("0.000") + " / " + pid.mD.ToString("0.000")
		UpdateParametersPIDInternals()
	End Sub

	Private Sub UpdateParametersPID()
		lblP.Text = "P= " + pid.Kp.ToString("0.000")
		lblI.Text = "I= " + pid.Ki.ToString("0.000")
		lblD.Text = "D= " + pid.Kd.ToString("0.000")
	End Sub

	Private Sub UpdateParametersSimulation()
		lblSP.Text = "SP= " + pid.SetPointValue.ToString("0.00")
		lblPV.Text = "PV= " + sim.ProcessValue.ToString("0.00")
		lblCV.Text = "CV= " + sim.ControlValue.ToString("0.00")
		lblGain.Text = "GAIN= " + sim.Gain.ToString("0.00")
	End Sub

	Private Function GetProgressbarValue(value As Double, minmax As Integer, range As Integer) As Double
		Dim result As Integer

		result = value
		If result < (minmax * -1) Then result = (minmax * -1)
		If result > (minmax * +1) Then result = (minmax * +1)

		result = result * (range / minmax)
		result = result / 2
		result = result + (range / 2)

		Return result
	End Function

	Private Sub UpdateParametersPIDInternals()
		pbP.Value = GetProgressbarValue(pid.mP, 100, pbP.Maximum)
		pbI.Value = GetProgressbarValue(pid.mI, 100, pbI.Maximum)
		pbD.Value = GetProgressbarValue(pid.mD, 100, pbD.Maximum)
	End Sub

	Private Sub tbP_Scroll(sender As Object, e As EventArgs) Handles tbP.Scroll
		pid.Kp = tbP.Value / factorP
		UpdateParametersPID()
	End Sub

	Private Sub tbI_Scroll(sender As Object, e As EventArgs) Handles tbI.Scroll
		pid.Ki = tbI.Value / factorI
		UpdateParametersPID()
	End Sub

	Private Sub tbD_Scroll(sender As Object, e As EventArgs) Handles tbD.Scroll
		pid.Kd = tbD.Value / factorD
		UpdateParametersPID()
	End Sub

	Private Sub tbSP_Scroll(sender As Object, e As EventArgs) Handles tbSP.Scroll
		pid.SetPointValue = tbSP.Value / factorSP
		UpdateParametersSimulation()
	End Sub

	Private Sub tbPV_Scroll(sender As Object, e As EventArgs) Handles tbPV.Scroll
		sim.ProcessValue = tbPV.Value / factorPV
		pid.ProcessValue = tbPV.Value / factorPV
		UpdateParametersSimulation()
	End Sub

	Private Sub tbCV_Scroll(sender As Object, e As EventArgs) Handles tbCV.Scroll
		sim.ControlValue = tbCV.Value / factorCV
		UpdateParametersSimulation()
	End Sub

	Private Sub tbGain_Scroll(sender As Object, e As EventArgs) Handles tbGain.Scroll
		sim.Gain = tbGain.Value / factorGain
		UpdateParametersSimulation()
		If sim.Gain = 0 Then
			lblGain.BackColor = Color.Red
		Else
			lblGain.BackColor = SystemColors.Control
		End If
	End Sub

	Private Sub chkPIDController_CheckedChanged(sender As Object, e As EventArgs) Handles chkPIDController.CheckedChanged
		tmrController.Enabled = chkPIDController.Checked
	End Sub

	Private Sub frmPIDMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		SaveSettings()
	End Sub

	Private Sub chkAntiWindUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkAntiWindUp.CheckedChanged
		pid.AntiWindUpEnable = chkAntiWindUp.Checked
	End Sub
End Class