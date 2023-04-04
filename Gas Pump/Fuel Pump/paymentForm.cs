using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Pump
{
    public partial class paymentForm : Form
    {
        public paymentForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 1;
            textbox1.Text += number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = 2;
            textbox1.Text += number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = 3;
            textbox1.Text += number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = 4;
            textbox1.Text += number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = 5;
            textbox1.Text += number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = 6;
            textbox1.Text += number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = 7;
            textbox1.Text += number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int number = 8;
            textbox1.Text += number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = 9;
            textbox1.Text += number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = 0;
            textbox1.Text += number;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textbox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string pin = "0608";



            if (textbox1.Text == pin)
            {
                string box_msg = "Log In Successfully!";
                MessageBox.Show(box_msg, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                AccountDetailsForm f3 = new AccountDetailsForm();
                f3.ShowDialog();
            }
            else
            {
                string box_msg = "Invalid PIN!";
                MessageBox.Show(box_msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            HScrollBar.Minimum = 0;
            HScrollBar.Maximum = 100;

            if (HScrollBar.Value == 100)
            {
                label5.Text = HScrollBar.Value.ToString() + "%";
                label6.Visible = true;
                groupBox1.Enabled = true;
                textbox1.Visible = true;
            }
            else if (HScrollBar.Value != 100)
            {
                label5.Text = HScrollBar.Value.ToString();
               
            }

        }

        private void paymentForm_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            textbox1.Visible = false;
        }
    }
}

