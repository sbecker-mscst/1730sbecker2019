using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sbecker17301d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralianDollar.Text = "0.00";
            txtRateAustralia.Text = "0.686253";
            txtYuan.Text = "0.00";
            txtRateChinese.Text = "0.140401";
            txtCubanPeso.Text = "0.00";
            txtRateCuba.Text = "0.0377358";
            txtGermanDollar.Text = "0.00";
            txtRateGerman.Text = "1.10504";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {

            txtUSDAustralia.Text = (Convert.ToDecimal(txtAmountAustralianDollar.Text) 
                * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        private void chinaTextChanged(object sender, EventArgs e)
        {
            txtUSDChina.Text = (Convert.ToDecimal(txtYuan.Text)
                * Convert.ToDecimal(txtRateChinese.Text)
                ).ToString("0.00");
        }

        private void cubaTextChanged(object sender, EventArgs e)
        {
            txtUSDCuba.Text = (Convert.ToDecimal(txtCubanPeso.Text)
                * Convert.ToDecimal(txtRateCuba.Text)
                ).ToString("0.00");
        }

        private void germanTextChanged(object sender, EventArgs e)
        {
            txtUSDGerman.Text = (Convert.ToDecimal(txtGermanDollar.Text)
                * Convert.ToDecimal(txtRateGerman.Text)
                ).ToString("0.00");
        }

        private void totalTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDAustralia.Text)
                + Convert.ToDecimal(txtUSDChina.Text)
                + Convert.ToDecimal(txtUSDCuba.Text)
                + Convert.ToDecimal(txtUSDGerman.Text)
                ).ToString("0.00");

        }
    }
}
