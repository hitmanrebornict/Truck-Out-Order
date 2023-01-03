Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports Truck_Out_Order.My.Resources

Public Class Admin

    Public TruckOutNumber As Integer
    Private companyNameHeader As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFunction.TopHeader(lblUserDetails, lblCompanyHeader, companyNameHeader)

        If (My.Settings.languageSetting = "fr") Then
            lblTooSystem.Text = ResourceAdminFrench.lblTooSystem
            lblNew.Text = ResourceAdminFrench.lblNew
            lblEdit.Text = ResourceAdminFrench.lblEdit
            lblReport.Text = ResourceAdminFrench.lblReport
            lblUserSetting.Text = ResourceAdminFrench.lblUserSetting
            lblFieldSetting.Text = ResourceAdminFrench.lblFieldSetting
            lblDriverSetting.Text = ResourceAdminFrench.lblDriverSetting
            lblCompany.Text = ResourceAdminFrench.lblCompany
            lblLogout.Text = ResourceAdminFrench.lblLogout
        Else
            lblTooSystem.Text = ResourceAdmin.lblTooSystem
            lblNew.Text = ResourceAdmin.lblNew
            lblEdit.Text = ResourceAdmin.lblEdit
            lblReport.Text = ResourceAdmin.lblReport
            lblUserSetting.Text = ResourceAdmin.lblUserSetting
            lblFieldSetting.Text = ResourceAdmin.lblFieldSetting
            lblDriverSetting.Text = ResourceAdmin.lblDriverSetting
            lblCompany.Text = ResourceAdmin.lblCompany
            lblLogout.Text = ResourceAdmin.lblLogout
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.username = ""
        GlobalFunction.backToPage(Login, Me)
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
        Dim maxDetailsTOONumber As Integer
        Dim rd As SqlDataReader

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT max(ID) as maxID from Shipping"
        rd = cmd.ExecuteReader
        rd.Read()
        If IsDBNull(rd.Item("maxID")) Then
            age = 0
        Else
            age = rd.Item("maxID")
        End If


        con.Close()
        con.Open()
        cmd.CommandText = "SELECT max(TOO_Number) as maxTOONumber from details where TOO_Number is not null"
        rd = cmd.ExecuteReader
        rd.Read()
        If IsDBNull(rd.Item("maxTOONumber")) Then
            maxDetailsTOONumber = 0
        Else
            maxDetailsTOONumber = rd.Item("maxTOONumber")
        End If


        If age = 0 Then
            My.Settings.newTOONumber = maxDetailsTOONumber
        Else
            If age >= maxDetailsTOONumber Then
                My.Settings.newTOONumber = age + 1
            Else
                My.Settings.newTOONumber = maxDetailsTOONumber
            End If

        End If
        Dim Obj As New NewPage
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
        Dim Obj As New Search
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
        Dim View As New ViewPage
        View.Show()
        Me.Close()
    End Sub

    Private Sub pbSystem_Hover(sender As Object, e As EventArgs) Handles pbCompany.MouseHover
        pbCompany.BackColor = Color.SkyBlue
        pnlCompany.BackColor = Color.LightGray
        lblCompany.BackColor = Color.LightGray
    End Sub

    Private Sub pbSystem_Leave(sender As Object, e As EventArgs) Handles pbCompany.MouseLeave
        pbCompany.BackColor = Color.Azure
        pnlCompany.BackColor = Color.White
        lblCompany.BackColor = Color.White
    End Sub

    Private Sub pbCompany_Click(sender As Object, e As EventArgs) Handles pbCompany.Click
        Dim Company As New CompanyMaintenance
        Company.Show()
        Me.Close()
    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Dim newPage As New NewPage
        newPage.Show()
        Me.Close()
    End Sub

    Private Sub lblEdit_Click(sender As Object, e As EventArgs) Handles lblEdit.Click
        Dim searchPage As New Search
        searchPage.Show()
        Me.Close()
    End Sub

    Private Sub lblReport_Click(sender As Object, e As EventArgs) Handles lblReport.Click
        Dim reportPage As New ViewPage
        reportPage.Show()
        Me.Close()
    End Sub

    Private Sub lblUserSetting_Click(sender As Object, e As EventArgs) Handles lblUserSetting.Click
        Dim userSetting As New AddUserTry
        userSetting.Show()
        Me.Close()
    End Sub

    Private Sub lblFieldSetting_Click(sender As Object, e As EventArgs) Handles lblFieldSetting.Click
        Dim fieldSetting As New FieldMaintenance
        fieldSetting.Show()
        Me.Close()
    End Sub

    Private Sub lblDriverSetting_Click(sender As Object, e As EventArgs) Handles lblDriverSetting.Click
        Dim driverSetting As New DriverMaintenance
        driverSetting.Show()
        Me.Close()
    End Sub

    Private Sub lblCompany_Click(sender As Object, e As EventArgs) Handles lblCompany.Click
        Dim systemSetting As New CompanyMaintenance
        systemSetting.Show()
        Me.Close()
    End Sub


End Class