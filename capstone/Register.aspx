<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">



    <h1>Register</h1>

    <p>Please fill in this form to create an account.</p>
    <hr />

    Email:<asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
    <br />
    <br />
    

    <asp:Label ID="lbl_password" runat="server" CssClass="Label" Text="Password"></asp:Label>
    <div class="cleaner">
    </div>
    <asp:TextBox ID="txtPword" runat="server" TextMode="Password" CssClass="textbox" ValidationGroup="RegisterCheck">
    </asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPword"
        ValidationGroup="RegisterCheck"></asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator ID="valPassword" runat="server" ControlToValidate="txtPword"
        ErrorMessage="Minimum password length is 6" ValidationExpression="^([a-zA-Z0-9@#$%^&+=*]{6,30})$"
        ValidationGroup="RegisterCheck" />
    <div class="cleaner_h10">
    </div>
    <asp:Label ID="lbl_ConfirmPassword" runat="server" CssClass="Label" Text="Confirm Password"></asp:Label>
    <div class="cleaner">
    </div>
    <asp:TextBox ID="radtxtConfirmPassword" runat="server" TextMode="Password" CssClass="textbox"
        ValidationGroup="RegisterCheck">
    </asp:TextBox>

    <asp:CompareValidator ID="cmpvldPassword" runat="server" ControlToCompare="radtxtConfirmPassword"
        ControlToValidate="txtPword" Type="String" Operator="Equal" ValidationGroup="RegisterCheck"
        ErrorMessage="Password should match"></asp:CompareValidator>


    <br />
    <br />

    <asp:Button ID="btnInsert" class="btn btn-primary btn-block" runat="server" Text="insert" OnClick="btnInsert_Click" />

    <asp:Label ID="lblFeedback" runat="server" />

    <p>Already have an account? <a data-toggle="modal" data-target="#popUpWindow">Sign in</a>.</p>




</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
</asp:Content>

