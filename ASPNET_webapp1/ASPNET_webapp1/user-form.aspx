<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user-form.aspx.cs" Inherits="ASPNET_webapp1.user_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Application</title>
    <style type="text/css">
        .auto-style1
        {
            width:100%;
        }
        .auto-style3
        {
            width:121px;
        }
        .auto-style2
        {
            margin-left:0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Welcome Gunwant</h2>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">                    
                    <asp:Label ID="Label1" runat="server" Text ="User Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Textbox1" runat ="server" CssClass="auto-style2"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat ="server" Text="File Upload"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID ="FileUpload1" runat ="server" />
                </td>
            </tr>
        </table>
        <div>
            <asp:Label ID="Label3" runat ="server" Text="Enter Name"></asp:Label>
            <asp:TextBox ID="UserName" runat ="server" ToolTip ="Enter user name"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="submitbutton" runat ="server" Text="Submit" OnClick ="submit_click" />
        </p>
        <div>
            <asp:Label ID ="Label4" runat ="server" Text ="Label Here"></asp:Label>
            <asp:TextBox ID="test" runat ="server" Text ="Test Name" AccessKey="B" ToolTip="Write"></asp:TextBox>
        </div>
         <div>
             <asp:Button ID="btn1" runat ="server" Text ="Click Me" OnClick="btn1_click" />
        </div>
    </div>
        <br /><asp:Button runat="server" ID="btn11" OnClientClick="javascript:window.open('http://www.javatpoint.com')" Text="Click Here!" />
        <br /><br />
        <div>
        <asp:RadioButton ID="radiobtn1" Text="M" runat ="server" GroupName="gender" />
        <asp:RadioButton ID ="radiobtn2" Text ="F" runat ="server" GroupName ="gender" />
            </div>
        <p>
            <asp:Button runat ="server" ID="btn2" Text="Gender" OnClick="radio_btn_click" style ="width:60px"/>
        </p>
        <div>
            <asp:Calendar runat="server" ID="Calendar1" OnSelectionChanged="Cal1_change" SelectedDate="2019-06-17"></asp:Calendar>
        </div>
        <div>
            <h2>Select Courses</h2>
            <asp:checkbox ID="chk1" runat ="server" Text="C#" />
            <asp:CheckBox ID ="chk2" runat ="server" Text="Java" />
            <asp:CheckBox ID ="chk3" runat="server" Text ="Angular" TabIndex="4" />
        </div>
        <p>
            <asp:Button ID ="chkbtn" runat ="server" Text ="Check_Btn" OnClick="chk_click" />
        </p>
        <p>
            Courses Selected: <asp:Label runat ="server" ID="ShowCourses"></asp:Label>
        </p>
        <asp:Label ID="lbl5" runat ="server" ></asp:Label>
         <asp:Label ID="cal" runat ="server" ></asp:Label>
    </form>
    <asp:Label ID="userinput" runat="server"></asp:Label><br />
    <asp:Label ID="lbl1" runat ="server" ></asp:Label>
    
    <div>
        
        <asp:HyperLink ID ="Hyperlink1" runat ="server" Text="Javatpoint" target="_blank" NavigateUrl="http://www.javatpoint.com"></asp:HyperLink>
    </div>
</body>
</html>
