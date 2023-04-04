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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        public static class GlobalVar
        {
            public static string fuel;

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = 7;
            textbox1.Text += number;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GlobalVar.fuel = "Diesel";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GlobalVar.fuel = "Unleaded";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GlobalVar.fuel = "Premium";
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

        private void done_Click(object sender, EventArgs e)
        {
            GlobalVariable.variable_Fuel = GlobalVar.fuel;
            GlobalVariable.variable_amount = textbox1.Text;


            if (GlobalVar.fuel != null)
            {
                string box_msg = "Fuel Type: " + GlobalVar.fuel + Environment.NewLine + "Amount: " + GlobalVariable.variable_amount;
                MessageBox.Show(box_msg, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                paymentForm f3 = new paymentForm();
                f3.ShowDialog();
            }

            else if (GlobalVar.fuel == null)
            {
                string box_msg1 = "Please choose FUEL TYPE. Thank You!";
                MessageBox.Show(box_msg1, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
