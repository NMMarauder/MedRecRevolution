<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAppt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtLastText = New System.Windows.Forms.TextBox()
        Me.txtNumTexts = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboShift = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(827, 23)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(55, 13)
        Me.lblLanguage.TabIndex = 35
        Me.lblLanguage.Text = "Language"
        '
        'cboLanguage
        '
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Location = New System.Drawing.Point(830, 38)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(90, 21)
        Me.cboLanguage.TabIndex = 7
        '
        'lblClinic
        '
        Me.lblClinic.AutoSize = True
        Me.lblClinic.Location = New System.Drawing.Point(423, 23)
        Me.lblClinic.Name = "lblClinic"
        Me.lblClinic.Size = New System.Drawing.Size(32, 13)
        Me.lblClinic.TabIndex = 34
        Me.lblClinic.Text = "Clinic"
        '
        'cboClinic
        '
        Me.cboClinic.FormattingEnabled = True
        Me.cboClinic.Location = New System.Drawing.Point(426, 38)
        Me.cboClinic.Name = "cboClinic"
        Me.cboClinic.Size = New System.Drawing.Size(137, 21)
        Me.cboClinic.TabIndex = 4
        '
        'lblRTime
        '
        Me.lblRTime.AutoSize = True
        Me.lblRTime.Location = New System.Drawing.Point(307, 73)
        Me.lblRTime.Name = "lblRTime"
        Me.lblRTime.Size = New System.Drawing.Size(78, 13)
        Me.lblRTime.TabIndex = 33
        Me.lblRTime.Text = "Reminder Time"
        '
        'lblReminder
        '
        Me.lblReminder.AutoSize = True
        Me.lblReminder.Location = New System.Drawing.Point(165, 73)
        Me.lblReminder.Name = "lblReminder"
        Me.lblReminder.Size = New System.Drawing.Size(78, 13)
        Me.lblReminder.TabIndex = 32
        Me.lblReminder.Text = "Reminder Date"
        '
        'lblScheduled
        '
        Me.lblScheduled.AutoSize = True
        Me.lblScheduled.Location = New System.Drawing.Point(27, 73)
        Me.lblScheduled.Name = "lblScheduled"
        Me.lblScheduled.Size = New System.Drawing.Size(109, 13)
        Me.lblScheduled.TabIndex = 31
        Me.lblScheduled.Text = "Scheduled Reconcile"
        '
        'cboRTime
        '
        Me.cboRTime.FormattingEnabled = True
        Me.cboRTime.Location = New System.Drawing.Point(308, 88)
        Me.cboRTime.Name = "cboRTime"
        Me.cboRTime.Size = New System.Drawing.Size(90, 21)
        Me.cboRTime.TabIndex = 11
        '
        'dtReminder
        '
        Me.dtReminder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReminder.Location = New System.Drawing.Point(168, 89)
        Me.dtReminder.Name = "dtReminder"
        Me.dtReminder.Size = New System.Drawing.Size(115, 20)
        Me.dtReminder.TabIndex = 10
        '
        'dtScheduled
        '
        Me.dtScheduled.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtScheduled.Location = New System.Drawing.Point(30, 89)
        Me.dtScheduled.Name = "dtScheduled"
        Me.dtScheduled.Size = New System.Drawing.Size(123, 20)
        Me.dtScheduled.TabIndex = 9
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(934, 23)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblMobile.TabIndex = 28
        Me.lblMobile.Text = "Mobile"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(704, 23)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblGroup.TabIndex = 26
        Me.lblGroup.Text = "Group"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(195, 23)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 24
        Me.lblLast.Text = "Last Name"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(88, 23)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(57, 13)
        Me.lblFirst.TabIndex = 22
        Me.lblFirst.Text = "First Name"
        '
        'cboGroup
        '
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Location = New System.Drawing.Point(707, 39)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(104, 21)
        Me.cboGroup.TabIndex = 6
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(937, 39)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(90, 20)
        Me.txtMobile.TabIndex = 8
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(198, 39)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(99, 20)
        Me.txtLast.TabIndex = 2
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(91, 39)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(90, 20)
        Me.txtFirst.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(28, 38)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(43, 20)
        Me.txtID.TabIndex = 36
        '
        'txtLastText
        '
        Me.txtLastText.Enabled = False
        Me.txtLastText.Location = New System.Drawing.Point(426, 89)
        Me.txtLastText.Name = "txtLastText"
        Me.txtLastText.Size = New System.Drawing.Size(128, 20)
        Me.txtLastText.TabIndex = 12
        '
        'txtNumTexts
        '
        Me.txtNumTexts.Enabled = False
        Me.txtNumTexts.Location = New System.Drawing.Point(578, 89)
        Me.txtNumTexts.Name = "txtNumTexts"
        Me.txtNumTexts.Size = New System.Drawing.Size(78, 20)
        Me.txtNumTexts.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Last Text Sent At"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(575, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "# Texts"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(874, 142)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 24)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(951, 142)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 24)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "MRN"
        '
        'txtMRN
        '
        Me.txtMRN.Location = New System.Drawing.Point(315, 38)
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.Size = New System.Drawing.Size(90, 20)
        Me.txtMRN.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(577, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Shift"
        '
        'cboShift
        '
        Me.cboShift.FormattingEnabled = True
        Me.cboShift.Location = New System.Drawing.Point(580, 38)
        Me.cboShift.Name = "cboShift"
        Me.cboShift.Size = New System.Drawing.Size(104, 21)
        Me.cboShift.TabIndex = 5
        '
        'frmEditAppt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 175)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMRN)
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
        Me.Name = "frmEditAppt"
        Me.Text = "Edit Reminder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtLastText As TextBox
    Friend WithEvents txtNumTexts As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboShift As ComboBox
End Class
