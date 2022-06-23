Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO.Ports
Imports System.Configuration


Public Class FrmJobMaster

    Dim cnn As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim conn As String = ConfigurationManager.ConnectionStrings("Conn").ConnectionString
    Private Sub FrmJobMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RIYALOERPDB100DataSet.Tbl_job_Master' table. You can move, or remove it, as needed.
        Me.Tbl_job_MasterTableAdapter.Fill(Me.RIYALOERPDB100DataSet.Tbl_job_Master)
        txtJobcode.Text = "@Auto"
        ucJobcode.Visible = False
        If txtJobcode.Text = "@Auto" Then
            btnUpdate.Visible = False
        End If


    End Sub
    Private Sub Filluc()

        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("select JobCode,JobName from Tbl_job_Master", sqlCon)
            Dim TBD As New DataTable
            TBD.Clear()


            Adapter.Fill(TBD)
            If TBD IsNot Nothing AndAlso TBD.Rows.Count > 0 Then
                For Each row As DataRow In TBD.Rows
                    Dim lst As ListViewItem

                    lst = ucJobcode.Items.Add(If(row(0) IsNot Nothing, row("jobcode").ToString(), ""))
                    For i As Integer = 1 To TBD.Columns.Count - 1
                        lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString(), ""))
                    Next
                Next

            End If

            sqlCon.Close()

        End Using

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clear()
        txtJobcode.Text = "@Auto"
        ucJobcode.Visible = False



    End Sub
    Private Sub clear()
        txtJobcode.Text = ""
        txtJobName.Text = ""
        txtJobRate.Text = ""
        txtReqDays.Text = ""
        txtJobcode.Text = "@Auto"
        ucJobcode.Visible = False
        If txtJobcode.Text = "@Auto" Then
            btnUpdate.Visible = False
        Else
            btnUpdate.Visible = True

        End If

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
    Private Sub txtJobName_TextChanged(sender As Object, e As EventArgs) Handles txtJobName.TextChanged

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Savedata()
        MessageBox.Show("Data Added Succesfully!!")
        'ucJobcode.Clear()
        clear()
    End Sub
    Private Sub Savedata()
        Dim JObid As Int32 = 1000
        Dim pirntID As Int32
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()

            'Part for retrieving Maxcode 
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("exec Get_Transaction_ID ' Job_Master_Code '", sqlCon)
            Dim TBD As New DataSet
            Adapter.Fill(TBD)
            If TBD.Tables(0).Rows.Count > 0 Then
                JObid = TBD.Tables(0).Rows(0).Item(0)
            Else
                JObid = 0
            End If



            Dim qry As String = "Insert into Tbl_job_Master (JobCode,JobName,JobCharge,Days_Comp) VALUES (@JobCode,@Jobname,@Jobcharge,@Days_comp);SELECT SCOPE_IDENTITY()"
            Dim ins As New SqlClient.SqlCommand(qry, sqlCon)
            With ins.Parameters
                .AddWithValue("JobCode", Convert.ToInt32(JObid))
                .AddWithValue("Jobname", txtJobName.Text.Trim())
                .AddWithValue("Jobcharge", (txtJobRate.Text.Trim()))
                .AddWithValue("Days_comp", txtReqDays.Text.Trim())

            End With

            Try
                Dim obj As Object = ins.ExecuteScalar()
                pirntID = CLng(obj.ToString)
            Catch ex As Exception
                pirntID = 0
            End Try


            sqlCon.Close()


        End Using


    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        DelData()

        clear()
        Filluc()
    End Sub
    Private Sub DelData()
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim jobcode As String = txtJobcode.Text.Trim()

            Dim dqry As String = "delete from tbl_job_master where jobCode =  '" & jobcode & "'"

            Dim del As New SqlClient.SqlCommand(dqry, sqlCon)
            del.ExecuteScalar()
            sqlCon.Close()

        End Using
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If (ucJobcode.Visible = True) Then
            ucJobcode.Visible = False
            Filluc()
        Else

            ucJobcode.BringToFront()
            ucJobcode.Visible = True
            Filluc()
        End If



    End Sub
    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Tbl_job_MasterTableAdapter.FillBy(Me.RIYALOERPDB100DataSet.Tbl_job_Master)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub DispToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Tbl_job_MasterTableAdapter.disp(Me.RIYALOERPDB100DataSet.Tbl_job_Master)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub FrmJobMaster_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ucJobcode.Visible = False
    End Sub
    Private Sub Filldata()
        If ucJobcode.SelectedItems.Count > 0 Then
            Dim jobcode As String = ucJobcode.SelectedItems(0).Text
            Dim jobname As String = ucJobcode.SelectedItems(0).SubItems(1).Text
            Using sqlCon = New SqlConnection(conn)
                sqlCon.Open()
                Dim da As New SqlClient.SqlDataAdapter
                da.SelectCommand = New SqlClient.SqlCommand("select * from Tbl_job_Master where jobcode = '" & jobcode & "'", sqlCon)
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    txtJobcode.Text = dt.Rows(0).Item("jobcode")
                    txtJobName.Text = dt.Rows(0).Item("jobname")
                    txtJobRate.Text = dt.Rows(0).Item("jobCharge")
                    txtReqDays.Text = dt.Rows(0).Item("Days_comp")




                End If

                sqlCon.Close()
                ucJobcode.Visible = False
                If txtJobcode.Text = "@Auto" Then
                    btnUpdate.Visible = False
                Else
                    btnUpdate.Visible = True

                End If

            End Using
        End If
    End Sub
    Private Sub ucJobcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ucJobcode.SelectedIndexChanged

    End Sub
    Private Sub ucJobcode_Click(sender As Object, e As EventArgs) Handles ucJobcode.Click
        Filldata()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateData()
        MessageBox.Show("Data Updated Success!!!!")
        clear()
    End Sub
    Private Sub UpdateData()
        Dim jobcode = txtJobcode.Text.Trim()
        Dim jobname = txtJobName.Text.Trim()
        Dim charge = txtJobRate.Text.Trim()
        Dim days = txtReqDays.Text.Trim()
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            'Dim jobcode As String = txtJobcode.Text.Trim()

            Dim uqry As String = "Update tbl_job_master set jobName = '" & jobname & "',JobCharge = " & charge & ",Days_comp = " & days & "where jobcode = " & jobcode

            Dim del As New SqlClient.SqlCommand(uqry, sqlCon)
            del.ExecuteScalar()
            sqlCon.Close()

        End Using

    End Sub
End Class
