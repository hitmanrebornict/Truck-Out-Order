Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
Imports Microsoft.Vbe.Interop

Public Class Search

    Public Shared selected As String
    Private companyNameHeader As String
    Private checkCargoWeight As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFunction.topHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dim selectString As String = "SELECT ID as 'Truck Out Number',ORIGIN as 'Company',INVOICE as 'Invoice',CONTAINER_NO as 'Container No',COMPANY as 'Send To Company',Container_Size as 'Container Size',LOADING_PORT as 'Loading Port',HAULIER as 'Haulier',PRODUCT as 'Product',SHIPMENT_CLOSING_DATE as 'Shipment Closing Date',SHIPMENT_CLOSING_TIME as 'Shipment Closing Time',DDB, Last_Modified_User as 'Last Modified User',Reversion as 'Reversion' ,Update_Time as 'Update Time',Shipping_POST as 'Shipping Post',SHIPPING_POST_TIME as 'Shipping Post Time' ,Shipping_POST_User as 'Shipping Post User',Warehouse_Post as 'Warehouse Post',Warehouse_Post_Time as 'Warehouse Post Time',Warehouse_Post_User as 'Warehouse Post User',Security_Post as 'Security Post',Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User' from Shipping"
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
                Case 3, 4
                    If (My.Settings.adminCheck) Then
                        cmd.CommandText = selectString & " WHERE SHIPPING_POST = '" + "YES" + "' and Security_Post is null order by id desc"
                    Else
                        cmd.CommandText = (selectString & " where shipping_post = '" + "YES" + "' and warehouse_Post is null order by id desc")
                    End If
                Case 5
                    cmd.CommandText = (selectString & " where shipping_post = '" + "YES" + "' and warehouse_Post  = '" + "YES" + "' and security_post is null order by id desc")
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
        Dim fieldValue As String
        con2.ConnectionString = My.Settings.connstr
        cmd2.Connection = con2
        con2.Open()
        con3.ConnectionString = My.Settings.connstr
        cmd3.Connection = con3
        con3.Open()

        If tbShippingId.Text = "" And tbInvoice.Text = "" And tbContainerNo.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If tbShippingId.Text <> "" And tbInvoice.Text = "" And tbContainerNo.Text = "" Then
                Select Case My.Settings.role_id
                    Case 2
                        cmd2.CommandText = "Select COUNT(ID) as COUNTID from Shipping where ID = '" + tbShippingId.Text + "'"
                        cmd3.CommandText = selectString & " where ID = '" + tbShippingId.Text + "'"
                    Case 3, 4
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where ID = '" + tbShippingId.Text + "'and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL)"
                        cmd3.CommandText = selectString & " where ID = '" + tbShippingId.Text + "'and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL)"
                    Case 5
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where Shipping_Post = '" + "YES" + "' and Warehouse_POST = '" + "YES" + "' and SECURITY_POST is NULL and ID = '" + tbShippingId.Text + "'"
                        cmd3.CommandText = selectString & " where Shipping_Post = '" + "YES" + "' and Warehouse_POST = '" + "YES" + "' and SECURITY_POST is NULL and ID = '" + tbShippingId.Text + "'"
                    Case 1
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where ID = '" + tbShippingId.Text + "'"
                        cmd3.CommandText = selectString & " where ID = '" + tbShippingId.Text + "'"
                End Select

            ElseIf tbShippingId.Text = "" And tbInvoice.Text <> "" And tbContainerNo.Text = "" Then
                Select Case My.Settings.role_id
                    Case 2
                        cmd2.CommandText = "Select COUNT(ID) as COUNTID from Shipping where  INVOICE = '" + tbInvoice.Text + "'"
                        cmd3.CommandText = selectString & " where INVOICE = '" + tbInvoice.Text + "'"
                    Case 3, 4
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where INVOICE = '" + tbInvoice.Text + "'and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL)"
                        cmd3.CommandText = selectString & " where INVOICE = '" + tbInvoice.Text + "'and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL)"
                    Case 5
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where Shipping_Post = '" + "YES" + "' and Warehouse_POST = '" + "YES" + "' and SECURITY_POST is NULL and INVOICE = '" + tbInvoice.Text + "'"
                        cmd3.CommandText = selectString & " where Shipping_Post = '" + "YES" + "' and Warehouse_POST = '" + "YES" + "' and SECURITY_POST is NULL and INVOICE = '" + tbInvoice.Text + "'"
                    Case 1
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where INVOICE = '" + tbInvoice.Text + "'"
                        cmd3.CommandText = selectString & " where INVOICE = '" + tbInvoice.Text + "'"
                End Select
            ElseIf tbShippingId.Text = "" And tbInvoice.Text = "" And tbContainerNo.Text <> "" Then
                Select Case My.Settings.role_id
                    Case 2
                        cmd2.CommandText = "Select COUNT(ID) as COUNTID from Shipping WHERE CONTAINER_NO = '" + tbContainerNo.Text + "'"
                        cmd3.CommandText = selectString & " where CONTAINER_NO = '" + tbContainerNo.Text + "'"
                    Case 3, 4
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where CONTAINER_NO = '" + tbContainerNo.Text + "'and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL)"
                        cmd3.CommandText = selectString & " where CONTAINER_NO = '" + tbContainerNo.Text + "'and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL)"
                    Case 5
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where Shipping_Post = '" + "YES" + "' and Warehouse_POST = '" + "YES" + "' and SECURITY_POST is NULL and CONTAINER_NO = '" + tbContainerNo.Text + "'"
                        cmd3.CommandText = selectString & " where Shipping_Post = '" + "YES" + "' and Warehouse_POST = '" + "YES" + "' and SECURITY_POST is NULL and CONTAINER_NO = '" + tbContainerNo.Text + "'"
                    Case 1
                        cmd2.CommandText = "SELECT COUNT(ID) as COUNTID from Shipping where CONTAINER_NO = '" + tbContainerNo.Text + "'"
                        cmd3.CommandText = selectString & " where CONTAINER_NO = '" + tbContainerNo.Text + "'"
                End Select
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

            Catch ex As InvalidOperationException
                MessageBox.Show("1) Data Not Found!" & vbNewLine & "2) Please only fill one textbox!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Please complete the required fields..", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If tbInvoice.Text <> "" And tbContainerNo.Text = "" And tbShippingId.Text = "" Then
                cmd.CommandText = ("SELECT * from Shipping where INVOICE like '" + tbInvoice.Text + "%' order by id desc")
            ElseIf tbInvoice.Text = "" And tbContainerNo.Text <> "" And tbShippingId.Text = "" Then
                cmd.CommandText = ("SELECT * from Shipping where CONTAINER_NO like '" + tbContainerNo.Text + "%' order by id desc")
            ElseIf tbInvoice.Text = "" And tbContainerNo.Text = "" And tbShippingId.Text <> "" Then
                'cmd.CommandText = ("SELECT * from Shipping where INVOICE = '" + tbInvoice.Text + "' and CONTAINER_NO = '" + tbContainerNo.Text + "'")
                cmd.CommandText = ("SELECT * from Shipping where id like '" + tbShippingId.Text + "%' order by id desc")
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
            MessageBox.Show("Please only fill one textbox", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Try
        End Try



        tbContainerNo.Text = ""
        tbInvoice.Text = ""
        tbShippingId.Text = ""
    End Sub

    Public Sub DataGridView1_Celldbclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim rd2 As SqlDataReader
        Dim selected As String
        selected = dgv.CurrentCell.Value
        con2.ConnectionString = My.Settings.connstr
        cmd2.Connection = con2
        con2.Open()

        'If My.Settings.adminCheck = True Or My.Settings.role_id = 2 Then
        '    cmd2.CommandText = "SELECT ID from Shipping where ID = @shippingID "
        'Else
        '    Select Case My.Settings.role_id
        '        Case 3, 4
        '            If (My.Settings.adminCheck) Then
        '                cmd2.CommandText = "SELECT ID from Shipping where ID = @shippingID and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL or Security_Post is null)"
        '            Else
        '                cmd2.CommandText = "SELECT ID from Shipping where ID = @shippingID and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL)"
        '            End If

        '        Case 5
        '            cmd2.CommandText = "SELECT ID from Shipping where Shipping_Post = '" + "YES" + "' and Warehouse_POST = '" + "YES" + "' and SECURITY_POST is NULL AND ID = @shippingID"
        '    End Select
        'End If

        'cmd2.Parameters.AddWithValue("@shippingID", selected)
        'rd2 = cmd2.ExecuteReader
        'If rd2.HasRows Then
        Try
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
                    If (My.Settings.adminCheck) Then
                        cmd2.CommandText = "SELECT Cargo_Weight_Check From Security where shipping_id = @shippingID and Allow_To_Post is not null"
                        cmd2.Parameters.AddWithValue("@shippingID", selected)
                        rd2 = cmd2.ExecuteReader
                        If (rd2.HasRows()) Then
                            Dim editPage As New Edit
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
            MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Buttona_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Obj As New Edit
        Obj.Show()
        Me.Close()
    End Sub


End Class
