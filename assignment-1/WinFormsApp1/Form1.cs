using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(numericUpDown1.Value);
            final = Convert.ToDouble(numericUpDown2.Value);
            ortalama = vize * 0.4 + final * 0.6;
            label3.Text = ortalama.ToString();

            if (ortalama <= 39)
            {
                label4.Text = "FF";
            }
            else if (ortalama <= 49)
            {
                label4.Text = "FD";
            }
            else if (ortalama <= 54)
            {
                label4.Text = "DD";
            }
            else if (ortalama <= 59)
            {
                label4.Text = "DC";
            }
            else if (ortalama <= 69)
            {
                label4.Text = "CC";
            }
            else if (ortalama <= 74)
            {
                label4.Text = "CB";
            }
            else if (ortalama <= 79)
            {
                label4.Text = "BB";
            }
            else if (ortalama <= 84)
            {
                label4.Text = "BA";
            }
            else if (ortalama <= 100)
            {
                label4.Text = "AA";
            }
            if (ortalama >= 50 && final > 50)
            {
                label5.Visible = true;
                label6.Visible = false;
            }
            else
            {
                label5.Visible = false;
                label6.Visible = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
        }
    }
}
