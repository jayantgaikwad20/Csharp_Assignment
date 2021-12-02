<%@ Page Language="C#" AutoEventWireup="true" CodeFile="welcome.aspx.cs" Inherits="welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 374px;
        }
        .auto-style2 {
            width: 233px;
        }
        .auto-style3 {
            width: 634px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registration Form </h1>
        </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">First Name</td>
            <td class="auto-style3">
                <asp:TextBox ID="firstname_lb" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstname_lb" ErrorMessage="name can not be blank"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Last Name</td>
            <td class="auto-style3">
                <asp:TextBox ID="lastname_lb" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastname_lb" ErrorMessage="last name can not be blank"></asp:RequiredFieldValidator>
            </td>
        </tr>


             <tr>
            <td class="auto-style2">Username</td>
            <td class="auto-style3">
                <asp:TextBox ID="username_lb" runat="server"></asp:TextBox>
                 </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="username_lb" ErrorMessage="username can not be blank"></asp:RequiredFieldValidator>
                 </td>
        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td class="auto-style3">
                <asp:TextBox ID="passname_lb" runat="server"></asp:TextBox>
            </td>
             <td>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="passname_lb" ErrorMessage="Password can not be blank"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
           <tr>
            <td class="auto-style2"> Confirm Password</td>
            <td class="auto-style3">
                <asp:TextBox ID="confirmPass_lb" runat="server"></asp:TextBox>
            </td>
             <td>
                 <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passname_lb" ControlToValidate="confirmPass_lb" ErrorMessage="Passoword did not match"></asp:CompareValidator>
               </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Address</td>
            <td class="auto-style3">
                <asp:TextBox ID="add_lb" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="add_lb" ErrorMessage="Address can not be blank"></asp:RequiredFieldValidator>
            </td>
        </tr>


             <tr>
            <td class="auto-style2">State</td>
            <td class="auto-style3">
                <asp:DropDownList ID="state_list" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                 </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="state_list" ErrorMessage="state can not be blank"></asp:RequiredFieldValidator>
                 </td>
        </tr>
        <tr>
            <td class="auto-style2">Mobile No.</td>
            <td class="auto-style3">
                <asp:TextBox ID="no_lb" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="no_lb" ErrorMessage="Mobile no is blank or digits are less than 10"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Date Of birth</td>
            <td class="auto-style3">
             <asp:TextBox ID="date" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
           <tr>
            <td class="auto-style2">Remark</td>
            <td class="auto-style3">
                <textarea id="remark_lb" cols="20" name="S1" rows="2" runat="server"></textarea></td>
            <td>&nbsp;</td>
        </tr>

         <tr>
            <td class="auto-style2"></td>
            <td class="auto-style3">
             
                <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" Width="232px" />
             
            </td>
                <asp:Label ID="insert_label" runat="server" Text=""></asp:Label>
      
        </tr>

         <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
             
                &nbsp;</td>
      
        </tr>

         <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
             
                &nbsp;</td>
      
        </tr>
    </table>
        <asp:HyperLink ID="HyperLink1" runat="server" href="views.aspx">view Data</asp:HyperLink>
    </form>
    </body>
</html>
