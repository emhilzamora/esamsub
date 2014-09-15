Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Startup
    'tooltip declaration
    Dim tt As ToolTip
    'sql connection
    Dim sqlConnection = New MySqlConnection
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'start na ang time
        tmrTimeRunner.Start()
        animateWin(Me, True)
        'para sa tooltip
        tt = New ToolTip
        tt.SetToolTip(btnHelp, "Help")
        tt.SetToolTip(btnAbout, "About")
        tt.SetToolTip(lblDate, "Current Date")
        tt.SetToolTip(lblTime, "Current Time")
        tt.SetToolTip(btnShutdown, "Shutdown")
        tt.SetToolTip(btnMinimize, "Minimize")
        tt.SetToolTip(btnOtherUser, "Secondary Users Level")
        tt.SetToolTip(btnAdministor, "Administrator User Level")
    End Sub

    Private Sub tmrTimeRunner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeRunner.Tick
        'set date and time
        lblTime.Text = Now.ToLongTimeString
        lblDate.Text = Now.ToLongDateString
    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        Select Case MsgBox("Are you sure you want to Exit?", MsgBoxStyle.YesNo, "Close Application")
            Case MsgBoxResult.Yes
                'pag yes close the application
                animateWin(Me, False)
                Application.Exit()
            Case MsgBoxResult.No
                'Walang gagawin kapag no ang kanyang pinili
        End Select
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        'minimize application
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAdministor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministor.Click
        animateWin(Me, False)
        Me.Hide()
        Admin_Login.ShowDialog()
    End Sub

    Private Sub btnOtherUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtherUser.Click
        animateWin(Me, False)
        Me.Hide()
        Other_User_Login.ShowDialog()
    End Sub
End Class
'1366 x 768 Screen Resolution ng Laptop ko
'262
'262, 394
