Imports System.Data.SqlClient

Public Class FieldMaintenance
    Public username As String
    Public role_id As Integer
    Public departmentName As String
    Public adminCheck As Boolean = True
    Public companyNameHeader As String
    Dim operation As String
    Dim FieldSelection As String
    Dim newCheck As Boolean = True
    Dim validationCheck As String
    Public fullName As String
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rd As SqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & fullName & vbNewLine & "Department of " & departmentName)
        cmbField.DropDownStyle = ComboBoxStyle.DropDownList
        cmbShortname.DropDownStyle = ComboBoxStyle.DropDownList
        cbActive.Appearance = Appearance.Button
        cbActive.AutoSize = False
        cbActive.Size = New Size(100, 40)
        lblCompanyNameHeader.Text = companyNameHeader
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShortname.SelectedIndexChanged
        'select short name
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        Select Case cmbField.Text
            Case "Company"
                cmd.CommandText = "SELECT * from details where company_name = @company_name"
                cmd.Parameters.AddWithValue("@company_name", cmbShortname.Text)
            Case "Loading Port"
                cmd.CommandText = "SELECT * from details where loading_port = @loading_port"
                cmd.Parameters.AddWithValue("@loading_port", cmbShortname.Text)
            Case "Container Size"
                cmd.CommandText = "SELECT * from details where container_size = @container_size"
                cmd.Parameters.AddWithValue("@container_size", cmbShortname.Text)
            Case "Warehouse Location"
                cmd.CommandText = "SELECT * from details where warehouse_location = @warehouse_location"
                cmd.Parameters.AddWithValue("@warehouse_location", cmbShortname.Text)
        End Select

        rd = cmd.ExecuteReader
        While rd.Read()
            If IsDBNull(rd.Item("full_name")) Then
                tbLongName.Text = ""
            Else
                tbLongName.Text = rd.Item("full_name")
            End If

            If rd.Item("validationCheck") = "YES" Then
                cbActive.Checked = True
                cbActive.Text = "Active"
            Else
                cbActive.Checked = False
                cbActive.Text = "Inactive"
            End If
        End While
        con.Close()
    End Sub


    Private Sub cmbField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbField.SelectedIndexChanged
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmbShortname.Items.Clear()

        Select Case cmbField.Text
            Case "Company"
                lblTitle.Text = "Company Maintenance"
                cmd.CommandText = "SELECT distinct(company_name) as r from details where company_name is not null order by company_name"
            Case "Loading Port"
                lblTitle.Text = "Loading Port Maintenance"
                cmd.CommandText = "SELECT distinct(loading_port) as r from details where loading_port is not null order by loading_port"
            Case "Container Size"
                lblTitle.Text = "Container Size Maintenance"
                cmd.CommandText = "SELECT distinct(container_size) as r from details where container_size is not null order by container_size"
            Case "Warehouse Location"
                lblTitle.Text = "Warehouse Location Maintenance"
                cmd.CommandText = "SELECT distinct(warehouse_location) as r from details where warehouse_location is not null order by warehouse_location"
        End Select
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbShortname.Items.Add(rd.Item("r"))
        End While
        con.Close()
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


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' save button 
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If cmbField.Text = "" Or cmbShortname.Text = "" Then
            MessageBox.Show("Please Fill All The Required Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Select Case cmbField.Text
                Case "Company"
                    If newCheck = True Then
                        cmd.CommandText = "Update details set full_name = @fullName , validationCheck = @validationCheck where company_name = @company_name1"
                        cmd.Parameters.AddWithValue("@company_name1", cmbShortname.Text)
                        cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                        cmd.Parameters.AddWithValue("@fullname", tbLongName.Text)
                    Else
                        cmd.CommandText = "Insert into details(company_name, full_name,validationCheck) values(@company_name1,@fullname,@validationCheck)"
                        cmd.Parameters.AddWithValue("@company_name1", cmbShortname.Text)
                        cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                        cmd.Parameters.AddWithValue("@fullname", tbLongName.Text)
                    End If
                Case "Loading Port"
                    If newCheck = True Then
                        cmd.CommandText = "Update details set full_name = @fullname , validationCheck = @validationCheck where Loading_Port = @loading_port "
                        cmd.Parameters.AddWithValue("@loading_port", cmbShortname.Text)
                        cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                        cmd.Parameters.AddWithValue("@fullname", tbLongName.Text)
                    Else
                        cmd.CommandText = "Insert into details(loading_port, full_name,validationCheck) values(@loading_port,@fullname,@validationCheck)"
                        cmd.Parameters.AddWithValue("@loading_port", cmbShortname.Text)
                        cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                        cmd.Parameters.AddWithValue("@fullname", tbLongName.Text)
                    End If
                Case "Warehouse Location"
                    If newCheck = True Then
                        cmd.CommandText = "Update details set full_name = @fullname , validationCheck = @validationCheck where Warehouse_Location = @warehouse_location"
                        cmd.Parameters.AddWithValue("@warehouse_location", cmbShortname.Text)
                        cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                        cmd.Parameters.AddWithValue("@fullname", tbLongName.Text)
                    Else
                        cmd.CommandText = "Insert into details(warehouse_location, full_name,validationCheck) values(@warehouse_location,@fullname,@validationCheck)"
                        cmd.Parameters.AddWithValue("@warehouse_location", cmbShortname.Text)
                        cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                        cmd.Parameters.AddWithValue("@fullname", tbLongName.Text)
                    End If
                Case "Container Size"
                    If newCheck = True Then
                        cmd.CommandText = "Update details set validationCheck = @validationCheck where container_size = @container_size"
                        cmd.Parameters.AddWithValue("@container_size", cmbShortname.Text)
                        cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                    Else
                        cmd.CommandText = "Insert into details(container_size,validationCheck) values(@container_size,@validationCheck)"
                        cmd.Parameters.AddWithValue("@container_size", cmbShortname.Text)
                        cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
                    End If
            End Select
            rd = cmd.ExecuteReader
            MessageBox.Show("Update Complete", "Authentication ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCancel.PerformClick()

        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        cmbShortname.DropDownStyle = ComboBoxStyle.DropDown
        cmbShortname.Text = ""
        cmbField.Text = ""
        cmbShortname.Text = ""
        tbLongName.Text = ""
        cbActive.Checked = False
        newCheck = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Admin As New Admin
        Admin.username = Me.username
        Admin.role_id = Me.role_id
        Admin.departmentName = Me.departmentName
        Admin.adminCheck = Me.adminCheck
        Admin.fullName = Me.fullName
        Admin.companyNameHeader = Me.companyNameHeader
        Admin.Show()
        Me.Close()
    End Sub
End Class