Imports System.Data
Imports System.Data.SqlClient

Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlcommand As String
        sqlcommand = "select * from customer_t where customer_name = '" & TextBox1.Text & "'"
        Dim sqlcommand2 As String
        sqlcommand2 = "select passwd from customer_t where customer_name = '" & TextBox1.Text & "'"
        Dim connection As New SqlConnection()
        connection.ConnectionString = "Server=DESKTOP-HV2CO5F\SQLEXPRESS;Database=PVFC;Initial Catalog=PVFC;Integrated Security=SSPI;"
        Dim cmd As New SqlCommand(sqlcommand, connection)
        Dim cmd2 As New SqlCommand(sqlcommand2, connection)

        Dim reader As SqlDataReader
        connection.Open()
        reader = cmd.ExecuteReader()

        If reader.Read() Then
            Session("customer_id") = reader("customer_id").ToString()
            Dim name As String = reader("customer_name")

            reader.Close()
            If String.Compare(TextBox1.Text, name) Then
                reader = cmd2.ExecuteReader()
                reader.Read()
                Dim password As String = reader("passwd")
                reader.Close()
                If String.Compare(TextBox2.Text, password) Then
                    Response.Redirect("ProductSearch.aspx")
                Else
                    result.Text = "Password is incorrect!"
                End If

            Else
                result.Text = "Not a valid customer!"
            End If
        Else
            result.Text = "Not a valid customer!"
        End If
        connection.Close()
    End Sub
End Class
