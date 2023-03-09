<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="UserControlPrj.ProjectDetails" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Project Start Date : <uc1:WebDateControl runat="server" ID="WebDateControl" />
        </div>
    </form>
</body>
</html>
