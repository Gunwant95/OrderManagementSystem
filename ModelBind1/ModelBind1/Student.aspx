<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="ModelBind1.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:GridView runat="server" ID="StudentsGrid" ItemType="ModelBind1.Models.Student" DataKeyNames="StudentID" SelectMethod="studentsGrid_GetData"
       AutoGenerateColumns="false" >
        <Columns>
            <asp:DynamicField DataField="StudentID" />
            <asp:DynamicField DataField="Firstname" />
            <asp:DynamicField DataField="Lastname" />
            <asp:DynamicField DataField="Email" />
        </Columns>
    </asp:GridView> 
</asp:Content>
