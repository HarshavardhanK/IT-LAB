using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK5_Q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                candidateList.Items.Add("Donald Trump");
                candidateList.Items.Add("Narendra Modi");
                candidateList.Items.Add("Joseph R Biden");

                houseList.Items.Add("Gryffindor");
                houseList.Items.Add("Slytherin");
                houseList.Items.Add("Ravenclaw");
            }
        }

        protected void submit_Click(object sender, EventArgs args)
        {

        }

        protected void phone_Custom_Server_Validator(object sender, ServerValidateEventArgs args)
        {
            try
            {
                long phoneNumber;
                long.TryParse(args.Value, out phoneNumber);

                int count = 0;

                while(phoneNumber > 0)
                {
                    count += 1;
                    phoneNumber /= 10;
                }

                args.IsValid = (count == 10);

            } catch(Exception ex)
            {
                args.IsValid = false;
            }
        }
    }
}