Imports MySql.Data.MySqlClient
Public Class Monitoring_Report
    Dim tt1 As ToolTip
    Dim sConnection = New MySqlConnection
    Private Sub tmrTimeDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeDate.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub Monitoring_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sConnection.Open()
            loadReports()
        End If
        'para sa tooltip
        tt1 = New ToolTip
        tt1.SetToolTip(btnBack, "Back to monitoring")
    End Sub

    Public Sub loadReports()
        Dim sqlQuery As String = "SELECT * from tbl_monitor_report"
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
        lvMonitoringReport.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With lvMonitoringReport
                .Items.Add(TABLE.Rows(i)("no"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("idnumber"))
                    .Add(TABLE.Rows(i)("fullname"))
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
        animateWin(Me, False)
        Me.Hide()
        animateWin(Monitoring, True)
        Monitoring.Show()
    End Sub
End Class