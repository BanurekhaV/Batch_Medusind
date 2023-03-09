using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CachingPrj
{
    public partial class CacheForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetProductByName("All");
            }

            // Seting Duration
            // Response.Cache.SetExpires(DateTime.Now.AddSeconds(30)); 
            //setting VaryByparam 
            //Response.Cache.VaryByParams["None"] = true;
            //setting the location
            //Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);
            lbl1.Text = "This Page is Cached: " + " " + DateTime.Now.ToString();
        }

        private void GetProductByName(string PName)
        {
            SqlConnection con = new SqlConnection("Data Source=Laptop-TJJ7D977;Initial Catalog=MedusindDB;" +
                "Integrated Security=true;");

            SqlDataAdapter da = new SqlDataAdapter("spGetProductByName", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ProductName";
            param.Value = PName;
            da.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductByName(DropDownList1.SelectedValue);
        }
    }
}