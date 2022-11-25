Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Edit

    Public TruckOutNumber As Integer

    Dim checkShippingPost As String
    Dim checkWarehousePost As String
    Dim checkWarehouse As String
    Dim checkWarehouseCheckpoint As String
    Dim checkSecurityDriver As String
    Dim checkSecurityPost As String
    Dim checkSecurityCheck As String
    Dim checkCargoWeight As Boolean
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rd As SqlDataReader

    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFunction.topHeader(lblUserDetails, lblCompanyNameHeader)
        lblTooNumber.Text = Me.TruckOutNumber

        cmbFullName.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPmCode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPmRegistrationPlate.DropDownStyle = ComboBoxStyle.DropDownList

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con

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

        GlobalFunction.getCmbValue(cmbCompany, cmbLoadingPort, cmbWarehouseLocation, cmbContainerSize)

        'Read data from Shipping Table
        GlobalFunction.selectFromShipping(
            Me.TruckOutNumber,
            cmbCompany,
            dtpSCD,
            dtpSCT,
            tbInvoice,
            tbProduct,
            tbShippingLine,
            cmbContainerSize,
            tbHaulier,
            cmbLoadingPort,
            tbContainerNo,
            tbLinerSealNo,
            tbInternalSealNo,
            tbTempSeal,
            cmbEsSealNo,
            cmbDDB,
            checkShippingPost,
            checkWarehousePost,
            checkSecurityPost,
            tbSendToCompany,
            GlobalFunction.checkTempSealNo
            )


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

            If Not IsDBNull(rd.Item("Cargo_Weight_Check_Value")) Then
                tbCargoChecking.Text = rd.Item("Cargo_Weight_Check_Value")
            Else
                tbCargoChecking.Text = "NULL"
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

        If GlobalFunction.checkTempSealNo = True Then
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
            lblCargoWeight.Text = "Failed"
            lblCargoWeight.ForeColor = Color.Red

        Else
            lblCargoWeight.Text = "Passed"
        End If

        If My.Settings.role_id = 1 And My.Settings.adminCheck = True Then
            btnAdminSave.Enabled = True
        Else
            btnAdminSave.Enabled = False
        End If

        If checkSecurityPost = "YES" Then

        Else
            lblCargoWeight.Text = "Uncompleted"
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

    Private Sub button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        GlobalFunction.printPage(e, Panel2, GlobalFunction.checkTempSealNo)
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
            GlobalFunction.checkTempSealNo = True
        Else
            tbTempSeal.Enabled = False
            GlobalFunction.checkTempSealNo = False
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

    Private Sub btnAdminSave_Click(sender As Object, e As EventArgs) Handles btnAdminSave.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con

        con.Open()
        cmd.CommandText = "update Shipping set Reversion='" + "R-S" + "',ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo WHERE ID = @TruckOutNumber"
        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        cmd.Parameters.AddWithValue("checkTempSealNo", GlobalFunction.checkTempSealNo)
        rd = cmd.ExecuteReader
        con.Close()

        con.Open()

        Try
            cmd.CommandText = "update Warehouse set WAREHOUSE_LOCATION = '" + cmbWarehouseLocation.Text + "',LOADING_BAY='" + tbLoadingBay.Text + "',Update_Time ='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', Update_User ='" + My.Settings.username + "',LOADING_COMPLETED_TIME='" + dtpLCT.Value.ToString("HH:mm:ss") + "',LOADING_COMPLETED_DATE='" + dtpLCD.Value.ToString("yyyy-MM-dd") + "',READY_TRUCK_OUT_TIME ='" + dtpRTT.Value.ToString("HH:mm:ss") + "',READY_TRUCK_OUT_DATE='" + dtpRTD.Value.ToString("yyyy-MM-dd") + "', COMPANY ='" + tbSendToCompany.Text + "' , Cargo_weight = '" + tbCargo.Text + "' where  Shipping_ID= @TruckOutNumber1"
            cmd.Parameters.AddWithValue("@TruckOutNumber1", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            con.Close()
            con.Open()
            cmd.CommandText = "update Shipping set COMPANY = '" + tbSendToCompany.Text + "', Reversion = 'R-W', ES_SEAL_NO = '" + cmbEsSealNo.Text + "' where ID= @TruckOutNumber2"
            cmd.Parameters.AddWithValue("@TruckOutNumber2", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            con.Close()

            con.Open()
            cmd.CommandText = "Update Security set Shipping_ID = @TruckOutNumber,Driver_Full_Name = '" + cmbFullName.Text + "',PM_CODE = '" + cmbPmCode.Text + "',PM_REGISTRATION_PLATE = '" + cmbPmRegistrationPlate.Text + "',DRIVER_CHECK = 'YES' ,Update_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Update_User = '" + My.Settings.username + "' where  Shipping_ID= @TruckOutNumber3”
            cmd.Parameters.AddWithValue("@TruckOutNumber3", Me.TruckOutNumber)
            rd = cmd.ExecuteReader
            con.Close()

            MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCancel.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Please only enter integer value in net cargo weight!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class