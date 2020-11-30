using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Purchase_Portal
{
    public partial class Form1 : Form
    {
        public static String[] mercedes = {"C-Class", "S-Class", "A-Class", "G-Class"};
        public static String[] pricesMercedes = { "12700000", "27500000", "11000000", "9800000" };

        public static String[] maruti = {"Boleno", "Swift", "Wagon-R"};
        public static String[] pricesMaruti = { "1200000", "1000000", "675000" };

        public static String[] hyundai = {"Grand i10", "i20 Asta", "i30"};
        public static String[] pricesHyundai = { "870000", "1100000", "2000000" };

        public static String[] kia = {"Sonet", "Seltos"};
        public static String[] pricesKia = { "1250000", "2100000"};

        public static String[] bmw = {"X5", "X1", "X3", "5 Series"};
        public static String[] pricesBmw = { "22100000", "17500000", "14000000", "10100000" };
        public Form1()
        {
            InitializeComponent();
        }

        public void comboBox1_ItemSelected(Object observer, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    listBox1.Items.Clear(); 
                    listBox1.Items.AddRange(maruti);
                    break;

                case 1:
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(hyundai);
                    break;

                case 2:
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(kia);
                    break;

                case 3:
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(mercedes);
                    break;

                default:
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(bmw);
                    break;
            }
        }

        public void listBox1_ItemSelected(Object observer, EventArgs e)
        {
            String price;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    price = pricesMaruti[listBox1.SelectedIndex];
                    break;

                case 1:
                    price = pricesHyundai[listBox1.SelectedIndex];
                    break;

                case 2:
                    price = pricesKia[listBox1.SelectedIndex];
                    break;

                case 3:
                    price = pricesMercedes[listBox1.SelectedIndex];
                    break;

                default:
                    price = pricesBmw[listBox1.SelectedIndex];
                    break;
            }

            label2.Text = price;
        }

        public void button1_Click(Object observer, EventArgs e)
        {
            MessageBox.Show("Thank you for Purchasing " + comboBox1.Text + " " + listBox1.SelectedItem + ".");
        }

        public void button2_Click(Object observer, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;
            label2.Text = "Uncalculated";
            MessageBox.Show("Selections Reset.");
        }
    }
}
