Public Class Camera_edit
    'calls for the instances of camera
    Public touchless As New TouchlessLib.TouchlessMgr
    Public camera1 As TouchlessLib.Camera = touchless.Cameras.ElementAt(0)
    Private Sub Camera_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrCamera.Enabled = True
        'enabled buttons
        btnSave.Enabled = False
        'ito ung tuamtawag ng camera na may size na 
        touchless.CurrentCamera = camera1
        touchless.CurrentCamera.CaptureHeight = 480
        touchless.CurrentCamera.CaptureWidth = 480
    End Sub

    Private Sub tmrCamera_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCamera.Tick
        pictMainCamera.Image = touchless.CurrentCamera.GetCurrentImage
    End Sub

    Private Sub btnTakePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTakePicture.Click
        'sinasalin sa picturebox ang picture
        pictMainCamera.Image = touchless.CurrentCamera.GetCurrentImage
        tmrCamera.Stop()
        'enabled button
        btnSave.Enabled = True
        btnTakePicture.Enabled = False
    End Sub

    Private Sub btnRetake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetake.Click
        'start ulit ang camera para sa bagong pagtake ng picture
        tmrCamera.Start()
        'enabeld button
        btnSave.Enabled = False
        btnTakePicture.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnTakePicture.Enabled = True
        'ipapasa ang picture sa kabila
        'babalik sa pag add ng student
        animateWin(Me, False)
        Me.Hide()
        pictMainCamera.Image = Nothing
        Edit_Student_Record.Show()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        btnTakePicture.Enabled = True
        pictMainCamera.Image = Nothing
        animateWin(Me, False)
        Me.Hide()
        Edit_Student_Record.Show()
    End Sub
End Class