using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK4_Q3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                cookie = Request.Cookies["shoppingCart"];

                if(cookie != null)
                {
                    nameTextbox.Text = cookie["name"];
                    itemNameTextbox.Text = cookie["itemName"];
                    itemPriceTextbox.Text = cookie["itemPrice"];
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            cookie = new HttpCookie("shoppingCart");

            cookie["name"] = nameTextbox.Text;
            cookie["itemName"] = itemNameTextbox.Text;
            cookie["itemPrice"] = itemPriceTextbox.Text;

            cookie.Expires = DateTime.Now.AddDays(10);

            Response.Cookies.Add(cookie);
        }
    }
}