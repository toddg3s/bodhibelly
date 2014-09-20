<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recipe.aspx.cs" Inherits="bodhibelly2.Recipe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><asp:Label ID="lblName" runat="server" Text="Recipe Name" CssClass=""></asp:Label></h2>
<div style="padding-left: 20px">
    <span style="float: right"><asp:Image ID="imgPicture" runat="server" AlternateText="." Width="300px" Height="200px" ImageUrl="http://3.bp.blogspot.com/-2rpDUjER6ls/TdFE0XOg4AI/AAAAAAAAACY/PlXTn0lG8Ac/s1600/Caprese+Salad+2+500.jpg" /></span>
    <asp:Label ID="lblDesc" runat="server" Text="This is a bunch of really, really long text to see what happens with the image on the right.  I'm hoping I can come up with enough tex tto show what is going to happen." /><br /><br />
    <asp:HyperLink ID="lnkLink" runat="server" NavigateUrl="http://google.com" Text="http://google.com" /><br /><br />
    <em>Contributed by: </em><asp:Label ID="lblContributor" runat="server" Text="Someone's Name" />&nbsp;on&nbsp;<asp:Label ID="lblPosted" runat="server" /><br /><br />
    <asp:Repeater ID="rptTags" runat="server">
        <HeaderTemplate><em>Tags: </em></HeaderTemplate>
        <ItemTemplate><asp:Label ID="lblTag" runat="server" Text="Tag" /></ItemTemplate>
        <SeparatorTemplate>, </SeparatorTemplate>
        <FooterTemplate><br /><br /></FooterTemplate>
    </asp:Repeater>
    <em>Servings: </em> <asp:Label ID="lblServings" runat="server" Text="4" /><br /><br />
    <asp:Repeater ID="rptIngredients" runat="server">
        <HeaderTemplate>
            <strong>Ingredients</strong><br />
        </HeaderTemplate>
        <ItemTemplate>
            <span style="display: inline-block; width: 70px;"><asp:Label ID="lblQuantity" runat="server" Text="1" />&nbsp;<asp:Label ID="lblUnit" runat="server" Text="ea" /></span>
            <asp:Label ID="lblName" runat="server" Text="Tomato" /><br />
        </ItemTemplate>
        <FooterTemplate><br /></FooterTemplate>
    </asp:Repeater>
    <asp:Repeater ID="rptInstructions" runat="server">
        <HeaderTemplate>
            <strong>Instructions</strong><br />
        </HeaderTemplate>
        <ItemTemplate>
            <span style="display: inline-block; width: 40px;"><asp:Label ID="lblStep" runat="server" Text="1" />.</span>
            <asp:Label ID="lblDescription" runat="server" Text="Do something" /><br />
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
    </asp:Repeater>
</div>
<div style="clear: both">
    <asp:SqlDataSource ID="dsRecipe" runat="server" ConnectionString="<%$ ConnectionStrings:graysoft_bodhibellyConnectionString %>" SelectCommand="SELECT * FROM [Recipe] WHERE ([Id] = @Id)">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="1" Name="Id" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    </div>
    <asp:FormView ID="FormView1" runat="server" DataSourceID="dsRecipe">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>

