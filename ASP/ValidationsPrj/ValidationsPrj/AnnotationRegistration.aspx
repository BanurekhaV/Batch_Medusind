<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnnotationRegistration.aspx.cs" Inherits="ValidationsPrj.AnnotationRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           Name : <asp:TextBox ID="Txtname" runat="server"></asp:TextBox><br /><br />
           Password : <asp:TextBox ID="Txtpass" runat="server"></asp:TextBox><br /><br />
            Confirm password :<asp:TextBox ID="Txtconpass" runat="server"></asp:TextBox><br /><br />

           Age : <asp:TextBox ID="Txtage" runat="server" TextMode="Number"></asp:TextBox><br /><br />
          Email :  <asp:TextBox ID="Txtmail" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="BtnAnnotation" runat="server" Text="validations Thru Annotations" OnClick="BtnAnnotation_Click" />
        </div>
    </form>
</body>
</html>
