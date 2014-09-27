Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Edit_Student_Record
    Dim tt = New ToolTip
    'tagahawak ng mga data
    Friend id As Integer
    Friend lastname As String
    Friend firstname As String
    Friend middlename As String
    Friend course As String
    Friend block As String
    Friend year As String
    Friend schoolyear As String
    Friend address As String
    Friend contactNo As String
    Friend gender As String
    Friend birthdate As String
    Friend age As String
    Friend nationality As String
    Friend religion As String
    Friend civil_status As String
    Friend father As String
    Friend fthrOccupation As String
    Friend mother As String
    Friend mthrOccupation As String
    Friend gname As String
    Friend gno As String
    Friend gaddress As String
    Friend department As String
    Friend birthplace As String
    Dim tt2 As ToolTip
    'sql connection
    Dim sqlConnection = New MySqlConnection
    'para sa hint ng textbox
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub Edit_Student_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sqlConnection.Open()
        End If
        'para sa tooltip
        tt = New ToolTip
        tt.SetToolTip(btnUpdate, "Update")
        tt.SetToolTip(btnCancel, "Cancel")
        'pag pasa ng laman ng mga variable
        Me.txtStudentId.Text = id
        Me.txtFirstname.Text = firstname
        Me.txtMiddlename.Text = middlename
        Me.txtLastname.Text = lastname
        Me.cmbDepartment.Text = department
        Me.cmbCourse.Text = course
        Me.txtBirthPlace.Text = birthplace
        Me.txtStudentAddress.Text = address
        Me.txtStudentContact.Text = contactNo
        Me.cmbGender.Text = gender
        Me.txtnationality.Text = nationality
        Me.txtReligion.Text = religion
        Me.cmbCivilStatus.Text = civil_status
        Me.cmbYear.Text = year
        Me.cmbGender.Text = gender
        Me.dtBirthday.Text = birthdate
        Me.txtAge.Text = age
        Me.txtGuardian.Text = gname
        Me.txtGuardianContact.Text = gno
        Me.txtGuardianAddress.Text = gaddress
        Me.txtFatherName.Text = father
        Me.txtFatherOccupation.Text = fthrOccupation
        Me.txtMotherName.Text = mother
        Me.txtMotherOccupation.Text = mthrOccupation


    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        If cmbDepartment.Text = "CCS" Then
            cmbCourse.Items.Clear()
            cmbCourse.Text = ""
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
            cmbCourse.Items.Add("Electrical Engineering")
            cmbCourse.Items.Add("Civil Engineering")
            cmbYear.Items.Clear()
            cmbYear.Text = Nothing
            cmbYear.Items.Add("First Year")
            cmbYear.Items.Add("Second Year")
            cmbYear.Items.Add("Third Year")
            cmbYear.Items.Add("Fourth Year")
            cmbYear.Items.Add("Fifth Year")
        ElseIf cmbDepartment.Text = "CABA" Then
            cmbCourse.Items.Clear()
            cmbCourse.Text = ""
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
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'error handling
        On Error GoTo labas
        'validation kung bakante ang mga textbox
        If txtFirstname.Text = Nothing Then
            MessageBox.Show("First name is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstname.Focus()
        ElseIf txtMiddlename.Text = Nothing Then
            MessageBox.Show("Middle name is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMiddlename.Focus()
        ElseIf txtLastname.Text = Nothing Then
            MessageBox.Show("Last name is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastname.Focus()
        ElseIf cmbDepartment.Text = Nothing Then
            MessageBox.Show("Department is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbDepartment.Focus()
        ElseIf cmbCourse.Text = Nothing Then
            MessageBox.Show("Course is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCourse.Focus()
        ElseIf txtBirthPlace.Text = Nothing Then
            MessageBox.Show("Birth place is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthPlace.Focus()
        ElseIf txtStudentAddress.Text = Nothing Then
            MessageBox.Show("Student address is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStudentAddress.Focus()
        ElseIf txtStudentContact.Text = Nothing Then
            MessageBox.Show("Student contact is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStudentContact.Focus()
        ElseIf txtnationality.Text = Nothing Then
            MessageBox.Show("Nationality is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnationality.Focus()
        ElseIf txtReligion.Text = Nothing Then
            MessageBox.Show("Religion is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtReligion.Focus()
        ElseIf cmbCivilStatus.Text = Nothing Then
            MessageBox.Show("Civil status is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCivilStatus.Focus()
        ElseIf cmbYear.Text = Nothing Then
            MessageBox.Show("Year level is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbYear.Focus()
        ElseIf cmbGender.Text = Nothing Then
            MessageBox.Show("Gender is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbGender.Focus()
        ElseIf dtBirthday.Text = Nothing Then
            MessageBox.Show("Birthdate is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtBirthday.Focus()
        ElseIf txtAge.Text = Nothing Then
            MessageBox.Show("Age is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAge.Focus()
        ElseIf txtGuardian.Text = Nothing Then
            MessageBox.Show("Guardian is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuardian.Focus()
        ElseIf txtGuardianAddress.Text = Nothing Then
            MessageBox.Show("Guardian address is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuardianAddress.Focus()
        ElseIf txtGuardianContact.Text = Nothing Then
            MessageBox.Show("Guardian contact number is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuardianContact.Focus()
        ElseIf txtFatherName.Text = Nothing Then
            MessageBox.Show("Father name is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherName.Focus()
        ElseIf txtFatherOccupation.Text = Nothing Then
            MessageBox.Show("Father occupation is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherOccupation.Focus()
        ElseIf txtMotherOccupation.Text = Nothing Then
            MessageBox.Show("Mother occupation is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMotherOccupation.Focus()
        ElseIf txtMotherName.Text = Nothing Then
            MessageBox.Show("Mother name is required field", "Cannot update student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMotherName.Focus()
        Else
            Select Case MsgBox("Are you sure do you want to save changes?", MsgBoxStyle.YesNo, "Save changes")
                Case MsgBoxResult.Yes
                    'update student record query
                    Dim sqlQuery As String = "UPDATE tbl_student SET fname =' " & Me.txtFirstname.Text.Trim & _
              "', mname = '" & Me.txtMiddlename.Text.Trim & " ', lname = '" & Me.txtLastname.Text.Trim & " ', department = '" & Me.cmbDepartment.Text.Trim & " ', course = '" & Me.cmbCourse.Text.Trim & " ', birth_place = '" & Me.txtBirthPlace.Text.Trim & " ', address = '" & Me.txtStudentAddress.Text.Trim & " ', contact_no = '" & Me.txtStudentContact.Text & " ', nationality = '" & Me.txtnationality.Text.Trim & " ', religion = '" & Me.txtReligion.Text.Trim & " ', civil_status = '" & Me.cmbCivilStatus.Text & " ', year = '" & Me.cmbYear.Text & " ', gender = '" & Me.cmbGender.Text & " ', date_birth = '" & Me.dtBirthday.Text & " ', age = '" & Me.txtAge.Text & " ', gName = '" & Me.txtGuardian.Text & " ', gContact = '" & Me.txtGuardianContact.Text & " ', gAddress = '" & Me.txtGuardianAddress.Text & " ', father = '" & Me.txtFatherName.Text & " ', fthr_occupation = '" & Me.txtFatherOccupation.Text & " ', mother = '" & Me.txtMotherName.Text & " ', mthr_occupation = '" & Me.txtMotherOccupation.Text & " ' WHERE  idnumber='" & id & "'"
                    Dim sqlCommand As New MySqlCommand
                    With sqlCommand

                        .CommandText = sqlQuery
                        .Connection = sqlConnection
                        .ExecuteNonQuery()
                    End With
                    'Add record to tbl access card if department is CCs
                    If cmbDepartment.Text = "CCS" Then
                        Dim query_internet_access = "INSERT into tbl_internet_access(idnumber,fname,mname,lname,course,year,hour_left)VALUES('" & Me.txtStudentId.Text.Trim & _
                        "','" & Me.txtFirstname.Text.Trim & "','" & Me.txtMiddlename.Text.Trim & "','" & Me.txtLastname.Text.Trim & "','" & Me.cmbCourse.Text.Trim & "','" & Me.cmbYear.Text.Trim & "','" & "10" & "')ON DUPLICATE KEY UPDATE idnumber = '" & Me.txtStudentId.Text & "'"
                        Dim sqlCommand1 As New MySqlCommand

                        With sqlCommand1
                            .CommandText = query_internet_access
                            .Connection = sqlConnection
                            .ExecuteNonQuery()
                        End With
                    End If

                    'delete student from internet acccess if change the course
                    If cmbDepartment.Text = "CABA" Or cmbDepartment.Text = "CEA" Then
                        Dim query_remove_student As String = "DELETE FROM tbl_internet_access WHERE  idnumber = '" & Me.txtStudentId.Text & "'"
                        Dim sqlCommand2 As New MySqlCommand
                        With sqlCommand2

                            .CommandText = query_remove_student
                            .Connection = sqlConnection
                            .ExecuteNonQuery()
                        End With

                    End If
                    ClearTextBoxes()
                    clearComboBox()
                    animateWin(Me, False)
                    Me.Close()
                    animateWin(Students, True)
                    Students.Show()
                    Students.LoadStudent()
                    'send back default picture
                Case MsgBoxResult.No
                    Select Case MsgBox("Exit editing ?", MsgBoxStyle.YesNo, "Save changes")
                        Case MsgBoxResult.Yes
                            ClearTextBoxes()
                            clearComboBox()
                            animateWin(Me, False)
                            Me.Close()
                            animateWin(Students, True)
                            Students.Show()
                            Students.LoadStudent()
                            'send back default picture
                        Case MsgBoxResult.No
                            'walang gagawin
                    End Select
            End Select
        End If
labas:
    End Sub
    'lilinisin ang mga textbox
    Public Sub ClearTextBoxes()
        txtAge.Text = Nothing
        txtBirthPlace.Text = Nothing
        txtFatherName.Text = Nothing
        txtFatherOccupation.Text = Nothing
        txtFirstname.Text = Nothing
        txtLastname.Text = Nothing
        txtMiddlename.Text = Nothing
        txtGuardian.Text = Nothing
        txtGuardianAddress.Text = Nothing
        txtGuardianContact.Text = Nothing
        txtMotherName.Text = Nothing
        txtMotherOccupation.Text = Nothing
        txtReligion.Text = Nothing
        txtnationality.Text = Nothing
        txtStudentContact.Text = Nothing
        txtStudentAddress.Text = Nothing
    End Sub
    'lilinisin ang mga combobox
    Public Sub clearComboBox()
        cmbCivilStatus.Text = Nothing
        cmbDepartment.Text = Nothing
        cmbYear.Text = Nothing
        cmbGender.Text = Nothing
        cmbCourse.Text = Nothing
    End Sub
    Private Sub txtFirstname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstname.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
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
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ,."
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
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ,."
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

    Private Sub txtBirthPlace_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBirthPlace.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ,."
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtBirthPlace_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBirthPlace.Validating
        'Capitalized the first Letter
        txtBirthPlace.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBirthPlace.Text)
    End Sub

    Private Sub txtStudentAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStudentAddress.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz,. "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtStudentAddress_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStudentAddress.Validating
        'Capitalized the first Letter
        txtStudentAddress.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtStudentAddress.Text)
    End Sub

    Private Sub txtnationality_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnationality.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ,."
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
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ,."
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
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ,."
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
    Private Sub txtFatherOccupation_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFatherOccupation.Validating
        'Capitalized the first Letter
        txtFatherOccupation.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFatherOccupation.Text)
    End Sub

    Private Sub txtMotherName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMotherName.KeyPress
        'Accept Only Letters
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ,."
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
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ,."
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
    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        'Accept Only numbers
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtGuardianContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuardianContact.KeyPress
        'Accept Only numbers
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStudentContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStudentContact.KeyPress
        'Accept Only numbers
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtGuardianContact_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGuardianContact.Leave
        If txtGuardianContact.Text = "" Then
            'walang gagawin
        Else
            If txtGuardianContact.TextLength < 11 Then
                MessageBox.Show("The number should be atleast 11 digits", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtGuardianContact.Focus()
            End If
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        animateWin(Me, False)
        Me.Close()
        animateWin(Students, True)
        Students.Show()
        ClearTextBoxes()
        clearComboBox()
        'send back default picture
    End Sub

    Private Sub dtBirthday_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtBirthday.ValueChanged
        'set ang birthday automatically
        Dim yr As Integer = DateDiff(DateInterval.Year, dtBirthday.Value, Now)
        txtAge.Text = yr
    End Sub
    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        If cmbCourse.Text = "Associate Computer Technology" Then
            cmbYear.Items.Clear()
            cmbYear.Items.Add("First Year")
            cmbYear.Items.Add("Second Year")
        End If
    End Sub
End Class