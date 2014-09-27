Imports MySql.Data.MySqlClient
Public Class Internet_Access_CrystalReportViewer
    Dim sConnection As New MySqlConnection
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Try
            Dim report As New CRI_Internet_Access
            CrystalReportViewer1.ReportSource = report
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class