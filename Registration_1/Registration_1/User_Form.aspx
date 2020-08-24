<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Form.aspx.cs" Inherits="Registration_1.User_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width:100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                </td>
                <td>
                    <asp:Textbox ID="username" runat="server" required="true"></asp:Textbox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl2" runat="server" Text="Email ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="emailid" runat="server" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl3" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="pswd" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
               <tr>
                <td>
                    <asp:Label ID="lbl4" runat="server" Text="Confirm Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="pswd2" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="lbl5" runat="server" Text ="Gender"></asp:Label>
                </td>
                <td>
                    <asp:RadioButton ID="radiobtn1" Text="M" runat="server" GroupName="gender" />
                    <asp:RadioButton ID="radiobtn2" Text="F" runat="server" GroupName="gender" />  
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl6" runat="server" Text="Select Course"></asp:Label>
                </td>
                <td>
                    <asp:Checkbox ID="chk1" runat="server" Text="J2EE" />
                    <asp:CheckBox ID="chk2" runat="server" Text="NET" />
                    <asp:CheckBox ID="chk3" runat="server" Text="JAVA" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <br />
                    <asp:Button ID="btn1" runat="server" CssClass="btn-btn-primary" Text="Register" onClick="btn1_click" />
                </td>
            </tr>
        </table>

        <asp:Label ID="msg" runat="server" Font-Size="Medium" ForeColor="red"></asp:Label>
    </div>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblfirst" runat="server" Text ="First Value"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtval1" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblsecond" runat="server" Text="Second Value"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtval2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="lblres" runat="server" Text="Result"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtval3" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="ressubmit" Text="Submit" OnClick="ressubmit_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>

    <table>
        <tr>
            <td>
                <asp:Label ID="showusernamelbl" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="showusername" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="showEmailIdlbl" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="showemail" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="showgenderlbl" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="showgender" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="showcourselbl" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="ShowCourse" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</body>
</html>
