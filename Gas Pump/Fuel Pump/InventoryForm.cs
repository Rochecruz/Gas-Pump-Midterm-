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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm form = new MenuForm();
            form.ShowDialog();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            int l = Int32.Parse(GlobalVariable.variable_liters);
            int d = Int32.Parse(GlobalVariable.variable_Dliters);
            int p = Int32.Parse(GlobalVariable.variable_Pliters);
            int u = Int32.Parse(GlobalVariable.variable_Uliters);
            int total = 0;

            if (GlobalVariable.variable_Fuel == "Diesel")
            {
                total = d - l;
                diesel.Text = total.ToString();
                GlobalVariable.variable_Dliters = total.ToString();
            }
            else if (GlobalVariable.variable_Fuel == "Premium")
            {
                total = p - l;
                premium.Text = total.ToString();
                GlobalVariable.variable_Pliters = total.ToString();

            }
            else if (GlobalVariable.variable_Fuel == "Unleaded")
            {
                total = u - l;
                unleaded.Text = total.ToString();
                GlobalVariable.variable_Uliters = total.ToString();

            }
        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
