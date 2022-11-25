Imports System.Data.SqlClient
Imports System.Drawing.Printing


Public Class ShippingEdit

    Public TruckOutNumber As Integer
    Dim checkShippingPost As String
    Dim checkWarehousePost As String
    Dim checkSecurityPost As String
    Dim checkWarehouseCheckpoint As String
    Public Shared checkTempSealNo As Boolean = True



    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GlobalFunction.topHeader(lblUserDetails, lblCompanyNameHeader)
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


        lblTooNumber.Text = Me.TruckOutNumber
        'Read data from database
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con

        'Read item into combobox
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
            checkTempSealNo
            )



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
        cbShippingPost.Enabled = False
        cbWarehousePost.Enabled = False
        cbSecurityPost.Enabled = False
        If checkShippingPost = "" Then
            cbShippingPost.Checked = False
            cbShippingPost.Text = “Unposted"
            btnSave1.Enabled = True
        Else
            cbShippingPost.Checked = True
            cbShippingPost.Text = "Posted"
            btnSave1.Enabled = False
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
            btnSave1.Enabled = False
        End If

        'show text in cmbCheckTempSeal
        If checkTempSealNo = True Then
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

        'IT admin can make modification all time
        If (My.Settings.role_id = 1 And My.Settings.adminCheck = True) Then
            btnSave1.Enabled = True
            tbContainerNo.Enabled = True
            tbEsSealNo.Enabled = True
            tbInternalSealNo.Enabled = True
            tbLinerSealNo.Enabled = True
            tbTempSeal.Enabled = True
            cmbEsSealNo.Enabled = True
            cmbCheckTempSealNo.Enabled = True
        End If
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel1.Click
    '    'Cancel Button
    '    Dim obj As New Search
    '    obj.Show()
    '    Me.Close()
    'End Sub

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
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim ra As Integer
        Dim con3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If checkShippingPost = "" Then
            cmd.CommandText = "update Shipping set ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo WHERE ID = @TruckOutNumber"
            cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            cmd.Parameters.AddWithValue("@checkTempSealNo", Me.checkTempSealNo)
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

    'print button
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub


    'the details of print function
    Public Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        GlobalFunction.printPage(e, Panel2, checkTempSealNo)
    End Sub

    'change the company full name when the cmb selected value changed
    Private Sub cmbCompany_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbCompany.SelectedIndexChanged
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

    'change the loading port full name when the cmb selected value changed
    Private Sub cmbLoadingPort_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbLoadingPort.SelectedIndexChanged
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


    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        'save button
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
                cmd.CommandText = "update Shipping set Reversion='" + "R-S" + "',ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Last_Modified_User ='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo WHERE ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
                ra = cmd.ExecuteNonQuery

                MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GlobalFunction.backToPage(Search, Me)
            ElseIf checkShippingPost = "YES" And My.Settings.adminCheck = False Then
                MessageBox.Show("This Number is posted. Please contact admin for modification. ", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.CommandText = "update Shipping set SHIPPING_POST = '" + "YES" + "',SHIPPING_POST_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',ORIGIN = '" + cmbCompany.Text + "',SHIPPING_POST_User = '" + My.Settings.username + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Last_Modified_User='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB ='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo  WHERE ID =@TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
                ra = cmd.ExecuteNonQuery
                MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GlobalFunction.backToPage(Search, Me)
            End If
        End If
        con.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel1.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Close application") = Windows.Forms.DialogResult.Yes Then
            Dim obj As New Search
            obj.Show()
            Me.Close()
            Me.Close()
        End If
    End Sub
End Class