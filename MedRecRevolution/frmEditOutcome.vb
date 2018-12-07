Public Class frmEditOutcome

    Private Sub dtreconcile_ValueChanged(sender As Object, e As EventArgs) Handles dtReconcile.ValueChanged
        Me.dtReconcile.Format = DateTimePickerFormat.Custom
        Me.dtReconcile.CustomFormat = "dd MMM yyyy"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dtReconcile.CustomFormat = " "
        dtReconcile.Format = DateTimePickerFormat.Custom
        dtReconcile.Update()
    End Sub

    Private Sub frmEditOutcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim ii As Integer
            Dim jj As Integer
            Dim strHr As String
            Dim strMin As String
            Dim str As String

            'Load form
            txtID.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(0).Text
            txtFirst.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(1).Text
            txtLast.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(2).Text

            'Clinic
            For i = 0 To FrmPassword.cboClinics.Items.Count - 1
                cboClinic.Items.Add(FrmPassword.cboClinics.Items(i))
            Next
            str = frmMain.lvwOutcome.SelectedItems(0).SubItems(3).Text
            cboClinic.SelectedIndex = cboClinic.FindString(str)

            'Group
            cboGroup.Items.Add("Not Participating")
            cboGroup.Items.Add("Receiving Texts")
            cboGroup.SelectedIndex = CInt(frmMain.lvwOutcome.SelectedItems(0).SubItems(4).Text)

            'Language
            For i = 0 To FrmPassword.cboLanguageName.Items.Count - 1
                cboLanguage.Items.Add(FrmPassword.cboLanguageName.Items(i))
            Next
            str = frmMain.lvwOutcome.SelectedItems(0).SubItems(5).Text
            cboLanguage.SelectedIndex = cboLanguage.FindString(str)

            'mobile
            txtMobile.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(6).Text

            'scheduled
            dtScheduled.CustomFormat = "dd MMM yyyy"
            dtScheduled.Format = DateTimePickerFormat.Custom
            If frmMain.lvwOutcome.SelectedItems(0).SubItems(7).Text <> "" Then
                dtScheduled.Value = frmMain.lvwOutcome.SelectedItems(0).SubItems(7).Text
            Else
                dtScheduled.CustomFormat = " "
            End If

            'Reminder Date
            dtReminder.CustomFormat = "dd MMM yyyy"
            dtReminder.Format = DateTimePickerFormat.Custom
            If frmMain.lvwOutcome.SelectedItems(0).SubItems(8).Text <> "" Then
                dtReminder.Value = frmMain.lvwOutcome.SelectedItems(0).SubItems(8).Text
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
            If frmMain.lvwOutcome.SelectedItems(0).SubItems(9).Text <> "" Then
                cboRTime.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(9).Text
            Else
                cboRTime.Text = ""
                cboRTime.SelectedItem = Nothing
            End If

            'date of last text and number of texts so far
            txtLastText.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(10).Text
            txtNumTexts.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(11).Text


            'Date reconcile happened
            dtReconcile.CustomFormat = "dd MMM yyyy"
            dtReconcile.Format = DateTimePickerFormat.Custom
            If frmMain.lvwOutcome.SelectedItems(0).SubItems(12).Text <> "" Then
                dtReconcile.Value = frmMain.lvwOutcome.SelectedItems(0).SubItems(12).Text
            Else
                dtReconcile.CustomFormat = " "
            End If


            If cboHappened.Items.Count = 0 Then
                cboHappened.Items.Add("No-Text Not Sent (automated)")
                cboHappened.Items.Add("Yes")
                cboHappened.Items.Add("No-Patient Reports Text Not Recieved")
                cboHappened.Items.Add("No-Patient Absent")
                cboHappened.Items.Add("No-Patient Left Early")
                cboHappened.Items.Add("No-Patient Non-compliant")
                cboHappened.Items.Add("No-Patient Forgot - Reschedule 1 week")
                cboHappened.Items.Add("No-Staff Issue")
                cboHappened.Items.Add("No-Other Issue")
            End If
            str = frmMain.lvwOutcome.SelectedItems(0).SubItems(13).Text
            cboHappened.SelectedIndex = cboHappened.FindString(str)
            'cboHappened.SelectedIndex = CInt(frmMain.lvwOutcome.SelectedItems(0).SubItems(13).Text)
            If frmMain.lvwOutcome.SelectedItems(0).SubItems(14).Text = "1" Then chkAll.Checked = True
            txtNumMedsBrought.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(15).Text
            txtUsefulList.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(16).Text
            txtTotalList.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(17).Text
            txtNumPhotosBrought.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(18).Text
            txtTotalPhotos.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(19).Text
            If frmMain.lvwOutcome.SelectedItems(0).SubItems(20).Text = "1" Then chkTech.Checked = True
            rtComment.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(21).Text
            txtMRN.Text = frmMain.lvwOutcome.SelectedItems(0).SubItems(22).Text

        Catch ex As Exception
            WriteToLog("frmEditOutcome_Load on frmEditOutcome - Exception Follows: " & ex.Message)
            'MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearOutcomesForm()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            If frmMain.lvwOutcome.SelectedItems.Count > 0 Then
                Dim ID As String = frmMain.lvwOutcome.SelectedItems(0).SubItems(0).Text
                Dim updateReady As Boolean = True

                Dim rday As String = ""
                Dim sday As String = ""
                'Check date reconcile not before dt scheduled
                If dtReconcile.Text <> " " Then
                    rday = dtReconcile.Value.ToString("MM/dd/yyyy")
                End If
                If dtScheduled.Text <> " " Then
                    sday = dtScheduled.Value.ToString("MM/dd/yyyy")
                End If

                Dim answer As Integer
                If rday <> "" And rday < sday Then
                    answer = MsgBox("Do you really want to record a reconcile date that is earlier than the scheduled date?", vbYesNo)
                    If answer = vbNo Then updateReady = False
                End If

                'Check happened 0-8
                Dim happened As Integer
                happened = cboHappened.SelectedIndex
                If happened > 8 Or happened < 0 Then
                    MsgBox("Oops. The reconcile happened response has a problem.")
                    updateReady = False
                End If

                'Check totals => brought
                Dim medsbrought As Integer
                If txtNumMedsBrought.Text <> "" Then
                    medsbrought = CInt(txtNumMedsBrought.Text)
                End If
                Dim picsBrought As Integer
                If txtNumPhotosBrought.Text <> "" Then
                    picsBrought = CInt(txtNumPhotosBrought.Text)
                End If
                Dim totalpics As Integer
                If txtTotalPhotos.Text <> "" Then
                    totalpics = CInt(txtTotalPhotos.Text)
                End If

                If totalpics < picsBrought Then
                    answer = MsgBox("Number of pictured bottles cannot be less than the number of useful pictured bottles", vbOK)
                    updateReady = False
                End If

                Dim techProb As Integer
                If chkTech.Checked Then techProb = 1

                Dim allClaim As Integer
                If chkAll.Checked Then allClaim = 1
                Dim comment As String = rtComment.Text

                Dim useFulList As Integer
                If txtUsefulList.Text <> "" Then
                    useFulList = CInt(txtUsefulList.Text)
                End If

                Dim TotalList As Integer
                If txtTotalList.Text <> "" Then
                    TotalList = CInt(txtTotalList.Text)
                End If

                If TotalList < useFulList Then
                    answer = MsgBox("Number of USEFUL listed medications cannot be less than the total listed medications", vbOK)
                    updateReady = False
                End If

                Dim MRN As String = txtMRN.Text
                If Trim(MRN) = "" Then
                    answer = MsgBox("The MRN is blank.  Would you like to leave it blank for now?", vbYesNo)
                    If answer = vbNo Then
                        updateReady = False
                    End If
                End If

                'Update outcome table in DB  - Where ID & scheduled date matches   
                If updateReady Then
                    UpdateOutcome(ID, sday, rday, happened, techProb, medsbrought, picsBrought, totalpics, comment, allClaim, useFulList, TotalList, MRN)

                    'Update outcomes list
                    frmMain.lvwOutcome.Items.Clear()
                    frmMain.LoadOutcomeStructFromDB()
                    frmMain.LoadOutcomeList(frmMain.lvwOutcome)
                    ClearOutcomesForm()
                    frmMain.Show()
                    frmMain.lvwOutcome.SelectedItems.Clear()
                    Me.Close()

                End If
            End If

        Catch ex As Exception
            WriteToLog("btnSave_click on frmEditOutcome - Exception Follows: " & ex.Message)
            'MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Function ClearOutcomesForm() As Boolean

        txtFirst.ResetText()
        txtLast.ResetText()
        txtMobile.ResetText()
        cboRTime.ResetText()
        cboRTime.SelectedItem = Nothing

        dtScheduled.CustomFormat = " "
        dtScheduled.Format = DateTimePickerFormat.Custom
        dtReminder.CustomFormat = " "
        dtReminder.Format = DateTimePickerFormat.Custom
        cboGroup.SelectedIndex = 0
        cboClinic.SelectedIndex = -1
        txtNumTexts.ResetText()
        dtReconcile.CustomFormat = " "
        dtReconcile.Format = DateTimePickerFormat.Custom
        cboHappened.ResetText()
        cboHappened.SelectedItem = Nothing
        chkTech.Checked = False
        chkAll.Checked = False
        txtNumMedsBrought.ResetText()
        txtNumPhotosBrought.ResetText()
        txtTotalPhotos.ResetText()
        rtComment.ResetText()
        cboLanguage.SelectedIndex = -1
        txtUsefulList.ResetText()
        txtTotalList.ResetText()

        Return True

    End Function
End Class