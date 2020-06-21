Public Class PIDControler
	Public Property kP As Double = 1.0
	Public Property kI As Double = 0.0
	Public Property kD As Double = 0.0

	Public Property SetPointValue As Double
	Public Property ProcessValue As Double
	Public Property ControlValue As Double
	Public Property Interval As Double

	Public Property AntiWindUpEnable As Boolean = False
	Public Property AntiWindUpMin As Double = -10.0
	Public Property AntiWindUpMax As Double = +10.0

	Public Property ControlValueLimitEnable As Boolean = False
	Public Property ControlValueMin As Double = -10.0
	Public Property ControlValueMax As Double = +10.0

	Public Property mP As Double
	Public Property mI As Double
	Public Property mD As Double
	Public Property mPLast As Double

	Private swt As StopwatchTimer

	Public Sub New()
		Me.swt = New StopwatchTimer
	End Sub

	Public Sub New(kP As Double, kI As Double, kD As Double)
		Me.New()

		Me.kP = kP
		Me.kI = kI
		Me.kD = kD
	End Sub

	Public Sub UpdateInterval()
		Me.Interval = swt.ElapsedTime / swt.TicksPerSecond
	End Sub

	Public Sub Reset(resetP As Boolean, resetI As Boolean, resetD As Boolean)
		If resetP Then Me.mPLast = Me.mP
		If resetI Then Me.mI = 0
		If resetD Then Me.mD = 0
	End Sub

	Public Sub Calculate()
		'Proportional
		Me.mP = Me.SetPointValue - Me.ProcessValue

		'Integral
		Me.mI = Me.mI + (Me.mP * Me.Interval)
		If Me.AntiWindUpEnable Then
			If Me.mI < Me.AntiWindUpMin Then Me.mI = Me.AntiWindUpMin
			If Me.mI > Me.AntiWindUpMax Then Me.mI = Me.AntiWindUpMax
		End If

		'Derivative
		Me.mD = (Me.mP - Me.mPLast) / Me.Interval

		'calculate control value
		Me.ControlValue = (Me.mP * Me.kP) + (Me.mI * Me.kI) + (Me.mD * Me.kD)

		'limit control value
		If Me.ControlValueLimitEnable Then
			If Me.ControlValue < Me.ControlValueMin Then Me.ControlValue = Me.ControlValueMin
			If Me.ControlValue > Me.ControlValueMax Then Me.ControlValue = Me.ControlValueMax
		End If

		'save last P value
		Me.mPLast = Me.mP
	End Sub

	Public Sub Calculate(SetPoint As Double)
		Me.SetPointValue = SetPoint
		Me.Calculate()
	End Sub

	Public Sub Calculate(SetPoint As Double, ProcessValue As Double)
		Me.ProcessValue = ProcessValue
		Me.Calculate(SetPoint)
	End Sub

	Public Sub Calculate(SetPoint As Double, ProcessValue As Double, ControlValue As Double)
		Me.ControlValue = ControlValue
		Me.Calculate(SetPoint, ProcessValue)
	End Sub

	Public Sub Calculate(SetPoint As Double, ProcessValue As Double, ControlValue As Double, Interval As Double)
		Me.Interval = Interval
		Me.Calculate(SetPoint, ProcessValue, ControlValue)
	End Sub
End Class
