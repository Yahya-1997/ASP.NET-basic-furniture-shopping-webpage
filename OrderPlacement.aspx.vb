Imports System.Data
Imports System.Data.SqlClient

Partial Class Default4
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlcom As String = "select top(1) order_id from order_t order by order_id desc"
        Dim connection As New SqlConnection()
        connection.ConnectionString = "Server=DESKTOP-HV2CO5F\SQLEXPRESS;Database=PVFC;Initial Catalog=PVFC;Integrated Security=SSPI;"
        Dim cmd1 As New SqlCommand(sqlcom, connection)
        connection.Open()
        Dim rd As SqlDataReader = cmd1.ExecuteReader()
        rd.Read()
        Session("order_id") = rd("order_id") + 1
        rd.Close()

        sqlcom = "insert into order_t(order_id, customer_id, order_date) values(" & Session("order_id") & ", " & Session("customer_id") & ", '2008-10-21')"
        Dim cmd2 As New SqlCommand(sqlcom, connection)
        sqlcom = "insert into order_line_t(order_id, product_id, ordered_quantity) values(" & Session("order_id") & ", " & (DropDownList1.SelectedIndex + 1) & ", '" & TextBox1.Text & "')"
        Dim cmd3 As New SqlCommand(sqlcom, connection)


        'Session("order_date") = "2008-10-21"
        'Session("product_id") = DropDownList1.SelectedIndex + 1
        'Session("price") = DropDownList1.SelectedItem.Value
        'Session("quantity") = TextBox1.Text

        cmd2.ExecuteNonQuery()
        cmd3.ExecuteNonQuery()
        connection.Close()
        Response.Redirect("InvoicePage.aspx")
    End Sub

    Private Sub Default4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim row As New TableRow()
        Dim name As New TableCell()
        Dim value As New TableCell()
        Dim quantity As New TableCell()
        name.Text = "<b>Product Description</b>&nbsp;&nbsp;"
        value.Text = "<b>Standard Price</b> &nbsp;&nbsp;"
        quantity.Text = "<b>Quantity</b>"
        row.Cells.Add(name)
        row.Cells.Add(value)
        row.Cells.Add(quantity)
        tab1.Rows.Add(row)
        Button1.Enabled = False
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row As New TableRow()
        Dim name As New TableCell()
        Dim value As New TableCell()
        Dim quantity As New TableCell()

        name.Text = DropDownList1.SelectedItem.Text
        value.Text = DropDownList1.SelectedItem.Value.ToString()
        quantity.Text = TextBox1.Text

        row.Cells.Add(name)
        row.Cells.Add(value)
        row.Cells.Add(quantity)

        'tab1.TabIndex = tab1.TabIndex + 1
        tab1.Rows.Add(row)
        HiddenField1.Value = HiddenField1.Value + 1

        Button1.Enabled = True
    End Sub
End Class
