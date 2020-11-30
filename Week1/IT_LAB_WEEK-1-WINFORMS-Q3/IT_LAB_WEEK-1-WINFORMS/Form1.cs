using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_LAB_WEEK_1_WINFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void salaryLabel_Click(object sender, EventArgs e)
        {
            salaryLabel.Text = "Haha";
        }

        private void label1_Click(object sender, EventArgs args)
        {

        }

        private void button1_Click(object sender, EventArgs args)
        {
            Int64 salary = Int64.Parse(salaryTextbox.Text);
            int position = comboBox1.SelectedIndex;

            double bonus;

            Console.WriteLine("hello");

            if (position == 0)
            {
                bonus = (0.1 * salary);
            }
            else if (position >= 1 && position < 4)
            {
                bonus = (0.09 * salary);
            }
            else if (position >= 4 && position < 7)
            {
                bonus = (0.07 * salary);
            }
            else
            {
                bonus = (0.05 * salary);
            }

            bonusLabel.Text = bonus.ToString("0.##");
            salaryLabel.Text = "hello";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Int64 salary = Int64.Parse(salaryTextbox.Text);
            int position = comboBox1.SelectedIndex;

            double bonus;

            Console.WriteLine("hello");

            if (position == 0)
            {
                bonus = (0.1 * salary);
            }
            else if (position >= 1 && position < 4)
            {
                bonus = (0.09 * salary);
            }
            else if (position >= 4 && position < 7)
            {
                bonus = (0.07 * salary);
            }
            else
            {
                bonus = (0.05 * salary);
            }

            bonusLabel.Text = bonus.ToString();
        }
    }
}
