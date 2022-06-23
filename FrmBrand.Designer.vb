<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBrand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBrand))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJobcode = New System.Windows.Forms.TextBox()
        Me.lblJObCode = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClose.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(574, 168)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(53, 45)
        Me.BtnClose.TabIndex = 59
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.BackgroundImage = CType(resources.GetObject("btnDel.BackgroundImage"), System.Drawing.Image)
        Me.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDel.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(437, 168)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(71, 45)
        Me.btnDel.TabIndex = 58
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(320, 168)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(67, 45)
        Me.BtnSave.TabIndex = 57
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(318, 132)
        Me.txtProduct.Multiline = True
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(309, 21)
        Me.txtProduct.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Product * "
        '
        'txtJobcode
        '
        Me.txtJobcode.Location = New System.Drawing.Point(318, 105)
        Me.txtJobcode.Multiline = True
        Me.txtJobcode.Name = "txtJobcode"
        Me.txtJobcode.ReadOnly = True
        Me.txtJobcode.Size = New System.Drawing.Size(309, 21)
        Me.txtJobcode.TabIndex = 61
        '
        'lblJObCode
        '
        Me.lblJObCode.AutoSize = True
        Me.lblJObCode.Font = New System.Drawing.Font("Sitka Heading", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJObCode.Location = New System.Drawing.Point(125, 105)
        Me.lblJObCode.Name = "lblJObCode"
        Me.lblJObCode.Size = New System.Drawing.Size(67, 21)
        Me.lblJObCode.TabIndex = 60
        Me.lblJObCode.Text = "Job Code"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(311, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 41)
        Me.lblTitle.TabIndex = 64
        Me.lblTitle.Text = "New Job Entry"
        '
        'FrmBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtJobcode)
        Me.Controls.Add(Me.lblJObCode)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "FrmBrand"
        Me.Text = "FrmBrand"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJobcode As TextBox
    Friend WithEvents lblJObCode As Label
    Friend WithEvents lblTitle As Label
End Class
