
Imports System.Data.SqlClient
Imports System.Data

Public Class Feedback_form

    Public showall As New UsersFeedback_form
    Dim type1 As String
    Dim level As String
    Dim feedbackList As New List(Of String)
    Dim bookname1 As String

    Private Sub Feedback_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbconnection()
        Try
            conn.Open()

            cmdText = "SELECT bookname from book_table"
            cmd = New SqlCommand(cmdText, conn)
            dr = cmd.ExecuteReader

            While dr.Read()
                coboBooks.Items.Add(dr("bookname"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Clear1()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        txtFeedback.Clear()
    End Sub

    Public Sub coboBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coboBooks.SelectedIndexChanged
        bookname1 = coboBooks.SelectedItem.ToString()
    End Sub

    Public Sub saveFeedback(bookname1 As String, type1 As String, level As String, text1 As String)

        Dim feedback As String = "Book Name  :  " & bookname1 & Environment.NewLine & "Feedback Type  :  " & type1 & Environment.NewLine & "Satisfaction Level  :  " & level & "Feedback  : " & text1 & Environment.NewLine & Environment.NewLine

        feedbackList.Add(feedback)

    End Sub


    Public Sub displayFeedback(text2 As TextBox)

        Dim output As String = ""

        For Each feedback In feedbackList
            output &= feedback & Environment.NewLine
        Next

        text2.Text = output

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear'
        txtFeedback.Clear()
    End Sub

    Private Sub btnDeleteFeed_Click(sender As Object, e As EventArgs) Handles btnDeleteFeed.Click

        'Submit'
        MsgBox("Thank you for reaching out and providing us with valuable feedback :)")
        saveFeedback(bookname1, type1, level, txtFeedback.Text)
        Clear1()
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click, RadioButton1.Click

        'Feedback Type'
        If RadioButton1.Checked = True Then
            type1 = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            type1 = RadioButton2.Text
        End If
    End Sub

    Private Sub RadioButton7_Click(sender As Object, e As EventArgs) Handles RadioButton7.Click, RadioButton6.Click, RadioButton5.Click, RadioButton4.Click, RadioButton3.Click

        'Satisfaction'
        If RadioButton3.Checked = True Then
            level = RadioButton3.Text
        ElseIf RadioButton4.Checked = True Then
            level = RadioButton4.Text
        ElseIf RadioButton5.Checked = True Then
            level = RadioButton5.Text
        ElseIf RadioButton6.Checked = True Then
            level = RadioButton6.Text
        ElseIf RadioButton7.Checked = True Then
            level = RadioButton7.Text
        End If
    End Sub

    Private Sub btnShowall_Click(sender As Object, e As EventArgs) Handles btnShowall.Click

        'show all'
        user_menu.switchPanel(showall)
        displayFeedback(showall.txtFeedbackAdmin)
    End Sub
End Class