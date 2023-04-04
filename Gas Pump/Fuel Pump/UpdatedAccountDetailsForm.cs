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
    public partial class UpdatedAccountDetailsForm : Form
    {
        public UpdatedAccountDetailsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string box_msg = "Please wait your RECEIPT!";
            MessageBox.Show(box_msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            receiptForm f3 = new receiptForm();
            f3.ShowDialog();
        }

        private void UpdatedAccountDetailsForm_Load(object sender, EventArgs e)
        {
            int c = Int32.Parse(GlobalVariable.variable_amount);
            int d = Int32.Parse(GlobalVariable.variable_cash);
            int a = d - c;
            string change = Convert.ToString(a);

            GlobalVariable.variable_change = change;
            cash.Text = change;
        }
    }
}
