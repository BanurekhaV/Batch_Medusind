using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementPrj
{
    public partial class QuerystringDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnget_Click(object sender, EventArgs e)
        {
            lbl1.Text = Request.QueryString["uname"];
            lbl2.Text = Request.QueryString["email"];

        }
    }
}