﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RegistrationPage.aspx.cs" Inherits="RegistrationPage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="background" >
   <p class="text1">Registration Page:</p>

    <ul>
  <li id="pos" ><a class="active2" href="#home">Personal</a></li>
  <li class="pos"><a href="#news">Employment</a></li>
  <li class="pos"><a href="#contact">Finance</a></li>
  <li class="pos"><a href="#about">Review</a></li>
  <li class="pos"><a href="#about">Decision</a></li>
  <li class="pos"><a href="#about">Confirmation</a></li>

</ul>
    <br>
    
   <div id="container1">
     First name:<input class="boxes" type="text" name="firstname" value="" id="firstName" runat="server">
  <br>
  <br>
       Surname:<input class="boxes" type="text" name="firstname" value="" id="surName" runat="server">
  <br>
  <br>
       Gender:<input class="boxes" type="text" name="gender" value="" id="gender" runat="server">
  <br>
  <br>
       Maritial Status:<input class="boxes" type="text" name="firstname" value="" id="mStatus" runat="server">
  <br>
  <br>
       Date of Birth:<input class="boxes" type="date" name="firstname" value="" id="dob" runat="server"> 
  <br>
  <br>
       Country of Birth:<input class="boxes" type="text" name="firstname" value="" id="cob" runat="server">
  <br>
  <br>
       Nationality/Citizenship:<input class="boxes" type="text" name="firstname" value="" id="nationality" runat="server">
  <br>
  <br>
      <p class="text2">Contact Details:</p>

       Postcode:<input class="boxes" type="text" name="firstname" value="" id="postCode" runat="server">
  <br>
  <br>
     House/flat no.:<input class="boxes" type="text" name="firstname" value="" id="houseNO" runat="server">
  <br>
  <br>
     Primary phone number:<input class="boxes" type="text" name="firstname" value="" id="phoneNo" runat="server">
  <br>
  <br>
     Email address:<input class="boxes" type="text" name="firstname" value="" id="email" runat="server">
  <br>
  <br>
     Confirm email address:<input class="boxes" type="text" name="firstname" value="" id="confirmEmail" runat="server">
  <br>
  <br>
   Terms and Conditions: <input id="tickPos" type="checkbox" runat="server"> Tick if you agree
    <br>
    <br>
    <button class="btn" id="btn1" name="submit" OnServerClick="Button1_OnClick" runat="server" >Submit</button>
    <br>
    <br>
    <p class="text2"> Already have an account?</p> <a class="btnLink" href="LoginPage" name="Login" >Login here</a>

    </div>
        </div>
</asp:Content>

