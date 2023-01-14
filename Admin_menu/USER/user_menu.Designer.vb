<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class user_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_menu))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnFeedback = New FontAwesome.Sharp.IconButton()
        Me.btnBooks = New FontAwesome.Sharp.IconButton()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.picbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlUserForm = New System.Windows.Forms.Panel()
        Me.pnlMenu.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnFeedback)
        Me.pnlMenu.Controls.Add(Me.btnBooks)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(220, 783)
        Me.pnlMenu.TabIndex = 1
        '
        'btnFeedback
        '
        Me.btnFeedback.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFeedback.FlatAppearance.BorderSize = 0
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedback.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFeedback.ForeColor = System.Drawing.Color.White
        Me.btnFeedback.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        Me.btnFeedback.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnFeedback.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFeedback.IconSize = 28
        Me.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.Location = New System.Drawing.Point(0, 370)
        Me.btnFeedback.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Padding = New System.Windows.Forms.Padding(16, 0, 23, 0)
        Me.btnFeedback.Size = New System.Drawing.Size(220, 120)
        Me.btnFeedback.TabIndex = 5
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'btnBooks
        '
        Me.btnBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBooks.FlatAppearance.BorderSize = 0
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBooks.ForeColor = System.Drawing.Color.White
        Me.btnBooks.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnBooks.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnBooks.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBooks.IconSize = 28
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(0, 250)
        Me.btnBooks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Padding = New System.Windows.Forms.Padding(16, 0, 23, 0)
        Me.btnBooks.Size = New System.Drawing.Size(220, 120)
        Me.btnBooks.TabIndex = 1
        Me.btnBooks.Text = "Books "
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.picbxLogo)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 250)
        Me.pnlLogo.TabIndex = 0
        '
        'picbxLogo
        '
        Me.picbxLogo.Image = CType(resources.GetObject("picbxLogo.Image"), System.Drawing.Image)
        Me.picbxLogo.Location = New System.Drawing.Point(12, 53)
        Me.picbxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picbxLogo.Name = "picbxLogo"
        Me.picbxLogo.Size = New System.Drawing.Size(184, 78)
        Me.picbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbxLogo.TabIndex = 0
        Me.picbxLogo.TabStop = False
        '
        'pnlUserForm
        '
        Me.pnlUserForm.BackColor = System.Drawing.Color.White
        Me.pnlUserForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUserForm.Location = New System.Drawing.Point(220, 0)
        Me.pnlUserForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlUserForm.Name = "pnlUserForm"
        Me.pnlUserForm.Size = New System.Drawing.Size(1067, 783)
        Me.pnlUserForm.TabIndex = 2
        '
        'user_menu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1287, 783)
        Me.Controls.Add(Me.pnlUserForm)
        Me.Controls.Add(Me.pnlMenu)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "user_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "user_menu"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picbxLogo As PictureBox
    Friend WithEvents btnFeedback As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBooks As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlUserForm As Panel
End Class
