
Imports System.Data.SqlClient

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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String = "select role_id where username = '" + tbUsername.Text + "'"
        Dim validationCheck As String
        Dim selectString = "SELECT Role_id,Username,Password,validationCheck,department,adminCheck,fullUserName from Login"
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        'con.Open()
        'cmd.CommandText = "SELECT CompanyName From Company WHERE companyID = 1"
        'rd = cmd.ExecuteReader
        ''If rd.HasRows() Then
        ''    My.Settings.companyNameHeader = rd.Item("CompanyName")
        ''Else
        ''    My.Settings.companyNameHeader = "Guan Chong Cocoa Manufacturer Sdn Bhd"
        ''End If

        'While rd.Read()
        '    If IsDBNull(rd.Item("CompanyName")) Then
        '        My.Settings.companyNameHeader = rd.Item("CompanyName")
        '    Else
        '        My.Settings.companyNameHeader = "Guan Chong Cocoa Manufacturer Sdn Bhd"
        '    End If

        'End While

        'con.Close()
        con.Open()
        If tbUsername.Text = "" Or tbPassword.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            'cmd.CommandText = "SELECT Role_id,Username,Password,validationCheck from Login where Username = '" + tbUsername.Text + "' and Password ='" + tbPassword.Text + "'"
            cmd.CommandText = selectString & " where Username = '" + tbUsername.Text + "' and Password ='" + tbPassword.Text + "'"
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

                If validationCheck = "NO" Then
                    MessageBox.Show("User is disabled", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbUsername.Text = ""
                tbPassword.Text = ""
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTooSystem.Left = (Me.Width - lblTooSystem.Width) / 2
        lblLogin.Location = New Point(pnlLogin.Width \ 2 - lblLogin.Width \ 2, lblLogin.Location.Y)
        tbUsername.Location = New Point(pnlLogin.Width \ 2 - tbUsername.Width \ 2, tbUsername.Location.Y)
        btnLogin.Location = New Point(pnlLogin.Width \ 2 - btnLogin.Width \ 2, btnLogin.Location.Y)
        pbGCB.Location = New Point(Me.Width \ 2 - pbGCB.Width \ 2, pbGCB.Location.Y)
        pnlLogin.Left = (pnlLogin.Parent.Width \ 2) - (pnlLogin.Width \ 2)
        pbGCB.Left = (pbGCB.Parent.Width \ 2) - (pbGCB.Width \ 2)


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCancel.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbPassword.Focus()
        End If
    End Sub


End Class
