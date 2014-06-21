<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="APusers.aspx.cs" Inherits="Shop1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
    <h1>Panel Administracyjny - U&#380;ytkownicy</h1>
    <p>

        Wybierz u&#380;ytkownika:&nbsp;
        <br />
        <br />
&nbsp;<asp:DropDownList ID="DropDownListUzytkownicy" runat="server">
        </asp:DropDownList>

    </p>
    <p>

        Has&#322;o administratora:<br />
        <asp:TextBox ID="TextBoxHasloAdmin" runat="server"></asp:TextBox>

    </p>
    <p>

        Wybierz opcj&#281;:<asp:RadioButtonList ID="RadioButtonListOpcje" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" TextAlign="Left">
            <asp:ListItem>Blokowanie</asp:ListItem>
            <asp:ListItem>Usuwanie</asp:ListItem>
        </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonPotwierdz" runat="server" Text="Potwierd&#378; " />

    </p>
</asp:Content>
