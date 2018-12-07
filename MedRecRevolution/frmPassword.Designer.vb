<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPassword
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
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtDBPath = New System.Windows.Forms.TextBox()
        Me.txtDBPassword = New System.Windows.Forms.TextBox()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.txtSMS = New System.Windows.Forms.TextBox()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.cboLanguageName = New System.Windows.Forms.ComboBox()
        Me.cboLanguageText = New System.Windows.Forms.ComboBox()
        Me.cboClinics = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsReturn = True
        Me.txtPassword.Location = New System.Drawing.Point(12, 37)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(142, 20)
        Me.txtPassword.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 21)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(98, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Enter the password"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(160, 36)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(63, 20)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtDBPath
        '
        Me.txtDBPath.Enabled = False
        Me.txtDBPath.Location = New System.Drawing.Point(12, 90)
        Me.txtDBPath.Name = "txtDBPath"
        Me.txtDBPath.Size = New System.Drawing.Size(114, 20)
        Me.txtDBPath.TabIndex = 3
        '
        'txtDBPassword
        '
        Me.txtDBPassword.Enabled = False
        Me.txtDBPassword.Location = New System.Drawing.Point(12, 119)
        Me.txtDBPassword.Name = "txtDBPassword"
        Me.txtDBPassword.Size = New System.Drawing.Size(114, 20)
        Me.txtDBPassword.TabIndex = 4
        '
        'txtSID
        '
        Me.txtSID.Enabled = False
        Me.txtSID.Location = New System.Drawing.Point(12, 145)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.Size = New System.Drawing.Size(114, 20)
        Me.txtSID.TabIndex = 5
        '
        'txtToken
        '
        Me.txtToken.Enabled = False
        Me.txtToken.Location = New System.Drawing.Point(12, 171)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(114, 20)
        Me.txtToken.TabIndex = 6
        '
        'txtSMS
        '
        Me.txtSMS.Enabled = False
        Me.txtSMS.Location = New System.Drawing.Point(15, 197)
        Me.txtSMS.Name = "txtSMS"
        Me.txtSMS.Size = New System.Drawing.Size(114, 20)
        Me.txtSMS.TabIndex = 7
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(149, 90)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(114, 20)
        Me.txtURL.TabIndex = 8
        '
        'cboLanguageName
        '
        Me.cboLanguageName.FormattingEnabled = True
        Me.cboLanguageName.Location = New System.Drawing.Point(149, 119)
        Me.cboLanguageName.Name = "cboLanguageName"
        Me.cboLanguageName.Size = New System.Drawing.Size(122, 21)
        Me.cboLanguageName.TabIndex = 9
        '
        'cboLanguageText
        '
        Me.cboLanguageText.FormattingEnabled = True
        Me.cboLanguageText.Location = New System.Drawing.Point(149, 146)
        Me.cboLanguageText.Name = "cboLanguageText"
        Me.cboLanguageText.Size = New System.Drawing.Size(122, 21)
        Me.cboLanguageText.TabIndex = 10
        '
        'cboClinics
        '
        Me.cboClinics.FormattingEnabled = True
        Me.cboClinics.Location = New System.Drawing.Point(149, 173)
        Me.cboClinics.Name = "cboClinics"
        Me.cboClinics.Size = New System.Drawing.Size(122, 21)
        Me.cboClinics.TabIndex = 11
        '
        'FrmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 78)
        Me.Controls.Add(Me.cboClinics)
        Me.Controls.Add(Me.cboLanguageText)
        Me.Controls.Add(Me.cboLanguageName)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.txtSMS)
        Me.Controls.Add(Me.txtToken)
        Me.Controls.Add(Me.txtSID)
        Me.Controls.Add(Me.txtDBPassword)
        Me.Controls.Add(Me.txtDBPath)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPassword"
        Me.Text = "Let's get started"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtDBPath As TextBox
    Friend WithEvents txtDBPassword As TextBox
    Friend WithEvents txtSID As TextBox
    Friend WithEvents txtToken As TextBox
    Friend WithEvents txtSMS As TextBox
    Friend WithEvents txtURL As TextBox
    Friend WithEvents cboLanguageName As ComboBox
    Friend WithEvents cboLanguageText As ComboBox
    Friend WithEvents cboClinics As ComboBox
End Class
