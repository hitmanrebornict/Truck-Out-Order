﻿Imports System.Data.SqlClient

Public Class AddUserTry

    Public username As String
    Public role_id As Integer
    Public departmentName As String
    Public adminCheck1 As Boolean
    Dim adminCheck As Boolean
    Dim validationCheck As String
    Dim selection As String
    Dim newCheck As Boolean = True
    Dim deptToRole As String
    Public fullName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & fullName & vbNewLine & "Department of " & departmentName)
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

        con.Open()
        cmd.CommandText = "SELECT distinct(department) as distinctDepartment from Login where username is not null order by department"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbSelectDepartmentID.Items.Add(rd.Item("distinctDepartment"))
        End While
        con.Close()

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
            If rd.Item("validationCheck") = "YES" Then
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'save button
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If cmbSelectUserID.Text = "" Or tbPassword.Text = "" Or cmbSelectDepartmentID.Text = "" Then
            MessageBox.Show("Please Fill The Required Field", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case cmbSelectDepartmentID.Text
                Case "IT"
                    deptToRole = 1
                Case "shipping"
                    deptToRole = 20
                Case "Warehouse"
                    deptToRole = 3
                Case "Warehouse Checking"
                    deptToRole = 4
                Case "Security"
                    deptToRole = 5

            End Select
            If newCheck = True Then
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
            Else
                cmd.CommandText = "select * from login where username = @username"
                cmd.Parameters.AddWithValue("@username", cmbSelectUserID.Text)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows() Then
                    MessageBox.Show("The user is already exist, please use different username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    btnCancel.PerformClick()
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
                End If
            End If


            MessageBox.Show("Update Complete", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCancel.PerformClick()
        End If
    End Sub

    Private Sub cbAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles cbAdmin.CheckedChanged
        If cbAdmin.Checked = True Then
            cbAdmin.Text = "Admin"
            adminCheck = True
        Else
            cbAdmin.Text = "Non-Admin"
            adminCheck = False
        End If
    End Sub

    Private Sub cbActive_CheckedChanged(sender As Object, e As EventArgs) Handles cbActive.CheckedChanged
        If cbActive.Checked = True Then
            cbActive.Text = "Active"
            validationCheck = "YES"
        Else
            cbActive.Text = "Inactive"
            validationCheck = "NO"
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
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
        Admin.username = Me.username
        Admin.role_id = Me.role_id
        Admin.departmentName = Me.departmentName
        Admin.adminCheck = Me.adminCheck1
        Admin.fullName = Me.fullName
        Admin.Show()
        Me.Close()
    End Sub


End Class
