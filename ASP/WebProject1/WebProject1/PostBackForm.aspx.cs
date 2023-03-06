using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject1
{
    public partial class PostBackForm : System.Web.UI.Page
    {
        int clickscount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtname.Text = "0";
            }

        }

        protected void btnclick_Click(object sender, EventArgs e)
        {
            //Option 1 No state management
            //clickscount = clickscount + 1;
            //txtname.Text = clickscount.ToString();

            //Option 2 statemanagement with viewstate

            //if (ViewState["Clicks"] != null)
            //{
            //    clickscount = (int)ViewState["Clicks"] + 1;
            //}
            //txtname.Text = clickscount.ToString();
            //ViewState["Clicks"] = clickscount;

            //option 3 statemenagement without explicitly declaring
            //any viewstate variable
            //All asp controls(server controls) have a hidden viewstate variable to maintain the state.

            clickscount = Convert.ToInt32(txtname.Text) + 1;
            txtname.Text = clickscount.ToString();
        }
    }
}