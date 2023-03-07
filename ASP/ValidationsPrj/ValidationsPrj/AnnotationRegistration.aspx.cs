using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using ValidationLibrary;

namespace ValidationsPrj
{
    public partial class AnnotationRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAnnotation_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Name = Txtname.Text;
            reg.Password = Txtpass.Text;
            reg.ConfirmPassword = Txtconpass.Text;
            reg.Age = Convert.ToInt32(Txtage.Text);
            reg.Email = Txtmail.Text;

            var vcontext = new ValidationContext(reg);
            var vresult = new List<ValidationResult>();

            //using TryValidateObject Method of the validator class, we are validating
            //given regsitrration object, within the validation context, and giving away
            //the results by validating all properties of the object.
            //it the last argument is set to false, then only the first property will get validated
            var isvalid = Validator.TryValidateObject(reg, vcontext, vresult, true);

            if (!isvalid)
            {
                foreach (var errlist in vresult)
                {
                    Response.Write(errlist.ErrorMessage.ToString());
                    Response.Write("<br/>");
                }
                return;
            }
            else
                Response.Redirect("Welcome.html");
        }
    }
}