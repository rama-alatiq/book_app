<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_menu))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnFeedback = New FontAwesome.Sharp.IconButton()
        Me.btnMngUsers = New FontAwesome.Sharp.IconButton()
        Me.btnMngBooks = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.picbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlMenu.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnFeedback)
        Me.pnlMenu.Controls.Add(Me.btnMngUsers)
        Me.pnlMenu.Controls.Add(Me.btnMngBooks)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(220, 783)
        Me.pnlMenu.TabIndex = 2
        '
        'btnFeedback
        '
        Me.btnFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnFeedback.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFeedback.FlatAppearance.BorderSize = 0
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedback.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFeedback.IconChar = FontAwesome.Sharp.IconChar.Comment
        Me.btnFeedback.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnFeedback.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFeedback.IconSize = 28
        Me.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.Location = New System.Drawing.Point(0, 470)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Padding = New System.Windows.Forms.Padding(16, 0, 23, 0)
        Me.btnFeedback.Size = New System.Drawing.Size(220, 90)
        Me.btnFeedback.TabIndex = 4
        Me.btnFeedback.Text = "User's Feedback"
        Me.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'btnMngUsers
        '
        Me.btnMngUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnMngUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMngUsers.FlatAppearance.BorderSize = 0
        Me.btnMngUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMngUsers.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMngUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMngUsers.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btnMngUsers.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnMngUsers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMngUsers.IconSize = 28
        Me.btnMngUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMngUsers.Location = New System.Drawing.Point(0, 380)
        Me.btnMngUsers.Name = "btnMngUsers"
        Me.btnMngUsers.Padding = New System.Windows.Forms.Padding(16, 0, 23, 0)
        Me.btnMngUsers.Size = New System.Drawing.Size(220, 90)
        Me.btnMngUsers.TabIndex = 3
        Me.btnMngUsers.Text = "Manage Users"
        Me.btnMngUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMngUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMngUsers.UseVisualStyleBackColor = True
        '
        'btnMngBooks
        '
        Me.btnMngBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnMngBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMngBooks.FlatAppearance.BorderSize = 0
        Me.btnMngBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMngBooks.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMngBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMngBooks.IconChar = FontAwesome.Sharp.IconChar.BookReader
        Me.btnMngBooks.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnMngBooks.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMngBooks.IconSize = 28
        Me.btnMngBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMngBooks.Location = New System.Drawing.Point(0, 290)
        Me.btnMngBooks.Name = "btnMngBooks"
        Me.btnMngBooks.Padding = New System.Windows.Forms.Padding(16, 0, 23, 0)
        Me.btnMngBooks.Size = New System.Drawing.Size(220, 90)
        Me.btnMngBooks.TabIndex = 2
        Me.btnMngBooks.Text = "Manage Books"
        Me.btnMngBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMngBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMngBooks.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart
        Me.btnDashboard.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 28
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 200)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(16, 0, 23, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(220, 90)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.picbxLogo)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 200)
        Me.pnlLogo.TabIndex = 0
        '
        'picbxLogo
        '
        Me.picbxLogo.Image = CType(resources.GetObject("picbxLogo.Image"), System.Drawing.Image)
        Me.picbxLogo.Location = New System.Drawing.Point(12, 52)
        Me.picbxLogo.Name = "picbxLogo"
        Me.picbxLogo.Size = New System.Drawing.Size(184, 78)
        Me.picbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbxLogo.TabIndex = 0
        Me.picbxLogo.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(220, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1067, 783)
        Me.pnlMain.TabIndex = 3
        '
        'admin_menu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1287, 783)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlMenu)
        Me.MaximizeBox = False
        Me.Name = "admin_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_menu"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picbxLogo As PictureBox
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFeedback As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMngUsers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMngBooks As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlMain As Panel
End Class
