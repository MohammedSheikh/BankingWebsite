<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CreateAccount.aspx.cs" Inherits="CreateAccount" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


     <div class="containerPayment">

        <h2>Create an Account!</h2> 

        <br />

        <h5>Choose your account:</h5> 

        <br />
        <br />
        Account Name:<input class="boxes" type="text" name="AccountName" value="" id="accountName" runat="server">
        <br />
        <br />
       Account Type *
            <select class="boxes" name="accountType" id="accountType" runat="server" required>

        <option value="CurrentAccount">Current Account</option>
        <option value="SavingsAccount">Savings Account</option>
        <option value="StudentAccount">Student Account</option>
       

    </select>

        <br />
        <br />
          Select Branch *
            <select class="boxes" name="branch" id="branch" runat="server" required>

        <option value="Central">Central London</option>
        <option value="Main">Main One</option>
        <option value="Birmingham">B'ham</option>
        <option value="Newcastle">Newcastle One</option>
        <option value="Manchester">Manchester</option>

    </select>
         
        <br />
         <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCreate" runat="server" Text="Create Account" />
        

        

    </div>


</asp:Content>

