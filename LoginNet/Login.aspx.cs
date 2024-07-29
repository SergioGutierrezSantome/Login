using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginNet
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void SignIn()
        {
            string username = txtName.Text;
            string password = txtPassword.Text;
            if(username=="administrador" && password == "1234")
            {
                Session["Username"] = username;
            }
            else
            {
                ConfirmMessage.Text = "El usuario o la contraseña no es correcto";
            }
          
        }
    }
}