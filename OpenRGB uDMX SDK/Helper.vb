Imports System.Runtime.CompilerServices
Imports OColor = OpenRGB.NET.Color

Module Helper

    Public UserSettingFile As String = $"{My.Application.Info.DirectoryPath}\UserSettings.xml"
    Public UserSettings As UserSettingData = New UserSettingData(UserSettingFile).InstanceXml

    <Extension>
    Public Function ToColor(modelcolor As OColor) As Color
        Return Color.FromArgb(modelcolor.R, modelcolor.G, modelcolor.B)
    End Function

    <Extension>
    Public Function GetDMXAcceptableValues(input As Integer) As Integer
        Return input / 32768 * 255
    End Function

End Module
