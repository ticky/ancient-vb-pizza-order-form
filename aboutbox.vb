Public Class aboutbox
    Inherits System.Windows.Forms.Form
    Dim Tick As Integer

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblData As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 50
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pizza Order Form"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2007 by Geoff Stokes"
        '
        'lblData
        '
        Me.lblData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblData.Location = New System.Drawing.Point(8, 64)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(456, 16)
        Me.lblData.TabIndex = 2
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(392, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ok"
        '
        'aboutbox
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 112)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.lblData, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "aboutbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Pizza Order Form"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub aboutbox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Tick = Tick + 1
        Select Case Tick
            Case 1
                lblData.Text = "Pizza Order Form"
            Case 10
                lblData.Text = "izza Order for"
            Case 11
                lblData.Text = "zza Order fo"
            Case 12
                lblData.Text = "za Order f"
            Case 13
                lblData.Text = " Order"
            Case 14
                lblData.Text = "rd"
            Case 15
                lblData.Text = ""
            Case 16
                lblData.Text = "by"
            Case 17
                lblData.Text = "7 by G"
            Case 18
                lblData.Text = "007 by Geo"
            Case 19
                lblData.Text = " 2007 by Geoff"
            Case 20
                lblData.Text = "in 2007 by Geoff S"
            Case 21
                lblData.Text = "e in 2007 by Geoff Sto"
            Case 22
                lblData.Text = "ade in 2007 by Geoff Stoke"
            Case 23
                lblData.Text = "Made in 2007 by Geoff Stokes"
            Case 34
                lblData.Text = "ade in 2007 by Geoff Stoke"
            Case 35
                lblData.Text = "e in 2007 by Geoff Sto"
            Case 36
                lblData.Text = "in 2007 by Geoff S"
            Case 37
                lblData.Text = " 2007 by Geoff"
            Case 38
                lblData.Text = "007 by Geo"
            Case 39
                lblData.Text = "7 by G"
            Case 40
                lblData.Text = "by"
            Case 41
                lblData.Text = ""
            Case 42
                lblData.Text = "rd"
            Case 43
                lblData.Text = " Order"
            Case 44
                lblData.Text = "za Order f"
            Case 45
                lblData.Text = "zza Order fo"
            Case 46
                lblData.Text = "izza Order for"
            Case 47
                lblData.Text = "Pizza Order Form"
            Case 60
                Tick = 0
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
