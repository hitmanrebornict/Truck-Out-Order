Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Reflection

Public Class ShippingEdit

    Public TruckOutNumber As Integer
    Private checkTempSealNo As Boolean
    Private checkShippingPost As String
    Private checkWarehousePost As String
    Private checkSecurityPost As String
    Private checkWarehouseCheckpoint As String
    Private checkCargoWeight As Boolean

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rd As SqlDataReader
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private companyNameHeader As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblTooNumber.Text = Me.TruckOutNumber
        GlobalFunction.topHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)


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
                checkWarehouseCheckpoint = ""
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


        If checkWarehouseCheckpoint = "YES" Then
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

        If checkShippingPost = "" Then
            cmd.CommandText = "update Shipping set ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "',LINER_SEA_NO='" + GlobalFunction.TrimSpace(tbLinerSealNo.Text) + "',INTERNAL_SEAL_NO='" + GlobalFunction.TrimSpace(tbInternalSealNo.Text) + "',TEMPORARY_SEAL_NO='" + GlobalFunction.TrimSpace(tbTempSeal.Text) + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo,Product_Type = '" + cmbProductType.Text + "' ,Net_Cargo_Weight ='" + tbCargo.Text + "' WHERE ID = @TruckOutNumber"
            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)
            ra = cmd.ExecuteNonQuery
            MessageBox.Show("Save Complete as " & Me.TruckOutNumber, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalFunction.backToPage(Search, Me)
        Else
            MessageBox.Show("This Number is posted. Please contact admin for modification. ", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        'Post button
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
            MessageBox.Show("Please Fill Out The SHIPMENT CLOSING DATE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbCompany.Text = "" Then
            MessageBox.Show("Please Fill Out The COMPANY Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpSCT.Text = "" Then
            MessageBox.Show("Please Fill Out The SHIPPING CLOSING TIME Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbInvoice.Text = "" Then
            MessageBox.Show("Please Fill Out The INVOICE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbProduct.Text = "" Then
            MessageBox.Show("Please Fill Out The PRODUCT Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbShippingLine.Text = "" Then
            MessageBox.Show("Please Fill Out The SHIPPING_LINE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbHaulier.Text = "" Then
            MessageBox.Show("Please Fill Out The HAULIER Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbLoadingPort.Text = "" Then
            MessageBox.Show("Please Fill Out The LOADING_PORT Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbContainerSize.Text = "" Then
            MessageBox.Show("Please Fill Out The Container_Size Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbContainerNo.Text = "" Then
            MessageBox.Show("Please Fill Out The CONTAINER NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tbInternalSealNo.Text = "" Then
            MessageBox.Show("Please Fill Out The INTERNAL SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbCheckTempSealNo.SelectedItem = "YES" And tbTempSeal.Text = "" Then
            MessageBox.Show("Please Fill Out The TEMPORARY SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' ElseIf ComboBox3.Text = "" Then
            '     MessageBox.Show("Please Fill Out The ES_SEAL_NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbDDB.Text = "" Then
            MessageBox.Show("Please Fill Out The DDB Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'shipping save
            If checkShippingPost = "YES" And My.Settings.adminCheck = True Then
                cmd.CommandText = "update Shipping set Reversion='" + "R-S" + "',ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "',LINER_SEA_NO='" + GlobalFunction.TrimSpace(tbLinerSealNo.Text) + "',INTERNAL_SEAL_NO='" + GlobalFunction.TrimSpace(tbInternalSealNo.Text) + "',TEMPORARY_SEAL_NO='" + GlobalFunction.TrimSpace(tbTempSeal.Text) + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo,Product_Type = '" + cmbProductType.Text + "' ,Net_Cargo_Weight ='" + tbCargo.Text + "' WHERE ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("checkTempSealNo", checkTempSealNo)
                ra = cmd.ExecuteNonQuery

                MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GlobalFunction.backToPage(Search, Me)
            ElseIf checkShippingPost = "YES" And My.Settings.adminCheck = False Then
                MessageBox.Show("This Number is posted. Please contact admin for modification. ", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.CommandText = "update Shipping set SHIPPING_POST = '" + "YES" + "',SHIPPING_POST_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',ORIGIN = '" + cmbCompany.Text + "',SHIPPING_POST_User = '" + My.Settings.username + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "',LINER_SEA_NO='" + GlobalFunction.TrimSpace(tbLinerSealNo.Text) + "',INTERNAL_SEAL_NO='" + GlobalFunction.TrimSpace(tbInternalSealNo.Text) + "',TEMPORARY_SEAL_NO='" + GlobalFunction.TrimSpace(tbTempSeal.Text) + "',Last_Modified_User='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB ='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo ,Product_Type = '" + cmbProductType.Text + "' ,Net_Cargo_Weight ='" + tbCargo.Text + "' WHERE ID =@TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)
                ra = cmd.ExecuteNonQuery
                MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GlobalFunction.backToPage(Search, Me)
            End If
        End If
        con.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel1.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Close application") = Windows.Forms.DialogResult.Yes Then
            GlobalFunction.backToPage(Search, Me)
        End If
    End Sub
End Class