Imports System.Data
Imports System.Data.SqlClient

Module db

    Public conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kamal\source\repos\Login\Admin_menu\DB AND OTHERS\literary_db1.mdf;Integrated Security=True")
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public dt As New DataTable
    Public i As Integer
    Public result As Boolean
    Public cmdText As String
    Public roleValue As String
    Public Function dbconnection() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kamal\source\repos\Login\Admin_menu\DB AND OTHERS\literary_db1.mdf;Integrated Security=True"
            End If

        Catch ex As Exception

            result = False
            MsgBox("Server Not Connected ")

        End Try
        Return result
    End Function


End Module
