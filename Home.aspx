<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <style>
.left {
    position: absolute;
    left: 0px;
    width: 300px;
    height: 500px;
    border: 3px solid #73AD21;
    padding: 10px;
    background-color: blue;
    
}

</style>

    <div class="left">

 <section class="container">
    <div class="login">
      <h1>Login</h1>
      <form method="post" action="index.html">
        <p><input type="text" name="login" value="" placeholder="Username or Email"></p>
        <p><input type="password" name="password" value="" placeholder="Password"></p>
        <p class="remember_me">
          <label>
            <input type="checkbox" name="remember_me" id="remember_me">
            Remember me on this computer
          </label>
        </p>
        <p class="submit"><input type="submit" name="commit" value="Login"></p>
      </form>
    </div>

    <div class="login-help">
      <p>Forgot your password? <a href="index.html">Click here to reset it</a>.</p>
    </div>
  </section>

  
   
      
     
  </section>
</div>
</asp:Content>

