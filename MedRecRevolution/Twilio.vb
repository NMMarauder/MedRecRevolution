Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types


Module Twilio


    ' Download the Twilio .NET library from twilio.com/docs/libraries/csharp
    Sub Twilio_Text(sms_number As String, sms_msg As String)

        Dim newitem As New ListViewItem()
        Dim dupeFound As Boolean = False
        Dim AlrtNum As Integer = 0
        'MsgBox("Text Sent" & sms_number)

        Try
            ' Make sure no one gets more than one message a day - This listbox gets cleared at midnight
            If FrmPassword.lvwSentToday.Items.Count >= 1 Then
                'Something has been sent today
                For Each item As ListViewItem In FrmPassword.lvwSentToday.Items
                    'is it this number that has already been sent a text?
                    If item.Text = sms_number Then
                        dupeFound = True
                    End If
                Next
            End If
            If Not dupeFound Then
                ' The number is new. Add it and send the text
                newitem.Text = sms_number                   'mobile
                FrmPassword.lvwSentToday.Items.Add(newitem)
            Else
                'Number is NOT new. Send an alert.  With too many alerts just bail
                If FrmPassword.txtAlertCount.Text <> "" Then AlrtNum = CInt(FrmPassword.txtAlertCount.Text)
                AlrtNum = AlrtNum + 1
                FrmPassword.txtAlertCount.Text = AlrtNum
                If AlrtNum = 5 Then
                    WriteToLog("Number of allowable Alerts exceeded.  Sms is stopped. ")
                    sms_msg = "Number of allowable Alerts exceeded.  Sms is stopped. "
                    sms_number = "(505) 288-9262"
                Else
                    WriteToLog("The number " & sms_number & " has already been texted today.")
                    sms_msg = "The number " & sms_number & " has already been texted today."
                    sms_number = "(505) 288-9262"
                End If
                If AlrtNum > 5 Then Exit Sub
            End If


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
            WriteToLog("Text Sent to: " & sms_number)

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            WriteToLog("Text Twilio - Exception Follows: " & ex.Message)

        End Try

    End Sub

End Module
