Imports System.Data.SqlClient
Imports System.Net.Security
Imports Microsoft.Office.Interop.Excel

Public Class WarehouseEdit
    Public Username As String
    Public role_id As Integer
    Public TruckOutNumber As Integer
    Public departmentName As String
    Public adminCheck As String
    Dim checkShippingPost As String
    Dim checkWarehousePost As String
    Dim checkSecurityPost As String
    Dim checkTempSealNo As Boolean = True
    Public fullName As String
    Dim checkWarehouse As String
    Dim checkWarehouseCheckpoint As String

    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If Me.role_id = 3 Or Me.role_id = 30 Then
            cbContainerNo.Enabled = False
            cbEsSealNo.Enabled = False
            cbTemporarySealNo.Enabled = False
            tbWarehouseCheckInternalSealNo.Enabled = False
            tbWarehouseCheckLinerSealNo.Enabled = False
            tbLinerSealNo.Enabled = False
            btnWarehouseCheckPoint.Visible = False
        ElseIf Me.role_id = 4 Then
            cbContainerNo.Enabled = True
            cbEsSealNo.Enabled = True
            cbTemporarySealNo.Enabled = True
            tbWarehouseCheckInternalSealNo.Enabled = True
            tbWarehouseCheckLinerSealNo.Enabled = True
            tbLinerSealNo.Enabled = True
            btnWarehouseCheckPoint.Visible = True
            tbSendToCompany.Enabled = False
            tbLoadingBay.Enabled = False
            cmbWarehouseLocation.Enabled = False
            cmbEsSealNo.Enabled = False
            tbEsSealNo.Enabled = False
            tbLinerSealNo.Enabled = False

        End If
        tbLinerSealNo.PasswordChar = "*"
        tbInternalSealNo.PasswordChar = "*"

        lblUserDetails.Text = ("Welcome, " & fullName & vbNewLine & "Department of " & departmentName)
        lblTooNumber.Text = Me.TruckOutNumber

        'Read data from database
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        'Read Data into Driver Check Section Combobox
        'Read Data Into Company Combobox

        'Read Data into Driver Check Section Combobox

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
        'Read Data Into Company Combobox
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


        con.Close()

        con.Open()
        cmd.CommandText = "Select Shipping_id, warehouse_location, loading_bay,es_seal_no,loading_completed_date, CONVERT(varchar,loading_completed_time,8) as LCT, READY_TRUCK_OUT_DATE, CONVERT(varchar,ready_truck_out_time,8) as RCT from Warehouse where Shipping_ID = @TruckOutNumber2 "
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
        End While
        con.Close()

        con.Open()
        cmd.CommandText = "Select * from Warehouse where Shipping_ID = @TruckOutNumber3"
        cmd.Parameters.AddWithValue("@TruckOutNumber3", Me.TruckOutNumber)
        rd = cmd.ExecuteReader()


        While rd.Read()
            If IsDBNull(rd.Item("CONTAINER_NO_Check")) Or IsDBNull(rd.Item("ES_SEAL_NO_Check")) Or IsDBNull(rd.Item("Temporary_SEAL_NO_Check")) Then
                cbContainerNo.Text = ""
                cbEsSealNo.Text = ""
                cbTemporarySealNo.Text = ""
                tbWarehouseCheckLinerSealNo.Text = ""
                tbWarehouseCheckInternalSealNo.Text = ""
            Else
                cbContainerNo.Text = rd.Item("CONTAINER_NO_Check")
                cbEsSealNo.Text = rd.Item("ES_SEAL_NO_Check")
                tbWarehouseCheckLinerSealNo.Text = rd.Item("LINER_SEAL_NO_Check")
                tbWarehouseCheckInternalSealNo.Text = rd.Item("INTERNAL_SEAL_NO_Check")
                cbTemporarySealNo.Text = rd.Item("Temporary_SEAL_NO_Check")

            End If

            If IsDBNull(rd.Item("Warehouse_Checkpoint_Check")) Then
                checkWarehouseCheckpoint = ""
            Else
                checkWarehouseCheckpoint = rd.Item("Warehouse_Checkpoint_Check")
            End If
        End While


        If cbContainerNo.Text = "NO" Then
            cbContainerNo.Checked = False
        ElseIf cbContainerNo.Text = "Yes" Then
            cbContainerNo.Checked = True
        End If

        If cbEsSealNo.Text = "NO" Then
            cbEsSealNo.Checked = False
        ElseIf cbEsSealNo.Text = "Yes" Then
            cbEsSealNo.Checked = True
        End If
        If cbTemporarySealNo.Text = "NO" Then
            cbTemporarySealNo.Checked = False
        ElseIf cbTemporarySealNo.Text = "Yes" Then
            cbTemporarySealNo.Checked = True
        End If
        cbContainerNo.Text = "Check Point"
        cbEsSealNo.Text = "Check Point"
        cbTemporarySealNo.Text = "Check Point"
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

        'cbpost checkin
        con.Open()
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

        'show text in cmbCheckTempSeal
        If checkTempSealNo = True Then
            cmbCheckTempSealNo.Text = "YES"
        Else
            cmbCheckTempSealNo.Text = "NO"
        End If

        If checkWarehouseCheckpoint = "" Then
        Else
            cbContainerNo.Enabled = False
            cbEsSealNo.Enabled = False
            cbTemporarySealNo.Enabled = False
            tbWarehouseCheckInternalSealNo.Enabled = False
            tbWarehouseCheckLinerSealNo.Enabled = False
            btnWarehouseCheckpoint.Visible = False
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Cancel Button
        Dim obj As New Search With {
            .username = Me.Username,
            .role_id = Me.role_id,
            .departmentName = Me.departmentName,
            .adminCheck = Me.adminCheck,
            .fullName = Me.fullName
        }
        obj.Show()
        Me.Close()
    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub cmbEsSealNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEsSealNo.SelectedIndexChanged
        If cmbEsSealNo.Text = "NO" Then
            tbEsSealNo.Enabled = False
            tbEsSealNo.Text = ""
        Else
            If role_id = 3 Or role_id = 30 Then
                tbEsSealNo.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If cmbEsSealNo.Text = "" Then
            MessageBox.Show("Please Fill Out The ES_SEAL_NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbEsSealNo.Text = "yes" And tbEsSealNo.Text = "" Then
            MessageBox.Show("Please Fill Out The ES_SEAL Number ..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If checkWarehousePost = "YES" Then
                MessageBox.Show("This Number is Posted Already", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnCancel.PerformClick()
                con.Close()
            Else

                If checkWarehouse <> "" Then
                    cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',ES_SEAL_NO ='" + tbEsSealNo.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + Me.Username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "' where  Shipping_ID= @TruckOutNumber"
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                    rd = cmd.ExecuteReader
                    con.Close()
                    con.Open()
                    cmd.CommandText = "Update Shipping set COMPANY = '" + tbSendToCompany.Text + "',ES_SEAL_NO = '" + cmbEsSealNo.Text + "'where ID= @TruckOutNumber2"
                    cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                    rd = cmd.ExecuteReader
                    con.Close()
                    btnCancel.PerformClick()
                    MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    cmd = New SqlCommand("INSERT INTO Warehouse (Shipping_ID,WAREHOUSE_LOCATION,LOADING_BAY,ES_SEAL_NO,Update_Time,Update_User,LOADING_COMPLETED_TIME,LOADING_COMPLETED_DATE,READY_TRUCK_OUT_TIME,READY_TRUCK_OUT_DATE,COMPANY)values (@TruckOutNumber,'" + cmbWarehouseLocation.Text + "','" + tbLoadingBay.Text + "','" + tbEsSealNo.Text + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Me.Username + "','" + dtpLCT.Value.ToString("HH:mm:ss") + "','" + dtpLCD.Value.ToString("yyyy-MM-dd") + "','" + dtpRTT.Value.ToString("HH:mm:ss") + "','" + dtpRTD.Value.ToString("yyyy-MM-dd") + "','" + tbSendToCompany.Text + "')", con)
                    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                    rd = cmd.ExecuteReader
                    con.Close()
                    con.Open()
                    cmd.CommandText = "Update Shipping set COMPANY = '" + tbSendToCompany.Text + "', ES_SEAL_NO = '" + cmbEsSealNo.Text + "' where ID=@TruckOutNumber2 "
                    cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                    rd = cmd.ExecuteReader
                    con.Close()
                    btnCancel.PerformClick()
                    MessageBox.Show("Save Complete as " + Me.TruckOutNumber.ToString, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If checkWarehouseCheckpoint = "" Then
            MessageBox.Show("Please Check The Checkpoint First", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnCancel.PerformClick()
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
            Select Case Me.role_id
                Case 30
                    If checkWarehousePost = "" Then
                        cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + Me.Username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "'where  Shipping_ID= @TruckOutNumber"
                        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        con.Open()
                        cmd.CommandText = "update Shipping set COMPANY = '" + tbSendToCompany.Text + "', ES_SEAL_NO = '" + cmbEsSealNo.Text + "',Warehouse_Post = 'YES', Warehouse_Post_User = '" + Me.Username + "', Warehouse_Post_Time = '" + Date.Now.ToString("HH:mm:ss") + "' where ID= @TruckOutNumber2"
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        btnCancel.PerformClick()
                        MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + Me.Username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "'where  Shipping_ID= @TruckOutNumber"
                        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        con.Open()
                        cmd.CommandText = "update Shipping set COMPANY = '" + tbSendToCompany.Text + "', Reversion = 'R-W', ES_SEAL_NO = '" + cmbEsSealNo.Text + "', Warehouse_Post_User = '" + Me.Username + "', Warehouse_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where ID= @TruckOutNumber2"
                        cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        btnCancel.PerformClick()
                        MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case Else
                    If checkWarehousePost = "" Then
                        cmd.CommandText = "update Shipping set Warehouse_Post_User = '" + Me.Username + "', Warehouse_Post_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Post = 'YES' where ID= @TruckOutNumber"
                        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                        rd = cmd.ExecuteReader
                        con.Close()
                        btnCancel.PerformClick()
                        MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        btnCancel.PerformClick()
                        MessageBox.Show("Data Already Post ..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select

        End If
    End Sub

    Private Sub btnWarehouseCheckpoint_Click(sender As Object, e As EventArgs) Handles btnWarehouseCheckpoint.Click
        'Warehouse Checkpoint
        'checkwarehousecheckpoint is used to check the checkpoint
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        If cbContainerNo.Checked = True Then
            cbContainerNo.Text = "Yes"
        Else
            cbContainerNo.Text = "NO"
        End If

        If cbEsSealNo.Checked = True Then
            cbEsSealNo.Text = "Yes"
        Else
            cbEsSealNo.Text = "NO"
        End If
        If cbTemporarySealNo.Checked = True Then
            cbTemporarySealNo.Text = "Yes"
        Else
            cbTemporarySealNo.Text = "NO"
        End If
        If tbWarehouseCheckLinerSealNo.Text <> Microsoft.VisualBasic.Right(tbLinerSealNo.Text, 4) Then
            MessageBox.Show("Please Check LINER'S SEAL NO.." + Environment.NewLine + "The number should be last 4 digit only.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbWarehouseCheckInternalSealNo.Text <> Microsoft.VisualBasic.Right(tbInternalSealNo.Text, 4) Then
            MessageBox.Show("Please Check INTERNAL SEAL NO.." + Environment.NewLine + "The number should be last 4 digit only.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf checkWarehouseCheckpoint = "" Then
            cmd.CommandText = "Update warehouse set Warehouse_Checkpoint_Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Checkpoint_Update_User = '" + Me.Username + "',Container_No_Check = '" + cbContainerNo.Text + "', Es_Seal_No_Check = '" + cbEsSealNo.Text + "',Liner_Seal_No_Check = '" + tbWarehouseCheckLinerSealNo.Text + "', Internal_Seal_No_Check = '" + tbWarehouseCheckInternalSealNo.Text + "',Temporary_Seal_No_Check= '" + cbTemporarySealNo.Text + "',warehouse_Checkpoint_Check = 'YES' Where Shipping_ID = @TruckOutNumber"
            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            btnCancel.PerformClick()
            MessageBox.Show("Save Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            cmd.CommandText = "Update warehouse set Warehouse_Checkpoint_Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Warehouse_Checkpoint_Update_User = '" + Me.Username + "',Container_No_Check = '" + cbContainerNo.Text + "', Es_Seal_No_Check = '" + cbEsSealNo.Text + "',Liner_Seal_No_Check = '" + tbWarehouseCheckLinerSealNo.Text + "', Internal_Seal_No_Check = '" + tbWarehouseCheckInternalSealNo.Text + "',Temporary_Seal_No_Check= '" + cbTemporarySealNo.Text + "' Where Shipping_ID = @TruckOutNumber"
            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            btnCancel.PerformClick()
            MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class