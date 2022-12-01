Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class WarehouseEdit

    Public TruckOutNumber As Integer
    Private checkTempSealNo As Boolean
    Private checkShippingPost As String
    Private checkWarehousePost As String
    Private checkSecurityPost As String
    Private checkWarehouseCheckpoint As String
    Private checkWarehouse As String
    Private checkCargoWeight As Boolean
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rd As SqlDataReader
    Private companyNameHeader As String

    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFunction.topHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader


        lblTooNumber.Text = Me.TruckOutNumber

        'Disable for Warehouse
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
        tbTempSeal.Enabled = False
        cmbProductType.Enabled = False
        tbCargo.Enabled = False



        If My.Settings.role_id = 3 Then
            cbContainerNo.Enabled = False
            cbEsSealNo.Enabled = False
            cbTemporarySealNo.Enabled = False
            tbWarehouseCheckInternalSealNo.Enabled = False
            tbWarehouseCheckLinerSealNo.Enabled = False
            tbLinerSealNo.Enabled = False
            btnCheck.Visible = False
        ElseIf My.Settings.role_id = 4 Then
            cbContainerNo.Enabled = True
            cbEsSealNo.Enabled = True
            cbTemporarySealNo.Enabled = True
            tbWarehouseCheckInternalSealNo.Enabled = True
            tbWarehouseCheckLinerSealNo.Enabled = True
            tbLinerSealNo.Enabled = True
            tbSendToCompany.Enabled = False
            tbLoadingBay.Enabled = False
            cmbWarehouseLocation.Enabled = False
            cmbEsSealNo.Enabled = False
            tbEsSealNo.Enabled = False
            tbLinerSealNo.Enabled = False
            dtpLCD.Enabled = False
            dtpLCT.Enabled = False
            dtpRTD.Enabled = False
            dtpRTT.Enabled = False
            tbCargo.Enabled = False
            btnSave.Enabled = False
        End If
        tbLinerSealNo.PasswordChar = "*"
        tbInternalSealNo.PasswordChar = "*"



        'Get the cmb item
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

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select checkTempSealNo, ORIGIN, INVOICE, CONTAINER_NO, LINER_SEA_NO, INTERNAL_SEAL_NO, ES_SEAL_NO, COMPANY, TEMPORARY_SEAL_NO, Container_Size, LOADING_PORT, SHIPPING_LINE, HAULIER, PRODUCT, SHIPMENT_CLOSING_DATE, CONVERT(varchar,SHIPMENT_CLOSING_TIME,8) as CloseTime, DDB ,Shipping_Post,warehouse_post,security_post,company,Product_Type, Net_Cargo_Weight from Shipping where id = @TruckOutNumber"
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
            If IsDBNull(rd.Item("CONTAINER_NO_Check")) Or IsDBNull(rd.Item("ES_SEAL_NO_Check")) Or IsDBNull(rd.Item("Temporary_SEAL_NO_Check")) Then
                cbContainerNo.Text = "Checkpoint"
                cbEsSealNo.Text = "Checkpoint"
                cbTemporarySealNo.Text = "Checkpoint"
                tbWarehouseCheckLinerSealNo.Text = ""
                tbWarehouseCheckInternalSealNo.Text = ""
            Else
                cbContainerNo.Text = rd.Item("CONTAINER_NO_Check")
                cbEsSealNo.Text = rd.Item("ES_SEAL_NO_Check")
                tbWarehouseCheckLinerSealNo.Text = rd.Item("LINER_SEAL_NO_Check")
                tbWarehouseCheckInternalSealNo.Text = rd.Item("INTERNAL_SEAL_NO_Check")
                cbTemporarySealNo.Text = rd.Item("Temporary_SEAL_NO_Check")
                cbContainerNo.Enabled = False
                cbEsSealNo.Enabled = False
                cbTemporarySealNo.Enabled = False
                tbWarehouseCheckInternalSealNo.Enabled = False
                tbWarehouseCheckLinerSealNo.Enabled = False
                btnCheck.Visible = False
            End If

            If IsDBNull(rd.Item("Warehouse_Checkpoint_Check")) Then
                checkWarehouseCheckpoint = ""
            Else
                checkWarehouseCheckpoint = rd.Item("Warehouse_Checkpoint_Check")
            End If
        End While


        If cbContainerNo.Text = "NO" Then
            cbContainerNo.Checked = False
        ElseIf cbContainerNo.Text = "YES" Then
            cbContainerNo.Checked = True
        End If

        If cbEsSealNo.Text = "NO" Then
            cbEsSealNo.Checked = False
        ElseIf cbEsSealNo.Text = "YES" Then
            cbEsSealNo.Checked = True
        End If
        If cbTemporarySealNo.Text = "NO" Then
            cbTemporarySealNo.Checked = False
        ElseIf cbTemporarySealNo.Text = "YES" Then
            cbTemporarySealNo.Checked = True
        End If
        con.Close()

        'Read the full_name into lblcompanyfullname and lblLoadingport
        GlobalFunction.loadFullNameIntoLabel(cmbCompany, cmbLoadingPort, lblCompanyFullName, lblLoadingPortFullName)

        'cbpost checkin
        GlobalFunction.checkPostBoxWithoutCargo(cbShippingPost, cbWarehousePost, cbSecurityPost, checkShippingPost, checkWarehousePost, checkSecurityPost)

        'show text in cmbCheckTempSeal
        If checkTempSealNo = True Then
            cmbCheckTempSealNo.Text = "YES"
        Else
            cmbCheckTempSealNo.Text = "NO"
        End If

    End Sub

    Private Sub cmbEsSealNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEsSealNo.SelectedIndexChanged
        If cmbEsSealNo.Text = "NO" Then
            tbEsSealNo.Enabled = False
            tbEsSealNo.Text = ""
        Else
            If My.Settings.role_id = 3 Then
                tbEsSealNo.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        con.Close()
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()


        If My.Settings.role_id = 3 Or ((My.Settings.role_id = 3 Or My.Settings.role_id = 4) And My.Settings.adminCheck = True) Then
            If checkWarehousePost = "YES" And My.Settings.adminCheck = True Then
                If cmbWarehouseLocation.Text = "" Then
                    MessageBox.Show("Please Fill Out The WAREHOUSE_LOCATION Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf tbLoadingBay.Text = "" Then
                    MessageBox.Show("Please Fill Out The LOADING_BAY Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf tbSendToCompany.Text = "" Then
                    MessageBox.Show("Please Fill Out The SEND TO COMPANY Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf dtpLCT.Text = "" Then
                    MessageBox.Show("Please Fill Out The LOADING_COMPLETED_TIME Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf dtpRTT.Text = "" Then
                    MessageBox.Show("Please Fill Out The READY_TRUCK_OUT_TIME Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cmbEsSealNo.Text = "YES" And tbEsSealNo.Text = "" Then
                    MessageBox.Show("Please Fill Out The ES_SEAL_NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + My.Settings.username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "'  where  Shipping_ID= @TruckOutNumber"
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        con.Open()
                        cmd.CommandText = "update Shipping set COMPANY = '" + tbSendToCompany.Text + "', Reversion = 'R-W', ES_SEAL_NO = '" + cmbEsSealNo.Text + "', Warehouse_Post_User = '" + My.Settings.username + "', Warehouse_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where ID= @TruckOutNumber2"
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        GlobalFunction.backToPage(Search, Me)
                        MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If
            ElseIf checkWarehousePost = "YES" And My.Settings.adminCheck = False Then
                MessageBox.Show("This number is posted, Please contact admin to modify", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            Else
                cmd.CommandText = "select shipping_id from warehouse where shipping_id = @shipping_id"
                cmd.Parameters.AddWithValue("@shipping_id", Me.TruckOutNumber)
                rd = cmd.ExecuteReader
                rd.Read()

                If checkWarehouse = "YES" Or rd.HasRows() Then
                    con.Close()
                    con.Open()

                    cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',ES_SEAL_NO ='" + tbEsSealNo.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + My.Settings.username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "' where  Shipping_ID= @TruckOutNumber"
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        con.Open()
                        cmd.CommandText = "Update Shipping set COMPANY = '" + tbSendToCompany.Text + "',ES_SEAL_NO = '" + cmbEsSealNo.Text + "'where ID= @TruckOutNumber2"
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        GlobalFunction.backToPage(Search, Me)
                        MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Else
                    con.Close()
                    con.Open()

                    cmd = New SqlCommand("INSERT INTO Warehouse (Shipping_ID,WAREHOUSE_LOCATION,LOADING_BAY,ES_SEAL_NO,Update_Time,Update_User,LOADING_COMPLETED_TIME,LOADING_COMPLETED_DATE,READY_TRUCK_OUT_TIME,READY_TRUCK_OUT_DATE,COMPANY)values (@TruckOutNumber,'" + cmbWarehouseLocation.Text + "','" + tbLoadingBay.Text + "','" + tbEsSealNo.Text + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + My.Settings.username + "','" + dtpLCT.Value.ToString("HH:mm:ss") + "','" + dtpLCD.Value.ToString("yyyy-MM-dd") + "','" + dtpRTT.Value.ToString("HH:mm:ss") + "','" + dtpRTD.Value.ToString("yyyy-MM-dd") + "','" + tbSendToCompany.Text + "')", con)
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        con.Open()
                        cmd.CommandText = "Update Shipping set COMPANY = '" + tbSendToCompany.Text + "', ES_SEAL_NO = '" + cmbEsSealNo.Text + "' where ID=@TruckOutNumber2 "
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        GlobalFunction.backToPage(Search, Me)
                        MessageBox.Show("Save Complete as " + Me.TruckOutNumber.ToString, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If
            End If
            'End If
        End If

    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        'post button 
        con.Close()
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If checkWarehouseCheckpoint = "" Then
            MessageBox.Show("Please Check The Checkpoint First", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbWarehouseLocation.Text = "" Then
            MessageBox.Show("Please Fill Out The WAREHOUSE_LOCATION Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbLoadingBay.Text = "" Then
            MessageBox.Show("Please Fill Out The LOADING_BAY Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbSendToCompany.Text = "" Then
            MessageBox.Show("Please Fill Out The SEND TO COMPANY Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpLCT.Text = "" Then
            MessageBox.Show("Please Fill Out The LOADING_COMPLETED_TIME Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpRTT.Text = "" Then
            MessageBox.Show("Please Fill Out The READY_TRUCK_OUT_TIME Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbEsSealNo.Text = "YES" And tbEsSealNo.Text = "" Then
            MessageBox.Show("Please Fill Out The ES_SEAL_NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If checkWarehousePost = "" Then
                cmd.CommandText = "update Shipping set Warehouse_Post_User = '" + My.Settings.username + "', Warehouse_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Post = 'YES' where ID= @TruckOutNumber6"
                cmd.Parameters.AddWithValue("@TruckOutNumber6", Me.TruckOutNumber)
                rd = cmd.ExecuteReader
                con.Close()
                GlobalFunction.backToPage(Search, Me)
                MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Data Already Post. Please use 'Save' button to modify.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

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

    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompany.SelectedIndexChanged
        con.Close()
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
        con.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'button check for warehouse checking
        con.Close()
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        If cbContainerNo.Checked = True Then
            cbContainerNo.Text = "YES"
        Else
            cbContainerNo.Text = "NO"
        End If

        If cbEsSealNo.Checked = True Then
            cbEsSealNo.Text = "YES"
        Else
            cbEsSealNo.Text = "NO"
        End If
        If cbTemporarySealNo.Checked = True Then
            cbTemporarySealNo.Text = "YES"
        Else
            cbTemporarySealNo.Text = "NO"
        End If
        If tbWarehouseCheckLinerSealNo.Text <> Microsoft.VisualBasic.Right(tbLinerSealNo.Text, 4) Then
            MessageBox.Show("Please Check LINER'S SEAL NO.." + Environment.NewLine + "The number should be last 4 digit only.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbWarehouseCheckInternalSealNo.Text <> Microsoft.VisualBasic.Right(tbInternalSealNo.Text, 4) Then
            MessageBox.Show("Please Check INTERNAL SEAL NO.." + Environment.NewLine + "The number should be last 4 digit only.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf checkWarehouseCheckpoint <> "YES" Then
            cmd.CommandText = "select shipping_id from warehouse where shipping_id = @shipping_id"
            cmd.Parameters.AddWithValue("@shipping_id", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            rd.Read()

            'If rd.HasRows() Then
            con.Close()
                con.Open()
                cmd.CommandText = "Update warehouse set Warehouse_Checkpoint_Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Checkpoint_Update_User = '" + My.Settings.username + "',Container_No_Check = '" + cbContainerNo.Text + "', Es_Seal_No_Check = '" + cbEsSealNo.Text + "',Liner_Seal_No_Check = '" + tbWarehouseCheckLinerSealNo.Text + "', Internal_Seal_No_Check = '" + tbWarehouseCheckInternalSealNo.Text + "',Temporary_Seal_No_Check= '" + cbTemporarySealNo.Text + "',warehouse_Checkpoint_Check = 'YES' Where Shipping_ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                rd = cmd.ExecuteReader
                MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbContainerNo.Enabled = False
                cbEsSealNo.Enabled = False
                cbTemporarySealNo.Enabled = False
                tbWarehouseCheckInternalSealNo.Enabled = False
                tbWarehouseCheckLinerSealNo.Enabled = False
            btnCheck.Visible = False
            checkWarehouseCheckpoint = "YES"
            'Else
            'con.Close()
            'con.Open()
            'cmd.CommandText = ("Insert into warehouse ( Shipping_ID, Warehouse_Checkpoint_Update_Time,Warehouse_Checkpoint_Update_User,Container_No_Check,Es_Seal_No_Check,Liner_Seal_No_Check, Internal_Seal_No_Check,Temporary_Seal_No_Check,warehouse_Checkpoint_Check) values ( @TruckOutNumber,'" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + My.Settings.username + "', '" + cbContainerNo.Text + "',  '" + cbEsSealNo.Text + "','" + tbWarehouseCheckLinerSealNo.Text + "', '" + tbWarehouseCheckInternalSealNo.Text + "', '" + cbTemporarySealNo.Text + "', 'YES')")
            'cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            'rd = cmd.ExecuteReader
            'MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'cbContainerNo.Enabled = False
            'cbEsSealNo.Enabled = False
            'cbTemporarySealNo.Enabled = False
            'tbWarehouseCheckInternalSealNo.Enabled = False
            'tbWarehouseCheckLinerSealNo.Enabled = False
            'btnCheck.Visible = False
            'End If

            'Else
            '    cmd.CommandText = "Update warehouse set Warehouse_Checkpoint_Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Checkpoint_Update_User = '" + My.Settings.username + "',Container_No_Check = '" + cbContainerNo.Text + "', Es_Seal_No_Check = '" + cbEsSealNo.Text + "',Liner_Seal_No_Check = '" + tbWarehouseCheckLinerSealNo.Text + "', Internal_Seal_No_Check = '" + tbWarehouseCheckInternalSealNo.Text + "',Temporary_Seal_No_Check= '" + cbTemporarySealNo.Text + "' Where Shipping_ID = @TruckOutNumber"
            '    cmd.Parameters.AddWithValue("@c", Me.TruckOutNumber)
            '    rd = cmd.ExecuteReader
            '    btnCancel.PerformClick()
            '    MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Close application") = Windows.Forms.DialogResult.Yes Then
            GlobalFunction.backToPage(Search, Me)
        End If
    End Sub

End Class