<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">


        <div class="row">
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Image ID="Image1" Style="width: 100%" runat="server" />
                    <div class="caption">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Image ID="Image2"  Style="width: 100%" runat="server" />
                    <div class="caption">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Image ID="Image3"  Style="width: 100%" runat="server" />
                    <div class="caption">
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Image ID="Image4"  Style="width: 100%" runat="server" />
                    <div class="caption">
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Image ID="Image5"  Style="width: 100%" runat="server" />
                    <div class="caption">
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="thumbnail">
                    <asp:Image ID="Image6"  Style="width: 100%" Height="70%" runat="server" />
                    <div class="caption">
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>


        </div>








</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
    <div style="width: 40%; height: 100%; margin-left:100px; background: #428bca; color: #fff; line-height: 600px; text-align: center;">SKYSCRAPER</div>

</asp:Content>

