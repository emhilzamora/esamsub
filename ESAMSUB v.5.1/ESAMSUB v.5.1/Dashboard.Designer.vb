<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.lblUserLevel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrTimeRunner = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCreatId = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnInternetAccess = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.btnMonitoring = New System.Windows.Forms.Button()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUserPic = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserLevel
        '
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblUserLevel.Font = New System.Drawing.Font("Open Sans Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLevel.ForeColor = System.Drawing.Color.White
        Me.lblUserLevel.Location = New System.Drawing.Point(1056, 106)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(184, 37)
        Me.lblUserLevel.TabIndex = 15
        Me.lblUserLevel.Text = "Administrator"
        Me.lblUserLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnShutdown)
        Me.Panel2.Controls.Add(Me.btnMinimize)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-6, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1374, 79)
        Me.Panel2.TabIndex = 29
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
        Me.Label2.Location = New System.Drawing.Point(103, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(379, 40)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Integrated Employees and Students Monitoring System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "using Barcode Technology of " & _
            "Urdaneta City University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(100, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 39)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Dashboard"
        '
        'tmrTimeRunner
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-2, 673)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1308, 27)
        Me.Panel1.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1167, 610)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 60)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "©Copyright Protected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      All Right Reseve" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "System Developer 2014" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         ies" & _
            "ms v.6.1"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.report_mirror1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(591, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 197)
        Me.Button1.TabIndex = 50
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCreatId
        '
        Me.btnCreatId.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Create_Id_mirror
        Me.btnCreatId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreatId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreatId.Enabled = False
        Me.btnCreatId.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnCreatId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreatId.Location = New System.Drawing.Point(365, 389)
        Me.btnCreatId.Name = "btnCreatId"
        Me.btnCreatId.Size = New System.Drawing.Size(220, 197)
        Me.btnCreatId.TabIndex = 46
        Me.btnCreatId.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Untitled_mirror
        Me.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployee.Enabled = False
        Me.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Location = New System.Drawing.Point(837, 148)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(220, 197)
        Me.btnEmployee.TabIndex = 45
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnInternetAccess
        '
        Me.btnInternetAccess.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.internet_Access_mirror
        Me.btnInternetAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInternetAccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInternetAccess.Enabled = False
        Me.btnInternetAccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnInternetAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInternetAccess.Location = New System.Drawing.Point(139, 389)
        Me.btnInternetAccess.Name = "btnInternetAccess"
        Me.btnInternetAccess.Size = New System.Drawing.Size(220, 197)
        Me.btnInternetAccess.TabIndex = 44
        Me.btnInternetAccess.UseVisualStyleBackColor = True
        '
        'btnStudents
        '
        Me.btnStudents.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Login_Icon_mirror2
        Me.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudents.Enabled = False
        Me.btnStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudents.Location = New System.Drawing.Point(591, 148)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(220, 197)
        Me.btnStudents.TabIndex = 43
        Me.btnStudents.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Info
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Location = New System.Drawing.Point(12, 85)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(41, 40)
        Me.btnAbout.TabIndex = 42
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Help
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Location = New System.Drawing.Point(71, 85)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(41, 40)
        Me.btnHelp.TabIndex = 41
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnManageUsers
        '
        Me.btnManageUsers.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Manage_Users
        Me.btnManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageUsers.Enabled = False
        Me.btnManageUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageUsers.Location = New System.Drawing.Point(139, 148)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(220, 197)
        Me.btnManageUsers.TabIndex = 40
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'btnMonitoring
        '
        Me.btnMonitoring.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Monitoring_mirror
        Me.btnMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMonitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonitoring.Enabled = False
        Me.btnMonitoring.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonitoring.Location = New System.Drawing.Point(365, 148)
        Me.btnMonitoring.Name = "btnMonitoring"
        Me.btnMonitoring.Size = New System.Drawing.Size(220, 197)
        Me.btnMonitoring.TabIndex = 39
        Me.btnMonitoring.UseVisualStyleBackColor = True
        '
        'btnShutdown
        '
        Me.btnShutdown.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.logout_1_512
        Me.btnShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShutdown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShutdown.Location = New System.Drawing.Point(1258, 7)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(42, 37)
        Me.btnShutdown.TabIndex = 37
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.searchalt
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(1199, 6)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(42, 37)
        Me.btnMinimize.TabIndex = 36
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(8, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 74)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnUserPic
        '
        Me.btnUserPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnUserPic.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Profile1
        Me.btnUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUserPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnUserPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserPic.Location = New System.Drawing.Point(1239, 95)
        Me.btnUserPic.Name = "btnUserPic"
        Me.btnUserPic.Size = New System.Drawing.Size(48, 48)
        Me.btnUserPic.TabIndex = 14
        Me.btnUserPic.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCreatId)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnInternetAccess)
        Me.Controls.Add(Me.btnStudents)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnManageUsers)
        Me.Controls.Add(Me.btnMonitoring)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnUserPic)
        Me.Controls.Add(Me.lblUserLevel)
        Me.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUserPic As System.Windows.Forms.Button
    Friend WithEvents lblUserLevel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tmrTimeRunner As System.Windows.Forms.Timer
    Friend WithEvents btnManageUsers As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnStudents As System.Windows.Forms.Button
    Friend WithEvents btnInternetAccess As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnCreatId As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnMonitoring As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
