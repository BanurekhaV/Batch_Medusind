using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to ASP.Net Web Forms");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "Medusind Inc.";
            txt2.Text = "medusind@medusind.org";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}