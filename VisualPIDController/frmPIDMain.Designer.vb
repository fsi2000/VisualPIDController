<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPIDMain
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
        Me.tmrSimulation = New System.Windows.Forms.Timer(Me.components)
        Me.tmrController = New System.Windows.Forms.Timer(Me.components)
        Me.chkPIDController = New System.Windows.Forms.CheckBox()
        Me.chkAntiWindUp = New System.Windows.Forms.CheckBox()
        Me.gbParameterPID = New System.Windows.Forms.GroupBox()
        Me.lblMD = New System.Windows.Forms.Label()
        Me.lblMI = New System.Windows.Forms.Label()
        Me.lblMP = New System.Windows.Forms.Label()
        Me.pbD = New System.Windows.Forms.ProgressBar()
        Me.pbI = New System.Windows.Forms.ProgressBar()
        Me.pbP = New System.Windows.Forms.ProgressBar()
        Me.lblD = New System.Windows.Forms.Label()
        Me.tbD = New System.Windows.Forms.TrackBar()
        Me.lblI = New System.Windows.Forms.Label()
        Me.tbI = New System.Windows.Forms.TrackBar()
        Me.lblP = New System.Windows.Forms.Label()
        Me.tbP = New System.Windows.Forms.TrackBar()
        Me.gbParameterSimulation = New System.Windows.Forms.GroupBox()
        Me.lblSP = New System.Windows.Forms.Label()
        Me.tbSP = New System.Windows.Forms.TrackBar()
        Me.lblPV = New System.Windows.Forms.Label()
        Me.tbPV = New System.Windows.Forms.TrackBar()
        Me.lblCV = New System.Windows.Forms.Label()
        Me.tbCV = New System.Windows.Forms.TrackBar()
        Me.lblGain = New System.Windows.Forms.Label()
        Me.tbGain = New System.Windows.Forms.TrackBar()
        Me.gbControl = New System.Windows.Forms.GroupBox()
        Me.cmdResetPID = New System.Windows.Forms.Button()
        Me.gbParameterPID.SuspendLayout()
        CType(Me.tbD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbParameterSimulation.SuspendLayout()
        CType(Me.tbSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrSimulation
        '
        Me.tmrSimulation.Enabled = True
        Me.tmrSimulation.Interval = 50
        '
        'tmrController
        '
        Me.tmrController.Interval = 75
        '
        'chkPIDController
        '
        Me.chkPIDController.AutoSize = True
        Me.chkPIDController.Location = New System.Drawing.Point(6, 19)
        Me.chkPIDController.Name = "chkPIDController"
        Me.chkPIDController.Size = New System.Drawing.Size(91, 17)
        Me.chkPIDController.TabIndex = 0
        Me.chkPIDController.Text = "PID Controller"
        Me.chkPIDController.UseVisualStyleBackColor = True
        '
        'chkAntiWindUp
        '
        Me.chkAntiWindUp.AutoSize = True
        Me.chkAntiWindUp.Location = New System.Drawing.Point(6, 42)
        Me.chkAntiWindUp.Name = "chkAntiWindUp"
        Me.chkAntiWindUp.Size = New System.Drawing.Size(104, 17)
        Me.chkAntiWindUp.TabIndex = 1
        Me.chkAntiWindUp.Text = "PID AntiWindUp"
        Me.chkAntiWindUp.UseVisualStyleBackColor = True
        '
        'gbParameterPID
        '
        Me.gbParameterPID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbParameterPID.Controls.Add(Me.lblMD)
        Me.gbParameterPID.Controls.Add(Me.lblMI)
        Me.gbParameterPID.Controls.Add(Me.lblMP)
        Me.gbParameterPID.Controls.Add(Me.pbD)
        Me.gbParameterPID.Controls.Add(Me.pbI)
        Me.gbParameterPID.Controls.Add(Me.pbP)
        Me.gbParameterPID.Controls.Add(Me.lblD)
        Me.gbParameterPID.Controls.Add(Me.tbD)
        Me.gbParameterPID.Controls.Add(Me.lblI)
        Me.gbParameterPID.Controls.Add(Me.tbI)
        Me.gbParameterPID.Controls.Add(Me.lblP)
        Me.gbParameterPID.Controls.Add(Me.tbP)
        Me.gbParameterPID.Enabled = False
        Me.gbParameterPID.Location = New System.Drawing.Point(417, 12)
        Me.gbParameterPID.Name = "gbParameterPID"
        Me.gbParameterPID.Size = New System.Drawing.Size(395, 238)
        Me.gbParameterPID.TabIndex = 1
        Me.gbParameterPID.TabStop = False
        Me.gbParameterPID.Text = "PID-Parameter"
        '
        'lblMD
        '
        Me.lblMD.Location = New System.Drawing.Point(6, 205)
        Me.lblMD.Name = "lblMD"
        Me.lblMD.Size = New System.Drawing.Size(77, 25)
        Me.lblMD.TabIndex = 10
        Me.lblMD.Text = "mD=0.000"
        Me.lblMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMI
        '
        Me.lblMI.Location = New System.Drawing.Point(6, 126)
        Me.lblMI.Name = "lblMI"
        Me.lblMI.Size = New System.Drawing.Size(77, 25)
        Me.lblMI.TabIndex = 6
        Me.lblMI.Text = "mI=0.000"
        Me.lblMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMP
        '
        Me.lblMP.Location = New System.Drawing.Point(6, 47)
        Me.lblMP.Name = "lblMP"
        Me.lblMP.Size = New System.Drawing.Size(77, 25)
        Me.lblMP.TabIndex = 2
        Me.lblMP.Text = "mP=0.000"
        Me.lblMP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbD
        '
        Me.pbD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbD.Location = New System.Drawing.Point(89, 205)
        Me.pbD.Maximum = 1000
        Me.pbD.Name = "pbD"
        Me.pbD.Size = New System.Drawing.Size(300, 25)
        Me.pbD.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbD.TabIndex = 11
        Me.pbD.Value = 1000
        '
        'pbI
        '
        Me.pbI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbI.Location = New System.Drawing.Point(89, 126)
        Me.pbI.Maximum = 1000
        Me.pbI.Name = "pbI"
        Me.pbI.Size = New System.Drawing.Size(300, 25)
        Me.pbI.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbI.TabIndex = 7
        Me.pbI.Value = 1000
        '
        'pbP
        '
        Me.pbP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbP.Location = New System.Drawing.Point(89, 47)
        Me.pbP.Maximum = 1000
        Me.pbP.Name = "pbP"
        Me.pbP.Size = New System.Drawing.Size(300, 25)
        Me.pbP.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbP.TabIndex = 3
        Me.pbP.Value = 1000
        '
        'lblD
        '
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(6, 174)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(77, 25)
        Me.lblD.TabIndex = 8
        Me.lblD.Text = "D=0.000"
        Me.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbD
        '
        Me.tbD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbD.AutoSize = False
        Me.tbD.LargeChange = 100
        Me.tbD.Location = New System.Drawing.Point(89, 174)
        Me.tbD.Maximum = 10000
        Me.tbD.Name = "tbD"
        Me.tbD.Size = New System.Drawing.Size(300, 25)
        Me.tbD.SmallChange = 50
        Me.tbD.TabIndex = 9
        Me.tbD.TickFrequency = 200
        Me.tbD.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblI
        '
        Me.lblI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblI.Location = New System.Drawing.Point(6, 95)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(77, 25)
        Me.lblI.TabIndex = 4
        Me.lblI.Text = "I=0.000"
        Me.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbI
        '
        Me.tbI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbI.AutoSize = False
        Me.tbI.LargeChange = 100
        Me.tbI.Location = New System.Drawing.Point(89, 95)
        Me.tbI.Maximum = 10000
        Me.tbI.Name = "tbI"
        Me.tbI.Size = New System.Drawing.Size(300, 25)
        Me.tbI.SmallChange = 50
        Me.tbI.TabIndex = 5
        Me.tbI.TickFrequency = 200
        Me.tbI.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblP
        '
        Me.lblP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP.Location = New System.Drawing.Point(6, 16)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(77, 25)
        Me.lblP.TabIndex = 0
        Me.lblP.Text = "P=0.000"
        Me.lblP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbP
        '
        Me.tbP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbP.AutoSize = False
        Me.tbP.LargeChange = 100
        Me.tbP.Location = New System.Drawing.Point(89, 16)
        Me.tbP.Maximum = 10000
        Me.tbP.Name = "tbP"
        Me.tbP.Size = New System.Drawing.Size(300, 25)
        Me.tbP.SmallChange = 50
        Me.tbP.TabIndex = 1
        Me.tbP.TickFrequency = 200
        Me.tbP.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'gbParameterSimulation
        '
        Me.gbParameterSimulation.Controls.Add(Me.lblSP)
        Me.gbParameterSimulation.Controls.Add(Me.tbSP)
        Me.gbParameterSimulation.Controls.Add(Me.lblPV)
        Me.gbParameterSimulation.Controls.Add(Me.tbPV)
        Me.gbParameterSimulation.Controls.Add(Me.lblCV)
        Me.gbParameterSimulation.Controls.Add(Me.tbCV)
        Me.gbParameterSimulation.Controls.Add(Me.lblGain)
        Me.gbParameterSimulation.Controls.Add(Me.tbGain)
        Me.gbParameterSimulation.Location = New System.Drawing.Point(12, 12)
        Me.gbParameterSimulation.Name = "gbParameterSimulation"
        Me.gbParameterSimulation.Size = New System.Drawing.Size(395, 163)
        Me.gbParameterSimulation.TabIndex = 0
        Me.gbParameterSimulation.TabStop = False
        Me.gbParameterSimulation.Text = "Simulation-Parameter"
        '
        'lblSP
        '
        Me.lblSP.Location = New System.Drawing.Point(6, 16)
        Me.lblSP.Name = "lblSP"
        Me.lblSP.Size = New System.Drawing.Size(77, 25)
        Me.lblSP.TabIndex = 0
        Me.lblSP.Text = "SP=0.000"
        Me.lblSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbSP
        '
        Me.tbSP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSP.AutoSize = False
        Me.tbSP.LargeChange = 100
        Me.tbSP.Location = New System.Drawing.Point(89, 16)
        Me.tbSP.Maximum = 1000
        Me.tbSP.Minimum = -1000
        Me.tbSP.Name = "tbSP"
        Me.tbSP.Size = New System.Drawing.Size(300, 25)
        Me.tbSP.SmallChange = 50
        Me.tbSP.TabIndex = 1
        Me.tbSP.TickFrequency = 200
        Me.tbSP.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblPV
        '
        Me.lblPV.Location = New System.Drawing.Point(6, 47)
        Me.lblPV.Name = "lblPV"
        Me.lblPV.Size = New System.Drawing.Size(77, 25)
        Me.lblPV.TabIndex = 2
        Me.lblPV.Text = "PV=0.000"
        Me.lblPV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbPV
        '
        Me.tbPV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPV.AutoSize = False
        Me.tbPV.LargeChange = 100
        Me.tbPV.Location = New System.Drawing.Point(89, 47)
        Me.tbPV.Maximum = 1000
        Me.tbPV.Minimum = -1000
        Me.tbPV.Name = "tbPV"
        Me.tbPV.Size = New System.Drawing.Size(300, 25)
        Me.tbPV.SmallChange = 50
        Me.tbPV.TabIndex = 3
        Me.tbPV.TickFrequency = 200
        Me.tbPV.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'lblCV
        '
        Me.lblCV.Location = New System.Drawing.Point(4, 95)
        Me.lblCV.Name = "lblCV"
        Me.lblCV.Size = New System.Drawing.Size(77, 25)
        Me.lblCV.TabIndex = 4
        Me.lblCV.Text = "CV=0.000"
        Me.lblCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCV
        '
        Me.tbCV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCV.AutoSize = False
        Me.tbCV.LargeChange = 100
        Me.tbCV.Location = New System.Drawing.Point(87, 95)
        Me.tbCV.Maximum = 1000
        Me.tbCV.Minimum = -1000
        Me.tbCV.Name = "tbCV"
        Me.tbCV.Size = New System.Drawing.Size(300, 25)
        Me.tbCV.SmallChange = 50
        Me.tbCV.TabIndex = 5
        Me.tbCV.TickFrequency = 200
        Me.tbCV.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblGain
        '
        Me.lblGain.Location = New System.Drawing.Point(6, 126)
        Me.lblGain.Name = "lblGain"
        Me.lblGain.Size = New System.Drawing.Size(77, 25)
        Me.lblGain.TabIndex = 6
        Me.lblGain.Text = "GAIN=0.000"
        Me.lblGain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbGain
        '
        Me.tbGain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbGain.AutoSize = False
        Me.tbGain.LargeChange = 100
        Me.tbGain.Location = New System.Drawing.Point(89, 126)
        Me.tbGain.Maximum = 1000
        Me.tbGain.Name = "tbGain"
        Me.tbGain.Size = New System.Drawing.Size(300, 25)
        Me.tbGain.SmallChange = 10
        Me.tbGain.TabIndex = 7
        Me.tbGain.TickFrequency = 200
        Me.tbGain.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'gbControl
        '
        Me.gbControl.Controls.Add(Me.cmdResetPID)
        Me.gbControl.Controls.Add(Me.chkAntiWindUp)
        Me.gbControl.Controls.Add(Me.chkPIDController)
        Me.gbControl.Location = New System.Drawing.Point(12, 183)
        Me.gbControl.Name = "gbControl"
        Me.gbControl.Size = New System.Drawing.Size(269, 67)
        Me.gbControl.TabIndex = 2
        Me.gbControl.TabStop = False
        Me.gbControl.Text = "Control"
        '
        'cmdResetPID
        '
        Me.cmdResetPID.Location = New System.Drawing.Point(188, 19)
        Me.cmdResetPID.Name = "cmdResetPID"
        Me.cmdResetPID.Size = New System.Drawing.Size(75, 40)
        Me.cmdResetPID.TabIndex = 2
        Me.cmdResetPID.Text = "PID RESET"
        Me.cmdResetPID.UseVisualStyleBackColor = True
        '
        'frmPIDMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 260)
        Me.Controls.Add(Me.gbControl)
        Me.Controls.Add(Me.gbParameterSimulation)
        Me.Controls.Add(Me.gbParameterPID)
        Me.Name = "frmPIDMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual PID Controller"
        Me.gbParameterPID.ResumeLayout(False)
        CType(Me.tbD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbParameterSimulation.ResumeLayout(False)
        CType(Me.tbSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControl.ResumeLayout(False)
        Me.gbControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrSimulation As Windows.Forms.Timer
	Friend WithEvents tmrController As Windows.Forms.Timer
    Friend WithEvents chkPIDController As CheckBox
    Friend WithEvents chkAntiWindUp As CheckBox
    Friend WithEvents gbParameterPID As GroupBox
    Friend WithEvents pbD As ProgressBar
    Friend WithEvents pbI As ProgressBar
    Friend WithEvents pbP As ProgressBar
    Friend WithEvents lblD As Label
    Friend WithEvents tbD As TrackBar
    Friend WithEvents lblI As Label
    Friend WithEvents tbI As TrackBar
    Friend WithEvents lblP As Label
    Friend WithEvents tbP As TrackBar
    Friend WithEvents gbParameterSimulation As GroupBox
    Friend WithEvents lblCV As Label
    Friend WithEvents tbCV As TrackBar
    Friend WithEvents lblGain As Label
    Friend WithEvents tbGain As TrackBar
    Friend WithEvents lblMD As Label
    Friend WithEvents lblMI As Label
    Friend WithEvents lblMP As Label
    Friend WithEvents lblSP As Label
    Friend WithEvents tbSP As TrackBar
    Friend WithEvents lblPV As Label
    Friend WithEvents tbPV As TrackBar
    Friend WithEvents gbControl As GroupBox
    Friend WithEvents cmdResetPID As Button
End Class
