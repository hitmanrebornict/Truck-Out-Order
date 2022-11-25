﻿Imports System.Data.SqlClient
Imports System.Drawing.Printing



Public Class GlobalFunction
    Public Shared checkTempSealNo As Boolean

    Public Shared Function topHeader(lblWelcome As Label, lblCompanyNameHeader As Label)
        lblWelcome.Text = ("Welcome, " & My.Settings.fullName & vbNewLine & "Department of " & My.Settings.departmentName)
        lblCompanyNameHeader.Text = My.Settings.companyNameHeader
        Return ""
    End Function

    Public Shared Function getCmbValue(cmbCompany As ComboBox, cmbLoadingPort As ComboBox, cmbWarehouseLocation As ComboBox, cmbContainerSize As ComboBox)
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
        Return ""
    End Function

    Public Shared Function backToPage(page As Form, self As Form)
        page.Show()
        self.Close()
        Return ""
    End Function

    Public Shared Function printPage(e As PrintPageEventArgs, panel2 As Panel, checkTempSealNo As Boolean)
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
        bit = New Bitmap(panel2.BackgroundImage, New Size(160, 64))
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
        e.Graphics.DrawString("Container No.", printFont, Brushes.Black, 0, 380)
        e.Graphics.DrawString("Es Seal No.", printFont, Brushes.Black, 0, 410)
        e.Graphics.DrawString("Liner Seal No", printFont, Brushes.Black, 0, 440)
        e.Graphics.DrawString("Internal Seal No", printFont, Brushes.Black, 0, 470)
        e.Graphics.DrawString("Temporary Seal No", printFont, Brushes.Black, 0, 500)

        'Second Section parallel part
        e.Graphics.DrawString("Loading Completed Date", printFont, Brushes.Black, 500, 380)
        e.Graphics.DrawString("Loading Completed Time", printFont, Brushes.Black, 500, 410)
        e.Graphics.DrawString("Ready Truck Out Date", printFont, Brushes.Black, 500, 440)
        e.Graphics.DrawString("Ready Truck Out Time", printFont, Brushes.Black, 500, 470)

        'Line between Second and Third Section
        e.Graphics.DrawLine(Pens.Black, 0, 540, 850, 540)

        'Third Section (Post User)
        e.Graphics.DrawString("Shipping Issue By", printFont, Brushes.Black, 0, 560)
        e.Graphics.DrawString("Shipping Seal", printFont, Brushes.Black, 0, 590)
        e.Graphics.DrawString("Shipping Verify By", printFont, Brushes.Black, 0, 620)
        e.Graphics.DrawString("Security Issue by", printFont, Brushes.Black, 0, 650)

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
                tempSealNo = ""
            End If
            e.Graphics.DrawString(": " & tempSealNo, printFont, Brushes.Black, 175, 500)
        Else
            e.Graphics.DrawString(": " & "", printFont, Brushes.Black, 175, 500)
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
        con.Close()
        Return ""
    End Function

    Public Shared Function backToPageAdminCheck(admin As Form, nonAdmin As Form, self As Form)
        Select Case My.Settings.adminCheck
            Case True
                admin.Show()
                self.Close()
            Case Else
                nonAdmin.Show()
                self.Close()
        End Select
        Return ""
    End Function

    Public Shared Function selectFromShipping(
    TruckOutNumber As Integer,
    cmbcompany As ComboBox,
    dtpSCD As DateTimePicker,
    dtpSCT As DateTimePicker,
    tbInvoice As TextBox,
    tbProduct As TextBox,
    tbShippingLine As TextBox,
    cmbContainerSize As ComboBox,
    tbHaulier As TextBox,
    cmbLoadingPort As ComboBox,
    tbContainerNo As TextBox,
    tbLinerSealNo As TextBox,
    tbInternalSealNo As TextBox,
    tbTempSeal As TextBox,
    cmbEsSealNo As ComboBox,
    cmbDDB As ComboBox,
    checkShippingPost As String,
    checkWarehousePost As String,
    checkSecurityPost As String,
    tbSendToCompany As TextBox,
    checkTempSealNo As Boolean
    )
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select checkTempSealNo, ORIGIN, INVOICE, CONTAINER_NO, LINER_SEA_NO, INTERNAL_SEAL_NO, ES_SEAL_NO, COMPANY, TEMPORARY_SEAL_NO, Container_Size, LOADING_PORT, SHIPPING_LINE, HAULIER, PRODUCT, SHIPMENT_CLOSING_DATE, CONVERT(varchar,SHIPMENT_CLOSING_TIME,8) as CloseTime, DDB ,Shipping_Post,warehouse_post,security_post,company from Shipping where id = @TruckOutNumber"
        cmd.Parameters.AddWithValue("@TruckOutNumber", TruckOutNumber)
        rd = cmd.ExecuteReader


        While rd.Read()
            If IsDBNull(rd.Item("ORIGIN")) Then
                cmbcompany.Text = ""
            Else
                cmbcompany.Text = rd.Item("ORIGIN")
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
        Return ""
    End Function
End Class
