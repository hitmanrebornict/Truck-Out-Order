<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DriverMaintenance
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbFullName = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblIcNumber = New System.Windows.Forms.Label()
        Me.lblPmCode = New System.Windows.Forms.Label()
        Me.tbIcNumber = New System.Windows.Forms.TextBox()
        Me.tbPmCode = New System.Windows.Forms.TextBox()
        Me.lblPmRegistrationPlate = New System.Windows.Forms.Label()
        Me.lblDriverID = New System.Windows.Forms.Label()
        Me.tbDriverID = New System.Windows.Forms.TextBox()
        Me.lblDrivingLicense = New System.Windows.Forms.Label()
        Me.tbDrivingLicense = New System.Windows.Forms.TextBox()
        Me.lblDrivingLicenceValid = New System.Windows.Forms.Label()
        Me.dtpLicenseValidDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbLegalWorker = New System.Windows.Forms.TextBox()
        Me.cbActive = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbRegistrationPlate = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUserDetails = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.cmbFullName)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnAddUser)
        Me.Panel3.Controls.Add(Me.lblFullName)
        Me.Panel3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(120, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1039, 703)
        Me.Panel3.TabIndex = 3
        '
        'cmbFullName
        '
        Me.cmbFullName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFullName.FormattingEnabled = True
        Me.cmbFullName.Location = New System.Drawing.Point(115, 99)
        Me.cmbFullName.Name = "cmbFullName"
        Me.cmbFullName.Size = New System.Drawing.Size(616, 27)
        Me.cmbFullName.TabIndex = 23
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblIcNumber, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPmCode, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbIcNumber, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPmCode, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPmRegistrationPlate, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDriverID, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbDriverID, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDrivingLicense, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbDrivingLicense, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDrivingLicenceValid, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpLicenseValidDate, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbLegalWorker, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbActive, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRegistrationPlate, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 135)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1033, 208)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'lblIcNumber
        '
        Me.lblIcNumber.AutoSize = True
        Me.lblIcNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIcNumber.Location = New System.Drawing.Point(4, 1)
        Me.lblIcNumber.Name = "lblIcNumber"
        Me.lblIcNumber.Size = New System.Drawing.Size(113, 24)
        Me.lblIcNumber.TabIndex = 1
        Me.lblIcNumber.Text = "IC Number:"
        '
        'lblPmCode
        '
        Me.lblPmCode.AutoSize = True
        Me.lblPmCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPmCode.Location = New System.Drawing.Point(4, 52)
        Me.lblPmCode.Name = "lblPmCode"
        Me.lblPmCode.Size = New System.Drawing.Size(99, 24)
        Me.lblPmCode.TabIndex = 2
        Me.lblPmCode.Text = "PM Code:"
        '
        'tbIcNumber
        '
        Me.tbIcNumber.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIcNumber.Location = New System.Drawing.Point(262, 4)
        Me.tbIcNumber.Name = "tbIcNumber"
        Me.tbIcNumber.Size = New System.Drawing.Size(251, 26)
        Me.tbIcNumber.TabIndex = 6
        '
        'tbPmCode
        '
        Me.tbPmCode.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPmCode.Location = New System.Drawing.Point(262, 55)
        Me.tbPmCode.Name = "tbPmCode"
        Me.tbPmCode.Size = New System.Drawing.Size(251, 26)
        Me.tbPmCode.TabIndex = 7
        '
        'lblPmRegistrationPlate
        '
        Me.lblPmRegistrationPlate.AutoSize = True
        Me.lblPmRegistrationPlate.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPmRegistrationPlate.Location = New System.Drawing.Point(4, 103)
        Me.lblPmRegistrationPlate.Name = "lblPmRegistrationPlate"
        Me.lblPmRegistrationPlate.Size = New System.Drawing.Size(209, 24)
        Me.lblPmRegistrationPlate.TabIndex = 3
        Me.lblPmRegistrationPlate.Text = "PM Registration Plate:"
        '
        'lblDriverID
        '
        Me.lblDriverID.AutoSize = True
        Me.lblDriverID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverID.Location = New System.Drawing.Point(4, 154)
        Me.lblDriverID.Name = "lblDriverID"
        Me.lblDriverID.Size = New System.Drawing.Size(95, 24)
        Me.lblDriverID.TabIndex = 9
        Me.lblDriverID.Text = "Driver ID:"
        '
        'tbDriverID
        '
        Me.tbDriverID.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDriverID.Location = New System.Drawing.Point(262, 157)
        Me.tbDriverID.Name = "tbDriverID"
        Me.tbDriverID.Size = New System.Drawing.Size(251, 26)
        Me.tbDriverID.TabIndex = 13
        '
        'lblDrivingLicense
        '
        Me.lblDrivingLicense.AutoSize = True
        Me.lblDrivingLicense.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrivingLicense.Location = New System.Drawing.Point(520, 1)
        Me.lblDrivingLicense.Name = "lblDrivingLicense"
        Me.lblDrivingLicense.Size = New System.Drawing.Size(151, 24)
        Me.lblDrivingLicense.TabIndex = 10
        Me.lblDrivingLicense.Text = "Driving Licence:"
        '
        'tbDrivingLicense
        '
        Me.tbDrivingLicense.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDrivingLicense.Location = New System.Drawing.Point(778, 4)
        Me.tbDrivingLicense.Name = "tbDrivingLicense"
        Me.tbDrivingLicense.Size = New System.Drawing.Size(251, 26)
        Me.tbDrivingLicense.TabIndex = 14
        '
        'lblDrivingLicenceValid
        '
        Me.lblDrivingLicenceValid.AutoSize = True
        Me.lblDrivingLicenceValid.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrivingLicenceValid.Location = New System.Drawing.Point(520, 52)
        Me.lblDrivingLicenceValid.Name = "lblDrivingLicenceValid"
        Me.lblDrivingLicenceValid.Size = New System.Drawing.Size(219, 24)
        Me.lblDrivingLicenceValid.TabIndex = 11
        Me.lblDrivingLicenceValid.Text = "Driving Licence Validity:"
        '
        'dtpLicenseValidDate
        '
        Me.dtpLicenseValidDate.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLicenseValidDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLicenseValidDate.Location = New System.Drawing.Point(778, 55)
        Me.dtpLicenseValidDate.Name = "dtpLicenseValidDate"
        Me.dtpLicenseValidDate.Size = New System.Drawing.Size(251, 26)
        Me.dtpLicenseValidDate.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(520, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(193, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Legal Worker? (Y/N)"
        '
        'tbLegalWorker
        '
        Me.tbLegalWorker.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLegalWorker.Location = New System.Drawing.Point(778, 106)
        Me.tbLegalWorker.Name = "tbLegalWorker"
        Me.tbLegalWorker.Size = New System.Drawing.Size(251, 26)
        Me.tbLegalWorker.TabIndex = 16
        '
        'cbActive
        '
        Me.cbActive.AutoSize = True
        Me.cbActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActive.Location = New System.Drawing.Point(778, 157)
        Me.cbActive.Name = "cbActive"
        Me.cbActive.Size = New System.Drawing.Size(15, 14)
        Me.cbActive.TabIndex = 18
        Me.cbActive.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(520, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Active:"
        '
        'tbRegistrationPlate
        '
        Me.tbRegistrationPlate.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRegistrationPlate.Location = New System.Drawing.Point(262, 106)
        Me.tbRegistrationPlate.Name = "tbRegistrationPlate"
        Me.tbRegistrationPlate.Size = New System.Drawing.Size(251, 26)
        Me.tbRegistrationPlate.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(746, 379)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(478, 379)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 29)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Save"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(215, 379)
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
        Me.lblFullName.Size = New System.Drawing.Size(106, 24)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(834, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Driver Maintenance"
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
        'DriverMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.Untitled_design__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "DriverMaintenance"
        Me.Text = "TOO System"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents tbRegistrationPlate As TextBox
    Friend WithEvents tbPmCode As TextBox
    Friend WithEvents tbIcNumber As TextBox
    Friend WithEvents lblPmRegistrationPlate As Label
    Friend WithEvents lblPmCode As Label
    Friend WithEvents lblIcNumber As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDriverID As Label
    Friend WithEvents lblDrivingLicense As Label
    Friend WithEvents lblDrivingLicenceValid As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbDriverID As TextBox
    Friend WithEvents tbDrivingLicense As TextBox
    Friend WithEvents tbLegalWorker As TextBox
    Friend WithEvents dtpLicenseValidDate As DateTimePicker
    Friend WithEvents cmbFullName As ComboBox
    Friend WithEvents cbActive As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
