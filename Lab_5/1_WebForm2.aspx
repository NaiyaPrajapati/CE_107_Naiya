<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_WebForm2.aspx.cs" Inherits="CE107_Task1._1_WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Cookie Status" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Remove Cookie" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    
        </div>
    </form>
</body>
</html>
