Imports System.Data.SqlClient
Imports System.Windows
Imports System.IO

Public Class MngBooks_form
    Private Sub MngBooks_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        DataGridView1.RowTemplate.Height = 30
        Load_Books()
        Auto_bookId()
    End Sub

    Public Sub Load_Books()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmdText = "SELECT bookid, bookname, author, price, tax, totalprice FROM book_table"
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

    Public Sub clear()
        picbxBook.Image = Nothing
        txtAuthor.Clear()
        txtBookName.Clear()
        txtPrice.Clear()
        txtTotalPrice.Clear()
        coboTax.SelectedIndex = -1

    End Sub


    Public Sub Auto_bookId()
        txtBookId.Clear()
        Try
            conn.Open()
            cmdText = "SELECT * FROM book_table ORDER BY ID DESC"
            cmd = New SqlCommand(cmdText, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                txtBookId.Text = dr.Item("bookId").ToString + 1
            Else
                txtBookId.Text = Date.Now.ToString("yyyy") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()
    End Sub

    'Private Sub btnCloseMngBooks_Click(sender As Object, e As EventArgs) 
    '    Me.Close()
    'End Sub

    Private Sub picbxBook_Click(sender As Object, e As EventArgs) Handles picbxBook.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            picbxBook.Image = Image.FromFile(pop.FileName)

        End If
    End Sub

    Private Sub btnSaveMngBooks_Click(sender As Object, e As EventArgs) Handles btnSaveMngBooks.Click
        If txtAuthor.Text = String.Empty Or txtBookName.Text = String.Empty Or txtPrice.Text = String.Empty Or txtTotalPrice.Text = String.Empty Then
            MsgBox("Warning : Missing Required Field !", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                cmdText = "INSERT INTO book_table (bookid , bookname , author , price , tax , totalprice , img )
                           VALUES ( @bookid , @bookname , @author , @price , @tax , @totalprice , @img )"
                cmd = New SqlCommand(cmdText, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@bookid", txtBookId.Text)
                cmd.Parameters.AddWithValue("@bookname", txtBookName.Text)
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text)
                cmd.Parameters.AddWithValue("@price", CDec(txtPrice.Text))
                cmd.Parameters.AddWithValue("@tax", coboTax.Text)
                cmd.Parameters.AddWithValue("@totalprice", CDec(txtTotalPrice.Text))

                Dim FileSize As New UInt32
                Dim mstream As New System.IO.MemoryStream
                picbxBook.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                FileSize = mstream.Length
                mstream.Close()

                cmd.Parameters.AddWithValue("@img", picture)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("New Book Register Sucess !", vbInformation)
                Else
                    MsgBox("Book Register Failed !", vbExclamation)
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            Load_Books()
            Auto_bookId()
        End If
    End Sub

    Private Sub coboTax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coboTax.SelectedIndexChanged
        Try
            txtTotalPrice.Text = CDec(txtPrice.Text * coboTax.Text / 100) + txtPrice.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            conn.Open()
            cmdText = "SELECT bookid, bookname, author, price, tax, totalprice, img FROM book_table WHERE bookid= '" & txtSearch.Text & "' "
            cmd = New SqlCommand(cmdText, conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                txtBookId.Text = dr.Item("bookid")
                txtBookName.Text = dr.Item("bookname")
                txtAuthor.Text = dr.Item("author")
                txtPrice.Text = dr.Item("price")
                txtTotalPrice.Text = dr.Item("totalprice")
                coboTax.Text = dr.Item("tax")


                Dim bytes As [Byte]() = dr.Item("img")
                Dim ms As New MemoryStream(bytes)
                picbxBook.Image = Image.FromStream(ms)

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub btnEditMngBooks_Click(sender As Object, e As EventArgs) Handles btnEditMngBooks.Click
        Try
            conn.Open()
            cmdText = "UPDATE book_table SET bookname=@bookname, author=@author, price=@price, tax=@tax, totalprice=@totalprice WHERE bookid=@bookid"
            cmd = New SqlCommand(cmdText, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@bookname", txtBookName.Text)
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txtPrice.Text))
            cmd.Parameters.AddWithValue("@tax", coboTax.Text)
            cmd.Parameters.AddWithValue("@totalprice", CDec(txtTotalPrice.Text))

            'Dim FileSize As New UInt32
            'Dim mstream As New System.IO.MemoryStream
            'picbxBook.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            'Dim picture() As Byte = mstream.GetBuffer
            'FileSize = mstream.Length
            'mstream.Close()

            'cmd.Parameters.AddWithValue("@img", picture)
            cmd.Parameters.AddWithValue("@bookid", txtBookId.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Book Update Success !", vbInformation)
            Else
                MsgBox("Book Update Failed !", vbExclamation)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        Load_Books()
        Auto_bookId()
    End Sub

    Private Sub btnDeleteMngBooks_Click(sender As Object, e As EventArgs) Handles btnDeleteMngBooks.Click
        If MsgBox("Are You Sure You Want To Delete This Book", vbQuestion + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmdText = "DELETE book_table WHERE bookid=@bookid"
                cmd = New SqlCommand(cmdText, conn)
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@bookid", txtBookId.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Book Deleted Success !", vbInformation)
                Else
                    MsgBox("Book Deleted Failed !", vbExclamation)
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            Load_Books()
            Auto_bookId()
        Else
            Return
        End If
    End Sub


End Class