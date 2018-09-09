<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" Runat="Server">

    &nbsp;&nbsp;&nbsp; 

    <asp:Label ID="txtTname" runat="server" CssClass="lbl1" Text="Label"  Width="508px"  ></asp:Label>
    <br /><br />
    
    <br /><br />  

    <asp:GridView runat="server" CssClass="rounded_corners" ID="gvpost" AutoGenerateColumns="false" >
         <Columns>
            <asp:BoundField DataField="Tname" HeaderText="Title"  />
              <asp:HyperLinkField Text="View" DataNavigateUrlFormatString="Display.aspx?Per_ID={0}" DataNavigateUrlFields="User_ID" />
        </Columns>
     </asp:GridView>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" Runat="Server">

</asp:Content>

