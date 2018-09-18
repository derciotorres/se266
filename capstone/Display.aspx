<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Display.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">
    <div class="picleft">

    <asp:Label ID="lblpost_ID" Visible="false" runat="server" /><br />
    <asp:Label ID="lblTname1" runat="server" CssClass="lbl1" Text="Label"   ></asp:Label>
    <br />
    <asp:Image ID="Image1" CssClass="image2" runat="server" />
    <br />
    <br />
     <asp:Label ID="Label2" CssClass="lbl2" runat="server" Text="<b>Item Description: </b>" ></asp:Label><br />
    <asp:Label ID="description1" CssClass="lbl2" runat="server" Text="Label" ></asp:Label><br />
    <asp:Label ID="Lable3" CssClass="lbl2" runat="server" Text="<b>Town: </b>" ></asp:Label>
    <asp:Label ID="town" CssClass="lbl2" runat="server" Text="Label" ></asp:Label>
    <br />
    <br />
    <br />
    <br />
    </div>
    <div class="picright">
 <h3>Contact Form</h3>

    <asp:Label ID="email" CssClass="lbl2" runat="server" Text="Label" Visible="false" Width="508px" ></asp:Label>
    
    <label>Subject</label> 
    <asp:TextBox ID="txtsubject" runat="server" CssClass="barslong" placeholder=" "></asp:TextBox>
   <label>Message</label>

    <asp:TextBox ID="txtmessage" CssClass="barslong" runat="server" TextMode="MultiLine" placeholder="Please write your message here! Leave the contact information that you wish to be reached by the donor."  style="height:200px"></asp:TextBox>
         <asp:Imagebutton ID="Bttn_Send"  CssClass="macacada2" ImageUrl="img/Send-Email-Button-Transparent-PNG.png" style="width:90%;"   runat="server" OnClick="Bttn_Send_Click"  />
</div>


      

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
      <div class="banner">

            <img src="img/banner.jpg"  style="width: 100%; margin-top: 10px;" />

        </div>
</asp:Content>

