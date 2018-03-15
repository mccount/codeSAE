using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quadratzahlen
{
    public partial class baseform : Form
    {
        public baseform()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            int basenumber = 1;
            int quadrat;

            lbEntries.Items.Clear();
            lbEntries.Items.Add("Basis\t\tQuadrat");

            for (basenumber = 1; basenumber <= 25; basenumber++)
            {
                quadrat = basenumber * basenumber;
                lbEntries.Items.Add(basenumber.ToString() + "\t\t" + quadrat.ToString());
            }
        }
    }
}
