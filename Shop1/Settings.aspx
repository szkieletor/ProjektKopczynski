<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="Shop1.Settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
    <a name="Moje konto"></a>
    <h1>Ustawienia konta</h1>
    <p>
        Email:<br />
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
    </p>
    <p>
        Login:<br />
        <asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>
    </p>
    <p>
        Has&#322;o:<br />
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        Powtórz has&#322;o:</p>
    <p>
        <asp:TextBox ID="TextBoxRepeatPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        Stare has&#322;o:<br />
        <asp:TextBox ID="TextBoxOldPassword" runat="server"></asp:TextBox>
    </p>
    <h1>Moje dane</h1>
    <p>
        Imi&#281;:<br />
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
    </p>
    <p>
        Nazwisko:<br />
        <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
    </p>
    <p>
        Adres:<br />
        <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
    </p>
    <p>
        Kod pocztowy<br />
        <asp:TextBox ID="TextBoxCode" runat="server"></asp:TextBox>
    </p>
    <p>
        Tel kom. :<br />
        <asp:TextBox ID="TextBoxTelephone" runat="server"></asp:TextBox>
    </p>
<p>
        <asp:Button ID="ButtonAccept" runat="server" OnClick="ButtonAccept_Click" Text="Potwierd&#378;" />
    </p>
</asp:Content>
