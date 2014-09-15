<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_User
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(80, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 33)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Change Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.txtOldPassword)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(33, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 306)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 22)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Open Sans Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(21, 70)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(227, 24)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 22)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.White
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Open Sans Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(21, 244)
        Me.txtConfirmPassword.MaxLength = 30
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(227, 24)
        Me.txtConfirmPassword.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 22)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Old Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.White
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPassword.Font = New System.Drawing.Font("Open Sans Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(21, 186)
        Me.txtNewPassword.MaxLength = 30
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassword.Size = New System.Drawing.Size(227, 24)
        Me.txtNewPassword.TabIndex = 3
        '
        'txtOldPassword
        '
        Me.txtOldPassword.BackColor = System.Drawing.Color.White
        Me.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldPassword.Font = New System.Drawing.Font("Open Sans Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtOldPassword.Location = New System.Drawing.Point(21, 128)
        Me.txtOldPassword.MaxLength = 30
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtOldPassword.Size = New System.Drawing.Size(227, 24)
        Me.txtOldPassword.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Update
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(239, 396)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(51, 50)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.cancel1
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(33, 396)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(51, 50)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ESAMSUB_v._5._1.My.Resources.Resources.Edit_User
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 72)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Edit_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(324, 457)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Open Sans Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Edit_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
