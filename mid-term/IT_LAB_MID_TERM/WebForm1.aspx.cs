using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_MID_TERM
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                oddEvenDropDown.Items.Add("Odd");
                oddEvenDropDown.Items.Add("Even");
            }
        }

        protected void next_Click(object sender, EventArgs args)
        {
            string url = "Result.aspx?";
            url += "Name=" + nameTextbox.Text.ToString() + "&";
            url += "Reg=" + regTextbox.Text.ToString() + "&";
            url += "Option=" + oddEvenDropDown.SelectedItem.Text.ToString();

            Response.Redirect(url);
        }
    }
}