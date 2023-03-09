<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="UserControlPrj.EmployeeForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Date Of Birth :<uc1:WebDateControl runat="server" ID="WebDateControl" />


            <br />
            <hr />
            Date of Joining : <uc1:WebDateControl runat="server" ID="WebDateControl1" />
        </div>
    </form>
</body>
</html>
