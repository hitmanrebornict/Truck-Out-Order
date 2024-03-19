Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Drawing.Text
Imports System.Net
Imports Truck_Out_Order.My.Resources

Public Class Edit

    Public TruckOutNumber As Integer

    Private checkSecurityCheck As Boolean
    Private checkDriver As Boolean
    Private checkTempSealNo As Boolean
    Private checkWarehouse As Boolean
    Private checkShippingPost As Boolean
    Private checkWarehousePost As Boolean
    Private checkSecurityPost As Boolean
    Private checkCargoWeight As Boolean
    Private checkWarehouseCheckpoint As Boolean
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private ReadOnly companyNameHeader As String
    Private checkAllowToPost As Boolean
    Private checkISO As Boolean
    Private stringUpdateComplete,
            stringComplete,
            stringUpdateFailed As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        If (My.Settings.languageSetting = "fr") Then
            btnCancel.Text = ResourceSecurityEditFrench.btnCancel
            btnAdminSave.Text = ResourceSecurityEditFrench.btnSave
            btnPrint.Text = ResourceSecurityEditFrench.btnPrint
            lblCompany.Text = ResourceSecurityEditFrench.lblCompnay
            lblContainerNo.Text = ResourceSecurityEditFrench.lblContainerNo
            lblContainerSize.Text = ResourceSecurityEditFrench.lblContainerSize
            lblDDB.Text = ResourceSecurityEditFrench.lblDDB
            lblEsSealNo.Text = ResourceSecurityEditFrench.lblEsSealNo
            lblFullName.Text = ResourceSecurityEditFrench.lblFullName
            lblHaulier.Text = ResourceSecurityEditFrench.lblHaulier
            lblInternalSealNo.Text = ResourceSecurityEditFrench.lblInternalSealNo
            lblInvoice.Text = ResourceSecurityEditFrench.lblInvoice
            lblISOTank.Text = ResourceSecurityEditFrench.lblISOTank
            lblISOTankWeight.Text = ResourceSecurityEditFrench.lblISOTankWeight
            lblNetCargoWeight.Text = ResourceSecurityEditFrench.lblISOTruckOutDate
            lblLinerSealNo.Text = ResourceSecurityEditFrench.lblLinerSealNo
            lblLoadingBay.Text = ResourceSecurityEditFrench.lblLoadingBay
            lblLoadingPort.Text = ResourceSecurityEditFrench.lblLoadingPort
            lblNetCargoWeight.Text = ResourceSecurityEditFrench.lblNetCargoWeight
            lblPortFullName.Text = ResourceSecurityEditFrench.lblPortFullName
            lblProduct.Text = ResourceSecurityEditFrench.lblProduct
            lblSCD.Text = ResourceSecurityEditFrench.lblSCD
            lblSCT.Text = ResourceSecurityEditFrench.lblSCT
            lblSendToCompany.Text = ResourceSecurityEditFrench.lblSendToCompany
            lblShippingLine.Text = ResourceSecurityEditFrench.lblShippingLine
            lblTemporarySealNo.Text = ResourceSecurityEditFrench.lblTemporarySealNo
            lblTruckOutNumber.Text = ResourceSecurityEditFrench.lblTruckOutNumber
            lblWarehouseLocation.Text = ResourceSecurityEditFrench.lblWarehouseLocation
            lblLCD.Text = ResourceSecurityEditFrench.lblLCD
            lblLCT.Text = ResourceSecurityEditFrench.lblLCT
            lblRTD.Text = ResourceSecurityEditFrench.lblRTD
            lblRTT.Text = ResourceSecurityEditFrench.lblRTT
            lblShippingPost.Text = ResourceSecurityEditFrench.lblShippingPost
            lblWarehousePost.Text = ResourceSecurityEditFrench.lblWarehousePost
            lblSecurityPost.Text = ResourceSecurityEditFrench.lblSecurityPost
            lblISOTruckOutDate.Text = ResourceSecurityEditFrench.lblISOTruckOutDate
            lblCompanyFullName1.Text = ResourceSecurityEditFrench.lblCompanyFullName1
            lblDriverCheck.Text = ResourceSecurityEditFrench.lblDriverCheck
            lblPmCode.Text = ResourceSecurityEditFrench.lblPMCode
            lblPmRegistrationPlate.Text = ResourceSecurityEditFrench.lblPMRegistrationPlate
            lblSecurityCheck.Text = ResourceSecurityEditFrench.lblSecurityCheck
            lblISOTruckOutDateCheck.Text = ResourceSecurityEditFrench.lblISOTruckOutDateCheck
            lblISOTankWeightCheck.Text = ResourceSecurityEditFrench.lblISOTankWeightCheck
            lblISOCheck.Text = ResourceSecurityEditFrench.lblISOCheck
            stringComplete = ResourceEditFrench.stringComplete
            stringUpdateComplete = ResourceEditFrench.stringUpdateComplete
            stringUpdateFailed = ResourceEditFrench.stringUpdateFailed

            GlobalFunction.ChangeFont(lblCompany, 10)
            GlobalFunction.ChangeFont(lblContainerSize, 10)
            GlobalFunction.ChangeFont(lblContainerNo, 10)
            GlobalFunction.ChangeFont(lblDDB, 10)
            GlobalFunction.ChangeFont(lblEsSealNo, 10)
            GlobalFunction.ChangeFont(lblFullName, 10)
            GlobalFunction.ChangeFont(lblHaulier, 10)
            GlobalFunction.ChangeFont(lblInternalSealNo, 10)
            GlobalFunction.ChangeFont(lblInvoice, 10)
            GlobalFunction.ChangeFont(lblISOTank, 10)
            GlobalFunction.ChangeFont(lblNetCargoWeight, 10)
            GlobalFunction.ChangeFont(lblLinerSealNo, 9)
            GlobalFunction.ChangeFont(lblLoadingBay, 10)
            GlobalFunction.ChangeFont(lblLoadingPort, 10)
            GlobalFunction.ChangeFont(lblNetCargoWeight, 10)
            GlobalFunction.ChangeFont(lblISOTankWeight, 10)
            GlobalFunction.ChangeFont(lblPortFullName, 10)
            GlobalFunction.ChangeFont(lblProduct, 10)
            GlobalFunction.ChangeFont(lblSCD, 10)
            GlobalFunction.ChangeFont(lblSCT, 10)
            GlobalFunction.ChangeFont(lblSendToCompany, 10)
            GlobalFunction.ChangeFont(lblShippingLine, 10)
            GlobalFunction.ChangeFont(lblTemporarySealNo, 10)
            GlobalFunction.ChangeFontBold(lblTruckOutNumber, 12)
            GlobalFunction.ChangeFont(lblWarehouseLocation, 10)
            GlobalFunction.ChangeFont(lblLCD, 9)
            GlobalFunction.ChangeFont(lblLCT, 9)
            GlobalFunction.ChangeFont(lblRTD, 9)
            GlobalFunction.ChangeFont(lblRTT, 9)
            GlobalFunction.ChangeFont(lblShippingPost, 12)
            GlobalFunction.ChangeFont(lblWarehousePost, 12)
            GlobalFunction.ChangeFont(lblSecurityPost, 12)
            GlobalFunction.ChangeFont(lblISOTruckOutDate, 10)
            GlobalFunction.ChangeFont(lblCompanyFullName1, 10)
            GlobalFunction.ChangeFontBold(lblDriverCheck, 12)
            GlobalFunction.ChangeFont(lblPmCode, 10)
            GlobalFunction.ChangeFont(lblPmRegistrationPlate, 10)
            GlobalFunction.ChangeFontBold(lblSecurityCheck, 12)
            GlobalFunction.ChangeFontBold(lblISOCheck, 12)
            GlobalFunction.ChangeFont(lblISOTruckOutDateCheck, 10)
            GlobalFunction.ChangeFont(lblISOTankWeightCheck, 10)
            btnCancel.Font = New Font("Helvetica", 9)
            btnPrint.Font = New Font("Helvetica", 9)
            btnAdminSave.Font = New Font("Helvetica", 9)

        Else
            btnCancel.Text = ResourceSecurityEdit.btnCancel

            btnPrint.Text = ResourceSecurityEdit.btnPrint
            lblCompany.Text = ResourceSecurityEdit.lblCompnay
            lblContainerNo.Text = ResourceSecurityEdit.lblContainerNo
            lblContainerSize.Text = ResourceSecurityEdit.lblContainerSize
            lblDDB.Text = ResourceSecurityEdit.lblDDB
            lblEsSealNo.Text = ResourceSecurityEdit.lblEsSealNo
            lblFullName.Text = ResourceSecurityEdit.lblFullName
            lblHaulier.Text = ResourceSecurityEdit.lblHaulier
            lblInternalSealNo.Text = ResourceSecurityEdit.lblInternalSealNo
            lblInvoice.Text = ResourceSecurityEdit.lblInvoice
            lblISOTank.Text = ResourceSecurityEdit.lblISOTank
            lblISOTankWeight.Text = ResourceSecurityEdit.lblISOTankWeight
            lblNetCargoWeight.Text = ResourceSecurityEdit.lblISOTruckOutDate
            lblLinerSealNo.Text = ResourceSecurityEdit.lblLinerSealNo
            lblLoadingBay.Text = ResourceSecurityEdit.lblLoadingBay
            lblLoadingPort.Text = ResourceSecurityEdit.lblLoadingPort
            lblNetCargoWeight.Text = ResourceSecurityEdit.lblNetCargoWeight
            lblPortFullName.Text = ResourceSecurityEdit.lblPortFullName
            lblProduct.Text = ResourceSecurityEdit.lblProduct
            lblSCD.Text = ResourceSecurityEdit.lblSCD
            lblSCT.Text = ResourceSecurityEdit.lblSCT
            lblSendToCompany.Text = ResourceSecurityEdit.lblSendToCompany
            lblShippingLine.Text = ResourceSecurityEdit.lblShippingLine
            lblTemporarySealNo.Text = ResourceSecurityEdit.lblTemporarySealNo
            lblTruckOutNumber.Text = ResourceSecurityEdit.lblTruckOutNumber
            lblWarehouseLocation.Text = ResourceSecurityEdit.lblWarehouseLocation
            lblLCD.Text = ResourceSecurityEdit.lblLCD
            lblLCT.Text = ResourceSecurityEdit.lblLCT
            lblRTD.Text = ResourceSecurityEdit.lblRTD
            lblRTT.Text = ResourceSecurityEdit.lblRTT
            lblShippingPost.Text = ResourceSecurityEdit.lblShippingPost
            lblWarehousePost.Text = ResourceSecurityEdit.lblWarehousePost
            lblSecurityPost.Text = ResourceSecurityEdit.lblSecurityPost
            lblISOTruckOutDate.Text = ResourceSecurityEdit.lblISOTruckOutDate
            lblCompanyFullName.Text = ResourceSecurityEdit.lblCompanyFullName1
            lblDriverCheck.Text = ResourceSecurityEdit.lblDriverCheck
            lblPmCode.Text = ResourceSecurityEdit.lblPMCode
            lblPmRegistrationPlate.Text = ResourceSecurityEdit.lblPMRegistrationPlate
            lblSecurityCheck.Text = ResourceSecurityEdit.lblSecurityCheck
            lblISOTruckOutDateCheck.Text = ResourceSecurityEdit.lblISOTruckOutDateCheck
            lblISOTankWeightCheck.Text = ResourceSecurityEdit.lblISOTankWeightCheck
            btnAdminSave.Text = ResourceSecurityEdit.btnSave
            stringComplete = ResourceEdit.stringComplete
            stringUpdateComplete = ResourceEdit.stringUpdateComplete
            stringUpdateFailed = ResourceEdit.stringUpdateFailed
        End If
        GlobalFunction.TopHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)
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
        cmd.CommandText = "Select checkTempSealNo, ORIGIN, INVOICE, CONTAINER_NO, LINER_SEA_NO, INTERNAL_SEAL_NO, ES_SEAL_NO, COMPANY, TEMPORARY_SEAL_NO, Container_Size, LOADING_PORT, SHIPPING_LINE, HAULIER, PRODUCT, SHIPMENT_CLOSING_DATE, CONVERT(varchar,SHIPMENT_CLOSING_TIME,8) as CloseTime, DDB ,Shipping_Post,warehouse_post,security_post,company,Product_Type, Net_Cargo_Weight,Check_ISO_Tank,ISO_Truck_Out_Date,ISO_Tank_Weight_Lower,ISO_Tank_Weight_Upper from Shipping where id = @TruckOutNumber"
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
                checkShippingPost = False
            Else
                checkShippingPost = rd.Item("Shipping_Post")
            End If

            If IsDBNull(rd.Item("Warehouse_Post")) Then
                checkWarehousePost = False
            Else
                checkWarehousePost = rd.Item("Warehouse_Post")
            End If

            If IsDBNull(rd.Item("Security_Post")) Then
                checkSecurityPost = False
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
                tbCargo.Text = ""
            Else
                tbCargo.Text = rd.Item("Net_Cargo_Weight")
            End If

            If IsDBNull(rd.Item("Check_ISO_Tank")) Then
                cbISO.Checked = False
            Else
                cbISO.Checked = rd.Item("Check_ISO_Tank")
            End If


            If IsDBNull(rd.Item("ISO_Truck_Out_Date")) Then
                dtpISO.Text = ""
            Else
                dtpISO.Text = rd.Item("ISO_Truck_Out_Date")
            End If


            If IsDBNull(rd.Item("ISO_Tank_Weight_Lower")) Then
                tbISOTankWeightLower.Text = ""
            Else
                tbISOTankWeightLower.Text = rd.Item("ISO_Tank_Weight_Lower")
            End If

            If IsDBNull(rd.Item("ISO_Tank_Weight_Upper")) Then
                tbISOTankWeightUpper.Text = ""
            Else
                tbISOTankWeightUpper.Text = rd.Item("ISO_Tank_Weight_Upper")
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
                checkWarehouse = False
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
                checkWarehouseCheckpoint = False
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
                checkDriver = False
            End If
            If Not IsDBNull(rd.Item("Security_Check")) Then
                checkSecurityCheck = rd.Item("Security_Check")
            Else
                checkSecurityCheck = False
            End If

            If Not IsDBNull(rd.Item("Cargo_Weight_Check")) Then
                checkCargoWeight = rd.Item("Cargo_Weight_Check")
            Else
                checkCargoWeight = True
            End If

            If Not IsDBNull(rd.Item("Cargo_Weight_Check_Value")) Then
                tbCargoChecking.Text = rd.Item("Cargo_Weight_Check_Value")
            Else
                tbCargoChecking.Text = ""
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

            If IsDBNull(rd.Item("Security_Check_ISO_Truck_Out_Date")) Then
                dtpISOCheck.Text = ""
            Else
                dtpISOCheck.Text = rd.Item("Security_Check_ISO_Truck_Out_Date")
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
        ElseIf My.Settings.role_id = 3 Or My.Settings.role_id = 4 Then
            tbLinerSealNo.PasswordChar = "*"
            tbInternalSealNo.PasswordChar = "*"
        End If

        If checkTempSealNo = True Then
            cmbCheckTempSealNo.SelectedItem = "YES"
        Else
            cmbCheckTempSealNo.SelectedItem = "NO"
        End If

        'Come From report page
        If My.Settings.adminCheck = False Then
            For Each ctrl As Control In Panel3.Controls
                ctrl.Enabled = False
            Next
            btnPrint.Enabled = True
            btnCancel.Enabled = True
            lblCargoWeight.Enabled = True
            btnAdminSave.Visible = False
            btnCargoCheck.Visible = False
        ElseIf My.Settings.role_id <> 1 And My.Settings.adminCheck = True Then
            For Each ctrl As Control In Panel3.Controls
                ctrl.Enabled = False
            Next
            btnPrint.Enabled = True
            btnCancel.Enabled = True
            lblCargoWeight.Enabled = True
        Else

        End If

        If My.Settings.role_id = 6 Then
            For Each ctrl As Control In Panel3.Controls
                ctrl.Enabled = True
            Next
        End If
        'If My.Settings.role_id <> 1 And My.Settings.adminCheck = True Then

        'End If

        'If My.Settings.role_id = 1 And My.Settings.adminCheck = True Then
        '    btnAdminSave.Enabled = True
        'Else
        '    btnAdminSave.Enabled = False
        'End If

        GlobalFunction.checkPostBoxWithCargo(cbShippingPost, cbWarehousePost, cbSecurityPost, checkShippingPost, checkWarehousePost, checkSecurityPost, checkCargoWeight, lblCargoWeight, checkSecurityCheck)

        If checkSecurityPost = False And checkCargoWeight = False Then
            btnCargoCheck.Enabled = True
        Else
            btnCargoCheck.Enabled = False
        End If

        If cbISO.Checked Then
            lblChecking.Text = "ISO Tank Check"
            cbWarehousePost.Visible = False
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

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If (My.Settings.languageSetting = "fr") Then
            GlobalFunction.printPageFrench(e, Panel2, checkTempSealNo, Me.TruckOutNumber)
        Else
            GlobalFunction.printPage(e, Panel2, checkTempSealNo, Me.TruckOutNumber)
        End If

    End Sub

    Private Sub BtnAdminSave_Click(sender As Object, e As EventArgs) Handles btnAdminSave.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        'Try
        con.Open()
        If cbISO.Checked Then
            cmd.CommandText =
                    "update Shipping set
                        Reversion ='" + "R-S" + "',
                        ORIGIN = @Origin,
                        INVOICE = @Invoice,
                        PRODUCT= @Product,
                        SHIPMENT_CLOSING_DATE = @Shipment_Closing_Date,
                        SHIPMENT_CLOSING_TIME= @Shipment_Closing_Time,
                        SHIPPING_LINE= @Shipping_Line,
                        Container_Size = @Container_Size,
                        HAULIER = @Haulier,
                        LOADING_PORT= @Loading_Port,
                        CONTAINER_NO= @Container_No,
                        DDB= @DDB,
                        Product_Type = @Product_Type,
                        Check_ISO_Tank = @Check_ISO_Tank, 
                        ISO_Truck_Out_Date = @ISO_Truck_Out_Date , 
                        ISO_Tank_Weight_Lower = @ISO_Tank_Weight_Lower,
                        ISO_Tank_Weight_Upper = @ISO_Tank_Weight_Upper, 
                        Shipping_Post = 1,
                        Last_Modified_User = @Shipping_Post_User,
                        Shipping_Post_Time= @Shipping_Post_Time, 
                        Internal_Seal_No = @Internal_Seal_No,
                        Company = @Company,
                        ES_Seal_No = @ES_Seal_No
                        WHERE ID = @TruckOutNumber"
            cmd.Parameters.AddWithValue("@Origin", cmbCompany.Text)
            cmd.Parameters.AddWithValue("@Shipment_Closing_Date", dtpSCD.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@Shipment_Closing_Time", dtpSCT.Value.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@Invoice", tbInvoice.Text)
            cmd.Parameters.AddWithValue("@Product", tbProduct.Text)
            cmd.Parameters.AddWithValue("@Shipping_Line", tbShippingLine.Text)
            cmd.Parameters.AddWithValue("@Container_Size", cmbContainerSize.Text)
            cmd.Parameters.AddWithValue("@Haulier", tbHaulier.Text)
            cmd.Parameters.AddWithValue("@Loading_Port", cmbLoadingPort.Text)
            cmd.Parameters.AddWithValue("@Container_No", GlobalFunction.TrimSpace(tbContainerNo.Text))
            cmd.Parameters.AddWithValue("@DDB", cmbDDB.Text)
            cmd.Parameters.AddWithValue("@Product_Type", cmbProductType.Text)
            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
            cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Lower", tbISOTankWeightLower.Text)
            cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Upper", tbISOTankWeightUpper.Text)
            cmd.Parameters.AddWithValue("@Internal_Seal_No", tbInternalSealNo.Text)
            cmd.Parameters.AddWithValue("@Shipping_Post_User", My.Settings.username)
            cmd.Parameters.AddWithValue("@Shipping_Post_Time", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@Company", tbSendToCompany.Text)
            cmd.Parameters.AddWithValue("@ES_Seal_No", cmbEsSealNo.Text)
        Else
            cmd.CommandText =
                    "update Shipping set 
                    Reversion='" + "R-S" + "',
                    ORIGIN = @Origin,
                    INVOICE = @Invoice,
                    PRODUCT= @Product,
                    SHIPMENT_CLOSING_DATE = @Shipment_Closing_Date,
                    SHIPMENT_CLOSING_TIME= @Shipment_Closing_Time,
                    SHIPPING_LINE= @Shipping_Line,
                    Container_Size = @Container_Size,
                    HAULIER = @Haulier,
                    Shipping_Post = 1,
                    LOADING_PORT= @Loading_Port,
                    CONTAINER_NO= @Container_No,
                    Liner_Sea_No = @Liner_Seal_No,
                    INTERNAL_SEAL_NO= @Internal_Seal_No,
                    TEMPORARY_SEAL_NO= @Temporary_Seal_No,
                    Last_Modified_User = @Shipping_Post_User,
                    Update_Time= @Shipping_Post_Time,
                    DDB= @DDB,
                    checkTempSealNo = @checkTempSealNo,
                    Product_Type = @Product_Type ,
                    Net_Cargo_Weight =@Net_Cargo_Weight,
                    Check_ISO_Tank = @Check_ISO_Tank,
                    Company = @Company,
                    ES_Seal_No = @ES_Seal_No
                    WHERE ID = @TruckOutNumber"
            cmd.Parameters.AddWithValue("@Origin", cmbCompany.Text)
            cmd.Parameters.AddWithValue("@Shipment_Closing_Date", dtpSCD.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@Shipment_Closing_Time", dtpSCT.Value.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@Invoice", tbInvoice.Text)
            cmd.Parameters.AddWithValue("@Product", tbProduct.Text)
            cmd.Parameters.AddWithValue("@Shipping_Line", tbShippingLine.Text)
            cmd.Parameters.AddWithValue("@Container_Size", cmbContainerSize.Text)
            cmd.Parameters.AddWithValue("@Haulier", tbHaulier.Text)
            cmd.Parameters.AddWithValue("@Loading_Port", cmbLoadingPort.Text)
            cmd.Parameters.AddWithValue("@Container_No", GlobalFunction.TrimSpace(tbContainerNo.Text))
            cmd.Parameters.AddWithValue("@Liner_Seal_No", GlobalFunction.TrimSpace(tbLinerSealNo.Text))
            cmd.Parameters.AddWithValue("@Temporary_Seal_No", GlobalFunction.TrimSpace(tbTempSeal.Text))
            cmd.Parameters.AddWithValue("@Internal_Seal_No", GlobalFunction.TrimSpace(tbInternalSealNo.Text))
            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
            cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)
            cmd.Parameters.AddWithValue("@Shipping_Post_User", My.Settings.username)
            cmd.Parameters.AddWithValue("@Shipping_Post_Time", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@DDB", cmbDDB.Text)
            cmd.Parameters.AddWithValue("@Product_Type", cmbProductType.Text)
            cmd.Parameters.AddWithValue("@Net_Cargo_Weight", tbCargo.Text)
            cmd.Parameters.AddWithValue("@Company", tbSendToCompany.Text)
            cmd.Parameters.AddWithValue("@ES_Seal_No", cmbEsSealNo.Text)
        End If
        rd = cmd.ExecuteReader
            con.Close()

            con.Open()
        cmd.CommandText = "update Warehouse set 
            ES_Seal_No = @ES_Seal_No_Warehouse,
            WAREHOUSE_LOCATION = @Warehouse_Location,
            LOADING_BAY= @Loading_Bay,
            Update_Time = @Update_Time1, 
            Update_User = @Update_User1,
            LOADING_COMPLETED_TIME= @Loading_Completed_Time,
            LOADING_COMPLETED_DATE= @Loading_Completed_Date,
            READY_TRUCK_OUT_TIME = @Ready_Truck_Out_Time,
            READY_TRUCK_OUT_DATE= @Ready_Truck_Out_Date,
            COMPANY = @SendToCompany 
            where  Shipping_ID= @TruckOutNumber1"
        cmd.Parameters.AddWithValue("@ES_Seal_No_Warehouse", tbEsSealNo.Text)
        cmd.Parameters.AddWithValue("@TruckOutNumber1", Me.TruckOutNumber)
            cmd.Parameters.AddWithValue("@Warehouse_Location", cmbWarehouseLocation.Text)
            cmd.Parameters.AddWithValue("@Loading_Bay", tbLoadingBay.Text)
        cmd.Parameters.AddWithValue("@Update_Time1", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        cmd.Parameters.AddWithValue("@Update_User1", My.Settings.username)
        cmd.Parameters.AddWithValue("@Loading_Completed_Time", dtpLCT.Value.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@Loading_Completed_Date", dtpLCD.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@Ready_Truck_Out_Time", dtpRTT.Value.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@Ready_Truck_Out_Date", dtpRTD.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@SendToCompany", tbSendToCompany.Text)
            rd = cmd.ExecuteReader
            con.Close()

        con.Open()
        If cbISO.Checked Then
            cmd.CommandText = "Update Security set 
            Driver_Full_Name = @Driver_Full_Name,
            PM_CODE = @PM_CODE,
            PM_REGISTRATION_PLATE = @PM_REGISTRATION_PLATE,
            Security_Check_ISO_Tank_Weight = @Security_Check_ISO_Tank_Weight,
            Security_Check_ISO_Truck_Out_Date = @Security_Check_ISO_Truck_Out_Date 
            where  Shipping_ID= @TruckOutNumber5”
            cmd.Parameters.AddWithValue("@Security_Check_ISO_Tank_Weight", tbSecurityCheckISOTankWeight.Text)
            cmd.Parameters.AddWithValue("@Security_Check_ISO_Truck_Out_Date", dtpISOCheck.Value.ToString("yyyy-MM-dd"))
        Else
            cmd.CommandText = "Update Security set 
            Driver_Full_Name = @Driver_Full_Name,
            PM_CODE = @PM_CODE,
            PM_REGISTRATION_PLATE = @PM_REGISTRATION_PLATE,
            Cargo_Weight_Check_Value = @Cargo_Weight_Check_Value
            where  Shipping_ID= @TruckOutNumber5”
            cmd.Parameters.AddWithValue("@Cargo_Weight_Check_Value", tbCargoChecking.Text)
        End If

        cmd.Parameters.AddWithValue("@TruckOutNumber5", Me.TruckOutNumber)
            cmd.Parameters.AddWithValue("@Driver_Full_Name", cmbFullName.Text)
            cmd.Parameters.AddWithValue("@PM_CODE", cmbPmCode.Text)
        cmd.Parameters.AddWithValue("@PM_REGISTRATION_PLATE", cmbPmRegistrationPlate.Text)
        rd = cmd.ExecuteReader
            con.Close()

            MessageBox.Show(stringUpdateComplete, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCancel.PerformClick()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, stringUpdateFailed, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    'Private Sub btnCargoCheck_Click(sender As Object, e As EventArgs) Handles btnCargoCheck.Click
    '    Dim con As New SqlConnection
    '    Dim cmd As New SqlCommand
    '    Dim rd As SqlDataReader
    '    con.ConnectionString = My.Settings.connstr
    '    cmd.Connection = con
    '    con.Open()
    '    cmd.CommandText = "update Security set Allow_To_Post = 1 ,Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "'where shipping_ID = @TruckOutNumber"
    '    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
    '    rd = cmd.ExecuteReader
    '    MessageBox.Show("This Number Can Be Posted By Security Now", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub
End Class