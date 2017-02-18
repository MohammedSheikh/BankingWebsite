<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Statement.aspx.cs" Inherits="Statement" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div id="Summary">

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
    </div>

    <br />

    <!--we will be pulling data in this table from backend-->
    <div id="statementMain">
        <table>
            <tr>
                <th>Date</th>
                <th>Description</th>
                <th>Type</th>
                <th>In</th>
                <th>Out</th>
                <th>Balance</th>
            </tr>
            <tr>
                <td>29/01/2017</td>
                <td>Unitemps</td>
                <td>Credit</td>
                <td>10.00</td>
                <td></td>
                <td>Balance</td>
            </tr>

        </table>

    </div>

</asp:Content>

