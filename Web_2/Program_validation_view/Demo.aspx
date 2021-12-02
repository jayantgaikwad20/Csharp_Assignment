<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Demo.aspx.cs" Inherits="Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" >
            </asp:DropDownList>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" BorderStyle="Groove" Height="29px" OnClick="Button1_Click" Text="Submit" Width="79px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Transfer" Width="206px" />
        </p>
    </form>
</body>
</html>
