<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudForm.aspx.cs" Inherits="School2.StudForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" >
        
        function onlyAlphabets() {
            var regex = /^[a-zA-Z]*$/;
            if (regex.test(document.getElementById("txtname").value)) {
                return true;
            } else {
                alert("Alphabets Only Please.");

                return false;
            }
        }
   


    </script>
    <style type="text/css">
        .auto-style1 {
            width: 193px;
        }
        .auto-style2 {
            width: 157px;
        }
        .auto-style3 {
            width: 117px;
        }
        .auto-style4 {
            width: 103px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:100%">
            <tr>
                <td class="auto-style4">
                    <asp:Label runat="server" ID="lblname" Text="NAME" ></asp:Label> 
                </td>
                <td class="auto-style2">
                    <asp:TextBox runat="server" ID="txtname" required="true"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblrno" runat="server" Text="ROLL NO"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtrno" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblclass" runat="server" Text="CLASS"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="dropdownlist1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dropdownlist1_SelectedIndexChanged">
                        <asp:ListItem>select</asp:ListItem>
                        <asp:ListItem>First Class</asp:ListItem>
                        <asp:ListItem>Second Class</asp:ListItem>
                        <asp:ListItem>Third Class</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblage" runat="server" Text="AGE"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtage" runat="server" required="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnadd" runat="server" Text="ADD" OnClick="btnadd_Click" OnClientClick="javascript:return onlyAlphabets();" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnedit" runat="server" Text="EDIT" />
                </td>
                <td>
                    <asp:Label ID="lblgender" runat="server" Text="GENDER"></asp:Label>
                </td>
                <td>
                    <asp:RadioButton ID="rdbtn1" GroupName="gender" runat="server" Text="Male" />
                    <asp:RadioButton ID="rdbtn2" GroupName="gender" runat="server" Text="Female" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btndelete" runat="server" Text="DELETE" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnfind" runat="server" Text="FIND" OnClick="btnfind_Click" />
                </td>
                        
                <td class="auto-style4">
                    <asp:Button ID="btnclear" runat="server" Text="CLEAR" OnClick="btnclear_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnshow" runat="server" Text="SHOW ALL" OnClick="btnshow_Click" />
                </td>
            </tr>
        </table>
    </div>       
        <!--<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" PageSize="5" >
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" BackColor="White" AutoGenerateColumns="False" AllowPaging="true" AllowSorting="true" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" PageSize="5" >
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Center" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView> -->


        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" AllowPaging="true" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" PageSize="5" OnPageIndexChanging="pagechange" OnPageIndexChanged="Page_Load">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>


    </form>
</body>
</html>
