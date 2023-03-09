<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CustomControl_Client.WebForm1" %>

<%@ Register assembly="CustomControlsPrj" namespace="CustomControlsPrj" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <cc1:CalendarControl ID="CalendarControl1" runat="server" imgbuttonUrl="Inages/Calendar.png" />
    </form>
</body>
</html>
