<%@ Page Language="VB" AutoEventWireup="false" CodeFile="OrderPlacement.aspx.vb" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Product_Description" DataValueField="Standard_Price">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pvfcConnectionString %>" SelectCommand="SELECT [Product_Description], [Standard_Price] FROM [PRODUCT_t]"></asp:SqlDataSource>
            Quantity:
            <asp:TextBox TextMode="Number" MaxLength="2" ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter quantity" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:Button ID="Button2" runat="server" Text="Add" />
            <br />
            <br />
            <asp:Table ID="tab1" runat="server"></asp:Table>
            <br />
            <asp:HiddenField ID="HiddenField1" value="1" runat="server" />
            <br />
            
            <asp:Button ID="Button1" runat="server" Text="Order" Width="126px" />
        </div>
    </form>
</body>
</html>
