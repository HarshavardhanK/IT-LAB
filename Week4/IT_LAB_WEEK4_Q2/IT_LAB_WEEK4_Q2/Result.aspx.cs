using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK4_Q2
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            cookie = Request.Cookies["student"];

            if(cookie == null)
            {
                cookie = new HttpCookie("student");
            }

            Student stud = (Student)Session["student"];

            if(!IsPostBack)
            {
                if(stud != null)
                {
                    detailsLabel.Text = stud.name + " : " + stud.roll + " : " + stud.subject;
                }

                counterLabel.Text = cookie["count"];
            }
        }

        protected void counter_Click(object sender, EventArgs args)
        {
            int counter;
            int.TryParse(cookie["count"], out counter);

            cookie["count"] = (counter + 1).ToString();
            cookie.Expires = DateTime.Now.AddDays(10);

            Response.Cookies.Add(cookie);

            counterLabel.Text = cookie["count"];
        }
    }
}