using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_MID_TERM
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            detailsLabel.Text = Request.QueryString["Name"] + "(" + Request.QueryString["Reg"] + ")";
            
        }

        protected void check_Click(object sender, EventArgs args)
        {
            string option = Request.QueryString["Option"];

            int number;
            int.TryParse(valueTextbox.Text.ToString(), out number);

            string result = "";

            if(option == "Odd" && number % 2 == 0)
            {
                result = "Failure";

            } else if(option == "Odd" && number % 2 != 0)
            {
                result = "Success";

            } else if(option == "Even" && number % 2 == 0)
            {
                result = "Success";

            } else if(option == "Even" && number % 2 != 0)
            {
                result = "Failure";
            }
            

            string listBoxText = valueTextbox.Text.ToString() + " " + result;

            numberListbox.Items.Add(listBoxText);
        }
    }
}