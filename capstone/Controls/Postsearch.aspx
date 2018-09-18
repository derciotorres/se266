<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Postsearch.aspx.cs" Inherits="Controls_PersonSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
    &nbsp;&nbsp;&nbsp; 
    First Name: <asp:TextBox ID="txtTname" runat="server" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button runat="server" ID="btnSearch" Text="Search" 
        onclick="btnSearch_Click" />
    <br /><br />  

    <asp:GridView runat="server" ID="gvpost" AutoGenerateColumns="false" >
         <Columns>
           <asp:BoundField DataField="Tname" HeaderText="Title"  />
              <asp:HyperLinkField Text="View" DataNavigateUrlFormatString="Display2.aspx?Per_ID={0}" DataNavigateUrlFields="User_ID" />
             <asp:HyperLinkField Text="Edit" DataNavigateUrlFormatString="Form2.aspx?Per_ID={0}" DataNavigateUrlFields="User_ID" />
        </Columns>
     </asp:GridView>
    </center>                                                       
</asp:Content>

