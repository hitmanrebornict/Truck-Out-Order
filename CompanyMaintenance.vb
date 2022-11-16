Imports System.Data.SqlClient

Public Class CompanyMaintenance

    Public username As String
    Public role_id As Integer
    Public departmentName As String
    Public adminCheck As Boolean = True
    Public companyNameHeader As String
    Dim selection As String
    Dim validationCheck As String
    Dim newCheck As Boolean = True
    Public fullName As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & fullName & vbNewLine & "Department of " & departmentName)
        lblCompanyNameHeader.Text = companyNameHeader
        cmbCompanyName.DropDownStyle = ComboBoxStyle.DropDownList
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim age As Integer
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT distinct(CompanyName) as CompanyName from Company  where CompanyName is not null order by CompanyName"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbCompanyName.Items.Add(rd.Item("CompanyName"))
        End While
        con.Close()

        con.Open()

        cmd.CommandText = "SELECT max(ID) as maxID from Shipping"
        rd = cmd.ExecuteReader
        While rd.Read()
            age = rd.Item("maxID")
        End While
        con.Close()
        con.Open()
        cmd.CommandText = "SELECT DISTINCT(maxTooNum) from details where maxTooNum is not null"

        'Find Current Max TOO Number
        lblCurrentMaxNum.Text = "Current Latest TOO Number is " & age & "."
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
            MessageBox.Show("Please FIll The Required Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If newCheck = True Then
                cmd.CommandText = "update Company set CompanyName = @CompanyName, AddressLine1 = @AddressLine1, AddressLine2 = @AddressLine2, City = @City, State = @State, Country = @Country, PostalCode = @PostalCode, Phone = @Phone, Fax = @Fax, RegistrationNum = @RegistrationNum where companyName = @companyName"
            Else
                cmd.CommandText = "INSERT INTO Company (CompanyName,AddressLine1,AddressLine2,City,State,Country,PostalCode,Phone,Fax,RegistrationNum) values (@CompanyName,@AddressLine1,@AddressLine2,@City,@State,@Country,@PostalCode,@Phone,@Fax,@RegistrationNum)"
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
            rd = cmd.ExecuteReader
            MessageBox.Show("Update Complete", "Authentication ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCancel.PerformClick()
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

        cmd.CommandText = "Delete from Company where CompanyName = @CompanyName"
        cmd.Parameters.AddWithValue("@companyName", cmbCompanyName.Text)
        rd = cmd.ExecuteReader
        MessageBox.Show("Delete Complete", "Authentication ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnCancel.PerformClick()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
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