using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Performance
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Int64 salary = Int64.Parse(textBox1.Text);
            Int32 position = comboBox1.SelectedIndex;

            Double bonus = 0;

            if(position == 0)
            {
                bonus = (0.1 * salary);
            }
            else if(position >= 1 && position < 4)
            {
                bonus = (0.09 * salary);
            }
            else if(position >= 4 && position < 7)
            {
                bonus = (0.07 * salary);
            }
            else
            {
                bonus = (0.05 * salary);
            }

            label2.Text = bonus.ToString("0.##");
        }
    }
}
