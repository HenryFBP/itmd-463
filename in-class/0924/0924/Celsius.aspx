<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_0924.WebForm1" %>

<%@ Register Src="~/SiteNavigation.ascx" TagPrefix="uc1" TagName="SiteNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:SiteNavigation runat="server" ID="SiteNavigation" />

            <asp:TextBox ID="TextBoxCelsius" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label">c</asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label">=</asp:Label>
            <asp:TextBox ID="TextBoxFahrenheit" runat="server" Enabled="false"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Label">f</asp:Label>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GO!" />
        </div>
    </form>
</body>
</html>
