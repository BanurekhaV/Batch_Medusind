<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuerystringDestination.aspx.cs" Inherits="StateManagementPrj.QuerystringDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnget" runat="server" Text="GetData" OnClick="btnget_Click" />
        </div>
    </form>
</body>
</html>
