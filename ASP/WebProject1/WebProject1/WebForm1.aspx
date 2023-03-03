<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebProject1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Text="SimpleText" ForeColor="#000066"></asp:TextBox>
        <br /><br />
            <asp:Label ID="lbl2" runat="server" Text="Email"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Click here" OnClick="Button1_Click" />
        &nbsp;
             <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />

            <br />
            <input id="Submit1" type="submit" value="submit" />
        </div>
       
    </form>
</body>
</html>
