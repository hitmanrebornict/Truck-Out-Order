Imports System.Data.SqlClient
Imports Truck_Out_Order.My.Resources

Public Class CompanyMaintenance

    Dim selection,
    stringCurrentMaxNum,
    stringFillRequired,
    stringError,
    stringComplete,
    stringAuthentication,
    stringDelete,
    stringCheckDelete,
    stringErrorLessThanExistingNumber,
    stringUpdateFailed,
    stringNewTOONumberIs,
    stringDeleteHeader As String

    Dim newCheck As Boolean = True
    Dim maxTOONumber, age As Integer
    Dim companyID As Integer = 1
    Dim nullCheck As Boolean = False
    Private companyNameHeader As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If (My.Settings.languageSetting = "fr") Then
            btnCancel.Text = ResourceCompanyMaintenanceFrench.btnCancel
            btnDel.Text = ResourceCompanyMaintenanceFrench.btnDel
            btnNew.Text = ResourceCompanyMaintenanceFrench.btnNew
            btnSave.Text = ResourceCompanyMaintenanceFrench.btnSave
            btnTOOSave.Text = ResourceCompanyMaintenanceFrench.btnTOOSave
            lblAddressLine1.Text = ResourceCompanyMaintenanceFrench.lblAddressLine1
            lblAddressLine2.Text = ResourceCompanyMaintenanceFrench.lblAddressLine2
            lblCity.Text = ResourceCompanyMaintenanceFrench.lblCity
            lblCompanyMaintenance.Text = ResourceCompanyMaintenanceFrench.lblCompanyMaintenance
            lblCompanyRegistrationNo.Text = ResourceCompanyMaintenanceFrench.lblCompanyRegistrationNo
            lblCountry.Text = ResourceCompanyMaintenanceFrench.lblCountry
            lblFax.Text = ResourceCompanyMaintenanceFrench.lblFax
            lblCompanyFullName.Text = ResourceCompanyMaintenanceFrench.lblCompanyFullName
            lblNewNumber.Text = ResourceCompanyMaintenanceFrench.lblNewNumber
            lblPostalCode.Text = ResourceCompanyMaintenanceFrench.lblPostalCode
            lblState.Text = ResourceCompanyMaintenanceFrench.lblState
            lblTelephone.Text = ResourceCompanyMaintenanceFrench.lblTelephone
            stringAuthentication = ResourceCompanyMaintenanceFrench.stringAuthentication
            stringCheckDelete = ResourceCompanyMaintenanceFrench.stringCheckDelete
            stringComplete = ResourceCompanyMaintenanceFrench.stringComplete
            stringCurrentMaxNum = ResourceCompanyMaintenanceFrench.stringCurrentMaxNum
            stringDelete = ResourceCompanyMaintenanceFrench.stringDelete
            stringError = ResourceCompanyMaintenanceFrench.stringError
            stringErrorLessThanExistingNumber = ResourceCompanyMaintenanceFrench.stringErrorLessThanExistingNumber
            stringFillRequired = ResourceCompanyMaintenanceFrench.stringFillRequired
            stringNewTOONumberIs = ResourceCompanyMaintenanceFrench.stringNewTOONumberIs
            stringUpdateFailed = ResourceCompanyMaintenanceFrench.stringUpdateFailed
            stringDeleteHeader = ResourceCompanyMaintenanceFrench.btnDel
        Else
            btnCancel.Text = ResourceCompanyMaintenance.btnCancel
            btnDel.Text = ResourceCompanyMaintenance.btnDel
            btnNew.Text = ResourceCompanyMaintenance.btnNew
            btnSave.Text = ResourceCompanyMaintenance.btnSave
            btnTOOSave.Text = ResourceCompanyMaintenance.btnTOOSave
            lblAddressLine1.Text = ResourceCompanyMaintenance.lblAddressLine1
            lblAddressLine2.Text = ResourceCompanyMaintenance.lblAddressLine2
            lblCity.Text = ResourceCompanyMaintenance.lblCIty
            lblCompanyMaintenance.Text = ResourceCompanyMaintenance.lblCompanyMaintenance
            lblCompanyRegistrationNo.Text = ResourceCompanyMaintenance.lblCompanyRegistrationNo
            lblCountry.Text = ResourceCompanyMaintenance.lblCountry
            lblFax.Text = ResourceCompanyMaintenance.lblFax
            lblCompanyFullName.Text = ResourceCompanyMaintenance.lblCompanyFullName
            lblNewNumber.Text = ResourceCompanyMaintenance.lblNewNumber
            lblPostalCode.Text = ResourceCompanyMaintenance.lblPostalCode
            lblState.Text = ResourceCompanyMaintenance.lblState
            lblTelephone.Text = ResourceCompanyMaintenance.lblTelephone
            stringAuthentication = ResourceCompanyMaintenance.stringAuthentication
            stringCheckDelete = ResourceCompanyMaintenance.stringCheckDelete
            stringComplete = ResourceCompanyMaintenance.stringComplete
            stringCurrentMaxNum = ResourceCompanyMaintenance.stringCurrentMaxNum
            stringDelete = ResourceCompanyMaintenance.stringDelete
            stringError = ResourceCompanyMaintenance.stringError
            stringErrorLessThanExistingNumber = ResourceCompanyMaintenance.stringErrorLessThanExistingNumber
            stringFillRequired = ResourceCompanyMaintenance.stringFillRequired
            stringNewTOONumberIs = ResourceCompanyMaintenance.stringNewTOONumberIs
            stringUpdateFailed = ResourceCompanyMaintenance.stringUpdateFailed
            stringDeleteHeader = ResourceCompanyMaintenance.btnDel
        End If



        GlobalFunction.TopHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)
        cmbCompanyName.DropDownStyle = ComboBoxStyle.DropDownList
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT distinct(CompanyName) as CompanyName from Company  where CompanyName is not null order by CompanyName"
        rd = cmd.ExecuteReader
        While rd.Read()
            If IsDBNull(rd.Item("CompanyName")) Then
                btnNew.Enabled = True
                nullCheck = True
            Else
                cmbCompanyName.Items.Add(rd.Item("CompanyName"))
                btnNew.Enabled = False
            End If

        End While
        con.Close()


        con.Open()
        cmd.CommandText = "SELECT max(TOO_Number) as maxTOONumber from details where TOO_Number is not null"
        rd = cmd.ExecuteReader
        rd.Read()
        If IsDBNull(rd.Item(maxTOONumber)) Then
            maxTOONumber = 0
        Else
            maxTOONumber = rd.Item("maxTOONumber")
        End If

        My.Settings.newTOONumber = maxTOONumber

        'Find Current Max TOO Number
        lblCurrentMaxNum.Text = stringCurrentMaxNum & " " & My.Settings.newTOONumber & "."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'New button 
        newCheck = False
        cmbCompanyName.DropDownStyle = ComboBoxStyle.DropDown
        cmbCompanyName.Text = ""
        tbState.Text = ""
        tbAddressLine1.Text = ""
        tbAddressLine2.Text = ""
        tbCity.Text = ""
        tbCountry.Text = ""
        tbFax.Text = ""
        tbPostalCode.Text = ""
        tbRegistrationNo.Text = ""
        tbTelephone.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save Button
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If tbAddressLine1.Text = "" Or tbState.Text = "" Or tbCity.Text = "" Or cmbCompanyName.Text = "" Or tbFax.Text = "" Or tbPostalCode.Text = "" Or tbRegistrationNo.Text = "" Or tbTelephone.Text = "" Or tbCountry.Text = "" Then
            MessageBox.Show(stringFillRequired, stringError, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If newCheck = True Then
                cmd.CommandText = "update Company set CompanyName = @CompanyName, AddressLine1 = @AddressLine1, AddressLine2 = @AddressLine2, City = @City, State = @State, Country = @Country, PostalCode = @PostalCode, Phone = @Phone, Fax = @Fax, RegistrationNum = @RegistrationNum where companyName = @companyName"
            Else
                cmd.CommandText = "INSERT INTO Company (CompanyName,AddressLine1,AddressLine2,City,State,Country,PostalCode,Phone,Fax,RegistrationNum,CompanyID) values (@CompanyName,@AddressLine1,@AddressLine2,@City,@State,@Country,@PostalCode,@Phone,@Fax,@RegistrationNum,@CompanyID)"
            End If
            cmd.Parameters.AddWithValue("@CompanyName", cmbCompanyName.Text)
            cmd.Parameters.AddWithValue("@AddressLine1", tbAddressLine1.Text)
            cmd.Parameters.AddWithValue("@AddressLine2", tbAddressLine2.Text)
            cmd.Parameters.AddWithValue("@City", tbCity.Text)
            cmd.Parameters.AddWithValue("@State", tbState.Text)
            cmd.Parameters.AddWithValue("@Country", tbCountry.Text)
            cmd.Parameters.AddWithValue("@PostalCode", tbPostalCode.Text)
            cmd.Parameters.AddWithValue("@Phone", tbTelephone.Text)
            cmd.Parameters.AddWithValue("@Fax", tbFax.Text)
            cmd.Parameters.AddWithValue("@RegistrationNum", tbRegistrationNo.Text)
            cmd.Parameters.AddWithValue("@companyID", companyID)
            rd = cmd.ExecuteReader
            MessageBox.Show(stringComplete, stringAuthentication, MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalFunction.backToPage(Admin, Me)
        End If

    End Sub


    Private Sub cmbFullName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompanyName.SelectedIndexChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from company where companyName = @companyName"
        cmd.Parameters.AddWithValue("@companyName", cmbCompanyName.Text)
        rd = cmd.ExecuteReader
        While rd.Read()
            tbAddressLine1.Text = rd.Item("AddressLine1")
            tbAddressLine2.Text = rd.Item("AddressLine2")
            tbCity.Text = rd.Item("City")
            tbState.Text = rd.Item("State")
            tbCountry.Text = rd.Item("Country")
            tbPostalCode.Text = rd.Item("PostalCode")
            tbTelephone.Text = rd.Item("Phone")
            tbFax.Text = rd.Item("Fax")
            tbRegistrationNo.Text = rd.Item("RegistrationNum")

        End While
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If MsgBox(stringCheckDelete, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, stringDeleteHeader) = Windows.Forms.DialogResult.Yes Then
            cmd.CommandText = "Delete from Company where CompanyName = @CompanyName"
            cmd.Parameters.AddWithValue("@companyName", cmbCompanyName.Text)
            rd = cmd.ExecuteReader
            MessageBox.Show(stringDelete, stringAuthentication, MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalFunction.backToPage(Admin, Me)
        Else

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Admin As New Admin
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnTOOSave.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        Try
            If Integer.Parse(tbTOO.Text) < maxTOONumber Then
                MessageBox.Show(stringErrorLessThanExistingNumber, stringUpdateFailed, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.CommandText = "Insert into details(TOO_Number) values (@TOO_Number)"
                cmd.Parameters.AddWithValue("@TOO_Number", tbTOO.Text)
                rd = cmd.ExecuteReader
                MessageBox.Show(stringCurrentMaxNum & tbTOO.Text, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, stringUpdateFailed, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class