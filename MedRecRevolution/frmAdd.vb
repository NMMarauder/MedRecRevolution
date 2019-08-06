Public Class frmAdd
    Public Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ii As Integer
        Dim jj As Integer
        Dim strHr As String
        Dim strMin As String

        'Load list box with times
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

        'Clear the dt pickers so they don't default to today.  (Should be a better way to do this)
        dtScheduled.Format = DateTimePickerFormat.Custom
        dtScheduled.CustomFormat = " "
        dtReminder.Format = DateTimePickerFormat.Custom
        dtReminder.CustomFormat = " "

        cboGroup.Items.Add("Not Participating")
        cboGroup.Items.Add("Receiving Texts")
        cboGroup.SelectedIndex = 1

        For i = 0 To FrmPassword.cboClinics.Items.Count - 1
            cboClinic.Items.Add(FrmPassword.cboClinics.Items(i))
        Next
        cboClinic.SelectedIndex = 0

        For i = 0 To FrmPassword.cboLanguageName.Items.Count - 1
            cboLanguage.Items.Add(FrmPassword.cboLanguageName.Items(i))
        Next
        cboLanguage.SelectedIndex = 0

        cboShift.Items.Add("MWF - 1")
        cboShift.Items.Add("MWF - 2")
        cboShift.Items.Add("MWF - 3")
        cboShift.Items.Add("TTS - 1")
        cboShift.Items.Add("TTS - 2")
        cboShift.Items.Add("TTS - 3")


        'frmMain.Hide()


    End Sub

    Private Sub dtReminder_valueChanged(sender As Object, e As EventArgs) Handles dtReminder.ValueChanged
        Me.dtReminder.Format = DateTimePickerFormat.Custom
        Me.dtReminder.CustomFormat = "dd MMM yyyy"
    End Sub

    Private Sub dtScheduled_valueChanged(sender As Object, e As EventArgs) Handles dtScheduled.ValueChanged
        Me.dtScheduled.Format = DateTimePickerFormat.Custom
        Me.dtScheduled.CustomFormat = "dd MMM yyyy"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearAddForm()
        frmMain.Show()
        frmMain.lvwReminder.SelectedItems.Clear()
        Me.Close()
    End Sub

    Private Function ClearAddForm() As Boolean

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
        txtMRN.ResetText()
        cboShift.Text = ""
        cboShift.SelectedIndex = -1
        txtNote.ResetText()
        Return True

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' This should ......
        ' A.) Get user input from the form
        ' B.) Validate user input 
        ' C.) Push validated input to Appointments table in the DB
        ' D.) Reload the appointments data structure & list view

        Try
            Dim DupeFound As Integer = 0
            Dim msg As String = ""

            'A.) Get user input
            '1 & 2 First and Last Names cannot be blank - format so first letter is capital, trim spaces
            Dim fname As String = CStr(txtFirst.Text)
            Dim lname As String = CStr(txtLast.Text)
            If fname = "" Then
                msg = msg & "The first name is blank" & Environment.NewLine
            Else
                FormatName(fname)
                txtFirst.Text = fname
            End If
            If lname = "" Then
                msg = msg & "The last name is blank" & Environment.NewLine
            Else
                FormatName(lname)
                txtLast.Text = lname
            End If

            '3 Clinic
            Dim Clinic As String = cboClinic.Text

            '4 Shift
            Dim Shift As String = cboShift.Text

            '4 Group
            Dim group As Integer = cboGroup.SelectedIndex

            '5 Language
            Dim language As String = cboLanguage.Text

            '6 mobile
            'Check validity and then format
            Dim mnum As String = CStr(txtMobile.Text)
            If mnum <> "" Then
                ' Check to see if the number entered could be a valid US number
                If ValidatePhone(mnum) = False Then
                    msg = msg & "The mobile number's format is invalid" & Environment.NewLine
                Else
                    FormatPhone(mnum)
                    txtMobile.Text = mnum
                End If
            End If

            '7 Scheduled Day
            Dim sday As String = ""
            If dtScheduled.Text <> " " Then sday = dtScheduled.Value.ToString("MM/dd/yyyy")
            'Scheduled day cannot be in the past
            Dim CurrDate As String = System.DateTime.Now.ToString("MM/dd/yyyy")
            Dim Sched_dt As Date
            If Not String.IsNullOrEmpty(sday) Then
                Sched_dt = CDate(sday)
                If Sched_dt < CurrDate Then
                    msg = msg & "You can't schedule a date in the past" & Environment.NewLine
                End If
            End If

            '8 Reminder day can be blank - in the case where the user is just entering the names and numbers
            ' Dim rdate As String = CStr(dtReminder.Value)
            Dim rday As String = ""
            If dtReminder.Text <> " " Then rday = dtReminder.Value.ToString("MM/dd/yyyy")

            '9 Reminder time must be in 24 hour format, if it exists
            Dim rtime As String = cboRTime.Text
            Dim strHHmm As String = "(((([0-1][0-9])|2[0-3]):?[0-5][0-9])|24:?00)"
            Dim reHHmm As New Text.RegularExpressions.Regex(strHHmm)
            Dim validTime As Boolean = False
            If Not String.IsNullOrEmpty(rtime) Then
                validTime = reHHmm.IsMatch(rtime) 'Check Validity if not empty
            Else
                validTime = True  'An empty time is valid -in the case where the user is just entering the names and numbers
            End If
            If Not validTime Then msg = msg & "The reminder time is not in 24hr format" & Environment.NewLine

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
            If group = 0 And (rday <> "" Or rtime <> "") Then
                Dim answer As Integer = MsgBox("Patient is in Group 0 (the group not getting text reminders) is it okay to blank out the reminder date and time?", vbYesNo)
                If answer = vbYes Then
                    rday = ""
                    rtime = ""
                Else
                    msg = msg & "Change the user group to something other than NOT PARTICIPATING" & Environment.NewLine
                End If
            End If

            Dim MRN As String = txtMRN.Text
            If Trim(MRN) = "" Then
                Dim answer As Integer = MsgBox("The MRN is blank.  Would you like to leave it blank for now?", vbYesNo)
                If answer = vbNo Then
                    msg = msg & "You must enter a MRN before proceeding" & Environment.NewLine
                End If
            End If

            Dim note As String = ""
            note = txtNote.Text

            'Check for duplicate in the appointment list
            If msg = "" Then
                IsDuplicate(mnum, fname, lname, group, DupeFound, frmMain.lvwReminder)
                If DupeFound = 0 Then
                    'C & D - Push data to database and reload the list
                    Insert_into_ApptTable(fname, lname, group, mnum, language, sday, rday, rtime, FrmPassword.txtDBPath.Text, Clinic, MRN, Shift, note)
                    frmMain.lvwReminder.Items.Clear()
                    frmMain.LoadApptStructFromDB()
                    frmMain.LoadApptList(frmMain.lvwReminder)
                    ClearAddForm()
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
            WriteToLog("btnAdd_Click on frmAdd - Exception Follows: " & ex.Message)
        End Try

    End Sub
End Class