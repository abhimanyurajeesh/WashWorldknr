﻿Imports System.Data.SqlClient
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
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Cursor = Cursors.WaitCursor
        UseWaitCursor = True
        Threading.Thread.Sleep(110)

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
            MessageBox.Show(TextBoxUsername.Text + ", you have logined in successfully", "Welcome :)", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Visible = False
            Threading.Thread.Sleep(100)
            Form2.Show()
            Me.Hide()
            TextBoxUsername.Clear()
            TextBoxPassword.Clear()


        ElseIf TextBoxUsername.Text = "" And TextBoxPassword.Text = "" Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    'minimize button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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

    'Resting password
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
        LoginPanel.Visible = True
        PasswordResetPanel.Visible = False
    End Sub

    'Clear button for Password Reset
    Private Sub ClearButton2_Click(sender As Object, e As EventArgs) Handles ClearButton2.Click
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
        If Not CheckResetCredentials() Then
            MessageBox.Show("Crosscheck the PIN & Username", "Wrong Credentials", 0, MessageBoxIcon.Error)
        Else

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
            MessageBox.Show(“Please enter numbers only”)
            e.Handled = True
        End If
    End Sub

    'Password Visibility
    Private Sub Lock_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        NewPassTextBox.PasswordChar = "*"
        ConfPassTextBox.PasswordChar = "*"
        PINTextBox.PasswordChar = "*"
        Button2.Visible = True
        Button1.Visible = False

    End Sub

    Private Sub Lockopen_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        NewPassTextBox.PasswordChar = ""
        ConfPassTextBox.PasswordChar = ""
        PINTextBox.PasswordChar = ""
        Button2.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub NewPassTextBox_TextChanged(sender As Object, e As EventArgs) Handles NewPassTextBox.TextChanged

    End Sub

    Private Sub ConfPassTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfPassTextBox.TextChanged

    End Sub
End Class