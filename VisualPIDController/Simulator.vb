Public Class Simulator
	Public Property ProcessValue As Double
	Public Property ControlValue As Double

	Public Property Gain As Double

	Public Property Interval As Double

	Public Property ProcessValueLimitEnable As Boolean
	Public Property ProcessValueMin As Double
	Public Property ProcessValueMax As Double

	Public Property ThresholdEnable As Boolean
	Public Property ThresholdValue As Double

	Private swt As StopwatchTimer

	Public Sub New()
		Me.ProcessValue = 0.0
		Me.ControlValue = 0.0

		Me.Interval = 1.0
		Me.Gain = 1.0

		Me.ProcessValueLimitEnable = False
		Me.ProcessValueMin = -128.0
		Me.ProcessValueMax = +128.0

		Me.ThresholdEnable = False
		Me.ThresholdValue = 0.0

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
