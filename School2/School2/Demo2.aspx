<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo2.aspx.cs" Inherits="School2.Demo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
.UnderLine
{
    style="text-decoration:underline"
}
</style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>     
        <asp:Label ID="lblCountry" Text="Country" runat="server"></asp:Label> 
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Selected="True">Select</asp:ListItem>
        </asp:DropDownList><br />
        <asp:Label ID="lblstate" Text="States" runat="server"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
            <asp:ListItem Selected="True">Select</asp:ListItem>
        </asp:DropDownList><br />
        <asp:Label ID="lblname" runat="server"  Text ="Name"></asp:Label>
        <asp:TextBox runat="server" ID ="txtname1" ></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtname1" ErrorMessage="Please enter alphabets only" ForeColor="Red" ValidationExpression="/^[a-zA-Z]*$/"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please write something" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Button runat="server" ID="send1" Text="Send" />
    </div>
    </form>
</body>
</html>
