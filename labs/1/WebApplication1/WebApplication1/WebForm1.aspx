<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <asp:TextBox ID="op1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="ops" runat="server"></asp:DropDownList>
            <asp:TextBox ID="op2" runat="server"></asp:TextBox>
            =
            <asp:TextBox ID="result" runat="server" Enabled="false"></asp:TextBox>
        </section>
        <section>
            <asp:Button runat="server" ID="calc" Text="Calculate!" />
        </section>
        <section>
            <ul id="problemsul" runat="server"></ul>
        </section>
    </form>
</body>
</html>
