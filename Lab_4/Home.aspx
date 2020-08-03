<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication4.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">Registration Form</td>
                </tr>
                <tr>
                    <td>Full Name :</td>
                    <td>
                        <asp:TextBox ID="fname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fname" ErrorMessage="Please Enter the Name" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Age :</td>
                    <td>
                        <asp:TextBox ID="age" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="age" ErrorMessage="Enter age between 18 to 50" ForeColor="Red" MaximumValue="50" MinimumValue="18"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password :</td>
                    <td>
                        <asp:TextBox ID="ps1" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Confirm Password :</td>
                    <td>
                        <asp:TextBox ID="ps2" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="ps1" ControlToValidate="ps2" ErrorMessage="Password not match" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender :</td>
                    <td>&nbsp;<asp:RadioButtonList ID="Gender" runat="server" Height="16px" Width="231px">
                            <asp:ListItem Selected="True">Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Mobile no. :</td>
                    <td>
                        <asp:TextBox ID="Monum" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Monum" ErrorMessage="Provide valid number" ForeColor="Red" ValidationExpression="^([+][9][1]|[9][1]|[0]){0,1}([7-9]{1})([0-9]{9})$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Hobbies :</td>
                    <td>
                        <asp:CheckBoxList ID="Hobbies" runat="server">
                            <asp:ListItem>Reading</asp:ListItem>
                            <asp:ListItem>Swimming</asp:ListItem>
                            <asp:ListItem>Writing</asp:ListItem>
                            <asp:ListItem>Playing</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>State :</td>
                    <td>
                        <asp:DropDownList ID="state" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="state_SelectedIndexChanged1">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>City :</td>
                    <td>
                        <asp:DropDownList ID="city" runat="server" AutoPostBack="true" AppendDataBoundItems="true">
                            <asp:ListItem>Ahmedabad</asp:ListItem>
                            <asp:ListItem>Vadodara</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Pan Number : </td>
                    <td>
                        <asp:TextBox ID="pannumber" runat="server"></asp:TextBox>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="pannumber" ErrorMessage="Provide valid Pan number" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
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
        <p>
            &nbsp;</p>
        <asp:Label ID="fname1" runat="server" Text="Full Name " Visible="False"></asp:Label>
        <br />
        <asp:Label ID="age1" runat="server" Text="Age" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="gen1" runat="server" Text="Gender" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="m1" runat="server" Text="Mobile number" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="hobies1" runat="server" Text="Hobbies " Visible="False"></asp:Label>
        <br />
        <asp:Label ID="S1" runat="server" Text="State" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="c1" runat="server" Text="City" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="pan1" runat="server" Text="Pan Number" Visible="False"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
