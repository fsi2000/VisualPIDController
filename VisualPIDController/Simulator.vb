Public Class Simulator
	Public Property ProcessValue As Double = 0.0
	Public Property ControlValue As Double = 0.0

	Public Property Gain As Double = 1.0

	Public Property Interval As Double = 1

	Public Property ProcessValueLimitEnable As Boolean = False
	Public Property ProcessValueMin As Double = -100.0
	Public Property ProcessValueMax As Double = +100.0

	Public Property ThresholdEnable As Boolean = False
	Public Property ThresholdValue As Double = 0.0

	Private swt As StopwatchTimer

	Public Sub New()
		Me.swt = New StopwatchTimer(StopwatchTimer.TimerResolution.ms)
	End Sub

	Public Sub New(ProcessValue As Double)
		Me.New()
		Me.ProcessValue = ProcessValue
	End Sub

	Public Sub New(ProcessValue As Double, Threshold As Double)
		Me.New(ProcessValue)
		Me.ThresholdEnable = True
		Me.ThresholdValue = Threshold
	End Sub

	Public Sub New(ProcessValue As Double, ProcessValueMin As Double, ProcessValueMax As Double)
		Me.New(ProcessValue)
		Me.ProcessValueLimitEnable = True
		Me.ProcessValueMin = ProcessValueMin
		Me.ProcessValueMax = ProcessValueMax
	End Sub

	Public Sub UpdateInterval()
		Me.Interval = (swt.TicksPerSecond / swt.ElapsedTime)
	End Sub

	Public Sub Calculate()
		Dim cv As Double
		Dim pv As Double

		cv = Me.ControlValue

		If Me.ThresholdEnable Then
			If Math.Abs(cv) < Me.ThresholdValue Then cv = 0.0
		End If

		pv = Me.ProcessValue + (cv * Me.Gain / Me.Interval)

		If Me.ProcessValueLimitEnable Then
			If pv < Me.ProcessValueMin Then pv = Me.ProcessValueMin
			If pv > Me.ProcessValueMax Then pv = Me.ProcessValueMax
		End If

		Me.ProcessValue = pv
	End Sub

	Public Sub Calculate(ControlValue As Double)
		Me.ControlValue = ControlValue
		Me.Calculate()
	End Sub
End Class
