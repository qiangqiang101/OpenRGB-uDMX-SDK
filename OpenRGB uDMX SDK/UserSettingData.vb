Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

Public Structure UserSettingData

    Public ReadOnly Property Instance As UserSettingData
        Get
            Return ReadFromBinFile()
        End Get
    End Property

    Public ReadOnly Property InstanceXml As UserSettingData
        Get
            Return ReadFromFile()
        End Get
    End Property

    <XmlIgnore>
    Public Property FileName() As String

    Public IpAddress As String
    Public Port As Integer

    Public RedChannel As Integer
    Public GreenChannel As Integer
    Public BlueChannel As Integer
    Public WhiteChannel As Integer
    Public SmoothnessChannel As Integer
    Public BrightnessChannel As Integer
    Public RotationXChannel As Integer
    Public RotationYChannel As Integer

    Public DeviceName As String
    Public DeviceZoneColor As String
    Public DeviceZoneXY As String

    Public Sub New(filename As String)
        Me.FileName = filename
    End Sub

    Public Sub Save()
        Using fs As FileStream = File.Create(FileName)
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(fs, Me)
        End Using

        MsgBox($"Settings successfully saved.", MsgBoxStyle.Information, "Build")
    End Sub

    Public Sub SaveXml()
        Dim ser = New XmlSerializer(GetType(UserSettingData))
        Dim writer As TextWriter = New StreamWriter(FileName)
        ser.Serialize(writer, Me)
        writer.Close()

        MsgBox($"Settings successfully saved.", MsgBoxStyle.Information, "Save")
    End Sub

    Public Sub SaveSilent()
        Using fs As FileStream = File.Create(FileName)
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(fs, Me)
        End Using
    End Sub

    Public Sub SaveSilentXml()
        Dim ser = New XmlSerializer(GetType(UserSettingData))
        Dim writer As TextWriter = New StreamWriter(FileName)
        ser.Serialize(writer, Me)
        writer.Close()
    End Sub

    Public Function ReadFromFile() As UserSettingData
        If Not File.Exists(FileName) Then
            Return New UserSettingData(FileName)
        End If

        Try
            Dim ser = New XmlSerializer(GetType(UserSettingData))
            Dim reader As TextReader = New StreamReader(FileName)
            Dim instance = CType(ser.Deserialize(reader), UserSettingData)
            reader.Close()
            Return instance
        Catch ex As Exception
            Return New UserSettingData(FileName)
        End Try
    End Function

    Public Function ReadFromBinFile() As UserSettingData
        If Not File.Exists(FileName) Then
            Return New UserSettingData(FileName)
        End If

        Try
            Using fs As FileStream = File.OpenRead(FileName)
                Dim formatter As New BinaryFormatter
                Dim instance = CType(formatter.Deserialize(fs), UserSettingData)
                Return instance
            End Using
        Catch ex As Exception
            Return New UserSettingData(FileName)
        End Try
    End Function

End Structure
