<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MyDetails.aspx.cs" Inherits="MyDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    
    <br />

    <h1>My Details</h1>
    <h2>Address</h2>
    <p>

        <asp:TextBox OnTextChanged = "textCheck" ID="Address1" runat="server" AutoPostBack="false"></asp:TextBox>
        <asp:TextBox OnTextChanged = "textCheck2" ID="Address2" runat="server" AutoPostBack="false"></asp:TextBox>
        <asp:TextBox OnTextChanged = "textCheck3" ID="Address3" runat="server" AutoPostBack="false"></asp:TextBox>
        <asp:TextBox OnTextChanged = "textCheck4" ID="PostCode" runat="server" AutoPostBack="false"></asp:TextBox>

    </p>
    <h2>Phone Number</h2>
    <asp:TextBox OnTextChanged = "textCheck5" ID="homePhone" runat="server" AutoPostBack="false"></asp:TextBox>
    <asp:TextBox OnTextChanged = "textCheck6" ID ="mobile" runat="server" AutoPostBack="false"></asp:TextBox>

    <h2>Email Address</h2>

    <asp:TextBox OnTextChanged = "textCheck7" ID="email" runat="server" AutoPostBack="false"></asp:TextBox>

    <br />
    <br />
    <asp:Button ID="saveChangesButton" runat="server" Text="Save Changes" Enabled="False" Height="35px" />

</asp:Content>

