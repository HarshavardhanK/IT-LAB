using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;



namespace Captcha

{

    public partial class Captcha : System.Web.UI.Page

    {

        public List<String> captchas;

        public List<String> values;

        public static int currentShow;

        public static int oldShow;

        public static int tries = 3;

        public void Initialize_Lists()

        {

            captchas = new List<String>();

            captchas.Add("https://captcha.com/images/captcha/botdetect3-captcha-ancientmosaic.jpg");

            captchas.Add("https://captcha.com/images/captcha/botdetect3-captcha-blackoverlap.jpg");

            captchas.Add("https://captcha.com/images/captcha/botdetect3-captcha-meltingheat.jpg");

            captchas.Add("https://captcha.com/images/captcha/botdetect3-captcha-negative.jpg");



            values = new List<String>();

            values.Add("W93BX");

            values.Add("RBSKW");

            values.Add("JA3V8");

            values.Add("459CT");

        }

        protected void Page_Load(object sender, EventArgs e)

        {

            if (tries > 0)

            {

                CaptchaText.Enabled = true;

                Submit.Enabled = true;

            }

            else

            {

                VerifiedStatus.Text = "Max Attempts Exceeded.";

                CaptchaText.Enabled = false;

                Submit.Enabled = false;

            }



            Random random = new Random();

            oldShow = currentShow;

            currentShow = random.Next(0, 4);



            Initialize_Lists();

            CaptchaImage.Src = captchas[currentShow];

        }



        protected void Check_Captcha(object sender, EventArgs e)

        {

            String captchaEntered = CaptchaText.Text.Trim().ToUpper();

            if (captchaEntered.Equals(values[oldShow]))

            {

                VerifiedStatus.Text = "Successfully Verified.";

            }

            else

            {

                tries--;

                VerifiedStatus.Text = "Failed. Remaining Attempts: " + tries;

            }

        }

    }

}