Imports System.Data.SqlClient
Imports WashWorld.Module1
Public Class Form2
    Dim Loc As Point
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim sda As New SqlDataAdapter
    Dim dTable As New DataTable
    Dim bs As New BindingSource
    Dim prevBut As Button
    Dim dr As SqlDataReader


    Private Sub ChangeButColor(sender As Object, e As EventArgs) Handles CustButton.Click, VehiButton.Click, WorkerButton.Click, ServiceButton.Click, InvoiceButton.Click, PayButton.Click
        prevBut.BackColor = Color.FromArgb(0, 0, 0, 0)
        sender.backcolor = Color.White
        prevBut = sender
    End Sub

    '************** FORM 2 LOAD ************
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = My.Settings.WWDBConnString
        CustPanel.Visible = False
        ToolTip1.SetToolTip(CustIDInfo, "Enter the customer ID only for Updation and Deletion")
        ToolTip1.SetToolTip(CustNameInfo, "Full name of the customer")
        ToolTip1.SetToolTip(PhoneInfo, "Phone Number without ISD code.")
        ToolTip1.SetToolTip(WorkerPhonInfo, "Phone Number without ISD code.")
        ToolTip1.SetToolTip(WorkIDInfo, "Enter the Worker Identification Number")
        ToolTip1.SetToolTip(WokerNameInfo, "Enter the Full name of the Worker")
        ToolTip1.SetToolTip(ServiceIDinfo, "Enter the Service ID")
        ToolTip1.SetToolTip(CustIDInfo2, "Enter the coustomer ID")
        ToolTip1.SetToolTip(RegInfo, "Example : KL 13 J 1234 ")
        ToolTip1.SetToolTip(CarRegInfo, "Example : KL 13 AB 1235")
        ToolTip1.SetToolTip(CarBrandInfo, "Example : BMW, Benz, Hyundai etc.")
        ToolTip1.SetToolTip(CarModelInfo, "Example : Swift, E-Class, i-10 etc.")
        ToolTip1.SetToolTip(ServiceTypeInfo, "Enter or Select the Service Type.")
        ToolTip1.SetToolTip(SeviceChargeInfo, "Enter the Cost of sevice")
        ToolTip1.SetToolTip(PaymentIDInfo, "It,s automated or enter the payment ID maually")
        ToolTip1.SetToolTip(PaymentTypeInfo, "Select the payment Type")
        ToolTip1.SetToolTip(InvoiceIDInfo, "Enter the invoice number")


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



    '*************** CUSTOMER PANEL ******************

    'load table button
    Private Sub Loadform_Click(sender As Object, e As EventArgs) Handles LoadCustTableButton.Click
        CustTableload()
        ClearCustTB()
    End Sub

    'load Table function
    Private Sub CustTableload()
        Dim CustDGV As DataGridView = Me.CustTableDataGridView1
        Try
            con.Open()
            cmd = New SqlCommand("select * from [Cust]", con)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            CustDGV.Rows.Clear()
            Do While dr.Read = True
                CustDGV.Rows.Add(dr(0), dr(1), dr(2), dr(3))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try

    End Sub

    'Save Button
    Private Sub CustSaveBUT_Click(sender As Object, e As EventArgs) Handles CustSaveBUT.Click
        Try
            If (CustNameTextBox.Text = "" Or CustPhoneTextBox.Text = "") Then
                MsgBox("Please enter the Customer Details", MsgBoxStyle.Information, "Data Updation Unsuccessful")
            Else
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd = New SqlCommand("INSERT INTO [Cust](CustName,CustPhone,CustAddress) Values('" & CustNameTextBox.Text & "','" & CustPhoneTextBox.Text & "','" & CustAddressTextBox.Text & "')", con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Customer " + CustNameTextBox.Text + " is Successfully added to Customer Databse", MsgBoxStyle.Information, "Data Updation Successful")
                ClearCustTB()
                CustTableload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' Try
        'CustBindingSource.EndEdit()
        'CustTableAdapter.Update(Database1DataSet.Cust)
        'MsgBox("Saved Successfully")
        'Catch ex As Exception
        'MsgBox(ex, 0, "Message")

        'End Try
    End Sub


    'Upadte Button
    Private Sub CustUpdateButt_Click(sender As Object, e As EventArgs) Handles CustUpdateButt.Click
        CustIDTextBox.ReadOnly = False
        Try
            If (CustIDTextBox.Text = "" Or CustNameTextBox.Text = "" Or CustPhoneTextBox.Text = "") Then
                MsgBox("Please enter the details for updation")
            Else
                con.Open()
                cmd = New SqlCommand("UPDATE [Cust] SET CustName = '" & CustNameTextBox.Text & "' , CustPhone= '" & CustPhoneTextBox.Text & "',  CustAddress = '" & CustAddressTextBox.Text & "'  WHERE CustID = '" & CustIDTextBox.Text & "'", con)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Updated the Custmer deatils Successfully", MsgBoxStyle.Information, "Data Updation Successful")
                Else
                    MsgBox("Failed in Updating data", MsgBoxStyle.Information, "Data Updation Unsuccessful")
                End If
                con.Close()
                CustTableload()
                ClearCustTB()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub


    'Delete Button
    Private Sub CustDeleteBut_Click(sender As Object, e As EventArgs) Handles CustDeleteBut.Click
        Dim CustDGV As DataGridView = Me.CustTableDataGridView1
        CustIDTextBox.ReadOnly = False
        Try
            If (CustNameTextBox.Text = "" Or CustPhoneTextBox.Text = "") Then
                MsgBox("Please enter the Customer ID to Delete")
            Else
                con.Open()
                cmd = New SqlCommand("DELETE FROM [Cust] WHERE CustID = '" & CustIDTextBox.Text & "'", con)
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                MsgBox("Customer " & CustNameTextBox.Text & " Deleted Successfully", MsgBoxStyle.Information, "Data Updation")
                con.Close()
                ClearCustTB()
                CustTableload()

                ' Do While dr.Read = True
                'CustDGV.Rows.Add(dr(0), dr(1), dr(2), dr(3))
                'Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try

    End Sub

    'TextBox AutoFill
    Private Sub CustIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustIDTextBox.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space) Then
                con.Open()
                sda = New SqlDataAdapter("SELECT CustID, CustName, CustPhone, CustAddress FROM [Cust] WHERE CustID ='" & CustIDTextBox.Text & "'", con)
                Dim table As New DataTable()
                sda.Fill(table)
                CustNameTextBox.Text = table(0)(1)
                CustPhoneTextBox.Text = table(0)(2)
                CustAddressTextBox.Text = table(0)(3)
                con.Close()

            End If
        Catch ex As Exception
            MsgBox("Invalid User ID, Please check the User ID")
        End Try

    End Sub


    'clear textbox
    Private Sub ClearCustTB()
        CustIDTextBox.Text = ""
        CustNameTextBox.Text = ""
        CustPhoneTextBox.Text = ""
        CustAddressTextBox.Text = ""
    End Sub

    'Pannel Layout and colour
    Private Sub Cust_Click(sender As Object, e As EventArgs) Handles CustButton.Click
        CustTableload()
        CustPanel.Visible = True
        VehiclePanel.Visible = False
        WorkerPanel.Visible = False
        ServicePanel.Visible = False
        InvoicePanel.Visible = False
        PaymentPanel.Visible = False

        Custglow.BackColor = Color.FromArgb(255, 50, 135, 212)
        Vehiglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Servglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Workglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Invoglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Paymglow.BackColor = Color.FromArgb(0, 50, 135, 212)

    End Sub






    '*********************VEHICLE PANEL*************************
    Private Sub Load_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Vehi_Click(sender As Object, e As EventArgs) Handles VehiButton.Click
        CustPanel.Visible = False
        VehiclePanel.Visible = True
        WorkerPanel.Visible = False
        ServicePanel.Visible = False
        InvoicePanel.Visible = False
        PaymentPanel.Visible = False

        Custglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Vehiglow.BackColor = Color.FromArgb(255, 50, 135, 212)
        Servglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Workglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Invoglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Paymglow.BackColor = Color.FromArgb(0, 50, 135, 212)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarTypeComboBox.SelectedIndexChanged

        Dim type As Integer
        type = CarTypeComboBox.SelectedIndex
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
        InvoicePanel.Visible = False
        PaymentPanel.Visible = False

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
        InvoicePanel.Visible = False
        PaymentPanel.Visible = False

        Custglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Vehiglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Servglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Workglow.BackColor = Color.FromArgb(255, 50, 135, 212)
        Invoglow.BackColor = Color.FromArgb(0, 50, 135, 212)
        Paymglow.BackColor = Color.FromArgb(0, 50, 135, 212)
    End Sub

    'Invoice Pannel
    Private Sub Text_cnter(sender As Object, e As EventArgs) Handles InvoicePanel.Enter
        ServiceInvo.TextAlign = ContentAlignment.MiddleCenter
    End Sub
    Private Sub InvoiceButton_Click(sender As Object, e As EventArgs) Handles InvoiceButton.Click
        CustPanel.Visible = False
        VehiclePanel.Visible = False
        WorkerPanel.Visible = False
        ServicePanel.Visible = False
        InvoicePanel.Visible = True
        PaymentPanel.Visible = False

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
        InvoicePanel.Visible = False
        PaymentPanel.Visible = True

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

    Private Sub CustBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustBindingNavigatorSaveItem.Click
        Me.Validate()
        ' Me.CustBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub


End Class