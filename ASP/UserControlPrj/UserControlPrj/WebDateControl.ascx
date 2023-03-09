<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebDateControl.ascx.cs" Inherits="UserControlPrj.WebDateControl" %>
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="57px" ImageUrl="~/Images/Calendar.png" OnClick="ImageButton1_Click" Width="70px" />
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>