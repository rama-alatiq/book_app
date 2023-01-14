Public Class Login_Form
    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlLogin.BackColor = Color.FromArgb(175, 0, 0, 0)
        pnlBar.BackColor = Color.FromArgb(175, 0, 0, 0)

        lblName.BackColor = Color.Transparent
        lblPass.BackColor = Color.Transparent


        picLogo.BorderStyle = BorderStyle.None


    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        If txtName.Text = String.Empty Or txtPass.Text = String.Empty Then
            MessageBox.Show("Warning : Required Missing Field !", "Literary Delights", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return

        End If
    End Sub
End Class
