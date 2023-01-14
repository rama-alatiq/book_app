Imports System.Data.SqlClient
Imports System.Data
Public Class Report_form
    Private Sub Report_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        DataGridView1.RowTemplate.Height = 25
        Load_Report()
    End Sub


    Sub Load_Report()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmdText = "SELECT tranno, transdate, bookid, bookname, author, price, tax, totalprice, grandtotal FROM book_inventory"
            cmd = New SqlCommand(cmdText, conn)
            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("tranno"), dr.Item("transdate"), dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("grandtotal"))
            End While


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        user_menu.switchPanel(books_From)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmdText = "SELECT tranno, transdate, bookid, bookname, author, price, tax, totalprice, grandtotal FROM book_inventory WHERE tranno like '%" & txtSearch.Text & "%' or bookid like '%" & txtSearch.Text & "%' or bookname like '%" & txtSearch.Text & "%'"
            cmd = New SqlCommand(cmdText, conn)
            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("tranno"), dr.Item("transdate"), dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("grandtotal"))
            End While


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")


        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmdText = "SELECT tranno, transdate, bookid, bookname, author, price, tax, totalprice, grandtotal FROM book_inventory WHERE transdate between '" & date1 & "'  and '" & date2 & "'"
            cmd = New SqlCommand(cmdText, conn)
            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("tranno"), dr.Item("transdate"), dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("grandtotal"))
            End While


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub


End Class