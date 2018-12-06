Public Class frmEditAppt


    Private Sub dtReminder_ValueChanged(sender As Object, e As EventArgs) Handles dtReminder.ValueChanged
        Me.dtReminder.Format = DateTimePickerFormat.Custom
        Me.dtReminder.CustomFormat = "dd MMM yyyy"
    End Sub

    Private Sub dtScheduled_ValueChanged(sender As Object, e As EventArgs) Handles dtScheduled.ValueChanged
        Me.dtScheduled.Format = DateTimePickerFormat.Custom
        Me.dtScheduled.CustomFormat = "dd MMM yyyy"
    End Sub

    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim ii As Integer
            Dim jj As Integer
            Dim strHr As String
            Dim strMin As String
            Dim str As String

            'Load form
            txtID.Text = frmMain.lvwReminder.SelectedItems(0).SubItems(0).Text
            txtFirst.Text = frmMain.lvwReminder.SelectedItems(0).SubItems(1).Text
            txtLast.Text = frmMain.lvwReminder.SelectedItems(0).SubItems(2).Text

            'Clinic
            For i = 0 To FrmPassword.cboClinics.Items.Count - 1
                cboClinic.Items.Add(FrmPassword.cboClinics.Items(i))
            Next
            str = frmMain.lvwReminder.SelectedItems(0).SubItems(3).Text
            cboClinic.SelectedIndex = cboClinic.FindString(str)

            'Group
            cboGroup.Items.Add("Not Participating")
            cboGroup.Items.Add("Receiving Texts")
            cboGroup.SelectedIndex = CInt(frmMain.lvwReminder.SelectedItems(0).SubItems(4).Text)

            'Language
            For i = 0 To FrmPassword.cboLanguageName.Items.Count - 1
                cboLanguage.Items.Add(FrmPassword.cboLanguageName.Items(i))
            Next
            str = frmMain.lvwReminder.SelectedItems(0).SubItems(5).Text
            cboLanguage.SelectedIndex = cboLanguage.FindString(str)

            'mobile
            txtMobile.Text = frmMain.lvwReminder.SelectedItems(0).SubItems(6).Text

            'scheduled
            dtScheduled.CustomFormat = "dd MMM yyyy"
            dtScheduled.Format = DateTimePickerFormat.Custom
            If frmMain.lvwReminder.SelectedItems(0).SubItems(7).Text <> "" Then
                dtScheduled.Value = frmMain.lvwReminder.SelectedItems(0).SubItems(7).Text
            Else
                dtScheduled.CustomFormat = " "
            End If

            'Reminder Date
            dtReminder.CustomFormat = "dd MMM yyyy"
            dtReminder.Format = DateTimePickerFormat.Custom
            If frmMain.lvwReminder.SelectedItems(0).SubItems(8).Text <> "" Then
                dtReminder.Value = frmMain.lvwReminder.SelectedItems(0).SubItems(8).Text
            Else
                dtReminder.CustomFormat = " "
                dtReminder.Format = DateTimePickerFormat.Custom
            End If

            'Reminder Time
            For ii = 15 To 23
                For jj = 0 To 45 Step 15
                    strHr = ii.ToString("00")
                    strMin = jj.ToString("00")
                    cboRTime.Items.Add(strHr & ":" & strMin)
                Next jj
            Next ii
            For ii = 0 To 14
                For jj = 0 To 45 Step 15
                    strHr = ii.ToString("00")
                    strMin = jj.ToString("00")
                    cboRTime.Items.Add(strHr & ":" & strMin)
                Next jj
            Next ii
            If frmMain.lvwReminder.SelectedItems(0).SubItems(9).Text <> "" Then
                cboRTime.Text = frmMain.lvwReminder.SelectedItems(0).SubItems(9).Text
            Else
                cboRTime.Text = ""
                cboRTime.SelectedItem = Nothing
            End If

            txtLastText.Text = frmMain.lvwReminder.SelectedItems(0).SubItems(10).Text
            txtNumTexts.Text = frmMain.lvwReminder.SelectedItems(0).SubItems(11).Text

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            '************* Get user data from the form **************************

            Dim msg As String = "" 'Used to capture problems with user input

            '0. ID
            Dim ID As Integer = CInt(txtID.Text)

            '1 & 2  First and Last name
            'If they change the name or mobile number we must check for duplicates
            Dim checkName As Boolean = False
            Dim fname As String = CStr(txtFirst.Text)
            Dim lname As String = CStr(txtLast.Text)
            If fname <> frmMain.lvwReminder.SelectedItems(0).SubItems(1).Text Or lname <> frmMain.lvwReminder.SelectedItems(0).SubItems(2).Text Then
                checkName = True 'This is to check for duplicate names
            End If

            '3. Clinic
            Dim Clinic As String = cboClinic.Text

            '4. Group
            Dim group As String = CInt(cboGroup.SelectedIndex)

            '5. Language
            Dim language As String = cboLanguage.Text

            '6. Mobile
            Dim checkPhone As Boolean = False
            Dim mnum As String = CStr(txtMobile.Text)
            If mnum <> frmMain.lvwReminder.SelectedItems(0).SubItems(6).Text Then 'Only check if changed
                checkPhone = True 'This is to check for duplicate phone numbers 
                If mnum <> "" Then
                    ' Check to see if the number entered could be a valid US number
                    If ValidatePhone(mnum) = False Then
                        msg = msg & "The mobile number's format is invalid" & Environment.NewLine
                    Else
                        FormatPhone(mnum)
                        txtMobile.Text = mnum
                    End If
                End If
            End If

            '7. Scheduled
            Dim sday As String = ""
            If dtScheduled.Text <> " " Then
                sday = dtScheduled.Value.ToString("MM/dd/yyyy")
            End If
            'Scheduled day cannot be in the past
            Dim CurrDate As String = System.DateTime.Now.ToString("MM/dd/yyyy")
            Dim Sched_dt As Date
            If Not String.IsNullOrEmpty(sday) Then
                Sched_dt = CDate(sday)
                If Sched_dt < CurrDate Then
                    msg = msg & "You can't schedule a date in the past" & Environment.NewLine
                End If
            End If

            '8. Reminder day
            Dim rday As String = ""
            If dtReminder.Text <> " " Then
                rday = dtReminder.Value.ToString("MM/dd/yyyy")
            End If

            '9. Reminder Time
            Dim rtime As String = CStr(cboRTime.Text)
            Dim strHHmm As String = "(((([0-1][0-9])|2[0-3]):?[0-5][0-9])|24:?00)"
            Dim reHHmm As New Text.RegularExpressions.Regex(strHHmm)
            Dim validTime As Boolean = False
            If Not String.IsNullOrEmpty(rtime) Then
                validTime = reHHmm.IsMatch(rtime) 'Check Validity if not empty
            Else
                validTime = True  'An empty time is valid -in the case where the user is just entering the names and numbers
            End If
            If Not validTime Then msg = msg & "The reminder time is not in 24hr format" & Environment.NewLine

            '10. Last text
            Dim lasttxt As String = CStr(txtLastText.Text)

            '11. Number of texts
            Dim numtxts As Integer = 0
            If txtNumTexts.Text <> "" Then numtxts = CInt(txtNumTexts.Text)

            'B.) Additional validations of data
            'Reminder Time must be Goldilocks (not too early or late) -  Must be after 16:00 on the day before the scheduled reconcile or before 16:00 on the day of scheduled reconcile
            If sday <> "" And rday <> "" Then
                Dim dt1 As DateTime = CDate(sday & " " & "6:00")
                Dim dt2 As DateTime = CDate(rday & " " & rtime)
                Dim hrs As Double '= (dt1 - dt2).Hours
                hrs = dt1.Subtract(dt2).TotalHours

                'Reminder can't be 24 hours before the start of 1st shift on day of reconcile
                If hrs > 24 Then msg = msg & "The reminder is more than 24 hours in advance" & Environment.NewLine
                'Reminder must be atleast one hour before start of 3rd shift on day of reconcile
                If hrs < -9 Then msg = msg & "The reminder is too late. Select an earlier time for the reminder" & Environment.NewLine

                'Reminder cannot be set before today
                Dim CurrTime As Date = System.DateTime.Now
                If dt2 < CurrTime Then msg = msg & "Not possible to schedule a reminder in the past " & Environment.NewLine
            End If

            'Are we Giving them a reminder day or time when they are in the group not recieveing texts
            'If group = 0 And (rday <> "" Or rtime <> "") Then msg = msg & "The patient has a reminder day or time but they are not in the group receiving reminders " & Environment.NewLine
            'Group = 0 No need for reminder day and time
            If group = 0 And (rday <> "" Or rtime <> "") Then
                Dim answer As Integer = MsgBox("Patient is in Group 0 (the group not getting text reminders) is it okay to blank out the reminder date and time?", vbYesNo)
                If answer = vbYes Then
                    rday = ""
                    rtime = ""
                Else
                    msg = msg & "Change the user group to something other than NOT PARTICIPATING" & Environment.NewLine
                End If
            End If

            If msg = "" Then
                Dim DupeFound As Integer = 0
                Dim alertUser As Boolean = False
                If checkName Or checkPhone Then IsDuplicate(mnum, fname, lname, group, DupeFound, frmMain.lvwReminder)
                If DupeFound > 0 Then alertUser = True
                If Not alertUser Then
                    UpdateAppt(ID, fname, lname, group, mnum, language, sday, rday, rtime, lasttxt, numtxts, clinic)
                    frmMain.lvwReminder.Items.Clear()
                    frmMain.LoadApptStructFromDB()
                    frmMain.LoadApptList(frmMain.lvwReminder)
                    ClearEditForm()
                    frmMain.Show()
                    frmMain.lvwReminder.SelectedItems.Clear()
                    Me.Close()
                Else
                    MsgBox("There is already a reminder for this mobile number or participant name")
                End If
            Else
                MsgBox(msg)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearEditForm()
        frmMain.lvwReminder.SelectedItems.Clear()
        Me.Close()
    End Sub



    Private Function ClearEditForm() As Boolean

        txtFirst.ResetText()
        txtLast.ResetText()
        txtMobile.ResetText()
        cboRTime.Text = ""
        cboRTime.SelectedItem = ""
        dtScheduled.CustomFormat = " "
        dtScheduled.Format = DateTimePickerFormat.Custom
        dtReminder.CustomFormat = " "
        dtReminder.Format = DateTimePickerFormat.Custom
        cboGroup.SelectedIndex = -1
        cboGroup.Text = ""
        cboGroup.SelectedItem = ""
        cboLanguage.SelectedIndex = -1
        cboLanguage.Text = ""
        cboLanguage.SelectedItem = ""
        Return True

    End Function

    'Private Sub dtReminder1_ValueChanged_1(sender As Object, e As EventArgs) Handles dtReminder1.ValueChanged
    '    Me.dtReminder1.Format = DateTimePickerFormat.Custom
    '    Me.dtReminder1.CustomFormat = "dd MMM yyyy"
    'End Sub

    'Private Sub dtReminder1_GotFocus(sender As Object, e As EventArgs) Handles dtReminder1.GotFocus
    '    Me.dtReminder1.Format = DateTimePickerFormat.Custom
    '    Me.dtReminder1.CustomFormat = "dd MMM yyyy"
    'End Sub

    'Private Sub dtScheduled_ValueChanged(sender As Object, e As EventArgs) Handles dtScheduled.ValueChanged

    'End Sub

    'Private Sub dtScheduled_GotFocus(sender As Object, e As EventArgs) Handles dtScheduled.GotFocus
    '    Me.dtScheduled.Format = DateTimePickerFormat.Custom
    '    Me.dtScheduled.CustomFormat = "dd MMM yyyy"
    'End Sub

    'Private Sub frmEditAppt_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    ClearEditForm()
    'End Sub

    'Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    '    dtScheduled.Format = DateTimePickerFormat.Custom
    '    dtScheduled.CustomFormat = " "
    '    dtReminder1.Format = DateTimePickerFormat.Custom
    '    dtReminder1.CustomFormat = " "
    '    cboRTime1.SelectedText = ""
    '    cboRTime1.SelectedValue = ""
    '    cboRTime1.Text = ""
    '    chkSpanish.Checked = False
    'End Sub
End Class