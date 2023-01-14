<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersFeedback_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMngUsers = New System.Windows.Forms.Panel()
        Me.btnExittt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFeedbackAdmin = New System.Windows.Forms.TextBox()
        Me.btnShowall = New System.Windows.Forms.Button()
        Me.pnlMngUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMngUsers
        '
        Me.pnlMngUsers.BackColor = System.Drawing.Color.Orange
        Me.pnlMngUsers.Controls.Add(Me.btnExittt)
        Me.pnlMngUsers.Controls.Add(Me.Label1)
        Me.pnlMngUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMngUsers.Location = New System.Drawing.Point(0, 0)
        Me.pnlMngUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMngUsers.Name = "pnlMngUsers"
        Me.pnlMngUsers.Size = New System.Drawing.Size(1067, 80)
        Me.pnlMngUsers.TabIndex = 6
        '
        'btnExittt
        '
        Me.btnExittt.FlatAppearance.BorderSize = 0
        Me.btnExittt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExittt.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExittt.ForeColor = System.Drawing.Color.White
        Me.btnExittt.Location = New System.Drawing.Point(931, 15)
        Me.btnExittt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExittt.Name = "btnExittt"
        Me.btnExittt.Size = New System.Drawing.Size(114, 40)
        Me.btnExittt.TabIndex = 40
        Me.btnExittt.Text = "[ EXIT ]"
        Me.btnExittt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER'S FEEDBACK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(178, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 38)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Feedback"
        '
        'txtFeedbackAdmin
        '
        Me.txtFeedbackAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFeedbackAdmin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFeedbackAdmin.Location = New System.Drawing.Point(178, 192)
        Me.txtFeedbackAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFeedbackAdmin.Multiline = True
        Me.txtFeedbackAdmin.Name = "txtFeedbackAdmin"
        Me.txtFeedbackAdmin.Size = New System.Drawing.Size(728, 491)
        Me.txtFeedbackAdmin.TabIndex = 18
        '
        'btnShowall
        '
        Me.btnShowall.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnShowall.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnShowall.FlatAppearance.BorderSize = 0
        Me.btnShowall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnShowall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowall.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnShowall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnShowall.Location = New System.Drawing.Point(469, 712)
        Me.btnShowall.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShowall.Name = "btnShowall"
        Me.btnShowall.Size = New System.Drawing.Size(153, 47)
        Me.btnShowall.TabIndex = 37
        Me.btnShowall.Text = "Show All"
        Me.btnShowall.UseVisualStyleBackColor = False
        Me.btnShowall.Visible = False
        '
        'UsersFeedback_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 783)
        Me.Controls.Add(Me.btnShowall)
        Me.Controls.Add(Me.txtFeedbackAdmin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlMngUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UsersFeedback_form"
        Me.Text = "UsersFeedback_form"
        Me.pnlMngUsers.ResumeLayout(False)
        Me.pnlMngUsers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMngUsers As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFeedbackAdmin As TextBox
    Friend WithEvents btnExittt As Button
    Friend WithEvents btnShowall As Button
End Class
