Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim Username As String
    Dim Pass As String
    Dim loc As Point

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhim\Desktop\WashWorld\Database1.mdf;Integrated Security=True"
        PasswordResetPanel.Visible = False
        ToolTip1.SetToolTip(CloseButton, "Click to Close")
        ToolTip1.SetToolTip(MiniButton, "Click to Minimize")
        ToolTip1.SetToolTip(PINInfo, "It's a 4 digit Number")
        ToolTip1.SetToolTip(PassInfo, "The max character is 16")

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Cursor = Cursors.WaitCursor
        UseWaitCursor = True
        Threading.Thread.Sleep(110)

        'Login
        If CheckLoginCredentials() Then
            LinkLabel1.Visible = False
            Threading.Thread.Sleep(50)
            ProgressBar1.Visible = True
            Dim a As Integer
            For a = 5 To 100
                ProgressBar1.Value = a
                Threading.Thread.Sleep(5)
            Next
            Threading.Thread.Sleep(50)
            'MessageBox.Show(TextBoxUsername.Text + ", you have logined in successfully", "Welcome :)", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Visible = False
            Threading.Thread.Sleep(100)
            Form2.Show()
            Me.Hide()
            TextBoxUsername.Clear()
            TextBoxPassword.Clear()


        ElseIf TextBoxUsername.Text = "" Or TextBoxPassword.Text = "" Then
            MessageBox.Show("Please enter the username & password", "No Value Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' ElseIf TextBox1.Text = Username And TextBox2.Text <> Pass Then
            '   MessageBox.Show("Try again, Password you entered is incorrect", "Incorrect Password :(", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' ElseIf TextBox1.Text <> Username And TextBox2.Text = Pass Then
            '  MessageBox.Show("Try again, Username you entered is incorrect", "Incorrect Username :(", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            MessageBox.Show("Username or Password is incorrect", "Sorry,Check the credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        LinkLabel1.Visible = True

        UseWaitCursor = False
        Cursor = Cursors.Default
    End Sub

    'clear button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ToolTip1.SetToolTip(ClearButton, "Click here to clear the text feild")
        If TextBoxUsername.Text = "" And TextBoxPassword.Text = "" Then
            MessageBox.Show("There is nothing to clear, TextBoxs are empty", "TextBox Already Cleared", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ProgressBar1.Visible = False
            LinkLabel1.Visible = True
            TextBoxUsername.Text = ""
            TextBoxPassword.Text = ""
        End If
    End Sub


    'close button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Me.Close()
    End Sub

    'minimize button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles MiniButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'For draging
    Private Sub SplitContainer2_Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles SplitContainer2.Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub
    Private Sub SplitContainer2_Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles SplitContainer2.Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    'Login function
    Private Function CheckLoginCredentials() As Boolean

        Dim UnameInput As String = TextBoxUsername.Text
        Dim PassInput As String = TextBoxPassword.Text
        Dim Answer As Boolean = False
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Username,Password FROM [User];"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        While dr1.Read()
            Username = dr1("Username")
            Pass = dr1("Password")
            If Username = UnameInput And Pass = PassInput Then
                Answer = True
            End If
        End While
        con.Close()
        Return Answer
    End Function

    'Resting password link
    Private Sub Passwordrest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginPanel.Visible = False
        PasswordResetPanel.Visible = True
        'Dim a, pin As Integer
        'pin = "3554"
        'a = InputBox("Enter the security pin for resetting the password", "PASSWORD RESET")
        'If a = pin Then
        'MsgBox("It's working")
        'End If
    End Sub

    'Back button for Password Reset
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ToolTip1.SetToolTip(BackButton, "Back to Login Page")
        LoginPanel.Visible = True
        PasswordResetPanel.Visible = False
    End Sub

    'Clear button for Password Reset
    Private Sub ClearButton2_Click(sender As Object, e As EventArgs) Handles ClearButton2.Click
        ToolTip1.SetToolTip(ClearButton2, "Click to clear the text feild")
        If PINTextBox.Text = "" And UsernameTextBox.Text = "" And NewPassTextBox.Text = "" And ConfPassTextBox.Text = "" Then
            MessageBox.Show("There is nothing to clear, TextBoxs are empty", "TextBox Already Cleared", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            PINTextBox.Text = ""
            UsernameTextBox.Text = ""
            NewPassTextBox.Text = ""
            ConfPassTextBox.Text = ""
        End If
    End Sub

    'rest button
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ToolTip1.SetToolTip(ResetButton, "Click to Reset Password")
        If Not CheckResetCredentials() Then
            MessageBox.Show("Crosscheck the PIN & Username", "Wrong Credentials", 0, MessageBoxIcon.Error)

        ElseIf UsernameTextBox.Text = "" Or PINTextBox.Text = "" Or NewPassTextBox.Text = "" Or ConfPassTextBox.Text = "" Then
            MessageBox.Show("Enter all the details", "", 0, MessageBoxIcon.Warning)

        ElseIf NewPassTextBox.Text <> ConfPassTextBox.Text Then
            MessageBox.Show("The passwords doesnt match", "", 0, MessageBoxIcon.Error)

        ElseIf CheckResetCredentials() And NewPassTextBox.Text = ConfPassTextBox.Text Then
            con.Open()
            cmd.Connection = con
            cmd = New SqlCommand("UPDATE User SET Password = @pass", con)

        End If

    End Sub

    Private Function CheckResetCredentials() As Boolean

        Dim UnameInput As String = UsernameTextBox.Text
        Dim PINInput As String = PINTextBox.Text
        Dim Answer As Boolean = False
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Username,UserPIN FROM [User];"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        While dr1.Read()
            Username = dr1("Username")
            Pass = dr1("UserPIN")
            If Username = UnameInput And Pass = PINInput Then
                Answer = True
            End If
        End While
        con.Close()
        Return Answer
    End Function

    Private Sub PINTextBox_keypress(sender As Object, e As KeyPressEventArgs) Handles PINTextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox(“Please enter numbers only”, 0, " ")
            e.Handled = True
        End If
    End Sub

    'Password Visibility
    Private Sub Lock_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ToolTip1.SetToolTip(Visiblityopen, "Click here to Show the Password")
        NewPassTextBox.PasswordChar = "*"
        ConfPassTextBox.PasswordChar = "*"
        PINTextBox.PasswordChar = "*"
        Visiblityopen.Visible = True
        Button1.Visible = False

    End Sub

    Private Sub Lockopen_Click_1(sender As Object, e As EventArgs) Handles Visiblityopen.Click
        ToolTip1.SetToolTip(Button1, "Click here to hide the Password")
        NewPassTextBox.PasswordChar = ""
        ConfPassTextBox.PasswordChar = ""
        PINTextBox.PasswordChar = ""
        Visiblityopen.Visible = False
        Button1.Visible = True
    End Sub


End Class
