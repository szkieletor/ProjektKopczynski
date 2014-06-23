<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdmProducts.aspx.cs" Inherits="Shop1.AdmProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
    <h1>Panel Administracyjny - Produkty i kategorie</h1>
    <p>
        <span style="font-size: medium">Edycja kategorii:</span><br />
        <br />
        Dodaj kategorie:<br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:TextBox ID="TextBoxAddCategory" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonAddCategory" runat="server" Text="Dodaj" OnClick="ButtonAddCategory_Click" />
                <br />
                <br />
                Usu&#324; kategori&#281;:<br />
                <asp:DropDownList ID="DropDownListRemoveCategory" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonRemoveCategory" runat="server" Text="Usu&#324;" OnClick="ButtonRemoveCategory_Click" />
                </p>
    <p>
        <span style="font-size: 11pt">Dodawanie produktu:<br />
        </span>
        <br />
        <asp:Button ID="ButtonAddProduct" runat="server" Text="Dodaj" OnClick="ButtonAddProduct_Click" />
    </p>
                <p>
                    <span style="font-size: medium">Edycja produktu:</span><br />
                    <br />
                    Wybierz produkt:
        <br />

                    &nbsp;<asp:DropDownList ID="DropDownListChooseCategory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListChooseCategory_SelectedIndexChanged">
                    </asp:DropDownList>
                    &nbsp;
        <asp:DropDownList ID="DropDownListChooseProduct" runat="server">
        </asp:DropDownList>
            </ContentTemplate>

            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="DropDownListChooseCategory" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="ButtonRemoveCategory" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="ButtonAddProduct" EventName="Click" />
            </Triggers>

        </asp:UpdatePanel>
        <br />
        Wybierz opcj&#281;:<br />
        <asp:RadioButtonList ID="RadioButtonListOpcje" runat="server" TextAlign="Left">
            <asp:ListItem>Edycja</asp:ListItem>
            <asp:ListItem>Usuwanie</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="ButtonEditDelete" runat="server" OnClick="ButtonEditDelete_Click" Text="Wykonaj" />
        <br />
    </p>
</asp:Content>
