using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinerGUIApplication
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            if (progressBar1.Value <= 25)
            {
                lblLoading.Text = "Gathering data, please wait...";
            }
            else if (progressBar1.Value <= 50)
            {
                lblLoading.Text = "Preparing your food...";
            }
            else if (progressBar1.Value <= 75)
            {
                lblLoading.Text = "Ready your money...";
            }
            else
            {
                lblLoading.Text = "Ready your money and tummy!";
            }

            // Update percentage label text
            lblNum.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }
    }
}
