﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJobEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJobEdit))
        Me.btnPnlchkClose = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCustClose = New System.Windows.Forms.Button()
        Me.chksms = New System.Windows.Forms.CheckBox()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.chkWhatsapp = New System.Windows.Forms.CheckBox()
        Me.BtnChk = New System.Windows.Forms.Button()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLoca = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttele = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtmob = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        Me.lblCustCode = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.lblchkhead = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RIYALOERPDB100DataSet = New JOBCARD.RIYALOERPDB100DataSet()
        Me.RIYALOERPDB100DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnAddLoc = New System.Windows.Forms.Button()
        Me.lblCnt = New System.Windows.Forms.Label()
        Me.dgvChk = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPrintBarcode = New System.Windows.Forms.Button()
        Me.BtnComplaint = New System.Windows.Forms.Button()
        Me.BtnBrand = New System.Windows.Forms.Button()
        Me.BtnTEch = New System.Windows.Forms.Button()
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPnlSettleClose = New System.Windows.Forms.Button()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbLoc = New System.Windows.Forms.ComboBox()
        Me.DtpJobDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpExpDel = New System.Windows.Forms.DateTimePicker()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.CmbComplaint = New System.Windows.Forms.ComboBox()
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.cmbtech = New System.Windows.Forms.ComboBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.lblServiceCharge = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.lblJobDate = New System.Windows.Forms.Label()
        Me.lblDel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblComplaint = New System.Windows.Forms.Label()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblTech = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtJobcode = New System.Windows.Forms.TextBox()
        Me.lblJObCode = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PnlSettlement = New System.Windows.Forms.Panel()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtCprice = New System.Windows.Forms.TextBox()
        Me.lblCompPrice = New System.Windows.Forms.Label()
        Me.txtScharge = New System.Windows.Forms.TextBox()
        Me.pnlChk = New System.Windows.Forms.Panel()
        Me.pnlCustomer = New System.Windows.Forms.Panel()
        CType(Me.RIYALOERPDB100DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIYALOERPDB100DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSettlement.SuspendLayout()
        Me.pnlChk.SuspendLayout()
        Me.pnlCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPnlchkClose
        '
        Me.btnPnlchkClose.BackColor = System.Drawing.Color.Transparent
        Me.btnPnlchkClose.BackgroundImage = CType(resources.GetObject("btnPnlchkClose.BackgroundImage"), System.Drawing.Image)
        Me.btnPnlchkClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPnlchkClose.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPnlchkClose.Location = New System.Drawing.Point(685, 4)
        Me.btnPnlchkClose.Name = "btnPnlchkClose"
        Me.btnPnlchkClose.Size = New System.Drawing.Size(29, 23)
        Me.btnPnlchkClose.TabIndex = 59
        Me.btnPnlchkClose.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackgroundImage = CType(resources.GetObject("btnDel.BackgroundImage"), System.Drawing.Image)
        Me.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDel.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(116, 21)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(71, 45)
        Me.btnDel.TabIndex = 151
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(43, 21)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(67, 45)
        Me.BtnUpdate.TabIndex = 150
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(916, 432)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 21)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "(  *   fields are Mandatory)"
        '
        'BtnCustClose
        '
        Me.BtnCustClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnCustClose.BackgroundImage = CType(resources.GetObject("BtnCustClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnCustClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCustClose.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustClose.Location = New System.Drawing.Point(1089, 7)
        Me.BtnCustClose.Name = "BtnCustClose"
        Me.BtnCustClose.Size = New System.Drawing.Size(35, 32)
        Me.BtnCustClose.TabIndex = 109
        Me.BtnCustClose.UseVisualStyleBackColor = False
        '
        'chksms
        '
        Me.chksms.AutoSize = True
        Me.chksms.Location = New System.Drawing.Point(804, 367)
        Me.chksms.Name = "chksms"
        Me.chksms.Size = New System.Drawing.Size(15, 14)
        Me.chksms.TabIndex = 107
        Me.chksms.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(804, 316)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(15, 14)
        Me.chkEmail.TabIndex = 106
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'chkWhatsapp
        '
        Me.chkWhatsapp.AutoSize = True
        Me.chkWhatsapp.Location = New System.Drawing.Point(804, 272)
        Me.chkWhatsapp.Name = "chkWhatsapp"
        Me.chkWhatsapp.Size = New System.Drawing.Size(15, 14)
        Me.chkWhatsapp.TabIndex = 105
        Me.chkWhatsapp.UseVisualStyleBackColor = True
        '
        'BtnChk
        '
        Me.BtnChk.BackgroundImage = CType(resources.GetObject("BtnChk.BackgroundImage"), System.Drawing.Image)
        Me.BtnChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnChk.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChk.Location = New System.Drawing.Point(954, 373)
        Me.BtnChk.Name = "BtnChk"
        Me.BtnChk.Size = New System.Drawing.Size(65, 50)
        Me.BtnChk.TabIndex = 152
        Me.BtnChk.UseVisualStyleBackColor = True
        '
        'txtCopies
        '
        Me.txtCopies.AllowDrop = True
        Me.txtCopies.Location = New System.Drawing.Point(1041, 33)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(64, 20)
        Me.txtCopies.TabIndex = 146
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(418, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(323, 41)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "New Customer Entry"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(611, 367)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 21)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Send SMS Updates?"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(611, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 21)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Send Email Updates?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(611, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 21)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Send Whatsapp Updates?"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(804, 187)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(309, 21)
        Me.txtEmail.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(611, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 21)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Email"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(804, 160)
        Me.txtCountry.Multiline = True
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(309, 21)
        Me.txtCountry.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(611, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Country"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(804, 133)
        Me.txtState.Multiline = True
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(309, 21)
        Me.txtState.TabIndex = 93
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(611, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 21)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "State"
        '
        'txtLoca
        '
        Me.txtLoca.Location = New System.Drawing.Point(804, 103)
        Me.txtLoca.Multiline = True
        Me.txtLoca.Name = "txtLoca"
        Me.txtLoca.ReadOnly = True
        Me.txtLoca.Size = New System.Drawing.Size(309, 21)
        Me.txtLoca.TabIndex = 91
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(611, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 21)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Location"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(246, 226)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(309, 126)
        Me.txtAddress.TabIndex = 89
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(53, 226)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 21)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Address"
        '
        'txttele
        '
        Me.txttele.Location = New System.Drawing.Point(246, 194)
        Me.txttele.Multiline = True
        Me.txttele.Name = "txttele"
        Me.txttele.Size = New System.Drawing.Size(309, 21)
        Me.txttele.TabIndex = 87
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(53, 194)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 21)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Telephone"
        '
        'txtmob
        '
        Me.txtmob.Location = New System.Drawing.Point(246, 162)
        Me.txtmob.Multiline = True
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(309, 21)
        Me.txtmob.TabIndex = 85
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(53, 162)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 21)
        Me.Label16.TabIndex = 84
        Me.Label16.Text = "Mobile"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(246, 130)
        Me.txtCustName.Multiline = True
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(309, 21)
        Me.txtCustName.TabIndex = 83
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(53, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 21)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Customer Name"
        '
        'txtCustCode
        '
        Me.txtCustCode.Location = New System.Drawing.Point(246, 103)
        Me.txtCustCode.Multiline = True
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.ReadOnly = True
        Me.txtCustCode.Size = New System.Drawing.Size(309, 21)
        Me.txtCustCode.TabIndex = 81
        '
        'lblCustCode
        '
        Me.lblCustCode.AutoSize = True
        Me.lblCustCode.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustCode.Location = New System.Drawing.Point(53, 103)
        Me.lblCustCode.Name = "lblCustCode"
        Me.lblCustCode.Size = New System.Drawing.Size(111, 21)
        Me.lblCustCode.TabIndex = 80
        Me.lblCustCode.Text = "Customer Code"
        '
        'BtnClose
        '
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClose.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(1130, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(33, 32)
        Me.BtnClose.TabIndex = 61
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'lblchkhead
        '
        Me.lblchkhead.AutoSize = True
        Me.lblchkhead.Font = New System.Drawing.Font("Sitka Subheading", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchkhead.ForeColor = System.Drawing.Color.Black
        Me.lblchkhead.Location = New System.Drawing.Point(225, 4)
        Me.lblchkhead.Name = "lblchkhead"
        Me.lblchkhead.Size = New System.Drawing.Size(268, 39)
        Me.lblchkhead.TabIndex = 60
        Me.lblchkhead.Text = "Pre Repair Checklist"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(693, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 21)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Click icon to Add Pre Repair Checklist"
        '
        'RIYALOERPDB100DataSet
        '
        Me.RIYALOERPDB100DataSet.DataSetName = "RIYALOERPDB100DataSet"
        Me.RIYALOERPDB100DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RIYALOERPDB100DataSetBindingSource
        '
        Me.RIYALOERPDB100DataSetBindingSource.DataSource = Me.RIYALOERPDB100DataSet
        Me.RIYALOERPDB100DataSetBindingSource.Position = 0
        '
        'BtnAddLoc
        '
        Me.BtnAddLoc.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddLoc.Location = New System.Drawing.Point(1111, 136)
        Me.BtnAddLoc.Name = "BtnAddLoc"
        Me.BtnAddLoc.Size = New System.Drawing.Size(110, 21)
        Me.BtnAddLoc.TabIndex = 154
        Me.BtnAddLoc.Text = "Add To Location"
        Me.BtnAddLoc.UseVisualStyleBackColor = True
        '
        'lblCnt
        '
        Me.lblCnt.AutoSize = True
        Me.lblCnt.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnt.Location = New System.Drawing.Point(935, 30)
        Me.lblCnt.Name = "lblCnt"
        Me.lblCnt.Size = New System.Drawing.Size(100, 21)
        Me.lblCnt.TabIndex = 145
        Me.lblCnt.Text = "No. Of Copies"
        '
        'dgvChk
        '
        Me.dgvChk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvChk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChk.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvChk.GridColor = System.Drawing.SystemColors.Control
        Me.dgvChk.Location = New System.Drawing.Point(81, 76)
        Me.dgvChk.Name = "dgvChk"
        Me.dgvChk.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow
        Me.dgvChk.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvChk.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChk.Size = New System.Drawing.Size(546, 245)
        Me.dgvChk.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(196, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 45)
        Me.Button1.TabIndex = 156
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnPrintBarcode
        '
        Me.BtnPrintBarcode.BackgroundImage = CType(resources.GetObject("BtnPrintBarcode.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintBarcode.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintBarcode.Location = New System.Drawing.Point(846, 14)
        Me.BtnPrintBarcode.Name = "BtnPrintBarcode"
        Me.BtnPrintBarcode.Size = New System.Drawing.Size(83, 59)
        Me.BtnPrintBarcode.TabIndex = 144
        Me.BtnPrintBarcode.UseVisualStyleBackColor = True
        '
        'BtnComplaint
        '
        Me.BtnComplaint.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplaint.Location = New System.Drawing.Point(558, 316)
        Me.BtnComplaint.Name = "BtnComplaint"
        Me.BtnComplaint.Size = New System.Drawing.Size(110, 21)
        Me.BtnComplaint.TabIndex = 143
        Me.BtnComplaint.Text = "Add To Complaint"
        Me.BtnComplaint.UseVisualStyleBackColor = True
        '
        'BtnBrand
        '
        Me.BtnBrand.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrand.Location = New System.Drawing.Point(558, 226)
        Me.BtnBrand.Name = "BtnBrand"
        Me.BtnBrand.Size = New System.Drawing.Size(110, 21)
        Me.BtnBrand.TabIndex = 142
        Me.BtnBrand.Text = "Add To Brand"
        Me.BtnBrand.UseVisualStyleBackColor = True
        '
        'BtnTEch
        '
        Me.BtnTEch.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTEch.Location = New System.Drawing.Point(558, 196)
        Me.BtnTEch.Name = "BtnTEch"
        Me.BtnTEch.Size = New System.Drawing.Size(110, 21)
        Me.BtnTEch.TabIndex = 141
        Me.BtnTEch.Text = "Add To Technician"
        Me.BtnTEch.UseVisualStyleBackColor = True
        '
        'btnAddCust
        '
        Me.btnAddCust.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCust.Location = New System.Drawing.Point(558, 136)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(110, 21)
        Me.btnAddCust.TabIndex = 139
        Me.btnAddCust.Text = "Add To Customer"
        Me.btnAddCust.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Subheading", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(164, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 35)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Amount Settlement"
        '
        'btnPnlSettleClose
        '
        Me.btnPnlSettleClose.BackColor = System.Drawing.Color.Transparent
        Me.btnPnlSettleClose.BackgroundImage = CType(resources.GetObject("btnPnlSettleClose.BackgroundImage"), System.Drawing.Image)
        Me.btnPnlSettleClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPnlSettleClose.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPnlSettleClose.Location = New System.Drawing.Point(590, 3)
        Me.btnPnlSettleClose.Name = "btnPnlSettleClose"
        Me.btnPnlSettleClose.Size = New System.Drawing.Size(34, 27)
        Me.btnPnlSettleClose.TabIndex = 62
        Me.btnPnlSettleClose.UseVisualStyleBackColor = False
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(230, 155)
        Me.txtVAT.Multiline = True
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVAT.Size = New System.Drawing.Size(200, 21)
        Me.txtVAT.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "VAT Amount"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotal.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTotal.Location = New System.Drawing.Point(230, 215)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(200, 48)
        Me.txtTotal.TabIndex = 43
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.Location = New System.Drawing.Point(42, 230)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(101, 21)
        Me.lblTot.TabIndex = 42
        Me.lblTot.Text = "Total Amount"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(796, 166)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(309, 21)
        Me.cmbStatus.TabIndex = 137
        '
        'cmbLoc
        '
        Me.cmbLoc.FormattingEnabled = True
        Me.cmbLoc.Location = New System.Drawing.Point(796, 136)
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(309, 21)
        Me.cmbLoc.TabIndex = 136
        '
        'DtpJobDate
        '
        Me.DtpJobDate.Location = New System.Drawing.Point(796, 106)
        Me.DtpJobDate.Name = "DtpJobDate"
        Me.DtpJobDate.Size = New System.Drawing.Size(309, 20)
        Me.DtpJobDate.TabIndex = 135
        '
        'dtpExpDel
        '
        Me.dtpExpDel.Location = New System.Drawing.Point(232, 376)
        Me.dtpExpDel.Name = "dtpExpDel"
        Me.dtpExpDel.Size = New System.Drawing.Size(309, 20)
        Me.dtpExpDel.TabIndex = 134
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(232, 346)
        Me.txtYear.Multiline = True
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(309, 21)
        Me.txtYear.TabIndex = 133
        '
        'CmbComplaint
        '
        Me.CmbComplaint.FormattingEnabled = True
        Me.CmbComplaint.Location = New System.Drawing.Point(232, 316)
        Me.CmbComplaint.Name = "CmbComplaint"
        Me.CmbComplaint.Size = New System.Drawing.Size(309, 21)
        Me.CmbComplaint.TabIndex = 132
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Location = New System.Drawing.Point(232, 286)
        Me.txtSerialNo.Multiline = True
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(309, 21)
        Me.txtSerialNo.TabIndex = 131
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(232, 256)
        Me.txtProduct.Multiline = True
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(309, 21)
        Me.txtProduct.TabIndex = 130
        '
        'cmbBrand
        '
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Location = New System.Drawing.Point(232, 226)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(309, 21)
        Me.cmbBrand.TabIndex = 129
        '
        'cmbtech
        '
        Me.cmbtech.FormattingEnabled = True
        Me.cmbtech.Location = New System.Drawing.Point(232, 196)
        Me.cmbtech.Name = "cmbtech"
        Me.cmbtech.Size = New System.Drawing.Size(309, 21)
        Me.cmbtech.TabIndex = 128
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(232, 166)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(309, 21)
        Me.txtPhone.TabIndex = 127
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(232, 136)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(309, 21)
        Me.cmbCustomer.TabIndex = 126
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(796, 196)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(309, 171)
        Me.txtNotes.TabIndex = 125
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(693, 274)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(49, 21)
        Me.lblNotes.TabIndex = 124
        Me.lblNotes.Text = "Notes"
        '
        'txtDisc
        '
        Me.txtDisc.Location = New System.Drawing.Point(230, 128)
        Me.txtDisc.Multiline = True
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDisc.Size = New System.Drawing.Size(200, 21)
        Me.txtDisc.TabIndex = 41
        '
        'lblServiceCharge
        '
        Me.lblServiceCharge.AutoSize = True
        Me.lblServiceCharge.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCharge.Location = New System.Drawing.Point(42, 95)
        Me.lblServiceCharge.Name = "lblServiceCharge"
        Me.lblServiceCharge.Size = New System.Drawing.Size(108, 21)
        Me.lblServiceCharge.TabIndex = 36
        Me.lblServiceCharge.Text = "Service Charge"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(693, 166)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(94, 21)
        Me.lblStatus.TabIndex = 123
        Me.lblStatus.Text = "Job Status * "
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc.Location = New System.Drawing.Point(693, 136)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(71, 21)
        Me.lblLoc.TabIndex = 122
        Me.lblLoc.Text = "Location "
        '
        'lblJobDate
        '
        Me.lblJobDate.AutoSize = True
        Me.lblJobDate.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobDate.Location = New System.Drawing.Point(693, 106)
        Me.lblJobDate.Name = "lblJobDate"
        Me.lblJobDate.Size = New System.Drawing.Size(66, 21)
        Me.lblJobDate.TabIndex = 121
        Me.lblJobDate.Text = "Job Date"
        '
        'lblDel
        '
        Me.lblDel.AutoSize = True
        Me.lblDel.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDel.Location = New System.Drawing.Point(35, 376)
        Me.lblDel.Name = "lblDel"
        Me.lblDel.Size = New System.Drawing.Size(163, 21)
        Me.lblDel.TabIndex = 120
        Me.lblDel.Text = "Expected Delivery Date"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(33, 346)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(40, 21)
        Me.lblYear.TabIndex = 119
        Me.lblYear.Text = "Year"
        '
        'lblComplaint
        '
        Me.lblComplaint.AutoSize = True
        Me.lblComplaint.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplaint.Location = New System.Drawing.Point(35, 316)
        Me.lblComplaint.Name = "lblComplaint"
        Me.lblComplaint.Size = New System.Drawing.Size(89, 21)
        Me.lblComplaint.TabIndex = 118
        Me.lblComplaint.Text = "Complaint *"
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.Location = New System.Drawing.Point(33, 286)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(87, 21)
        Me.lblSerial.TabIndex = 117
        Me.lblSerial.Text = "Serial No. *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Product * "
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(35, 226)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(65, 21)
        Me.lblBrand.TabIndex = 115
        Me.lblBrand.Text = "Brand * "
        '
        'lblTech
        '
        Me.lblTech.AutoSize = True
        Me.lblTech.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTech.Location = New System.Drawing.Point(39, 196)
        Me.lblTech.Name = "lblTech"
        Me.lblTech.Size = New System.Drawing.Size(95, 21)
        Me.lblTech.TabIndex = 114
        Me.lblTech.Text = "Technician * "
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(39, 166)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(88, 21)
        Me.lblPhone.TabIndex = 113
        Me.lblPhone.Text = "Phone No. *"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(39, 136)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(128, 21)
        Me.lblCustomerName.TabIndex = 112
        Me.lblCustomerName.Text = "Customer Name *"
        '
        'txtJobcode
        '
        Me.txtJobcode.Location = New System.Drawing.Point(232, 106)
        Me.txtJobcode.Multiline = True
        Me.txtJobcode.Name = "txtJobcode"
        Me.txtJobcode.ReadOnly = True
        Me.txtJobcode.Size = New System.Drawing.Size(309, 21)
        Me.txtJobcode.TabIndex = 111
        '
        'lblJObCode
        '
        Me.lblJObCode.AutoSize = True
        Me.lblJObCode.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJObCode.Location = New System.Drawing.Point(39, 106)
        Me.lblJObCode.Name = "lblJObCode"
        Me.lblJObCode.Size = New System.Drawing.Size(67, 21)
        Me.lblJObCode.TabIndex = 110
        Me.lblJObCode.Text = "Job Code"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(432, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(254, 41)
        Me.lblTitle.TabIndex = 109
        Me.lblTitle.Text = "Job Master Edit"
        '
        'PnlSettlement
        '
        Me.PnlSettlement.BackColor = System.Drawing.Color.Khaki
        Me.PnlSettlement.Controls.Add(Me.Label4)
        Me.PnlSettlement.Controls.Add(Me.btnPnlSettleClose)
        Me.PnlSettlement.Controls.Add(Me.txtVAT)
        Me.PnlSettlement.Controls.Add(Me.Label3)
        Me.PnlSettlement.Controls.Add(Me.txtTotal)
        Me.PnlSettlement.Controls.Add(Me.lblTot)
        Me.PnlSettlement.Controls.Add(Me.txtDisc)
        Me.PnlSettlement.Controls.Add(Me.lblDiscount)
        Me.PnlSettlement.Controls.Add(Me.txtCprice)
        Me.PnlSettlement.Controls.Add(Me.lblCompPrice)
        Me.PnlSettlement.Controls.Add(Me.txtScharge)
        Me.PnlSettlement.Controls.Add(Me.lblServiceCharge)
        Me.PnlSettlement.Location = New System.Drawing.Point(37, 109)
        Me.PnlSettlement.Name = "PnlSettlement"
        Me.PnlSettlement.Size = New System.Drawing.Size(627, 264)
        Me.PnlSettlement.TabIndex = 138
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(42, 125)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(69, 21)
        Me.lblDiscount.TabIndex = 40
        Me.lblDiscount.Text = "Discount"
        '
        'txtCprice
        '
        Me.txtCprice.Location = New System.Drawing.Point(230, 71)
        Me.txtCprice.Multiline = True
        Me.txtCprice.Name = "txtCprice"
        Me.txtCprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCprice.Size = New System.Drawing.Size(200, 21)
        Me.txtCprice.TabIndex = 39
        '
        'lblCompPrice
        '
        Me.lblCompPrice.AutoSize = True
        Me.lblCompPrice.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompPrice.Location = New System.Drawing.Point(42, 65)
        Me.lblCompPrice.Name = "lblCompPrice"
        Me.lblCompPrice.Size = New System.Drawing.Size(129, 21)
        Me.lblCompPrice.TabIndex = 38
        Me.lblCompPrice.Text = "Components Price"
        '
        'txtScharge
        '
        Me.txtScharge.Location = New System.Drawing.Point(230, 98)
        Me.txtScharge.Multiline = True
        Me.txtScharge.Name = "txtScharge"
        Me.txtScharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtScharge.Size = New System.Drawing.Size(200, 21)
        Me.txtScharge.TabIndex = 37
        '
        'pnlChk
        '
        Me.pnlChk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlChk.Controls.Add(Me.btnPnlchkClose)
        Me.pnlChk.Controls.Add(Me.dgvChk)
        Me.pnlChk.Controls.Add(Me.lblchkhead)
        Me.pnlChk.Location = New System.Drawing.Point(302, 71)
        Me.pnlChk.Name = "pnlChk"
        Me.pnlChk.Size = New System.Drawing.Size(717, 382)
        Me.pnlChk.TabIndex = 140
        '
        'pnlCustomer
        '
        Me.pnlCustomer.BackColor = System.Drawing.Color.Cornsilk
        Me.pnlCustomer.Controls.Add(Me.BtnCustClose)
        Me.pnlCustomer.Controls.Add(Me.chksms)
        Me.pnlCustomer.Controls.Add(Me.chkEmail)
        Me.pnlCustomer.Controls.Add(Me.chkWhatsapp)
        Me.pnlCustomer.Controls.Add(Me.Label18)
        Me.pnlCustomer.Controls.Add(Me.Label11)
        Me.pnlCustomer.Controls.Add(Me.Label10)
        Me.pnlCustomer.Controls.Add(Me.Label9)
        Me.pnlCustomer.Controls.Add(Me.txtEmail)
        Me.pnlCustomer.Controls.Add(Me.Label8)
        Me.pnlCustomer.Controls.Add(Me.txtCountry)
        Me.pnlCustomer.Controls.Add(Me.Label7)
        Me.pnlCustomer.Controls.Add(Me.txtState)
        Me.pnlCustomer.Controls.Add(Me.Label12)
        Me.pnlCustomer.Controls.Add(Me.txtLoca)
        Me.pnlCustomer.Controls.Add(Me.Label13)
        Me.pnlCustomer.Controls.Add(Me.txtAddress)
        Me.pnlCustomer.Controls.Add(Me.Label14)
        Me.pnlCustomer.Controls.Add(Me.txttele)
        Me.pnlCustomer.Controls.Add(Me.Label15)
        Me.pnlCustomer.Controls.Add(Me.txtmob)
        Me.pnlCustomer.Controls.Add(Me.Label16)
        Me.pnlCustomer.Controls.Add(Me.txtCustName)
        Me.pnlCustomer.Controls.Add(Me.Label17)
        Me.pnlCustomer.Controls.Add(Me.txtCustCode)
        Me.pnlCustomer.Controls.Add(Me.lblCustCode)
        Me.pnlCustomer.Controls.Add(Me.BtnClose)
        Me.pnlCustomer.Location = New System.Drawing.Point(7, 75)
        Me.pnlCustomer.Name = "pnlCustomer"
        Me.pnlCustomer.Size = New System.Drawing.Size(1130, 418)
        Me.pnlCustomer.TabIndex = 155
        '
        'FrmJobEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1248, 702)
        Me.Controls.Add(Me.pnlChk)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnChk)
        Me.Controls.Add(Me.txtCopies)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnAddLoc)
        Me.Controls.Add(Me.lblCnt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnPrintBarcode)
        Me.Controls.Add(Me.BtnComplaint)
        Me.Controls.Add(Me.BtnBrand)
        Me.Controls.Add(Me.BtnTEch)
        Me.Controls.Add(Me.btnAddCust)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbLoc)
        Me.Controls.Add(Me.DtpJobDate)
        Me.Controls.Add(Me.dtpExpDel)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.CmbComplaint)
        Me.Controls.Add(Me.txtSerialNo)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.cmbBrand)
        Me.Controls.Add(Me.cmbtech)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.cmbCustomer)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblLoc)
        Me.Controls.Add(Me.lblJobDate)
        Me.Controls.Add(Me.lblDel)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblComplaint)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblTech)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtJobcode)
        Me.Controls.Add(Me.lblJObCode)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PnlSettlement)
        Me.Controls.Add(Me.pnlCustomer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmJobEdit"
        Me.Text = "Job Master Edit"
        CType(Me.RIYALOERPDB100DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIYALOERPDB100DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSettlement.ResumeLayout(False)
        Me.PnlSettlement.PerformLayout()
        Me.pnlChk.ResumeLayout(False)
        Me.pnlChk.PerformLayout()
        Me.pnlCustomer.ResumeLayout(False)
        Me.pnlCustomer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPnlchkClose As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCustClose As Button
    Friend WithEvents chksms As CheckBox
    Friend WithEvents chkEmail As CheckBox
    Friend WithEvents chkWhatsapp As CheckBox
    Friend WithEvents BtnChk As Button
    Friend WithEvents txtCopies As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtLoca As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txttele As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtmob As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCustCode As TextBox
    Friend WithEvents lblCustCode As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents lblchkhead As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RIYALOERPDB100DataSet As RIYALOERPDB100DataSet
    Friend WithEvents RIYALOERPDB100DataSetBindingSource As BindingSource
    Friend WithEvents BtnAddLoc As Button
    Friend WithEvents lblCnt As Label
    Friend WithEvents dgvChk As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnPrintBarcode As Button
    Friend WithEvents BtnComplaint As Button
    Friend WithEvents BtnBrand As Button
    Friend WithEvents BtnTEch As Button
    Friend WithEvents btnAddCust As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPnlSettleClose As Button
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTot As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbLoc As ComboBox
    Friend WithEvents DtpJobDate As DateTimePicker
    Friend WithEvents dtpExpDel As DateTimePicker
    Friend WithEvents txtYear As TextBox
    Friend WithEvents CmbComplaint As ComboBox
    Friend WithEvents txtSerialNo As TextBox
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents cmbtech As ComboBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtDisc As TextBox
    Friend WithEvents lblServiceCharge As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLoc As Label
    Friend WithEvents lblJobDate As Label
    Friend WithEvents lblDel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblComplaint As Label
    Friend WithEvents lblSerial As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblTech As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtJobcode As TextBox
    Friend WithEvents lblJObCode As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents PnlSettlement As Panel
    Friend WithEvents lblDiscount As Label
    Friend WithEvents txtCprice As TextBox
    Friend WithEvents lblCompPrice As Label
    Friend WithEvents txtScharge As TextBox
    Friend WithEvents pnlChk As Panel
    Friend WithEvents pnlCustomer As Panel
End Class
