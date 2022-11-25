Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop.Excel

Public Class CompanyMaintenance

    Dim selection As String
    Dim validationCheck As String
    Dim newCheck As Boolean = True
    Dim maxTOONumber, age As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFunction.topHeader(lblUserDetails, lblCompanyNameHeader)
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
        cmd.CommandText = "SELECT max(TOO_Number) as maxTOONumber from details where TOO_Number is not null"
        rd = cmd.ExecuteReader
        rd.Read()
        maxTOONumber = rd.Item("maxTOONumber")

        If age = 0 Then
            My.Settings.newTOONumber = 34800
        Else
            If age >= maxTOONumber Then
                My.Settings.newTOONumber = age + 1
            Else
                My.Settings.newTOONumber = maxTOONumber
            End If

        End If




        'Find Current Max TOO Number
        lblCurrentMaxNum.Text = "Current Latest TOO Number is " & My.Settings.newTOONumber & "."
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
                MessageBox.Show("The new TOO Number can't less than existing TOO Number", "Update Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.CommandText = "Insert into details(TOO_Number) values (@TOO_Number)"
                cmd.Parameters.AddWithValue("@TOO_Number", tbTOO.Text)
                rd = cmd.ExecuteReader
                MessageBox.Show("The new TOO Number is " & tbTOO.Text, "Update Completed ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class