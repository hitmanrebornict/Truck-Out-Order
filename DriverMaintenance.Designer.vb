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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DriverMaintenance))
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCompanyNameHeader = New System.Windows.Forms.Label()
        Me.lblUserMaintenance = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUserDetails = New System.Windows.Forms.Label()
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
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Controls.Add(Me.lblFullName)
        Me.Panel3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(113, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1039, 678)
        Me.Panel3.TabIndex = 3
        '
        'cmbFullName
        '
        Me.cmbFullName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFullName.FormattingEnabled = True
        Me.cmbFullName.Location = New System.Drawing.Point(122, 160)
        Me.cmbFullName.Name = "cmbFullName"
        Me.cmbFullName.Size = New System.Drawing.Size(660, 27)
        Me.cmbFullName.TabIndex = 0
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 203)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1022, 230)
        Me.TableLayoutPanel1.TabIndex = 1
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
        Me.lblPmCode.Location = New System.Drawing.Point(4, 58)
        Me.lblPmCode.Name = "lblPmCode"
        Me.lblPmCode.Size = New System.Drawing.Size(99, 24)
        Me.lblPmCode.TabIndex = 2
        Me.lblPmCode.Text = "PM Code:"
        '
        'tbIcNumber
        '
        Me.tbIcNumber.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIcNumber.Location = New System.Drawing.Point(259, 4)
        Me.tbIcNumber.Name = "tbIcNumber"
        Me.tbIcNumber.Size = New System.Drawing.Size(248, 26)
        Me.tbIcNumber.TabIndex = 2
        '
        'tbPmCode
        '
        Me.tbPmCode.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPmCode.Location = New System.Drawing.Point(259, 61)
        Me.tbPmCode.Name = "tbPmCode"
        Me.tbPmCode.Size = New System.Drawing.Size(248, 26)
        Me.tbPmCode.TabIndex = 3
        '
        'lblPmRegistrationPlate
        '
        Me.lblPmRegistrationPlate.AutoSize = True
        Me.lblPmRegistrationPlate.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPmRegistrationPlate.Location = New System.Drawing.Point(4, 115)
        Me.lblPmRegistrationPlate.Name = "lblPmRegistrationPlate"
        Me.lblPmRegistrationPlate.Size = New System.Drawing.Size(209, 24)
        Me.lblPmRegistrationPlate.TabIndex = 3
        Me.lblPmRegistrationPlate.Text = "PM Registration Plate:"
        '
        'lblDriverID
        '
        Me.lblDriverID.AutoSize = True
        Me.lblDriverID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverID.Location = New System.Drawing.Point(4, 172)
        Me.lblDriverID.Name = "lblDriverID"
        Me.lblDriverID.Size = New System.Drawing.Size(95, 24)
        Me.lblDriverID.TabIndex = 9
        Me.lblDriverID.Text = "Driver ID:"
        '
        'tbDriverID
        '
        Me.tbDriverID.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDriverID.Location = New System.Drawing.Point(259, 175)
        Me.tbDriverID.Name = "tbDriverID"
        Me.tbDriverID.Size = New System.Drawing.Size(248, 26)
        Me.tbDriverID.TabIndex = 5
        '
        'lblDrivingLicense
        '
        Me.lblDrivingLicense.AutoSize = True
        Me.lblDrivingLicense.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrivingLicense.Location = New System.Drawing.Point(514, 1)
        Me.lblDrivingLicense.Name = "lblDrivingLicense"
        Me.lblDrivingLicense.Size = New System.Drawing.Size(151, 24)
        Me.lblDrivingLicense.TabIndex = 10
        Me.lblDrivingLicense.Text = "Driving Licence:"
        '
        'tbDrivingLicense
        '
        Me.tbDrivingLicense.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDrivingLicense.Location = New System.Drawing.Point(769, 4)
        Me.tbDrivingLicense.Name = "tbDrivingLicense"
        Me.tbDrivingLicense.Size = New System.Drawing.Size(249, 26)
        Me.tbDrivingLicense.TabIndex = 6
        '
        'lblDrivingLicenceValid
        '
        Me.lblDrivingLicenceValid.AutoSize = True
        Me.lblDrivingLicenceValid.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrivingLicenceValid.Location = New System.Drawing.Point(514, 58)
        Me.lblDrivingLicenceValid.Name = "lblDrivingLicenceValid"
        Me.lblDrivingLicenceValid.Size = New System.Drawing.Size(219, 24)
        Me.lblDrivingLicenceValid.TabIndex = 11
        Me.lblDrivingLicenceValid.Text = "Driving Licence Validity:"
        '
        'dtpLicenseValidDate
        '
        Me.dtpLicenseValidDate.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLicenseValidDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLicenseValidDate.Location = New System.Drawing.Point(769, 61)
        Me.dtpLicenseValidDate.Name = "dtpLicenseValidDate"
        Me.dtpLicenseValidDate.Size = New System.Drawing.Size(249, 26)
        Me.dtpLicenseValidDate.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(514, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(193, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Legal Worker? (Y/N)"
        '
        'tbLegalWorker
        '
        Me.tbLegalWorker.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLegalWorker.Location = New System.Drawing.Point(769, 118)
        Me.tbLegalWorker.Name = "tbLegalWorker"
        Me.tbLegalWorker.Size = New System.Drawing.Size(249, 26)
        Me.tbLegalWorker.TabIndex = 8
        '
        'cbActive
        '
        Me.cbActive.AutoSize = True
        Me.cbActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActive.Location = New System.Drawing.Point(769, 175)
        Me.cbActive.Name = "cbActive"
        Me.cbActive.Size = New System.Drawing.Size(15, 14)
        Me.cbActive.TabIndex = 9
        Me.cbActive.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(514, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Active:"
        '
        'tbRegistrationPlate
        '
        Me.tbRegistrationPlate.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRegistrationPlate.Location = New System.Drawing.Point(259, 118)
        Me.tbRegistrationPlate.Name = "tbRegistrationPlate"
        Me.tbRegistrationPlate.Size = New System.Drawing.Size(248, 26)
        Me.tbRegistrationPlate.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(938, 638)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 30)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(842, 638)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 30)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Save"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(746, 638)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 30)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(10, 160)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(106, 24)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.lblCompanyNameHeader)
        Me.Panel1.Controls.Add(Me.lblUserMaintenance)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblUserDetails)
        Me.Panel1.Location = New System.Drawing.Point(113, 3)
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
        'lblUserMaintenance
        '
        Me.lblUserMaintenance.AutoSize = True
        Me.lblUserMaintenance.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserMaintenance.Location = New System.Drawing.Point(838, 51)
        Me.lblUserMaintenance.Name = "lblUserMaintenance"
        Me.lblUserMaintenance.Size = New System.Drawing.Size(198, 24)
        Me.lblUserMaintenance.TabIndex = 0
        Me.lblUserMaintenance.Text = "Driver Maintenance"
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
        'DriverMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.Untitled_design__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
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
    Friend WithEvents btnNew As Button
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCompanyNameHeader As Label
    Friend WithEvents lblUserMaintenance As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUserDetails As Label
End Class
