Public Class frmPIDMainNew
	Private sim As Simulator
	Private pid As PIDControler

	Private Const factorP As Double = 1000
	Private Const factorI As Double = 1000
	Private Const factorD As Double = 1000
	Private Const factorPV As Double = 10
	Private Const factorCV As Double = 100
	Private Const factorSP As Double = 10
	Private Const factorGain As Double = 100

	Private Sub frmPIDMainNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sim = New Simulator()
		sim.ProcessValueLimitEnable = True
		sim.ProcessValueMin = -100.0
		sim.ProcessValueMax = +100.0

		pid = New PIDControler()
		pid.ControlValueLimitEnable = True
		pid.ControlValueMin = -1000
		pid.ControlValueMax = +1000


		tbGain.Value = 5 * factorGain
		tbGain_Scroll(sender, e)

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
		sim.ControlValue = pid.ControlValue
		UpdateParametersSimulation()

		tbCV.Value = CInt(pid.ControlValue)
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
End Class