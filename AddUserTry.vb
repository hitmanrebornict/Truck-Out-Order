﻿Imports System.Data.SqlClient
Imports Truck_Out_Order.My.Resources

Public Class AddUserTry

    Dim adminCheck As Boolean
    Dim validationCheck As Boolean
    Dim newCheck As Boolean = True
    Private companyNameHeader As String

    Dim selection,
        deptToRole,
        stringError,
        stringFillRequired,
        stringExist,
        stringComplete,
        stringAuthentification As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If (My.Settings.languageSetting = "fr") Then
            btnAddUser.Text = ResourceAddUserTryFrench.btnAddUser
            btnCancel.Text = ResourceAddUserTryFrench.btnCancel
            btnUpdate.Text = ResourceAddUserTryFrench.btnUpdate
            lblActive.Text = ResourceAddUserTryFrench.lblActive
            lblAdmin.Text = ResourceAddUserTryFrench.lblAdmin
            lblDepartment.Text = ResourceAddUserTryFrench.lblDepartment
            lblPassword.Text = ResourceAddUserTryFrench.lblPassword
            lblUserID.Text = ResourceAddUserTryFrench.lblUserID
            lblUserMaintenance.Text = ResourceAddUserTryFrench.lblUserMaintenance
            lblUsername.Text = ResourceAddUserTryFrench.lblUsername
            stringAuthentification = ResourceAddUserTryFrench.stringAuthentification
            stringComplete = ResourceAddUserTryFrench.stringComplete
            stringError = ResourceAddUserTryFrench.stringError
            stringExist = ResourceAddUserTryFrench.stringError
            stringFillRequired = ResourceAddUserTryFrench.stringFillRequired
        Else
            btnAddUser.Text = ResourceAddUserTry.btnAddUser
            btnCancel.Text = ResourceAddUserTry.btnCancel
            btnUpdate.Text = ResourceAddUserTry.btnUpdate
            lblActive.Text = ResourceAddUserTry.lblActive
            lblAdmin.Text = ResourceAddUserTry.lblAdmin
            lblDepartment.Text = ResourceAddUserTry.lblDepartment
            lblPassword.Text = ResourceAddUserTry.lblPassword
            lblUserID.Text = ResourceAddUserTry.lblUserID
            lblUserMaintenance.Text = ResourceAddUserTry.lblUserMaintenance
            lblUsername.Text = ResourceAddUserTry.lblUsername
            stringAuthentification = ResourceAddUserTry.stringAuthentification
            stringComplete = ResourceAddUserTry.stringComplete
            stringError = ResourceAddUserTry.stringError
            stringExist = ResourceAddUserTry.stringError
            stringFillRequired = ResourceAddUserTry.stringFillRequired
        End If

        GlobalFunction.TopHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)

        cbAdmin.Appearance = Appearance.Button
        cbAdmin.AutoSize = False
        cbAdmin.Size = New Size(100, 40)
        cbActive.Appearance = Appearance.Button
        cbActive.AutoSize = False
        cbActive.Size = New Size(100, 40)
        cmbSelectUserID.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSelectDepartmentID.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRoleID.DropDownStyle = ComboBoxStyle.DropDownList
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT distinct(username) as distinctUsername from Login where username is not null order by username"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbSelectUserID.Items.Add(rd.Item("distinctUsername"))
        End While
        con.Close()

        'con.Open()
        'cmd.CommandText = "SELECT distinct(department) as distinctDepartment from Login where username is not null order by department"
        'rd = cmd.ExecuteReader
        'While rd.Read()
        '    cmbSelectDepartmentID.Items.Add(rd.Item("distinctDepartment"))
        'End While
        'con.Close()

        'con.Open()
        'cmd.CommandText = "SELECT distinct(role_id) as distinctRoleID from Login where username is not null order by role_id"
        'rd = cmd.ExecuteReader
        'While rd.Read()
        '    cmbRoleID.Items.Add(rd.Item("distinctRoleID"))
        'End While
        'con.Close()

    End Sub



    Private Sub cmbSelectUserID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectUserID.SelectedIndexChanged

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "select * from login where username = @username"
        cmd.Parameters.AddWithValue("@username", cmbSelectUserID.Text)

        rd = cmd.ExecuteReader

        While rd.Read()
            If IsDBNull(rd.Item("fullUsername")) Then
                tbSelectUsername.Text = ""
            Else
                tbSelectUsername.Text = rd.Item("fullUsername")
            End If

            cmbSelectDepartmentID.Text = rd.Item("Department")
            tbPassword.Text = rd.Item("Password")
            cmbRoleID.Text = rd.Item("role_id")
            If rd.Item("validationCheck") = True Then
                cbActive.Checked = True
                cbActive.Text = "Active"
            Else
                cbActive.Checked = False
                cbActive.Text = "Inactive"
            End If

            If rd.Item("adminCheck") = True Then
                cbAdmin.Checked = True
                cbAdmin.Text = "Admin"
            Else
                cbAdmin.Checked = False
                cbAdmin.Text = "Non-Admin"
            End If

        End While
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'save button
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If cmbSelectUserID.Text = "" Or tbPassword.Text = "" Or cmbSelectDepartmentID.Text = "" Then
            MessageBox.Show(stringFillRequired, stringError, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case cmbSelectDepartmentID.SelectedItem
                Case "IT"
                    deptToRole = 1
                Case "Shipping"
                    deptToRole = 2
                Case "Warehouse"
                    deptToRole = 3
                Case "Warehouse Checking"
                    deptToRole = 4
                Case "Security"
                    deptToRole = 5
                Case "super user"
                    deptToRole = 6


            End Select


            If newCheck = True Then
                If deptToRole = 6 And My.Settings.role_id <> 1 Then
                    MessageBox.Show("Sa can only be created by IT department.", stringError, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cmd.CommandText = "Update Login set username = @username, fullUsername = @fullUsername, password = @password, department = @department,validationCheck = @validationCheck, adminCheck = @adminCheck, role_id = @role_id where username = @username"
                    cmd.Parameters.AddWithValue("@username", cmbSelectUserID.Text)
                    cmd.Parameters.AddWithValue("@fullUsername", tbSelectUsername.Text)
                    cmd.Parameters.AddWithValue("@department", cmbSelectDepartmentID.Text)
                    cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                    cmd.Parameters.AddWithValue("@adminCheck", adminCheck)
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text)
                    cmd.Parameters.AddWithValue("@role_id", deptToRole)
                    con.Close()
                    con.Open()
                    rd = cmd.ExecuteReader
                    MessageBox.Show(stringComplete, stringAuthentification, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                cmd.CommandText = "select * from login where username = @username"
                cmd.Parameters.AddWithValue("@username", cmbSelectUserID.Text)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows() Then
                    MessageBox.Show(stringExist, stringError, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf deptToRole = 6 And My.Settings.role_id <> 1 Then
                    MessageBox.Show("Sa can only be created by IT department.", stringError, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cmd.CommandText = ("Insert into Login(username,fullUsername,password,department,role_id,validationCheck,adminCheck) values(@username1,@fullUsername,@password,@department,@role_id,@validationCheck,@adminCheck)")
                    cmd.Parameters.AddWithValue("@username1", cmbSelectUserID.Text)
                    cmd.Parameters.AddWithValue("@fullUsername", tbSelectUsername.Text)
                    cmd.Parameters.AddWithValue("@department", cmbSelectDepartmentID.Text)
                    cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                    cmd.Parameters.AddWithValue("@adminCheck", adminCheck)
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text)
                    cmd.Parameters.AddWithValue("@role_id", deptToRole)
                    con.Close()
                    con.Open()
                    rd = cmd.ExecuteReader
                    MessageBox.Show(stringComplete, stringAuthentification, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If



            GlobalFunction.backToPage(Admin, Me)
        End If

    End Sub

    Private Sub cbAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles cbAdmin.CheckedChanged
        If cbAdmin.Checked = True Then
            cbAdmin.Text = "Non-Admin"
            adminCheck = False
        Else
            cbAdmin.Text = "Admin"
            adminCheck = True
        End If
    End Sub

    Private Sub cbActive_CheckedChanged(sender As Object, e As EventArgs) Handles cbActive.CheckedChanged
        If cbActive.Checked = True Then
            cbActive.Text = "Active"
            validationCheck = True
        Else
            cbActive.Text = "Inactive"
            validationCheck = False
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        cmbSelectUserID.DropDownStyle = ComboBoxStyle.DropDown
        cmbSelectUserID.Text = ""
        newCheck = False
        cmbSelectUserID.Visible = True
        'tbNewUserID.Visible = True
        tbSelectUsername.Text = ""
        cmbSelectDepartmentID.Text = ""
        cmbRoleID.Text = ""
        tbPassword.Text = ""
        cbActive.Checked = False
        cbActive.Checked = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Admin As New Admin
        Admin.Show()
        Me.Close()
    End Sub


End Class
