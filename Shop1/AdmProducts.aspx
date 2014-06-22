<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdmProducts.aspx.cs" Inherits="Shop1.AdmProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
     <h1>Panel Administracyjny - Produkty i kategorie</h1> 
      <p><span style="font-size: medium">Edycja kategorii:</span><br />
          <br />
          Dodaj kategorie:<br />
<asp:TextBox ID="TextBoxAddCategory" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="ButtonAddCategory" runat="server" Text="Dodaj" />
          <br />
          <br />
          Usu&#324; kategori&#281;:<br />
<asp:DropDownList ID="DropDownListRemoveCategory" runat="server">
</asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="ButtonRemoveCategory" runat="server" Text="Usu&#324;" />
    </p>
    <p><span style="font-size: 11pt">Dodawanie produktu:<br />
        </span>
<br />
<asp:Button ID="ButtonAddProduct" runat="server" Text="Dodaj" />
    </p>
    <p><span style="font-size: medium">Edycja produktu:</span><br />
        <br />
        Wybierz produkt:
        <br />
&nbsp;<asp:DropDownList ID="DropDownListChooseCategory0" runat="server">
</asp:DropDownList>
&nbsp;
        <asp:DropDownList ID="DropDownListChooseProduct" runat="server">
        </asp:DropDownList>
        <br />
        Wybierz opcj&#281;:<br />
        <asp:RadioButtonList ID="RadioButtonListOpcje" runat="server" TextAlign="Left">
            <asp:ListItem>Edycja</asp:ListItem>
            <asp:ListItem>Usuwanie</asp:ListItem>
        </asp:RadioButtonList>
<br /></p>
</asp:Content>
