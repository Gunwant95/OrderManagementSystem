<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RequestControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
        <asp:Button ID="btn1" runat="server" Text="Show" />
    </div>

        <div>
            <table>
                <tr>
                    <td>
                        First Val
                    </td>
                    <td>
                        <asp:TextBox ID="firstval" runat="server" required="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Second Val
                    </td>
                    <td>
                        <asp:TextBox ID="secondval" runat="server"  required="true"></asp:TextBox>It Should be greater than First Value
                    </td>
                </tr>
                <tr> 
                    <td>
                        <asp:Button ID="btn2" runat="server" Text="Compare" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Enter Value between 100-200
                    </td>
                    <td>
                        <asp:TextBox ID="value3" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        EMAIL ID
                    </td>
                    <td>
                        <asp:TextBox ID="useremail" runat="server" ></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Enter Valid Code " ControlToCompare="secondval" ControlToValidate="firstval" Display="Dynamic" ForeColor="Red" Operator="GreaterThan" Type="Integer"></asp:CompareValidator>
            <asp:RangeValidator ID="RangeValid" runat="server" ErrorMessage="Enter between Range" ForeColor="Red" ControlToValidate="value3" MaximumValue="200" MinimumValue="100" SetFocusOnError="True" Type=" Integer"></asp:RangeValidator>
            <asp:RegularExpressionValidator ID="regularExp" runat="server" ErrorMessage="Please enter valid email" ControlToValidate="useremail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="requireFld" runat="server" ErrorMessage="Please enter email ID" ControlToValidate="useremail" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:ValidationSummary ID="validsummary" runat="server" ForeColor="Green"/>
        </div>        
    </form>
</body>
</html>
