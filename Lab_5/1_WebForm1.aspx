﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_WebForm1.aspx.cs" Inherits="CE107_Task1._1_WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 
    <form id="form1" runat="server">
    <div>
    
        Name :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Password :
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    
    </div>
    </form>

</body>
</html>
