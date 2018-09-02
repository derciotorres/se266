<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">


        <div class="row">
            <div class="col-md-4">
                <div class="thumbnail">
                 <asp:Imagebutton ID="Image1"  Style="width: 100%" runat="server" OnClick="btnopen1_Click " />
                    <div class="caption">
                        <asp:Label ID="lblTname1" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblDescription1" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblRows" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblRows2" runat="server" Text="Label"></asp:Label>

                    </div>
                </div>
            </div>
            <div class="col-md-4"> 
                <div class="thumbnail">
                    <asp:Imagebutton ID="Image2"  Style="width: 100%" runat="server"  OnClick="btnopen2_Click "  />
                    <div class="caption">
                        <asp:Label ID="lblTname2" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblDescription2" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Imagebutton ID="Image3"  Style="width: 100%" runat="server"  OnClick="btnopen3_Click "  />
                    <div class="caption">
                         <asp:Label ID="lblTname3" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblDescription3" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Imagebutton ID="Image4"  Style="width: 100%" runat="server"  OnClick="btnopen4_Click " />
                    <div class="caption">
                         <asp:Label ID="lblTname4" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblDescription4" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Imagebutton ID="Image5"  Style="width: 100%" runat="server" OnClick="btnopen5_Click " />
                    <div class="caption">
                        <asp:Label ID="lblTname5" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblDescription5" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Imagebutton ID="Image6"  Style="width: 100%"  runat="server"  OnClick="btnopen6_Click "  />
                    <div class="caption">
                       <asp:Label ID="lblTname6" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lblDescription6" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>


        </div>








</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
    <div style="width: 40%; height: 100%; margin-left:20px; background: #428bca; color: #fff; line-height: 600px; text-align: center;">SKYSCRAPER</div>

</asp:Content>

