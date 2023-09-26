<%@ Page Title="Products" Language="C#" MasterPageFile="~/Views/Client/ClientMaster.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Affiliate.Views.Client.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
       .img{
           width:150px;
       }
    </style>
    <div>
        <asp:Label runat="server" ID="lblBind">
            Products
        </asp:Label>

    </div>

    <div id="productContainer" runat="server">
       <%-- <asp:GridView runat="server" ID="grdProd" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:TemplateField HeaderText="Product">
                    <ItemTemplate>
                        <a href='<%# Eval("Link") %>' target="_blank">
                            <img src='<%# Eval("Img_Link") %>' alt='<%# Eval("Img_Link") %>' class="img" />
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>--%>
    </div>

</asp:Content>
