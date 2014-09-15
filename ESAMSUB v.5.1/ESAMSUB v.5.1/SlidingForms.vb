Module SlidingForms
    Public Enum AnimateWindowFlags
        AW_HOR_POSITIVE = &H1
        AW_HOR_NEGATIVE = &H2
        AW_VER_POSITIVE = &H4
        AW_VER_NEGATIVE = &H8
        AW_CENTER = &H10
        AW_HIDE = &H10000
        AW_ACTIVATE = &H20000
        AW_SLIDE = &H40000
        AW_BLEND = &H80000
    End Enum
    Dim f1 As Form
    Public Declare Auto Function AnimateWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal time As Integer, ByVal flags As AnimateWindowFlags) As Boolean
    Sub Main()
        Dim xx As Integer = Screen.PrimaryScreen.Bounds.Width - f1.Size.Width
        Dim yy As Integer = Screen.PrimaryScreen.Bounds.Height / 2 - (f1.Size.Height / 2)
        f1.Location = New Point(xx, yy)
        Application.Run(f1)
    End Sub
    Sub animateWin(ByVal frmToAnimate As Form, ByVal showForm As Boolean)
        f1 = frmToAnimate
        If showForm Then
            AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_HOR_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)
        Else
            AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_HOR_POSITIVE Or AnimateWindowFlags.AW_HIDE)
        End If
    End Sub
End Module
