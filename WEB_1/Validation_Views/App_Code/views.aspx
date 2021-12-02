<%@ Page Language="C#" AutoEventWireup="true" CodeFile="views.aspx.cs" Inherits="views" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 323px;
        }
        .auto-style3 {
            width: 484px;
        }
        .auto-style5 {
            width: 484px;
            height: 121px;
        }
        .auto-style6 {
            height: 121px;
        }
        .auto-style7 {
            width: 100%;
            height: 346px;
        }
        .auto-style8 {
            width: 693px;
        }
        .auto-style9 {
            margin-right: 0px;
        }
        .auto-style10 {
            width: 661px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AspFormDBConnectionString %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [userTable]"
            UpdateCommand="updateData" UpdateCommandType="StoredProcedure" DeleteCommand="deleteData" DeleteCommandType="StoredProcedure"  InsertCommand="insertData" InsertCommandType="StoredProcedure"></asp:SqlDataSource>
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
            <asp:GridView ID="GridView1" DataKeyNames="username" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="273px" Width="141px" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                    <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                    <asp:BoundField DataField="firstname" HeaderText="firstname" SortExpression="firstname" />
                    <asp:BoundField DataField="lastname" HeaderText="lastname" SortExpression="lastname" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
                    <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
                    <asp:BoundField DataField="birthdate" HeaderText="birthdate" SortExpression="birthdate" />
                    <asp:BoundField DataField="remark" HeaderText="remark" SortExpression="remark" />
                </Columns>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>
                    </td>
                    <td class="auto-style3">1 .Grid view<br />
                        2.Form view<br />
                        3.Details view<br />
                        4.List View<br />
                        5. Data List</td>
                </tr>
                <tr>
                    <td class="auto-style6">
        <asp:FormView ID="FormView1" DataKeyNames="username" runat="server" AllowPaging="True" DataSourceID="SqlDataSource1" OnPageIndexChanging="FormView1_PageIndexChanging" Width="833px">
            <EditItemTemplate>
                username:
                <asp:TextBox ID="usernameTextBox" runat="server" Text='<%# Bind("username") %>' />
                <br />
                password:
                <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                <br />
                firstname:
                <asp:TextBox ID="firstnameTextBox" runat="server" Text='<%# Bind("firstname") %>' />
                <br />
                lastname:
                <asp:TextBox ID="lastnameTextBox" runat="server" Text='<%# Bind("lastname") %>' />
                <br />
                address:
                <asp:TextBox ID="addressTextBox" runat="server" Text='<%# Bind("address") %>' />
                <br />
                state:
                <asp:TextBox ID="stateTextBox" runat="server" Text='<%# Bind("state") %>' />
                <br />
                mobile:
                <asp:TextBox ID="mobileTextBox" runat="server" Text='<%# Bind("mobile") %>' />
                <br />
                birthdate:
                <asp:TextBox ID="birthdateTextBox" runat="server" Text='<%# Bind("birthdate") %>' />
                <br />
                remark:
                <asp:TextBox ID="remarkTextBox" runat="server" Text='<%# Bind("remark") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                username:
                <asp:TextBox ID="usernameTextBox" runat="server" Text='<%# Bind("username") %>' />
                <br />
                password:
                <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                <br />
                firstname:
                <asp:TextBox ID="firstnameTextBox" runat="server" Text='<%# Bind("firstname") %>' />
                <br />
                lastname:
                <asp:TextBox ID="lastnameTextBox" runat="server" Text='<%# Bind("lastname") %>' />
                <br />
                address:
                <asp:TextBox ID="addressTextBox" runat="server" Text='<%# Bind("address") %>' />
                <br />
                state:
                <asp:TextBox ID="stateTextBox" runat="server" Text='<%# Bind("state") %>' />
                <br />
                mobile:
                <asp:TextBox ID="mobileTextBox" runat="server" Text='<%# Bind("mobile") %>' />
                <br />
                birthdate:
                <asp:TextBox ID="birthdateTextBox" runat="server" Text='<%# Bind("birthdate") %>' />
                <br />
                remark:
                <asp:TextBox ID="remarkTextBox" runat="server" Text='<%# Bind("remark") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                username:
                <asp:Label ID="usernameLabel" runat="server" Text='<%# Bind("username") %>' />
                <br />
                password:
                <asp:Label ID="passwordLabel" runat="server" Text='<%# Bind("password") %>' />
                <br />
                firstname:
                <asp:Label ID="firstnameLabel" runat="server" Text='<%# Bind("firstname") %>' />
                <br />
                lastname:
                <asp:Label ID="lastnameLabel" runat="server" Text='<%# Bind("lastname") %>' />
                <br />
                address:
                <asp:Label ID="addressLabel" runat="server" Text='<%# Bind("address") %>' />
                <br />
                state:
                <asp:Label ID="stateLabel" runat="server" Text='<%# Bind("state") %>' />
                <br />
                mobile:
                <asp:Label ID="mobileLabel" runat="server" Text='<%# Bind("mobile") %>' />
                <br />
                birthdate:
                <asp:Label ID="birthdateLabel" runat="server" Text='<%# Bind("birthdate") %>' />
                <br />
                remark:
                <asp:Label ID="remarkLabel" runat="server" Text='<%# Bind("remark") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
                    </td>
                    <td class="auto-style5">
                        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="username" DataSourceID="SqlDataSource1" Height="50px" Width="531px">
                            <Fields>
                                <asp:BoundField DataField="username" HeaderText="username" ReadOnly="True" SortExpression="username" />
                                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                                <asp:BoundField DataField="firstname" HeaderText="firstname" SortExpression="firstname" />
                                <asp:BoundField DataField="lastname" HeaderText="lastname" SortExpression="lastname" />
                                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                                <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
                                <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
                                <asp:BoundField DataField="birthdate" HeaderText="birthdate" SortExpression="birthdate" />
                                <asp:BoundField DataField="remark" HeaderText="remark" SortExpression="remark" />
                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                            </Fields>
                        </asp:DetailsView>
                    </td>
                </tr>
            </table>
            <hr />
        </div>
        <p>
            <table class="auto-style7">
                <tr>
                    <td class="auto-style10">
                        <asp:ListView ID="ListView1" runat="server" DataKeyNames="username" DataSourceID="SqlDataSource1" InsertItemPosition="LastItem">
                            <AlternatingItemTemplate>
                                <li style="background-color: #FFF8DC;">username:
                                    <asp:Label ID="usernameLabel" runat="server" Text='<%# Eval("username") %>' />
                                    <br />
                                    password:
                                    <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("password") %>' />
                                    <br />
                                    firstname:
                                    <asp:Label ID="firstnameLabel" runat="server" Text='<%# Eval("firstname") %>' />
                                    <br />
                                    lastname:
                                    <asp:Label ID="lastnameLabel" runat="server" Text='<%# Eval("lastname") %>' />
                                    <br />
                                    address:
                                    <asp:Label ID="addressLabel" runat="server" Text='<%# Eval("address") %>' />
                                    <br />
                                    state:
                                    <asp:Label ID="stateLabel" runat="server" Text='<%# Eval("state") %>' />
                                    <br />
                                    mobile:
                                    <asp:Label ID="mobileLabel" runat="server" Text='<%# Eval("mobile") %>' />
                                    <br />
                                    birthdate:
                                    <asp:Label ID="birthdateLabel" runat="server" Text='<%# Eval("birthdate") %>' />
                                    <br />
                                    remark:
                                    <asp:Label ID="remarkLabel" runat="server" Text='<%# Eval("remark") %>' />
                                    <br />
                                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                                </li>
                            </AlternatingItemTemplate>
                            <EditItemTemplate>
                                <li style="background-color: #008A8C;color: #FFFFFF;">username:
                                    <asp:Label ID="usernameLabel1" runat="server" Text='<%# Eval("username") %>' />
                                    <br />
                                    password:
                                    <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                                    <br />
                                    firstname:
                                    <asp:TextBox ID="firstnameTextBox" runat="server" Text='<%# Bind("firstname") %>' />
                                    <br />
                                    lastname:
                                    <asp:TextBox ID="lastnameTextBox" runat="server" Text='<%# Bind("lastname") %>' />
                                    <br />
                                    address:
                                    <asp:TextBox ID="addressTextBox" runat="server" Text='<%# Bind("address") %>' />
                                    <br />
                                    state:
                                    <asp:TextBox ID="stateTextBox" runat="server" Text='<%# Bind("state") %>' />
                                    <br />
                                    mobile:
                                    <asp:TextBox ID="mobileTextBox" runat="server" Text='<%# Bind("mobile") %>' />
                                    <br />
                                    birthdate:
                                    <asp:TextBox ID="birthdateTextBox" runat="server" Text='<%# Bind("birthdate") %>' />
                                    <br />
                                    remark:
                                    <asp:TextBox ID="remarkTextBox" runat="server" Text='<%# Bind("remark") %>' />
                                    <br />
                                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                                </li>
                            </EditItemTemplate>
                            <EmptyDataTemplate>
                                No data was returned.
                            </EmptyDataTemplate>
                            <InsertItemTemplate>
                                <li style="">username:
                                    <asp:TextBox ID="usernameTextBox" runat="server" Text='<%# Bind("username") %>' />
                                    <br />password:
                                    <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                                    <br />firstname:
                                    <asp:TextBox ID="firstnameTextBox" runat="server" Text='<%# Bind("firstname") %>' />
                                    <br />lastname:
                                    <asp:TextBox ID="lastnameTextBox" runat="server" Text='<%# Bind("lastname") %>' />
                                    <br />address:
                                    <asp:TextBox ID="addressTextBox" runat="server" Text='<%# Bind("address") %>' />
                                    <br />state:
                                    <asp:TextBox ID="stateTextBox" runat="server" Text='<%# Bind("state") %>' />
                                    <br />mobile:
                                    <asp:TextBox ID="mobileTextBox" runat="server" Text='<%# Bind("mobile") %>' />
                                    <br />birthdate:
                                    <asp:TextBox ID="birthdateTextBox" runat="server" Text='<%# Bind("birthdate") %>' />
                                    <br />remark:
                                    <asp:TextBox ID="remarkTextBox" runat="server" Text='<%# Bind("remark") %>' />
                                    <br />
                                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                                </li>
                            </InsertItemTemplate>
                            <ItemSeparatorTemplate>
<br />
                            </ItemSeparatorTemplate>
                            <ItemTemplate>
                                <li style="background-color: #DCDCDC;color: #000000;">username:
                                    <asp:Label ID="usernameLabel" runat="server" Text='<%# Eval("username") %>' />
                                    <br />
                                    password:
                                    <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("password") %>' />
                                    <br />
                                    firstname:
                                    <asp:Label ID="firstnameLabel" runat="server" Text='<%# Eval("firstname") %>' />
                                    <br />
                                    lastname:
                                    <asp:Label ID="lastnameLabel" runat="server" Text='<%# Eval("lastname") %>' />
                                    <br />
                                    address:
                                    <asp:Label ID="addressLabel" runat="server" Text='<%# Eval("address") %>' />
                                    <br />
                                    state:
                                    <asp:Label ID="stateLabel" runat="server" Text='<%# Eval("state") %>' />
                                    <br />
                                    mobile:
                                    <asp:Label ID="mobileLabel" runat="server" Text='<%# Eval("mobile") %>' />
                                    <br />
                                    birthdate:
                                    <asp:Label ID="birthdateLabel" runat="server" Text='<%# Eval("birthdate") %>' />
                                    <br />
                                    remark:
                                    <asp:Label ID="remarkLabel" runat="server" Text='<%# Eval("remark") %>' />
                                    <br />
                                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                                </li>
                            </ItemTemplate>
                            <LayoutTemplate>
                                <ul id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <li runat="server" id="itemPlaceholder" />
                                </ul>
                                <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                                    <asp:DataPager ID="DataPager1" runat="server">
                                        <Fields>
                                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                            </LayoutTemplate>
                            <SelectedItemTemplate>
                                <li style="background-color: #008A8C;font-weight: bold;color: #FFFFFF;">username:
                                    <asp:Label ID="usernameLabel" runat="server" Text='<%# Eval("username") %>' />
                                    <br />
                                    password:
                                    <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("password") %>' />
                                    <br />
                                    firstname:
                                    <asp:Label ID="firstnameLabel" runat="server" Text='<%# Eval("firstname") %>' />
                                    <br />
                                    lastname:
                                    <asp:Label ID="lastnameLabel" runat="server" Text='<%# Eval("lastname") %>' />
                                    <br />
                                    address:
                                    <asp:Label ID="addressLabel" runat="server" Text='<%# Eval("address") %>' />
                                    <br />
                                    state:
                                    <asp:Label ID="stateLabel" runat="server" Text='<%# Eval("state") %>' />
                                    <br />
                                    mobile:
                                    <asp:Label ID="mobileLabel" runat="server" Text='<%# Eval("mobile") %>' />
                                    <br />
                                    birthdate:
                                    <asp:Label ID="birthdateLabel" runat="server" Text='<%# Eval("birthdate") %>' />
                                    <br />
                                    remark:
                                    <asp:Label ID="remarkLabel" runat="server" Text='<%# Eval("remark") %>' />
                                    <br />
                                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                                </li>
                            </SelectedItemTemplate>
                        </asp:ListView>
                    </td>
                    <td class="auto-style8">
                        <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style9" DataKeyField="username" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" Height="1505px" Width="443px">
                            <AlternatingItemStyle BackColor="White" />
                            <FooterStyle BackColor="#CCCC99" />
                            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#F7F7DE" />
                            <ItemTemplate>
                                username:
                                <asp:Label ID="usernameLabel" runat="server" Text='<%# Eval("username") %>' />
                                <br />
                                password:
                                <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("password") %>' />
                                <br />
                                firstname:
                                <asp:Label ID="firstnameLabel" runat="server" Text='<%# Eval("firstname") %>' />
                                <br />
                                lastname:
                                <asp:Label ID="lastnameLabel" runat="server" Text='<%# Eval("lastname") %>' />
                                <br />
                                address:
                                <asp:Label ID="addressLabel" runat="server" Text='<%# Eval("address") %>' />
                                <br />
                                state:
                                <asp:Label ID="stateLabel" runat="server" Text='<%# Eval("state") %>' />
                                <br />
                                mobile:
                                <asp:Label ID="mobileLabel" runat="server" Text='<%# Eval("mobile") %>' />
                                <br />
                                birthdate:
                                <asp:Label ID="birthdateLabel" runat="server" Text='<%# Eval("birthdate") %>' />
                                <br />
                                remark:
                                <asp:Label ID="remarkLabel" runat="server" Text='<%# Eval("remark") %>' />
                                <br />
<br />
                            </ItemTemplate>
                            <SelectedItemStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        </asp:DataList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
            </table>
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
