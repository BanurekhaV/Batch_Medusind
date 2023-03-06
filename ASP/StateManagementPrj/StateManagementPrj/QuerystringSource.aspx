<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuerystringSource.aspx.cs" Inherits="StateManagementPrj.QuerystringSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="lbluname" runat="server" Text="UserName"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Textname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Textemail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnRedirect" runat="server"  Text="Redirect" OnClick="BtnRedirect_Click"  />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
        </div>
    </form>
</body>
</html>
