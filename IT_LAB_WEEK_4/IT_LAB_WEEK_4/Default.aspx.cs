using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK_4 {

    public partial class Default : System.Web.UI.Page {

        public void Page_Load(object sender, EventArgs args) {
            label.Text = "Convert Currency";
        }

        public void SubmitClickEvent(object sender, EventArgs args) {
            label.Text = "Clicked";
        }
    }
}
