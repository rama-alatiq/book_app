Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows


Public Class MngUsers_Form
    Private Sub MngUsers_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
    End Sub

    Public Sub clear()
        txtName.Clear()
        txtPassword.Clear()
        txtUsername.Clear()
        coboRole.SelectedIndex = -1
    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Try
            conn.Open()
            cmdText = "INSERT INTO user_table (name,username,password,role) 
                                 VALUES (@name,@username,@password, @role)"
            cmd = New SqlCommand(cmdText, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@role", coboRole.Text)

            i = cmd.ExecuteNonQuery()

            If i > 0 And txtName.Text <> "" Then

                MessageBox.Show("New User Register Success ! ", "Literary Delights", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("New User Register Failed ! ", "Literary Delights", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()
        clear()

    End Sub

    'Private Sub btnCancel_Click(sender As Object, e As EventArgs) 
    '    clear()
    '    Me.Close()
    'End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        admin_menu.switchPanel(UsertblRecords)
    End Sub

    Private Sub coboRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coboRole.SelectedIndexChanged
        roleValue = coboRole.Text
        'roleValue = coboRole.SelectedItem.ToString()
    End Sub
End Class