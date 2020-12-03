using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK4_Q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                carManufacturersList.Items.Add("Honda");
                carManufacturersList.Items.Add("BMW");
                carManufacturersList.Items.Add("Toyota");
                carManufacturersList.Items.Add("Mahindra");

            }
        }

        protected void submit_Button_Click(object sender, EventArgs args)
        {
            string url = "Result.aspx?";
            url += "Model=" + modelTextbox.Text.ToString();//HttpUtility.UrlEncode(modelTextbox.Text.ToString()) + "&";
            url += "&Make=" + carManufacturersList.SelectedItem.ToString();//HttpUtility.UrlEncode(carManufacturersList.SelectedItem.ToString());

            Response.Redirect(url);
        }
    }
}