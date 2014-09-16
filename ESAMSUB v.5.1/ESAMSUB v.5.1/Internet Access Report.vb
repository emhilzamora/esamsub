Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Internet_Access_Report
    Dim sConnection As New MySqlConnection
    Dim tt1 As ToolTip
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub tmrTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeDate.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        animateWin(Me, False)
        Me.Hide()
        animateWin(Internet_Access_Usage, True)
        Internet_Access_Usage.Show()
    End Sub

    Private Sub Internet_Access_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sConnection.Open()
            loadReports()
        End If
        tt1 = New ToolTip
        tt1.SetToolTip(btnBack, "Back to internet access usage")
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "Search Student")
    End Sub
    Public Sub loadReports()
        Dim sqlQuery As String = "SELECT * from tbl_internet_access_report"
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
        lvInternetAccessReport.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With lvInternetAccessReport
                .Items.Add(TABLE.Rows(i)("no"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("idnumber"))
                    .Add(TABLE.Rows(i)("fullname"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("year"))
                    .Add(TABLE.Rows(i)("date_log"))
                    .Add(TABLE.Rows(i)("hour_left"))
                End With
            End With
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadReports()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_internet_access_report Where idnumber like '%" & Me.txtSearch.Text & "%'  or fullname like '%" & Me.txtSearch.Text & "%' or course like '%" & Me.txtSearch.Text & "%'  or year like '%" & Me.txtSearch.Text & "%'  or date_log like '%" & Me.txtSearch.Text & "'"
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

        lvInternetAccessReport.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvInternetAccessReport
                .Items.Add(TABLE.Rows(i)("no"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("idnumber"))
                    .Add(TABLE.Rows(i)("fullname"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("year"))
                    .Add(TABLE.Rows(i)("date_log"))
                    .Add(TABLE.Rows(i)("hour_left"))
                End With
            End With
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_internet_access_report Where idnumber like '%" & Me.txtSearch.Text & "%'  or fullname like '%" & Me.txtSearch.Text & "%' or course like '%" & Me.txtSearch.Text & "%'  or year like '%" & Me.txtSearch.Text & "%'  or date_log like '%" & Me.txtSearch.Text & "'"
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

        lvInternetAccessReport.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvInternetAccessReport
                .Items.Add(TABLE.Rows(i)("no"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("idnumber"))
                    .Add(TABLE.Rows(i)("fullname"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("year"))
                    .Add(TABLE.Rows(i)("date_log"))
                    .Add(TABLE.Rows(i)("hour_left"))
                End With
            End With
        Next
    End Sub
End Class