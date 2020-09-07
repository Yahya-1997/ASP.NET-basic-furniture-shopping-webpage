<%@ Page Language="VB" AutoEventWireup="false" CodeFile="InvoicePage.aspx.vb" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1" runat="server">
            <asp:Label ID="result" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Payment method:<br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Text="Online Pay" Value="1"></asp:ListItem>
                <asp:ListItem Text="Cash on Delivery" Value="2"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Pay" />
        </div>
        <br />
            <br />
        <asp:Label ID="result2" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
