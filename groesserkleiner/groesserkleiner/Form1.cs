using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groesserkleiner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxNumberOne_TextChanged(object sender, EventArgs e)
        {
            Form1_Load(this, null);
            if (Regex.IsMatch(tbxNumberOne.Text, "[^0-9,]"))
            {
                tbxNumberOne.Text = tbxNumberOne.Text.Remove(tbxNumberOne.Text.Length - 1);
            }
        }

        private void tbxNumberTwo_TextChanged(object sender, EventArgs e)
        {
            Form1_Load(this, null);
            if (Regex.IsMatch(tbxNumberTwo.Text, "[^0-9,]"))
            {
                tbxNumberTwo.Text = tbxNumberTwo.Text.Remove(tbxNumberTwo.Text.Length - 1);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            double nOne = Double.Parse(tbxNumberOne.Text);
            double nTwo = Double.Parse(tbxNumberTwo.Text);

            if (nOne != nTwo)
            {
                
                if (nOne > nTwo)
                {
                    tbxBigger.Text = nOne.ToString();
                    tbxSmaller.Text = nTwo.ToString();
                    FullVisible();
                }

                if (nOne < nTwo)
                {
                    tbxBigger.Text = nTwo.ToString();
                    tbxSmaller.Text = nOne.ToString();
                    FullVisible();
                }

            }
            else
            {
                lblBigger.Text = "Gleichheit";
                tbxBigger.Text = nOne.ToString();
                lblBigger.Visible = true;
                tbxBigger.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBigger.Visible = false;
            lblBigger.Text = "Größere Zahl";
            lblSmaller.Visible = false;
            tbxBigger.Visible = false;
            tbxSmaller.Visible = false;
        }

        private void FullVisible()
        {
            lblBigger.Visible = true;
            lblSmaller.Visible = true;
            tbxBigger.Visible = true;
            tbxSmaller.Visible = true;
        }
    }
}
