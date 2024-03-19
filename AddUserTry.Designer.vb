<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUserTry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUserTry))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cmbSelectUserID = New System.Windows.Forms.ComboBox()
        Me.cmbSelectDepartmentID = New System.Windows.Forms.ComboBox()
        Me.tbSelectUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.cbAdmin = New System.Windows.Forms.CheckBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.cbActive = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbRoleID = New System.Windows.Forms.ComboBox()
        Me.lblUserMaintenance = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCompanyNameHeader = New System.Windows.Forms.Label()
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
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnAddUser)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(179, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(907, 669)
        Me.Panel3.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(790, 627)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 30)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(671, 627)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 30)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Save"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(552, 627)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(110, 30)
        Me.btnAddUser.TabIndex = 13
        Me.btnAddUser.Text = "New"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblUserID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblUsername, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDepartment, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSelectUserID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSelectDepartmentID, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbSelectUsername, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPassword, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPassword, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAdmin, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cbAdmin, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblActive, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cbActive, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 126)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(904, 330)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(4, 1)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(103, 28)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "User ID:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(4, 55)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(136, 28)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username:"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(4, 109)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(151, 28)
        Me.lblDepartment.TabIndex = 7
        Me.lblDepartment.Text = "Department:"
        '
        'cmbSelectUserID
        '
        Me.cmbSelectUserID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectUserID.FormattingEnabled = True
        Me.cmbSelectUserID.Location = New System.Drawing.Point(455, 4)
        Me.cmbSelectUserID.Name = "cmbSelectUserID"
        Me.cmbSelectUserID.Size = New System.Drawing.Size(325, 31)
        Me.cmbSelectUserID.TabIndex = 1
        '
        'cmbSelectDepartmentID
        '
        Me.cmbSelectDepartmentID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectDepartmentID.FormattingEnabled = True
        Me.cmbSelectDepartmentID.Items.AddRange(New Object() {"IT", "Shipping", "Security", "Warehouse", "Warehouse Checking", "super user"})
        Me.cmbSelectDepartmentID.Location = New System.Drawing.Point(455, 112)
        Me.cmbSelectDepartmentID.Name = "cmbSelectDepartmentID"
        Me.cmbSelectDepartmentID.Size = New System.Drawing.Size(325, 31)
        Me.cmbSelectDepartmentID.TabIndex = 3
        '
        'tbSelectUsername
        '
        Me.tbSelectUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSelectUsername.Location = New System.Drawing.Point(455, 58)
        Me.tbSelectUsername.Name = "tbSelectUsername"
        Me.tbSelectUsername.Size = New System.Drawing.Size(325, 30)
        Me.tbSelectUsername.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(4, 163)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(131, 28)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Text = "Password:"
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(455, 166)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(325, 30)
        Me.tbPassword.TabIndex = 4
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(4, 217)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(92, 28)
        Me.lblAdmin.TabIndex = 18
        Me.lblAdmin.Text = "Admin:"
        '
        'cbAdmin
        '
        Me.cbAdmin.AutoSize = True
        Me.cbAdmin.Location = New System.Drawing.Point(455, 220)
        Me.cbAdmin.Name = "cbAdmin"
        Me.cbAdmin.Size = New System.Drawing.Size(18, 17)
        Me.cbAdmin.TabIndex = 5
        Me.cbAdmin.UseVisualStyleBackColor = True
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActive.Location = New System.Drawing.Point(4, 271)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(87, 28)
        Me.lblActive.TabIndex = 21
        Me.lblActive.Text = "Active:"
        '
        'cbActive
        '
        Me.cbActive.AutoSize = True
        Me.cbActive.Location = New System.Drawing.Point(455, 274)
        Me.cbActive.Name = "cbActive"
        Me.cbActive.Size = New System.Drawing.Size(18, 17)
        Me.cbActive.TabIndex = 6
        Me.cbActive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1132, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 42)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Role_ID"
        Me.Label1.Visible = False
        '
        'cmbRoleID
        '
        Me.cmbRoleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoleID.FormattingEnabled = True
        Me.cmbRoleID.Location = New System.Drawing.Point(927, 508)
        Me.cmbRoleID.Name = "cmbRoleID"
        Me.cmbRoleID.Size = New System.Drawing.Size(325, 44)
        Me.cmbRoleID.TabIndex = 100
        Me.cmbRoleID.Visible = False
        '
        'lblUserMaintenance
        '
        Me.lblUserMaintenance.AutoSize = True
        Me.lblUserMaintenance.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserMaintenance.Location = New System.Drawing.Point(667, 51)
        Me.lblUserMaintenance.Name = "lblUserMaintenance"
        Me.lblUserMaintenance.Size = New System.Drawing.Size(227, 30)
        Me.lblUserMaintenance.TabIndex = 0
        Me.lblUserMaintenance.Text = "User Maintenance"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.lblCompanyNameHeader)
        Me.Panel1.Controls.Add(Me.lblUserMaintenance)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblUserDetails)
        Me.Panel1.Location = New System.Drawing.Point(179, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 97)
        Me.Panel1.TabIndex = 139
        '
        'lblCompanyNameHeader
        '
        Me.lblCompanyNameHeader.AutoSize = True
        Me.lblCompanyNameHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyNameHeader.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyNameHeader.Location = New System.Drawing.Point(147, 13)
        Me.lblCompanyNameHeader.Name = "lblCompanyNameHeader"
        Me.lblCompanyNameHeader.Size = New System.Drawing.Size(231, 29)
        Me.lblCompanyNameHeader.TabIndex = 138
        Me.lblCompanyNameHeader.Text = "lblCompanyHeader"
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
        Me.lblUserDetails.Size = New System.Drawing.Size(180, 30)
        Me.lblUserDetails.TabIndex = 129
        Me.lblUserDetails.Text = "lblUserDetails"
        '
        'AddUserTry
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.Untitled_design__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRoleID)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "AddUserTry"
        Me.Text = "TOO System"
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbRoleID As ComboBox
    Friend WithEvents lblUserMaintenance As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents cbActive As CheckBox
    Friend WithEvents cmbSelectUserID As ComboBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lblActive As Label
    Friend WithEvents cmbSelectDepartmentID As ComboBox
    Friend WithEvents lblAdmin As Label
    Friend WithEvents tbSelectUsername As TextBox
    Friend WithEvents cbAdmin As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCompanyNameHeader As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAddUser As Button
End Class
