using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK4_Q1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            makeLabel.Text = Request.QueryString["Make"];//HttpUtility.UrlDecode(Request.QueryString["Make"]);
            modelLabel.Text = Request.QueryString["Model"];//HttpUtility.UrlDecode(Request.QueryString["Model"]);
        }
    }
}