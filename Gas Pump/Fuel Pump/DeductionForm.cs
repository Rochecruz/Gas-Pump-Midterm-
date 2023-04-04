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
    public partial class DeductionForm : Form
    {
        public DeductionForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                label3.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {

                timer1.Stop();

                string box_msg = "The process is Successful!";
                MessageBox.Show(box_msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                UpdatedAccountDetailsForm f3 = new UpdatedAccountDetailsForm();
                f3.ShowDialog();
            }
        }

        private void DeductionForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
