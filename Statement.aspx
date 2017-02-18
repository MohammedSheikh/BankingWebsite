<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Statement.aspx.cs" Inherits="Statement" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <button class="statementLeft" type="button">Print Statement</button>
    <button class="statementRight" type="button">Search Statement</button>

    <div id="statementSummary">
    <!--This student could be any other account - will have to connect to C# later-->
    <p>"Student" Account Summary</p> 
    <!--this balance will have to be pulled in by c# code-->
    <p>Balance: "£2000.00" | Available: "£2500.00"</p>
    </div>

    <button class="statementLeft" type="button">Export Statement</button>
    <button class="statementRight" type="button">Switch Account</button>

</asp:Content>

