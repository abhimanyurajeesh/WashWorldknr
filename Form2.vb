Imports System.Data.SqlClient
Public Class Form2
    Dim Loc As Point
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim prevBut As Button

    Private Sub ChangeButColor(sender As Object, e As EventArgs) Handles CustButton.Click, VehiButton.Click, WorkerButton.Click, ServiceButton.Click, InvoiceButton.Click, PayButton.Click
        prevBut.BackColor = Color.FromArgb(0, 0, 0, 0)
        sender.backcolor = Color.White
        prevBut = sender
    End Sub
    'Form Load
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhim\Desktop\WashWorld\Database1.mdf;Integrated Security=True"
        CustPanel.Visible = False
        ToolTip1.SetToolTip(CustIDInfo, "Enter the coustomer ID")
        ToolTip1.SetToolTip(CustNameInfo, "Enter the Full name of coustomer")
        ToolTip1.SetToolTip(CustIDInfo, "Enter the 10 digit coustomer Phone Number")
        prevBut = CustButton
    End Sub

    'Return to login form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    'close button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CloseButton2.Click
        Form1.Close()

    End Sub

    'minimize button
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles MiniButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'maximize button
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles MaxButton.Click
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



    'Cust Panel
    Private Sub Loadform_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Cust_Click(sender As Object, e As EventArgs) Handles CustButton.Click
        CustPanel.Visible = True
        VehiclePanel.Visible = False
        WorkerPanel.Visible = False
        ServicePanel.Visible = False

        Custglow.BackColor = Color.FromArgb(255, 50, 135, 212)
        Vehiglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Servglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Workglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Invoglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Paymglow.BackColor = Color.FromArgb(0, 50, 135, 212)

    End Sub

    'Vehicle Panel

    Private Sub Load_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Vehi_Click(sender As Object, e As EventArgs) Handles VehiButton.Click
        CustPanel.Visible = False
        VehiclePanel.Visible = True
        WorkerPanel.Visible = False
        ServicePanel.Visible = False

        Custglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Vehiglow.BackColor = Color.FromArgb(255, 50, 135, 212)
        Servglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Workglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Invoglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Paymglow.BackColor = Color.FromArgb(0, 50, 135, 212)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim type As Integer
        type = ComboBox1.SelectedIndex
        Select Case type
            Case 0
                CarTypePB.Image = WashWorld.My.Resources.Resources.MICRO
            Case 1
                CarTypePB.Image = WashWorld.My.Resources.Resources.SEDAN
            Case 2
                CarTypePB.Image = WashWorld.My.Resources.Resources.HATCHBACK
            Case 3
                CarTypePB.Image = WashWorld.My.Resources.Resources.ROADSTER
            Case 4
                CarTypePB.Image = WashWorld.My.Resources.Resources.COUPE
            Case 5
                CarTypePB.Image = WashWorld.My.Resources.Resources.CUV
            Case 6
                CarTypePB.Image = WashWorld.My.Resources.Resources.SUV
            Case Else
                CarTypePB.Image = Nothing
        End Select
    End Sub

    'Sevice Panel
    Private Sub ServiceButton_Click(sender As Object, e As EventArgs) Handles ServiceButton.Click
        CustPanel.Visible = False
        VehiclePanel.Visible = False
        WorkerPanel.Visible = False
        ServicePanel.Visible = True

        Custglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Vehiglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Servglow.BackColor = Color.FromArgb(255, 50, 135, 212)
        Workglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Invoglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Paymglow.BackColor = Color.FromArgb(0, 50, 135, 212)
    End Sub

    'Worker Panel
    Private Sub WorkerButton_Click(sender As Object, e As EventArgs) Handles WorkerButton.Click
        CustPanel.Visible = False
        VehiclePanel.Visible = False
        WorkerPanel.Visible = True
        ServicePanel.Visible = False

        Custglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Vehiglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Servglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Workglow.BackColor = Color.FromArgb(255, 50, 135, 212)
        Invoglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Paymglow.BackColor = Color.FromArgb(0, 50, 135, 212)
    End Sub

    'Invoice Pannel
    Private Sub InvoiceButton_Click(sender As Object, e As EventArgs) Handles InvoiceButton.Click
        CustPanel.Visible = False
        VehiclePanel.Visible = False
        WorkerPanel.Visible = False
        ServicePanel.Visible = False

        Custglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Vehiglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Servglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Workglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Invoglow.BackColor = Color.FromArgb(255, 50, 135, 212)
        Paymglow.BackColor = Color.FromArgb(0, 50, 135, 212)
    End Sub

    'Payment Pannel
    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        CustPanel.Visible = False
        VehiclePanel.Visible = False
        WorkerPanel.Visible = False
        ServicePanel.Visible = False

        Custglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Vehiglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Servglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Workglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Invoglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Paymglow.BackColor = Color.FromArgb(255, 50, 135, 212)
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

    Private Sub VehiclePanel_Paint(sender As Object, e As PaintEventArgs) Handles VehiclePanel.Paint

    End Sub
End Class