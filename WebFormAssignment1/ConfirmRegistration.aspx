<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmRegistration.aspx.cs" Inherits="WebFormAssignment1.ConfirmRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 269px;
            text-align: right;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            width: 269px;
            text-align: right;
            height: 23px;
        }
        .auto-style5 {
            text-align: left;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">User Name:</td>
                <td class="auto-style3">
                    <asp:Label ID="UserNameDisplay" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Email:</td>
                <td class="auto-style3">
                    <asp:Label ID="EmailDisplay" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Password:</td>
                <td class="auto-style5">
                    <asp:Label ID="PasswordDisplay" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">Confirm Password:</td>
                <td class="auto-style3">
                    <asp:Label ID="ConfirmPasswordDisplay" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Country:</td>
                <td class="auto-style3">
                    <asp:Label ID="CountryDisplay" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Confirm" runat="server" OnClick="Button1_Click" Text="Confirm" />
                    <asp:Button ID="Reject" runat="server" Text="Reject" OnClick="Cancel_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td>&nbsp;</td>
                <td></td>
            </tr>
        </table>
    
    </div>
    </form>

</body>
</html>
