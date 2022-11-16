<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompanyMaintenance
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
        Me.btnDelete = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDriverID = New System.Windows.Forms.Label()
        Me.cmbCompanyName = New System.Windows.Forms.ComboBox()
        Me.tbRegistrationNo = New System.Windows.Forms.TextBox()
        Me.lblPmRegistrationPlate = New System.Windows.Forms.Label()
        Me.tbFax = New System.Windows.Forms.TextBox()
        Me.lblPmCode = New System.Windows.Forms.Label()
        Me.tbTelephone = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCountry = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbState = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAddressLine2 = New System.Windows.Forms.TextBox()
        Me.lblIcNumber = New System.Windows.Forms.Label()
        Me.tbAddressLine1 = New System.Windows.Forms.TextBox()
        Me.tbPostalCode = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCompanyNameHeader = New System.Windows.Forms.Label()
        Me.lblUserMaintenance = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUserDetails = New System.Windows.Forms.Label()
        Me.btnDelete.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.Controls.Add(Me.btnCancel)
        Me.btnDelete.Controls.Add(Me.btnSave)
        Me.btnDelete.Controls.Add(Me.btnNew)
        Me.btnDelete.Controls.Add(Me.btnDel)
        Me.btnDelete.Controls.Add(Me.TableLayoutPanel1)
        Me.btnDelete.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(120, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(1039, 703)
        Me.btnDelete.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(934, 661)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 30)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(742, 661)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 30)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(646, 661)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 30)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(838, 661)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(90, 30)
        Me.btnDel.TabIndex = 13
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.94574!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.05426!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDriverID, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCompanyName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRegistrationNo, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPmRegistrationPlate, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tbFax, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPmCode, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tbTelephone, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFullName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCountry, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbState, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCity, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbAddressLine2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblIcNumber, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbAddressLine1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPostalCode, 1, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 135)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1033, 453)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblDriverID
        '
        Me.lblDriverID.AutoSize = True
        Me.lblDriverID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverID.Location = New System.Drawing.Point(4, 406)
        Me.lblDriverID.Name = "lblDriverID"
        Me.lblDriverID.Size = New System.Drawing.Size(244, 24)
        Me.lblDriverID.TabIndex = 9
        Me.lblDriverID.Text = "Company Registration No."
        '
        'cmbCompanyName
        '
        Me.cmbCompanyName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompanyName.FormattingEnabled = True
        Me.cmbCompanyName.Location = New System.Drawing.Point(344, 4)
        Me.cmbCompanyName.Name = "cmbCompanyName"
        Me.cmbCompanyName.Size = New System.Drawing.Size(433, 27)
        Me.cmbCompanyName.TabIndex = 1
        '
        'tbRegistrationNo
        '
        Me.tbRegistrationNo.Location = New System.Drawing.Point(344, 409)
        Me.tbRegistrationNo.Name = "tbRegistrationNo"
        Me.tbRegistrationNo.Size = New System.Drawing.Size(433, 26)
        Me.tbRegistrationNo.TabIndex = 10
        '
        'lblPmRegistrationPlate
        '
        Me.lblPmRegistrationPlate.AutoSize = True
        Me.lblPmRegistrationPlate.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPmRegistrationPlate.Location = New System.Drawing.Point(4, 361)
        Me.lblPmRegistrationPlate.Name = "lblPmRegistrationPlate"
        Me.lblPmRegistrationPlate.Size = New System.Drawing.Size(49, 24)
        Me.lblPmRegistrationPlate.TabIndex = 3
        Me.lblPmRegistrationPlate.Text = "Fax:"
        '
        'tbFax
        '
        Me.tbFax.Location = New System.Drawing.Point(344, 364)
        Me.tbFax.Name = "tbFax"
        Me.tbFax.Size = New System.Drawing.Size(433, 26)
        Me.tbFax.TabIndex = 9
        '
        'lblPmCode
        '
        Me.lblPmCode.AutoSize = True
        Me.lblPmCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPmCode.Location = New System.Drawing.Point(4, 316)
        Me.lblPmCode.Name = "lblPmCode"
        Me.lblPmCode.Size = New System.Drawing.Size(107, 24)
        Me.lblPmCode.TabIndex = 2
        Me.lblPmCode.Text = "Telephone:"
        '
        'tbTelephone
        '
        Me.tbTelephone.Location = New System.Drawing.Point(344, 319)
        Me.tbTelephone.Name = "tbTelephone"
        Me.tbTelephone.Size = New System.Drawing.Size(433, 26)
        Me.tbTelephone.TabIndex = 8
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(4, 1)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(160, 24)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Company Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Postal Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Country:"
        '
        'tbCountry
        '
        Me.tbCountry.Location = New System.Drawing.Point(344, 229)
        Me.tbCountry.Name = "tbCountry"
        Me.tbCountry.Size = New System.Drawing.Size(433, 26)
        Me.tbCountry.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "State:"
        '
        'tbState
        '
        Me.tbState.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbState.Location = New System.Drawing.Point(344, 184)
        Me.tbState.Name = "tbState"
        Me.tbState.Size = New System.Drawing.Size(433, 26)
        Me.tbState.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "City:"
        '
        'tbCity
        '
        Me.tbCity.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCity.Location = New System.Drawing.Point(344, 139)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(433, 26)
        Me.tbCity.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Address Line 2:"
        '
        'tbAddressLine2
        '
        Me.tbAddressLine2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddressLine2.Location = New System.Drawing.Point(344, 94)
        Me.tbAddressLine2.Name = "tbAddressLine2"
        Me.tbAddressLine2.Size = New System.Drawing.Size(433, 26)
        Me.tbAddressLine2.TabIndex = 3
        '
        'lblIcNumber
        '
        Me.lblIcNumber.AutoSize = True
        Me.lblIcNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIcNumber.Location = New System.Drawing.Point(4, 46)
        Me.lblIcNumber.Name = "lblIcNumber"
        Me.lblIcNumber.Size = New System.Drawing.Size(149, 24)
        Me.lblIcNumber.TabIndex = 1
        Me.lblIcNumber.Text = "Address Line 1:"
        '
        'tbAddressLine1
        '
        Me.tbAddressLine1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddressLine1.Location = New System.Drawing.Point(344, 49)
        Me.tbAddressLine1.Name = "tbAddressLine1"
        Me.tbAddressLine1.Size = New System.Drawing.Size(433, 26)
        Me.tbAddressLine1.TabIndex = 2
        '
        'tbPostalCode
        '
        Me.tbPostalCode.Location = New System.Drawing.Point(344, 274)
        Me.tbPostalCode.Name = "tbPostalCode"
        Me.tbPostalCode.Size = New System.Drawing.Size(433, 26)
        Me.tbPostalCode.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.lblCompanyNameHeader)
        Me.Panel1.Controls.Add(Me.lblUserMaintenance)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblUserDetails)
        Me.Panel1.Location = New System.Drawing.Point(120, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1039, 97)
        Me.Panel1.TabIndex = 140
        '
        'lblCompanyNameHeader
        '
        Me.lblCompanyNameHeader.AutoSize = True
        Me.lblCompanyNameHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyNameHeader.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyNameHeader.Location = New System.Drawing.Point(147, 13)
        Me.lblCompanyNameHeader.Name = "lblCompanyNameHeader"
        Me.lblCompanyNameHeader.Size = New System.Drawing.Size(191, 24)
        Me.lblCompanyNameHeader.TabIndex = 138
        Me.lblCompanyNameHeader.Text = "lblCompanyHeader"
        '
        'lblUserMaintenance
        '
        Me.lblUserMaintenance.AutoSize = True
        Me.lblUserMaintenance.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserMaintenance.Location = New System.Drawing.Point(804, 51)
        Me.lblUserMaintenance.Name = "lblUserMaintenance"
        Me.lblUserMaintenance.Size = New System.Drawing.Size(232, 24)
        Me.lblUserMaintenance.TabIndex = 0
        Me.lblUserMaintenance.Text = "Company Maintenance"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.realGuanChongIcon_removebg_preview
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(138, 48)
        Me.Panel2.TabIndex = 136
        '
        'lblUserDetails
        '
        Me.lblUserDetails.AutoSize = True
        Me.lblUserDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblUserDetails.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDetails.Location = New System.Drawing.Point(3, 51)
        Me.lblUserDetails.Name = "lblUserDetails"
        Me.lblUserDetails.Size = New System.Drawing.Size(140, 24)
        Me.lblUserDetails.TabIndex = 129
        Me.lblUserDetails.Text = "lblUserDetails"
        '
        'CompanyMaintenance
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.Untitled_design__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 704)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "CompanyMaintenance"
        Me.Text = "TOO System"
        Me.btnDelete.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDelete As Panel
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbAddressLine2 As TextBox
    Friend WithEvents tbAddressLine1 As TextBox
    Friend WithEvents lblPmRegistrationPlate As Label
    Friend WithEvents lblPmCode As Label
    Friend WithEvents lblIcNumber As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDriverID As Label
    Friend WithEvents tbState As TextBox
    Friend WithEvents cmbCompanyName As ComboBox
    Friend WithEvents tbRegistrationNo As TextBox
    Friend WithEvents tbPostalCode As TextBox
    Friend WithEvents tbFax As TextBox
    Friend WithEvents tbTelephone As TextBox
    Friend WithEvents tbCountry As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCompanyNameHeader As Label
    Friend WithEvents lblUserMaintenance As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
End Class
