<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.PasswordResetPanel = New System.Windows.Forms.Panel()
        Me.PasswordResetBox = New System.Windows.Forms.GroupBox()
        Me.PassInfo = New System.Windows.Forms.Button()
        Me.PINInfo = New System.Windows.Forms.Button()
        Me.Visiblityopen = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NewPassTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PINTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ConfPassTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClearButton2 = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BrushLogo = New System.Windows.Forms.Button()
        Me.MiniButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.LoginPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PasswordResetPanel.SuspendLayout()
        Me.PasswordResetBox.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.SplitContainer1.Panel1.BackgroundImage = Global.WashWorld.My.Resources.Resources.SMALL_WashworldLogo_Globe_ai
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SplitContainer1.Panel1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.LoginPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PasswordResetPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(900, 309)
        Me.SplitContainer1.SplitterDistance = 310
        Me.SplitContainer1.TabIndex = 0
        '
        'LoginPanel
        '
        Me.LoginPanel.Controls.Add(Me.GroupBox1)
        Me.LoginPanel.Location = New System.Drawing.Point(21, 21)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(543, 260)
        Me.LoginPanel.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PowderBlue
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxUsername)
        Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.LoginButton)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(543, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label5.Location = New System.Drawing.Point(6, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "LOGIN PAGE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Font = New System.Drawing.Font("MS PGothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(179, 78)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(162, 24)
        Me.TextBoxUsername.TabIndex = 1
        Me.TextBoxUsername.Text = "Abhimanyu"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("MS PGothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(179, 137)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(162, 24)
        Me.TextBoxPassword.TabIndex = 2
        Me.TextBoxPassword.Text = "12345"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Raleway SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(168, 214)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(197, 18)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click here to reset password"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.GreenYellow
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 213)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(517, 21)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 7
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.LightGray
        Me.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(372, 131)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(101, 38)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.LightGray
        Me.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LoginButton.Location = New System.Drawing.Point(372, 71)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(101, 37)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "Login"
        Me.LoginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'PasswordResetPanel
        '
        Me.PasswordResetPanel.Controls.Add(Me.PasswordResetBox)
        Me.PasswordResetPanel.Location = New System.Drawing.Point(21, 21)
        Me.PasswordResetPanel.Name = "PasswordResetPanel"
        Me.PasswordResetPanel.Size = New System.Drawing.Size(543, 260)
        Me.PasswordResetPanel.TabIndex = 10
        '
        'PasswordResetBox
        '
        Me.PasswordResetBox.BackColor = System.Drawing.Color.PowderBlue
        Me.PasswordResetBox.Controls.Add(Me.PassInfo)
        Me.PasswordResetBox.Controls.Add(Me.PINInfo)
        Me.PasswordResetBox.Controls.Add(Me.Visiblityopen)
        Me.PasswordResetBox.Controls.Add(Me.Button1)
        Me.PasswordResetBox.Controls.Add(Me.BackButton)
        Me.PasswordResetBox.Controls.Add(Me.Label6)
        Me.PasswordResetBox.Controls.Add(Me.NewPassTextBox)
        Me.PasswordResetBox.Controls.Add(Me.UsernameTextBox)
        Me.PasswordResetBox.Controls.Add(Me.PINTextBox)
        Me.PasswordResetBox.Controls.Add(Me.Label10)
        Me.PasswordResetBox.Controls.Add(Me.ConfPassTextBox)
        Me.PasswordResetBox.Controls.Add(Me.Label9)
        Me.PasswordResetBox.Controls.Add(Me.Label7)
        Me.PasswordResetBox.Controls.Add(Me.Label8)
        Me.PasswordResetBox.Controls.Add(Me.ClearButton2)
        Me.PasswordResetBox.Controls.Add(Me.ResetButton)
        Me.PasswordResetBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PasswordResetBox.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordResetBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.PasswordResetBox.Location = New System.Drawing.Point(0, 0)
        Me.PasswordResetBox.Margin = New System.Windows.Forms.Padding(0)
        Me.PasswordResetBox.Name = "PasswordResetBox"
        Me.PasswordResetBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PasswordResetBox.Size = New System.Drawing.Size(543, 260)
        Me.PasswordResetBox.TabIndex = 0
        Me.PasswordResetBox.TabStop = False
        Me.PasswordResetBox.UseCompatibleTextRendering = True
        '
        'PassInfo
        '
        Me.PassInfo.BackgroundImage = Global.WashWorld.My.Resources.Resources.information
        Me.PassInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PassInfo.FlatAppearance.BorderSize = 0
        Me.PassInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.PassInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassInfo.Location = New System.Drawing.Point(362, 152)
        Me.PassInfo.Name = "PassInfo"
        Me.PassInfo.Size = New System.Drawing.Size(15, 15)
        Me.PassInfo.TabIndex = 10
        Me.PassInfo.UseVisualStyleBackColor = True
        '
        'PINInfo
        '
        Me.PINInfo.BackgroundImage = Global.WashWorld.My.Resources.Resources.information
        Me.PINInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PINInfo.FlatAppearance.BorderSize = 0
        Me.PINInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.PINInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PINInfo.Location = New System.Drawing.Point(362, 54)
        Me.PINInfo.Name = "PINInfo"
        Me.PINInfo.Size = New System.Drawing.Size(15, 15)
        Me.PINInfo.TabIndex = 10
        Me.PINInfo.UseVisualStyleBackColor = True
        '
        'Visiblityopen
        '
        Me.Visiblityopen.BackgroundImage = Global.WashWorld.My.Resources.Resources.visibility
        Me.Visiblityopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Visiblityopen.FlatAppearance.BorderSize = 0
        Me.Visiblityopen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Visiblityopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Visiblityopen.Location = New System.Drawing.Point(372, 198)
        Me.Visiblityopen.Name = "Visiblityopen"
        Me.Visiblityopen.Size = New System.Drawing.Size(28, 28)
        Me.Visiblityopen.TabIndex = 9
        Me.Visiblityopen.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WashWorld.My.Resources.Resources.visibility_locked
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(372, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.LightGray
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(418, 160)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(101, 38)
        Me.BackButton.TabIndex = 7
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label6.Location = New System.Drawing.Point(6, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "PASSWORD RESET PAGE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewPassTextBox
        '
        Me.NewPassTextBox.Font = New System.Drawing.Font("MS PGothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassTextBox.Location = New System.Drawing.Point(198, 148)
        Me.NewPassTextBox.MaxLength = 16
        Me.NewPassTextBox.Name = "NewPassTextBox"
        Me.NewPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassTextBox.Size = New System.Drawing.Size(162, 24)
        Me.NewPassTextBox.TabIndex = 3
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("MS PGothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(198, 95)
        Me.UsernameTextBox.MaxLength = 16
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(162, 24)
        Me.UsernameTextBox.TabIndex = 2
        '
        'PINTextBox
        '
        Me.PINTextBox.Font = New System.Drawing.Font("MS PGothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PINTextBox.Location = New System.Drawing.Point(198, 50)
        Me.PINTextBox.MaxLength = 4
        Me.PINTextBox.Name = "PINTextBox"
        Me.PINTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PINTextBox.Size = New System.Drawing.Size(162, 24)
        Me.PINTextBox.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Raleway SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 24)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "New Password        :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConfPassTextBox
        '
        Me.ConfPassTextBox.Font = New System.Drawing.Font("MS PGothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfPassTextBox.Location = New System.Drawing.Point(198, 197)
        Me.ConfPassTextBox.MaxLength = 16
        Me.ConfPassTextBox.Name = "ConfPassTextBox"
        Me.ConfPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfPassTextBox.Size = New System.Drawing.Size(162, 24)
        Me.ConfPassTextBox.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Raleway SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Username                 :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Raleway SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Confirm Password  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Raleway SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "User PIN                    :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClearButton2
        '
        Me.ClearButton2.BackColor = System.Drawing.Color.LightGray
        Me.ClearButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ClearButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.ClearButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton2.Location = New System.Drawing.Point(418, 101)
        Me.ClearButton2.Name = "ClearButton2"
        Me.ClearButton2.Size = New System.Drawing.Size(101, 38)
        Me.ClearButton2.TabIndex = 6
        Me.ClearButton2.Text = "Clear"
        Me.ClearButton2.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.LightGray
        Me.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ResetButton.Location = New System.Drawing.Point(418, 46)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(101, 37)
        Me.ResetButton.TabIndex = 5
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.BrushLogo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.MiniButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.CloseButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(900, 340)
        Me.SplitContainer2.SplitterDistance = 30
        Me.SplitContainer2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(41, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "WASH"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BrushLogo
        '
        Me.BrushLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BrushLogo.BackgroundImage = Global.WashWorld.My.Resources.Resources.brush_machine
        Me.BrushLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BrushLogo.Enabled = False
        Me.BrushLogo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BrushLogo.FlatAppearance.BorderSize = 0
        Me.BrushLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BrushLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BrushLogo.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrushLogo.ForeColor = System.Drawing.Color.Black
        Me.BrushLogo.Location = New System.Drawing.Point(6, 4)
        Me.BrushLogo.Name = "BrushLogo"
        Me.BrushLogo.Size = New System.Drawing.Size(29, 23)
        Me.BrushLogo.TabIndex = 7
        Me.BrushLogo.TabStop = False
        Me.BrushLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BrushLogo.UseVisualStyleBackColor = True
        '
        'MiniButton
        '
        Me.MiniButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiniButton.BackgroundImage = Global.WashWorld.My.Resources.Resources.mini
        Me.MiniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MiniButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MiniButton.FlatAppearance.BorderSize = 0
        Me.MiniButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.MiniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiniButton.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniButton.ForeColor = System.Drawing.Color.Black
        Me.MiniButton.Location = New System.Drawing.Point(833, 5)
        Me.MiniButton.Name = "MiniButton"
        Me.MiniButton.Size = New System.Drawing.Size(24, 20)
        Me.MiniButton.TabIndex = 10
        Me.MiniButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MiniButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackgroundImage = Global.WashWorld.My.Resources.Resources.Close
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Transparent
        Me.CloseButton.Location = New System.Drawing.Point(866, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(24, 20)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(89, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "WORLD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(900, 340)
        Me.Controls.Add(Me.SplitContainer2)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 340)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WashWorld"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.LoginPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PasswordResetPanel.ResumeLayout(False)
        Me.PasswordResetBox.ResumeLayout(False)
        Me.PasswordResetBox.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents MiniButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BrushLogo As Button
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PasswordResetPanel As Panel
    Friend WithEvents PasswordResetBox As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PINTextBox As TextBox
    Friend WithEvents ConfPassTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ClearButton2 As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents NewPassTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents Visiblityopen As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PINInfo As Button
    Friend WithEvents PassInfo As Button
End Class
