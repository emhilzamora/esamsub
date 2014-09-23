Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Monitoring_Time_Out
    Dim x As Integer
    Dim tt As New ToolTip
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Dim sConnection = New MySqlConnection
    'ito ang pag load ng listview kapag hndi pa naglog in ay hndi pa sya lalabas sa listview
    Public Sub loadMonitorOut()
        Dim sqlQuery As String = "SELECT * from tbl_monitoring_stud where time_out ='" & "Waiting.." & " ' "
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
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sConnection.Open()
            loadMonitorOut()
        End If
    End Sub

    Private Sub tmrTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeDate.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub tmrWindowDn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWindowDn.Tick
        'mag open ung panel para makita ung listview
        pnlWindow.Height = pnlWindow.Height + 20
        If pnlWindow.Height >= 587 Then
            tmrWindowDn.Enabled = False
            txtMonitoring.Enabled = True
        End If
    End Sub

    Private Sub tmrWindowUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWindowUp.Tick
        'mag open ung panel para makita ung listview
        pnlWindow.Height = pnlWindow.Height - 20
        If pnlWindow.Height <= 1 Then
            tmrWindowUp.Enabled = False
            grpControl.Visible = True
            txtMonitoring.Enabled = False
            txtMonitoring.Focus()
        End If
    End Sub

    Private Sub btnUpWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpWindow.Click
        tmrWindowUp.Enabled = True
    End Sub
    Private Sub btnDownWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownWindow.Click
        tmrWindowDn.Enabled = True
    End Sub

    Private Sub btnBack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack2.Click
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
                txtMonitoring.Enabled = False
                loadMonitorOut()
                lblStudentCount.Text = 0
            Case MsgBoxResult.No
                'Walang gagawin kapag no ang kanyang pinili
        End Select
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'panel back to size
        tmrWindowDn.Enabled = True
        grpControl.Hide()
        'back to dashboard
        If tmrWindowDn.Enabled - False Then
            'disabled the buttons
            Dashboard.btnCreatId.Enabled = False
            Dashboard.btnManageUsers.Enabled = False
            Dashboard.btnCreatId.Enabled = False
            Dashboard.btnEmployee.Enabled = False
            Dashboard.btnMonitoring.Enabled = False
            Dashboard.btnStudents.Enabled = False
            pnlWindow.Visible = True
            animateWin(Me, False)
            Me.Hide()
            animateWin(Dashboard, True)
            Dashboard.Show()
        End If
    End Sub
End Class