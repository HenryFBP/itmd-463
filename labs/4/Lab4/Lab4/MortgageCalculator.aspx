<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MortgageCalculator.aspx.cs" Inherits="Lab4.MortgageCalculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <ul>
            <li>
                <label>Principle:</label>
                <asp:TextBox ID="TextBoxPrinciple" runat="server"></asp:TextBox>
            </li>
            <li>
                <label>Duration (years)</label>
                <asp:RadioButtonList ID="RadioButtonListYears" runat="server" AutoPostBack="true" OnSelectedIndexChanged="PostBackYears">
                    <asp:ListItem Value="15">15</asp:ListItem>
                    <asp:ListItem Value="30">30</asp:ListItem>
                    <asp:ListItem Value="other">other</asp:ListItem>
                </asp:RadioButtonList>
                <asp:UpdatePanel  UpdateMode="Conditional" runat="server" ID="MortgageCalcUpdatePanel">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBoxYearsOther" runat="server" Enabled="false"></asp:TextBox>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="RadioButtonListYears" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </li>
            <li>
                <label>Interest Rate</label>
                <asp:DropDownList ID="DropDownListInterestRate" runat="server"></asp:DropDownList>
            </li>
        </ul>
        <asp:Button runat="server" Text="Calculate!" />
    </section>
    <section>
        <h1>Result:</h1>
        <asp:TextBox ID="TextBoxResult" Enabled="false" runat="server"></asp:TextBox>
    </section>
    <section>
        <h1>Problems:</h1>
        <asp:BulletedList ID="BulletedListProblems" runat="server">
        </asp:BulletedList>
    </section>
</asp:Content>
