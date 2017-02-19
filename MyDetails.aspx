<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MyDetails.aspx.cs" Inherits="MyDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <h1>My Details</h1>
    <h2>Address</h2>
    <p>
        <input type="text" placeholder="10">
        <input type="text" placeholder="Address">
        <input type="text" placeholder="N21 3HS">
    </p>
    <h2>Phone Number</h2>
    <input type="text" placeholder="+44">
    <input type="text" placeholder="07789201807">
    <h2>Email Address</h2>
    <a href="mailto:Example@gmail.com">Example@gmail.com</a>
    <p></p>

    <button>Save Changes</button>

</asp:Content>

