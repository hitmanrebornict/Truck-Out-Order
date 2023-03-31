Imports System.Data.SqlClient
Imports Truck_Out_Order.My.Resources

Public Class Search

    Public Shared selected As String
    Private companyNameHeader As String
    Private checkCargoWeight As Boolean
    Private checkISOTank As Boolean
    Private stringFillRequired,
            stringSearchError,
            stringFilterError As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (My.Settings.languageSetting = "fr") Then
            btnCancel.Text = ResourceSearchFrench.btnCancel
            btnFilter.Text = ResourceSearchFrench.btnFilter
            btnSearch.Text = ResourceSearchFrench.btnSearch
            lblContainerNo.Text = ResourceSearchFrench.lblContainerNo
            lblInvoiceNumber.Text = ResourceSearchFrench.lblInvoiceNumber
            lblShippingID.Text = ResourceSearchFrench.lblShippingID
            stringFillRequired = ResourceSearchFrench.stringFillRequired
            stringSearchError = ResourceSearchFrench.stringSearchError
            stringFilterError = ResourceSearchFrench.stringFilterError
        Else
            btnCancel.Text = ResourceSearch.btnCancel
            btnFilter.Text = ResourceSearch.btnFilter
            btnSearch.Text = ResourceSearch.btnSearch
            lblContainerNo.Text = ResourceSearch.lblContainerNo
            lblInvoiceNumber.Text = ResourceSearch.lblInvoiceNumber
            lblShippingID.Text = ResourceSearch.lblShippingID
            stringFillRequired = ResourceSearch.stringFillRequired
            stringSearchError = ResourceSearch.stringSearchError
            stringFilterError = ResourceSearch.stringFilterError
        End If
        GlobalFunction.TopHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dim selectString As String = "SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank' from Shipping"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If My.Settings.adminCheck = True And (My.Settings.role_id = 2 Or My.Settings.role_id = 1) Then
            cmd.CommandText = (selectString & " order by id desc")
        Else
            Select Case My.Settings.role_id
                Case 2
                    cmd.CommandText = (selectString & " order by id desc")
                Case 3, 4
                    If (My.Settings.adminCheck) Then
                        cmd.CommandText = selectString & " WHERE SHIPPING_POST = 1 and Security_Post is null and Check_ISO_Tank = 0 order by id desc"
                    Else
                        cmd.CommandText = (selectString & " where shipping_post = 1 and warehouse_Post is null and Check_ISO_Tank = 0 order by id desc")
                    End If
                Case 5
                    cmd.CommandText = (selectString & "  where shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) order by id desc")
            End Select
        End If
        rd = cmd.ExecuteReader
        con.Close()
        sda.Fill(dt)
        dgv.DataSource = dt
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim rd2 As SqlDataReader
        Dim con3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        Dim rd3 As SqlDataReader
        Dim sda As New SqlDataAdapter(cmd2)
        Dim sda3 As New SqlDataAdapter(cmd3)
        Dim dt As New DataTable()
        Dim selected As String = tbShippingId.Text
        Dim checkDuplicate As Integer
        Dim selectString As String = "SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User' from Shipping"

        con2.ConnectionString = My.Settings.connstr
        cmd2.Connection = con2
        con2.Open()
        con3.ConnectionString = My.Settings.connstr
        cmd3.Connection = con3
        con3.Open()

        If tbShippingId.Text = "" And tbInvoice.Text = "" And tbContainerNo.Text = "" Then
            MessageBox.Show(stringFillRequired, stringSearchError, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'If tbShippingId.Text <> "" And tbInvoice.Text = "" And tbContainerNo.Text = "" Then
            If tbShippingId.Text <> "" Then
                Select Case My.Settings.role_id
                    Case 2
                        cmd2.CommandText = "Select COUNT(ID) as COUNTID from Shipping where ID = @shipping_id2"
                        cmd3.CommandText = selectString & " where ID = @shipping_id3"
                    Case 3, 4
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where ID = @shipping_id2 and (SHIPPING_POST = 1 or WAREHOUSE_POST is NULL)"
                        cmd3.CommandText = selectString & " where ID = @shipping_id3 and (SHIPPING_POST = 1 or WAREHOUSE_POST is NULL)"
                    Case 5
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) and ID = @shipping_id2"
                        cmd3.CommandText = selectString & " where shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) and ID = @shipping_id3"
                    Case 1
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where ID = @shipping_id2"
                        cmd3.CommandText = selectString & " where ID = @shipping_id3"
                End Select
                cmd2.Parameters.AddWithValue("@shipping_id2", tbShippingId.Text)
                cmd3.Parameters.AddWithValue("@shipping_id3", tbShippingId.Text)
                'ElseIf tbShippingId.Text = "" And tbInvoice.Text <> "" And tbContainerNo.Text = "" Then
            ElseIf tbInvoice.Text <> "" Then
                Select Case My.Settings.role_id
                    Case 2
                        cmd2.CommandText = "Select COUNT(ID) as COUNTID from Shipping where  INVOICE = @invoice2"
                        cmd3.CommandText = selectString & " where INVOICE = @invoice3"
                    Case 3, 4
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where INVOICE = @invoice2 and (SHIPPING_POST = 1 or WAREHOUSE_POST is NULL)"
                        cmd3.CommandText = selectString & " where INVOICE = @invoice3 and (SHIPPING_POST = 1 or WAREHOUSE_POST is NULL)"
                    Case 5
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) and INVOICE = @invoice2"
                        cmd3.CommandText = selectString & "  where shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) and INVOICE = @invoice3"
                    Case 1
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where INVOICE = @invoice2"
                        cmd3.CommandText = selectString & " where INVOICE = @invoice3"
                End Select
                cmd2.Parameters.AddWithValue("@invoice2", tbInvoice.Text)
                cmd3.Parameters.AddWithValue("@invoice3", tbInvoice.Text)
                'ElseIf tbShippingId.Text = "" And tbInvoice.Text = "" And tbContainerNo.Text <> "" Then
            ElseIf tbContainerNo.Text <> "" Then
                Select Case My.Settings.role_id
                    Case 2
                        cmd2.CommandText = "Select COUNT(ID) as COUNTID from Shipping WHERE CONTAINER_NO = @container_id2"
                        cmd3.CommandText = selectString & " where CONTAINER_NO = @container_id3"
                    Case 3, 4
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where CONTAINER_NO = @container_id2 and (SHIPPING_POST = 1 or WAREHOUSE_POST is NULL)"
                        cmd3.CommandText = selectString & " where CONTAINER_NO = @container_id3 and (SHIPPING_POST = 1 or WAREHOUSE_POST is NULL)"
                    Case 5
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping  where shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) and CONTAINER_NO = @container_id2"
                        cmd3.CommandText = selectString & " where shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) and CONTAINER_NO = @container_id3"
                    Case 1
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where CONTAINER_NO = @container_id2"
                        cmd3.CommandText = selectString & " where CONTAINER_NO = @container_id3"
                End Select
                cmd2.Parameters.AddWithValue("@container_id2", tbContainerNo.Text)
                cmd3.Parameters.AddWithValue("@container_id3", tbContainerNo.Text)
            End If
            Me.selected = selected
            Try
                rd2 = cmd2.ExecuteReader
                rd2.Read()
                checkDuplicate = rd2.Item("COUNTID")
                con2.Close()
                If checkDuplicate > 1 Then
                    rd3 = cmd3.ExecuteReader
                    con3.Close()
                    sda3.Fill(dt)
                    dgv.DataSource = dt
                Else
                    con3.Close()
                    con3.Open()
                    rd3 = cmd3.ExecuteReader
                    rd3.Read()
                    selected = rd3.Item("Truck Out Number")
                    Select Case My.Settings.role_id
                        Case 1
                            Dim obj As New Edit
                            Edit.TruckOutNumber = selected
                            Edit.Show()
                            Me.Close()
                        Case 2
                            Dim obj As New ShippingEdit
                            obj.TruckOutNumber = selected
                            obj.Show()
                            Me.Close()
                        Case 3, 4
                            Dim obj As New WarehouseEdit
                            obj.TruckOutNumber = selected
                            obj.Show()
                            Me.Close()
                        Case 5
                            Dim obj As New SecurityEdit
                            obj.TruckOutNumber = selected
                            obj.Show()
                            Me.Close()
                    End Select
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, stringSearchError, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Try

            End Try

        End If
        tbContainerNo.Text = ""
        tbInvoice.Text = ""
        tbShippingId.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        GlobalFunction.backToPageAdminCheck(Admin, NormalUserPage, Me)
    End Sub

    'Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
    '    Dim con2 As New SqlConnection
    '    Dim cmd2 As New SqlCommand
    '    Dim rd2 As SqlDataReader
    '    Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)

    '    Dim selected As String = row.Cells(0).Value.ToString

    '    con2.ConnectionString = My.Settings.connstr
    '    cmd2.Connection = con2
    '    con2.Open()

    '    Try
    '        Select Case My.Settings.role_id
    '            Case 1
    '                Dim obj As New Edit
    '                Edit.TruckOutNumber = selected
    '                Edit.Show()
    '                Me.Close()
    '            Case 2
    '                If (My.Settings.adminCheck) Then
    '                    cmd2.CommandText = "SELECT id from shipping join security on shipping.id = security.shipping_id where shipping_id = @shippingID and Check_ISO_Tank = 1 and Allow_To_Post is not null"
    '                    cmd2.Parameters.AddWithValue("@shippingID", selected)
    '                    rd2 = cmd2.ExecuteReader
    '                    If (rd2.HasRows()) Then
    '                        Dim Security As New SecurityEdit
    '                        Security.TruckOutNumber = selected
    '                        Security.Show()
    '                        Me.Close()
    '                    Else
    '                        Dim se As New ShippingEdit
    '                        se.TruckOutNumber = selected
    '                        se.Show()
    '                        Me.Close()
    '                    End If
    '                Else
    '                    Dim obj As New ShippingEdit
    '                    obj.TruckOutNumber = selected
    '                    obj.Show()
    '                    Me.Close()
    '                End If

    '            Case 3, 4
    '                If (My.Settings.adminCheck) Then
    '                    cmd2.CommandText = "SELECT Cargo_Weight_Check From Security where shipping_id = @shippingID and Allow_To_Post is not null"
    '                    cmd2.Parameters.AddWithValue("@shippingID", selected)
    '                    rd2 = cmd2.ExecuteReader
    '                    If (rd2.HasRows()) Then
    '                        Dim editPage As New SecurityEdit
    '                        editPage.TruckOutNumber = selected
    '                        editPage.Show()
    '                        Me.Close()
    '                    Else
    '                        Dim obj As New WarehouseEdit
    '                        obj.TruckOutNumber = selected
    '                        obj.Show()
    '                        Me.Close()
    '                    End If

    '                Else
    '                    Dim obj As New WarehouseEdit
    '                    obj.TruckOutNumber = selected
    '                    obj.Show()
    '                    Me.Close()
    '                End If

    '            Case 5
    '                Dim obj As New SecurityEdit
    '                obj.TruckOutNumber = selected
    '                obj.Show()
    '                Me.Close()
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, stringSearchError, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick, dgv.CellClick
        Try
            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim rd2 As SqlDataReader
            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
            Dim selectedTruckOutNumber As String = row.Cells(0).Value.ToString
            Dim selectedInvoceNumber As String = row.Cells(2).Value.ToString
            Dim selectedContainerNumber As String = row.Cells(3).Value.ToString

            tbShippingId.Text = selectedTruckOutNumber
            tbInvoice.Text = selectedInvoceNumber
            tbContainerNo.Text = selectedContainerNumber
        Catch ex As Exception
            MessageBox.Show(ex.Message, stringSearchError, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    'Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
    '    Dim con2 As New SqlConnection
    '    Dim cmd2 As New SqlCommand
    '    Dim rd2 As SqlDataReader
    '    Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)

    '    Dim selected As String = row.Cells(0).Value.ToString

    '    con2.ConnectionString = My.Settings.connstr
    '    cmd2.Connection = con2
    '    con2.Open()

    '    Try
    '        Select Case My.Settings.role_id
    '            Case 1
    '                Dim obj As New Edit
    '                Edit.TruckOutNumber = selected
    '                Edit.Show()
    '                Me.Close()
    '            Case 2
    '                If (My.Settings.adminCheck) Then
    '                    cmd2.CommandText = "SELECT id from shipping join security on shipping.id = security.shipping_id where shipping_id = @shippingID and Check_ISO_Tank = 1 and Allow_To_Post is not null"
    '                    cmd2.Parameters.AddWithValue("@shippingID", selected)
    '                    rd2 = cmd2.ExecuteReader
    '                    If (rd2.HasRows()) Then
    '                        Dim Security As New SecurityEdit
    '                        Security.TruckOutNumber = selected
    '                        Security.Show()
    '                        Me.Close()
    '                    Else
    '                        Dim se As New ShippingEdit
    '                        se.TruckOutNumber = selected
    '                        se.Show()
    '                        Me.Close()
    '                    End If
    '                Else
    '                    Dim obj As New ShippingEdit
    '                    obj.TruckOutNumber = selected
    '                    obj.Show()
    '                    Me.Close()
    '                End If

    '            Case 3, 4
    '                If (My.Settings.adminCheck) Then
    '                    cmd2.CommandText = "SELECT Cargo_Weight_Check From Security where shipping_id = @shippingID and Allow_To_Post is not null"
    '                    cmd2.Parameters.AddWithValue("@shippingID", selected)
    '                    rd2 = cmd2.ExecuteReader
    '                    If (rd2.HasRows()) Then
    '                        Dim editPage As New SecurityEdit
    '                        editPage.TruckOutNumber = selected
    '                        editPage.Show()
    '                        Me.Close()
    '                    Else
    '                        Dim obj As New WarehouseEdit
    '                        obj.TruckOutNumber = selected
    '                        obj.Show()
    '                        Me.Close()
    '                    End If

    '                Else
    '                    Dim obj As New WarehouseEdit
    '                    obj.TruckOutNumber = selected
    '                    obj.Show()
    '                    Me.Close()
    '                End If

    '            Case 5
    '                Dim obj As New SecurityEdit
    '                obj.TruckOutNumber = selected
    '                obj.Show()
    '                Me.Close()
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, stringSearchError, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub dgv_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentDoubleClick, dgv.CellDoubleClick
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim rd2 As SqlDataReader
        Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)

        Dim selected As String = row.Cells(0).Value.ToString

        con2.ConnectionString = My.Settings.connstr
        cmd2.Connection = con2
        con2.Open()

        Try
            Select Case My.Settings.role_id
                Case 1
                    Dim obj As New Edit
                    Edit.TruckOutNumber = selected
                    Edit.Show()
                    Me.Close()
                Case 2
                    If (My.Settings.adminCheck) Then
                        cmd2.CommandText = "SELECT id from shipping join security on shipping.id = security.shipping_id where shipping_id = @shippingID and Check_ISO_Tank = 1 and Allow_To_Post is not null"
                        cmd2.Parameters.AddWithValue("@shippingID", selected)
                        rd2 = cmd2.ExecuteReader
                        If (rd2.HasRows()) Then
                            Dim Security As New SecurityEdit
                            Security.TruckOutNumber = selected
                            Security.Show()
                            Me.Close()
                        Else
                            Dim se As New ShippingEdit
                            se.TruckOutNumber = selected
                            se.Show()
                            Me.Close()
                        End If
                    Else
                        Dim obj As New ShippingEdit
                        obj.TruckOutNumber = selected
                        obj.Show()
                        Me.Close()
                    End If

                Case 3, 4
                    If (My.Settings.adminCheck) Then
                        cmd2.CommandText = "SELECT Cargo_Weight_Check From Security where shipping_id = @shippingID and Allow_To_Post is not null"
                        cmd2.Parameters.AddWithValue("@shippingID", selected)
                        rd2 = cmd2.ExecuteReader
                        If (rd2.HasRows()) Then
                            Dim editPage As New SecurityEdit
                            editPage.TruckOutNumber = selected
                            editPage.Show()
                            Me.Close()
                        Else
                            Dim obj As New WarehouseEdit
                            obj.TruckOutNumber = selected
                            obj.Show()
                            Me.Close()
                        End If

                    Else
                        Dim obj As New WarehouseEdit
                        obj.TruckOutNumber = selected
                        obj.Show()
                        Me.Close()
                    End If

                Case 5
                    Dim obj As New SecurityEdit
                    obj.TruckOutNumber = selected
                    obj.Show()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, stringSearchError, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Same when the page was loaded
        Dim selectString As String = "SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank' from Shipping"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If My.Settings.adminCheck = True And (My.Settings.role_id = 2 Or My.Settings.role_id = 1) Then
            cmd.CommandText = (selectString & " order by id desc")
        Else
            Select Case My.Settings.role_id
                Case 2
                    cmd.CommandText = (selectString & " order by id desc")
                Case 3, 4
                    If (My.Settings.adminCheck) Then
                        cmd.CommandText = selectString & " WHERE SHIPPING_POST = 1 and Security_Post is null and Check_ISO_Tank = 0 order by id desc"
                    Else
                        cmd.CommandText = (selectString & " where shipping_post = 1 and warehouse_Post is null and Check_ISO_Tank = 0 order by id desc")
                    End If
                Case 5
                    cmd.CommandText = (selectString & " where (shipping_post = 1 and warehouse_Post  = 1 and security_post is null) or (shipping_post = 1 and Check_ISO_Tank = 1 and security_post is null) order by id desc")
            End Select
        End If
        rd = cmd.ExecuteReader
        con.Close()
        sda.Fill(dt)
        dgv.DataSource = dt
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        'Filter

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If tbInvoice.Text = "" And tbContainerNo.Text = "" And tbShippingId.Text = "" Then
            MessageBox.Show(stringFillRequired, stringFilterError, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If tbInvoice.Text <> "" And tbContainerNo.Text = "" And tbShippingId.Text = "" Then
                If My.Settings.role_id = 5 Then
                    cmd.CommandText = ("SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank'  from Shipping where INVOICE like @Invoice + '%' and shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) order by id desc")
                ElseIf My.Settings.role_id = 3 Or My.Settings.role_id = 4 Then
                    cmd.CommandText = ("SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank'  from Shipping where INVOICE like @Invoice + '%' and shipping_post = 1 and warehouse_Post is null and Check_ISO_Tank = 0 order by id desc")
                Else
                    cmd.CommandText = ("SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank'  from Shipping where INVOICE like @Invoice + '%' order by id desc")
                End If

                cmd.Parameters.AddWithValue("@Invoice", tbInvoice.Text)
            ElseIf tbInvoice.Text = "" And tbContainerNo.Text <> "" And tbShippingId.Text = "" Then

                If My.Settings.role_id = 5 Then
                    cmd.CommandText = ("SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank'  from Shipping where CONTAINER_NO like @Container_no + '%' and shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) order by id desc")
                ElseIf My.Settings.role_id = 3 Or My.Settings.role_id = 4 Then
                    cmd.CommandText = ("SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank'  from Shipping where CONTAINER_NO like @Container_no + '%' and shipping_post = 1 and warehouse_Post is null and Check_ISO_Tank = 0 order by id desc")
                Else
                    cmd.CommandText = ("SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank'  from Shipping where CONTAINER_NO like @Container_no + '%' order by id desc")
                End If

                cmd.Parameters.AddWithValue("@container_no", tbContainerNo.Text)
            ElseIf tbInvoice.Text = "" And tbContainerNo.Text = "" And tbShippingId.Text <> "" Then
                If My.Settings.role_id = 5 Then
                    cmd.CommandText = ("SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank'  from Shipping where id like @shipping_id + '%' and shipping_post = 1 and security_post is null and (warehouse_Post  = 1 or Check_ISO_Tank = 1) order by id desc")
                ElseIf My.Settings.role_id = 3 Or My.Settings.role_id = 4 Then
                    cmd.CommandText = ("SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank'  from Shipping where id like @shipping_id + '%' and shipping_post = 1 and warehouse_Post is null and Check_ISO_Tank = 0 order by id desc")
                Else
                    cmd.CommandText = ("SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User', Check_ISO_Tank as 'ISO Tank'  from Shipping where id like @shipping_id + '%' order by id desc")
                End If
                'cmd.CommandText = ("SELECT * from Shipping where INVOICE = '" + tbInvoice.Text + "' and CONTAINER_NO = '" + tbContainerNo.Text + "'")

                cmd.Parameters.AddWithValue("@shipping_id", tbShippingId.Text)
            End If
        End If
        Try
            rd = cmd.ExecuteReader

            If rd.HasRows Then
            Else

            End If
            con.Close()
            sda.Fill(dt)
            dgv.DataSource = dt
        Catch ex As System.InvalidOperationException
            MessageBox.Show(ex.Message, stringFilterError, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Try
        End Try



        tbContainerNo.Text = ""
        tbInvoice.Text = ""
        tbShippingId.Text = ""
    End Sub

    'Public Sub DataGridView1_Celldbclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
    '    'Dim con2 As New SqlConnection
    '    'Dim cmd2 As New SqlCommand
    '    'Dim rd2 As SqlDataReader
    '    'Dim selected As String
    '    'selected = dgv.CurrentCell.Value
    '    'con2.ConnectionString = My.Settings.connstr
    '    'cmd2.Connection = con2
    '    'con2.Open()

    '    'Try
    '    '    Select Case My.Settings.role_id
    '    '        Case 1
    '    '            Dim obj As New Edit
    '    '            Edit.TruckOutNumber = selected
    '    '            Edit.Show()
    '    '            Me.Close()
    '    '        Case 2
    '    '            If (My.Settings.adminCheck) Then
    '    '                cmd2.CommandText = "SELECT id from shipping join security on shipping.id = security.shipping_id where shipping_id = @shippingID and Check_ISO_Tank = 1 and Allow_To_Post is not null"
    '    '                cmd2.Parameters.AddWithValue("@shippingID", selected)
    '    '                rd2 = cmd2.ExecuteReader
    '    '                If (rd2.HasRows()) Then
    '    '                    Dim Security As New SecurityEdit
    '    '                    Security.TruckOutNumber = selected
    '    '                    Security.Show()
    '    '                    Me.Close()
    '    '                Else
    '    '                    Dim se As New ShippingEdit
    '    '                    se.TruckOutNumber = selected
    '    '                    se.Show()
    '    '                    Me.Close()
    '    '                End If
    '    '            Else
    '    '                Dim obj As New ShippingEdit
    '    '                obj.TruckOutNumber = selected
    '    '                obj.Show()
    '    '                Me.Close()
    '    '            End If

    '    '        Case 3, 4
    '    '            If (My.Settings.adminCheck) Then
    '    '                cmd2.CommandText = "SELECT Cargo_Weight_Check From Security where shipping_id = @shippingID and Allow_To_Post is not null"
    '    '                cmd2.Parameters.AddWithValue("@shippingID", selected)
    '    '                rd2 = cmd2.ExecuteReader
    '    '                If (rd2.HasRows()) Then
    '    '                    Dim editPage As New SecurityEdit
    '    '                    editPage.TruckOutNumber = selected
    '    '                    editPage.Show()
    '    '                    Me.Close()
    '    '                Else
    '    '                    Dim obj As New WarehouseEdit
    '    '                    obj.TruckOutNumber = selected
    '    '                    obj.Show()
    '    '                    Me.Close()
    '    '                End If

    '    '            Else
    '    '                Dim obj As New WarehouseEdit
    '    '                obj.TruckOutNumber = selected
    '    '                obj.Show()
    '    '                Me.Close()
    '    '            End If

    '    '        Case 5
    '    '            Dim obj As New SecurityEdit
    '    '            obj.TruckOutNumber = selected
    '    '            obj.Show()
    '    '            Me.Close()
    '    '    End Select
    '    'Catch ex As Exception
    '    '    MessageBox.Show(ex.Message, stringSearchError, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    'End Try
    'End Sub




End Class
