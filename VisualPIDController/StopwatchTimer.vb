Public Class StopwatchTimer
	Public Enum TimerResolution
		ns
		ms
	End Enum

	Public Property Resolution As TimerResolution

	Private LastTimestamp As Long
	Private CurrentTimestamp As Long

	Public Sub New()
		Me.Resolution = TimerResolution.ms
		Initialize()
	End Sub

	Public Sub New(Resolution As TimerResolution)
		Me.New()
		Me.Resolution = Resolution
		Initialize()
	End Sub

	Private Sub Initialize()
		LastTimestamp = Me.Timestamp
	End Sub

	Public Function Timestamp() As Long
		Dim result As Long

		Select Case Me.Resolution
			Case TimerResolution.ms
				result = System.Diagnostics.Stopwatch.GetTimestamp / System.Diagnostics.Stopwatch.Frequency * 1000
			Case TimerResolution.ns
				result = System.Diagnostics.Stopwatch.GetTimestamp / System.Diagnostics.Stopwatch.Frequency
		End Select

		Return result
	End Function

	Public Function ElapsedTime() As Long
		Dim result As Long

		Me.CurrentTimestamp = Me.Timestamp
		result = (Me.CurrentTimestamp - Me.LastTimestamp)
		Me.LastTimestamp = Me.CurrentTimestamp

		Return result
	End Function

	Public Function TicksPerSecond() As Long
		Dim result As Long

		Select Case Me.Resolution
			Case TimerResolution.ms
				result = 1000
			Case TimerResolution.ns
				result = 1000000
		End Select

		Return result
	End Function
End Class
