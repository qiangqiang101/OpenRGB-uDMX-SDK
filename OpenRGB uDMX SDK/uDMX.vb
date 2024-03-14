Imports LibUsbDotNet
Imports LibUsbDotNet.Info
Imports LibUsbDotNet.Main

Public Class UDMX
    Implements IDisposable

    Private Const MANUFACTURER As String = "www.anyma.ch"
    Private Const PRODUCT As String = "uDMX"
    Private Const vID As Integer = &H16C0
    Private Const pID As Integer = &H5DC

    Private _device As UsbDevice

    Enum Command
        SetSingleChannel = 1
        SetChannelRange = 2
        StartBootloader = &H32
    End Enum

    Public Sub New()
        Dim finder As UsbDeviceFinder = New UsbDeviceFinder(vID, pID)
        _device = UsbDevice.OpenUsbDevice(finder)

        If _device IsNot Nothing Then
            If Not _device.Info.ManufacturerString = MANUFACTURER AndAlso _device.Info.ProductString = PRODUCT Then _device = Nothing
        End If
    End Sub

    Public ReadOnly Property IsOpen() As Boolean
        Get
            Return _device IsNot Nothing AndAlso _device.IsOpen
        End Get
    End Property

    Public Function SetSingleChannel(channel As Short, value As Byte) As Boolean
        Return SendCommand(Command.SetSingleChannel, value, channel, Nothing)
    End Function

    Public Function SetChannelRange(channel As Short, values As Byte()) As Boolean
        Return SendCommand(Command.SetChannelRange, CShort(values.Length), channel, values)
    End Function

    Public Function StartBootloader() As Boolean
        Return SendCommand(Command.StartBootloader, 0, 0, Nothing)
    End Function

    Private Function SendCommand(command As Command, cvalue As Short, cindex As Short, buffer As Byte()) As Boolean
        Dim result As Boolean = False
        Dim transfered As Integer

        If _device IsNot Nothing Then
            Dim packet As UsbSetupPacket = New UsbSetupPacket
            With packet
                .RequestType = CByte(UsbRequestType.TypeVendor) Or CByte(UsbRequestRecipient.RecipDevice) Or CByte(UsbEndpointDirection.EndpointOut)
                .Request = CByte(command)
                .Value = cvalue
                .Index = cindex
                .Length = cvalue
            End With

            If buffer Is Nothing Then buffer = New Byte(-1) {}
            If _device.ControlTransfer(packet, buffer, buffer.Length, transfered) Then result = True
        End If

        Return result
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        If _device IsNot Nothing Then _device.Close()

        UsbDevice.Exit()
    End Sub
End Class
