Public Class Timer
	Public Enum TimerResolution
		ns
		ms
	End Enum

	Public Property Resolution As TimerResolution

	Private lastTimestamp As Long
	Private currentTimestamp As Long

	Public Sub New()
		Me.Resolution = TimerResolution.ms
		Initialize()
	End Sub

	Public Sub New(res As TimerResolution)
		MyBase.New
		Me.Resolution = res
		Initialize()
	End Sub

	Private Sub Initialize()
		lastTimestamp = Me.Timestamp
	End Sub

	Public ReadOnly Property Timestamp As Long
		Get
			Dim result As Long
			Select Case Me.Resolution
				Case TimerResolution.ns
					result = System.Diagnostics.Stopwatch.GetTimestamp / System.Diagnostics.Stopwatch.Frequency
				Case TimerResolution.ms
					result = System.Diagnostics.Stopwatch.GetTimestamp / System.Diagnostics.Stopwatch.Frequency * 1000
			End Select
			Return result
		End Get
	End Property

	Private Function ElapsedTime() As Long
		Dim result As Long

		currentTimestamp = Me.Timestamp
		result = (currentTimestamp - lastTimestamp)
		lastTimestamp = currentTimestamp

		Return result
	End Function
End Class
