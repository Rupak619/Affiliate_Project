<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <label>Electronics</label>
        <asp:DropDownList runat="server" ID="ddlElect">
            <asp:ListItem>Mobiles</asp:ListItem>
            <asp:ListItem>Cameras</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div>
        <label>Men's FashionWear</label>
        <asp:DropDownList runat="server" ID="ddlMF">
            <asp:ListItem>Tshirts</asp:ListItem>
            <asp:ListItem>Shirts</asp:ListItem>
            <asp:ListItem>Jeans</asp:ListItem>
            <asp:ListItem>Shoes</asp:ListItem>
            <asp:ListItem>Slippers</asp:ListItem>
        </asp:DropDownList>
    </div>
    <a target="_blank" href="https://www.amazon.in/b?_encoding=UTF8&tag=myaffilia0494-21&linkCode=ur2&linkId=fce9bfff5ef6f433285d11e80f08e1fd&camp=3638&creative=24630&node=3561110031">Mobiles</a>

    <iframe sandbox="allow-popups allow-scripts allow-modals allow-forms allow-same-origin" style="width:120px;height:240px;" marginwidth="0" marginheight="0" scrolling="no" frameborder="0" src="//ws-in.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=IN&source=ss&ref=as_ss_li_til&ad_type=product_link&tracking_id=myaffilia0494-21&language=en_IN&marketplace=amazon&region=IN&placement=B0BY8MCQ9S&asins=B0BY8MCQ9S&linkId=dd0cc1cfb9401bc4da6626a3188b4ce9&show_border=true&link_opens_in_new_window=true"></iframe>

    <a target="_blank" href="AddProducts.aspx">
        Add Products
    </a>
    


</asp:Content>
