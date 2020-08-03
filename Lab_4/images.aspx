<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="images.aspx.cs" Inherits="WebApplication4.images" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Image ID="Image1" runat="server" Height="1024px" Width="768px" ImageUrl="img1.jpg" Visible="False" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Image" />
    </form>
</body>
</html>
