<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewstateForm.aspx.cs" Inherits="StateManagementPrj.ViewstateForm" %>

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
            <asp:Button ID="BtnStore" runat="server"  Text="StoreData" OnClick="BtnStore_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnLoad" runat="server" Text="LoadData" OnClick="BtnLoad_Click"  />

            <br />
            <br />
            <br />
            <asp:Label ID="lbl3" runat="server" Text=" "></asp:Label>

        </div>
    </form>
</body>
</html>
