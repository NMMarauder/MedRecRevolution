<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateOutcome
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.cboClinic = New System.Windows.Forms.ComboBox()
        Me.lblScheduled = New System.Windows.Forms.Label()
        Me.dtSchReconcile = New System.Windows.Forms.DateTimePicker()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.cboGroup = New System.Windows.Forms.ComboBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboShift = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtActual = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "MRN"
        '
        'txtMRN
        '
        Me.txtMRN.Location = New System.Drawing.Point(304, 28)
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.Size = New System.Drawing.Size(90, 20)
        Me.txtMRN.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(876, 77)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 24)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(799, 77)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(73, 24)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(16, 28)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(43, 20)
        Me.txtID.TabIndex = 64
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(766, 12)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(55, 13)
        Me.lblLanguage.TabIndex = 63
        Me.lblLanguage.Text = "Language"
        '
        'cboLanguage
        '
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Location = New System.Drawing.Point(769, 27)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(90, 21)
        Me.cboLanguage.TabIndex = 7
        '
        'lblClinic
        '
        Me.lblClinic.AutoSize = True
        Me.lblClinic.Location = New System.Drawing.Point(491, 13)
        Me.lblClinic.Name = "lblClinic"
        Me.lblClinic.Size = New System.Drawing.Size(32, 13)
        Me.lblClinic.TabIndex = 62
        Me.lblClinic.Text = "Clinic"
        '
        'cboClinic
        '
        Me.cboClinic.FormattingEnabled = True
        Me.cboClinic.Location = New System.Drawing.Point(494, 28)
        Me.cboClinic.Name = "cboClinic"
        Me.cboClinic.Size = New System.Drawing.Size(137, 21)
        Me.cboClinic.TabIndex = 5
        '
        'lblScheduled
        '
        Me.lblScheduled.AutoSize = True
        Me.lblScheduled.Location = New System.Drawing.Point(15, 69)
        Me.lblScheduled.Name = "lblScheduled"
        Me.lblScheduled.Size = New System.Drawing.Size(118, 13)
        Me.lblScheduled.TabIndex = 59
        Me.lblScheduled.Text = "Sched. Reconcile Date"
        '
        'dtSchReconcile
        '
        Me.dtSchReconcile.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSchReconcile.Location = New System.Drawing.Point(18, 85)
        Me.dtSchReconcile.Name = "dtSchReconcile"
        Me.dtSchReconcile.Size = New System.Drawing.Size(123, 20)
        Me.dtSchReconcile.TabIndex = 9
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(873, 12)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblMobile.TabIndex = 58
        Me.lblMobile.Text = "Mobile"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(643, 12)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblGroup.TabIndex = 57
        Me.lblGroup.Text = "Group"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(188, 13)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 56
        Me.lblLast.Text = "Last Name"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(76, 13)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(57, 13)
        Me.lblFirst.TabIndex = 55
        Me.lblFirst.Text = "First Name"
        '
        'cboGroup
        '
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Location = New System.Drawing.Point(646, 28)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(104, 21)
        Me.cboGroup.TabIndex = 6
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(876, 28)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(90, 20)
        Me.txtMobile.TabIndex = 8
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(191, 29)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(99, 20)
        Me.txtLast.TabIndex = 2
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(79, 29)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(90, 20)
        Me.txtFirst.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Shift"
        '
        'cboShift
        '
        Me.cboShift.FormattingEnabled = True
        Me.cboShift.Location = New System.Drawing.Point(404, 27)
        Me.cboShift.Name = "cboShift"
        Me.cboShift.Size = New System.Drawing.Size(75, 21)
        Me.cboShift.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Actual Reconcile Date"
        '
        'dtActual
        '
        Me.dtActual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtActual.Location = New System.Drawing.Point(175, 85)
        Me.dtActual.Name = "dtActual"
        Me.dtActual.Size = New System.Drawing.Size(123, 20)
        Me.dtActual.TabIndex = 74
        '
        'frmCreateOutcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 113)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtActual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMRN)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblLanguage)
        Me.Controls.Add(Me.cboLanguage)
        Me.Controls.Add(Me.lblClinic)
        Me.Controls.Add(Me.cboClinic)
        Me.Controls.Add(Me.lblScheduled)
        Me.Controls.Add(Me.dtSchReconcile)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.cboGroup)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "frmCreateOutcome"
        Me.Text = "Create Outcome without sending text message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblLanguage As Label
    Friend WithEvents cboLanguage As ComboBox
    Friend WithEvents lblClinic As Label
    Friend WithEvents cboClinic As ComboBox
    Public WithEvents lblScheduled As Label
    Friend WithEvents dtSchReconcile As DateTimePicker
    Public WithEvents lblMobile As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents cboGroup As ComboBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboShift As ComboBox
    Public WithEvents Label3 As Label
    Friend WithEvents dtActual As DateTimePicker
End Class
