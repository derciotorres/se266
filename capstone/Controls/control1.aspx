<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/AdminMasterPage.master" AutoEventWireup="true" CodeFile="control1.aspx.cs" Inherits="Controls_control1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <center>
        <asp:Button ID="btnuser" runat="server" Text="Searchuser" Height="57px" Width="187px" OnClick="btnuser_Click" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSearch" runat="server" Text="Search" Height="57px" Width="187px" OnClick="btnSearch_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAccount" runat="server" Text="Create a new account" Height="57px"  Width="187px" OnClick="btnAccount_Click" />

    </center>

</asp:Content>


