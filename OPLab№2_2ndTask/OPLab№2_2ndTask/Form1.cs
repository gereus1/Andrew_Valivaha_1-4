using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPLab_2_2ndTask
{

    public partial class Form1 : Form
    {
        Dictionary<string, List<double>> currencies = new Dictionary<string, List<double>>()
        {
            { "USD", new List<double>(){ 1, 1.1, 0.9 } },
            { "UAH", new List<double>(){ 8, 25, 27, 28, 34 } },
            { "EUR", new List<double>(){ 0.7, 0.74, 0.8, 0.94 } },
            { "PLN", new List<double>(){ 3.78, 3.60, 4.4, 4.32 } },
            { "GBP", new List<double>(){ 0.6, 0.78, 0.8 } },
            { "CHF", new List<double>(){ 0.87, 0.96 } },
            { "AED", new List<double>(){ 3.3, 3.47, 3.67 } }
        };


        public Form1()
        {
            InitializeComponent();

            fromcombo1.Items.Clear();
            tocombo2.Items.Clear();

            List<(string, double)> lastCurrencies = new List<(string, double)>();

            foreach (var item in currencies)
            {
                lastCurrencies.Add((item.Key, item.Value.Last()));
            }

            lastCurrencies = lastCurrencies.OrderBy(i => i.Item2).ToList();

            foreach (var currency in lastCurrencies)
            {
                fromcombo1.Items.Add(currency.Item1);
                tocombo2.Items.Add(currency.Item1);
            }

        }
 
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(amount_txt.Text);

            string fromCurrency = fromcombo1.SelectedItem.ToString();
            string toCurrency = tocombo2.SelectedItem.ToString();

            double fromKoef = currencies[fromCurrency].Last();
            double toKoef = currencies[toCurrency].Last();
            double conver = i * toKoef / fromKoef;

            display_txt.Text = "Converted Amount :" + conver + "\t " + toCurrency;

            CurrRate.Text = "Currency Exchange Rate: " + (toKoef / fromKoef).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
