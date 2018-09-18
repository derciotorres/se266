<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Form2.aspx.cs" Inherits="Controls_Form2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="picleft2">

      
  <asp:Label ID="lbluser_ID" runat="server" /><br />
       <p class="lr">Title Name:</p> 
        <asp:TextBox ID="txtTname" CssClass="barslong" runat="server"></asp:TextBox>
     
      <p class="lr" > Category :</p>
        <asp:DropDownList ID="txtCategory" CssClass="barslong" runat="server">
            <asp:ListItem Text=" "></asp:ListItem>
            <asp:ListItem Text="Furniture"></asp:ListItem>
            <asp:ListItem Text="Outside furniture"></asp:ListItem>
        </asp:DropDownList>
        <p class="lr"> Description :</p>
        <asp:TextBox ID="txtDescription" runat="server" CssClass="barslong" TextMode="MultiLine" Rows="5" Height="217px"></asp:TextBox>
       
        <p class="lr"> Photo Upload:</p>
        <asp:FileUpload ID="fileuploadimages" runat="server" Height="46px" Width="520px" />
        <p class="lr">Town</p>
        <asp:TextBox ID="txtTown" CssClass="barslong" runat="server"></asp:TextBox>
       
        <p class="lr" >Address:</p>
        <asp:TextBox ID="txtAddress" CssClass="barslong" runat="server"></asp:TextBox>

       <p class="lr" >Zip:</p>
        <asp:TextBox ID="txtZip" CssClass="barslong" runat="server"></asp:TextBox>

       <p class="lr">Phone Number:</p>
        <asp:TextBox ID="txtFnumber" CssClass="barslong" runat="server"></asp:TextBox>

        <p class="lr">Email:</p>
        <asp:TextBox ID="txtEmail" CssClass="barslong" runat="server"></asp:TextBox>

        <br />

          <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

        <asp:Label ID="lblFeedback" runat="server" />
</asp:Content>


