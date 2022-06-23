Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO.Ports
Imports System.Configuration
Imports Spire.DataExport.PDF
Imports System.Data
Imports System.Data.OleDb




Public Class frmJobListing
    Dim cnn As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim conn As String = ConfigurationManager.ConnectionStrings("Conn").ConnectionString
    Public jobid As Int32
    Dim JobCode As String
    Private Sub frmJobListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldata()
    End Sub
    Private Sub filldata()
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("select * from vw_JobMaster order by JObDate desc", sqlCon)
            Dim TBD As New DataTable

            TBD.Clear()
            Adapter.Fill(TBD)
            If TBD IsNot Nothing AndAlso TBD.Rows.Count > 0 Then
                For Each row As DataRow In TBD.Rows
                    Dim lst As ListViewItem

                    lst = ucJobList.Items.Add(If(row(0) IsNot Nothing, row("JobDate").ToString(), ""))
                    For i As Integer = 1 To TBD.Columns.Count - 1
                        lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString(), ""))
                    Next
                Next

            End If

            sqlCon.Close()

        End Using
    End Sub

    Private Sub frmJobListing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'FrmJobMaster.Show()
        Me.Close()

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        'Try
        '    Dim objExcel As New Excel.Application
        '    Dim bkWorkBook As Workbook
        '    Dim shWorkSheet As Worksheet
        '    Dim i As Integer
        '    Dim j As Integer

        '    objExcel = New Excel.Application
        '    bkWorkBook = objExcel.Workbooks.Add
        '    shWorkSheet = CType(bkWorkBook.ActiveSheet, Worksheet)
        '    For i = 0 To Me.ucJobList.Columns.Count - 1
        '        shWorkSheet.Cells(1, i + 1) = Me.ucJobList.Columns(i).Text
        '    Next
        '    For i = 0 To Me.ucJobList.Items.Count - 1
        '        For j = 0 To Me.ucJobList.Items(i).SubItems.Count - 1
        '            shWorkSheet.Cells(i + 2, j + 1) = Me.ucJobList.Items(i).SubItems(j).Text
        '        Next
        '    Next

        '    objExcel.Visible = True
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


    End Sub

    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles BtnPdf.Click

    End Sub

    Private Sub btnNewJob_Click(sender As Object, e As EventArgs) Handles btnNewJob.Click
        FrmNewJob.Show()
        Me.Hide()
    End Sub



    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            'Me.CellExport1.ActionAfterExport = DataExport.Common.ActionType.None
            'Me.CellExport1.DataFormats.CultureName = "zh-CN"
            'Me.CellExport1.DataFormats.Currency = "?#,###,##0.00"
            'Me.CellExport1.DataFormats.DateTime = "yyyy-M-d H:mm"
            'Me.CellExport1.DataFormats.Float = "#,###,##0.00"
            'Me.CellExport1.DataFormats.Integer = "#,###,##0"
            'Me.CellExport1.DataFormats.Time = "H:mm"
            'Me.CellExport1.SheetOptions.AggregateFormat.Font.Name = "Arial"
            'Me.CellExport1.SheetOptions.CustomDataFormat.Font.Name = "Arial"
            'Me.CellExport1.SheetOptions.DefaultFont.Name = "Arial"
            'Me.CellExport1.SheetOptions.FooterFormat.Font.Name = "Arial"
            'Me.CellExport1.SheetOptions.HeaderFormat.Font.Name = "Arial"
            'Me.CellExport1.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue
            'Me.CellExport1.SheetOptions.HyperlinkFormat.Font.Name = "Arial"
            'Me.CellExport1.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single
            'Me.CellExport1.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left
            'Me.CellExport1.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top
            'Me.CellExport1.SheetOptions.NoteFormat.Font.Bold = True
            'Me.CellExport1.SheetOptions.NoteFormat.Font.Name = "Tahoma"
            'Me.CellExport1.SheetOptions.NoteFormat.Font.Size = 8.0F
            'Me.CellExport1.SheetOptions.TitlesFormat.Font.Bold = True
            'Me.CellExport1.SheetOptions.TitlesFormat.Font.Name = "Arial"
            'Me.CellExport1.DataSource = DataExport.Common.ExportSource.ListView
            'Me.CellExport1.ListView = Me.listView1
            'Dim stream As New MemoryStream()
            'CellExport1.SaveToFile(stream)
            'stream.Close()
            'Me.oleDbConnection1.Close()
            'Dim workbook As New Workbook(stream)

            'Dim pdfConverter As New PdfConverter(workbook)

            'Dim pdfDocument As New PdfDocument()
            'pdfDocument.PageSettings.Orientation = pdf.PdfPageOrientation.Landscape
            'pdfDocument.PageSettings.Width = 970
            'pdfDocument.PageSettings.Height = 850

            'Dim settings As New PdfConverterSettings()
            'settings.TemplateDocument = pdfDocument
            'pdfDocument = pdfConverter.Convert(settings)

            'pdfDocument.SaveToFile("test.pdf")
            sqlCon.Close()
        End Using

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub ucJobList_DoubleClick(sender As Object, e As EventArgs) Handles ucJobList.DoubleClick
        Dim result As DialogResult = MessageBox.Show("Do You Really Want to Edit the Data.", "Edit Data", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            Me.Show()
        ElseIf result = DialogResult.No Then
            Me.Show()
        ElseIf result = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            Me.Hide()
            FrmJobEdit.Show()
        End If



    End Sub

    Private Sub ucJobList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ucJobList.SelectedIndexChanged

        JobCode = ucJobList.Items(ucJobList.FocusedItem.Index).SubItems(1).Text
        Jobid = Convert.ToInt32(JobCode)
    End Sub

End Class