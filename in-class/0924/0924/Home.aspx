<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_0924.WebForm2" %>

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
            <h2>F2C Home</h2>

            <asp:BulletedList DisplayMode="HyperLink" runat="server">
                <asp:ListItem Value="~/Celsius.aspx" runat="server">F -> C</asp:ListItem>
                <asp:ListItem Value="~/Fahrenheit.aspx" runat="server">C -> F</asp:ListItem>
            </asp:BulletedList>

        </div>
    </form>
</body>
</html>
