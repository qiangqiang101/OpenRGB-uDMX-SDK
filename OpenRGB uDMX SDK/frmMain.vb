Imports System.IO
Imports System.Security.Policy
Imports OpenRGB.NET
Imports OColor = OpenRGB.NET.Color
Imports Color = System.Drawing.Color

Public Class frmMain

    Private oRgbClient As OpenRGBClient
    Private lastColor As Color = Color.Black
    Private lastXY As Color = Color.Black

    Private colorZone As Integer = 0
    Private xyZone As Integer = 0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(UserSettingFile) Then
            Dim newUSD As New UserSettingData(UserSettingFile)
            With newUSD
                .IpAddress = "127.0.0.1"
                .Port = 6742
                .RedChannel = 7
                .GreenChannel = 8
                .BlueChannel = 9
                .WhiteChannel = 10
                .SmoothnessChannel = 5
                .BrightnessChannel = 6
                .RotationXChannel = 1
                .RotationYChannel = 3

                Try
                    Using oRgbClient As New OpenRgbClient(name:="Getting devices information", protocolVersionNumber:=4)
                        If oRgbClient.Connected Then
                            Dim firstDevice = oRgbClient.GetAllControllerData.Where(Function(x) x.Type = DeviceType.Ledstrip AndAlso x.Description = "DMX Device").FirstOrDefault
                            If firstDevice IsNot Nothing Then
                                .DeviceName = firstDevice.Name

                                Dim firstZone = oRgbClient.GetAllControllerData.Where(Function(x) x.Name = .DeviceName).FirstOrDefault.Zones.FirstOrDefault
                                If firstZone IsNot Nothing Then
                                    .DeviceZoneColor = firstZone.Name
                                End If

                                Dim secondZone = oRgbClient.GetAllControllerData.Where(Function(x) x.Name = .DeviceName).FirstOrDefault.Zones(1)
                                If secondZone IsNot Nothing Then
                                    .DeviceZoneXY = secondZone.Name
                                End If
                            Else
                                .DeviceName = Nothing
                                .DeviceZoneColor = Nothing
                                .DeviceZoneXY = Nothing
                            End If
                        End If
                    End Using
                Catch ex As Exception
                    .DeviceName = Nothing
                    .DeviceZoneColor = Nothing
                    .DeviceZoneXY = Nothing
                End Try

                .SaveSilentXml()
            End With

            UserSettings = New UserSettingData(UserSettingFile).InstanceXml
        End If

        Try
            Using oRgbClient As New OpenRgbClient(UserSettings.IpAddress, UserSettings.Port, "Getting devices information", protocolVersionNumber:=4)
                For Each device In oRgbClient.GetAllControllerData.Where(Function(x) x.Type = DeviceType.Ledstrip AndAlso x.Description = "DMX Device")
                    cmbDeviceName.Items.Add(device.Name)
                Next
                cmbDeviceName.SelectedItem = UserSettings.DeviceName
                For Each zone In oRgbClient.GetAllControllerData.Where(Function(x) x.Name = cmbDeviceName.SelectedItem).FirstOrDefault.Zones
                    cmbDeviceZone.Items.Add(zone.Name)
                    cmbDeviceZoneXY.Items.Add(zone.Name)
                Next
                cmbDeviceZone.SelectedItem = UserSettings.DeviceZoneColor
                cmbDeviceZoneXY.SelectedItem = UserSettings.DeviceZoneXY
            End Using
        Catch ex As Exception
            cmbDeviceName.Items.Add(UserSettings.DeviceName)
            cmbDeviceZone.Items.Add(UserSettings.DeviceZoneColor)
            cmbDeviceZoneXY.Items.Add(UserSettings.DeviceZoneXY)
            cmbDeviceName.SelectedItem = UserSettings.DeviceName
            cmbDeviceZone.SelectedItem = UserSettings.DeviceZoneColor
            cmbDeviceZoneXY.SelectedItem = UserSettings.DeviceZoneXY
        End Try

        txtIpAddress.Text = UserSettings.IpAddress
        txtPort.Text = UserSettings.Port

        nudRed.Value = UserSettings.RedChannel
        nudGreen.Value = UserSettings.GreenChannel
        nudBlue.Value = UserSettings.BlueChannel
        nudWhite.Value = UserSettings.WhiteChannel
        nudBright.Value = UserSettings.BrightnessChannel
        nudSmooth.Value = UserSettings.SmoothnessChannel
        nudX.Value = UserSettings.RotationXChannel
        nudY.Value = UserSettings.RotationYChannel
    End Sub

    Private Function Connect() As Boolean
        Try
            If oRgbClient IsNot Nothing Then oRgbClient.Dispose()
            If timerRGB.Enabled Then timerRGB.Stop()
            If timerXY.Enabled Then timerXY.Stop()

            oRgbClient = New OpenRgbClient(txtIpAddress.Text, CInt(txtPort.Text), "uDMX", True, 10000, 4)
            timerRGB.Start()
            timerXY.Start()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Disconnect() As Boolean
        Try
            If oRgbClient IsNot Nothing Then oRgbClient.Dispose()
            If timerRGB.Enabled Then timerRGB.Stop()
            If timerXY.Enabled Then timerXY.Stop()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If btnConnect.Tag = "start" Then
            If Connect() Then
                btnConnect.Text = "Disconnect"
                btnConnect.Tag = "stop"

                If oRgbClient.Connected Then
                    Dim device = oRgbClient.GetAllControllerData.Where(Function(x) x.Name = UserSettings.DeviceName).FirstOrDefault
                    If device IsNot Nothing Then
                        colorZone = device.Zones.Where(Function(x) x.Name = UserSettings.DeviceZoneColor).FirstOrDefault.LedCount - 1
                        xyZone = device.Zones.Where(Function(x) x.Name = UserSettings.DeviceZoneXY).FirstOrDefault.LedCount + colorZone
                    End If
                End If
            End If
        Else
            If Disconnect() Then
                btnConnect.Text = "Connect"
                btnConnect.Tag = "start"
            End If
        End If
    End Sub

    Private Sub cmbDeviceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeviceName.SelectedIndexChanged
        If oRgbClient IsNot Nothing Then
            If oRgbClient.Connected Then
                cmbDeviceZone.Items.Clear()

                Try
                    For Each zone In oRgbClient.GetAllControllerData.Where(Function(x) x.Name = cmbDeviceName.SelectedItem).FirstOrDefault.Zones
                        cmbDeviceZone.Items.Add(zone.Name)
                    Next
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newUSD As New UserSettingData
        With newUSD
            .FileName = UserSettingFile
            .IpAddress = txtIpAddress.Text
            .Port = txtPort.Text
            .RedChannel = nudRed.Value
            .GreenChannel = nudGreen.Value
            .BlueChannel = nudBlue.Value
            .WhiteChannel = nudWhite.Value
            .SmoothnessChannel = nudSmooth.Value
            .BrightnessChannel = nudBright.Value
            .RotationXChannel = nudX.Value
            .RotationYChannel = nudY.Value
            .DeviceName = cmbDeviceName.SelectedItem
            .DeviceZoneColor = cmbDeviceZone.SelectedItem
            .DeviceZoneXY = cmbDeviceZoneXY.SelectedItem
            .SaveXml()
        End With

        UserSettings = New UserSettingData(UserSettingFile).InstanceXml
    End Sub

    Private Sub UpdateLEDs()
        Try
            If oRgbClient IsNot Nothing Then
                If oRgbClient.Connected Then
                    For Each device In oRgbClient.GetAllControllerData.Where(Function(x) x.Name = UserSettings.DeviceName)
                        For Each zone In device.Zones.Where(Function(x) x.Name = UserSettings.DeviceZoneColor)
                            Dim rgbColor = device.Colors(zone.Index).ToColor
                            If lastColor <> rgbColor Then
                                Using dmx As UDMX = New UDMX()
                                    dmx.SetSingleChannel(UserSettings.RedChannel - 1, rgbColor.R)
                                    dmx.SetSingleChannel(UserSettings.GreenChannel - 1, rgbColor.G)
                                    dmx.SetSingleChannel(UserSettings.BlueChannel - 1, rgbColor.B)
                                    dmx.SetSingleChannel(UserSettings.BrightnessChannel - 1, device.ActiveMode.Brightness)
                                End Using
                                lastColor = rgbColor
                            End If
                        Next
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UpdateXY()
        Try
            If oRgbClient IsNot Nothing Then
                If oRgbClient.Connected Then
                    For Each device In oRgbClient.GetAllControllerData.Where(Function(x) x.Name = UserSettings.DeviceName)
                        For Each zone In device.Zones.Where(Function(x) x.Name = UserSettings.DeviceZoneXY)
                            Dim rgbColor = device.Colors(zone.Index).ToColor
                            If lastXY <> rgbColor Then
                                Using dmx As UDMX = New UDMX()
                                    dmx.SetSingleChannel(UserSettings.RotationXChannel - 1, rgbColor.R)
                                    dmx.SetSingleChannel(UserSettings.RotationYChannel - 1, rgbColor.G)
                                    'dmx.SetSingleChannel(UserSettings.SmoothnessChannel - 1, device.ActiveMode.Brightness)
                                End Using
                                lastXY = rgbColor
                            End If
                        Next
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If oRgbClient IsNot Nothing Then oRgbClient.Dispose()
    End Sub

    Private Sub timerRGB_Tick(sender As Object, e As EventArgs) Handles timerRGB.Tick
        UpdateLEDs()
    End Sub

    Private Sub timerXY_Tick(sender As Object, e As EventArgs) Handles timerXY.Tick
        UpdateXY()
    End Sub

    Private Sub TrackbarScroll(sender As Object, e As EventArgs) Handles tbCh1.Scroll, tbCh2.Scroll, tbCh3.Scroll,
        tbCh4.Scroll, tbCh5.Scroll, tbCh6.Scroll, tbCh7.Scroll, tbCh8.Scroll, tbCh9.Scroll, tbCh10.Scroll

        Dim scr As TrackBar = sender
        Using dmx As UDMX = New UDMX()
            dmx.SetSingleChannel(scr.TabIndex, CByte(scr.Value))
        End Using
    End Sub

End Class
