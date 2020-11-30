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
        public static String[] toyota = {"Corolla", "Yaris", "Innova", "Fortuner"};
        public static String[] toyotaPrices = { "900000", "1700000", "2100000", "3500000" };

        public static String[] marutiSuzuki = {"Baleno", "Swift", "Dezire"};
        public static String[] suzukiPrices = { "1200000", "1000000", "875000" };

        public static String[] hyundai = {"Grand i10", "i20 Asta", "i30"};
        public static String[] hyundaiPrices = { "870000", "1100000", "2000000" };

        public static String[] kia = {"Sonet", "Seltos"};
        public static String[] kiaPrices = { "1250000", "2100000"};

        public Form1()
        {
            InitializeComponent();
        }

        public void comboBox1_ItemSelected(Object observer, EventArgs e)
        {
           switch(comboBox1.SelectedIndex)
            {
                case 0:
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(marutiSuzuki);
                    break;

                case 1:
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(hyundai); break;

                case 2:
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(kia);break;

                case 3:
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(toyota); break;
            }
        }

        public void listBox1_ItemSelected(Object observer, EventArgs e)
        {
            String price;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    price = suzukiPrices[listBox1.SelectedIndex];
                    break;

                case 1:
                    price = hyundaiPrices[listBox1.SelectedIndex];
                    break;

                case 2:
                    price = kiaPrices[listBox1.SelectedIndex];
                    break;

                case 3:
                    price = toyotaPrices[listBox1.SelectedIndex];
                    break;

                default:
                    price = "0";
                    break;
            }

            label2.Text = price;
        }

        public void button1_Click(Object observer, EventArgs e)
        {
            MessageBox.Show("Thank you for Purchasing " + comboBox1.Text + " " + listBox1.SelectedItem);
        }

        public void button2_Click(Object observer, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;
            label2.Text = "Uncalculated";
            MessageBox.Show("Selections Reset");
        }
    }
}
