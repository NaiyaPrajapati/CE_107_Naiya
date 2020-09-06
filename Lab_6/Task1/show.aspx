<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="Lab6_student.show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Btn1" runat="server" OnClick="Btn1_Click" Text="Insert" />
        <asp:Button ID="Btn2" runat="server" CssClass="auto-style3" OnClick="Btn2_Click" Text="Update" />
        <asp:Button ID="Btn3" runat="server" CssClass="auto-style2" OnClick="Btn3_Click" Text="Delete" />
        <div class="auto-style1">
        </div>
    </form>
</body>
</html>
