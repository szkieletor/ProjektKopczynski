<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="APproducts.aspx.cs" Inherits="Shop1.AdminPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
 <h1>Panel Administracyjny - Produkty i kategorie</h1> 
      <p><span style="font-size: medium">Edycja kategorii:</span><br />
          <br />
          Has&#322;o administratora:<br />
          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          <br />
          <br />
          Dodaj kategorie:<br />
<asp:TextBox ID="TextBoxAddCategory" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="ButtonAddCategory" runat="server" OnClick="ButtonAddCategory_Click" Text="Dodaj" />
          <br />
          <br />
          Usu&#324; kategori&#281;:<br />
<asp:DropDownList ID="DropDownListRemoveCategory" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="ButtonRemoveCategory" runat="server" OnClick="ButtonRemoveCategory_Click" Text="Usu&#324;" />
    </p>
    <p><span style="font-size: 11pt">Dodawanie produktu:<br />
        </span>
<br />
<asp:Button ID="ButtonAddProduct" runat="server" OnClick="ButtonAddCategory_Click" Text="Dodaj" />
    </p>
    <p><span style="font-size: medium">Edycja produktu:</span><br />
        <br />
        Wybierz produkt:
        <br />
&nbsp;<asp:DropDownList ID="DropDownListChooseCategory0" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
&nbsp;
        <asp:DropDownList ID="DropDownListChooseProduct" runat="server">
        </asp:DropDownList>
        <br />
        Wybierz opcj&#281;:<br />
        <asp:RadioButtonList ID="RadioButtonListOpcje" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" TextAlign="Left">
            <asp:ListItem>Edycja</asp:ListItem>
            <asp:ListItem>Usuwanie</asp:ListItem>
        </asp:RadioButtonList>
<br /></p>
</asp:Content>
