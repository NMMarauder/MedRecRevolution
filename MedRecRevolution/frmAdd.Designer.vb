<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.cboGroup = New System.Windows.Forms.ComboBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.dtScheduled = New System.Windows.Forms.DateTimePicker()
        Me.dtReminder = New System.Windows.Forms.DateTimePicker()
        Me.cboRTime = New System.Windows.Forms.ComboBox()
        Me.lblScheduled = New System.Windows.Forms.Label()
        Me.lblReminder = New System.Windows.Forms.Label()
        Me.lblRTime = New System.Windows.Forms.Label()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.cboClinic = New System.Windows.Forms.ComboBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(33, 39)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(90, 20)
        Me.txtFirst.TabIndex = 0
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(145, 39)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(99, 20)
        Me.txtLast.TabIndex = 1
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(653, 39)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(90, 20)
        Me.txtMobile.TabIndex = 6
        '
        'cboGroup
        '
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Location = New System.Drawing.Point(423, 39)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(104, 21)
        Me.cboGroup.TabIndex = 4
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(30, 23)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(57, 13)
        Me.lblFirst.TabIndex = 4
        Me.lblFirst.Text = "First Name"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(142, 23)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 5
        Me.lblLast.Text = "Last Name"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(420, 23)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblGroup.TabIndex = 6
        Me.lblGroup.Text = "Group"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(650, 23)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblMobile.TabIndex = 7
        Me.lblMobile.Text = "Mobile"
        '
        'dtScheduled
        '
        Me.dtScheduled.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtScheduled.Location = New System.Drawing.Point(761, 39)
        Me.dtScheduled.Name = "dtScheduled"
        Me.dtScheduled.Size = New System.Drawing.Size(123, 20)
        Me.dtScheduled.TabIndex = 7
        '
        'dtReminder
        '
        Me.dtReminder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReminder.Location = New System.Drawing.Point(910, 39)
        Me.dtReminder.Name = "dtReminder"
        Me.dtReminder.Size = New System.Drawing.Size(115, 20)
        Me.dtReminder.TabIndex = 8
        '
        'cboRTime
        '
        Me.cboRTime.FormattingEnabled = True
        Me.cboRTime.Location = New System.Drawing.Point(1041, 38)
        Me.cboRTime.Name = "cboRTime"
        Me.cboRTime.Size = New System.Drawing.Size(90, 21)
        Me.cboRTime.TabIndex = 9
        '
        'lblScheduled
        '
        Me.lblScheduled.AutoSize = True
        Me.lblScheduled.Location = New System.Drawing.Point(758, 23)
        Me.lblScheduled.Name = "lblScheduled"
        Me.lblScheduled.Size = New System.Drawing.Size(109, 13)
        Me.lblScheduled.TabIndex = 11
        Me.lblScheduled.Text = "Scheduled Reconcile"
        '
        'lblReminder
        '
        Me.lblReminder.AutoSize = True
        Me.lblReminder.Location = New System.Drawing.Point(907, 23)
        Me.lblReminder.Name = "lblReminder"
        Me.lblReminder.Size = New System.Drawing.Size(78, 13)
        Me.lblReminder.TabIndex = 12
        Me.lblReminder.Text = "Reminder Date"
        '
        'lblRTime
        '
        Me.lblRTime.AutoSize = True
        Me.lblRTime.Location = New System.Drawing.Point(1038, 23)
        Me.lblRTime.Name = "lblRTime"
        Me.lblRTime.Size = New System.Drawing.Size(78, 13)
        Me.lblRTime.TabIndex = 13
        Me.lblRTime.Text = "Reminder Time"
        '
        'lblClinic
        '
        Me.lblClinic.AutoSize = True
        Me.lblClinic.Location = New System.Drawing.Point(260, 23)
        Me.lblClinic.Name = "lblClinic"
        Me.lblClinic.Size = New System.Drawing.Size(32, 13)
        Me.lblClinic.TabIndex = 15
        Me.lblClinic.Text = "Clinic"
        '
        'cboClinic
        '
        Me.cboClinic.FormattingEnabled = True
        Me.cboClinic.Location = New System.Drawing.Point(263, 38)
        Me.cboClinic.Name = "cboClinic"
        Me.cboClinic.Size = New System.Drawing.Size(137, 21)
        Me.cboClinic.TabIndex = 3
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(543, 23)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(55, 13)
        Me.lblLanguage.TabIndex = 17
        Me.lblLanguage.Text = "Language"
        '
        'cboLanguage
        '
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Location = New System.Drawing.Point(546, 38)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(90, 21)
        Me.cboLanguage.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(967, 99)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 26)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1055, 99)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 26)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 137)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
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
        Me.Name = "frmAdd"
        Me.Text = "Add Reconcile Reminder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents cboGroup As ComboBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblGroup As Label
    Public WithEvents lblMobile As Label
    Friend WithEvents dtScheduled As DateTimePicker
    Friend WithEvents dtReminder As DateTimePicker
    Friend WithEvents cboRTime As ComboBox
    Public WithEvents lblScheduled As Label
    Public WithEvents lblReminder As Label
    Public WithEvents lblRTime As Label
    Friend WithEvents lblClinic As Label
    Friend WithEvents cboClinic As ComboBox
    Friend WithEvents lblLanguage As Label
    Friend WithEvents cboLanguage As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
End Class
