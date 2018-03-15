using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wuerfelspiel
{
    public partial class WuerfelGlueck : Form
    {
        public WuerfelGlueck()
        {
            InitializeComponent();
        }

        private void btnWuerfeln_Click(object sender, EventArgs e)
        {
            ClearFields();

            Random rnd = new Random();
            //MessageBox.Show(tbxAnzahl2.Text);
            //int gewAnzahl = Convert.ToInt32(tbxAnzahl2.Text);
            //int treffer = 0;
            //double haufigkeit;
            //int zufallZahl, benWurfe = 0;

            //while (treffer < gewAnzahl)
            //{
            //    zufallZahl = rnd.Next(1, 7);
            //    if(zufallZahl == 6)
            //    {
            //        treffer += 1;
            //    }
            //    benWurfe += 1;
            //}

            //haufigkeit = Convert.ToDouble(gewAnzahl) / Convert.ToDouble(benWurfe) * 100.0;
            //tbxHaufigkeit.Text = Math.Round(haufigkeit, 2).ToString();
            //tbxBenWurfe.Text = benWurfe.ToString();
            
            int versuche = 0, versuchegesamt = 0, zufallzahl, treffer = 0;
            int gewunscht = Convert.ToInt32(tbxAnzahl2.Text);

            while (versuche != gewunscht)
            {
                versuche = 0;
                while (treffer < gewunscht)
                {
                    zufallzahl = rnd.Next(1, 7);
                    if (zufallzahl == 6)
                    {
                        treffer += 1;
                        versuche += 1;
                    } else
                    {
                        versuche += 1;
                    }
                }
                versuchegesamt += 1;
                treffer = 0;
            }

            tbxBenWurfe.Text = versuchegesamt.ToString();
            double haufigkeit = Convert.ToDouble(versuche) / Convert.ToDouble(versuchegesamt) * 100.0;
            //tbxHaufigkeit.Text = Math.Round(haufigkeit, 2).ToString();
            tbxHaufigkeit.Text = haufigkeit.ToString();

        }

        private void ClearFields()
        {
            tbxHaufigkeit.Text = "";
            tbxBenWurfe.Text = "";
        }

        private void WuerfelGlueck_Load(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
