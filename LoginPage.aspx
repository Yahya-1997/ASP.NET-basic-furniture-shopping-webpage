<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LoginPage.aspx.vb" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User:
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
            &nbsp;<asp:RequiredFieldValidator ID="Req1" runat="server" controltovalidate="TextBox1" ErrorMessage="Username is compulsory!" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            Password:<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> 
            &nbsp;<asp:RequiredFieldValidator ID="Req2" runat="server" controltovalidate="TextBox2" ErrorMessage="Password is compulsory!" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" />
            <br />
            <br />
        </div>
        <asp:Label ID="result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
