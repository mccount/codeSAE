using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechenprüfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtZahl1.Text);
            double zahl2 = Convert.ToDouble(txtZahl2.Text);
            double ergebnis = Convert.ToDouble(txtErgebnis.Text);
            double quote;
            int cnt = 0;

            if (zahl1 + zahl2 == ergebnis)
            {
                lblAddition.Text = "Addition korrekt";
                lblAddition.BackColor = Color.Green;
                cnt++;
            }
            else
            {
                lblAddition.Text = "Addition falsch";
                lblAddition.BackColor = Color.Red;
            }

            if (zahl1 - zahl2 == ergebnis)
            {
                lblSubtraktion.Text = "Subtraktion korrekt";
                lblSubtraktion.BackColor = Color.Green;
                cnt++;
            }
            else
            {
                lblSubtraktion.Text = "Subtraktion falsch";
                lblSubtraktion.BackColor = Color.Red;
            }

            if (zahl1 * zahl2 == ergebnis)
            {
                lblMultiplikation.Text = "Multiplikation korrekt";
                lblMultiplikation.BackColor = Color.Green;
                cnt++;
            }
            else
            {
                lblMultiplikation.Text = "Multiplikation falsch";
                lblMultiplikation.BackColor = Color.Red;
            }

            if (zahl2 != 0)
            {
                if (zahl1 / zahl2 == ergebnis)
                {
                    lblDivision.Text = "Division korrekt";
                    lblDivision.BackColor = Color.Green;
                    cnt++;
                }
                else
                {
                    lblDivision.Text = "Division falsch";
                    lblDivision.BackColor = Color.Red;
                }
            }
            else
            {
                lblDivision.Text = "Division falsch / Nullteilung";
                lblDivision.BackColor = Color.Red;
            }

            quote = (cnt * 100) / 4;
            lblQuote.Text = "Trefferquote: " + quote.ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAddition.Text = "";
            lblDivision.Text = "";
            lblMultiplikation.Text = "";
            lblQuote.Text = "";
            lblSubtraktion.Text = "";
            lblAddition.BackColor = default(Color);
            lblDivision.BackColor = default(Color);
            lblMultiplikation.BackColor = default(Color);
            lblQuote.BackColor = default(Color);
            lblSubtraktion.BackColor = default(Color);
        }
    }
}
