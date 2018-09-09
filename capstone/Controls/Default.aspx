<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Controls_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
    <div id="loggin">
    <center>Login Page</center>
    <br /><br />
    <!--Loging setup -->
          
            Username: <asp:TextBox ID="txtUser" runat="server" MaxLength="30" /><br/>
            <br />
            Password: <asp:TextBox ID="txtPass" type="password" runat="server" MaxLength="30" EnableViewState="True" /><br/>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" onclick="btnLogin_Click" /><br />
            <br />
            <asp:Label ID="lblFeedback" runat="server" />
        
   </div>

     </center>
</asp:Content>

