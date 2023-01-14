<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlLogin.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.txtPass)
        Me.pnlLogin.Controls.Add(Me.txtName)
        Me.pnlLogin.Controls.Add(Me.lblPass)
        Me.pnlLogin.Controls.Add(Me.lblName)
        Me.pnlLogin.Controls.Add(Me.picLogo)
        Me.pnlLogin.Location = New System.Drawing.Point(56, 99)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(592, 503)
        Me.pnlLogin.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Castellar", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(156, 394)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(278, 57)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtPass.Font = New System.Drawing.Font("High Tower Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPass.Location = New System.Drawing.Point(200, 274)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(337, 39)
        Me.txtPass.TabIndex = 5
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtName.Font = New System.Drawing.Font("High Tower Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(200, 197)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(337, 39)
        Me.txtName.TabIndex = 4
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPass.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPass.Location = New System.Drawing.Point(55, 283)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(132, 25)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblName.Location = New System.Drawing.Point(56, 206)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(131, 25)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Username"
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(171, 24)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(251, 102)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'pnlBar
        '
        Me.pnlBar.Controls.Add(Me.btnMinimize)
        Me.pnlBar.Controls.Add(Me.btnClose)
        Me.pnlBar.Location = New System.Drawing.Point(56, 45)
        Me.pnlBar.Name = "pnlBar"
        Me.pnlBar.Size = New System.Drawing.Size(592, 48)
        Me.pnlBar.TabIndex = 7
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(512, 8)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(553, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 7
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(702, 635)
        Me.Controls.Add(Me.pnlBar)
        Me.Controls.Add(Me.pnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_Form"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLogin As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents pnlBar As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
End Class
