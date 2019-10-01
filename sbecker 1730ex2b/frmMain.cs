using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sbecker_1730ex2b
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
   
        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = 10m;
            decimal rateAustralia = 0.686253m;
            decimal usdAustralia = amountAustralia * rateAustralia;

            decimal amountYuan = 10m;
            decimal rateChinese = 0.140401m;
            decimal usdChina = amountYuan * rateChinese;

            decimal amountCuban = 10m;
            decimal rateCuba = 0.0377358m;
            decimal usdCuba = amountCuban * rateCuba;

            decimal amountGerman = 10m;
            decimal rateGerman = 1.10504m;
            decimal usdGerman = amountGerman * rateGerman;

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

        private void totalTextChanged(object sender, EventArgs e)
        {
            decimal totalUSD = txtUSDAustralia + txtUSDChina + txtUSDCuba + txtUSDGerman;

    }
}
