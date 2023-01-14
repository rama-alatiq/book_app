
Imports System.Data.SqlClient
Imports System.Data

Public Class dashboard_form


    Sub Get_Dashboard()

        conn.Open()
        cmdText = "SELECT SUM(totalprice) FROM book_inventory WHERE transdate= '" & Date.Now.ToString("yyyy-MM-dd") & "'"
        cmd = New SqlCommand(cmdText, conn)
        lblTodaySales.Text = cmd.ExecuteScalar
        conn.Close()


        conn.Open()
        cmdText = "SELECT COUNT(bookid) FROM book_inventory WHERE transdate= '" & Date.Now.ToString("yyyy-MM-dd") & "'"
        cmd = New SqlCommand(cmdText, conn)
        lblNoOfTodaySales.Text = cmd.ExecuteScalar
        conn.Close()


        conn.Open()
        cmdText = "SELECT SUM(totalprice) FROM book_inventory WHERE transmonth= '" & Date.Now.ToString("MM") & "'"
        cmd = New SqlCommand(cmdText, conn)
        lblCurrentMonth.Text = cmd.ExecuteScalar
        conn.Close()


        conn.Open()
        cmdText = "SELECT COUNT(bookid) FROM book_inventory WHERE transmonth= '" & Date.Now.ToString("MM") & "'"
        cmd = New SqlCommand(cmdText, conn)
        lblNoOfMonthlySAles.Text = cmd.ExecuteScalar
        conn.Close()


        conn.Open()
        cmdText = "SELECT COUNT(bookid) FROM book_table"
        cmd = New SqlCommand(cmdText, conn)
        lblTotalBooks.Text = cmd.ExecuteScalar
        conn.Close()


        conn.Open()
        cmdText = "SELECT COUNT(name) FROM user_table"
        cmd = New SqlCommand(cmdText, conn)
        lblTotalUsers.Text = cmd.ExecuteScalar
        conn.Close()

    End Sub

    Private Sub dashboard_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        Get_Dashboard()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
        lblDate.Text = Date.Now.ToString("dddd MMMM-yyyy")
    End Sub


End Class