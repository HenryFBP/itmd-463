<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteNavigation.ascx.cs" Inherits="_0924.SiteNavigation" %>
<h1>F2C Application</h1>

<hr />
<asp:Menu ID="Menu1" Orientation="Horizontal" runat="server">
    <Items>
        <asp:MenuItem NavigateUrl="~/Home.aspx" Text="Home" Value="Home"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/Fahrenheit.aspx" Text="Fahrenheit" Value="Fahrenheit"></asp:MenuItem>
    </Items>
</asp:Menu>
<hr />

