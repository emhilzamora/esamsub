Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class Add_New_User
    Dim sqlConnection = New MySqlConnection
    Dim tt1 = New ToolTip
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearTextBoxes()
        animateWin(Me, False)
        Me.Close()
        animateWin(Manage_Users, True)
        Manage_Users.Show()
    End Sub

    Private Sub Add_New_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'focus sa combo box
        cmbUserType.Focus()
        'tooltip
        tt1 = New ToolTip
        tt1.SetToolTip(btnSave, "Save")
        tt1.SetToolTip(btnCancel, "Cancel")
        'textbox hints
        'hint sa textbox
        SendMessage(Me.txtUsername.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtUsername.Handle, &H1501, 0, "Username")
        SendMessage(Me.txtPassword.Handle, &H1501, 0, "$X.XX")
        SendMessage(Me.txtPassword.Handle, &H1501, 0, "Password")
        SendMessage(Me.txtRetypeUserPassword.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtRetypeUserPassword.Handle, &H1501, 0, "Re-type Password")
        SendMessage(Me.txtContact.Handle, &H1501, 0, "$X.XX")
        SendMessage(Me.txtContact.Handle, &H1501, 0, "Cellphone Number")
    End Sub
    'Code for Smart Clear of Textbox
    Public Sub ClearTextBoxes()
        txtContact.Text = ""
        txtPassword.Text = ""
        txtRetypeUserPassword.Text = ""
        txtUsername.Text = ""
        cmbUserType.Text = ""
    End Sub
    'Button Save
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtPassword.TextLength < 5 Then
            MessageBox.Show("The Password should be atleast 5 Characters", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
            txtRetypeUserPassword.Text = ""
            txtPassword.Focus()
            Exit Sub
        End If
        If cmbUserType.Text = "" And txtContact.Text = "" And txtPassword.Text = "" And txtUsername.Text = "" Then
            MessageBox.Show("Required fields are Empty", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearTextBoxes()
            cmbUserType.Focus()
        ElseIf txtUsername.Text = Nothing Then
            MessageBox.Show("Username is Required field", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
        ElseIf txtPassword.Text = Nothing Then
            MessageBox.Show("Password is Required field", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
        ElseIf txtRetypeUserPassword.Text = Nothing Then
            MessageBox.Show("Re-Type your Password", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRetypeUserPassword.Focus()
        ElseIf txtPassword.Text <> txtRetypeUserPassword.Text Then
            MessageBox.Show("Passwords doesn't Match", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = Nothing
            txtRetypeUserPassword.Text = Nothing
            txtPassword.Focus()
        ElseIf txtContact.Text = "" Then
            MessageBox.Show("Contact is Required field", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContact.Focus()
        Else
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
                sqlConnection.Open()
            End If
            Dim sqlQuery As String = "INSERT into tbl_users(user_type,username,password,contact) VALUES('" & cmbUserType.Text & _
            "','" & txtUsername.Text & "','" & txtRetypeUserPassword.Text & "','" & txtContact.Text & "')"

            Dim sqlCommand As New MySqlCommand

            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
                .ExecuteNonQuery()
            End With
            MessageBox.Show("User Saved Successfully", "Account Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearTextBoxes()
            Manage_Users.LoadUsers()
            animateWin(Me, False)
            Me.Close()
            animateWin(Manage_Users, True)
            Manage_Users.Show()
        End If
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        'Accept Only numbers
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            MessageBox.Show("Enter Number Only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub txtContact_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.Leave
        If txtContact.Text = "" Then

        Else
            If txtContact.TextLength < 11 Then
                MessageBox.Show("The number should be atleast 11 digits", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContact.Focus()
            End If
        End If
    End Sub
End Class