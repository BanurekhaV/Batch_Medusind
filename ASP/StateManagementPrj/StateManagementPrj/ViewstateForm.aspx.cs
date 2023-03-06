using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementPrj
{
    public partial class ViewstateForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            ViewState["uname"] = Textname.Text;
            ViewState["email"] = Textemail.Text;
            Textname.Text = " ";
            Textemail.Text = String.Empty;
        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            //string a = ViewState["uname"].ToString();
            //string b = ViewState["email"].ToString();
            //lbl3.Text = "Your Name is :" + a + " "+ "and your Email is :" + b;
            lbl3.Text= "Your Name : " + ViewState["uname"].ToString() + 
                " and your Email is :" + ViewState["email"].ToString();
            // Response.Redirect("~/SampleForm.aspx");
        }
    }
}