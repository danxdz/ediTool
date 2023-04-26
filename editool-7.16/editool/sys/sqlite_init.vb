Option Explicit On

Imports System.Data.SQLite
Imports Newtonsoft.Json
Imports System.IO
Imports System.Data.Entity.Core

Module SQLiteDB

    Public Class SQLiteToolDatabase

        Private ReadOnly connectionString As String
        Private ReadOnly tableName As String

        Public Sub New(tableName As String)
            Me.connectionString = "Data Source=mydatabase.db"
            Me.tableName = tableName
        End Sub

        Public Sub CreateToolTable()
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = $"CREATE TABLE IF NOT EXISTS {tableName} (id INTEGER PRIMARY KEY, GroupeMat TEXT, ManufRef TEXT, D1 REAL, L1 REAL, NoTT INTEGER)"
                Dim command As New SQLiteCommand(query, connection)
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Sub

        Public Sub AddTool(tool As Tool)

            Dim tableName As String = If(tool.Type <> "", tool.Type, "endMill")

            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                Dim testquery = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}';"
                Dim findTable As New SQLiteCommand(testquery, connection)

                Dim result As Object = findTable.ExecuteScalar()

                If result Is Nothing Then
                    CreateToolTable()
                    ' Tabela não existe, faça o que deseja aqui '
                End If
                Dim query As String = $"INSERT INTO {tableName} ( GroupeMat, ManufRef, D1, L1, NoTT) VALUES (@GroupeMat, @ManufRef, @D1, @L1, @NoTT);"

                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@GroupeMat", tool.GroupeMat)
                    command.Parameters.AddWithValue("@ManufRef", tool.ManufRef)
                    command.Parameters.AddWithValue("@D1", tool.D1)
                    command.Parameters.AddWithValue("@L1", tool.L1)
                    command.Parameters.AddWithValue("@NoTT", tool.NoTT)
                    command.ExecuteNonQuery()
                    End Using

                ' Create JSON file for tool
                Dim json As String = JsonConvert.SerializeObject(tool, Formatting.Indented)
                Dim jsonFilePath As String = Path.Combine(Application.StartupPath, "tools", $"{tool.ManufRef}.json")

                File.WriteAllText(jsonFilePath, json)

                connection.Close()
            End Using
        End Sub

        Public Function GetAllTools() As List(Of Tool)
            Dim tools As New List(Of Tool)
            Dim query As String = $"SELECT * FROM {tableName};"

            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Try
                    Using command As New SQLiteCommand(query, connection)
                        Using reader As SQLiteDataReader = command.ExecuteReader()
                            While reader.Read()
                                Dim tool As New Tool With {
                                                                .ManufRef = reader("ManufRef").ToString(),
                                                                .GroupeMat = reader("GroupeMat").ToString(),
                                                                .D1 = CDbl(reader("D1")),
                                                                .L1 = CDbl(reader("L1")),
                                                                .NoTT = CInt(reader("NoTT"))
                                                            }
                                tools.Add(tool)
                            End While
                        End Using
                    End Using
                Catch ex As Exception
                    Debug.WriteLine("error: ", ex)
                End Try

                connection.Close()
            End Using

            Return tools
        End Function

    End Class

End Module
