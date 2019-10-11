using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sbecker17302d1
{
    public partial class statements : Form
    {
        public statements()
        {
            InitializeComponent();
        }

        private void Statements_Load(object sender, EventArgs e)
        {

        }

        private void BtnSetPassValues_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "3";
            textBox10InputB.Text = "3";
        }

        private void BtnSetFailValues_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            textBox1Result.Text = "Fail";
            textBox2Result.Text = "Fail";
            textBox3Result.Text = "Fail";
            textBox4Result.Text = "Fail";
            textBox5Result.Text = "Fail";
            textBox6Result.Text = "Fail";
            textBox7Result.Text = "Fail";
            textBox8Result.Text = "Fail";
            textBox9Result.Text = "Fail";
            textBox10Result.Text = "Fail";

            textBox1ResultB.Text = "Success";
            textBox2ResultB.Text = "Success";
            textBox3ResultB.Text = "Success";
            textBox4ResultB.Text = "Success";
            textBox5ResultB.Text = "Success";
            textBox6ResultB.Text = "Success";
            textBox7ResultB.Text = "Success";
            textBox8ResultB.Text = "Success";
            textBox9ResultB.Text = "Success";
            textBox10ResultB.Text = "Success";
                

            if (textBox1Input.Text == "Frank")
                textBox1Result.Text = "Success";
            if (textBox1Input.Text == "Frank")
                textBox1ResultB.Text = "Fail";

            if (textBox2Input.Text == "")
                textBox2Result.Text = "Success";
            if (textBox2Input.Text == "")
                textBox2ResultB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3Result.Text = "Success";
            _ = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultB.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4Result.Text = "Success";
            _ = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4ResultB.Text = "Fail";

            decimal val5A = Convert.ToDecimal(textBox5InputA.Text);
            if (val5A == 1.0m)
                textBox5Result.Text = "Success";
            _ = Convert.ToDecimal(textBox5InputA.Text);
            if (val5A == 1.0m)
                textBox5ResultB.Text = "Fail";

            decimal val5B = Convert.ToDecimal(textBox5InputB.Text);
            if (val5B == 2.0m)
                textBox5Result.Text = "Success";
            _ = Convert.ToDecimal(textBox5InputB.Text);
            if (val5B == 2.0m)
                textBox5ResultB.Text = "Fail";

            if (textBox6Input.Text != "Jones")
                textBox6Result.Text = "Success";
            if (textBox6Input.Text != "Jones")
                textBox6ResultB.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 > 0m)
                textBox7Result.Text = "Success";
            _ = Convert.ToDecimal(textBox7Input.Text);
            if (val7 > 0m)
                textBox7ResultB.Text = "Fail";

            _ = Convert.ToDecimal(textBox8InputA.Text);
            if (val5A == 1.0m)
                textBox8Result.Text = "Success";
            _ = Convert.ToDecimal(textBox8InputA.Text);
            if (val5A == 1.0m)
                textBox8ResultB.Text = "Fail";


            _ = Convert.ToDecimal(textBox8InputB.Text);
            if (val5B == 2.0m)
                textBox8Result.Text = "Success";
            _ = Convert.ToDecimal(textBox8InputB.Text);
            if (val5B == 2.0m)
                textBox8ResultB.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 >= 500m)
                textBox9Result.Text = "Success";
            _ = Convert.ToDecimal(textBox9Input.Text);
            if (val9 >= 500m)
                textBox9ResultB.Text = "Fail";

            decimal val10A = Convert.ToDecimal(textBox10InputA.Text);
            if (val10A <= 3.0m)
                textBox10Result.Text = "Success";
            _ = Convert.ToDecimal(textBox10InputA.Text);
            if (val10A <= 3.0m)
                textBox10ResultB.Text = "Fail";

            decimal val10B = Convert.ToDecimal(textBox10InputB.Text);
            if (val10B >= 4.0m)
                textBox10Result.Text = "Success";
            _ = Convert.ToDecimal(textBox10InputB.Text);
            if (val10B >= 4.0m)
                textBox10ResultB.Text = "Fail";

        }
    }
}
