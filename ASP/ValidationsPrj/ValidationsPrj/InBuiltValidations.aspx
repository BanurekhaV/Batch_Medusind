<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InBuiltValidations.aspx.cs" Inherits="ValidationsPrj.InBuiltValidations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:red;font-size:20px;">Registration Form</h1>
            <br />
            Name&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtname" ErrorMessage="Please Enter name" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Password :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtpass" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="Txtpass" ErrorMessage="Password is Must" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password:&nbsp;
            <asp:TextBox ID="Txtconpass" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="Txtconpass" Display="Dynamic" ErrorMessage="Enter Confirm Password" 
                ForeColor="#CC0000">*</asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server"
    ControlToCompare="Txtpass" ControlToValidate="Txtconpass" Display="Dynamic" ErrorMessage="Password and Confirm Password Does not Match" ForeColor="#CC0000">*</asp:CompareValidator>
            <br />
            <br />
            <br />
            Age&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtage" runat="server" TextMode="Number"></asp:TextBox>
            &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Txtage" 
                Display="Dynamic" ErrorMessage="Age to be between 18 and 50" ForeColor="#CC0000" MaximumValue="50" MinimumValue="18" Type="Integer">*</asp:RangeValidator>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Txtage" 
    Display="Dynamic" ErrorMessage="Age is required" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtmail" runat="server"></asp:TextBox>
            &nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txtmail" 
                Display="Dynamic" ErrorMessage="Invalid Email" ForeColor="#CC0000" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Txtmail" 
    Display="Dynamic" ErrorMessage="Email is Required" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="BtnRegister" runat="server" Text="Register"   OnClick="BtnRegister_Click"  ValidationGroup="v1"  />
        &nbsp;
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000"  ValidationGroup="v1" />
            <br />
            <br />

            <br />
            <br />
            <hr />
            <h1 style="color:red;font-size:20px;">Login Form</h1>

            Login Mail :&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox1" ErrorMessage="Email Required"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Invalid Email"></asp:RegularExpressionValidator>
            <br />
            <br />
            Password :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password Must"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"  ValidationGroup="v2" />
            <br />
            <br />
            <br />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
