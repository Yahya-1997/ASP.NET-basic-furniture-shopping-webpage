Imports System.Data
Imports System.Data.SqlClient

Partial Class Default5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim sqlcommand As String
            sqlcommand = "select customer_name, customer_address, product_description, ordered_quantity, standard_price, order_date from customer_t, order_t, order_line_t, product_t where customer_t.customer_id = order_t.customer_id and order_t.order_id = order_line_t.order_id and product_t.product_id = order_line_t.product_id and order_t.order_id = " & Session("order_id").ToString()
            Dim connection As New SqlConnection()
            connection.ConnectionString = "Server=DESKTOP-HV2CO5F\SQLEXPRESS;Database=PVFC;Initial Catalog=PVFC;Integrated Security=SSPI;"
            Dim cmd As New SqlCommand(sqlcommand, connection)
            connection.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            reader.Read()
            Dim total As Integer = reader("ordered_quantity") * reader("standard_price")
            result.Text &= "<br><br><br><b>Customer Name:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & reader("customer_name") & "<br>"
            result.Text &= "<b>Product Description:</b>&nbsp;" & reader("product_description") & "<br>"
            result.Text &= "<b>Product Price:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & reader("standard_price") & "<br>"
            result.Text &= "<b>Quantity:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & reader("ordered_quantity") & "<br>"
            result.Text &= "<b>Total:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & total & "<br>"
            Session("address") = reader("customer_address")
            Session("name") = reader("customer_name")
            Session("amt") = total
            reader.Close()
            connection.Close()
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButtonList1.SelectedItem.Value = 1 Then
            Response.Redirect("OnlinePay.aspx")
        Else
            result2.Text = "The order will be delivered (within 7 days) to your address:<br>" & Session("name") & "  " & Session("address").ToString()
        End If
    End Sub
End Class
