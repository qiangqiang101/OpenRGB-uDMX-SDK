<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Label1 = New Label()
        cmbDeviceName = New ComboBox()
        cmbDeviceZone = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnConnect = New Button()
        gbChannels = New GroupBox()
        Label14 = New Label()
        tbCh10 = New TrackBar()
        Label13 = New Label()
        tbCh9 = New TrackBar()
        Label12 = New Label()
        tbCh8 = New TrackBar()
        Label11 = New Label()
        tbCh7 = New TrackBar()
        Label10 = New Label()
        tbCh6 = New TrackBar()
        Label9 = New Label()
        tbCh5 = New TrackBar()
        Label8 = New Label()
        tbCh4 = New TrackBar()
        Label7 = New Label()
        tbCh3 = New TrackBar()
        Label6 = New Label()
        tbCh2 = New TrackBar()
        Label5 = New Label()
        tbCh1 = New TrackBar()
        nudRed = New NumericUpDown()
        Label15 = New Label()
        GroupBox2 = New GroupBox()
        cmbDeviceZoneXY = New ComboBox()
        Label23 = New Label()
        nudY = New NumericUpDown()
        Label22 = New Label()
        Label21 = New Label()
        nudX = New NumericUpDown()
        Label20 = New Label()
        nudWhite = New NumericUpDown()
        Label19 = New Label()
        nudSmooth = New NumericUpDown()
        Label18 = New Label()
        nudBright = New NumericUpDown()
        Label17 = New Label()
        nudBlue = New NumericUpDown()
        Label16 = New Label()
        nudGreen = New NumericUpDown()
        txtIpAddress = New TextBox()
        txtPort = New TextBox()
        btnSave = New Button()
        timerRGB = New Timer(components)
        timerXY = New Timer(components)
        niNotify = New NotifyIcon(components)
        gbChannels.SuspendLayout()
        CType(tbCh10, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbCh9, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbCh8, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbCh7, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbCh6, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbCh5, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbCh4, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbCh3, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbCh2, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbCh1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudRed, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(nudY, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudX, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudWhite, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSmooth, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBright, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBlue, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudGreen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 0
        Label1.Text = "Device Name:"
        ' 
        ' cmbDeviceName
        ' 
        cmbDeviceName.BackColor = SystemColors.ControlDarkDark
        cmbDeviceName.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDeviceName.ForeColor = SystemColors.ControlLightLight
        cmbDeviceName.FormattingEnabled = True
        cmbDeviceName.Location = New Point(112, 138)
        cmbDeviceName.Name = "cmbDeviceName"
        cmbDeviceName.Size = New Size(307, 23)
        cmbDeviceName.TabIndex = 8
        ' 
        ' cmbDeviceZone
        ' 
        cmbDeviceZone.BackColor = SystemColors.ControlDarkDark
        cmbDeviceZone.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDeviceZone.ForeColor = SystemColors.ControlLightLight
        cmbDeviceZone.FormattingEnabled = True
        cmbDeviceZone.Location = New Point(112, 167)
        cmbDeviceZone.Name = "cmbDeviceZone"
        cmbDeviceZone.Size = New Size(307, 23)
        cmbDeviceZone.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 2
        Label2.Text = "Color Zone:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 15)
        Label3.TabIndex = 5
        Label3.Text = "IP:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(217, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 7
        Label4.Text = "Port:"
        ' 
        ' btnConnect
        ' 
        btnConnect.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnConnect.BackColor = SystemColors.ControlDarkDark
        btnConnect.Location = New Point(452, 12)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(75, 23)
        btnConnect.TabIndex = 3
        btnConnect.Tag = "start"
        btnConnect.Text = "Connect"
        btnConnect.UseVisualStyleBackColor = False
        ' 
        ' gbChannels
        ' 
        gbChannels.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gbChannels.Controls.Add(Label14)
        gbChannels.Controls.Add(tbCh10)
        gbChannels.Controls.Add(Label13)
        gbChannels.Controls.Add(tbCh9)
        gbChannels.Controls.Add(Label12)
        gbChannels.Controls.Add(tbCh8)
        gbChannels.Controls.Add(Label11)
        gbChannels.Controls.Add(tbCh7)
        gbChannels.Controls.Add(Label10)
        gbChannels.Controls.Add(tbCh6)
        gbChannels.Controls.Add(Label9)
        gbChannels.Controls.Add(tbCh5)
        gbChannels.Controls.Add(Label8)
        gbChannels.Controls.Add(tbCh4)
        gbChannels.Controls.Add(Label7)
        gbChannels.Controls.Add(tbCh3)
        gbChannels.Controls.Add(Label6)
        gbChannels.Controls.Add(tbCh2)
        gbChannels.Controls.Add(Label5)
        gbChannels.Controls.Add(tbCh1)
        gbChannels.ForeColor = SystemColors.ControlLightLight
        gbChannels.Location = New Point(12, 276)
        gbChannels.Name = "gbChannels"
        gbChannels.Size = New Size(515, 373)
        gbChannels.TabIndex = 4
        gbChannels.TabStop = False
        gbChannels.Text = "Channels"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Bottom
        Label14.AutoSize = True
        Label14.Location = New Point(469, 353)
        Label14.Name = "Label14"
        Label14.Size = New Size(36, 15)
        Label14.TabIndex = 23
        Label14.Text = "CH10"
        ' 
        ' tbCh10
        ' 
        tbCh10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh10.Location = New Point(465, 22)
        tbCh10.Maximum = 255
        tbCh10.Name = "tbCh10"
        tbCh10.Orientation = Orientation.Vertical
        tbCh10.Size = New Size(45, 328)
        tbCh10.TabIndex = 9
        tbCh10.TickFrequency = 5
        tbCh10.TickStyle = TickStyle.Both
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Bottom
        Label13.AutoSize = True
        Label13.Location = New Point(418, 353)
        Label13.Name = "Label13"
        Label13.Size = New Size(30, 15)
        Label13.TabIndex = 21
        Label13.Text = "CH9"
        ' 
        ' tbCh9
        ' 
        tbCh9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh9.Location = New Point(414, 22)
        tbCh9.Maximum = 255
        tbCh9.Name = "tbCh9"
        tbCh9.Orientation = Orientation.Vertical
        tbCh9.Size = New Size(45, 328)
        tbCh9.TabIndex = 8
        tbCh9.TickFrequency = 5
        tbCh9.TickStyle = TickStyle.Both
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Bottom
        Label12.AutoSize = True
        Label12.Location = New Point(367, 353)
        Label12.Name = "Label12"
        Label12.Size = New Size(30, 15)
        Label12.TabIndex = 19
        Label12.Text = "CH8"
        ' 
        ' tbCh8
        ' 
        tbCh8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh8.Location = New Point(363, 22)
        tbCh8.Maximum = 255
        tbCh8.Name = "tbCh8"
        tbCh8.Orientation = Orientation.Vertical
        tbCh8.Size = New Size(45, 328)
        tbCh8.TabIndex = 7
        tbCh8.TickFrequency = 5
        tbCh8.TickStyle = TickStyle.Both
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Bottom
        Label11.AutoSize = True
        Label11.Location = New Point(316, 353)
        Label11.Name = "Label11"
        Label11.Size = New Size(30, 15)
        Label11.TabIndex = 17
        Label11.Text = "CH7"
        ' 
        ' tbCh7
        ' 
        tbCh7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh7.Location = New Point(312, 22)
        tbCh7.Maximum = 255
        tbCh7.Name = "tbCh7"
        tbCh7.Orientation = Orientation.Vertical
        tbCh7.Size = New Size(45, 328)
        tbCh7.TabIndex = 6
        tbCh7.TickFrequency = 5
        tbCh7.TickStyle = TickStyle.Both
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Bottom
        Label10.AutoSize = True
        Label10.Location = New Point(265, 353)
        Label10.Name = "Label10"
        Label10.Size = New Size(30, 15)
        Label10.TabIndex = 15
        Label10.Text = "CH6"
        ' 
        ' tbCh6
        ' 
        tbCh6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh6.Location = New Point(261, 22)
        tbCh6.Maximum = 255
        tbCh6.Name = "tbCh6"
        tbCh6.Orientation = Orientation.Vertical
        tbCh6.Size = New Size(45, 328)
        tbCh6.TabIndex = 5
        tbCh6.TickFrequency = 5
        tbCh6.TickStyle = TickStyle.Both
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Bottom
        Label9.AutoSize = True
        Label9.Location = New Point(214, 353)
        Label9.Name = "Label9"
        Label9.Size = New Size(30, 15)
        Label9.TabIndex = 13
        Label9.Text = "CH5"
        ' 
        ' tbCh5
        ' 
        tbCh5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh5.Location = New Point(210, 22)
        tbCh5.Maximum = 255
        tbCh5.Name = "tbCh5"
        tbCh5.Orientation = Orientation.Vertical
        tbCh5.Size = New Size(45, 328)
        tbCh5.TabIndex = 4
        tbCh5.TickFrequency = 5
        tbCh5.TickStyle = TickStyle.Both
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.Location = New Point(163, 353)
        Label8.Name = "Label8"
        Label8.Size = New Size(30, 15)
        Label8.TabIndex = 11
        Label8.Text = "CH4"
        ' 
        ' tbCh4
        ' 
        tbCh4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh4.Location = New Point(159, 22)
        tbCh4.Maximum = 255
        tbCh4.Name = "tbCh4"
        tbCh4.Orientation = Orientation.Vertical
        tbCh4.Size = New Size(45, 328)
        tbCh4.TabIndex = 3
        tbCh4.TickFrequency = 5
        tbCh4.TickStyle = TickStyle.Both
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Bottom
        Label7.AutoSize = True
        Label7.Location = New Point(112, 353)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 15)
        Label7.TabIndex = 9
        Label7.Text = "CH3"
        ' 
        ' tbCh3
        ' 
        tbCh3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh3.Location = New Point(108, 22)
        tbCh3.Maximum = 255
        tbCh3.Name = "tbCh3"
        tbCh3.Orientation = Orientation.Vertical
        tbCh3.Size = New Size(45, 328)
        tbCh3.TabIndex = 2
        tbCh3.TickFrequency = 5
        tbCh3.TickStyle = TickStyle.Both
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom
        Label6.AutoSize = True
        Label6.Location = New Point(61, 353)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 15)
        Label6.TabIndex = 7
        Label6.Text = "CH2"
        ' 
        ' tbCh2
        ' 
        tbCh2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh2.Location = New Point(57, 22)
        tbCh2.Maximum = 255
        tbCh2.Name = "tbCh2"
        tbCh2.Orientation = Orientation.Vertical
        tbCh2.Size = New Size(45, 328)
        tbCh2.TabIndex = 1
        tbCh2.TickFrequency = 5
        tbCh2.TickStyle = TickStyle.Both
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom
        Label5.AutoSize = True
        Label5.Location = New Point(10, 353)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 5
        Label5.Text = "CH1"
        ' 
        ' tbCh1
        ' 
        tbCh1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        tbCh1.Location = New Point(6, 22)
        tbCh1.Maximum = 255
        tbCh1.Name = "tbCh1"
        tbCh1.Orientation = Orientation.Vertical
        tbCh1.Size = New Size(45, 328)
        tbCh1.TabIndex = 0
        tbCh1.TickFrequency = 5
        tbCh1.TickStyle = TickStyle.Both
        ' 
        ' nudRed
        ' 
        nudRed.BackColor = SystemColors.ControlDarkDark
        nudRed.ForeColor = SystemColors.ControlLightLight
        nudRed.Location = New Point(113, 22)
        nudRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudRed.Name = "nudRed"
        nudRed.Size = New Size(74, 23)
        nudRed.TabIndex = 0
        nudRed.Value = New Decimal(New Integer() {7, 0, 0, 0})
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(6, 24)
        Label15.Name = "Label15"
        Label15.Size = New Size(77, 15)
        Label15.TabIndex = 25
        Label15.Text = "Red Channel:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(cmbDeviceZoneXY)
        GroupBox2.Controls.Add(Label23)
        GroupBox2.Controls.Add(nudY)
        GroupBox2.Controls.Add(Label22)
        GroupBox2.Controls.Add(Label21)
        GroupBox2.Controls.Add(nudX)
        GroupBox2.Controls.Add(Label20)
        GroupBox2.Controls.Add(nudWhite)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(nudSmooth)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(nudBright)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(nudBlue)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(nudGreen)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(nudRed)
        GroupBox2.Controls.Add(cmbDeviceName)
        GroupBox2.Controls.Add(cmbDeviceZone)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.ForeColor = SystemColors.ControlLightLight
        GroupBox2.Location = New Point(12, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(515, 229)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Device"
        ' 
        ' cmbDeviceZoneXY
        ' 
        cmbDeviceZoneXY.BackColor = SystemColors.ControlDarkDark
        cmbDeviceZoneXY.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDeviceZoneXY.ForeColor = SystemColors.ControlLightLight
        cmbDeviceZoneXY.FormattingEnabled = True
        cmbDeviceZoneXY.Location = New Point(112, 196)
        cmbDeviceZoneXY.Name = "cmbDeviceZoneXY"
        cmbDeviceZoneXY.Size = New Size(307, 23)
        cmbDeviceZoneXY.TabIndex = 10
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(6, 199)
        Label23.Name = "Label23"
        Label23.Size = New Size(85, 15)
        Label23.TabIndex = 41
        Label23.Text = "Rotation Zone:"
        ' 
        ' nudY
        ' 
        nudY.BackColor = SystemColors.ControlDarkDark
        nudY.ForeColor = SystemColors.ControlLightLight
        nudY.Location = New Point(321, 109)
        nudY.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudY.Name = "nudY"
        nudY.Size = New Size(74, 23)
        nudY.TabIndex = 7
        nudY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(194, 111)
        Label22.Name = "Label22"
        Label22.Size = New Size(101, 15)
        Label22.TabIndex = 39
        Label22.Text = "Rotate Y Channel:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(6, 111)
        Label21.Name = "Label21"
        Label21.Size = New Size(101, 15)
        Label21.TabIndex = 37
        Label21.Text = "Rotate X Channel:"
        ' 
        ' nudX
        ' 
        nudX.BackColor = SystemColors.ControlDarkDark
        nudX.ForeColor = SystemColors.ControlLightLight
        nudX.Location = New Point(113, 109)
        nudX.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudX.Name = "nudX"
        nudX.Size = New Size(74, 23)
        nudX.TabIndex = 6
        nudX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(6, 82)
        Label20.Name = "Label20"
        Label20.Size = New Size(88, 15)
        Label20.TabIndex = 35
        Label20.Text = "White Channel:"
        ' 
        ' nudWhite
        ' 
        nudWhite.BackColor = SystemColors.ControlDarkDark
        nudWhite.ForeColor = SystemColors.ControlLightLight
        nudWhite.Location = New Point(113, 80)
        nudWhite.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudWhite.Name = "nudWhite"
        nudWhite.Size = New Size(74, 23)
        nudWhite.TabIndex = 4
        nudWhite.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(193, 82)
        Label19.Name = "Label19"
        Label19.Size = New Size(122, 15)
        Label19.TabIndex = 33
        Label19.Text = "Smoothness Channel:"
        ' 
        ' nudSmooth
        ' 
        nudSmooth.BackColor = SystemColors.ControlDarkDark
        nudSmooth.ForeColor = SystemColors.ControlLightLight
        nudSmooth.Location = New Point(321, 80)
        nudSmooth.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudSmooth.Name = "nudSmooth"
        nudSmooth.Size = New Size(74, 23)
        nudSmooth.TabIndex = 5
        nudSmooth.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(193, 53)
        Label18.Name = "Label18"
        Label18.Size = New Size(112, 15)
        Label18.TabIndex = 31
        Label18.Text = "Brightness Channel:"
        ' 
        ' nudBright
        ' 
        nudBright.BackColor = SystemColors.ControlDarkDark
        nudBright.ForeColor = SystemColors.ControlLightLight
        nudBright.Location = New Point(321, 51)
        nudBright.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudBright.Name = "nudBright"
        nudBright.Size = New Size(74, 23)
        nudBright.TabIndex = 3
        nudBright.Value = New Decimal(New Integer() {6, 0, 0, 0})
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(6, 53)
        Label17.Name = "Label17"
        Label17.Size = New Size(80, 15)
        Label17.TabIndex = 29
        Label17.Text = "Blue Channel:"
        ' 
        ' nudBlue
        ' 
        nudBlue.BackColor = SystemColors.ControlDarkDark
        nudBlue.ForeColor = SystemColors.ControlLightLight
        nudBlue.Location = New Point(113, 51)
        nudBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudBlue.Name = "nudBlue"
        nudBlue.Size = New Size(74, 23)
        nudBlue.TabIndex = 2
        nudBlue.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(193, 24)
        Label16.Name = "Label16"
        Label16.Size = New Size(88, 15)
        Label16.TabIndex = 27
        Label16.Text = "Green Channel:"
        ' 
        ' nudGreen
        ' 
        nudGreen.BackColor = SystemColors.ControlDarkDark
        nudGreen.ForeColor = SystemColors.ControlLightLight
        nudGreen.Location = New Point(321, 22)
        nudGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudGreen.Name = "nudGreen"
        nudGreen.Size = New Size(74, 23)
        nudGreen.TabIndex = 1
        nudGreen.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' txtIpAddress
        ' 
        txtIpAddress.BackColor = SystemColors.ControlDarkDark
        txtIpAddress.ForeColor = SystemColors.ControlLightLight
        txtIpAddress.Location = New Point(38, 12)
        txtIpAddress.Name = "txtIpAddress"
        txtIpAddress.Size = New Size(173, 23)
        txtIpAddress.TabIndex = 0
        txtIpAddress.Text = "127.0.0.1"
        ' 
        ' txtPort
        ' 
        txtPort.BackColor = SystemColors.ControlDarkDark
        txtPort.ForeColor = SystemColors.ControlLightLight
        txtPort.Location = New Point(255, 12)
        txtPort.Name = "txtPort"
        txtPort.Size = New Size(72, 23)
        txtPort.TabIndex = 1
        txtPort.Text = "6742"
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSave.BackColor = SystemColors.ControlDarkDark
        btnSave.Location = New Point(371, 12)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' timerRGB
        ' 
        timerRGB.Interval = 50
        ' 
        ' timerXY
        ' 
        timerXY.Interval = 1000
        ' 
        ' niNotify
        ' 
        niNotify.BalloonTipIcon = ToolTipIcon.Info
        niNotify.BalloonTipText = "You can access setting by right clicking the icon."
        niNotify.BalloonTipTitle = "OpenRGB uDMX SDK"
        niNotify.Icon = CType(resources.GetObject("niNotify.Icon"), Icon)
        niNotify.Text = "OpenRGB uDMX SDK"
        niNotify.Visible = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(539, 661)
        Controls.Add(btnSave)
        Controls.Add(txtPort)
        Controls.Add(txtIpAddress)
        Controls.Add(GroupBox2)
        Controls.Add(gbChannels)
        Controls.Add(btnConnect)
        Controls.Add(Label4)
        Controls.Add(Label3)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlLightLight
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(555, 482)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OpenRGB uDMX SDK"
        gbChannels.ResumeLayout(False)
        gbChannels.PerformLayout()
        CType(tbCh10, ComponentModel.ISupportInitialize).EndInit()
        CType(tbCh9, ComponentModel.ISupportInitialize).EndInit()
        CType(tbCh8, ComponentModel.ISupportInitialize).EndInit()
        CType(tbCh7, ComponentModel.ISupportInitialize).EndInit()
        CType(tbCh6, ComponentModel.ISupportInitialize).EndInit()
        CType(tbCh5, ComponentModel.ISupportInitialize).EndInit()
        CType(tbCh4, ComponentModel.ISupportInitialize).EndInit()
        CType(tbCh3, ComponentModel.ISupportInitialize).EndInit()
        CType(tbCh2, ComponentModel.ISupportInitialize).EndInit()
        CType(tbCh1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudRed, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(nudY, ComponentModel.ISupportInitialize).EndInit()
        CType(nudX, ComponentModel.ISupportInitialize).EndInit()
        CType(nudWhite, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSmooth, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBright, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBlue, ComponentModel.ISupportInitialize).EndInit()
        CType(nudGreen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDeviceName As ComboBox
    Friend WithEvents cmbDeviceZone As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents gbChannels As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbCh10 As TrackBar
    Friend WithEvents Label13 As Label
    Friend WithEvents tbCh9 As TrackBar
    Friend WithEvents Label12 As Label
    Friend WithEvents tbCh8 As TrackBar
    Friend WithEvents Label11 As Label
    Friend WithEvents tbCh7 As TrackBar
    Friend WithEvents Label10 As Label
    Friend WithEvents tbCh6 As TrackBar
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCh5 As TrackBar
    Friend WithEvents Label8 As Label
    Friend WithEvents tbCh4 As TrackBar
    Friend WithEvents Label7 As Label
    Friend WithEvents tbCh3 As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCh2 As TrackBar
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCh1 As TrackBar
    Friend WithEvents nudRed As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents nudSmooth As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents nudBright As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents nudBlue As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents nudGreen As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents nudX As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents nudWhite As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents txtIpAddress As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents nudY As NumericUpDown
    Friend WithEvents btnSave As Button
    Friend WithEvents timerRGB As Timer
    Friend WithEvents timerXY As Timer
    Friend WithEvents cmbDeviceZoneXY As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents niNotify As NotifyIcon

End Class
