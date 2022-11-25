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

        'Read Data Into Company Combobox
        getCmbItem()



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
            'btnCancel.PerformClick()
            MessageBox.Show("Save Complete as " & Me.TruckOutNumber, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            meclose()
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
        Dim printFont As Font
        Dim tooNumberFont As Font
        printFont = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        tooNumberFont = New Font("Microsoft Sans Serif", 10)
        Dim bit As Bitmap
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 0, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 50, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 100, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 150, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 200, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 300, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 400, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 500, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 600, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 800, 0)
        'e.Graphics.DrawString("1", printfont, Brushes.Black, 850, 0)
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim lcd, lct, rtd, rtt, esSealNo, netCargoWeight As String
        Dim driverFullName, pmCode, registrationPlate, netCargoWeightCheckValue, netCargoWeightCheck As String
        Dim checkCargoWeight As Boolean

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT * FROM COMPANY WHERE companyID = 1"
        rd = cmd.ExecuteReader
        rd.Read()
        'Read the company details
        Dim companyName As String = rd.Item("CompanyName")
        Dim addressLine1 As String = rd.Item("AddressLine1")
        Dim addressline2 As String
        If IsDBNull(rd.Item("AddressLine2")) Then
            addressline2 = ""
        Else
            addressline2 = rd.Item("AddressLine2")
        End If
        Dim city As String = rd.Item("City")
        Dim state As String = rd.Item("State")
        Dim country As String = rd.Item("Country")
        Dim PostalCode As Integer = rd.Item("PostalCode")
        Dim phone As String = rd.Item("Phone")
        Dim fax As String = rd.Item("Fax")
        Dim registrationNum As String = rd.Item("RegistrationNum")

        con.Close()
        ' Logo Image
        bit = New Bitmap(Panel2.BackgroundImage, New Size(160, 64))
        e.Graphics.DrawImage(bit, 0, 0)

        'Font Style
        printFont = New Font("Microsoft Sans Serif", 10)
        tooNumberFont = New Font("Microsoft Sans Setif", 14, FontStyle.Bold)

        'Truck Out Number
        e.Graphics.DrawString("Truck Out Number : " & Search.selected, tooNumberFont, Brushes.Black, 550, 0)

        'Company Details
        e.Graphics.DrawString(companyName, tooNumberFont, Brushes.Black, 0, 70)
        e.Graphics.DrawString(addressLine1 & " " & addressline2, printFont, Brushes.Black, 0, 90)
        e.Graphics.DrawString(PostalCode & " " & city & ", " & state & ", " & country, printFont, Brushes.Black, 0, 105)
        e.Graphics.DrawString("Tel: " & phone & "  Fax: " & fax, printFont, Brushes.Black, 0, 120)

        'First Section (Shipping Details)
        e.Graphics.DrawString("Company", printFont, Brushes.Black, 0, 170)
        e.Graphics.DrawString("Company Full Name", printFont, Brushes.Black, 0, 200)
        e.Graphics.DrawString("Loading Port", printFont, Brushes.Black, 0, 230)
        e.Graphics.DrawString("Loading Port Full Name", printFont, Brushes.Black, 0, 260)
        e.Graphics.DrawString("Product", printFont, Brushes.Black, 0, 290)
        e.Graphics.DrawString("Send To Company", printFont, Brushes.Black, 0, 320)

        'First Section Parellel Part
        e.Graphics.DrawString("Invoice", printFont, Brushes.Black, 500, 170)
        e.Graphics.DrawString("Shipment Closing Date", printFont, Brushes.Black, 500, 200)
        e.Graphics.DrawString("Shipment Closing Time", printFont, Brushes.Black, 500, 230)
        e.Graphics.DrawString("Haulier", printFont, Brushes.Black, 500, 260)
        e.Graphics.DrawString("Container Size", printFont, Brushes.Black, 500, 290)
        e.Graphics.DrawString("Shipping Line", printFont, Brushes.Black, 500, 320)

        'Line between First and Second Section
        e.Graphics.DrawLine(Pens.Black, 0, 360, 850, 360)

        'Second Section (Container No.)
        e.Graphics.DrawString(lblContainerNo.Text, printFont, Brushes.Black, 0, 380)
        e.Graphics.DrawString(lblEsSealNo.Text, printFont, Brushes.Black, 0, 410)
        e.Graphics.DrawString(lblLinerSealNo.Text, printFont, Brushes.Black, 0, 440)
        e.Graphics.DrawString(lblInternalSealNo.Text, printFont, Brushes.Black, 0, 470)
        e.Graphics.DrawString(lblTemporarySealNo.Text, printFont, Brushes.Black, 0, 500)

        'Second Section parallel part
        e.Graphics.DrawString(lblLCD.Text, printFont, Brushes.Black, 500, 380)
        e.Graphics.DrawString(lblLCT.Text, printFont, Brushes.Black, 500, 410)
        e.Graphics.DrawString(lblRTD.Text, printFont, Brushes.Black, 500, 440)
        e.Graphics.DrawString(lblRTT.Text, printFont, Brushes.Black, 500, 470)

        'Line between Second and Third Section
        e.Graphics.DrawLine(Pens.Black, 0, 540, 850, 540)

        'Third Section (Post User)
        e.Graphics.DrawString("Shipping Issue By", printFont, Brushes.Black, 0, 560)
        e.Graphics.DrawString("Shipping Seal", printFont, Brushes.Black, 0, 590)
        e.Graphics.DrawString("Shipping Verify By", printFont, Brushes.Black, 0, 620)
        e.Graphics.DrawString("Security Issue by", printFont, Brushes.Black, 0, 650)

        ''First Section Content
        'e.Graphics.DrawString(": " & cmbCompany.Text, printFont, Brushes.Black, 175, 170)
        'e.Graphics.DrawString(": " & lblCompanyFullName.Text, printFont, Brushes.Black, 175, 200)
        'e.Graphics.DrawString(": " & cmbLoadingPort.Text, printFont, Brushes.Black, 175, 230)
        'e.Graphics.DrawString(": " & lblLoadingPortFullName.Text, printFont, Brushes.Black, 175, 260)
        'e.Graphics.DrawString(": " & tbProduct.Text, printFont, Brushes.Black, 175, 290)
        'e.Graphics.DrawString(": " & tbSendToCompany.Text, printFont, Brushes.Black, 175, 320)

        ''First Section Content Parallel
        'e.Graphics.DrawString(": " & tbInvoice.Text, printFont, Brushes.Black, 700, 170)
        'e.Graphics.DrawString(": " & dtpSCD.Value.ToString("yyyy-MM-dd"), printFont, Brushes.Black, 700, 200)
        'e.Graphics.DrawString(": " & dtpSCT.Value.ToString("HH:mm:ss"), printFont, Brushes.Black, 700, 230)
        'e.Graphics.DrawString(": " & tbHaulier.Text, printFont, Brushes.Black, 700, 260)
        'e.Graphics.DrawString(": " & cmbContainerSize.Text, printFont, Brushes.Black, 700, 290)
        'e.Graphics.DrawString(": " & tbShippingLine.Text, printFont, Brushes.Black, 700, 320)

        ''Second Section Content
        'e.Graphics.DrawString(": " & tbContainerNo.Text, printFont, Brushes.Black, 175, 380)
        'e.Graphics.DrawString(": " & tbEsSealNo.Text, printFont, Brushes.Black, 175, 410)
        'e.Graphics.DrawString(": " & tbLinerSealNo.Text, printFont, Brushes.Black, 175, 440)
        'e.Graphics.DrawString(": " & tbInternalSealNo.Text, printFont, Brushes.Black, 175, 470)
        'If checkTempSealNo = True Then
        '    e.Graphics.DrawString(": " & tbTempSeal.Text, printFont, Brushes.Black, 175, 500)
        'Else
        '    e.Graphics.DrawString(": " & "NULL", printFont, Brushes.Black, 175, 500)
        'End If

        con.Open()
        cmd.CommandText = "SELECT * from shipping where ID = @TruckOutNumber"
        cmd.Parameters.AddWithValue("@TruckOutNumber", Search.selected)
        rd = cmd.ExecuteReader
        rd.Read()

        Dim origin As String = rd.Item("origin")
        Dim loadingPort As String = rd.Item("Loading_Port")

        e.Graphics.DrawString(": " & origin, printFont, Brushes.Black, 175, 170)

        e.Graphics.DrawString(": " & loadingPort, printFont, Brushes.Black, 175, 230)

        e.Graphics.DrawString(": " & rd.Item("Product"), printFont, Brushes.Black, 175, 290)
        e.Graphics.DrawString(": " & rd.Item("Company"), printFont, Brushes.Black, 175, 320)

        Dim scd As String = Date.Parse(rd.Item("Shipment_Closing_Date").ToString()).ToString("yyyy-MM-dd")
        Dim sct As String = DateTime.Parse(rd.Item("Shipment_Closing_Time").ToString()).ToString("HH:mm:ss")
        'First Section Content Parallel
        e.Graphics.DrawString(": " & rd.Item("Invoice"), printFont, Brushes.Black, 700, 170)
        e.Graphics.DrawString(": " & scd, printFont, Brushes.Black, 700, 200)
        e.Graphics.DrawString(": " & sct, printFont, Brushes.Black, 700, 230)
        e.Graphics.DrawString(": " & rd.Item("Haulier"), printFont, Brushes.Black, 700, 260)
        e.Graphics.DrawString(": " & rd.Item("Container_Size"), printFont, Brushes.Black, 700, 290)
        e.Graphics.DrawString(": " & rd.Item("Shipping_Line"), printFont, Brushes.Black, 700, 320)

        'Second Section Content
        e.Graphics.DrawString(": " & rd.Item("Container_No"), printFont, Brushes.Black, 175, 380)

        e.Graphics.DrawString(": " & rd.Item("Liner_SEA_NO"), printFont, Brushes.Black, 175, 440)
        e.Graphics.DrawString(": " & rd.Item("INTERNAL_SEAL_NO"), printFont, Brushes.Black, 175, 470)
        Dim tempSealNo As String
        If checkTempSealNo = True Then
            tempSealNo = rd.Item("TEMPORARY_SEAL_NO")
            If Len(tempSealNo) >= 1 Then
            Else
                tempSealNo = "NULL"
            End If
            e.Graphics.DrawString(": " & tempSealNo, printFont, Brushes.Black, 175, 500)
        Else
            e.Graphics.DrawString(": " & "NULL", printFont, Brushes.Black, 175, 500)
        End If


        'Check shipping, warehouse, security post statement
        Dim warehousePostUser As String
        Dim securityPostUser As String
        Dim checkWarehouseCheckPoint As String
        Dim warehouseCheckUser As String

        Dim shippingPostUser As String = rd.Item("Shipping_Post_User")
        If IsDBNull(rd.Item("Warehouse_Post_User")) Then
            warehousePostUser = "Uncompleted"
        Else
            warehousePostUser = rd.Item("Warehouse_Post_User")
        End If

        If IsDBNull(rd.Item("Security_Post_User")) Then
            securityPostUser = "Uncompleted"
        Else
            securityPostUser = rd.Item("Security_Post_User")
        End If

        con.Close()

        Dim companyFullName, loadingPortFullName As String
        con.Open()
        cmd.CommandText = "select distinct(full_name) as companyFullName from details where company_name = @origin and company_name is not null"
        cmd.Parameters.AddWithValue("@origin", origin)
        rd = cmd.ExecuteReader
        rd.Read()
        companyFullName = rd.Item("companyFullName")
        con.Close()
        con.Open()
        cmd.CommandText = "select distinct(full_name) as loadingPortFullName from details where loading_port = @loadingPort and loading_port is not null"
        cmd.Parameters.AddWithValue("@loadingPort", loadingPort)
        rd = cmd.ExecuteReader
        rd.Read()
        loadingPortFullName = rd.Item("loadingPortFullName")
        con.Close()

        e.Graphics.DrawString(": " & companyFullName, printFont, Brushes.Black, 175, 200)
        e.Graphics.DrawString(": " & loadingPortFullName, printFont, Brushes.Black, 175, 260)

        'Post User Section Detail


        con.Open()
        cmd.CommandText = "SELECT * from Warehouse Where Shipping_ID = @TruckOutNumberWarehouse"
        cmd.Parameters.AddWithValue("@TruckOutNumberWarehouse", Search.selected)
        rd = cmd.ExecuteReader
        rd.Read()


        If rd.HasRows() Then
            lcd = Date.Parse(rd.Item("Loading_Completed_Date").ToString()).ToString("yyyy-MM-dd")
            lct = DateTime.Parse(rd.Item("Loading_Completed_Time").ToString()).ToString("HH:mm:ss")
            rtd = Date.Parse(rd.Item("Ready_Truck_Out_Date").ToString()).ToString("yyyy-MM-dd")
            rtt = DateTime.Parse(rd.Item("Ready_Truck_Out_Time").ToString()).ToString("HH:mm:ss")
            If IsDBNull(rd.Item("Es_Seal_No")) Then
                esSealNo = ""
            Else
                esSealNo = rd.Item("Es_Seal_No")
                If Len(esSealNo) >= 1 Then
                Else
                    esSealNo = ""
                End If
            End If
            If IsDBNull(rd.Item("Warehouse_Checkpoint_Check")) Then
                checkWarehouseCheckPoint = ""
            Else
                checkWarehouseCheckPoint = rd.Item("Warehouse_Checkpoint_Check")
            End If

            If IsDBNull(rd.Item("Warehouse_CheckPoint_Update_User")) Then
                warehouseCheckUser = ""
            Else
                warehouseCheckUser = rd.Item("Warehouse_CheckPoint_Update_User")
            End If
            If IsDBNull(rd.Item("Cargo_Weight")) Then
                netCargoWeight = ""
            Else
                netCargoWeight = rd.Item("Cargo_Weight")
            End If
        End If

        con.Close()
        con.Open()
        cmd.CommandText = "Select * from Security where Shipping_ID = @TruckOutNumber4"
        cmd.Parameters.AddWithValue("@TruckOutNumber4", Search.selected)
        rd = cmd.ExecuteReader()
        If rd.HasRows() Then
            rd.Read()
            If Not IsDBNull(rd.Item("DRIVER_FULL_NAME")) Then
                driverFullName = rd.Item("DRIVER_FULL_NAME")
            Else
                driverFullName = ""
            End If

            If Not IsDBNull(rd.Item("PM_CODE")) Then
                pmCode = rd.Item("PM_CODE")
            Else
                pmCode = ""
            End If

            If Not IsDBNull(rd.Item("PM_REGISTRATION_PLATE")) Then
                registrationPlate = rd.Item("PM_REGISTRATION_PLATE")
            Else
                registrationPlate = ""
            End If

            If Not IsDBNull(rd.Item("Cargo_Weight_Check")) Then
                checkCargoWeight = rd.Item("Cargo_Weight_Check")
                If checkCargoWeight = True Then
                    netCargoWeightCheck = "Passed"
                Else
                    netCargoWeightCheck = "Failed"
                End If
            Else
                netCargoWeight = ""
            End If


            If Not IsDBNull(rd.Item("Cargo_Weight_Check_Value")) Then
                netCargoWeightCheckValue = rd.Item("Cargo_Weight_Check_Value")
            Else
                netCargoWeightCheckValue = ""
            End If
        End If
        con.Close()

        e.Graphics.DrawString(": " & esSealNo, printFont, Brushes.Black, 175, 410)
        'Second Section Content Parallel
        e.Graphics.DrawString(": " & lcd, printFont, Brushes.Black, 700, 380)
        e.Graphics.DrawString(": " & lct, printFont, Brushes.Black, 700, 410)
        e.Graphics.DrawString(": " & rtd, printFont, Brushes.Black, 700, 440)
        e.Graphics.DrawString(": " & rtt, printFont, Brushes.Black, 700, 470)

        e.Graphics.DrawString(": " & shippingPostUser, printFont, Brushes.Black, 175, 560)

        If checkWarehouseCheckPoint = "YES" Then
            e.Graphics.DrawString(": " & warehouseCheckUser, printFont, Brushes.Black, 175, 590)
        Else
            e.Graphics.DrawString(": " & "Uncompleted", printFont, Brushes.Black, 175, 590)
        End If
        e.Graphics.DrawString(": " & warehousePostUser, printFont, Brushes.Black, 175, 620)
        e.Graphics.DrawString(": " & securityPostUser, printFont, Brushes.Black, 175, 650)


        'Current User Part
        e.Graphics.DrawLine(Pens.Black, 0, 690, 850, 690)
        e.Graphics.DrawString("Net Cargo Weight Checking", printFont, Brushes.Black, 0, 710)
        e.Graphics.DrawString("Net Cargo Weight", printFont, Brushes.Black, 0, 740)
        e.Graphics.DrawString("Net Cargo Weight Checking Value", printFont, Brushes.Black, 0, 770)
        e.Graphics.DrawLine(Pens.Black, 0, 810, 850, 810)
        e.Graphics.DrawString("Driver's Full Name", printFont, Brushes.Black, 0, 830)
        e.Graphics.DrawString("Driver's PM Code ", printFont, Brushes.Black, 0, 860)
        e.Graphics.DrawString("Driver's PM Registration Plate", printFont, Brushes.Black, 0, 890)
        e.Graphics.DrawLine(Pens.Black, 0, 930, 850, 930)
        e.Graphics.DrawString("Current User", printFont, Brushes.Black, 0, 950)

        e.Graphics.DrawString(": " & netCargoWeightCheck, printFont, Brushes.Black, 275, 710)
        e.Graphics.DrawString(": " & netCargoWeight, printFont, Brushes.Black, 275, 740)
        e.Graphics.DrawString(": " & netCargoWeightCheckValue, printFont, Brushes.Black, 275, 770)
        e.Graphics.DrawString(": " & driverFullName, printFont, Brushes.Black, 275, 830)
        e.Graphics.DrawString(": " & pmCode, printFont, Brushes.Black, 275, 860)
        e.Graphics.DrawString(": " & registrationPlate, printFont, Brushes.Black, 275, 890)
        e.Graphics.DrawString(": " & My.Settings.username, printFont, Brushes.Black, 275, 950)
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

    Private Function getCmbItem()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
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
    End Function

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
                meclose()
            ElseIf checkShippingPost = "YES" And My.Settings.adminCheck = False Then
                MessageBox.Show("This Number is posted. Please contact admin for modification. ", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.CommandText = "update Shipping set SHIPPING_POST = '" + "YES" + "',SHIPPING_POST_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',ORIGIN = '" + cmbCompany.Text + "',SHIPPING_POST_User = '" + My.Settings.username + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Last_Modified_User='" + My.Settings.username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB ='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo  WHERE ID =@TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
                ra = cmd.ExecuteNonQuery
                MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                meclose()
            End If
        End If
        con.Close()
    End Sub

    Private Function meclose()
        Dim obj As New Search
        obj.Show()
        Me.Close()
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel1.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Close application") = Windows.Forms.DialogResult.Yes Then
            Dim obj As New Search
            obj.Show()
            Me.Close()
            Me.Close()
        End If
    End Sub
End Class