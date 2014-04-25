Imports System.Data.SqlClient
Module mdlConnection
    Public sqlConn As New SqlConnection(GetConnectionString)
    Public dReader As SqlDataReader

    Public Function GetConnectionString() As String
        Dim appConnectionString As New SqlConnectionStringBuilder


        With appConnectionString
            .DataSource = ".\SQLEXPRESS"
            .InitialCatalog = "DTR_DB"
            .IntegratedSecurity = True
        End With

        Return appConnectionString.ConnectionString
    End Function

    Public Sub OpenConnection()
        Try
            If sqlConn.State <> ConnectionState.Closed Then
                sqlConn.Close()
            End If

            sqlConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub ExecuteCommand(ByVal storedProcedureName As String, _
                              ByVal sqlParameters() As SqlParameter)
        Try
            Dim sqlComm As New SqlCommand

            OpenConnection()

            With sqlComm
                .CommandType = CommandType.StoredProcedure
                .CommandText = storedProcedureName
                .Connection = sqlConn
                .Parameters.AddRange(sqlParameters)
            End With

            sqlComm.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ExecuteCommand(ByVal storedProcedureName As String, _
                              Optional ByVal withParam As Boolean = False, _
                                Optional ByVal params() As SqlParameter = Nothing)
        Try
            Dim sqlComm As New SqlCommand

            OpenConnection()

            With sqlComm
                .CommandType = CommandType.StoredProcedure
                .CommandText = storedProcedureName
                .Connection = sqlConn
                If withParam = True Then
                    .Parameters.AddRange(params)
                End If
            End With

            dReader = sqlComm.ExecuteReader
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Module

