﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Lb8_Task4.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Update Details: </h2>
            
            ID:
            <asp:TextBox ID="Sid" runat="server"></asp:TextBox>&nbsp;&nbsp; 
            <asp:Button ID="Button5" runat="server" Text="Get_Details" OnClick="Fill_Details"/>
            &nbsp;
            <br />
            <br />
        </div>
        <div id="Fields" runat="server">
             Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <br />
            <br />
            Sem:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Sem" runat="server"></asp:TextBox>
            <br />
            <br />
            CPI:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="CPI" runat="server"></asp:TextBox>
            <br />
            <br />
            Contact No:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ContactNo" runat="server"></asp:TextBox>
            <br />
            <br />
            Email Id:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Update_Details"/>
            
        </div>
            <br />
            
            <asp:Label ID="Label1" runat="server" Text="" ForeColor="Green"></asp:Label>

        <br />
        <br />
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Insert_Details"/>
            &nbsp;
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Delete_Details"/>
            &nbsp;
            <asp:Button ID="Button4" runat="server" Text="Show All" OnClick="Show_Details"/>
    </form>
</body>
</html>