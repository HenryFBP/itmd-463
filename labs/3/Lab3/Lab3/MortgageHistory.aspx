<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MortgageHistory.aspx.cs" Inherits="Lab3.MortgageHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridViewHistory" runat="server" AutoGenerateColumns="True">
    </asp:GridView>
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
    <asp:Button runat="server" ID="ButtonDelete" OnClick="ButtonDelete_Click" Text="Delete history?" />
</asp:Content>
