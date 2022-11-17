Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Printing
Imports System.Net.Security

Public Class ShippingEdit
    Public Username As String
    Public role_id As Integer
    Public TruckOutNumber As Integer
    Public departmentName As String
    Public adminCheck As String
    Public companyNameHeader As String
    Dim checkShippingPost As String
    Dim checkWarehousePost As String
    Dim checkSecurityPost As String
    Dim checkTempSealNo As Boolean = True
    Public fullName As String

    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        lblUserDetails.Text = ("Welcome, " & fullName & vbNewLine & "Department of " & departmentName)
        lblTooNumber.Text = Me.TruckOutNumber
        lblCompanyNameHeader.Text = companyNameHeader
        'Read data from database
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
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

        'if warehouse post ald, then shipping can't the value anymore
        If checkWarehousePost = "" Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel1.Click
        'Cancel Button
        Dim obj As New Search With {
            .username = Me.Username,
            .role_id = Me.role_id,
            .departmentName = Me.departmentName,
            .adminCheck = Me.adminCheck,
            .fullName = Me.fullName,
            .companyNameHeader = Me.companyNameHeader
        }
        obj.Show()
        Me.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

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

    Private Sub btnWarehouseSave_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
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
            If checkShippingPost = "YES" Then
                cmd.CommandText = "update Shipping set Reversion='" + "R-S" + "',ORIGIN = '" + cmbCompany.Text + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Update_User='" + Me.Username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo WHERE ID = @TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
                ra = cmd.ExecuteNonQuery
                btnCancel1.PerformClick()
                MessageBox.Show("Update Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cmd.CommandText = "update Shipping set SHIPPING_POST = '" + "YES" + "',SHIPPING_POST_Time = '" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',ORIGIN = '" + cmbCompany.Text + "',SHIPPING_POST_User = '" + Me.Username + "',INVOICE = '" + tbInvoice.Text + "',PRODUCT='" + tbProduct.Text + "',SHIPMENT_CLOSING_DATE = '" + dtpSCD.Value.ToString("yyyy-MM-dd") + "',SHIPMENT_CLOSING_TIME= '" + dtpSCT.Value.ToString("HH:mm:ss") + "',SHIPPING_LINE='" + tbShippingLine.Text + "',Container_Size ='" + cmbContainerSize.Text + "',HAULIER ='" + tbHaulier.Text + "',LOADING_PORT='" + cmbLoadingPort.Text + "', CONTAINER_NO='" + tbContainerNo.Text + "',LINER_SEA_NO='" + tbLinerSealNo.Text + "',INTERNAL_SEAL_NO='" + tbInternalSealNo.Text + "',TEMPORARY_SEAL_NO='" + tbTempSeal.Text + "',Update_User='" + Me.Username + "',Update_Time='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',DDB ='" + cmbDDB.Text + "', checkTempSealNo = @checkTempSealNo  WHERE ID =@TruckOutNumber"
                cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
                cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
                ra = cmd.ExecuteNonQuery
                btnCancel1.PerformClick()
                MessageBox.Show("Post Complete", "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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

    ' PrintDialog1.Document = PrintDocument1

    '    Dim dialogResult As DialogResult = PrintDialog1.ShowDialog()
    'If (dialogResult = DialogResult.OK) Then
    '        PrintDocument1.Print()
    '    End If
    Private bitmap As Bitmap
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Add a Panel control.
        'Show the Print Preview Dialog.
        'Dim dialogResult As DialogResult = PrintDialog1.ShowDialog()
        'If (dialogResult = DialogResult.OK) Then
        '    PrintDocument1.Print()
        'End If

        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()

        End If
    End Sub



    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printfont As Font
        Dim tooNumberFont As Font
        Dim bit As Bitmap
        'e.Graphics.DrawString("1", printFont, Brushes.Black, 0, 0)
        'e.Graphics.DrawString("1", printFont, Brushes.Black, 50, 0)
        'e.Graphics.DrawString("1", printFont, Brushes.Black, 100, 0)
        'e.Graphics.DrawString("1", printFont, Brushes.Black, 150, 0)
        'e.Graphics.DrawString("1", printFont, Brushes.Black, 200, 0)
        'e.Graphics.DrawString("1", printFont, Brushes.Black, 300, 0)
        'e.Graphics.DrawString("1", printFont, Brushes.Black, 400, 0)
        'e.Graphics.DrawString("1", printFont, Brushes.Black, 500, 0)
        'e.Graphics.DrawString("1", printFont, Brushes.Black, 600, 0)
        ''e.Graphics.DrawString("1", printFont, Brushes.Black, 800, 0)
        ''e.Graphics.DrawString("1", printFont, Brushes.Black, 850, 0)
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
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
        bit = New Bitmap(Panel2.BackgroundImage, New Size(128, 64))
        e.Graphics.DrawImage(bit, 0, 0)

        'Font Style
        printfont = New Font("Microsoft Sans Serif", 10)
        tooNumberFont = New Font("Microsoft Sans Setif", 14, FontStyle.Bold)

        'Truck Out Number
        e.Graphics.DrawString("Truck Out Number:" & Me.TruckOutNumber, tooNumberFont, Brushes.Black, 550, 0)

        'Company Details
        e.Graphics.DrawString(companyName, tooNumberFont, Brushes.Black, 0, 70)
        e.Graphics.DrawString(addressLine1 & " " & addressline2, printfont, Brushes.Black, 0, 90)
        e.Graphics.DrawString(PostalCode & " " & city & ", " & state & ", " & country, printfont, Brushes.Black, 0, 105)
        e.Graphics.DrawString("Tel: " & phone & "  Fax: " & fax, printfont, Brushes.Black, 0, 120)

        'First Section (Shipping Details)
        e.Graphics.DrawString("Company", printfont, Brushes.Black, 0, 170)
        e.Graphics.DrawString("Company Full Name", printfont, Brushes.Black, 0, 200)
        e.Graphics.DrawString("Loading Port", printfont, Brushes.Black, 0, 230)
        e.Graphics.DrawString("Loading Port Full Name", printfont, Brushes.Black, 0, 260)
        e.Graphics.DrawString("Product", printfont, Brushes.Black, 0, 290)
        e.Graphics.DrawString("Send To Company", printfont, Brushes.Black, 0, 320)

        'First Section Parellel Part
        e.Graphics.DrawString("Invoice", printfont, Brushes.Black, 500, 170)
        e.Graphics.DrawString("Shipment Closing Date", printfont, Brushes.Black, 500, 200)
        e.Graphics.DrawString("Shipment Closing Time", printfont, Brushes.Black, 500, 230)
        e.Graphics.DrawString("Haulier", printfont, Brushes.Black, 500, 260)
        e.Graphics.DrawString("Container Size", printfont, Brushes.Black, 500, 290)
        e.Graphics.DrawString("Shipping Line", printfont, Brushes.Black, 500, 320)

        'Line between First and Second Section
        e.Graphics.DrawLine(Pens.Black, 0, 360, 850, 360)

        'Second Section (Container No.)
        e.Graphics.DrawString(lblContainerNo.Text, printfont, Brushes.Black, 0, 380)
        e.Graphics.DrawString(lblEsSealNo.Text, printfont, Brushes.Black, 0, 410)
        e.Graphics.DrawString(lblLinerSealNo.Text, printfont, Brushes.Black, 0, 440)
        e.Graphics.DrawString(lblInternalSealNo.Text, printfont, Brushes.Black, 0, 470)
        e.Graphics.DrawString(lblTemporarySealNo.Text, printfont, Brushes.Black, 0, 500)

        'Second Section parallel part
        e.Graphics.DrawString(lblLCD.Text, printfont, Brushes.Black, 500, 380)
        e.Graphics.DrawString(lblLCT.Text, printfont, Brushes.Black, 500, 410)
        e.Graphics.DrawString(lblRTD.Text, printfont, Brushes.Black, 500, 440)
        e.Graphics.DrawString(lblRTT.Text, printfont, Brushes.Black, 500, 470)

        'Line between Second and Third Section
        e.Graphics.DrawLine(Pens.Black, 0, 540, 850, 540)

        'Third Section (Post User)
        e.Graphics.DrawString("Shipping Issue By", printfont, Brushes.Black, 0, 560)
        e.Graphics.DrawString("Shipping Seal", printfont, Brushes.Black, 0, 590)
        e.Graphics.DrawString("Shipping Verify By", printfont, Brushes.Black, 0, 620)
        e.Graphics.DrawString("Shipping Verify by", printfont, Brushes.Black, 0, 650)

        'First Section Content
        e.Graphics.DrawString(":" & cmbCompany.Text, printfont, Brushes.Black, 175, 170)
        e.Graphics.DrawString(":" & lblCompanyFullName.Text, printfont, Brushes.Black, 175, 200)
        e.Graphics.DrawString(":" & cmbLoadingPort.Text, printfont, Brushes.Black, 175, 230)
        e.Graphics.DrawString(":" & lblLoadingPortFullName.Text, printfont, Brushes.Black, 175, 260)
        e.Graphics.DrawString(":" & tbProduct.Text, printfont, Brushes.Black, 175, 290)
        e.Graphics.DrawString(":" & tbSendToCompany.Text, printfont, Brushes.Black, 175, 320)

        'First Section Content Parallel
        e.Graphics.DrawString(":" & tbInvoice.Text, printfont, Brushes.Black, 700, 170)
        e.Graphics.DrawString(":" & dtpSCD.Value.ToString("yyyy-MM-dd"), printfont, Brushes.Black, 700, 200)
        e.Graphics.DrawString(":" & dtpSCT.Value.ToString("HH:mm:ss"), printfont, Brushes.Black, 700, 230)
        e.Graphics.DrawString(":" & tbHaulier.Text, printfont, Brushes.Black, 700, 260)
        e.Graphics.DrawString(":" & cmbContainerSize.Text, printfont, Brushes.Black, 700, 290)
        e.Graphics.DrawString(":" & tbShippingLine.Text, printfont, Brushes.Black, 700, 320)

        'Second Section Content
        e.Graphics.DrawString(":" & tbContainerNo.Text, printfont, Brushes.Black, 175, 380)
        e.Graphics.DrawString(":" & tbEsSealNo.Text, printfont, Brushes.Black, 175, 410)
        e.Graphics.DrawString(":" & tbLinerSealNo.Text, printfont, Brushes.Black, 175, 440)
        e.Graphics.DrawString(":" & tbInternalSealNo.Text, printfont, Brushes.Black, 175, 470)
        If checkTempSealNo = True Then
            e.Graphics.DrawString(":" & tbTempSeal.Text, printfont, Brushes.Black, 175, 500)
        Else
            e.Graphics.DrawString(":" & "NULL", printfont, Brushes.Black, 175, 500)
        End If

        'Second Section Content Parallel
        e.Graphics.DrawString(":" & dtpLCD.Value.ToString("yyyy-MM-dd"), printfont, Brushes.Black, 700, 380)
        e.Graphics.DrawString(":" & dtpLCT.Value.ToString("HH:mm:ss"), printfont, Brushes.Black, 700, 410)
        e.Graphics.DrawString(":" & dtpRTD.Value.ToString("yyyy-MM-dd"), printfont, Brushes.Black, 700, 440)
        e.Graphics.DrawString(":" & dtpRTT.Value.ToString("HH:mm:ss"), printfont, Brushes.Black, 700, 470)

        'Check shipping, warehouse, security post statement
        Dim warehousePostUser As String
        Dim securityPostUser As String
        Dim checkWarehouseCheckPoint As String
        Dim warehouseCheckUser As String
        con.Open()

        cmd.CommandText = "SELECT Shipping_Post_User, Warehouse_Post_User,Security_Post_User from shipping where ID = @TruckOutNumber"
        cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
        rd = cmd.ExecuteReader
        rd.Read()
        Dim shippingPostUser As String = rd.Item("Shipping_Post_User")
        If IsDBNull(rd.Item("Warehouse_Post_User")) Then
            warehousePostUser = ""
        Else
            warehousePostUser = rd.Item("Warehouse_Post_User")
        End If

        If IsDBNull(rd.Item("Security_Post_User")) Then
            securityPostUser = ""
        Else
            securityPostUser = rd.Item("Security_Post_User")
        End If

        con.Close()

        'Post User Section Detail
        e.Graphics.DrawString(":" & shippingPostUser, printfont, Brushes.Black, 175, 560)

        con.Open()
        cmd.CommandText = "SELECT Warehouse_Checkpoint_Update_User, Warehouse_Checkpoint_Check from Warehouse Where Shipping_ID = @TruckOutNumberWarehouse"
        cmd.Parameters.AddWithValue("@TruckOutNumberWarehouse", Me.TruckOutNumber)
        rd = cmd.ExecuteReader
        rd.Read()
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


        If checkWarehouseCheckPoint = "YES" Then
            e.Graphics.DrawString(":" & warehouseCheckUser, printfont, Brushes.Black, 175, 590)
        Else
            e.Graphics.DrawString(":" & "Uncompleted", printfont, Brushes.Black, 175, 590)
        End If

        If checkWarehousePost = "YES" Then
            e.Graphics.DrawString(":" & warehousePostUser, printfont, Brushes.Black, 175, 620)
        Else
            e.Graphics.DrawString(":" & "Uncompleted", printfont, Brushes.Black, 175, 620)
        End If

        If checkSecurityPost = "YES" Then
            e.Graphics.DrawString(":" & securityPostUser, printfont, Brushes.Black, 175, 650)
        Else
            e.Graphics.DrawString(":" & "Uncompleted", printfont, Brushes.Black, 175, 650)
        End If

        'Current User Part
        e.Graphics.DrawLine(Pens.Black, 0, 690, 850, 690)
        e.Graphics.DrawString("Current User", printfont, Brushes.Black, 0, 710)
        e.Graphics.DrawString(":" & Me.Username, printfont, Brushes.Black, 175, 710)
    End Sub
End Class