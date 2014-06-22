<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdmUsers.aspx.cs" Inherits="Shop1.AdmUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
    <p><span style="font-size: medium">Edycja u&#380;ytkownika:</span><br />
        <br />
        Wybierz u&#380;ytkownika:
        <br />
&nbsp;<asp:DropDownList ID="DropDownListChooseUser" runat="server">
    <asp:ListItem>
        Test
    </asp:ListItem>
</asp:DropDownList>
&nbsp;</p>
    <p>&nbsp;<br />
        Wybierz opcj&#281;:<br />
        <asp:RadioButtonList ID="RadioButtonListOpcje" runat="server" TextAlign="Left">
            <asp:ListItem>Blokuj</asp:ListItem>
            <asp:ListItem>Odblokuj</asp:ListItem>
            <asp:ListItem>Usu&#324;</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="ButtonPotwierdz" runat="server" Text="Potwierdz" OnClick="ButtonPotwierdz_Click" />
    &nbsp;<br />
    </p>
</asp:Content>
