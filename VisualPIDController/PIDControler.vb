Public Class PIDControler
	Public Property Kp As Double
	Public Property Ki As Double
	Public Property Kd As Double

	Public Property SetPointValue As Double
	Public Property ProcessValue As Double
	Public Property ControlValue As Double
	Public Property Interval As Double

	Public Property AntiWindUpEnable As Boolean
	Public Property AntiWindUpMin As Boolean
	Public Property AntiWindUpMax As Boolean

	Public Property ControlValueLimitEnable As Boolean
	Public Property ControlValueMin As Double
	Public Property ControlValueMax As Double

	Private mP As Double
	Private mI As Double
	Private mD As Double
	Private mPLast As Double

	Private swt As StopwatchTimer

	Public Sub New()
		Me.Kp = 1.0
		Me.Ki = 0.0
		Me.Kd = 0.0

		Me.Interval = 1

		Me.AntiWindUpEnable = False
		Me.AntiWindUpMin = -10.0
		Me.AntiWindUpMax = +10.0

		Me.ControlValueLimitEnable = False
		Me.ControlValueMin = -10.0
		Me.ControlValueMax = +10.0

		Me.swt = New StopwatchTimer
	End Sub

	Public Sub UpdateInterval()
		Me.Interval = (swt.TicksPerSecond / swt.ElapsedTime)
	End Sub

	Public Sub Calculate()
		Me.mP = Me.SetPointValue - Me.ProcessValue

		Me.mI = Me.mI + (Me.mP * Me.Interval)
		If Me.AntiWindUpEnable Then
			If Me.mI < Me.AntiWindUpMin Then Me.mI = Me.AntiWindUpMin
			If Me.mI > Me.AntiWindUpMax Then Me.mI = Me.AntiWindUpMax
		End If

		Me.mD = (Me.mP - Me.mPLast) / Me.Interval

		Me.mPLast = Me.mP
		Me.ControlValue = (Me.mP * Me.Kp) + (Me.mI * Me.Ki) + (Me.mD * Me.Kd)

		If Me.ControlValueLimitEnable Then
			If Me.ControlValue < Me.ControlValueMin Then Me.ControlValue = Me.ControlValueMin
			If Me.ControlValue > Me.ControlValueMax Then Me.ControlValue = Me.ControlValueMax
		End If
	End Sub

	Public Sub Calculate(SetPoint As Double)
		Me.SetPointValue = SetPoint
		Me.Calculate()
	End Sub

	Public Sub Calculate(SetPoint As Double, ProcessValue As Double)
		Me.SetPointValue = SetPoint
		Me.ProcessValue = ProcessValue
		Me.Calculate()
	End Sub

	Public Sub Calculate(SetPoint As Double, ProcessValue As Double, ControlValue As Double)
		Me.SetPointValue = SetPoint
		Me.ProcessValue = ProcessValue
		Me.ControlValue = ControlValue
		Me.Calculate()
	End Sub

	Public Sub Calculate(SetPoint As Double, ActualValue As Double, ControlValue As Double, Interval As Double)
		Me.SetPointValue = SetPoint
		Me.ProcessValue = ActualValue
		Me.ControlValue = ControlValue
		Me.Interval = Interval
		Me.Calculate()
	End Sub
End Class
