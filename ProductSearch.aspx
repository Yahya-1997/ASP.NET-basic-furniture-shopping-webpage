<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ProductSearch.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:LinkButton ID="LinkButton1" runat="server">Customer Page</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server">Order placement</asp:LinkButton>
       <br /><br />
        <div>
            Product Database <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:Button ID="Button1" runat="server" Text="Search" />&nbsp;
            <br />
        </div>
        <br />
        <asp:Label ID="result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
