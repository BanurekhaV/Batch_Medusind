using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementPrj
{
    public partial class SampleForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblstatus.Text = "Your Name : " + ViewState["uname"].ToString() + 
            //    " and your Email is :" + ViewState["email"].ToString();
            Response.Write("Welcome");
        }

    }
}