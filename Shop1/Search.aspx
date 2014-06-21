<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Shop1.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">

    <asp:Label ID="LabelNoResults" runat="server" Text="Brak wyników!"></asp:Label>
    
    <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
            <a href='<%# "ProductDetails.aspx?ProductID=" + Eval("ProductID") %>'><%#Eval("Name") %></a>
            <br />
            Price:
            <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
            <br />
            <br />
        </ItemTemplate>
</asp:DataList>
</asp:Content>
