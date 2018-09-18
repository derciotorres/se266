<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContainer" runat="Server">

    <div class="picleft3">
        <!-- register field with some validation -->
        <h1>
            <img src="img/contentrotator636524317775251931.png" style="width: 90%; margin-top: 10px;" /></h1>

        UserName:<asp:TextBox ID="txtUname" CssClass="barslong3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="usernameReq"
            runat="server"
            ControlToValidate="txtUname"
            ErrorMessage="Username is required!"
            SetFocusOnError="True" />
        <br />
        Password:
        <asp:TextBox ID="txtPword" CssClass="barslong3" runat="server"
            TextMode="Password" />
        <br />
        <asp:RequiredFieldValidator ID="passwordReq"
            runat="server"
            ControlToValidate="txtPword"
            ErrorMessage="Password is required!"
            SetFocusOnError="True" Display="Dynamic" />
        <br />
        Confirm Password:<asp:TextBox ID="txtPword2" CssClass="barslong3" runat="server"
            TextMode="Password" />
        <br />
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
        <center>
         <asp:Imagebutton ID="btnInsert" ImageUrl="img/Register-Now-Button_b_smaller.png" style="width:80%; margin-left:20px"  runat="server" OnClick="btnInsert_Click"  />
         </center>

        <asp:Label ID="lblFeedback" runat="server" />

        <p>Already have an account? <a data-toggle="modal" data-target="#popUpWindow">Sign in</a>.</p>


    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
    <div class="banner">

        <img src="img/banner.jpg" style="width: 100%; height: auto; margin-top: 10px;" />

    </div>
</asp:Content>

