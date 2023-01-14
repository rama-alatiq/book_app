<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MngBooks_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMngUsers = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.picbxBook = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSaveMngBooks = New System.Windows.Forms.Button()
        Me.btnEditMngBooks = New System.Windows.Forms.Button()
        Me.btnDeleteMngBooks = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.coboTax = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtBookId = New System.Windows.Forms.TextBox()
        Me.pnlMngUsers.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.picbxBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMngUsers
        '
        Me.pnlMngUsers.BackColor = System.Drawing.Color.Orange
        Me.pnlMngUsers.Controls.Add(Me.Label1)
        Me.pnlMngUsers.Location = New System.Drawing.Point(0, 0)
        Me.pnlMngUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMngUsers.Name = "pnlMngUsers"
        Me.pnlMngUsers.Size = New System.Drawing.Size(1068, 80)
        Me.pnlMngUsers.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANAGE BOOKS"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TabControl1.ItemSize = New System.Drawing.Size(120, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 84)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1068, 700)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1060, 662)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BOOK LIST"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 47
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(3, 2)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1054, 658)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 43
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "BOOK ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 86
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "BOOK NAME "
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "AUTHOR"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 94
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "PRICE"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 73
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "TAX %"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 60
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "TOTAL PRICE"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 108
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.picbxBook)
        Me.TabPage2.Controls.Add(Me.btnSearch)
        Me.TabPage2.Controls.Add(Me.btnSaveMngBooks)
        Me.TabPage2.Controls.Add(Me.btnEditMngBooks)
        Me.TabPage2.Controls.Add(Me.btnDeleteMngBooks)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtSearch)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtTotalPrice)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.coboTax)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtPrice)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtAuthor)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtBookName)
        Me.TabPage2.Controls.Add(Me.lblName)
        Me.TabPage2.Controls.Add(Me.txtBookId)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(1060, 662)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MANAGE BOOK"
        '
        'picbxBook
        '
        Me.picbxBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbxBook.Location = New System.Drawing.Point(28, 131)
        Me.picbxBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picbxBook.Name = "picbxBook"
        Me.picbxBook.Size = New System.Drawing.Size(281, 318)
        Me.picbxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbxBook.TabIndex = 33
        Me.picbxBook.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(672, 45)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 30)
        Me.btnSearch.TabIndex = 32
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSaveMngBooks
        '
        Me.btnSaveMngBooks.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnSaveMngBooks.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSaveMngBooks.FlatAppearance.BorderSize = 0
        Me.btnSaveMngBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.btnSaveMngBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveMngBooks.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveMngBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSaveMngBooks.Location = New System.Drawing.Point(243, 530)
        Me.btnSaveMngBooks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveMngBooks.Name = "btnSaveMngBooks"
        Me.btnSaveMngBooks.Size = New System.Drawing.Size(164, 46)
        Me.btnSaveMngBooks.TabIndex = 31
        Me.btnSaveMngBooks.Text = "Save"
        Me.btnSaveMngBooks.UseVisualStyleBackColor = False
        '
        'btnEditMngBooks
        '
        Me.btnEditMngBooks.BackColor = System.Drawing.Color.BurlyWood
        Me.btnEditMngBooks.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditMngBooks.FlatAppearance.BorderSize = 0
        Me.btnEditMngBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna
        Me.btnEditMngBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditMngBooks.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditMngBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEditMngBooks.Location = New System.Drawing.Point(653, 530)
        Me.btnEditMngBooks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditMngBooks.Name = "btnEditMngBooks"
        Me.btnEditMngBooks.Size = New System.Drawing.Size(164, 46)
        Me.btnEditMngBooks.TabIndex = 30
        Me.btnEditMngBooks.Text = "Edit"
        Me.btnEditMngBooks.UseVisualStyleBackColor = False
        '
        'btnDeleteMngBooks
        '
        Me.btnDeleteMngBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnDeleteMngBooks.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDeleteMngBooks.FlatAppearance.BorderSize = 0
        Me.btnDeleteMngBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteMngBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteMngBooks.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteMngBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeleteMngBooks.Location = New System.Drawing.Point(448, 530)
        Me.btnDeleteMngBooks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteMngBooks.Name = "btnDeleteMngBooks"
        Me.btnDeleteMngBooks.Size = New System.Drawing.Size(164, 46)
        Me.btnDeleteMngBooks.TabIndex = 29
        Me.btnDeleteMngBooks.Text = "Delete"
        Me.btnDeleteMngBooks.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(268, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 25)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSearch.Location = New System.Drawing.Point(353, 45)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(295, 30)
        Me.txtSearch.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(352, 396)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Total Price"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPrice.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTotalPrice.Location = New System.Drawing.Point(490, 399)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(378, 30)
        Me.txtTotalPrice.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(352, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "TAX %"
        '
        'coboTax
        '
        Me.coboTax.BackColor = System.Drawing.SystemColors.Control
        Me.coboTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coboTax.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.coboTax.FormattingEnabled = True
        Me.coboTax.Items.AddRange(New Object() {"5", "9", "18", "24", "28"})
        Me.coboTax.Location = New System.Drawing.Point(490, 346)
        Me.coboTax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.coboTax.Name = "coboTax"
        Me.coboTax.Size = New System.Drawing.Size(378, 32)
        Me.coboTax.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(352, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPrice.Location = New System.Drawing.Point(490, 295)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(378, 30)
        Me.txtPrice.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(352, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Author"
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthor.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAuthor.Location = New System.Drawing.Point(490, 244)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(378, 30)
        Me.txtAuthor.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(352, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Book Name"
        '
        'txtBookName
        '
        Me.txtBookName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookName.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBookName.Location = New System.Drawing.Point(490, 192)
        Me.txtBookName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(378, 30)
        Me.txtBookName.TabIndex = 17
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(352, 141)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 25)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Book ID"
        '
        'txtBookId
        '
        Me.txtBookId.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtBookId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookId.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBookId.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtBookId.Location = New System.Drawing.Point(490, 140)
        Me.txtBookId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBookId.Name = "txtBookId"
        Me.txtBookId.Size = New System.Drawing.Size(378, 30)
        Me.txtBookId.TabIndex = 11
        '
        'MngBooks_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 783)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlMngUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MngBooks_form"
        Me.Text = "MngBooks_form"
        Me.pnlMngUsers.ResumeLayout(False)
        Me.pnlMngUsers.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.picbxBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMngUsers As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents coboTax As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtBookId As TextBox
    Friend WithEvents btnSaveMngBooks As Button
    Friend WithEvents btnEditMngBooks As Button
    Friend WithEvents btnDeleteMngBooks As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents picbxBook As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
