<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .table {
            text-align:center;
            margin: 1% 10%;
            width: 70%;
            height: 185px;
        }
        .auto-style2 {
            width: 361px;
        }
        .auto-style3 {
            width: 488px;
        }
       /* .auto-style4 {
            margin-left: 80px;
        }*/
        .auto-style5 {
            margin-bottom: 0px;
        }
        .auto-style6 {
            width: 488px;
            margin-left: 160px;
        }
        .auto-style7 {
            text-align: center;
            margin: 1% 10%;
            width: 70%;
            height: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     
        <h2 style="text-align:center;padding:3%">Admin Login</h2>
        <table class="auto-style7">
     
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="user_label" runat="server" Text="Username"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="login_text" runat="server" Width="249px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="user_error" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="pass_label" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="pass_text" runat="server" CssClass="auto-style5" Width="245px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="pass_error" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style4" Text="Log In" Width="105px" OnClick="Button1_Click" />
                </td>
                <td>
                    <asp:Label ID="login_btn_error" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
             <tr>
                <td class="auto-style2">No of Hits</td>
                <td class="auto-style3">
                    <asp:Label ID="no_hits" runat="server" Text=" "></asp:Label>
                </td>
                <td>
                  
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
