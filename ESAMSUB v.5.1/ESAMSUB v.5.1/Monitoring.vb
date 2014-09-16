Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Monitoring
    Dim x As Integer
    Dim tt As New ToolTip
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Dim sConnection = New MySqlConnection
    Public Sub loadMonitor()
        Dim sqlQuery As String = "SELECT * from tbl_monitoring_stud"
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
        lvMonitoringStud.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With lvMonitoringStud
                .Items.Add(TABLE.Rows(i)("idnumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("fname"))
                    .Add(TABLE.Rows(i)("mname"))
                    .Add(TABLE.Rows(i)("lname"))
                    .Add(TABLE.Rows(i)("department"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("date_log"))
                    .Add(TABLE.Rows(i)("time_in"))
                    .Add(TABLE.Rows(i)("time_out"))
                End With
            End With
        Next
    End Sub
    Private Sub tmrTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeDate.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub Monitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tt = New ToolTip
        tt.SetToolTip(btnReset, "Reset")
        tt.SetToolTip(btnRecords, "Open records")
        tt.SetToolTip(btnSearch, "Search student")
        tt.SetToolTip(btnBack, "Back to dashboard")
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "Search Student")
        SendMessage(Me.txtMonitoring.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtMonitoring.Handle, &H1501, 0, "Read barcode")
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sConnection.Open()
        End If
        loadMonitor()
    End Sub

    Private Sub txtMonitoring_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonitoring.TextChanged
        If cmbType.Text = "Time-In" Then
            If txtMonitoring.Text = Nothing Then

            Else
                Dim sqlQuery As String = "SELECT fname,mname,lname,department,course FROM tbl_monitoring_stud WHERE idnumber='" & txtMonitoring.Text & " ' "
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


                Student_TimeIn.id = txtMonitoring.Text
                Student_TimeIn.fullname = sqlTable.Rows(0)("fname") & " " & sqlTable.Rows(0)("mname") & " " & sqlTable.Rows(0)("lname")
                Student_TimeIn.department = sqlTable.Rows(0)("department")
                Student_TimeIn.course = sqlTable.Rows(0)("course")
                Student_TimeIn.ShowDialog()
            End If
        ElseIf cmbType.Text = "Time-Out" Then
            If txtMonitoring.Text = Nothing Then

            Else
                Dim sqlQuery As String = "SELECT fname,mname,lname,department,course,time_in FROM tbl_monitoring_stud WHERE idnumber='" & txtMonitoring.Text & " ' "
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


                Student_TimeOut.id = txtMonitoring.Text
                Student_TimeOut.fullname = sqlTable.Rows(0)("fname") & " " & sqlTable.Rows(0)("mname") & " " & sqlTable.Rows(0)("lname")
                Student_TimeOut.course = sqlTable.Rows(0)("department")
                Student_TimeOut.course = sqlTable.Rows(0)("course")
                Student_TimeOut.time_in = sqlTable.Rows(0)("time_in")
                Student_TimeOut.ShowDialog()
            End If

        End If
    End Sub
    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.Text = "Time-In" Or cmbType.Text = "Time-Out" Then
            txtMonitoring.Enabled = True
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sConnection.Open()
        End If
        Dim sqlQuery As String = "UPDATE tbl_monitoring_stud SET date_log = '" & "" & "', time_in ='" & "" & "', time_out = '" & "" & " ' WHERE  date_log='" & Date.Today & "'"
        Dim sqlCommand As New MySqlCommand
        With sqlCommand

            .CommandText = sqlQuery
            .Connection = sConnection
            .ExecuteNonQuery()
        End With

        loadMonitor()
    End Sub

  
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_monitoring_stud Where idnumber like '%" & Me.txtSearch.Text & "%'  or fname like '%" & Me.txtSearch.Text & "%'  or lname like '%" & Me.txtSearch.Text & "'"
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

        lvMonitoringStud.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvMonitoringStud
                .Items.Add(TABLE.Rows(i)("idnumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("fname"))
                    .Add(TABLE.Rows(i)("mname"))
                    .Add(TABLE.Rows(i)("lname"))
                    .Add(TABLE.Rows(i)("department"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("date_log"))
                    .Add(TABLE.Rows(i)("time_in"))
                    .Add(TABLE.Rows(i)("time_out"))
                End With
            End With
        Next
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_monitoring_stud Where idnumber like '%" & Me.txtSearch.Text & "%'  or fname like '%" & Me.txtSearch.Text & "%'  or lname like '%" & Me.txtSearch.Text & "'"
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

        lvMonitoringStud.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvMonitoringStud
                .Items.Add(TABLE.Rows(i)("idnumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("fname"))
                    .Add(TABLE.Rows(i)("mname"))
                    .Add(TABLE.Rows(i)("lname"))
                    .Add(TABLE.Rows(i)("department"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("date_log"))
                    .Add(TABLE.Rows(i)("time_in"))
                    .Add(TABLE.Rows(i)("time_out"))
                End With
            End With
        Next
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'disabled the buttons
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnManageUsers.Enabled = False
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnEmployee.Enabled = False
        Dashboard.btnMonitoring.Enabled = False
        Dashboard.btnStudents.Enabled = False
        'back to dashboard
        animateWin(Me, False)
        Me.Hide()
        animateWin(Dashboard, True)
        Dashboard.Show()
    End Sub

    Private Sub btnRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecords.Click
        'call the form monitoring student
        animateWin(Me, False)
        Me.Hide()
        animateWin(Monitoring_Report, True)
        Monitoring_Report.Show()
    End Sub
End Class