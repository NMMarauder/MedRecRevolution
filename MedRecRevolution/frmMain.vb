Imports System.Data.OleDb
Imports MedRecRevolution.Sort

Public Class frmMain
    Private AddForm As frmAdd
    Private EditAForm As frmEditAppt
    Private EditOut As frmEditOutcome


    'The two main data structures that hold everything in the database
    Structure Appointment
        Dim Id As Integer
        Dim LastName As String
        Dim FirstName As String
        Dim Mobile As String
        Dim Clinic As String
        Dim Language As String
        Dim Group As String
        Dim ScheduledDay As Date
        Dim ReminderDay As Date
        Dim ReminderTime As String
        Dim LastText As DateTime
        Dim NumTextsSent As Integer
    End Structure
    Dim Appointments As Appointment()
    Structure Outcome
        Dim Id As Integer
        Dim LastName As String
        Dim FirstName As String
        Dim Mobile As String
        Dim Clinic As String
        Dim Language As String
        Dim Group As String
        Dim ScheduledDay As Date
        Dim ReminderDay As Date
        Dim ReminderTime As String
        Dim LastText As DateTime
        Dim NumTextsSent As Integer
        Dim ReconcileDate As Date
        Dim Happened As Integer
        Dim PhoneProblem As Integer
        Dim NumMeds As Integer
        Dim NumUsefulPics As Integer
        Dim TotalPics As Integer
        Dim UsefulList As Integer
        Dim ClaimsAll As Integer
        Dim Comment As String
        Dim TotalList As Integer
    End Structure
    Dim Outcomes As Outcome()

    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'When the main window is closed - close the password form (The startup form)
        FrmPassword.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        '*************************************************************************************************
        '* This is the main loop used for sending out notifications and updating the lists in the editor.  
        '* Set the version to "SERVER" when compiling the version that sends the text messages to the patients.
        '*
        '*************************************************************************************************
        Dim SoftwareVersion As String
        ' SoftwareVersion = "EDITOR"
        SoftwareVersion = "SERVER"
        lblVersion.Text = SoftwareVersion & " VERSION 2.0"



        Dim CurrTime As String = System.DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")
        Dim DayName As String = DateTime.Now.DayOfWeek.ToString
        Label1.Text = DayName & " " & CurrTime

        'Update lists every 15 minutes for the editor
        If System.DateTime.Now.Minute Mod 15 = 0 And System.DateTime.Now.Second = 0 Then
            'Don't refresh if they are editing either list
            If Not (Application.OpenForms().OfType(Of frmEditAppt).Any Or Application.OpenForms().OfType(Of frmEditOutcome).Any Or Application.OpenForms().OfType(Of frmAdd).Any) Then
                lvwReminder.Items.Clear()
                LoadApptStructFromDB()
                LoadApptList(lvwReminder)
                lvwOutcome.Items.Clear()
                LoadOutcomeStructFromDB()
                LoadOutcomeList(lvwOutcome)
            End If
        End If

        '*************************************************************************************************
        '* The code from here to the end of the subroutine is used only for the SERVER version.  
        '*************************************************************************************************

        If SoftwareVersion = "SERVER" Then
            'At 1 AM move the group zero (Patients not recieving texts) to the outcomes list
            'If System.DateTime.Now.Hour = 1 And System.DateTime.Now.Minute = 1 And System.DateTime.Now.Second = 1 Then
            ' Notify_Grp_0()
            ' Notify_Grp_0_missed()
            'End If

            'Every 2 minutes check for texts to send.  
            ' *Missed* finds patients that should have been sent a text hours ago. (In the case that this application wasn't running/working at the time)
            ' Postto2 - pings an external server used for monitoring this application to make sure it is still running
            If System.DateTime.Now.Minute Mod 2 = 0 And System.DateTime.Now.Second = 0 Then
                Notify_Grp_1_missed()
                Notify_Grp_1()
                PostTo2("code_word=flash&time=" & CurrTime)
            End If
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        lvwReminder.Columns.Add("ID")
        lvwReminder.Columns.Add("First Name")
        lvwReminder.Columns.Add("Last Name")
        lvwReminder.Columns.Add("Clinic")
        lvwReminder.Columns.Add("Group")
        lvwReminder.Columns.Add("Language")
        lvwReminder.Columns.Add("Mobile Number")
        lvwReminder.Columns.Add("Sch. Reconcile")
        lvwReminder.Columns.Add("Reminder Day")
        lvwReminder.Columns.Add("Reminder Time")
        lvwReminder.Columns.Add("Last Text At")
        lvwReminder.Columns.Add("# of Texts So Far")

        'lvwReminder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)


        lvwOutcome.Columns.Add("ID")
        lvwOutcome.Columns.Add("First Name")
        lvwOutcome.Columns.Add("Last Name")
        lvwOutcome.Columns.Add("Clinic")
        lvwOutcome.Columns.Add("Group")
        lvwOutcome.Columns.Add("Language")
        lvwOutcome.Columns.Add("Mobile Number")
        lvwOutcome.Columns.Add("Sch. Reconcile")
        lvwOutcome.Columns.Add("Reminder Day")
        lvwOutcome.Columns.Add("Reminder Time")
        lvwOutcome.Columns.Add("Last Text At")
        lvwOutcome.Columns.Add("# Texts So Far")
        lvwOutcome.Columns.Add("Actual Reconcile Date")
        lvwOutcome.Columns.Add("Happened?")
        lvwOutcome.Columns.Add("Claims All")
        lvwOutcome.Columns.Add("# Meds Brought")
        lvwOutcome.Columns.Add("# Useful list")
        lvwOutcome.Columns.Add("Total list")
        lvwOutcome.Columns.Add("# Useful Pics")
        lvwOutcome.Columns.Add("Total Pics")
        lvwOutcome.Columns.Add("Phone Problem")
        lvwOutcome.Columns.Add("Comments")

        LoadApptStructFromDB()
        LoadApptList(lvwReminder)
        LoadOutcomeStructFromDB()
        LoadOutcomeList(lvwOutcome)

        'lvwOutcome.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        lvwReminder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        lvwOutcome.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub

    Public Sub LoadOutcomeStructFromDB()

        Dim stopWatch As New Stopwatch()
        stopWatch.Start()

        Try
            Dim connection As New OleDbConnection
            Dim command As New OleDbCommand
            Dim data_reader As OleDbDataReader

            Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FrmPassword.txtDBPath.Text & ";Jet OLEDB:Database Password=" & FrmPassword.txtDBPassword.Text

            connection.ConnectionString = strConnectionString
            connection.Open()

            'Determine number of rows in the outcomes table to create the  outcomes structure
            Dim dataAdapt As OleDbDataAdapter
            dataAdapt = New OleDb.OleDbDataAdapter("SELECT * FROM Outcomes WHERE (((Outcomes.[key])>0));", connection)
            Dim dt As New DataTable
            dataAdapt.Fill(dt)
            Dim TotalRows As Integer = dt.Rows.Count
            ReDim Outcomes(TotalRows)

            'Grab data for outcomes
            command = New OleDbCommand("SELECT * FROM Outcomes", connection)
            data_reader = command.ExecuteReader

            'add data to data structure
            If data_reader.HasRows Then
                Dim count As Integer = 0

                While data_reader.Read
                    If data_reader.GetValue(1).ToString <> "" Then Outcomes(count).Id = CInt(data_reader.GetValue(1))              'ID
                    If data_reader.GetValue(2).ToString <> "" Then Outcomes(count).Language = CStr(data_reader.GetValue(2))        'Language
                    If data_reader.GetValue(3).ToString <> "" Then Outcomes(count).FirstName = CStr(data_reader.GetValue(3))       'First Name
                    If data_reader.GetValue(4).ToString <> "" Then Outcomes(count).LastName = CStr(data_reader.GetValue(4))        'Last Name
                    If data_reader.GetValue(5).ToString <> "" Then Outcomes(count).Group = CStr(data_reader.GetValue(5))           'Group
                    If data_reader.GetValue(6).ToString <> "" Then Outcomes(count).Mobile = CStr(data_reader.GetValue(6))          'Mobile
                    If data_reader.GetValue(7).ToString <> "" Then Outcomes(count).ScheduledDay = CDate(data_reader.GetValue(7))   'Scheduled
                    If data_reader.GetValue(8).ToString <> "" Then Outcomes(count).ReminderDay = CDate(data_reader.GetValue(8))    'Reminder Day
                    If data_reader.GetValue(9).ToString <> "" Then Outcomes(count).ReminderTime = CStr(data_reader.GetValue(9))    'Reminder Time
                    If data_reader.GetValue(10).ToString <> "" Then Outcomes(count).LastText = CDate(data_reader.GetValue(10))      'Last Text
                    If data_reader.GetValue(11).ToString <> "" Then Outcomes(count).NumTextsSent = CInt(data_reader.GetValue(11))   'NumTextsSent
                    If data_reader.GetValue(12).ToString <> "" Then Outcomes(count).ReconcileDate = CDate(data_reader.GetValue(12)) 'Reconcile Date
                    If data_reader.GetValue(13).ToString <> "" Then Outcomes(count).Happened = CInt(data_reader.GetValue(13))       'Happened
                    If data_reader.GetValue(14).ToString <> "" Then Outcomes(count).PhoneProblem = CInt(data_reader.GetValue(14))   'Phone Problem
                    If data_reader.GetValue(15).ToString <> "" Then Outcomes(count).NumMeds = CInt(data_reader.GetValue(15))        'Num Meds
                    If data_reader.GetValue(16).ToString <> "" Then Outcomes(count).NumUsefulPics = CInt(data_reader.GetValue(16))  'Num Useful Pics
                    If data_reader.GetValue(17).ToString <> "" Then Outcomes(count).TotalPics = CInt(data_reader.GetValue(17))      'Total Pics
                    If data_reader.GetValue(18).ToString <> "" Then Outcomes(count).Comment = CStr(data_reader.GetValue(18))        'Comment
                    If data_reader.GetValue(19).ToString <> "" Then Outcomes(count).ClaimsAll = CInt(data_reader.GetValue(19))      'Claims All
                    If data_reader.GetValue(20).ToString <> "" Then Outcomes(count).UsefulList = CInt(data_reader.GetValue(20))     'Useful list
                    If data_reader.GetValue(21).ToString <> "" Then Outcomes(count).Clinic = CStr(data_reader.GetValue(21))         'Clinic
                    If data_reader.GetValue(22).ToString <> "" Then Outcomes(count).TotalList = CInt(data_reader.GetValue(22))       'Total List
                    count = count + 1
                End While
            End If
            data_reader.Close()
            connection.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            WriteToLog("LoadOutcomeStructFromDB - Exception Follows:" & ex.Message)
        End Try

        stopWatch.Stop()
        ' Get the elapsed time as a TimeSpan value.
        Dim ts As TimeSpan = stopWatch.Elapsed

        ' Format and display the TimeSpan value.
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
        ' MsgBox("LoadOutcomeStructFromDB  " + elapsedTime)


    End Sub
    Public Sub LoadOutcomeList(ByRef lvw As ListView)
        Dim stopWatch As New Stopwatch()
        stopWatch.Start()
        Dim count As Integer = 0
        Dim NoDate As DateTime = DateTime.MinValue

        Try
            'add data to listview
            If Outcomes.Count > 0 Then
                While count < Outcomes.Count - 1
                    Dim newitem As New ListViewItem()

                    newitem.Text = Outcomes(count).Id                   'ID
                    newitem.SubItems.Add(Outcomes(count).FirstName)     'First Name
                    newitem.SubItems.Add(Outcomes(count).LastName)      'Last Name
                    newitem.SubItems.Add(Outcomes(count).Clinic)        'Clinic
                    newitem.SubItems.Add(Outcomes(count).Group)         'Group
                    newitem.SubItems.Add(Outcomes(count).Language)      'Language
                    newitem.SubItems.Add(Outcomes(count).Mobile)        'Mobile
                    If Outcomes(count).ScheduledDay = NoDate Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(Outcomes(count).ScheduledDay.ToString("MM/dd/yyyy")) 'Scheduled
                    End If
                    If Outcomes(count).ReminderDay = NoDate Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(Outcomes(count).ReminderDay.ToString("MM/dd/yyyy"))  'Reminder Day
                    End If
                    If Outcomes(count).ReminderTime = "" Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(Outcomes(count).ReminderTime) 'Reminder Time
                    End If
                    newitem.SubItems.Add(Outcomes(count).LastText)     'Last Text
                    newitem.SubItems.Add(Outcomes(count).NumTextsSent) 'NumTextsSent
                    If Outcomes(count).ReconcileDate = NoDate Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(Outcomes(count).ReconcileDate) 'Reconcile Date
                    End If
                    ' newitem.SubItems.Add(Outcomes(count).Happened)      'Happened
                    Select Case Outcomes(count).Happened
                        Case 0
                            newitem.SubItems.Add("No-Text Not Sent (automated)")
                        Case 1
                            newitem.SubItems.Add("Yes")
                        Case 2
                            newitem.SubItems.Add("No-Patient Reports Text Not Recieved")
                        Case 3
                            newitem.SubItems.Add("No-Patient Absent")
                        Case 4
                            newitem.SubItems.Add("No-Patient Left Early")
                        Case 5
                            newitem.SubItems.Add("No-Patient Non-compliant")
                        Case 6
                            newitem.SubItems.Add("No-Patient Forgot - Reschedule 1 week")
                        Case 7
                            newitem.SubItems.Add("No-Staff Issue")
                        Case 8
                            newitem.SubItems.Add("No-Other Issue")
                    End Select
                    newitem.SubItems.Add(Outcomes(count).ClaimsAll)     'Claims All
                    newitem.SubItems.Add(Outcomes(count).NumMeds)       'Num Meds
                    newitem.SubItems.Add(Outcomes(count).UsefulList)    'Useful list
                    newitem.SubItems.Add(Outcomes(count).TotalList)     'Total list
                    newitem.SubItems.Add(Outcomes(count).NumUsefulPics) 'Num Useful Pics
                    newitem.SubItems.Add(Outcomes(count).TotalPics)     'Total Pics
                    newitem.SubItems.Add(Outcomes(count).PhoneProblem)  'Phone Problem
                    newitem.SubItems.Add(Outcomes(count).Comment)       'Comment

                    lvw.Items.Add(newitem)
                    count = count + 1
                End While
            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            WriteToLog("LoadOutComeListFromDB - Exception Follows: " & ex.Message)
        End Try

        'lvwOutcome.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        stopWatch.Stop()
        ' Get the elapsed time as a TimeSpan value.
        Dim ts As TimeSpan = stopWatch.Elapsed

        ' Format and display the TimeSpan value.
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
        ' MsgBox("Load ListTime " + elapsedTime)


    End Sub
    Public Sub LoadApptStructFromDB()
        Dim stopWatch As New Stopwatch()
        stopWatch.Start()

        Try

            Dim connection As New OleDbConnection
            Dim command As New OleDbCommand
            Dim data_reader As OleDbDataReader
            Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FrmPassword.txtDBPath.Text & ";Jet OLEDB:Database Password=" & FrmPassword.txtDBPassword.Text

            connection.ConnectionString = strConnectionString
            connection.Open()

            'Determine number of rows in the appts table to create the appts structure
            Dim dataAdapt As OleDbDataAdapter
            dataAdapt = New OleDb.OleDbDataAdapter("SELECT * FROM Appts WHERE (((Appts.[ID])>0));", connection)
            Dim dt As New DataTable
            dataAdapt.Fill(dt)
            Dim TotalRows As Integer = dt.Rows.Count
            ReDim Appointments(TotalRows)


            'Grab data for outcomes
            command = New OleDbCommand("SELECT * FROM Appts", connection)
            data_reader = command.ExecuteReader

            'add data to data structure
            If data_reader.HasRows Then
                Dim count As Integer = 0

                While data_reader.Read
                    If data_reader.GetValue(0).ToString <> "" Then Appointments(count).Id = CInt(data_reader.GetValue(0))                                                             'ID
                    If data_reader.GetValue(1).ToString <> "" Then Appointments(count).Language = CStr(data_reader.GetValue(1))        'Language
                    If data_reader.GetValue(2).ToString <> "" Then Appointments(count).FirstName = CStr(data_reader.GetValue(2))       'First Name
                    If data_reader.GetValue(3).ToString <> "" Then Appointments(count).LastName = CStr(data_reader.GetValue(3))        'Last Name
                    If data_reader.GetValue(4).ToString <> "" Then Appointments(count).Group = CStr(data_reader.GetValue(4))           'Group
                    If data_reader.GetValue(5).ToString <> "" Then Appointments(count).Mobile = CStr(data_reader.GetValue(5))          'Mobile
                    If data_reader.GetValue(6).ToString <> "" Then Appointments(count).ScheduledDay = CDate(data_reader.GetValue(6))   'Scheduled
                    If data_reader.GetValue(7).ToString <> "" Then Appointments(count).ReminderDay = CDate(data_reader.GetValue(7))    'Reminder Day
                    If data_reader.GetValue(8).ToString <> "" Then
                        Appointments(count).ReminderTime = CStr(data_reader.GetValue(8))   'Reminder Time
                    End If
                    If data_reader.GetValue(9).ToString <> "" Then
                        Appointments(count).LastText = CDate(data_reader.GetValue(9))      'Last Text
                    End If
                    If data_reader.GetValue(10).ToString <> "" Then Appointments(count).NumTextsSent = CInt(data_reader.GetValue(10))   'NumTextsSent
                    If data_reader.GetValue(11).ToString <> "" Then Appointments(count).Clinic = CStr(data_reader.GetValue(11))         'Clinic
                    count = count + 1
                End While
            End If
            data_reader.Close()
            connection.Close()

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            WriteToLog("LoadApptStructFromDB - Exception Follows: " & ex.Message)
        End Try

        stopWatch.Stop()
        ' Get the elapsed time as a TimeSpan value.
        Dim ts As TimeSpan = stopWatch.Elapsed

        ' Format and display the TimeSpan value.
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
        ' MsgBox("LoadApptStructFromDB  " + elapsedTime)


    End Sub
    Public Sub LoadApptList(ByRef lvw As ListView)

        Dim stopWatch As New Stopwatch()
        stopWatch.Start()
        Dim count As Integer = 0
        Dim NoDate As DateTime = DateTime.MinValue

        Try
            If Appointments.Count > 0 Then
                While count < Appointments.Count - 1
                    Dim newitem As New ListViewItem()
                    newitem.Text = Appointments(count).Id                   'ID
                    newitem.SubItems.Add(Appointments(count).FirstName)     'First Name
                    newitem.SubItems.Add(Appointments(count).LastName)      'Last Name
                    newitem.SubItems.Add(Appointments(count).Clinic)        'Clinic
                    newitem.SubItems.Add(Appointments(count).Group)         'Group
                    newitem.SubItems.Add(Appointments(count).Language)      'Language
                    newitem.SubItems.Add(Appointments(count).Mobile)        'Mobile
                    If Appointments(count).ScheduledDay = NoDate Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(Appointments(count).ScheduledDay.ToString("MM/dd/yyyy")) 'Scheduled
                    End If
                    If Appointments(count).ReminderDay = NoDate Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(Appointments(count).ReminderDay.ToString("MM/dd/yyyy"))  'Reminder Day
                    End If
                    If Appointments(count).ReminderTime = "" Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(Appointments(count).ReminderTime) 'Reminder Time
                    End If
                    If Appointments(count).LastText = NoDate Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(Appointments(count).LastText)    'Last Text
                    End If
                    newitem.SubItems.Add(Appointments(count).NumTextsSent) 'NumTextsSent
                    lvw.Items.Add(newitem)
                    count = count + 1
                End While
            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            WriteToLog("LoadApptList - Exception Follows: " & ex.Message)
        End Try

        'lvwReminder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        stopWatch.Stop()
        ' Get the elapsed time as a TimeSpan value.
        Dim ts As TimeSpan = stopWatch.Elapsed

        ' Format and display the TimeSpan value.
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
        ' MsgBox("LoadApptList  " + elapsedTime)


    End Sub

    Private Sub btnAddAppt_Click(sender As Object, e As EventArgs) Handles btnAddAppt.Click

        If AddForm Is Nothing Then
            Dim AddForm As New frmAdd
            AddForm.ShowDialog()
        End If


    End Sub

    Private Sub btnEditAppt_Click(sender As Object, e As EventArgs) Handles btnEditAppt.Click

        'Find selected item or give user message that they must select something first
        If lvwReminder.SelectedItems.Count = 0 Then
            MsgBox("You must select an entry to edit in the appointment list before clicking the edit button")
        Else
            If EditAForm Is Nothing Then
                Dim EditAForm As New frmEditAppt
                EditAForm.ShowDialog()
            End If


        End If
    End Sub

    Private Sub btnDeleteAppt_Click(sender As Object, e As EventArgs) Handles btnDeleteAppt.Click
        Dim ID As Integer
        Dim strFirst As String
        Dim strLast As String
        Dim answer As Integer
        Dim stopWatch As New Stopwatch()
        stopWatch.Start()


        If lvwReminder.SelectedItems.Count = 0 Then
            MsgBox("You must select an entry to DELETE in the reminder list before clicking the DELETE button")
        Else
            ID = CInt(lvwReminder.SelectedItems(0).SubItems(0).Text)
            strFirst = lvwReminder.SelectedItems(0).SubItems(1).Text
            strLast = lvwReminder.SelectedItems(0).SubItems(2).Text

            answer = MsgBox("Are you sure you want to delete this entry for " & ID & " : " & strFirst & " " & strLast, vbYesNo)
            If answer = 6 Then
                Try
                    DeleteReminder(ID) 'Deletes from Database
                    lvwReminder.Items.Clear()
                    LoadApptStructFromDB()
                    LoadApptList(Me.lvwReminder)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                stopWatch.Stop()
                ' Get the elapsed time as a TimeSpan value.
                Dim ts As TimeSpan = stopWatch.Elapsed

                ' Format and display the TimeSpan value.
                Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
                ' MsgBox("SQL Delete Time " + elapsedTime)


            End If
            lvwReminder.SelectedItems.Clear()
        End If
    End Sub

    Private Sub btnEditOutcome_Click(sender As Object, e As EventArgs) Handles btnEditOutcome.Click
        'Find selected item or give user message that they must select something first
        If lvwOutcome.SelectedItems.Count = 0 Then
            MsgBox("You must select an entry to edit in the outcome list before clicking the edit button")
        Else
            If EditOut Is Nothing Then
                Dim EditOut As New frmEditOutcome
                EditOut.ShowDialog()
            End If
        End If

    End Sub
    Private Sub lvwReminder_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles lvwReminder.ColumnClick
        Dim iSortOrder As SortOrder = CType(lvwReminder.Columns(e.Column).Tag, SortOrder)
        Dim lvcs As New ListViewColumnSorter
        If iSortOrder = SortOrder.Ascending Then
            lvwReminder.Columns(e.Column).Tag = SortOrder.Descending
            lvcs.SortingOrder = SortOrder.Descending
        Else
            lvwReminder.Columns(e.Column).Tag = SortOrder.Ascending
            lvcs.SortingOrder = SortOrder.Ascending
        End If
        lvcs.ColumnIndex = e.Column
        lvwReminder.ListViewItemSorter = lvcs
    End Sub

    Private Sub lvwOutcome_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvwOutcome.ColumnClick
        Dim iSortOrder As SortOrder = CType(lvwOutcome.Columns(e.Column).Tag, SortOrder)
        Dim lvcs As New ListViewColumnSorter
        If iSortOrder = SortOrder.Ascending Then
            lvwOutcome.Columns(e.Column).Tag = SortOrder.Descending
            lvcs.SortingOrder = SortOrder.Descending
        Else
            lvwOutcome.Columns(e.Column).Tag = SortOrder.Ascending
            lvcs.SortingOrder = SortOrder.Ascending
        End If
        lvcs.ColumnIndex = e.Column
        lvwOutcome.ListViewItemSorter = lvcs
    End Sub

    Public Sub Notify_Grp_1_missed()
        ' This subroutine queries the database looking for missed appointment reminders.  If the reminder is more than 6 hours late, it is marked as a missed reminder.  This 6 hour time period is hard coded in
        ' the lines below.   This should be moved to the config file at some point.

        Dim HrsLateUpperLimit = 6  'ToDo:  Move this to the config file


        'If lblDebug.Text = "debug" Then WriteToLog2("Into Notify group 1 missed", "debug_log.txt")

        Dim data_reader As OleDbDataReader
        Dim connection As New OleDbConnection

        Try
            Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FrmPassword.txtDBPath.Text & ";Jet OLEDB:Database Password=" & FrmPassword.txtDBPassword.Text
            connection.ConnectionString = strConnectionString
            connection.Open()

            'Check to see if reminders were missed since the last application start
            Dim today1 As String = System.DateTime.Now.ToString("MM/dd/yyyy")
            Dim str As String = "SELECT * FROM Appts WHERE ((rday1 <> '') AND (rday1 < '" & today1 & "'));"
            Dim command As New OleDbCommand(str, connection)

            data_reader = command.ExecuteReader

            If data_reader.HasRows Then
                While data_reader.Read
                    'results from query
                    Dim Id As Integer = data_reader.GetValue(0)
                    Dim language As String = data_reader.GetValue(1) & ""
                    Dim fname As String = data_reader.GetValue(2) & ""
                    Dim lname As String = data_reader.GetValue(3) & ""
                    Dim group As Integer = data_reader.GetValue(4)
                    Dim mnum As String = data_reader.GetValue(5) & ""
                    Dim sday As String = data_reader.GetValue(6) & ""
                    Dim rday1 As String = data_reader.GetValue(7) & ""
                    Dim rtime1 As String = data_reader.GetValue(8) & ""
                    Dim lasttxt As String = data_reader.GetValue(9) & ""
                    Dim clinic As String = data_reader.GetValue(11) & ""
                    Dim numtxts As Integer = 0
                    Dim sms_msg As String = "DCI appreciates you"
                    Dim comment As String = ""
                    Dim RemindDT As Date
                    Dim RemindIsDate As Boolean = Date.TryParse(rday1 & " " & rtime1, RemindDT)
                    Dim EventHappened As Integer = 7
                    Dim DTnow As Date = System.DateTime.Now
                    If RemindIsDate Then
                        Dim diff As TimeSpan = DTnow - RemindDT
                        If (diff.Days > 1 Or diff.Hours > HrsLateUpperLimit) Then
                            EventHappened = 0
                            comment = "At " & CStr(DTnow) & " the system determined that this reminder was missed.  "
                        End If
                    End If
                    If Not data_reader.GetValue(10) Is DBNull.Value Then
                        numtxts = data_reader.GetValue(10)
                    Else
                        numtxts = 0
                    End If
                    If EventHappened <> 0 Then numtxts = numtxts + 1
                    Dim Index As Integer = FrmPassword.cboLanguageName.FindString(language)
                    FrmPassword.cboLanguageText.SelectedIndex = Index
                    sms_msg = FrmPassword.cboLanguageText.Text

                    'update lasttext and #texts lview entry in the reminders listview
                    If EventHappened <> 0 Then 'Don't update last text and number of texts if it was a missed text
                        lasttxt = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm")
                        For Each oItem As ListViewItem In lvwReminder.Items
                            Dim count As Integer = oItem.SubItems.Count
                            If oItem.Text = data_reader.GetValue(0) Then
                                oItem.SubItems(10).Text = lasttxt
                                oItem.SubItems(11).Text = CStr(numtxts)
                            End If
                        Next
                    End If

                    'copy to outcomes list
                    Dim newitem As New ListViewItem()
                    newitem.Text = Id                   '0
                    newitem.SubItems.Add(fname)         '1
                    newitem.SubItems.Add(lname)         '2
                    newitem.SubItems.Add(clinic)        '3
                    newitem.SubItems.Add(group)         '4
                    newitem.SubItems.Add(language)      '5
                    newitem.SubItems.Add(mnum)          '6
                    newitem.SubItems.Add(sday)          '7
                    newitem.SubItems.Add(rday1)         '8
                    newitem.SubItems.Add(rtime1)        '9
                    If EventHappened = 0 Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(lasttxt)       '10
                    End If
                    newitem.SubItems.Add(CStr(numtxts)) '11
                    newitem.SubItems.Add("") ' actual rec date
                    'newitem.SubItems.Add(EventHappened) 'Happened - set to staff issue by default
                    Select Case EventHappened
                        Case 0
                            newitem.SubItems.Add("No-Text Not Sent (automated)")
                        Case 1
                            newitem.SubItems.Add("Yes")
                        Case 2
                            newitem.SubItems.Add("No-Patient Reports Text Not Recieved")
                        Case 3
                            newitem.SubItems.Add("No-Patient Absent")
                        Case 4
                            newitem.SubItems.Add("No-Patient Left Early")
                        Case 5
                            newitem.SubItems.Add("No-Patient Non-compliant")
                        Case 6
                            newitem.SubItems.Add("No-Patient Forgot - Reschedule 1 week")
                        Case 7
                            newitem.SubItems.Add("No-Staff Issue")
                        Case 8
                            newitem.SubItems.Add("No-Other Issue")
                    End Select
                    newitem.SubItems.Add("") 'claims all
                    newitem.SubItems.Add("") 'num meds brought
                    newitem.SubItems.Add("") 'num useful list
                    newitem.SubItems.Add("") 'total list
                    newitem.SubItems.Add("") 'num useful pics
                    newitem.SubItems.Add("") 'total pics
                    newitem.SubItems.Add("") 'phone prob
                    newitem.SubItems.Add(comment) 'comment
                    lvwOutcome.Items.Add(newitem)

                    'Add this to the Outcomes DB table
                    InsertInOutcomesTable(Id, language, fname, lname, group, mnum, sday, rday1, rtime1, lasttxt, numtxts, "", EventHappened, "", "", "", "", comment, "", "", clinic, "")

                    'Blank out listview columns sday rday1 rtime1
                    For Each oItem As ListViewItem In lvwReminder.Items
                        If oItem.Text = data_reader.GetValue(0) Then
                            oItem.SubItems(7).Text = "" 'Scheduled Day
                            oItem.SubItems(8).Text = "" 'Reminder Day
                            oItem.SubItems(9).Text = "" 'Reminder Time
                        End If
                    Next

                    'Send Txt reminder - unless it is so long ago that it is now "missed"
                    If EventHappened <> 0 Then
                        ' MsgBox("Text sent to " & fname & " " & lname & " at " & mnum)
                        Twilio_Text(mnum, sms_msg)
                    End If
                    'update Appts DB table - to reflect that the text went out
                    UpdateAppt(Id, fname, lname, group, mnum, language, "", "", "", lasttxt, numtxts, clinic)

                End While

            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            WriteToLog("Notify Group One Missed - Exception Follows: " & ex.Message)
        End Try

        If data_reader IsNot Nothing Then
            data_reader.Close()
            connection.Close()
        End If
        ' If lblDebug.Text = "debug" Then WriteToLog2("out of Notify group 1 missed", "debug_log.txt")

    End Sub

    Public Sub Notify_Grp_1()

        ' This subroutine queries the database looking for missed appointment reminders.  If the reminder is more than 6 hours late, it is marked as a missed reminder.  This 6 hour time period is hard coded in
        ' the lines below.   This should be moved to the config file at some point.

        Dim HrsLateUpperLimit = 6  'ToDo:  Move this to the config file


        'If lblDebug.Text = "debug" Then WriteToLog2("Into Notify group 1 missed", "debug_log.txt")

        Dim data_reader As OleDbDataReader
        Dim connection As New OleDbConnection

        Try
            Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FrmPassword.txtDBPath.Text & ";Jet OLEDB:Database Password=" & FrmPassword.txtDBPassword.Text
            connection.ConnectionString = strConnectionString
            connection.Open()

            'Check to see if reminders were missed since the last application start
            Dim Time_now As String = System.DateTime.Now.ToString("HH:mm")
            Dim today As String = System.DateTime.Now.ToString("MM/dd/yyyy")
            Dim Str As String = "SELECT * FROM Appts WHERE ((rday1 = '" & Today & "') AND (rtime1 <='" & Time_now & "'));"
            Dim command As New OleDbCommand(str, connection)

            data_reader = command.ExecuteReader

            If data_reader.HasRows Then
                While data_reader.Read
                    'results from query
                    Dim Id As Integer = data_reader.GetValue(0)
                    Dim language As String = data_reader.GetValue(1) & ""
                    Dim fname As String = data_reader.GetValue(2) & ""
                    Dim lname As String = data_reader.GetValue(3) & ""
                    Dim group As Integer = data_reader.GetValue(4)
                    Dim mnum As String = data_reader.GetValue(5) & ""
                    Dim sday As String = data_reader.GetValue(6) & ""
                    Dim rday1 As String = data_reader.GetValue(7) & ""
                    Dim rtime1 As String = data_reader.GetValue(8) & ""
                    Dim lasttxt As String = data_reader.GetValue(9) & ""
                    Dim clinic As String = data_reader.GetValue(11) & ""
                    Dim numtxts As Integer = 0
                    Dim sms_msg As String = "DCI appreciates you"
                    Dim comment As String = ""
                    Dim RemindDT As Date
                    Dim RemindIsDate As Boolean = Date.TryParse(rday1 & " " & rtime1, RemindDT)
                    Dim EventHappened As Integer = 7
                    Dim DTnow As Date = System.DateTime.Now
                    If RemindIsDate Then
                        Dim diff As TimeSpan = DTnow - RemindDT
                        If diff.Hours > HrsLateUpperLimit Then
                            EventHappened = 0
                            comment = "At " & CStr(DTnow) & " the system determined that this reminder was missed.  "
                        End If
                    End If
                    If Not data_reader.GetValue(10) Is DBNull.Value Then
                        numtxts = data_reader.GetValue(10)
                    Else
                        numtxts = 0
                    End If
                    If EventHappened <> 0 Then numtxts = numtxts + 1
                    Dim Index As Integer = FrmPassword.cboLanguageName.FindString(language)
                    FrmPassword.cboLanguageText.SelectedIndex = Index
                    sms_msg = FrmPassword.cboLanguageText.Text

                    'update lasttext and #texts lview entry in the reminders listview
                    If EventHappened <> 0 Then 'Don't update last text and number of texts if it was a missed text
                        lasttxt = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm")
                        For Each oItem As ListViewItem In lvwReminder.Items
                            Dim count As Integer = oItem.SubItems.Count
                            If oItem.Text = data_reader.GetValue(0) Then
                                oItem.SubItems(10).Text = lasttxt
                                oItem.SubItems(11).Text = CStr(numtxts)
                            End If
                        Next
                    End If

                    'copy to outcomes list
                    Dim newitem As New ListViewItem()
                    newitem.Text = Id                   '0
                    newitem.SubItems.Add(fname)         '1
                    newitem.SubItems.Add(lname)         '2
                    newitem.SubItems.Add(clinic)        '3
                    newitem.SubItems.Add(group)         '4
                    newitem.SubItems.Add(language)      '5
                    newitem.SubItems.Add(mnum)          '6
                    newitem.SubItems.Add(sday)          '7
                    newitem.SubItems.Add(rday1)         '8
                    newitem.SubItems.Add(rtime1)        '9
                    If EventHappened = 0 Then
                        newitem.SubItems.Add("")
                    Else
                        newitem.SubItems.Add(lasttxt)       '10
                    End If
                    newitem.SubItems.Add(CStr(numtxts)) '11
                    newitem.SubItems.Add("") ' actual rec date
                    'newitem.SubItems.Add(EventHappened) 'Happened - set to staff issue by default
                    Select Case EventHappened
                        Case 0
                            newitem.SubItems.Add("No-Text Not Sent (automated)")
                        Case 1
                            newitem.SubItems.Add("Yes")
                        Case 2
                            newitem.SubItems.Add("No-Patient Reports Text Not Recieved")
                        Case 3
                            newitem.SubItems.Add("No-Patient Absent")
                        Case 4
                            newitem.SubItems.Add("No-Patient Left Early")
                        Case 5
                            newitem.SubItems.Add("No-Patient Non-compliant")
                        Case 6
                            newitem.SubItems.Add("No-Patient Forgot - Reschedule 1 week")
                        Case 7
                            newitem.SubItems.Add("No-Staff Issue")
                        Case 8
                            newitem.SubItems.Add("No-Other Issue")
                    End Select
                    newitem.SubItems.Add("") 'claims all
                    newitem.SubItems.Add("") 'num meds brought
                    newitem.SubItems.Add("") 'num useful list
                    newitem.SubItems.Add("") 'Total list
                    newitem.SubItems.Add("") 'num useful pics
                    newitem.SubItems.Add("") 'total pics
                    newitem.SubItems.Add("") 'phone prob
                    newitem.SubItems.Add(comment) 'comment
                    lvwOutcome.Items.Add(newitem)

                    'Add this to the Outcomes DB table
                    InsertInOutcomesTable(Id, language, fname, lname, group, mnum, sday, rday1, rtime1, lasttxt, numtxts, "", EventHappened, "", "", "", "", comment, "", "", clinic, "")

                    'Blank out listview columns sday rday1 rtime1
                    For Each oItem As ListViewItem In lvwReminder.Items
                        If oItem.Text = data_reader.GetValue(0) Then
                            oItem.SubItems(7).Text = "" 'Scheduled Day
                            oItem.SubItems(8).Text = "" 'Reminder Day
                            oItem.SubItems(9).Text = "" 'Reminder Time
                        End If
                    Next

                    'Send Txt reminder - unless it is so long ago that it is now "missed"
                    If EventHappened <> 1 Then
                        Twilio_Text(mnum, sms_msg)
                        'MsgBox("Text sent to " & fname & " " & lname & " at " & mnum)
                    End If
                    'update Appts DB table - to reflect that the text went out
                    UpdateAppt(Id, fname, lname, group, mnum, language, "", "", "", lasttxt, numtxts, clinic)

                End While

            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            WriteToLog("Notify Group One - Exception Follows: " & ex.Message)
        End Try

        If data_reader IsNot Nothing Then
            data_reader.Close()
            connection.Close()
        End If


    End Sub
End Class
