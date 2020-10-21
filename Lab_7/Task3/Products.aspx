﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Lb8_Task3.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Product Details</h1>
            <asp:DetailsView EmptyDataText="Invalid Id!" ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="pid" DataSourceID="SqlDataSource1" Height="143px" Width="175px" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" AutoGenerateInsertButton="True">
                <Fields>
                    <asp:BoundField DataField="pid" HeaderText="pid" InsertVisible="False" ReadOnly="True" SortExpression="pid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                    <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                </Fields>
            </asp:DetailsView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConTest %>" 
                SelectCommand="SELECT * FROM [products] WHERE ([pid] = @pid)" DeleteCommand="DELETE FROM [products] WHERE [pid] = @pid" InsertCommand="INSERT INTO [products] ([name], [description], [category], [price]) VALUES (@name, @description, @category, @price)" UpdateCommand="UPDATE [products] SET [name] = @name, [description] = @description, [category] = @category, [price] = @price WHERE [pid] = @pid">
                <DeleteParameters>
                    <asp:Parameter Name="pid" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="description" Type="String" />
                    <asp:Parameter Name="category" Type="String" />
                    <asp:Parameter Name="price" Type="Decimal" />
                </InsertParameters>
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="1" Name="pid" QueryStringField="pid" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="description" Type="String" />
                    <asp:Parameter Name="category" Type="String" />
                    <asp:Parameter Name="price" Type="Decimal" />
                    <asp:Parameter Name="pid" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Show All Data" OnClick="Btn_Click" />
        </div>
    </form>
</body>
</html>