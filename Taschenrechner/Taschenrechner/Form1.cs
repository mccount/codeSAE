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

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Double numberOne, numberTwo, result;
            Boolean error = false;
            if (tbxNumberOne.Text != "" && Regex.IsMatch(tbxNumberOne.Text, @"^[0-9]+$"))
            {
                numberOne = Double.Parse(tbxNumberOne.Text);
            } else
            {
                MessageBox.Show("Zahl 1 leer oder keine Zahl!");
                error = true;
                numberOne = 0;
            }

            if (tbxNumberTwo.Text != "" && Regex.IsMatch(tbxNumberTwo.Text, @"^[0-9]+$"))
            {
                numberTwo = Double.Parse(tbxNumberTwo.Text);
            }
            else
            {
                MessageBox.Show("Zahl 2 leer oder keine Zahl!");
                error = true;
                numberTwo = 0;
            }

            if (! error) {
                result = numberOne * numberTwo;
                tbxResult.Text = result.ToString();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Double numberOne, numberTwo, result;
            Boolean error = false;
            if (tbxNumberOne.Text != "" && Regex.IsMatch(tbxNumberOne.Text, @"^[0-9]+$"))
            {
                numberOne = Double.Parse(tbxNumberOne.Text);
            }
            else
            {
                MessageBox.Show("Zahl 1 leer oder keine Zahl!");
                error = true;
                numberOne = 0;
            }

            if (tbxNumberTwo.Text != "" && Regex.IsMatch(tbxNumberTwo.Text, @"^[0-9]+$"))
            {
                numberTwo = Double.Parse(tbxNumberTwo.Text);
            }
            else
            {
                MessageBox.Show("Zahl 2 leer oder keine Zahl!");
                error = true;
                numberTwo = 0;
            }

            if (!error)
            {
                result = numberOne / numberTwo;
                tbxResult.Text = result.ToString();
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            Double numberOne, numberTwo, result;
            Boolean error = false;
            if (tbxNumberOne.Text != "" && Regex.IsMatch(tbxNumberOne.Text, @"^[0-9]+$"))
            {
                numberOne = Double.Parse(tbxNumberOne.Text);
            }
            else
            {
                MessageBox.Show("Zahl 1 leer oder keine Zahl!");
                error = true;
                numberOne = 0;
            }

            if (tbxNumberTwo.Text != "" && Regex.IsMatch(tbxNumberTwo.Text, @"^[0-9]+$"))
            {
                numberTwo = Double.Parse(tbxNumberTwo.Text);
            }
            else
            {
                MessageBox.Show("Zahl 2 leer oder keine Zahl!");
                error = true;
                numberTwo = 0;
            }

            if (!error)
            {
                result = numberOne + numberTwo;
                tbxResult.Text = result.ToString();
            }
        }

        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            Double numberOne, numberTwo, result;
            Boolean error = false;
            if (tbxNumberOne.Text != "" && Regex.IsMatch(tbxNumberOne.Text, @"^[0-9]+$"))
            {
                numberOne = Double.Parse(tbxNumberOne.Text);
            }
            else
            {
                MessageBox.Show("Zahl 1 leer oder keine Zahl!");
                error = true;
                numberOne = 0;
            }

            if (tbxNumberTwo.Text != "" && Regex.IsMatch(tbxNumberTwo.Text, @"^[0-9]+$"))
            {
                numberTwo = Double.Parse(tbxNumberTwo.Text);
            }
            else
            {
                MessageBox.Show("Zahl 2 leer oder keine Zahl!");
                error = true;
                numberTwo = 0;
            }

            if (!error)
            {
                result = numberOne - numberTwo;
                tbxResult.Text = result.ToString();
            }
        }

        private void tbxNumberOne_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxNumberOne.Text, "[^0-9]"))
            {
                tbxNumberOne.Text = tbxNumberOne.Text.Remove(tbxNumberOne.Text.Length - 1);
            }
        }

        private void tbxNumberTwo_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxNumberTwo.Text, "[^0-9]"))
            {
                tbxNumberTwo.Text = tbxNumberTwo.Text.Remove(tbxNumberTwo.Text.Length - 1);
            }
        }

        private void GetParameter(String input)
        {
            int intPara;
            int intLen;
            int pos = 0;
            
            intPara = input.Where(c => c == '+').Count() + input.Where(c => c == '-').Count();
            intPara = !input[0].Equals("-") ? intPara + 1 : intPara;

            String[] arrPara = new String[intPara];

            intLen = input.Length;

            for (int i=0; i < intPara; i++)
            {
                
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnSimple.Select();
            tbxDerivative.Enabled = false;
        }

        private void rbtnExpanded_CheckedChanged(object sender, EventArgs e)
        {
            tbxDerivative.Enabled = true;
        }

        private void rbtnSimple_CheckedChanged(object sender, EventArgs e)
        {
            tbxDerivative.Enabled = false;
        }

        private void btnDerivative_Click(object sender, EventArgs e)
        {

        }
    }
}
