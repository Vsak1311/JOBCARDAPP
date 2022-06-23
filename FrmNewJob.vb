Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO.Ports
Imports System.Configuration


Public Class FrmNewJob

    Dim cnn As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim conn As String = ConfigurationManager.ConnectionStrings("Conn").ConnectionString
    Dim JobCode As Int32
    Dim CustID As Int32
    Dim CustName As String
    Dim PhoneNo As String
    Dim SNo As String
    Dim TID As Int32
    Dim BID As Int32
    Dim Cid As Int32
    Dim Product As String
    Dim year As Int32
    Dim expDelDate As DateTime
    Dim JobDate As DateTime
    Dim LocId As Int32
    Dim statusId As Int32
    Dim Notes As String
    Dim Items As String
    Dim Cond As String
    Dim cPrice As Decimal
    Dim Scharge As Decimal
    Dim Disc As Decimal
    Dim tot As Decimal


    'FrmJOBMAster
    Private Sub FrmNewJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlChk.Visible = False
        PnlSettlement.Visible = False
        pnlCustomer.Visible = False
        txtJobcode.Text = "@Auto"
        Clear()

    End Sub
    Private Sub FrmNewJob_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        pnlChk.Visible = False
        PnlSettlement.Visible = False
        pnlCustomer.Visible = False
    End Sub

    'Combobox click
    Private Sub cmbCustomer_Click(sender As Object, e As EventArgs) Handles cmbCustomer.Click
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("select CustCode,CustName from TblCustomer", sqlCon)
            Dim TBD As New DataTable
            TBD.Clear()
            Adapter.Fill(TBD)
            cmbCustomer.DataSource = TBD
            cmbCustomer.DisplayMember = "CustName"
            cmbCustomer.ValueMember = "CustCode"


            sqlCon.Close()
        End Using
    End Sub
    Private Sub cmbBrand_Click(sender As Object, e As EventArgs) Handles cmbBrand.Click
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("select Bid,Br_Name from TblBrand", sqlCon)
            Dim TBD As New DataTable
            TBD.Clear()
            Adapter.Fill(TBD)
            cmbBrand.DataSource = TBD
            cmbBrand.DisplayMember = "Br_Name"
            cmbBrand.ValueMember = "Bid"



            sqlCon.Close()
        End Using
    End Sub
    Private Sub CmbComplaint_Click(sender As Object, e As EventArgs) Handles CmbComplaint.Click
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("select CID,C_Desc from TblComplaint", sqlCon)
            Dim TBD As New DataTable
            TBD.Clear()
            Adapter.Fill(TBD)
            CmbComplaint.DataSource = TBD
            CmbComplaint.DisplayMember = "C_Desc"
            CmbComplaint.ValueMember = "CID"


            sqlCon.Close()
        End Using
    End Sub
    Private Sub cmbStatus_Click(sender As Object, e As EventArgs) Handles cmbStatus.Click
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("select ID,StatusName from TblStatus", sqlCon)
            Dim TBD As New DataTable
            TBD.Clear()
            Adapter.Fill(TBD)
            cmbStatus.DataSource = TBD
            cmbStatus.DisplayMember = "StatusName"
            cmbStatus.ValueMember = "ID"

            sqlCon.Close()
        End Using

    End Sub
    Private Sub cmbtech_Click(sender As Object, e As EventArgs) Handles cmbtech.Click
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("select Tid,T_Name from TblTEchnician", sqlCon)
            Dim TBD As New DataTable
            TBD.Clear()
            Adapter.Fill(TBD)
            cmbtech.DataSource = TBD
            cmbtech.DisplayMember = "T_Name"
            cmbtech.ValueMember = "TID"


            sqlCon.Close()
        End Using
    End Sub

    Private Sub cmbLoc_Click(sender As Object, e As EventArgs) Handles cmbLoc.Click

        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("select LocId,LocName from TblLocation", sqlCon)
            Dim TBD As New DataTable
            TBD.Clear()
            Adapter.Fill(TBD)
            cmbLoc.DataSource = TBD
            cmbLoc.DisplayMember = "LocName"
            cmbLoc.ValueMember = "LocId"


            sqlCon.Close()
        End Using
    End Sub


    'Combobutton click for master entry

    Private Sub BtnComplaint_Click(sender As Object, e As EventArgs) Handles BtnComplaint.Click
        Dim C_id As Int32 = 1000
        Dim pirntID As Int32
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("exec Get_Transaction_ID 'Cid'", sqlCon)
            Dim TBD As New DataSet
            Adapter.Fill(TBD)
            If TBD.Tables(0).Rows.Count > 0 Then
                Cid = TBD.Tables(0).Rows(0).Item(0)
            Else
                Cid = 0
            End If

            Dim qry As String = "Insert into TblComplaint (Cid,C_desc) VALUES (@Cid,@Cname);SELECT SCOPE_IDENTITY()"
            Dim ins As New SqlClient.SqlCommand(qry, sqlCon)
            With ins.Parameters
                .AddWithValue("Cid", Convert.ToInt32(Cid))
                .AddWithValue("Cname", CmbComplaint.Text.Trim())


            End With

            Try
                Dim obj As Object = ins.ExecuteScalar()
                MessageBox.Show("Complaint Added!!")


                pirntID = CLng(obj.ToString)

            Catch ex As Exception
                pirntID = 0
            End Try


            sqlCon.Close()


        End Using
    End Sub
    Private Sub BtnBrand_Click(sender As Object, e As EventArgs) Handles BtnBrand.Click
        Dim Cid As Int32 = 1000
        Dim pirntID As Int32
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("exec Get_Transaction_ID 'Bid'", sqlCon)
            Dim TBD As New DataSet
            Adapter.Fill(TBD)
            If TBD.Tables(0).Rows.Count > 0 Then
                Cid = TBD.Tables(0).Rows(0).Item(0)
            Else
                Cid = 0
            End If

            Dim qry As String = "Insert into TblBrand (Bid,Br_name) VALUES (@Bid,@Bname);SELECT SCOPE_IDENTITY()"
            Dim ins As New SqlClient.SqlCommand(qry, sqlCon)
            With ins.Parameters
                .AddWithValue("Bid", Convert.ToInt32(Cid))
                .AddWithValue("Bname", cmbBrand.Text)


            End With

            Try
                Dim obj As Object = ins.ExecuteScalar()
                MessageBox.Show("Brand Added!!")
                pirntID = CLng(obj.ToString)

            Catch ex As Exception
                pirntID = 0
            End Try


            sqlCon.Close()
        End Using

    End Sub
    Private Sub BtnTEch_Click(sender As Object, e As EventArgs) Handles BtnTEch.Click
        Dim Cid As Int32 = 1000
        Dim pirntID As Int32
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("exec Get_Transaction_ID 'Tid'", sqlCon)
            Dim TBD As New DataSet
            Adapter.Fill(TBD)
            If TBD.Tables(0).Rows.Count > 0 Then
                Cid = TBD.Tables(0).Rows(0).Item(0)
            Else
                Cid = 0
            End If

            Dim qry As String = "Insert into TblTEchnician (Tid,T_name) VALUES (@Cid,@Cname);SELECT SCOPE_IDENTITY()"
            Dim ins As New SqlClient.SqlCommand(qry, sqlCon)
            With ins.Parameters
                .AddWithValue("Cid", Convert.ToInt32(Cid))
                .AddWithValue("Cname", cmbtech.Text.Trim())


            End With

            Try
                Dim obj As Object = ins.ExecuteScalar()
                MessageBox.Show("Technician Added!!")
                pirntID = CLng(obj.ToString)

            Catch ex As Exception
                pirntID = 0
            End Try


            sqlCon.Close()


        End Using
    End Sub
    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        pnlCustomer.BringToFront()
        pnlCustomer.Visible = True


    End Sub

    Private Sub BtnAddLoc_Click(sender As Object, e As EventArgs) Handles BtnAddLoc.Click
        Dim Cid As Int32 = 1000
        Dim pirntID As Int32
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("exec Get_Transaction_ID 'LocId'", sqlCon)
            Dim TBD As New DataSet
            Adapter.Fill(TBD)
            If TBD.Tables(0).Rows.Count > 0 Then
                Cid = TBD.Tables(0).Rows(0).Item(0)
            Else
                Cid = 0
            End If

            Dim qry As String = "Insert into TblLocation (LocId,LocName) VALUES (@Cid,@Cname);SELECT SCOPE_IDENTITY()"
            Dim ins As New SqlClient.SqlCommand(qry, sqlCon)
            With ins.Parameters
                .AddWithValue("Cid", Convert.ToInt32(Cid))
                .AddWithValue("Cname", cmbLoc.Text.Trim())


            End With

            Try
                Dim obj As Object = ins.ExecuteScalar()
                MessageBox.Show("Location Added!!")
                pirntID = CLng(obj.ToString)

            Catch ex As Exception
                pirntID = 0
            End Try


            sqlCon.Close()


        End Using

    End Sub


    'Comboboc leave

    Private Sub cmbCustomer_Leave(sender As Object, e As EventArgs) Handles cmbCustomer.Leave

        CustID = Convert.ToInt32(cmbCustomer.SelectedValue.ToString())
    End Sub
    Private Sub cmbtech_Leave(sender As Object, e As EventArgs) Handles cmbtech.Leave
        TID = Convert.ToInt32(cmbtech.SelectedValue.ToString())
    End Sub
    Private Sub cmbBrand_Leave(sender As Object, e As EventArgs) Handles cmbBrand.Leave
        BID = Convert.ToInt32(cmbBrand.SelectedValue.ToString())
    End Sub
    Private Sub CmbComplaint_Leave(sender As Object, e As EventArgs) Handles CmbComplaint.Leave
        Cid = Convert.ToInt32(CmbComplaint.SelectedValue.ToString())
    End Sub
    Private Sub cmbLoc_Leave(sender As Object, e As EventArgs) Handles cmbLoc.Leave
        If cmbLoc.SelectedValue.ToString() Is Nothing Then
            LocId = 1
        Else
            LocId = Convert.ToInt32(cmbLoc.SelectedValue.ToString())
        End If

    End Sub

    Private Sub cmbStatus_Leave(sender As Object, e As EventArgs) Handles cmbStatus.Leave
        If cmbStatus.Text = "DELIVERED" Then
            PnlSettlement.BringToFront()

            PnlSettlement.Visible = True
        Else
            PnlSettlement.SendToBack()

            PnlSettlement.Visible = False

        End If
        statusId = Convert.ToInt32(cmbStatus.SelectedValue.ToString())

    End Sub

    'Other functions
    Private Sub BtnChk_Click(sender As Object, e As EventArgs) Handles BtnChk.Click
        pnlChk.BringToFront()

        pnlChk.Visible = True

    End Sub

    Private Sub Clear()
        pnlChk.Visible = False
        PnlSettlement.Visible = False
        pnlCustomer.Visible = False
        txtJobcode.Text = "@Auto"
        txtCopies.Text = ""
        txtCprice.Text = ""
        txtDisc.Text = ""
        txtNotes.Text = ""
        txtPhone.Text = ""
        txtProduct.Text = ""
        txtScharge.Text = ""
        txtSerialNo.Text = ""
        txtTotal.Text = ""
        txtVAT.Text = ""
        txtYear.Text = ""
        cmbBrand.Text = "Select"
        cmbCustomer.Text = "Select"
        cmbLoc.Text = "Select"
        cmbStatus.Text = "Select"
        cmbtech.Text = "Select"
        CmbComplaint.Text = "Select"

    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmJobListing.Show()
    End Sub

    Private Sub dgvChk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub btnPnlchkClose_Click(sender As Object, e As EventArgs) Handles btnPnlchkClose.Click
        pnlChk.Visible = False
    End Sub
    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged

    End Sub
    Private Sub btnPnlSettleClose_Click(sender As Object, e As EventArgs) Handles btnPnlSettleClose.Click
        PnlSettlement.Visible = False
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub
    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        frmJobListing.Show()
        Me.Hide()

    End Sub
    Private Sub BtnCustClose_Click(sender As Object, e As EventArgs) Handles BtnCustClose.Click
        pnlCustomer.SendToBack()
        pnlCustomer.Visible = False
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        savedata()
    End Sub

    Private Sub savedata()
        insjob()
        insChk()

        MessageBox.Show("Job Added Succesfully!!")




    End Sub
    Private Sub insjob()
        Dim JObid As Int32 = 1000
        Dim pirntID As Int32
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()

            'Part for retrieving Maxcode 
            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("exec Get_Transaction_ID ' JobId '", sqlCon)
            Dim TBD As New DataSet
            Adapter.Fill(TBD)
            If TBD.Tables(0).Rows.Count > 0 Then
                JObid = TBD.Tables(0).Rows(0).Item(0)
                JobCode = JObid
            Else
                JObid = 0
            End If



            Dim qry As String = "Insert into TblJobMaster (Jobcode, CustId, CustName, PhNo, TechID, BrandID, Prod_Name, SNo, Cid, Year, Exp_Del_date, JobDate, LocId, StatusID, Notes) 
                                 VALUES ( @Jobcode, @CustId, @CustName, @PhNo, @TechID, @BrandID, @Prod_Name, @SNo, @Cid, @Year, @Exp_Del_date, @JobDate, @LocId, @StatusID, @Notes);SELECT SCOPE_IDENTITY()"
            Dim ins As New SqlClient.SqlCommand(qry, sqlCon)
            With ins.Parameters
                .AddWithValue("JobCode", Convert.ToInt32(JObid))
                .AddWithValue("CustId", CustID)
                .AddWithValue("CustName", cmbCustomer.Text.Trim())
                .AddWithValue("PhNo", txtPhone.Text.Trim())
                .AddWithValue("TechID", TID)
                .AddWithValue("BrandID", BID)
                .AddWithValue("Prod_Name", txtProduct.Text.Trim())
                .AddWithValue("SNo", txtSerialNo.Text.Trim())
                .AddWithValue("Cid", Cid)
                .AddWithValue("Year", txtYear.Text.Trim())
                .AddWithValue("Exp_Del_date", dtpExpDel.Value)
                .AddWithValue("JobDate", dtpExpDel.Value)
                .AddWithValue("LocId", LocId)
                .AddWithValue("StatusID", statusId)
                .AddWithValue("Notes", txtNotes.Text.Trim())

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

    Private Sub insChk()
        Dim JObid As Int32
        Dim pirntID As Int32
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()



            For Each rw As DataGridViewRow In dgvChk.Rows
                If rw.Cells("Item").Value IsNot Nothing Then
                    Dim Adapter As New SqlClient.SqlDataAdapter
                    Adapter.SelectCommand = New SqlClient.SqlCommand("exec Get_Transaction_ID ' chkid '", sqlCon)
                    Dim TBD As New DataSet
                    Adapter.Fill(TBD)
                    If TBD.Tables(0).Rows.Count > 0 Then
                        JObid = TBD.Tables(0).Rows(0).Item(0)
                    Else
                        JObid = 0
                    End If
                    Dim qry As String = "insert into  TblChecklist (ChkId, JobId, Item, Condition) values (@chkId,@JobId,@Item,@Cond)"
                    Dim ins As New SqlClient.SqlCommand(qry, sqlCon)
                    With ins.Parameters
                        .AddWithValue("ChkId", Convert.ToInt32(JObid))
                        .AddWithValue("JobId", JobCode)
                        .AddWithValue("Item", rw.Cells("Item").Value)
                        .AddWithValue("Cond", rw.Cells("Condition").Value)
                    End With


                    ins.ExecuteNonQuery()

                End If
            Next



            sqlCon.Close()


        End Using
    End Sub

    Private Sub Settle()
        Dim Sidd As Int32
        Dim pirntID As Int32
        Using sqlCon = New SqlConnection(conn)
            sqlCon.Open()

            Dim Adapter As New SqlClient.SqlDataAdapter
            Adapter.SelectCommand = New SqlClient.SqlCommand("exec Get_Transaction_ID ' Sid '", sqlCon)
            Dim TBD As New DataSet
            Adapter.Fill(TBD)
            If TBD.Tables(0).Rows.Count > 0 Then
                Sidd = TBD.Tables(0).Rows(0).Item(0)
            Else
                Sidd = 0
            End If



            Dim qry As String = "Insert into TblSettlement ( Sid, JobId, CPrice, SPrice, Disc, VAT) 
                                 VALUES (  @Sid, @JobId, @CPrice, @SPrice, @Disc, @VAT);SELECT SCOPE_IDENTITY()"
            Dim ins As New SqlClient.SqlCommand(qry, sqlCon)
            With ins.Parameters
                .AddWithValue("Sid", Convert.ToInt32(Sidd))
                .AddWithValue("JobId", JobCode)
                .AddWithValue("CPrice", txtCprice.Text.Trim())
                .AddWithValue("SPrice", txtScharge.Text.Trim())
                .AddWithValue("Disc", txtDisc.Text.Trim())



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


End Class