Imports System.Data.SqlClient
Module Module1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhim\Desktop\WashWorld\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Function getCustData() As DataTable
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * from [Cust];"
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        cmd.CommandType = CommandType.Text
        sda.Fill(dt)
        con.Close()
        Return dt
    End Function
End Module
