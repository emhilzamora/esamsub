Imports MySql.Data.MySqlClient

Public Class Student_TimeIn
    Dim sConnection = New MySqlConnection
    Friend id As String
    Friend fullname As String
    Friend department As String
    Friend course As String
    Private Sub tmrEnabled_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnabled.Tick
        lblTime.Text = lblTime.Text + 1
        If lblTime.Text = 25 Then
            Me.Close()
            animateWin(Monitoring, True)
            Monitoring.Show()
            tmrEnabled.Stop()
            Monitoring.txtSearch.Clear()
            Monitoring.loadMonitor()
            lblTime.Text = 0
        End If
    End Sub

    Private Sub Student_TimeIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pctProfile.ImageLocation = Application.StartupPath & "\Pictures\" & id & ".jpg"
        tmrEnabled.Start()
        lblId.Text = id
        lblFname.Text = fullname
        lblCourse.Text = course
        lblDepartment.Text = department
        lblTimeToday.Text = Now.ToLongTimeString
        lblDateToday.Text = Date.Today
        lblTimeIn.Text = TimeOfDay
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sConnection.Open()
        End If
        Dim sqlQuery As String = "UPDATE tbl_monitoring_stud SET date_log ='" & lblDateToday.Text & "', time_in ='" & lblTimeIn.Text & "', time_out = '" & "Waiting.." & " ' WHERE  idnumber='" & lblId.Text & "'"
        Dim sqlCommand As New MySqlCommand
        With sqlCommand

            .CommandText = sqlQuery
            .Connection = sConnection
            .ExecuteNonQuery()
        End With
        Dim sqlQuery1 As String = "INSERT into tbl_monitor_report(idnumber,fullname,department,course,date_log,time_in,time_out) VALUES('" & lblId.Text & _
"','" & lblFname.Text & "','" & lblDepartment.Text & "','" & lblCourse.Text & "','" & lblDateToday.Text & "','" & lblTimeIn.Text & "','" & "Waiting.." & "')"
        Dim sqlCommand1 As New MySqlCommand
        With sqlCommand1

            .CommandText = sqlQuery1
            .Connection = sConnection
            .ExecuteNonQuery()
        End With
        Monitoring.txtMonitoring.Text = ""
        Monitoring.loadMonitor()
    End Sub
End Class
