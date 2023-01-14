
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Public Class books_From

    Private WithEvents pic As New PictureBox
    Private WithEvents lblbookid As New Label
    Private WithEvents lblbookname As New Label
    Private WithEvents lblprice As New Label
    Private Sub books_From_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        DataGridView1.RowTemplate.Height = 28
        lblTransDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Auto_generateTransNo()
        Load_Books()
    End Sub


    Sub Auto_generateTransNo()
        Try
            conn.Open()
            cmdText = "SELECT * from book_inventory ORDER BY ID DESC"
            cmd = New SqlCommand(cmdText, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblTransNo.Text = dr.Item("tranno").ToString + 2
            Else
                lblTransNo.Text = Date.Now.ToString("yyyyMM") & "001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub


    Sub Total()
        Dim sum As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(6).Value
        Next

        lblGrandTotal.Text = Format(CDec(sum), "#,##0.00")

    End Sub


    Sub Load_Controls()

        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))

        pic = New PictureBox
        pic.Width = 130
        pic.Height = 160
        pic.BackgroundImageLayout = ImageLayout.Stretch
        pic.Tag = dr.Item("bookid").ToString


        lblbookid = New Label
        With lblbookid
            .ForeColor = Color.Black
            .BackColor = Color.Wheat
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Tag = dr.Item("bookid").ToString
        End With


        lblbookname = New Label
        With lblbookname
            .ForeColor = Color.Black
            .BackColor = Color.Wheat
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Tag = dr.Item("bookid").ToString
        End With


        lblprice = New Label
        With lblprice
            .ForeColor = Color.DarkOrange
            .BackColor = Color.Wheat
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Bottom
            .Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .Tag = dr.Item("bookid").ToString
        End With



        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        pic.BackgroundImage = bitmap
        lblbookid.Text = dr.Item("bookid").ToString
        lblbookname.Text = dr.Item("bookname").ToString
        lblprice.Text = dr.Item("totalprice").ToString

        pic.Controls.Add(lblbookid)
        pic.Controls.Add(lblbookname)
        pic.Controls.Add(lblprice)

        FlowLayoutPanel1.Controls.Add(pic)

        AddHandler pic.Click, AddressOf Selectimg_click
        AddHandler lblbookid.Click, AddressOf Selectimg_click
        AddHandler lblbookname.Click, AddressOf Selectimg_click
        AddHandler lblprice.Click, AddressOf Selectimg_click

    End Sub

    Private Sub Selectimg_click(sender As Object, e As EventArgs)
        Try
            conn.Open()
            cmdText = "SELECT bookid,bookname,author,price,tax,totalprice from book_table WHERE bookid like '%" & sender.tag.ToString & "%'"
            cmd = New SqlCommand(cmdText, conn)
            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Public Sub Load_Books()

        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()
        conn.Open()
        cmdText = "SELECT img,bookid,bookname,author,price,tax,totalprice from book_table "
        cmd = New SqlCommand(cmdText, conn)
        dr = cmd.ExecuteReader

        While dr.Read = True
            Load_Controls()
        End While

        dr.DisposeAsync()
        conn.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Total()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()
        conn.Open()
        cmdText = "SELECT img,bookid,bookname,author,price,tax,totalprice, status from book_table WHERE status='' and bookid like '%" & txtSearch.Text & "%' or bookname like '%" & txtSearch.Text & "%'"
        cmd = New SqlCommand(cmdText, conn)
        dr = cmd.ExecuteReader

        While dr.Read = True
            Load_Controls()
        End While

        dr.DisposeAsync()
        conn.Close()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        'If lblGrandTotal.Text > txtEnterAmount.Text Then
        If lblGrandTotal.Text = "0.00" Then
            MsgBox("Infinity Balance", vbExclamation)
            Return
        Else


            Try
                conn.Open()
                cmdText = "insert into book_inventory(tranno, transdate, transmonth, bookid, bookname, author, price, tax, totalprice, grandtotal) VALUES(@tranno, @transdate, @transmonth, @bookid, @bookname, @author, @price, @tax, @totalprice, @grandtotal)"
                cmd = New SqlCommand(cmdText, conn)

                For j As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@tranno", lblTransNo.Text)
                    cmd.Parameters.AddWithValue("@transdate", lblTransDate.Text)
                    cmd.Parameters.AddWithValue("@transmonth", Date.Now.ToString("MM"))
                    cmd.Parameters.AddWithValue("@bookid", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@bookname", DataGridView1.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@author", DataGridView1.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@tax", DataGridView1.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@totalprice", DataGridView1.Rows(j).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@grandtotal", lblGrandTotal.Text)
                    i = cmd.ExecuteNonQuery
                Next

                If i > 0 Then
                    MsgBox("Transaction Save Success ! ", vbInformation)
                Else
                    MsgBox("Transaction Save Failed ! ", vbExclamation)
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            update_bookstock()
            clear()
        End If

    End Sub


    Sub clear()
        DataGridView1.Rows.Clear()
        Load_Books()
        Auto_generateTransNo()
        txtSearch.Clear()
        lblGrandTotal.Text = "0.00"

    End Sub


    Sub update_bookstock()
        Try
            conn.Open()
            cmdText = "UPDATE book_table set status=@status WHERE bookid=@bookid"
            cmd = New SqlCommand(cmdText, conn)

            For j As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@status", "SELL")
                cmd.Parameters.AddWithValue("@bookid", DataGridView1.Rows(j).Cells(1).Value)
                i = cmd.ExecuteNonQuery
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clear()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        user_menu.switchPanel(Report_form)
    End Sub


End Class