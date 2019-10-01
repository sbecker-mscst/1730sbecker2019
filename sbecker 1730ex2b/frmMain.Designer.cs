namespace sbecker_1730ex2b
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.txtUSDGerman = new System.Windows.Forms.TextBox();
            this.txtUSDCuba = new System.Windows.Forms.TextBox();
            this.txtUSDChina = new System.Windows.Forms.TextBox();
            this.txtUSDAustralia = new System.Windows.Forms.TextBox();
            this.txtRateGerman = new System.Windows.Forms.TextBox();
            this.txtRateCuba = new System.Windows.Forms.TextBox();
            this.txtRateChinese = new System.Windows.Forms.TextBox();
            this.txtRateAustralia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGermanDollar = new System.Windows.Forms.TextBox();
            this.txtCubanPeso = new System.Windows.Forms.TextBox();
            this.txtYuan = new System.Windows.Forms.TextBox();
            this.txtAmountAustralianDollar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(375, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(294, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(687, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "$US:";
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(728, 232);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(141, 20);
            this.txtTotalUSD.TabIndex = 53;
            this.txtTotalUSD.TabStop = false;
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalUSD.TextChanged += new System.EventHandler(this.totalTextChanged);
            // 
            // txtUSDGerman
            // 
            this.txtUSDGerman.Location = new System.Drawing.Point(522, 232);
            this.txtUSDGerman.Name = "txtUSDGerman";
            this.txtUSDGerman.ReadOnly = true;
            this.txtUSDGerman.Size = new System.Drawing.Size(141, 20);
            this.txtUSDGerman.TabIndex = 52;
            this.txtUSDGerman.TabStop = false;
            this.txtUSDGerman.Text = "0.00";
            this.txtUSDGerman.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDGerman.TextChanged += new System.EventHandler(this.totalTextChanged);
            // 
            // txtUSDCuba
            // 
            this.txtUSDCuba.Location = new System.Drawing.Point(375, 232);
            this.txtUSDCuba.Name = "txtUSDCuba";
            this.txtUSDCuba.ReadOnly = true;
            this.txtUSDCuba.Size = new System.Drawing.Size(141, 20);
            this.txtUSDCuba.TabIndex = 51;
            this.txtUSDCuba.TabStop = false;
            this.txtUSDCuba.Text = "0.00";
            this.txtUSDCuba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDCuba.TextChanged += new System.EventHandler(this.totalTextChanged);
            // 
            // txtUSDChina
            // 
            this.txtUSDChina.Location = new System.Drawing.Point(228, 232);
            this.txtUSDChina.Name = "txtUSDChina";
            this.txtUSDChina.ReadOnly = true;
            this.txtUSDChina.Size = new System.Drawing.Size(141, 20);
            this.txtUSDChina.TabIndex = 50;
            this.txtUSDChina.TabStop = false;
            this.txtUSDChina.Text = "0.00";
            this.txtUSDChina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDChina.TextChanged += new System.EventHandler(this.totalTextChanged);
            // 
            // txtUSDAustralia
            // 
            this.txtUSDAustralia.Location = new System.Drawing.Point(81, 232);
            this.txtUSDAustralia.Name = "txtUSDAustralia";
            this.txtUSDAustralia.ReadOnly = true;
            this.txtUSDAustralia.Size = new System.Drawing.Size(141, 20);
            this.txtUSDAustralia.TabIndex = 49;
            this.txtUSDAustralia.TabStop = false;
            this.txtUSDAustralia.Text = "0.00";
            this.txtUSDAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDAustralia.TextChanged += new System.EventHandler(this.totalTextChanged);
            // 
            // txtRateGerman
            // 
            this.txtRateGerman.Location = new System.Drawing.Point(522, 192);
            this.txtRateGerman.Name = "txtRateGerman";
            this.txtRateGerman.Size = new System.Drawing.Size(141, 20);
            this.txtRateGerman.TabIndex = 46;
            this.txtRateGerman.Text = "1.10504";
            this.txtRateGerman.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateGerman.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateCuba
            // 
            this.txtRateCuba.Location = new System.Drawing.Point(375, 192);
            this.txtRateCuba.Name = "txtRateCuba";
            this.txtRateCuba.Size = new System.Drawing.Size(141, 20);
            this.txtRateCuba.TabIndex = 44;
            this.txtRateCuba.Text = "0.0377358";
            this.txtRateCuba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateCuba.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateChinese
            // 
            this.txtRateChinese.Location = new System.Drawing.Point(228, 192);
            this.txtRateChinese.Name = "txtRateChinese";
            this.txtRateChinese.Size = new System.Drawing.Size(141, 20);
            this.txtRateChinese.TabIndex = 42;
            this.txtRateChinese.Text = "0.140401";
            this.txtRateChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateChinese.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateAustralia
            // 
            this.txtRateAustralia.Location = new System.Drawing.Point(81, 192);
            this.txtRateAustralia.Name = "txtRateAustralia";
            this.txtRateAustralia.Size = new System.Drawing.Size(141, 20);
            this.txtRateAustralia.TabIndex = 39;
            this.txtRateAustralia.Text = "0.686253";
            this.txtRateAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateAustralia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Amount:";
            // 
            // txtGermanDollar
            // 
            this.txtGermanDollar.Location = new System.Drawing.Point(522, 153);
            this.txtGermanDollar.Name = "txtGermanDollar";
            this.txtGermanDollar.Size = new System.Drawing.Size(141, 20);
            this.txtGermanDollar.TabIndex = 34;
            this.txtGermanDollar.Text = "0.00";
            this.txtGermanDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGermanDollar.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtCubanPeso
            // 
            this.txtCubanPeso.Location = new System.Drawing.Point(375, 153);
            this.txtCubanPeso.Name = "txtCubanPeso";
            this.txtCubanPeso.Size = new System.Drawing.Size(141, 20);
            this.txtCubanPeso.TabIndex = 32;
            this.txtCubanPeso.Text = "0.00";
            this.txtCubanPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCubanPeso.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtYuan
            // 
            this.txtYuan.Location = new System.Drawing.Point(228, 153);
            this.txtYuan.Name = "txtYuan";
            this.txtYuan.Size = new System.Drawing.Size(141, 20);
            this.txtYuan.TabIndex = 29;
            this.txtYuan.Text = "0.00";
            this.txtYuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtYuan.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountAustralianDollar
            // 
            this.txtAmountAustralianDollar.Location = new System.Drawing.Point(81, 153);
            this.txtAmountAustralianDollar.Name = "txtAmountAustralianDollar";
            this.txtAmountAustralianDollar.Size = new System.Drawing.Size(141, 20);
            this.txtAmountAustralianDollar.TabIndex = 28;
            this.txtAmountAustralianDollar.Text = "0.00";
            this.txtAmountAustralianDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAustralianDollar.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "US Dollar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(728, 41);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(141, 96);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "German Euro";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(522, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cuban Peso";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(375, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Chinese Yuan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(228, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Australian Dollar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalUSD);
            this.Controls.Add(this.txtUSDGerman);
            this.Controls.Add(this.txtUSDCuba);
            this.Controls.Add(this.txtUSDChina);
            this.Controls.Add(this.txtUSDAustralia);
            this.Controls.Add(this.txtRateGerman);
            this.Controls.Add(this.txtRateCuba);
            this.Controls.Add(this.txtRateChinese);
            this.Controls.Add(this.txtRateAustralia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGermanDollar);
            this.Controls.Add(this.txtCubanPeso);
            this.Controls.Add(this.txtYuan);
            this.Controls.Add(this.txtAmountAustralianDollar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.TextBox txtUSDGerman;
        private System.Windows.Forms.TextBox txtUSDCuba;
        private System.Windows.Forms.TextBox txtUSDChina;
        private System.Windows.Forms.TextBox txtUSDAustralia;
        private System.Windows.Forms.TextBox txtRateGerman;
        private System.Windows.Forms.TextBox txtRateCuba;
        private System.Windows.Forms.TextBox txtRateChinese;
        private System.Windows.Forms.TextBox txtRateAustralia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGermanDollar;
        private System.Windows.Forms.TextBox txtCubanPeso;
        private System.Windows.Forms.TextBox txtYuan;
        private System.Windows.Forms.TextBox txtAmountAustralianDollar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

