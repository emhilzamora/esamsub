Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Internet_Access_Usage
    Dim status As Integer
    Dim x As Integer
    Dim tt As ToolTip
    Dim sConnection = New MySqlConnection
    Friend id As String
    Friend fname As String
    Friend lname As String
    Friend mname As String
    Friend course As String
    Friend year As String
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub Internet_Access_Usage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sConnection.Open()
            loadStudents()
        End If
        tt = New ToolTip
        tt.SetToolTip(btnRecords, "Open records")
        tt.SetToolTip(btnSearch, "Search student")
        tt.SetToolTip(btnBack, "Back to dashboard")
        SendMessage(Me.txtInternetUsage.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtInternetUsage.Handle, &H1501, 0, "Use Internet Access")
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "Search students")
    End Sub
    'load students
    Public Sub loadStudents()
        Dim sqlQuery As String = "SELECT * from tbl_internet_access"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Dim TABLE As New DataTable
        Dim i As Integer


        With sqlCommand
            .CommandText = sqlQuery
            .Connection = sConnection
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(TABLE)
        End With
        lvInternetAccess.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvInternetAccess
                .Items.Add(TABLE.Rows(i)("idnumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("fname"))
                    .Add(TABLE.Rows(i)("mname"))
                    .Add(TABLE.Rows(i)("lname"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("year"))
                    .Add(TABLE.Rows(i)("hour_left"))
                End With
            End With
        Next
    End Sub

    Private Sub lvInternetAccess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvInternetAccess.Click
        id = lvInternetAccess.SelectedItems(0).Text
    End Sub

    Private Sub tmrTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeDate.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
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

    Private Sub txtInternetUsage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInternetUsage.TextChanged
        On Error GoTo labas
        If txtInternetUsage.Text = Nothing Then
        Else
            Dim sqlQuery As String = "SELECT fname,mname,lname,course,year,hour_left FROM tbl_internet_access WHERE idnumber='" & txtInternetUsage.Text & " ' "
            Dim sqlAdapter As New MySqlDataAdapter
            Dim sqlcommand As New MySqlCommand
            Dim sqlTable As New DataTable


            With sqlcommand
                .CommandText = sqlQuery
                .Connection = sConnection
            End With
            With sqlAdapter
                .SelectCommand = sqlcommand
                .Fill(sqlTable)
            End With
            Internet_Access_Prompt.id = txtInternetUsage.Text
            Internet_Access_Prompt.fullname = sqlTable.Rows(0)("fname") & " " & sqlTable.Rows(0)("mname") & " " & sqlTable.Rows(0)("lname")
            Internet_Access_Prompt.year = sqlTable.Rows(0)("year")
            Internet_Access_Prompt.course = sqlTable.Rows(0)("course")
            Internet_Access_Prompt.hour_left = sqlTable.Rows(0)("hour_left")
            Internet_Access_Prompt.lblDate.Text = Date.Today
            Internet_Access_Prompt.lblTime.Text = TimeOfDay
            Internet_Access_Prompt.ShowDialog()

        End If
labas:
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        loadStudents()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_internet_access Where idnumber like '%" & Me.txtSearch.Text & "%'  or fname like '%" & Me.txtSearch.Text & "%'  or lname like '%" & Me.txtSearch.Text & "'"
        Dim SqlCommand As New MySqlCommand
        Dim SqlAdapter As New MySqlDataAdapter
        Dim TABLE As New DataTable
        With SqlCommand
            .CommandText = SqlQuery
            .Connection = sConnection
        End With

        With SqlAdapter
            .SelectCommand = SqlCommand
            .Fill(TABLE)

        End With

        lvInternetAccess.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvInternetAccess
                .Items.Add(TABLE.Rows(i)("idnumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("fname"))
                    .Add(TABLE.Rows(i)("mname"))
                    .Add(TABLE.Rows(i)("lname"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("year"))
                    .Add(TABLE.Rows(i)("hour_left"))
                End With
            End With
        Next
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_internet_access Where idnumber like '%" & Me.txtSearch.Text & "%'  or fname like '%" & Me.txtSearch.Text & "%'  or lname like '%" & Me.txtSearch.Text & "'"
        Dim SqlCommand As New MySqlCommand
        Dim SqlAdapter As New MySqlDataAdapter
        Dim TABLE As New DataTable
        With SqlCommand
            .CommandText = SqlQuery
            .Connection = sConnection
        End With

        With SqlAdapter
            .SelectCommand = SqlCommand
            .Fill(TABLE)

        End With

        lvInternetAccess.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvInternetAccess
                .Items.Add(TABLE.Rows(i)("idnumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("fname"))
                    .Add(TABLE.Rows(i)("mname"))
                    .Add(TABLE.Rows(i)("lname"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("year"))
                    .Add(TABLE.Rows(i)("hour_left"))
                End With
            End With
        Next
    End Sub

    Private Sub btnRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecords.Click
        'call the form internet access usage form
        animateWin(Me, False)
        Me.Hide()
        animateWin(Internet_Access_Report, True)
        Internet_Access_Report.Show()
    End Sub
End Class