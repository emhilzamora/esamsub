<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_TimeOut
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
        Me.lblTimeIn = New System.Windows.Forms.Label()
        Me.lblTimeToday = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.tmrEnabled = New System.Windows.Forms.Timer(Me.components)
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pctProfile = New System.Windows.Forms.PictureBox()
        CType(Me.pctProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTimeIn
        '
        Me.lblTimeIn.AutoSize = True
        Me.lblTimeIn.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeIn.Font = New System.Drawing.Font("Gill Sans MT", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIn.ForeColor = System.Drawing.Color.Red
        Me.lblTimeIn.Location = New System.Drawing.Point(427, 201)
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.Size = New System.Drawing.Size(183, 101)
        Me.lblTimeIn.TabIndex = 64
        Me.lblTimeIn.Text = "5:30"
        '
        'lblTimeToday
        '
        Me.lblTimeToday.AutoSize = True
        Me.lblTimeToday.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeToday.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeToday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblTimeToday.Location = New System.Drawing.Point(79, 147)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(108, 32)
        Me.lblTimeToday.TabIndex = 63
        Me.lblTimeToday.Text = "DATE TODAY"
        '
        'lblDateToday
        '
        Me.lblDateToday.AutoSize = True
        Me.lblDateToday.BackColor = System.Drawing.Color.Transparent
        Me.lblDateToday.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblDateToday.Location = New System.Drawing.Point(79, 116)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(108, 32)
        Me.lblDateToday.TabIndex = 62
        Me.lblDateToday.Text = "DATE TODAY"
        '
        'lblTimeOut
        '
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeOut.Font = New System.Drawing.Font("Gill Sans MT", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.ForeColor = System.Drawing.Color.Red
        Me.lblTimeOut.Location = New System.Drawing.Point(427, 339)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(183, 101)
        Me.lblTimeOut.TabIndex = 61
        Me.lblTimeOut.Text = "5:30"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblId.Location = New System.Drawing.Point(114, 510)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(154, 29)
        Me.lblId.TabIndex = 60
        Me.lblId.Text = "ID NUMBER"
        '
        'tmrEnabled
        '
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(189, 478)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(65, 20)
        Me.lblDepartment.TabIndex = 67
        Me.lblDepartment.Text = "Course"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(150, 454)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(65, 20)
        Me.lblCourse.TabIndex = 66
        Me.lblCourse.Text = "Course"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.BackColor = System.Drawing.Color.Transparent
        Me.lblFname.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(140, 430)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(63, 20)
        Me.lblFname.TabIndex = 65
        Me.lblFname.Text = "Fname"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(277, 397)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(16, 16)
        Me.lblTime.TabIndex = 68
        Me.lblTime.Text = "0"
        Me.lblTime.Visible = False
        '
        'pctProfile
        '
        Me.pctProfile.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Profile1
        Me.pctProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctProfile.Location = New System.Drawing.Point(68, 192)
        Me.pctProfile.Name = "pctProfile"
        Me.pctProfile.Size = New System.Drawing.Size(241, 225)
        Me.pctProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctProfile.TabIndex = 69
        Me.pctProfile.TabStop = False
        '
        'Student_TimeOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Student_Login
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(924, 560)
        Me.Controls.Add(Me.pctProfile)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.lblTimeIn)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.lblTimeOut)
        Me.Controls.Add(Me.lblId)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Student_TimeOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_TimeOut"
        CType(Me.pctProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTimeIn As System.Windows.Forms.Label
    Friend WithEvents lblTimeToday As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents tmrEnabled As System.Windows.Forms.Timer
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents pctProfile As System.Windows.Forms.PictureBox
End Class
