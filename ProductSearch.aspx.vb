Imports System.Data
Imports System.Data.SqlClient

Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        result.Text = ""
        Dim sqlcommand As String
        sqlcommand = "select * from product_t where product_description like '%" & TextBox1.Text & "%' or product_finish like '%" & TextBox1.Text & "%'"
        Dim connection As SqlConnection = New SqlConnection()
        connection.ConnectionString = "Server=DESKTOP-HV2CO5F\SQLEXPRESS;Database=PVFC;Initial Catalog=PVFC;Integrated Security=SSPI;"
        Dim cmd As New SqlCommand(sqlcommand, connection)
        Dim reader As SqlDataReader
        connection.Open()

        reader = cmd.ExecuteReader()
        Do While reader.Read()

            result.Text &= "<br><br><br><b>Product ID:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & reader("product_id") & "<br>"
            result.Text &= "<b>Product Line ID:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & reader("product_line_id") & "<br>"
            result.Text &= "<b>Product Description:</b>&nbsp;" & reader("product_description") & "<br>"
            result.Text &= "<b>Product Finish:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & reader("product_finish") & "<br>"
            result.Text &= "<b>Standard Price:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & reader("standard_price") & "<br>"

        Loop
        reader.Close()
        connection.Close()
        If result.ToString() Is Nothing Then
            result.Text = "Product is not available!"
        End If
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("CustomerSearch.aspx")
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'result.Text = ""
    End Sub
    Protected Sub LinkButton2_Click(sender As Object, e As EventArgs) Handles LinkButton2.Click
        Response.Redirect("OrderPlacement.aspx")
    End Sub
End Class
