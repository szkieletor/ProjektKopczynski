<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Shop1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
    <asp:Login ID="Login1" runat="server">
    <LayoutTemplate>
        <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
            <tr>
                <td>
                    <table cellpadding="0">
                        <tr>
                            <td align="center" colspan="2">Log In<br /> Wpisz nazw&#281; u&#380;ytkownika i has&#322;o. Zarejestruj si&#281; je&#347;li nie masz konta</td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nazwa u&#380;ytkownika:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Has&#322;o:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:CheckBox ID="RememberMe" runat="server" Text="Zapami&#281;taj" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2" style="color:Red;">
                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False" Text="B&#322;&#261;d"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" colspan="2">
                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </LayoutTemplate>
</asp:Login>
</asp:Content>
