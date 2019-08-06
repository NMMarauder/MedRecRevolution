<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditOutcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumTexts = New System.Windows.Forms.TextBox()
        Me.txtLastText = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.cboClinic = New System.Windows.Forms.ComboBox()
        Me.lblRTime = New System.Windows.Forms.Label()
        Me.lblReminder = New System.Windows.Forms.Label()
        Me.lblScheduled = New System.Windows.Forms.Label()
        Me.cboRTime = New System.Windows.Forms.ComboBox()
        Me.dtReminder = New System.Windows.Forms.DateTimePicker()
        Me.dtScheduled = New System.Windows.Forms.DateTimePicker()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.cboGroup = New System.Windows.Forms.ComboBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtTotalPhotos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumPhotosBrought = New System.Windows.Forms.TextBox()
        Me.chkTech = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUsefulList = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalListed = New System.Windows.Forms.Label()
        Me.txtTotalList = New System.Windows.Forms.TextBox()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.rtComment = New System.Windows.Forms.RichTextBox()
        Me.cboHappened = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtReconcile = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboShift = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumMedsBrought = New System.Windows.Forms.TextBox()
        Me.dtDarwin = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClearDarwin = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(762, 637)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 24)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(685, 637)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 24)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(654, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "# Texts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(515, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Last Text Sent At"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "ID"
        '
        'txtNumTexts
        '
        Me.txtNumTexts.Enabled = False
        Me.txtNumTexts.Location = New System.Drawing.Point(657, 77)
        Me.txtNumTexts.Name = "txtNumTexts"
        Me.txtNumTexts.Size = New System.Drawing.Size(78, 20)
        Me.txtNumTexts.TabIndex = 14
        '
        'txtLastText
        '
        Me.txtLastText.Enabled = False
        Me.txtLastText.Location = New System.Drawing.Point(518, 78)
        Me.txtLastText.Name = "txtLastText"
        Me.txtLastText.Size = New System.Drawing.Size(128, 20)
        Me.txtLastText.TabIndex = 13
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(21, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(43, 20)
        Me.txtID.TabIndex = 1
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(741, 8)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(55, 13)
        Me.lblLanguage.TabIndex = 61
        Me.lblLanguage.Text = "Language"
        '
        'cboLanguage
        '
        Me.cboLanguage.Enabled = False
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Location = New System.Drawing.Point(743, 24)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(90, 21)
        Me.cboLanguage.TabIndex = 8
        '
        'lblClinic
        '
        Me.lblClinic.AutoSize = True
        Me.lblClinic.Location = New System.Drawing.Point(379, 8)
        Me.lblClinic.Name = "lblClinic"
        Me.lblClinic.Size = New System.Drawing.Size(32, 13)
        Me.lblClinic.TabIndex = 60
        Me.lblClinic.Text = "Clinic"
        '
        'cboClinic
        '
        Me.cboClinic.Enabled = False
        Me.cboClinic.FormattingEnabled = True
        Me.cboClinic.Location = New System.Drawing.Point(382, 23)
        Me.cboClinic.Name = "cboClinic"
        Me.cboClinic.Size = New System.Drawing.Size(137, 21)
        Me.cboClinic.TabIndex = 5
        '
        'lblRTime
        '
        Me.lblRTime.AutoSize = True
        Me.lblRTime.Location = New System.Drawing.Point(406, 62)
        Me.lblRTime.Name = "lblRTime"
        Me.lblRTime.Size = New System.Drawing.Size(78, 13)
        Me.lblRTime.TabIndex = 59
        Me.lblRTime.Text = "Reminder Time"
        '
        'lblReminder
        '
        Me.lblReminder.AutoSize = True
        Me.lblReminder.Location = New System.Drawing.Point(267, 61)
        Me.lblReminder.Name = "lblReminder"
        Me.lblReminder.Size = New System.Drawing.Size(78, 13)
        Me.lblReminder.TabIndex = 58
        Me.lblReminder.Text = "Reminder Date"
        '
        'lblScheduled
        '
        Me.lblScheduled.AutoSize = True
        Me.lblScheduled.Location = New System.Drawing.Point(123, 61)
        Me.lblScheduled.Name = "lblScheduled"
        Me.lblScheduled.Size = New System.Drawing.Size(109, 13)
        Me.lblScheduled.TabIndex = 57
        Me.lblScheduled.Text = "Scheduled Reconcile"
        '
        'cboRTime
        '
        Me.cboRTime.Enabled = False
        Me.cboRTime.FormattingEnabled = True
        Me.cboRTime.IntegralHeight = False
        Me.cboRTime.Location = New System.Drawing.Point(409, 77)
        Me.cboRTime.Name = "cboRTime"
        Me.cboRTime.Size = New System.Drawing.Size(90, 21)
        Me.cboRTime.TabIndex = 12
        '
        'dtReminder
        '
        Me.dtReminder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReminder.Location = New System.Drawing.Point(270, 77)
        Me.dtReminder.Name = "dtReminder"
        Me.dtReminder.Size = New System.Drawing.Size(115, 20)
        Me.dtReminder.TabIndex = 11
        '
        'dtScheduled
        '
        Me.dtScheduled.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtScheduled.Location = New System.Drawing.Point(126, 77)
        Me.dtScheduled.Name = "dtScheduled"
        Me.dtScheduled.Size = New System.Drawing.Size(123, 20)
        Me.dtScheduled.TabIndex = 10
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(18, 61)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblMobile.TabIndex = 56
        Me.lblMobile.Text = "Mobile"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(624, 8)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblGroup.TabIndex = 55
        Me.lblGroup.Text = "Group"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(174, 8)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 54
        Me.lblLast.Text = "Last Name"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(72, 8)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(57, 13)
        Me.lblFirst.TabIndex = 53
        Me.lblFirst.Text = "First Name"
        '
        'cboGroup
        '
        Me.cboGroup.Enabled = False
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Location = New System.Drawing.Point(625, 24)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(104, 21)
        Me.cboGroup.TabIndex = 7
        '
        'txtMobile
        '
        Me.txtMobile.Enabled = False
        Me.txtMobile.Location = New System.Drawing.Point(21, 77)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(90, 20)
        Me.txtMobile.TabIndex = 9
        '
        'txtLast
        '
        Me.txtLast.Enabled = False
        Me.txtLast.Location = New System.Drawing.Point(177, 24)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(99, 20)
        Me.txtLast.TabIndex = 3
        '
        'txtFirst
        '
        Me.txtFirst.Enabled = False
        Me.txtFirst.Location = New System.Drawing.Point(75, 24)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(90, 20)
        Me.txtFirst.TabIndex = 2
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(399, 165)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(56, 13)
        Me.lblComment.TabIndex = 120
        Me.lblComment.Text = "Comments"
        '
        'txtTotalPhotos
        '
        Me.txtTotalPhotos.Location = New System.Drawing.Point(226, 52)
        Me.txtTotalPhotos.Name = "txtTotalPhotos"
        Me.txtTotalPhotos.Size = New System.Drawing.Size(48, 20)
        Me.txtTotalPhotos.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Total pictured bottles"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Number of USEFUL pictured bottles"
        '
        'txtNumPhotosBrought
        '
        Me.txtNumPhotosBrought.Location = New System.Drawing.Point(226, 20)
        Me.txtNumPhotosBrought.Name = "txtNumPhotosBrought"
        Me.txtNumPhotosBrought.Size = New System.Drawing.Size(48, 20)
        Me.txtNumPhotosBrought.TabIndex = 21
        '
        'chkTech
        '
        Me.chkTech.AutoSize = True
        Me.chkTech.Location = New System.Drawing.Point(16, 87)
        Me.chkTech.Name = "chkTech"
        Me.chkTech.Size = New System.Drawing.Size(282, 17)
        Me.chkTech.TabIndex = 88
        Me.chkTech.Text = "Phone technical problems interfered with reconciliation"
        Me.chkTech.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalPhotos)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtNumPhotosBrought)
        Me.GroupBox2.Controls.Add(Me.chkTech)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 508)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 122)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Brought Photos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(187, 13)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Number of USEFUL listed medications"
        '
        'txtUsefulList
        '
        Me.txtUsefulList.Location = New System.Drawing.Point(227, 23)
        Me.txtUsefulList.Name = "txtUsefulList"
        Me.txtUsefulList.Size = New System.Drawing.Size(47, 20)
        Me.txtUsefulList.TabIndex = 19
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(230, 191)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 22)
        Me.btnClear.TabIndex = 123
        Me.btnClear.Text = "<- Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalListed)
        Me.GroupBox1.Controls.Add(Me.txtTotalList)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtUsefulList)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 395)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 85)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Brought List"
        '
        'lblTotalListed
        '
        Me.lblTotalListed.AutoSize = True
        Me.lblTotalListed.Location = New System.Drawing.Point(17, 57)
        Me.lblTotalListed.Name = "lblTotalListed"
        Me.lblTotalListed.Size = New System.Drawing.Size(117, 13)
        Me.lblTotalListed.TabIndex = 80
        Me.lblTotalListed.Text = "Total listed medications"
        '
        'txtTotalList
        '
        Me.txtTotalList.Location = New System.Drawing.Point(227, 57)
        Me.txtTotalList.Name = "txtTotalList"
        Me.txtTotalList.Size = New System.Drawing.Size(47, 20)
        Me.txtTotalList.TabIndex = 20
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(47, 285)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(228, 17)
        Me.chkAll.TabIndex = 17
        Me.chkAll.Text = "Patient claims this is all current medications"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'rtComment
        '
        Me.rtComment.Location = New System.Drawing.Point(402, 191)
        Me.rtComment.Name = "rtComment"
        Me.rtComment.Size = New System.Drawing.Size(431, 440)
        Me.rtComment.TabIndex = 23
        Me.rtComment.Text = ""
        '
        'cboHappened
        '
        Me.cboHappened.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboHappened.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboHappened.FormattingEnabled = True
        Me.cboHappened.Location = New System.Drawing.Point(34, 144)
        Me.cboHappened.Name = "cboHappened"
        Me.cboHappened.Size = New System.Drawing.Size(260, 21)
        Me.cboHappened.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 13)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Reconcile Event Happened On Scheduled Date?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Date of Reconcile on Sheet"
        '
        'dtReconcile
        '
        Me.dtReconcile.Location = New System.Drawing.Point(38, 193)
        Me.dtReconcile.Name = "dtReconcile"
        Me.dtReconcile.Size = New System.Drawing.Size(179, 20)
        Me.dtReconcile.TabIndex = 16
        Me.dtReconcile.Value = New Date(2019, 1, 10, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "MRN"
        '
        'txtMRN
        '
        Me.txtMRN.Location = New System.Drawing.Point(290, 24)
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.Size = New System.Drawing.Size(78, 20)
        Me.txtMRN.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(522, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Shift"
        '
        'cboShift
        '
        Me.cboShift.FormattingEnabled = True
        Me.cboShift.Location = New System.Drawing.Point(525, 24)
        Me.cboShift.Name = "cboShift"
        Me.cboShift.Size = New System.Drawing.Size(90, 21)
        Me.cboShift.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtNumMedsBrought)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 321)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(332, 52)
        Me.GroupBox3.TabIndex = 122
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Patient Brought Bottles"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(199, 13)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Number of medications brought in bottles"
        '
        'txtNumMedsBrought
        '
        Me.txtNumMedsBrought.Location = New System.Drawing.Point(227, 19)
        Me.txtNumMedsBrought.Name = "txtNumMedsBrought"
        Me.txtNumMedsBrought.Size = New System.Drawing.Size(47, 20)
        Me.txtNumMedsBrought.TabIndex = 18
        '
        'dtDarwin
        '
        Me.dtDarwin.Location = New System.Drawing.Point(36, 248)
        Me.dtDarwin.Name = "dtDarwin"
        Me.dtDarwin.Size = New System.Drawing.Size(179, 20)
        Me.dtDarwin.TabIndex = 128
        Me.dtDarwin.Value = New Date(2019, 1, 10, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 13)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Date of Reconcile in Darwin"
        '
        'btnClearDarwin
        '
        Me.btnClearDarwin.Location = New System.Drawing.Point(230, 246)
        Me.btnClearDarwin.Name = "btnClearDarwin"
        Me.btnClearDarwin.Size = New System.Drawing.Size(82, 22)
        Me.btnClearDarwin.TabIndex = 130
        Me.btnClearDarwin.Text = "<- Clear"
        Me.btnClearDarwin.UseVisualStyleBackColor = True
        '
        'frmEditOutcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 672)
        Me.Controls.Add(Me.btnClearDarwin)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtDarwin)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMRN)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.rtComment)
        Me.Controls.Add(Me.cboHappened)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtReconcile)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumTexts)
        Me.Controls.Add(Me.txtLastText)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblLanguage)
        Me.Controls.Add(Me.cboLanguage)
        Me.Controls.Add(Me.lblClinic)
        Me.Controls.Add(Me.cboClinic)
        Me.Controls.Add(Me.lblRTime)
        Me.Controls.Add(Me.lblReminder)
        Me.Controls.Add(Me.lblScheduled)
        Me.Controls.Add(Me.cboRTime)
        Me.Controls.Add(Me.dtReminder)
        Me.Controls.Add(Me.dtScheduled)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.cboGroup)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditOutcome"
        Me.Text = "Edit Outcome"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumTexts As TextBox
    Friend WithEvents txtLastText As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblLanguage As Label
    Friend WithEvents cboLanguage As ComboBox
    Friend WithEvents lblClinic As Label
    Friend WithEvents cboClinic As ComboBox
    Public WithEvents lblRTime As Label
    Public WithEvents lblReminder As Label
    Public WithEvents lblScheduled As Label
    Friend WithEvents cboRTime As ComboBox
    Friend WithEvents dtReminder As DateTimePicker
    Friend WithEvents dtScheduled As DateTimePicker
    Public WithEvents lblMobile As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents cboGroup As ComboBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents txtTotalPhotos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNumPhotosBrought As TextBox
    Friend WithEvents chkTech As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUsefulList As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents rtComment As RichTextBox
    Friend WithEvents cboHappened As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtReconcile As DateTimePicker
    Friend WithEvents lblTotalListed As Label
    Friend WithEvents txtTotalList As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboShift As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNumMedsBrought As TextBox
    Friend WithEvents dtDarwin As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents btnClearDarwin As Button
End Class
