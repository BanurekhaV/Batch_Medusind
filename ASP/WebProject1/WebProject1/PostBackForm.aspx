<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBackForm.aspx.cs" Inherits="WebProject1.PostBackForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           No Of. Clicks: <asp:TextBox ID="txtname" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnclick" runat="server" Text="ClicksCount" OnClick="btnclick_Click" />
        </div>
    </form>
</body>
</html>
