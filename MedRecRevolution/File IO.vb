Imports System.Xml

Module File_IO




    'Public Function GetInitXML(strSetting As String) As String
    '    GetInitXML = ""
    '    Try
    '        Dim AppName As String = System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath)
    '        Dim ApplicationDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
    '        Dim XMLfilePath = System.IO.Path.Combine(ApplicationDir, AppName & "Settings.xml")
    '        Dim xr As XmlReader = XmlReader.Create(XMLfilePath)

    '        Do While xr.Read()
    '            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = strSetting Then
    '                GetInitXML = xr.ReadElementString()
    '                Exit Do
    '            End If
    '        Loop

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try

    '    Return GetInitXML

    'End Function


End Module
