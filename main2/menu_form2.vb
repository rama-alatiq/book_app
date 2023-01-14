Public Class menu_form2


    ''Fields'
    'Private currentBtn As 
    'Private leftBorderBtn As Panel
    'Private currentChildForm As Form
    ''Constructor'
    'Public Sub New()
    '    ' This call is required by the designer.'
    '    InitializeComponent()
    '    ' Add any initialization after the InitializeComponent() call.'
    '    leftBorderBtn = New Panel()
    '    leftBorderBtn.Size = New Size(7, 60)
    '    pnlMenu.Controls.Add(leftBorderBtn)
    '    'Form'
    '    Me.Text = String.Empty
    '    Me.ControlBox = False
    '    Me.DoubleBuffered = True
    '    Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    'End Sub
    ''Methods'
    'Private Sub ActivateButton(senderBtn As Object, customColor As Color)
    '    If senderBtn IsNot Nothing Then
    '        DisableButton()
    '        'Button'
    '        currentBtn = CType(senderBtn, IconButton)
    '        currentBtn.BackColor = Color.FromArgb(37, 36, 81)
    '        currentBtn.ForeColor = customColor
    '        currentBtn.IconColor = customColor
    '        currentBtn.TextAlign = ContentAlignment.MiddleCenter
    '        currentBtn.ImageAlign = ContentAlignment.MiddleRight
    '        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
    '        'Left Border'
    '        leftBorderBtn.BackColor = customColor
    '        leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
    '        leftBorderBtn.Visible = True
    '        leftBorderBtn.BringToFront()
    '        'current Form icon'
    '        IconCurrentForm.IconChar = currentBtn.IconChar
    '        IconCurrentForm.IconColor = customColor
    '    End If
    'End Sub




    ''Menu buttons Cliks'
    'Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
    '    ActivateButton(sender, RGBColors.color1)
    '    OpenChildForm(New FormDashboard)
    'End Sub
    ''Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
    ''    ActivateButton(sender, RGBColors.color2)
    ''    OpenChildForm(New FormOrders)
    ''End Sub
    ''Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
    ''    ActivateButton(sender, RGBColors.color3)
    ''    OpenChildForm(New FormProducts)
    ''End Sub
    ''Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
    ''    ActivateButton(sender, RGBColors.color4)
    ''    OpenChildForm(New FormCustomers)
    ''End Sub
    ''Private Sub btnMarketing_Click(sender As Object, e As EventArgs) Handles btnMarketing.Click
    ''    ActivateButton(sender, RGBColors.color5)
    ''    OpenChildForm(New FormMarketing)
    ''End Sub
    ''Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
    ''    ActivateButton(sender, RGBColors.color6)
    ''    OpenChildForm(New FormSetting)
    ''End Sub
    '''Drag Form'
    ''<DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    ''Private Shared Sub ReleaseCapture()
    ''End Sub
    ''<DllImport("user32.DLL", EntryPoint:="SendMessage")>
    ''Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    'End Sub
    'Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
    '    ReleaseCapture()
    '    SendMessage(Me.Handle, &H112&, &HF012&, 0)
    'End Sub
    ''Close-Maximize-Minimize'
    'Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    '    Application.Exit()
    'End Sub
    'Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
    '    If WindowState = FormWindowState.Normal Then
    '        WindowState = FormWindowState.Maximized
    '    Else
    '        WindowState = FormWindowState.Normal
    '    End If
    'End Sub
    'Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
    '    WindowState = FormWindowState.Minimized
    'End Sub
    ''Remove transparent border in maximized state'
    'Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    If WindowState = FormWindowState.Maximized Then
    '        FormBorderStyle = FormBorderStyle.None
    '    Else
    '        FormBorderStyle = FormBorderStyle.Sizable
    '    End If
    'End Sub
End Class