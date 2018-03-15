using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCLand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            int kinder = Convert.ToInt32(tbxKinder.Text);
            double einkommen = Convert.ToDouble(tbxEinkommen.Text);
            int kindergeld = 0;
            String ausgabe;

            if (kinder != 0) {

                for (int i = 1; i < kinder + 1; i++)
                {
                    
                    switch (i)
                    {
                        case 1:
                            kindergeld += 70;
                            break;

                        case 2:
                            if (einkommen < 45000) kindergeld += 130;
                            if (einkommen > 45000) kindergeld += 70;
                            break;

                        case 3:
                            if (einkommen < 45000) kindergeld += 220;
                            if (einkommen > 45000) kindergeld += 140;
                            break;

                        default:
                            if (einkommen < 45000) kindergeld += 240;
                            if (einkommen > 45000) kindergeld += 140;
                            break;
                    }
                }
            }
            ausgabe = "Ihr Kindergeld beträgt " + kindergeld.ToString() + "D$.";
            tbxAusgabe.Text = ausgabe;
        }

        private void tbxKinder_TextChanged(object sender, EventArgs e)
        {
            tbxAusgabe.Text = "";
        }

        private void tbxEinkommen_TextChanged(object sender, EventArgs e)
        {
            tbxAusgabe.Text = "";
        }
    }
}
