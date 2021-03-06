﻿Imports MySql.Data.MySqlClient
Public Class Student_TimeOut
    Dim sConnection = New MySqlConnection
    Friend id As String
    Friend fullname As String
    Friend department As String
    Friend course As String
    Friend time_in As String
    Private Sub tmrEnabled_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnabled.Tick
        lblTime.Text = lblTime.Text + 1
        If lblTime.Text = 25 Then
            Me.Close()
            animateWin(Monitoring_Time_Out, True)
            Monitoring_Time_Out.Show()
            tmrEnabled.Stop()
            Monitoring_Time_Out.txtMonitoring.Clear()
            Monitoring_Time_Out.txtMonitoring.Focus()
            Monitoring_Time_Out.loadMonitorOut()
            lblTime.Text = 0
        End If
    End Sub

    Private Sub Student_TimeOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pctProfile.ImageLocation = Application.StartupPath & "\Pictures\" & id & ".jpg"
        tmrEnabled.Start()
        lblId.Text = id
        lblFname.Text = fullname
        lblCourse.Text = course
        lblTimeIn.Text = time_in
        lblTimeOut.Text = TimeOfDay
        'digital time and date
        lblTimeToday.Text = Now.ToLongTimeString
        lblDateToday.Text = Date.Today
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sConnection.Open()
        End If
        Dim sqlQuery1 As String = "UPDATE tbl_monitoring_stud SET time_out = '" & lblTimeOut.Text & " ' WHERE  idnumber='" & lblId.Text & "'"
        Dim sqlCommand1 As New MySqlCommand
        With sqlCommand1

            .CommandText = sqlQuery1
            .Connection = sConnection
            .ExecuteNonQuery()
        End With
        Dim sqlQuery As String = "UPDATE tbl_monitor_report SET time_out = '" & lblTimeOut.Text & " ' WHERE  date_log like '%" & Date.Today & "%' and idnumber like '%" & Me.lblId.Text & "'"
        Dim sqlCommand As New MySqlCommand
        With sqlCommand
            .CommandText = sqlQuery
            .Connection = sConnection
            .ExecuteNonQuery()
        End With
        Monitoring.txtMonitoring.Text = ""
        Monitoring.loadMonitor()
    End Sub
End Class