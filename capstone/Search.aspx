<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" Runat="Server">
       <center>
    &nbsp;&nbsp;&nbsp; 

    Last Name: <asp:TextBox ID="txtTname" runat="server" />
    <br /><br />
    <asp:Button runat="server" ID="btnSearch" Text="Search" onclick="btnSearch_Click" />
    <br /><br />  

    <asp:GridView runat="server" ID="gvpost" AutoGenerateColumns="false" >
         <Columns>
            <asp:BoundField DataField="Tname" HeaderText="Title"  />

        </Columns>
     </asp:GridView>
    </center>     
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" Runat="Server">
</asp:Content>

