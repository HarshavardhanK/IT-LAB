using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_LAB_WEEK4_Q2
{

    public class Student
    {
        public string name { get; set; }
        public string roll { get; set; }
        public string subject { get; set; }

        public Student() { }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                subjectsList.Items.Add("Physics");
                subjectsList.Items.Add("Mathematics");
                subjectsList.Items.Add("Chemistry");
                subjectsList.Items.Add("English");

            }
        }

        protected void submit_Click(object sender, EventArgs args)
        {
            Student stud = new Student();
            stud.name = nameTextBox.Text.ToString();
            stud.roll = rollTextbox.Text.ToString();
            stud.subject = subjectsList.SelectedItem.ToString();

            Session["student"] = stud;

            Response.Redirect("Result.aspx");
        }
    }
}