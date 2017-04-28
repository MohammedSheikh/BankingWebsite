<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MyDetails.aspx.cs" Inherits="MyDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <h1>My Details</h1>
    <h2>Address</h2>
    <p>

        <asp:TextBox ID="Address1" runat="server"></asp:TextBox>
        <asp:TextBox ID="Address2" runat="server"></asp:TextBox>
        <asp:TextBox ID="Address3" runat="server"></asp:TextBox>
        <asp:TextBox ID="PostCode" runat="server"></asp:TextBox>

    </p>
    <h2>Phone Number</h2>
    <asp:TextBox ID="homePhone" runat="server"></asp:TextBox>
    <asp:TextBox ID="mobile" runat="server"></asp:TextBox>

    <h2>Email Address</h2>

    <asp:TextBox ID="email" runat="server"></asp:TextBox>

    <br />
    <br />
    <asp:Button ID="saveChangesButton" runat="server" Text="Save Changes" Enabled="False" />

</asp:Content>

