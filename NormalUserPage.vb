Imports System.Data.SqlClient

Public Class NormalUserPage

    Public username As String
    Public role_id As Integer 'Role
    Public TruckOutNumber As Integer
    Public departmentName As String
    Public adminCheck As Boolean
    Public fullName As String
    Public companyNameHeader As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTooSystem.Left = (Me.Width - lblTooSystem.Width) / 2
        lblUserDetails.Text = ("Welcome, " & fullName & vbNewLine & "Department of " & departmentName)
        lblCompanyHeader.Text = companyNameHeader

        If role_id = 20 Then
            pnlNew.Visible = True
        Else
            pnlNew.Visible = False
            lblNew.Visible = False
        End If
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginPage As New Login
        loginPage.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Hover(sender As Object, e As EventArgs) Handles btnLogout.MouseHover
        btnLogout.BackColor = Color.LightGray
    End Sub

    Private Sub btnLogout_Leave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.BackColor = Color.Azure
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
        Obj.companyNameHeader = Me.companyNameHeader
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
            .fullName = Me.fullName,
            .companyNameHeader = Me.companyNameHeader
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
            .fullName = Me.fullName,
            .companyNameHeader = Me.companyNameHeader
        }
        View.Show()
        Me.Close()
    End Sub


End Class


