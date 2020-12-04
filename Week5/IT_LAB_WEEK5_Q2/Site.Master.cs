using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK5_Q2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                amazonLogo.ImageUrl = "https://1000logos.net/wp-content/uploads/2016/10/Amazon-Logo.png";
            }
        }
    }
}