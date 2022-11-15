Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Imports System.Reflection.Emit

Public Class Admin

    Public username As String ' username
    Public fullName As String
    Public role_id As Integer 'Role
    Public TruckOutNumber As Integer
    Public departmentName As String
    Public adminCheck As Boolean
    Public companyNameHeader As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & fullName & vbNewLine & "Department of " & departmentName)
        lblTooSystem.Left = (Me.Width - lblTooSystem.Width) / 2
        ''Me.TruckOutNumber = 70535
        lblCompanyHeader.Text = companyNameHeader
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim loginPage As New Login
        loginPage.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Hover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.LightGray
    End Sub
    Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Azure
    End Sub
    Private Sub PictureBox1_hover(sender As Object, e As EventArgs) Handles pbUserSetting.MouseHover
        pbUserSetting.BackColor = Color.SkyBlue
        pnlUser.BackColor = Color.LightGray
        lblUserSetting.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox1_left(sender As Object, e As EventArgs) Handles pbUserSetting.MouseLeave
        pbUserSetting.BackColor = Color.Azure
        pnlUser.BackColor = Color.White
        lblUserSetting.BackColor = Color.White
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbUserSetting.Click
        Dim Add As New AddUserTry
        Add.username = Me.username
        Add.role_id = Me.role_id
        Add.departmentName = Me.departmentName
        Add.adminCheck1 = Me.adminCheck
        Add.fullName = Me.fullName
        Add.Show()
        Me.Close()
    End Sub

    Private Sub pbFieldSetting_hover(sender As Object, e As EventArgs) Handles pbFieldSetting.MouseHover
        pbFieldSetting.BackColor = Color.SkyBlue
        pnlFrieldSetting.BackColor = Color.LightGray
        lblFieldSetting.BackColor = Color.LightGray
    End Sub

    Private Sub pbFieldSetting_leave(sender As Object, e As EventArgs) Handles pbFieldSetting.MouseLeave
        pbFieldSetting.BackColor = Color.Azure
        pnlFrieldSetting.BackColor = Color.White
        lblFieldSetting.BackColor = Color.White
    End Sub

    Private Sub pbFieldSetting_click(sender As Object, e As EventArgs) Handles pbFieldSetting.MouseClick
        Dim Add As New FieldMaintenance
        Add.username = Me.username
        Add.role_id = Me.role_id
        Add.departmentName = Me.departmentName
        Add.adminCheck = Me.adminCheck
        Add.fullName = Me.fullName
        Add.Show()
        Me.Close()
    End Sub

    Private Sub pbDriverSetting_Hover(sender As Object, e As EventArgs) Handles pbDriverSetting.MouseHover
        pbDriverSetting.BackColor = Color.SkyBlue
        pnlDriverSetting.BackColor = Color.LightGray
        lblDriverSetting.BackColor = Color.LightGray
    End Sub
    Private Sub pbDriverSetting_Leave(sender As Object, e As EventArgs) Handles pbDriverSetting.MouseLeave
        pbDriverSetting.BackColor = Color.Azure
        pnlDriverSetting.BackColor = Color.White
        lblDriverSetting.BackColor = Color.White
    End Sub

    Private Sub pbDriverSetting_Click(sender As Object, e As EventArgs) Handles pbDriverSetting.Click
        Dim driver As New DriverMaintenance
        driver.username = Me.username
        driver.role_id = Me.role_id
        driver.departmentName = Me.departmentName
        driver.adminCheck = Me.adminCheck
        driver.fullName = Me.fullName
        driver.Show()
        Me.Close()
    End Sub

    Private Sub pbNew_Hover(sender As Object, e As EventArgs) Handles pbNew.MouseHover
        pbNew.BackColor = Color.SkyBlue
        pnlNew.BackColor = Color.LightGray
        lblNew.BackColor = Color.LightGray
    End Sub

    Private Sub pbNew_Leave(sender As Object, e As EventArgs) Handles pbNew.MouseLeave
        pbNew.BackColor = Color.Azure
        pnlNew.BackColor = Color.White
        lblNew.BackColor = Color.White
    End Sub

    Private Sub pbNew_Click(sender As Object, e As EventArgs) Handles pbNew.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim age As Integer
        Dim rd As SqlDataReader

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "SELECT max(ID) as maxID from Shipping"
        rd = cmd.ExecuteReader
        While rd.Read()
            age = rd.Item("maxID")
        End While

        If age = 0 Then
            Me.TruckOutNumber = 34800
        Else
            Me.TruckOutNumber = age + 1
        End If
        Dim Obj As New NewPage
        Obj.Username = Me.username
        Obj.role_id = Me.role_id
        Obj.TruckOutNumber = Me.TruckOutNumber
        Obj.departmentName = Me.departmentName
        Obj.adminCheck = Me.adminCheck
        Obj.fullName = Me.fullName
        Obj.Show()
        Me.Close()
    End Sub

    Private Sub pbEdit_Hover(sender As Object, e As EventArgs) Handles pbEdit.MouseHover
        pbEdit.BackColor = Color.SkyBlue
        pnlEdit.BackColor = Color.LightGray
        lblEdit.BackColor = Color.LightGray
    End Sub

    Private Sub pbEdit_Leave(sender As Object, e As EventArgs) Handles pbEdit.MouseLeave
        pbEdit.BackColor = Color.Azure
        pnlEdit.BackColor = Color.White
        lblEdit.BackColor = Color.White
    End Sub

    Private Sub pbEdit_Click(sender As Object, e As EventArgs) Handles pbEdit.Click
        Dim Obj As New Search With {
            .username = Me.username,
            .role_id = Me.role_id,
            .departmentName = Me.departmentName,
            .adminCheck = Me.adminCheck,
            .fullName = Me.fullName
        }
        Obj.Show()
        Me.Close()
    End Sub

    Private Sub pbReport_Hover(sender As Object, e As EventArgs) Handles pbReport.MouseHover
        pbReport.BackColor = Color.SkyBlue
        pnlReport.BackColor = Color.LightGray
        lblReport.BackColor = Color.LightGray
    End Sub

    Private Sub pbReport_Leave(sender As Object, e As EventArgs) Handles pbReport.MouseLeave
        pbReport.BackColor = Color.Azure
        pnlReport.BackColor = Color.White
        lblReport.BackColor = Color.White
    End Sub

    Private Sub pbReport_Click(sender As Object, e As EventArgs) Handles pbReport.Click
        Dim View As New ViewPage With {
            .username = Me.username,
            .role_id = Me.role_id,
            .departmentName = Me.departmentName,
            .adminCheck = Me.adminCheck,
            .fullName = Me.fullName
        }
        View.Show()
        Me.Close()
    End Sub

    Private Sub pbCompany_Click(sender As Object, e As EventArgs) Handles pbCompany.Click
        Dim Company As New CompanyMaintenance With {
            .username = Me.username,
            .role_id = Me.role_id,
            .departmentName = Me.departmentName,
            .adminCheck = Me.adminCheck,
            .fullName = Me.fullName
        }
        Company.Show()
        Me.Close()
    End Sub
End Class