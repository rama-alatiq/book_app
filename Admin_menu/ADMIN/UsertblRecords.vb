Imports System.Data.SqlClient
Imports System.Data
Public Class UsertblRecords
    Private Sub UsertblRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        DataGridView1.RowTemplate.Height = 30
        Load_Users()
    End Sub

    Sub Load_Users()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmdText = "SELECT name, username, password, role FROM user_table"
            cmd = New SqlCommand(cmdText, conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("name"), dr.Item("username"), dr.Item("password"), dr.Item("role"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnExitUseresRecords_Click(sender As Object, e As EventArgs) Handles btnExitUseresRecords.Click
        admin_menu.switchPanel(MngUsers_Form)
    End Sub
End Class