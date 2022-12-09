Imports System.Data.SqlClient


Public Class NewPage

    Dim checkTempSealNo As Boolean
    ReadOnly TimeNow As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private companyNameHeader As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFunction.topHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)
        lblTooNumber.Text = My.Settings.newTOONumber
        tbTemporarySealNo.Enabled = False
        cmbCheckTempSealNo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCheckTempSealNo.SelectedItem = "NO"
        cmbDDB.SelectedItem = "No"
        tbEsSealNo.Enabled = False
        tbLoadingBay.Enabled = False
        cmbWarehouseLocation.Enabled = False
        cmbEsSealNo.Enabled = False
        lblCompanyName.Text = ""
        lblLoadingPortFullName.Text = ""
        GlobalFunction.getCmbValue(cmbCompany, cmbLoadingPort, cmbWarehouseLocation, cmbContainerSize)
        GlobalFunction.getProductType(cmbProductType)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        'Post button
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
        ElseIf cmbDDB.Text = "" Then
            MessageBox.Show("Please Fill Out The DDB Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbProductType.Text = "" Then
            MessageBox.Show("Please Fill Out The PRODUCT TYPE Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cbISO.Checked Then
                If dtpISO.Text = "" Then
                    MessageBox.Show("Please Fill Out The Truck Out Date Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf tbISOTankWeightLower.Text = "" Then
                    MessageBox.Show("Please Fill Out The ISO Tank Weight Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cmd = New SqlCommand("INSERT INTO Shipping (ID,ORIGIN,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,INVOICE,PRODUCT,SHIPPING_LINE,Container_Size,HAULIER,LOADING_PORT,CONTAINER_NO,DDB,Product_Type,Check_ISO_Tank,ISO_Truck_Out_Date,ISO_Tank_Weight_Lower,ISO_Tank_Weight_Upper,Internal_Seal_No,Shipping_Post,Shipping_Post_User,Shipping_POST_Time) values (@TruckOutNumber ,'" + cmbCompany.Text + "','" + dtpSCD.Value.ToString("yyyy-MM-dd") + "','" + dtpSCT.Value.ToString("HH:mm:ss") + "','" + tbInvoice.Text + "','" + tbProduct.Text + "','" + tbShippingLine.Text + "','" + cmbContainerSize.Text + "','" + tbHaulier.Text + "','" + cmbLoadingPort.Text + "','" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "','" + cmbDDB.Text + "','" + cmbProductType.Text + "',@Check_ISO_Tank,@ISO_Truck_Out_Date,@ISO_Tank_Weight_Lower,@ISO_Tank_Weight_Upper, @Internal_Seal_No,1,'" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')", con)
                    ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
                    cmd.Parameters.AddWithValue("@TruckOutNumber", My.Settings.newTOONumber)
                    cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
                    cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Lower", tbISOTankWeightLower.Text)
                    cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Upper", tbISOTankWeightUpper.Text)
                    cmd.Parameters.AddWithValue("@Internal_Seal_No", tbInternalSealNo.Text)
                End If
            Else
                If tbInternalSealNo.Text = "" Then
                    MessageBox.Show("Please Fill Out The INTERNAL SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cmbCheckTempSealNo.Text = "" Then
                    MessageBox.Show("Please Fill Out The TEMPORARY SEAL NO Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf cmbCheckTempSealNo.Text = "YES" And tbContainerNo.Text = "" Then
                    MessageBox.Show("Please Fill Out The Temorary Seal No Field", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf tbLinerSealNo.Text = "" Then
                    MessageBox.Show("Please Fill Out The Liner Seal No Field..", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cmd = New SqlCommand("INSERT INTO Shipping (ID,ORIGIN,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,INVOICE,PRODUCT,SHIPPING_LINE,Container_Size,HAULIER,LOADING_PORT,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO,TEMPORARY_SEAL_NO,Shipping_Post,Shipping_Post_User,Shipping_POST_Time,DDB,checkTempSealNo,Product_Type,Net_Cargo_Weight,Check_ISO_Tank) values (@TruckOutNumber ,'" + cmbCompany.Text + "','" + dtpSCD.Value.ToString("yyyy-MM-dd") + "','" + dtpSCT.Value.ToString("HH:mm:ss") + "','" + tbInvoice.Text + "','" + tbProduct.Text + "','" + tbShippingLine.Text + "','" + cmbContainerSize.Text + "','" + tbHaulier.Text + "','" + cmbLoadingPort.Text + "','" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "','" + GlobalFunction.TrimSpace(tbLinerSealNo.Text) + "','" + GlobalFunction.TrimSpace(tbInternalSealNo.Text) + "','" + GlobalFunction.TrimSpace(tbTemporarySealNo.Text) + "',1,'" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbDDB.Text + "', @checkTempSealNo,'" + cmbProductType.Text + "','" + tbCargo.Text + "',@Check_ISO_Tank)", con)
                    ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
                    cmd.Parameters.AddWithValue("@TruckOutNumber", My.Settings.newTOONumber)
                    cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)
                    cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
                End If
            End If

            ra = cmd.ExecuteNonQuery
            'btnCancel.PerformClick()
            GlobalFunction.backToPageAdminCheck(Admin, NormalUserPage, Me)
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
                lblCompanyName.Text = ""
            Else
                lblCompanyName.Text = rd.Item("full_name")
            End If

        End While


        lblCompanyName.Visible = True
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


    Private Sub Button_Save(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim ra As Integer
        Dim con3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()


        If cbISO.Checked Then
            cmd = New SqlCommand("INSERT INTO Shipping (ID,ORIGIN,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,INVOICE,PRODUCT,SHIPPING_LINE,Container_Size,HAULIER,LOADING_PORT,CONTAINER_NO,DDB, Last_Modified_User,Update_Time,Product_Type,Check_ISO_Tank,ISO_Truck_Out_Date,ISO_Tank_Weight_Lower,ISO_Tank_Weight_Upper,Internal_Seal_No) values (@TruckOutNumber ,'" + cmbCompany.Text + "','" + dtpSCD.Value.ToString("yyyy-MM-dd") + "','" + dtpSCT.Value.ToString("HH:mm:ss") + "','" + tbInvoice.Text + "','" + tbProduct.Text + "','" + tbShippingLine.Text + "','" + cmbContainerSize.Text + "','" + tbHaulier.Text + "','" + cmbLoadingPort.Text + "','" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "','" + cmbDDB.Text + "','" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbProductType.Text + "',@Check_ISO_Tank,@ISO_Truck_Out_Date,@ISO_Tank_Weight_Lower,@ISO_Tank_Weight_Upper,@Internal_Seal_No)", con)
            ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
            cmd.Parameters.AddWithValue("@TruckOutNumber", My.Settings.newTOONumber)
            cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
            cmd.Parameters.AddWithValue("@ISO_Truck_Out_Date", dtpISO.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Lower", tbISOTankWeightLower.Text)
            cmd.Parameters.AddWithValue("@ISO_Tank_Weight_Upper", tbISOTankWeightUpper.Text)
            cmd.Parameters.AddWithValue("@Internal_Seal_No", tbInternalSealNo.Text)
        Else
            cmd = New SqlCommand("INSERT INTO Shipping (ID,ORIGIN,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,INVOICE,PRODUCT,SHIPPING_LINE,Container_Size,HAULIER,LOADING_PORT,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO,TEMPORARY_SEAL_NO,DDB,checkTempSealNo, Last_Modified_User,Update_Time,Product_Type,Net_Cargo_Weight, Check_ISO_Tank) values (@TruckOutNumber ,'" + cmbCompany.Text + "','" + dtpSCD.Value.ToString("yyyy-MM-dd") + "','" + dtpSCT.Value.ToString("HH:mm:ss") + "','" + tbInvoice.Text + "','" + tbProduct.Text + "','" + tbShippingLine.Text + "','" + cmbContainerSize.Text + "','" + tbHaulier.Text + "','" + cmbLoadingPort.Text + "','" + GlobalFunction.TrimSpace(tbContainerNo.Text) + "','" + GlobalFunction.TrimSpace(tbLinerSealNo.Text) + "','" + GlobalFunction.TrimSpace(tbInternalSealNo.Text) + "','" + GlobalFunction.TrimSpace(tbTemporarySealNo.Text) + "','" + cmbDDB.Text + "', @checkTempSealNo,'" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbProductType.Text + "','" + tbCargo.Text + "', @Check_ISO_Tank)", con)
            ''" + My.Settings.username + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',
            cmd.Parameters.AddWithValue("@TruckOutNumber", My.Settings.newTOONumber)
            cmd.Parameters.AddWithValue("@checkTempSealNo", checkTempSealNo)
            cmd.Parameters.AddWithValue("@Check_ISO_Tank", cbISO.Checked)
        End If
        Try
            ra = cmd.ExecuteNonQuery
            GlobalFunction.backToPageAdminCheck(Admin, NormalUserPage, Me)
            MessageBox.Show("Save Complete as " + My.Settings.newTOONumber.ToString, "Complete ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Please Only Enter Integer In Net Cargo Weight", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'btnCancel.PerformClick()

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Close application") = Windows.Forms.DialogResult.Yes Then
            GlobalFunction.backToPageAdminCheck(Admin, NormalUserPage, Me)
        End If
    End Sub

    Private Sub cbISO_CheckedChanged(sender As Object, e As EventArgs) Handles cbISO.CheckedChanged
        If cbISO.Checked Then
            tlpISO.Enabled = True
            cmbEsSealNo.Enabled = False
            cmbCheckTempSealNo.Enabled = False
            tbTemporarySealNo.Enabled = False
            tbLinerSealNo.Enabled = False
            tbEsSealNo.Enabled = False
            tbCargo.Enabled = False
            cmbEsSealNo.Text = ""
            cmbCheckTempSealNo.Text = ""
            tbTemporarySealNo.Text = ""
            tbLinerSealNo.Text = ""
            tbEsSealNo.Text = ""
            tbCargo.Text = ""
        Else
            tlpISO.Enabled = False
            cmbCheckTempSealNo.Enabled = True
            tbLinerSealNo.Enabled = True
            tbCargo.Enabled = True
        End If
    End Sub


End Class