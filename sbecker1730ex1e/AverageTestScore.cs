using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sbecker1730ex1e
{
    public partial class AverageTestScore : Form
    {
        public AverageTestScore()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (Convert.ToDecimal(txtTest1.Text) / 3m
                + Convert.ToDecimal(txtTest2.Text) / 3m
                + Convert.ToDecimal(txtTest3.Text) / 3m).ToString("0.00");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
