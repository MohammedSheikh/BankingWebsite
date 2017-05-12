<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="ResetPassword" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <div id="key">

   

    <p>Please enter your new password to reset it</p>
        
    <br />
    <br />
    <br />

        Email:
    <asp:TextBox ID="email" runat="server"></asp:TextBox>

     <br />
    <br />
    <br />
    
        NewPassword:
    <asp:TextBox ID="password" runat="server"></asp:TextBox>

     <br />
    <br />
    <br />
    
        Confirm Password:
    <asp:TextBox ID="confirmPassword" runat="server"></asp:TextBox>

     <br />
    <br />
    <br />



    <asp:Button ID="Button1" runat="server" Text="Change Password" OnClick="Button1_Click" />


         </div>

</asp:Content>

