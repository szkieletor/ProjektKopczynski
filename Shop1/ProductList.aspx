<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Shop1.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">


    <asp:DataList ID="DataList1" runat="server" Width="430px" DataSourceID="SqlDataSource1" DataKeyField="ProductID">
        <ItemTemplate>
            <a href='<%# "ProductDetails.aspx?ProductID=" + Eval("ProductID") %>'><%#Eval("Name") %></a>
            <br />
            Price:
            <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ProductID], [Name], [Price] FROM [Products] WHERE ([ProductCategory_ProductCategoryID] = @ProductCategory_ProductCategoryID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ProductCategory_ProductCategoryID" QueryStringField="ProductCategoryID" Type="Int32" DefaultValue="4" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
