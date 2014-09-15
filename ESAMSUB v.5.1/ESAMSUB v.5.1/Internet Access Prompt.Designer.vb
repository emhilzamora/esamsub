<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Internet_Access_Prompt
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNoTimeLeft = New System.Windows.Forms.Label()
        Me.lblHourLeft = New System.Windows.Forms.Label()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.pctProfile = New System.Windows.Forms.PictureBox()
        Me.tmrInterval = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(106, 333)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(106, 354)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(50, 16)
        Me.lblYear.TabIndex = 1
        Me.lblYear.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course:"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(106, 372)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(50, 16)
        Me.lblCourse.TabIndex = 3
        Me.lblCourse.Text = "Label4"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(64, 86)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(62, 28)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "lblDate"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(64, 113)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(55, 28)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(592, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TIME LEFT"
        '
        'lblNoTimeLeft
        '
        Me.lblNoTimeLeft.AutoSize = True
        Me.lblNoTimeLeft.BackColor = System.Drawing.Color.Transparent
        Me.lblNoTimeLeft.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoTimeLeft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblNoTimeLeft.Location = New System.Drawing.Point(375, 232)
        Me.lblNoTimeLeft.Name = "lblNoTimeLeft"
        Me.lblNoTimeLeft.Size = New System.Drawing.Size(304, 32)
        Me.lblNoTimeLeft.TabIndex = 7
        Me.lblNoTimeLeft.Text = "SORRY YOU HAVE NO MORE TIME LEFT"
        Me.lblNoTimeLeft.Visible = False
        '
        'lblHourLeft
        '
        Me.lblHourLeft.AutoSize = True
        Me.lblHourLeft.BackColor = System.Drawing.Color.Transparent
        Me.lblHourLeft.Font = New System.Drawing.Font("Gill Sans MT", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourLeft.ForeColor = System.Drawing.Color.Red
        Me.lblHourLeft.Location = New System.Drawing.Point(435, 152)
        Me.lblHourLeft.Name = "lblHourLeft"
        Me.lblHourLeft.Size = New System.Drawing.Size(211, 183)
        Me.lblHourLeft.TabIndex = 8
        Me.lblHourLeft.Text = "10"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.BackColor = System.Drawing.Color.Transparent
        Me.lblInterval.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblInterval.Location = New System.Drawing.Point(422, 323)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(22, 28)
        Me.lblInterval.TabIndex = 9
        Me.lblInterval.Text = "0"
        Me.lblInterval.Visible = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(51, 390)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(116, 26)
        Me.lblId.TabIndex = 10
        Me.lblId.Text = "20111861"
        '
        'pctProfile
        '
        Me.pctProfile.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Profile1
        Me.pctProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctProfile.Location = New System.Drawing.Point(50, 147)
        Me.pctProfile.Name = "pctProfile"
        Me.pctProfile.Size = New System.Drawing.Size(192, 178)
        Me.pctProfile.TabIndex = 11
        Me.pctProfile.TabStop = False
        '
        'tmrInterval
        '
        '
        'Internet_Access_Prompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Internet_Access
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 435)
        Me.Controls.Add(Me.pctProfile)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblInterval)
        Me.Controls.Add(Me.lblNoTimeLeft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHourLeft)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Internet_Access_Prompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Internet_Access_Prompt"
        CType(Me.pctProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNoTimeLeft As System.Windows.Forms.Label
    Friend WithEvents lblHourLeft As System.Windows.Forms.Label
    Friend WithEvents lblInterval As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents pctProfile As System.Windows.Forms.PictureBox
    Friend WithEvents tmrInterval As System.Windows.Forms.Timer
End Class
