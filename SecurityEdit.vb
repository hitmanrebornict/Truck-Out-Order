Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class SecurityEdit

    Public TruckOutNumber As Integer
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private checkTempSealNo As Boolean
    Private checkDriver As String
    Private checkSecurityCheck As String
    Private checkWarehouse As String
    Private checkShippingPost As String
    Private checkWarehousePost As String
    Private checkSecurityPost As String
    Private checkCargoWeight As Boolean
    Private companyNameHeader As String
    Private checkAllowToPost As Boolean
    Private netCargoWeight As Integer
    Private checkTry As Boolean
    Private ISOTankWeight As Integer
    Private ISOTODValue As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFunction.topHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)
        lblTooNumber.Text = Me.TruckOutNumber
        cmbFullName.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPmCode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPmRegistrationPlate.DropDownStyle = ComboBoxStyle.DropDownList
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con

        GlobalFunction.ReadForDriverCheck("Full_Name", cmbFullName)
        GlobalFunction.ReadForDriverCheck("PM_Code", cmbPmCode)
        GlobalFunction.ReadForDriverCheck("PM_Registration_Plate", cmbPmRegistrationPlate)

        'Get item for combobox
        GlobalFunction.getCmbValue(cmbCompany, cmbLoadingPort, cmbWarehouseLocation, cmbContainerSize)
        GlobalFunction.getProductType(cmbProductType)

        'Read data from Shipping Table
        'GlobalFunction.selectFromShipping(
        '    Me.TruckOutNumber,
        '    cmbCompany,
        '    dtpSCD,
        '    dtpSCT,
        '    tbInvoice,
        '    tbProduct,
        '    tbShippingLine,
        '    cmbContainerSize,
        '    tbHaulier,
        '    cmbLoadingPort,
        '    tbContainerNo,
        '    tbLinerSealNo,
        '    tbInternalSealNo,
        '    tbTempSeal,
        '    cmbEsSealNo,
        '    cmbDDB,
        '    tbSendToCompany,
        '    checkTempSealNo
        '    )

        'Read Data from Warehouse Table
        'GlobalFunction.selectFromWarehouse(
        '    Me.TruckOutNumber,
        '    cmbWarehouseLocation,
        '    tbLoadingBay,
        '    cmbEsSealNo,
        '    tbEsSealNo,
        '    dtpLCD,
        '    dtpLCT,
        '    dtpRTD,
        '    dtpRTT,
        '    tbCargo1
        '    )


        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select checkTempSealNo, ORIGIN, INVOICE, CONTAINER_NO, LINER_SEA_NO, INTERNAL_SEAL_NO, ES_SEAL_NO, COMPANY, TEMPORARY_SEAL_NO, Container_Size, LOADING_PORT, SHIPPING_LINE, HAULIER, PRODUCT, SHIPMENT_CLOSING_DATE, CONVERT(varchar,SHIPMENT_CLOSING_TIME,8) as CloseTime, DDB ,Shipping_Post,warehouse_post,security_post,company,Product_Type, Net_Cargo_Weight,Check_ISO_Tank,ISO_Truck_Out_Date,ISO_Tank_Weight from Shipping where id = @TruckOutNumber"
        cmd.Parameters.AddWithValue("@TruckOutNumber", TruckOutNumber)
        rd = cmd.ExecuteReader


        While (rd.Read())
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

            If IsDBNull(rd.Item("Liner_Sea_No")) Then
                tbLinerSealNo.Text = ""
            Else
                tbLinerSealNo.Text = rd.Item("LINER_SEA_NO")
            End If

            If IsDBNull(rd.Item("Internal_Seal_No")) Then
                tbInternalSealNo.Text = ""
            Else
                tbInternalSealNo.Text = rd.Item("INTERNAL_SEAL_NO")
            End If

            If IsDBNull(rd.Item("Temporary_Seal_No")) Then
                tbTempSeal.Text = ""
            Else
                tbTempSeal.Text = rd.Item("TEMPORARY_SEAL_NO")
            End If

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

            If IsDBNull(rd.Item("Product_Type")) Then
                cmbProductType.Text = ""
            Else
                cmbProductType.Text = rd.Item("Product_Type")
            End If

            If IsDBNull(rd.Item("Net_Cargo_Weight")) Then
                tbCargo1.Text = ""
            Else
                tbCargo1.Text = rd.Item("Net_Cargo_Weight")
            End If

            If IsDBNull(rd.Item("Check_ISO_Tank")) Then
                cbISO.Checked = False
            Else
                cbISO.Checked = rd.Item("Check_ISO_Tank")
            End If


            If IsDBNull(rd.Item("ISO_Truck_Out_Date")) Then
                ISOTODValue = ""
            Else
                ISOTODValue = rd.Item("ISO_Truck_Out_Date")
            End If

            If IsDBNull(rd.Item("ISO_Tank_Weight")) Then
                tbISOTankWeight.Text = ""
            Else
                tbISOTankWeight.Text = rd.Item("ISO_Tank_Weight")
            End If
        End While
        con.Close()

        con.Open()
        cmd.CommandText = "Select Shipping_id, warehouse_location, loading_bay,es_seal_no,loading_completed_date, CONVERT(varchar,loading_completed_time,8) as LCT, READY_TRUCK_OUT_DATE, CONVERT(varchar,ready_truck_out_time,8) as RCT from Warehouse where Shipping_ID = @TruckOutNumber2 "
        cmd.Parameters.AddWithValue("@TruckOutNumber2", TruckOutNumber)
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


        End While
        con.Close()


        'Load Data From Security Table
        con.Open()
        cmd.CommandText = "Select * from Security where Shipping_ID = @TruckOutNumber4"
        cmd.Parameters.AddWithValue("@TruckOutNumber4", Me.TruckOutNumber)
        rd = cmd.ExecuteReader()
        rd.Read()

        If rd.HasRows() Then
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
                checkDriver = rd.Item("Driver_Check")
            Else
                checkDriver = ""
            End If
            If Not IsDBNull(rd.Item("Security_Check")) Then
                checkSecurityCheck = rd.Item("Security_Check")
            Else
                checkSecurityCheck = ""
            End If

            If Not IsDBNull(rd.Item("Cargo_Weight_Check")) Then
                checkCargoWeight = rd.Item("Cargo_Weight_Check")
            Else
                checkCargoWeight = True
            End If

            If IsDBNull(rd.Item("Cargo_Weight_Check_Value")) Then
                tbCheckCargoWeight.Text = ""
            Else
                tbCheckCargoWeight.Text = rd.Item("Cargo_Weight_Check_Value")
            End If

            If IsDBNull(rd.Item("Allow_To_Post")) Then
                checkAllowToPost = False
            Else
                checkAllowToPost = rd.Item("Allow_To_Post")
            End If

            If IsDBNull(rd.Item("Security_Check_ISO_Tank_Weight")) Then
                tbSecurityCheckISOTankWeight.Text = ""
            Else
                tbSecurityCheckISOTankWeight.Text = rd.Item("Security_Check_ISO_Tank_Weight")
            End If
        End If
        con.Close()

        'Read the full_name into lblcompanyfullname and lblLoadingport
        GlobalFunction.loadFullNameIntoLabel(cmbCompany, cmbLoadingPort, lblCompanyFullName, lblLoadingPortFullName)

        GlobalFunction.checkPostBoxWithCargo(cbShippingPost, cbWarehousePost, cbSecurityPost, checkShippingPost, checkWarehousePost, checkSecurityPost, checkCargoWeight, lblCargoWeight, checkSecurityCheck)

        'Driver Check Button Visible
        If checkDriver = "YES" Then
            btnDriverCheck.Visible = False
            btnSecurityCheck.Visible = True
            cmbFullName.Enabled = False
            cmbPmCode.Enabled = False
            cmbPmRegistrationPlate.Enabled = False

        Else
            btnDriverCheck.Visible = True
            btnSecurityPost.Visible = False
            btnSecurityCheck.Visible = False
        End If


        'IF ES_SEAL_NO = False then textbox11 can't be enabled
        If cmbEsSealNo.Text = "NO" Then
            tbSecurityCheckEsSealNo.Enabled = False
        End If


        'Fill in security check field
        If checkSecurityCheck = "YES" Then
            btnSecurityPost.Enabled = True
            btnSecurityCheck.Enabled = False
            btnSecurityCheck.Visible = False
            tbSecurityCheckContainerNo.Text = tbContainerNo.Text
            tbSecurityCheckLinerSealNo.Text = tbLinerSealNo.Text
            tbSecurityCheckInternalSealNo.Text = tbInternalSealNo.Text
            tbSecurityCheckTemporarySealNo.Text = tbTempSeal.Text
            tbSecurityCheckEsSealNo.Text = tbEsSealNo.Text
            tbCheckCargoWeight.Enabled = False
            tbCheckCargoWeight.Enabled = False
            tbSecurityCheckContainerNo.Enabled = False
            tbSecurityCheckEsSealNo.Enabled = False
            tbSecurityCheckInternalSealNo.Enabled = False
            tbSecurityCheckLinerSealNo.Enabled = False
            tbSecurityCheckTemporarySealNo.Enabled = False
            tbSecurityCheckISOTankWeight.Enabled = False
            dtpISO.Enabled = False
            tbISOTankWeight.Enabled = False
            If My.Settings.role_id <> 5 Then
                btnSecurityCheck.Enabled = True
                btnSecurityCheck.Visible = True

            End If
        Else
        End If

        If My.Settings.role_id = 5 Then
            tbContainerNo.PasswordChar = "*"
            tbEsSealNo.PasswordChar = "*"
            tbInternalSealNo.PasswordChar = "*"
            tbLinerSealNo.PasswordChar = "*"
            tbTempSeal.PasswordChar = "*"
            tbCargo1.PasswordChar = "*"
        End If


        If checkTempSealNo = True Then
            cmbCheckTempSealNo.SelectedItem = "YES"
            If My.Settings.role_id = 5 Then
                tbSecurityCheckTemporarySealNo.Enabled = True
            End If
        Else
            tbSecurityCheckTemporarySealNo.Enabled = False
            cmbCheckTempSealNo.SelectedItem = "NO"
        End If

        'cbpost checkin


        'show text in cmbCheckTempSeal
        If checkTempSealNo = True Then
            cmbCheckTempSealNo.Text = "YES"
        Else
            cmbCheckTempSealNo.Text = "NO"
        End If


        cbISO.Enabled = False
        If cbISO.Checked Then
            If My.Settings.role_id <> 5 Then
                btnSecurityCheck.Text = "ISO Approve"
            Else
                btnSecurityCheck.Text = "ISO Check"
            End If
            tbSecurityCheckLinerSealNo.Enabled = False
            tbSecurityCheckEsSealNo.Enabled = False
            tbSecurityCheckInternalSealNo.Enabled = False
            tbSecurityCheckTemporarySealNo.Enabled = False
            tbCheckCargoWeight.Enabled = False
            tlpISO.Enabled = True
        Else
            If My.Settings.role_id <> 5 Then
                btnSecurityCheck.Text = "Cargo Approve"
            Else
                btnSecurityCheck.Text = "Security Check"
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnDriverCheck.Click
        'Driver Check
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim checkRow As Boolean = False 'To check the driver section
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If cmbFullName.Text = "" Then
            MessageBox.Show("Please Check Driver Full Name..", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbPmCode.Text = "" Then
            MessageBox.Show("Please Check PM Code..", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbPmRegistrationPlate.Text = "" Then
            MessageBox.Show("Please Check PM Registration Plate ..", "Check Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmd.CommandText = "SELECT * from DRIVER_INFO where FULL_NAME = '" + cmbFullName.Text + "' and  PM_CODE = '" + cmbPmCode.Text + "' and  PM_REGISTRATION_PLATE = '" + cmbPmRegistrationPlate.Text + "'"
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                checkRow = True
                cmbFullName.Enabled = False
                cmbPmCode.Enabled = False
                cmbPmRegistrationPlate.Enabled = False
                btnDriverCheck.Visible = False
                cmd = New SqlCommand("Insert Into Security (Shipping_ID,Driver_Full_Name,PM_CODE,PM_REGISTRATION_PLATE,DRIVER_CHECK,Update_Time,Update_User) values(@TruckOutNumber,'" + cmbFullName.Text + "','" + cmbPmCode.Text + "','" + cmbPmRegistrationPlate.Text + "','YES','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + My.Settings.username + "')", con)
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            Else
                MessageBox.Show("DRIVER VALIDATION FAIL", "VALIDATION FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
            If checkRow Then
                con.Open()
                rd = cmd.ExecuteReader
                con.Close()
                MessageBox.Show("DRIVER VALIDATION PASS", "VALIDATION PASS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                checkDriver = "YES"
                btnSecurityCheck.Visible = True
            End If

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnSecurityPost.Click
        'Security Post 
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con

        con.Open()

        If checkSecurityCheck <> "YES" Then
            MessageBox.Show("Please Check Security Check", "Post Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf checkSecurityCheck = "YES" And checkAllowToPost = True Then
            cmd.CommandText = "update Shipping set Security_Post = '" + "YES" + "',Security_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Security_Post_User = '" + My.Settings.username + "' WHERE ID = @TruckOutNumber"
            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            MessageBox.Show("Post Complete", "Post Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnPrint.PerformClick()
            GlobalFunction.backToPage(Search, Me)
        ElseIf checkSecurityCheck = "YES" And checkAllowToPost = False And cbISO.Checked Then
            MessageBox.Show("Please Inform Shipping Admin", "Net Cargo Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf checkSecurityCheck = "YES" And checkAllowToPost = False Then
            MessageBox.Show("Please Inform Warehouse Admin", "Net Cargo Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        GlobalFunction.printPage(e, Panel2, checkTempSealNo, Me.TruckOutNumber)
    End Sub

    Private Sub cmbEsSealNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEsSealNo.SelectedIndexChanged
        If cmbEsSealNo.Text = "NO" Then
            tbEsSealNo.Enabled = False
        Else
            If My.Settings.role_id = 2 And My.Settings.role_id = 20 Then
                tbEsSealNo.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbCheckTempSealNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCheckTempSealNo.SelectedIndexChanged
        If cmbCheckTempSealNo.SelectedItem = "YES" Then
            If My.Settings.role_id <> 5 Then
                tbTempSeal.Enabled = True
            Else
            End If
            tbTempSeal.Enabled = False
        End If
    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompany.SelectedIndexChanged
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Close application") = Windows.Forms.DialogResult.Yes Then
            Dim obj As New Search
            obj.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnSecurityCheck_Click(sender As Object, e As EventArgs) Handles btnSecurityCheck.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con

        con.Open()
        If cbISO.Checked = True Then
            If (My.Settings.role_id = 2 Or My.Settings.role_id = 1) And My.Settings.adminCheck = True Then
                'ISO TANK is not allow to post
                cmd.CommandText = "update Security set Allow_To_Post = 1 where shipping_ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)

                rd = cmd.ExecuteReader
                con.Close()
                con.Open()
                cmd.CommandText = "Update Shipping set ISO_Truck_Out_Date = @ISO_Truck_Out_Date, Last_Modified_User = @Last_Modified_User , Update_Time = @Update_Time  Where Id = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@Last_Modified_User", My.Settings.username)
                cmd.Parameters.AddWithValue("@Update_Time", Date.Now.ToString("yyyy-MM-dd"))
                MessageBox.Show("This Number Can Be Posted By Security Now", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Try
                    If Integer.Parse(tbSecurityCheckISOTankWeight.Text) >= Integer.Parse(tbISOTankWeight.Text) And String.Compare(dtpISO.Value.ToString("d/MM/yyyy"), ISOTODValue) = 0 And String.Compare(tbSecurityCheckContainerNo.Text, tbContainerNo.Text) = 0 Then
                        'Check ISO Tank
                        checkAllowToPost = True
                        checkSecurityCheck = "YES"
                        btnSecurityCheck.Visible = False
                        tbSecurityCheckContainerNo.Enabled = False
                        dtpISO.Enabled = False
                        tbISOTankWeight.Enabled = False
                        cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = 'YES',Allow_To_Post = @Allow_To_Post, Security_Check_ISO_Tank_Weight = @Security_Check_ISO_Tank_Weight WHERE Shipping_ID = @TruckOutNumber2"
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        cmd.Parameters.AddWithValue("@Allow_To_Post", checkAllowToPost)
                        cmd.Parameters.AddWithValue("@Security_Check_ISO_Tank_Weight", tbSecurityCheckISOTankWeight.Text)
                        rd = cmd.ExecuteReader
                        con.Close()
                        MessageBox.Show("ISO Security Check Complete", "Check Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf Not String.Compare(tbSecurityCheckContainerNo.Text, tbContainerNo.Text) = 0 Then
                        MessageBox.Show("Please Check Container No.", "Check Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf Not String.Compare(dtpISO.Value.ToString("d/MM/yyyy"), ISOTODValue) = 0 Or Integer.Parse(tbSecurityCheckISOTankWeight.Text) < Integer.Parse(tbISOTankWeight.Text) Then
                        checkAllowToPost = False
                        checkSecurityCheck = "YES"
                        cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = 'YES',Allow_To_Post = @Allow_To_Post, Security_Check_ISO_Tank_Weight = @Security_Check_ISO_Tank_Weight WHERE Shipping_ID = @TruckOutNumber2"
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        cmd.Parameters.AddWithValue("@Allow_To_Post", checkAllowToPost)
                        cmd.Parameters.AddWithValue("@Security_Check_ISO_Tank_Weight", tbSecurityCheckISOTankWeight.Text)
                        rd = cmd.ExecuteReader
                        con.Close()
                        MessageBox.Show("Inform Shipping", "ISO Check Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            If (My.Settings.role_id = 3 Or My.Settings.role_id = 4 Or My.Settings.role_id = 1) And My.Settings.adminCheck = True Then
                ' Allow Cargo Check TO Post
                cmd.CommandText = "update Security set Allow_To_Post = 1 ,Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "'where shipping_ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                rd = cmd.ExecuteReader
                con.Close()
                MessageBox.Show("This Number Can Be Posted By Security Now", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cmbEsSealNo.Text = "YES" And tbSecurityCheckEsSealNo.Text = "" Then
                MessageBox.Show("Please Check ES_SEAL_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckEsSealNo.Text <> tbEsSealNo.Text Then
                tbSecurityCheckEsSealNo.Enabled = False

            ElseIf tbSecurityCheckContainerNo.Text <> tbContainerNo.Text Then
                MessageBox.Show("Please Check CONTAINER_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckLinerSealNo.Text <> tbLinerSealNo.Text Then
                MessageBox.Show("Please Check LINER'S SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckInternalSealNo.Text <> tbInternalSealNo.Text Then
                MessageBox.Show("Please Check INTERNAL SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckTemporarySealNo.Text <> tbTempSeal.Text Then
                MessageBox.Show("Please Check TEMPORARY SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbCheckCargoWeight.Text = " " Then
                MessageBox.Show("Please enter Cargo Weight Field", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Security Check Cargo Weight
                Try
                    If Integer.Parse(tbCheckCargoWeight.Text) >= tbCargo1.Text Then
                        checkCargoWeight = True
                        checkAllowToPost = True
                    Else
                        checkCargoWeight = False
                        checkAllowToPost = False
                    End If

                    cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = 'YES', Cargo_Weight_Check = @checkCargoWeight,Cargo_Weight_Check_Value = @cargoWeightCheckValue,Allow_To_Post = @Allow_To_Post WHERE Shipping_ID = @TruckOutNumber2"
                    cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                    cmd.Parameters.AddWithValue("@checkCargoWeight", checkCargoWeight)
                    cmd.Parameters.AddWithValue("@cargoWeightCheckValue", tbCheckCargoWeight.Text)
                    cmd.Parameters.AddWithValue("@Allow_To_Post", checkAllowToPost)
                    rd = cmd.ExecuteReader
                    con.Close()
                    If (checkCargoWeight) Then
                        MessageBox.Show("Security Check Complete", "Check Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Stop CTNR /Inform Warehouse", "Fail Case", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    checkSecurityCheck = "YES"
                    btnSecurityCheck.Visible = False
                    tbCheckCargoWeight.Enabled = False
                    tbSecurityCheckContainerNo.Enabled = False
                    tbSecurityCheckEsSealNo.Enabled = False
                    tbSecurityCheckInternalSealNo.Enabled = False
                    tbSecurityCheckLinerSealNo.Enabled = False
                    tbSecurityCheckTemporarySealNo.Enabled = False
                Catch ex As Exception
                    MessageBox.Show("Please only enter integer value in net cargo weight!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

        btnSecurityPost.Visible = True
    End Sub

End Class