Imports System.Data.SqlClient


Public Class NewPage
    Dim surface As Graphics = CreateGraphics()
    Dim pen1 As Pen = New Pen(Color.Black, 2)


    Public checkTempSealNo As Boolean
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & My.Settings.fullName & vbNewLine & "Department of " & My.Settings.departmentName)
        lblCompanyNameHeader.Text = My.Settings.companyNameHeader
        lblTooNumber.Text = My.Settings.newTOONumber
        tbTemporarySealNo.Enabled = False
        cmbCheckTempSealNo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCheckTempSealNo.SelectedItem = "NO"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmbDDB.SelectedItem = "No"

        tbEsSealNo.Enabled = False
            tbLoadingBay.Enabled = False
            cmbWarehouseLocation.Enabled = False
            cmbEsSealNo.Enabled = False


        'Read Data Into Company Combobox
        cmd.CommandText = "SELECT distinct(company_name) as r from details where company_name is not null and validationCheck = 'YES'  order by company_name"
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
        cmd.CommandText = "SELECT distinct(Container_Size) as r from details where Container_Size is not null and validationCheck = 'YES'  order by container_size"
        rd = cmd.ExecuteReader
        While rd.Read()
            cmbContainerSize.Items.Add(rd.Item("r"))
        End While
        con.Close()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    '    'Cancel Button
    '    'Dim Admin As New Admin
    '    'Dim User As New NormalUserPage

    '    'Select Case My.Settings.adminCheck
    '    '    Case True
    '    '        Admin.Show()
    '    '        Me.Close()
    '    '    Case False
    '    '        User.Show()
    '    '        Me.Close()
    '    'End Select
    '    Me.Close()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPost.Click
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
        Dim check As String

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
        ElseIf cmbCheckTempSealNo.Text = "" Then
            MessageBox.Show("Please Fill Out The TEMPORARY SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' ElseIf ComboBox3.Text = "" Then
            '     MessageBox.Show("Please Fill Out The ES_SEAL_NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbDDB.Text = "" Then
            MessageBox.Show("Please Fill Out The DDB Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'If cmbSaveAndPost.SelectedItem = "Save" Then

            '    cmd = New SqlCommand("INSERT INTO Shipping (ID,ORIGIN,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,INVOICE,PRODUCT,SHIPPING_LINE,Container_Size,HAULIER,LOADING_PORT,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO,TEMPORARY_SEAL_NO,Update_User,Update_Time,DDB) values ( @TruckOutNumber ,'" + cmbCompany.Text + "','" + dtpSCD.Value.ToString("yyyy-MM-dd") + "','" + dtpSCT.Value.ToString("HH:mm:ss") + "','" + tbInvoice.Text + "','" + tbProduct.Text + "','" + tbShippingLine.Text + "','" + cmbContainerSize.Text + "','" + tbHaulier.Text + "','" + cmbLoadingPort.Text + "','" + tbContainerNo.Text + "','" + tbLinerSealNo.Text + "','" + tbInternalSealNo.Text + "','" + tbTemporarySealNo.Text + "','" + Me.Username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbDDB.Text + "')", con)
            '    cmd.Parameters.AddWithValue("@TruckOutNumber", Me.TruckOutNumber)
            '    ra = cmd.ExecuteNonQuery
            '    btnCancel.PerformClick()
            '    MessageBox.Show("Save Complete as " + Me.TruckOutNumber.ToString, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else

            cmd = New SqlCommand("INSERT INTO Shipping (ID,ORIGIN,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,INVOICE,PRODUCT,SHIPPING_LINE,Container_Size,HAULIER,LOADING_PORT,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO,TEMPORARY_SEAL_NO,Shipping_Post,Shipping_Post_User,Shipping_POST_Time,DDB,checkTempSealNo, Last_Modified_User,Update_Time) values (@TruckOutNumber ,'" + cmbCompany.Text + "','" + dtpSCD.Value.ToString("yyyy-MM-dd") + "','" + dtpSCT.Value.ToString("HH:mm:ss") + "','" + tbInvoice.Text + "','" + tbProduct.Text + "','" + tbShippingLine.Text + "','" + cmbContainerSize.Text + "','" + tbHaulier.Text + "','" + cmbLoadingPort.Text + "','" + tbContainerNo.Text + "','" + tbLinerSealNo.Text + "','" + tbInternalSealNo.Text + "','" + tbTemporarySealNo.Text + "','" + "YES" + "','" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbDDB.Text + "', @checkTempSealNo,'" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')", con)
            ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
            cmd.Parameters.AddWithValue("@TruckOutNumber", My.Settings.newTOONumber)
            cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
            ra = cmd.ExecuteNonQuery
            'btnCancel.PerformClick()
            meClose()
            MessageBox.Show("Post Complete as " + My.Settings.newTOONumber.ToString, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        End If
        con.Close()

    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompany.SelectedIndexChanged
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

    Private Sub cmbLoadingPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoadingPort.SelectedIndexChanged
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCheckTempSealNo.SelectedIndexChanged
        If cmbCheckTempSealNo.Text = "NO" Then
            tbTemporarySealNo.Enabled = False
            checkTempSealNo = False
            tbTemporarySealNo.Text = ""
        Else
            tbTemporarySealNo.Enabled = True
            checkTempSealNo = True
        End If
    End Sub

    'Private Sub cmbEsSealNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEsSealNo.SelectedIndexChanged
    '    If cmbEsSealNo.SelectedItem = "NO" Then
    '        tbEsSealNo.Enabled = False
    '        tbEsSealNo.Text = ""
    '    Else
    '        tbEsSealNo.Enabled = True
    '    End If
    'End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim ra As Integer
        Dim con3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        cmd = New SqlCommand("INSERT INTO Shipping (ID,ORIGIN,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,INVOICE,PRODUCT,SHIPPING_LINE,Container_Size,HAULIER,LOADING_PORT,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO,TEMPORARY_SEAL_NO,DDB,checkTempSealNo, Last_Modified_User,Update_Time) values (@TruckOutNumber ,'" + cmbCompany.Text + "','" + dtpSCD.Value.ToString("yyyy-MM-dd") + "','" + dtpSCT.Value.ToString("HH:mm:ss") + "','" + tbInvoice.Text + "','" + tbProduct.Text + "','" + tbShippingLine.Text + "','" + cmbContainerSize.Text + "','" + tbHaulier.Text + "','" + cmbLoadingPort.Text + "','" + tbContainerNo.Text + "','" + tbLinerSealNo.Text + "','" + tbInternalSealNo.Text + "','" + tbTemporarySealNo.Text + "','" + cmbDDB.Text + "', @checkTempSealNo,'" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')", con)
        ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
        cmd.Parameters.AddWithValue("@TruckOutNumber", My.Settings.newTOONumber)
        cmd.Parameters.AddWithValue("checkTempSealNo", Me.checkTempSealNo)
        ra = cmd.ExecuteNonQuery
        'btnCancel.PerformClick()
        meClose()
        MessageBox.Show("Save Complete as " + My.Settings.newTOONumber.ToString, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Close application") = Windows.Forms.DialogResult.Yes Then
            Dim Admin As New Admin
            Dim User As New NormalUserPage

            Select Case My.Settings.adminCheck
                Case True
                    Admin.Show()
                Case False
                    User.Show()
            End Select
            Me.Close()
        End If
    End Sub

    Function meClose()
        Dim Admin As New Admin
        Dim User As New NormalUserPage

        Select Case My.Settings.adminCheck
            Case True
                Admin.Show()
            Case False
                User.Show()
        End Select
        Me.Close()
    End Function

End Class