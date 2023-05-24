Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    Private Shared connectionString As String = "Server=127.0.0.1;Database=lease_package;Uid=root;Pwd=123456;"

    Public Shared Function GetConnection() As MySqlConnection
        Dim connection As New MySqlConnection(connectionString)
        Return connection
    End Function

    Public Shared Sub CloseConnection(ByVal connection As MySqlConnection)
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class

