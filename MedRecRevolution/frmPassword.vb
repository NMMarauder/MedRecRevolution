Imports System.Configuration
Imports System.Xml

Public Class FrmPassword

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        LoadSettings()

    End Sub

    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            LoadSettings()
            e.Handled = True
        End If

    End Sub

    Private Sub LoadSettings()

        If txtPassword.Text <> "" Then
            Dim strPassword As String = txtPassword.Text
            Dim wrapper As New Simple3Des(strPassword)

            Try
                WriteToLog("Valid Password - Starting")
                Dim doc As New XmlDocument
                Dim AppName As String = System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath)
                Dim ApplicationDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
                Dim XMLfilePath = System.IO.Path.Combine(ApplicationDir, AppName & "Settings.xml")

                Dim xReader As XmlReader = XmlReader.Create(XMLfilePath)
                Dim strElement As String = ""
                Dim strValue As String = ""
                Dim StrAttribute As String = ""
                Dim lnCount As Integer = 0
                Dim ltCount As Integer = 0
                Dim ClCount As Integer = 0

                While xReader.Read()
                    Select Case xReader.NodeType
                        Case XmlNodeType.Element
                            strElement = xReader.Name
                            Exit Select
                        Case XmlNodeType.Text
                            strValue = xReader.Value
                            Exit Select
                        Case XmlNodeType.EndElement
                            If strElement = "DBPath" Then txtDBPath.Text = Trim(strValue)
                            If strElement = "DBPassword" Then txtDBPassword.Text = Trim(wrapper.DecryptData(strValue))
                            If strElement = "SID" Then txtSID.Text = Trim(wrapper.DecryptData(strValue))
                            If strElement = "Token" Then txtToken.Text = Trim(wrapper.DecryptData(strValue))
                            If strElement = "SMS" Then txtSMS.Text = Trim(wrapper.DecryptData(strValue))
                            If strElement = "URL" Then txtURL.Text = Trim(wrapper.DecryptData(strValue))
                            If strElement = "LanguageName" Then cboLanguageName.Items.Add(strValue)
                            If strElement = "LanguageText" Then cboLanguageText.Items.Add(strValue)
                            If strElement = "Clinic" Then cboClinics.Items.Add(strValue)
                            strElement = ""
                            strValue = ""
                            Exit Select
                    End Select
                End While

                lvwSentToday.Columns.Add("Mobile")
                lvwSentToday.Columns.Add("Num txts Sent")
                txtAlertCount.Text = "0"

                frmMain.Show()
                Me.Hide()
            Catch ex As System.Security.Cryptography.CryptographicException
                MsgBox("That's not the correct password.")
                txtPassword.Clear()
                txtPassword.Select()
            End Try

        Else
            MsgBox("You must enter the password", vbOKOnly)
        End If

    End Sub
    Private Function GetAttibuteValue(ByVal node As XmlNode, ByVal attibutename As String) As String

        Dim ret As String = String.Empty
        If node IsNot Nothing AndAlso node.Attributes IsNot Nothing Then
            Dim attrib As XmlNode = node.Attributes.GetNamedItem(attibutename)
            If attrib IsNot Nothing Then
                ret = attrib.Value
            End If
        End If
        Return ret
    End Function 'GetAttibuteValue

End Class