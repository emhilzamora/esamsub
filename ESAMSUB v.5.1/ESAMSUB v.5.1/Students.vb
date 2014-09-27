Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class Students
    Dim tt2 As ToolTip
    Private id As Integer
    'sql connection
    Dim sqlConnection = New MySqlConnection
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub Students_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrTimeRunner.Start()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sqlConnection.Open()
            LoadStudent()
        End If
        tt2 = New ToolTip
        tt2.SetToolTip(btnBack, "Back")
        tt2.SetToolTip(btnBack, "Add Student")
        tt2.SetToolTip(btnBack, "Edit Student")
        tt2.SetToolTip(btnBack, "Search")
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtSearch.Handle, &H1501, 0, "Search Student")
    End Sub

    Public Sub reset()
        lblIdnumber.Text = "-----------"
        lblFname.Text = "-----------"
        lblMname.Text = "-----------"
        lblLname.Text = "-----------"
        lblDepartment.Text = "-----------"
        lblCourse.Text = "-----------"
        lblbirthplace.Text = "-----------"
        lblAddress.Text = "-----------"
        lblContact.Text = "-----------"
        lblNationality.Text = "-----------"
        lblReligion.Text = "-----------"
        lblCivilStatus.Text = "-----------"
        lblYear.Text = "-----------"
        lblGender.Text = "-----------"
        lblDateBirth.Text = "-----------"
        lblAge.Text = "-----------"
        lblGuardian.Text = "-----------"
        lblGcontact.Text = "-----------"
        lblGaddress.Text = "-----------"
        lblFatherName.Text = "-----------"
        lblFthrOccuaption.Text = "-----------"
        lblMothername.Text = "-----------"
        lblmthrOccupation.Text = "-----------"
        pictStudentPic.ImageLocation = Application.StartupPath & "\Pictures\Profile.jpg"
labas:
    End Sub

    Public Sub LoadStudent()
        Dim sqlQuery As String = "SELECT * from tbl_student"
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
        lvStudents.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvStudents
                .Items.Add(TABLE.Rows(i)("idnumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("fname"))
                    .Add(TABLE.Rows(i)("mname"))
                    .Add(TABLE.Rows(i)("lname"))
                    .Add(TABLE.Rows(i)("department"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("contact_no"))
                    .Add(TABLE.Rows(i)("address"))
                End With
            End With
        Next
    End Sub
    Private Sub tmrTimeRunner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeRunner.Tick
        'running time and date
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Validate kung mag exit tlaga ung application
        Select Case MsgBox("Are you sure you want to Exit?", MsgBoxStyle.YesNo, "Close Application")
            Case MsgBoxResult.Yes
                'pag yes close the application
                animateWin(Me, False)
                Application.Exit()
            Case MsgBoxResult.No
                'Walang gagawin kapag no ang kanyang pinili
        End Select

    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'minimize application
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        id = Nothing
        reset()
        animateWin(Me, False)
        Me.Hide()
        'disabled the buttons
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnManageUsers.Enabled = False
        Dashboard.btnCreatId.Enabled = False
        Dashboard.btnEmployee.Enabled = False
        Dashboard.btnMonitoring.Enabled = False
        Dashboard.btnStudents.Enabled = False
        animateWin(Dashboard, True)
        Dashboard.Show()
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        id = Nothing
        reset()
        LoadStudent()
    End Sub
    Private Sub btnAddStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        reset()
        animateWin(Me, False)
        Me.Hide()
        animateWin(AddStudent, True)
        AddStudent.Show()
    End Sub
    Private Sub lvStudents_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvStudents.Click
        id = lvStudents.SelectedItems(0).Text
        On Error GoTo labas
        Dim sqlQuery As String = "SELECT fname,mname,lname,department,course,birth_place,address,contact_no,nationality,religion,civil_status,year,gender,date_birth,age,gName,gContact,gAddress,father,fthr_occupation,mother,mthr_occupation FROM tbl_student WHERE idnumber='" & lvStudents.SelectedItems(0).Text & " ' "
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
        End With

        lblIdnumber.Text = lvStudents.SelectedItems(0).Text
        lblFname.Text = sqlTable.Rows(0)("fname")
        lblMname.Text = sqlTable.Rows(0)("mname")
        lblLname.Text = sqlTable.Rows(0)("lname")
        lblDepartment.Text = sqlTable.Rows(0)("department")
        lblCourse.Text = sqlTable.Rows(0)("course")
        lblbirthplace.Text = sqlTable.Rows(0)("birth_place")
        lblAddress.Text = sqlTable.Rows(0)("address")
        lblContact.Text = sqlTable.Rows(0)("contact_no")
        lblNationality.Text = sqlTable.Rows(0)("nationality")
        lblReligion.Text = sqlTable.Rows(0)("religion")
        lblCivilStatus.Text = sqlTable.Rows(0)("civil_status")
        lblYear.Text = sqlTable.Rows(0)("year")
        lblGender.Text = sqlTable.Rows(0)("gender")
        lblDateBirth.Text = sqlTable.Rows(0)("date_birth")
        lblAge.Text = sqlTable.Rows(0)("age")
        lblGuardian.Text = sqlTable.Rows(0)("gName")
        lblGcontact.Text = sqlTable.Rows(0)("gContact")
        lblGaddress.Text = sqlTable.Rows(0)("gAddress")
        lblFatherName.Text = sqlTable.Rows(0)("father")
        lblFthrOccuaption.Text = sqlTable.Rows(0)("fthr_occupation")
        lblMothername.Text = sqlTable.Rows(0)("mother")
        lblmthrOccupation.Text = sqlTable.Rows(0)("mthr_occupation")
        pictStudentPic.ImageLocation = Application.StartupPath & "\Pictures\" & lvStudents.SelectedItems(0).Text & ".jpg"
labas:
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_student Where idnumber like '%" & Me.txtSearch.Text & "%'  or fname like '%" & Me.txtSearch.Text & "%'  or lname like '%" & Me.txtSearch.Text & "'"
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

        lvStudents.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvStudents
                .Items.Add(TABLE.Rows(i)("idnumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("fname"))
                    .Add(TABLE.Rows(i)("mname"))
                    .Add(TABLE.Rows(i)("lname"))
                    .Add(TABLE.Rows(i)("department"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("contact_no"))
                    .Add(TABLE.Rows(i)("address"))
                End With
            End With
        Next
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        'Search code
        Dim SqlQuery As String = "SELECT * FROM tbl_student Where idnumber like '%" & Me.txtSearch.Text & "%'  or fname like '%" & Me.txtSearch.Text & "%'  or course like '%" & Me.txtSearch.Text & "%'  or department like '%" & Me.txtSearch.Text & "%'  or year like '%" & Me.txtSearch.Text & "'"
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

        lvStudents.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With lvStudents
                .Items.Add(TABLE.Rows(i)("idnumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("fname"))
                    .Add(TABLE.Rows(i)("mname"))
                    .Add(TABLE.Rows(i)("lname"))
                    .Add(TABLE.Rows(i)("department"))
                    .Add(TABLE.Rows(i)("course"))
                    .Add(TABLE.Rows(i)("contact_no"))
                    .Add(TABLE.Rows(i)("address"))
                End With
            End With
        Next
    End Sub

    Private Sub btnEditstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditstudent.Click
        On Error GoTo labas
        If id = Nothing Then
            MessageBox.Show("Select student from list to Edit", "No student selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim sqlQuery As String = "SELECT fname,mname,lname,department,course,birth_place,address,contact_no,nationality,religion,civil_status,year,gender,date_birth,age,gName,gContact,gAddress,father,fthr_occupation,mother,mthr_occupation FROM tbl_student WHERE idnumber='" & lvStudents.SelectedItems(0).Text & " ' "
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
            End With
            Edit_Student_Record.id = lvStudents.SelectedItems(0).Text
            Edit_Student_Record.firstname = sqlTable.Rows(0)("fname")
            Edit_Student_Record.middlename = sqlTable.Rows(0)("mname")
            Edit_Student_Record.lastname = sqlTable.Rows(0)("lname")
            Edit_Student_Record.department = sqlTable.Rows(0)("department")
            Edit_Student_Record.course = sqlTable.Rows(0)("course")
            Edit_Student_Record.birthplace = sqlTable.Rows(0)("birth_place")
            Edit_Student_Record.address = sqlTable.Rows(0)("address")
            Edit_Student_Record.contactNo = sqlTable.Rows(0)("contact_no")
            Edit_Student_Record.nationality = sqlTable.Rows(0)("nationality")
            Edit_Student_Record.religion = sqlTable.Rows(0)("religion")
            Edit_Student_Record.civil_status = sqlTable.Rows(0)("civil_status")
            Edit_Student_Record.year = sqlTable.Rows(0)("year")
            Edit_Student_Record.gender = sqlTable.Rows(0)("gender")
            Edit_Student_Record.birthdate = sqlTable.Rows(0)("date_birth")
            Edit_Student_Record.age = sqlTable.Rows(0)("age")
            Edit_Student_Record.gname = sqlTable.Rows(0)("gName")
            Edit_Student_Record.gno = sqlTable.Rows(0)("gContact")
            Edit_Student_Record.gaddress = sqlTable.Rows(0)("gAddress")
            Edit_Student_Record.father = sqlTable.Rows(0)("father")
            Edit_Student_Record.fthrOccupation = sqlTable.Rows(0)("fthr_occupation")
            Edit_Student_Record.mother = sqlTable.Rows(0)("mother")
            Edit_Student_Record.mthrOccupation = sqlTable.Rows(0)("mthr_occupation")
            Edit_Student_Record.ShowDialog()
            reset()
        End If
labas:
    End Sub
End Class