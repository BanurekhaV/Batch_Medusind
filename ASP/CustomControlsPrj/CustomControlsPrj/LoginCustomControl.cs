using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControlsPrj
{
    
    [ToolboxData("<{0}:LoginCustomControl runat=server></{0}:LoginCustomControl>")]
    public class LoginCustomControl : CompositeControl
    {        
        Label lbluname;
        Label lblpassword;
        TextBox txtuname;
        TextBox txtpassword;
        Button btn1;
        LiteralControl lc;
        Label lblstatus;

        protected override void CreateChildControls()
        {
            lbluname = new Label();
            lbluname.Text = "Enter User Name";
            lbluname.Width = Unit.Pixel(120);

            lblpassword = new Label();
            lblpassword.Text = "Enter Password";
            lblpassword.Width = Unit.Pixel(140);

            txtuname = new TextBox();
            txtuname.ID = "txtuname";
            txtuname.Width = Unit.Pixel(150);

            txtpassword = new TextBox();
            txtpassword.ID = "txtpassword";
            txtpassword.Width = Unit.Pixel(150);

            btn1 = new Button();
            btn1.ID = "BtnSubmit";
            btn1.Text = "Login";
            btn1.Width = Unit.Pixel(100);

            //generate an event for the button control
            btn1.Click += new EventHandler(BtnSubmit_Click);

            lblstatus = new Label();

            lc = new LiteralControl("<br/>");

            //we now add the instantiated objects to the class
            this.Controls.Add(lbluname);
            this.Controls.Add(txtuname);
            this.Controls.Add(lc);

            this.Controls.Add(lblpassword);
            this.Controls.Add(txtpassword);
            this.Controls.Add(lc);

            this.Controls.Add(btn1);
            this.Controls.Add(lc);
            this.Controls.Add(lc);

            this.Controls.Add(lblstatus);
        }

        //render the controls as html markup
        protected override void Render(HtmlTextWriter writer)
        {
            lbluname.RenderControl(writer);
            txtuname.RenderControl(writer);
            lc.RenderControl(writer);
            lblpassword.RenderControl(writer);
            txtpassword.RenderControl(writer);
            lc.RenderControl(writer);
            btn1.RenderControl(writer);
            lc.RenderControl(writer);
            lc.RenderControl(writer);
            lblstatus.RenderControl(writer);
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //validating the login credentials will be done using the database
            if (txtuname.Text == "Admin" && txtpassword.Text == "admin@123")
            {
                lblstatus.Text = "Welcome.." + " " + txtuname.Text;
                lblstatus.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                lblstatus.Text = "User name or Password is incorrect";
                lblstatus.ForeColor = System.Drawing.Color.IndianRed;
            }
        }
    }
}
