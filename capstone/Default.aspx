<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">

    <!-- This page has holds all the pictures and the information for it on the back end  -->


      <div class="container2" style="width: 100%";">

        <div class="row">
            <div class="col-md-4 imgdiv">
                <asp:Imagebutton ID="Image1" class="pic3" runat="server" OnClick="btnopen1_Click " />
                    <div class="caption" style="text-align:  center; color: dodgerblue; " >
                        <asp:Label ID="lblTname1" runat="server"  Text="Label"></asp:Label>
                        <asp:Label ID="description1" Visible="false" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="email1" runat="server" Visible="false" Text="Label"></asp:Label>
                        <asp:Label ID="town1" runat="server" Visible="false" Text="Label"></asp:Label>
                    </div>
            </div>
            <div class="col-md-4 imgdiv">
            <asp:Imagebutton ID="Image2" class="pic3" runat="server"  OnClick="btnopen2_Click "  />
                 <div class="caption"  style="text-align:  center; color: dodgerblue;">
                        <asp:Label ID="lblTname2" runat="server"  Text="Label"></asp:Label>
                        <asp:Label ID="description2" runat="server" Visible="false" Text="Label"></asp:Label>
                        <asp:Label ID="email2" runat="server" Visible="false" Text="Label"></asp:Label>
                     <asp:Label ID="town2" runat="server" Visible="false" Text="Label"></asp:Label>
                    </div>
            </div>
            <div class="col-md-4 imgdiv">
               <asp:Imagebutton ID="Image3"  class="pic3" runat="server" OnClick="btnopen3_Click "  />
                   <div class="caption" style="text-align:center; color: dodgerblue;">
                        <asp:Label ID="lblTname3" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="description3" runat="server" Visible="false" Text="Label"></asp:Label>
                        <asp:Label ID="email3" runat="server" Visible="false" Text="Label"></asp:Label>
                       <asp:Label ID="town3" runat="server" Visible="false" Text="Label"></asp:Label>
                    </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4 imgdiv">
             <asp:Imagebutton ID="Image4"  class="pic3" runat="server" OnClick="btnopen4_Click "  />
                   <div class="caption" style="text-align:center; color: dodgerblue;">
                         <asp:Label ID="lblTname4" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="description4" runat="server" Visible="false" Text="Label"></asp:Label>
                        <asp:Label ID="email4" runat="server" Visible="false" Text="Label"></asp:Label>
                       <asp:Label ID="town4" runat="server" Visible="false" Text="Label"></asp:Label>
                    </div>
            </div>
            <div class="col-md-4 imgdiv">
             <asp:Imagebutton ID="Image5"  class="pic3" runat="server" OnClick="btnopen5_Click " />
                <div class="caption" style="text-align:center; color: dodgerblue;">
                        <asp:Label ID="lblTname5" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="description5" runat="server" Visible="false" Text="Label"></asp:Label>
                        <asp:Label ID="email5" runat="server" Visible="false" Text="Label"></asp:Label>
                    <asp:Label ID="town5" runat="server" Visible="false" Text="Label"></asp:Label>
                    </div>
            </div>
            <div class="col-md-4 imgdiv">
             <asp:Imagebutton ID="Image6" class="pic3" runat="server" OnClick="btnopen6_Click "   />
                 <div class="caption" style="text-align:center; color: dodgerblue;">
                         <asp:Label ID="lblTname6" runat="server" text="Label"></asp:Label>
                        <asp:Label ID="description6" runat="server" Visible="false" Text="Label"></asp:Label>
                        <asp:Label ID="email6" runat="server" Visible="false" Text="Label"></asp:Label>
                     <asp:Label ID="town6" runat="server" Visible="false" Text="Label"></asp:Label>
                    </div>
            </div>
        </div>
  
        </div>
 


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
      <div class="banner">

            <img src="img/banner.jpg"  style="width: 100%; margin-top: 10px;" />

        </div>

</asp:Content>

