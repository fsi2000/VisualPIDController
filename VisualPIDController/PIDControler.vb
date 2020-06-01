Public Class PIDControler
	Public Property kP As Double
	Public Property kI As Double
	Public Property kD As Double

	Public Property mP As Double
	Public Property mI As Double
	Public Property mD As Double
	Public Property mPLast As Double

	Public Property SetPoint As Double
	Public Property ActualValue As Double
	Public Property ControlValue As Double
	Public Property Interval As Double

	Public Property AntiWindUpEnable As Boolean
	Public Property AntiWindUpMin As Boolean
	Public Property AntiWindUpMax As Boolean

	Public Property ControlValueLimitEnable As Boolean
	Public Property ControlValueMin As Double
	Public Property ControlValueMax As Double

	Public Sub New()
		Me.kP = 1.0
		Me.kI = 0.0
		Me.kD = 0.0

		Me.AntiWindUpEnable = False
		Me.AntiWindUpMin = -1000.0
		Me.AntiWindUpMax = +1000.0

		Me.ControlValueLimitEnable = False
		Me.ControlValueMin = -1000.0
		Me.ControlValueMax = +1000.0
	End Sub

	Public Sub Calculate()
		mP = Me.SetPoint - Me.ActualValue
		mI = mI + (mP * Me.Interval)
		mD = (mP - Me.mPLast) / Me.Interval
		Me.mPLast = mP

		If Me.AntiWindUpEnable Then
			If Me.mI < Me.AntiWindUpMin Then Me.mI = Me.AntiWindUpMin
			If Me.mI > Me.AntiWindUpMax Then Me.mI = Me.AntiWindUpMax
		End If

		Me.ControlValue = (mP * Me.kP) + (mI * Me.kI) + (mD * Me.kD)

		If Me.ControlValueLimitEnable Then
			If Me.ControlValue < Me.ControlValueMin Then Me.ControlValue = Me.ControlValueMin
			If Me.ControlValue > Me.ControlValueMax Then Me.ControlValue = Me.ControlValueMax
		End If
	End Sub

	Public Sub Calculate(SetPoint As Double)
		Me.SetPoint = SetPoint
		Me.Calculate()
	End Sub

	Public Sub Calculate(SetPoint As Double, ActualValue As Double)
		Me.SetPoint = SetPoint
		Me.ActualValue = ActualValue
		Me.Calculate()
	End Sub

	Public Sub Calculate(SetPoint As Double, ActualValue As Double, ControlValue As Double)
		Me.SetPoint = SetPoint
		Me.ActualValue = ActualValue
		Me.ControlValue = ControlValue
		Me.Calculate()
	End Sub

	Public Sub Calculate(SetPoint As Double, ActualValue As Double, ControlValue As Double, Interval As Double)
		Me.SetPoint = SetPoint
		Me.ActualValue = ActualValue
		Me.ControlValue = ControlValue
		Me.Interval = Interval
		Me.Calculate()
	End Sub
End Class
