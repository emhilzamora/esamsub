Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Admin_Login
    'Represents an SQL statement or stored procedure to execute against a data source.
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    'declare con as connection and it will now a new connection because 
    'it is equal to Getconnection Function
    Dim sqlConnection As MySqlConnection = loginConnection()
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Dim tt As New ToolTip
    'public connection
    Public Function loginConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=esamsub2014")
    End Function
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'clear fields
        txtPassword.Text = Nothing
        txtUsername.Text = Nothing
        'back to start up
        animateWin(Me, False)
        Me.Close()
        animateWin(Startup, True)
        Startup.Show()
    End Sub


    Private Sub Admin_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'hint sa textbox
        SendMessage(Me.txtUsername.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtUsername.Handle, &H1501, 0, "Username")
        SendMessage(Me.txtPassword.Handle, &H1501, 0, "$X.XX")
        SendMessage(Me.txtPassword.Handle, &H1501, 0, "Password")

        'tooltpips para sa mouse hover
        tt = New ToolTip
        tt.SetToolTip(btnBack, "Back to Startup")
        tt.SetToolTip(btnLogin, "Proceed")
    End Sub

    Private Sub chkShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPassword.CheckedChanged
        'show password code
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = Nothing
        Else
            txtPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Up Then
            txtUsername.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            Dim sql As String
            Dim publictable As New DataTable
            Try
                'check if the textbox is equal to nothing then it will display the message below!.
                If txtUsername.Text = Nothing Then
                    MessageBox.Show("No Username Entered", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Focus()
                ElseIf txtPassword.Text = Nothing Then
                    MessageBox.Show("No Password Entered", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Focus()
                Else
                    sql = "select * from tbl_users where username ='" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
                    'bind the connection and query
                    With cmd
                        .Connection = sqlConnection
                        .CommandText = sql
                    End With
                    da.SelectCommand = cmd
                    da.Fill(publictable)
                    'check if theres a result by getting the count number of rows
                    If publictable.Rows.Count > 0 Then

                        'it gets the data from specific column and assign to the variable
                        Dim user_type, name As String
                        user_type = publictable.Rows(0).Item(1)
                        name = publictable.Rows(0).Item(2)
                        'check if the type of user is admin
                        If user_type = "Administrator" Then
                            'welcomes the user as Admiistrator
                            MessageBox.Show("Welcome " & name & " you login as Administrator ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'enabled user level
                            animateWin(Me, False)
                            'set the lbllogin text to Logout 
                            animateWin(Dashboard, True)
                            Dashboard.Show()
                            Dashboard.lblAdmin.Visible = True
                            txtUsername.Text = Nothing
                            txtPassword.Text = Nothing
                            Me.Hide()
                        End If

                    Else
                        MessageBox.Show("Please contact the Administrator", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtUsername.Text = Nothing
                        txtPassword.Text = Nothing
                        txtUsername.Focus()
                    End If

                    da.Dispose()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            sqlConnection.Clone()
        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Down Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim sql As String
        Dim publictable As New DataTable
        Try
            'check if the textbox is equal to nothing then it will display the message below!.
            If txtUsername.Text = Nothing Then
                MessageBox.Show("No Username Entered", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
            ElseIf txtPassword.Text = Nothing Then
                MessageBox.Show("No Password Entered", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
            Else
                sql = "select * from tbl_users where username ='" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
                'bind the connection and query
                With cmd
                    .Connection = sqlConnection
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(publictable)
                'check if theres a result by getting the count number of rows
                If publictable.Rows.Count > 0 Then

                    'it gets the data from specific column and assign to the variable
                    Dim user_type, name As String
                    user_type = publictable.Rows(0).Item(1)
                    name = publictable.Rows(0).Item(2)
                    'check if the type of user is admin
                    If user_type = "Administrator" Then
                        'welcomes the user as Admiistrator
                        MessageBox.Show("Welcome " & name & " you login as Administrator ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'enabled user level
                        animateWin(Me, False)
                        'set the lbllogin text to Logout 
                        animateWin(Dashboard, True)
                        Dashboard.Show()
                        Dashboard.lblAdmin.Visible = True
                        txtUsername.Text = Nothing
                        txtPassword.Text = Nothing
                        Me.Hide()
                    End If

                Else
                    MessageBox.Show("Please contact the Administrator", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Text = Nothing
                    txtPassword.Text = Nothing
                    txtUsername.Focus()
                End If

                da.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        sqlConnection.Clone()
    End Sub

End Class