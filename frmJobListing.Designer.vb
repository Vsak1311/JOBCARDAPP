<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobListing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobListing))
        Me.ucJobList = New System.Windows.Forms.ListView()
        Me.c1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewJob = New System.Windows.Forms.Button()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PdfExport1 = New Spire.DataExport.PDF.PDFExport()
        Me.CellExport1 = New Spire.DataExport.XLS.CellExport()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucJobList
        '
        Me.ucJobList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucJobList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.c1, Me.c2, Me.c3, Me.c4, Me.c5, Me.c6, Me.c7, Me.c8, Me.c9})
        Me.ucJobList.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ucJobList.GridLines = True
        Me.ucJobList.HideSelection = False
        Me.ucJobList.HoverSelection = True
        Me.ucJobList.Location = New System.Drawing.Point(2, 142)
        Me.ucJobList.Name = "ucJobList"
        Me.ucJobList.Size = New System.Drawing.Size(1303, 544)
        Me.ucJobList.TabIndex = 0
        Me.ucJobList.UseCompatibleStateImageBehavior = False
        Me.ucJobList.View = System.Windows.Forms.View.Details
        '
        'c1
        '
        Me.c1.Text = "Date"
        Me.c1.Width = 75
        '
        'c2
        '
        Me.c2.Text = "Job No"
        Me.c2.Width = 70
        '
        'c3
        '
        Me.c3.Text = "Customer Name"
        Me.c3.Width = 165
        '
        'c4
        '
        Me.c4.Text = "Phone Number"
        Me.c4.Width = 116
        '
        'c5
        '
        Me.c5.Text = "Brand"
        Me.c5.Width = 121
        '
        'c6
        '
        Me.c6.Text = "Model"
        Me.c6.Width = 107
        '
        'c7
        '
        Me.c7.Text = "Complaint"
        Me.c7.Width = 366
        '
        'c8
        '
        Me.c8.Text = "Amount"
        Me.c8.Width = 128
        '
        'c9
        '
        Me.c9.Text = "Status"
        Me.c9.Width = 148
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(518, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "JOB LIST"
        '
        'btnNewJob
        '
        Me.btnNewJob.BackColor = System.Drawing.SystemColors.Window
        Me.btnNewJob.BackgroundImage = CType(resources.GetObject("btnNewJob.BackgroundImage"), System.Drawing.Image)
        Me.btnNewJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNewJob.ForeColor = System.Drawing.Color.Transparent
        Me.btnNewJob.Location = New System.Drawing.Point(13, 8)
        Me.btnNewJob.Name = "btnNewJob"
        Me.btnNewJob.Padding = New System.Windows.Forms.Padding(200)
        Me.btnNewJob.Size = New System.Drawing.Size(66, 41)
        Me.btnNewJob.TabIndex = 2
        Me.btnNewJob.UseVisualStyleBackColor = False
        '
        'BtnPdf
        '
        Me.BtnPdf.BackColor = System.Drawing.Color.Transparent
        Me.BtnPdf.BackgroundImage = CType(resources.GetObject("BtnPdf.BackgroundImage"), System.Drawing.Image)
        Me.BtnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPdf.Location = New System.Drawing.Point(1066, 10)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(61, 40)
        Me.BtnPdf.TabIndex = 3
        Me.BtnPdf.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExcel.BackgroundImage = CType(resources.GetObject("btnExcel.BackgroundImage"), System.Drawing.Image)
        Me.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcel.Location = New System.Drawing.Point(1133, 9)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(58, 40)
        Me.btnExcel.TabIndex = 4
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(1197, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 36)
        Me.Button4.TabIndex = 5
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PdfExport1
        '
        Me.PdfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
        Me.PdfExport1.Columns.AddRange(New Object() {"Date", "Job No", "Customer Name", "Phone Number", "Brand", "Model", "Complaint", "Amount", "Status"})
        Me.PdfExport1.DataFormats.CultureName = "en-US"
        Me.PdfExport1.DataFormats.Currency = "c"
        Me.PdfExport1.DataFormats.DateTime = "M/d/yyyy h:mm tt"
        Me.PdfExport1.DataFormats.Float = "g"
        Me.PdfExport1.DataFormats.Integer = "g"
        Me.PdfExport1.DataFormats.Time = "h:mm tt"
        Me.PdfExport1.DataSource = Spire.DataExport.Common.ExportSource.ListView
        Me.PdfExport1.ExportLongColumn = True
        Me.PdfExport1.ListView = Me.ucJobList
        Me.PdfExport1.PDFOptions.DataFont.CustomFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PdfExport1.PDFOptions.FooterFont.CustomFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PdfExport1.PDFOptions.HeaderFont.CustomFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PdfExport1.PDFOptions.PageOptions.Format = Spire.DataExport.PDF.PageFormat.User
        Me.PdfExport1.PDFOptions.PageOptions.Height = 11.67R
        Me.PdfExport1.PDFOptions.PageOptions.MarginBottom = 0.78R
        Me.PdfExport1.PDFOptions.PageOptions.MarginLeft = 1.17R
        Me.PdfExport1.PDFOptions.PageOptions.MarginRight = 0.57R
        Me.PdfExport1.PDFOptions.PageOptions.MarginTop = 0.78R
        Me.PdfExport1.PDFOptions.PageOptions.Width = 8.25R
        Me.PdfExport1.PDFOptions.TitleFont.CustomFont = New System.Drawing.Font("Arial", 10.0!)
        '
        'CellExport1
        '
        Me.CellExport1.DataFormats.CultureName = "en-US"
        Me.CellExport1.DataFormats.Currency = "$#,###,##0.00"
        Me.CellExport1.DataFormats.DateTime = "M/d/yyyy h:mm tt"
        Me.CellExport1.DataFormats.Float = "#,###,##0.00"
        Me.CellExport1.DataFormats.Integer = "#,###,##0"
        Me.CellExport1.DataFormats.Time = "h:mm tt"
        Me.CellExport1.DataSource = Spire.DataExport.Common.ExportSource.ListView
        Me.CellExport1.ExportLongColumn = True
        Me.CellExport1.ListView = Me.ucJobList
        Me.CellExport1.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
        Me.CellExport1.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.[Single]
        Me.CellExport1.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
        Me.CellExport1.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
        Me.CellExport1.SheetOptions.NoteFormat.Font.Bold = True
        Me.CellExport1.SheetOptions.NoteFormat.Font.Name = "Tahoma"
        Me.CellExport1.SheetOptions.NoteFormat.Font.Size = 8.0!
        Me.CellExport1.SheetOptions.TitlesFormat.Font.Bold = True
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogout.BackgroundImage = CType(resources.GetObject("BtnLogout.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogout.Location = New System.Drawing.Point(1257, 9)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(35, 37)
        Me.BtnLogout.TabIndex = 6
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'frmJobListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1317, 684)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.BtnPdf)
        Me.Controls.Add(Me.btnNewJob)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucJobList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmJobListing"
        Me.Text = "frmJobListing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucJobList As ListView
    Friend WithEvents c1 As ColumnHeader
    Friend WithEvents c2 As ColumnHeader
    Friend WithEvents c3 As ColumnHeader
    Friend WithEvents c4 As ColumnHeader
    Friend WithEvents c5 As ColumnHeader
    Friend WithEvents c6 As ColumnHeader
    Friend WithEvents c7 As ColumnHeader
    Friend WithEvents c8 As ColumnHeader
    Friend WithEvents c9 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewJob As Button
    Friend WithEvents BtnPdf As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CellExport1 As Spire.DataExport.XLS.CellExport
    Private WithEvents PdfExport1 As Spire.DataExport.PDF.PDFExport
    Friend WithEvents BtnLogout As Button
End Class
