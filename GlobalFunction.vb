Public Class GlobalFunction

    Public Shared Function topHeader(lblWelcome As Label, lblCompanyNameHeader As Label)
        lblWelcome.Text = ("Welcome, " & My.Settings.fullName & vbNewLine & "Department of " & My.Settings.departmentName)
        lblCompanyNameHeader.Text = My.Settings.companyNameHeader
    End Function
End Class
