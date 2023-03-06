<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstSession.aspx.cs" Inherits="StateManagementPrj.FirstSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         Name :<asp:TextBox ID="txtname" runat="server" Text=""> </asp:TextBox>
            <br />
          Email :  <asp:TextBox ID="txtemail" runat="server" Text=""></asp:TextBox>
            <br />   <br />
            <asp:Button ID="btnsession" runat="server" Text="SessionRedirect" OnClick="btnsession_Click"  />
        </div>
    </form>
</body>
</html>
