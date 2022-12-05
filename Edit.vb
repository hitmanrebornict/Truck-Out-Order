Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Drawing.Text

Public Class Edit

    Public TruckOutNumber As Integer

    Private checkSecurityCheck As String
    Private checkDriver As String
    Private checkTempSealNo As String
    Private checkWarehouse As String
    Private checkShippingPost As String
    Private checkWarehousePost As String
    Private checkSecurityPost As String
    Private checkCargoWeight As Boolean
    Private checkWarehouseCheckpoint As String
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private companyNameHeader As String
    Private checkAllowToPost As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        GlobalFunction.topHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)
        lblTooNumber.Text = Me.TruckOutNumber

        cmbFullName.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPmCode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPmRegistrationPlate.DropDownStyle = ComboBoxStyle.DropDownList

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con

        'Read Data into Driver Check Section Combobox

        GlobalFunction.ReadForDriverCheck("Full_Name", cmbFullName)
        GlobalFunction.ReadForDriverCheck("PM_Code", cmbPmCode)
        GlobalFunction.ReadForDriverCheck("PM_Registration_Plate", cmbPmRegistrationPlate)


        GlobalFunction.getCmbValue(cmbCompany, cmbLoadingPort, cmbWarehouseLocation, cmbContainerSize)
        GlobalFunction.getProductType(cmbProductType)

        ''Read data from Shipping Table
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

        ''Read Data from Warehouse Table
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
        '    tbCargo
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
                tbCargoChecking.Text = ""
            Else
                tbCargoChecking.Text = rd.Item("Net_Cargo_Weight")
            End If

            'If IsDBNull(rd.Item("Check_ISO_Tank")) Then
            '    checkISO = False
            'Else
            '    checkISO = rd.Item("Check_ISO_Tank")
            'End If


            'If IsDBNull(rd.Item("ISO_Truck_Out_Date")) Then
            '    dtpISO.Text = ""
            'Else
            '    dtpISO.Text = rd.Item("ISO_Truck_Out_Date")
            'End If

            'If IsDBNull(rd.Item("ISO_Tank_Weight")) Then
            '    tbISOTankWeight.Text = ""
            'Else
            '    tbISOTankWeight.Text = rd.Item("ISO_Tank_Weight")
            'End If
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

        con.Open()
        cmd.CommandText = "Select * from Warehouse where Shipping_ID = @TruckOutNumber3"
        cmd.Parameters.AddWithValue("@TruckOutNumber3", Me.TruckOutNumber)
        rd = cmd.ExecuteReader()

        While rd.Read()
            If IsDBNull(rd.Item("Warehouse_Checkpoint_Check")) Then
                checkWarehouseCheckpoint = ""
            Else
                checkWarehouseCheckpoint = rd.Item("Warehouse_Checkpoint_Check")
            End If
        End While

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
                checkDriver = rd.Item("Driver_Check")
            Else
                checkDriver = ""
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

            If Not IsDBNull(rd.Item("Cargo_Weight_Check_Value")) Then
                tbCargoChecking.Text = rd.Item("Cargo_Weight_Check_Value")
            Else
                tbCargoChecking.Text = "NULL"
            End If

            If IsDBNull(rd.Item("Allow_To_Post")) Then
                checkAllowToPost = False
            Else
                checkAllowToPost = rd.Item("Allow_To_Post")
            End If
        End While

        con.Close()

        'Read the full_name into lblcompanyfullname and lblLoadingport
        GlobalFunction.loadFullNameIntoLabel(cmbCompany, cmbLoadingPort, lblCompanyFullName, lblLoadingPortFullName)

        'shipping and warehouse save button set to false
        If My.Settings.role_id = 5 Then
            tbContainerNo.PasswordChar = "*"
            tbEsSealNo.PasswordChar = "*"
            tbInternalSealNo.PasswordChar = "*"
            tbLinerSealNo.PasswordChar = "*"
            tbTempSeal.PasswordChar = "*"
        ElseIf My.Settings.role_id = 3 Or My.Settings.role_id = 30 Or My.Settings.role_id = 4 Then
            tbLinerSealNo.PasswordChar = "*"
            tbInternalSealNo.PasswordChar = "*"
        End If

        If checkTempSealNo = True Then
            cmbCheckTempSealNo.SelectedItem = "YES"
        Else
            cmbCheckTempSealNo.SelectedItem = "NO"
        End If

        'Come From report page
        If ViewPage.reportCheck = True Then
            For Each ctrl As Control In Panel3.Controls
                ctrl.Enabled = False
            Next
            btnPrint.Enabled = True
            btnCancel.Enabled = True
            lblCargoWeight.Enabled = True
            btnAdminSave.Visible = False
            btnCargoCheck.Visible = False
        End If

        If My.Settings.role_id <> 1 And My.Settings.adminCheck = True Then
            For Each ctrl As Control In Panel3.Controls
                ctrl.Enabled = False
            Next
            btnPrint.Enabled = True
            btnCancel.Enabled = True
            lblCargoWeight.Enabled = True
        End If

        If My.Settings.role_id = 1 And My.Settings.adminCheck = True Then
            btnAdminSave.Enabled = True
        Else
            btnAdminSave.Enabled = False
        End If

        GlobalFunction.checkPostBoxWithCargo(cbShippingPost, cbWarehousePost, cbSecurityPost, checkShippingPost, checkWarehousePost, checkSecurityPost, checkCargoWeight, lblCargoWeight, checkSecurityCheck)

        If checkSecurityPost <> "YES" And checkCargoWeight = False Then
            btnCargoCheck.Enabled = True
        Else
            btnCargoCheck.Enabled = False
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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        GlobalFunction.printPage(e, Panel2, checkTempSealNo, Me.TruckOutNumber)
    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbLoadingPort_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdminSave_Click(sender As Object, e As EventArgs) Handles btnAdminSave.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        Try
            con.Open()
            cmd.CommandText = "update Shipping set Reversion='" + "R-S" + "',ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo WHERE ID = @TruckOutNumber"
            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            cmd.Parameters.AddWithValue("checkTempSealNo", checkTempSealNo)
            rd = cmd.ExecuteReader
            con.Close()

            con.Open()
            cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + My.Settings.username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "' , Cargo_weight = '" + tbCargoChecking.Text + "' where  Shipping_ID= @TruckOutNumber1"
            cmd.Parameters.AddWithValue("@TruckOutNumber1", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            con.Close()
            con.Open()
            cmd.CommandText = "update Shipping set COMPANY = '" + tbSendToCompany.Text + "', Reversion = 'R-W', ES_SEAL_NO = '" + cmbEsSealNo.Text + "' where ID= @TruckOutNumber2"
            cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            con.Close()

            con.Open()
            cmd.CommandText = "Update Security set Shipping_ID = @TruckOutNumber,Driver_Full_Name = '" + cmbFullName.Text + "',PM_CODE = '" + cmbPmCode.Text + "',PM_REGISTRATION_PLATE = '" + cmbPmRegistrationPlate.Text + "',DRIVER_CHECK = 'YES' ,Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Update_User = '" + My.Settings.username + "' where  Shipping_ID= @TruckOutNumber5”
            cmd.Parameters.AddWithValue("@TruckOutNumber5", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            con.Close()

            MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCancel.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Please only enter integer value in net cargo weight!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCargoCheck_Click(sender As Object, e As EventArgs) Handles btnCargoCheck.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "update Security set Allow_To_Post = 1 ,Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "'where shipping_ID = @TruckOutNumber"
        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        rd = cmd.ExecuteReader
        MessageBox.Show("This Number Can Be Posted By Security Now", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class