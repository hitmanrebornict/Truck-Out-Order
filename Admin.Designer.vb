﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTooSystem = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.lblUserSetting = New System.Windows.Forms.Label()
        Me.lblFieldSetting = New System.Windows.Forms.Label()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.lblDriverSetting = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblUserDetails = New System.Windows.Forms.Label()
        Me.pnlNew = New System.Windows.Forms.Panel()
        Me.pbNew = New System.Windows.Forms.PictureBox()
        Me.pnlReport = New System.Windows.Forms.Panel()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.pbReport = New System.Windows.Forms.PictureBox()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.pbEdit = New System.Windows.Forms.PictureBox()
        Me.pnlDriverSetting = New System.Windows.Forms.Panel()
        Me.pbDriverSetting = New System.Windows.Forms.PictureBox()
        Me.pnlFrieldSetting = New System.Windows.Forms.Panel()
        Me.pbFieldSetting = New System.Windows.Forms.PictureBox()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.pbUserSetting = New System.Windows.Forms.PictureBox()
        Me.pbGCB = New System.Windows.Forms.PictureBox()
        Me.pnlCompany = New System.Windows.Forms.Panel()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.pbCompany = New System.Windows.Forms.PictureBox()
        Me.lblCompanyHeader = New System.Windows.Forms.Label()
        Me.pnlNew.SuspendLayout()
        CType(Me.pbNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReport.SuspendLayout()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEdit.SuspendLayout()
        CType(Me.pbEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDriverSetting.SuspendLayout()
        CType(Me.pbDriverSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrieldSetting.SuspendLayout()
        CType(Me.pbFieldSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUser.SuspendLayout()
        CType(Me.pbUserSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGCB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCompany.SuspendLayout()
        CType(Me.pbCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTooSystem
        '
        Me.lblTooSystem.AutoSize = True
        Me.lblTooSystem.BackColor = System.Drawing.Color.Transparent
        Me.lblTooSystem.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTooSystem.Location = New System.Drawing.Point(87, 139)
        Me.lblTooSystem.Name = "lblTooSystem"
        Me.lblTooSystem.Size = New System.Drawing.Size(1074, 109)
        Me.lblTooSystem.TabIndex = 3
        Me.lblTooSystem.Text = "Truck Out Order System"
        Me.lblTooSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserSetting
        '
        Me.lblUserSetting.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUserSetting.AutoSize = True
        Me.lblUserSetting.BackColor = System.Drawing.Color.White
        Me.lblUserSetting.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserSetting.Location = New System.Drawing.Point(39, 117)
        Me.lblUserSetting.Name = "lblUserSetting"
        Me.lblUserSetting.Size = New System.Drawing.Size(78, 38)
        Me.lblUserSetting.TabIndex = 13
        Me.lblUserSetting.Text = "USER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SETTING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblUserSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFieldSetting
        '
        Me.lblFieldSetting.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFieldSetting.AutoSize = True
        Me.lblFieldSetting.BackColor = System.Drawing.Color.White
        Me.lblFieldSetting.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFieldSetting.Location = New System.Drawing.Point(46, 117)
        Me.lblFieldSetting.Name = "lblFieldSetting"
        Me.lblFieldSetting.Size = New System.Drawing.Size(78, 38)
        Me.lblFieldSetting.TabIndex = 15
        Me.lblFieldSetting.Text = "FIELD " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SETTING"
        Me.lblFieldSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEdit
        '
        Me.lblEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEdit.AutoSize = True
        Me.lblEdit.BackColor = System.Drawing.Color.White
        Me.lblEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.Location = New System.Drawing.Point(53, 169)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(47, 19)
        Me.lblEdit.TabIndex = 14
        Me.lblEdit.Text = "EDIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDriverSetting
        '
        Me.lblDriverSetting.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDriverSetting.AutoSize = True
        Me.lblDriverSetting.BackColor = System.Drawing.Color.White
        Me.lblDriverSetting.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverSetting.Location = New System.Drawing.Point(39, 117)
        Me.lblDriverSetting.Name = "lblDriverSetting"
        Me.lblDriverSetting.Size = New System.Drawing.Size(78, 38)
        Me.lblDriverSetting.TabIndex = 17
        Me.lblDriverSetting.Text = "DRIVER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SETTING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblDriverSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Azure
        Me.Button1.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.icons8_logout_rounded_down_100
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1117, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 79)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1141, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "LOGOUT"
        '
        'lblNew
        '
        Me.lblNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNew.AutoSize = True
        Me.lblNew.BackColor = System.Drawing.Color.White
        Me.lblNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(51, 169)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(46, 19)
        Me.lblNew.TabIndex = 20
        Me.lblNew.Text = "NEW" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblUserDetails
        '
        Me.lblUserDetails.AutoSize = True
        Me.lblUserDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblUserDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDetails.Location = New System.Drawing.Point(13, 34)
        Me.lblUserDetails.Name = "lblUserDetails"
        Me.lblUserDetails.Size = New System.Drawing.Size(178, 29)
        Me.lblUserDetails.TabIndex = 21
        Me.lblUserDetails.Text = "lblUserDetails"
        '
        'pnlNew
        '
        Me.pnlNew.BackColor = System.Drawing.Color.White
        Me.pnlNew.Controls.Add(Me.lblNew)
        Me.pnlNew.Controls.Add(Me.pbNew)
        Me.pnlNew.Location = New System.Drawing.Point(18, 376)
        Me.pnlNew.Name = "pnlNew"
        Me.pnlNew.Size = New System.Drawing.Size(162, 241)
        Me.pnlNew.TabIndex = 22
        '
        'pbNew
        '
        Me.pbNew.BackColor = System.Drawing.Color.Azure
        Me.pbNew.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.icons8_new_view_100
        Me.pbNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNew.Location = New System.Drawing.Point(0, 0)
        Me.pbNew.Name = "pbNew"
        Me.pbNew.Size = New System.Drawing.Size(162, 110)
        Me.pbNew.TabIndex = 21
        Me.pbNew.TabStop = False
        '
        'pnlReport
        '
        Me.pnlReport.BackColor = System.Drawing.Color.White
        Me.pnlReport.Controls.Add(Me.lblReport)
        Me.pnlReport.Controls.Add(Me.pbReport)
        Me.pnlReport.Location = New System.Drawing.Point(427, 376)
        Me.pnlReport.Name = "pnlReport"
        Me.pnlReport.Size = New System.Drawing.Size(163, 241)
        Me.pnlReport.TabIndex = 23
        '
        'lblReport
        '
        Me.lblReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblReport.AutoSize = True
        Me.lblReport.BackColor = System.Drawing.Color.White
        Me.lblReport.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(46, 169)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(73, 19)
        Me.lblReport.TabIndex = 16
        Me.lblReport.Text = "REPORT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pbReport
        '
        Me.pbReport.BackColor = System.Drawing.Color.Azure
        Me.pbReport.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.icons8_graph_report_100
        Me.pbReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReport.Location = New System.Drawing.Point(0, 0)
        Me.pbReport.Name = "pbReport"
        Me.pbReport.Size = New System.Drawing.Size(162, 110)
        Me.pbReport.TabIndex = 26
        Me.pbReport.TabStop = False
        '
        'pnlEdit
        '
        Me.pnlEdit.BackColor = System.Drawing.Color.White
        Me.pnlEdit.Controls.Add(Me.lblEdit)
        Me.pnlEdit.Controls.Add(Me.pbEdit)
        Me.pnlEdit.Location = New System.Drawing.Point(224, 376)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(162, 241)
        Me.pnlEdit.TabIndex = 23
        '
        'pbEdit
        '
        Me.pbEdit.BackColor = System.Drawing.Color.Azure
        Me.pbEdit.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.icons8_pencil_100
        Me.pbEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEdit.Location = New System.Drawing.Point(0, 0)
        Me.pbEdit.Name = "pbEdit"
        Me.pbEdit.Size = New System.Drawing.Size(162, 110)
        Me.pbEdit.TabIndex = 22
        Me.pbEdit.TabStop = False
        '
        'pnlDriverSetting
        '
        Me.pnlDriverSetting.BackColor = System.Drawing.Color.White
        Me.pnlDriverSetting.Controls.Add(Me.lblDriverSetting)
        Me.pnlDriverSetting.Controls.Add(Me.pbDriverSetting)
        Me.pnlDriverSetting.Location = New System.Drawing.Point(788, 474)
        Me.pnlDriverSetting.Name = "pnlDriverSetting"
        Me.pnlDriverSetting.Size = New System.Drawing.Size(162, 174)
        Me.pnlDriverSetting.TabIndex = 24
        '
        'pbDriverSetting
        '
        Me.pbDriverSetting.BackColor = System.Drawing.Color.Azure
        Me.pbDriverSetting.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.icons8_semi_truck_100
        Me.pbDriverSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDriverSetting.Location = New System.Drawing.Point(0, 0)
        Me.pbDriverSetting.Name = "pbDriverSetting"
        Me.pbDriverSetting.Size = New System.Drawing.Size(162, 110)
        Me.pbDriverSetting.TabIndex = 18
        Me.pbDriverSetting.TabStop = False
        '
        'pnlFrieldSetting
        '
        Me.pnlFrieldSetting.BackColor = System.Drawing.Color.White
        Me.pnlFrieldSetting.Controls.Add(Me.lblFieldSetting)
        Me.pnlFrieldSetting.Controls.Add(Me.pbFieldSetting)
        Me.pnlFrieldSetting.Location = New System.Drawing.Point(1027, 275)
        Me.pnlFrieldSetting.Name = "pnlFrieldSetting"
        Me.pnlFrieldSetting.Size = New System.Drawing.Size(162, 174)
        Me.pnlFrieldSetting.TabIndex = 24
        '
        'pbFieldSetting
        '
        Me.pbFieldSetting.BackColor = System.Drawing.Color.Azure
        Me.pbFieldSetting.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.icons8_category_100
        Me.pbFieldSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFieldSetting.Location = New System.Drawing.Point(0, 0)
        Me.pbFieldSetting.Name = "pbFieldSetting"
        Me.pbFieldSetting.Size = New System.Drawing.Size(162, 110)
        Me.pbFieldSetting.TabIndex = 16
        Me.pbFieldSetting.TabStop = False
        '
        'pnlUser
        '
        Me.pnlUser.BackColor = System.Drawing.Color.White
        Me.pnlUser.Controls.Add(Me.lblUserSetting)
        Me.pnlUser.Controls.Add(Me.pbUserSetting)
        Me.pnlUser.Location = New System.Drawing.Point(788, 275)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(162, 174)
        Me.pnlUser.TabIndex = 24
        '
        'pbUserSetting
        '
        Me.pbUserSetting.BackColor = System.Drawing.Color.Azure
        Me.pbUserSetting.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.icons8_account_100
        Me.pbUserSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUserSetting.Location = New System.Drawing.Point(0, 0)
        Me.pbUserSetting.Name = "pbUserSetting"
        Me.pbUserSetting.Size = New System.Drawing.Size(162, 110)
        Me.pbUserSetting.TabIndex = 26
        Me.pbUserSetting.TabStop = False
        '
        'pbGCB
        '
        Me.pbGCB.BackColor = System.Drawing.Color.Transparent
        Me.pbGCB.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.realGuanChongIcon_removebg_preview
        Me.pbGCB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbGCB.Location = New System.Drawing.Point(442, 12)
        Me.pbGCB.Name = "pbGCB"
        Me.pbGCB.Size = New System.Drawing.Size(349, 124)
        Me.pbGCB.TabIndex = 25
        Me.pbGCB.TabStop = False
        '
        'pnlCompany
        '
        Me.pnlCompany.BackColor = System.Drawing.Color.White
        Me.pnlCompany.Controls.Add(Me.lblCompany)
        Me.pnlCompany.Controls.Add(Me.pbCompany)
        Me.pnlCompany.Location = New System.Drawing.Point(1027, 474)
        Me.pnlCompany.Name = "pnlCompany"
        Me.pnlCompany.Size = New System.Drawing.Size(162, 174)
        Me.pnlCompany.TabIndex = 25
        '
        'lblCompany
        '
        Me.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.White
        Me.lblCompany.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(35, 117)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(89, 38)
        Me.lblCompany.TabIndex = 17
        Me.lblCompany.Text = "COMPANY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " SETTING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbCompany
        '
        Me.pbCompany.BackColor = System.Drawing.Color.Azure
        Me.pbCompany.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.icons8_enterprise_resource_planning_100
        Me.pbCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCompany.Location = New System.Drawing.Point(0, 0)
        Me.pbCompany.Name = "pbCompany"
        Me.pbCompany.Size = New System.Drawing.Size(162, 110)
        Me.pbCompany.TabIndex = 18
        Me.pbCompany.TabStop = False
        '
        'lblCompanyHeader
        '
        Me.lblCompanyHeader.AutoSize = True
        Me.lblCompanyHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyHeader.Location = New System.Drawing.Point(12, 5)
        Me.lblCompanyHeader.Name = "lblCompanyHeader"
        Me.lblCompanyHeader.Size = New System.Drawing.Size(237, 29)
        Me.lblCompanyHeader.TabIndex = 27
        Me.lblCompanyHeader.Text = "lblCompanyHeader"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.Untitled_design__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.lblCompanyHeader)
        Me.Controls.Add(Me.pnlCompany)
        Me.Controls.Add(Me.pbGCB)
        Me.Controls.Add(Me.pnlDriverSetting)
        Me.Controls.Add(Me.lblTooSystem)
        Me.Controls.Add(Me.pnlFrieldSetting)
        Me.Controls.Add(Me.pnlUser)
        Me.Controls.Add(Me.pnlReport)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.lblUserDetails)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlNew)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Admin"
        Me.Text = "Form2"
        Me.pnlNew.ResumeLayout(False)
        Me.pnlNew.PerformLayout()
        CType(Me.pbNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReport.ResumeLayout(False)
        Me.pnlReport.PerformLayout()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        CType(Me.pbEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDriverSetting.ResumeLayout(False)
        Me.pnlDriverSetting.PerformLayout()
        CType(Me.pbDriverSetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrieldSetting.ResumeLayout(False)
        Me.pnlFrieldSetting.PerformLayout()
        CType(Me.pbFieldSetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUser.ResumeLayout(False)
        Me.pnlUser.PerformLayout()
        CType(Me.pbUserSetting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGCB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCompany.ResumeLayout(False)
        Me.pnlCompany.PerformLayout()
        CType(Me.pbCompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTooSystem As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblUserSetting As Label
    Friend WithEvents lblFieldSetting As Label
    Friend WithEvents lblEdit As Label
    Friend WithEvents lblDriverSetting As Label
    Public WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents pnlNew As Panel
    Friend WithEvents pnlReport As Panel
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents pnlDriverSetting As Panel
    Friend WithEvents pnlFrieldSetting As Panel
    Friend WithEvents pnlUser As Panel
    Friend WithEvents pbGCB As PictureBox
    Friend WithEvents pbUserSetting As PictureBox
    Friend WithEvents pbDriverSetting As PictureBox
    Friend WithEvents pbFieldSetting As PictureBox
    Friend WithEvents pbNew As PictureBox
    Friend WithEvents pbReport As PictureBox
    Friend WithEvents pbEdit As PictureBox
    Friend WithEvents lblReport As Label
    Friend WithEvents pnlCompany As Panel
    Friend WithEvents lblCompany As Label
    Friend WithEvents pbCompany As PictureBox
    Friend WithEvents lblCompanyHeader As Label
End Class
