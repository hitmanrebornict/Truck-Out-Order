Imports System.Data.SqlClient

Public Class Admin

    Public TruckOutNumber As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserDetails.Text = ("Welcome, " & My.Settings.fullName & vbNewLine & "Department of " & My.Settings.departmentName)
        lblTooSystem.Left = (Me.Width - lblTooSystem.Width) / 2
        ''Me.TruckOutNumber = 70535
        lblCompanyHeader.Text = My.Settings.companyNameHeader
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

    Private Sub pbCompany_Click(sender As Object, e As EventArgs) Handles pbCompany.Click
        Dim Company As New CompanyMaintenance
        Company.Show()
        Me.Close()
    End Sub
End Class