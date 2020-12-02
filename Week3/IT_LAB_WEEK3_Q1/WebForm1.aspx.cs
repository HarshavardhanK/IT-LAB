using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK3_Q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                // Set font options.
                fontDropDown.Items.Add("Times New Roman");
                fontDropDown.Items.Add("Arial");
                fontDropDown.Items.Add("Verdana");
                fontDropDown.Items.Add("Tahoma");

                colorDropDown.Items.Add("White");
                colorDropDown.Items.Add("Red");
                colorDropDown.Items.Add("Green");
                colorDropDown.Items.Add("Blue");
                colorDropDown.Items.Add("Yellow");

                backgroundColor.Items.Add("White");
                backgroundColor.Items.Add("Red");
                backgroundColor.Items.Add("Green");
                backgroundColor.Items.Add("Blue");
                backgroundColor.Items.Add("Yellow");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            titleLabel.Text = messageTextBox.Text;
        }

        protected void generate(object sender, EventArgs args)
        {

            magazine.BackColor = Color.FromName(backgroundColor.SelectedItem.Text);

            string selectedFont = fontSizeDropDown.SelectedValue;
            titleLabel.Font.Size = FontUnit.Point(Int32.Parse(selectedFont));
            titleLabel.BackColor = Color.FromName(colorDropDown.SelectedItem.Text);
            titleLabel.Text = messageTextBox.Text;

            coverImage.ImageUrl = imageLocal.Text;
        }
    }
}