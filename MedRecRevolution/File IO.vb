Imports System.Xml
Imports System.IO
Imports System.Net
Imports System.Text

Module File_IO

    Public Sub WriteToLog(LogMsg As String)
        Dim CurrTime As String = System.DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")
        Try
            Dim AppName As String = System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath)
            Dim dir As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim FileLocation As String = dir & "\" & AppName & "_Log.txt"

            If Not File.Exists(FileLocation) Then
                Using sw As StreamWriter = File.CreateText(FileLocation)

                    sw.WriteLine("Log Start: " & CurrTime)
                    sw.Close()
                End Using
            Else
                Using sw As StreamWriter = File.AppendText(FileLocation)
                    sw.WriteLine(CurrTime & " - " & LogMsg)
                    sw.Close()
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Doh.  WriteToLog exception: " & ex.Message)
        End Try

    End Sub

    Public Sub PostTo2(postData As String)

        Try
            Dim stopWatch As New Stopwatch()
            stopWatch.Start()

            Dim url As String = Trim(FrmPassword.txtURL.Text)
            Dim request As WebRequest = WebRequest.Create(url)


            request.Method = "POST"

            ' Create POST data and convert it to a byte array.  
            'Dim postData As String = "?authtoken=" & "xxxxxxxxxx" & "?scope=creatorapi" & "?TicketID=" & sTicketID
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)

            ' Set the ContentType property of the WebRequest.  
            request.ContentType = "application/x-www-form-urlencoded"

            ' Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length

            ' Get the request stream.  
            Dim dataStream As Stream = request.GetRequestStream()

            ' Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length)

            ' Close the Stream object.  
            dataStream.Close()

            stopWatch.Stop()
            ' Get the elapsed time as a TimeSpan value.
            Dim ts As TimeSpan = stopWatch.Elapsed

            ' Format and display the TimeSpan value.
            Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
            'WriteToLog("PostTo2 - Time to complete: " & elapsedTime)

        Catch ex As Exception
            WriteToLog("PostTo2 - Exception Follows: " & ex.Message)
            'MessageBox.Show(ex.Message)
        End Try


    End Sub



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
