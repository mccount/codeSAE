using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_steps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHeading_Click(object sender, EventArgs e)
        {
            if (lblHeading.ForeColor == Color.Red) {
                lblHeading.Text = "Überschrift";
                lblHeading.ForeColor = Color.Black;
            } else {
                lblHeading.Text = "Surprise\nMotherfucker :D";
                lblHeading.ForeColor = Color.Red;
            }

        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            Color cl = Color.FromName(tbxColor.Text);
            btnPopup.BackColor = cl;
        }
    }
}
