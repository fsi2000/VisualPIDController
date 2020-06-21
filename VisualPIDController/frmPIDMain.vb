Public Class frmPIDMain
	Private sim As Simulator
	Private pid As PIDControler

	Private factorP As Double
	Private factorI As Double
	Private factorD As Double
	Private factorSP As Double
	Private factorPV As Double
	Private factorCV As Double
	Private factorGain As Double

	Private Sub LoadSettings()
		tbP.Value = LimitValueInt(My.Settings.P * factorP, tbP.Minimum, tbP.Maximum)
		tbI.Value = LimitValueInt(My.Settings.I * factorI, tbI.Minimum, tbI.Maximum)
		tbD.Value = LimitValueInt(My.Settings.D * factorD, tbD.Minimum, tbD.Maximum)
		tbCV.Value = LimitValueInt(My.Settings.CV * factorCV, tbCV.Minimum, tbCV.Maximum)
		tbSP.Value = LimitValueInt(My.Settings.SP * factorSP, tbSP.Minimum, tbSP.Maximum)
		tbPV.Value = LimitValueInt(My.Settings.PV * factorPV, tbPV.Minimum, tbPV.Maximum)
		tbGain.Value = LimitValueInt(My.Settings.Gain * factorGain, tbGain.Minimum, tbGain.Maximum)

		pid.AntiWindUpEnable = My.Settings.AntiWindUp
	End Sub

	Private Sub SaveSettings()
		My.Settings.P = pid.kP
		My.Settings.I = pid.kI
		My.Settings.D = pid.kD
		My.Settings.CV = sim.ControlValue
		My.Settings.SP = pid.SetPointValue
		My.Settings.PV = sim.ProcessValue
		My.Settings.Gain = sim.Gain

		My.Settings.AntiWindUp = pid.AntiWindUpEnable
	End Sub

	Private Sub CalculateFactors()
		factorP = tbP.Maximum / 5
		factorI = tbI.Maximum / 5
		factorD = tbD.Maximum / 2
		factorSP = tbSP.Maximum / 100
		factorPV = tbPV.Maximum / 100
		factorCV = tbCV.Maximum / 100
		factorGain = tbGain.Maximum / 5
	End Sub

	Private Sub InitSimulator()
		sim = New Simulator()
		sim.ProcessValueLimitEnable = True
		sim.ProcessValueMin = -100.0
		sim.ProcessValueMax = +100.0

		sim.ThresholdEnable = True
		sim.ThresholdValue = 5
	End Sub

	Private Sub InitPID()
		pid = New PIDControler()
		pid.ControlValueLimitEnable = False
		pid.ControlValueMin = -1000
		pid.ControlValueMax = +1000

		pid.AntiWindUpEnable = False
		pid.AntiWindUpMin = -100
		pid.AntiWindUpMax = +100
	End Sub

	Private Sub frmPIDMainNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CalculateFactors()

		InitSimulator()

		InitPID()
		LoadSettings()
	End Sub

	Private Sub tmrSimulation_Tick(sender As Object, e As EventArgs) Handles tmrSimulation.Tick
		sim.UpdateInterval()
		sim.Calculate()
		tbPV.Value = LimitValueInt(CInt(sim.ProcessValue * factorPV), tbPV.Minimum, tbPV.Maximum)
		UpdateTextSimulation()
	End Sub

	Private Sub tmrController_Tick(sender As Object, e As EventArgs) Handles tmrController.Tick
		pid.ProcessValue = sim.ProcessValue
		pid.UpdateInterval()
		pid.Calculate()
		tbCV.Value = LimitValueInt(CInt(pid.ControlValue), tbCV.Minimum, tbCV.Maximum)

		sim.ControlValue = pid.ControlValue

		UpdateTextSimulation()
		UpdateParametersPIDInternals()
	End Sub

	Private Sub UpdateTextPID()
		lblP.Text = "kP= " + pid.kP.ToString("0.000")
		lblI.Text = "kI= " + pid.kI.ToString("0.000")
		lblD.Text = "kD= " + pid.kD.ToString("0.000")
	End Sub

	Private Sub UpdateTextSimulation()
		lblSP.Text = "SP= " + pid.SetPointValue.ToString("0.00")
		lblPV.Text = "PV= " + sim.ProcessValue.ToString("0.00")
		lblCV.Text = "CV= " + sim.ControlValue.ToString("0.00")
		lblGain.Text = "GAIN= " + sim.Gain.ToString("0.00")
	End Sub

	Private Sub UpdateParametersPIDInternals()
		pbP.Value = GetProgressbarValue(pid.mP, -100, +100, pbP.Maximum)
		pbI.Value = GetProgressbarValue(pid.mI, -100, +100, pbI.Maximum)
		pbD.Value = GetProgressbarValue(pid.mD, -100, +100, pbD.Maximum)

		lblMP.Text = "mP= " + pid.mP.ToString("0.000")
		lblMI.Text = "mI= " + pid.mI.ToString("0.000")
		lblMD.Text = "mD= " + pid.mD.ToString("0.000")
	End Sub

	Private Function LimitValueInt(value As Integer, min As Integer, max As Integer) As Integer
		Dim result As Integer

		result = value
		If result < min Then result = min
		If result > max Then result = max
		Return result
	End Function

	Private Function GetProgressbarValue(value As Integer, min As Integer, max As Integer, range As Integer) As Integer
		Dim result As Integer

		result = LimitValueInt(value, min, max)

		result = result * (range / max)
		result = result / 2
		result = result + (range / 2)

		Return result
	End Function

	Private Sub tbP_ValueChanged(sender As Object, e As EventArgs) Handles tbP.ValueChanged
		pid.kP = tbP.Value / factorP
		UpdateTextPID()
	End Sub

	Private Sub tbI_ValueChanged(sender As Object, e As EventArgs) Handles tbI.ValueChanged
		pid.Ki = tbI.Value / factorI
		UpdateTextPID()
	End Sub

	Private Sub tbD_ValueChanged(sender As Object, e As EventArgs) Handles tbD.ValueChanged
		pid.Kd = tbD.Value / factorD
		UpdateTextPID()
	End Sub

	Private Sub tbSP_ValueChanged(sender As Object, e As EventArgs) Handles tbSP.ValueChanged
		pid.SetPointValue = tbSP.Value / factorSP
		UpdateTextSimulation()
	End Sub

	Private Sub tbPV_ValueChanged(sender As Object, e As EventArgs) Handles tbPV.ValueChanged
		sim.ProcessValue = tbPV.Value / factorPV
		pid.ProcessValue = tbPV.Value / factorPV
		UpdateTextSimulation()
	End Sub

	Private Sub tbCV_ValueChanged(sender As Object, e As EventArgs) Handles tbCV.ValueChanged
		sim.ControlValue = tbCV.Value / factorCV
		UpdateTextSimulation()
	End Sub

	Private Sub tbGain_ValueChanged(sender As Object, e As EventArgs) Handles tbGain.ValueChanged
		sim.Gain = tbGain.Value / factorGain
		UpdateTextSimulation()
	End Sub

	Private Sub chkPIDController_CheckedChanged(sender As Object, e As EventArgs) Handles chkPIDController.CheckedChanged
	End Sub

	Private Sub frmPIDMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		SaveSettings()
	End Sub

	Private Sub chkAntiWindUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkAntiWindUp.CheckedChanged
	End Sub

	Private Sub chkPIDController_Click(sender As Object, e As EventArgs) Handles chkPIDController.Click
		tmrController.Enabled = chkPIDController.Checked
		gbParameterPID.Enabled = chkPIDController.Checked
	End Sub

	Private Sub chkAntiWindUp_Click(sender As Object, e As EventArgs) Handles chkAntiWindUp.Click
		pid.AntiWindUpEnable = chkAntiWindUp.Checked
	End Sub

	Private Sub cmdResetPID_Click(sender As Object, e As EventArgs) Handles cmdResetPID.Click
		pid.Reset(True, True, True)
	End Sub
End Class