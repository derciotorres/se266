<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">

    <div class="picleft">

        <h1>Register</h1>

        <p>Please fill in this form to create an account.</p>
        <hr />

        UserName:<asp:TextBox ID="txtUname" CssClass="barslong" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="usernameReq"
            runat="server"
            ControlToValidate="txtUname"
            ErrorMessage="Username is required!"
            SetFocusOnError="True" />
        <br />

        Password:
        <asp:TextBox ID="txtPword" CssClass="barslong" runat="server"
            TextMode="Password" />
        <asp:RequiredFieldValidator ID="passwordReq"
            runat="server"
            ControlToValidate="txtPword"
            ErrorMessage="Password is required!"
            SetFocusOnError="True" Display="Dynamic" />

        <br />
        Confirm Password:<asp:TextBox ID="txtPword2" CssClass="barslong" runat="server"
            TextMode="Password" />
        <asp:RequiredFieldValidator ID="confirmPasswordReq"
            runat="server"
            ControlToValidate="txtPword2"
            ErrorMessage="Password confirmation is required!"
            SetFocusOnError="True"
            Display="Dynamic" />
        <asp:CompareValidator ID="comparePasswords"
            runat="server"
            ControlToCompare="txtPword"
            ControlToValidate="txtPword2"
            ErrorMessage="Your passwords do not match up!"
            Display="Dynamic" />


        <br />
        <br />

        <asp:Button ID="btnInsert" class="btn btn-primary btn-block" runat="server" Text="insert" OnClick="btnInsert_Click" />

        <asp:Label ID="lblFeedback" runat="server" />

        <p>Already have an account? <a data-toggle="modal" data-target="#popUpWindow">Sign in</a>.</p>


    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
</asp:Content>

