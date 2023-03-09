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
   
    [ToolboxData("<{0}:CalendarControl runat=server></{0}:CalendarControl>")]
    public class CalendarControl : CompositeControl
    {
        TextBox textbox;
        ImageButton imgbutton;
        Calendar calendar;

        [Category("Appearance")]
        [Description("To set an image for the Calendar Image Button")]
        public string imgbuttonUrl
        {
            get { EnsureChildControls();
                return imgbutton.ImageUrl != null ? imgbutton.ImageUrl : string.Empty;
            }
            set
            {
                EnsureChildControls();
                imgbutton.ImageUrl = value;
            }
        }

        protected override void RecreateChildControls()
        {
            EnsureChildControls();
        }

        protected override void CreateChildControls()
        {
            Controls.Clear();
            textbox = new TextBox();
            textbox.ID = "txtdate";
            textbox.Width = Unit.Pixel(100);

            imgbutton = new ImageButton();
            imgbutton.ID = "imgcalendar";
            imgbutton.Width = Unit.Pixel(25);

            //add calendar toggle event on imgbutton
            imgbutton.Click += new ImageClickEventHandler(imgbutton_Click);

            calendar = new Calendar();
            calendar.ID = "calendar1";
            calendar.Visible = false;

            //add calendar selectionchanged event
            calendar.SelectionChanged += new EventHandler(calendar_SelectionChanged);

            //add all the above controls
            this.Controls.Add(textbox);
            this.Controls.Add(imgbutton);
            this.Controls.Add(calendar);
        }

        private void calendar_SelectionChanged(object sender, EventArgs e)
        {
            textbox.Text = calendar.SelectedDate.ToShortDateString();
            calendar.Visible = false;
        }

        private void imgbutton_Click(object sender, ImageClickEventArgs e)
        {
            if(calendar.Visible)
            {
                calendar.Visible = false;
            }
            else
            {
                calendar.Visible = true;
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            textbox.RenderControl(writer);
            imgbutton.RenderControl(writer);
            calendar.RenderControl(writer);
        }

    }
}
