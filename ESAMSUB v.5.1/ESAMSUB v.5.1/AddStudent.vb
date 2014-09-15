Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AddStudent
    Dim tt As ToolTip
    Dim sqlConnection As New MySqlConnection
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub AddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sqlConnection.Open()
        End If
        'para sa tooltip
        tt = New ToolTip
        tt.SetToolTip(btnSave, "Save")
        tt.SetToolTip(btnCancel, "Cancel")
        tt.SetToolTip(btnBrowsePicture, "Browse Pictures")
        tt.SetToolTip(btnTakePicture, "Take Picture")
        tt.SetToolTip(pictStudentPic, "Default Picture")
        tt.SetToolTip(btnClear, "Clear fields")
        tt.SetToolTip(cmbCourse, "Select Department first")
        SendMessage(Me.txtStudentAddress.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtStudentAddress.Handle, &H1501, 0, "Street\Barangay\City\Province")
        SendMessage(Me.txtBirthPlace.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtBirthPlace.Handle, &H1501, 0, "Street\Barangay\City\Province")
        SendMessage(Me.txtGuardianAddress.Handle, &H1501, 0, "$X.XX") 'Me.Font, Brushes.LightGray
        SendMessage(Me.txtGuardianAddress.Handle, &H1501, 0, "Street\Barangay\City\Province")

        'Resize Image

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'send back default picture
        pictStudentPic.ImageLocation = Application.StartupPath & "\Pictures\Profile.jpg"
        ClearTextBoxes()
        ClearComboBox()
        animateWin(Me, False)
        Me.Hide()
        animateWin(Students, True)
        Students.Show()
    End Sub
    'lilinisin ang mga textbox
    Public Sub ClearTextBoxes()
        For Each ctrl As Control In Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next

    End Sub
    'lilinisin ang mga combobox
    Public Sub clearComboBox()
        cmbCivilStatus.Text = ""
        cmbDepartment.Text = ""
        cmbYear.Text = ""
        cmbGender.Text = ""
        cmbCourse.Text = ""
    End Sub
    'add ng record ng student
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'send back default picture
        pictStudentPic.ImageLocation = Application.StartupPath & "\Pictures\Profile.jpg"
        'validate lahat ng textbox at combobox kapag walang laman
        If txtStudentId.Text = "" And txtFirstname.Text = "" And txtMiddlename.Text = "" And txtLastname.Text = "" And cmbDepartment.Text = "" And cmbCourse.Text = "" And txtBirthPlace.Text = "" And txtStudentAddress.Text = "" And txtStudentContact.Text = "" And txtnationality.Text = "" And txtReligion.Text = "" And cmbCivilStatus.Text = "" And cmbYear.Text = "" And cmbGender.Text = "" And txtAge.Text = "" And txtGuardian.Text = "" And txtGuardianContact.Text = "" And txtGuardianAddress.Text = "" And txtFatherName.Text = "" And txtFatherOccupation.Text = "" And txtMotherName.Text = "" And txtMotherOccupation.Text = "" Then
            MessageBox.Show("All Required fields are empty", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStudentId.Focus()
        ElseIf txtFirstname.Text = Nothing Then
            MessageBox.Show("First name is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstname.Focus()
        ElseIf txtMiddlename.Text = Nothing Then
            MessageBox.Show("Middle name is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMiddlename.Focus()
        ElseIf txtLastname.Text = Nothing Then
            MessageBox.Show("Last name is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastname.Focus()
        ElseIf cmbDepartment.Text = Nothing Then
            MessageBox.Show("Department is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbDepartment.Focus()
        ElseIf cmbCourse.Text = Nothing Then
            MessageBox.Show("Course is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCourse.Focus()
        ElseIf txtBirthPlace.Text = Nothing Then
            MessageBox.Show("Birth place is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthPlace.Focus()
        ElseIf txtStudentAddress.Text = Nothing Then
            MessageBox.Show("Student address is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStudentAddress.Focus()
        ElseIf txtStudentContact.Text = Nothing Then
            MessageBox.Show("Student contact is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStudentContact.Focus()
        ElseIf txtnationality.Text = Nothing Then
            MessageBox.Show("Nationality is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnationality.Focus()
        ElseIf txtReligion.Text = Nothing Then
            MessageBox.Show("Religion is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtReligion.Focus()
        ElseIf cmbCivilStatus.Text = Nothing Then
            MessageBox.Show("Civil status is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCivilStatus.Focus()
        ElseIf cmbYear.Text = Nothing Then
            MessageBox.Show("Year level is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbYear.Focus()
        ElseIf cmbGender.Text = Nothing Then
            MessageBox.Show("Gender is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbGender.Focus()
        ElseIf dtBirthday.Text = Nothing Then
            MessageBox.Show("Birthdate is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtBirthday.Focus()
        ElseIf txtAge.Text = Nothing Then
            MessageBox.Show("Age is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAge.Focus()
        ElseIf txtGuardian.Text = Nothing Then
            MessageBox.Show("Guardian is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuardian.Focus()
        ElseIf txtGuardianAddress.Text = Nothing Then
            MessageBox.Show("Guardian address is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuardianAddress.Focus()
        ElseIf txtGuardianContact.Text = Nothing Then
            MessageBox.Show("Guardian contact number is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuardianContact.Focus()
        ElseIf txtFatherName.Text = Nothing Then
            MessageBox.Show("Father name is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherName.Focus()
        ElseIf txtFatherOccupation.Text = Nothing Then
            MessageBox.Show("Father occupation is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherOccupation.Focus()
        ElseIf txtMotherOccupation.Text = Nothing Then
            MessageBox.Show("Mother occupation is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMotherOccupation.Focus()
        ElseIf txtMotherName.Text = Nothing Then
            MessageBox.Show("Mother name is required field", "Cannot add new student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMotherName.Focus()
        ElseIf txtGuardianContact.TextLength < 11 Then
            MessageBox.Show("The number should be atleast 11 digits", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuardianContact.Focus()
        Else
            'kapag may laman na lahat ng field mag execute na ang query
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
                sqlConnection.Open()
            End If
            'insert to table student
            Dim sqlQuery As String = "INSERT into tbl_student(idnumber,fname,mname,lname,department,course,birth_place,address,contact_no,nationality,religion,civil_status,year,gender,date_birth,age,gName,gContact,gAddress,father,fthr_occupation,mother,mthr_occupation) VALUES('" & Me.txtStudentId.Text & _
    "','" & Me.txtFirstname.Text & "','" & Me.txtMiddlename.Text & "','" & Me.txtLastname.Text & "','" & Me.cmbDepartment.Text & "','" & Me.cmbCourse.Text & "','" & Me.txtBirthPlace.Text & "','" & Me.txtStudentAddress.Text & "','" & Me.txtStudentContact.Text & "','" & Me.txtnationality.Text & "','" & Me.txtReligion.Text & "','" & Me.cmbCivilStatus.Text & "','" & Me.cmbYear.Text & "','" & Me.cmbGender.Text & "','" & Me.dtBirthday.Text & "','" & Me.txtAge.Text & "','" & Me.txtGuardian.Text & "','" & Me.txtGuardianContact.Text & "','" & Me.txtGuardianAddress.Text & "','" & Me.txtFatherName.Text & "','" & Me.txtFatherOccupation.Text & "','" & Me.txtMotherName.Text & "','" & Me.txtMotherOccupation.Text & "')"

            Dim sqlCommand As New MySqlCommand

            With sqlCommand
                .CommandText = sqlQuery
                .Connection = sqlConnection
                .ExecuteNonQuery()
            End With
            'indert to table monitoring student
            Dim query_monitor As String = "INSERT into tbl_monitoring_stud(idnumber,fname,mname,lname,department,course,date_log,time_in,time_out) VALUES('" & txtStudentId.Text & _
   "','" & txtFirstname.Text & "','" & txtMiddlename.Text & "','" & txtLastname.Text & "','" & cmbDepartment.Text & "','" & cmbCourse.Text & "','" & Date.Today & "','" & "" & "','" & "" & "')"

            Dim sqlCommandMonitor As New MySqlCommand

            With sqlCommandMonitor
                .CommandText = query_monitor
                .Connection = sqlConnection
                .ExecuteNonQuery()
            End With
            'Add record to tbl access card if department is CCs
            If cmbDepartment.Text = "CCS" Then
                Dim query_internet_access = "INSERT into tbl_internet_access(idnumber,fname,mname,lname,course,year,hour_left)VALUES('" & txtStudentId.Text & _
                "','" & txtFirstname.Text & "','" & txtMiddlename.Text & "','" & txtLastname.Text & "','" & cmbCourse.Text & "','" & cmbYear.Text & "','" & "10" & "')"
                Dim sqlCommand1 As New MySqlCommand

                With sqlCommand1
                    .CommandText = query_internet_access
                    .Connection = sqlConnection
                    .ExecuteNonQuery()
                End With
            End If
            Select Case MsgBox("Student successfully added to database, want to add more Student?", MsgBoxStyle.YesNo, "Added new record")
                Case MsgBoxResult.Yes
                    'send back default picture
                    pictStudentPic.ImageLocation = Application.StartupPath & "\Pictures\Profile.jpg"
                    'pag yes close the application
                    clearComboBox()
                    ClearTextBoxes()
                    txtStudentId.Focus()
                Case MsgBoxResult.No
                    'send back default picture
                    pictStudentPic.ImageLocation = Application.StartupPath & "\Pictures\Profile.jpg"
                    'Walang gagawin kapag no ang kanyang pinili
                    clearComboBox()
                    ClearTextBoxes()
                    animateWin(Me, False)
                    Me.Close()
                    animateWin(Students, True)
                    Students.Show()
                    Students.LoadStudent()
            End Select
        End If
    End Sub

    Private Sub txtFirstname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstname.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFirstname_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFirstname.Validating
        'Capitalized the first Letter
        txtFirstname.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFirstname.Text)
    End Sub

    Private Sub txtMiddlename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiddlename.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMiddlename_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMiddlename.Validating
        'Capitalized the first Letter
        txtMiddlename.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMiddlename.Text)
    End Sub

    Private Sub txtLastname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastname.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtLastname_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLastname.Validating
        'Capitalized the first Letter
        txtLastname.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastname.Text)
    End Sub


    Private Sub txtBirthPlace_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBirthPlace.Validating
        'Capitalized the first Letter
        txtBirthPlace.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBirthPlace.Text)
    End Sub

    Private Sub txtStudentAddress_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStudentAddress.Validating
        'Capitalized the first Letter
        txtStudentAddress.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtStudentAddress.Text)
    End Sub

    Private Sub txtnationality_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnationality.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtnationality_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnationality.Validating
        'Capitalized the first Letter
        txtnationality.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnationality.Text)
    End Sub

    Private Sub txtReligion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReligion.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtReligion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtReligion.Validating
        'Capitalized the first Letter
        txtReligion.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtReligion.Text)
    End Sub

    Private Sub txtGuardian_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuardian.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtGuardian_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGuardian.Validating
        'Capitalized the first Letter
        txtGuardian.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtGuardian.Text)
    End Sub

    Private Sub txtGuardianContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuardianContact.KeyPress
        'Accept Only numbers
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtGuardianContact_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGuardianContact.Validating
        'Capitalized the first Letter
        txtGuardianContact.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtGuardianContact.Text)
    End Sub

    Private Sub txtGuardianAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuardianAddress.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtGuardianAddress_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGuardianAddress.Validating
        'Capitalized the first Letter
        txtGuardianAddress.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtGuardianAddress.Text)
    End Sub

    Private Sub txtFatherName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFatherName.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtFatherName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFatherName.Validating
        'Capitalized the first Letter
        txtFatherName.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFatherName.Text)
    End Sub

    Private Sub txtFatherOccupation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFatherOccupation.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtFatherOccupation_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFatherOccupation.Validating
        'Capitalized the first Letter
        txtFatherOccupation.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFatherOccupation.Text)
    End Sub

    Private Sub txtMotherName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMotherName.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMotherName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMotherName.Validating
        'Capitalized the first Letter
        txtMotherName.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMotherName.Text)
    End Sub

    Private Sub txtMotherOccupation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMotherOccupation.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz .,"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMotherOccupation_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMotherOccupation.Validating
        'Capitalized the first Letter
        txtMotherOccupation.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMotherOccupation.Text)
    End Sub

    Private Sub txtStudentContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStudentContact.KeyPress
        'Accept Only numbers
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtStudentContact_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudentContact.Leave
        If txtStudentContact.Text = "" Then
            'walang gagawin
        Else
            If txtStudentContact.TextLength < 11 Then
                MessageBox.Show("The number should be atleast 11 digits", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentContact.Focus()
            End If
        End If
    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        'Accept Only numbers
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtGuardianContact_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGuardianContact.Leave
        If txtGuardianContact.Text = "" Then

        Else
            If txtGuardianContact.TextLength < 11 Then
                MessageBox.Show("The number should be atleast 11 digits", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtGuardianContact.Focus()
            End If
        End If
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        If cmbDepartment.Text = "CCS" Then
            cmbCourse.Items.Clear()
            cmbCourse.Text = ""
            cmbCourse.Enabled = True
            cmbCourse.Items.Add("Information Technology")
            cmbCourse.Items.Add("Associate Computer Technology")
            cmbYear.Items.Clear()
            cmbYear.Text = Nothing
            cmbYear.Items.Add("First Year")
            cmbYear.Items.Add("Second Year")
            cmbYear.Items.Add("Third Year")
            cmbYear.Items.Add("Fourth Year")
        ElseIf cmbDepartment.Text = "CEA" Then
            cmbCourse.Items.Clear()
            cmbCourse.Text = ""
            cmbCourse.Enabled = True
            cmbCourse.Items.Add("Electrical Engineering")
            cmbCourse.Items.Add("Civil Engineering")
            cmbYear.Items.Clear()
            cmbCourse.Text = Nothing
            cmbYear.Items.Add("First Year")
            cmbYear.Items.Add("Second Year")
            cmbYear.Items.Add("Third Year")
            cmbYear.Items.Add("Fourth Year")
            cmbYear.Items.Add("Fifth Year")
        ElseIf cmbDepartment.Text = "CABA" Then
            cmbCourse.Items.Clear()
            cmbCourse.Text = ""
            cmbCourse.Enabled = True
            cmbCourse.Items.Add("Accountancy")
            cmbCourse.Items.Add("Bussiness Administration")
            cmbYear.Items.Clear()
            cmbYear.Text = Nothing
            cmbYear.Items.Add("First Year")
            cmbYear.Items.Add("Second Year")
            cmbYear.Items.Add("Third Year")
            cmbYear.Items.Add("Fourth Year")
        End If
    End Sub
    Private Sub ScaleImage(ByVal p As PictureBox, ByRef i As Bitmap)
        If i.Height > p.Height Then
            Dim diff As Integer = i.Height - p.Height
            Dim Resized As Bitmap = New Bitmap(i, New Size(i.Width - diff, i.Height - diff))
            i = Resized
        End If
        If i.Width > p.Width Then
            Dim diff As Integer = i.Width - p.Width
            Dim Resized As Bitmap = New Bitmap(i, New Size(i.Width - diff, i.Height - diff))
            i = Resized
        End If
    End Sub
    Private Sub btnBrowsePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePicture.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Choose Student Picture"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                pictStudentPic.ImageLocation = fdlg.FileName
            End If

        End If

    End Sub

    Private Sub btnTakePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTakePicture.Click
        Camera.ShowDialog()
    End Sub
    Private Sub dtBirthday_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtBirthday.ValueChanged
        Dim myAge =
DateTime.Today.Year - dtBirthday.Value.Year
        txtAge.Text = myAge.ToString()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'send back default picture
        pictStudentPic.ImageLocation = Application.StartupPath & "\Pictures\Profile.jpg"
        clearComboBox()
        ClearTextBoxes()
    End Sub
End Class