<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Login.aspx.cs" Inherits="Lb6_1._2_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 15px;
            margin-bottom: 0px;
        }
        .auto-style2 {
            margin-left: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User Id:<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
            <br />
            <br />
            Password :<asp:TextBox ID="TextBox2" type="password" runat="server" CssClass="auto-style1" Width="156px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
