using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementPrj
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnget_Click(object sender, EventArgs e)
        {
            //persistant cookie
            //HttpCookie rc = Request.Cookies["MyTrialcookie"];
            //lbl1.Text = rc["c1"];
            //lbl2.Text = rc["c2"];

            //Non-persistant cookie
            lbl1.Text = Request.Cookies["d1"].Value.ToString();
            lbl2.Text = Request.Cookies["d2"].Value.ToString();
        }
    }
}