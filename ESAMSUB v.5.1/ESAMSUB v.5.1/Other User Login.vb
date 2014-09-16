Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Other_User_Login
    'Represents an SQL statement or stored procedure to execute against a data source.
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    'declare con as connection and it will now a new connection because 
    'it is equal to Getconnection Function
    Dim con As MySqlConnection = loginConnection()
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Dim tt As New ToolTip
    'public connection
    Public Function loginConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=esamsub2014")
    End Function
    Private Sub Other_User_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbUserType.Focus()
        'hint ng textbox
        SendMessage(Me.cmbUserType.Handle, &H1501, 0, "$X.XX")
        SendMessage(Me.cmbUserType.Handle, &H1501, 0, "--Select UserType--")
        SendMessage(Me.txtUsername.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtUsername.Handle, &H1501, 0, "Username")
        SendMessage(Me.txtPassword.Handle, &H1501, 0, "$X.XX")
        SendMessage(Me.txtPassword.Handle, &H1501, 0, "Password")
        'tooltip
        tt = New ToolTip
        tt.SetToolTip(btnBack, "Back to Startup")
        tt.SetToolTip(btnLogin, "Proceed")
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim sql As String
        Dim publictable As New DataTable
        Try
            'check if the textbox is equal to nothing then it will display the message below!.
            If cmbUserType.Text = Nothing Then
                MessageBox.Show("Select User Type", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbUserType.Focus()
            ElseIf txtUsername.Text = Nothing Then
                MessageBox.Show("No Username Entered", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
            ElseIf txtPassword.Text = Nothing Then
                MessageBox.Show("No Password Entered", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()

            Else
                sql = "select * from tbl_users where user_type = '" & cmbUserType.Text & "' and username ='" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
                'bind the connection and query
                With cmd
                    .Connection = con
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
                    If user_type = "Registrar" Then
                        MessageBox.Show("Welcome " & name & " you login as Registrar", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If Dashboard.lblAdmin.Text = "Registrar" Then
                            Dashboard.btnStudents.Enabled = True
                        End If
                        cmbUserType.Text = Nothing
                        txtUsername.Text = Nothing
                        txtPassword.Text = Nothing
                        animateWin(Me, False)
                        animateWin(Students, True)
                        Students.Show()
                        Dashboard.lblRegistrar.Visible = True
                        Me.Hide()
                    ElseIf user_type = "Id Room Personnel" Then
                        MessageBox.Show("Welcome " & name & " you login as ID Room Personnel ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cmbUserType.Text = Nothing
                        txtUsername.Text = Nothing
                        txtPassword.Text = Nothing
                        animateWin(Me, False)
                        Me.Hide()
                        animateWin(Print_Id_Cards, True)
                        Print_Id_Cards.Show()
                        Dashboard.lblIdroom.Visible = True
                    ElseIf user_type = "Security Personnel" Then
                        MessageBox.Show("Welcome " & name & " you login as Security Personnel ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cmbUserType.Text = Nothing
                        txtUsername.Text = Nothing
                        txtPassword.Text = Nothing
                        animateWin(Me, False)
                        Me.Hide()
                        animateWin(Monitoring, True)
                        Monitoring.Show()
                        Dashboard.lblSecurity.Visible = true
                    ElseIf user_type = "Librarian" Then
                        MessageBox.Show("Welcome " & name & " you login as Librarian ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cmbUserType.Text = Nothing
                        txtUsername.Text = Nothing
                        txtPassword.Text = Nothing
                        animateWin(Me, False)
                        Me.Hide()
                        animateWin(Internet_Access_Usage, True)
                        Internet_Access_Usage.Show()
                        Dashboard.lblLibrarian.Visible = True
                    ElseIf user_type = "Department Head" Then
                        MessageBox.Show("Welcome " & name & " you login as Department Head ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cmbUserType.Text = Nothing
                        txtUsername.Text = Nothing
                        txtPassword.Text = Nothing
                        animateWin(Me, False)
                        Me.Hide()
                        animateWin(Monitoring, True)
                        Monitoring.Show()
                        Dashboard.lblHead.Visible = True
                    End If
                Else
                    MessageBox.Show("Please contact the Administrator", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Text = Nothing
                    txtPassword.Text = Nothing
                    cmbUserType.Text = Nothing
                    cmbUserType.Focus()
                End If

                da.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        con.Clone()
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
                If cmbUserType.Text = Nothing Then
                    MessageBox.Show("Select User Type", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cmbUserType.Focus()
                ElseIf txtUsername.Text = Nothing Then
                    MessageBox.Show("No Username Entered", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Focus()
                ElseIf txtPassword.Text = Nothing Then
                    MessageBox.Show("No Password Entered", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Focus()

                Else
                    sql = "select * from tbl_users where user_type = '" & cmbUserType.Text & "' and username ='" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
                    'bind the connection and query
                    With cmd
                        .Connection = con
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
                        If user_type = "Registrar" Then
                            MessageBox.Show("Welcome " & name & " you login as Registrar", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If Dashboard.lblAdmin.Text = "Registrar" Then
                                Dashboard.btnStudents.Enabled = True
                            End If
                            cmbUserType.Text = Nothing
                            txtUsername.Text = Nothing
                            txtPassword.Text = Nothing
                            animateWin(Me, False)
                            animateWin(Students, True)
                            Students.Show()
                            Dashboard.lblRegistrar.Visible = True
                            Me.Hide()
                        ElseIf user_type = "Id Room Personnel" Then
                            MessageBox.Show("Welcome " & name & " you login as ID Room Personnel ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cmbUserType.Text = Nothing
                            txtUsername.Text = Nothing
                            txtPassword.Text = Nothing
                            animateWin(Me, False)
                            Me.Hide()
                            animateWin(Print_Id_Cards, True)
                            Print_Id_Cards.Show()
                            Dashboard.lblIdroom.Visible = True
                        ElseIf user_type = "Security Personnel" Then
                            MessageBox.Show("Welcome " & name & " you login as Security Personnel ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cmbUserType.Text = Nothing
                            txtUsername.Text = Nothing
                            txtPassword.Text = Nothing
                            animateWin(Me, False)
                            Me.Hide()
                            animateWin(Monitoring, True)
                            Monitoring.Show()
                            Dashboard.lblSecurity.Visible = True
                        ElseIf user_type = "Librarian" Then
                            MessageBox.Show("Welcome " & name & " you login as Librarian ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cmbUserType.Text = Nothing
                            txtUsername.Text = Nothing
                            txtPassword.Text = Nothing
                            animateWin(Me, False)
                            Me.Hide()
                            animateWin(Internet_Access_Usage, True)
                            Internet_Access_Usage.Show()
                            Dashboard.lblLibrarian.Visible = True
                        ElseIf user_type = "Department Head" Then
                            MessageBox.Show("Welcome " & name & " you login as Department Head ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cmbUserType.Text = Nothing
                            txtUsername.Text = Nothing
                            txtPassword.Text = Nothing
                            animateWin(Me, False)
                            Me.Hide()
                            animateWin(Monitoring, True)
                            Monitoring.Show()
                            Dashboard.lblHead.Visible = True
                        End If
                    Else
                        MessageBox.Show("Please contact the Administrator", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtUsername.Text = Nothing
                        txtPassword.Text = Nothing
                        cmbUserType.Text = Nothing
                        cmbUserType.Focus()
                    End If

                    da.Dispose()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            con.Clone()
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPassword.CheckedChanged
        'show password code
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = Nothing
        Else
            txtPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Up Then
            cmbUserType.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'clear fields
        txtPassword.Text = Nothing
        txtUsername.Text = Nothing
        'back to startup
        animateWin(Me, False)
        Me.Close()
        animateWin(Startup, True)
    End Sub
End Class