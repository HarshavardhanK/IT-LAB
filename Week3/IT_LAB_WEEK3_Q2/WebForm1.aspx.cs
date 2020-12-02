using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK3_Q2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        string[] images = {"https://www.hindustantimes.com/rf/image_size_960x540/HT/p2/2020/12/01/Pictures/president-trump-holds-thanksgiving-videoconference-military-members_2e7ba9e6-33ff-11eb-9c97-4dbf0d0924a0.jpg"
                , "https://www.hindustantimes.com/rf/image_size_960x540/HT/p2/2020/12/01/Pictures/president-trump-holds-thanksgiving-videoconference-military-members_2e7ba9e6-33ff-11eb-9c97-4dbf0d0924a0.jpg"
                , "https://www.hindustantimes.com/rf/image_size_960x540/HT/p2/2020/12/01/Pictures/president-trump-holds-thanksgiving-videoconference-military-members_2e7ba9e6-33ff-11eb-9c97-4dbf0d0924a0.jpg" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                employeeIDDropDown.Items.Add("E1");
                employeeIDDropDown.Items.Add("E2");
                employeeIDDropDown.Items.Add("E3");

            }
        }

        protected void elibible_Promotion(object sender, EventArgs args)
        {
            string joinDate = joinDateTextbox.Text;
            DateTime join;

            var isValidDate = DateTime.TryParse(joinDate, out join);

            if(isValidDate)
            {
                var now = DateTime.Now;
                int years = now.Year - join.Year;

                if(years > 5)
                {
                    eligibleLabel.Text = "YES";

                } else
                {
                    eligibleLabel.Text = "NO";
                }
            }
        }

        protected void choose_Employee(object sender, EventArgs args)
        {
            int selectedEmployee = employeeIDDropDown.SelectedIndex;
            //Console.WriteLine(selectedEmployee);
            employeeImage.ImageUrl = images[selectedEmployee];
        }

    }
}