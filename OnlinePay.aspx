<%@ Page Language="VB" AutoEventWireup="false" CodeFile="OnlinePay.aspx.vb" Inherits="OnlinePay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" MaxLength="15"></asp:TextBox>
            <br />
            Credit Card Number:
            <asp:TextBox ID="TextBox2" runat="server" MaxLength="10" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Pay" Width="88px" />
            <br />
            <br />
            <asp:Label ID="result" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="lb" runat="server">Home</asp:LinkButton>
        </div>
    </form>
</body>
</html>
