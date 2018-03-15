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
    public partial class spielform : Form
    {
        public spielform()
        {
            InitializeComponent();
        }

        private void spielform_Load(object sender, EventArgs e)
        {
            lbWuerfeLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbWuerfeLogic();
            int zufallZahl = 0;
            int anzWuerfe = 0;
            int anzAugen = 0;

            Random rnd = new Random();

            while (anzAugen < 50)
            {
                zufallZahl = rnd.Next(1, 7);
                anzWuerfe += 1;
                anzAugen += zufallZahl;
                lbWuerfe.Items.Add(anzWuerfe.ToString() + "\t" + zufallZahl.ToString() + "\t" + anzAugen.ToString());

            }
            tbxAnzahl.Text = anzWuerfe.ToString() + " Würfe";

        }
        private void lbWuerfeLogic()
        {
            lbWuerfe.Items.Clear();
            lbWuerfe.Items.Add("Wurf-Nr.\tAugen\tSumme");
            lbWuerfe.Items.Add("__________________________");
        }

        private void btnWurfelGluck_Click(object sender, EventArgs e)
        {
            WuerfelGlueck weiteresSpiel = new WuerfelGlueck();
            weiteresSpiel.Show();
        }
    }
}
