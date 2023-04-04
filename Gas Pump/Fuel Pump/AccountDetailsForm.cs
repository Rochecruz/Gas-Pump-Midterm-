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
    public partial class AccountDetailsForm : Form
    {
        public AccountDetailsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Int32.Parse(GlobalVariable.variable_amount);
            int d = Int32.Parse(GlobalVariable.variable_cash);



            if (d < c)
            {
                MessageBox.Show("Insufficient Funds", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Hide();
                MenuForm f3 = new MenuForm();
                f3.ShowDialog();
            }
            else
            {
                this.Hide();
                DeductionForm f3 = new DeductionForm();
                f3.ShowDialog();
            }

        }

        private void AccountDetailsForm_Load(object sender, EventArgs e)
        {
            cash.Text = GlobalVariable.variable_cash;
        }
    }
}
