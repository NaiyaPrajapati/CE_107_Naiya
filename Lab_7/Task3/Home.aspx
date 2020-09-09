<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Lb8_Task3.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Product Id:
            <asp:TextBox ID="pid" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Submit" OnClick="Btn1_Click" />
            <br />
        <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
