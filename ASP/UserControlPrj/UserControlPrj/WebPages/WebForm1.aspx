<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UserControlPrj.WebForm1" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Date of Travel : <uc1:WebDateControl runat="server" ID="WebDateControl" />
            <br />
            <asp:Button ID="btn1" runat="server" Text="Click" OnClick="btn1_Click" />


        </div>
    </form>
</body>
</html>
