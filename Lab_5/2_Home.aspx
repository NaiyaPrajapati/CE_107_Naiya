<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Home.aspx.cs" Inherits="Lb5._2_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Welcome" runat="server" Text="Welcome " 
            Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <div>
            <h4>What would you like to buy?</h4>
            <p>
                <asp:RadioButtonList ID="Radio" AutoPostBack="true" runat="server" OnSelectedIndexChanged="List_Change">
                    <asp:ListItem>Electronics</asp:ListItem>
                    <asp:ListItem>Books</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p>
                <asp:ListBox ID="ListOfItems" runat="server" Height="150px" Width="280px">

                </asp:ListBox>
            </p>
            <p>
                <asp:Button runat="server" Text="Place Order" OnClick="CheckOut"/>
            </p>
        </div>
    </form>
</body>
</html>
