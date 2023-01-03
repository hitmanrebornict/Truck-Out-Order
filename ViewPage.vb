Imports System.Data.SqlClient
Imports System.Runtime.Serialization.Formatters
Imports System.Security.Permissions
Imports Truck_Out_Order.My.Resources
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ViewPage

    Dim ReportString As String = "report"
    Public Shared reportCheck As Boolean = "False"
    Public Shared reportSelected As String
    Private companyNameHeader As String
    Private stringPleaseSelect,
            stringSearchError,
            stringNetCargoBetween,
            stringCompletedPostBetween,
            stringSuccess,
            stringPrivilege,
            stringThereAre,
            selectString,
            selectStringNormal As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (My.Settings.languageSetting = "fr") Then
            btnSearch.Text = ResourceViewPageFrench.btnSearch
            btnExport.Text = ResourceViewPageFrench.btnExport
            btnCancel.Text = ResourceViewPageFrench.btnCancel
            cmbPostSelect.Items.Add(ResourceViewPageFrench.itemShipping)
            cmbPostSelect.Items.Add(ResourceViewPageFrench.itemWarehouse)
            cmbPostSelect.Items.Add(ResourceViewPageFrench.itemSecurity)
            cmbPostSelect.Items.Add(ResourceViewPageFrench.itemCargo)
            cmbPostSelect.Items.Add(ResourceViewPageFrench.itemISO)
            stringPleaseSelect = ResourceViewPageFrench.stringPleaseSelect
            stringSearchError = ResourceViewPageFrench.stringSearchError
            stringNetCargoBetween = ResourceViewPageFrench.stringNetCargoBetween
            stringCompletedPostBetween = ResourceViewPageFrench.stringCompletedPostBetween
            stringSuccess = ResourceViewPageFrench.stringSuccess
            stringPrivilege = ResourceViewPageFrench.stringPrivilege
            stringThereAre = ResourceViewPageFrench.stringThereAre
            selectString = ResourceViewPageFrench.stringSelectString
            selectStringNormal = ResourceViewPageFrench.stringSelectStringNormal

        Else
            btnSearch.Text = ResourceViewPage.btnSearch
            btnExport.Text = ResourceViewPage.btnExport
            btnCancel.Text = ResourceViewPage.btnCancel
            cmbPostSelect.Items.Add(ResourceViewPage.itemShipping)
            cmbPostSelect.Items.Add(ResourceViewPage.itemWarehouse)
            cmbPostSelect.Items.Add(ResourceViewPage.itemSecurity)
            cmbPostSelect.Items.Add(ResourceViewPage.itemCargo)
            cmbPostSelect.Items.Add(ResourceViewPage.itemISO)
            stringPleaseSelect = ResourceViewPage.stringPleaseSelect
            stringSearchError = ResourceViewPage.stringSearchError
            stringNetCargoBetween = ResourceViewPage.stringNetCargoBetween
            stringCompletedPostBetween = ResourceViewPage.stringCompletedPostBetween
            stringSuccess = ResourceViewPage.stringSuccess
            stringPrivilege = ResourceViewPage.stringPrivilege
            stringThereAre = ResourceViewPage.stringThereAre
            selectString = ResourceViewPage.stringSelectString
            selectStringNormal = ResourceViewPage.stringSelectStringNormal
        End If
        GlobalFunction.TopHeader(lblUserDetails, lblCompanyNameHeader, companyNameHeader)

        lblReport.Visible = False
        dgvView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        'Dim con2 As New SqlConnection
        'Dim cmd2 As New SqlCommand
        'Dim rd2 As SqlDataReader
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        Dim postOption As String
        Dim selectOption As String

        Dim numOfReport As String
        Dim startDate, endDate As String
        startDate = dtpFrom.Value.ToString("yyyy-MM-dd")
        endDate = dtpTo.Value.ToString("yyyy-MM-dd")

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If cmbPostSelect.Text = "" Then
            MessageBox.Show(stringPleaseSelect, stringSearchError, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Select Case cmbPostSelect.SelectedIndex
                Case 0
                    postOption = "Shipping_POST_Time"
                    selectOption = selectStringNormal & " Shipping_POST_User as 'Shipping Post User',Shipping_Post_Time as 'Shipping Post Time',Last_Modified_User as 'Last Modified User', Shipping.Update_Time as 'Last Modified Time' from Shipping left join warehouse on shipping.id = warehouse.shipping_id"
                    cmd.CommandText = (selectOption & " where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "') Order by id ")
                Case 1
                    postOption = "Warehouse_Post_Time"
                    selectOption = selectStringNormal & " Warehouse_Post_User as 'Warehouse Post User',Warehouse_Post_Time as 'Warehouse Post Time', warehouse.Update_User as 'Last Modified User', warehouse.Update_Time as 'Last Modified Time' from Shipping join warehouse on shipping.id = warehouse.shipping_id"
                    cmd.CommandText = (selectOption & " where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "') Order by id ")
                Case 2
                    postOption = "Security_Post_Time"
                    selectOption = selectStringNormal & " Security_Post_User as 'Security Post User',Security_Post_Time as 'Security Post Time' from Shipping left join warehouse on shipping.id = warehouse.shipping_id inner join security on shipping.id = security.shipping_id "
                    cmd.CommandText = (selectOption & " where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "') Order by id ")
                Case 3
                    postOption = "Security_Post_Time"
                    selectOption = selectString & "Security_Post_Time as 'Security Post Time',Security_Post_User as 'Security Post User' from Shipping  join Security  on Shipping.ID = Security.Shipping_ID join warehouse on shipping.ID = warehouse.shipping_ID"
                    cmd.CommandText = (selectOption & " where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "') and shipping.Net_Cargo_Weight is not null  Order by security.cargo_weight_check,shipping.container_size, id")
                Case 4
                    postOption = "Security_Post_Time"
                    selectOption = selectStringNormal & " Security_Post_User as 'Security Post User',Security_Post_Time as 'Security Post Time' from Shipping left join warehouse on shipping.id = warehouse.shipping_id join security on shipping.id = security.shipping_id "
                    cmd.CommandText = (selectOption & " where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "') and Shipping.Check_ISO_Tank = 1 Order by id ")
            End Select



            rd = cmd.ExecuteReader

            con.Close()
            sda.Fill(dt)

            dgvView.DataSource = dt

            con.Open()
            Dim postString As String
            Select Case cmbPostSelect.Text
                Case 3
                    postString = " " & stringNetCargoBetween & " "
                    cmd.CommandText = "SELECT COUNT(ID) as numofReport from shipping inner join security on shipping.id = security.shipping_id where  " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "')  and Cargo_Weight_Check_Value is not null"
                Case 4
                    postString = " " & stringCompletedPostBetween & " "
                    cmd.CommandText = "Select COUNT(ID) As numOfReport from Shipping where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "') and Check_ISO_Tank = 1 "
                Case Else
                    postString = " " & stringCompletedPostBetween & " "
                    cmd.CommandText = "SELECT COUNT(ID) as numOfReport from Shipping where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "')  "
            End Select
            rd = cmd.ExecuteReader
            rd.Read()
            numOfReport = rd.Item("numOfReport")
            lblReport.Visible = True

            lblReport.Text = stringThereAre & " " & numOfReport & postString & startDate & " - " & endDate & ""
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Dim xlapp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlapp = New Excel.Application
        xlWorkBook = xlapp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Sheets("Sheet1"), Excel.Worksheet)

        For k = 0 To dgvView.ColumnCount - 1
            xlWorkSheet.Cells(1, k + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Cells(1, k + 1) = dgvView.Columns(k).Name
        Next
        For i = 0 To dgvView.RowCount - 1
            For j = 0 To dgvView.ColumnCount - 1
                xlWorkSheet.Cells(i + 2, j + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                xlWorkSheet.Cells(i + 2, j + 1) =
                    dgvView(j, i).Value.ToString()
            Next
        Next

        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "Execl files (*.xlsx)|*.xlsx"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
            MsgBox(stringSuccess)
        Else
            Return
        End If
        xlWorkBook.Close()
        xlapp.Quit()

    End Sub


    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        GlobalFunction.backToPageAdminCheck(Admin, NormalUserPage, Me)
    End Sub


    Private Sub DataGridView1_Celldbclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvView.CellDoubleClick
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim rd2 As SqlDataReader
        Dim selected As String

        reportCheck = True
        selected = dgvView.CurrentCell.Value
        con2.ConnectionString = My.Settings.connstr
        cmd2.Connection = con2
        con2.Open()

        Select Case My.Settings.role_id
            'Case 2
            '    cmd2.CommandText = "SELECT ID from Shipping where SHIPPING_POST is NULL and ID = @shippingID"
            'Case 3, 4
            '    cmd2.CommandText = "SELECT ID from Shipping where ID = @shippingID and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL)"
            'Case 5
            '    cmd2.CommandText = "SELECT ID from Shipping where Shipping_Post = '" + "YES" + "' and Warehouse_POST = '" + "NO" + "'  AND ID = @shippingID"
            Case Else
                cmd2.CommandText = "SELECT ID from Shipping where ID = @shippingID"
        End Select
        cmd2.Parameters.AddWithValue("@shippingID", selected)
        rd2 = cmd2.ExecuteReader

        If rd2.HasRows Then
            Dim obj As New Edit
            obj.TruckOutNumber = selected
            obj.Show()
            Me.Close()

        Else
            MessageBox.Show(stringPrivilege, stringSearchError, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Search.selected = selected
    End Sub
End Class