using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DressDiscount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Input Variables
            double originalPricePrecious = Convert.ToDouble(txtPrecious.Text);
            double originalPriceMpho = Convert.ToDouble(txtMpho.Text);
            double discountMpho = 350.0;

            // Constants
            double discountPercentagePrecious = 0.355;
            double vatRate = 0.14;

            // Intermediate Calculations for Precious
            double discountAmountPrecious = originalPricePrecious * discountPercentagePrecious;
            double priceAfterDiscountPrecious = originalPricePrecious - discountAmountPrecious;
            double vatAmountPrecious = priceAfterDiscountPrecious * vatRate;
            double finalPricePrecious = priceAfterDiscountPrecious + vatAmountPrecious;

            // Intermediate Calculations for Mpho
            double priceAfterDiscountMpho = originalPriceMpho - discountMpho;
            double vatAmountMpho = priceAfterDiscountMpho * vatRate;
            double finalPriceMpho = priceAfterDiscountMpho + vatAmountMpho;
            double percentageSavedMpho = (discountMpho / originalPriceMpho) * 100.0;

            // Display Output
            lblFinalPricePrecious.Text = $"Precious bought a dress for {originalPricePrecious} and got a discount of {discountAmountPrecious} now he final Due is R" + finalPricePrecious.ToString("0.00");
            lblFinalPriceMpho.Text = $"Mpho bough a dress for {originalPriceMpho} and got a discount of {discountMpho} and the final due is R" + finalPriceMpho.ToString("0.00");
            lblPercentageSavedMpho.Text = $"Mpho saved" + percentageSavedMpho.ToString("0.00") + "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPrecious.Clear();
            txtMpho.Clear();
            lblFinalPricePrecious.Text = "";
            lblFinalPriceMpho.Text = "";
            lblPercentageSavedMpho.Text = "";
        }
    }
    
}
