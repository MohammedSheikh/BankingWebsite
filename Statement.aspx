<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Statement.aspx.cs" Inherits="Statement" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <!--everthing within this 'asp:content' tag can be HTML-->

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#hideshow').click(function () {
                $('#searchStatement').toggle('show');
            });
            $('#hideshow1').click(function () {
                $('#searchStatement').toggle('show');
            });
        });
    </script>
    <script>
        function printStatement() {
            window.print();
        }
    </script>

    <br />

    <div id="Summary">

        <div class="statementLeft">
            <p>
                <button type="button" onclick="printStatement()">Print Statement</button></p>
            <p>
                <button type="button">Export Statement</button></p>
        </div>

        <div class="statementMiddle">
            <div id="statementSummary">
                <!--This student could be any other account - will have to connect to C# later-->
                <p><u>"Student" Account Summary</u></p>

                <h4>Account No:</h4> <asp:Label ID="accountNumber" runat="server" Text="Label"></asp:Label>
                <h4>Sort Code:</h4> <asp:Label ID="sortCode" runat="server" Text="Label"></asp:Label>

                <!--this balance will have to be pulled in by c# code-->
                <p>Balance:</p>
                <asp:Label ID="balanceLabel" runat="server" Text="Label"></asp:Label>
                <p>Available:</p>
                <asp:Label ID="availableLabel" runat="server" Text="Label"></asp:Label>
                <p>Overdraft Limit:</p>
                <asp:Label ID="overdraftLimit" runat="server" Text="Label"></asp:Label>
                <p>Charges:</p>
                <asp:Label ID="chargesLabel" runat="server" Text="Label"></asp:Label>

            </div>
        </div>

        <div class="statementRight">
            <button class="rightButton" type="button" id="hideshow" value="hide/show">Search Statement</button>
            <p></p>
            <br />
            <p></p>
            <button class="rightButton" type="button">Switch Account</button>
        </div>
    </div>

    <br />

    <div id="key">
        <a href="#openModal1"><u>Click here</u></a> to see what the different types of payment acronyms mean.
    </div>

    <!--popup box-->
    <div id="openModal1" class="modalDialog">
        <div>
            <a href="#close" title="Close" class="close">X</a>

            <h2>Payment Types</h2>
            <p>BAC - Electronic Payment System</p>
            <p>BGC - Bank Giro Credit</p>
            <p>BP  - Bill Payment</p>
            <p>CHG - Charge</p>
            <p>CPT - Cashpoint</p>
            <p>CSH - Cash </p>
            <p>OTH - Other</p>
            <p>SAL - Salary</p>
            <p>SPB - Cashpoint</p>
            <p>SO  - Standing Order </p>
        </div>
    </div>

    <br />

    <div id="searchStatement" style="display: none">
        <b>Search your statement:</b>
        <div id="closeButton">
            <button type="button" id='hideshow1' value='hide/show'>X</button>
        </div>
        <div id="search">
            <p>Time Period:
                <input type="text" placeholder="Number of days">
                Days</p>
            <p>Between:
                <input type="text" placeholder="Date From">
                To
                <input type="text" placeholder="Date To"></p>
            <p>Description:
                <input type="text" placeholder="Transaction Name"></p>
            <button type="button">Search</button>
        </div>
    </div>

    <br />

    <!--we will be pulling data in this table from backend-->
    <div id="statementMain">
        <table>
            <tr>
                <!--table header-->
                <th style="text-align: center">Date</th>
                <th style="text-align: center">Description</th>
                <th style="text-align: center">Type</th>
                <th style="text-align: center">In</th>
                <th style="text-align: center">Out</th>
                <th style="text-align: center">Balance</th>
            </tr>
            <tr>
                <td>29/01/2017</td>
                <td>Unitemps</td>
                <td>Credit</td>
                <td>10.00</td>
                <td></td>
                <td>2000.00</td>
            </tr>
            <tr>
                <td>28/01/2017</td>
                <td>Unitemps</td>
                <td>BAC</td>
                <td>10.00</td>
                <td></td>
                <td>1990.00</td>
            </tr>
            <tr>
                <td>27/01/2017</td>
                <td>X</td>
                <td>DEBIT</td>
                <td>2.00</td>
                <td></td>
                <td>1000.00</td>
            </tr>
            <tr>
                <td>26/01/2017</td>
                <td>Student Finance England</td>
                <td>BAC</td>
                <td>48.00</td>
                <td></td>
                <td>998.00</td>
            </tr>
            <tr>
                <td>25/01/2017</td>
                <td>eBay</td>
                <td>BAC</td>
                <td></td>
                <td>1150.00</td>
                <td>950.00</td>
            </tr>
            <tr>
                <td>24/01/2017</td>
                <td>PayPal</td>
                <td>DEPOSIT</td>
                <td></td>
                <td>16.00</td>
                <td>2100.00</td>
            </tr>

        </table>

    </div>

</asp:Content>