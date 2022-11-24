Imports System.Data.SqlClient

Public Class NormalUserPage
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTooSystem.Left = (Me.Width - lblTooSystem.Width) / 2
        lblUserDetails.Text = ("Welcome, " & My.Settings.fullName & vbNewLine & "Department of " & My.Settings.departmentName)
        lblCompanyHeader.Text = My.Settings.companyNameHeader

        If My.Settings.role_id = 2 Then
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
        Dim maxDetailsTOONumber As Integer
        Dim rd As SqlDataReader

        con.ConnectionString = My.Settings.connstr
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "SELECT max(ID) as maxID from Shipping"
        rd = cmd.ExecuteReader
        While rd.Read()
            age = rd.Item("maxID")
        End While

        con.Close()
        con.Open()
        cmd.CommandText = "SELECT max(TOO_Number) as maxTOONumber from details where TOO_Number is not null"
        rd = cmd.ExecuteReader
        rd.Read()
        maxDetailsTOONumber = rd.Item("maxTOONumber")

        If age = 0 Then
            My.Settings.newTOONumber = 10000
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
End Class


