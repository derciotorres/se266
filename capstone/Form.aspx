<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Form.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">
    <!-- My donate form with validation -->
    <div class="picleft2">

        <img src="img/download.png" style="width: 100%; height: auto; margin-top: 10px; margin-bottom: 10px; transform: rotate(15deg)" />

        <p class="lr">Title Name:</p>
        <asp:TextBox ID="txtTname" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfTname" runat="server" ErrorMessage="Title is required" ForeColor="Red" ControlToValidate="txtTname" />
        <p class="lr">Category :</p>
        <asp:DropDownList ID="txtCategory" CssClass="barslong" runat="server">
            <asp:ListItem Text=" "></asp:ListItem>
            <asp:ListItem Text="Furniture"></asp:ListItem>
            <asp:ListItem Text="Outside furniture"></asp:ListItem>
        </asp:DropDownList>
        <p class="lr">Description :</p>
        <asp:TextBox ID="txtDescription" runat="server" CssClass="barslong" TextMode="MultiLine" Rows="5" Height="217px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfDescription" runat="server" ErrorMessage="Description is required" ForeColor="Red" ControlToValidate="txtDescription" />
        <p class="lr">Photo Upload:</p>
        <asp:FileUpload ID="fileuploadimages" runat="server" Height="46px" Width="520px" />
        <p class="lr">Town</p>
        <asp:TextBox ID="txtTown" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfTown" runat="server" ErrorMessage="Town is required" ForeColor="Red" ControlToValidate="txtTown" />
        <p class="lr">Address:</p>
        <asp:TextBox ID="txtAddress" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfAddress" runat="server" ErrorMessage="Address is required" ForeColor="Red" ControlToValidate="txtAddress" />
        <p class="lr">Zip:</p>
        <asp:TextBox ID="txtZip" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfZip" runat="server" ErrorMessage="Zip is required" ForeColor="Red" ControlToValidate="txtZip" />
        <asp:RegularExpressionValidator ID="revZip" runat="server" ErrorMessage="wrong format for ZipCode"
            ControlToValidate="txtZip" ValidationExpression="^(\d{5}-\d{4}|\d{5}|\d{9})$|^([a-zA-Z]\d[a-zA-Z] \d[a-zA-Z]\d)$">
        </asp:RegularExpressionValidator>
        <p class="lr">Phone Number:</p>
        <asp:TextBox ID="txtFnumber" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfFnumber" runat="server" ErrorMessage="Phone number is required" ForeColor="Red" ControlToValidate="txtFnumber" />
        <asp:RegularExpressionValidator ID="revPhone" runat="server" ErrorMessage="wrong format for Cell Phone number"
            ControlToValidate="txtFnumber" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$">
        </asp:RegularExpressionValidator>
        <p class="lr">Email:</p>
        <asp:TextBox ID="txtEmail" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfEmail" runat="server" ErrorMessage="Email is required" ForeColor="Red" ControlToValidate="txtEmail" />
        <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="wrong format for email"
            ControlToValidate="txtEmail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
        </asp:RegularExpressionValidator>
        <br />

        <asp:ImageButton ID="donatebtn" ImageUrl="img/DonateButton-1.png" Style="width: 100%;" runat="server" OnClick="btnInsert_Click" />
        <asp:Label ID="lblFeedback" runat="server" />

    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">

    <div class="banner">

        <img src="img/banner.jpg" style="width: 100%; margin-top: 10px;" />

    </div>

</asp:Content>

