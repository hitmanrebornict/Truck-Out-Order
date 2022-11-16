Imports System.Data.SqlClient


Public Class NewPage
    Dim surface As Graphics = CreateGraphics()
    Dim pen1 As Pen = New Pen(Color.Black, 2)

    Public Username As String
    Public role_id As Integer
    Public TruckOutNumber As Integer
    Public checkTempSealNo As Boolean
    Public departmentName As String
    Public adminCheck As Boolean
    Public fullName As String
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Public companyNameHeader As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & fullName & vbNewLine & "Department of " & departmentName)
        lblCompanyNameHeader.Text = companyNameHeader
        lblTooNumber.Text = Me.TruckOutNumber
        tbTemporarySealNo.Enabled = False
        cmbCheckTempSealNo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCheckTempSealNo.SelectedItem = "NO"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmbDDB.SelectedItem = "No"
        surface.DrawLine(pen1, 10, 10, 100, 10)

        If Me.role_id = "2" Or Me.role_id = "20" Then
            tbEsSealNo.Enabled = False
            tbLoadingBay.Enabled = False
            cmbWarehouseLocation.Enabled = False
            cmbEsSealNo.Enabled = False
            dtpRTD.Enabled = False
            dtpLCD.Enabled = False
            dtpLCT.Enabled = False
            dtpRTT.Enabled = False
        End If

        'Read Data Into Company Combobox
        cmd.CommandText = "SELECT distinct(company_name) as r from details where company_name is not null and validationCheck = 'YES'  order by company_name"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbCompany.Items.Add(rd.Item("r"))
        End While
        con.Close()

        con.Open()
        'Read Data Into Loading Port Combobox
        cmd.CommandText = "SELECT distinct(Loading_Port) as r from details where Loading_Port is not null and validationCheck = 'YES' order by loading_port "
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbLoadingPort.Items.Add(rd.Item("r"))
        End While
        con.Close()
        con.Open()
        'Read Data Into Warehouse Location Combobox
        cmd.CommandText = "SELECT distinct(Warehouse_Location) as r from details where Warehouse_Location is not null and validationCheck = 'YES'  order by warehouse_location"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbWarehouseLocation.Items.Add(rd.Item("r"))
        End While
        con.Close()
        con.Open()
        'Read Data Into Container Size Combobox
        cmd.CommandText = "SELECT distinct(Container_Size) as r from details where Container_Size is not null and validationCheck = 'YES'  order by container_size"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbContainerSize.Items.Add(rd.Item("r"))
        End While
        con.Close()


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Cancel Button
        Dim Admin As New Admin
        Dim User As New NormalUserPage

        Select Case adminCheck
            Case True
                Admin.username = Me.Username
                Admin.role_id = Me.role_id
                Admin.departmentName = Me.departmentName
                Admin.adminCheck = Me.adminCheck
                Admin.fullName = Me.fullName
                Admin.companyNameHeader = Me.companyNameHeader
                Admin.Show()
                Me.Close()
            Case False
                User.username = Me.Username
                User.role_id = Me.role_id
                User.departmentName = Me.departmentName
                User.adminCheck = Me.adminCheck
                User.fullName = Me.fullName
                Admin.companyNameHeader = Me.companyNameHeader
                User.Show()
                Me.Close()

        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'save button
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim ra As Integer
        Dim con3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        con3.ConnectionString = My.Settings.connstr
        cmd3.Connection = con3
        con3.Open()
        Dim check As String

        If dtpSCD.Text = "" Then
            MessageBox.Show("Please Fill Out The SHIPMENT CLOSING DATE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbCompany.Text = "" Then
            MessageBox.Show("Please Fill Out The COMPANY Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpSCT.Text = "" Then
            MessageBox.Show("Please Fill Out The SHIPPING CLOSING TIME Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbInvoice.Text = "" Then
            MessageBox.Show("Please Fill Out The INVOICE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbProduct.Text = "" Then
            MessageBox.Show("Please Fill Out The PRODUCT Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbShippingLine.Text = "" Then
            MessageBox.Show("Please Fill Out The SHIPPING_LINE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbHaulier.Text = "" Then
            MessageBox.Show("Please Fill Out The HAULIER Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbLoadingPort.Text = "" Then
            MessageBox.Show("Please Fill Out The LOADING_PORT Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbContainerSize.Text = "" Then
            MessageBox.Show("Please Fill Out The Container_Size Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbContainerNo.Text = "" Then
            MessageBox.Show("Please Fill Out The CONTAINER NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbInternalSealNo.Text = "" Then
            MessageBox.Show("Please Fill Out The INTERNAL SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbCheckTempSealNo.Text = "" Then
            MessageBox.Show("Please Fill Out The TEMPORARY SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' ElseIf ComboBox3.Text = "" Then
            '     MessageBox.Show("Please Fill Out The ES_SEAL_NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbDDB.Text = "" Then
            MessageBox.Show("Please Fill Out The DDB Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'If cmbSaveAndPost.SelectedItem = "Save" Then

            '    cmd = New SqlCommand("INSERT INTO Shipping (ID,ORIGIN,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,INVOICE,PRODUCT,SHIPPING_LINE,Container_Size,HAULIER,LOADING_PORT,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO,TEMPORARY_SEAL_NO,Update_User,Update_Time,DDB) values ( @TruckOutNumber ,'" + cmbCompany.Text + "','" + dtpSCD.Value.ToString("yyyy-MM-dd") + "','" + dtpSCT.Value.ToString("HH:mm:ss") + "','" + tbInvoice.Text + "','" + tbProduct.Text + "','" + tbShippingLine.Text + "','" + cmbContainerSize.Text + "','" + tbHaulier.Text + "','" + cmbLoadingPort.Text + "','" + tbContainerNo.Text + "','" + tbLinerSealNo.Text + "','" + tbInternalSealNo.Text + "','" + tbTemporarySealNo.Text + "','" + Me.Username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbDDB.Text + "')", con)
            '    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            '    ra = cmd.ExecuteNonQuery
            '    btnCancel.PerformClick()
            '    MessageBox.Show("Save Complete as " + Me.TruckOutNumber.ToString, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else

            cmd = New SqlCommand("INSERT INTO Shipping (ID,ORIGIN,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,INVOICE,PRODUCT,SHIPPING_LINE,Container_Size,HAULIER,LOADING_PORT,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO,TEMPORARY_SEAL_NO,Update_User,Update_Time,Shipping_Post,Shipping_Post_User,Shipping_POST_Time,DDB,checkTempSealNo) values (@TruckOutNumber ,'" + cmbCompany.Text + "','" + dtpSCD.Value.ToString("yyyy-MM-dd") + "','" + dtpSCT.Value.ToString("HH:mm:ss") + "','" + tbInvoice.Text + "','" + tbProduct.Text + "','" + tbShippingLine.Text + "','" + cmbContainerSize.Text + "','" + tbHaulier.Text + "','" + cmbLoadingPort.Text + "','" + tbContainerNo.Text + "','" + tbLinerSealNo.Text + "','" + tbInternalSealNo.Text + "','" + tbTemporarySealNo.Text + "','" + Me.Username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "YES" + "','" + Me.Username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbDDB.Text + "', @checkTempSealNo)", con)
            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
            ra = cmd.ExecuteNonQuery
            btnCancel.PerformClick()
            MessageBox.Show("Save Complete as " + Me.TruckOutNumber.ToString, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        End If
        con.Close()

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSaveAndPost.SelectedIndexChanged
        btnSave.Enabled = True
    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompany.SelectedIndexChanged
        'Show Company full name when the cmbcompany's value is changed
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "select full_name from details where company_name = '" + cmbCompany.Text + "'"
        rd = cmd.ExecuteReader

        While rd.Read()
            If IsDBNull(rd.Item("full_name")) Then
                lblCompanyFullName.Text = ""
            Else
                lblCompanyFullName.Text = rd.Item("full_name")
            End If

        End While
        lblCompanyFullName.Visible = True
        con.Close()
    End Sub

    Private Sub cmbLoadingPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoadingPort.SelectedIndexChanged
        'show the full name of loading port when the cmblodingport's value is changed
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "select full_name from details where Loading_port = '" + cmbLoadingPort.Text + "'"
        rd = cmd.ExecuteReader

        While rd.Read()
            If IsDBNull(rd.Item("full_name")) Then
                lblLoadingPortFullName.Text = ""
            Else
                lblLoadingPortFullName.Text = rd.Item("full_name")
            End If
        End While
        lblLoadingPortFullName.Visible = True
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCheckTempSealNo.SelectedIndexChanged
        If cmbCheckTempSealNo.Text = "NO" Then
            tbTemporarySealNo.Enabled = False
            checkTempSealNo = False
        Else
            tbTemporarySealNo.Enabled = True
            checkTempSealNo = True
        End If
    End Sub

    Private Sub cmbEsSealNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEsSealNo.SelectedIndexChanged
        If cmbEsSealNo.SelectedItem = "NO" Then
            tbEsSealNo.Enabled = False
        Else
            tbEsSealNo.Enabled = True
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


    End Sub
End Class