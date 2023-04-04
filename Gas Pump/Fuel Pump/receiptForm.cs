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
    public partial class receiptForm : Form
    {
        public receiptForm()
        {
            InitializeComponent();
        }

        private void liters_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string box_msg = "Thank you!";
            MessageBox.Show(box_msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GlobalVariable.variable_cash = GlobalVariable.variable_change;

            this.Hide();
            InventoryForm form = new InventoryForm();
            form.ShowDialog();
        }

        private void receiptForm_Load(object sender, EventArgs e)
        {
            fuel.Text = GlobalVariable.variable_Fuel;

            int p = 0;

            if (GlobalVariable.variable_Fuel == "Diesel")
            {
                fuelPrice.Text = "50";
                p = 50;
            }
            else if (GlobalVariable.variable_Fuel == "Premium")
            {
                fuelPrice.Text = "60";
                p = 60;
            }
            else if (GlobalVariable.variable_Fuel == "Unleaded")
            {
                fuelPrice.Text = "55";
                p = 55;
            }

            int a = Int32.Parse(GlobalVariable.variable_amount);
            int l = a / p;
            string liter = Convert.ToString(l);

            liters.Text = liter;

            GlobalVariable.variable_liters = liter;

            total.Text = GlobalVariable.variable_amount;

            cash.Text = GlobalVariable.variable_cash;
            change.Text = GlobalVariable.variable_change;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
