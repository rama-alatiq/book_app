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
        Me.btnContact = New FontAwesome.Sharp.IconButton()
        Me.btnReviews = New FontAwesome.Sharp.IconButton()
        Me.btnChat = New FontAwesome.Sharp.IconButton()
        Me.btnRecomm = New FontAwesome.Sharp.IconButton()
        Me.btnBooks = New FontAwesome.Sharp.IconButton()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.picbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlMenu.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnContact)
        Me.pnlMenu.Controls.Add(Me.btnReviews)
        Me.pnlMenu.Controls.Add(Me.btnChat)
        Me.pnlMenu.Controls.Add(Me.btnRecomm)
        Me.pnlMenu.Controls.Add(Me.btnBooks)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(220, 604)
        Me.pnlMenu.TabIndex = 1
        '
        'btnContact
        '
        Me.btnContact.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnContact.FlatAppearance.BorderSize = 0
        Me.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContact.Font = New System.Drawing.Font("Sylfaen", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnContact.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        Me.btnContact.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnContact.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnContact.IconSize = 28
        Me.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContact.Location = New System.Drawing.Point(0, 441)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.btnContact.Size = New System.Drawing.Size(220, 70)
        Me.btnContact.TabIndex = 5
        Me.btnContact.Text = "Contact Us"
        Me.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnContact.UseVisualStyleBackColor = True
        '
        'btnReviews
        '
        Me.btnReviews.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReviews.FlatAppearance.BorderSize = 0
        Me.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReviews.Font = New System.Drawing.Font("Sylfaen", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReviews.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReviews.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.btnReviews.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnReviews.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReviews.IconSize = 28
        Me.btnReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReviews.Location = New System.Drawing.Point(0, 371)
        Me.btnReviews.Name = "btnReviews"
        Me.btnReviews.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.btnReviews.Size = New System.Drawing.Size(220, 70)
        Me.btnReviews.TabIndex = 4
        Me.btnReviews.Text = "Reviews"
        Me.btnReviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReviews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReviews.UseVisualStyleBackColor = True
        '
        'btnChat
        '
        Me.btnChat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Font = New System.Drawing.Font("Sylfaen", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnChat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnChat.IconChar = FontAwesome.Sharp.IconChar.Rocketchat
        Me.btnChat.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnChat.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnChat.IconSize = 28
        Me.btnChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChat.Location = New System.Drawing.Point(0, 301)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.btnChat.Size = New System.Drawing.Size(220, 70)
        Me.btnChat.TabIndex = 3
        Me.btnChat.Text = "Readers Room"
        Me.btnChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'btnRecomm
        '
        Me.btnRecomm.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecomm.FlatAppearance.BorderSize = 0
        Me.btnRecomm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecomm.Font = New System.Drawing.Font("Sylfaen", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRecomm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRecomm.IconChar = FontAwesome.Sharp.IconChar.Lightbulb
        Me.btnRecomm.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnRecomm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRecomm.IconSize = 28
        Me.btnRecomm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecomm.Location = New System.Drawing.Point(0, 231)
        Me.btnRecomm.Name = "btnRecomm"
        Me.btnRecomm.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.btnRecomm.Size = New System.Drawing.Size(220, 70)
        Me.btnRecomm.TabIndex = 2
        Me.btnRecomm.Text = "Recommendations"
        Me.btnRecomm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecomm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecomm.UseVisualStyleBackColor = True
        '
        'btnBooks
        '
        Me.btnBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBooks.FlatAppearance.BorderSize = 0
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Sylfaen", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBooks.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnBooks.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnBooks.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBooks.IconSize = 28
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(0, 161)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Padding = New System.Windows.Forms.Padding(13, 0, 20, 0)
        Me.btnBooks.Size = New System.Drawing.Size(220, 70)
        Me.btnBooks.TabIndex = 1
        Me.btnBooks.Text = "Books and Podcasts"
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.picbxLogo)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 161)
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
        'user_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 604)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "user_menu"
        Me.Text = "user_menu"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picbxLogo As PictureBox
    Friend WithEvents btnContact As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReviews As FontAwesome.Sharp.IconButton
    Friend WithEvents btnChat As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRecomm As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBooks As FontAwesome.Sharp.IconButton
End Class
