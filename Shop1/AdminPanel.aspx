<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="Shop1.AdminPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
    <br />
<br />
<asp:Label ID="Label1" runat="server" Text="Ustawienia kategorii"></asp:Label>
<br />
<asp:DropDownList ID="DropDownListRemoveCategory" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<asp:Button ID="ButtonRemoveCategory" runat="server" OnClick="ButtonRemoveCategory_Click" Text="Remove" />
<br />
<asp:TextBox ID="TextBoxAddCategory" runat="server"></asp:TextBox>
<asp:Button ID="ButtonAddCategory" runat="server" OnClick="ButtonAddCategory_Click" Text="Button" />
<br />
<br />
<br />
</asp:Content>
