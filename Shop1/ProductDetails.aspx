<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Shop1.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">
            <a name="DodawanieProduktu"></a>
                <h1>

            <asp:Label ID="LabelName" runat="server" Text="Nazwa produktu"></asp:Label>

            </h1>

        <div id="sidebar">
            
            <asp:Image ID="Image1" runat="server" Height="164px" Width="171px" />
             <br />
            <br />
            <asp:Label ID="LabelDescription" runat="server" Text="Label"></asp:Label>
            <br />
        </div>

        <div id="rightcolumn">

            <asp:Label ID="LabelPrice" runat="server" Text="Cena"></asp:Label>

            <br />
            <br />

            <asp:Button ID="ButtonAddToCart" runat="server" Height="31px" Text="Dodaj do koszyka" Width="109px" OnClick="ButtonAddToCart_Click" />
            <br />
            <br />
            <br />

        </div>
</asp:Content>
