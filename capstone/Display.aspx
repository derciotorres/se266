<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Display.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">
    <div class="picleft">
    <asp:Label ID="Label1" runat="server" CssClass="lbl1" Text="Label"  Width="508px"  ></asp:Label>
    <br />
    <asp:Image ID="Image1" CssClass="image2" runat="server" />
    <br />
    <br />
    <asp:Label ID="Label2" CssClass="lbl2" runat="server" Text="Label" Width="508px" ></asp:Label>

    <br />
    <br />
    <br />
    <br />
    </div>
    <div class="picright">


<div class="container">
    <br />
      <br />
 <h3>Contact Form</h3>
    <label>Your Email</label>
    <asp:TextBox ID="txtTo" runat="server" CssClass="barslong"  placeholder="123@gmail.com"></asp:TextBox>

    <label>Subject</label> 
    <asp:TextBox ID="txtsubject" runat="server" CssClass="barslong" placeholder="Your last name.."></asp:TextBox>
   <label>Subject</label>

    <asp:TextBox ID="txtmessage" CssClass="barslong" runat="server" TextMode="MultiLine" placeholder="Write your message here. please leave your contact for the donor to be able to contact you"  style="height:200px"></asp:TextBox>

    <asp:Button ID="Bttn_Send" class="btn btn-primary btn-block" runat="server" Text="insert" OnClick="Bttn_Send_Click" />

</div>

 </div>
      

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
</asp:Content>

