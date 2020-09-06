<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="Lab6_student.insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                   <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">Registration Form</td>
                </tr>
                <tr>
                    <td>Id :</td>
                    <td><asp:TextBox ID="id" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name :</td>
                    <td>
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Please Enter the Name" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>sem :</td>
                    <td>
                        <asp:TextBox ID="sem" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="sem" ErrorMessage="Enter sem between 1 to 8" ForeColor="Red" MaximumValue="8" MinimumValue="1"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Mobile No. :</td>
                    <td>
                        <asp:TextBox ID="mobile_no" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email-id :</td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        </div>
    </form>
</body>
</html>
