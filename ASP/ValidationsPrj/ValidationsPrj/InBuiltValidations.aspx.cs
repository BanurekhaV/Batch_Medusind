using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ValidationLibrary;

namespace ValidationsPrj
{
    public partial class InBuiltValidations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("Welcome.html");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
