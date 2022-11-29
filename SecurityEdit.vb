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


        dtpRTD.Enabled = False
        dtpLCD.Enabled = False
        dtpLCT.Enabled = False
        dtpRTT.Enabled = False
        cmbWarehouseLocation.Enabled = False
        tbLoadingBay.Enabled = False
        tbSendToCompany.Enabled = False

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


        tbLinerSealNo.Enabled = False
        cmbCheckTempSealNo.Enabled = False
        tbTempSeal.Enabled = False
        cmbEsSealNo.Enabled = False
        tbEsSealNo.Enabled = False

        con.Open()
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

        'Get item for combobox
        GlobalFunction.getCmbValue(cmbCompany, cmbLoadingPort, cmbWarehouseLocation, cmbContainerSize)

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
        cmd.CommandText = "Select checkTempSealNo, ORIGIN, INVOICE, CONTAINER_NO, LINER_SEA_NO, INTERNAL_SEAL_NO, ES_SEAL_NO, COMPANY, TEMPORARY_SEAL_NO, Container_Size, LOADING_PORT, SHIPPING_LINE, HAULIER, PRODUCT, SHIPMENT_CLOSING_DATE, CONVERT(varchar,SHIPMENT_CLOSING_TIME,8) as CloseTime, DDB ,Shipping_Post,warehouse_post,security_post,company from Shipping where id = @TruckOutNumber"
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
        con.Close()

        con.Open()
        cmd.CommandText = "Select Shipping_id, warehouse_location, loading_bay,es_seal_no,loading_completed_date, CONVERT(varchar,loading_completed_time,8) as LCT, READY_TRUCK_OUT_DATE, CONVERT(varchar,ready_truck_out_time,8) as RCT, Cargo_Weight from Warehouse where Shipping_ID = @TruckOutNumber2 "
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

            If IsDBNull(rd.Item("Cargo_Weight")) Then
                tbCargo1.Text = ""
            Else
                tbCargo1.Text = rd.Item("Cargo_Weight")
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
        End If
        con.Close()

        'Read the full_name into lblcompanyfullname and lblLoadingport
        GlobalFunction.loadFullNameIntoLabel(cmbCompany, cmbLoadingPort, lblCompanyFullName, lblLoadingPortFullName)


        'Driver Check Button Visible
        If checkDriver = "YES" Then
            btnDriverCheck.Visible = False
            btnSecurityPost.Visible = True
            cmbFullName.Enabled = False
            cmbPmCode.Enabled = False
            cmbPmRegistrationPlate.Enabled = False
        Else
            btnDriverCheck.Visible = True
            btnSecurityPost.Visible = False
        End If


        'IF ES_SEAL_NO = False then textbox11 can't be enabled
        If cmbEsSealNo.Text = "NO" Then
            tbSecurityCheckEsSealNo.Enabled = False
        End If


        'Fill in security check field
        If checkSecurityCheck = "YES" Then
            btnSecurityPost.Enabled = True
            tbSecurityCheckContainerNo.Text = tbContainerNo.Text
            tbSecurityCheckLinerSealNo.Text = tbLinerSealNo.Text
            tbSecurityCheckInternalSealNo.Text = tbInternalSealNo.Text
            tbSecurityCheckTemporarySealNo.Text = tbTempSeal.Text
            tbSecurityCheckEsSealNo.Text = tbEsSealNo.Text
        End If
        'shipping and warehouse save button set to false


        tbContainerNo.PasswordChar = "*"
        tbEsSealNo.PasswordChar = "*"
        tbInternalSealNo.PasswordChar = "*"
        tbLinerSealNo.PasswordChar = "*"
        tbTempSeal.PasswordChar = "*"

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
        GlobalFunction.checkPostBox(cbShippingPost, cbWarehousePost, cbSecurityPost, Label9, ViewPage.reportCheck, checkShippingPost, checkWarehousePost, checkSecurityPost, checkCargoWeight)

        'show text in cmbCheckTempSeal
        If checkTempSealNo = True Then
            cmbCheckTempSealNo.Text = "YES"
        Else
            cmbCheckTempSealNo.Text = "NO"
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
                btnSecurityPost.Visible = True
            End If

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnSecurityPost.Click
        'Security Check and Post 
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con

        con.Open()
        If cmbDDB.Text = "NO" Then
            If tbSecurityCheckContainerNo.Text <> tbContainerNo.Text Then
                MessageBox.Show("Please Check CONTAINER_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckTemporarySealNo.Text <> tbTempSeal.Text Then
                MessageBox.Show("Please Check TEMPORARY SEAL NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If checkSecurityPost = "" Then
                    cmd.CommandText = "update Shipping set Security_Post = '" + "YES" + "',Security_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Security_Post_User = '" + My.Settings.username + "' WHERE ID = @TruckOutNumber"
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                    rd = cmd.ExecuteReader
                    con.Close()
                    con.Open()
                    cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = 'YES',Cargo_Weight_Check = @checkCargoWeight,Cargo_Weight_Check_Value = @cargoWeightCheckValue WHERE Shipping_ID = @TruckOutNumber2"
                    cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                    cmd.Parameters.AddWithValue("@checkCargoWeight", checkCargoWeight)
                    cmd.Parameters.AddWithValue("@cargoWeightCheckValue", tbCheckCargoWeight.Text)
                    rd = cmd.ExecuteReader
                    MessageBox.Show("Post Complete", "Post Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnPrint.PerformClick()
                    GlobalFunction.backToPage(Search, Me)
                    con.Close()

                Else
                    MessageBox.Show("This Number is Posted Already", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GlobalFunction.backToPage(Search, Me)
                    con.Close()
                End If
            End If
        Else
            If cmbEsSealNo.Text = "YES" And tbSecurityCheckEsSealNo.Text = "" Then
                MessageBox.Show("Please Check ES_SEAL_NO..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tbSecurityCheckEsSealNo.Text <> tbEsSealNo.Text Then
                tbSecurityCheckEsSealNo.Enabled = False
            End If

            If tbSecurityCheckContainerNo.Text <> tbContainerNo.Text Then
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
                If checkSecurityPost = "" Then
                    Try
                        If cmbContainerSize.Text = "20" And Integer.Parse(tbCheckCargoWeight.Text) < My.Settings.cargoWeight20 Then
                            MessageBox.Show("Stop CTNR /Inform Warehouse", "Fail Case", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            checkCargoWeight = False
                        ElseIf cmbContainerSize.Text = "40" And Integer.Parse(tbCheckCargoWeight.Text) < My.Settings.cargoWeight40 Then
                            MessageBox.Show("Stop CTNR /Inform Warehouse", "Fail Case", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            checkCargoWeight = False
                        Else
                            checkCargoWeight = True
                        End If
                        cmd.CommandText = "update Shipping set Security_Post = '" + "YES" + "',Security_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Security_Post_User = '" + My.Settings.username + "' WHERE ID = @TruckOutNumber"
                        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        con.Open()
                        cmd.CommandText = "update security set Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,Update_User = '" + My.Settings.username + "', Security_Check = 'YES', Cargo_Weight_Check = @checkCargoWeight,Cargo_Weight_Check_Value = @cargoWeightCheckValue WHERE Shipping_ID = @TruckOutNumber2"
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        cmd.Parameters.AddWithValue("@checkCargoWeight", checkCargoWeight)
                        cmd.Parameters.AddWithValue("@cargoWeightCheckValue", tbCheckCargoWeight.Text)
                        rd = cmd.ExecuteReader
                        con.Close()
                        MessageBox.Show("Post Complete", "Post Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btnPrint.PerformClick()
                        GlobalFunction.backToPage(Search, Me)
                    Catch ex As Exception
                        MessageBox.Show("Please only enter integer value in net cargo weight!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try


                Else
                    MessageBox.Show("This Number is Posted Already", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GlobalFunction.backToPage(Search, Me)
                    con.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        GlobalFunction.printPage(e, Panel2, checkTempSealNo)
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
            Me.Close()
        End If
    End Sub
End Class