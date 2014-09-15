Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class Edit_User
    Dim tt = New ToolTip
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        animateWin(Me, False)
        Me.Close()
        animateWin(Manage_Users, True)
        Manage_Users.Show()
    End Sub

    Private Sub Edit_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Focus()
        tt = New ToolTip
        tt.SetToolTip(btnUpdate, "Update")
        tt.SetToolTip(btnCancel, "Cancel")
        SendMessage(Me.txtUsername.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtUsername.Handle, &H1501, 0, "Username")
        SendMessage(Me.txtOldPassword.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtOldPassword.Handle, &H1501, 0, "Old Password")
        SendMessage(Me.txtNewPassword.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtNewPassword.Handle, &H1501, 0, "New Password")
        SendMessage(Me.txtConfirmPassword.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtConfirmPassword.Handle, &H1501, 0, "Confirm Password")
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim sqlDataReader As MySqlDataReader = Nothing
        Dim sqlConnection As MySqlConnection = Nothing
        Dim sqlCommand As MySqlCommand = Nothing
        Dim conn As String = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"

        Dim RowsAffected As Integer = 0


        If Len(Trim(txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter the Username", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If

        If Len(Trim(txtOldPassword.Text)) = 0 Then
            MessageBox.Show("Please enter the Old Password", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOldPassword.Focus()
            Exit Sub
        End If

        If Len(Trim(txtNewPassword.Text)) = 0 Then
            MessageBox.Show("Please enter the New Password", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewPassword.Focus()
            Exit Sub
        End If

        If Len(Trim(txtConfirmPassword.Text)) = 0 Then
            MessageBox.Show("Please confirm the New Password", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmPassword.Focus()
            Exit Sub
        End If

        If txtNewPassword.TextLength < 5 Then
            MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtNewPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password did not match", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewPassword.Text = ""
            txtOldPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtOldPassword.Focus()
            Exit Sub
        ElseIf txtOldPassword.Text = txtNewPassword.Text Then
            MessageBox.Show("Password are the same. Please Enter a New Valid Password", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtNewPassword.Focus()
            Exit Sub
        End If
        sqlConnection = New MySqlConnection(conn)
        sqlConnection.Open()

        Dim edit As String = "UPDATE tbl_users set password = '" & txtNewPassword.Text & "' WHERE username='" & txtUsername.Text & "' and password = '" & txtOldPassword.Text & "'"

        sqlCommand = New MySqlCommand(edit)

        sqlCommand.Connection = sqlConnection
        RowsAffected = sqlCommand.ExecuteNonQuery()
        If RowsAffected > 0 Then

            MessageBox.Show("Successfully Changed", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Text = ""
            txtNewPassword.Text = ""
            txtOldPassword.Text = ""
            txtConfirmPassword.Text = ""
            animateWin(Me, False)
            Me.Close()
            animateWin(Manage_Users, True)
            Manage_Users.Show()
        Else

            MessageBox.Show("Invalid Username or Password", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Text = ""
            txtNewPassword.Text = ""
            txtOldPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtUsername.Focus()
        End If


        If sqlConnection.State = ConnectionState.Open Then
            sqlConnection.Close()
        End If
        sqlConnection.Close()

    End Sub
End Class