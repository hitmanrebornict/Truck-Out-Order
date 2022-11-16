Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ViewPage
    Public username As String
    Public role_id As String
    Public departmentName As String
    Public adminCheck As Boolean
    Public companyNameHeader As String
    Dim ReportString As String = "report"
    Public fullName As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & fullName & vbNewLine & "Department of " & departmentName)
        lblCompanyNameHeader.Text = companyNameHeader
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

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        'cmd.CommandText = ("select * from shipping")
        If role_id = 5 Or role_id = 4 Or role_id = 3 Or role_id = 30 Then
            cmd.CommandText = ("SELECT ID, ORIGIN,INVOICE,CONTAINER_NO,COMPANY,Container_Size,LOADING_PORT,HAULIER,PRODUCT,SHIPMENT_CLOSING_DATE,SHIPMENT_CLOSING_TIME,Update_User,Reversion,Update_Time,Shipping_POST,SHIPMENT_CLOSING_TIME,Shipping_POST_User,Warehouse_Post,Warehouse_Post_Time,Warehouse_Post_User,Security_Post,Security_Post_Time,Security_Post_User,DDB  from Shipping where shipping_post_time > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and shipping_post_time < '" + dtpTo.Value.ToString("yyyy-MM-dd") + "' ")
        Else
            cmd.CommandText = ("SELECT * from Shipping where shipping_post_time > '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' and shipping_post_time < '" + dtpTo.Value.ToString("yyyy-MM-dd") + "' ")
        End If


        rd = cmd.ExecuteReader

        con.Close()
        sda.Fill(dt)

        dgvView.DataSource = dt
        dgvView.Columns(4).Visible = False
        dgvView.Columns(5).Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For i = 0 To dgvView.RowCount - 2
            For j = 0 To dgvView.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) =
                    dgvView(j, i).Value.ToString()
            Next
        Next

        Try
            xlWorkSheet.SaveAs("C:\Users\it_intern01\Desktop\" & ReportString & ".xlsx")

        Catch ex As Runtime.InteropServices.COMException
            xlApp.Quit()

        Finally
            MsgBox("You can find the file called Report.xlsx at Desktop")
        End Try



        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        Try
            xlWorkBook.Close()
        Catch ex As Runtime.InteropServices.InvalidComObjectException

        End Try

        Me.Show()

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub DATAGRIDVIEW_TO_EXCEL(ByVal DGV As DataGridView)
        Try
            Dim DTB = New DataTable, RWS As Integer, CLS As Integer

            For CLS = 0 To DGV.ColumnCount - 1 ' COLUMNS OF DTB
                DTB.Columns.Add(DGV.Columns(CLS).Name.ToString)
            Next

            Dim DRW As DataRow

            For RWS = 0 To DGV.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                DRW = DTB.NewRow

                For CLS = 0 To DGV.ColumnCount - 1
                    Try
                        DRW(DTB.Columns(CLS).ColumnName.ToString) = DGV.Rows(RWS).Cells(CLS).Value.ToString
                    Catch ex As Exception

                    End Try
                Next

                DTB.Rows.Add(DRW)
            Next

            DTB.AcceptChanges()

            Dim DST As New DataSet
            DST.Tables.Add(DTB)
            Dim FLE As String = "D:\TruckOutOrder.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
            DTB.WriteXml(FLE)
            Dim EXL As String = "C:\Program Files (x86)\Microsoft Office\Office14\EXCEL.EXE" ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
            Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Admin As New Admin
        Dim User As New NormalUserPage

        Select Case adminCheck
            Case True
                Admin.username = Me.username
                Admin.role_id = Me.role_id
                Admin.departmentName = Me.departmentName
                Admin.adminCheck = Me.adminCheck
                Admin.fullName = Me.fullName
                Admin.companyNameHeader = Me.companyNameHeader
                Admin.Show()
                Me.Close()


            Case Else
                User.username = Me.username
                User.role_id = Me.role_id
                User.departmentName = Me.departmentName
                User.adminCheck = Me.adminCheck
                User.fullName = Me.fullName
                User.companyNameHeader = Me.companyNameHeader
                User.Show()
                Me.Close()

        End Select
    End Sub


    Private Sub DataGridView1_Celldbclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvView.CellDoubleClick
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim rd2 As SqlDataReader
        Dim selected As String
        selected = dgvView.CurrentCell.Value
        con2.ConnectionString = My.Settings.connstr
        cmd2.Connection = con2
        con2.Open()

        Select Case role_id
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
            obj.Username = Me.username
            obj.role_id = Me.role_id
            obj.TruckOutNumber = selected
            obj.departmentName = Me.departmentName
            obj.adminCheck = Me.adminCheck
            obj.fullName = Me.fullName
            obj.companyNameHeader = Me.companyNameHeader
            obj.Show()
            Me.Close()

        Else
            MessageBox.Show("You have no privilege to view this number.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub
End Class