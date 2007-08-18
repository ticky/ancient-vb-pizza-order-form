'Pizza Order Form version 1.52
'Copyright (C) 2007 Geoff Stokes.
Public Class FormSubmitting
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
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 8)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(320, 24)
        Me.ProgressBar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Checking Totals..."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cancel"
        '
        'Timer
        '
        '
        'FormSubmitting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 64)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Label1, Me.ProgressBar1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSubmitting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Submitting Order..."
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormSubmitting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MainForm As New Form1()
        Button1.Text = "Cancel"
        Timer.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MainForm As New Form1()
        Me.Close()
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Tick = Tick + 1
        Select Case Tick
            Case 2
                ProgressBar1.Value = 10
                Label1.Text = "Connecting..."
            Case 4
                Label1.Text = "Authenticating..."
            Case 6
                ProgressBar1.Value = 20
                Label1.Text = "Handshaking..."
            Case 8
                ProgressBar1.Value = 30
                Label1.Text = "Success!"
            Case 16
                ProgressBar1.Value = 35
                Label1.Text = "Submitting Order..."
            Case 18
                Button1.Enabled = False
                ProgressBar1.Value = 78
                Label1.Text = "Checking Order..."
            Case 20
                ProgressBar1.Value = 95
                Label1.Text = "Order OK. Closing Connection"
            Case 22
                ProgressBar1.Value = 100
                Button1.Enabled = True
                Label1.Text = "Finished. Your Pizza will arrive shortly."
                Button1.Text = "Close"
            Case 23
        End Select
    End Sub
End Class
