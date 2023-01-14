Imports System.Data.SqlClient
Imports System.Data
Public Class admin_menu

    Private Sub admin_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New System.Drawing.Size(1303, 822)
    End Sub

    Public Sub switchPanel(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnMngUsers_Click(sender As Object, e As EventArgs) Handles btnMngUsers.Click
        switchPanel(MngUsers_Form)
    End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        switchPanel(dashboard_form)
    End Sub

    Private Sub btnMngBooks_Click(sender As Object, e As EventArgs) Handles btnMngBooks.Click
        switchPanel(MngBooks_form)
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        switchPanel(UsersFeedback_form)
    End Sub


End Class