using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sbecker17301f
{
    public partial class CurrencyExchange : Form
    {
        public CurrencyExchange()
        {
            InitializeComponent();
        }

        private void CurrencyExchange_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnCuba.BackgroundImage = picCubaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";

        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnCuba.BackgroundImage = picCubaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            txtRate.Text = "0.686253";
            lblCurrency.Text = "Australian Dollar:";
        }

        private void BtnChina_Click(object sender, EventArgs e)
        {
            btnChina.BackgroundImage = picChina.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCuba.BackgroundImage = picCubaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            txtRate.Text = "0.140401";
            lblCurrency.Text = "Chinese Yuan:";
        }

        private void BtnCuba_Click(object sender, EventArgs e)
        {
            btnCuba.BackgroundImage = picCuba.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            txtRate.Text = "0.0377358";
            lblCurrency.Text = "Cuban Peso:";
        }

        private void BtnGermany_Click(object sender, EventArgs e)
        {
            btnGermany.BackgroundImage = picGermany.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnCuba.BackgroundImage = picCubaDim.Image;
            txtRate.Text = "1.10504";
            lblCurrency.Text = "Euro:";
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtUSDollars.Text = "0.00";
            lblEquation.Text = "0.00";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtTotalUSD.Text;
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDollars.Text) 
                + Convert.ToDecimal(txtTotalUSD.Text)).ToString("0.00");
        }

        private void TxtUSDollars_TextChanged(object sender, EventArgs e)
        {
            txtUSDollars.Text = (Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }
    }
}
