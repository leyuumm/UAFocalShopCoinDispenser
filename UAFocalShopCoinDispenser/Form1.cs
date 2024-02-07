using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAFocalShopCoinDispenser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FivePesoLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Variable Declaration
            int amountPurchased, amountTendered;
            int tenPeso, fivePeso, onePeso; // Pesos
            int twentyfiveCent, tenCent, fiveCent, oneCent; // Cents

            int change;

            // Input
            amountPurchased = Convert.ToInt32(AmountPurchasedTextBox.Text);
            amountTendered = Convert.ToInt32(AmountTenderedTextBox.Text);

            // Process
            change = amountTendered - amountPurchased;
            tenPeso = change / 1000;
            fivePeso = change % 1000 / 500;
            onePeso = change % 1000 % 500 / 100;
            twentyfiveCent = change % 1000 % 500 % 100 / 25;
            tenCent = change % 1000 % 500 % 100 % 25 / 10;
            fiveCent = change % 1000 % 500 % 100 % 25 % 10 / 5;
            oneCent = change % 1000 % 500 % 100 % 25 % 10 % 5 / 1;

            // Output
            AmountPurchasedTextBox.Enabled = false;
            ChangeTextBox.Text = (change / 100.0).ToString("F2", CultureInfo.CurrentCulture);
            TenPesoLabel.Text = tenPeso.ToString();
            FivePesoLabel.Text = fivePeso.ToString();
            OnePesoLabel.Text = onePeso.ToString();
            TwentyFiveCentLabel.Text = twentyfiveCent.ToString();
            TenCentLabel.Text = tenCent.ToString();
            FiveCentLabel.Text = fiveCent.ToString();
            OneCentLabel.Text = oneCent.ToString();
        }
    }
}
