﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NormalUserPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NormalUserPage))
        Me.lblTooSystem = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.lblUserDetails = New System.Windows.Forms.Label()
        Me.pbGCB = New System.Windows.Forms.PictureBox()
        Me.pnlReport = New System.Windows.Forms.Panel()
        Me.pbReport = New System.Windows.Forms.PictureBox()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.pbEdit = New System.Windows.Forms.PictureBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.pnlNew = New System.Windows.Forms.Panel()
        Me.pbNew = New System.Windows.Forms.PictureBox()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblCompanyHeader = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.pbGCB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReport.SuspendLayout()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEdit.SuspendLayout()
        CType(Me.pbEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNew.SuspendLayout()
        CType(Me.pbNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTooSystem
        '
        Me.lblTooSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTooSystem.AutoSize = True
        Me.lblTooSystem.BackColor = System.Drawing.Color.Transparent
        Me.lblTooSystem.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTooSystem.Location = New System.Drawing.Point(3, 5)
        Me.lblTooSystem.Name = "lblTooSystem"
        Me.lblTooSystem.Size = New System.Drawing.Size(1258, 109)
        Me.lblTooSystem.TabIndex = 3
        Me.lblTooSystem.Text = "Truck Out Order System"
        Me.lblTooSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Azure
        Me.btnLogout.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.icons8_logout_rounded_down_100
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Location = New System.Drawing.Point(1084, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(134, 95)
        Me.btnLogout.TabIndex = 27
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblLogout
        '
        Me.lblLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLogout.AutoSize = True
        Me.lblLogout.BackColor = System.Drawing.Color.Transparent
        Me.lblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.Location = New System.Drawing.Point(3, 4)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(215, 20)
        Me.lblLogout.TabIndex = 28
        Me.lblLogout.Text = "LOGOUT"
        Me.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserDetails
        '
        Me.lblUserDetails.AutoSize = True
        Me.lblUserDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblUserDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDetails.Location = New System.Drawing.Point(12, 38)
        Me.lblUserDetails.Name = "lblUserDetails"
        Me.lblUserDetails.Size = New System.Drawing.Size(159, 25)
        Me.lblUserDetails.TabIndex = 29
        Me.lblUserDetails.Text = "lblUserDetails"
        '
        'pbGCB
        '
        Me.pbGCB.BackColor = System.Drawing.Color.Transparent
        Me.pbGCB.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.realGuanChongIcon_removebg_preview
        Me.pbGCB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbGCB.Location = New System.Drawing.Point(458, 54)
        Me.pbGCB.Name = "pbGCB"
        Me.pbGCB.Size = New System.Drawing.Size(349, 124)
        Me.pbGCB.TabIndex = 30
        Me.pbGCB.TabStop = False
        '
        'pnlReport
        '
        Me.pnlReport.BackColor = System.Drawing.Color.White
        Me.pnlReport.Controls.Add(Me.pbReport)
        Me.pnlReport.Controls.Add(Me.lblReport)
        Me.pnlReport.Location = New System.Drawing.Point(759, 352)
        Me.pnlReport.Name = "pnlReport"
        Me.pnlReport.Size = New System.Drawing.Size(162, 241)
        Me.pnlReport.TabIndex = 33
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
        'lblReport
        '
        Me.lblReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReport.BackColor = System.Drawing.Color.White
        Me.lblReport.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(3, 113)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(156, 128)
        Me.lblReport.TabIndex = 16
        Me.lblReport.Text = "REPORT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlEdit
        '
        Me.pnlEdit.BackColor = System.Drawing.Color.White
        Me.pnlEdit.Controls.Add(Me.pbEdit)
        Me.pnlEdit.Controls.Add(Me.lblEdit)
        Me.pnlEdit.Location = New System.Drawing.Point(551, 352)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(162, 241)
        Me.pnlEdit.TabIndex = 32
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
        'lblEdit
        '
        Me.lblEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEdit.BackColor = System.Drawing.Color.White
        Me.lblEdit.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.Location = New System.Drawing.Point(3, 113)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(156, 128)
        Me.lblEdit.TabIndex = 14
        Me.lblEdit.Text = "EDIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlNew
        '
        Me.pnlNew.BackColor = System.Drawing.Color.White
        Me.pnlNew.Controls.Add(Me.pbNew)
        Me.pnlNew.Controls.Add(Me.lblNew)
        Me.pnlNew.Location = New System.Drawing.Point(343, 352)
        Me.pnlNew.Name = "pnlNew"
        Me.pnlNew.Size = New System.Drawing.Size(162, 241)
        Me.pnlNew.TabIndex = 31
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
        'lblNew
        '
        Me.lblNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNew.BackColor = System.Drawing.Color.White
        Me.lblNew.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(0, 113)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(159, 128)
        Me.lblNew.TabIndex = 20
        Me.lblNew.Text = "NEW" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCompanyHeader
        '
        Me.lblCompanyHeader.AutoSize = True
        Me.lblCompanyHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblCompanyHeader.Name = "lblCompanyHeader"
        Me.lblCompanyHeader.Size = New System.Drawing.Size(211, 25)
        Me.lblCompanyHeader.TabIndex = 34
        Me.lblCompanyHeader.Text = "lblCompanyHeader"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTooSystem, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 184)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1264, 119)
        Me.TableLayoutPanel1.TabIndex = 35
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblLogout, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1041, 113)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(221, 29)
        Me.TableLayoutPanel2.TabIndex = 36
        '
        'NormalUserPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.Untitled_design__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblCompanyHeader)
        Me.Controls.Add(Me.pnlReport)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.pnlNew)
        Me.Controls.Add(Me.pbGCB)
        Me.Controls.Add(Me.lblUserDetails)
        Me.Controls.Add(Me.btnLogout)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "NormalUserPage"
        Me.Text = "TOO System"
        CType(Me.pbGCB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReport.ResumeLayout(False)
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEdit.ResumeLayout(False)
        CType(Me.pbEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNew.ResumeLayout(False)
        CType(Me.pbNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTooSystem As Label
    Public WithEvents btnLogout As Button
    Friend WithEvents lblLogout As Label
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents pbGCB As PictureBox
    Friend WithEvents pnlReport As Panel
    Friend WithEvents pbReport As PictureBox
    Friend WithEvents lblReport As Label
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents pbEdit As PictureBox
    Friend WithEvents lblEdit As Label
    Friend WithEvents pnlNew As Panel
    Friend WithEvents pbNew As PictureBox
    Friend WithEvents lblNew As Label
    Friend WithEvents lblCompanyHeader As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
