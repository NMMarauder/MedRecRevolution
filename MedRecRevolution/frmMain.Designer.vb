<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvwOutcome = New System.Windows.Forms.ListView()
        Me.btnAddAppt = New System.Windows.Forms.Button()
        Me.btnEditAppt = New System.Windows.Forms.Button()
        Me.btnDeleteAppt = New System.Windows.Forms.Button()
        Me.btnEditOutcome = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvwReminder = New System.Windows.Forms.ListView()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.dtStart = New System.Windows.Forms.DateTimePicker()
        Me.dtEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkFilter = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(653, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'lvwOutcome
        '
        Me.lvwOutcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwOutcome.FullRowSelect = True
        Me.lvwOutcome.Location = New System.Drawing.Point(15, 270)
        Me.lvwOutcome.Name = "lvwOutcome"
        Me.lvwOutcome.Size = New System.Drawing.Size(1451, 242)
        Me.lvwOutcome.TabIndex = 1
        Me.lvwOutcome.UseCompatibleStateImageBehavior = False
        Me.lvwOutcome.View = System.Windows.Forms.View.Details
        '
        'btnAddAppt
        '
        Me.btnAddAppt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddAppt.Location = New System.Drawing.Point(15, 221)
        Me.btnAddAppt.Name = "btnAddAppt"
        Me.btnAddAppt.Size = New System.Drawing.Size(96, 21)
        Me.btnAddAppt.TabIndex = 3
        Me.btnAddAppt.Text = "Add Reminder"
        Me.btnAddAppt.UseVisualStyleBackColor = True
        '
        'btnEditAppt
        '
        Me.btnEditAppt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditAppt.Location = New System.Drawing.Point(122, 221)
        Me.btnEditAppt.Name = "btnEditAppt"
        Me.btnEditAppt.Size = New System.Drawing.Size(90, 21)
        Me.btnEditAppt.TabIndex = 4
        Me.btnEditAppt.Text = "Edit Reminder"
        Me.btnEditAppt.UseVisualStyleBackColor = True
        '
        'btnDeleteAppt
        '
        Me.btnDeleteAppt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteAppt.AutoSize = True
        Me.btnDeleteAppt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDeleteAppt.Location = New System.Drawing.Point(1365, 221)
        Me.btnDeleteAppt.Name = "btnDeleteAppt"
        Me.btnDeleteAppt.Size = New System.Drawing.Size(96, 23)
        Me.btnDeleteAppt.TabIndex = 5
        Me.btnDeleteAppt.Text = "Delete Reminder"
        Me.btnDeleteAppt.UseVisualStyleBackColor = True
        '
        'btnEditOutcome
        '
        Me.btnEditOutcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditOutcome.Location = New System.Drawing.Point(15, 518)
        Me.btnEditOutcome.Name = "btnEditOutcome"
        Me.btnEditOutcome.Size = New System.Drawing.Size(95, 21)
        Me.btnEditOutcome.TabIndex = 6
        Me.btnEditOutcome.Text = "Edit Outcome"
        Me.btnEditOutcome.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Reminder List"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Outcomes List"
        '
        'lvwReminder
        '
        Me.lvwReminder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwReminder.FullRowSelect = True
        Me.lvwReminder.Location = New System.Drawing.Point(15, 38)
        Me.lvwReminder.Name = "lvwReminder"
        Me.lvwReminder.Size = New System.Drawing.Size(1446, 160)
        Me.lvwReminder.TabIndex = 9
        Me.lvwReminder.UseCompatibleStateImageBehavior = False
        Me.lvwReminder.View = System.Windows.Forms.View.Details
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(352, 19)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(42, 13)
        Me.lblVersion.TabIndex = 10
        Me.lblVersion.Text = "Version"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(295, 221)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(99, 21)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "Create Outcome"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'dtStart
        '
        Me.dtStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtStart.Location = New System.Drawing.Point(630, 221)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(123, 20)
        Me.dtStart.TabIndex = 12
        '
        'dtEnd
        '
        Me.dtEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtEnd.Location = New System.Drawing.Point(781, 221)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(123, 20)
        Me.dtEnd.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(759, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "to"
        '
        'chkFilter
        '
        Me.chkFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkFilter.AutoSize = True
        Me.chkFilter.Location = New System.Drawing.Point(920, 221)
        Me.chkFilter.Name = "chkFilter"
        Me.chkFilter.Size = New System.Drawing.Size(102, 17)
        Me.chkFilter.TabIndex = 16
        Me.chkFilter.Text = "Filter Outcomes "
        Me.chkFilter.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1493, 542)
        Me.Controls.Add(Me.chkFilter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lvwReminder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEditOutcome)
        Me.Controls.Add(Me.btnDeleteAppt)
        Me.Controls.Add(Me.btnEditAppt)
        Me.Controls.Add(Me.btnAddAppt)
        Me.Controls.Add(Me.lvwOutcome)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Medication Reconciliation Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lvwOutcome As ListView
    Friend WithEvents btnAddAppt As Button
    Friend WithEvents btnEditAppt As Button
    Friend WithEvents btnDeleteAppt As Button
    Friend WithEvents btnEditOutcome As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lvwReminder As ListView
    Friend WithEvents lblVersion As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents chkFilter As CheckBox
End Class
