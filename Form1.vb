'Pizza Order Form version 1.52
'Copyright (C) 2007 Geoff Stokes.
Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim TotalPrice As Decimal
    Dim TotalPriceStr As String
    '
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
    Friend WithEvents picPizzaSelected_Supreme As System.Windows.Forms.PictureBox
    Friend WithEvents grpPizzaSelect As System.Windows.Forms.GroupBox
    Friend WithEvents nudNumberPizzas As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbPizzaSelect As System.Windows.Forms.ComboBox
    Friend WithEvents grpDrinks As System.Windows.Forms.GroupBox
    Friend WithEvents nudH20 As System.Windows.Forms.NumericUpDown
    Friend WithEvents picH20 As System.Windows.Forms.PictureBox
    Friend WithEvents nudSprite As System.Windows.Forms.NumericUpDown
    Friend WithEvents picSprite As System.Windows.Forms.PictureBox
    Friend WithEvents nudFanta As System.Windows.Forms.NumericUpDown
    Friend WithEvents picFanta As System.Windows.Forms.PictureBox
    Friend WithEvents nudDietCoke As System.Windows.Forms.NumericUpDown
    Friend WithEvents picDietCoke As System.Windows.Forms.PictureBox
    Friend WithEvents nudCoke As System.Windows.Forms.NumericUpDown
    Friend WithEvents picCoke As System.Windows.Forms.PictureBox
    Friend WithEvents grpExtras As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkGarlicBread As System.Windows.Forms.CheckBox
    Friend WithEvents grpDelivery As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblSuburb As System.Windows.Forms.Label
    Friend WithEvents txtSuburb As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents chkHomeDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents picPizzaSelected_Pepperoni As System.Windows.Forms.PictureBox
    Friend WithEvents picPizzaSelected_Hawaiian As System.Windows.Forms.PictureBox
    Friend WithEvents picPizzaSelected_Vego As System.Windows.Forms.PictureBox
    Friend WithEvents picPizzaSelected_MeatLovers As System.Windows.Forms.PictureBox
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents tipPizzaSelect As System.Windows.Forms.ToolTip
    Friend WithEvents tipPizzaNum As System.Windows.Forms.ToolTip
    Friend WithEvents tipCost As System.Windows.Forms.ToolTip
    Friend WithEvents tipSubmitOrder As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.picPizzaSelected_Supreme = New System.Windows.Forms.PictureBox()
        Me.grpPizzaSelect = New System.Windows.Forms.GroupBox()
        Me.picPizzaSelected_MeatLovers = New System.Windows.Forms.PictureBox()
        Me.picPizzaSelected_Vego = New System.Windows.Forms.PictureBox()
        Me.picPizzaSelected_Hawaiian = New System.Windows.Forms.PictureBox()
        Me.picPizzaSelected_Pepperoni = New System.Windows.Forms.PictureBox()
        Me.nudNumberPizzas = New System.Windows.Forms.NumericUpDown()
        Me.cmbPizzaSelect = New System.Windows.Forms.ComboBox()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.nudH20 = New System.Windows.Forms.NumericUpDown()
        Me.picH20 = New System.Windows.Forms.PictureBox()
        Me.nudSprite = New System.Windows.Forms.NumericUpDown()
        Me.picSprite = New System.Windows.Forms.PictureBox()
        Me.nudFanta = New System.Windows.Forms.NumericUpDown()
        Me.picFanta = New System.Windows.Forms.PictureBox()
        Me.nudDietCoke = New System.Windows.Forms.NumericUpDown()
        Me.picDietCoke = New System.Windows.Forms.PictureBox()
        Me.nudCoke = New System.Windows.Forms.NumericUpDown()
        Me.picCoke = New System.Windows.Forms.PictureBox()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkGarlicBread = New System.Windows.Forms.CheckBox()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblSuburb = New System.Windows.Forms.Label()
        Me.txtSuburb = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkHomeDelivery = New System.Windows.Forms.CheckBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.tipPizzaSelect = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipPizzaNum = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipCost = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipSubmitOrder = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpPizzaSelect.SuspendLayout()
        CType(Me.nudNumberPizzas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDrinks.SuspendLayout()
        CType(Me.nudH20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDietCoke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCoke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExtras.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPizzaSelected_Supreme
        '
        Me.picPizzaSelected_Supreme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPizzaSelected_Supreme.Image = CType(resources.GetObject("picPizzaSelected_Supreme.Image"), System.Drawing.Bitmap)
        Me.picPizzaSelected_Supreme.Location = New System.Drawing.Point(8, 40)
        Me.picPizzaSelected_Supreme.Name = "picPizzaSelected_Supreme"
        Me.picPizzaSelected_Supreme.Size = New System.Drawing.Size(342, 256)
        Me.picPizzaSelected_Supreme.TabIndex = 0
        Me.picPizzaSelected_Supreme.TabStop = False
        '
        'grpPizzaSelect
        '
        Me.grpPizzaSelect.BackColor = System.Drawing.SystemColors.Control
        Me.grpPizzaSelect.Controls.AddRange(New System.Windows.Forms.Control() {Me.picPizzaSelected_MeatLovers, Me.picPizzaSelected_Vego, Me.picPizzaSelected_Hawaiian, Me.picPizzaSelected_Pepperoni, Me.nudNumberPizzas, Me.picPizzaSelected_Supreme, Me.cmbPizzaSelect})
        Me.grpPizzaSelect.Location = New System.Drawing.Point(8, 8)
        Me.grpPizzaSelect.Name = "grpPizzaSelect"
        Me.grpPizzaSelect.Size = New System.Drawing.Size(360, 304)
        Me.grpPizzaSelect.TabIndex = 1
        Me.grpPizzaSelect.TabStop = False
        Me.grpPizzaSelect.Text = "Choose a Pizza..."
        '
        'picPizzaSelected_MeatLovers
        '
        Me.picPizzaSelected_MeatLovers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPizzaSelected_MeatLovers.Image = CType(resources.GetObject("picPizzaSelected_MeatLovers.Image"), System.Drawing.Bitmap)
        Me.picPizzaSelected_MeatLovers.Location = New System.Drawing.Point(8, 40)
        Me.picPizzaSelected_MeatLovers.Name = "picPizzaSelected_MeatLovers"
        Me.picPizzaSelected_MeatLovers.Size = New System.Drawing.Size(342, 256)
        Me.picPizzaSelected_MeatLovers.TabIndex = 7
        Me.picPizzaSelected_MeatLovers.TabStop = False
        Me.picPizzaSelected_MeatLovers.Visible = False
        '
        'picPizzaSelected_Vego
        '
        Me.picPizzaSelected_Vego.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPizzaSelected_Vego.Image = CType(resources.GetObject("picPizzaSelected_Vego.Image"), System.Drawing.Bitmap)
        Me.picPizzaSelected_Vego.Location = New System.Drawing.Point(8, 40)
        Me.picPizzaSelected_Vego.Name = "picPizzaSelected_Vego"
        Me.picPizzaSelected_Vego.Size = New System.Drawing.Size(342, 256)
        Me.picPizzaSelected_Vego.TabIndex = 6
        Me.picPizzaSelected_Vego.TabStop = False
        Me.picPizzaSelected_Vego.Visible = False
        '
        'picPizzaSelected_Hawaiian
        '
        Me.picPizzaSelected_Hawaiian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPizzaSelected_Hawaiian.Image = CType(resources.GetObject("picPizzaSelected_Hawaiian.Image"), System.Drawing.Bitmap)
        Me.picPizzaSelected_Hawaiian.Location = New System.Drawing.Point(8, 40)
        Me.picPizzaSelected_Hawaiian.Name = "picPizzaSelected_Hawaiian"
        Me.picPizzaSelected_Hawaiian.Size = New System.Drawing.Size(342, 256)
        Me.picPizzaSelected_Hawaiian.TabIndex = 5
        Me.picPizzaSelected_Hawaiian.TabStop = False
        Me.picPizzaSelected_Hawaiian.Visible = False
        '
        'picPizzaSelected_Pepperoni
        '
        Me.picPizzaSelected_Pepperoni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPizzaSelected_Pepperoni.Image = CType(resources.GetObject("picPizzaSelected_Pepperoni.Image"), System.Drawing.Bitmap)
        Me.picPizzaSelected_Pepperoni.Location = New System.Drawing.Point(8, 40)
        Me.picPizzaSelected_Pepperoni.Name = "picPizzaSelected_Pepperoni"
        Me.picPizzaSelected_Pepperoni.Size = New System.Drawing.Size(342, 256)
        Me.picPizzaSelected_Pepperoni.TabIndex = 4
        Me.picPizzaSelected_Pepperoni.TabStop = False
        Me.picPizzaSelected_Pepperoni.Visible = False
        '
        'nudNumberPizzas
        '
        Me.nudNumberPizzas.Location = New System.Drawing.Point(304, 16)
        Me.nudNumberPizzas.Name = "nudNumberPizzas"
        Me.nudNumberPizzas.Size = New System.Drawing.Size(48, 20)
        Me.nudNumberPizzas.TabIndex = 3
        Me.nudNumberPizzas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbPizzaSelect
        '
        Me.cmbPizzaSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPizzaSelect.Items.AddRange(New Object() {"Supreme ($15.50)", "Vegetarian ($12.20)", "Meat Lovers ($13.00)", "Hawaiian ($12.50)", "Pepperoni ($13.00)"})
        Me.cmbPizzaSelect.Location = New System.Drawing.Point(8, 16)
        Me.cmbPizzaSelect.Name = "cmbPizzaSelect"
        Me.cmbPizzaSelect.Size = New System.Drawing.Size(296, 21)
        Me.cmbPizzaSelect.TabIndex = 2
        '
        'grpDrinks
        '
        Me.grpDrinks.Controls.AddRange(New System.Windows.Forms.Control() {Me.nudH20, Me.picH20, Me.nudSprite, Me.picSprite, Me.nudFanta, Me.picFanta, Me.nudDietCoke, Me.picDietCoke, Me.nudCoke, Me.picCoke})
        Me.grpDrinks.Location = New System.Drawing.Point(8, 72)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(160, 184)
        Me.grpDrinks.TabIndex = 2
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Drinks? ($2.50ea)"
        '
        'nudH20
        '
        Me.nudH20.Location = New System.Drawing.Point(104, 152)
        Me.nudH20.Name = "nudH20"
        Me.nudH20.Size = New System.Drawing.Size(48, 20)
        Me.nudH20.TabIndex = 9
        '
        'picH20
        '
        Me.picH20.Image = CType(resources.GetObject("picH20.Image"), System.Drawing.Bitmap)
        Me.picH20.Location = New System.Drawing.Point(8, 144)
        Me.picH20.Name = "picH20"
        Me.picH20.Size = New System.Drawing.Size(93, 32)
        Me.picH20.TabIndex = 8
        Me.picH20.TabStop = False
        '
        'nudSprite
        '
        Me.nudSprite.Location = New System.Drawing.Point(104, 120)
        Me.nudSprite.Name = "nudSprite"
        Me.nudSprite.Size = New System.Drawing.Size(48, 20)
        Me.nudSprite.TabIndex = 7
        '
        'picSprite
        '
        Me.picSprite.Image = CType(resources.GetObject("picSprite.Image"), System.Drawing.Bitmap)
        Me.picSprite.Location = New System.Drawing.Point(8, 112)
        Me.picSprite.Name = "picSprite"
        Me.picSprite.Size = New System.Drawing.Size(93, 32)
        Me.picSprite.TabIndex = 6
        Me.picSprite.TabStop = False
        '
        'nudFanta
        '
        Me.nudFanta.Location = New System.Drawing.Point(104, 88)
        Me.nudFanta.Name = "nudFanta"
        Me.nudFanta.Size = New System.Drawing.Size(48, 20)
        Me.nudFanta.TabIndex = 5
        '
        'picFanta
        '
        Me.picFanta.Image = CType(resources.GetObject("picFanta.Image"), System.Drawing.Bitmap)
        Me.picFanta.Location = New System.Drawing.Point(8, 80)
        Me.picFanta.Name = "picFanta"
        Me.picFanta.Size = New System.Drawing.Size(93, 32)
        Me.picFanta.TabIndex = 4
        Me.picFanta.TabStop = False
        '
        'nudDietCoke
        '
        Me.nudDietCoke.Location = New System.Drawing.Point(104, 56)
        Me.nudDietCoke.Name = "nudDietCoke"
        Me.nudDietCoke.Size = New System.Drawing.Size(48, 20)
        Me.nudDietCoke.TabIndex = 3
        '
        'picDietCoke
        '
        Me.picDietCoke.Image = CType(resources.GetObject("picDietCoke.Image"), System.Drawing.Bitmap)
        Me.picDietCoke.Location = New System.Drawing.Point(8, 48)
        Me.picDietCoke.Name = "picDietCoke"
        Me.picDietCoke.Size = New System.Drawing.Size(93, 32)
        Me.picDietCoke.TabIndex = 2
        Me.picDietCoke.TabStop = False
        '
        'nudCoke
        '
        Me.nudCoke.Location = New System.Drawing.Point(104, 24)
        Me.nudCoke.Name = "nudCoke"
        Me.nudCoke.Size = New System.Drawing.Size(48, 20)
        Me.nudCoke.TabIndex = 1
        '
        'picCoke
        '
        Me.picCoke.Image = CType(resources.GetObject("picCoke.Image"), System.Drawing.Bitmap)
        Me.picCoke.Location = New System.Drawing.Point(8, 16)
        Me.picCoke.Name = "picCoke"
        Me.picCoke.Size = New System.Drawing.Size(93, 32)
        Me.picCoke.TabIndex = 0
        Me.picCoke.TabStop = False
        '
        'grpExtras
        '
        Me.grpExtras.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkCheese, Me.chkGarlicBread, Me.grpDrinks})
        Me.grpExtras.Location = New System.Drawing.Point(376, 8)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(176, 264)
        Me.grpExtras.TabIndex = 3
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras?"
        '
        'chkCheese
        '
        Me.chkCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheese.Location = New System.Drawing.Point(8, 40)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(160, 24)
        Me.chkCheese.TabIndex = 1
        Me.chkCheese.Text = "Extra Cheese ($0.50)"
        '
        'chkGarlicBread
        '
        Me.chkGarlicBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarlicBread.Location = New System.Drawing.Point(8, 16)
        Me.chkGarlicBread.Name = "chkGarlicBread"
        Me.chkGarlicBread.Size = New System.Drawing.Size(160, 24)
        Me.chkGarlicBread.TabIndex = 0
        Me.chkGarlicBread.Text = "Garlic Bread ($3.00)"
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtPhoneNumber, Me.lblPhoneNumber, Me.lblSuburb, Me.txtSuburb, Me.txtAddress, Me.lblAddress, Me.lblName, Me.txtName})
        Me.grpDelivery.Location = New System.Drawing.Point(560, 8)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(288, 152)
        Me.grpDelivery.TabIndex = 4
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Delivery Details"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Enabled = False
        Me.txtPhoneNumber.Location = New System.Drawing.Point(96, 128)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(184, 20)
        Me.txtPhoneNumber.TabIndex = 7
        Me.txtPhoneNumber.Text = ""
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.Enabled = False
        Me.lblPhoneNumber.Location = New System.Drawing.Point(8, 128)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(88, 16)
        Me.lblPhoneNumber.TabIndex = 6
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblSuburb
        '
        Me.lblSuburb.Enabled = False
        Me.lblSuburb.Location = New System.Drawing.Point(8, 104)
        Me.lblSuburb.Name = "lblSuburb"
        Me.lblSuburb.Size = New System.Drawing.Size(48, 16)
        Me.lblSuburb.TabIndex = 5
        Me.lblSuburb.Text = "Suburb"
        '
        'txtSuburb
        '
        Me.txtSuburb.Enabled = False
        Me.txtSuburb.Location = New System.Drawing.Point(56, 104)
        Me.txtSuburb.Name = "txtSuburb"
        Me.txtSuburb.Size = New System.Drawing.Size(224, 20)
        Me.txtSuburb.TabIndex = 4
        Me.txtSuburb.Text = ""
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(8, 80)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(272, 20)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = ""
        '
        'lblAddress
        '
        Me.lblAddress.Enabled = False
        Me.lblAddress.Location = New System.Drawing.Point(8, 64)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(112, 16)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(8, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(112, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(8, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(272, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = ""
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.LightBlue
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(560, 168)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(288, 104)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "$15.50"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(560, 280)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(288, 32)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit Order"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(464, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 32)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Order"
        '
        'chkHomeDelivery
        '
        Me.chkHomeDelivery.Location = New System.Drawing.Point(568, 8)
        Me.chkHomeDelivery.Name = "chkHomeDelivery"
        Me.chkHomeDelivery.Size = New System.Drawing.Size(104, 16)
        Me.chkHomeDelivery.TabIndex = 8
        Me.chkHomeDelivery.Text = "Home Delivery?"
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(376, 280)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(80, 32)
        Me.btnAbout.TabIndex = 9
        Me.btnAbout.Text = "About..."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(858, 320)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAbout, Me.btnClear, Me.btnSubmit, Me.lblPrice, Me.grpExtras, Me.grpPizzaSelect, Me.chkHomeDelivery, Me.grpDelivery})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza Order Form"
        Me.grpPizzaSelect.ResumeLayout(False)
        CType(Me.nudNumberPizzas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDrinks.ResumeLayout(False)
        CType(Me.nudH20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDietCoke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCoke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExtras.ResumeLayout(False)
        Me.grpDelivery.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub CalculateTotals()
        TotalPrice = 0.0
        Select Case cmbPizzaSelect.SelectedItem
            Case "Supreme ($15.50)"
                TotalPrice = TotalPrice + 15.5 * nudNumberPizzas.Value
            Case "Vegetarian ($12.20)"
                TotalPrice = TotalPrice + 12.2 * nudNumberPizzas.Value
            Case "Meat Lovers ($13.00)"
                TotalPrice = TotalPrice + 13.0 * nudNumberPizzas.Value
            Case "Hawaiian ($12.50)"
                TotalPrice = TotalPrice + 12.5 * nudNumberPizzas.Value
            Case "Pepperoni ($13.00)"
                TotalPrice = TotalPrice + 13.0 * nudNumberPizzas.Value
        End Select
        If chkCheese.Checked = True Then
            TotalPrice = TotalPrice + 0.5 * nudNumberPizzas.Value
        End If
        If chkGarlicBread.Checked = True Then
            TotalPrice = TotalPrice + 3.0
        End If
        TotalPrice = TotalPrice + 2.5 * nudCoke.Value
        TotalPrice = TotalPrice + 2.5 * nudDietCoke.Value
        TotalPrice = TotalPrice + 2.5 * nudFanta.Value
        TotalPrice = TotalPrice + 2.5 * nudSprite.Value
        TotalPrice = TotalPrice + 2.5 * nudH20.Value
        CheckCurrency()
        lblPrice.Text = "$" & TotalPriceStr
    End Sub

    Public Sub CheckCurrency()
        TotalPriceStr = TotalPrice
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Order()
    End Sub

    Private Sub nudCoke_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPizzaSelect.SelectedIndexChanged, chkGarlicBread.CheckedChanged, nudNumberPizzas.ValueChanged, chkCheese.CheckedChanged, nudCoke.ValueChanged, nudDietCoke.ValueChanged, nudFanta.ValueChanged, nudSprite.ValueChanged, nudH20.ValueChanged
        CalculateTotals()
    End Sub

    Private Sub cmbPizzaSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPizzaSelect.SelectedIndexChanged
        Select Case cmbPizzaSelect.SelectedItem
            Case "Supreme ($15.50)"
                picPizzaSelected_Supreme.Visible = True
                picPizzaSelected_Pepperoni.Visible = False
                picPizzaSelected_Vego.Visible = False
                picPizzaSelected_Hawaiian.Visible = False
                picPizzaSelected_MeatLovers.Visible = False
            Case "Vegetarian ($12.20)"
                picPizzaSelected_Supreme.Visible = False
                picPizzaSelected_Pepperoni.Visible = False
                picPizzaSelected_Vego.Visible = True
                picPizzaSelected_Hawaiian.Visible = False
                picPizzaSelected_MeatLovers.Visible = False
            Case "Meat Lovers ($13.00)"
                picPizzaSelected_Supreme.Visible = False
                picPizzaSelected_Pepperoni.Visible = False
                picPizzaSelected_Vego.Visible = False
                picPizzaSelected_Hawaiian.Visible = False
                picPizzaSelected_MeatLovers.Visible = True
            Case "Hawaiian ($12.50)"
                picPizzaSelected_Supreme.Visible = False
                picPizzaSelected_Pepperoni.Visible = False
                picPizzaSelected_Vego.Visible = False
                picPizzaSelected_Hawaiian.Visible = True
                picPizzaSelected_MeatLovers.Visible = False
            Case "Pepperoni ($13.00)"
                picPizzaSelected_Supreme.Visible = False
                picPizzaSelected_Pepperoni.Visible = True
                picPizzaSelected_Vego.Visible = False
                picPizzaSelected_Hawaiian.Visible = False
                picPizzaSelected_MeatLovers.Visible = False
            Case Else
                'shut dawwwwwwwn, paul.
        End Select
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        chkGarlicBread.Checked = False
        chkCheese.Checked = False
        nudCoke.Value = 0
        nudFanta.Value = 0
        nudSprite.Value = 0
        nudH20.Value = 0
        nudDietCoke.Value = 0
        nudNumberPizzas.Value = 1
        cmbPizzaSelect.SelectedItem = "Supreme ($15.50)"
        CalculateTotals()
    End Sub

    Private Sub chkHomeDelivery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHomeDelivery.CheckedChanged
        If chkHomeDelivery.Checked = True Then
            txtAddress.Enabled = True
            lblAddress.Enabled = True
            txtSuburb.Enabled = True
            lblSuburb.Enabled = True
            txtPhoneNumber.Enabled = True
            lblPhoneNumber.Enabled = True
        Else
            txtAddress.Enabled = False
            lblAddress.Enabled = False
            txtSuburb.Enabled = False
            lblSuburb.Enabled = False
            txtPhoneNumber.Enabled = False
            lblPhoneNumber.Enabled = False
        End If
    End Sub
    Public Sub Order()
        Dim sSubmitForm As FormSubmitting = New FormSubmitting()
        CalculateTotals()
        Me.Opacity = 0.5
        Me.Enabled = False
        If chkHomeDelivery.Checked = True Then
            If txtAddress.Text = "" Or txtSuburb.Text = "" Or txtPhoneNumber.Text = "" Then
                MsgBox("You must enter your address Details for a home delivery!", MsgBoxStyle.Exclamation, "Pizza Order Form - Error!")
            Else
                If txtName.Text <> "" Then
                    If TotalPrice = 0.0 Then
                        MsgBox("You have not ordered anything. Please enter an order.", MsgBoxStyle.Information, "Pizza Order Form - Error!")
                    Else
                        sSubmitForm.Show()
                    End If
                Else
                    MsgBox("You must enter your name in order to place an order.", MsgBoxStyle.Information, "Pizza Order Form - Error!")
                End If
            End If
        Else
            If txtName.Text <> "" Then
                If TotalPrice = 0.0 Then
                    MsgBox("You have not ordered anything. Please enter an order.", MsgBoxStyle.Information, "Pizza Order Form - Error!")
                Else
                    sSubmitForm.Show()
                End If
            Else
                MsgBox("You must enter your name in order to place an order.", MsgBoxStyle.Information, "Pizza Order Form - Error!")
            End If
        End If
        Me.Enabled = True
        Me.Opacity = 1
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        Dim AboutBox As New aboutbox()
        AboutBox.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tipPizzaSelect.SetToolTip(cmbPizzaSelect, "Select a Pizza using this list.")
        tipPizzaNum.SetToolTip(nudNumberPizzas, "Select the number of pizzas you want to buy.")
        tipCost.SetToolTip(lblPrice, "This is the toal price of your order.")
        tipSubmitOrder.SetToolTip(btnSubmit, "Click this button to submit your order to us.")
    End Sub
End Class
