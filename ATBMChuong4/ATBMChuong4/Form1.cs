using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBMChuong4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            performCalculation();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtB.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                performCalculation();
            }
        }
        private void performCalculation()
        {
            try
            {
                long a = long.Parse(txtA.Text);
                long b = long.Parse(txtB.Text);

                EuclidExtended ee = new EuclidExtended(a, b);
                EuclidExtendedSolution result = ee.calculate();

                lbRS.Text = string.Format("d = {0} {1}x = {2} {1}y = {3}", result.D, Environment.NewLine, result.X, result.Y);
            }
            catch (Exception ex)
            {
                String message = string.Format("That doesn't seem right:{0}\"{1}\"", Environment.NewLine, ex.Message);
                MessageBox.Show(message, "Whoopsie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
