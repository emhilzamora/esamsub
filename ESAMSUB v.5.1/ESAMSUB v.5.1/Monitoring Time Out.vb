Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Monitoring_Time_Out
    Dim x As Integer
    Dim tt As New ToolTip
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Dim sqlConnection = New MySqlConnection
    'ito ang pag load ng listview kapag hndi pa naglog in ay hndi pa sya lalabas sa listview
    Public Sub loadMonitorOut()
        Dim sqlQuery As String = "SELECT * from tbl_monitoring_stud where time_out ='" & "Waiting.." & " ' "
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
        lvMonitoringOut.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With lvMonitoringOut
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
                    lblStudentCount.Text = lvMonitoringOut.Items.Count
                End With
            End With
        Next
    End Sub

    Private Sub Monitoring_Time_Out_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tt = New ToolTip
        tt.SetToolTip(btnReset, "Reset record")
        tt.SetToolTip(btnRecords, "Open records")
        tt.SetToolTip(btnSearch, "Search student")
        tt.SetToolTip(btnBack, "Back to dashboard")
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "Search Student")
        SendMessage(Me.txtMonitoring.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtMonitoring.Handle, &H1501, 0, "Read barcode")
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sqlConnection.Open()
            loadMonitorOut()
        End If
        loadMonitorOut()
        txtMonitoring.Focus()
        btnSearch.Enabled = False
    End Sub

    Private Sub tmrTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeDate.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub
    Private Sub btnBack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'disabled the buttons
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnManageUsers.Enabled = False
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnEmployee.Enabled = False
        Dashboard.btnMonitoring.Enabled = False
        Dashboard.btnStudents.Enabled = False
        'back to dashboard
        grpControl.Visible = False
        animateWin(Me, False)
        Me.Hide()
        animateWin(Dashboard, True)
        Dashboard.Show()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'confirmation na mag reset talga ang record
        Select Case MsgBox("Are you sure you want to reset record?", MsgBoxStyle.YesNo, "Reset Records")
            Case MsgBoxResult.Yes
                If sqlConnection.State = ConnectionState.Closed Then
                    sqlConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
                    sqlConnection.Open()
                End If
                Dim sqlQuery As String = "UPDATE tbl_monitoring_stud SET date_log = '" & "" & "', time_in ='" & "" & "', time_out = '" & "" & " ' WHERE  date_log='" & Date.Today & "'"
                Dim sqlCommand As New MySqlCommand
                With sqlCommand

                    .CommandText = sqlQuery
                    .Connection = sqlConnection
                    .ExecuteNonQuery()
                End With
                txtMonitoring.Enabled = False
                loadMonitorOut()
                lblStudentCount.Text = 0
            Case MsgBoxResult.No
                'Walang gagawin kapag no ang kanyang pinili
        End Select
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'panel back to size
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

    Private Sub txtMonitoring_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonitoring.TextChanged
       If txtMonitoring.Text = Nothing Then 	

        Else
            Dim sqlQuery As String = "SELECT fname,mname,lname,department,course,time_in FROM tbl_monitoring_stud WHERE idnumber='" & txtMonitoring.Text & " ' "
            Dim sqlAdapter As New MySqlDataAdapter
            Dim sqlcommand As New MySqlCommand
            Dim sqlTable As New DataTable

            With sqlcommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
            End With
            With sqlAdapter
                .SelectCommand = sqlcommand
                .Fill(sqlTable)

                Student_TimeOut.id = txtMonitoring.Text
                Student_TimeOut.fullname = sqlTable.Rows(0)("fname") & " " & sqlTable.Rows(0)("mname") & " " & sqlTable.Rows(0)("lname")
                Student_TimeOut.course = sqlTable.Rows(0)("department")
                Student_TimeOut.course = sqlTable.Rows(0)("course")
                Student_TimeOut.time_in = sqlTable.Rows(0)("time_in")
                Student_TimeOut.ShowDialog()
            End With
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_monitoring_stud Where idnumber like '%" & Me.txtSearch.Text & "%'  or fname like '%" & Me.txtSearch.Text & "%'  or lname like '%" & Me.txtSearch.Text & "'"
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

        lvMonitoringOut.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvMonitoringOut
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
            loadMonitorOut()
        Next

    End Sub

    Private Sub btnRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecords.Click
        'call the form monitoring student
        animateWin(Me, False)
        Me.Hide()
        animateWin(Monitoring_Report, True)
        Monitoring_Report.Show()
    End Sub
End Class