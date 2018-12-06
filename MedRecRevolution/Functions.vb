Module Functions

    Public Sub IsDuplicate(ByVal mnum As String, ByVal fname As String, ByVal lname As String, ByVal group As Integer, ByRef DupFound As Integer, ByRef lvw As ListView)


        DupFound = 0
        If lvw.Items.Count > 1 Then
            If group <> 0 Then
                'Text reminders cannot have a duplicate phone number in the list
                For Each item As ListViewItem In lvw.Items
                    If item.SubItems.Count > 1 Then
                        If item.SubItems(4).Text = mnum Then
                            DupFound = 1
                        End If
                    End If
                Next
            Else
                'Participant is not in the study - search for duplicate name
                For Each item As ListViewItem In lvw.Items
                    If item.SubItems.Count > 1 Then
                        If item.SubItems(1).Text = fname And item.SubItems(2).Text = lname Then
                            DupFound = 2
                        End If
                    End If

                Next
            End If
        End If

    End Sub
    Public Sub FormatName(ByRef Name As String)

        If Name.Length > 1 Then
            Name = Name.Substring(0, 1).ToUpper + Name.Substring(1)
            Name.Trim()
        End If

    End Sub

    Public Sub FormatPhone(ByRef mnum As String)

        'Remove anything not a number to prep it for proper formatting
        mnum = mnum.Replace("-", "")
        mnum = mnum.Replace(")", "")
        mnum = mnum.Replace("(", "")
        mnum = mnum.Replace(" ", "")

        ' Format number for display
        Dim lnum As Long = CLng(mnum)
        mnum = String.Format("{0:(###) ###-####}", Long.Parse(lnum))

    End Sub

    Public Function ValidatePhone(ByVal strPhoneNum As String) As Boolean

        'Create Reg Exp Pattern - Only 10 digit numbers acceptable
        Dim strPhonePattern As String
        strPhonePattern = "\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"  '  "^[1-9]\d{2}-[1-9]\d{2}-\d{4}$"
        Dim rePhone As New Text.RegularExpressions.Regex(strPhonePattern)

        If Not String.IsNullOrEmpty(strPhoneNum) Then
            ValidatePhone = rePhone.IsMatch(strPhoneNum) 'Check Validity

        Else
            ValidatePhone = False 'Not Valid / Empty
        End If

        strPhoneNum = strPhoneNum.Replace("-", "")
        strPhoneNum = strPhoneNum.Replace(")", "")
        strPhoneNum = strPhoneNum.Replace("(", "")
        strPhoneNum = strPhoneNum.Replace(" ", "")
        If strPhoneNum.Length <> 10 Then ValidatePhone = False
        Return ValidatePhone 'Return True / False

    End Function


End Module
