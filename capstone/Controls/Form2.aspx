<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Form2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="picleft">
        <asp:Label ID="lbluser_ID" runat="server" /><br />
        <h1>Item Page</h1>
        <p>Please fill up</p>
        <hr />

        <h3>Title Name:</h3>
        <asp:TextBox ID="txtTname" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfTname" runat="server" ErrorMessage="Title is required" ForeColor="Red" ControlToValidate="txtTname" /><br />

        <br />
        <br />
        <h3>Category :</h3>
        <br />
        <asp:DropDownList ID="txtCategory" CssClass="barslong" runat="server">
            <asp:ListItem Text=" "></asp:ListItem>
            <asp:ListItem Text="Furniture"></asp:ListItem>
            <asp:ListItem Text="Outside furniture"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <h3>Description:</h3>
        <br />
        <asp:TextBox ID="txtDescription" runat="server" CssClass="barslong" TextMode="MultiLine" Rows="10"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfDescription" runat="server" ErrorMessage="Description is required" ForeColor="Red" ControlToValidate="txtDescription" /><br />
        <br />
        <br />
        <h3>Photo Upload:</h3>
        <asp:FileUpload ID="fileuploadimages" runat="server" Height="46px" Width="520px" />
        <asp:Button ID="btnUpload" runat="server" Text="Upload photo" OnClick="btnUpload_Click" />
        <hr />
        <asp:Image ID="fileUpload1" Visible="false" runat="server" Height="100px" Width="100px" />
        <br />
        <hr />
        <br />
        <h3>Town:</h3>
        <asp:TextBox ID="txtTown" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfTown" runat="server" ErrorMessage="Town is required" ForeColor="Red" ControlToValidate="txtTown" /><br />
        <br />
        <br />
        <h3>Address:</h3>
        <asp:TextBox ID="txtAddress" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfAddress" runat="server" ErrorMessage="Address is required" ForeColor="Red" ControlToValidate="txtAddress" /><br />
        <br />
        <br />
        <h3>Zip:</h3>
        <asp:TextBox ID="txtZip" CssClass="barslong" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfZip" runat="server" ErrorMessage="Zip is required" ForeColor="Red" ControlToValidate="txtZip"/><br />
        <asp:RegularExpressionValidator ID="revZip" runat="server" ErrorMessage="wrong format for ZipCode"
        ControlToValidate="txtZip" ValidationExpression="^(\d{5}-\d{4}|\d{5}|\d{9})$|^([a-zA-Z]\d[a-zA-Z] \d[a-zA-Z]\d)$">
        </asp:RegularExpressionValidator>
        <br />
        <br />
        <h3>Phone Number:</h3>
        <asp:TextBox ID="txtFnumber" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfFnumber" runat="server" ErrorMessage="Phone number is required" ForeColor="Red" ControlToValidate="txtFnumber"/><br />
        <asp:RegularExpressionValidator ID="revPhone" runat="server" ErrorMessage="wrong format for Cell Phone number"
        ControlToValidate="txtPhone" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$">
        </asp:RegularExpressionValidator>
        <br />
        <br />
        <h3>Email:</h3>
        <asp:TextBox ID="txtEmail" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfEmail" runat="server" ErrorMessage="Email is required" ForeColor="Red" ControlToValidate="txtEmail"/><br />
        <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="wrong format for email"
        ControlToValidate="txtEmail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
        </asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

        <asp:Label ID="lblFeedback" runat="server" />

    </div>
</asp:Content>


