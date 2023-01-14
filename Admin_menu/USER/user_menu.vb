Public Class user_menu
    Private Sub user_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New System.Drawing.Size(1303, 822)
    End Sub

    Public Sub switchPanel(ByVal panel As Form)
        pnlUserForm.Controls.Clear()
        panel.TopLevel = False
        pnlUserForm.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        switchPanel(books_From)
    End Sub


    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        switchPanel(Feedback_form)
    End Sub

End Class