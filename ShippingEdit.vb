Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.Remoting.Messaging
Imports Truck_Out_Order.My.Resources

Public Class ShippingEdit

    Public TruckOutNumber As Integer

    Private checkTempSealNo,
            checkShippingPost,
            checkWarehousePost,
            checkSecurityPost,
            checkWarehouseCheckpoint,
            checkCargoWeight,
            checkISO As Boolean

    Private stringCargoWeightEx,
            stringCloseApplication,
            stringComplete,
            stringFillCompany,
            stringFillContainerNo,
            stringFillContainerSize,
            stringFillDDB,
            stringFillHaulier,
            stringFillInternalSealNo,
            stringFillInvoice,
            stringFillISOTankWeight,
            stringFillISOTOD,
            stringFillLinerSealNo,
            stringFillLoadingPort,
            stringFillProduct,
            stringFillProductType,
            stringFillSCD,
            stringFillSCT,
            stringFillShippingLine,
            stringFillTempSealNo,
            stringPostCompleteAs,
            stringQuitChecking,
            stringSaveCompleteAs,
            stringUpdateFailure,
            stringPosted As String

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rd As SqlDataReader
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private companyNameHeader As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (My.Settings.languageSetting = "fr") Then
            btnCancel1.Text = ResourceShippingEditFrench.btnCancel
            btnPost1.Text = ResourceShippingEditFrench.btnPost
            btnSave1.Text = ResourceShippingEditFrench.btnSave
            btnPrint1.Text = ResourceShippingEditFrench.btnPrint
            lblCompany.Text = ResourceShippingEditFrench.lblCompnay
            lblContainerNo.Text = ResourceShippingEditFrench.lblContainerNo
            lblContainerSize.Text = ResourceShippingEditFrench.lblContainerSize
            lblDDB.Text = ResourceShippingEditFrench.lblDDB
            lblEsSealNo.Text = ResourceShippingEditFrench.lblEsSealNo
            lblFullName.Text = ResourceShippingEditFrench.lblFullName
            lblHaulier.Text = ResourceShippingEditFrench.lblHaulier
            lblInternalSealNo.Text = ResourceShippingEditFrench.lblInternalSealNo
            lblInvoice.Text = ResourceShippingEditFrench.lblInvoice
            lblISOTank.Text = ResourceShippingEditFrench.lblISOTank
            lblISOTankWeight.Text = ResourceShippingEditFrench.lblISOTankWeight
            lblNetCargoWeight.Text = ResourceShippingEditFrench.lblISOTruckOutDate
            lblLinerSealNo.Text = ResourceShippingEditFrench.lblLinerSealNo
            lblLoadingBay.Text = ResourceShippingEditFrench.lblLoadingBay
            lblLoadingPort.Text = ResourceShippingEditFrench.lblLoadingPort
            lblNetCargoWeight.Text = ResourceShippingEditFrench.lblNetCargoWeight
            lblPortFullName.Text = ResourceShippingEditFrench.lblPortFullName
            lblProduct.Text = ResourceShippingEditFrench.lblProduct
            lblSCD.Text = ResourceShippingEditFrench.lblSCD
            lblSCT.Text = ResourceShippingEditFrench.lblSCT
            lblSendToCompany.Text = ResourceShippingEditFrench.lblSendToCompany
            lblShippingLine.Text = ResourceShippingEditFrench.lblShippingLine
            lblTemporarySealNo.Text = ResourceShippingEditFrench.lblTemporarySealNo
            lblTruckOutNumber.Text = ResourceShippingEditFrench.lblTruckOutNumber
            lblWarehouseLocation.Text = ResourceShippingEditFrench.lblWarehouseLocation
            lblLCD.Text = ResourceShippingEditFrench.lblLCD
            lblLCT.Text = ResourceShippingEditFrench.lblLCT
            lblRTD.Text = ResourceShippingEditFrench.lblRTD
            lblRTT.Text = ResourceShippingEditFrench.lblRTT
            lblShippingPost.Text = ResourceShippingEditFrench.lblShippingPost
            lblWarehousePost.Text = ResourceShippingEditFrench.lblWarehousePost
            lblSecurityPost.Text = ResourceShippingEditFrench.lblSecurityPost
            lblSOTruckOutDate.Text = ResourceShippingEditFrench.lblISOTruckOutDate
            stringUpdateFailure = ResourceShippingEditFrench.stringUpdateFailure
            stringFillSCD = ResourceShippingEditFrench.stringFillSCD
            stringFillCompany = ResourceShippingEditFrench.stringFillCompany
            stringFillSCT = ResourceShippingEditFrench.stringFillSCT
            stringFillInvoice = ResourceShippingEditFrench.stringFillInvoice
            stringFillProduct = ResourceShippingEditFrench.stringFillProduct
            stringFillShippingLine = ResourceShippingEditFrench.stringFillShippingLine
            stringFillHaulier = ResourceShippingEditFrench.stringFillHaulier
            stringFillLoadingPort = ResourceShippingEditFrench.stringFillLoadingPort
            stringFillContainerSize = ResourceShippingEditFrench.stringFillContainerSize
            stringFillContainerNo = ResourceShippingEditFrench.stringFillContainerNo
            stringFillDDB = ResourceShippingEditFrench.stringFillDDB
            stringFillProductType = ResourceShippingEditFrench.stringFillProductType
            stringFillISOTOD = ResourceShippingEditFrench.stringFillISOTOD
            stringFillISOTankWeight = ResourceShippingEditFrench.stringFillISOTankWeight
            stringFillInternalSealNo = ResourceShippingEditFrench.stringFillInternalSealNo
            stringFillTempSealNo = ResourceShippingEditFrench.stringFillTempSealNo
            stringFillLinerSealNo = ResourceShippingEditFrench.stringFillLinerSealNo
            stringPostCompleteAs = ResourceShippingEditFrench.stringPostCompleteAs
            stringComplete = ResourceShippingEditFrench.stringComplete
            stringCargoWeightEx = ResourceShippingEditFrench.stringCargoWeightEx
            stringQuitChecking = ResourceShippingEditFrench.stringQuitChecking
            stringCloseApplication = ResourceShippingEditFrench.stringCloseApplication
            stringSaveCompleteAs = ResourceShippingEditFrench.stringSaveCompleteAs
            stringPosted = ResourceShippingEditFrench.stringPosted
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
            GlobalFunction.ChangeFontBold(lblTruckOutNumber, 14)
            GlobalFunction.ChangeFont(lblWarehouseLocation, 10)
            GlobalFunction.ChangeFont(lblLCD, 10)
            GlobalFunction.ChangeFont(lblLCT, 10)
            GlobalFunction.ChangeFont(lblRTD, 10)
            GlobalFunction.ChangeFont(lblRTT, 10)
            GlobalFunction.ChangeFontBold(lblShippingPost, 10)
            GlobalFunction.ChangeFontBold(lblWarehousePost, 10)
            GlobalFunction.ChangeFontBold(lblSecurityPost, 10)
            GlobalFunction.ChangeFont(lblSOTruckOutDate, 10)
            btnCancel1.Font = New Font("Helvetica", 9)
            btnPrint1.Font = New Font("Helvetica", 9)
            btnSave1.Font = New Font("Helvetica", 9)
            btnPost1.Font = New Font("Helvetica", 9)
        Else
            btnCancel1.Text = ResourceShippingEdit.btnCancel
            btnPost1.Text = ResourceShippingEdit.btnPost
            btnSave1.Text = ResourceShippingEdit.btnSave
            btnPrint1.Text = ResourceShippingEdit.btnPrint
            lblCompany.Text = ResourceShippingEdit.lblCompany
            lblContainerNo.Text = ResourceShippingEdit.lblContainerNo
            lblContainerSize.Text = ResourceShippingEdit.lblContainerSize
            lblDDB.Text = ResourceShippingEdit.lblDDB
            lblEsSealNo.Text = ResourceShippingEdit.lblEsSealNo
            lblFullName.Text = ResourceShippingEdit.lblFullName
            lblHaulier.Text = ResourceShippingEdit.lblHaulier
            lblInternalSealNo.Text = ResourceShippingEdit.lblInternalSealNo
            lblInvoice.Text = ResourceShippingEdit.lblInvoice
            lblISOTank.Text = ResourceShippingEdit.lblISOTank
            lblISOTankWeight.Text = ResourceShippingEdit.lblISOTankWeight
            lblNetCargoWeight.Text = ResourceShippingEdit.lblISOTruckOutDate
            lblLinerSealNo.Text = ResourceShippingEdit.lblLinerSealNo
            lblLoadingBay.Text = ResourceShippingEdit.lblLoadingBay
            lblLoadingPort.Text = ResourceShippingEdit.lblLoadingPort
            lblNetCargoWeight.Text = ResourceShippingEdit.lblNetCargoWeight
            lblPortFullName.Text = ResourceShippingEdit.lblPortFullName
            lblProduct.Text = ResourceShippingEdit.lblProduct
            lblSCD.Text = ResourceShippingEdit.lblSCD
            lblSCT.Text = ResourceShippingEdit.lblSCT
            lblSendToCompany.Text = ResourceShippingEdit.lblSendToCompany
            lblShippingLine.Text = ResourceShippingEdit.lblShippingLine
            lblTemporarySealNo.Text = ResourceShippingEdit.lblTemporarySealNo
            lblTruckOutNumber.Text = ResourceShippingEdit.lblTruckOutNumber
            lblWarehouseLocation.Text = ResourceShippingEdit.lblWarehouseLocation
            lblLCD.Text = ResourceShippingEdit.lblLCD
            lblLCT.Text = ResourceShippingEdit.lblLCT
            lblRTD.Text = ResourceShippingEdit.lblRTD
            lblRTT.Text = ResourceShippingEdit.lblRTT
            lblShippingPost.Text = ResourceShippingEdit.lblShippingPost
            lblWarehousePost.Text = ResourceShippingEdit.lblWarehousePost
            lblSecurityPost.Text = ResourceShippingEdit.lblSecurityPost
            lblSOTruckOutDate.Text = ResourceShippingEdit.lblISOTruckOutDate
            stringUpdateFailure = ResourceShippingEdit.stringUpdateFailure
            stringFillSCD = ResourceShippingEdit.stringFillSCD
            stringFillCompany = ResourceShippingEdit.stringFillCompany
            stringFillSCT = ResourceShippingEdit.stringFillSCT
            stringFillInvoice = ResourceShippingEdit.stringFillInvoice
            stringFillProduct = ResourceShippingEdit.stringFillProduct
            stringFillShippingLine = ResourceShippingEdit.stringFillShippingLine
            stringFillHaulier = ResourceShippingEdit.stringFillHaulier
            stringFillLoadingPort = ResourceShippingEdit.stringFillLoadingPort
            stringFillContainerSize = ResourceShippingEdit.stringFillContainerSize
            stringFillContainerNo = ResourceShippingEdit.stringFillContainerNo
            stringFillDDB = ResourceShippingEdit.stringFillDDB
            stringFillProductType = ResourceShippingEdit.stringFillProductType
            stringFillISOTOD = ResourceShippingEdit.stringFillISOTOD
            stringFillISOTankWeight = ResourceShippingEdit.stringFillISOTankWeight
            stringFillInternalSealNo = ResourceShippingEdit.stringFillInternalSealNo
            stringFillTempSealNo = ResourceShippingEdit.stringFillTempSealNo
            stringFillLinerSealNo = ResourceShippingEdit.stringFillLinerSealNo
            stringPostCompleteAs = ResourceShippingEdit.stringPostCompleteAs
            stringComplete = ResourceShippingEdit.stringComplete
            stringCargoWeightEx = ResourceShippingEdit.stringCargoWeightEx
            stringQuitChecking = ResourceShippingEdit.stringQuitChecking
            stringCloseApplication = ResourceShippingEdit.stringCloseApplication
            stringSaveCompleteAs = ResourceShippingEdit.stringSaveCompleteAs
            stringPosted = ResourceShippingEdit.stringPosted
        End If

        lblTooNumber.Text = Me.TruckOutNumber
        GlobalFunction.TopHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)


        'Disable for shipping
        tbEsSealNo.Enabled = False
        tbLoadingBay.Enabled = False
        cmbWarehouseLocation.Enabled = False
        cmbEsSealNo.Enabled = False
        dtpRTD.Enabled = False
        dtpLCD.Enabled = False
        dtpLCT.Enabled = False
        dtpRTT.Enabled = False
        tbSendToCompany.Enabled = False

        'Read item into combobox
        GlobalFunction.getCmbValue(cmbCompany, cmbLoadingPort, cmbWarehouseLocation, cmbContainerSize)
        GlobalFunction.getProductType(cmbProductType)

        'Read Data from Shipping Table
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
        '    checkTempSealNo,
        '    checkShippingPost,
        '    checkWarehousePost,
        '    checkSecurityPost
        '    )

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
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
                checkISO = False
            Else
                checkISO = rd.Item("Check_ISO_Tank")
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
        cmd.CommandText = "Select Shipping_id, warehouse_location, loading_bay,es_seal_no,loading_completed_date, CONVERT(varchar,loading_completed_time,8) as LCT, READY_TRUCK_OUT_DATE, CONVERT(varchar,ready_truck_out_time,8) as RCT, Warehouse_Checkpoint_Check from Warehouse where Shipping_ID = @TruckOutNumber2 "
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

            If IsDBNull(rd.Item("Warehouse_Checkpoint_Check")) Then
                checkWarehouseCheckpoint = False
            Else
                checkWarehouseCheckpoint = rd.Item("Warehouse_Checkpoint_Check")
            End If
        End While
        con.Close()

        'Read the full_name into lblcompanyfullname and lblLoadingport
        GlobalFunction.loadFullNameIntoLabel(cmbCompany, cmbLoadingPort, lblCompanyFullName, lblLoadingPortFullName)

        'show text in cmbCheckTempSeal
        If Me.checkTempSealNo = True Then
            cmbCheckTempSealNo.Text = "YES"
        Else
            cmbCheckTempSealNo.Text = "NO"
        End If


        If checkWarehouseCheckpoint = True Then
            tbContainerNo.Enabled = False
            tbEsSealNo.Enabled = False
            tbInternalSealNo.Enabled = False
            tbLinerSealNo.Enabled = False
            tbTempSeal.Enabled = False
            cmbEsSealNo.Enabled = False
            cmbCheckTempSealNo.Enabled = False
        End If

        'cbpost checkin
        GlobalFunction.checkPostBoxWithoutCargo(cbShippingPost, cbWarehousePost, cbSecurityPost, checkShippingPost, checkWarehousePost, checkSecurityPost)

        cbISO.Checked = checkISO
    End Sub


    Private Sub cmbCheckTempSealNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCheckTempSealNo.SelectedIndexChanged
        If cmbCheckTempSealNo.SelectedItem = "YES" Then
            tbTempSeal.Enabled = True
            checkTempSealNo = True
        Else
            tbTempSeal.Enabled = False
            checkTempSealNo = False
            tbTempSeal.Text = ""
        End If
    End Sub

    Private Sub btnShippingSave_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        Dim ra As Integer

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If checkShippingPost = False Then
            If cbISO.Checked Then
                cmd.CommandText = "update Shipping set ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "',Product_Type = '" + cmbProductType.Text + "', Check_ISO_Tank = @Check_ISO_Tank, ISO_Truck_Out_Date = @ISO_Truck_Out_Date, ISO_Tank_Weight_Lower = @ISO_Tank_Weight_Lower, ISO_Tank_Weight_Upper = @ISO_Tank_Weight_Upper,Internal_Seal_No = @Internal_Seal_No WHERE ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
                cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Lower", tbISOTankWeightLower.Text)
                cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Upper", tbISOTankWeightUpper.Text)
                cmd.Parameters.AddWithValue("@Internal_Seal_No", tbInternalSealNo.Text)
            Else
                cmd.CommandText = "update Shipping set ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "',LINER_SEA_NO='" + GlobalFunction.TrimSpace(tbLinerSealNo.Text) + "',INTERNAL_SEAL_NO='" + GlobalFunction.TrimSpace(tbInternalSealNo.Text) + "',TEMPORARY_SEAL_NO='" + GlobalFunction.TrimSpace(tbTempSeal.Text) + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo,Product_Type = '" + cmbProductType.Text + "' ,Net_Cargo_Weight ='" + tbCargo.Text + "', Check_ISO_Tank = @Check_ISO_Tank WHERE ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)
                cmd.Parameters.AddWithValue("@check_ISO_Tank", cbISO.Checked)
            End If

            ra = cmd.ExecuteNonQuery
            MessageBox.Show(stringSaveCompleteAs & " " & Me.TruckOutNumber, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalFunction.backToPage(Search, Me)
        Else
            MessageBox.Show(stringPosted, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        con.Close()

    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Show Company full name when the cmbcompany's value is changed
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

    'print button
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnPrint1.Click
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    'the details of print function
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        GlobalFunction.printPage(e, Panel2, checkTempSealNo, Me.TruckOutNumber)
    End Sub

    'change the company full name when the cmb selected value changed
    Private Sub cmbCompany_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbCompany.SelectedIndexChanged
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

    'change the loading port full name when the cmb selected value changed
    Private Sub cmbLoadingPort_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbLoadingPort.SelectedIndexChanged
        'show the full name of loading port when the cmblodingport's value is changed
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

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost1.Click
        'Post button
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If dtpSCD.Text = "" Then
            MessageBox.Show(stringFillSCD, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbCompany.Text = "" Then
            MessageBox.Show(stringFillCompany, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpSCT.Text = "" Then
            MessageBox.Show(stringFillSCT, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbInvoice.Text = "" Then
            MessageBox.Show(stringFillInvoice, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbProduct.Text = "" Then
            MessageBox.Show(stringFillProduct, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbShippingLine.Text = "" Then
            MessageBox.Show(stringFillShippingLine, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbHaulier.Text = "" Then
            MessageBox.Show(stringFillHaulier, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbLoadingPort.Text = "" Then
            MessageBox.Show(stringFillLoadingPort, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbContainerSize.Text = "" Then
            MessageBox.Show(stringFillContainerSize, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbContainerNo.Text = "" Then
            MessageBox.Show(stringFillContainerNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbDDB.Text = "" Then
            MessageBox.Show(stringFillDDB, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbProductType.Text = "" Then
            MessageBox.Show(stringFillProductType, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If cbISO.Checked Then
                If dtpISO.Text = "" Then
                            MessageBox.Show(stringFillISOTOD, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ElseIf tbISOTankWeightLower.Text = "" Or tbISOTankWeightUpper.Text = "" Then
                            MessageBox.Show(stringFillISOTankWeight, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ElseIf checkShippingPost = True And My.Settings.adminCheck = True Then
                    cmd.CommandText = "update Shipping set Reversion='" + "R-S" + "',ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "',Product_Type = '" + cmbProductType.Text + "' ,Net_Cargo_Weight ='" + tbCargo.Text + "',Check_ISO_Tank = @Check_ISO_Tank, ISO_Truck_Out_Date = @ISO_Truck_Out_Date, ISO_Tank_Weight_Lower = @ISO_Tank_Weight_Lower, ISO_Tank_Weight_Upper = @ISO_Tank_Weight_Upper,Internal_Seal_No = @Internal_Seal_No WHERE ID = @TruckOutNumber"
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                    cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
                    cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Lower", tbISOTankWeightLower.Text)
                    cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Upper", tbISOTankWeightUpper.Text)
                    cmd.Parameters.AddWithValue("@Internal_Seal_No", tbInternalSealNo.Text)

                    MessageBox.Show(stringPostCompleteAs, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf checkShippingPost = True And My.Settings.adminCheck = False Then
                    MessageBox.Show(stringPosted, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cmd.CommandText = "update Shipping set ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "',DDB='" + cmbDDB.Text + "',Product_Type = '" + cmbProductType.Text + "',Check_ISO_Tank = @Check_ISO_Tank, ISO_Truck_Out_Date = @ISO_Truck_Out_Date , ISO_Tank_Weight_Lower = @ISO_Tank_Weight_Lower, ISO_Tank_Weight_Upper = @ISO_Tank_Weight_Upper, Shipping_Post = 1, Shipping_Post_User ='" + My.Settings.username + "',Shipping_Post_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Internal_Seal_No = @Internal_Seal_No  WHERE ID = @TruckOutNumber"
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                    cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
                    cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Lower", tbISOTankWeightLower.Text)
                    cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Upper", tbISOTankWeightUpper.Text)
                    cmd.Parameters.AddWithValue("@Internal_Seal_No", tbInternalSealNo.Text)
                    MessageBox.Show(stringPostCompleteAs & " " & Me.TruckOutNumber, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If
            Else
                If tbInternalSealNo.Text = "" Then
                    MessageBox.Show(stringFillInternalSealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cmbCheckTempSealNo.Text = "" Then
                    MessageBox.Show(stringFillTempSealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cmbCheckTempSealNo.Text = "YES" And tbContainerNo.Text = "" Then
                    MessageBox.Show(stringFillTempSealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf tbLinerSealNo.Text = "" Then
                    MessageBox.Show(stringFillLinerSealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf checkShippingPost = True And My.Settings.adminCheck = True Then
                    cmd.CommandText = "update Shipping set Reversion='" + "R-S" + "',ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "',Liner_Sea_No = '" + GlobalFunction.TrimSpace(tbLinerSealNo.Text) + "',INTERNAL_SEAL_NO='" + GlobalFunction.TrimSpace(tbInternalSealNo.Text) + "',TEMPORARY_SEAL_NO='" + GlobalFunction.TrimSpace(tbTempSeal.Text) + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo,Product_Type = '" + cmbProductType.Text + "' ,Net_Cargo_Weight ='" + tbCargo.Text + "',Check_ISO_Tank = @Check_ISO_Tank WHERE ID = @TruckOutNumber"
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                    cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
                    cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)
                    MessageBox.Show(stringPostCompleteAs & " " & Me.TruckOutNumber, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf checkShippingPost = True And My.Settings.adminCheck = False Then
                    MessageBox.Show(stringPosted, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cmd.CommandText = "update Shipping set ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "',Liner_Sea_No = '" + GlobalFunction.TrimSpace(tbLinerSealNo.Text) + "',INTERNAL_SEAL_NO='" + GlobalFunction.TrimSpace(tbInternalSealNo.Text) + "',TEMPORARY_SEAL_NO='" + GlobalFunction.TrimSpace(tbTempSeal.Text) + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo,Product_Type = '" + cmbProductType.Text + "' ,Net_Cargo_Weight ='" + tbCargo.Text + "',Check_ISO_Tank = @Check_ISO_Tank,Shipping_Post = 1, Shipping_Post_User ='" + My.Settings.username + "',Shipping_Post_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE ID = @TruckOutNumber"
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                    cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
                    cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)
                    MessageBox.Show(stringPostCompleteAs & " " & Me.TruckOutNumber, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
        rd = cmd.ExecuteReader
        GlobalFunction.backToPage(Search, Me)
        con.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel1.Click
        If MsgBox(stringQuitChecking, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, stringCloseApplication) = Windows.Forms.DialogResult.Yes Then
            GlobalFunction.backToPage(Search, Me)
        End If
    End Sub

    Private Sub cbISO_CheckedChanged(sender As Object, e As EventArgs) Handles cbISO.CheckedChanged
        If cbISO.Checked Then
            tlpISO.Enabled = True
            cmbEsSealNo.Enabled = False
            cmbCheckTempSealNo.Enabled = False
            tbTempSeal.Enabled = False
            tbLinerSealNo.Enabled = False
            tbEsSealNo.Enabled = False
            tbCargo.Enabled = False
            cmbEsSealNo.Text = ""
            cmbCheckTempSealNo.Text = ""
            tbTempSeal.Text = ""
            tbLinerSealNo.Text = ""
            tbEsSealNo.Text = ""
            tbCargo.Text = ""
        Else
            tlpISO.Enabled = False
            cmbCheckTempSealNo.Enabled = True
            tbTempSeal.Enabled = True
            tbLinerSealNo.Enabled = True
            tbCargo.Enabled = True
        End If
    End Sub
End Class