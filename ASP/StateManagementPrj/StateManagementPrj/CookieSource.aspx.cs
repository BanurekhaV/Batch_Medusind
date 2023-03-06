using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementPrj
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {
            //persistant cookie
            //HttpCookie hc = new HttpCookie("MyTrialcookie");
            //hc["c1"] = Textname.Text;
            //hc["c2"] = Textemail.Text;
            //Response.Cookies.Add(hc);
            //hc.Expires = DateTime.Now.AddMinutes(10);
            //Response.Redirect("~/CookieDestination.aspx");

            //non-persistant cookie
            Response.Cookies["d1"].Value = Textname.Text;
            Response.Cookies["d2"].Value = Textemail.Text;
            Response.Redirect("~/CookieDestination.aspx");
        }
    }
}