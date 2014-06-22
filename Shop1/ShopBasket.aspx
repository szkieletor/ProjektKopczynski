<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ShopBasket.aspx.cs" Inherits="Shop1.ShopBasket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
    <h1>Mój koszyk</h1>
    <p>
        Wybierz produkt:<br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:RadioButtonList ID="RadioButtonOpcje" runat="server">
            <asp:ListItem>Zmie&#324; ilo&#347;&#263;</asp:ListItem>
            <asp:ListItem>Usu&#324; z koszyka</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Zmie&#324; ilo&#347;&#263;:<br />
        <asp:TextBox ID="TextBoxZmien" runat="server" EnableTheming="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonPotwierz" runat="server" Height="22px" Text="Potwierd&#378;" />
    </p>
    <p>
        Twoje produkty w koszyku:</p>
    <asp:BulletedList ID="BulletedList1" runat="server" Height="20px" Width="370px">
    </asp:BulletedList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonPrzejdz" runat="server" Text="Przejd&#378; do p&#322;atno&#347;ci" />
</asp:Content>
