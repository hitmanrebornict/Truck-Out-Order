Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.Office.Interop.Excel

Public Class Edit

    Public TruckOutNumber As Integer

    Dim checkShippingPost As String
    Dim checkWarehousePost As String
    Dim checkWarehouse As String
    Dim checkWarehouseCheckpoint As String
    Dim checkSecurityDriver As String
    Dim checkSecurityPost As String
    Dim checkSecurityCheck As String
    Dim checkTempSealNo As Boolean = True
    Dim checkCargoWeight As Boolean

    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & My.Settings.fullName & vbNewLine & "Department of " & My.Settings.departmentName)
        lblCompanyNameHeader.Text = My.Settings.companyNameHeader
        lblTooNumber.Text = Me.TruckOutNumber

        cmbFullName.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPmCode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPmRegistrationPlate.DropDownStyle = ComboBoxStyle.DropDownList
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        Select Case My.Settings.role_id
            Case 2, 20
                tbEsSealNo.Enabled = False
                tbLoadingBay.Enabled = False
                cmbWarehouseLocation.Enabled = False
                cmbEsSealNo.Enabled = False
                dtpRTD.Enabled = False
                dtpLCD.Enabled = False
                dtpLCT.Enabled = False
                dtpRTT.Enabled = False
                'cbContainerNo.Enabled = False
                'cbEsSealNo.Enabled = False
                'cbTemporarySealNo.Enabled = False
                'tbWarehouseCheckLinerSealNo.Enabled = False
                'tbWarehouseCheckInternalSealNo.Enabled = False
                'tbSecurityCheckContainerNo.Enabled = False
                'tbSecurityCheckEsSealNo.Enabled = False
                'tbSecurityCheckLinerSealNo.Enabled = False
                'tbSecurityCheckInternalSealNo.Enabled = False
                'tbSecurityCheckTemporarySealNo.Enabled = False
                cmbFullName.Enabled = False
                cmbPmCode.Enabled = False
                cmbPmRegistrationPlate.Enabled = False
                btnPost.Visible = False
                tbSendToCompany.Enabled = False
            Case 3, 30, 4
                cmbCompany.Enabled = False
                dtpSCD.Enabled = False
                dtpSCT.Enabled = False
                tbInvoice.Enabled = False
                tbShippingLine.Enabled = False
                tbProduct.Enabled = False
                cmbDDB.Enabled = False
                tbHaulier.Enabled = False
                cmbLoadingPort.Enabled = False
                cmbContainerSize.Enabled = False
                tbContainerNo.Enabled = False
                tbInternalSealNo.Enabled = False
                cmbCheckTempSealNo.Enabled = False
                'tbSecurityCheckContainerNo.Enabled = False
                'tbSecurityCheckEsSealNo.Enabled = False
                'tbSecurityCheckInternalSealNo.Enabled = False
                'tbSecurityCheckLinerSealNo.Enabled = False
                'tbSecurityCheckTemporarySealNo.Enabled = False
                If My.Settings.role_id = 3 Or My.Settings.role_id = 30 Then
                    'cbContainerNo.Enabled = False
                    'cbEsSealNo.Enabled = False
                    'cbTemporarySealNo.Enabled = False
                    'tbWarehouseCheckInternalSealNo.Enabled = False
                    'tbWarehouseCheckLinerSealNo.Enabled = False
                    tbLinerSealNo.Enabled = False

                ElseIf My.Settings.role_id = 4 Then
                    'cbContainerNo.Enabled = True
                    'cbEsSealNo.Enabled = True
                    'cbTemporarySealNo.Enabled = True
                    'tbWarehouseCheckInternalSealNo.Enabled = True
                    'tbWarehouseCheckLinerSealNo.Enabled = True
                    tbLinerSealNo.Enabled = True

                    tbSendToCompany.Enabled = False
                    tbLoadingBay.Enabled = False
                    cmbWarehouseLocation.Enabled = False
                    cmbEsSealNo.Enabled = False
                    tbEsSealNo.Enabled = False

                End If
                cmbFullName.Enabled = False
                cmbPmCode.Enabled = False
                cmbPmRegistrationPlate.Enabled = False
                tbLinerSealNo.Enabled = False
            Case 5
                dtpRTD.Enabled = False
                dtpLCD.Enabled = False
                dtpLCT.Enabled = False
                dtpRTT.Enabled = False
                cmbWarehouseLocation.Enabled = False
                tbLoadingBay.Enabled = False
                tbSendToCompany.Enabled = False
                'cbEsSealNo.Enabled = False
                cmbCompany.Enabled = False
                dtpSCD.Enabled = False
                dtpSCT.Enabled = False
                tbInvoice.Enabled = False
                tbShippingLine.Enabled = False
                tbProduct.Enabled = False
                cmbDDB.Enabled = False
                tbHaulier.Enabled = False
                cmbLoadingPort.Enabled = False
                cmbContainerSize.Enabled = False
                tbContainerNo.Enabled = False
                tbInternalSealNo.Enabled = False
                'cbContainerNo.Enabled = False
                'cbEsSealNo.Enabled = False
                'cbTemporarySealNo.Enabled = False
                'tbWarehouseCheckInternalSealNo.Enabled = False
                'tbWarehouseCheckLinerSealNo.Enabled = False
                tbLinerSealNo.Enabled = False
                tbLinerSealNo.Enabled = False
                cmbCheckTempSealNo.Enabled = False
                tbTempSeal.Enabled = False
                cmbEsSealNo.Enabled = False
                tbEsSealNo.Enabled = False
        End Select

        'Read Data into Driver Check Section Combobox
        cmd.CommandText = "SELECT distinct(Full_Name) as Driver_Name from Driver_Info  where Full_Name is not null and validationCheck = 'YES' order by Full_Name"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbFullName.Items.Add(rd.Item("Driver_Name"))
        End While
        con.Close()
        con.Open()

        cmd.CommandText = "SELECT distinct(PM_Code) as PM from Driver_Info where PM_Code is not null and validationCheck = 'YES' order by PM_Code"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbPmCode.Items.Add(rd.Item("PM"))
        End While
        con.Close()

        con.Open()
        cmd.CommandText = "SELECT distinct(PM_Registration_Plate) as PM_Plate from Driver_Info where PM_Registration_Plate is not null and validationCheck = 'YES' order by PM_Registration_Plate"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbPmRegistrationPlate.Items.Add(rd.Item("PM_Plate"))
        End While
        con.Close()
        con.Open()

        'Read Data Into Company Combobox
        cmd.CommandText = "SELECT distinct(company_name) as r from details where company_name is not null and validationCheck = 'YES' order by company_name"
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
        cmd.CommandText = "SELECT distinct(Container_Size) as r from details where Container_Size is not null and validationCheck = 'YES' order by container_size"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbContainerSize.Items.Add(rd.Item("r"))
        End While
        con.Close()

        con.Open()
        cmd.CommandText = "Select checkTempSealNo, ORIGIN, INVOICE, CONTAINER_NO, LINER_SEA_NO, INTERNAL_SEAL_NO, ES_SEAL_NO, COMPANY, TEMPORARY_SEAL_NO, Container_Size, LOADING_PORT, SHIPPING_LINE, HAULIER, PRODUCT, SHIPMENT_CLOSING_DATE, CONVERT(varchar,SHIPMENT_CLOSING_TIME,8) as CloseTime, DDB ,Shipping_Post,warehouse_post,security_post,company from Shipping where id = @TruckOutNumber"
        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        rd = cmd.ExecuteReader


        While rd.Read()
            If IsDBNull(rd.Item("ORIGIN")) Then
                cmbCompany.Text = ""
            Else
                cmbCompany.Text = rd.Item("ORIGIN")
            End If

            dtpSCD.Text = rd.Item("SHIPMENT_CLOSING_DATE")
            dtpSCT.Text = rd.Item("CloseTime")
            tbInvoice.Text = rd.Item("INVOICE")
            tbProduct.Text = rd.Item("PRODUCT")
            tbShippingLine.Text = rd.Item("SHIPPING_LINE")
            cmbContainerSize.Text = rd.Item("Container_Size")
            tbHaulier.Text = rd.Item("HAULIER")
            cmbLoadingPort.Text = rd.Item("LOADING_PORT")
            tbContainerNo.Text = rd.Item("CONTAINER_NO")
            'ComboBox3.Text = rd.Item("ES_SEAL_NO")
            tbLinerSealNo.Text = rd.Item("LINER_SEA_NO")
            tbInternalSealNo.Text = rd.Item("INTERNAL_SEAL_NO")
            tbTempSeal.Text = rd.Item("TEMPORARY_SEAL_NO")

            'tbTemporarySealNo.Text = rd.Item("TEMPORARY_SEAL_NO")
            If IsDBNull(rd.Item("ES_SEAL_NO")) Then
                cmbEsSealNo.Text = ""
            Else
                cmbEsSealNo.Text = rd.Item("ES_SEAL_NO")
            End If
            If IsDBNull(rd.Item("DDB")) Then
                cmbDDB.Text = ""
            Else
                cmbDDB.Text = rd.Item("DDB")
            End If

            If IsDBNull(rd.Item("Shipping_Post")) Then
                checkShippingPost = ""
            Else
                checkShippingPost = rd.Item("Shipping_Post")
            End If

            If IsDBNull(rd.Item("Warehouse_Post")) Then
                checkWarehousePost = ""
            Else
                checkWarehousePost = rd.Item("Warehouse_Post")
            End If

            If IsDBNull(rd.Item("Security_Post")) Then
                checkSecurityPost = ""
            Else
                checkSecurityPost = rd.Item("Security_Post")


            End If

            If IsDBNull(rd.Item("company")) Then
                tbSendToCompany.Text = ""
            Else
                tbSendToCompany.Text = rd.Item("company")
            End If

            If IsDBNull(rd.Item("checkTempSealNo")) Then
                checkTempSealNo = False
            Else
                checkTempSealNo = rd.Item("checkTempSealNo")
            End If
        End While

        If checkWarehousePost = "YES" And My.Settings.role_id = 20 Then
            btnSave.Enabled = False
        End If
        con.Close()

        con.Open()
        cmd.CommandText = "Select Shipping_id, warehouse_location, loading_bay,es_seal_no,loading_completed_date, CONVERT(varchar,loading_completed_time,8) as LCT, READY_TRUCK_OUT_DATE, CONVERT(varchar,ready_truck_out_time,8) as RCT, Cargo_Weight from Warehouse where Shipping_ID = @TruckOutNumber2 "
        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
        rd = cmd.ExecuteReader()
        While rd.Read()
            cmbWarehouseLocation.Text = rd.Item("WAREHOUSE_LOCATION")
            tbLoadingBay.Text = rd.Item("LOADING_BAY")
            If cmbEsSealNo.Text = "NO" Then
                tbEsSealNo.Enabled = False
            Else
                tbEsSealNo.Text = rd.Item("ES_SEAL_NO")
            End If

            dtpLCD.Text = rd.Item("LOADING_COMPLETED_DATE")
            dtpLCT.Text = rd.Item("LCT")
            dtpRTD.Text = rd.Item("READY_TRUCK_OUT_DATE")
            dtpRTT.Text = rd.Item("RCT")


            If IsDBNull(rd.Item("Shipping_ID")) Then
                checkWarehouse = ""
            Else
                checkWarehouse = rd.Item("shipping_id")
            End If

            If IsDBNull(rd.Item("Cargo_Weight")) Then
                tbCargo.Text = ""
            Else
                tbCargo.Text = rd.Item("Cargo_Weight")
            End If
        End While
        con.Close()

        con.Open()
        cmd.CommandText = "Select * from Warehouse where Shipping_ID = @TruckOutNumber3"
        cmd.Parameters.AddWithValue("@TruckOutNumber3", Me.TruckOutNumber)
        rd = cmd.ExecuteReader()

        While rd.Read()
            'If IsDBNull(rd.Item("CONTAINER_NO_Check")) Or IsDBNull(rd.Item("ES_SEAL_NO_Check")) Or IsDBNull(rd.Item("Temporary_SEAL_NO_Check")) Then
            '    cbContainerNo.Text = ""
            '    cbEsSealNo.Text = ""
            '    cbTemporarySealNo.Text = ""
            '    tbWarehouseCheckLinerSealNo.Text = ""
            '    tbWarehouseCheckInternalSealNo.Text = ""
            'Else
            '    cbContainerNo.Text = rd.Item("CONTAINER_NO_Check")
            '    cbEsSealNo.Text = rd.Item("ES_SEAL_NO_Check")
            '    tbWarehouseCheckLinerSealNo.Text = rd.Item("LINER_SEAL_NO_Check")
            '    tbWarehouseCheckInternalSealNo.Text = rd.Item("INTERNAL_SEAL_NO_Check")
            '    cbTemporarySealNo.Text = rd.Item("Temporary_SEAL_NO_Check")

            'End If

            If IsDBNull(rd.Item("Warehouse_Checkpoint_Check")) Then
                checkWarehouseCheckpoint = ""
            Else
                checkWarehouseCheckpoint = rd.Item("Warehouse_Checkpoint_Check")
            End If
        End While


        'If cbContainerNo.Text = "NO" Then
        '    cbContainerNo.Checked = False
        'ElseIf cbContainerNo.Text = "Yes" Then
        '    cbContainerNo.Checked = True
        'End If

        'If cbEsSealNo.Text = "NO" Then
        '    cbEsSealNo.Checked = False
        'ElseIf cbEsSealNo.Text = "Yes" Then
        '    cbEsSealNo.Checked = True
        'End If
        'If cbTemporarySealNo.Text = "NO" Then
        '    cbTemporarySealNo.Checked = False
        'ElseIf cbTemporarySealNo.Text = "Yes" Then
        '    cbTemporarySealNo.Checked = True
        'End If
        'cbContainerNo.Text = "Check Point"
        'cbEsSealNo.Text = "Check Point"
        'cbTemporarySealNo.Text = "Check Point"
        con.Close()

        'Load Data From Security Table
        con.Open()
        cmd.CommandText = "Select * from Security where Shipping_ID = @TruckOutNumber4"
        cmd.Parameters.AddWithValue("@TruckOutNumber4", Me.TruckOutNumber)
        rd = cmd.ExecuteReader()
        While rd.Read()
            If Not IsDBNull(rd.Item("DRIVER_FULL_NAME")) Then
                cmbFullName.Text = rd.Item("DRIVER_FULL_NAME")
            Else
                cmbFullName.Text = ""
            End If

            If Not IsDBNull(rd.Item("PM_CODE")) Then
                cmbPmCode.Text = rd.Item("PM_CODE")
            Else
                cmbPmCode.Text = "" And cmbPmRegistrationPlate.Text = ""
            End If
            If Not IsDBNull(rd.Item("PM_REGISTRATION_PLATE")) Then
                cmbPmRegistrationPlate.Text = rd.Item("PM_REGISTRATION_PLATE")

            Else
                cmbPmRegistrationPlate.Text = ""
            End If
            If Not IsDBNull(rd.Item("Driver_Check")) Then
                checkSecurityDriver = rd.Item("Driver_Check")
            Else
                checkSecurityDriver = ""
            End If
            If Not IsDBNull(rd.Item("Security_Check")) Then
                checkSecurityCheck = rd.Item("Driver_Check")
            Else
                checkSecurityCheck = ""
            End If

            If Not IsDBNull(rd.Item("Cargo_Weight_Check")) Then
                checkCargoWeight = rd.Item("Cargo_Weight_Check")
            Else
                checkCargoWeight = True
            End If
        End While

        con.Close()
        'Read the full_name into lblCompanyFullName
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
        con.Close()

        'Read the full_name into lblLoadingPortFullName
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
        con.Close()




        'IF ES_SEAL_NO = False then textbox11 can't be enabled

        'If cmbEsSealNo.Text = "NO" Then
        '    tbSecurityCheckEsSealNo.Enabled = False
        'End If


        ''Fill in security check field
        'If checkSecurityCheck = "YES" Then

        '    tbSecurityCheckContainerNo.Text = tbContainerNo.Text
        '    tbSecurityCheckLinerSealNo.Text = tbLinerSealNo.Text
        '    tbSecurityCheckInternalSealNo.Text = tbInternalSealNo.Text
        '    tbSecurityCheckTemporarySealNo.Text = tbTempSeal.Text
        '    tbSecurityCheckEsSealNo.Text = tbEsSealNo.Text
        'End If

        'shipping and warehouse save button set to false

        If My.Settings.role_id = 5 Then
            tbContainerNo.PasswordChar = "*"
            tbEsSealNo.PasswordChar = "*"
            tbInternalSealNo.PasswordChar = "*"
            tbLinerSealNo.PasswordChar = "*"
            tbTempSeal.PasswordChar = "*"
            'tbWarehouseCheckInternalSealNo.PasswordChar = "*"
            'tbWarehouseCheckLinerSealNo.PasswordChar = "*"
        ElseIf My.Settings.role_id = 3 Or My.Settings.role_id = 30 Or My.Settings.role_id = 4 Then
            tbLinerSealNo.PasswordChar = "*"
            tbInternalSealNo.PasswordChar = "*"
        End If

        If checkTempSealNo = True Then
            cmbCheckTempSealNo.SelectedItem = "YES"
            If My.Settings.role_id = 5 Then
                'tbSecurityCheckTemporarySealNo.Enabled = True
            End If
        Else
            'tbSecurityCheckTemporarySealNo.Enabled = False
            cmbCheckTempSealNo.SelectedItem = "NO"


        End If

        'Shipping can't use post
        If My.Settings.role_id = 20 Then
            btnPost.Enabled = False
        End If

        'Come From report page
        If ViewPage.reportCheck = True Then
            For Each ctrl As Control In Panel3.Controls
                ctrl.Enabled = False
            Next
            btnPrint.Enabled = True
            btnCancel.Enabled = True
        End If

        cbShippingPost.Enabled = False
        cbWarehousePost.Enabled = False
        cbSecurityPost.Enabled = False
        If checkShippingPost = "" Then
            cbShippingPost.Checked = False
            cbShippingPost.Text = “Unposted"
        Else
            cbShippingPost.Checked = True
            cbShippingPost.Text = "Posted"
        End If

        If checkWarehousePost = "" Then
            cbWarehousePost.Checked = False
            cbWarehousePost.Text = "Unposted"
        Else
            cbWarehousePost.Checked = True
            cbWarehousePost.Text = "Posted"
        End If

        If checkSecurityPost = "" Then
            cbSecurityPost.Checked = False
            cbSecurityPost.Text = "Unposted"
        Else
            cbSecurityPost.Checked = True
            cbSecurityPost.Text = "Posted"
        End If

        If checkCargoWeight = False Then
            cbCargoWeightCheck.Checked = False
            cbCargoWeightCheck.Text = "Failed"
            MessageBox.Show("Please Inform Warehouse (Net Cargo Weight Checking Failed)", "Failed Case", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cbCargoWeightCheck.Checked = True
            cbCargoWeightCheck.Text = "Passed"

        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Cancel Button
        If ViewPage.reportCheck = True Then
            Dim obj As New ViewPage
            obj.Show()
            Me.Close()
        Else
            Dim obj As New Search
            obj.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'save button
        'Dim con As New SqlConnection
        'Dim cmd As New SqlCommand
        'Dim ra As Integer
        'Dim rd As SqlDataReader
        'Dim con3 As New SqlConnection
        'Dim cmd3 As New SqlCommand
        'Dim checkRow As Boolean = False 'To check the driver section
        'con.ConnectionString = My.Settings.connstr
        'cmd.Connection = con
        'con.Open()
        'con3.ConnectionString = My.Settings.connstr
        'cmd3.Connection = con3
        'con3.Open()

        ''Shipping Save
        'If My.Settings.role_id Then
        '    If dtpSCD.Text = "" Then
        '        MessageBox.Show("Please Fill Out The SHIPMENT CLOSING DATE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf cmbCompany.Text = "" Then
        '        MessageBox.Show("Please Fill Out The COMPANY Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf dtpSCT.Text = "" Then
        '        MessageBox.Show("Please Fill Out The SHIPPING CLOSING TIME Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbInvoice.Text = "" Then
        '        MessageBox.Show("Please Fill Out The INVOICE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbProduct.Text = "" Then
        '        MessageBox.Show("Please Fill Out The PRODUCT Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbShippingLine.Text = "" Then
        '        MessageBox.Show("Please Fill Out The SHIPPING_LINE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbHaulier.Text = "" Then
        '        MessageBox.Show("Please Fill Out The HAULIER Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf cmbLoadingPort.Text = "" Then
        '        MessageBox.Show("Please Fill Out The LOADING_PORT Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf cmbContainerSize.Text = "" Then
        '        MessageBox.Show("Please Fill Out The Container_Size Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbContainerNo.Text = "" Then
        '        MessageBox.Show("Please Fill Out The CONTAINER NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbInternalSealNo.Text = "" Then
        '        MessageBox.Show("Please Fill Out The INTERNAL SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf cmbCheckTempSealNo.SelectedItem = "YES" And tbTempSeal.Text = "" Then
        '        MessageBox.Show("Please Fill Out The TEMPORARY SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        ' ElseIf ComboBox3.Text = "" Then
        '        '     MessageBox.Show("Please Fill Out The ES_SEAL_NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf cmbDDB.Text = "" Then
        '        MessageBox.Show("Please Fill Out The DDB Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        'shipping save
        '        If checkShippingPost = "YES" Then
        '            cmd.CommandText = "update Shipping set Reversion='" + "R-S" + "',ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Update_User='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo WHERE ID = @TruckOutNumber"
        '            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '            cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
        '            ra = cmd.ExecuteNonQuery
        '            btnCancel.PerformClick()
        '            MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Else
        '            cmd.CommandText = "update Shipping set SHIPPING_POST = '" + "YES" + "',SHIPPING_POST_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',ORIGIN = '" + cmbCompany.Text + "',SHIPPING_POST_User = '" + My.Settings.username + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Update_User='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB ='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo  WHERE ID =@TruckOutNumber"
        '            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '            cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
        '            ra = cmd.ExecuteNonQuery
        '            btnCancel.PerformClick()
        '            MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
        '    End If
        '    con.Close()
        'ElseIf My.Settings.role_id Then
        '    'Warehouse Save
        '    If cmbEsSealNo.Text = "" Then
        '        MessageBox.Show("Please Fill Out The ES_SEAL_NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf cmbEsSealNo.Text = "yes" And tbEsSealNo.Text = "" Then
        '        MessageBox.Show("Please Fill Out The ES_SEAL Number ..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        If checkWarehousePost = "YES" Then
        '            MessageBox.Show("This Number is Posted Already", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            btnCancel.PerformClick()
        '            con.Close()
        '        Else

        '            If checkWarehouse <> "" Then
        '                cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',ES_SEAL_NO ='" + tbEsSealNo.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + My.Settings.username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "' where  Shipping_ID= @TruckOutNumber"
        '                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '                rd = cmd.ExecuteReader
        '                con.Close()
        '                con.Open()
        '                cmd.CommandText = "Update Shipping set COMPANY = '" + tbSendToCompany.Text + "',ES_SEAL_NO = '" + cmbEsSealNo.Text + "'where ID= @TruckOutNumber2"
        '                cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
        '                rd = cmd.ExecuteReader
        '                con.Close()
        '                btnCancel.PerformClick()
        '                MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Else
        '                cmd = New SqlCommand("INSERT INTO Warehouse (Shipping_ID,WAREHOUSE_LOCATION,LOADING_BAY,ES_SEAL_NO,Update_Time,Update_User,LOADING_COMPLETED_TIME,LOADING_COMPLETED_DATE,READY_TRUCK_OUT_TIME,READY_TRUCK_OUT_DATE,COMPANY)values (@TruckOutNumber,'" + cmbWarehouseLocation.Text + "','" + tbLoadingBay.Text + "','" + tbEsSealNo.Text + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + My.Settings.username + "','" + dtpLCT.Value.ToString("HH:mm:ss") + "','" + dtpLCD.Value.ToString("yyyy-MM-dd") + "','" + dtpRTT.Value.ToString("HH:mm:ss") + "','" + dtpRTD.Value.ToString("yyyy-MM-dd") + "','" + tbSendToCompany.Text + "')", con)
        '                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '                rd = cmd.ExecuteReader
        '                con.Close()
        '                con.Open()
        '                cmd.CommandText = "Update Shipping set COMPANY = '" + tbSendToCompany.Text + "', ES_SEAL_NO = '" + cmbEsSealNo.Text + "' where ID=@TruckOutNumber2 "
        '                cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
        '                rd = cmd.ExecuteReader
        '                con.Close()
        '                btnCancel.PerformClick()
        '                MessageBox.Show("Save Complete as " + Me.TruckOutNumber.ToString, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            End If
        '        End If
        '    End If
        'ElseIf My.Settings.role_id = 4 Then
        '    'warehousecheck for warehouse checking
        '    If cbContainerNo.Checked = True Then
        '        cbContainerNo.Text = "Yes"
        '    Else
        '        cbContainerNo.Text = "NO"
        '    End If

        '    If cbEsSealNo.Checked = True Then
        '        cbEsSealNo.Text = "Yes"
        '    Else
        '        cbEsSealNo.Text = "NO"
        '    End If
        '    If cbTemporarySealNo.Checked = True Then
        '        cbTemporarySealNo.Text = "Yes"
        '    Else
        '        cbTemporarySealNo.Text = "NO"
        '    End If
        '    If tbWarehouseCheckLinerSealNo.Text <> Microsoft.VisualBasic.Right(tbLinerSealNo.Text, 4) Then
        '        MessageBox.Show("Please Check LINER'S SEAL NO.." + Environment.NewLine + "The number should be last 4 digit only.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbWarehouseCheckInternalSealNo.Text <> Microsoft.VisualBasic.Right(tbInternalSealNo.Text, 4) Then
        '        MessageBox.Show("Please Check INTERNAL SEAL NO.." + Environment.NewLine + "The number should be last 4 digit only.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf checkWarehouseCheckpoint = "" Then
        '        cmd.CommandText = "Update warehouse set Warehouse_Checkpoint_Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Checkpoint_Update_User = '" + My.Settings.username + "',Container_No_Check = '" + cbContainerNo.Text + "', Es_Seal_No_Check = '" + cbEsSealNo.Text + "',Liner_Seal_No_Check = '" + tbWarehouseCheckLinerSealNo.Text + "', Internal_Seal_No_Check = '" + tbWarehouseCheckInternalSealNo.Text + "',Temporary_Seal_No_Check= '" + cbTemporarySealNo.Text + "',warehouse_Checkpoint_Check = 'YES' Where Shipping_ID = @TruckOutNumber"
        '        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '        rd = cmd.ExecuteReader
        '        btnCancel.PerformClick()
        '        MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        cmd.CommandText = "Update warehouse set Warehouse_Checkpoint_Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Checkpoint_Update_User = '" + My.Settings.username + "',Container_No_Check = '" + cbContainerNo.Text + "', Es_Seal_No_Check = '" + cbEsSealNo.Text + "',Liner_Seal_No_Check = '" + tbWarehouseCheckLinerSealNo.Text + "', Internal_Seal_No_Check = '" + tbWarehouseCheckInternalSealNo.Text + "',Temporary_Seal_No_Check= '" + cbTemporarySealNo.Text + "' Where Shipping_ID = @TruckOutNumber"
        '        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '        rd = cmd.ExecuteReader
        '        btnCancel.PerformClick()
        '        MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'ElseIf My.Settings.role_id = 5 Then
        '    'security driver checking
        '    If checkSecurityDriver <> "" Then
        '        MessageBox.Show("Driver Checked Already", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        btnSave.Enabled = False
        '    ElseIf cmbFullName.Text = "" Then
        '        MessageBox.Show("Please Check Driver Full Name..", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf cmbPmCode.Text = "" Then
        '        MessageBox.Show("Please Check PM Code..", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf cmbPmRegistrationPlate.Text = "" Then
        '        MessageBox.Show("Please Check PM Registration Plate ..", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        cmd.CommandText = "SELECT * from DRIVER_INFO where FULL_NAME = '" + cmbFullName.Text + "' and  PM_CODE = '" + cmbPmCode.Text + "' and  PM_REGISTRATION_PLATE = '" + cmbPmRegistrationPlate.Text + "'"
        '        rd = cmd.ExecuteReader
        '        If rd.HasRows Then
        '            checkRow = True
        '            cmbFullName.Enabled = False
        '            cmbPmCode.Enabled = False
        '            cmbPmRegistrationPlate.Enabled = False

        '            cmd = New SqlCommand("Insert Into Security (Shipping_ID,Driver_Full_Name,PM_CODE,PM_REGISTRATION_PLATE,DRIVER_CHECK,Update_Time,Update_User) values(@TruckOutNumber,'" + cmbFullName.Text + "','" + cmbPmCode.Text + "','" + cmbPmRegistrationPlate.Text + "','YES','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + My.Settings.username + "')", con)
        '            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '        Else
        '            MessageBox.Show("DRIVER VALIDATION FAIL", "VALIDATION FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End If
        '        con.Close()
        '        If checkRow Then
        '            con.Open()
        '            rd = cmd.ExecuteReader
        '            con.Close()
        '            MessageBox.Show("DRIVER VALIDATION PASS", "VALIDATION PASS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '        End If

        '    End If
        'End If
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        ''warehouse post
        'Dim con As New SqlConnection
        'Dim cmd As New SqlCommand
        'Dim rd As SqlDataReader
        'con.ConnectionString = My.Settings.connstr
        'cmd.Connection = con
        'con.Open()

        'If My.Settings.role_id = 3 Or My.Settings.role_id = 4 Then
        '    If checkWarehouseCheckpoint = "" Then
        '        MessageBox.Show("Please Check The Checkpoint First", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        btnCancel.PerformClick()
        '    ElseIf cmbWarehouseLocation.Text = "" Then
        '        MessageBox.Show("Please Fill Out The WAREHOUSE_LOCATION Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbLoadingBay.Text = "" Then
        '        MessageBox.Show("Please Fill Out The LOADING_BAY Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbSendToCompany.Text = "" Then
        '        MessageBox.Show("Please Fill Out The SEND TO COMPANY Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf dtpLCT.Text = "" Then
        '        MessageBox.Show("Please Fill Out The LOADING_COMPLETED_TIME Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf dtpRTT.Text = "" Then
        '        MessageBox.Show("Please Fill Out The READY_TRUCK_OUT_TIME Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf cmbEsSealNo.Text = "YES" And tbEsSealNo.Text = "" Then
        '        MessageBox.Show("Please Fill Out The ES_SEAL_NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        Select Case My.Settings.role_id
        '            Case 30
        '                If checkWarehousePost = "" Then
        '                    cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + My.Settings.username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "'where  Shipping_ID= @TruckOutNumber"
        '                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '                    rd = cmd.ExecuteReader
        '                    con.Close()
        '                    con.Open()
        '                    cmd.CommandText = "update Shipping set COMPANY = '" + tbSendToCompany.Text + "', ES_SEAL_NO = '" + cmbEsSealNo.Text + "',Warehouse_Post = 'YES', Warehouse_Post_User = '" + My.Settings.username + "', Warehouse_Post_Time = '" + Date.Now.ToString("HH:mm:ss") + "' where ID= @TruckOutNumber2"
        '                    cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
        '                    rd = cmd.ExecuteReader
        '                    con.Close()
        '                    btnCancel.PerformClick()
        '                    MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                Else
        '                    cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + My.Settings.username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "'where  Shipping_ID= @TruckOutNumber"
        '                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '                    rd = cmd.ExecuteReader
        '                    con.Close()
        '                    con.Open()
        '                    cmd.CommandText = "update Shipping set COMPANY = '" + tbSendToCompany.Text + "', Reversion = 'R-W', ES_SEAL_NO = '" + cmbEsSealNo.Text + "', Warehouse_Post_User = '" + My.Settings.username + "', Warehouse_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where ID= @TruckOutNumber2"
        '                    cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
        '                    rd = cmd.ExecuteReader
        '                    con.Close()
        '                    btnCancel.PerformClick()
        '                    MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                End If
        '            Case Else
        '                If checkWarehousePost = "" Then
        '                    cmd.CommandText = "update Shipping set Warehouse_Post_User = '" + My.Settings.username + "', Warehouse_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Post = 'YES' where ID= @TruckOutNumber"
        '                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '                    rd = cmd.ExecuteReader
        '                    con.Close()
        '                    btnCancel.PerformClick()
        '                    MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                Else
        '                    btnCancel.PerformClick()
        '                    MessageBox.Show("Data Already Post ..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                End If
        '        End Select

        '    End If

        'ElseIf My.Settings.role_id = 5 Then
        '    If cmbDDB.Text = "NO" Then
        '        If tbSecurityCheckContainerNo.Text <> tbContainerNo.Text Then
        '            MessageBox.Show("Please Check CONTAINER_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        ElseIf tbSecurityCheckTemporarySealNo.Text <> tbTempSeal.Text Then
        '            MessageBox.Show("Please Check TEMPORARY SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Else
        '            If checkSecurityPost = "" Then
        '                cmd.CommandText = "update Shipping set Security_Post = '" + "YES" + "',Security_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Security_Post_User = '" + My.Settings.username + "' WHERE ID = @TruckOutNumber"
        '                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '                rd = cmd.ExecuteReader
        '                con.Close()
        '                con.Open()
        '                cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = 'YES' WHERE Shipping_ID = @TruckOutNumber2"
        '                cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
        '                rd = cmd.ExecuteReader
        '                btnCancel.PerformClick()
        '                con.Close()
        '                MessageBox.Show("Post Complete", "Post Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Else
        '                MessageBox.Show("This Number is Posted Already", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                btnCancel.PerformClick()
        '                con.Close()
        '            End If
        '        End If
        '    Else
        '        If cmbEsSealNo.Text = "YES" And tbSecurityCheckEsSealNo.Text = "" Then
        '            MessageBox.Show("Please Check ES_SEAL_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        ElseIf tbSecurityCheckEsSealNo.Text <> tbEsSealNo.Text Then
        '            tbSecurityCheckEsSealNo.Enabled = False
        '        End If

        '        If tbSecurityCheckContainerNo.Text <> tbContainerNo.Text Then
        '            MessageBox.Show("Please Check CONTAINER_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        ElseIf tbSecurityCheckLinerSealNo.Text <> tbLinerSealNo.Text Then
        '            MessageBox.Show("Please Check LINER'S SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        ElseIf tbSecurityCheckInternalSealNo.Text <> tbInternalSealNo.Text Then
        '            MessageBox.Show("Please Check INTERNAL SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        ElseIf tbSecurityCheckTemporarySealNo.Text <> tbTempSeal.Text Then
        '            MessageBox.Show("Please Check TEMPORARY SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Else
        '            If checkSecurityPost = "" Then
        '                cmd.CommandText = "update Shipping set Security_Post = '" + "YES" + "',Security_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Security_Post_User = '" + My.Settings.username + "' WHERE ID = @TruckOutNumber"
        '                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '                rd = cmd.ExecuteReader
        '                con.Close()
        '                con.Open()
        '                cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = 'YES' WHERE Shipping_ID = @TruckOutNumber2"
        '                cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
        '                rd = cmd.ExecuteReader
        '                btnCancel.PerformClick()
        '                con.Close()
        '                MessageBox.Show("Post Complete", "Post Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Else
        '                MessageBox.Show("This Number is Posted Already", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                btnCancel.PerformClick()
        '                con.Close()
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnWarehouseCheckPoint.Click
    '    'Warehouse Checkpoint
    '    'checkwarehousecheckpoint is used to check the checkpoint
    '    Dim con As New SqlConnection
    '    Dim cmd As New SqlCommand
    '    Dim rd As SqlDataReader
    '    con.ConnectionString = My.Settings.connstr
    '    cmd.Connection = con
    '    con.Open()
    '    If cbContainerNo.Checked = True Then
    '        cbContainerNo.Text = "Yes"
    '    Else
    '        cbContainerNo.Text = "NO"
    '    End If

    '    If cbEsSealNo.Checked = True Then
    '        cbEsSealNo.Text = "Yes"
    '    Else
    '        cbEsSealNo.Text = "NO"
    '    End If
    '    If cbTemporarySealNo.Checked = True Then
    '        cbTemporarySealNo.Text = "Yes"
    '    Else
    '        cbTemporarySealNo.Text = "NO"
    '    End If
    '    If tbWarehouseCheckLinerSealNo.Text <> Microsoft.VisualBasic.Right(tbLinerSealNo.Text, 4) Then
    '        MessageBox.Show("Please Check LINER'S SEAL NO.." + Environment.NewLine + "The number should be last 4 digit only.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    ElseIf tbWarehouseCheckInternalSealNo.Text <> Microsoft.VisualBasic.Right(tbInternalSealNo.Text, 4) Then
    '        MessageBox.Show("Please Check INTERNAL SEAL NO.." + Environment.NewLine + "The number should be last 4 digit only.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    ElseIf checkWarehouseCheckpoint = "" Then
    '        cmd.CommandText = "Update warehouse set Warehouse_Checkpoint_Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Checkpoint_Update_User = '" + Me.Username + "',Container_No_Check = '" + cbContainerNo.Text + "', Es_Seal_No_Check = '" + cbEsSealNo.Text + "',Liner_Seal_No_Check = '" + tbWarehouseCheckLinerSealNo.Text + "', Internal_Seal_No_Check = '" + tbWarehouseCheckInternalSealNo.Text + "',Temporary_Seal_No_Check= '" + cbTemporarySealNo.Text + "',warehouse_Checkpoint_Check = 'YES' Where Shipping_ID = @TruckOutNumber"
    '        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
    '        rd = cmd.ExecuteReader
    '        btnCancel.PerformClick()
    '        MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        cmd.CommandText = "Update warehouse set Warehouse_Checkpoint_Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Checkpoint_Update_User = '" + Me.Username + "',Container_No_Check = '" + cbContainerNo.Text + "', Es_Seal_No_Check = '" + cbEsSealNo.Text + "',Liner_Seal_No_Check = '" + tbWarehouseCheckLinerSealNo.Text + "', Internal_Seal_No_Check = '" + tbWarehouseCheckInternalSealNo.Text + "',Temporary_Seal_No_Check= '" + cbTemporarySealNo.Text + "' Where Shipping_ID = @TruckOutNumber"
    '        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
    '        rd = cmd.ExecuteReader
    '        btnCancel.PerformClick()
    '        MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If

    'End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnDriverCheck.Click
    '    'Driver Check
    '    Dim con As New SqlConnection
    '    Dim cmd As New SqlCommand
    '    Dim rd As SqlDataReader
    '    Dim checkRow As Boolean = False 'To check the driver section
    '    con.ConnectionString = My.Settings.connstr
    '    cmd.Connection = con
    '    con.Open()

    '    If cmbFullName.Text = "" Then
    '        MessageBox.Show("Please Check Driver Full Name..", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    ElseIf cmbPmCode.Text = "" Then
    '        MessageBox.Show("Please Check PM Code..", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    ElseIf cmbPmRegistrationPlate.Text = "" Then
    '        MessageBox.Show("Please Check PM Registration Plate ..", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Else
    '        cmd.CommandText = "SELECT * from DRIVER_INFO where FULL_NAME = '" + cmbFullName.Text + "' and  PM_CODE = '" + cmbPmCode.Text + "' and  PM_REGISTRATION_PLATE = '" + cmbPmRegistrationPlate.Text + "'"
    '        rd = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            checkRow = True
    '            cmbFullName.Enabled = False
    '            cmbPmCode.Enabled = False
    '            cmbPmRegistrationPlate.Enabled = False
    '            btnDriverCheck.Visible = False
    '            cmd = New SqlCommand("Insert Into Security (Shipping_ID,Driver_Full_Name,PM_CODE,PM_REGISTRATION_PLATE,DRIVER_CHECK,Update_Time,Update_User) values(@TruckOutNumber,'" + cmbFullName.Text + "','" + cmbPmCode.Text + "','" + cmbPmRegistrationPlate.Text + "','YES','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Me.Username + "')", con)
    '            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
    '        Else
    '            MessageBox.Show("DRIVER VALIDATION FAIL", "VALIDATION FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '        con.Close()
    '        If checkRow Then
    '            con.Open()
    '            rd = cmd.ExecuteReader
    '            con.Close()
    '            MessageBox.Show("DRIVER VALIDATION PASS", "VALIDATION PASS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            btnSecurityPost.Visible = True
    '        End If

    '    End If
    'End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        ''Security Check and Post 
        'Dim con As New SqlConnection
        'Dim cmd As New SqlCommand
        'Dim rd As SqlDataReader
        'con.ConnectionString = My.Settings.connstr
        'cmd.Connection = con
        'con.Open()

        'If cmbDDB.Text = "NO" Then
        '    If tbSecurityCheckContainerNo.Text <> tbContainerNo.Text Then
        '        MessageBox.Show("Please Check CONTAINER_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbSecurityCheckTemporarySealNo.Text <> tbTempSeal.Text Then
        '        MessageBox.Show("Please Check TEMPORARY SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        If checkSecurityPost = "" Then
        '            cmd.CommandText = "update Shipping set Security_Post = '" + "YES" + "',Security_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Security_Post_User = '" + My.Settings.username + "' WHERE ID = @TruckOutNumber"
        '            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '            rd = cmd.ExecuteReader
        '            con.Close()
        '            con.Open()
        '            cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = 'YES' WHERE Shipping_ID = @TruckOutNumber2"
        '            cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
        '            rd = cmd.ExecuteReader
        '            btnCancel.PerformClick()
        '            con.Close()
        '            MessageBox.Show("Post Complete", "Post Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Else
        '            MessageBox.Show("This Number is Posted Already", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            btnCancel.PerformClick()
        '            con.Close()
        '        End If
        '    End If
        'Else
        '    If cmbEsSealNo.Text = "YES" And tbSecurityCheckEsSealNo.Text = "" Then
        '        MessageBox.Show("Please Check ES_SEAL_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbSecurityCheckEsSealNo.Text <> tbEsSealNo.Text Then
        '        tbSecurityCheckEsSealNo.Enabled = False
        '    End If

        '    If tbSecurityCheckContainerNo.Text <> tbContainerNo.Text Then
        '        MessageBox.Show("Please Check CONTAINER_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbSecurityCheckLinerSealNo.Text <> tbLinerSealNo.Text Then
        '        MessageBox.Show("Please Check LINER'S SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbSecurityCheckInternalSealNo.Text <> tbInternalSealNo.Text Then
        '        MessageBox.Show("Please Check INTERNAL SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ElseIf tbSecurityCheckTemporarySealNo.Text <> tbTempSeal.Text Then
        '        MessageBox.Show("Please Check TEMPORARY SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        If checkSecurityPost = "" Then
        '            cmd.CommandText = "update Shipping set Security_Post = '" + "YES" + "',Security_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Security_Post_User = '" + My.Settings.username + "' WHERE ID = @TruckOutNumber"
        '            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        '            rd = cmd.ExecuteReader
        '            con.Close()
        '            con.Open()
        '            cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = 'YES' WHERE Shipping_ID = @TruckOutNumber2"
        '            cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
        '            rd = cmd.ExecuteReader
        '            btnCancel.PerformClick()
        '            con.Close()
        '            MessageBox.Show("Post Complete", "Post Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Else
        '            MessageBox.Show("This Number is Posted Already", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            btnCancel.PerformClick()
        '            con.Close()
        '        End If
        '    End If
        'End If
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ShippingEdit.PrintDocument1_PrintPage(e, e)
    End Sub

    Private Sub cmbEsSealNo_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbEsSealNo.Text = "NO" Then
            tbEsSealNo.Enabled = False
        Else
            If My.Settings.role_id = 2 And My.Settings.role_id = 20 Then
                tbEsSealNo.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbCheckTempSealNo_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbCheckTempSealNo.SelectedItem = "YES" Then
            tbTempSeal.Enabled = True
            checkTempSealNo = True
        Else
            tbTempSeal.Enabled = False
            checkTempSealNo = False
            tbTempSeal.Text = ""
        End If
    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs)
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

    Private Sub cmbLoadingPort_SelectedIndexChanged(sender As Object, e As EventArgs)
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
End Class