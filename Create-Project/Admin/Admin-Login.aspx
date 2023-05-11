<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Admin-Login.aspx.cs" Inherits="Create_Project.Admin.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin Login Page...</h1>
    <hr />
    <center>
        <table border="1">
            <tr>
                <td>Login</td>
                <td> <asp:TextBox ID="TxtAdminLogin" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="ButLogin" runat="server" Text="Login" class="btn btn-primary" OnClick="ButLogin_Click"> </asp:Button>
    </center>
</asp:Content>
