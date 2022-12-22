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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompanyMaintenance))
        Me.tbTOONumber = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCurrentMaxNum = New System.Windows.Forms.Label()
        Me.btnTOOSave = New System.Windows.Forms.Button()
        Me.tbTOO = New System.Windows.Forms.TextBox()
        Me.lblNewNumber = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCompanyRegistrationNo = New System.Windows.Forms.Label()
        Me.cmbCompanyName = New System.Windows.Forms.ComboBox()
        Me.tbRegistrationNo = New System.Windows.Forms.TextBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.tbFax = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.tbTelephone = New System.Windows.Forms.TextBox()
        Me.lblCompanyFullName = New System.Windows.Forms.Label()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.tbCountry = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.tbState = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.lblAddressLine2 = New System.Windows.Forms.Label()
        Me.tbAddressLine2 = New System.Windows.Forms.TextBox()
        Me.lblAddressLine1 = New System.Windows.Forms.Label()
        Me.tbAddressLine1 = New System.Windows.Forms.TextBox()
        Me.tbPostalCode = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCompanyNameHeader = New System.Windows.Forms.Label()
        Me.lblCompanyMaintenance = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUserDetails = New System.Windows.Forms.Label()
        Me.tbTOONumber.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTOONumber
        '
        Me.tbTOONumber.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbTOONumber.Controls.Add(Me.Panel3)
        Me.tbTOONumber.Controls.Add(Me.btnCancel)
        Me.tbTOONumber.Controls.Add(Me.btnSave)
        Me.tbTOONumber.Controls.Add(Me.btnNew)
        Me.tbTOONumber.Controls.Add(Me.btnDel)
        Me.tbTOONumber.Controls.Add(Me.TableLayoutPanel1)
        Me.tbTOONumber.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTOONumber.Location = New System.Drawing.Point(113, 1)
        Me.tbTOONumber.Name = "tbTOONumber"
        Me.tbTOONumber.Size = New System.Drawing.Size(1039, 680)
        Me.tbTOONumber.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel3.Controls.Add(Me.lblCurrentMaxNum)
        Me.Panel3.Controls.Add(Me.btnTOOSave)
        Me.Panel3.Controls.Add(Me.tbTOO)
        Me.Panel3.Controls.Add(Me.lblNewNumber)
        Me.Panel3.Location = New System.Drawing.Point(7, 534)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(603, 122)
        Me.Panel3.TabIndex = 30
        '
        'lblCurrentMaxNum
        '
        Me.lblCurrentMaxNum.AutoSize = True
        Me.lblCurrentMaxNum.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMaxNum.Location = New System.Drawing.Point(3, 9)
        Me.lblCurrentMaxNum.Name = "lblCurrentMaxNum"
        Me.lblCurrentMaxNum.Size = New System.Drawing.Size(176, 24)
        Me.lblCurrentMaxNum.TabIndex = 18
        Me.lblCurrentMaxNum.Text = "lblCurrentMaxNum"
        '
        'btnTOOSave
        '
        Me.btnTOOSave.Location = New System.Drawing.Point(408, 73)
        Me.btnTOOSave.Name = "btnTOOSave"
        Me.btnTOOSave.Size = New System.Drawing.Size(110, 30)
        Me.btnTOOSave.TabIndex = 32
        Me.btnTOOSave.Text = "Save"
        Me.btnTOOSave.UseVisualStyleBackColor = True
        '
        'tbTOO
        '
        Me.tbTOO.Location = New System.Drawing.Point(408, 41)
        Me.tbTOO.Name = "tbTOO"
        Me.tbTOO.Size = New System.Drawing.Size(176, 26)
        Me.tbTOO.TabIndex = 31
        '
        'lblNewNumber
        '
        Me.lblNewNumber.AutoSize = True
        Me.lblNewNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewNumber.Location = New System.Drawing.Point(3, 41)
        Me.lblNewNumber.Name = "lblNewNumber"
        Me.lblNewNumber.Size = New System.Drawing.Size(182, 24)
        Me.lblNewNumber.TabIndex = 22
        Me.lblNewNumber.Text = "New TOO Number:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(924, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 30)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(688, 469)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 30)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(570, 469)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(110, 30)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(806, 469)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(110, 30)
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
        Me.TableLayoutPanel1.Controls.Add(Me.lblCompanyRegistrationNo, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCompanyName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRegistrationNo, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFax, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tbFax, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTelephone, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tbTelephone, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCompanyFullName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPostalCode, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCountry, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCountry, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblState, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbState, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCity, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCity, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAddressLine2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbAddressLine2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAddressLine1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbAddressLine1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPostalCode, 1, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 103)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1033, 360)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblCompanyRegistrationNo
        '
        Me.lblCompanyRegistrationNo.AutoSize = True
        Me.lblCompanyRegistrationNo.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyRegistrationNo.Location = New System.Drawing.Point(4, 316)
        Me.lblCompanyRegistrationNo.Name = "lblCompanyRegistrationNo"
        Me.lblCompanyRegistrationNo.Size = New System.Drawing.Size(244, 24)
        Me.lblCompanyRegistrationNo.TabIndex = 9
        Me.lblCompanyRegistrationNo.Text = "Company Registration No."
        '
        'cmbCompanyName
        '
        Me.cmbCompanyName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompanyName.FormattingEnabled = True
        Me.cmbCompanyName.Location = New System.Drawing.Point(344, 4)
        Me.cmbCompanyName.Name = "cmbCompanyName"
        Me.cmbCompanyName.Size = New System.Drawing.Size(654, 27)
        Me.cmbCompanyName.TabIndex = 1
        '
        'tbRegistrationNo
        '
        Me.tbRegistrationNo.Location = New System.Drawing.Point(344, 319)
        Me.tbRegistrationNo.Name = "tbRegistrationNo"
        Me.tbRegistrationNo.Size = New System.Drawing.Size(654, 26)
        Me.tbRegistrationNo.TabIndex = 10
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.Location = New System.Drawing.Point(4, 281)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(49, 24)
        Me.lblFax.TabIndex = 3
        Me.lblFax.Text = "Fax:"
        '
        'tbFax
        '
        Me.tbFax.Location = New System.Drawing.Point(344, 284)
        Me.tbFax.Name = "tbFax"
        Me.tbFax.Size = New System.Drawing.Size(654, 26)
        Me.tbFax.TabIndex = 9
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephone.Location = New System.Drawing.Point(4, 246)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(107, 24)
        Me.lblTelephone.TabIndex = 2
        Me.lblTelephone.Text = "Telephone:"
        '
        'tbTelephone
        '
        Me.tbTelephone.Location = New System.Drawing.Point(344, 249)
        Me.tbTelephone.Name = "tbTelephone"
        Me.tbTelephone.Size = New System.Drawing.Size(654, 26)
        Me.tbTelephone.TabIndex = 8
        '
        'lblCompanyFullName
        '
        Me.lblCompanyFullName.AutoSize = True
        Me.lblCompanyFullName.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyFullName.Location = New System.Drawing.Point(4, 1)
        Me.lblCompanyFullName.Name = "lblCompanyFullName"
        Me.lblCompanyFullName.Size = New System.Drawing.Size(160, 24)
        Me.lblCompanyFullName.TabIndex = 0
        Me.lblCompanyFullName.Text = "Company Name:"
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.Location = New System.Drawing.Point(4, 211)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(124, 24)
        Me.lblPostalCode.TabIndex = 24
        Me.lblPostalCode.Text = "Postal Code:"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(4, 176)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(86, 24)
        Me.lblCountry.TabIndex = 24
        Me.lblCountry.Text = "Country:"
        '
        'tbCountry
        '
        Me.tbCountry.Location = New System.Drawing.Point(344, 179)
        Me.tbCountry.Name = "tbCountry"
        Me.tbCountry.Size = New System.Drawing.Size(654, 26)
        Me.tbCountry.TabIndex = 6
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(4, 141)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(63, 24)
        Me.lblState.TabIndex = 24
        Me.lblState.Text = "State:"
        '
        'tbState
        '
        Me.tbState.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbState.Location = New System.Drawing.Point(344, 144)
        Me.tbState.Name = "tbState"
        Me.tbState.Size = New System.Drawing.Size(654, 26)
        Me.tbState.TabIndex = 5
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(4, 106)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(50, 24)
        Me.lblCity.TabIndex = 24
        Me.lblCity.Text = "City:"
        '
        'tbCity
        '
        Me.tbCity.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCity.Location = New System.Drawing.Point(344, 109)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(654, 26)
        Me.tbCity.TabIndex = 4
        '
        'lblAddressLine2
        '
        Me.lblAddressLine2.AutoSize = True
        Me.lblAddressLine2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressLine2.Location = New System.Drawing.Point(4, 71)
        Me.lblAddressLine2.Name = "lblAddressLine2"
        Me.lblAddressLine2.Size = New System.Drawing.Size(149, 24)
        Me.lblAddressLine2.TabIndex = 24
        Me.lblAddressLine2.Text = "Address Line 2:"
        '
        'tbAddressLine2
        '
        Me.tbAddressLine2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddressLine2.Location = New System.Drawing.Point(344, 74)
        Me.tbAddressLine2.Name = "tbAddressLine2"
        Me.tbAddressLine2.Size = New System.Drawing.Size(654, 26)
        Me.tbAddressLine2.TabIndex = 3
        '
        'lblAddressLine1
        '
        Me.lblAddressLine1.AutoSize = True
        Me.lblAddressLine1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressLine1.Location = New System.Drawing.Point(4, 36)
        Me.lblAddressLine1.Name = "lblAddressLine1"
        Me.lblAddressLine1.Size = New System.Drawing.Size(149, 24)
        Me.lblAddressLine1.TabIndex = 1
        Me.lblAddressLine1.Text = "Address Line 1:"
        '
        'tbAddressLine1
        '
        Me.tbAddressLine1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddressLine1.Location = New System.Drawing.Point(344, 39)
        Me.tbAddressLine1.Name = "tbAddressLine1"
        Me.tbAddressLine1.Size = New System.Drawing.Size(654, 26)
        Me.tbAddressLine1.TabIndex = 2
        '
        'tbPostalCode
        '
        Me.tbPostalCode.Location = New System.Drawing.Point(344, 214)
        Me.tbPostalCode.Name = "tbPostalCode"
        Me.tbPostalCode.Size = New System.Drawing.Size(654, 26)
        Me.tbPostalCode.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.lblCompanyNameHeader)
        Me.Panel1.Controls.Add(Me.lblCompanyMaintenance)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblUserDetails)
        Me.Panel1.Location = New System.Drawing.Point(113, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1039, 97)
        Me.Panel1.TabIndex = 140
        '
        'lblCompanyNameHeader
        '
        Me.lblCompanyNameHeader.AutoSize = True
        Me.lblCompanyNameHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyNameHeader.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyNameHeader.Location = New System.Drawing.Point(147, 13)
        Me.lblCompanyNameHeader.Name = "lblCompanyNameHeader"
        Me.lblCompanyNameHeader.Size = New System.Drawing.Size(189, 22)
        Me.lblCompanyNameHeader.TabIndex = 138
        Me.lblCompanyNameHeader.Text = "lblCompanyHeader"
        '
        'lblCompanyMaintenance
        '
        Me.lblCompanyMaintenance.AutoSize = True
        Me.lblCompanyMaintenance.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyMaintenance.Location = New System.Drawing.Point(767, 51)
        Me.lblCompanyMaintenance.Name = "lblCompanyMaintenance"
        Me.lblCompanyMaintenance.Size = New System.Drawing.Size(232, 24)
        Me.lblCompanyMaintenance.TabIndex = 0
        Me.lblCompanyMaintenance.Text = "Company Maintenance"
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
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbTOONumber)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "CompanyMaintenance"
        Me.Text = "TOO System"
        Me.tbTOONumber.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbTOONumber As Panel
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbAddressLine2 As TextBox
    Friend WithEvents tbAddressLine1 As TextBox
    Friend WithEvents lblFax As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblAddressLine1 As Label
    Friend WithEvents lblCompanyFullName As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblCompanyRegistrationNo As Label
    Friend WithEvents tbState As TextBox
    Friend WithEvents cmbCompanyName As ComboBox
    Friend WithEvents tbRegistrationNo As TextBox
    Friend WithEvents tbPostalCode As TextBox
    Friend WithEvents tbFax As TextBox
    Friend WithEvents tbTelephone As TextBox
    Friend WithEvents tbCountry As TextBox
    Friend WithEvents lblAddressLine2 As Label
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents btnDel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCompanyNameHeader As Label
    Friend WithEvents lblCompanyMaintenance As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents lblCurrentMaxNum As Label
    Friend WithEvents btnTOOSave As Button
    Friend WithEvents tbTOO As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNewNumber As Label
End Class
