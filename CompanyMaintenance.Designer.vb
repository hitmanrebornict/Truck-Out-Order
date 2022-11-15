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
        Me.cmbCompanyName = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbRegistrationNo = New System.Windows.Forms.TextBox()
        Me.lblIcNumber = New System.Windows.Forms.Label()
        Me.tbFax = New System.Windows.Forms.TextBox()
        Me.tbPostalCode = New System.Windows.Forms.TextBox()
        Me.tbTelephone = New System.Windows.Forms.TextBox()
        Me.tbAddressLine1 = New System.Windows.Forms.TextBox()
        Me.tbAddressLine2 = New System.Windows.Forms.TextBox()
        Me.tbState = New System.Windows.Forms.TextBox()
        Me.tbCountry = New System.Windows.Forms.TextBox()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.lblDriverID = New System.Windows.Forms.Label()
        Me.lblPmRegistrationPlate = New System.Windows.Forms.Label()
        Me.lblPmCode = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUserDetails = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDelete.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.Controls.Add(Me.Button1)
        Me.btnDelete.Controls.Add(Me.cmbCompanyName)
        Me.btnDelete.Controls.Add(Me.TableLayoutPanel1)
        Me.btnDelete.Controls.Add(Me.btnCancel)
        Me.btnDelete.Controls.Add(Me.btnUpdate)
        Me.btnDelete.Controls.Add(Me.btnAddUser)
        Me.btnDelete.Controls.Add(Me.lblFullName)
        Me.btnDelete.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(120, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(1039, 703)
        Me.btnDelete.TabIndex = 3
        '
        'cmbCompanyName
        '
        Me.cmbCompanyName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompanyName.FormattingEnabled = True
        Me.cmbCompanyName.Location = New System.Drawing.Point(261, 102)
        Me.cmbCompanyName.Name = "cmbCompanyName"
        Me.cmbCompanyName.Size = New System.Drawing.Size(321, 27)
        Me.cmbCompanyName.TabIndex = 23
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.39535!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.60465!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRegistrationNo, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblIcNumber, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbFax, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPostalCode, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tbTelephone, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tbAddressLine1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbAddressLine2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbState, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCountry, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCity, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDriverID, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPmRegistrationPlate, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPmCode, 0, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 135)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1033, 305)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Postal Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Country:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Address Line 2:"
        '
        'tbRegistrationNo
        '
        Me.tbRegistrationNo.Location = New System.Drawing.Point(328, 268)
        Me.tbRegistrationNo.Name = "tbRegistrationNo"
        Me.tbRegistrationNo.Size = New System.Drawing.Size(251, 26)
        Me.tbRegistrationNo.TabIndex = 29
        '
        'lblIcNumber
        '
        Me.lblIcNumber.AutoSize = True
        Me.lblIcNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIcNumber.Location = New System.Drawing.Point(4, 1)
        Me.lblIcNumber.Name = "lblIcNumber"
        Me.lblIcNumber.Size = New System.Drawing.Size(149, 24)
        Me.lblIcNumber.TabIndex = 1
        Me.lblIcNumber.Text = "Address Line 1:"
        '
        'tbFax
        '
        Me.tbFax.Location = New System.Drawing.Point(328, 235)
        Me.tbFax.Name = "tbFax"
        Me.tbFax.Size = New System.Drawing.Size(251, 26)
        Me.tbFax.TabIndex = 27
        '
        'tbPostalCode
        '
        Me.tbPostalCode.Location = New System.Drawing.Point(328, 169)
        Me.tbPostalCode.Name = "tbPostalCode"
        Me.tbPostalCode.Size = New System.Drawing.Size(251, 26)
        Me.tbPostalCode.TabIndex = 28
        '
        'tbTelephone
        '
        Me.tbTelephone.Location = New System.Drawing.Point(328, 202)
        Me.tbTelephone.Name = "tbTelephone"
        Me.tbTelephone.Size = New System.Drawing.Size(251, 26)
        Me.tbTelephone.TabIndex = 26
        '
        'tbAddressLine1
        '
        Me.tbAddressLine1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddressLine1.Location = New System.Drawing.Point(328, 4)
        Me.tbAddressLine1.Name = "tbAddressLine1"
        Me.tbAddressLine1.Size = New System.Drawing.Size(251, 26)
        Me.tbAddressLine1.TabIndex = 6
        '
        'tbAddressLine2
        '
        Me.tbAddressLine2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddressLine2.Location = New System.Drawing.Point(328, 37)
        Me.tbAddressLine2.Name = "tbAddressLine2"
        Me.tbAddressLine2.Size = New System.Drawing.Size(251, 26)
        Me.tbAddressLine2.TabIndex = 7
        '
        'tbState
        '
        Me.tbState.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbState.Location = New System.Drawing.Point(328, 103)
        Me.tbState.Name = "tbState"
        Me.tbState.Size = New System.Drawing.Size(251, 26)
        Me.tbState.TabIndex = 13
        '
        'tbCountry
        '
        Me.tbCountry.Location = New System.Drawing.Point(328, 136)
        Me.tbCountry.Name = "tbCountry"
        Me.tbCountry.Size = New System.Drawing.Size(251, 26)
        Me.tbCountry.TabIndex = 25
        '
        'tbCity
        '
        Me.tbCity.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCity.Location = New System.Drawing.Point(328, 70)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(251, 26)
        Me.tbCity.TabIndex = 8
        '
        'lblDriverID
        '
        Me.lblDriverID.AutoSize = True
        Me.lblDriverID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverID.Location = New System.Drawing.Point(4, 265)
        Me.lblDriverID.Name = "lblDriverID"
        Me.lblDriverID.Size = New System.Drawing.Size(244, 24)
        Me.lblDriverID.TabIndex = 9
        Me.lblDriverID.Text = "Company Registration No."
        '
        'lblPmRegistrationPlate
        '
        Me.lblPmRegistrationPlate.AutoSize = True
        Me.lblPmRegistrationPlate.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPmRegistrationPlate.Location = New System.Drawing.Point(4, 232)
        Me.lblPmRegistrationPlate.Name = "lblPmRegistrationPlate"
        Me.lblPmRegistrationPlate.Size = New System.Drawing.Size(49, 24)
        Me.lblPmRegistrationPlate.TabIndex = 3
        Me.lblPmRegistrationPlate.Text = "Fax:"
        '
        'lblPmCode
        '
        Me.lblPmCode.AutoSize = True
        Me.lblPmCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPmCode.Location = New System.Drawing.Point(4, 199)
        Me.lblPmCode.Name = "lblPmCode"
        Me.lblPmCode.Size = New System.Drawing.Size(107, 24)
        Me.lblPmCode.TabIndex = 2
        Me.lblPmCode.Text = "Telephone:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(742, 446)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(355, 447)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 29)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Save"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(107, 445)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(90, 30)
        Me.btnAddUser.TabIndex = 9
        Me.btnAddUser.Text = "New"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(3, 102)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(160, 24)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Company Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(800, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Company Maintenance"
        '
        'lblUserDetails
        '
        Me.lblUserDetails.AutoSize = True
        Me.lblUserDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblUserDetails.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDetails.Location = New System.Drawing.Point(147, 3)
        Me.lblUserDetails.Name = "lblUserDetails"
        Me.lblUserDetails.Size = New System.Drawing.Size(74, 24)
        Me.lblUserDetails.TabIndex = 22
        Me.lblUserDetails.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblUserDetails)
        Me.Panel1.Location = New System.Drawing.Point(120, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1039, 64)
        Me.Panel1.TabIndex = 140
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.realGuanChongIcon_removebg_preview
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(138, 48)
        Me.Panel2.TabIndex = 136
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(578, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CompanyMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.Untitled_design__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "CompanyMaintenance"
        Me.Text = "TOO System"
        Me.btnDelete.ResumeLayout(False)
        Me.btnDelete.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDelete As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbAddressLine2 As TextBox
    Friend WithEvents tbAddressLine1 As TextBox
    Friend WithEvents lblPmRegistrationPlate As Label
    Friend WithEvents lblPmCode As Label
    Friend WithEvents lblIcNumber As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDriverID As Label
    Friend WithEvents tbState As TextBox
    Friend WithEvents cmbCompanyName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents Button1 As Button
End Class
