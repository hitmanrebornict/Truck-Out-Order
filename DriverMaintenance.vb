Imports System.Data.SqlClient

Public Class DriverMaintenance

    Dim selection As String
    Dim validationCheck As String
    Dim newCheck As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & My.Settings.fullName & vbNewLine & "Department of " & My.Settings.departmentName)
        lblCompanyNameHeader.Text = My.Settings.companyNameHeader
        cbActive.Appearance = Appearance.Button
        cbActive.AutoSize = False
        cbActive.Size = New Size(100, 40)
        cmbFullName.DropDownStyle = ComboBoxStyle.DropDownList
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT distinct(Full_Name) as Driver_Name from Driver_Info  where Full_Name is not null order by Full_Name"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbFullName.Items.Add(rd.Item("Driver_Name"))
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Cancel Button
        Dim Admin As New Admin
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'New button 
        newCheck = False
        cmbFullName.DropDownStyle = ComboBoxStyle.DropDown
        cmbFullName.Text = ""
        tbDriverID.Text = ""
        tbDrivingLicense.Text = ""
        tbIcNumber.Text = ""
        tbLegalWorker.Text = ""
        tbPmCode.Text = ""
        tbRegistrationPlate.Text = ""
        dtpLicenseValidDate.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Save Button
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If tbIcNumber.Text = "" Or tbDriverID.Text = "" Or tbDrivingLicense.Text = "" Or tbLegalWorker.Text = "" Or tbPmCode.Text = "" Or tbRegistrationPlate.Text = "" Or cmbFullName.Text = "" Or dtpLicenseValidDate.Text = "" Then
            MessageBox.Show("Please FIll The Required Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If newCheck = True Then
                cmd.CommandText = "update driver_info set ic_number = @ic_number, pm_code = @pm_code, pm_registration_plate = @pm_registration_plate, driver_id = @driver_id, driving_licence = @driving_licence, legal_worker = @legal_worker, driving_licence_validity = @driving_licence_validity, validationCheck = @validationCheck where full_name = @full_name"
            Else
                cmd.CommandText = "INSERT INTO Driver_Info (Full_Name,IC_Number,PM_Code,PM_Registration_Plate,Driver_ID,Driving_Licence,Driving_Licence_Validity,Legal_Worker,validationCheck) values (@full_name_tb,@ic_number,@pm_code,@pm_registration_plate,@driver_id,@driving_licence,@driving_licence_validity,@legal_worker,@validationCheck)"
            End If
            cmd.Parameters.AddWithValue("@ic_number", tbIcNumber.Text)
            cmd.Parameters.AddWithValue("@pm_code", tbPmCode.Text)
            cmd.Parameters.AddWithValue("@pm_registration_plate", tbRegistrationPlate.Text)
            cmd.Parameters.AddWithValue("@driver_id", tbDriverID.Text)
            cmd.Parameters.AddWithValue("@driving_licence", tbDrivingLicense.Text)
            cmd.Parameters.AddWithValue("@legal_worker", tbLegalWorker.Text)
            cmd.Parameters.AddWithValue("@validationCheck", validationCheck)
            cmd.Parameters.AddWithValue("@driving_licence_validity", dtpLicenseValidDate.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@full_name", cmbFullName.Text)
            cmd.Parameters.AddWithValue("@full_name_tb", cmbFullName.Text)
            rd = cmd.ExecuteReader
            MessageBox.Show("Update Complete", "Authentication ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCancel.PerformClick()
        End If

    End Sub


    Private Sub cmbFullName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFullName.SelectedIndexChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from driver_info where full_name = @fullName"
        cmd.Parameters.AddWithValue("@fullName", cmbFullName.Text)
        rd = cmd.ExecuteReader
        While rd.Read()
            tbDriverID.Text = rd.Item("Driver_ID")
            tbDrivingLicense.Text = rd.Item("Driving_Licence")
            tbIcNumber.Text = rd.Item("IC_Number")
            tbLegalWorker.Text = rd.Item("legal_Worker")
            tbPmCode.Text = rd.Item("PM_Code")
            tbRegistrationPlate.Text = rd.Item("PM_Registration_Plate")
            If IsDBNull(rd.Item("Driving_Licence_Validity")) Then
                dtpLicenseValidDate.Text = ""
            Else
                dtpLicenseValidDate.Value = rd.Item("Driving_Licence_Validity")
            End If

            If rd.Item("validationCheck") = "YES" Then
                validationCheck = "YES"
                cbActive.Checked = True
                cbActive.Text = "Active"
            Else
                validationCheck = "NO"
                cbActive.Checked = False
                cbActive.Text = "Inactive"
            End If

        End While
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


End Class