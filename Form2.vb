Imports System.Data.SqlClient
Public Class Form2
    Dim Loc As Point
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    'Form Load
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhim\Desktop\WashWorld\Database1.mdf;Integrated Security=True"
        CustPanel.Visible = False
    End Sub

    'Return to login form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    'close button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()

    End Sub

    'minimize button
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'maximize button
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Button1_Mouseenter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.BlueViolet
    End Sub
    Private Sub Button1_Mouseleave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black

    End Sub

    'For draging
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            Loc = e.Location
        End If
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - Loc
        End If
    End Sub

    'Cust form
    Private Sub Loadform_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Cust_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CustPanel.Visible = True
        Custglow.BackColor = Color.FromArgb(255, 50, 135, 212)

    End Sub


    Private Sub CustPanel_VisibleChanged(sender As Object, e As EventArgs) Handles CustPanel.VisibleChanged
        Custglow.BackColor = Color.FromArgb(0, 50, 135, 212)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class