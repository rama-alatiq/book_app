<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MngUsers_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.coboRole = New System.Windows.Forms.ComboBox()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.pnlMngUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMngUsers
        '
        Me.pnlMngUsers.BackColor = System.Drawing.Color.Orange
        Me.pnlMngUsers.Controls.Add(Me.Label1)
        Me.pnlMngUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMngUsers.Location = New System.Drawing.Point(0, 0)
        Me.pnlMngUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMngUsers.Name = "pnlMngUsers"
        Me.pnlMngUsers.Size = New System.Drawing.Size(1067, 80)
        Me.pnlMngUsers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANAGE USERS"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Tw Cen MT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(370, 225)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(487, 39)
        Me.txtName.TabIndex = 6
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Tw Cen MT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsername.Location = New System.Drawing.Point(370, 296)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(487, 39)
        Me.txtUsername.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Tw Cen MT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(370, 367)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(487, 39)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(202, 232)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(78, 32)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Name"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRole.Location = New System.Drawing.Point(205, 442)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(60, 32)
        Me.lblRole.TabIndex = 11
        Me.lblRole.Text = "Role"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPassword.Location = New System.Drawing.Point(202, 372)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(111, 32)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsername.Location = New System.Drawing.Point(202, 302)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(121, 32)
        Me.lblUsername.TabIndex = 13
        Me.lblUsername.Text = "Username"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(320, 623)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(180, 51)
        Me.btnRegister.TabIndex = 15
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'coboRole
        '
        Me.coboRole.BackColor = System.Drawing.SystemColors.ControlLight
        Me.coboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.coboRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.coboRole.Font = New System.Drawing.Font("Tw Cen MT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.coboRole.ForeColor = System.Drawing.SystemColors.MenuText
        Me.coboRole.FormattingEnabled = True
        Me.coboRole.ItemHeight = 34
        Me.coboRole.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.coboRole.Location = New System.Drawing.Point(370, 438)
        Me.coboRole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.coboRole.Name = "coboRole"
        Me.coboRole.Size = New System.Drawing.Size(487, 42)
        Me.coboRole.TabIndex = 17
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRecords.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnRecords.FlatAppearance.BorderSize = 0
        Me.btnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRecords.Location = New System.Drawing.Point(566, 623)
        Me.btnRecords.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(180, 51)
        Me.btnRecords.TabIndex = 18
        Me.btnRecords.Text = "Display Records"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'MngUsers_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1067, 783)
        Me.Controls.Add(Me.btnRecords)
        Me.Controls.Add(Me.coboRole)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.pnlMngUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MngUsers_Form"
        Me.Text = "MngUsers_Form"
        Me.pnlMngUsers.ResumeLayout(False)
        Me.pnlMngUsers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMngUsers As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents coboRole As ComboBox
    Friend WithEvents btnRecords As Button
End Class
