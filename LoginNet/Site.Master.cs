using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginNet
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                MessageLogin.InnerText = "Hola" + Session["Username"];
            }
            else
            {
                // Redirigir a la página de login si el usuario no está autenticado
                Response.Redirect("Login.aspx");
            }
        }
    }
}