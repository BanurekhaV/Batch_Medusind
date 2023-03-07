<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheForm.aspx.cs" Inherits="CachingPrj.CacheForm" %>
<%@ OutputCache  Duration="30"  Location="Client" VaryByParam="None"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="All" Value="All" ></asp:ListItem>
                <asp:ListItem Text="Laptops" Value="Laptops"></asp:ListItem>
                <asp:ListItem Text="Desktops" Value="Desktops" ></asp:ListItem>
                <asp:ListItem Text="IPads" Value="iPads"></asp:ListItem>
                <asp:ListItem Text="LED TVs" Value="LEDs"> </asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
            <p>
                Server Time :
                <asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
            </p>
            <br />
            Client Time :
            <script>
                document.write(Date());
            </script>

        </div>
    </form>
</body>
</html>
