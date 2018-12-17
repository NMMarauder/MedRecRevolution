Public Class frmCreateOutcome

    Private Sub dtScheduled_ValueChanged(sender As Object, e As EventArgs) Handles dtSchReconcile.ValueChanged
        Me.dtSchReconcile.Format = DateTimePickerFormat.Custom
        Me.dtSchReconcile.CustomFormat = "dd MMM yyyy"
    End Sub

    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


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

            'Shift
            cboShift.Items.Add("MWF - 1")
            cboShift.Items.Add("MWF - 2")
            cboShift.Items.Add("MWF - 3")
            cboShift.Items.Add("TTS - 1")
            cboShift.Items.Add("TTS - 2")
            cboShift.Items.Add("TTS - 3")
            str = frmMain.lvwReminder.SelectedItems(0).SubItems(4).Text
            cboShift.SelectedIndex = cboShift.FindString(str)

            'Group
            cboGroup.Items.Add("Not Participating")
            cboGroup.Items.Add("Receiving Texts")
            cboGroup.SelectedIndex = CInt(frmMain.lvwReminder.SelectedItems(0).SubItems(5).Text)

            'Language
            For i = 0 To FrmPassword.cboLanguageName.Items.Count - 1
                cboLanguage.Items.Add(FrmPassword.cboLanguageName.Items(i))
            Next
            str = frmMain.lvwReminder.SelectedItems(0).SubItems(6).Text
            cboLanguage.SelectedIndex = cboLanguage.FindString(str)

            'mobile
            txtMobile.Text = frmMain.lvwReminder.SelectedItems(0).SubItems(7).Text

            'scheduled
            dtSchReconcile.CustomFormat = "dd MMM yyyy"
            dtSchReconcile.Format = DateTimePickerFormat.Custom
            If frmMain.lvwReminder.SelectedItems(0).SubItems(8).Text <> "" Then
                dtSchReconcile.Value = frmMain.lvwReminder.SelectedItems(0).SubItems(8).Text
            Else
                dtSchReconcile.CustomFormat = " "
            End If

            'mobile
            txtMRN.Text = frmMain.lvwReminder.SelectedItems(0).SubItems(13).Text

        Catch ex As Exception
            WriteToLog("frmEdit_Load - Exception Follows: " & ex.Message)
            'MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Try
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

            '4 Shift
            Dim Shift As String = cboShift.Text

            '5. Group
            Dim group As String = CInt(cboGroup.SelectedIndex)

            '6. Language
            Dim language As String = cboLanguage.Text

            '7. Mobile
            Dim checkPhone As Boolean = False
            Dim mnum As String = CStr(txtMobile.Text)
            If mnum <> frmMain.lvwReminder.SelectedItems(0).SubItems(7).Text Then 'Only check if changed
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

            '8. Scheduled
            Dim sday As String = ""
            If dtSchReconcile.Text <> " " Then
                sday = dtSchReconcile.Value.ToString("MM/dd/yyyy")
            End If
            If sday = "" Then
                msg = msg & "The scheduled reconcile date is blank. Please fill in the date." & Environment.NewLine
            End If

            '9. actual Day
            Dim aday As String = ""
            If dtSchReconcile.Text <> " " Then
                aday = dtActual.Value.ToString("MM/dd/yyyy")
            End If
            If aday = "" Then
                msg = msg & "The actual reconcile date is blank. Please fill in the date." & Environment.NewLine
            End If

            Dim lasttxt As String = frmMain.lvwReminder.SelectedItems(0).SubItems(11).Text
            Dim numtxts As String = frmMain.lvwReminder.SelectedItems(0).SubItems(12).Text
            Dim MRN As String = txtMRN.Text
            Dim EventHappened As Integer = 9 ' Yes - w/o text reminder

            If msg = "" Then

                'Add this to the Outcomes DB table
                InsertInOutcomesTable(ID, language, fname, lname, group, mnum, sday, "", "", lasttxt, numtxts, aday, EventHappened, "", "", "", "", "Outcome created w/o SMS reminder", "", "", Clinic, "", MRN, Shift)


                'Update outcomes list
                frmMain.lvwOutcome.Items.Clear()
                frmMain.LoadOutcomeStructFromDB()
                frmMain.LoadOutcomeList(frmMain.lvwOutcome)
                ClearCreateForm()
                frmMain.Show()
                frmMain.lvwReminder.SelectedItems(0).SubItems(8).Text = "" 'Scheduled Day
                frmMain.lvwReminder.SelectedItems(0).SubItems(9).Text = "" 'Reminder Day
                frmMain.lvwReminder.SelectedItems(0).SubItems(10).Text = "" 'Reminder Time
                frmMain.lvwReminder.SelectedItems.Clear()
                Me.Close()
            Else
                MsgBox(msg)
            End If

        Catch ex As Exception
            WriteToLog("btnCreate_Click - Exception Follows: " & ex.Message)
            'MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Function ClearCreateForm() As Boolean

        txtID.ResetText()
        txtFirst.ResetText()
        txtLast.ResetText()
        cboClinic.SelectedIndex = -1
        cboGroup.SelectedIndex = -1
        cboLanguage.SelectedIndex = -1
        txtMobile.ResetText()
        dtSchReconcile.CustomFormat = " "
        dtSchReconcile.Format = DateTimePickerFormat.Custom
        txtMRN.ResetText()
        cboShift.Text = ""
        cboShift.SelectedIndex = -1

        Return True

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        ClearCreateForm()
        frmMain.lvwReminder.SelectedItems.Clear()
        Me.Close()

    End Sub
End Class