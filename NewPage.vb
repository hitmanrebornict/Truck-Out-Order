Imports System.Data.SqlClient
Imports Truck_Out_Order.My.Resources

Public Class NewPage

    Dim checkTempSealNo As Boolean
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private companyNameHeader As String
    Private stringUpdateFailure,
    stringFillSCD,
    stringFillCompany,
    stringFillSCT,
    stringFillInvoice,
    stringFillProduct,
    stringFillShippingLine,
    stringFillHaulier,
    stringFillLoadingPort,
    stringFillContainerSize,
    stringFillContainerNo,
    stringFillDDB,
    stringFillProductType,
    stringFillISOTOD,
    stringFillISOTankWeight,
    stringFillInternalSealNo,
    stringFillTempSealNo,
    stringFillLinerSealNo,
    stringPostCompleteAs,
    stringComplete,
    stringCargoWeightEx,
    stringQuitChecking,
    stringCloseApplication,
    stringSaveCompleteAs As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFunction.TopHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)

        'TableLayoutPanel3.Font = New Font("Microsoft Sans Serif", 1, FontStyle.Regular)

        'For Each ctl As Control In Me.Controls
        '    ctl.Font = New Font("Microsoft Sans Serif", 1, FontStyle.Regular)
        'Next

        'For Each ctl As Control In Me.Controls
        '    If TypeOf ctl Is Label Then
        '        Dim lbl As Label = DirectCast(ctl, Label)
        '        MessageBox.Show(lbl.Name)
        '        tbCargo.Text = tbCargo.Text & lbl.Name
        '    End If
        'Next

        If (My.Settings.languageSetting = "fr") Then
            btnCancel.Text = ResourceNewPageFrench.btnCancel
            btnPost.Text = ResourceNewPageFrench.btnPost
            btnSave.Text = ResourceNewPageFrench.btnSave
            lblCompany.Text = ResourceNewPageFrench.lblCompany
            lblContainerNo.Text = ResourceNewPageFrench.lblContainerNo
            lblContainerSize.Text = ResourceNewPageFrench.lblContainerSize
            lblDDB.Text = ResourceNewPageFrench.lblDDB
            lblEsSealNo.Text = ResourceNewPageFrench.lblEsSealNo
            lblFullName.Text = ResourceNewPageFrench.lblFullName
            lblHaulier.Text = ResourceNewPageFrench.lblHaulier
            lblInternalSealNo.Text = ResourceNewPageFrench.lblInternalSealNo
            lblInvoice.Text = ResourceNewPageFrench.lblInvoice
            lblISOTank.Text = ResourceNewPageFrench.lblISOTank
            lblISOTankWeight.Text = ResourceNewPageFrench.lblISOTankWeight
            lblISOTruckOutDate.Text = ResourceNewPageFrench.lblISOTruckOutDate
            lblLinerSealNo.Text = ResourceNewPageFrench.lblLinerSealNo
            lblLoadingBay.Text = ResourceNewPageFrench.lblLoadingBay
            lblLoadingPort.Text = ResourceNewPageFrench.lblLoadingPort
            lblNetCargoWeight.Text = ResourceNewPageFrench.lblNetCargoWeight
            lblPortFullName.Text = ResourceNewPageFrench.lblPortFullName
            lblProduct.Text = ResourceNewPageFrench.lblProduct
            lblSCD.Text = ResourceNewPageFrench.lblSCD
            lblSCT.Text = ResourceNewPageFrench.lblSCT
            lblSendToCompany.Text = ResourceNewPageFrench.lblSendToCompany
            lblShippingLine.Text = ResourceNewPageFrench.lblShippingLine
            lblTemporarySealNo.Text = ResourceNewPageFrench.lblTemporarySealNo
            lblTruckOutNumber.Text = ResourceNewPageFrench.lblTruckOutNumber
            lblWarehouseLocation.Text = ResourceNewPageFrench.lblWarehouseLocation
            stringUpdateFailure = ResourceNewPageFrench.stringUpdateFailure
            stringFillSCD = ResourceNewPageFrench.stringFillSCD
            stringFillCompany = ResourceNewPageFrench.stringFillCompany
            stringFillSCT = ResourceNewPageFrench.stringFillSCT
            stringFillInvoice = ResourceNewPageFrench.stringFillInvoice
            stringFillProduct = ResourceNewPageFrench.stringFillProduct
            stringFillShippingLine = ResourceNewPageFrench.stringFillShippingLine
            stringFillHaulier = ResourceNewPageFrench.stringFillHaulier
            stringFillLoadingPort = ResourceNewPageFrench.stringFillLoadingPort
            stringFillContainerSize = ResourceNewPageFrench.stringFillContainerSize
            stringFillContainerNo = ResourceNewPageFrench.stringFillContainerNo
            stringFillDDB = ResourceNewPageFrench.stringFillDDB
            stringFillProductType = ResourceNewPageFrench.stringFillProductType
            stringFillISOTOD = ResourceNewPageFrench.stringFillISOTOD
            stringFillISOTankWeight = ResourceNewPageFrench.stringFillISOTankWeight
            stringFillInternalSealNo = ResourceNewPageFrench.stringFillInternalSealNo
            stringFillTempSealNo = ResourceNewPageFrench.stringFillTempSealNo
            stringFillLinerSealNo = ResourceNewPageFrench.stringFillLinerSealNo
            stringPostCompleteAs = ResourceNewPageFrench.stringPostCompleteAs
            stringComplete = ResourceNewPageFrench.stringComplete
            stringCargoWeightEx = ResourceNewPageFrench.stringCargoWeightEx
            stringQuitChecking = ResourceNewPageFrench.stringQuitChecking
            stringCloseApplication = ResourceNewPageFrench.stringCloseApplication
            stringSaveCompleteAs = ResourceNewPageFrench.stringSaveCompleteAs
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
            GlobalFunction.ChangeFont(lblISOTruckOutDate, 10)
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
            GlobalFunction.ChangeFontBold(lblTruckOutNumber, 10)
            GlobalFunction.ChangeFont(lblWarehouseLocation, 10)
        Else
            btnCancel.Text = ResourceNewPage.btnCancel
            btnPost.Text = ResourceNewPage.btnPost
            btnSave.Text = ResourceNewPage.btnSave
            lblCompany.Text = ResourceNewPage.lblCompany
            lblContainerNo.Text = ResourceNewPage.lblContainerNo
            lblContainerSize.Text = ResourceNewPage.lblContainerSize
            lblDDB.Text = ResourceNewPage.lblDDB
            lblEsSealNo.Text = ResourceNewPage.lblEsSealNo
            lblFullName.Text = ResourceNewPage.lblFullName
            lblHaulier.Text = ResourceNewPage.lblHaulier
            lblInternalSealNo.Text = ResourceNewPage.lblInternalSealNo
            lblInvoice.Text = ResourceNewPage.lblInvoice
            lblISOTank.Text = ResourceNewPage.lblISOTank
            lblISOTankWeight.Text = ResourceNewPage.lblISOTankWeight
            lblISOTruckOutDate.Text = ResourceNewPage.lblISOTruckOutDate
            lblLinerSealNo.Text = ResourceNewPage.lblLinerSealNo
            lblLoadingBay.Text = ResourceNewPage.lblLoadingBay
            lblLoadingPort.Text = ResourceNewPage.lblLoadingPort
            lblNetCargoWeight.Text = ResourceNewPage.lblNetCargoWeight
            lblPortFullName.Text = ResourceNewPage.lblPortFullName
            lblProduct.Text = ResourceNewPage.lblProduct
            lblSCD.Text = ResourceNewPage.lblSCD
            lblSCT.Text = ResourceNewPage.lblSCT
            lblSendToCompany.Text = ResourceNewPage.lblSendToCompany
            lblShippingLine.Text = ResourceNewPage.lblShippingLine
            lblTemporarySealNo.Text = ResourceNewPage.lblTemporarySealNo
            lblTruckOutNumber.Text = ResourceNewPage.lblTruckOutNumber
            lblWarehouseLocation.Text = ResourceNewPage.lblWarehouseLocation
            stringUpdateFailure = ResourceNewPage.stringUpdateFailure
            stringFillSCD = ResourceNewPage.stringFillSCD
            stringFillCompany = ResourceNewPage.stringFillCompany
            stringFillSCT = ResourceNewPage.stringFillSCT
            stringFillInvoice = ResourceNewPage.stringFillInvoice
            stringFillProduct = ResourceNewPage.stringFillProduct
            stringFillShippingLine = ResourceNewPage.stringFillShippingLine
            stringFillHaulier = ResourceNewPage.stringFillHaulier
            stringFillLoadingPort = ResourceNewPage.stringFillLoadingPort
            stringFillContainerSize = ResourceNewPage.stringFillContainerSize
            stringFillContainerNo = ResourceNewPage.stringFillContainerNo
            stringFillDDB = ResourceNewPage.stringFillDDB
            stringFillProductType = ResourceNewPage.stringFillProductType
            stringFillISOTOD = ResourceNewPage.stringFillISOTOD
            stringFillISOTankWeight = ResourceNewPage.stringFillISOTankWeight
            stringFillInternalSealNo = ResourceNewPage.stringFillInternalSealNo
            stringFillTempSealNo = ResourceNewPage.stringFillTempSealNo
            stringFillLinerSealNo = ResourceNewPage.stringFillLinerSealNo
            stringPostCompleteAs = ResourceNewPage.stringPostCompleteAs
            stringComplete = ResourceNewPage.stringComplete
            stringCargoWeightEx = ResourceNewPage.stringCargoWeightEx
            stringQuitChecking = ResourceNewPage.stringQuitChecking
            stringCloseApplication = ResourceNewPage.stringCloseApplication
            stringSaveCompleteAs = ResourceNewPage.stringSaveCompleteAs
        End If


        lblTooNumber.Text = My.Settings.newTOONumber
        tbTemporarySealNo.Enabled = False
        cmbCheckTempSealNo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCheckTempSealNo.SelectedItem = "NO"
        cmbDDB.SelectedItem = "No"
        tbEsSealNo.Enabled = False
        tbLoadingBay.Enabled = False
        cmbWarehouseLocation.Enabled = False
        cmbEsSealNo.Enabled = False
        lblCompanyName.Text = ""
        lblLoadingPortFullName.Text = ""
        GlobalFunction.getCmbValue(cmbCompany, cmbLoadingPort, cmbWarehouseLocation, cmbContainerSize)
        GlobalFunction.getProductType(cmbProductType)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        'Post button
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
                ElseIf tbISOTankWeightLower.Text = "" Then
                    MessageBox.Show(stringFillISOTankWeight, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cmd = New SqlCommand("INSERT INTO Shipping
                    (ID,
                    ORIGIN,
                    SHIPMENT_CLOSING_DATE,
                    SHIPMENT_CLOSING_TIME,
                    INVOICE,
                    PRODUCT,
                    SHIPPING_LINE,
                    Container_Size,
                    HAULIER,
                    LOADING_PORT,
                    CONTAINER_NO,
                    DDB,
                    Product_Type,
                    Check_ISO_Tank,
                    ISO_Truck_Out_Date,
                    ISO_Tank_Weight_Lower,
                    ISO_Tank_Weight_Upper,
                    Internal_Seal_No,
                    Shipping_Post,
                    Shipping_Post_User,
                    Shipping_POST_Time) 
                    values 
                    (@TruckOutNumber ,
                    @Origin,
                    @Shipment_Closing_Date,
                    @Shipment_Closing_Time,
                    @Invoice,
                    @Product,
                    @Shipping_Line,
                    @Container_Size,
                    @Haulier,
                    @Loading_Port,
                    @Container_No,
                    @DDB,
                    @Product_Type,
                    @Check_ISO_Tank,
                    @ISO_Truck_Out_Date,
                    @ISO_Tank_Weight_Lower,
                    @ISO_Tank_Weight_Upper,
                    @Internal_Seal_No,
                    1,
                    @Shipping_Post_User,
                    @Shipping_Post_Time)", con)
                    ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
                    cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Lower", tbISOTankWeightLower.Text)
                    cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Upper", tbISOTankWeightUpper.Text)

                End If
            Else
                If tbInternalSealNo.Text = "" Then
                    MessageBox.Show(stringFillInternalSealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cmbCheckTempSealNo.Text = "" Then
                    MessageBox.Show("Please Fill Out The TEMPORARY SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cmbCheckTempSealNo.Text = "YES" And tbContainerNo.Text = "" Then
                    MessageBox.Show("Please Fill Out The Temorary Seal No Field", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf tbLinerSealNo.Text = "" Then
                    MessageBox.Show(stringFillLinerSealNo, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cmd = New SqlCommand("INSERT INTO Shipping 
                    (ID,
                    ORIGIN,
                    SHIPMENT_CLOSING_DATE,
                    SHIPMENT_CLOSING_TIME,
                    INVOICE,
                    PRODUCT,
                    SHIPPING_LINE,
                    Container_Size,
                    HAULIER,
                    LOADING_PORT,
                    CONTAINER_NO,
                    LINER_SEA_NO,
                    INTERNAL_SEAL_NO,
                    TEMPORARY_SEAL_NO,
                    Shipping_Post,
                    Shipping_Post_User,
                    Shipping_POST_Time,
                    DDB,
                    checkTempSealNo,
                    Product_Type,
                    Net_Cargo_Weight,
                    Check_ISO_Tank) 
                    values (@TruckOutNumber ,
                    @Origin,
                    @Shipment_Closing_Date,
                    @Shipment_Closing_Time,
                    @Invoice,
                    @Product,
                    @Shipping_Line,
                    @Container_Size,
                    @Haulier,
                    @Loading_Port,
                    @Container_No,
                    @Liner_Seal_No,
                    @Internal_Seal_No,
                    @Temporary_Seal_No,
                    1,
                    @Shipping_Post_User,
                    @Shipping_Post_Time,
                    @DDB,
                    @checkTempSealNo,
                    @Product_Type,
                    @Net_Cargo_Weight,
                    @Check_ISO_Tank)", con)
                    ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
                    cmd.Parameters.AddWithValue("@Liner_Seal_No", GlobalFunction.TrimSpace(tbLinerSealNo.Text))
                    cmd.Parameters.AddWithValue("@Temporary_Seal_No", GlobalFunction.TrimSpace(tbTemporarySealNo.Text))
                    cmd.Parameters.AddWithValue("@Net_Cargo_Weight", tbCargo.Text)
                    cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)

                End If
            End If
            cmd.Parameters.AddWithValue("@TruckOutNumber", My.Settings.newTOONumber)
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
            cmd.Parameters.AddWithValue("@Internal_Seal_No", GlobalFunction.TrimSpace(tbInternalSealNo.Text))
            cmd.Parameters.AddWithValue("@Shipping_Post_User", My.Settings.username)
            cmd.Parameters.AddWithValue("@Shipping_Post_Time", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
            ra = cmd.ExecuteNonQuery
            'btnCancel.PerformClick()
            GlobalFunction.backToPageAdminCheck(Admin, NormalUserPage, Me)
            MessageBox.Show(stringPostCompleteAs & " " & +My.Settings.newTOONumber.ToString, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        End If
        con.Close()

    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompany.SelectedIndexChanged
        'Show Company full name when the cmbcompany's value is changed
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "select full_name from details where company_name = @company_name"
        cmd.Parameters.AddWithValue("@company_name", cmbCompany.Text)
        rd = cmd.ExecuteReader

        While rd.Read()
            If IsDBNull(rd.Item("full_name")) Then
                lblCompanyName.Text = ""
            Else
                lblCompanyName.Text = rd.Item("full_name")
            End If

        End While


        lblCompanyName.Visible = True
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

        cmd.CommandText = "select full_name from details where Loading_port = @Loading_port"
        cmd.Parameters.AddWithValue("@Loading_port", cmbLoadingPort.Text)
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
            tbTemporarySealNo.Text = ""
        Else
            tbTemporarySealNo.Enabled = True
            checkTempSealNo = True
        End If
    End Sub


    Private Sub Button_Save(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim ra As Integer
        Dim con3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()


        If cbISO.Checked Then
            cmd = New SqlCommand("INSERT INTO Shipping
                    (ID,
                    ORIGIN,
                    SHIPMENT_CLOSING_DATE,
                    SHIPMENT_CLOSING_TIME,
                    INVOICE,
                    PRODUCT,
                    SHIPPING_LINE,
                    Container_Size,
                    HAULIER,
                    LOADING_PORT,
                    CONTAINER_NO,
                    DDB,
                    Product_Type,
                    Check_ISO_Tank,
                    ISO_Truck_Out_Date,
                    ISO_Tank_Weight_Lower,
                    ISO_Tank_Weight_Upper,
                    Internal_Seal_No) 
                    values 
                    (@TruckOutNumber ,
                    @Origin,
                    @Shipment_Closing_Date,
                    @Shipment_Closing_Time,
                    @Invoice,
                    @Product,
                    @Shipping_Line,
                    @Container_Size,
                    @Haulier,
                    @Loading_Port,
                    @Container_No,
                    @DDB,
                    @Product_Type,
                    @Check_ISO_Tank,
                    @ISO_Truck_Out_Date,
                    @ISO_Tank_Weight_Lower,
                    @ISO_Tank_Weight_Upper,
                    @Internal_Seal_No)", con)
            ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
            cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Lower", tbISOTankWeightLower.Text)
            cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Upper", tbISOTankWeightUpper.Text)
        Else
            cmd = New SqlCommand("INSERT INTO Shipping 
                    (ID,
                    ORIGIN,
                    SHIPMENT_CLOSING_DATE,
                    SHIPMENT_CLOSING_TIME,
                    INVOICE,
                    PRODUCT,
                    SHIPPING_LINE,
                    Container_Size,
                    HAULIER,
                    LOADING_PORT,
                    CONTAINER_NO,
                    LINER_SEA_NO,
                    INTERNAL_SEAL_NO,
                    TEMPORARY_SEAL_NO,
                    DDB,
                    checkTempSealNo,
                    Product_Type,
                    Net_Cargo_Weight,
                    Check_ISO_Tank) 
                    values (@TruckOutNumber ,
                    @Origin,
                    @Shipment_Closing_Date,
                    @Shipment_Closing_Time,
                    @Invoice,
                    @Product,
                    @Shipping_Line,
                    @Container_Size,
                    @Haulier,
                    @Loading_Port,
                    @Container_No,
                    @Liner_Seal_No,
                    @Internal_Seal_No,
                    @Temporary_Seal_No,
                    @DDB,
                    @checkTempSealNo,
                    @Product_Type,
                    @Net_Cargo_Weight,
                    @Check_ISO_Tank)", con)
            ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
            cmd.Parameters.AddWithValue("@Liner_Seal_No", GlobalFunction.TrimSpace(tbLinerSealNo.Text))
            cmd.Parameters.AddWithValue("@Temporary_Seal_No", GlobalFunction.TrimSpace(tbTemporarySealNo.Text))
            cmd.Parameters.AddWithValue("@Net_Cargo_Weight", tbCargo.Text)
            cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)
        End If
        Try
            cmd.Parameters.AddWithValue("@TruckOutNumber", My.Settings.newTOONumber)
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
            cmd.Parameters.AddWithValue("@Internal_Seal_No", GlobalFunction.TrimSpace(tbInternalSealNo.Text))
            cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
            ra = cmd.ExecuteNonQuery
            GlobalFunction.backToPageAdminCheck(Admin, NormalUserPage, Me)
            MessageBox.Show(stringSaveCompleteAs & " " & My.Settings.newTOONumber.ToString, stringComplete, MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(stringCargoWeightEx, stringUpdateFailure, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'btnCancel.PerformClick()

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox(stringQuitChecking, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, stringCloseApplication) = Windows.Forms.DialogResult.Yes Then
            GlobalFunction.backToPageAdminCheck(Admin, NormalUserPage, Me)
        End If
    End Sub

    Private Sub cbISO_CheckedChanged(sender As Object, e As EventArgs) Handles cbISO.CheckedChanged
        If cbISO.Checked Then
            tlpISO.Enabled = True
            cmbEsSealNo.Enabled = False
            cmbCheckTempSealNo.Enabled = False
            tbTemporarySealNo.Enabled = False
            tbLinerSealNo.Enabled = False
            tbEsSealNo.Enabled = False
            tbCargo.Enabled = False
            cmbEsSealNo.Text = ""
            cmbCheckTempSealNo.Text = ""
            tbTemporarySealNo.Text = ""
            tbLinerSealNo.Text = ""
            tbEsSealNo.Text = ""
            tbCargo.Text = ""
        Else
            tlpISO.Enabled = False
            cmbCheckTempSealNo.Enabled = True
            tbLinerSealNo.Enabled = True
            tbCargo.Enabled = True

        End If
    End Sub


End Class