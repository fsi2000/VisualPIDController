Public Class Simulator

	Public Property Value As Double

	Public Property ValueLimitEnable As Boolean
	Public Property ValueMin As Double     'TODO: Limit
	Public Property ValueMax As Double     'TODO: Limit

	Public Property Threshold As Boolean
	Public Property ThresholdValue As Double     'TODO: Limit

	Public Property ControlValue As Double
	Public Property ControlValueGain As Double



	Public Sub New()
		Me.Value = 0
		Me.ControlValueGain = 1.0

		Me.ValueLimitEnable = False
		Me.ValueMin = -1000
		Me.ValueMax = +1000

		Me.Threshold = False
		Me.ThresholdValue = 0
	End Sub

	Public Sub New(value As Double)
		Me.New()
		Me.Value = value
	End Sub

	Public Sub New(value As Double, minValue As Double, maxValue As Double)
		Me.New(value)
		Me.ValueLimitEnable = True
		Me.ValueMin = minValue
		Me.ValueMax = maxValue
	End Sub

	'TODO: Use elapsed time to remove timing effects
	Public Sub Calculate()
		Dim cv As Double
		Dim result As Double

		cv = Me.ControlValue

		If Threshold Then
			If Math.Abs(cv) < Me.ThresholdValue Then cv = 0
		End If

		result = Me.Value + (cv * Me.ControlValueGain)

		If Me.ValueLimitEnable Then
			If result < Me.ValueMin Then result = Me.ValueMin
			If result > Me.ValueMax Then result = Me.ValueMax
		End If

		Me.Value = result
	End Sub

	Public Sub Calculate(controlvalue As Double)
		Me.ControlValue = controlvalue
		Me.Calculate()
	End Sub
End Class
