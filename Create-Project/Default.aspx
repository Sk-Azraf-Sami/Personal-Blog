<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Create_Project.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is The Default Home Page ...!</h1>
    <hr />
    <asp:Repeater ID="RepBlogDetails" runat="server">
        <ItemTemplate>
            <b><%#Eval("Btitle") %></b>
            <p class="card-text">
                <%#Eval("BDesc") %>
            </p>
            <a href="<%#Eval("Bcatagory") %>/<%#Eval("BUrl") %>">Read The Complete Article ....</a>
            <div class="card-footer text-muted">
                Posted On : <%#Eval("Bposteddate","{0: MMMM dd, yyyy}") %>
                <a href="<%#Eval("Bcatagory") %>/Home.aspx"><%#Eval("Bcatagory") %></a>
            </div>
            <hr />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
