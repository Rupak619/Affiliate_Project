<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="Affiliate.Views.Admin.AddProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Label runat="server" ID="lblDescription"> Description : </asp:Label>
        <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDesc" />
    </div>

    <div>
        <asp:Label runat="server" ID="lblLink"> Link : </asp:Label>
        <asp:TextBox runat="server" ID="txtLink"></asp:TextBox>
    </div>

    <div>
        <asp:Label runat="server" ID="lblImgLnk">Image Link : </asp:Label>
        <asp:TextBox runat="server" ID="txtImgLnk"></asp:TextBox>
    </div>

    <div>
        <asp:Button Text="Save" runat="server" ID="btnSave" OnClick="btnSave_Click" />
        <asp:Label runat="server" ID="lblmsg"></asp:Label>
    </div>

</asp:Content>
