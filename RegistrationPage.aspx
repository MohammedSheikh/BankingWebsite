<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RegistrationPage.aspx.cs" Inherits="RegistrationPage" %>

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
       Title:<input class="boxes" type="text" name="firstname" value="" id="title" runat="server">
  <br>
  <br>
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
  <br>
  <br>
     House/flat no.:<input class="boxes" type="text" name="firstname" value="" id="houseNO" runat="server">
  <br>
  <br>
     Address Line 2.:<input class="boxes" type="text" name="addressLine2" value="" id="addressLine2" runat="server">
  <br>
  <br>
     Address Line 3.:<input class="boxes" type="text" name="addressLine3" value="" id="addressLine3" runat="server">
  <br>
  <br>
       City:<input class="boxes" type="text" name="firstname" value="" id="city" runat="server">
  <br>
  <br>
       County:<input class="boxes" type="text" name="firstname" value="" id="county" runat="server">
  <br>
  <br>
       Country:<input class="boxes" type="text" name="firstname" value="" id="country" runat="server">
  <br>
  <br>
       Postcode:<input class="boxes" type="text" name="firstname" value="" id="postCode" runat="server">
  <br>
  <br>
     Primary phone number:<input class="boxes" type="text" name="firstname" value="" id="phoneNo" runat="server">
  <br>
  <br>
     Mobile:<input class="boxes" type="text" name="firstname" value="" id="mobile" runat="server">
  <br>
  <br>
     Email address:<input class="boxes" type="text" name="firstname" value="" id="email" runat="server">
  <br>
  <br>
     Email address:<input class="boxes" type="text" name="firstname" value="" id="confirmEmail" runat="server">
  <br>
  <br>
     Password:<input class="boxes" type="password" name="password" value="" id="password" runat="server">
  <br>
  <br>
     Confirm Password:<input class="boxes" type="password" name="confirmPassword" value="" id="confirmPassword" runat="server">
  <br>

  <br>
     Joined Date:<input class="boxes" type="text" name="firstname" value="" id="joinedDate" runat="server">
  <br>
  <br>
   Terms and Conditions: <input id="tickPos" type="checkbox" runat="server" required> Tick if you agree
    <br>
    <br>
    <button class="btn" id="btn1" onclick="return Validate()" name="submit" OnServerClick="Button1_OnClick" runat="server" >Submit</button>
    <br>
       <asp:Label ID="errorLabel" runat="server" value="" Text="Test"></asp:Label>
    <br>
    <p class="text2"> Already have an account?</p> <a class="btnLink" href="LoginPage" name="Login" >Login here</a>

    </div>
        </div>


    <script type="text/javascript">


    function Validate() {
        var password = document.getElementById("password").value;
        var confirmPassword = document.getElementById("confirmPassword").value;
        if (password != confirmPassword) {
            alert("Passwords do not match.");
     
            

            
            return false;
        }
        return true;
    }
</script>




    </asp:Content>
