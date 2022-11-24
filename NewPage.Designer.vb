<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewPage))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLoadingPortFullName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCompanyFullName = New System.Windows.Forms.Label()
        Me.lblCompanyShort = New System.Windows.Forms.Label()
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.cmbContainerSize = New System.Windows.Forms.ComboBox()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.tbInvoice = New System.Windows.Forms.TextBox()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.tbProduct = New System.Windows.Forms.TextBox()
        Me.lblContainerSize = New System.Windows.Forms.Label()
        Me.lblShippingLine = New System.Windows.Forms.Label()
        Me.tbShippingLine = New System.Windows.Forms.TextBox()
        Me.lblLoadingPort = New System.Windows.Forms.Label()
        Me.cmbLoadingPort = New System.Windows.Forms.ComboBox()
        Me.lblDDB = New System.Windows.Forms.Label()
        Me.cmbDDB = New System.Windows.Forms.ComboBox()
        Me.dtpSCT = New System.Windows.Forms.DateTimePicker()
        Me.dtpSCD = New System.Windows.Forms.DateTimePicker()
        Me.lblHaulier = New System.Windows.Forms.Label()
        Me.tbHaulier = New System.Windows.Forms.TextBox()
        Me.lblLoadingBay = New System.Windows.Forms.Label()
        Me.lblWarehouseLocation = New System.Windows.Forms.Label()
        Me.tbLoadingBay = New System.Windows.Forms.TextBox()
        Me.cmbWarehouseLocation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSCT = New System.Windows.Forms.Label()
        Me.lblSCD = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbInternalSealNo = New System.Windows.Forms.TextBox()
        Me.tbLinerSealNo = New System.Windows.Forms.TextBox()
        Me.tbContainerNo = New System.Windows.Forms.TextBox()
        Me.lblContainerNo = New System.Windows.Forms.Label()
        Me.lblEsSealNo = New System.Windows.Forms.Label()
        Me.lblLinerSealNo = New System.Windows.Forms.Label()
        Me.lblInternalSealNo = New System.Windows.Forms.Label()
        Me.lblTemporarySealNo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbEsSealNo = New System.Windows.Forms.ComboBox()
        Me.tbEsSealNo = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbTemporarySealNo = New System.Windows.Forms.TextBox()
        Me.cmbCheckTempSealNo = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTooNumber = New System.Windows.Forms.Label()
        Me.lblTruckOutNumber = New System.Windows.Forms.Label()
        Me.lblUserDetails = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCompanyNameHeader = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(95, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1075, 680)
        Me.Panel3.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.37828!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.09363!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.40586!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblLoadingPortFullName, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblCompanyFullName, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblCompanyShort, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbCompany, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbContainerSize, 3, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblInvoice, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.tbInvoice, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblProduct, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.tbProduct, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lblContainerSize, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblShippingLine, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.tbShippingLine, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.lblLoadingPort, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbLoadingPort, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblDDB, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbDDB, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpSCT, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpSCD, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblHaulier, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.tbHaulier, 3, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lblLoadingBay, 2, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.lblWarehouseLocation, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.tbLoadingBay, 3, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbWarehouseLocation, 3, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSCT, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSCD, 0, 2)
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 111)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1069, 297)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'lblLoadingPortFullName
        '
        Me.lblLoadingPortFullName.AutoSize = True
        Me.lblLoadingPortFullName.Location = New System.Drawing.Point(803, 45)
        Me.lblLoadingPortFullName.Name = "lblLoadingPortFullName"
        Me.lblLoadingPortFullName.Size = New System.Drawing.Size(58, 19)
        Me.lblLoadingPortFullName.TabIndex = 130
        Me.lblLoadingPortFullName.Text = "Label4"
        Me.lblLoadingPortFullName.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(511, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 22)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Loading Port Full Name:"
        '
        'lblCompanyFullName
        '
        Me.lblCompanyFullName.AutoSize = True
        Me.lblCompanyFullName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyFullName.Location = New System.Drawing.Point(243, 45)
        Me.lblCompanyFullName.Name = "lblCompanyFullName"
        Me.lblCompanyFullName.Size = New System.Drawing.Size(58, 19)
        Me.lblCompanyFullName.TabIndex = 128
        Me.lblCompanyFullName.Text = "Label2"
        Me.lblCompanyFullName.Visible = False
        '
        'lblCompanyShort
        '
        Me.lblCompanyShort.AutoSize = True
        Me.lblCompanyShort.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyShort.Location = New System.Drawing.Point(4, 1)
        Me.lblCompanyShort.Name = "lblCompanyShort"
        Me.lblCompanyShort.Size = New System.Drawing.Size(104, 22)
        Me.lblCompanyShort.TabIndex = 115
        Me.lblCompanyShort.Text = "Company :"
        '
        'cmbCompany
        '
        Me.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompany.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(243, 4)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(220, 27)
        Me.cmbCompany.TabIndex = 1
        '
        'cmbContainerSize
        '
        Me.cmbContainerSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContainerSize.FormattingEnabled = True
        Me.cmbContainerSize.Location = New System.Drawing.Point(803, 136)
        Me.cmbContainerSize.Name = "cmbContainerSize"
        Me.cmbContainerSize.Size = New System.Drawing.Size(256, 27)
        Me.cmbContainerSize.TabIndex = 9
        '
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.Location = New System.Drawing.Point(4, 133)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(77, 22)
        Me.lblInvoice.TabIndex = 105
        Me.lblInvoice.Text = "Invoice:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbInvoice
        '
        Me.tbInvoice.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInvoice.Location = New System.Drawing.Point(243, 136)
        Me.tbInvoice.Name = "tbInvoice"
        Me.tbInvoice.Size = New System.Drawing.Size(218, 26)
        Me.tbInvoice.TabIndex = 3
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(4, 177)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(82, 22)
        Me.lblProduct.TabIndex = 106
        Me.lblProduct.Text = "Product:"
        '
        'tbProduct
        '
        Me.tbProduct.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProduct.Location = New System.Drawing.Point(243, 180)
        Me.tbProduct.Name = "tbProduct"
        Me.tbProduct.Size = New System.Drawing.Size(218, 26)
        Me.tbProduct.TabIndex = 4
        '
        'lblContainerSize
        '
        Me.lblContainerSize.AutoSize = True
        Me.lblContainerSize.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainerSize.Location = New System.Drawing.Point(511, 133)
        Me.lblContainerSize.Name = "lblContainerSize"
        Me.lblContainerSize.Size = New System.Drawing.Size(142, 22)
        Me.lblContainerSize.TabIndex = 117
        Me.lblContainerSize.Text = "Container Size:"
        '
        'lblShippingLine
        '
        Me.lblShippingLine.AutoSize = True
        Me.lblShippingLine.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingLine.Location = New System.Drawing.Point(4, 221)
        Me.lblShippingLine.Name = "lblShippingLine"
        Me.lblShippingLine.Size = New System.Drawing.Size(133, 22)
        Me.lblShippingLine.TabIndex = 107
        Me.lblShippingLine.Text = "Shipping Line:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbShippingLine
        '
        Me.tbShippingLine.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbShippingLine.Location = New System.Drawing.Point(243, 224)
        Me.tbShippingLine.Name = "tbShippingLine"
        Me.tbShippingLine.Size = New System.Drawing.Size(218, 26)
        Me.tbShippingLine.TabIndex = 5
        '
        'lblLoadingPort
        '
        Me.lblLoadingPort.AutoSize = True
        Me.lblLoadingPort.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadingPort.Location = New System.Drawing.Point(511, 1)
        Me.lblLoadingPort.Name = "lblLoadingPort"
        Me.lblLoadingPort.Size = New System.Drawing.Size(125, 22)
        Me.lblLoadingPort.TabIndex = 119
        Me.lblLoadingPort.Text = "Loading Port:"
        '
        'cmbLoadingPort
        '
        Me.cmbLoadingPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoadingPort.FormattingEnabled = True
        Me.cmbLoadingPort.Location = New System.Drawing.Point(803, 4)
        Me.cmbLoadingPort.Name = "cmbLoadingPort"
        Me.cmbLoadingPort.Size = New System.Drawing.Size(256, 27)
        Me.cmbLoadingPort.TabIndex = 7
        '
        'lblDDB
        '
        Me.lblDDB.AutoSize = True
        Me.lblDDB.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDDB.Location = New System.Drawing.Point(4, 265)
        Me.lblDDB.Name = "lblDDB"
        Me.lblDDB.Size = New System.Drawing.Size(61, 22)
        Me.lblDDB.TabIndex = 113
        Me.lblDDB.Text = "DDB :"
        '
        'cmbDDB
        '
        Me.cmbDDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDDB.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDDB.FormattingEnabled = True
        Me.cmbDDB.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbDDB.Location = New System.Drawing.Point(243, 268)
        Me.cmbDDB.Name = "cmbDDB"
        Me.cmbDDB.Size = New System.Drawing.Size(218, 27)
        Me.cmbDDB.TabIndex = 6
        '
        'dtpSCT
        '
        Me.dtpSCT.CustomFormat = "HH:mm:ss"
        Me.dtpSCT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSCT.Location = New System.Drawing.Point(803, 92)
        Me.dtpSCT.Name = "dtpSCT"
        Me.dtpSCT.ShowUpDown = True
        Me.dtpSCT.Size = New System.Drawing.Size(256, 26)
        Me.dtpSCT.TabIndex = 8
        '
        'dtpSCD
        '
        Me.dtpSCD.CustomFormat = """ """
        Me.dtpSCD.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSCD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSCD.Location = New System.Drawing.Point(243, 92)
        Me.dtpSCD.Name = "dtpSCD"
        Me.dtpSCD.Size = New System.Drawing.Size(218, 26)
        Me.dtpSCD.TabIndex = 2
        '
        'lblHaulier
        '
        Me.lblHaulier.AutoSize = True
        Me.lblHaulier.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHaulier.Location = New System.Drawing.Point(511, 177)
        Me.lblHaulier.Name = "lblHaulier"
        Me.lblHaulier.Size = New System.Drawing.Size(76, 22)
        Me.lblHaulier.TabIndex = 118
        Me.lblHaulier.Text = "Haulier:"
        '
        'tbHaulier
        '
        Me.tbHaulier.Location = New System.Drawing.Point(803, 180)
        Me.tbHaulier.Name = "tbHaulier"
        Me.tbHaulier.Size = New System.Drawing.Size(256, 26)
        Me.tbHaulier.TabIndex = 10
        Me.tbHaulier.Text = "PHD"
        '
        'lblLoadingBay
        '
        Me.lblLoadingBay.AutoSize = True
        Me.lblLoadingBay.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadingBay.Location = New System.Drawing.Point(511, 265)
        Me.lblLoadingBay.Name = "lblLoadingBay"
        Me.lblLoadingBay.Size = New System.Drawing.Size(124, 22)
        Me.lblLoadingBay.TabIndex = 121
        Me.lblLoadingBay.Text = "Loading Bay:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblWarehouseLocation
        '
        Me.lblWarehouseLocation.AutoSize = True
        Me.lblWarehouseLocation.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarehouseLocation.Location = New System.Drawing.Point(511, 221)
        Me.lblWarehouseLocation.Name = "lblWarehouseLocation"
        Me.lblWarehouseLocation.Size = New System.Drawing.Size(193, 22)
        Me.lblWarehouseLocation.TabIndex = 120
        Me.lblWarehouseLocation.Text = "Warehouse Location:"
        '
        'tbLoadingBay
        '
        Me.tbLoadingBay.Location = New System.Drawing.Point(803, 268)
        Me.tbLoadingBay.Name = "tbLoadingBay"
        Me.tbLoadingBay.Size = New System.Drawing.Size(256, 26)
        Me.tbLoadingBay.TabIndex = 12
        '
        'cmbWarehouseLocation
        '
        Me.cmbWarehouseLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWarehouseLocation.FormattingEnabled = True
        Me.cmbWarehouseLocation.Location = New System.Drawing.Point(803, 224)
        Me.cmbWarehouseLocation.Name = "cmbWarehouseLocation"
        Me.cmbWarehouseLocation.Size = New System.Drawing.Size(256, 27)
        Me.cmbWarehouseLocation.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 22)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Company Full Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSCT
        '
        Me.lblSCT.AutoSize = True
        Me.lblSCT.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSCT.Location = New System.Drawing.Point(511, 89)
        Me.lblSCT.Name = "lblSCT"
        Me.lblSCT.Size = New System.Drawing.Size(214, 22)
        Me.lblSCT.TabIndex = 104
        Me.lblSCT.Text = "Shipment Closing Time:"
        '
        'lblSCD
        '
        Me.lblSCD.AutoSize = True
        Me.lblSCD.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSCD.Location = New System.Drawing.Point(4, 89)
        Me.lblSCD.Name = "lblSCD"
        Me.lblSCD.Size = New System.Drawing.Size(213, 22)
        Me.lblSCD.TabIndex = 103
        Me.lblSCD.Text = "Shipment Closing Date:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(984, 646)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 28)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(900, 646)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 28)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "Post"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.03181!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.10647!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.04175!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.45929!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbInternalSealNo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbLinerSealNo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbContainerNo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblContainerNo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEsSealNo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLinerSealNo, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInternalSealNo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTemporarySealNo, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 414)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.16807!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.84874!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.16807!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.16807!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(507, 239)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'tbInternalSealNo
        '
        Me.tbInternalSealNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbInternalSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInternalSealNo.Location = New System.Drawing.Point(243, 144)
        Me.tbInternalSealNo.Name = "tbInternalSealNo"
        Me.tbInternalSealNo.Size = New System.Drawing.Size(255, 26)
        Me.tbInternalSealNo.TabIndex = 35
        '
        'tbLinerSealNo
        '
        Me.tbLinerSealNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbLinerSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLinerSealNo.Location = New System.Drawing.Point(243, 102)
        Me.tbLinerSealNo.Name = "tbLinerSealNo"
        Me.tbLinerSealNo.Size = New System.Drawing.Size(255, 26)
        Me.tbLinerSealNo.TabIndex = 34
        '
        'tbContainerNo
        '
        Me.tbContainerNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbContainerNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContainerNo.Location = New System.Drawing.Point(243, 4)
        Me.tbContainerNo.Name = "tbContainerNo"
        Me.tbContainerNo.Size = New System.Drawing.Size(255, 26)
        Me.tbContainerNo.TabIndex = 31
        '
        'lblContainerNo
        '
        Me.lblContainerNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainerNo.Location = New System.Drawing.Point(4, 1)
        Me.lblContainerNo.Name = "lblContainerNo"
        Me.lblContainerNo.Size = New System.Drawing.Size(188, 34)
        Me.lblContainerNo.TabIndex = 27
        Me.lblContainerNo.Text = "Container No."
        '
        'lblEsSealNo
        '
        Me.lblEsSealNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsSealNo.Location = New System.Drawing.Point(4, 48)
        Me.lblEsSealNo.Name = "lblEsSealNo"
        Me.lblEsSealNo.Size = New System.Drawing.Size(187, 33)
        Me.lblEsSealNo.TabIndex = 28
        Me.lblEsSealNo.Text = "ES Seal No."
        '
        'lblLinerSealNo
        '
        Me.lblLinerSealNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinerSealNo.Location = New System.Drawing.Point(4, 99)
        Me.lblLinerSealNo.Name = "lblLinerSealNo"
        Me.lblLinerSealNo.Size = New System.Drawing.Size(188, 21)
        Me.lblLinerSealNo.TabIndex = 29
        Me.lblLinerSealNo.Text = "Liner's Seal No."
        '
        'lblInternalSealNo
        '
        Me.lblInternalSealNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternalSealNo.Location = New System.Drawing.Point(4, 141)
        Me.lblInternalSealNo.Name = "lblInternalSealNo"
        Me.lblInternalSealNo.Size = New System.Drawing.Size(215, 34)
        Me.lblInternalSealNo.TabIndex = 30
        Me.lblInternalSealNo.Text = "Internal Seal No."
        '
        'lblTemporarySealNo
        '
        Me.lblTemporarySealNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemporarySealNo.Location = New System.Drawing.Point(4, 188)
        Me.lblTemporarySealNo.Name = "lblTemporarySealNo"
        Me.lblTemporarySealNo.Size = New System.Drawing.Size(232, 37)
        Me.lblTemporarySealNo.TabIndex = 31
        Me.lblTemporarySealNo.Text = "Temporary Seal No."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmbEsSealNo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbEsSealNo, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(243, 51)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(259, 40)
        Me.TableLayoutPanel2.TabIndex = 53
        '
        'cmbEsSealNo
        '
        Me.cmbEsSealNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEsSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEsSealNo.FormattingEnabled = True
        Me.cmbEsSealNo.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbEsSealNo.Location = New System.Drawing.Point(4, 4)
        Me.cmbEsSealNo.Name = "cmbEsSealNo"
        Me.cmbEsSealNo.Size = New System.Drawing.Size(122, 27)
        Me.cmbEsSealNo.TabIndex = 32
        '
        'tbEsSealNo
        '
        Me.tbEsSealNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEsSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEsSealNo.Location = New System.Drawing.Point(133, 4)
        Me.tbEsSealNo.Name = "tbEsSealNo"
        Me.tbEsSealNo.Size = New System.Drawing.Size(122, 26)
        Me.tbEsSealNo.TabIndex = 33
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.tbTemporarySealNo, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cmbCheckTempSealNo, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(243, 191)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(259, 41)
        Me.TableLayoutPanel5.TabIndex = 137
        '
        'tbTemporarySealNo
        '
        Me.tbTemporarySealNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTemporarySealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTemporarySealNo.Location = New System.Drawing.Point(133, 4)
        Me.tbTemporarySealNo.Name = "tbTemporarySealNo"
        Me.tbTemporarySealNo.Size = New System.Drawing.Size(122, 26)
        Me.tbTemporarySealNo.TabIndex = 37
        '
        'cmbCheckTempSealNo
        '
        Me.cmbCheckTempSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCheckTempSealNo.FormattingEnabled = True
        Me.cmbCheckTempSealNo.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbCheckTempSealNo.Location = New System.Drawing.Point(4, 4)
        Me.cmbCheckTempSealNo.Name = "cmbCheckTempSealNo"
        Me.cmbCheckTempSealNo.Size = New System.Drawing.Size(122, 27)
        Me.cmbCheckTempSealNo.TabIndex = 36
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
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblTooNumber, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblTruckOutNumber, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(672, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(400, 37)
        Me.TableLayoutPanel4.TabIndex = 135
        '
        'lblTooNumber
        '
        Me.lblTooNumber.AutoSize = True
        Me.lblTooNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTooNumber.Location = New System.Drawing.Point(251, 1)
        Me.lblTooNumber.Name = "lblTooNumber"
        Me.lblTooNumber.Size = New System.Drawing.Size(74, 24)
        Me.lblTooNumber.TabIndex = 135
        Me.lblTooNumber.Text = "Label2"
        '
        'lblTruckOutNumber
        '
        Me.lblTruckOutNumber.AutoSize = True
        Me.lblTruckOutNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblTruckOutNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTruckOutNumber.Location = New System.Drawing.Point(4, 1)
        Me.lblTruckOutNumber.Name = "lblTruckOutNumber"
        Me.lblTruckOutNumber.Size = New System.Drawing.Size(192, 24)
        Me.lblTruckOutNumber.TabIndex = 134
        Me.lblTruckOutNumber.Text = "Truck Out Number:"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.lblCompanyNameHeader)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Controls.Add(Me.lblUserDetails)
        Me.Panel1.Location = New System.Drawing.Point(95, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 98)
        Me.Panel1.TabIndex = 137
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
        'NewPage
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
        Me.Name = "NewPage"
        Me.Text = "TOO System"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbTemporarySealNo As TextBox
    Friend WithEvents tbInternalSealNo As TextBox
    Friend WithEvents tbLinerSealNo As TextBox
    Friend WithEvents tbContainerNo As TextBox
    Friend WithEvents lblContainerNo As Label
    Friend WithEvents lblEsSealNo As Label
    Friend WithEvents lblLinerSealNo As Label
    Friend WithEvents lblInternalSealNo As Label
    Friend WithEvents lblTemporarySealNo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmbEsSealNo As ComboBox
    Friend WithEvents tbEsSealNo As TextBox
    Friend WithEvents cmbLoadingPort As ComboBox
    Friend WithEvents cmbContainerSize As ComboBox
    Friend WithEvents cmbWarehouseLocation As ComboBox
    Friend WithEvents tbLoadingBay As TextBox
    Friend WithEvents tbHaulier As TextBox
    Friend WithEvents lblLoadingBay As Label
    Friend WithEvents lblWarehouseLocation As Label
    Friend WithEvents lblLoadingPort As Label
    Friend WithEvents lblHaulier As Label
    Friend WithEvents lblContainerSize As Label
    Friend WithEvents cmbCompany As ComboBox
    Friend WithEvents lblCompanyShort As Label
    Friend WithEvents cmbDDB As ComboBox
    Friend WithEvents lblDDB As Label
    Friend WithEvents dtpSCT As DateTimePicker
    Friend WithEvents dtpSCD As DateTimePicker
    Friend WithEvents tbShippingLine As TextBox
    Friend WithEvents tbProduct As TextBox
    Friend WithEvents lblShippingLine As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblInvoice As Label
    Friend WithEvents lblSCT As Label
    Friend WithEvents lblSCD As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblTruckOutNumber As Label
    Friend WithEvents lblTooNumber As Label
    Friend WithEvents tbInvoice As TextBox
    Friend WithEvents lblLoadingPortFullName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCompanyFullName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents cmbCheckTempSealNo As ComboBox
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblCompanyNameHeader As Label
End Class
