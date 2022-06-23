<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmJobMaster
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJobMaster))
        Me.lblJobmaster = New System.Windows.Forms.Label()
        Me.lblJobCode = New System.Windows.Forms.Label()
        Me.lblJobName = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.txtJobcode = New System.Windows.Forms.TextBox()
        Me.txtJobName = New System.Windows.Forms.TextBox()
        Me.txtJobRate = New System.Windows.Forms.TextBox()
        Me.lblReqDays = New System.Windows.Forms.Label()
        Me.txtReqDays = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TbljobMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RIYALOERPDB100DataSet = New JOBCARD.RIYALOERPDB100DataSet()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Tbl_job_MasterTableAdapter = New JOBCARD.RIYALOERPDB100DataSetTableAdapters.Tbl_job_MasterTableAdapter()
        Me.ucJobcode = New System.Windows.Forms.ListView()
        Me.JobCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JobName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.TbljobMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIYALOERPDB100DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJobmaster
        '
        Me.lblJobmaster.AutoSize = True
        Me.lblJobmaster.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobmaster.Location = New System.Drawing.Point(117, 26)
        Me.lblJobmaster.Name = "lblJobmaster"
        Me.lblJobmaster.Size = New System.Drawing.Size(472, 41)
        Me.lblJobmaster.TabIndex = 0
        Me.lblJobmaster.Text = "COMPLAINT MASTER ENTRY"
        '
        'lblJobCode
        '
        Me.lblJobCode.AutoSize = True
        Me.lblJobCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobCode.Location = New System.Drawing.Point(72, 142)
        Me.lblJobCode.Name = "lblJobCode"
        Me.lblJobCode.Size = New System.Drawing.Size(111, 16)
        Me.lblJobCode.TabIndex = 1
        Me.lblJobCode.Text = "Complaint Code "
        '
        'lblJobName
        '
        Me.lblJobName.AutoSize = True
        Me.lblJobName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobName.Location = New System.Drawing.Point(72, 172)
        Me.lblJobName.Name = "lblJobName"
        Me.lblJobName.Size = New System.Drawing.Size(56, 16)
        Me.lblJobName.TabIndex = 2
        Me.lblJobName.Text = "Reason"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(72, 202)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(38, 16)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "Rate "
        '
        'txtJobcode
        '
        Me.txtJobcode.Location = New System.Drawing.Point(218, 141)
        Me.txtJobcode.Multiline = True
        Me.txtJobcode.Name = "txtJobcode"
        Me.txtJobcode.ReadOnly = True
        Me.txtJobcode.Size = New System.Drawing.Size(228, 23)
        Me.txtJobcode.TabIndex = 4
        '
        'txtJobName
        '
        Me.txtJobName.Location = New System.Drawing.Point(218, 171)
        Me.txtJobName.Multiline = True
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Size = New System.Drawing.Size(228, 23)
        Me.txtJobName.TabIndex = 5
        '
        'txtJobRate
        '
        Me.txtJobRate.Location = New System.Drawing.Point(218, 201)
        Me.txtJobRate.Multiline = True
        Me.txtJobRate.Name = "txtJobRate"
        Me.txtJobRate.Size = New System.Drawing.Size(228, 23)
        Me.txtJobRate.TabIndex = 6
        '
        'lblReqDays
        '
        Me.lblReqDays.AutoSize = True
        Me.lblReqDays.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqDays.Location = New System.Drawing.Point(72, 233)
        Me.lblReqDays.Name = "lblReqDays"
        Me.lblReqDays.Size = New System.Drawing.Size(124, 16)
        Me.lblReqDays.TabIndex = 7
        Me.lblReqDays.Text = "Required Days (Min)"
        '
        'txtReqDays
        '
        Me.txtReqDays.Location = New System.Drawing.Point(218, 231)
        Me.txtReqDays.Multiline = True
        Me.txtReqDays.Name = "txtReqDays"
        Me.txtReqDays.Size = New System.Drawing.Size(228, 23)
        Me.txtReqDays.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(218, 277)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 33)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(318, 277)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(89, 33)
        Me.btnDel.TabIndex = 10
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(413, 277)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 33)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(492, 140)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(33, 35)
        Me.btnNew.TabIndex = 12
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(451, 140)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(36, 35)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'TbljobMasterBindingSource
        '
        Me.TbljobMasterBindingSource.DataMember = "Tbl_job_Master"
        Me.TbljobMasterBindingSource.DataSource = Me.RIYALOERPDB100DataSet
        '
        'RIYALOERPDB100DataSet
        '
        Me.RIYALOERPDB100DataSet.DataSetName = "RIYALOERPDB100DataSet"
        Me.RIYALOERPDB100DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(217, 277)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 33)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Tbl_job_MasterTableAdapter
        '
        Me.Tbl_job_MasterTableAdapter.ClearBeforeFill = True
        '
        'ucJobcode
        '
        Me.ucJobcode.AllowDrop = True
        Me.ucJobcode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucJobcode.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.JobCode, Me.JobName})
        Me.ucJobcode.Cursor = System.Windows.Forms.Cursors.Default
        Me.ucJobcode.FullRowSelect = True
        Me.ucJobcode.GridLines = True
        Me.ucJobcode.HideSelection = False
        Me.ucJobcode.HoverSelection = True
        Me.ucJobcode.LabelWrap = False
        Me.ucJobcode.Location = New System.Drawing.Point(217, 165)
        Me.ucJobcode.MultiSelect = False
        Me.ucJobcode.Name = "ucJobcode"
        Me.ucJobcode.ShowGroups = False
        Me.ucJobcode.Size = New System.Drawing.Size(229, 106)
        Me.ucJobcode.TabIndex = 16
        Me.ucJobcode.UseCompatibleStateImageBehavior = False
        Me.ucJobcode.View = System.Windows.Forms.View.Details
        '
        'JobCode
        '
        Me.JobCode.Tag = "Job Code"
        Me.JobCode.Text = "Job Code"
        Me.JobCode.Width = 101
        '
        'JobName
        '
        Me.JobName.Tag = "Job Name"
        Me.JobName.Text = "Job Name"
        Me.JobName.Width = 121
        '
        'FrmJobMaster
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtReqDays)
        Me.Controls.Add(Me.lblReqDays)
        Me.Controls.Add(Me.txtJobRate)
        Me.Controls.Add(Me.txtJobName)
        Me.Controls.Add(Me.txtJobcode)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblJobName)
        Me.Controls.Add(Me.lblJobCode)
        Me.Controls.Add(Me.lblJobmaster)
        Me.Controls.Add(Me.ucJobcode)
        Me.Name = "FrmJobMaster"
        Me.Text = "cmplaintMaster"
        CType(Me.TbljobMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIYALOERPDB100DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJobmaster As Label
    Friend WithEvents lblJobCode As Label
    Friend WithEvents lblJobName As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents txtJobcode As TextBox
    Friend WithEvents txtJobName As TextBox
    Friend WithEvents txtJobRate As TextBox
    Friend WithEvents lblReqDays As Label
    Friend WithEvents txtReqDays As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents RIYALOERPDB100DataSet As RIYALOERPDB100DataSet
    Friend WithEvents TbljobMasterBindingSource As BindingSource
    Friend WithEvents Tbl_job_MasterTableAdapter As RIYALOERPDB100DataSetTableAdapters.Tbl_job_MasterTableAdapter
    Friend WithEvents ucJobcode As ListView
    Friend WithEvents JobCode As ColumnHeader
    Friend WithEvents JobName As ColumnHeader
End Class
