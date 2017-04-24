using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TESTINGLukasz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ASPXsubmit_Click(object sender, EventArgs e)
    {
      //  ValidatePassword();
            
    }
   //protected void ValidatePassword(string password, out string ErrorMessage)
   // {
   //     var input = password;
   //     ErrorMessage = string.Empty;
   //     Label1.Text = ErrorMessage;

   //     if (string.IsNullOrWhiteSpace(input))
   //     {
   //         throw new Exception("Password should not be empty");
   //     }

   //     var hasNumber = new Regex(@"[0-9]+");
   //     var hasUpperChar = new Regex(@"[A-Z]+");
   //     var hasMiniMaxChars = new Regex(@".{8,15}");
   //     var hasLowerChar = new Regex(@"[a-z]+");
   //     //var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

   //     if (!hasLowerChar.IsMatch(input))
   //     {
   //         ErrorMessage = "Password should contain At least one lower case letter";
   //     }
   //     else if (!hasUpperChar.IsMatch(input))
   //     {
   //         ErrorMessage = "Password should contain At least one upper case letter";
   //     }
   //     else if (!hasMiniMaxChars.IsMatch(input))
   //     {
   //         ErrorMessage = "Password should not be less than or greater than 12 characters";
   //     }
   //     else if (!hasNumber.IsMatch(input))
   //     {
   //         ErrorMessage = "Password should contain At least one numeric value";
   //     }

        //else if (!hasSymbols.IsMatch(input))
        //{
        //    ErrorMessage = "Password should contain At least one special case characters";
        //    return false;
        //}
      
  //  }
   

}