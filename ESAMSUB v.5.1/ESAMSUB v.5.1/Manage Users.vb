Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class Manage_Users
    Dim id As Integer
    'tooltip declaration
    Dim tt2 As ToolTip
    'sql connection
    Dim sqlConnection = New MySqlConnection
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'minimize application
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Validate kung mag exit tlaga ung application
        Select Case MsgBox("Are you sure you want to Exit?", MsgBoxStyle.YesNo, "Close Application")
            Case MsgBoxResult.Yes
                'pag yes close the application
                animateWin(Me, False)
                Application.Exit()
            Case MsgBoxResult.No
                'Walang gagawin kapag no ang kanyang pinili
        End Select

    End Sub
    Private Sub Manage_Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrTimeRunner.Start()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sqlConnection.Open()
        End If
        LoadUsers()
        tt2 = New ToolTip
        tt2.SetToolTip(btnBack, "Back")
        tt2.SetToolTip(btnSearch, "Search")
        tt2.SetToolTip(btnEditUser, "Change User Password")
        tt2.SetToolTip(btnAddNewUser, "Add New User")
        tt2.SetToolTip(btnDeleteUser, "Delete  selected User")
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "Search Usertype or Username")
    End Sub
    'Load users then display to listview
    Public Sub LoadUsers()
        Dim sqlQuery As String = "SELECT * from tbl_users"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Dim TABLE As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = sqlQuery
            .Connection = sqlConnection
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(TABLE)
        End With
        lvShowUsers.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With lvShowUsers
                .Items.Add(TABLE.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("user_type"))
                    .Add(TABLE.Rows(i)("username"))
                    .Add("●●●●●●●●")
                    .Add(TABLE.Rows(i)("contact"))
                End With
            End With
        Next
    End Sub

    Private Sub lvShowUsers_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvShowUsers.MouseClick
        id = lvShowUsers.SelectedItems(0).Text
    End Sub

    Private Sub btnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUser.Click
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sqlConnection.Open()
        End If
        If id = Nothing Then
            MessageBox.Show("Select User from List to delete", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Select Case MsgBox("Are you sure you want delete user?", MsgBoxStyle.YesNo, "Confirmation")
                Case MsgBoxResult.Yes
                    'Delete user
                    Dim sqlQuery As String = "DELETE FROM tbl_users WHERE  id = '" & id & "'"
                    Dim sqlCommand As New MySqlCommand
                    With sqlCommand

                        .CommandText = sqlQuery
                        .Connection = sqlConnection
                        .ExecuteNonQuery()
                    End With
                Case MsgBoxResult.No
                    'Walang gagawin kapag no ang kanyang pinili
            End Select

            MessageBox.Show("User Successfully Deleted", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            id = Nothing
            LoadUsers()
        End If
    End Sub

    Private Sub btnAddNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewUser.Click
        animateWin(Add_New_User, True)
        Add_New_User.ShowDialog()
        Add_New_User.cmbUserType.Text = Nothing
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'disabled the buttons
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnManageUsers.Enabled = False
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnEmployee.Enabled = False
        Dashboard.btnMonitoring.Enabled = False
        Dashboard.btnStudents.Enabled = False
        animateWin(Me, False)
        Me.Hide()
        animateWin(Dashboard, True)
        Dashboard.Show()
    End Sub

    Private Sub tmrTimeRunner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeRunner.Tick
        'running time and date
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub btnEditUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditUser.Click
        animateWin(Edit_User, True)
        Edit_User.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_users Where user_type like '%" & Me.txtSearch.Text & "%'  or username like '%" & Me.txtSearch.Text & "'"
        Dim SqlCommand As New MySqlCommand
        Dim SqlAdapter As New MySqlDataAdapter
        Dim TABLE As New DataTable
        With SqlCommand
            .CommandText = SqlQuery
            .Connection = sqlConnection
        End With

        With SqlAdapter
            .SelectCommand = SqlCommand
            .Fill(TABLE)

        End With

        lvShowUsers.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvShowUsers
                .Items.Add(TABLE.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("user_type"))
                    .Add(TABLE.Rows(i)("username"))
                    .Add("●●●●●●●●")
                    .Add(TABLE.Rows(i)("contact"))
                End With
            End With
        Next
    End Sub
End Class