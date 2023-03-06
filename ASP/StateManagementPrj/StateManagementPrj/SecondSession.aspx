<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondSession.aspx.cs" Inherits="StateManagementPrj.SecondSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb1" runat="server" Text=""></asp:Label>

            <br />
            <br />
            <asp:Label ID="lb2" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            <asp:Button ID="Btngetsession" runat="server" Text="GetSession" OnClick="Btngetsession_Click" />

        </div>
    </form>
</body>
</html>
