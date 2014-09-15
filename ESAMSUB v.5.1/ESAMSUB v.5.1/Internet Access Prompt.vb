Imports MySql.Data.MySqlClient
Public Class Internet_Access_Prompt
    Dim sConnection = New MySqlConnection
    Friend id As String
    Friend fullname As String
    Friend course As String
    Friend hour_left As Integer
    Friend year As String
    Private Sub Internet_Access_Prompt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrInterval.Start()
        lblId.Text = id
        lblName.Text = fullname
        lblCourse.Text = course
        lblYear.Text = year
        lblHourLeft.Text = hour_left
        lblHourLeft.Text = lblHourLeft.Text - 1

        If lblHourLeft.Text < 0 Then
            lblNoTimeLeft.Visible = True
            lblHourLeft.Visible = False
        Else

            If sConnection.State = ConnectionState.Closed Then
                sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
                sConnection.Open()
            End If
            Dim sqlQuery As String = "UPDATE tbl_internet_access SET hour_left ='" & lblHourLeft.Text & " ' WHERE  idnumber='" & lblId.Text & "'"
            Dim sqlCommand As New MySqlCommand
            With sqlCommand

                .CommandText = sqlQuery
                .Connection = sConnection
                .ExecuteNonQuery()
            End With
            If lblHourLeft.Text <= 0 Then
                Internet_Access_Usage.loadStudents()
            Else
                Dim sqlQuery1 As String = "INSERT into tbl_internet_access_report(idnumber,fullname,course,year,date_log,hour_left) VALUES('" & lblId.Text & _
            "','" & lblName.Text & "','" & lblCourse.Text & "','" & lblYear.Text & "','" & lblDate.Text & "','" & lblHourLeft.Text & "')"
                Dim sqlCommand1 As New MySqlCommand
                With sqlCommand1

                    .CommandText = sqlQuery1
                    .Connection = sConnection
                    .ExecuteNonQuery()
                End With
            End If
            Internet_Access_Usage.loadStudents()
        End If

    End Sub

    Private Sub tmrInterval_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInterval.Tick
        lblInterval.Text = lblInterval.Text + 1
        If lblInterval.Text = 50 Then
            lblInterval.Text = 0
            Me.Close()
            Internet_Access_Usage.txtinternetusage.Clear()
        End If

    End Sub
End Class