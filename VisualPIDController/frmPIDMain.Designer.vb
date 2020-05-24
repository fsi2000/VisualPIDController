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
        Me.tbP = New System.Windows.Forms.TrackBar()
        Me.tmrPIDController = New System.Windows.Forms.Timer(Me.components)
        Me.tbI = New System.Windows.Forms.TrackBar()
        Me.tbD = New System.Windows.Forms.TrackBar()
        Me.tbIstwert = New System.Windows.Forms.TrackBar()
        Me.tbSollwert = New System.Windows.Forms.TrackBar()
        Me.tbStellgroesse = New System.Windows.Forms.TrackBar()
        Me.lblP = New System.Windows.Forms.Label()
        Me.lblI = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblStellgroesse = New System.Windows.Forms.Label()
        Me.lblIstwert = New System.Windows.Forms.Label()
        Me.lblSollwert = New System.Windows.Forms.Label()
        Me.tmrSimulation = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbFehler = New System.Windows.Forms.ProgressBar()
        Me.lblCVminmax = New System.Windows.Forms.Label()
        Me.tbCV = New System.Windows.Forms.TrackBar()
        CType(Me.tbP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbIstwert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSollwert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbStellgroesse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbP
        '
        Me.tbP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbP.LargeChange = 10
        Me.tbP.Location = New System.Drawing.Point(108, 4)
        Me.tbP.Maximum = 50000
        Me.tbP.Name = "tbP"
        Me.tbP.Size = New System.Drawing.Size(861, 45)
        Me.tbP.TabIndex = 0
        Me.tbP.TickFrequency = 250
        Me.tbP.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbP.Value = 250
        '
        'tmrPIDController
        '
        Me.tmrPIDController.Interval = 50
        '
        'tbI
        '
        Me.tbI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbI.LargeChange = 10
        Me.tbI.Location = New System.Drawing.Point(108, 56)
        Me.tbI.Maximum = 1000
        Me.tbI.Name = "tbI"
        Me.tbI.Size = New System.Drawing.Size(861, 45)
        Me.tbI.TabIndex = 1
        Me.tbI.TickFrequency = 50
        Me.tbI.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbD
        '
        Me.tbD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbD.LargeChange = 10
        Me.tbD.Location = New System.Drawing.Point(108, 108)
        Me.tbD.Maximum = 100000
        Me.tbD.Name = "tbD"
        Me.tbD.Size = New System.Drawing.Size(861, 45)
        Me.tbD.TabIndex = 2
        Me.tbD.TickFrequency = 500
        Me.tbD.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbIstwert
        '
        Me.tbIstwert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbIstwert.LargeChange = 250
        Me.tbIstwert.Location = New System.Drawing.Point(108, 294)
        Me.tbIstwert.Maximum = 1000
        Me.tbIstwert.Minimum = -1000
        Me.tbIstwert.Name = "tbIstwert"
        Me.tbIstwert.Size = New System.Drawing.Size(861, 45)
        Me.tbIstwert.SmallChange = 50
        Me.tbIstwert.TabIndex = 4
        Me.tbIstwert.TickFrequency = 100
        Me.tbIstwert.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbSollwert
        '
        Me.tbSollwert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSollwert.LargeChange = 250
        Me.tbSollwert.Location = New System.Drawing.Point(108, 242)
        Me.tbSollwert.Maximum = 1000
        Me.tbSollwert.Minimum = -1000
        Me.tbSollwert.Name = "tbSollwert"
        Me.tbSollwert.Size = New System.Drawing.Size(861, 45)
        Me.tbSollwert.SmallChange = 50
        Me.tbSollwert.TabIndex = 3
        Me.tbSollwert.TickFrequency = 100
        Me.tbSollwert.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbStellgroesse
        '
        Me.tbStellgroesse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbStellgroesse.LargeChange = 250
        Me.tbStellgroesse.Location = New System.Drawing.Point(108, 414)
        Me.tbStellgroesse.Maximum = 5000
        Me.tbStellgroesse.Minimum = -5000
        Me.tbStellgroesse.Name = "tbStellgroesse"
        Me.tbStellgroesse.Size = New System.Drawing.Size(861, 45)
        Me.tbStellgroesse.SmallChange = 50
        Me.tbStellgroesse.TabIndex = 5
        Me.tbStellgroesse.TickFrequency = 100
        Me.tbStellgroesse.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblP
        '
        Me.lblP.Location = New System.Drawing.Point(8, 4)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(80, 48)
        Me.lblP.TabIndex = 6
        Me.lblP.Text = "P"
        Me.lblP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblI
        '
        Me.lblI.Location = New System.Drawing.Point(8, 56)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(80, 48)
        Me.lblI.TabIndex = 7
        Me.lblI.Text = "I"
        Me.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblD
        '
        Me.lblD.Location = New System.Drawing.Point(8, 108)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(80, 48)
        Me.lblD.TabIndex = 8
        Me.lblD.Text = "D"
        Me.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStellgroesse
        '
        Me.lblStellgroesse.Location = New System.Drawing.Point(8, 414)
        Me.lblStellgroesse.Name = "lblStellgroesse"
        Me.lblStellgroesse.Size = New System.Drawing.Size(80, 48)
        Me.lblStellgroesse.TabIndex = 11
        Me.lblStellgroesse.Text = "STELL"
        Me.lblStellgroesse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIstwert
        '
        Me.lblIstwert.Location = New System.Drawing.Point(8, 294)
        Me.lblIstwert.Name = "lblIstwert"
        Me.lblIstwert.Size = New System.Drawing.Size(80, 48)
        Me.lblIstwert.TabIndex = 10
        Me.lblIstwert.Text = "IST"
        Me.lblIstwert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSollwert
        '
        Me.lblSollwert.Location = New System.Drawing.Point(8, 242)
        Me.lblSollwert.Name = "lblSollwert"
        Me.lblSollwert.Size = New System.Drawing.Size(80, 48)
        Me.lblSollwert.TabIndex = 9
        Me.lblSollwert.Text = "SOLL"
        Me.lblSollwert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrSimulation
        '
        Me.tmrSimulation.Interval = 25
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 48)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FEHLER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbFehler
        '
        Me.pbFehler.Location = New System.Drawing.Point(108, 354)
        Me.pbFehler.Maximum = 250
        Me.pbFehler.Name = "pbFehler"
        Me.pbFehler.Size = New System.Drawing.Size(824, 48)
        Me.pbFehler.TabIndex = 13
        '
        'lblCVminmax
        '
        Me.lblCVminmax.Location = New System.Drawing.Point(8, 176)
        Me.lblCVminmax.Name = "lblCVminmax"
        Me.lblCVminmax.Size = New System.Drawing.Size(80, 48)
        Me.lblCVminmax.TabIndex = 15
        Me.lblCVminmax.Text = "CV (min/max)"
        Me.lblCVminmax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCV
        '
        Me.tbCV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCV.LargeChange = 100
        Me.tbCV.Location = New System.Drawing.Point(108, 176)
        Me.tbCV.Maximum = 5000
        Me.tbCV.Minimum = 1
        Me.tbCV.Name = "tbCV"
        Me.tbCV.Size = New System.Drawing.Size(861, 45)
        Me.tbCV.TabIndex = 14
        Me.tbCV.TickFrequency = 500
        Me.tbCV.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbCV.Value = 1
        '
        'frmPIDMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 471)
        Me.Controls.Add(Me.lblCVminmax)
        Me.Controls.Add(Me.tbCV)
        Me.Controls.Add(Me.pbFehler)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStellgroesse)
        Me.Controls.Add(Me.lblIstwert)
        Me.Controls.Add(Me.lblSollwert)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblI)
        Me.Controls.Add(Me.lblP)
        Me.Controls.Add(Me.tbStellgroesse)
        Me.Controls.Add(Me.tbIstwert)
        Me.Controls.Add(Me.tbSollwert)
        Me.Controls.Add(Me.tbD)
        Me.Controls.Add(Me.tbI)
        Me.Controls.Add(Me.tbP)
        Me.Name = "frmPIDMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual PID Controller"
        CType(Me.tbP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbIstwert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSollwert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbStellgroesse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbP As TrackBar
	Friend WithEvents tmrPIDController As Timer
	Friend WithEvents tbI As TrackBar
	Friend WithEvents tbD As TrackBar
	Friend WithEvents tbIstwert As TrackBar
	Friend WithEvents tbSollwert As TrackBar
	Friend WithEvents tbStellgroesse As TrackBar
	Friend WithEvents lblP As Label
	Friend WithEvents lblI As Label
	Friend WithEvents lblD As Label
	Friend WithEvents lblStellgroesse As Label
	Friend WithEvents lblIstwert As Label
	Friend WithEvents lblSollwert As Label
	Friend WithEvents tmrSimulation As Timer
	Friend WithEvents Label1 As Label
	Friend WithEvents pbFehler As ProgressBar
    Friend WithEvents lblCVminmax As Label
    Friend WithEvents tbCV As TrackBar
End Class
