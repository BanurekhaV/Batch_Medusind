using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementPrj
{
    public partial class SecondSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btngetsession_Click(object sender, EventArgs e)
        {
            lb1.Text = Session["name"].ToString();
            lb2.Text = Session["mail"].ToString();
        }
    }
}