<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="NETCURD.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField ID="HfContactID" runat="server" />
        <table>
            <tr>
                <td>
                    <asp:Label ID="lbl1" runat="server" Text="Name"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl2" runat="server" Text="Mobile"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl3" runat="server" Text="Address"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat ="server" Text="Save" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblSuccess" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </td>
            </tr>            
        </table>
        <br />
        <asp:GridView ID="grContact" runat="server">
           <Columns>
               <asp:BoundField DataField="Name" HeaderText="Name" />
               <asp:BoundField DataField="Mobile" HeaderText="Mobile" />
               <asp:BoundField DataField="Address" HeaderText="Address" />
               <asp:TemplateField>
                   <ItemTemplate>
                       <asp:LinkButton ID="LnkView" runat="server" CommandArgument='<%#Eval(ContactID) %>'>View</asp:LinkButton>
                   </ItemTemplate>
               </asp:TemplateField>
           </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
