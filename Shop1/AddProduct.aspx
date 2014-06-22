<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Shop1.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
        <a name="DodawanieProduktu"></a>
                <h1>Dodaj nowy produkt</h1>

        <div id="sidebar">
            
            <asp:Image ID="Image1" runat="server" Height="164px" Width="171px" />
             <br />
            <br />
             <asp:FileUpload ID="FileUploadImage" runat="server" Width="214px" Height="21px" />
        </div>

        <div id="rightcolumn">

            <asp:Label ID="LabelName" runat="server" Text="Nazwa produktu"></asp:Label>

            :<br />
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Pole Nazwa jest wymagane!"></asp:RequiredFieldValidator>
            <br />
            <br />
            Ilo&#347;&#263;:<br />
            <asp:TextBox ID="TextBoxCount" runat="server"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBoxCount" ErrorMessage="Nie podano poprawnie ilo&#347;ci!" Operator="GreaterThan" Type="Integer" ValueToCompare="-1"></asp:CompareValidator>
            <br />
            <br />

            <asp:Label ID="LabelPrice" runat="server" Text="Cena"></asp:Label>
            :<br />
            <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBoxPrice" ErrorMessage="CompareValidator" Operator="DataTypeCheck" Type="Integer">Pole Has&#322;o musi by&#263; liczb&#261;!</asp:CompareValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Kategoria"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownListCategory" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />

        </div>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Opis produktu"></asp:Label>
    <asp:TextBox ID="TextBoxDescription" runat="server" TextMode="MultiLine" Height="357px" Rows="50" Width="437px"></asp:TextBox>
        <br />
    <asp:Button ID="ButtonAccept" runat="server" Text="Akceptuj" OnClick="ButtonAccept_Click" />
    <br />
    <br />
</asp:Content>
