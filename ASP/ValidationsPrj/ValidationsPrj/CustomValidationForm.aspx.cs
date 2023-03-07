using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationsPrj
{
    public partial class CustomValidationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(args.Value=="")
            {
                args.IsValid = false;
            }
            else
            {
                if ((Convert.ToInt32(args.Value) > 0) && (Convert.ToInt32(args.Value) % 2 == 0))
                {
                    args.IsValid = true;
                }
                else args.IsValid = false;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                lblstatus.Text = "Data Validated.. and saving";
                lblstatus.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblstatus.Text = "Validation Failed.. not saving";
                lblstatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}