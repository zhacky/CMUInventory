Imports System.Data.SqlClient

Module DatabaseModule

    Private Property ServerName As String
    Private Property DatabaseName As String
    Private Property DbPassword As String
    Private Property DbUserName As String
    Public Property CurrentConnectionString As String


    Function GetDatabaseList() As String
        If String.IsNullOrEmpty(ServerName) Or String.IsNullOrEmpty(DbUserName) Or _
            String.IsNullOrEmpty(DbPassword) Then
            ServerName = AppInit.Default.DbServer
            DbUserName = AppInit.Default.DbUsername
            DbPassword = AppInit.Default.DbPassword

        End If

        Dim db As String = ""
        Dim connString As String
        connString = "Data Source=" & ServerName & _
            ";Initial Catalog=" & DatabaseName & ";Persist Security Info=True;User ID=" & DbUserName & _
            ";Password=" & DbPassword & ""
        Dim conn As New SqlConnection(connString)
        Dim query As String = "SELECT * FROM Sys.Databases"
        Dim cmd As New SqlCommand(query, conn)
        Dim reader As SqlDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()
            Using reader
                While reader.Read
                    ' Process SprocResults datareader here.
                    Console.WriteLine(reader.GetValue(0))
                    db &= "/" & reader.GetValue(0)
                End While
            End Using
        Catch ex As SqlException
            MessageBox.Show("Database connection error: " & vbCrLf & ex.Message)
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try



        Return db
    End Function

    Function SetAndTestDb(ByVal server As String, ByVal username As String, ByVal password As String, ByVal database As String) As Boolean
        Dim result As Boolean = False
        AppInit.Default.DbServer = server
        AppInit.Default.DbUsername = username
        AppInit.Default.DbPassword = password
        AppInit.Default.DbDatabase = database
        AppInit.Default.Save()

        ServerName = server
        DbUserName = username
        DbPassword = password
        DatabaseName = database
        CurrentConnectionString = "Data Source=" & ServerName & _
            ";Initial Catalog=" & DatabaseName & ";Persist Security Info=True;User ID=" & DbUserName & _
            ";Password=" & DbPassword & ""
        Dim conn As New SqlConnection(CurrentConnectionString)
        Dim query As String = "SELECT * FROM Products"
        Dim cmd As New SqlCommand(query, conn)
        Dim resultset As Object
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            resultset = cmd.ExecuteScalar()
            result = True
            MessageBox.Show("Test Succeeded")
        Catch ex As Exception
            MessageBox.Show("Failed connecting to the database")
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

        Return result
    End Function

    Function SetAndTestDb() As Boolean
        Dim result As Boolean = False
        ServerName = AppInit.Default.DbServer
        DbUserName = AppInit.Default.DbUsername
        DbPassword = AppInit.Default.DbPassword
        DatabaseName = AppInit.Default.DbDatabase
        CurrentConnectionString = "Data Source=" & ServerName & _
            ";Initial Catalog=" & DatabaseName & ";Persist Security Info=True;User ID=" & DbUserName & _
            ";Password=" & DbPassword & ""
        Dim conn As New SqlConnection(CurrentConnectionString)
        Dim query As String = "SELECT * FROM Products"
        Dim cmd As New SqlCommand(query, conn)
        Dim resultset As Object
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            resultset = cmd.ExecuteScalar()
            result = True
        Catch ex As Exception
            MessageBox.Show("Failed connecting to the database")

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try


        Return result
    End Function

End Module


