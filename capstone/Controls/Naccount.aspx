<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Naccount.aspx.cs" Inherits="Controls_Naccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <center>
    <div id="loggin">
    <center>Create Account</center>
    <br /><br />
    <!--Loging setup -->
          
            Username: <asp:TextBox ID="txtUname" runat="server" MaxLength="30" /><br />
            <br />
            Password: <asp:TextBox ID="txtPW" type="password" runat="server" MaxLength="30" EnableViewState="True" /><br />
            <br />
            <asp:Button ID="btnCreate" runat="server" Text="Create" onclick="btnCreate_Click" /><br />
            <br />
            <asp:Label ID="lblFeedback" runat="server" />
        
   </div>

     </center>

</asp:Content>

