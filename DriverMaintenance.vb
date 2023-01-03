Imports System.Data.SqlClient
Imports Truck_Out_Order.My.Resources

Public Class DriverMaintenance

    Dim selection,
    stringFillRequired,
    stringAuthentification,
    stringComplete,
    stringError,
    stringExist As String

    Dim validationCheck As Boolean
    Dim newCheck As Boolean = True
    Private companyNameHeader As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (My.Settings.languageSetting = "fr") Then
            btnCancel.Text = ResourceDriverMaintenanceFrench.btnCancel
            btnNew.Text = ResourceDriverMaintenanceFrench.btnNew
            btnUpdate.Text = ResourceDriverMaintenanceFrench.btnUpdate
            lblActive.Text = ResourceDriverMaintenanceFrench.lblActive
            lblDriverID.Text = ResourceDriverMaintenanceFrench.lblDriverID
            lblDriverMaintenance.Text = ResourceDriverMaintenanceFrench.lblDriverMaintenance
            lblDrivingLicenceValid.Text = ResourceDriverMaintenanceFrench.lblDrivingLicenceValid
            lblDrivingLicense.Text = ResourceDriverMaintenanceFrench.lblDrivingLicense
            lblFullName.Text = ResourceDriverMaintenanceFrench.lblFullName
            lblIcNumber.Text = ResourceDriverMaintenanceFrench.lblICNumber
            lblLegalWorker.Text = ResourceDriverMaintenanceFrench.lblLegalWorker
            lblPmCode.Text = ResourceDriverMaintenanceFrench.lblPMCode
            lblPmRegistrationPlate.Text = ResourceDriverMaintenanceFrench.lblPMRegistrationPlate
            stringAuthentification = ResourceDriverMaintenanceFrench.stringAuthentification
            stringComplete = ResourceDriverMaintenanceFrench.stringComplete
            stringError = ResourceDriverMaintenanceFrench.stringError
            stringExist = ResourceDriverMaintenanceFrench.stringExist
            stringFillRequired = ResourceDriverMaintenanceFrench.stringFillRequired
        Else
            btnCancel.Text = ResourceDriverMaintenance.btnCancel
            btnNew.Text = ResourceDriverMaintenance.btnNew
            btnUpdate.Text = ResourceDriverMaintenance.btnUpdate
            lblActive.Text = ResourceDriverMaintenance.lblActive
            lblDriverID.Text = ResourceDriverMaintenance.lblDriverID
            lblDriverMaintenance.Text = ResourceDriverMaintenance.lblDriverMaintenance
            lblDrivingLicenceValid.Text = ResourceDriverMaintenance.lblDrivingLicenceValid
            lblDrivingLicense.Text = ResourceDriverMaintenance.lblDrivingLicense
            lblFullName.Text = ResourceDriverMaintenance.lblFullName
            lblIcNumber.Text = ResourceDriverMaintenance.lblICNumber
            lblLegalWorker.Text = ResourceDriverMaintenance.lblLegalWorker
            lblPmCode.Text = ResourceDriverMaintenance.lblPMCode
            lblPmRegistrationPlate.Text = ResourceDriverMaintenance.lblPMRegistrationPlate
            stringAuthentification = ResourceDriverMaintenance.stringAuthentification
            stringComplete = ResourceDriverMaintenance.stringComplete
            stringError = ResourceDriverMaintenance.stringError
            stringExist = ResourceDriverMaintenance.stringExist
            stringFillRequired = ResourceDriverMaintenance.stringFillRequired
        End If


        GlobalFunction.TopHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)
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
            MessageBox.Show(stringFillRequired, stringError, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show(stringComplete, stringAuthentification, MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalFunction.backToPage(Admin, Me)
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

            If rd.Item("validationCheck") = True Then
                validationCheck = True
                cbActive.Checked = True
                cbActive.Text = "Active"
            Else
                validationCheck = False
                cbActive.Checked = False
                cbActive.Text = "Inactive"
            End If

        End While
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


End Class