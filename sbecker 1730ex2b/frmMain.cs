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
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralianDollar.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");

            decimal amountYuan = Convert.ToDecimal(txtYuan.Text);
            decimal rateChinese = Convert.ToDecimal(txtRateChinese.Text);
            decimal usdChina = amountYuan * rateChinese;
            txtUSDChina.Text = usdChina.ToString("0.00");

            decimal amountCubanPeso = Convert.ToDecimal(txtCubanPeso.Text);
            decimal rateCuba = Convert.ToDecimal(txtRateCuba.Text);
            decimal usdCuba = amountCubanPeso * rateCuba;
            txtUSDCuba.Text = usdCuba.ToString("0.00");

            decimal amountGermanDollar= Convert.ToDecimal(txtGermanDollar.Text);
            decimal rateGerman = Convert.ToDecimal(txtRateGerman.Text);
            decimal usdGerman = amountGermanDollar * rateGerman;
            txtUSDGerman.Text = usdGerman.ToString("0.00");

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

            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDAustralia.Text)
                + Convert.ToDecimal(txtUSDChina.Text)
                + Convert.ToDecimal(txtUSDCuba.Text)
                + Convert.ToDecimal(txtUSDGerman.Text)
                ).ToString("0.00");
        }
    }
}
