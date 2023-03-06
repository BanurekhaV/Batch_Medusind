using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementPrj
{
    public partial class HiddenfieldForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = Textname.Text;
            HiddenField2.Value = Textemail.Text;
            Textname.Text = string.Empty;
            Textemail.Text = string.Empty;
        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            lbl3.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}