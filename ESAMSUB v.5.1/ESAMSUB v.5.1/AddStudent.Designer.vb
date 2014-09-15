<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudentContact = New System.Windows.Forms.TextBox()
        Me.txtStudentAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.txtnationality = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFatherOccupation = New System.Windows.Forms.TextBox()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtMotherOccupation = New System.Windows.Forms.TextBox()
        Me.txtMotherName = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbCivilStatus = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtReligion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBrowsePicture = New System.Windows.Forms.Button()
        Me.pictStudentPic = New System.Windows.Forms.PictureBox()
        Me.btnTakePicture = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGuardian = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtGuardianAddress = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtGuardianContact = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pictStudentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(64, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1268, 57)
        Me.Panel2.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(42, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(281, 33)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Add New Student Record"
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.Color.White
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastname.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtLastname.Location = New System.Drawing.Point(154, 177)
        Me.txtLastname.MaxLength = 30
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(250, 26)
        Me.txtLastname.TabIndex = 4
        '
        'txtFirstname
        '
        Me.txtFirstname.BackColor = System.Drawing.Color.White
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstname.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtFirstname.Location = New System.Drawing.Point(154, 89)
        Me.txtFirstname.MaxLength = 30
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(250, 26)
        Me.txtFirstname.TabIndex = 2
        '
        'txtStudentId
        '
        Me.txtStudentId.BackColor = System.Drawing.Color.White
        Me.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentId.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtStudentId.Location = New System.Drawing.Point(154, 39)
        Me.txtStudentId.MaxLength = 30
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(250, 26)
        Me.txtStudentId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 22)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Student Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 22)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(61, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 22)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Last Name"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDepartment.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"CABA", "CCS", "CEA"})
        Me.cmbDepartment.Location = New System.Drawing.Point(154, 227)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(250, 28)
        Me.cmbDepartment.TabIndex = 5
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYear.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year", "Fifth Year"})
        Me.cmbYear.Location = New System.Drawing.Point(583, 186)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(176, 28)
        Me.cmbYear.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 22)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(491, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Year Level"
        '
        'txtStudentContact
        '
        Me.txtStudentContact.BackColor = System.Drawing.Color.White
        Me.txtStudentContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentContact.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtStudentContact.Location = New System.Drawing.Point(154, 427)
        Me.txtStudentContact.MaxLength = 11
        Me.txtStudentContact.Name = "txtStudentContact"
        Me.txtStudentContact.Size = New System.Drawing.Size(250, 26)
        Me.txtStudentContact.TabIndex = 9
        '
        'txtStudentAddress
        '
        Me.txtStudentAddress.BackColor = System.Drawing.Color.White
        Me.txtStudentAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentAddress.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtStudentAddress.Location = New System.Drawing.Point(154, 375)
        Me.txtStudentAddress.MaxLength = 100
        Me.txtStudentAddress.Name = "txtStudentAddress"
        Me.txtStudentAddress.Size = New System.Drawing.Size(250, 26)
        Me.txtStudentAddress.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 22)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Complete Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(18, 430)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 22)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Contact Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(38, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 22)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Middle Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(492, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 22)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Nationality"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BackColor = System.Drawing.Color.White
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMiddlename.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtMiddlename.Location = New System.Drawing.Point(154, 133)
        Me.txtMiddlename.MaxLength = 30
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(250, 26)
        Me.txtMiddlename.TabIndex = 3
        '
        'txtnationality
        '
        Me.txtnationality.BackColor = System.Drawing.Color.White
        Me.txtnationality.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnationality.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnationality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtnationality.Location = New System.Drawing.Point(583, 39)
        Me.txtnationality.MaxLength = 30
        Me.txtnationality.Name = "txtnationality"
        Me.txtnationality.Size = New System.Drawing.Size(176, 26)
        Me.txtnationality.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(856, 381)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 22)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "Father's Occupation"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(895, 336)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 22)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Father's Name"
        '
        'txtFatherOccupation
        '
        Me.txtFatherOccupation.BackColor = System.Drawing.Color.White
        Me.txtFatherOccupation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFatherOccupation.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherOccupation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtFatherOccupation.Location = New System.Drawing.Point(1013, 375)
        Me.txtFatherOccupation.MaxLength = 30
        Me.txtFatherOccupation.Name = "txtFatherOccupation"
        Me.txtFatherOccupation.Size = New System.Drawing.Size(250, 26)
        Me.txtFatherOccupation.TabIndex = 22
        '
        'txtFatherName
        '
        Me.txtFatherName.BackColor = System.Drawing.Color.White
        Me.txtFatherName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFatherName.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtFatherName.Location = New System.Drawing.Point(1013, 328)
        Me.txtFatherName.MaxLength = 30
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(250, 26)
        Me.txtFatherName.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(86, 281)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 22)
        Me.Label17.TabIndex = 95
        Me.Label17.Text = "Course"
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Enabled = False
        Me.cmbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCourse.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(154, 276)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(250, 28)
        Me.cmbCourse.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(849, 472)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(158, 22)
        Me.Label18.TabIndex = 99
        Me.Label18.Text = "Mother's Occupation"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(888, 425)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 22)
        Me.Label19.TabIndex = 98
        Me.Label19.Text = "Mother's Name"
        '
        'txtMotherOccupation
        '
        Me.txtMotherOccupation.BackColor = System.Drawing.Color.White
        Me.txtMotherOccupation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMotherOccupation.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotherOccupation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtMotherOccupation.Location = New System.Drawing.Point(1013, 470)
        Me.txtMotherOccupation.MaxLength = 30
        Me.txtMotherOccupation.Name = "txtMotherOccupation"
        Me.txtMotherOccupation.Size = New System.Drawing.Size(250, 26)
        Me.txtMotherOccupation.TabIndex = 24
        '
        'txtMotherName
        '
        Me.txtMotherName.BackColor = System.Drawing.Color.White
        Me.txtMotherName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMotherName.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotherName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtMotherName.Location = New System.Drawing.Point(1013, 423)
        Me.txtMotherName.MaxLength = 30
        Me.txtMotherName.Name = "txtMotherName"
        Me.txtMotherName.Size = New System.Drawing.Size(250, 26)
        Me.txtMotherName.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(42, 331)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(104, 22)
        Me.Label23.TabIndex = 107
        Me.Label23.Text = "Place of Birth"
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.BackColor = System.Drawing.Color.White
        Me.txtBirthPlace.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBirthPlace.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthPlace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtBirthPlace.Location = New System.Drawing.Point(154, 328)
        Me.txtBirthPlace.MaxLength = 100
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(250, 26)
        Me.txtBirthPlace.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(487, 136)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 22)
        Me.Label25.TabIndex = 113
        Me.Label25.Text = "Civil Status"
        '
        'cmbCivilStatus
        '
        Me.cmbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCivilStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCivilStatus.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCivilStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cmbCivilStatus.FormattingEnabled = True
        Me.cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widowed"})
        Me.cmbCivilStatus.Location = New System.Drawing.Point(583, 140)
        Me.cmbCivilStatus.Name = "cmbCivilStatus"
        Me.cmbCivilStatus.Size = New System.Drawing.Size(176, 28)
        Me.cmbCivilStatus.TabIndex = 12
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(506, 93)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 22)
        Me.Label26.TabIndex = 119
        Me.Label26.Text = "Religion"
        '
        'txtReligion
        '
        Me.txtReligion.BackColor = System.Drawing.Color.White
        Me.txtReligion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReligion.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReligion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtReligion.Location = New System.Drawing.Point(583, 90)
        Me.txtReligion.MaxLength = 30
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Size = New System.Drawing.Size(176, 26)
        Me.txtReligion.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBrowsePicture)
        Me.GroupBox1.Controls.Add(Me.pictStudentPic)
        Me.GroupBox1.Controls.Add(Me.btnTakePicture)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(1013, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 300)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Picture"
        '
        'btnBrowsePicture
        '
        Me.btnBrowsePicture.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Explorer
        Me.btnBrowsePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrowsePicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowsePicture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnBrowsePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowsePicture.Location = New System.Drawing.Point(156, 233)
        Me.btnBrowsePicture.Name = "btnBrowsePicture"
        Me.btnBrowsePicture.Size = New System.Drawing.Size(59, 58)
        Me.btnBrowsePicture.TabIndex = 26
        Me.btnBrowsePicture.UseVisualStyleBackColor = True
        '
        'pictStudentPic
        '
        Me.pictStudentPic.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Profile2
        Me.pictStudentPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictStudentPic.Location = New System.Drawing.Point(13, 26)
        Me.pictStudentPic.Name = "pictStudentPic"
        Me.pictStudentPic.Size = New System.Drawing.Size(201, 200)
        Me.pictStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictStudentPic.TabIndex = 114
        Me.pictStudentPic.TabStop = False
        '
        'btnTakePicture
        '
        Me.btnTakePicture.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Pictures_Library
        Me.btnTakePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTakePicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTakePicture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnTakePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTakePicture.Location = New System.Drawing.Point(13, 233)
        Me.btnTakePicture.Name = "btnTakePicture"
        Me.btnTakePicture.Size = New System.Drawing.Size(59, 58)
        Me.btnTakePicture.TabIndex = 25
        Me.btnTakePicture.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(1240, 641)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 20)
        Me.Label21.TabIndex = 124
        Me.Label21.Text = "Cancel"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(1051, 641)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 20)
        Me.Label27.TabIndex = 125
        Me.Label27.Text = "Save"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(1147, 641)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 20)
        Me.Label28.TabIndex = 127
        Me.Label28.Text = "Clear"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGender.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(583, 233)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(176, 28)
        Me.cmbGender.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(512, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 22)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Gender"
        '
        'dtBirthday
        '
        Me.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthday.Location = New System.Drawing.Point(583, 281)
        Me.dtBirthday.Name = "dtBirthday"
        Me.dtBirthday.Size = New System.Drawing.Size(176, 29)
        Me.dtBirthday.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(474, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 22)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Date of Birth"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtAge.Location = New System.Drawing.Point(583, 333)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(176, 26)
        Me.txtAge.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(540, 333)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 22)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Age"
        '
        'txtGuardian
        '
        Me.txtGuardian.BackColor = System.Drawing.Color.White
        Me.txtGuardian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuardian.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtGuardian.Location = New System.Drawing.Point(583, 378)
        Me.txtGuardian.MaxLength = 30
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(250, 26)
        Me.txtGuardian.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(444, 378)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(133, 22)
        Me.Label20.TabIndex = 103
        Me.Label20.Text = "Guardian's Name"
        '
        'txtGuardianAddress
        '
        Me.txtGuardianAddress.BackColor = System.Drawing.Color.White
        Me.txtGuardianAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuardianAddress.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtGuardianAddress.Location = New System.Drawing.Point(583, 468)
        Me.txtGuardianAddress.MaxLength = 100
        Me.txtGuardianAddress.Name = "txtGuardianAddress"
        Me.txtGuardianAddress.Size = New System.Drawing.Size(250, 26)
        Me.txtGuardianAddress.TabIndex = 20
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(430, 468)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 22)
        Me.Label22.TabIndex = 105
        Me.Label22.Text = "Complete Address"
        '
        'txtGuardianContact
        '
        Me.txtGuardianContact.BackColor = System.Drawing.Color.White
        Me.txtGuardianContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuardianContact.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtGuardianContact.Location = New System.Drawing.Point(583, 422)
        Me.txtGuardianContact.MaxLength = 11
        Me.txtGuardianContact.Name = "txtGuardianContact"
        Me.txtGuardianContact.Size = New System.Drawing.Size(250, 26)
        Me.txtGuardianContact.TabIndex = 19
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(449, 422)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(128, 22)
        Me.Label24.TabIndex = 109
        Me.Label24.Text = "Contact Number"
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Recycle_Bin_Full
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(1142, 588)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(48, 50)
        Me.btnClear.TabIndex = 28
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Save1
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(1046, 588)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(48, 50)
        Me.btnSave.TabIndex = 27
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.cancel1
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(1240, 588)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(48, 50)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Add_new_user2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 72)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtStudentId)
        Me.GroupBox2.Controls.Add(Me.txtFirstname)
        Me.GroupBox2.Controls.Add(Me.txtLastname)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cmbDepartment)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.txtMotherOccupation)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtMotherName)
        Me.GroupBox2.Controls.Add(Me.txtReligion)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtStudentAddress)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cmbCivilStatus)
        Me.GroupBox2.Controls.Add(Me.txtFatherOccupation)
        Me.GroupBox2.Controls.Add(Me.txtStudentContact)
        Me.GroupBox2.Controls.Add(Me.txtFatherName)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtGuardianContact)
        Me.GroupBox2.Controls.Add(Me.txtMiddlename)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtGuardianAddress)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtBirthPlace)
        Me.GroupBox2.Controls.Add(Me.txtGuardian)
        Me.GroupBox2.Controls.Add(Me.cmbCourse)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtnationality)
        Me.GroupBox2.Controls.Add(Me.cmbGender)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmbYear)
        Me.GroupBox2.Controls.Add(Me.dtBirthday)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtAge)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1279, 505)
        Me.GroupBox2.TabIndex = 184
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-8, 673)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1321, 27)
        Me.Panel1.TabIndex = 185
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pictStudentPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStudentContact As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtnationality As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFatherOccupation As System.Windows.Forms.TextBox
    Friend WithEvents txtFatherName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMotherOccupation As System.Windows.Forms.TextBox
    Friend WithEvents txtMotherName As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtBirthPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbCivilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents pictStudentPic As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowsePicture As System.Windows.Forms.Button
    Friend WithEvents btnTakePicture As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtReligion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtBirthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGuardian As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtGuardianAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtGuardianContact As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
