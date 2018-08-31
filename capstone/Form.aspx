<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Form.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">

       
       
            <h1>Item Page</h1>
            <p>Please fill up</p>
            <hr />

            Title Name:<asp:TextBox ID="txtTname" runat="server"></asp:TextBox>
            <br />
            <br />
            Category :<br />
            <asp:DropDownList ID="txtCategory" runat="server" Height="44px" Width="545px">
                <asp:ListItem Text=" "></asp:ListItem>
                <asp:ListItem Text="Furniture"></asp:ListItem>
                <asp:ListItem Text="Outside furniture"></asp:ListItem>
            </asp:DropDownList>
            <br />
            Description: 
        <br />
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="10" Height="137px" Width="546px"></asp:TextBox>
            <br />
            <br />
            <asp:FileUpload ID="fileuploadimages" runat="server" Height="46px" Width="520px" />
            <asp:Button ID="btnUpload" runat="server" Text="Upload photo" OnClick="btnUpload_Click" />
            <hr />
            <asp:Image ID="fileUpload1" Visible="false" runat="server" Height="100px" Width="100px" />
            <br />
            <hr />
            <br />
            Town:<asp:TextBox ID="txtTown" runat="server"></asp:TextBox>
            <br />
            <br />
            Address:<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <br />
            Zip:<asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone Number:<asp:TextBox ID="txtFnumber" runat="server"></asp:TextBox>
            <br />
            <br />
            Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnInsert" class="btn btn-primary btn-block" runat="server" Text="insert" OnClick="btnInsert_Click" />

            <asp:Label ID="lblFeedback" runat="server" />


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
    
             
       
            <h1>Item Page</h1>
            <p>Please fill up</p>
            <hr />

           





</asp:Content>

