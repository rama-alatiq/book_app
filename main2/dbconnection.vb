Imports System.Data
Imports System.Data.SqlClient

Module db

    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public dt As New DataTable
    Public i As Integer
    Public result As Boolean

    Public Function dbconnection() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;username=root;password=;database=literary_db1"
            End If

        Catch ex As Exception

            result = False
            MsgBox("Server Not Connected ")

        End Try
        Return result
    End Function


End Module
