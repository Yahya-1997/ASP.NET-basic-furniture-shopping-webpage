Imports System.Data
Imports System.Data.SqlClient

Partial Class OnlinePay
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlcommand As String
        sqlcommand = "select amount from bank where customer_name = '" & Session("name").ToString() & "'"
        Dim connection As New SqlConnection()
        connection.ConnectionString = "Server=DESKTOP-HV2CO5F\SQLEXPRESS;Database=PVFC;Initial Catalog=PVFC;Integrated Security=SSPI;"
        Dim cmd As New SqlCommand(sqlcommand, connection)
        connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        reader.Read()
        Dim remaining As Integer = reader("amount") - Session("amt")
        If Session("amt") > reader("amount") Then
            result.Text = "Your acount balance is not enough!"
        Else
            reader.Close()
            sqlcommand = "update bank set amount = " & remaining & " where customer_name = '" & Session("name").ToString() & "'"
            Dim com As New SqlCommand(sqlcommand, connection)
            com.ExecuteNonQuery()
            result.Text &= "Payment successful. Your order will be shipped to:<br>"
            result.Text &= Session("name") & "  " & Session("address")
        End If
        connection.Close()

        Button1.Enabled = False
        lb.Visible = True
    End Sub
    Protected Sub lb_Click(sender As Object, e As EventArgs) Handles lb.Click
        Response.Redirect("ProductSearch.aspx")
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lb.Visible = False
    End Sub
End Class
