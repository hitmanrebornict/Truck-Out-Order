
Imports System.Data.SqlClient
Imports System.Globalization

Imports System.Threading
Imports Microsoft.VisualBasic.ApplicationServices
Imports Truck_Out_Order.My.Resources

Public Class Login

    'Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) _
    '    As Boolean
    '    If (keyData = Keys.Enter) Then
    '        SendKeys.Send("{TAB}")
    '        'Parent.SelectNextControl(Me, True, True, True, True)
    '        Return True
    '    End If
    '    Return MyBase.ProcessCmdKey(msg, keyData)
    'End Function

    Dim stringRequired,
        stringAuthentificationError,
        stringUserDisabled,
    stringDoNotMatch As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        Dim validationCheck As Boolean
        Dim selectString = "SELECT Role_id,Username,Password,validationCheck,department,adminCheck,fullUserName from Login"
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con

        con.Open()
        If tbUsername.Text = "" Or tbPassword.Text = "" Then
            MessageBox.Show(stringRequired, stringAuthentificationError, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            'cmd.CommandText = "SELECT Role_id,Username,Password,validationCheck from Login where Username = '" + tbUsername.Text + "' and Password ='" + tbPassword.Text + "'"
            cmd.CommandText = selectString & " where Username = @username and Password = @password"
            cmd.Parameters.AddWithValue("@username", tbUsername.Text)
            cmd.Parameters.AddWithValue("@password", tbPassword.Text)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                My.Settings.role_id = rd.Item("Role_ID")
                validationCheck = rd.Item("validationCheck")
                My.Settings.departmentName = rd.Item("department")
                My.Settings.adminCheck = rd.Item("adminCheck")
                My.Settings.username = rd.Item("username")
                If IsDBNull(rd.Item("fullUserName")) Then
                    My.Settings.fullName = ""
                Else
                    My.Settings.fullName = rd.Item("fullUserName")
                End If


                Dim Admin As New Admin
                Dim User As New NormalUserPage

                If validationCheck = False Then
                    MessageBox.Show(stringUserDisabled, stringAuthentificationError, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Select Case My.Settings.adminCheck
                        Case True
                            Admin.Show()
                        Case False
                            User.Show()
                    End Select
                End If
                Me.Close()

                tbUsername.Text = ""
                tbPassword.Text = ""
                tbUsername.Focus()

            Else
                MessageBox.Show(stringDoNotMatch, stringAuthentificationError, MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbUsername.Text = ""
                tbPassword.Text = ""
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (My.Settings.languageSetting = "fr") Then
            lblTooSystem.Text = ResourceLoginFrench.lblTOOSystem
            lblLogin.Text = ResourceLoginFrench.lblLogin
            lblUsername.Text = ResourceLoginFrench.lblUsername
            lblPassword.Text = ResourceLoginFrench.lblPassword
            btnLogin.Text = ResourceLoginFrench.btnLogin
            btnCancel.Text = ResourceLoginFrench.btnCancel
            stringRequired = ResourceLoginFrench.stringRequired
            stringAuthentificationError = ResourceLoginFrench.stringAuthentificationError
            stringUserDisabled = ResourceLoginFrench.stringUserDisabled
            stringDoNotMatch = ResourceLoginFrench.stringDoNotMatch
            cmbLanguage.SelectedIndex = 1
        Else
            lblTooSystem.Text = ResourceLogin.lblTOOSystem
            lblLogin.Text = ResourceLogin.lblLogin
            lblUsername.Text = ResourceLogin.lblUsername
            lblPassword.Text = ResourceLogin.lblPassword
            btnLogin.Text = ResourceLogin.btnLogin
            btnCancel.Text = ResourceLogin.btnCancel
            stringRequired = ResourceLogin.stringRequired
            stringAuthentificationError = ResourceLogin.stringAuthentificationError
            stringUserDisabled = ResourceLogin.stringUserDisabled
            stringDoNotMatch = ResourceLogin.stringDoNotMatch
            cmbLanguage.SelectedIndex = 0
        End If

        Dim Admin As New Admin
        Dim User As New NormalUserPage

        If My.Settings.username <> "" Then
            Select Case My.Settings.adminCheck
                Case True
                    Admin.Show()
                Case False
                    User.Show()
            End Select
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCancel.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbPassword.Focus()
        End If
    End Sub

    Private Sub cmbLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLanguage.SelectedIndexChanged
        Select Case cmbLanguage.SelectedItem
            Case "English"
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-MY")
                My.Settings.languageSetting = "en"
            Case "French"
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
                My.Settings.languageSetting = "fr"
        End Select
        Dim currentUICulture As CultureInfo = Thread.CurrentThread.CurrentUICulture


        If (currentUICulture.ToString() = "fr-FR") Then
            lblTooSystem.Text = ResourceLoginFrench.lblTOOSystem
            lblLogin.Text = ResourceLoginFrench.lblLogin
            lblUsername.Text = ResourceLoginFrench.lblUsername
            lblPassword.Text = ResourceLoginFrench.lblPassword
            btnLogin.Text = ResourceLoginFrench.btnLogin
            btnCancel.Text = ResourceLoginFrench.btnCancel
            stringRequired = ResourceLoginFrench.stringRequired
            stringAuthentificationError = ResourceLoginFrench.stringAuthentificationError
            stringUserDisabled = ResourceLoginFrench.stringUserDisabled
            stringDoNotMatch = ResourceLoginFrench.stringDoNotMatch
        Else
            lblTooSystem.Text = ResourceLogin.lblTOOSystem
            lblLogin.Text = ResourceLogin.lblLogin
            lblUsername.Text = ResourceLogin.lblUsername
            lblPassword.Text = ResourceLogin.lblPassword
            btnLogin.Text = ResourceLogin.btnLogin
            btnCancel.Text = ResourceLogin.btnCancel
            stringRequired = ResourceLogin.stringRequired
            stringAuthentificationError = ResourceLogin.stringAuthentificationError
            stringUserDisabled = ResourceLogin.stringUserDisabled
            stringDoNotMatch = ResourceLogin.stringDoNotMatch
        End If


    End Sub


End Class
