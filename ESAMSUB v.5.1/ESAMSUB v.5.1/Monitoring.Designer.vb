<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitoring
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.lvMonitoringStud = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtMonitoring = New System.Windows.Forms.TextBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1374, 79)
        Me.Panel2.TabIndex = 54
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Monitoring1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(809, 51)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(214, 22)
        Me.lblDate.TabIndex = 32
        Me.lblDate.Text = "monday, september 30,1002"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Open Sans Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(620, 37)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(183, 39)
        Me.lblTime.TabIndex = 31
        Me.lblTime.Text = "10:50:09 PM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 40)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Employee and Student Monitoring System of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Urdaneta City University using Barcode" & _
            " Technology"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 39)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Monitoring"
        '
        'tmrTimeDate
        '
        Me.tmrTimeDate.Enabled = True
        '
        'lvMonitoringStud
        '
        Me.lvMonitoringStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lvMonitoringStud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvMonitoringStud.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.lvMonitoringStud.ForeColor = System.Drawing.Color.White
        Me.lvMonitoringStud.FullRowSelect = True
        Me.lvMonitoringStud.GridLines = True
        Me.lvMonitoringStud.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvMonitoringStud.Location = New System.Drawing.Point(50, 156)
        Me.lvMonitoringStud.Name = "lvMonitoringStud"
        Me.lvMonitoringStud.Size = New System.Drawing.Size(1209, 470)
        Me.lvMonitoringStud.TabIndex = 55
        Me.lvMonitoringStud.UseCompatibleStateImageBehavior = False
        Me.lvMonitoringStud.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Student Id"
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Firstname"
        Me.ColumnHeader11.Width = 132
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Middlename"
        Me.ColumnHeader12.Width = 137
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Lastname"
        Me.ColumnHeader13.Width = 138
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Department"
        Me.ColumnHeader14.Width = 100
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Course"
        Me.ColumnHeader15.Width = 260
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Current date"
        Me.ColumnHeader17.Width = 129
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Time in"
        Me.ColumnHeader18.Width = 103
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Time out"
        Me.ColumnHeader19.Width = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-4, 649)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1308, 50)
        Me.Panel1.TabIndex = 56
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(785, 110)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(237, 26)
        Me.txtSearch.TabIndex = 58
        '
        'txtMonitoring
        '
        Me.txtMonitoring.BackColor = System.Drawing.Color.White
        Me.txtMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMonitoring.Enabled = False
        Me.txtMonitoring.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonitoring.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtMonitoring.Location = New System.Drawing.Point(345, 106)
        Me.txtMonitoring.MaxLength = 30
        Me.txtMonitoring.Name = "txtMonitoring"
        Me.txtMonitoring.Size = New System.Drawing.Size(237, 26)
        Me.txtMonitoring.TabIndex = 59
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Time-In", "Time-Out"})
        Me.cmbType.Location = New System.Drawing.Point(111, 102)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 30)
        Me.cmbType.TabIndex = 60
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Power___Restart1
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(1213, 96)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(36, 36)
        Me.btnReset.TabIndex = 62
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Search_alt__2_
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(1028, 103)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(41, 36)
        Me.btnSearch.TabIndex = 57
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1209, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 22)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Reset"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(238, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 22)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Login/Logout"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.left_Arrow
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(50, 96)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(43, 41)
        Me.btnBack.TabIndex = 63
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.txtMonitoring)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvMonitoringStud)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Monitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrTimeDate As System.Windows.Forms.Timer
    Friend WithEvents lvMonitoringStud As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtMonitoring As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
