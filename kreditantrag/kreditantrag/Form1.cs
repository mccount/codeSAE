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

namespace kreditantrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tbxAlter.Text = "";
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(tbxAlter.Text);

            if (age >= 18)
            {
                if (age < 65)
                {
                    MessageBox.Show("Antragsteller ist volljährig");
                }
                else if (age >= 1000)
                {
                    MessageBox.Show("Antragsteller ist Gandalf");
                }
                else
                {
                    MessageBox.Show("Antragsteller ist 65 oder älter");
                }
            }
            else
            {
                MessageBox.Show("Antragsteller ist minderjährig");
            }

            Form1_Load(this, null);
        }
        

        private void tbxAlter_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxAlter.Text, "[^0-9]"))
            {
                tbxAlter.Text = tbxAlter.Text.Remove(tbxAlter.Text.Length - 1);
            }
        }
    }
}
