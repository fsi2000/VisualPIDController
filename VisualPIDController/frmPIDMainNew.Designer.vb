<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPIDMainNew
	Inherits System.Windows.Forms.Form

	'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Wird vom Windows Form-Designer benötigt.
	Private components As System.ComponentModel.IContainer

	'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
	'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
	'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.tbP = New System.Windows.Forms.TrackBar()
		Me.tmrSimulation = New System.Windows.Forms.Timer(Me.components)
		Me.lblP = New System.Windows.Forms.Label()
		Me.lblI = New System.Windows.Forms.Label()
		Me.tbI = New System.Windows.Forms.TrackBar()
		Me.lblD = New System.Windows.Forms.Label()
		Me.tbD = New System.Windows.Forms.TrackBar()
		Me.tmrController = New System.Windows.Forms.Timer(Me.components)
		Me.lblSP = New System.Windows.Forms.Label()
		Me.tbSP = New System.Windows.Forms.TrackBar()
		Me.lblPV = New System.Windows.Forms.Label()
		Me.tbPV = New System.Windows.Forms.TrackBar()
		Me.lblCV = New System.Windows.Forms.Label()
		Me.tbCV = New System.Windows.Forms.TrackBar()
		Me.lblGain = New System.Windows.Forms.Label()
		Me.tbGain = New System.Windows.Forms.TrackBar()
		Me.chkPIDController = New System.Windows.Forms.CheckBox()
		CType(Me.tbP, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tbI, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tbD, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tbSP, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tbPV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tbCV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tbGain, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tbP
		'
		Me.tbP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbP.AutoSize = False
		Me.tbP.LargeChange = 100
		Me.tbP.Location = New System.Drawing.Point(118, 9)
		Me.tbP.Maximum = 10000
		Me.tbP.Name = "tbP"
		Me.tbP.Size = New System.Drawing.Size(452, 25)
		Me.tbP.SmallChange = 50
		Me.tbP.TabIndex = 2
		Me.tbP.TickFrequency = 200
		Me.tbP.TickStyle = System.Windows.Forms.TickStyle.None
		Me.tbP.Value = 1000
		'
		'tmrSimulation
		'
		Me.tmrSimulation.Enabled = True
		Me.tmrSimulation.Interval = 50
		'
		'lblP
		'
		Me.lblP.Location = New System.Drawing.Point(12, 9)
		Me.lblP.Name = "lblP"
		Me.lblP.Size = New System.Drawing.Size(100, 25)
		Me.lblP.TabIndex = 3
		Me.lblP.Text = "P=0.000"
		Me.lblP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblI
		'
		Me.lblI.Location = New System.Drawing.Point(12, 40)
		Me.lblI.Name = "lblI"
		Me.lblI.Size = New System.Drawing.Size(100, 25)
		Me.lblI.TabIndex = 5
		Me.lblI.Text = "I=0.000"
		Me.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'tbI
		'
		Me.tbI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbI.AutoSize = False
		Me.tbI.LargeChange = 100
		Me.tbI.Location = New System.Drawing.Point(118, 40)
		Me.tbI.Maximum = 10000
		Me.tbI.Name = "tbI"
		Me.tbI.Size = New System.Drawing.Size(452, 25)
		Me.tbI.SmallChange = 50
		Me.tbI.TabIndex = 4
		Me.tbI.TickFrequency = 200
		Me.tbI.TickStyle = System.Windows.Forms.TickStyle.None
		'
		'lblD
		'
		Me.lblD.Location = New System.Drawing.Point(12, 71)
		Me.lblD.Name = "lblD"
		Me.lblD.Size = New System.Drawing.Size(100, 25)
		Me.lblD.TabIndex = 7
		Me.lblD.Text = "D=0.000"
		Me.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'tbD
		'
		Me.tbD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbD.AutoSize = False
		Me.tbD.LargeChange = 100
		Me.tbD.Location = New System.Drawing.Point(118, 71)
		Me.tbD.Maximum = 10000
		Me.tbD.Name = "tbD"
		Me.tbD.Size = New System.Drawing.Size(452, 25)
		Me.tbD.SmallChange = 50
		Me.tbD.TabIndex = 6
		Me.tbD.TickFrequency = 200
		Me.tbD.TickStyle = System.Windows.Forms.TickStyle.None
		'
		'tmrController
		'
		'
		'lblSP
		'
		Me.lblSP.Location = New System.Drawing.Point(12, 125)
		Me.lblSP.Name = "lblSP"
		Me.lblSP.Size = New System.Drawing.Size(100, 25)
		Me.lblSP.TabIndex = 9
		Me.lblSP.Text = "SP=0.000"
		Me.lblSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'tbSP
		'
		Me.tbSP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbSP.AutoSize = False
		Me.tbSP.LargeChange = 100
		Me.tbSP.Location = New System.Drawing.Point(118, 125)
		Me.tbSP.Maximum = 1000
		Me.tbSP.Minimum = -1000
		Me.tbSP.Name = "tbSP"
		Me.tbSP.Size = New System.Drawing.Size(452, 25)
		Me.tbSP.SmallChange = 50
		Me.tbSP.TabIndex = 8
		Me.tbSP.TickFrequency = 200
		Me.tbSP.TickStyle = System.Windows.Forms.TickStyle.None
		'
		'lblPV
		'
		Me.lblPV.Location = New System.Drawing.Point(12, 156)
		Me.lblPV.Name = "lblPV"
		Me.lblPV.Size = New System.Drawing.Size(100, 25)
		Me.lblPV.TabIndex = 11
		Me.lblPV.Text = "PV=0.000"
		Me.lblPV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'tbPV
		'
		Me.tbPV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbPV.AutoSize = False
		Me.tbPV.LargeChange = 100
		Me.tbPV.Location = New System.Drawing.Point(118, 156)
		Me.tbPV.Maximum = 1000
		Me.tbPV.Minimum = -1000
		Me.tbPV.Name = "tbPV"
		Me.tbPV.Size = New System.Drawing.Size(452, 25)
		Me.tbPV.SmallChange = 50
		Me.tbPV.TabIndex = 10
		Me.tbPV.TickFrequency = 200
		Me.tbPV.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		'
		'lblCV
		'
		Me.lblCV.Location = New System.Drawing.Point(12, 240)
		Me.lblCV.Name = "lblCV"
		Me.lblCV.Size = New System.Drawing.Size(100, 25)
		Me.lblCV.TabIndex = 13
		Me.lblCV.Text = "CV=0.000"
		Me.lblCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'tbCV
		'
		Me.tbCV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbCV.AutoSize = False
		Me.tbCV.LargeChange = 100
		Me.tbCV.Location = New System.Drawing.Point(118, 240)
		Me.tbCV.Maximum = 1000
		Me.tbCV.Minimum = -1000
		Me.tbCV.Name = "tbCV"
		Me.tbCV.Size = New System.Drawing.Size(452, 25)
		Me.tbCV.SmallChange = 50
		Me.tbCV.TabIndex = 12
		Me.tbCV.TickFrequency = 200
		Me.tbCV.TickStyle = System.Windows.Forms.TickStyle.None
		'
		'lblGain
		'
		Me.lblGain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblGain.Location = New System.Drawing.Point(12, 416)
		Me.lblGain.Name = "lblGain"
		Me.lblGain.Size = New System.Drawing.Size(100, 25)
		Me.lblGain.TabIndex = 16
		Me.lblGain.Text = "GAIN=0.000"
		Me.lblGain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'tbGain
		'
		Me.tbGain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbGain.AutoSize = False
		Me.tbGain.LargeChange = 100
		Me.tbGain.Location = New System.Drawing.Point(118, 416)
		Me.tbGain.Maximum = 2500
		Me.tbGain.Name = "tbGain"
		Me.tbGain.Size = New System.Drawing.Size(448, 25)
		Me.tbGain.SmallChange = 50
		Me.tbGain.TabIndex = 15
		Me.tbGain.TickFrequency = 200
		Me.tbGain.TickStyle = System.Windows.Forms.TickStyle.None
		Me.tbGain.Value = 1000
		'
		'chkPIDController
		'
		Me.chkPIDController.AutoSize = True
		Me.chkPIDController.Location = New System.Drawing.Point(12, 271)
		Me.chkPIDController.Name = "chkPIDController"
		Me.chkPIDController.Size = New System.Drawing.Size(73, 17)
		Me.chkPIDController.TabIndex = 17
		Me.chkPIDController.Text = "PID -> CV"
		Me.chkPIDController.UseVisualStyleBackColor = True
		'
		'frmPIDMainNew
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(582, 450)
		Me.Controls.Add(Me.chkPIDController)
		Me.Controls.Add(Me.lblGain)
		Me.Controls.Add(Me.tbGain)
		Me.Controls.Add(Me.lblCV)
		Me.Controls.Add(Me.tbCV)
		Me.Controls.Add(Me.lblPV)
		Me.Controls.Add(Me.tbPV)
		Me.Controls.Add(Me.lblSP)
		Me.Controls.Add(Me.tbSP)
		Me.Controls.Add(Me.lblD)
		Me.Controls.Add(Me.tbD)
		Me.Controls.Add(Me.lblI)
		Me.Controls.Add(Me.tbI)
		Me.Controls.Add(Me.lblP)
		Me.Controls.Add(Me.tbP)
		Me.Name = "frmPIDMainNew"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Visual PID Controller"
		CType(Me.tbP, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tbI, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tbD, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tbSP, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tbPV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tbCV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tbGain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents tbP As TrackBar
	Friend WithEvents tmrSimulation As Windows.Forms.Timer
	Friend WithEvents lblP As Label
	Friend WithEvents lblI As Label
	Friend WithEvents tbI As TrackBar
	Friend WithEvents lblD As Label
	Friend WithEvents tbD As TrackBar
	Friend WithEvents tmrController As Windows.Forms.Timer
	Friend WithEvents lblSP As Label
	Friend WithEvents tbSP As TrackBar
	Friend WithEvents lblPV As Label
	Friend WithEvents tbPV As TrackBar
	Friend WithEvents lblCV As Label
	Friend WithEvents tbCV As TrackBar
	Friend WithEvents lblGain As Label
	Friend WithEvents tbGain As TrackBar
	Friend WithEvents chkPIDController As CheckBox
End Class
