Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types
Module Twilio

    ' Download the Twilio .NET library from twilio.com/docs/libraries/csharp
    Sub Twilio_Text(sms_number As String, sms_msg As String)

        'MsgBox("Text Sent" & sms_number)
        Try
            ' Find your Account Sid and Auth Token at twilio.com/console
            Dim accountSid As String = Trim(FrmPassword.txtSID.Text)
            Dim authToken As String = Trim(FrmPassword.txtToken.Text)
            Dim mysms As String = Trim(FrmPassword.txtSMS.Text)

            TwilioClient.Init(accountSid, authToken)

            Dim toNumber = New PhoneNumber(sms_number)
            Dim message = MessageResource.Create(
                    toNumber, from:=New PhoneNumber(mysms),
                    body:=sms_msg)

            Console.WriteLine(message.Sid)
            'WriteToLog("Text Sent to: " & sms_number)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'WriteToLog("Text Twilio - Exception Follows:")
            'WriteToLog(CStr(ex.Message))

        End Try

    End Sub

End Module
