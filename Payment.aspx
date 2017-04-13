<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="Payment" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="containerPayment">

        <h2>Make Payment</h2> 

        <br />

        <h5>Who would you like this payment to?</h5> 

        <br />
        <br />
        Account ID:<input class="boxes" type="text" name="AccountNo" value="" id="accountNo" runat="server">
        <br />
        <br />
        Bank ID:<input class="boxes" type="text" name="SortCode" value="" id="sortCode" runat="server" >

        <br />
        <br />


        Payment Reference:<input class="boxes" type="text" name="Reference" value="" id="reference" runat="server">
        <br />
        <br />
        Payment Amount (£):<input class="boxes" type="text" name="Amount" value="" id="amount" runat="server" placeholder="e.g. 200.00" >

        <br />
        <br />
        <br />

        <button type="button" >Make Payment</button>

    </div>

   

</asp:Content>

