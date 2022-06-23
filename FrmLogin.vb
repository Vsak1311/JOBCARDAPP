Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO.Ports
Imports System.Configuration

Public Class FrmLogin
    Dim cnn As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim conn As String = ConfigurationManager.ConnectionStrings("Conn").ConnectionString
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub
    Private Sub Login()
        Dim username = txtUserName.Text.Trim()
        Dim password = txtPwd.Text.Trim()
        Dim Iuser As Long
        Dim IPwd As Integer = 0
        Using sqlCon = New SqlConnection(conn)

            sqlCon.Open()
            Dim Adapter As New SqlClient.SqlDataAdapter
            Dim ins = New SqlClient.SqlCommand("select * from TblUsers where username = '" & username & "' and password = '" & EncrypPassword(password.ToString()) & "'", sqlCon)
            Try
                Dim obj As Object = ins.ExecuteScalar()
                If obj Is Nothing Then
                    MessageBox.Show("Invalid Username or Password.Please Check the Credentials!!")
                    clear()
                    txtUserName.Focus()

                Else
                    'Iuser = CLng(obj.ToString)
                    'MessageBox.Show("Success!!!")
                    LoadJoblistings()
                    clear()
                End If

            Catch ex As Exception
                Iuser = 0
            End Try

            sqlCon.Close()

        End Using
    End Sub
    Private Sub LoadJoblistings()
        frmJobListing.Show()
        Me.Hide()
    End Sub
    Private Sub clear()
        txtPwd.Text = ""
        txtUserName.Text = ""

    End Sub

    Public Function EncrypPassword(ByVal str As String) As String
        If str.Length = 0 Then
            Return ""
        Else
            Return Crypto.Encrypt(str, "")
        End If

    End Function

    Private Sub txtPwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPwd.KeyPress

    End Sub

    Private Sub txtPwd_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.TextChanged

    End Sub

    Private Sub txtPwd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
            btnLogin.Focus()

        End If
    End Sub

    Private Sub txtUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPwd.Focus()
        End If
    End Sub


End Class