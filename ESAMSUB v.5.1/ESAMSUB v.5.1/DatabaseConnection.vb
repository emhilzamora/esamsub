Imports MySql.Data.MySqlClient
Module DatabaseConnection
    Dim sConnection As New MySqlConnection
    Public Sub Connection()
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "SERVER =localhost; USERID=root;PASSWORD=;DATABASE=esamsub2014;"
            sConnection.Open()
        End If
    End Sub
End Module
