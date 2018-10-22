<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MortgageHistory.aspx.cs" Inherits="Lab5.MortgageHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridViewHistory" runat="server" AutoGenerateColumns="True">
            </asp:GridView>
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
            <asp:Button runat="server" ID="ButtonDelete" OnClick="ButtonDelete_Click" Text="Delete history?" />
        </ContentTemplate>
        <Triggers>
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
