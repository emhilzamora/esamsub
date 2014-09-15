﻿Imports System.Runtime.InteropServices
Public Class Dashboard
    Dim tt1 As ToolTip
    Private Sub tmrTimeRunner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeRunner.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
        If lblUserLevel.Text = "Administrator" Then
            btnManageUsers.Enabled = True
            btnInternetAccess.Enabled = True
            btnCreatId.Enabled = True
            btnEmployee.Enabled = True
            btnMonitoring.Enabled = True
            btnStudents.Enabled = True

        ElseIf lblUserLevel.Text = "Registrar" Then
            btnStudents.Enabled = True
            btnManageUsers.Enabled = False
            btnInternetAccess.Enabled = False
            btnCreatId.Enabled = False
            btnEmployee.Enabled = False
            btnMonitoring.Enabled = False
        End If
    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        'para sa tooltip
        tt1 = New ToolTip
        tt1.SetToolTip(btnHelp, "Help")
        tt1.SetToolTip(btnAbout, "About")
        tt1.SetToolTip(btnShutdown, "Shutdown")
        tt1.SetToolTip(btnMinimize, "Minimize")
        tt1.SetToolTip(btnUserPic, "Log out")
        tt1.SetToolTip(btnManageUsers, "Open User Manager")
        tt1.SetToolTip(btnInternetAccess, "Monitor Internet access")
        tt1.SetToolTip(btnCreatId, "Create id")
        tt1.SetToolTip(btnEmployee, "Employees")
        tt1.SetToolTip(btnStudents, "Students")
        tt1.SetToolTip(btnMonitoring, "Start Monitoring")
        'enable the time
        tmrTimeRunner.Start()
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        'minimize application
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        Select Case MsgBox("Are you sure you want to Exit?", MsgBoxStyle.YesNo, "Close Application")
            Case MsgBoxResult.Yes
                'pag yes close the application
                animateWin(Me, False)
                Application.Exit()
            Case MsgBoxResult.No
                'Walang gagawin kapag no ang kanyang pinili
        End Select
    End Sub

    Private Sub btnManageUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageUsers.Click
        animateWin(Me, False)
        Me.Hide()
        animateWin(Manage_Users, True)
        Manage_Users.Show()
    End Sub

    Private Sub btnUserPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserPic.Click
        btnManageUsers.Enabled = False
        btnCreatId.Enabled = False
        btnEmployee.Enabled = False
        btnMonitoring.Enabled = False
        btnStudents.Enabled = False
        animateWin(Me, False)
        Me.Hide()
        animateWin(Startup, True)
        Startup.Show()
    End Sub

    Private Sub btnStudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudents.Click
        animateWin(Me, False)
        Me.Hide()
        animateWin(Students, True)
        Students.Show()
    End Sub

    Private Sub btnInternetAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInternetAccess.Click
        animateWin(Me, False)
        Me.Hide()
        animateWin(Internet_Access_Usage, True)
        Internet_Access_Usage.Show()
    End Sub

    Private Sub btnMonitoring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonitoring.Click
        animateWin(Me, False)
        Me.Hide()
        animateWin(Monitoring, True)
        Monitoring.Show()
    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        animateWin(Me, False)
        Me.Hide()
        animateWin(Employees, True)
        Employees.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class