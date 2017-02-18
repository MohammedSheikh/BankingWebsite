<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Statement.aspx.cs" Inherits="Statement" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="statementLeft">
    <p><button type="button">Print Statement</button></p>
    <p><button type="button">Export Statement</button></p>  
    </div>

    <div class="statementMiddle">
    <div id="statementSummary">
    <!--This student could be any other account - will have to connect to C# later-->
    <p>"Student" Account Summary</p> 
    <!--this balance will have to be pulled in by c# code-->
    <p>Balance: "£2000.00" | Available: "£2500.00"</p>
    </div>
    </div>
    
    <div class="statementRight">
    <button class="rightButton" type="button">Search Statement</button>
    <p></p><br /><p></p>
    <button class="rightButton" type="button">Switch Account</button>
    </div>

</asp:Content>

