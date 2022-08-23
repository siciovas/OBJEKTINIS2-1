<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LD1.aspx.cs" Inherits="LD1.LD1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Roko Sičiovo 1 laboratorinis darbas"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Užduotis - 11 (Pilis)"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Skaičiuoti!" BackColor="#FF9900" BorderColor="Black" BorderWidth="5px" />
            <br />
            <br />
            <asp:Table ID="Table1" runat="server" BackColor="#CC9900" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" GridLines="Both">
            </asp:Table>
            <br />
            <asp:Table ID="Table2" runat="server" BackColor="#009900" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" GridLines="Both">
            </asp:Table>
            <asp:Table ID="Table3" runat="server" BackColor="#009900" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" GridLines="Both">
            </asp:Table>
            <br />
            <asp:Button ID="Button2" runat="server" BackColor="Red" BorderColor="Black" BorderStyle="Solid" BorderWidth="5px" OnClick="Button2_Click" Text="Išvalyti rezultatus!" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
