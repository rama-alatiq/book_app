Public Class UsersFeedback_form

    Private Sub btnExittt_Click(sender As Object, e As EventArgs) Handles btnExittt.Click
        user_menu.switchPanel(Feedback_form)
    End Sub

    Private Sub btnShowall_Click(sender As Object, e As EventArgs) Handles btnShowall.Click
        Feedback_form.displayFeedback(txtFeedbackAdmin)
    End Sub

End Class