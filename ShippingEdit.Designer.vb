﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShippingEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShippingEdit))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPortFullName = New System.Windows.Forms.Label()
        Me.lblLoadingPortFullName = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.cmbContainerSize = New System.Windows.Forms.ComboBox()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.tbProduct = New System.Windows.Forms.TextBox()
        Me.lblContainerSize = New System.Windows.Forms.Label()
        Me.lblShippingLine = New System.Windows.Forms.Label()
        Me.tbShippingLine = New System.Windows.Forms.TextBox()
        Me.lblLoadingPort = New System.Windows.Forms.Label()
        Me.cmbLoadingPort = New System.Windows.Forms.ComboBox()
        Me.lblSCT = New System.Windows.Forms.Label()
        Me.lblSCD = New System.Windows.Forms.Label()
        Me.lblSendToCompany = New System.Windows.Forms.Label()
        Me.tbSendToCompany = New System.Windows.Forms.TextBox()
        Me.dtpSCD = New System.Windows.Forms.DateTimePicker()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblDDB = New System.Windows.Forms.Label()
        Me.cmbDDB = New System.Windows.Forms.ComboBox()
        Me.dtpSCT = New System.Windows.Forms.DateTimePicker()
        Me.lblHaulier = New System.Windows.Forms.Label()
        Me.tbHaulier = New System.Windows.Forms.TextBox()
        Me.lblLoadingBay = New System.Windows.Forms.Label()
        Me.lblWarehouseLocation = New System.Windows.Forms.Label()
        Me.tbLoadingBay = New System.Windows.Forms.TextBox()
        Me.cmbWarehouseLocation = New System.Windows.Forms.ComboBox()
        Me.tbInvoice = New System.Windows.Forms.TextBox()
        Me.lblCompanyFullName = New System.Windows.Forms.Label()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnSave1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCancel1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtpRTT = New System.Windows.Forms.DateTimePicker()
        Me.dtpLCD = New System.Windows.Forms.DateTimePicker()
        Me.dtpRTD = New System.Windows.Forms.DateTimePicker()
        Me.dtpLCT = New System.Windows.Forms.DateTimePicker()
        Me.lblRTD = New System.Windows.Forms.Label()
        Me.lblLCT = New System.Windows.Forms.Label()
        Me.lblLCD = New System.Windows.Forms.Label()
        Me.lblRTT = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbSecurityPost = New System.Windows.Forms.CheckBox()
        Me.cbShippingPost = New System.Windows.Forms.CheckBox()
        Me.cbWarehousePost = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbInternalSealNo = New System.Windows.Forms.TextBox()
        Me.tbLinerSealNo = New System.Windows.Forms.TextBox()
        Me.tbContainerNo = New System.Windows.Forms.TextBox()
        Me.lblEsSealNo = New System.Windows.Forms.Label()
        Me.lblLinerSealNo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbEsSealNo = New System.Windows.Forms.ComboBox()
        Me.tbEsSealNo = New System.Windows.Forms.TextBox()
        Me.lblInternalSealNo = New System.Windows.Forms.Label()
        Me.lblTemporarySealNo = New System.Windows.Forms.Label()
        Me.lblContainerNo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbTempSeal = New System.Windows.Forms.TextBox()
        Me.cmbCheckTempSealNo = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTooNumber = New System.Windows.Forms.Label()
        Me.lblTruckOutNumber = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCompanyNameHeader = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUserDetails = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel3.Controls.Add(Me.btnPost)
        Me.Panel3.Controls.Add(Me.btnSave1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.btnCancel1)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel6)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Location = New System.Drawing.Point(13, 5)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1238, 734)
        Me.Panel3.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.73663!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.73251!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.25103!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.17695!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblPortFullName, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblLoadingPortFullName, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblCompany, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbCompany, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbContainerSize, 3, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblInvoice, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblProduct, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.tbProduct, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lblContainerSize, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblShippingLine, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.tbShippingLine, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.lblLoadingPort, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbLoadingPort, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSCT, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSCD, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSendToCompany, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.tbSendToCompany, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpSCD, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblFullName, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblDDB, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbDDB, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpSCT, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblHaulier, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.tbHaulier, 3, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lblLoadingBay, 2, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.lblWarehouseLocation, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.tbLoadingBay, 3, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbWarehouseLocation, 3, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.tbInvoice, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblCompanyFullName, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(7, 124)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(973, 316)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'lblPortFullName
        '
        Me.lblPortFullName.AutoSize = True
        Me.lblPortFullName.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortFullName.Location = New System.Drawing.Point(514, 40)
        Me.lblPortFullName.Name = "lblPortFullName"
        Me.lblPortFullName.Size = New System.Drawing.Size(218, 22)
        Me.lblPortFullName.TabIndex = 134
        Me.lblPortFullName.Text = "Loading Port Full Name:"
        '
        'lblLoadingPortFullName
        '
        Me.lblLoadingPortFullName.AutoSize = True
        Me.lblLoadingPortFullName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadingPortFullName.Location = New System.Drawing.Point(740, 40)
        Me.lblLoadingPortFullName.Name = "lblLoadingPortFullName"
        Me.lblLoadingPortFullName.Size = New System.Drawing.Size(178, 19)
        Me.lblLoadingPortFullName.TabIndex = 132
        Me.lblLoadingPortFullName.Text = "Loading Port Full Name"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(4, 1)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(99, 22)
        Me.lblCompany.TabIndex = 115
        Me.lblCompany.Text = "Company:"
        '
        'cmbCompany
        '
        Me.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompany.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(225, 4)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(272, 27)
        Me.cmbCompany.TabIndex = 1
        '
        'cmbContainerSize
        '
        Me.cmbContainerSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContainerSize.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContainerSize.FormattingEnabled = True
        Me.cmbContainerSize.Location = New System.Drawing.Point(740, 121)
        Me.cmbContainerSize.Name = "cmbContainerSize"
        Me.cmbContainerSize.Size = New System.Drawing.Size(224, 27)
        Me.cmbContainerSize.TabIndex = 10
        '
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.Location = New System.Drawing.Point(4, 118)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(77, 22)
        Me.lblInvoice.TabIndex = 105
        Me.lblInvoice.Text = "Invoice:"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(4, 157)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(82, 22)
        Me.lblProduct.TabIndex = 106
        Me.lblProduct.Text = "Product:"
        '
        'tbProduct
        '
        Me.tbProduct.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProduct.Location = New System.Drawing.Point(225, 160)
        Me.tbProduct.Name = "tbProduct"
        Me.tbProduct.Size = New System.Drawing.Size(272, 26)
        Me.tbProduct.TabIndex = 4
        '
        'lblContainerSize
        '
        Me.lblContainerSize.AutoSize = True
        Me.lblContainerSize.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainerSize.Location = New System.Drawing.Point(514, 118)
        Me.lblContainerSize.Name = "lblContainerSize"
        Me.lblContainerSize.Size = New System.Drawing.Size(142, 22)
        Me.lblContainerSize.TabIndex = 117
        Me.lblContainerSize.Text = "Container Size:"
        '
        'lblShippingLine
        '
        Me.lblShippingLine.AutoSize = True
        Me.lblShippingLine.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingLine.Location = New System.Drawing.Point(4, 196)
        Me.lblShippingLine.Name = "lblShippingLine"
        Me.lblShippingLine.Size = New System.Drawing.Size(133, 22)
        Me.lblShippingLine.TabIndex = 107
        Me.lblShippingLine.Text = "Shipping Line:"
        '
        'tbShippingLine
        '
        Me.tbShippingLine.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbShippingLine.Location = New System.Drawing.Point(225, 199)
        Me.tbShippingLine.Name = "tbShippingLine"
        Me.tbShippingLine.Size = New System.Drawing.Size(272, 26)
        Me.tbShippingLine.TabIndex = 5
        '
        'lblLoadingPort
        '
        Me.lblLoadingPort.AutoSize = True
        Me.lblLoadingPort.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadingPort.Location = New System.Drawing.Point(514, 1)
        Me.lblLoadingPort.Name = "lblLoadingPort"
        Me.lblLoadingPort.Size = New System.Drawing.Size(125, 22)
        Me.lblLoadingPort.TabIndex = 119
        Me.lblLoadingPort.Text = "Loading Port:"
        '
        'cmbLoadingPort
        '
        Me.cmbLoadingPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoadingPort.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoadingPort.FormattingEnabled = True
        Me.cmbLoadingPort.Location = New System.Drawing.Point(740, 4)
        Me.cmbLoadingPort.Name = "cmbLoadingPort"
        Me.cmbLoadingPort.Size = New System.Drawing.Size(224, 27)
        Me.cmbLoadingPort.TabIndex = 8
        '
        'lblSCT
        '
        Me.lblSCT.AutoSize = True
        Me.lblSCT.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSCT.Location = New System.Drawing.Point(514, 79)
        Me.lblSCT.Name = "lblSCT"
        Me.lblSCT.Size = New System.Drawing.Size(214, 22)
        Me.lblSCT.TabIndex = 104
        Me.lblSCT.Text = "Shipment Closing Time:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSCD
        '
        Me.lblSCD.AutoSize = True
        Me.lblSCD.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSCD.Location = New System.Drawing.Point(4, 79)
        Me.lblSCD.Name = "lblSCD"
        Me.lblSCD.Size = New System.Drawing.Size(213, 22)
        Me.lblSCD.TabIndex = 103
        Me.lblSCD.Text = "Shipment Closing Date:"
        '
        'lblSendToCompany
        '
        Me.lblSendToCompany.AutoSize = True
        Me.lblSendToCompany.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSendToCompany.Location = New System.Drawing.Point(4, 274)
        Me.lblSendToCompany.Name = "lblSendToCompany"
        Me.lblSendToCompany.Size = New System.Drawing.Size(176, 22)
        Me.lblSendToCompany.TabIndex = 128
        Me.lblSendToCompany.Text = "Send To Company:"
        '
        'tbSendToCompany
        '
        Me.tbSendToCompany.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSendToCompany.Location = New System.Drawing.Point(225, 277)
        Me.tbSendToCompany.Name = "tbSendToCompany"
        Me.tbSendToCompany.Size = New System.Drawing.Size(272, 26)
        Me.tbSendToCompany.TabIndex = 7
        '
        'dtpSCD
        '
        Me.dtpSCD.CustomFormat = """ """
        Me.dtpSCD.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSCD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSCD.Location = New System.Drawing.Point(225, 82)
        Me.dtpSCD.Name = "dtpSCD"
        Me.dtpSCD.Size = New System.Drawing.Size(272, 26)
        Me.dtpSCD.TabIndex = 2
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(4, 40)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(192, 22)
        Me.lblFullName.TabIndex = 133
        Me.lblFullName.Text = "Company Full Name:"
        '
        'lblDDB
        '
        Me.lblDDB.AutoSize = True
        Me.lblDDB.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDDB.Location = New System.Drawing.Point(4, 235)
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
        Me.cmbDDB.Location = New System.Drawing.Point(225, 238)
        Me.cmbDDB.Name = "cmbDDB"
        Me.cmbDDB.Size = New System.Drawing.Size(272, 27)
        Me.cmbDDB.TabIndex = 6
        '
        'dtpSCT
        '
        Me.dtpSCT.CustomFormat = "HH:mm:ss"
        Me.dtpSCT.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSCT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSCT.Location = New System.Drawing.Point(740, 82)
        Me.dtpSCT.Name = "dtpSCT"
        Me.dtpSCT.ShowUpDown = True
        Me.dtpSCT.Size = New System.Drawing.Size(224, 26)
        Me.dtpSCT.TabIndex = 9
        '
        'lblHaulier
        '
        Me.lblHaulier.AutoSize = True
        Me.lblHaulier.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHaulier.Location = New System.Drawing.Point(514, 157)
        Me.lblHaulier.Name = "lblHaulier"
        Me.lblHaulier.Size = New System.Drawing.Size(76, 22)
        Me.lblHaulier.TabIndex = 118
        Me.lblHaulier.Text = "Haulier:"
        '
        'tbHaulier
        '
        Me.tbHaulier.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHaulier.Location = New System.Drawing.Point(740, 160)
        Me.tbHaulier.Name = "tbHaulier"
        Me.tbHaulier.Size = New System.Drawing.Size(224, 26)
        Me.tbHaulier.TabIndex = 11
        '
        'lblLoadingBay
        '
        Me.lblLoadingBay.AutoSize = True
        Me.lblLoadingBay.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadingBay.Location = New System.Drawing.Point(514, 235)
        Me.lblLoadingBay.Name = "lblLoadingBay"
        Me.lblLoadingBay.Size = New System.Drawing.Size(124, 22)
        Me.lblLoadingBay.TabIndex = 121
        Me.lblLoadingBay.Text = "Loading Bay:"
        '
        'lblWarehouseLocation
        '
        Me.lblWarehouseLocation.AutoSize = True
        Me.lblWarehouseLocation.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarehouseLocation.Location = New System.Drawing.Point(514, 196)
        Me.lblWarehouseLocation.Name = "lblWarehouseLocation"
        Me.lblWarehouseLocation.Size = New System.Drawing.Size(193, 22)
        Me.lblWarehouseLocation.TabIndex = 120
        Me.lblWarehouseLocation.Text = "Warehouse Location:"
        '
        'tbLoadingBay
        '
        Me.tbLoadingBay.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLoadingBay.Location = New System.Drawing.Point(740, 238)
        Me.tbLoadingBay.Name = "tbLoadingBay"
        Me.tbLoadingBay.Size = New System.Drawing.Size(224, 26)
        Me.tbLoadingBay.TabIndex = 13
        '
        'cmbWarehouseLocation
        '
        Me.cmbWarehouseLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWarehouseLocation.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWarehouseLocation.FormattingEnabled = True
        Me.cmbWarehouseLocation.Location = New System.Drawing.Point(740, 199)
        Me.cmbWarehouseLocation.Name = "cmbWarehouseLocation"
        Me.cmbWarehouseLocation.Size = New System.Drawing.Size(224, 27)
        Me.cmbWarehouseLocation.TabIndex = 12
        '
        'tbInvoice
        '
        Me.tbInvoice.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInvoice.Location = New System.Drawing.Point(225, 121)
        Me.tbInvoice.Name = "tbInvoice"
        Me.tbInvoice.Size = New System.Drawing.Size(272, 26)
        Me.tbInvoice.TabIndex = 3
        '
        'lblCompanyFullName
        '
        Me.lblCompanyFullName.AutoSize = True
        Me.lblCompanyFullName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyFullName.Location = New System.Drawing.Point(225, 40)
        Me.lblCompanyFullName.Name = "lblCompanyFullName"
        Me.lblCompanyFullName.Size = New System.Drawing.Size(156, 19)
        Me.lblCompanyFullName.TabIndex = 130
        Me.lblCompanyFullName.Text = "Company Full Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnPost
        '
        Me.btnPost.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.Location = New System.Drawing.Point(1070, 646)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(78, 28)
        Me.btnPost.TabIndex = 102
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'btnSave1
        '
        Me.btnSave1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave1.Location = New System.Drawing.Point(986, 646)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(78, 28)
        Me.btnSave1.TabIndex = 101
        Me.btnSave1.Text = "Save"
        Me.btnSave1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(902, 646)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 28)
        Me.Button2.TabIndex = 100
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCancel1
        '
        Me.btnCancel1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel1.Location = New System.Drawing.Point(1154, 646)
        Me.btnCancel1.Name = "btnCancel1"
        Me.btnCancel1.Size = New System.Drawing.Size(78, 28)
        Me.btnCancel1.TabIndex = 103
        Me.btnCancel1.Text = "Cancel"
        Me.btnCancel1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.dtpRTT, 0, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.dtpLCD, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.dtpRTD, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.dtpLCT, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.lblRTD, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.lblLCT, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.lblLCD, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lblRTT, 0, 6)
        Me.TableLayoutPanel6.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(987, 124)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 8
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(246, 315)
        Me.TableLayoutPanel6.TabIndex = 30
        '
        'dtpRTT
        '
        Me.dtpRTT.CalendarFont = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRTT.CustomFormat = """ """
        Me.dtpRTT.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpRTT.Location = New System.Drawing.Point(5, 278)
        Me.dtpRTT.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpRTT.Name = "dtpRTT"
        Me.dtpRTT.ShowUpDown = True
        Me.dtpRTT.Size = New System.Drawing.Size(233, 30)
        Me.dtpRTT.TabIndex = 34
        '
        'dtpLCD
        '
        Me.dtpLCD.CalendarFont = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLCD.CustomFormat = """ """
        Me.dtpLCD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLCD.Location = New System.Drawing.Point(5, 44)
        Me.dtpLCD.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpLCD.Name = "dtpLCD"
        Me.dtpLCD.Size = New System.Drawing.Size(233, 30)
        Me.dtpLCD.TabIndex = 31
        '
        'dtpRTD
        '
        Me.dtpRTD.CalendarFont = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRTD.CustomFormat = """ """
        Me.dtpRTD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRTD.Location = New System.Drawing.Point(5, 200)
        Me.dtpRTD.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpRTD.Name = "dtpRTD"
        Me.dtpRTD.Size = New System.Drawing.Size(233, 30)
        Me.dtpRTD.TabIndex = 33
        '
        'dtpLCT
        '
        Me.dtpLCT.CalendarFont = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLCT.CustomFormat = """ """
        Me.dtpLCT.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpLCT.Location = New System.Drawing.Point(5, 122)
        Me.dtpLCT.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpLCT.Name = "dtpLCT"
        Me.dtpLCT.ShowUpDown = True
        Me.dtpLCT.Size = New System.Drawing.Size(233, 30)
        Me.dtpLCT.TabIndex = 32
        '
        'lblRTD
        '
        Me.lblRTD.AutoSize = True
        Me.lblRTD.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRTD.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblRTD.Location = New System.Drawing.Point(5, 157)
        Me.lblRTD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRTD.Name = "lblRTD"
        Me.lblRTD.Size = New System.Drawing.Size(202, 22)
        Me.lblRTD.TabIndex = 32
        Me.lblRTD.Text = "Ready Truck Out Date"
        Me.lblRTD.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblLCT
        '
        Me.lblLCT.AutoSize = True
        Me.lblLCT.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLCT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblLCT.Location = New System.Drawing.Point(5, 79)
        Me.lblLCT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLCT.Name = "lblLCT"
        Me.lblLCT.Size = New System.Drawing.Size(226, 22)
        Me.lblLCT.TabIndex = 32
        Me.lblLCT.Text = "Loading Completed Time"
        Me.lblLCT.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblLCD
        '
        Me.lblLCD.AutoSize = True
        Me.lblLCD.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLCD.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblLCD.Location = New System.Drawing.Point(5, 1)
        Me.lblLCD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLCD.Name = "lblLCD"
        Me.lblLCD.Size = New System.Drawing.Size(225, 22)
        Me.lblLCD.TabIndex = 32
        Me.lblLCD.Text = "Loading Completed Date"
        Me.lblLCD.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblRTT
        '
        Me.lblRTT.AutoSize = True
        Me.lblRTT.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRTT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblRTT.Location = New System.Drawing.Point(5, 235)
        Me.lblRTT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRTT.Name = "lblRTT"
        Me.lblRTT.Size = New System.Drawing.Size(203, 22)
        Me.lblRTT.TabIndex = 32
        Me.lblRTT.Text = "Ready Truck Out Time"
        Me.lblRTT.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.cbSecurityPost, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.cbShippingPost, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cbWarehousePost, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(1009, 447)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(173, 173)
        Me.TableLayoutPanel5.TabIndex = 149
        '
        'cbSecurityPost
        '
        Me.cbSecurityPost.AutoSize = True
        Me.cbSecurityPost.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSecurityPost.Location = New System.Drawing.Point(5, 145)
        Me.cbSecurityPost.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSecurityPost.Name = "cbSecurityPost"
        Me.cbSecurityPost.Size = New System.Drawing.Size(111, 23)
        Me.cbSecurityPost.TabIndex = 122
        Me.cbSecurityPost.Text = "CheckBox1"
        Me.cbSecurityPost.UseVisualStyleBackColor = True
        '
        'cbShippingPost
        '
        Me.cbShippingPost.AutoSize = True
        Me.cbShippingPost.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShippingPost.Location = New System.Drawing.Point(5, 33)
        Me.cbShippingPost.Margin = New System.Windows.Forms.Padding(4)
        Me.cbShippingPost.Name = "cbShippingPost"
        Me.cbShippingPost.Size = New System.Drawing.Size(111, 19)
        Me.cbShippingPost.TabIndex = 119
        Me.cbShippingPost.Text = "CheckBox1"
        Me.cbShippingPost.UseVisualStyleBackColor = True
        '
        'cbWarehousePost
        '
        Me.cbWarehousePost.AutoSize = True
        Me.cbWarehousePost.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWarehousePost.Location = New System.Drawing.Point(5, 89)
        Me.cbWarehousePost.Margin = New System.Windows.Forms.Padding(4)
        Me.cbWarehousePost.Name = "cbWarehousePost"
        Me.cbWarehousePost.Size = New System.Drawing.Size(111, 19)
        Me.cbWarehousePost.TabIndex = 120
        Me.cbWarehousePost.Text = "CheckBox1"
        Me.cbWarehousePost.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 1)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 19)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Shipping Post"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 19)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Warehouse Post"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Security Post"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1424, 816)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 34)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(1295, 816)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 34)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1549, 816)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 34)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 293.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbInternalSealNo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbLinerSealNo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbContainerNo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEsSealNo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLinerSealNo, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInternalSealNo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTemporarySealNo, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblContainerNo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 1, 4)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 447)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.28647!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.78072!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35986!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.28647!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.28647!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(518, 198)
        Me.TableLayoutPanel1.TabIndex = 50
        '
        'tbInternalSealNo
        '
        Me.tbInternalSealNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbInternalSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInternalSealNo.Location = New System.Drawing.Point(228, 120)
        Me.tbInternalSealNo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbInternalSealNo.Name = "tbInternalSealNo"
        Me.tbInternalSealNo.Size = New System.Drawing.Size(277, 26)
        Me.tbInternalSealNo.TabIndex = 56
        '
        'tbLinerSealNo
        '
        Me.tbLinerSealNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbLinerSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLinerSealNo.Location = New System.Drawing.Point(228, 82)
        Me.tbLinerSealNo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLinerSealNo.Name = "tbLinerSealNo"
        Me.tbLinerSealNo.Size = New System.Drawing.Size(277, 26)
        Me.tbLinerSealNo.TabIndex = 55
        '
        'tbContainerNo
        '
        Me.tbContainerNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbContainerNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContainerNo.Location = New System.Drawing.Point(228, 5)
        Me.tbContainerNo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbContainerNo.Name = "tbContainerNo"
        Me.tbContainerNo.Size = New System.Drawing.Size(277, 26)
        Me.tbContainerNo.TabIndex = 51
        '
        'lblEsSealNo
        '
        Me.lblEsSealNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsSealNo.Location = New System.Drawing.Point(5, 40)
        Me.lblEsSealNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEsSealNo.Name = "lblEsSealNo"
        Me.lblEsSealNo.Size = New System.Drawing.Size(214, 37)
        Me.lblEsSealNo.TabIndex = 28
        Me.lblEsSealNo.Text = "Es Seal No."
        '
        'lblLinerSealNo
        '
        Me.lblLinerSealNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinerSealNo.Location = New System.Drawing.Point(5, 78)
        Me.lblLinerSealNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLinerSealNo.Name = "lblLinerSealNo"
        Me.lblLinerSealNo.Size = New System.Drawing.Size(209, 36)
        Me.lblLinerSealNo.TabIndex = 29
        Me.lblLinerSealNo.Text = "Liner's Seal No."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.10458!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.89542!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmbEsSealNo, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tbEsSealNo, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(228, 44)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(277, 29)
        Me.TableLayoutPanel2.TabIndex = 52
        '
        'cmbEsSealNo
        '
        Me.cmbEsSealNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEsSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEsSealNo.FormattingEnabled = True
        Me.cmbEsSealNo.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbEsSealNo.Location = New System.Drawing.Point(5, -4)
        Me.cmbEsSealNo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEsSealNo.Name = "cmbEsSealNo"
        Me.cmbEsSealNo.Size = New System.Drawing.Size(69, 27)
        Me.cmbEsSealNo.TabIndex = 53
        '
        'tbEsSealNo
        '
        Me.tbEsSealNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEsSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEsSealNo.Location = New System.Drawing.Point(83, -4)
        Me.tbEsSealNo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbEsSealNo.Name = "tbEsSealNo"
        Me.tbEsSealNo.Size = New System.Drawing.Size(189, 26)
        Me.tbEsSealNo.TabIndex = 54
        '
        'lblInternalSealNo
        '
        Me.lblInternalSealNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternalSealNo.Location = New System.Drawing.Point(5, 116)
        Me.lblInternalSealNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInternalSealNo.Name = "lblInternalSealNo"
        Me.lblInternalSealNo.Size = New System.Drawing.Size(214, 38)
        Me.lblInternalSealNo.TabIndex = 30
        Me.lblInternalSealNo.Text = "Internal Seal No."
        '
        'lblTemporarySealNo
        '
        Me.lblTemporarySealNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemporarySealNo.Location = New System.Drawing.Point(5, 155)
        Me.lblTemporarySealNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTemporarySealNo.Name = "lblTemporarySealNo"
        Me.lblTemporarySealNo.Size = New System.Drawing.Size(214, 42)
        Me.lblTemporarySealNo.TabIndex = 31
        Me.lblTemporarySealNo.Text = "Temporary Seal No."
        '
        'lblContainerNo
        '
        Me.lblContainerNo.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainerNo.Location = New System.Drawing.Point(5, 1)
        Me.lblContainerNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContainerNo.Name = "lblContainerNo"
        Me.lblContainerNo.Size = New System.Drawing.Size(214, 36)
        Me.lblContainerNo.TabIndex = 27
        Me.lblContainerNo.Text = "Container No."
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.45098!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.54902!))
        Me.TableLayoutPanel7.Controls.Add(Me.tbTempSeal, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.cmbCheckTempSealNo, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(228, 159)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(277, 34)
        Me.TableLayoutPanel7.TabIndex = 57
        '
        'tbTempSeal
        '
        Me.tbTempSeal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTempSeal.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTempSeal.Location = New System.Drawing.Point(81, 5)
        Me.tbTempSeal.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTempSeal.Name = "tbTempSeal"
        Me.tbTempSeal.Size = New System.Drawing.Size(191, 26)
        Me.tbTempSeal.TabIndex = 59
        '
        'cmbCheckTempSealNo
        '
        Me.cmbCheckTempSealNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCheckTempSealNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCheckTempSealNo.FormattingEnabled = True
        Me.cmbCheckTempSealNo.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbCheckTempSealNo.Location = New System.Drawing.Point(5, 5)
        Me.cmbCheckTempSealNo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCheckTempSealNo.Name = "cmbCheckTempSealNo"
        Me.cmbCheckTempSealNo.Size = New System.Drawing.Size(67, 27)
        Me.cmbCheckTempSealNo.TabIndex = 58
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblCompanyNameHeader)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblUserDetails)
        Me.Panel1.Location = New System.Drawing.Point(15, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1235, 121)
        Me.Panel1.TabIndex = 151
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
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(698, 4)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(533, 46)
        Me.TableLayoutPanel4.TabIndex = 135
        '
        'lblTooNumber
        '
        Me.lblTooNumber.AutoSize = True
        Me.lblTooNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTooNumber.Location = New System.Drawing.Point(334, 1)
        Me.lblTooNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.lblTruckOutNumber.Location = New System.Drawing.Point(5, 1)
        Me.lblTruckOutNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTruckOutNumber.Name = "lblTruckOutNumber"
        Me.lblTruckOutNumber.Size = New System.Drawing.Size(192, 24)
        Me.lblTruckOutNumber.TabIndex = 134
        Me.lblTruckOutNumber.Text = "Truck Out Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1472, 63)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 24)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "Shipping Edit"
        '
        'lblCompanyNameHeader
        '
        Me.lblCompanyNameHeader.AutoSize = True
        Me.lblCompanyNameHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyNameHeader.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyNameHeader.Location = New System.Drawing.Point(196, 26)
        Me.lblCompanyNameHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompanyNameHeader.Name = "lblCompanyNameHeader"
        Me.lblCompanyNameHeader.Size = New System.Drawing.Size(191, 24)
        Me.lblCompanyNameHeader.TabIndex = 138
        Me.lblCompanyNameHeader.Text = "lblCompanyHeader"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.realGuanChongIcon_removebg_preview
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(4, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 59)
        Me.Panel2.TabIndex = 136
        '
        'lblUserDetails
        '
        Me.lblUserDetails.AutoSize = True
        Me.lblUserDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblUserDetails.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDetails.Location = New System.Drawing.Point(4, 63)
        Me.lblUserDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserDetails.Name = "lblUserDetails"
        Me.lblUserDetails.Size = New System.Drawing.Size(140, 24)
        Me.lblUserDetails.TabIndex = 129
        Me.lblUserDetails.Text = "lblUserDetails"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ShippingEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.Untitled_design__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "ShippingEdit"
        Me.Text = "TOO System"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
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
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents tbTempSeal As TextBox
    Friend WithEvents cmbCheckTempSealNo As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbShippingPost As CheckBox
    Friend WithEvents cbWarehousePost As CheckBox
    Friend WithEvents cbSecurityPost As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents dtpRTT As DateTimePicker
    Friend WithEvents dtpLCD As DateTimePicker
    Friend WithEvents dtpRTD As DateTimePicker
    Friend WithEvents dtpLCT As DateTimePicker
    Friend WithEvents lblRTD As Label
    Friend WithEvents lblLCT As Label
    Friend WithEvents lblLCD As Label
    Friend WithEvents lblRTT As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCompanyNameHeader As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblTooNumber As Label
    Friend WithEvents lblTruckOutNumber As Label
    Friend WithEvents lblUserDetails As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnPost As Button
    Friend WithEvents btnSave1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCancel1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblPortFullName As Label
    Friend WithEvents lblLoadingPortFullName As Label
    Friend WithEvents lblCompanyFullName As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents cmbCompany As ComboBox
    Friend WithEvents cmbContainerSize As ComboBox
    Friend WithEvents lblInvoice As Label
    Friend WithEvents tbInvoice As TextBox
    Friend WithEvents lblProduct As Label
    Friend WithEvents tbProduct As TextBox
    Friend WithEvents lblContainerSize As Label
    Friend WithEvents lblShippingLine As Label
    Friend WithEvents tbShippingLine As TextBox
    Friend WithEvents lblLoadingPort As Label
    Friend WithEvents cmbLoadingPort As ComboBox
    Friend WithEvents lblSCT As Label
    Friend WithEvents lblSCD As Label
    Friend WithEvents lblSendToCompany As Label
    Friend WithEvents tbSendToCompany As TextBox
    Friend WithEvents dtpSCD As DateTimePicker
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblDDB As Label
    Friend WithEvents cmbDDB As ComboBox
    Friend WithEvents dtpSCT As DateTimePicker
    Friend WithEvents lblHaulier As Label
    Friend WithEvents tbHaulier As TextBox
    Friend WithEvents lblLoadingBay As Label
    Friend WithEvents lblWarehouseLocation As Label
    Friend WithEvents tbLoadingBay As TextBox
    Friend WithEvents cmbWarehouseLocation As ComboBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
