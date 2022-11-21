Imports System.Data.SqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ViewPage

    Dim ReportString As String = "report"
    Public Shared reportCheck As Boolean = "False"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUserDetails.Text = ("Welcome, " & My.Settings.fullName & vbNewLine & "Department of " & My.Settings.departmentName)
        lblCompanyNameHeader.Text = My.Settings.companyNameHeader
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
        Dim selectOptionNonAdmin As String
        Dim selectOptionAdmin As String
        Dim numOfReport As String
        Dim startDate, endDate As String
        startDate = dtpFrom.Value.ToString("yyyy-MM-dd")
        endDate = dtpTo.Value.ToString("yyyy-MM-dd")

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        If cmbPostSelect.Text = "" Then
            MessageBox.Show("Please Select The Post Option", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Select Case cmbPostSelect.Text
                Case "Shipping Post Completed"
                    postOption = "Shipping_POST_Time"
                    selectOptionNonAdmin = "SELECT ID, ORIGIN,INVOICE,CONTAINER_NO, ES_SEAL_NO,TEMPORARY_SEAL_NO, COMPANY,Container_Size,LOADING_PORT,SHIPPING_LINE,HAULIER,PRODUCT,DDB, SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,Shipping_Post_Time,Shipping_POST_User  from Shipping"
                    selectOptionAdmin = "SELECT ID, ORIGIN,INVOICE,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO, ES_SEAL_NO,TEMPORARY_SEAL_NO, COMPANY,Container_Size,LOADING_PORT,SHIPPING_LINE,HAULIER,PRODUCT,DDB, SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,Shipping_Post_Time,Shipping_POST_User from Shipping"
                Case "Warehouse Post Completed"
                    postOption = "Warehouse_Post_Time"
                    selectOptionNonAdmin = "SELECT ID, ORIGIN,INVOICE,CONTAINER_NO, ES_SEAL_NO,TEMPORARY_SEAL_NO, COMPANY,Container_Size,LOADING_PORT,SHIPPING_LINE,HAULIER,PRODUCT,DDB, SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,Warehouse_Post_Time,Warehouse_Post_User from Shipping"
                    selectOptionAdmin = "SELECT ID, ORIGIN,INVOICE,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO, ES_SEAL_NO,TEMPORARY_SEAL_NO, COMPANY,Container_Size,LOADING_PORT,SHIPPING_LINE,HAULIER,PRODUCT,DDB, SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,Warehouse_Post,Warehouse_Post_Time,Warehouse_Post_User  from Shipping"
                Case "Security Post Completed"
                    postOption = "Security_Post_Time"
                    selectOptionNonAdmin = "SELECT ID, ORIGIN,INVOICE,CONTAINER_NO, ES_SEAL_NO,TEMPORARY_SEAL_NO, COMPANY,Container_Size,LOADING_PORT,SHIPPING_LINE,HAULIER,PRODUCT,DDB, SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,Security_Post_Time,Security_Post_User  from Shipping"
                    selectOptionAdmin = "SELECT ID, ORIGIN,INVOICE,CONTAINER_NO,LINER_SEA_NO,INTERNAL_SEAL_NO, ES_SEAL_NO,TEMPORARY_SEAL_NO, COMPANY,Container_Size,LOADING_PORT,SHIPPING_LINE,HAULIER,PRODUCT,DDB, SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,Security_Post_Time,Security_Post_User  from Shipping"
            End Select

            If My.Settings.adminCheck = False Then
                cmd.CommandText = (selectOptionNonAdmin & " where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "') Order by id ")
            Else
                cmd.CommandText = (selectOptionAdmin & " where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "') Order by id ")
            End If
            rd = cmd.ExecuteReader

            con.Close()
            sda.Fill(dt)

            dgvView.DataSource = dt

            con.Open()
            cmd.CommandText = "SELECT COUNT(ID) as numOfReport from Shipping where " & postOption & " > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and " & postOption & " < dateadd(day,1,'" + dtpTo.Value.ToString("yyyy-MM-dd") + "')  "
            rd = cmd.ExecuteReader
            rd.Read()
            numOfReport = rd.Item("numOfReport")

            lblReport.Visible = True

            lblReport.Text = "There are " & numOfReport & " Completed Post Between " & startDate & " To " & endDate & ""
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
            MsgBox("Save file success")
        Else
            Return
        End If
        xlWorkBook.Close()
        xlapp.Quit()

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Admin As New Admin
        Dim User As New NormalUserPage

        Select Case My.Settings.adminCheck
            Case True
                Admin.Show()
                Me.Close()
            Case Else
                User.Show()
                Me.Close()

        End Select
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
            Case 2
                cmd2.CommandText = "SELECT ID from Shipping where SHIPPING_POST is NULL and ID = @shippingID"
            Case 3, 4
                cmd2.CommandText = "SELECT ID from Shipping where ID = @shippingID and (SHIPPING_POST = '" + "YES" + "' or WAREHOUSE_POST is NULL)"
            Case 5
                cmd2.CommandText = "SELECT ID from Shipping where Shipping_Post = '" + "YES" + "' and Warehouse_POST = '" + "YES" + "' and SECURITY_POST is NULL AND ID = @shippingID"
            Case 1, 20, 30
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
            MessageBox.Show("You have no privilege to view this number.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class