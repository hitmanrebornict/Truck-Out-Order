﻿Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Truck_Out_Order.My.Resources

Public Class SecurityEdit

    Public TruckOutNumber As Integer
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private checkTempSealNo As Boolean
    Private checkDriver As Boolean
    Private checkSecurityCheck As Boolean
    Private checkWarehouse As Boolean
    Private checkShippingPost As Boolean
    Private checkWarehousePost As Boolean
    Private checkSecurityPost As Boolean
    Private checkCargoWeight As Boolean
    Private companyNameHeader As String
    Private checkAllowToPost As Boolean
    Private netCargoWeight As Integer
    Private ISOTankWeight As Integer
    Private ISOTODValue As Date
    Private checkDDB As Boolean

    Private stringCheckDriverFullName,
            stringCheckPMCode,
            stringCheckPMRegistrationPlate,
            stringCheckFailure,
            stringDriverValidationPass,
            stringDriverValidationFail,
            stringValidationFail,
            stringValidationPass,
            stringCheckSecurityCheck,
            stringPostFailed,
            stringInformShippingAdmin,
            stringTruckOutDateError,
            stringPostComplete,
            stringComplete,
            stringISOCheckFailed,
            stringInformWarehouseAdmin,
            stringNetCargoCheckFailed,
            stringCheckQuit,
            stringCloseApplication,
            stringCanBePosted,
            stringUpdateComplete,
            stringISOCheckComplete,
            stringCheckContainerNo,
            stringCheckInternalSealNo,
            stringCheckComplete,
            stringCheckFail,
            stringUpdateFailure,
            stringCheckESSealNo,
            stringCheckTemporarySealNo,
            stringFillCargoWeight,
            stringSecurityCheckComplete,
            stringStopCTNR,
            stringCheckLinerSealNo,
            stringISOApprove,
            stringISOCheck,
            stringCargoApprove,
            stringSecurityCheck As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (My.Settings.languageSetting = "fr") Then
            btnCancel.Text = ResourceSecurityEditFrench.btnCancel
            btnSecurityPost.Text = ResourceSecurityEditFrench.btnPost
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
            lblSOTruckOutDate.Text = ResourceSecurityEditFrench.lblISOTruckOutDate
            lblCompanyFullName1.Text = ResourceSecurityEditFrench.lblCompanyFullName1
            lblDriverCheck.Text = ResourceSecurityEditFrench.lblDriverCheck
            lblPmCode.Text = ResourceSecurityEditFrench.lblPMCode
            lblPmRegistrationPlate.Text = ResourceSecurityEditFrench.lblPMRegistrationPlate
            lblSecurityCheck.Text = ResourceSecurityEditFrench.lblSecurityCheck
            lblISOTruckOutDateCheck.Text = ResourceSecurityEditFrench.lblISOTruckOutDateCheck
            lblISOTankWeightCheck.Text = ResourceSecurityEditFrench.lblISOTankWeightCheck
            lblISOCheck.Text = ResourceSecurityEditFrench.lblISOCheck
            stringCheckDriverFullName = ResourceSecurityEditFrench.stringCheckDriverFullName
            stringCheckPMRegistrationPlate = ResourceSecurityEditFrench.stringCheckPMRegistrationPlate
            stringCheckFailure = ResourceSecurityEditFrench.stringCheckFailure
            stringDriverValidationPass = ResourceSecurityEditFrench.stringDriverValidationPass
            stringDriverValidationFail = ResourceSecurityEditFrench.stringDriverValidationFail
            stringValidationFail = ResourceSecurityEditFrench.stringValidationFail
            stringValidationPass = ResourceSecurityEditFrench.stringValidationPass
            stringCheckSecurityCheck = ResourceSecurityEditFrench.stringCheckSecurityCheck
            stringPostFailed = ResourceSecurityEditFrench.stringPostFailed
            stringInformShippingAdmin = ResourceSecurityEditFrench.stringInformShippingAdmin
            stringTruckOutDateError = ResourceSecurityEditFrench.stringTruckOutDateError
            stringPostComplete = ResourceSecurityEditFrench.stringPostComplete
            stringComplete = ResourceSecurityEditFrench.stringComplete
            stringISOCheckFailed = ResourceSecurityEditFrench.stringISOCheckFailed
            stringInformWarehouseAdmin = ResourceSecurityEditFrench.stringInformWarehouseAdmin
            stringNetCargoCheckFailed = ResourceSecurityEditFrench.stringNetCargoCheckFailed
            stringCheckQuit = ResourceSecurityEditFrench.stringCheckQuit
            stringCloseApplication = ResourceSecurityEditFrench.stringCloseApplication
            stringCanBePosted = ResourceSecurityEditFrench.stringCanBePosted
            stringUpdateComplete = ResourceSecurityEditFrench.stringUpdateComplete
            stringISOCheckComplete = ResourceSecurityEditFrench.stringISOCheckComplete
            stringCheckContainerNo = ResourceSecurityEditFrench.stringCheckContainerNo
            stringCheckInternalSealNo = ResourceSecurityEditFrench.stringCheckInternalSealNo
            stringCheckComplete = ResourceSecurityEditFrench.stringCheckComplete
            stringCheckFail = ResourceSecurityEdit.stringCheckFail
            stringUpdateFailure = ResourceSecurityEditFrench.stringUpdateFailure
            stringCheckESSealNo = ResourceSecurityEditFrench.stringCheckESSealNo
            stringCheckTemporarySealNo = ResourceSecurityEditFrench.stringCheckTemporarySealNo
            stringFillCargoWeight = ResourceSecurityEditFrench.stringFillCargoWeight
            stringSecurityCheckComplete = ResourceSecurityEditFrench.stringSecurityCheckComplete
            stringStopCTNR = ResourceSecurityEditFrench.stringStopCTNR
            stringCheckLinerSealNo = ResourceSecurityEditFrench.stringCheckLinerSealNo
            stringISOApprove = ResourceSecurityEditFrench.stringISOApprove
            stringISOCheck = ResourceSecurityEditFrench.stringISOCheck
            stringCargoApprove = ResourceSecurityEditFrench.stringISOApprove
            stringSecurityCheck = ResourceSecurityEditFrench.stringSecurityCheck
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
            GlobalFunction.ChangeFont(lblSOTruckOutDate, 10)
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
            btnSecurityPost.Font = New Font("Helvetica", 9)
            btnDriverCheck.Font = New Font("Helvetica", 9)
            btnSecurityCheck.Font = New Font("Helvetica", 8)
        Else
            btnCancel.Text = ResourceSecurityEdit.btnCancel
            btnSecurityPost.Text = ResourceSecurityEdit.btnPost
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
            lblSOTruckOutDate.Text = ResourceSecurityEdit.lblISOTruckOutDate
            lblCompanyFullName.Text = ResourceSecurityEdit.lblCompanyFullName1
            lblDriverCheck.Text = ResourceSecurityEdit.lblDriverCheck
            lblPmCode.Text = ResourceSecurityEdit.lblPMCode
            lblPmRegistrationPlate.Text = ResourceSecurityEdit.lblPMRegistrationPlate
            lblSecurityCheck.Text = ResourceSecurityEdit.lblSecurityCheck
            lblISOTruckOutDateCheck.Text = ResourceSecurityEdit.lblISOTruckOutDateCheck
            lblISOTankWeightCheck.Text = ResourceSecurityEdit.lblISOTankWeightCheck
            stringCheckDriverFullName = ResourceSecurityEdit.stringCheckDriverFullName
            stringCheckPMRegistrationPlate = ResourceSecurityEdit.stringCheckPMRegistrationPlate
            stringCheckFailure = ResourceSecurityEdit.stringCheckFailure
            stringDriverValidationPass = ResourceSecurityEdit.stringDriverValidationPass
            stringDriverValidationFail = ResourceSecurityEdit.stringDriverValidationFail
            stringValidationFail = ResourceSecurityEdit.stringValidationFail
            stringValidationPass = ResourceSecurityEdit.stringValidationPass
            stringCheckSecurityCheck = ResourceSecurityEdit.stringCheckSecurityCheck
            stringPostFailed = ResourceSecurityEdit.stringPostFailed
            stringInformShippingAdmin = ResourceSecurityEdit.stringInformShippingAdmin
            stringTruckOutDateError = ResourceSecurityEdit.stringTruckOutDateError
            stringPostComplete = ResourceSecurityEdit.stringPostComplete
            stringComplete = ResourceSecurityEdit.stringComplete
            stringISOCheckFailed = ResourceSecurityEdit.stringISOCheckFailed
            stringInformWarehouseAdmin = ResourceSecurityEdit.stringInformWarehouseAdmin
            stringNetCargoCheckFailed = ResourceSecurityEdit.stringNetCargoCheckFailed
            stringCheckQuit = ResourceSecurityEdit.stringCheckQuit
            stringCloseApplication = ResourceSecurityEdit.stringCloseApplication
            stringCanBePosted = ResourceSecurityEdit.stringCanBePosted
            stringUpdateComplete = ResourceSecurityEdit.stringUpdateComplete
            stringISOCheckComplete = ResourceSecurityEdit.stringISOCheckComplete
            stringCheckContainerNo = ResourceSecurityEdit.stringCheckContainerNo
            stringCheckInternalSealNo = ResourceSecurityEdit.stringCheckInternalSealNo
            stringCheckComplete = ResourceSecurityEdit.stringCheckComplete
            stringCheckFail = ResourceSecurityEdit.stringCheckFail
            stringUpdateFailure = ResourceSecurityEdit.stringUpdateFailure
            stringCheckESSealNo = ResourceSecurityEdit.stringCheckESSealNo
            stringCheckTemporarySealNo = ResourceSecurityEdit.stringCheckTemporarySealNo
            stringFillCargoWeight = ResourceSecurityEdit.stringFillCargoWeight
            stringSecurityCheckComplete = ResourceSecurityEdit.stringSecurityCheckComplete
            stringStopCTNR = ResourceSecurityEdit.stringStopCTNR
            stringCheckLinerSealNo = ResourceSecurityEdit.stringCheckLinerSealNo
            lblISOCheck.Text = ResourceSecurityEdit.lblISOCheck
            stringISOApprove = ResourceSecurityEdit.stringISOApprove
            stringISOCheck = ResourceSecurityEdit.stringISOCheck
            stringCargoApprove = ResourceSecurityEdit.stringISOApprove
            stringSecurityCheck = ResourceSecurityEdit.stringSecurityCheck
        End If
        GlobalFunction.TopHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)
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
                ISOTODValue = Date.Now
            Else
                ISOTODValue = rd.Item("ISO_Truck_Out_Date")
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
                checkWarehouse = True
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

            If IsDBNull(rd.Item("Security_Check_ISO_Truck_Out_Date")) Then
                dtpISOCheck.Text = ""
            Else
                dtpISOCheck.Text = rd.Item("Security_Check_ISO_Truck_Out_Date")
            End If
        End If
        con.Close()

        'Read the full_name into lblcompanyfullname and lblLoadingport
        GlobalFunction.loadFullNameIntoLabel(cmbCompany, cmbLoadingPort, lblCompanyFullName, lblLoadingPortFullName)

        GlobalFunction.checkPostBoxWithCargo(cbShippingPost, cbWarehousePost, cbSecurityPost, checkShippingPost, checkWarehousePost, checkSecurityPost, checkCargoWeight, lblCargoWeight, checkSecurityCheck
                                             )

        'Driver Check Button Visible
        If checkDriver = True Then
            btnDriverCheck.Visible = False
            btnSecurityCheck.Enabled = True
            cmbFullName.Enabled = False
            cmbPmCode.Enabled = False
            cmbPmRegistrationPlate.Enabled = False

        Else
            btnDriverCheck.Visible = True
            btnSecurityPost.Enabled = False
            btnSecurityCheck.Enabled = False
        End If


        'IF ES_SEAL_NO = False then textbox11 can't be enabled
        If cmbEsSealNo.Text = "NO" Then
            tbSecurityCheckEsSealNo.Enabled = False
        End If


        'Fill in security check field
        If checkSecurityCheck = True Then
            btnSecurityPost.Enabled = True
            'btnSecurityCheck.Enabled = False
            tbSecurityCheckContainerNo.Text = tbContainerNo.Text
            tbSecurityCheckLinerSealNo.Text = tbLinerSealNo.Text
            tbSecurityCheckInternalSealNo.Text = tbInternalSealNo.Text
            tbSecurityCheckTemporarySealNo.Text = tbTempSeal.Text
            tbSecurityCheckEsSealNo.Text = tbEsSealNo.Text
            'tbCheckCargoWeight.Enabled = False
            'tbSecurityCheckISOTankWeight.Enabled = False
            dtpISO.Visible = True
            dtpISO.Enabled = False
            'tbISOTankWeightLower.Enabled = False
            'tbISOTankWeightUpper.Enabled = False
            'tbSecurityCheckISOTankWeight.Enabled = False
            'dtpISOCheck.Enabled = False


            If My.Settings.role_id <> 5 Or My.Settings.role_id = 2 Then
                btnSecurityCheck.Enabled = True
                btnSecurityCheck.Visible = True
                btnSecurityPost.Enabled = False
                dtpISO.Enabled = True
                dtpISO.Visible = True
                tbISOTankWeightLower.Enabled = True
                tbISOTankWeightUpper.Enabled = True
                dtpISO.Value = ISOTODValue
                dtpISOCheck.Enabled = False
                tbISOTankWeightLower.Enabled = False
                tbISOTankWeightUpper.Enabled = False
            ElseIf My.Settings.role_id = 3 Or My.Settings.role_id = 4 Then
                btnSecurityCheck.Enabled = True
                btnSecurityCheck.Visible = True
                btnSecurityPost.Enabled = False
            End If
        Else
        End If

        If My.Settings.role_id = 5 And cmbDDB.Text = "No" Then
            tbContainerNo.PasswordChar = "*"
            tbEsSealNo.PasswordChar = "*"
            tbInternalSealNo.PasswordChar = "*"
            tbLinerSealNo.PasswordChar = "*"
            tbTempSeal.PasswordChar = "*"
            tbCargo1.PasswordChar = "*"
            tbISOTankWeightLower.PasswordChar = "*"
            tbISOTankWeightUpper.PasswordChar = "*"
            tbISOTankWeightLower.Enabled = False
            tbISOTankWeightUpper.Enabled = False
            checkDDB = False
        Else
            tbContainerNo.PasswordChar = "*"
            tbEsSealNo.PasswordChar = "*"
            tbTempSeal.PasswordChar = "*"
            tbCargo1.PasswordChar = "*"
            tbISOTankWeightLower.PasswordChar = "*"
            tbISOTankWeightUpper.PasswordChar = "*"
            tbISOTankWeightLower.Enabled = False
            tbISOTankWeightUpper.Enabled = False
            tbSecurityCheckInternalSealNo.Enabled = False
            tbSecurityCheckLinerSealNo.Enabled = False
            checkDDB = True
        End If


        If checkTempSealNo Then
            cmbCheckTempSealNo.SelectedItem = "YES"
            cmbCheckTempSealNo.Text = "YES"
            If My.Settings.role_id = 5 Then
                tbSecurityCheckTemporarySealNo.Enabled = True
            End If
        Else
            tbSecurityCheckTemporarySealNo.Enabled = False
            cmbCheckTempSealNo.SelectedItem = "NO"
            cmbCheckTempSealNo.Text = "NO"
        End If

        'cbpost checkin

        cbISO.Enabled = False
        If cbISO.Checked Then
            lblChecking.Text = "ISO Tank Check"
            cbWarehousePost.Visible = False
            If My.Settings.role_id <> 5 Then
                btnSecurityCheck.Text = stringISOApprove
            Else
                btnSecurityCheck.Text = stringISOCheck
            End If
            tbSecurityCheckLinerSealNo.Enabled = False
            tbSecurityCheckEsSealNo.Enabled = False
            tbSecurityCheckTemporarySealNo.Enabled = False
            tbCheckCargoWeight.Enabled = False
            tlpISO.Enabled = True
        Else
            If My.Settings.role_id <> 5 Then
                btnSecurityCheck.Text = stringCargoApprove
            Else
                btnSecurityCheck.Text = stringSecurityCheck
            End If
        End If

        'If ISOTODValue <> "" Then
        dtpISO.Value = ISOTODValue
        'End If



        If checkSecurityPost = True Then
            btnSecurityCheck.Enabled = False
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
            MessageBox.Show(stringCheckDriverFullName, stringCheckFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbPmCode.Text = "" Then
            MessageBox.Show(stringCheckPMCode, stringCheckFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbPmRegistrationPlate.Text = "" Then
            MessageBox.Show(stringCheckPMRegistrationPlate, stringCheckFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmd.CommandText = "Select * from DRIVER_INFO where FULL_NAME = '" + cmbFullName.Text + "' and  PM_CODE = '" + cmbPmCode.Text + "' and  PM_REGISTRATION_PLATE = '" + cmbPmRegistrationPlate.Text + "'"
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                checkDriver = True
                checkRow = True
                cmbFullName.Enabled = False
                cmbPmCode.Enabled = False
                cmbPmRegistrationPlate.Enabled = False
                btnDriverCheck.Visible = False
                cmd = New SqlCommand("Insert Into Security (Shipping_ID,Driver_Full_Name,PM_CODE,PM_REGISTRATION_PLATE,DRIVER_CHECK,Update_Time,Update_User) values(@TruckOutNumber,'" + cmbFullName.Text + "','" + cmbPmCode.Text + "','" + cmbPmRegistrationPlate.Text + "',@Driver_Check,'" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + My.Settings.username + "')", con)
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("@Driver_Check", checkDriver)
            Else
                MessageBox.Show(stringDriverValidationFail, stringValidationFail, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
            If checkRow Then
                con.Open()
                rd = cmd.ExecuteReader
                con.Close()
                MessageBox.Show(stringDriverValidationPass, stringValidationPass, MessageBoxButtons.OK, MessageBoxIcon.Information)
                checkDriver = True
                btnSecurityCheck.Enabled = True
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

        If checkSecurityCheck = False Then
            MessageBox.Show(stringCheckSecurityCheck, stringPostFailed, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf checkSecurityCheck = True And checkAllowToPost = True Then
            If cbISO.Checked = True And dtpISOCheck.Value < ISOTODValue Then
                MessageBox.Show(stringInformShippingAdmin, stringTruckOutDateError, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.CommandText = "update Shipping set Security_Post = 1,Security_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Security_Post_User = '" + My.Settings.username + "' WHERE ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                rd = cmd.ExecuteReader
                MessageBox.Show(stringPostComplete, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnPrint.PerformClick()
            End If

            GlobalFunction.backToPage(Search, Me)
        ElseIf checkSecurityCheck = True And checkAllowToPost = False And cbISO.Checked Then
            MessageBox.Show(stringInformShippingAdmin, stringISOCheckFailed, MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf checkSecurityCheck = True And checkAllowToPost = False Then
            MessageBox.Show(stringInformWarehouseAdmin, stringNetCargoCheckFailed, MessageBoxButtons.OK, MessageBoxIcon.Error)

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
        If MsgBox(stringCheckQuit, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, stringCloseApplication) = Windows.Forms.DialogResult.Yes Then
            Dim obj As New Search
            obj.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnSecurityCheck_Click(sender As Object, e As EventArgs) Handles btnSecurityCheck.Click
        ''security check button click
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
                cmd.CommandText = "Update Shipping set ISO_Truck_Out_Date = @ISO_Truck_Out_Date, Last_Modified_User = @Last_Modified_User , Update_Time = @Update_Time  Where Id = @TruckOutNumber1"
                cmd.Parameters.AddWithValue("@TruckOutNumber1", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@Last_Modified_User", My.Settings.username)
                cmd.Parameters.AddWithValue("@Update_Time", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                rd = cmd.ExecuteReader
                con.Close()
                MessageBox.Show(stringCanBePosted, stringUpdateComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
                checkSecurityCheck = True

            Else
                Try
                    If Decimal.Parse(tbSecurityCheckISOTankWeight.Text) >= Decimal.Parse(tbISOTankWeightLower.Text) And Decimal.Parse(tbSecurityCheckISOTankWeight.Text) <= Decimal.Parse(tbISOTankWeightUpper.Text) And dtpISOCheck.Value >= ISOTODValue And String.Compare(tbSecurityCheckContainerNo.Text, tbContainerNo.Text) = 0 And String.Compare(tbSecurityCheckInternalSealNo.Text, tbInternalSealNo.Text) = 0 Then
                        'Check ISO Tank
                        checkAllowToPost = True
                        checkSecurityCheck = True
                        btnSecurityCheck.Enabled = False
                        tbSecurityCheckContainerNo.Enabled = False
                        tbSecurityCheckInternalSealNo.Enabled = False
                        dtpISO.Enabled = False
                        tbISOTankWeightLower.Enabled = False
                        tbISOTankWeightUpper.Enabled = False
                        tbSecurityCheckISOTankWeight.Enabled = False
                        dtpISO.Enabled = False
                        dtpISOCheck.Enabled = False
                        cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = @Security_Check ,Allow_To_Post = @Allow_To_Post, Security_Check_ISO_Tank_Weight = @Security_Check_ISO_Tank_Weight, Security_Check_ISO_Truck_Out_Date =  @Security_Check_ISO_Truck_Out_Date  WHERE Shipping_ID = @TruckOutNumber2"
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        cmd.Parameters.AddWithValue("@Allow_To_Post", checkAllowToPost)
                        cmd.Parameters.AddWithValue("@Security_Check_ISO_Tank_Weight", tbSecurityCheckISOTankWeight.Text)
                        cmd.Parameters.AddWithValue(“@Security_Check_ISO_Truck_Out_Date”， dtpISOCheck.Value.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@Security_Check", checkSecurityCheck)
                        rd = cmd.ExecuteReader
                        con.Close()
                        MessageBox.Show(stringISOCheckComplete, stringCheckComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btnSecurityCheck.Enabled = False
                        dtpISO.Visible = True
                    ElseIf Not String.Compare(tbSecurityCheckContainerNo.Text, tbContainerNo.Text) = 0 Then
                        MessageBox.Show(stringCheckContainerNo, stringCheckFail, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf Not String.Compare(tbSecurityCheckInternalSealNo.Text, tbInternalSealNo.Text) = 0 Then
                        MessageBox.Show(stringCheckInternalSealNo, stringCheckFail, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf dtpISOCheck.Value < ISOTODValue Or Decimal.Parse(tbSecurityCheckISOTankWeight.Text) < Decimal.Parse(tbISOTankWeightLower.Text) Or Decimal.Parse(tbSecurityCheckISOTankWeight.Text) > Decimal.Parse(tbISOTankWeightUpper.Text) Then
                        checkAllowToPost = False
                        checkSecurityCheck = True
                        'btnSecurityCheck.Enabled = False
                        'tbSecurityCheckContainerNo.Enabled = False
                        'dtpISO.Enabled = False
                        'tbISOTankWeightLower.Enabled = False
                        'tbISOTankWeightUpper.Enabled = False
                        'tbSecurityCheckISOTankWeight.Enabled = False
                        'dtpISO.Enabled = False
                        'dtpISOCheck.Enabled = False
                        cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = @Security_Check,Allow_To_Post = @Allow_To_Post, Security_Check_ISO_Tank_Weight = @Security_Check_ISO_Tank_Weight,  Security_Check_ISO_Truck_Out_Date =  @Security_Check_ISO_Truck_Out_Date  WHERE Shipping_ID = @TruckOutNumber2"
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        cmd.Parameters.AddWithValue("@Allow_To_Post", checkAllowToPost)
                        cmd.Parameters.AddWithValue("@Security_Check_ISO_Tank_Weight", tbSecurityCheckISOTankWeight.Text)
                        cmd.Parameters.AddWithValue(“@Security_Check_ISO_Truck_Out_Date”， dtpISOCheck.Value.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@Security_Check", checkSecurityCheck)
                        rd = cmd.ExecuteReader
                        con.Close()
                        MessageBox.Show(stringInformShippingAdmin, stringISOCheckFailed, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'btnSecurityCheck.Enabled = False
                        'dtpISO.Visible = True
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            If (My.Settings.role_id = 3 Or My.Settings.role_id = 4 Or My.Settings.role_id = 1) And My.Settings.adminCheck = True Then
                ' Allow Cargo Check TO Post
                cmd.CommandText = "update Security set Allow_To_Post = 1 ,Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "'where shipping_ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                rd = cmd.ExecuteReader
                con.Close()
                MessageBox.Show(stringCanBePosted, stringUpdateComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cmbEsSealNo.Text = "YES" And tbSecurityCheckEsSealNo.Text = "" Then
                MessageBox.Show(stringCheckESSealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckEsSealNo.Text <> tbEsSealNo.Text Then
                tbSecurityCheckEsSealNo.Enabled = False

            ElseIf tbSecurityCheckContainerNo.Text <> tbContainerNo.Text Then
                MessageBox.Show(stringCheckContainerNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckLinerSealNo.Text <> tbLinerSealNo.Text And checkDDB = False Then
                MessageBox.Show(stringCheckLinerSealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckInternalSealNo.Text <> tbInternalSealNo.Text And checkDDB = False Then
                MessageBox.Show(stringCheckInternalSealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckTemporarySealNo.Text <> tbTempSeal.Text Then
                MessageBox.Show(stringCheckTemporarySealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbCheckCargoWeight.Text = " " Then
                MessageBox.Show(stringFillCargoWeight, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Security Check Cargo Weight
                Try
                    If Integer.Parse(tbCheckCargoWeight.Text) >= tbCargo1.Text Then
                        checkCargoWeight = True
                        checkAllowToPost = True
                        checkSecurityCheck = True
                    Else
                        checkCargoWeight = False
                        checkAllowToPost = False
                        checkSecurityCheck = True
                    End If

                    cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = @Security_Check, Cargo_Weight_Check = @checkCargoWeight,Cargo_Weight_Check_Value = @cargoWeightCheckValue,Allow_To_Post = @Allow_To_Post WHERE Shipping_ID = @TruckOutNumber2"
                    cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                    cmd.Parameters.AddWithValue("@checkCargoWeight", checkCargoWeight)
                    cmd.Parameters.AddWithValue("@cargoWeightCheckValue", tbCheckCargoWeight.Text)
                    cmd.Parameters.AddWithValue("@Allow_To_Post", checkAllowToPost)
                    cmd.Parameters.AddWithValue("@Security_Check", checkSecurityCheck)
                    rd = cmd.ExecuteReader
                    con.Close()
                    If (checkCargoWeight) Then
                        MessageBox.Show(stringSecurityCheckComplete, stringCheckComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show(stringStopCTNR, stringCheckFail, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    checkSecurityCheck = True
                    'btnSecurityCheck.Enabled = False
                    'tbCheckCargoWeight.Enabled = False
                    'tbSecurityCheckContainerNo.Enabled = False
                    'tbSecurityCheckEsSealNo.Enabled = False
                    'tbSecurityCheckInternalSealNo.Enabled = False
                    'tbSecurityCheckLinerSealNo.Enabled = False
                    'tbSecurityCheckTemporarySealNo.Enabled = False
                Catch ex As Exception
                    MessageBox.Show(ex.Message, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

        If My.Settings.role_id = 5 Then
            btnSecurityPost.Enabled = True
        End If
    End Sub


End Class